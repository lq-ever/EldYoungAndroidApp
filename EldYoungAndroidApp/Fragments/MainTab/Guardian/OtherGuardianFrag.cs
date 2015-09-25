
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
using EldYoungAndroidApp.Model.Guardian;
using EldYoungAndroidApp.Adapter;
using Com.Handmark.Pulltorefresh.Library.Extras;
using EldYoungAndroidApp.Common;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using Com.Nostra13.Universalimageloader.Core.Listener;
using Com.Nostra13.Universalimageloader.Core;

namespace EldYoungAndroidApp.Fragments.MainTab.Guardian
{
	public class OtherGuardianFrag : BaseFragment,PullToRefreshBase.IOnRefreshListener2
	{
		private List<GuardianInfoListItem> guardianInfoList;
		private GuardianInfoAdapter guardianInfoAdapter ;
		private PullToRefreshListView otherGuardianRefreshListView;
		private ListView actualListView;
		private int lastY;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private GuardianMeInfoListParam guardianMeInfoListParam;//请求参数对象
		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private int total;//总记录数


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
			var otherGuardianView = inflater.Inflate (Resource.Layout.OtherGuardianFragLayout, container, false);
			return otherGuardianView;
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			otherGuardianRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_OtherGuardian);
			actualListView = (ListView)otherGuardianRefreshListView.RefreshableView;

			//设置可以上拉加载。下拉刷新
			otherGuardianRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;

			//下拉刷新提示文本
			otherGuardianRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			otherGuardianRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			otherGuardianRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			otherGuardianRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			otherGuardianRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			otherGuardianRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));

			//设置声音
//			SoundPullEventListener soundListener = new SoundPullEventListener(Activity);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.PullToRefresh, Resource.Raw.pull_event);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.Reset, Resource.Raw.reset_sound);
//			soundListener.AddSoundEvent (PullToRefreshBase.PullToRefreshState.Refreshing, Resource.Raw.refreshing_sound);
//			otherGuardianRefreshListView.SetOnPullEventListener (soundListener);

			//设置上拉下拉监听事件
			otherGuardianRefreshListView.SetOnRefreshListener (this);
			//otherGuardianRefreshListView.SetOnLastItemVisibleListener (this);
			actualListView.SetOnScrollListener (new PauseOnScrollListener(Global.imageLoader,false,false));

			actualListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				//Toast.MakeText(Activity,guardianInfoAdapter.GetItem(e.Position-1).Content,ToastLength.Short).Show();
			};

			//设置adapter
			guardianInfoAdapter = new GuardianInfoAdapter (Activity);
			actualListView.Adapter = guardianInfoAdapter;

			//初始化请求参数对象
			guardianMeInfoListParam = new GuardianMeInfoListParam (){ UserId = Global.MyInfo.UId };

			IsPrepared = true;
			LasyloadData ();
		
		}

		/// <summary>
		/// 懒加载数据
		/// </summary>
		public override void LasyloadData ()
		{

			if (!IsPrepared || !IsVisible)
				return;
			//第一次进入设置自动刷新view
			otherGuardianRefreshListView.Refreshing = true;

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
								otherGuardianRefreshListView.OnRefreshComplete ();
								HasLoadedOnce = true;//加载第一次成功
							});
					}
					else
					{
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取监护人列表信息失败...",ToastLength.Short).Show();
								otherGuardianRefreshListView.OnRefreshComplete ();
								return;
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
							otherGuardianRefreshListView.OnRefreshComplete ();
							return;
						});
				}
				else
				{
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();
							otherGuardianRefreshListView.OnRefreshComplete ();
							return;
						});
				}
			});
		}
		private void UpdateGuardianInfoListParam()
		{
			guardianMeInfoListParam.PageIndex = pageIndex.ToString();
			SetRestRequestParams ();
		}

		private void SetRestRequestParams()
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", guardianMeInfoListParam.Key);
			else
				requestParams ["key"] = guardianMeInfoListParam.Key;
			
			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", guardianMeInfoListParam.EuserId);
			else
				requestParams ["eUserId"] = guardianMeInfoListParam.EuserId;

			if (!requestParams.ContainsKey ("ePageIndex"))
				requestParams.Add ("ePageIndex", guardianMeInfoListParam.EpageIndex);
			else
				requestParams ["ePageIndex"] = guardianMeInfoListParam.EpageIndex;

			if (!requestParams.ContainsKey ("ePageSize"))
				requestParams.Add ("ePageSize", guardianMeInfoListParam.EpageSize);
			else
				requestParams ["ePageSize"] = guardianMeInfoListParam.EpageSize;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", guardianMeInfoListParam.Eaction);
			else
				requestParams ["eaction"] = guardianMeInfoListParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", guardianMeInfoListParam.Md5);
			else
				requestParams ["md5"] = guardianMeInfoListParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (guardianMeInfoListParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;

		}


		/// <summary>
		/// 监听下拉刷新事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullDownToRefresh (PullToRefreshBase p0)
		{

		
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
			lastY = guardianInfoList.Count;
			Task.Factory.StartNew (() => {
				//获取更多监护人数据
				LoadMoreData();
			});


		}


		private void LoadMoreData()
		{
			lastY = guardianInfoList.Count;
			pageIndex++;
			UpdateGuardianInfoListParam ();
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
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
								otherGuardianRefreshListView.OnRefreshComplete ();
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

								otherGuardianRefreshListView.OnRefreshComplete ();
								return;
							});
					}
				}
				else if(response.ResponseStatus == RestSharp.ResponseStatus.TimedOut)
				{
					pageIndex --;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();

							otherGuardianRefreshListView.OnRefreshComplete ();
							return;
						});
				}
				else
				{
					pageIndex --;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,response.StatusDescription,ToastLength.Short).Show();

							otherGuardianRefreshListView.OnRefreshComplete ();
							return;
						});
				}

			});

		}
	}
}

