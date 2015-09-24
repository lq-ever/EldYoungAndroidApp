
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

namespace EldYoungAndroidApp.Fragments.Advice
{
	public class WriteAdviceFragment : BaseFragment,Android.Widget.RadioGroup.IOnCheckedChangeListener
	{
		private RadioGroup radio_advice_Group;
		private RadioButton rbtn_zixun, rbtn_jianyi, rbtn_tousu, rbtn_other;
		private EditText edit_advice_title, edit_advice_content;
		private string _adviceType = AdviceType.Consult.ToString();
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
			var WriteAdviceView = inflater.Inflate (Resource.Layout.WriteAdviceLayout,container,false);
			return WriteAdviceView;
		}

		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);

			//radiogroup
			radio_advice_Group = View.FindViewById<RadioGroup> (Resource.Id.radio_advice_Group);
			radio_advice_Group.SetOnCheckedChangeListener (this);
			//radiobutton
			rbtn_zixun = View.FindViewById<RadioButton> (Resource.Id.rbtn_zixun);
			rbtn_zixun.Tag = AdviceType.Consult.ToString();
			//默认咨询选中
			rbtn_zixun.Checked = true;
			rbtn_jianyi = View.FindViewById<RadioButton> (Resource.Id.rbtn_jianyi);
			rbtn_jianyi.Tag = AdviceType.Suggest.ToString ();
			rbtn_tousu = View.FindViewById<RadioButton> (Resource.Id.rbtn_tousu);
			rbtn_tousu.Tag = AdviceType.Complain.ToString ();
			rbtn_other = View.FindViewById<RadioButton> (Resource.Id.rbtn_other);
			rbtn_other.Tag = AdviceType.Other.ToString();

			edit_advice_title = View.FindViewById<EditText> (Resource.Id.edit_advice_title);
			edit_advice_content = View.FindViewById<EditText> (Resource.Id.edit_advice_content);


			//初始化view完成
			IsPrepared = true;
			LasyloadData ();
		}

		public override void LasyloadData ()
		{
			if (!IsPrepared || !IsVisible)
				return;
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
	}
}

