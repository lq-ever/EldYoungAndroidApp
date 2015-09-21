
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
using CN.Jpush.Android.Api;
using Android.Util;


using EldYoungAndroidApp.Common;
using System.Threading;
using EldYoungAndroidApp.Param;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;

namespace EldYoungAndroidApp
{
	[Activity (Theme="@style/AppTheme")]			
	public class LoginActivity : InstrumentedActivity
	{

		private EditText edit_userName, edit_userPassword;
		private CheckBox cb_autoLogin, cb_passWord;
		private Button btn_login;
		private string userNameValue, passwordValue;
		private ISharedPreferences sp_userinfo;
		private TextView tv_Register;

		private JPushUtil _jpushUtil;

		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
	



		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.LoginLayout);
			_jpushUtil = new JPushUtil (this);
			// Create your application here
			//或得共享实例变量
			sp_userinfo = this.GetSharedPreferences(Global.SHAREDPREFERENCES_USERINFO,FileCreationMode.Private);
		

			//获得实例对象
			edit_userName = FindViewById<EditText>(Resource.Id.edit_UserName);
			edit_userPassword = FindViewById<EditText> (Resource.Id.edit_PassWord);
			cb_passWord = FindViewById<CheckBox> (Resource.Id.cb_Password);
			//cb_autoLogin = FindViewById<CheckBox> (Resource.Id.cb_AutoLogin);
			btn_login = FindViewById<Button> (Resource.Id.btn_Login);
			tv_Register = FindViewById<TextView> (Resource.Id.tv_Register);
			var tv_forgetPwd = FindViewById<TextView> (Resource.Id.tv_forgetPwd);
			var img_eye = FindViewById<ImageView> (Resource.Id.img_eye);
			img_eye.Click += (sender, e) => 
			{
				if(edit_userPassword.InputType == (Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword))
				{
					edit_userPassword.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationVisiblePassword;
					img_eye.SetImageResource(Resource.Drawable.ic_login_eye_selected);
				}
				else if(edit_userPassword.InputType == (Android.Text.InputTypes.ClassText| Android.Text.InputTypes.TextVariationVisiblePassword))
				{
					edit_userPassword.InputType = Android.Text.InputTypes.ClassText|Android.Text.InputTypes.TextVariationPassword;
					img_eye.SetImageResource(Resource.Drawable.ic_login_eye_normal);
				}

			};

			//点击注册
			tv_Register.Click += (sender, e) => 
			{
				StartActivity(typeof(RegisterActivity));

				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			//找回密码
			tv_forgetPwd.Click += (sender, e) => 
			{
				var intent = new Intent(this,typeof(SendSecurityCodeActivity));
				var sendbundle = new Bundle();
				sendbundle.PutString("SendType","FindPwd");
				sendbundle.PutString("PhoneNumber",string.Empty);
				intent.PutExtras(sendbundle);
				StartActivity(intent);
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};

			//如果选择了记住密码，则赋值
			if (sp_userinfo.GetBoolean (Global.login_Password_Check, false)) {
				cb_passWord.Checked = true;
				edit_userName.Text = sp_userinfo.GetString (Global.login_UserName, string.Empty);
				edit_userPassword.Text = sp_userinfo.GetString (Global.login_Password, string.Empty);

//				if (sp_userinfo.GetBoolean (Global.login_AutoLogin_Check, false)) {
//					cb_autoLogin.Checked = true;
//				}
			}

			///自动登录选择框事件
//			cb_autoLogin.CheckedChange += (sender, e) => 
//			{
//				if(cb_autoLogin.Checked)
//					sp_userinfo.Edit().PutBoolean(Global.login_AutoLogin_Check,true).Commit();
//				else
//					sp_userinfo.Edit().PutBoolean(Global.login_AutoLogin_Check,false).Commit();
//			};

			//记住密码选择事件
			cb_passWord.CheckedChange += (sender, e) => 
			{
				if(cb_passWord.Checked)
					sp_userinfo.Edit().PutBoolean(Global.login_Password_Check,true).Commit();
				else
					sp_userinfo.Edit().PutBoolean(Global.login_Password_Check,false).Commit();
			};
            

			//登录按钮事件
			btn_login.Click += (sender, e) => 
			{
				
				Login();
			};
				
		}

