
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
using System.Threading;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;

namespace EldYoungAndroidApp
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class PersonBasicActivity : Activity
	{
		private TextView tv_userName;
		private EditText edit_trueName,edit_IdCardNo,edit_birth,edit_fixedPhone,edit_email,edit_idCardLocation,edit_locationthreelevel,edit_locationdeatil
		,edit_phoneNumberOne;
		private RadioButton rbtn_male,rbtn_female;
		private string UserName, TrueName, IdCardNo, Gender, Birth, PhoneNumberOne, FixedPhone, EmailAddress, IdCardLocation, LocationThreeLevel, LocationDetail,TrueAddress;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
		private Dictionary<string,string> requestMyInfoParams = new Dictionary<string,string> ();
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			// Create your application here
			SetContentView(Resource.Layout.PersonBasicLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_titlebar_action);
			InitView ();
		}

		private void InitView()
		{
			//设置标题栏
			var btn_headerBack = FindViewById<Button> (Resource.Id.btn_header_back);

			btn_headerBack.Click += (sender, e) => 
			{
				this.Finish();
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "个人资料";
			//完成按钮
			var tv_header_save = FindViewById<TextView>(Resource.Id.tv_header_save);
			tv_header_save.Text = "保存";
			tv_header_save.Click += (sender, e) => 
			{
				SubmitPesonInfo();
			};
			//用户名
			tv_userName = FindViewById<TextView>(Resource.Id.tv_userName);
			//tv_userName.Text = Global.MyInfo.UserName;
			//真实姓名
			edit_trueName = FindViewById<EditText>(Resource.Id.edit_trueName);
			//edit_trueName.Text = string.IsNullOrEmpty (Global.MyInfo.TrueName) ? "" : Global.MyInfo.TrueName;
			//身份证号码
			edit_IdCardNo = FindViewById<EditText>(Resource.Id.edit_IdCardNo);
			//edit_IdCardNo.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "" : Global.MyInfo.IDNumber;

			//性别
			rbtn_male = FindViewById<RadioButton>(Resource.Id.rbtn_male);
		    rbtn_female = FindViewById<RadioButton> (Resource.Id.rbtn_female);
//			if (!string.IsNullOrEmpty (Global.MyInfo.Gender) && Global.MyInfo.Gender.Equals ("0"))
//				rbtn_male.Checked = true;
//			else
//				rbtn_female.Checked = true;
			//生日
			edit_birth = FindViewById<EditText> (Resource.Id.edit_birth);
			//edit_birth.Text = !string.IsNullOrEmpty (Global.MyInfo.Age) ?Convert.ToDateTime(Global.MyInfo.Age).ToString("yyyy-MM-dd") :"";
			edit_birth.Click += (sender, e) => 
			{
				var datepickdialog = new DatePickDialogUtil(this,edit_birth.Text);
				datepickdialog.DatePickDialogShow(edit_birth);

			};
			//电话号码
			edit_phoneNumberOne = FindViewById<EditText>(Resource.Id.edit_phoneNumberOne);
//			edit_phoneNumberOne.Text = !string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne) ? Global.MyInfo.PhoneNumberOne : "";
//			if (!string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne))
//				edit_phoneNumberOne.Enabled = false;
			//固定电话
			edit_fixedPhone = FindViewById<EditText>(Resource.Id.edit_fixedPhone);
			//edit_fixedPhone.Text = !string.IsNullOrEmpty (Global.MyInfo.TelePhoneNumber) ? Global.MyInfo.TelePhoneNumber : "";
			//电子邮箱
			edit_email = FindViewById<EditText>(Resource.Id.edit_email);
			//edit_email.Text = !string.IsNullOrEmpty (Global.MyInfo.Email) ? Global.MyInfo.Email : "";
			//身份证所在地
			edit_idCardLocation = FindViewById<EditText>(Resource.Id.edit_idCardLocation);
			//edit_idCardLocation.Text = !string.IsNullOrEmpty (Global.MyInfo.IDAddress) ? Global.MyInfo.IDAddress : "";
			//todo:设置详细地址
			edit_locationthreelevel = FindViewById<EditText>(Resource.Id.edit_locationthreelevel);
			edit_locationdeatil = FindViewById<EditText> (Resource.Id.edit_locationdeatil);
			GetPersonInfo ();
		}

		private void GetPersonInfo()
		{
			var getMyInfoParam = new GetMyInfoParam () {
				Uid = Global.MyInfo.UId
			};
			if (!requestMyInfoParams.ContainsKey ("key"))
				requestMyInfoParams.Add ("key", getMyInfoParam.Key);
			else
				requestMyInfoParams ["key"] = getMyInfoParam.Key;

			if (!requestMyInfoParams.ContainsKey ("eUId"))
				requestMyInfoParams.Add ("eUId", getMyInfoParam.Euid);
			else
				requestMyInfoParams ["eUId"] = getMyInfoParam.Euid;
			
			if (!requestMyInfoParams.ContainsKey ("eaction"))
				requestMyInfoParams.Add ("eaction", getMyInfoParam.Eaction);
			else
				requestMyInfoParams ["eaction"] = getMyInfoParam.Eaction;

			if (!requestMyInfoParams.ContainsKey ("md5"))
				requestMyInfoParams.Add ("md5", getMyInfoParam.Md5);
			else
				requestMyInfoParams ["md5"] = getMyInfoParam.Md5;
			var restSharpRequestHelp = new RestSharpRequestHelp(getMyInfoParam.Url,requestMyInfoParams);
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
			
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed)
				{
					//获取并解析返回resultJson获取安全码结果值
					if(response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var result = response.Content;
						var getmyInfoJson = JsonConvert.DeserializeObject<GetMyInfoJson>(result);
						if(getmyInfoJson.statuscode =="1")
						{
							Global.MyInfo = getmyInfoJson.data[0];
						}

					}
				}
				else
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时",ToastLength.Short).Show();
							ProgressDialogUtil.StopProgressDialog();
							return;
						});
				}
				SetPersonInfoShow();
			});
		}
		/// <summary>
		/// 显示个人基本信息
		/// </summary>
		private void SetPersonInfoShow()
		{
			RunOnUiThread (() => {
				//用户名
				tv_userName.Text = Global.MyInfo.UserName;
				//真实姓名
				edit_trueName.Text = string.IsNullOrEmpty (Global.MyInfo.TrueName) ? "" : Global.MyInfo.TrueName;
				//身份证号码
				edit_IdCardNo.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "" : Global.MyInfo.IDNumber;
				if(!string.IsNullOrEmpty(Global.MyInfo.IDNumber))
				{
					edit_IdCardNo.Enabled = false;
				}
					
				//性别
				if (!string.IsNullOrEmpty (Global.MyInfo.Gender) && Global.MyInfo.Gender.Equals ("0"))
					rbtn_male.Checked = true;
				else
					rbtn_female.Checked = true;
				//生日
				edit_birth.Text = !string.IsNullOrEmpty (Global.MyInfo.Age) ?Convert.ToDateTime(Global.MyInfo.Age).ToString("yyyy-MM-dd") :"";
				//电话号码
				edit_phoneNumberOne.Text = !string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne) ? Global.MyInfo.PhoneNumberOne : "";
				if (!string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne))
					edit_phoneNumberOne.Enabled = false;
				//固定电话

				edit_fixedPhone.Text = !string.IsNullOrEmpty (Global.MyInfo.TelePhoneNumber) ? Global.MyInfo.TelePhoneNumber : "";
				//电子邮箱
				edit_email.Text = !string.IsNullOrEmpty (Global.MyInfo.Email) ? Global.MyInfo.Email : "";
				//身份证所在地
				edit_idCardLocation.Text = !string.IsNullOrEmpty (Global.MyInfo.IDAddress) ? Global.MyInfo.IDAddress : "";
				//todo:设置详细地址

			});

		}

		private void SubmitPesonInfo()
		{
			if (!ValidInput ())
				return;

			ProgressDialogUtil.StartProgressDialog(this,"正在保存中,请稍后...");
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
				Toast.MakeText(this,"网络连接超时,请检测网路",ToastLength.Short).Show();
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			var updatePersonInfoParam = new UpdatePersonInfoParam () {
				Uid = Global.MyInfo.UId,TrueName = TrueName,IdCardNo = IdCardNo,Gender = Gender,Birth = Birth,PhoneNumberOne = PhoneNumberOne,FixedPhone = FixedPhone,
				Email = EmailAddress,IdCardLocation = IdCardLocation,TrueAddress = TrueAddress
			};
			//使用restsharpApi方式

			SetRestRequestParams (updatePersonInfoParam);

			var restSharpRequestHelp = new RestSharpRequestHelp(updatePersonInfoParam.Url,requestParams);
			restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取安全码结果值

					var result= response.Content;
					var updatepersoninfoJson = JsonConvert.DeserializeObject<UpdatePersonInfoJson>(result);
					if(updatepersoninfoJson.statuscode =="1")
					{
						RunOnUiThread(()=>{
							
							Toast.MakeText(this,"修改个人资料成功",ToastLength.Short).Show();
							this.Finish();

						});
					}
					else
					{
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,updatepersoninfoJson.message,ToastLength.Short).Show();
							});
					}	
				}
				else
				{
					RunOnUiThread(()=>
						{
							Toast.MakeText(this,"网络连接超时",ToastLength.Short).Show();
						});
				}
				RunOnUiThread(()=>
					{
						ProgressDialogUtil.StopProgressDialog();
					});
			});
		}
		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <returns><c>true</c>, if input was valided, <c>false</c> otherwise.</returns>
		private bool ValidInput()
		{
			UserName = tv_userName.Text;

			TrueName = edit_trueName.Text;

			IdCardNo = edit_IdCardNo.Text;
			if (!string.IsNullOrEmpty (IdCardNo)) {
				if (!EldYoungUtil.IsIdCardNo (IdCardNo)) {
					Toast.MakeText (this, "身份证号码输入不规范", ToastLength.Short).Show ();
					return false;
				}
			}
			Gender = rbtn_male.Checked ? "0" : "1";
			Birth = edit_birth.Text;
			if (Convert.ToDateTime(Birth) >= Convert.ToDateTime(DateTime.Now.ToString ("yyyy-MM-dd"))) {
				Toast.MakeText (this, "生日应小于当前日期", ToastLength.Short).Show ();
				return false;
			}

			PhoneNumberOne = edit_phoneNumberOne.Text;
			if (!string.IsNullOrEmpty (PhoneNumberOne)) {
				if (!EldYoungUtil.IsMobileNo (PhoneNumberOne)) {
					Toast.MakeText (this, "请输入正确手机号", ToastLength.Short).Show ();
					return false;
				}
			}
			FixedPhone = edit_fixedPhone.Text;
			if (!string.IsNullOrEmpty (FixedPhone)) {
				if (!EldYoungUtil.IsFixedPhone (FixedPhone)) {
					Toast.MakeText (this, "请输入正确的邮编", ToastLength.Short).Show ();
					return false;
				}
			}
			EmailAddress = edit_email.Text;
			if (!string.IsNullOrEmpty (EmailAddress)) {
				if (!EldYoungUtil.IsEmail (EmailAddress)) {
					Toast.MakeText (this, "请输入正确的邮箱", ToastLength.Short).Show ();
					return false;
				}
			}
			IdCardLocation = edit_idCardLocation.Text;
			LocationThreeLevel = edit_locationthreelevel.Text;
			LocationDetail = edit_locationdeatil.Text;

			//todo:按照一定规则去拼接真实地址
			TrueAddress = LocationThreeLevel + LocationDetail;

			return true;	
		}

		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="updatePersonInfoParam">Message info parameter.</param>
		private void SetRestRequestParams(UpdatePersonInfoParam updatePersonInfoParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", updatePersonInfoParam.Key);
			else
				requestParams ["key"] = updatePersonInfoParam.Key;

			if (!requestParams.ContainsKey ("eUId"))
				requestParams.Add ("eUId", updatePersonInfoParam.Euid);
			else
				requestParams ["eUId"] = updatePersonInfoParam.Euid;
			
			if (!requestParams.ContainsKey ("eTrueName"))
				requestParams.Add ("eTrueName", updatePersonInfoParam.EtrueName);
			else
				requestParams ["eTrueName"] = updatePersonInfoParam.EtrueName;

			if (!requestParams.ContainsKey ("eNo"))
				requestParams.Add ("eNo", updatePersonInfoParam.EidCardNo);
			else
				requestParams ["eNo"] = updatePersonInfoParam.EidCardNo;
			
			if (!requestParams.ContainsKey ("eSex"))
				requestParams.Add ("eSex", updatePersonInfoParam.Egender);
			else
				requestParams ["eSex"] = updatePersonInfoParam.Egender;


			if (!requestParams.ContainsKey ("eBirthday"))
				requestParams.Add ("eBirthday", updatePersonInfoParam.Ebirth);
			else
				requestParams ["eBirthday"] = updatePersonInfoParam.Ebirth;

			if (!requestParams.ContainsKey ("ePhoneNo"))
				requestParams.Add ("ePhoneNo", updatePersonInfoParam.EphoneNumberOne);
			else
				requestParams ["ePhoneNo"] = updatePersonInfoParam.EphoneNumberOne;

			if (!requestParams.ContainsKey ("eTel"))
				requestParams.Add ("eTel", updatePersonInfoParam.EfixedPhone);
			else
				requestParams ["eTel"] = updatePersonInfoParam.EfixedPhone;
			
			if (!requestParams.ContainsKey ("eEmail"))
				requestParams.Add ("eEmail", updatePersonInfoParam.Eemail);
			else
				requestParams ["eEmail"] = updatePersonInfoParam.Eemail;
			
			if (!requestParams.ContainsKey ("ePersonCardAdress"))
				requestParams.Add ("ePersonCardAdress", updatePersonInfoParam.EidCardLocation);
			else
				requestParams ["ePersonCardAdress"] = updatePersonInfoParam.EidCardLocation;

			if (!requestParams.ContainsKey ("eTrueAdress"))
				requestParams.Add ("eTrueAdress", updatePersonInfoParam.EtrueAddress);
			else
				requestParams ["eTrueAdress"] = updatePersonInfoParam.EtrueAddress;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", updatePersonInfoParam.Md5);
			else
				requestParams ["md5"] = updatePersonInfoParam.Md5;

		}
	}
}

