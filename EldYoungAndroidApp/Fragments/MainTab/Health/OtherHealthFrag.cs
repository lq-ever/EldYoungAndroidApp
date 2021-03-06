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
using EldYoungAndroidApp.Adapter;
using EldYoungAndroidApp.Param;
using EldYoungAndroidApp.Common;
using EldYoungAndroidApp.Model.Health;
using EldYoungAndroidApp.Model.Alarm;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using System.Threading.Tasks;

namespace EldYoungAndroidApp.Fragments.MainTab.Health
{
	public class OtherHealthFrag :BaseFragment,PullToRefreshBase.IOnRefreshListener2,Spinner.IOnItemSelectedListener,Android.Views.View.IOnFocusChangeListener
	{
		private HealthInfoListAdapter healthInfoAdapter;
		private PullToRefreshListView otherhealthRefreshListView;
		private int lastY;

		private ListView actualListView;
		private EditText edit_other_searchTime;
		private string other_searchTime_default;
		private Button btn_other_search;
		private Spinner sp_other_guardian;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private SearchHealthInforParam healthInfoParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private RestSharpRequestHelp restSharpGetMyUserRequestHelp;
		private int total;//总记录数
		private List<HealthInfoItem> healthInfoLists = new List<HealthInfoItem>();

		private List<AllMyUserListItem> myUserLists;//我的监护人列表
		private SearchAllMyUserParam myUserParam = new SearchAllMyUserParam(){UserId = Global.MyInfo.UId};//我的监护人请求参数对象
		private Dictionary<string,string> myUserRequestParams = new Dictionary<string, string>();//监护人web请求
		private ArrayAdapter<AllMyUserListItem> myUserListAdapter;
		private string myUserId;
		private bool btnSearchFlag = false;//监听是否点击查询
		private bool IsRefreshing = false;//是否正在获取数据
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
			var otherHealthView = inflater.Inflate (Resource.Layout.OtherHealthFragLayout, container, false);
			return otherHealthView;
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			otherhealthRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_otherHealth);
			actualListView = (ListView)otherhealthRefreshListView.RefreshableView;

			//设置可以上拉加载。下拉刷新
			otherhealthRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;
			//下拉刷新提示文本
			otherhealthRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			otherhealthRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			otherhealthRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			otherhealthRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			otherhealthRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			otherhealthRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));
			//绑定监听事件
			otherhealthRefreshListView.SetOnRefreshListener (this);

			//加载view
			edit_other_searchTime = View.FindViewById<EditText>(Resource.Id.edit_other_searchTime);