		private void Login()
		{
			userNameValue = edit_userName.Text.ToString();
			passwordValue = edit_userPassword.Text.ToString();
			if(string.IsNullOrEmpty(userNameValue)||string.IsNullOrEmpty(passwordValue))
			{
				Toast.MakeText(this,"用户名或密码不能为空,请填写...",ToastLength.Long).Show();	
				return;
			}

			if (!EldYoungUtil.IsValidUserName (userNameValue)) {
				Toast.MakeText (this, "请输入正确规范用户名4-20位，由中英文、数字、下划线组成", ToastLength.Short).Show ();
				return;
			}
			if (!EldYoungUtil.IsPassWord (passwordValue)) {
				Toast.MakeText (this, "请输入正确规范用户名6-20位，建议由字母、数字和符号两种以上组成", ToastLength.Short).Show ();
				return;
			}

			ProgressDialogUtil.StartProgressDialog(this,GetString(Resource.String.loginMsg));
			//检测网络连接
			if(!EldYoungUtil.IsConnected(this))
			{
		        Toast.MakeText(this,"网络连接超时,请检测网络",ToastLength.Short).Show();	
				ProgressDialogUtil.StopProgressDialog();
				return;
			}

			//调用restapi service 登录
			var loginInfoParam = new LoginInfoParam () {
				LoginName = userNameValue,LoginPwd = passwordValue
			};

			//初始化请求参数
			SetRestRequestParams (loginInfoParam);

			var restSharpRequestHelp = new RestSharpRequestHelp(loginInfoParam.Url,requestParams);
			restSharpRequestHelp.ExcuteAsync ((response) => {
				if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
				{
					//获取并解析返回resultJson获取安全码结果值
					var resultJson = response.Content;
					var loginJson = JsonConvert.DeserializeObject<LoginJson>(resultJson);
					if(loginJson.statuscode =="1")
					{
						Global.MyInfo = loginJson.data.Table[0];
						Global.Guid = Global.MyInfo.UId;

						var guidAsAlias = Global.Guid.Replace("-","_");//使用用户guid作为推送别名
						_jpushUtil.SetAlias(guidAsAlias);
						//登录成功，且记住用户密码选中，才记录
						if(cb_passWord.Checked)
						{
							sp_userinfo.Edit().PutString(Global.login_UserName,userNameValue).Commit();
							sp_userinfo.Edit().PutString(Global.login_Password,passwordValue).Commit();
							sp_userinfo.Edit().PutBoolean(Global.login_Password_Check,true).Commit();
						}
						RunOnUiThread (()=>
							{
								//跳转到功能主界面
								var intent = new Intent(this,typeof(MainFragActivity));
								intent.SetFlags(ActivityFlags.ClearTask|ActivityFlags.NewTask);
								StartActivity(intent);						
								this.Finish();
								ProgressDialogUtil.StopProgressDialog();
								Toast.MakeText(this,"登录成功",ToastLength.Short).Show();
								OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);

							});

					}
					else
					{
						RunOnUiThread(()=>
							{
								Toast.MakeText(this,loginJson.message,ToastLength.Short).Show();
								ProgressDialogUtil.StopProgressDialog();
								return;
							});
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

			});


		}


		/// <summary>
		/// 设置参数值
		/// </summary>
		/// <param name="msgInfoParam">Message info parameter.</param>
		private void SetRestRequestParams(LoginInfoParam loginInfoParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", loginInfoParam.Key);
			else
				requestParams ["key"] = loginInfoParam.Key;

			if (!requestParams.ContainsKey ("eaction"))
				requestParams.Add ("eaction", loginInfoParam.Eaction);
			else
				requestParams ["eaction"] = loginInfoParam.Eaction;
			
			if (!requestParams.ContainsKey ("eLoginName"))
				requestParams.Add ("eLoginName", loginInfoParam.EloginName);
			else
				requestParams ["eLoginName"] = loginInfoParam.EloginName;
			if (!requestParams.ContainsKey ("eLoginPwd"))
				requestParams.Add ("eLoginPwd", loginInfoParam.EloginPwd);
			else
				requestParams ["eLoginPwd"] = loginInfoParam.EloginPwd;
		
			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", loginInfoParam.Md5);
			else
				requestParams ["md5"] = loginInfoParam.Md5;

		}




	}
}

