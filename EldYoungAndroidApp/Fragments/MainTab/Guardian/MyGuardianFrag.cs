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
using EldYoungAndroidApp.Model.Guardian;
using EldYoungAndroidApp.Adapter;
using Com.Handmark.Pulltorefresh.Library.Extras;
using System.Threading.Tasks;
using EldYoungAndroidApp.Common;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using Com.Nostra13.Universalimageloader.Core.Listener;
using Com.Nostra13.Universalimageloader.Core;

namespace EldYoungAndroidApp.Fragments.MainTab.Guardian
{
	public class MyGuardianFrag :  BaseFragment,PullToRefreshBase.IOnRefreshListener2
	{
		
		private PullToRefreshListView myGuardianRefreshListView;
		private ListView actualListView;
		private int lastY;

		private List<GuardianInfoListItem> guardianInfoList;
		private GuardianInfoAdapter guardianInfoAdapter ;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private MineGuardianInfoListParam myGuardianInfoListParam;//请求参数对象
		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private int total;//总记录数

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
			var myGuardianView = inflater.Inflate (Resource.Layout.MyGuardianFragLayout, container, false);
			return myGuardianView;

		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			myGuardianRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_myGuardian);
			actualListView = (ListView)myGuardianRefreshListView.RefreshableView;
			//设置可以上拉加载。下拉刷新
			myGuardianRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;

			//下拉刷新提示文本
			myGuardianRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			myGuardianRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			myGuardianRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));



			//设置声音
//			SoundPullEventListener soundListener = new SoundPullEventListener(Activity);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.PullToRefresh, Resource.Raw.pull_event);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.Reset, Resource.Raw.reset_sound);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.Refreshing, Resource.Raw.refreshing_sound);
//			myGuardianRefreshListView.SetOnPullEventListener (soundListener);

			//设置上拉下拉监听事件
			myGuardianRefreshListView.SetOnRefreshListener (this);
			//myGuardianRefreshListView.SetOnLastItemVisibleListener (this);
			actualListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				//	Toast.MakeText(Activity,guardianInfoAdapter.GetItem(e.Position-1).Content,ToastLength.Short).Show();

			};

			//设置滑动listview停止加载图片
			actualListView.SetOnScrollListener (new PauseOnScrollListener(Global.imageLoader,false,false));
		
			guardianInfoAdapter = new GuardianInfoAdapter (Activity);
			actualListView.Adapter = guardianInfoAdapter;

			//初始化请求参数对象
			myGuardianInfoListParam = new MineGuardianInfoListParam (){ UserId = Global.MyInfo.UId };
	
			IsPrepared = true;
			LasyloadData ();
		}

		/// <summary>
		/// 重写第一次加载方法
		/// </summary>
		public override void LasyloadData ()
		{
//			if (!IsPrepared || !IsVisible || HasLoadedOnce)
//				return;
			if (!IsPrepared || !IsVisible)
				return;
			//第一次进入设置自动刷新view
			myGuardianRefreshListView.Refreshing = true;
		

		}
			

		private void loadData()
		{
			pageIndex = 1;
			UpdateGuardianInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					
					var result = response.Content;
					var guardianInfoJson =  JsonConvert.DeserializeObject<GuardianInfoJson>(result);
					if(guardianInfoJson.statuscode =="1")
					{
						total = guardianInfoJson.data.total;
						guardianInfoList = guardianInfoJson.data.items;
						Activity.RunOnUiThread(()=>
							{
								guardianInfoAdapter.Clear();
								guardianInfoAdapter.AddAll(guardianInfoList);
								guardianInfoAdapter.NotifyDataSetChanged();
								HasLoadedOnce = true;//加载第一次成功
							});
					}
					else
					{
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取监护人列表信息失败...",ToastLength.Short).Show();
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
						myGuardianRefreshListView.OnRefreshComplete ();
						IsRefreshing = false;
					});
			});
		}

		private void UpdateGuardianInfoListParam()
		{
			myGuardianInfoListParam.PageIndex = pageIndex.ToString();
			SetRestRequestParams ();
		}

		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", myGuardianInfoListParam.Key);
			else
				requestParams ["key"] = myGuardianInfoListParam.Key;
			
			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", myGuardianInfoListParam.EuserId);
			else
				requestParams ["eUserId"] = myGuardianInfoListParam.EuserId;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", myGuardianInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = myGuardianInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", myGuardianInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = myGuardianInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", myGuardianInfoListParam.Eaction);
			else
				requestParams ["eaction"] = myGuardianInfoListParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", myGuardianInfoListParam.Md5);
			else
				requestParams ["md5"] = myGuardianInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (myGuardianInfoListParam.Url,requestParams);
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
				Task.Factory.StartNew (() => {
					loadData ();
				});
			} else {
				myGuardianRefreshListView.OnRefreshComplete ();
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
				Task.Factory.StartNew (() => {
					LoadMoreData ();
				});
			} else {
				myGuardianRefreshListView.OnRefreshComplete ();
				IsRefreshing = false;
			}


		}

		private void LoadMoreData()
		{
			lastY = guardianInfoList.Count;
			pageIndex++;
			UpdateGuardianInfoListParam ();
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed)
				{
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var result = response.Content;
						var guardianInfoJson =  JsonConvert.DeserializeObject<GuardianInfoJson>(result); 
						if(guardianInfoJson.statuscode == "1")
						{
							total = guardianInfoJson.data.total;
							guardianInfoList.AddRange(guardianInfoJson.data.items);
							Activity.RunOnUiThread(()=>
								{
									guardianInfoAdapter.AddAll(guardianInfoJson.data.items);
									guardianInfoAdapter.NotifyDataSetChanged();
									//讲listview滚动到上次加载位置
									actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
								});
						}
						else
						{
							pageIndex --;
							Activity.RunOnUiThread(()=>
								{
									Toast.MakeText(Activity,"获取更多监护人列表信息出错...",ToastLength.Short).Show();
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
						myGuardianRefreshListView.OnRefreshComplete ();
						IsRefreshing = false;
					});

			});

		}




	

	}
}

