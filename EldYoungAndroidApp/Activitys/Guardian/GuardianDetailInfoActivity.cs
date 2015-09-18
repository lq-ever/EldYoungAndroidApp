
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
using EldYoungAndroidApp.Common;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;

namespace EldYoungAndroidApp.Activitys.Guardian
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class GuardianDetailInfoActivity : Activity
	{
		private string UId =string.Empty;
		private TextView tv_TrueName, tv_Gender, tv_Brnl, tv_PhoneNumberOne, tv_IDNumber, tv_ContactAddress, tv_TelePhoneNumber, tv_Email,
			tv_Height, tv_Weight, tv_HereditaryDisease;
		private RestSharpRequestHelp restSharpRequestHelp;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private GuardianDetailInfoParam guardianInfoDetailParam;//请求参数对象
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle); 
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.GuardianDetailInfoLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}

		/// <summary>
		/// Inits the view.
		/// </summary>
		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
			};

			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "详情";
			tv_TrueName = FindViewById<TextView> (Resource.Id.tv_TrueName);
			tv_Gender = FindViewById<TextView> (Resource.Id.tv_Gender);
			tv_Brnl = FindViewById<TextView> (Resource.Id.tv_Brnl);
			tv_PhoneNumberOne = FindViewById<TextView> (Resource.Id.tv_PhoneNumberOne);
			tv_IDNumber = FindViewById<TextView> (Resource.Id.tv_IDNumber);
			tv_ContactAddress = FindViewById<TextView> (Resource.Id.tv_ContactAddress);
			tv_TelePhoneNumber = FindViewById<TextView> (Resource.Id.tv_TelePhoneNumber);
			tv_Email = FindViewById<TextView> (Resource.Id.tv_Email);
			tv_Height = FindViewById<TextView> (Resource.Id.tv_Height);
			tv_Weight = FindViewById<TextView> (Resource.Id.tv_Weight);
			tv_HereditaryDisease = FindViewById<TextView> (Resource.Id.tv_HereditaryDisease);
			//取得上一页面传递过来的值
			var bundle = Intent.Extras;
			//从bundle中获取值赋值显示
			UId= bundle.GetString("UId");
			//LoadDetailData ();
			new Handler ().PostDelayed (LoadDetailData, 1000);
		}

		private void LoadDetailData ()
		{
			ProgressDialogUtil.StartProgressDialog (this, "正在加载用户详细数据...");
			if (string.IsNullOrEmpty (UId))
				return;
			guardianInfoDetailParam = new GuardianDetailInfoParam (){ Id = UId };
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", guardianInfoDetailParam.Key);
			else
				requestParams ["eId"] = guardianInfoDetailParam.Key;
			if (!requestParams.ContainsKey ("eId"))
				requestParams.Add ("eId",guardianInfoDetailParam.Eid);

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", guardianInfoDetailParam.Eaction);
			else
				requestParams ["eaction"] = guardianInfoDetailParam.Eaction;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", guardianInfoDetailParam.Md5);
			else
				requestParams ["md5"] = guardianInfoDetailParam.Md5;
			//设置restsharprequest
			if (restSharpRequestHelp == null)
				restSharpRequestHelp = new RestSharpRequestHelp (guardianInfoDetailParam.Url,requestParams);
			else
				restSharpRequestHelp.RequestParams = requestParams;
			//调用监护人详情web服务
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed)
				{
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var result = response.Content;
						var guardianDetailInfoJson = JsonConvert.DeserializeObject<GuardianDetailInfoJson>(result);
						if(guardianDetailInfoJson.statuscode == "1")
						{
							if(guardianDetailInfoJson.data!=null && guardianDetailInfoJson.data.Count >0)
							{
								var detailItem = guardianDetailInfoJson.data[0];
								RunOnUiThread(()=>
									{
										tv_TrueName.Text = detailItem.TrueName;
										tv_Gender.Text = detailItem.Gender;
										tv_Brnl.Text = detailItem.BRNL;
										tv_PhoneNumberOne.Text = detailItem.PhoneNumberOne;
										tv_IDNumber.Text = detailItem.IDNumber;
										tv_ContactAddress.Text = detailItem.ContactAddress;
										tv_TelePhoneNumber.Text = detailItem.TelePhoneNumber;
										tv_Email.Text = detailItem.Email;
										tv_Height.Text = detailItem.Height;
										tv_Weight.Text = detailItem.Weight;
										tv_HereditaryDisease.Text = detailItem.HereditaryDisease;

									});
								

							}
							RunOnUiThread(()=>
								{
									ProgressDialogUtil.StopProgressDialog();
								});
						}
						else
						{
							RunOnUiThread(()=>
								{
									Toast.MakeText(this,"获取用户详情信息失败...",ToastLength.Short).Show();
									ProgressDialogUtil.StopProgressDialog();
									return;
								});
						}
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
			});

		}
	}
}

