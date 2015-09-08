
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
using Android.Support.V4.Widget;
using Com.Handmark.Pulltorefresh.Library;
using EldYoungAndroidApp.Adapter;
using EldYoungAndroidApp.Model.Health;
using EldYoungAndroidApp.Param;
using EldYoungAndroidApp.Common;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using System.Threading.Tasks;

namespace EldYoungAndroidApp.Fragments.MainTab.Health
{
	public class MyHealthFrag : BaseFragment,PullToRefreshBase.IOnRefreshListener2
	{
		

		private HealthInfoListAdapter healthInfoAdapter;
		private PullToRefreshListView myhealthRefreshListView;
		private int lastY;

		private ListView actualListView;
		private EditText edit_my_searchTime;
		private string my_searchTime_default;
		private Button btn_my_search;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private SearchHealthInforParam healthInfoParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private int total;//总记录数
		private List<HealthInfoItem> healthInfoLists = new List<HealthInfoItem>();
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
			var myHealthView = inflater.Inflate (Resource.Layout.MyHealthFragLayout, container, false);
			return myHealthView;

		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			myhealthRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_MyHealth);
			actualListView = (ListView)myhealthRefreshListView.RefreshableView;

			//设置可以上拉加载。下拉刷新
			myhealthRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;
			//下拉刷新提示文本
			myhealthRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			myhealthRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			myhealthRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			myhealthRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			myhealthRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			myhealthRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));

			//绑定监听事件
			myhealthRefreshListView.SetOnRefreshListener (this);
			//myAlarmRefreshListView.SetOnLastItemVisibleListener (this);

			//加载view
			edit_my_searchTime = View.FindViewById<EditText>(Resource.Id.edit_my_searchTime);
			edit_my_searchTime.Click += (sender, e) => 
			{
				var datepickdialog = new DatePickDialogUtil(Activity,edit_my_searchTime.Text);
				datepickdialog.DatePickDialogShow(edit_my_searchTime);
			};
			my_searchTime_default = DateTime.Now.ToString ("yyyy-MM-dd");
			edit_my_searchTime.Text = my_searchTime_default;

			btn_my_search = View.FindViewById<Button> (Resource.Id.btn_my_search);
			//查询按钮
			btn_my_search.Click += (sender, e) => 
			{
				btnSearchFlag = true;
				loadData();
			};

			//设置adapter		
			healthInfoAdapter = new HealthInfoListAdapter (Activity);
			actualListView.Adapter = healthInfoAdapter;

			//点击列表详细
			actualListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => 
			{
				//将
				var intent  = new Intent(Activity,typeof(HealthDetailInfoActivity));
				var _healthInfoItem = healthInfoAdapter.GetItem(e.Position -1);
				var _healthInfoJson = JsonConvert.SerializeObject(_healthInfoItem);

				intent.PutExtra("healthInfo",_healthInfoJson);

				Activity.StartActivity(intent);

			};

			healthInfoParam =  new SearchHealthInforParam(){Id = Global.Guid};

			//初始化view完成
			IsPrepared = true;
			LasyloadData ();

		}

		public override void LasyloadData ()
		{
//			if (!IsPrepared || !IsVisible || HasLoadedOnce)
//				return;
			if (!IsPrepared || !IsVisible)
				return;
			//第一次进入设置自动刷新view
			myhealthRefreshListView.Refreshing = true;
		}

		private void loadData()
		{
			if(btnSearchFlag)
				ProgressDialogUtil.StartProgressDialog(Activity,"正在查询体检信息...");
			pageIndex =1;
			UpdateHealthInfoListParam ();

			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
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
								healthInfoAdapter.Clear();//清空所有数据
								healthInfoAdapter.AddAll(healthInfoLists);
								healthInfoAdapter.NotifyDataSetChanged();
								myhealthRefreshListView.OnRefreshComplete ();
								HasLoadedOnce = true;//加载第一次成功
								if(btnSearchFlag)
									ProgressDialogUtil.StopProgressDialog();
							});

					}
					else
					{
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取体检列表信息错误",ToastLength.Short).Show();
								myhealthRefreshListView.OnRefreshComplete ();
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
							if(btnSearchFlag)
								ProgressDialogUtil.StopProgressDialog();
							myhealthRefreshListView.OnRefreshComplete ();
							return;
						});
				}
			});

		}

		/// <summary>
		/// 更新参数请求对象
		/// </summary>
		private void UpdateHealthInfoListParam()
		{
			healthInfoParam.PageIndex = pageIndex.ToString();
			healthInfoParam.SearchTime = string.IsNullOrEmpty (edit_my_searchTime.Text) ? my_searchTime_default : edit_my_searchTime.Text;
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

		private void LoadMoreData()
		{
			lastY = healthInfoLists.Count;
			pageIndex++;
			UpdateHealthInfoListParam ();
			//调用webservice获取数据
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
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
								myhealthRefreshListView.OnRefreshComplete ();
								//讲listview滚动到上次加载位置
								actualListView.SetSelectionFromTop(lastY,(int)TrimMemory.Background);
							});

					}
					else
					{
						pageIndex--;
						Activity.RunOnUiThread(()=>
							{
								Toast.MakeText(Activity,"获取更多体检信息错误",ToastLength.Short).Show();
								myhealthRefreshListView.OnRefreshComplete ();
								return;
							});
					}
				}
				else
				{
					pageIndex--;
					Activity.RunOnUiThread(()=>
						{
							Toast.MakeText(Activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
							myhealthRefreshListView.OnRefreshComplete ();
							return;
						});
				}
			});

		}



	}
}

