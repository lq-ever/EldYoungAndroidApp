
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Com.Handmark.Pulltorefresh.Library;
using System.Threading.Tasks;
using Com.Handmark.Pulltorefresh.Library.Extras;
using EldYoungAndroidApp.Activitys.Alarm;
using EldYoungAndroidApp.Adapter;
using EldYoungAndroidApp.Param;
using EldYoungAndroidApp.Common;
using EldYoungAndroidApp.Model.Alarm;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;

namespace EldYoungAndroidApp.Fragments.MainTab.Alarm
{
	public class OtherAlarmFrag : BaseFragment,PullToRefreshBase.IOnRefreshListener2,Spinner.IOnItemSelectedListener
	{
		private AlarmInfoListAdapter alarmInfoAdapter;
		private string other_startTime_default, other_endTime_default;
		private PullToRefreshListView otherAlarmRefreshListView;
		private int lastY;
		private ListView actualListView;
		private EditText edit_other_startTime, edit_other_endTime;
		private RadioGroup rgp_other_alarmWay;
		private RadioButton rbtn_other_paul, rbtn_other_trip;
		private Button btn_other_search;
		private Spinner sp_other_guardian;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private AlarmInfoListParam alarmInfoListParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private RestSharpRequestHelp restSharpGetMyUserRequestHelp;
		private int total;//总记录数
		private List<AlarmInfoListItem> alarmInfoLists = new List<AlarmInfoListItem>();

		private List<AllMyUserListItem> myUserLists;//我的监护人列表
		private SearchAllMyUserParam myUserParam = new SearchAllMyUserParam(){UserId = Global.Guid};//我的监护人请求参数对象
		private Dictionary<string,string> myUserRequestParams = new Dictionary<string, string>();//监护人web请求
		private ArrayAdapter<AllMyUserListItem> myUserListAdapter;
		private string myUserId;
		private bool btnSearchFlag = false;//监听是否点击查询

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			base.OnCreateView (inflater, container, savedInstanceState);
			var otherAlarmView = inflater.Inflate (Resource.Layout.OtherAlarmFragLayout,container,false);
			return otherAlarmView;
			 
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			otherAlarmRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_otherAlarm);
			actualListView = (ListView)otherAlarmRefreshListView.RefreshableView;


			//设置可以上拉加载。下拉刷新
			otherAlarmRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;

			//下拉刷新提示文本
			otherAlarmRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			otherAlarmRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			otherAlarmRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));

			//设置声音
