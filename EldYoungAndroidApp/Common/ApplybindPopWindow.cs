using System;
using Android.Widget;
using Android.App;
using Android.Views;
using Android.Graphics.Drawables;
using Android.Content;
using System.Threading;
using EldYoungAndroidApp.Model.Guardian;
using EldYoungAndroidApp.Model;


namespace EldYoungAndroidApp.Common
{
	//定义解绑委托
	public delegate void ApplyBindEventHandler(SearchGuardianListItem item,string applyMsgContent);
	public class ApplybindPopWindow:PopupWindow
	{
		private View contentView;  
		private Activity activity;
		public ApplyBindEventHandler applyBindEventHandler;
		/// <summary>
		/// Initializes a new instance of the <see cref="EldYoungAndroidApp.Common.ApplybindPopWindow"/> class.
		/// </summary>
		/// <param name="_activity">Activity.</param>
		/// <param name="userId">要申请绑定的用户id</param>
		public ApplybindPopWindow (Activity _activity,SearchGuardianListItem item)
		{
			activity = _activity;
			LayoutInflater inflater = (LayoutInflater) activity.GetSystemService (Context.LayoutInflaterService);
			contentView = inflater.Inflate(Resource.Layout.customapplybinddialog, null);  

			ContentView = contentView;
			Width = 960;
			Height = 690;
			Focusable = true;
			OutsideTouchable = true;
			Update ();
			SetBackgroundDrawable (new ColorDrawable());
			AnimationStyle = Resource.Style.AnimationPreview;
			var btn_Send = contentView.FindViewById<Button> (Resource.Id.btn_Send);
			var txt_ApplyMsgContent = contentView.FindViewById<EditText> (Resource.Id.txt_ApplyMsgContent);
			txt_ApplyMsgContent.Text = string.IsNullOrEmpty(item.Remark)?string.Empty:item.Remark;

			btn_Send.Click += (sender, e) => 
			{
				Dismiss();

				if(applyBindEventHandler!=null)
					applyBindEventHandler(item,txt_ApplyMsgContent.Text);
			};
			var btn_cancel = contentView.FindViewById<Button> (Resource.Id.btn_cancel);
			btn_cancel.Click += (sender, e) => 
			{
				Dismiss();
			};

			DismissEvent += (sender, e) => 
			{
				BackgroundAlpha(1f);
			};
		}

		/// <summary>
		/// 设置弹出背景色
		/// </summary>
		/// <param name="bgAlpha">Background alpha.</param>
		public void BackgroundAlpha(float bgAlpha)  
		{  
			activity.Window.AddFlags (WindowManagerFlags.DimBehind);
			WindowManagerLayoutParams lp = activity.Window.Attributes;
			lp.Alpha = bgAlpha;
			activity.Window.Attributes = lp;
		}  

		public void ShowPopWindow(View parent)
		{
			if (!IsShowing) {
				BackgroundAlpha (0.5f);
				ShowAtLocation (parent, GravityFlags.Center, 0, 0);
			} else
				Dismiss ();
		}
	}
}

