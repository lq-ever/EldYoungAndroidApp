
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
using Com.Handmark.Pulltorefresh.Library;

using System.Threading.Tasks;
using Android.Support.V4.View;
using Android.Support.V4.App;
using EldYoungAndroidApp.Fragments.MainTab.Health;
using EldYoungAndroidApp.Adapter;
using Android.Views.Animations;

namespace EldYoungAndroidApp.Fragments.MainTab
{
	public class HealthInfoFragment :  Fragment,ViewPager.IOnPageChangeListener,View.IOnClickListener
	{

		private ViewPager healthViewPager;
		private List<Fragment> fragmentsList;
		private ImageView ivBottomLine;
		private Button btnTabmyHealth, btnTabotherHealth;
		private int currentIndex = 0;
	
		MyHealthFrag _myHealthFrag;
		OtherHealthFrag _otherHealthFrag;

		private int bottomLineWidth;
		private int offset = 0;
		private int position_one;
		public  static int num = 2 ; 
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

			var tab_healthView = inflater.Inflate(Resource.Layout.Main_Tab_HealthLayout,container , false);


			return tab_healthView;
		}

		public override void OnResume ()
		{
			base.OnResume ();
		}
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			InitWidth ();
			InitTextView();
			InitViewPager();
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

		private void InitTextView( ) {
			btnTabmyHealth = View.FindViewById<Button>(Resource.Id.btn_tab_myHealth);
			btnTabotherHealth = View.FindViewById<Button>(Resource.Id.btn_tab_otherHealth);

			btnTabmyHealth.SetTextColor(Resources.GetColor(Resource.Color.blue));

			btnTabmyHealth.SetOnClickListener(this);
			btnTabotherHealth.SetOnClickListener(this);
		}

		private void InitViewPager() {
			healthViewPager = (ViewPager) View.FindViewById<ViewPager>(Resource.Id.healthViewpager);
			fragmentsList = new List<Fragment>();

			_myHealthFrag = new MyHealthFrag();
			_otherHealthFrag = new OtherHealthFrag();

			fragmentsList.Add(_myHealthFrag);
			fragmentsList.Add(_otherHealthFrag);

			//关闭预加载，默认一次只加载一个Fragment
			healthViewPager.OffscreenPageLimit =1;
			healthViewPager.Adapter = new ViewFragmentPagerAdapter(fragmentsList,ChildFragmentManager);
			healthViewPager.AddOnPageChangeListener (this);
			healthViewPager.SetCurrentItem (0, true);

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
					btnTabmyHealth.SetTextColor (Resources.GetColor(Resource.Color.blue));
				} 

				btnTabotherHealth.SetTextColor(Resources.GetColor(Resource.Color.black));
				break;
			case 1:
				if (currentIndex == 0) {
					animation = new TranslateAnimation (offset, position_one, 0, 0);
					btnTabotherHealth.SetTextColor (Resources.GetColor (Resource.Color.blue));
				} 
				btnTabmyHealth.SetTextColor (Resources.GetColor(Resource.Color.black));
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
			case Resource.Id.btn_tab_myHealth:
				position = 0;
				SetCurView (position);
				break;
			case Resource.Id.btn_tab_otherHealth:
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
			healthViewPager.SetCurrentItem (position,true);
		}
	}
}

