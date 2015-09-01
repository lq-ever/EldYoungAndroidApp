
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
using Android.Support.V4.View;
using EldYoungAndroidApp.Activitys.Guardian;
using EldYoungAndroidApp.Fragments.MainTab.Guardian;
using EldYoungAndroidApp.Adapter;
using Android.Views.Animations;
using Android.Graphics.Drawables;
using EldYoungAndroidApp.Common;

namespace EldYoungAndroidApp.Fragments.MainTab
{
	public class GuardianInfoFragment :  Fragment,ViewPager.IOnPageChangeListener,View.IOnClickListener
	{
		private ViewPager guardianViewPager;
		private List<Fragment> fragmentsList;
		private ImageView ivBottomLine;
		private int bottomLineWidth;
		private Button btnTabmyGuardian, btnTabotherGuardian;
		private Button btn_bindGuardian;
		private LinearLayout ll_actionBar;
		private int currentIndex = 0;


		MyGuardianFrag _myGuardianFrag;
		OtherGuardianFrag _otherGuardianFrag;

		private int offset = 0;
		private int position_one;
		public  static int num = 2 ; 

		private PopupWindow guardianPopupWindow;
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
			var tab_guardianView = inflater.Inflate (Resource.Layout.Main_Tab_GuardianLayout, container, false);
			return tab_guardianView;

		}
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			InitWidth ();
			InitView ();


		}
		private void InitWidth() {
			ivBottomLine = View.FindViewById<ImageView>(Resource.Id.iv_bottom_line);
			bottomLineWidth = ivBottomLine.LayoutParameters.Width;
			DisplayMetrics dm = new DisplayMetrics();

			Activity.WindowManager.DefaultDisplay.GetMetrics(dm);
			int screenW = dm.WidthPixels;
			offset = (int) ((screenW / num - bottomLineWidth) / 2);
			int avg = (int) (screenW / num);

			position_one = avg + offset;


		}
		private void InitView( ) {
			
			btnTabmyGuardian = View.FindViewById<Button>(Resource.Id.btn_tab_myGuardian);
			btnTabotherGuardian = View.FindViewById<Button>(Resource.Id.btn_tab_otherGuardian);
			btnTabmyGuardian.SetTextColor(Resources.GetColor(Resource.Color.blue));

			btnTabmyGuardian.SetOnClickListener(this);
			btnTabotherGuardian.SetOnClickListener(this);

			//设置viewpager
			guardianViewPager = (ViewPager) View.FindViewById<ViewPager>(Resource.Id.guardianViewpager);
			fragmentsList = new List<Fragment>();

			_myGuardianFrag = new MyGuardianFrag();
			_otherGuardianFrag = new OtherGuardianFrag();

			fragmentsList.Add(_myGuardianFrag);
			fragmentsList.Add(_otherGuardianFrag);

			//关闭预加载，默认一次只加载一个Fragment
			guardianViewPager.OffscreenPageLimit =1;

			guardianViewPager.Adapter = new ViewFragmentPagerAdapter(fragmentsList,ChildFragmentManager);

			guardianViewPager.AddOnPageChangeListener (this);
			guardianViewPager.SetCurrentItem (0, true);

			ll_actionBar = View.FindViewById<LinearLayout> (Resource.Id.ll_actionBar);
			//弹出popupwindow，绑定监护人和监护人申请
			btn_bindGuardian = View.FindViewById<Button> (Resource.Id.btn_BindGuardian);
			btn_bindGuardian.Click += (sender, e) => 
			{
				BackgroundAlpha(0.5f);
				if(guardianPopupWindow!=null)
					guardianPopupWindow.ShowAsDropDown(ll_actionBar,-100,1,GravityFlags.Right|GravityFlags.Top);

				else
				{
					InitPopupWindow();
				}
			};

		}

		private void InitPopupWindow()
		{
			LayoutInflater inflater = LayoutInflater.From(Activity);
			//var popView = inflater.inflate(R.layout.popupwindow_content, null);
			var popView = inflater.Inflate(Resource.Layout.GuardianPopupWindowLayout,null);

			var ll_bindGuardian = popView.FindViewById<LinearLayout> (Resource.Id.ll_bindGuardian);
			var ll_applyGuardian = popView.FindViewById<LinearLayout> (Resource.Id.ll_ApplyGuardian);
			//guardianPopupWindow = new PopupWindow (popView,Android.Widget.LinearLayout.LayoutParams.WrapContent,Android.Widget.LinearLayout.LayoutParams.WrapContent);
			guardianPopupWindow = new PopupWindow (popView,600,290);
			var m = Resources.DisplayMetrics.Density;
			guardianPopupWindow.OutsideTouchable = true;
			guardianPopupWindow.Focusable = true;
			guardianPopupWindow.SetBackgroundDrawable(new ColorDrawable());  

			guardianPopupWindow.AnimationStyle = Resource.Style.AnimationPreview;
		
			guardianPopupWindow.ShowAsDropDown(ll_actionBar,-30,1,GravityFlags.Right|GravityFlags.Top);

			guardianPopupWindow.DismissEvent += (sender, e) => 
			{
				BackgroundAlpha(1f);
			};

			ll_bindGuardian.Click+= (sender, e) => 
			{
				//绑定监护人
				guardianPopupWindow.Dismiss();
				Activity.StartActivity(typeof(BindGuardianActivity));
			};
			ll_applyGuardian.Click += (sender, e) => 
			{
				//监护人申请
				guardianPopupWindow.Dismiss();
				Activity.StartActivity(typeof(GuardianApplyActivity));
			};
		}

	

		/// <summary>
		/// 设置背景透明度
		/// </summary>
		/// <param name="bgAlpha">Background alpha.</param>
		public void BackgroundAlpha(float bgAlpha)  
		{  
			Activity.Window.AddFlags (WindowManagerFlags.DimBehind);
			WindowManagerLayoutParams lp = Activity.Window.Attributes;
			lp.Alpha = bgAlpha;
			Activity.Window.Attributes = lp;
		}  

		#region 实现IOnPageChangeListener接口
		public  void  OnPageScrollStateChanged (int state)
		{

		}

		public  void OnPageScrolled(int arg0, float arg1, int arg2) {

		}

		/// <summary>
		/// 新的页面被选中调用
		/// </summary>
		/// <param name="position">Position.</param>
		public void OnPageSelected(int position)
		{
			Animation animation = null;
			switch (position)
			{
			case 0:
				if (currentIndex == 1) {
					animation = new TranslateAnimation (position_one, offset, 0, 0);
					btnTabmyGuardian.SetTextColor (Resources.GetColor(Resource.Color.blue));
				} 

				btnTabotherGuardian.SetTextColor(Resources.GetColor(Resource.Color.darkgray));
				break;
			case 1:
				if (currentIndex == 0) {
					animation = new TranslateAnimation (offset, position_one, 0, 0);
					btnTabotherGuardian.SetTextColor (Resources.GetColor (Resource.Color.blue));
				} 
				btnTabmyGuardian.SetTextColor (Resources.GetColor(Resource.Color.darkgray));
				break;
			}
			animation.FillAfter = true;
			animation.Duration = 300;
			ivBottomLine.StartAnimation (animation);
			currentIndex = position;
		}
		#endregion
		#region 重写IOnClickListener接口
		/// <summary>
		/// 触发回调函数
		/// </summary>
		/// <param name="v">V.</param>
		public void  OnClick (View v)
		{
			int position = 0;
			switch (v.Id) {
			case Resource.Id.btn_tab_myGuardian:
				position = 0;
				SetCurView (position);
				break;
			case Resource.Id.btn_tab_otherGuardian:
				position = 1;
				SetCurView (position);
				break;
			default:
				break;
			}
			currentIndex = position;
		}
		#endregion

		/// <summary>
		/// 设置当前页
		/// </summary>
		/// <param name="position">Position.</param>
		private void SetCurView(int position)
		{
			if (position < 0 || position >= fragmentsList.Count)
				return;
			guardianViewPager.SetCurrentItem (position,true);
		}
	}
}