//			edit_other_searchTime.Click += (sender, e) => 
//			{
//				var datepickdialog = new DatePickDialogUtil(Activity,edit_other_searchTime.Text);
//				datepickdialog.DatePickDialogShow(edit_other_searchTime);
//			};
			edit_other_searchTime.OnFocusChangeListener = this;
			edit_other_searchTime.InputType = Android.Text.InputTypes.Null;
			other_searchTime_default = DateTime.Now.ToString ("yyyy-MM-dd");
			edit_other_searchTime.Text = other_searchTime_default;
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
			healthInfoAdapter = new HealthInfoListAdapter (Activity);
			actualListView.Adapter = healthInfoAdapter;

			actualListView.ItemClick += (sender, e) => 
			{
				//var intent  = new Intent(Activity,typeof(HealthDetailInfoActivity));
				var intent  = new Intent(Activity,typeof(PhysicalDetailInfoActivity));
				var _healthInfoItem = healthInfoAdapter.GetItem(e.Position -1);
				var _healthInfoJson = JsonConvert.SerializeObject(_healthInfoItem);
				intent.PutExtra("healthInfo",_healthInfoJson);

				Activity.StartActivity(intent);
				Activity.OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			healthInfoParam =  new SearchHealthInforParam();
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
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
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
				else
				{

					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
							return;
						});
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
					otherhealthRefreshListView.Refreshing = true;
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
			//第一次进入设置自动刷新view
			//otherhealthRefreshListView.Refreshing = true; //update by lq放入加载监护人之后
		}


		private void loadData()
		{
			if(btnSearchFlag)
				ProgressDialogUtil.StartProgressDialog(Activity,"正在查询健康体检信息...",true);
			if (string.IsNullOrEmpty (myUserId)) {
				//未选择任何监护人
				Activity.RunOnUiThread (() => {
					otherhealthRefreshListView.OnRefreshComplete ();
					if(btnSearchFlag)
						ProgressDialogUtil.StopProgressDialog();
				});
				return;
			}
			pageIndex =1;
			UpdateHealthInfoListParam ();

			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed)
				{
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var result = response.Content;
						var healthInfoJson = JsonConvert.DeserializeObject<SearchHealthInfoJson>(result);
						if(healthInfoJson.statuscode == "1")
						{
							total =  healthInfoJson.data.total;
							healthInfoLists = healthInfoJson.data.items;

							Activity.RunOnUiThread(()=>
								{
									healthInfoAdapter.Clear();
									healthInfoAdapter.AddAll(healthInfoLists);
									healthInfoAdapter.NotifyDataSetChanged();
									HasLoadedOnce = true;//加载第一次成功

								});

						}
						else
						{
							Activity.RunOnUiThread(()=>
								{
									Toast.MakeText(Activity,"查询健康体检信息错误",ToastLength.Short).Show();

								});
						}
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
						otherhealthRefreshListView.OnRefreshComplete ();
						if(btnSearchFlag)
							ProgressDialogUtil.StopProgressDialog();
						IsRefreshing = false;
					});
			});

		}

		/// <summary>
		/// 更新参数请求对象
		/// </summary>
		private void UpdateHealthInfoListParam()
		{
			healthInfoParam.Id = myUserId;
			healthInfoParam.PageIndex = pageIndex.ToString();
			healthInfoParam.SearchTime = string.IsNullOrEmpty (edit_other_searchTime.Text) ? other_searchTime_default : edit_other_searchTime.Text;
			SetRestRequestParams ();
		}
		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("ESearchTime"))
				requestParams.Add ("ESearchTime", healthInfoParam.EsearchTime);
			else
				requestParams ["ESearchTime"] = healthInfoParam.EsearchTime;


			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", healthInfoParam.Eid);
			else
				requestParams ["eUserId"] = healthInfoParam.Eid;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", healthInfoParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = healthInfoParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", healthInfoParam.EpageSize);
			else
				requestParams ["ePageSize"] = healthInfoParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", healthInfoParam.Eaction);
			else
				requestParams ["eaction"] = healthInfoParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", healthInfoParam.Md5);
			else
				requestParams ["md5"] = healthInfoParam.Md5;

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", healthInfoParam.Key);
			else
				requestParams ["key"] = healthInfoParam.Key;
			
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (healthInfoParam.Url,requestParams);
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
				otherhealthRefreshListView.OnRefreshComplete ();
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
				btnSearchFlag = false;
				Task.Factory.StartNew (() => {
					//加载更多数据
					LoadMoreData ();
				});
			} else {
				otherhealthRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}

		}

		/// <summary>
		/// Loads the more data.
		/// </summary>
		private void LoadMoreData()
		{
			lastY = healthInfoLists.Count;
			pageIndex++;
			UpdateHealthInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed)
				{
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var result = response.Content;
						var searchHealthInfoJson = JsonConvert.DeserializeObject<SearchHealthInfoJson>(result);
						if(searchHealthInfoJson.statuscode == "1")
						{
							total =  searchHealthInfoJson.data.total;
							healthInfoLists.AddRange(searchHealthInfoJson.data.items);

							Activity.RunOnUiThread(()=>
								{
									healthInfoAdapter.AddAll(searchHealthInfoJson.data.items);
									healthInfoAdapter.NotifyDataSetChanged();
									//讲listview滚动到上次加载位置
									actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
								});
						}
						else
						{
							pageIndex --;
							Activity.RunOnUiThread(()=>
								{
									Toast.MakeText(Activity,"获取更多体检信息错误",ToastLength.Short).Show();
								});
						}
					}

				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					pageIndex --;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
						});
				}
				else
				{
					pageIndex --;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();
						});
				}
				Activity.RunOnUiThread(()=>
					{
						otherhealthRefreshListView.OnRefreshComplete ();
						IsRefreshing = false;
					});
			});
		}

	}
}

