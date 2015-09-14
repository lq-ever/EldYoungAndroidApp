
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
using EldYoungAndroidApp.My;
using Android.Graphics;
using EldYoungAndroidApp.Common;
using Android.Provider;



namespace EldYoungAndroidApp.Fragments.MainTab
{
	public class MyInfoFragment : Android.Support.V4.App.Fragment,View.IOnClickListener
	{
		private  string path="/sdcard/eldYoung/Cache/HeadImage/";//sd卡路径
		private ImageView img_head;
		private SelectPicPopWindow picPopWindow;
		private int None =0;
		private int PhotoTake = 1;//拍照
		private int PhotoPick = 2;//选取照片
		private int PhotoResult =3;//处理结果

		private  string IMAGE_UNSPECTFIED = "image/*"; 

	

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

			img_head = View.FindViewById<ImageView> (Resource.Id.img_head);
			//设置头像
			SetPersonImg ();
			//设置界面
			var btn_setting = View.FindViewById<Button> (Resource.Id.btn_setting);
			btn_setting.Click += (sender, e) => 
			{
				Activity.StartActivity(typeof(SetActivity));
				Activity.OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};

			//设置个人账户信息
			var rl_personal = View.FindViewById<RelativeLayout>(Resource.Id.rl_personal);
			rl_personal.Click += (sender, e) => 
			{
//				Activity.StartActivity(typeof(PersonActivity));
//			    Activity.OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
				if(picPopWindow ==null)
					picPopWindow = new SelectPicPopWindow(Activity,this);
				picPopWindow.ShowPopWindow(View.FindViewById<LinearLayout>(Resource.Id.ll_person));
			};

			var tv_nickName = View.FindViewById<TextView> (Resource.Id.tv_nickName);
			var tv_phonenumber = View.FindViewById<TextView> (Resource.Id.tv_phonenumber);
			//设置用户昵称和手机号
			tv_nickName.Text = string.IsNullOrEmpty(Global.MyInfo.UserName)?"未设置昵称":Global.MyInfo.UserName;
			var iphoneNumber = Global.MyInfo.PhoneNumberOne;
			if (!string.IsNullOrEmpty (iphoneNumber)) {
				var midleStr = iphoneNumber.Substring (3, 4);
				var resultStr = iphoneNumber.Replace (midleStr, "****");
				tv_phonenumber.Text = resultStr;
			} else
				tv_phonenumber.Text = "未绑定手机号";
				

			
			//基本资料
			var rl_person_basic = View.FindViewById<RelativeLayout> (Resource.Id.rl_person_basic);
			rl_person_basic.Click += (sender, e) => 
			{
				Activity.StartActivity(typeof(PersonBasicActivity));
				Activity.OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};

			//登录密码
			var rl_person_loginPwd =View. FindViewById<RelativeLayout>(Resource.Id.rl_person_loginPwd);
			rl_person_loginPwd.Click += (sender, e) => 
			{
				var intent = new Intent(Activity,typeof(SendSecurityCodeActivity));
				var sendbundle = new Bundle();
				sendbundle.PutString("SendType","ModifyPwd");//修改密码
				sendbundle.PutString("PhoneNumber",Global.MyInfo.PhoneNumberOne);
				intent.PutExtras(sendbundle);
				Activity.StartActivity(intent);
				Activity.OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);

			};
			//修改支付密码
			var rl_person_payPwd = View.FindViewById<RelativeLayout>(Resource.Id.rl_person_payPwd);
			rl_person_payPwd.Click += (sender, e) => 
			{
				var intent = new Intent(Activity,typeof(SendSecurityCodeActivity));
				var sendbundle = new Bundle();
				sendbundle.PutString("SendType","ModifyPayPwd");//设置支付密码
				sendbundle.PutString("PhoneNumber",Global.MyInfo.PhoneNumberOne);
				intent.PutExtras(sendbundle);
				Activity.StartActivity(intent);
				Activity.OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
			var tv_payPwd = View. FindViewById<TextView> (Resource.Id.tv_payPwd);
			tv_payPwd.Text = string.IsNullOrEmpty (Global.MyInfo.PayPassword) ? "未设置" : "修改";

			//手机绑定
			var rl_person_phoneBind = View.FindViewById<RelativeLayout>(Resource.Id.rl_person_phoneBind);
			rl_person_phoneBind.Click += (sender, e) => 
			{

			};
			var tv_phoneBind = View. FindViewById<TextView> (Resource.Id.tv_phoneBind);
			tv_phoneBind.Text = string.IsNullOrEmpty (Global.MyInfo.PhoneNumberOne) ? "未绑定" : "已绑定";
			//身份认证
			var rl_person_identity = View. FindViewById<RelativeLayout>(Resource.Id.rl_person_identity);
			rl_person_identity.Click += (sender, e) => 
			{

			};
			var tv_identity = View.FindViewById<TextView> (Resource.Id.tv_identity);
			tv_identity.Text = string.IsNullOrEmpty (Global.MyInfo.IDNumber) ? "未认证" : "已认证";


		}
		private void SetPersonImg()
		{
			//从Sd中找头像，转换成Bitmap
			Bitmap bt = BitmapFactory.DecodeFile(path +Global.Guid+ "head.jpg");
			if(bt!=null){

				img_head.SetImageBitmap (bt);
			}
			else
			{
				//本地无照片,调用web服务获取
				Global.imageLoader.DisplayImage(Global.MyInfo.HeadImgReleaseUrl,img_head,Global.Options);
			}
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

					//todo:调用web服务上传头像

					//将图像保存至本地
					SetPicToLocal(photo);//保存在SD卡中
					img_head.SetImageBitmap (photo);
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

		private void SetPicToLocal(Bitmap mBitmap) 
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
			string fileName = path +Global.Guid+ "head.jpg";
			try{
				MyFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create);  
				//保存照片  
				mBitmap.Compress(Bitmap.CompressFormat.Jpeg, 100, MyFileStream);  
			}
			catch(Java.IO.FileNotFoundException e) {
				e.PrintStackTrace ();
			}
			finally {
				MyFileStream.Flush ();
				MyFileStream.Close ();
			}	

		}

		public override void OnResume ()
		{
			SetPersonImg ();
			base.OnResume ();
		}
	}
}