//			SoundPullEventListener soundListener = new SoundPullEventListener(Activity);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.PullToRefresh, Resource.Raw.pull_event);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.Reset, Resource.Raw.reset_sound);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.Refreshing, Resource.Raw.refreshing_sound);
//			otherAlarmRefreshListView.SetOnPullEventListener (soundListener);


			otherAlarmRefreshListView.SetOnRefreshListener (this);
			//otherAlarmRefreshListView.SetOnLastItemVisibleListener (this);


			//加载view
			edit_other_startTime = View.FindViewById<EditText>(Resource.Id.edit_other_startTime);
			edit_other_startTime.Click += (sender, e) => 
			{
				var datepickdialog = new DatePickDialogUtil(Activity,edit_other_startTime.Text);
				datepickdialog.DatePickDialogShow(edit_other_startTime);
			};
			edit_other_endTime = View.FindViewById<EditText> (Resource.Id.edit_other_endTime);
			edit_other_endTime.Click += (sender, e) => 
			{
				var datepickdialog = new DatePickDialogUtil(Activity,edit_other_endTime.Text);
				datepickdialog.DatePickDialogShow(edit_other_endTime);
			};
			other_endTime_default = DateTime.Now.ToString ("yyyy-MM-dd");
			other_startTime_default = DateTime.Now.AddDays (-7).ToString ("yyyy-MM-dd");
			edit_other_startTime.Text = other_startTime_default;
			edit_other_endTime.Text = other_endTime_default;

			rgp_other_alarmWay = View.FindViewById<RadioGroup> (Resource.Id.rgp_other_alarmWay);

			rbtn_other_paul = View.FindViewById<RadioButton> (Resource.Id.rbtn_other_paul);
			rbtn_other_trip = View.FindViewById<RadioButton> (Resource.Id.rbtn_other_trip);
			btn_other_search = View.FindViewById<Button> (Resource.Id.btn_other_search);
			//查询按钮
			btn_other_search.Click += (sender, e) => 
			{
				btnSearchFlag = true;
				loadData();
			};
			//下拉框
			sp_other_guardian = View.FindViewById<Spinner>(Resource.Id.sp_other_guardian);
			sp_other_guardian.OnItemSelectedListener = this;   
			sp_other_guardian.Visibility = ViewStates.Visible;//设置默认值

				
			//设置自定义列表adapter		
			alarmInfoAdapter = new AlarmInfoListAdapter (Activity);
			actualListView.Adapter = alarmInfoAdapter;

			actualListView.ItemClick += (sender, e) => 
			{
				var intent  = new Intent(Activity,typeof(AlarmDetailInfoActivity));
				var bundle = new Bundle();
				bundle.PutString("alarmOrigin","alarmList");
				bundle.PutString("alarmId",alarmInfoAdapter.GetItem(e.Position-1).AId);
				intent.PutExtras(bundle);
				Activity.StartActivity(intent);
			};

			alarmInfoListParam =  new AlarmInfoListParam();
			//初始化view完成
			IsPrepared = true;
			LasyloadData ();

		}
		/// <summary>
		/// 设置我的监护人下拉框
		/// </summary>
		private void InitSpinner()
		{
			if (!myUserRequestParams.ContainsKey ("eUserId"))
				myUserRequestParams.Add ("eUserId", myUserParam.EuserId);
			else
				myUserRequestParams ["eUserId"] = myUserParam.EuserId;

			if (!myUserRequestParams.ContainsKey ("eaction"))
				myUserRequestParams.Add ("eaction", myUserParam.Eaction);
			else
				myUserRequestParams ["eaction"] = myUserParam.Eaction;
			
			if (!myUserRequestParams.ContainsKey ("md5"))
				myUserRequestParams.Add ("md5", myUserParam.Md5);
			else
				myUserRequestParams ["md5"] = myUserParam.Md5;

			if (!myUserRequestParams.ContainsKey ("key"))
				myUserRequestParams.Add ("key", myUserParam.Key);
			else
				myUserRequestParams ["key"] = myUserParam.Key;
			//设置restsharprequest
			if (restSharpGetMyUserRequestHelp == null)
				restSharpGetMyUserRequestHelp = new RestSharpRequestHelp (myUserParam.Url,myUserRequestParams);
			else
				restSharpGetMyUserRequestHelp.RequestParams = myUserRequestParams;
			restSharpGetMyUserRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {

				if(response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var searchMyUserJson = JsonConvert.DeserializeObject<SearchAllMyUserJson>(result);
					if(searchMyUserJson.statuscode == "1")
					{
						
						myUserLists = searchMyUserJson.data;

						Activity.RunOnUiThread(()=>
							{
								myUserListAdapter = new ArrayAdapter<AllMyUserListItem>(Activity,Android.Resource.Layout.SimpleSpinnerItem,myUserLists);
								myUserListAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
								sp_other_guardian.Adapter = myUserListAdapter;
								sp_other_guardian.SetSelection(0,true);
							});

					}

				}


			});
			
		}

		#region spinner 事件
		public  void OnItemSelected (AdapterView parent, View view, int position, long id)
		{
			var userSelected = myUserListAdapter.GetItem (position);
			myUserId = userSelected.UId;
			parent.Visibility = ViewStates.Visible;
			Activity.RunOnUiThread(()=>
				{
					//第一次进入设置自动刷新view
					otherAlarmRefreshListView.Refreshing = true;
				});

		}
		public void OnNothingSelected (AdapterView parent)
		{
			
		}
		#endregion
		public override void LasyloadData ()
		{

			if (!IsPrepared || !IsVisible)
				return;
			InitSpinner ();//填充我的监护人
//			//第一次进入设置自动刷新view
//			otherAlarmRefreshListView.Refreshing = true;
		}


		private void loadData()
		{
			if(btnSearchFlag)
				ProgressDialogUtil.StartProgressDialog(Activity,"正在查询报警信息...");
			if (string.IsNullOrEmpty (myUserId)) {
				//未选择任何监护人
				Activity.RunOnUiThread (() => {
					otherAlarmRefreshListView.OnRefreshComplete ();
					if(btnSearchFlag)
						ProgressDialogUtil.StopProgressDialog();
				});
				return;
			}
			pageIndex =1;
			UpdateAlarmInfoListParam ();

			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var alarmlistInfoJson = JsonConvert.DeserializeObject<SearchAlarmInfoJson>(result);
					if(alarmlistInfoJson.statuscode == "1")
					{
						total =  alarmlistInfoJson.data.total;
						alarmInfoLists = alarmlistInfoJson.data.items;

						Activity.RunOnUiThread(()=>
							{
								alarmInfoAdapter.Clear();
								alarmInfoAdapter.AddAll(alarmInfoLists);
								alarmInfoAdapter.NotifyDataSetChanged();
								otherAlarmRefreshListView.OnRefreshComplete ();
								HasLoadedOnce = true;//加载第一次成功
								if(btnSearchFlag)
									ProgressDialogUtil.StopProgressDialog();
							});

					}
					else
					{
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取报警列表信息错误",ToastLength.Short).Show();
								otherAlarmRefreshListView.OnRefreshComplete ();
								if(btnSearchFlag)
									ProgressDialogUtil.StopProgressDialog();
								return;
							});
					}
				}
				else
				{

					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();

							otherAlarmRefreshListView.OnRefreshComplete ();
							if(btnSearchFlag)
								ProgressDialogUtil.StopProgressDialog();
							return;
						});
				}
			});

		}

		/// <summary>
		/// 更新参数请求对象
		/// </summary>
		private void UpdateAlarmInfoListParam()
		{
			alarmInfoListParam.UserId = myUserId;
			alarmInfoListParam.PageIndex = pageIndex.ToString();
			alarmInfoListParam.StartTime = string.IsNullOrEmpty( edit_other_startTime.Text)?other_startTime_default:edit_other_startTime.Text;
			alarmInfoListParam.EndTime = string.IsNullOrEmpty( edit_other_endTime.Text)?other_endTime_default:edit_other_endTime.Text;
			alarmInfoListParam.AlarmType = rbtn_other_paul.Checked?"0":"1";
			SetRestRequestParams ();
		}
		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", alarmInfoListParam.Key);
			else
				requestParams ["key"] = alarmInfoListParam.Key;

			if (!requestParams.ContainsKey ("eAlarmType"))
				requestParams.Add ("eAlarmType", alarmInfoListParam.EalarmType);
			else
				requestParams ["eAlarmType"] = alarmInfoListParam.EalarmType;

			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", alarmInfoListParam.EuserId);
			else
				requestParams ["eUserId"] = alarmInfoListParam.EuserId;

			if (!requestParams.ContainsKey ("eStartTime"))
				requestParams.Add ("eStartTime", alarmInfoListParam.EstartTime);
			else
				requestParams ["eStartTime"] = alarmInfoListParam.EstartTime;

			if (!requestParams.ContainsKey ("eEndTime"))
				requestParams.Add ("eEndTime", alarmInfoListParam.EendTime);
			else
				requestParams ["eEndTime"] = alarmInfoListParam.EendTime;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", alarmInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = alarmInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", alarmInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = alarmInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", alarmInfoListParam.Eaction);
			else
				requestParams ["eaction"] = alarmInfoListParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", alarmInfoListParam.Md5);
			else
				requestParams ["md5"] = alarmInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (alarmInfoListParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;

		}



		/// <summary>
		/// 监听下拉刷新事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullDownToRefresh (PullToRefreshBase p0)
		{
			btnSearchFlag = false;
			p0.GetLoadingLayoutProxy(true,false).SetLastUpdatedLabel(string.Format("上次刷新:{0:t}",DateTime.Now));
			Task.Factory.StartNew (() => {
				loadData();
			});
		}

		/// <summary>
		/// 监听上拉加载更多事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullUpToRefresh (PullToRefreshBase p0)
		{
			btnSearchFlag = false;
			p0.GetLoadingLayoutProxy(false,true).SetLastUpdatedLabel(string.Format("上次加载:{0:t}",DateTime.Now));

			Task.Factory.StartNew (() => {

				//加载更多数据
				LoadMoreData();
			
			});

		}

		/// <summary>
		/// Loads the more data.
		/// </summary>
		private void LoadMoreData()
		{
			lastY = alarmInfoLists.Count;
			pageIndex++;
			UpdateAlarmInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.StatusCode == System.Net.HttpStatusCode.OK)
				{

					var result = response.Content;
					var alarmlistInfoJson = JsonConvert.DeserializeObject<SearchAlarmInfoJson>(result);
					if(alarmlistInfoJson.statuscode == "1")
					{
						total =  alarmlistInfoJson.data.total;
						alarmInfoLists.AddRange(alarmlistInfoJson.data.items);

						Activity.RunOnUiThread(()=>
							{

								alarmInfoAdapter.AddAll(alarmlistInfoJson.data.items);
								alarmInfoAdapter.NotifyDataSetChanged();
								otherAlarmRefreshListView.OnRefreshComplete ();
								//讲listview滚动到上次加载位置
								actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
							});

					}
					else
					{
						pageIndex --;
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取更多报警列表信息错误",ToastLength.Short).Show();
								otherAlarmRefreshListView.OnRefreshComplete ();
								return;
							});
					}
				}
				else
				{
					pageIndex --;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
							//ProgressDialogUtil.StopProgressDialog();
							otherAlarmRefreshListView.OnRefreshComplete ();
							return;
						});
				}
			});
		}
			
	
		 
	}
}

