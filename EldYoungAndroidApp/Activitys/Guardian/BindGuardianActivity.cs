
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EldYoungAndroidApp.Model.Guardian;
using EldYoungAndroidApp.Adapter;
using EldYoungAndroidApp.Common;
using System.Threading;
using EldYoungAndroidApp.Model;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using Com.Nostra13.Universalimageloader.Core.Listener;
using Com.Nostra13.Universalimageloader.Core;

namespace EldYoungAndroidApp.Activitys.Guardian
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class BindGuardianActivity : Activity,SearchView.IOnQueryTextListener
	{
		private SearchView searchView;
		private TextView textView;
		private ListView listView;

		private ApplyGuardianListAdapter applyGuardianListAdapter ;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private SearchGuardianParam searchGuardianParam = new SearchGuardianParam(){Guid = Global.Guid};//请求参数对象
		private RestSharpRequestHelp restSharpRequestHelp;
		protected bool HasLoadedOnce;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.BindGuardianLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}

		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
			};

			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "监护人绑定";

			listView = FindViewById<ListView> (Resource.Id.lv_searchGuardian);


		    searchView = FindViewById<SearchView> (Resource.Id.searchView);
			searchView.SetOnQueryTextListener (this);
			//设置searchview中textview颜色
			var id = searchView.Context.Resources.GetIdentifier ("android:id/search_src_text", null, null);
			textView = (TextView)searchView.FindViewById(id);
			textView.SetTextColor (Resources.GetColor (Resource.Color.lightgray));

			//查询
			var txt_Querry = FindViewById<TextView> (Resource.Id.txt_Querry);
			txt_Querry.Click += (sender, e) => 
			{
				OnQueryTextSubmit(textView.Text);
			};

			applyGuardianListAdapter = new ApplyGuardianListAdapter (this);
			applyGuardianListAdapter.RefreshAction = () => {
				QuerryBindGuardian(textView.Text);
			};
			listView.Adapter = applyGuardianListAdapter;
			//设置滑动listview停止加载图片
			listView.SetOnScrollListener (new PauseOnScrollListener(Global.imageLoader,false,false));
		}



		public bool OnQueryTextSubmit (string query)
		{
			QuerryBindGuardian (query);

			return true;
		}


		public bool OnQueryTextChange (string newText)
		{
			return true;
		}

		private void QuerryBindGuardian(string condition)
		{
			ProgressDialogUtil.StartProgressDialog(this,"正在加载中...");
			searchGuardianParam.Condition = condition;

			if (!requestParams.ContainsKey ("econdition"))
				requestParams.Add ("econdition", searchGuardianParam.Econdition);
			else
				requestParams ["econdition"] = searchGuardianParam.Econdition;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", searchGuardianParam.Eaction);
			else
				requestParams ["eaction"] = searchGuardianParam.Eaction;
			
			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", searchGuardianParam.Md5);
			else
				requestParams ["md5"] = searchGuardianParam.Md5;

			if (!requestParams.ContainsKey ("eguid"))
				requestParams.Add ("eguid", searchGuardianParam.Eguid);
			else
				requestParams ["eguid"] = searchGuardianParam.Eguid;

			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", searchGuardianParam.Key);
			else
				requestParams ["key"] = searchGuardianParam.Key;
			


			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (searchGuardianParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;
			
			//调用web服务
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed)
				{
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var result = response.Content;
						var searchGardianlistInfoJson = JsonConvert.DeserializeObject<SearchGuardianListJson>(result);
						if(searchGardianlistInfoJson.statuscode == "1")
						{
							RunOnUiThread(()=>
							{
								applyGuardianListAdapter.Clear();//清空所有数据
								applyGuardianListAdapter.AddAll(searchGardianlistInfoJson.data);
								applyGuardianListAdapter.NotifyDataSetChanged();
							    ProgressDialogUtil.StopProgressDialog();
							    HasLoadedOnce = true;
							});
						}
						else
						{
							RunOnUiThread(()=>
								{
									Toast.MakeText(this,"获取会员信息失败",ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									return;
								});
						}
					}
					else
					{
						RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时,稍后在试...",ToastLength.Short).Show();
						    ProgressDialogUtil.StopProgressDialog();
							return;
						});
					}
				}
			});

		}

	}
}

