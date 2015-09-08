
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EldYoungAndroidApp.Fragments.MainTab;
using Android.Support.V4.App;
using Android.App;

namespace EldYoungAndroidApp
{
	//@android:style/Theme.Light     @android:style/Theme.Black.NoTitleBar  android:style/Theme.Light.NoTitleBar
	[Activity (Theme= "@style/AppTheme")]			
	public class MainFragActivity : FragmentActivity,View.IOnClickListener
	{
		private HealthInfoFragment _healthInfoFrag;
		private AlarmInfoFragment _alarmInfoFrag;
		private GuardianInfoFragment _guardianInfoFrag;
		private MyInfoFragment _myInfoFrag;
		//底部四个按钮
		private LinearLayout mTabBtnHealth;
		private LinearLayout mTabBtnAlarm;
		private LinearLayout mTabBtnGuardian;
		private LinearLayout mTabBtnMy;

		//使用fragmentManager管理
		private Android.Support.V4.App.FragmentManager fragmentManager;

		private Dialog exitDialog;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);
			// Create your application here
			fragmentManager = SupportFragmentManager;
			InitViews ();
			//设置第一个选中
			SetTabSections (0);

		}
		/// <summary>
		/// 初始化
		/// </summary>
		private void InitViews()
		{
			mTabBtnHealth = FindViewById<LinearLayout> (Resource.Id.id_tab_bottom_health);
			mTabBtnAlarm = FindViewById<LinearLayout> (Resource.Id.id_tab_bottom_alarm);
			mTabBtnGuardian = FindViewById<LinearLayout> (Resource.Id.id_tab_bottom_guardian);
			mTabBtnMy = FindViewById<LinearLayout> (Resource.Id.id_tab_bottom_my);
			//设置触发事件
			mTabBtnHealth.SetOnClickListener (this);
			mTabBtnAlarm.SetOnClickListener (this);
			mTabBtnGuardian.SetOnClickListener (this);
			mTabBtnMy.SetOnClickListener (this);

		}
		/// <summary>
		/// 触发回调函数
		/// </summary>
		/// <param name="v">V.</param>
		public void  OnClick (View v)
		{
			switch (v.Id) {
			case Resource.Id.id_tab_bottom_health:
				SetTabSections (0);
				break;
			case Resource.Id.id_tab_bottom_alarm:
				SetTabSections (1);
				break;
			case Resource.Id.id_tab_bottom_guardian:
				SetTabSections (2);
				break;
			case Resource.Id.id_tab_bottom_my:
				SetTabSections (3);
				break;
			default:
				break;
			}
		}

		private void SetTabSections(int index)
		{
			ResetImageButton ();
			var trasaction = fragmentManager.BeginTransaction ();

			//隐藏掉所有的fragment
			HideFragments(trasaction);
			switch (index) {
			case 0:
				mTabBtnHealth.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_health).SetImageResource (Resource.Drawable.ic_menu_health_selected);
				mTabBtnHealth.FindViewById<TextView>(Resource.Id.tv_menu_bottom_health).SetTextColor(Resources.GetColor(Resource.Color.blue));
				if (_healthInfoFrag == null) {
					_healthInfoFrag = new HealthInfoFragment ();
					trasaction.Add (Resource.Id.id_mainContent, _healthInfoFrag);
				}
				else
					trasaction.Show(_healthInfoFrag);
				break;
			case 1:
				mTabBtnAlarm.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_alarm).SetImageResource (Resource.Drawable.ic_menu_alarm_selected);
				mTabBtnAlarm.FindViewById<TextView>(Resource.Id.tv_menu_bottom_alarm).SetTextColor(Resources.GetColor(Resource.Color.blue));
				if (_alarmInfoFrag == null) {
					_alarmInfoFrag = new AlarmInfoFragment ();
					trasaction.Add (Resource.Id.id_mainContent, _alarmInfoFrag);

				} else
					trasaction.Show (_alarmInfoFrag);
				break;
			case 2:
				mTabBtnGuardian.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_guradian).SetImageResource (Resource.Drawable.ic_menu_guardian_selected);

				mTabBtnGuardian.FindViewById<TextView>(Resource.Id.tv_menu_bottom_guardian).SetTextColor(Resources.GetColor(Resource.Color.blue));
				if (_guardianInfoFrag == null) {
					_guardianInfoFrag = new GuardianInfoFragment ();
					trasaction.Add (Resource.Id.id_mainContent, _guardianInfoFrag);
				} else
					trasaction.Show (_guardianInfoFrag);
				break;
			case 3:
				mTabBtnMy.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_my).SetImageResource (Resource.Drawable.ic_menu_mine_selected);
				mTabBtnMy.FindViewById<TextView>(Resource.Id.tv_menu_bottom_my).SetTextColor(Resources.GetColor(Resource.Color.blue));

				if (_myInfoFrag == null) {
					_myInfoFrag = new MyInfoFragment ();
					trasaction.Add (Resource.Id.id_mainContent, _myInfoFrag);
				} else
					trasaction.Show (_myInfoFrag);
				break;

			}
			trasaction.Commit ();
		}

		/// <summary>
		/// 重置所有选中状态
		/// </summary>
		private void ResetImageButton()
		{
			mTabBtnHealth.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_health).SetImageResource (Resource.Drawable.ic_menu_health_normal);
			mTabBtnHealth.FindViewById<TextView>(Resource.Id.tv_menu_bottom_health).SetTextColor(Resources.GetColor(Resource.Color.lightgray));

			mTabBtnAlarm.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_alarm).SetImageResource (Resource.Drawable.ic_menu_alarm_normal);
			mTabBtnAlarm.FindViewById<TextView>(Resource.Id.tv_menu_bottom_alarm).SetTextColor(Resources.GetColor(Resource.Color.lightgray));

			mTabBtnGuardian.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_guradian).SetImageResource (Resource.Drawable.ic_menu_guardian_normal);
			mTabBtnGuardian.FindViewById<TextView>(Resource.Id.tv_menu_bottom_guardian).SetTextColor(Resources.GetColor(Resource.Color.lightgray));

			mTabBtnMy.FindViewById<ImageButton> (Resource.Id.btn_menu_bottom_my).SetImageResource (Resource.Drawable.ic_menu_mine_normal);
			mTabBtnMy.FindViewById<TextView>(Resource.Id.tv_menu_bottom_my).SetTextColor(Resources.GetColor(Resource.Color.lightgray));


		}

		private void HideFragments(Android.Support.V4.App.FragmentTransaction transaction)
		{
			if (_healthInfoFrag != null)
				transaction.Hide (_healthInfoFrag);
			if (_alarmInfoFrag != null)
				transaction.Hide (_alarmInfoFrag);
			if (_guardianInfoFrag != null)
				transaction.Hide (_guardianInfoFrag);
			if (_myInfoFrag != null)
				transaction.Hide (_myInfoFrag);
		}

		/// <param name="keyCode">The value in event.getKeyCode().</param>
		/// <param name="e">Description of the key event.</param>
		/// <summary>
		/// Called when a key was pressed down and not handled by any of the views 退出提示
		///  inside of the activity.
		/// </summary>
		/// <returns>To be added.</returns>
		public override bool OnKeyDown (Keycode keyCode, KeyEvent e)
		{
			
			if (keyCode == Keycode.Back && e.RepeatCount == 0) {
				var builder = new AlertDialog.Builder (this).SetTitle ("操作提示").SetMessage ("确定要退出吗?");
				builder.SetPositiveButton ("确定", (sender1, e1) => {
					this.Finish();
					
				}).SetNegativeButton ("取消", (sender2, e2) => {
					exitDialog.Dismiss();
				});
				exitDialog= builder.Create ();
				exitDialog.Show();
			}
			return base.OnKeyDown (keyCode, e);
		}

//		/// <summary>
//		/// 退出应用
//		/// </summary>
//		protected override void OnDestroy ()
//		{
//			Intent intent = new Intent ();
//
//			Android.OS.Process.KillProcess (Android.OS.Process.MyPid());
//			base.OnDestroy ();
//		}
	}
}

