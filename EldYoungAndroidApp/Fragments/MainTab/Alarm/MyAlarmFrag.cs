﻿ 
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
using Com.Handmark.Pulltorefresh.Library.Extras;
using System.Threading.Tasks;
using EldYoungAndroidApp.Activitys.Alarm;
using EldYoungAndroidApp.Adapter;
using EldYoungAndroidApp.Common;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using EldYoungAndroidApp.Model.Alarm;
using System.Threading;


namespace EldYoungAndroidApp.Fragments.MainTab.Alarm
{
	public class MyAlarmFrag : BaseFragment,PullToRefreshBase.IOnRefreshListener2,Android.Views.View.IOnFocusChangeListener,Spinner.IOnItemSelectedListener
	{
		
		private AlarmInfoListAdapter alarmInfoAdapter;
		private PullToRefreshListView myAlarmRefreshListView;
		private int lastY;

		private ListView actualListView;

		private EditText edit_my_startTime, edit_my_endTime;
		private string my_startTime_default, my_endTime_default;
		private Button btn_my_search;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private AlarmInfoListParam alarmInfoListParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private int total;//总记录数
		private List<AlarmInfoListItem> alarmInfoLists = new List<AlarmInfoListItem>();

		private bool btnSearchFlag = false;//监听是否点击查询

		private bool IsRefreshing = false;//是否正在获取数据

		private Spinner sp_alarmType;//报警类型
		private List<AlarmTypeItem> alarmTypeList;
		private ArrayAdapter<AlarmTypeItem> alarmTypeAdapter;//报警类型适配器
		private string alarmTypeId;//选择的报警类型
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
			var myAlarmView = inflater.Inflate (Resource.Layout.MyAlarmFragLayout,container,false);
			return myAlarmView;
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			
			base.OnActivityCreated (savedInstanceState);
			myAlarmRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_MyAlarm);
			actualListView = (ListView)myAlarmRefreshListView.RefreshableView;

