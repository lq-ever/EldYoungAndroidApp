using System;
using Android.Widget;
using EldYoungAndroidApp.Model.Guardian;
using Android.App;
using Android.Views;
using EldYoungAndroidApp.Model;
using EldYoungAndroidApp.Common;
using EldYoungAndroidApp.Activitys.Guardian;
using System.Threading;
using System.Collections.Generic;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using EldYoungAndroidApp.Common.ImageCache;

namespace EldYoungAndroidApp.Adapter
{
	public class ApplyGuardianListAdapter:ArrayAdapter<SearchGuardianListItem>
	{
		private Activity activity;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private ApplyBindGuardianParam applyBindGuardianParam = new ApplyBindGuardianParam(){UserId = Global.Guid};//请求参数对象
		private RestSharpRequestHelp restSharpRequestHelp;
		private ImageLoader imageLoader;
		public Action RefreshAction {
			get;
			set;
		}
		public ApplyGuardianListAdapter (Activity _activity):base(_activity,0)
		{
			activity = _activity;
			//imageLoader = new ImageLoader (_activity.ApplicationContext);
			imageLoader = ImageLoader.CreateImageLoaderInstance(_activity.ApplicationContext);
		}

		public override Android.Views.View GetView ( int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			SearchGuardianItemView _searchGuardianItemView = null;
			var item = GetItem (position);
			if (convertView == null) {

				convertView = LayoutInflater.From (Context).Inflate (Resource.Layout.searchguardianListItemView, null);
				_searchGuardianItemView = new SearchGuardianItemView ();
				_searchGuardianItemView.guardian_img_head = convertView.FindViewById<ImageView> (Resource.Id.guardian_img_head);
				_searchGuardianItemView.tv_Name = convertView.FindViewById<TextView> (Resource.Id.tv_Name);
				_searchGuardianItemView.tv_PhoneNum = convertView.FindViewById<TextView> (Resource.Id.tv_phoneNumber);
				_searchGuardianItemView.img_Sex = convertView.FindViewById<ImageView> (Resource.Id.img_sex);
				//_searchGuardianItemView.tv_Detail = convertView.FindViewById<TextView> (Resource.Id.tv_detail);
				_searchGuardianItemView.btn_Action = convertView.FindViewById<Button> (Resource.Id.btn_Action);
				_searchGuardianItemView.tv_Location = convertView.FindViewById<TextView> (Resource.Id.tv_location);
				_searchGuardianItemView.tv_GuardianStatus = convertView.FindViewById<TextView> (Resource.Id.tv_GuardianStatus);
				convertView.SetTag (Resource.Id.searchGuardianListItemView, (Java.Lang.Object)_searchGuardianItemView);

			} else
				_searchGuardianItemView = (SearchGuardianItemView)convertView.GetTag (Resource.Id.searchGuardianListItemView);

			_searchGuardianItemView.tv_Name.Text = item.TrueName;
			_searchGuardianItemView.tv_PhoneNum.Text = item.PhoneNumberOne;
			//_searchGuardianItemView.tv_Location.Text = item.ContactAddress;//todo:解析获取位置
			_searchGuardianItemView.tv_GuardianStatus.Text = GetGuardianStatus(item.IsPass);

		  
			SetbtnAction(_searchGuardianItemView.btn_Action,item.IsPass);//设置操作按钮文字和可用状态

			var imgSexId = (item.Sex == Sex.Male) ? Resource.Drawable.ic_sex_man : Resource.Drawable.ic_sex_woman;
			_searchGuardianItemView.img_Sex.SetImageResource (imgSexId);

			//设置头像采用二级缓存、异步加载
			imageLoader.DisplayImage(item.HeadImgReleaseUrl,_searchGuardianItemView.guardian_img_head);


			//按钮绑定事件 			
			_searchGuardianItemView.btn_Action.Tag = item;
			_searchGuardianItemView.btn_Action.Click -= ActionHandler;
			_searchGuardianItemView.btn_Action.Click += ActionHandler;

			//详情按钮事件
//			_searchGuardianItemView.tv_Detail.Tag = item;
//			_searchGuardianItemView.tv_Detail.Click -= DetailHandler;
//			_searchGuardianItemView.tv_Detail.Click += DetailHandler;

			return convertView;
		}
		/// <summary>
		/// Gets the guardian status.
		/// </summary>
		/// <returns>The guardian status.</returns>
		/// <param name="guardianStatus">Guardian status.</param>
		private string GetGuardianStatus(string guardianStatus)
		{
			switch (guardianStatus) {
			case "0":
				return "等待对方处理申请";

			case "1":
				return "对方已同意申请";
			case "2":
				return "对方已拒绝申请";
			
			default:
				return string.Empty;
			}
		}

