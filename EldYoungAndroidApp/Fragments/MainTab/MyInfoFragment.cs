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
using Android.App;

using Android.Graphics;
using EldYoungAndroidApp.Common;
using Android.Provider;
using EldYoungAndroidApp.Param;
using Java.IO;
using Newtonsoft.Json;
using EldYoungAndroidApp.Json;
using System.IO;



namespace EldYoungAndroidApp.Fragments.MainTab
{
	public class MyInfoFragment : Android.Support.V4.App.Fragment,View.IOnClickListener
	{
		private TextView tv_nickName, tv_phonenumber;
		//private  string path="/sdcard/eldYoung/Cache/HeadImage/";//sd卡路径
		private string path = Android.OS.Environment.ExternalStorageDirectory.ToString()+"/"+"eldyoung/Cache/HeadImage/";
		private ImageView img_head;
		private SelectPicPopWindow picPopWindow;
		private int None =0;
		private int PhotoTake = 1;//拍照
		private int PhotoPick = 2;//选取照片
		private int PhotoResult =3;//处理结果

		private  string IMAGE_UNSPECTFIED = "image/*"; 
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();
	

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
			var tab_MyView = inflater.Inflate (Resource.Layout.Main_Tab_MyLayout, container, false);
			return tab_MyView;
		}
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);


			//设置操作
			var img_setting = View.FindViewById<ImageView> (Resource.Id.img_setting);
			img_setting.Click += (sender, e) => 
			{
				Activity.StartActivity(typeof(SetActivity));
				Activity.OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};
			img_head = View.FindViewById<ImageView> (Resource.Id.img_head);

			//设置个人头像信息
			img_head.Click += (sender, e) => 
			{
				if(picPopWindow ==null)
					picPopWindow = new SelectPicPopWindow(Activity,this);
				picPopWindow.ShowPopWindow(View.FindViewById<LinearLayout>(Resource.Id.ll_person));
			};

			tv_nickName = View.FindViewById<TextView> (Resource.Id.tv_nickName);
			tv_phonenumber = View.FindViewById<TextView> (Resource.Id.tv_phonenumber);

			//个人资料
			var rl_person_basic = View.FindViewById<RelativeLayout> (Resource.Id.rl_person_basic);
			rl_person_basic.Click += (sender, e) => 
			{
				
				Activity.StartActivity(typeof(PersonInfoActivity));
				Activity.OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//账户安全
			var rl_person_accountSecurity = View.FindViewById<RelativeLayout> (Resource.Id.rl_person_accountSecurity);
			rl_person_accountSecurity.Click += (sender, e) => 
			{
				Activity.StartActivity(typeof(AccountSecurityActivity));
				Activity.OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//投诉建议
			var rl_person_advice = View.FindViewById<RelativeLayout> (Resource.Id.rl_person_advice);
			rl_person_advice.Click += (sender, e) => 
			{
				Activity.StartActivity(typeof(AdviceActivity));
				Activity.OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			//拨打电话
			var tv_customPhone = View.FindViewById<TextView>(Resource.Id.tv_customPhone);
			var customPhoneNum = tv_customPhone.Text;//客服电话
			var img_callCustom = View.FindViewById<ImageView> (Resource.Id.img_callCustom);
			img_callCustom.Click += (sender, e) => 
			{
				Intent intent=new Intent(Intent.ActionCall,Android.Net.Uri.Parse ("tel:"+customPhoneNum));
				Activity.StartActivity(intent);
			};

			SetShowInfo ();
		}

		private void SetShowInfo()
		{
			//设置用户昵称和手机号
			tv_nickName.Text = string.IsNullOrEmpty(Global.MyInfo.UserName)?"未设置昵称":Global.MyInfo.UserName;
			var iphoneNumber = Global.MyInfo.PhoneNumberOne;
			if (!string.IsNullOrEmpty (iphoneNumber)) {
				var midleStr = iphoneNumber.Substring (3, 4);
				var resultStr = iphoneNumber.Replace (midleStr, "****");
				tv_phonenumber.Text = resultStr;
			} else
				tv_phonenumber.Text = "未绑定手机号";
			
			//从Sd中找头像，转换成Bitmap
//
//			Bitmap bt = BitmapFactory.DecodeFile(path + "myHead.jpg");
//			if(bt!=null){
//
//				img_head.SetImageBitmap (bt);
//			}
//			else
//			{
//				//调用web服务获取
//				Global.imageLoader.DisplayImage(Global.MyInfo.HeadImgReleaseUrl,img_head,Global.Options);
//			}
//			//调用web服务获取
			Global.imageLoader.DisplayImage(Global.MyInfo.HeadImgReleaseUrl,img_head,Global.Options);
		}

		public void OnClick (View v)
		{
			picPopWindow.Dismiss ();
			switch (v.Id) {
			case Resource.Id.btn_take_photo://调用照相机拍照
				var intent1 = new Intent (MediaStore.ActionImageCapture);
				var file =  new Java.IO.File(Android.OS.Environment.ExternalStorageDirectory.ToString()+"/"+Android.OS.Environment.DirectoryDcim.ToString() ,"head.jpg");
				intent1.PutExtra (MediaStore.ExtraOutput,Android.Net.Uri.FromFile(file));

				StartActivityForResult (intent1, PhotoTake);
				break;
			case Resource.Id.btn_pick_photo://从相册里取照片
				var intent2 = new Intent (Intent.ActionPick, null);
				intent2.SetDataAndType (MediaStore.Images.Media.ExternalContentUri, IMAGE_UNSPECTFIED);
				StartActivityForResult (intent2, PhotoPick);
				break;
			default:
				break;
			}
		}

		public override void OnActivityResult (int requestCode, int resultCode, Intent data)
		{
			if (resultCode == (int)Result.Canceled)
				return;
			if (requestCode == None)
				return;

			if (requestCode == PhotoTake) {
				if (resultCode !=(int) Result.Ok)
					return;
				//拍照
				Java.IO.File picture = new Java.IO.File(Android.OS.Environment.ExternalStorageDirectory.ToString()+"/"+Android.OS.Environment.DirectoryDcim.ToString() + "/head.jpg");  

				if (System.IO.File.Exists(picture.ToString()))  
				{  
					CropPhoto(Android.Net.Uri.FromFile(picture));  
				}  
			}
			if (data == null)
				return;
			if (requestCode == PhotoPick) {//选取照片
				if (resultCode != (int)Result.Ok)
					return;
				CropPhoto(data.Data);  
			}
			//处理结果
			if (requestCode == PhotoResult) {

				Bundle extras = data.Extras;  
				if (extras != null)  
				{  
					Bitmap photo = (Bitmap)extras.GetParcelable("data");  
					img_head.SetImageBitmap (photo);
					//将图像保存至本地和服务器上
					SetPicToLocalAndServer(photo);//保存在SD卡中
				}  
			}

			
			base.OnActivityResult (requestCode, resultCode, data);
		}
			
		//缩放 - 压缩
		public void CropPhoto(Android.Net.Uri uri)  
		{  
			var intent = new Intent("com.android.camera.action.CROP");  
			intent.SetDataAndType(uri, IMAGE_UNSPECTFIED);  

			intent.PutExtra("crop", true);  
			//// aspectX aspectY 是宽高的比例   
			intent.PutExtra("aspectX", 1);  
			intent.PutExtra("aspectY", 1);  
			//// outputX outputY 是裁剪图片宽高
			intent.PutExtra("outputX", 200);  
			intent.PutExtra("outputY", 200);  
			intent.PutExtra("return-data", true);  
			StartActivityForResult(intent, PhotoResult);  

		}

		private void SetPicToLocalAndServer(Bitmap mBitmap) 
		{

			var sdStatus = Android.OS.Environment.ExternalStorageState;
			//检测sd是否可用
			if (!sdStatus.Equals (Android.OS.Environment.MediaMounted)) {
				return;
			}
			System.IO.FileStream MyFileStream = null;

			Java.IO.File file = new Java.IO.File(path);
			if(!file.Exists())
				file.Mkdirs();// 创建文件夹
			string fileName = path + "myHead.jpg";
			try{
				MyFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.OpenOrCreate);  
				//保存照片  
				mBitmap.Compress(Bitmap.CompressFormat.Jpeg, 100, MyFileStream); 

				byte[] buffer = new byte[MyFileStream.Length];
				// 设置当前流的位置为流的开始
				MyFileStream.Seek(0, SeekOrigin.Begin);
				MyFileStream.Read(buffer, 0, buffer.Length);


				var  headimgStr = Convert.ToBase64String(buffer);
				//调用restapi提交头像
				var headImgPostParam = new HeadImgPostParam () {
					UId = Global.MyInfo.UId,ImageStr = headimgStr
				};
				SetRestRequestParams (headImgPostParam);
				var restSharpRequestHelp = new RestSharpRequestHelp(headImgPostParam.Url,requestParams);
				restSharpRequestHelp.ExcuteAsync ((RestSharp.IRestResponse response) => {
					if(response.ResponseStatus == RestSharp.ResponseStatus.Completed && response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						//获取并解析返回resultJson获取安全码结果值
						var result = response.Content;
						var headimgJson = JsonConvert.DeserializeObject<HeadImgJson>(result);
						if(headimgJson.statuscode == "1")
							Global.MyInfo.HeadImgUrl = headimgJson.data[0].HeadImgUrl;
						else
						{
							Activity.RunOnUiThread(()=>
								{
									Toast.MakeText(Activity,"头像上传失败",ToastLength.Short).Show();
								});
						}

					}
	
				});
			}
			catch(Java.IO.FileNotFoundException e) {
				e.PrintStackTrace ();
			}
			finally {
				MyFileStream.Flush ();
				MyFileStream.Close ();
			}	

		}

		/// <summary>
		/// Sets the rest request parameters.
		/// </summary>
		/// <param name="registerInfoParam">Register info parameter.</param>
		private void SetRestRequestParams(HeadImgPostParam headImgPostParam)
		{
			if (!requestParams.ContainsKey ("key"))
				requestParams.Add ("key", headImgPostParam.Key);
			else
				requestParams ["key"] = headImgPostParam.Key;

			if (!requestParams.ContainsKey ("eguid"))
				requestParams.Add ("eguid", headImgPostParam.Euid);
			else
				requestParams ["eguid"] = headImgPostParam.Euid;

			if (!requestParams.ContainsKey ("eimgstr"))
				requestParams.Add ("eimgstr", headImgPostParam.EimageStr);
			else
				requestParams ["eimgstr"] = headImgPostParam.EimageStr;

			if (!requestParams.ContainsKey ("md5"))
				requestParams.Add ("md5", headImgPostParam.Md5);
			else
				requestParams ["md5"] = headImgPostParam.Md5;

		}

	}
}