			//设置可以上拉加载。下拉刷新
			myAlarmRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;
			//下拉刷新提示文本
			myAlarmRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			myAlarmRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			myAlarmRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			myAlarmRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			myAlarmRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			myAlarmRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));

			//绑定监听事件
			myAlarmRefreshListView.SetOnRefreshListener (this);


			//下拉框
			sp_alarmType = View.FindViewById<Spinner>(Resource.Id.sp_alarmType);
			sp_alarmType.OnItemSelectedListener = this;   
			sp_alarmType.Visibility = ViewStates.Visible;//设置默认值

		    

			//加载view
			edit_my_startTime = View.FindViewById<EditText>(Resource.Id.edit_my_startTime);
			edit_my_startTime.OnFocusChangeListener = this;
			edit_my_startTime.InputType = Android.Text.InputTypes.Null;

			edit_my_endTime = View.FindViewById<EditText> (Resource.Id.edit_my_endTime);
			edit_my_endTime.OnFocusChangeListener = this;
			edit_my_endTime.InputType = Android.Text.InputTypes.Null;
			my_endTime_default = DateTime.Now.ToString ("yyyy-MM-dd");
			my_startTime_default = DateTime.Now.AddDays (-7).ToString ("yyyy-MM-dd");
			edit_my_startTime.Text = my_startTime_default;
			edit_my_endTime.Text = my_endTime_default;

			btn_my_search = View.FindViewById<Button> (Resource.Id.btn_my_search);
			//查询按钮
			btn_my_search.Click += (sender, e) => 
			{
				btnSearchFlag = true;
				loadData();
			};

			//设置adapter		
			alarmInfoAdapter = new AlarmInfoListAdapter (Activity);
			actualListView.Adapter = alarmInfoAdapter;

			//点击列表详细
			actualListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				//将
				var intent  = new Intent(Activity,typeof(AlarmDetailInfoActivity));
				var bundle = new Bundle();
				bundle.PutString("alarmOrigin","alarmList");
				bundle.PutString("alarmId",alarmInfoAdapter.GetItem(e.Position-1).AId);
				intent.PutExtras(bundle);
				Activity.StartActivity(intent);

			};

			alarmInfoListParam =  new AlarmInfoListParam(){UserId = Global.MyInfo.UId};

			//初始化view完成
			IsPrepared = true;
			LasyloadData ();

		}

	    public void OnFocusChange (View v, bool hasFocus)
		{
			if (hasFocus) {
				((EditText)v).ClearFocus ();
				var datepickdialog = new DatePickDialogUtil (Activity, ((EditText)v).Text);
				datepickdialog.DatePickDialogShow ((EditText)v);
			}
		}


		public override void LasyloadData ()
		{
			if (!IsPrepared || !IsVisible)
				return;
			InitAlarmTypeSpinner();
			//第一次进入设置自动刷新view
			//myAlarmRefreshListView.Refreshing = true;
		}

		/// <summary>
		/// 初始化报警类型
		/// </summary>
		private void InitAlarmTypeSpinner()
		{
			alarmTypeList = new List<AlarmTypeItem> ()
			{
				new AlarmTypeItem(){AlarmTypeId="0",AlarmTypeDesc="PAUL报警"},new AlarmTypeItem(){AlarmTypeId="1",AlarmTypeDesc="摔倒报警"},
				new AlarmTypeItem(){AlarmTypeId="1002",AlarmTypeDesc="紧急求助报警"},new AlarmTypeItem(){AlarmTypeId="1003",AlarmTypeDesc="无活动报警"},
				new AlarmTypeItem(){AlarmTypeId="1011",AlarmTypeDesc="防盗报警"},new AlarmTypeItem(){AlarmTypeId="1012",AlarmTypeDesc="火灾报警"},
				new AlarmTypeItem(){AlarmTypeId="1013",AlarmTypeDesc="燃气泄漏报警"}
			};
			alarmTypeAdapter = new ArrayAdapter<AlarmTypeItem>(Activity,Android.Resource.Layout.SimpleSpinnerItem,alarmTypeList);
			alarmTypeAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
			sp_alarmType.Adapter = alarmTypeAdapter;
			sp_alarmType.SetSelection(0,true);
		}


		#region spinner 事件
		public  void OnItemSelected (AdapterView parent, View view, int position, long id)
		{
			var alarmTypeSelected = alarmTypeAdapter.GetItem (position);
			alarmTypeId = alarmTypeSelected.AlarmTypeId;
			parent.Visibility = ViewStates.Visible;
			//第一次进入设置自动刷新view
			myAlarmRefreshListView.Refreshing = true;
		}
		public void OnNothingSelected (AdapterView parent)
		{
		}
		#endregion
		private void loadData()
		{
			if(btnSearchFlag)
				ProgressDialogUtil.StartProgressDialog(Activity,"正在查询报警信息...",true);
			pageIndex =1;
			UpdateAlarmInfoListParam ();

			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					
					var result = response.Content;
					var alarmlistInfoJson = JsonConvert.DeserializeObject<SearchAlarmInfoJson>(result);
					if(alarmlistInfoJson.statuscode == "1")
					{
						
						total =  alarmlistInfoJson.data.total;
						alarmInfoLists = alarmlistInfoJson.data.items;

						Activity.RunOnUiThread(()=>
							{
								alarmInfoAdapter.Clear();//清空所有数据
								alarmInfoAdapter.AddAll(alarmInfoLists);
								alarmInfoAdapter.NotifyDataSetChanged();
								HasLoadedOnce = true;//加载第一次成功
							});
						
					}
					else
					{
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取报警列表信息错误",ToastLength.Short).Show();
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();

						});
				}
				else
				{
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();
						});
				}

				Activity.RunOnUiThread(()=>
					{
						if(btnSearchFlag)
							ProgressDialogUtil.StopProgressDialog();
						myAlarmRefreshListView.OnRefreshComplete ();
						IsRefreshing = false;
					});
			

					
			});

		}
		/// <summary>
		/// 更新参数请求对象
		/// </summary>
		private void UpdateAlarmInfoListParam()
		{
			alarmInfoListParam.PageIndex = pageIndex.ToString();
			alarmInfoListParam.StartTime = string.IsNullOrEmpty( edit_my_startTime.Text)?my_startTime_default:edit_my_startTime.Text;
			alarmInfoListParam.EndTime = string.IsNullOrEmpty( edit_my_endTime.Text)?my_endTime_default:edit_my_endTime.Text;
			alarmInfoListParam.AlarmType = alarmTypeId;
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
			if (!IsRefreshing) {
				IsRefreshing = true;
				btnSearchFlag = false;
				Task.Factory.StartNew (() => {
					loadData ();
				});
			} else {
				myAlarmRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}
		
		}



		/// <summary>
		/// 监听上拉加载更多事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullUpToRefresh (PullToRefreshBase p0)
		{
			if (!IsRefreshing) {
				IsRefreshing = true;
				btnSearchFlag = false;
				Task.Factory.StartNew (() => {
					//加载更多数据
					LoadMoreData ();
				});
			} else {
				myAlarmRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}

		}



		private void LoadMoreData()
		{
			lastY = alarmInfoLists.Count;
			pageIndex++;
			UpdateAlarmInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
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
								//讲listview滚动到上次加载位置
								actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
							});
					}
					else
					{
						pageIndex--;
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取更多报警列表信息错误",ToastLength.Short).Show();
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					pageIndex--;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
						});
				}
				else
				{
					pageIndex--;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();
						});
				}
				Activity.RunOnUiThread(()=>
					{
						myAlarmRefreshListView.OnRefreshComplete ();
						IsRefreshing = false;
					});
			});

		}


	}
}