		private void SetbtnAction(Button btn_action,string guardianStatus)
		{
			switch (guardianStatus) {
			case "0"://审核中
				btn_action.Text = "申请绑定";
				btn_action.Enabled = true;
				btn_action.SetBackgroundResource (Resource.Color.blue);
				break;

			case "1"://同意
				btn_action.Text = "已绑定";
				btn_action.Enabled = false;
				btn_action.SetBackgroundResource (Resource.Color.lightgray);
				break;
				
			case "2"://未同意
				btn_action.Text = "申请绑定";
				btn_action.Enabled = true;
				btn_action.SetBackgroundResource (Resource.Color.blue);
				break;

			default:
				btn_action.Text = "申请绑定";
				btn_action.Enabled = true;
				btn_action.SetBackgroundResource (Resource.Color.blue);
				break;
				
			}
		}

		private void ActionHandler(object sender, EventArgs e)
		{
			var item = (SearchGuardianListItem)(sender as Button).Tag;
			var applybindPopWindow = new ApplybindPopWindow (activity, item){applyBindEventHandler = ApplyBindGuardian};
			applybindPopWindow.ShowPopWindow (activity.FindViewById<LinearLayout> (Resource.Id.ll_MainGuardian));
		}

		/// <summary>
		/// 申请绑定监护人
		/// </summary>
		/// <param name="item">Item.</param>
		/// <param name="applyMsgContent">Apply message content.</param>
		private void ApplyBindGuardian(SearchGuardianListItem item,string applyMsgContent)
		{
			ProgressDialogUtil.StartProgressDialog(activity,"正在申请中...");
			applyBindGuardianParam.GId = item.UId;
			applyBindGuardianParam.ApplyContent = applyMsgContent;
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", applyBindGuardianParam.Key);
			else
				requestParams ["key"] = applyBindGuardianParam.Key;
			
			if (!requestParams.ContainsKey ("eapplycontent"))
				requestParams.Add ("eapplycontent", applyBindGuardianParam.EapplyContent);
			else
				requestParams ["eapplycontent"] = applyBindGuardianParam.EapplyContent;
			
			if (!requestParams.ContainsKey ("eUserId"))
				requestParams.Add ("eUserId", applyBindGuardianParam.EuserId);
			else
				requestParams ["eUserId"] = applyBindGuardianParam.EuserId;
			
			if (!requestParams.ContainsKey ("egid"))
				requestParams.Add ("egid", applyBindGuardianParam.Egid);
			else
				requestParams ["egid"] = applyBindGuardianParam.Egid;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", applyBindGuardianParam.Eaction);
			else
				requestParams ["eaction"] = applyBindGuardianParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", applyBindGuardianParam.Md5);
			else
				requestParams ["md5"] = applyBindGuardianParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (applyBindGuardianParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;

			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					var result = response.Content;
					var applyGuardianJson = JsonConvert.DeserializeObject<ApplyForGuardianJson>(result);

					if(applyGuardianJson.statuscode == "1")
					{
						if(applyGuardianJson.data == "1")
						{
							activity.RunOnUiThread(()=>
								{
									Toast.MakeText(activity,"申请绑定监护人成功",ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();

									return;
								});
						}
						else
						{
							activity.RunOnUiThread(()=>
								{
									Toast.MakeText(activity,"申请绑定失败,稍后在试...",ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									return;
								});
						}
					}
					else
					{
						activity.RunOnUiThread(()=>
							{
								Toast.MakeText(activity,"申请绑定失败,稍后在试...",ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								return;
							});
					}
				}
				else
				{
					activity.RunOnUiThread(()=>
						{
							Toast.MakeText(activity,"网络连接超时,稍后在试...",ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							return;
						});
				}
				activity.RunOnUiThread(()=>
					{
						if(RefreshAction!=null)
							RefreshAction();
					});


			});
			

		}

		/// <summary>
		/// 详情事件方法
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void DetailHandler(object sender, EventArgs e)
		{
			var item = (SearchGuardianListItem)(sender as TextView).Tag;

			Context.StartActivity (typeof(GuardianDetailInfoActivity));
		}

	}


	/// <summary>
	/// Guardian item view.组件
	/// </summary>
	public class SearchGuardianItemView:Java.Lang.Object
	{
		public TextView tv_Name;
		public TextView tv_PhoneNum;
		public ImageView img_Sex;
		//public TextView tv_Detail;
		public Button btn_Action;
		public TextView tv_Location;
		public ImageView guardian_img_head;
		public TextView tv_GuardianStatus;


	}
}

