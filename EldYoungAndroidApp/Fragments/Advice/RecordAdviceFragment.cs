
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
using EldYoungAndroidApp.Common;
using Com.Handmark.Pulltorefresh.Library;
using EldYoungAndroidApp.Model;
using EldYoungAndroidApp.Param;
using System.Threading.Tasks;

namespace EldYoungAndroidApp.Fragments.Advice
{
	public class RecordAdviceFragment : BaseFragment,Android.Widget.RadioGroup.IOnCheckedChangeListener,PullToRefreshBase.IOnRefreshListener2
	{
		private RadioGroup radio_advice_Group;
		private RadioButton rbtn_all, rbtn_zixun, rbtn_jianyi, rbtn_tousu, rbtn_other;
		private TextView tv_recordNum;
		private string _adviceType = AdviceType.All.ToString();//默认咨询建议类型

		private AdviceRecordListAdapter adviceRecordListAdapter;
		private PullToRefreshListView lv_recordAdviceRefreshListView;
		private int lastY;
		private ListView actualListView;
		private Dictionary<string,string> requestParams = new Dictionary<string,string> ();

		private AdviceRecordInfoListParam adviceRecordInfoListParam;//请求参数对象

		private int pageIndex =1;//当前页码
		private RestSharpRequestHelp restSharpRequestHelp;
		private int total;//总记录数
		private List<AdviceRecordInfoItem> adviceRecordLists = new List<AdviceRecordInfoItem>();

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
			var recordAdviceView = inflater.Inflate (Resource.Layout.RecordAdviceLayout,container,false);
			return recordAdviceView;
		}
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			//radiogroup
			radio_advice_Group = View.FindViewById<RadioGroup> (Resource.Id.radio_advice_Group);
			radio_advice_Group.SetOnCheckedChangeListener (this);
			//radiobutton
			rbtn_all  = View.FindViewById<RadioButton>(Resource.Id.rbtn_all);
			rbtn_all.Tag = AdviceType.All.ToString ();
			//默认咨询选中
			rbtn_all.Checked = true;
			rbtn_zixun = View.FindViewById<RadioButton> (Resource.Id.rbtn_zixun);
			rbtn_zixun.Tag = AdviceType.Consult.ToString();
			rbtn_jianyi = View.FindViewById<RadioButton> (Resource.Id.rbtn_jianyi);
			rbtn_jianyi.Tag = AdviceType.Suggest.ToString ();
			rbtn_tousu = View.FindViewById<RadioButton> (Resource.Id.rbtn_tousu);
			rbtn_tousu.Tag = AdviceType.Complain.ToString ();
			rbtn_other = View.FindViewById<RadioButton> (Resource.Id.rbtn_other);
			rbtn_other.Tag = AdviceType.Other.ToString();

			//pulltolistview
			lv_recordAdviceRefreshListView = View.FindViewById<PullToRefreshListView> (Resource.Id.lv_recordAdvice);
			actualListView = (ListView)lv_recordAdviceRefreshListView.RefreshableView;

			//设置可以上拉加载。下拉刷新
			lv_recordAdviceRefreshListView.Mode = PullToRefreshBase.PullToRefreshMode.Both;
			//下拉刷新提示文本
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy(true,false).SetPullLabel(GetString(Resource.String.pullDownLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (true,false).SetRefreshingLabel(GetString(Resource.String.pullDownRefreshLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (true, false).SetReleaseLabel (GetString(Resource.String.pullDownReleaseLbl));
			//上拉加载提示文本
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy(false,true).SetPullLabel(GetString(Resource.String.pullUpLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (false, true).SetRefreshingLabel (GetString(Resource.String.pullUpRefreshLbl));
			lv_recordAdviceRefreshListView.GetLoadingLayoutProxy (false, true).SetReleaseLabel (GetString(Resource.String.pullUpReleaseLbl));

			//绑定监听事件
			lv_recordAdviceRefreshListView.SetOnRefreshListener (this);

			//设置adapter		
			adviceRecordListAdapter = new AdviceRecordListAdapter (Activity);
			actualListView.Adapter = adviceRecordListAdapter;
			//初始化view完成
			IsPrepared = true;
			LasyloadData ();
		}
		/// <summary>
		/// radiogroup的选择切换事件
		/// </summary>
		/// <param name="group">Group.</param>
		/// <param name="checkedId">Checked identifier.</param>
		public void OnCheckedChanged (RadioGroup group, int checkedId)
		{
			_adviceType = View.FindViewById<RadioButton> (checkedId).Tag.ToString();
		}

		public override void LasyloadData ()
		{
			if (!IsPrepared || !IsVisible)
				return;
			//第一次进入设置自动刷新view
			lv_recordAdviceRefreshListView.Refreshing = true;
		}

		/// <summary>
		/// 监听下拉刷新事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullDownToRefresh (PullToRefreshBase p0)
		{
			
			Task.Factory.StartNew (() => {
				LoadData();
			});

		}
		/// <summary>
		/// 初始化数据
		/// </summary>
		private void LoadData()
		{
			
		}
		/// <summary>
		/// 监听上拉加载更多事件
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnPullUpToRefresh (PullToRefreshBase p0)
		{
			
			Task.Factory.StartNew (() => {
				//加载更多数据
				LoadMoreData();
			});

		}
		/// <summary>
		/// 获取更多数据
		/// </summary>
		private void LoadMoreData()
		{
			
		}
	}
}

