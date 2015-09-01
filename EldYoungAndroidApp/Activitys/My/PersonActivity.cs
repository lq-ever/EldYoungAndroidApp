
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
using Android.Provider;

using Android.Graphics;
using Java.IO;
using System.IO;
using Android.Graphics.Drawables;

namespace EldYoungAndroidApp.My
{
	[Activity (Theme="@style/MyCustomTheme")]			
	public class PersonActivity : Activity,View.IOnClickListener
	{
		private SelectPicPopWindow picPopWindow;
		private int None =0;
		private int PhotoTake = 1;//拍照
		private int PhotoPick = 2;//选取照片
		private int PhotoResult =3;//处理结果

		private  string IMAGE_UNSPECTFIED = "image/*"; 

		private  string path="/sdcard/eldYoung/Head/";//sd卡路径

		private ImageView img_person_head;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.PersonLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			InitView ();
			// Create your application here
		}
		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
			};



			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "个人信息";



			//头像布局
			var rl_person_head = FindViewById<RelativeLayout> (Resource.Id.rl_person_head);
			rl_person_head.Click += (sender, e) => 
			{
				//todo :调出弹出框,设置使用图库或新拍照方式
				if(picPopWindow ==null)
					picPopWindow = new SelectPicPopWindow(this);
				picPopWindow.ShowPopWindow(FindViewById<LinearLayout>(Resource.Id.ll_person));


			};

			img_person_head = FindViewById<ImageView> (Resource.Id.img_person_head);

			//从Sd中找头像，转换成Bitmap
			Bitmap bt = BitmapFactory.DecodeFile(path +Global.Guid+ "head.jpg");
			if(bt!=null){
				
//				Drawable drawable = new BitmapDrawable(bt);//转换成drawable
//				img_person_head.SetImageDrawable(drawable);


				img_person_head.SetImageBitmap (bt);

			

			}
			else
			{
				//todo本地无照片,调用web服务获取
			}

			//基本资料
			var rl_person_basic = FindViewById<RelativeLayout> (Resource.Id.rl_person_basic);
			rl_person_basic.Click += (sender, e) => 
			{
				StartActivity(typeof(PersonBasicActivity));
				OverridePendingTransition(Android.Resource.Animation.FadeIn,Android.Resource.Animation.FadeOut);
			};
			//登录密码
			var rl_person_loginPwd = FindViewById<RelativeLayout>(Resource.Id.rl_person_loginPwd);
			rl_person_loginPwd.Click += (sender, e) => 
			{
				StartActivity(typeof(UpdatePasswordActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);

			};
			//修改支付密码
			var rl_person_payPwd = FindViewById<RelativeLayout>(Resource.Id.rl_person_payPwd);
			rl_person_payPwd.Click += (sender, e) => 
			{
				StartActivity(typeof(PayPasswordActivity));
				OverridePendingTransition(Android.Resource.Animation.SlideInLeft,Android.Resource.Animation.SlideOutRight);
			};
		}

		public void OnClick (View v)
		{
			picPopWindow.Dismiss ();
			switch (v.Id) {
			case Resource.Id.btn_take_photo://调用照相机拍照
				var intent1 = new Intent (MediaStore.ActionImageCapture);

//				var file = System.IO.Path.Combine (Android.OS.Environment.ExternalStorageDirectory.ToString (), Android.OS.Environment.DirectoryDcim.ToString () + "/head.jpg");
//				var outputFileUri = Android.Net.Uri.Parse (file); 
				var file =  new Java.IO.File(Android.OS.Environment.ExternalStorageDirectory.ToString()+"/"+Android.OS.Environment.DirectoryDcim.ToString() ,"head.jpg");


				//intent1.PutExtra (MediaStore.ExtraOutput, file);
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

		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			if (resultCode == Result.Canceled)
				return;
			if (requestCode == None)
				return;
			
			if (requestCode == PhotoTake) {
				if (resultCode != Result.Ok)
					return;
				//拍照
//				if (data.Extras == null)
//					return;
				Java.IO.File picture = new Java.IO.File(Android.OS.Environment.ExternalStorageDirectory.ToString()+"/"+Android.OS.Environment.DirectoryDcim.ToString() + "/head.jpg");  

//				Bitmap bitmap = (Bitmap)data.Extras.Get("data");  
//
//				FileStream MyFileStream = new FileStream(picture.ToString(), FileMode.Create);  
//				//保存照片  
//				bitmap.Compress(Bitmap.CompressFormat.Jpeg, 100, MyFileStream);  


				if (System.IO.File.Exists(picture.ToString()))  
				{  
					CropPhoto(Android.Net.Uri.FromFile(picture));  
				}  
			}
			if (data == null)
				return;
			if (requestCode == PhotoPick) {//选取照片
				if (resultCode != Result.Ok)
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
					img_person_head.SetImageBitmap (photo);
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
			if (!sdStatus.Equals (Android.OS.Environment.MediaMounted)) {
				//检测sd是否可用
				return;
			}
			FileStream MyFileStream = null;

			Java.IO.File file = new Java.IO.File(path);
			if(!file.Exists())
				file.Mkdirs();// 创建文件夹


			string fileName = path +Global.Guid+ "head.jpg";
			try{
				 MyFileStream = new FileStream(fileName, FileMode.Create);  
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


	}
}

