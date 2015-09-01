
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
using Android.Support.V4.View;
using Android.Views.Animations;
using EldYoungAndroidApp.Fragments.MainTab.Alarm;
using EldYoungAndroidApp.Adapter;
using Android.Support.V4.App;




namespace EldYoungAndroidApp.Fragments.MainTab
{
	public class AlarmInfoFragment : Fragment,ViewPager.IOnPageChangeListener,View.IOnClickListener
	{
		
		private ViewPager alarmViewPager;
		private List<Fragment> fragmentsList;
		private ImageView ivBottomLine;
		private TextView tvTabmyAlarm, tvTabotherAlarm;

		private int currentIndex = 0;
		private int bottomLineWidth;
		private int offset = 0;
		private int position_one;
		public  static int num = 2 ; 
		MyAlarmFrag _myAlarmFrag;
		OtherAlarmFrag _otherAlarmFrag;

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
			var tab_alarmView = inflater.Inflate (Resource.Layout.Main_Tab_AlarmLayout, container, false);
			return tab_alarmView;

		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			InitWidth();
			InitTextView();
			InitViewPager();
			TranslateAnimation animation = new TranslateAnimation(position_one, offset, 0, 0){FillAfter = true,Duration = 300};
			ivBottomLine.StartAnimation(animation);
		}

		private void InitTextView( ) {
			tvTabmyAlarm = View.FindViewById<Button>(Resource.Id.tv_tab_myAlarm);
			tvTabotherAlarm = View.FindViewById<Button>(Resource.Id.tv_tab_otherAlarm);
			tvTabmyAlarm.SetTextColor(Resources.GetColor(Resource.Color.blue));

			tvTabmyAlarm.SetOnClickListener(this);
			tvTabotherAlarm.SetOnClickListener(this);
		}

		private void InitViewPager() {
			alarmViewPager = (ViewPager) View.FindViewById<ViewPager>(Resource.Id.alarmViewPager);
			fragmentsList = new List<Fragment>();

			_myAlarmFrag = new MyAlarmFrag();
			_otherAlarmFrag = new OtherAlarmFrag();

			fragmentsList.Add(_myAlarmFrag);
			fragmentsList.Add(_otherAlarmFrag);

			//关闭预加载，默认一次只加载一个Fragment
			alarmViewPager.OffscreenPageLimit =1;

			alarmViewPager.Adapter = new ViewFragmentPagerAdapter(fragmentsList,ChildFragmentManager);
			alarmViewPager.AddOnPageChangeListener (this);
			alarmViewPager.SetCurrentItem (0, true);

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
					tvTabmyAlarm.SetTextColor (Resources.GetColor (Resource.Color.blue));
				} 
					
				tvTabotherAlarm.SetTextColor (Resources.GetColor (Resource.Color.darkgray));

					break;
			case 1:
				if (currentIndex == 0) {
					animation = new TranslateAnimation (offset, position_one, 0, 0);
					tvTabotherAlarm.SetTextColor (Resources.GetColor (Resource.Color.blue));
				} 
				tvTabmyAlarm.SetTextColor (Resources.GetColor(Resource.Color.darkgray));
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
			case Resource.Id.tv_tab_myAlarm:
				position = 0;
				SetCurView (position);
				break;
			case Resource.Id.tv_tab_otherAlarm:
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
			alarmViewPager.SetCurrentItem (position,true);
		}
	}
}

