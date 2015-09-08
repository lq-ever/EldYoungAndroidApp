
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
using EldYoungAndroidApp.Model.Health;
using Newtonsoft.Json;
using System.Threading.Tasks;
using EldYoungAndroidApp.Common;

namespace EldYoungAndroidApp
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class HealthDetailInfoActivity : Activity
	{
		private HealthInfoItem healthInfoItem;
		private TextView tv_TestTime,tv_BMI_Show,tv_Height,tv_Weight,tv_BMI,tv_BMI_High,tv_BMI_Low,tv_BloodGlucose_Show,tv_BloodGlucose,tv_BloodGlucose_High,tv_BloodGlucose_Low,tv_BloodOxygen_Show,
		tv_BloodOxygenParaOne,tv_BloodOxygenParaOne_High,tv_BloodOxygenParaOne_Low,tv_HeartRate_Show,tv_HeartRate,tv_HeartRate_High,tv_HeartRate_Low,tv_BreathCapacity_Show,tv_BreathCapacity,tv_BreathCapacity_High,
		tv_BreathCapacity_Low,tv_BodyTemperature_Show,tv_BodyTemperature,tv_BodyTemperature_High,tv_BodyTemperature_Low,tv_BloodPressure_Show,tv_BloodPressureParaTwo,tv_BloodPressureParaOne,tv_BloodLipid_Show,tv_BloodLipidParaOne,
		tv_BloodLipidParaOne_High,tv_BloodLipidParaOne_Low,tv_BloodLipidParaFour,tv_BloodLipidParaFour_High,tv_BloodLipidParaFour_Low,tv_BloodLipidParaTwo,tv_BloodLipidParaTwo_High,tv_BloodLipidParaTwo_Low,
		tv_BloodLipidParaThree,tv_BloodLipidParaThree_High,tv_BloodLipidParaThree_Low,tv_UrineRoutine_Show,tv_UrineRoutinePH,tv_UrineRoutinePH_High,tv_UrineRoutinePH_Low,tv_UrineRoutineSG,tv_UrineRoutineSG_High,tv_UrineRoutineSG_Low,
		tv_UrineRoutineURO,tv_UrineRoutineURO_High,tv_UrineRoutineURO_Low,tv_UrineRoutineWBC,tv_UrineRoutineBLO,tv_UrineRoutineKET,tv_UrineRoutineGLU,tv_UrineRoutineRPO,tv_UrineRoutineBIL;

		private ImageView img_BMI_Arraw, img_BloodGlucose_Arraw, img_BloodOxygenParaOne_Arraw, img_HeartRate_Arraw, img_BreathCapacity_Arraw, img_BodyTemperature_Arraw, img_BloodLipidParaOne_Arraw, img_BloodLipidParaFour_Arraw, img_BloodLipidParaTwo_Arraw,
			img_BloodLipidParaThree_Arraw, img_UrineRoutinePH_Arraw, img_UrineRoutineSG_Arraw, img_UrineRoutineURO_Arraw;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.HealthDetailInfoLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}
		private void InitView()
		{
			ProgressDialogUtil.StartProgressDialog(this,"正在加载体检详细信息...");
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
			};

			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "体检详情";
			//获取列表传递详细数据
			var _healthItemInfoJson = Intent.GetStringExtra ("healthInfo");
			healthInfoItem = JsonConvert.DeserializeObject<HealthInfoItem> (_healthItemInfoJson);

			tv_TestTime = FindViewById<TextView> (Resource.Id.tv_TestTime);
			tv_BMI_Show = FindViewById<TextView> (Resource.Id.tv_BMI_Show);
			tv_Height = FindViewById<TextView> (Resource.Id.tv_Height);
			tv_Weight = FindViewById<TextView> (Resource.Id.tv_Weight);
			tv_BMI = FindViewById<TextView> (Resource.Id.tv_BMI);
			tv_BMI_High = FindViewById<TextView> (Resource.Id.tv_BMI_High);
			tv_BMI_Low = FindViewById<TextView> (Resource.Id.tv_BMI_Low);
			tv_BloodGlucose_Show = FindViewById<TextView> (Resource.Id.tv_BloodGlucose_Show);
			tv_BloodGlucose = FindViewById<TextView> (Resource.Id.tv_BloodGlucose);
			tv_BloodGlucose_High = FindViewById<TextView> (Resource.Id.tv_BloodGlucose_High);
			tv_BloodGlucose_Low = FindViewById<TextView> (Resource.Id.tv_BloodGlucose_Low);
			tv_BloodOxygen_Show = FindViewById<TextView> (Resource.Id.tv_BloodOxygen_Show);
			tv_BloodOxygenParaOne = FindViewById<TextView> (Resource.Id.tv_BloodOxygenParaOne);
			tv_BloodOxygenParaOne_High = FindViewById<TextView> (Resource.Id.tv_BloodOxygenParaOne_High);
			tv_BloodOxygenParaOne_Low = FindViewById<TextView> (Resource.Id.tv_BloodOxygenParaOne_Low);
			tv_HeartRate_Show = FindViewById<TextView> (Resource.Id.tv_HeartRate_Show);
			tv_HeartRate = FindViewById<TextView> (Resource.Id.tv_HeartRate);
			tv_HeartRate_High = FindViewById<TextView> (Resource.Id.tv_HeartRate_High);
			tv_HeartRate_Low = FindViewById<TextView> (Resource.Id.tv_HeartRate_Low);
			tv_BreathCapacity_Show = FindViewById<TextView> (Resource.Id.tv_BreathCapacity_Show);

			tv_BreathCapacity = FindViewById<TextView> (Resource.Id.tv_BreathCapacity);
			tv_BreathCapacity_High = FindViewById<TextView> (Resource.Id.tv_BreathCapacity_High);
			tv_BreathCapacity_Low = FindViewById<TextView> (Resource.Id.tv_BreathCapacity_Low);
			tv_BodyTemperature_Show = FindViewById<TextView> (Resource.Id.tv_BodyTemperature_Show);
			tv_BodyTemperature = FindViewById<TextView> (Resource.Id.tv_BodyTemperature);
			tv_BodyTemperature_High = FindViewById<TextView> (Resource.Id.tv_BodyTemperature_High);
			tv_BodyTemperature_Low = FindViewById<TextView> (Resource.Id.tv_BodyTemperature_Low);
			tv_BloodPressure_Show = FindViewById<TextView> (Resource.Id.tv_BloodPressure_Show);
			tv_BloodPressureParaTwo = FindViewById<TextView> (Resource.Id.tv_BloodPressureParaTwo);
			tv_BloodPressureParaOne = FindViewById<TextView> (Resource.Id.tv_BloodPressureParaOne);

			tv_BloodLipid_Show = FindViewById<TextView> (Resource.Id.tv_BloodLipid_Show);
			tv_BloodLipidParaOne = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaOne);
			tv_BloodLipidParaOne_High = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaOne_High);
			tv_BloodLipidParaOne_Low = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaOne_Low);
			tv_BloodLipidParaFour = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaFour);
			tv_BloodLipidParaFour_High = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaFour_High);
			tv_BloodLipidParaFour_Low = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaFour_Low);
			tv_BloodLipidParaTwo = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaTwo);
			tv_BloodLipidParaTwo_High = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaTwo_High);
			tv_BloodLipidParaTwo_Low = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaTwo_Low);
			tv_BloodLipidParaThree = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaThree);
			tv_BloodLipidParaThree_High = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaThree_High);
			tv_BloodLipidParaThree_Low = FindViewById<TextView> (Resource.Id.tv_BloodLipidParaThree_Low);

			tv_UrineRoutine_Show = FindViewById<TextView> (Resource.Id.tv_UrineRoutine_Show);
			tv_UrineRoutinePH = FindViewById<TextView> (Resource.Id.tv_UrineRoutinePH);
			tv_UrineRoutinePH_High = FindViewById<TextView> (Resource.Id.tv_UrineRoutinePH_High);
			tv_UrineRoutinePH_Low = FindViewById<TextView> (Resource.Id.tv_UrineRoutinePH_Low);
			tv_UrineRoutineSG = FindViewById<TextView> (Resource.Id.tv_UrineRoutineSG);
			tv_UrineRoutineSG_High = FindViewById<TextView> (Resource.Id.tv_UrineRoutineSG_High);
			tv_UrineRoutineSG_Low = FindViewById<TextView> (Resource.Id.tv_UrineRoutineSG_Low);

			tv_UrineRoutineURO = FindViewById<TextView> (Resource.Id.tv_UrineRoutineURO);
			tv_UrineRoutineURO_High = FindViewById<TextView> (Resource.Id.tv_UrineRoutineURO_High);
			tv_UrineRoutineURO_Low = FindViewById<TextView> (Resource.Id.tv_UrineRoutineURO_Low);
			tv_UrineRoutineWBC = FindViewById<TextView> (Resource.Id.tv_UrineRoutineWBC);
			tv_UrineRoutineBLO = FindViewById<TextView> (Resource.Id.tv_UrineRoutineBLO);
			tv_UrineRoutineKET = FindViewById<TextView> (Resource.Id.tv_UrineRoutineKET);
			tv_UrineRoutineGLU = FindViewById<TextView> (Resource.Id.tv_UrineRoutineGLU);

			tv_UrineRoutineRPO = FindViewById<TextView> (Resource.Id.tv_UrineRoutineRPO);
			tv_UrineRoutineBIL = FindViewById<TextView> (Resource.Id.tv_UrineRoutineBIL);

			img_BMI_Arraw = FindViewById<ImageView> (Resource.Id.img_BMI_Arraw);
			img_BloodGlucose_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodGlucose_Arraw);
			img_BloodOxygenParaOne_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodOxygenParaOne_Arraw);
			img_HeartRate_Arraw = FindViewById<ImageView> (Resource.Id.img_HeartRate_Arraw);
			img_BreathCapacity_Arraw = FindViewById<ImageView> (Resource.Id.img_BreathCapacity_Arraw);

			img_BodyTemperature_Arraw = FindViewById<ImageView> (Resource.Id.img_BodyTemperature_Arraw);
			img_BloodLipidParaOne_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaOne_Arraw);
			img_BloodLipidParaFour_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaFour_Arraw);
			img_BloodLipidParaTwo_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaTwo_Arraw);
			img_BloodLipidParaThree_Arraw = FindViewById<ImageView> (Resource.Id.img_BloodLipidParaThree_Arraw);

			img_UrineRoutinePH_Arraw = FindViewById<ImageView> (Resource.Id.img_UrineRoutinePH_Arraw);
			img_UrineRoutineSG_Arraw = FindViewById<ImageView> (Resource.Id.img_UrineRoutineSG_Arraw);
			img_UrineRoutineURO_Arraw = FindViewById<ImageView> (Resource.Id.img_UrineRoutineURO_Arraw);
//			Task.Factory.StartNew (() => {
//				LoadData();
//			});

			new Handler ().PostDelayed (LoadData, 1000);

		}



		/// <summary>
		/// 加载体检详细数据
		/// </summary>
		private void LoadData()
		{
			//身体质量指数
			tv_TestTime.Text = string.IsNullOrEmpty (healthInfoItem.TestTime) ? "-" : healthInfoItem.TestTime;
			tv_BMI_High.Text = HealthStand.BMI_High.ToString ();
			tv_BMI_Low.Text = HealthStand.BMI_Low.ToString ();
			tv_Height.Text = string.IsNullOrEmpty (healthInfoItem.Height) ? "-" : healthInfoItem.Height;
			tv_Weight.Text = string.IsNullOrEmpty (healthInfoItem.Weight) ? "-" : healthInfoItem.Weight;
			if (!string.IsNullOrEmpty (healthInfoItem.Height) && !string.IsNullOrEmpty (healthInfoItem.Weight)) {
				var bmi = Convert.ToDouble (healthInfoItem.Weight) / ((Convert.ToDouble (healthInfoItem.Height) / 100) * (Convert.ToDouble (healthInfoItem.Height) / 100));
				tv_BMI.Text = string.Format ("{0:F}",bmi); // bmi.ToString ();
				if (bmi > HealthStand.BMI_High || bmi < HealthStand.BMI_Low) {
					//异常
					tv_BMI.SetTextColor(Resources.GetColor(Resource.Color.pink));
					tv_BMI_Show.SetBackgroundResource (Resource.Color.pink);
				}

			}

			//血糖
			tv_BloodGlucose.Text = string.IsNullOrEmpty(healthInfoItem.BloodGlucose)?"-":healthInfoItem.BloodGlucose;
			tv_BloodGlucose_High.Text = HealthStand.BloodGlucose_High.ToString ();
			tv_BloodGlucose_Low.Text = HealthStand.BloodGlucose_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BloodGlucose)) {
				var bloodGlucose = healthInfoItem.BloodGlucose;

				if (Convert.ToDouble (bloodGlucose) > HealthStand.BloodGlucose_High || Convert.ToDouble (bloodGlucose) < HealthStand.BloodGlucose_Low) {
					tv_BloodGlucose.SetTextColor (Resources.GetColor (Resource.Color.pink));
					tv_BloodGlucose_Show.SetBackgroundResource (Resource.Color.pink);
				}
			}

			//血氧
			tv_BloodOxygenParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodOxygenParaOne)?"-":healthInfoItem.BloodOxygenParaOne;
			tv_BloodOxygenParaOne_High.Text = HealthStand.BloodOxygen_High.ToString ();
			tv_BloodOxygenParaOne_Low.Text = HealthStand.BloodOxygen_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BloodOxygenParaOne)) {
				var bloodOxygen = healthInfoItem.BloodOxygenParaOne;
				if (Convert.ToDouble (bloodOxygen) > HealthStand.BloodOxygen_High || Convert.ToDouble (bloodOxygen) < HealthStand.BloodOxygen_Low) {
					tv_BloodOxygenParaOne.SetTextColor (Resources.GetColor (Resource.Color.pink));
					tv_BloodOxygen_Show.SetBackgroundResource (Resource.Color.pink);
				}
			}

			//血压
			tv_BloodPressureParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodPressureParaOne)?"-":healthInfoItem.BloodPressureParaOne;
			tv_BloodPressureParaTwo.Text = string.IsNullOrEmpty (healthInfoItem.BloodPressureParaTwo) ? "-" : healthInfoItem.BloodPressureParaTwo;
			//心率
			tv_HeartRate.Text = string.IsNullOrEmpty(healthInfoItem.HeartRate)?"-":healthInfoItem.HeartRate;
			tv_HeartRate_High.Text = HealthStand.HeartRate_High.ToString ();
			tv_HeartRate_Low.Text = HealthStand.HeartRate_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.HeartRate)) {
				var heartRate = healthInfoItem.HeartRate;
				if (Convert.ToDouble (heartRate) > HealthStand.HeartRate_High || Convert.ToDouble (heartRate) < HealthStand.HeartRate_Low) {
					tv_HeartRate.SetTextColor (Resources.GetColor (Resource.Color.pink));
					tv_HeartRate_Show.SetBackgroundResource (Resource.Color.pink);
				}
			}

			//肺活量
			tv_BreathCapacity.Text = string.IsNullOrEmpty(healthInfoItem.BreathCapacity)?"-":healthInfoItem.BreathCapacity;
			tv_BreathCapacity_High.Text = HealthStand.BreathCapacity_High.ToString ();
			tv_BreathCapacity_Low.Text = HealthStand.BreathCapacity_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BreathCapacity)) {
				var breathCapacity = healthInfoItem.BreathCapacity;
				if (Convert.ToDouble (breathCapacity) > HealthStand.BreathCapacity_High || Convert.ToDouble (breathCapacity) < HealthStand.BreathCapacity_Low) {
					tv_BreathCapacity.SetTextColor (Resources.GetColor (Resource.Color.pink));
					tv_BreathCapacity_Show.SetBackgroundResource(Resource.Color.pink);
				}
			}
			//体温
			tv_BodyTemperature.Text = string.IsNullOrEmpty(healthInfoItem.BodyTemperature)?"-":healthInfoItem.BodyTemperature;
			tv_BodyTemperature_High.Text = HealthStand.BodyTemperature_High.ToString ();
			tv_BodyTemperature_Low.Text = HealthStand.BodyTemperature_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BodyTemperature)) {
				var bodyTemperature = Convert.ToDouble(healthInfoItem.BodyTemperature);
				if (bodyTemperature > HealthStand.BodyTemperature_High || bodyTemperature < HealthStand.BodyTemperature_Low) {
					tv_BodyTemperature.SetTextColor (Resources.GetColor (Resource.Color.pink));
					tv_BodyTemperature_Show.SetBackgroundResource (Resource.Color.pink);
				}
			}
			//总胆固醇
			tv_BloodLipidParaOne.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaOne)?"-":healthInfoItem.BloodLipidParaOne;
			tv_BloodLipidParaOne_High.Text = HealthStand.BloodLipidParaOne_High.ToString ();
			tv_BloodLipidParaOne_Low.Text = HealthStand.BloodLipidParaOne_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaOne)) {
				var bloodLipidParaOne = Convert.ToDouble (healthInfoItem.BloodLipidParaOne);
				if (bloodLipidParaOne > HealthStand.BloodLipidParaOne_High || bloodLipidParaOne < HealthStand.BloodLipidParaOne_Low) {
					tv_BloodLipidParaOne.SetTextColor (Resources.GetColor (Resource.Color.pink));
				}
			}
			//低密度脂蛋白胆固醇

			tv_BloodLipidParaTwo.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaTwo)?"-":healthInfoItem.BloodLipidParaTwo;
			tv_BloodLipidParaTwo_High.Text = HealthStand.BloodLipidParaTwo_High.ToString ();
			tv_BloodLipidParaTwo_Low.Text = HealthStand.BloodLipidParaTwo_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaTwo)) {
				var bloodLipidParaTwo = Convert.ToDouble (healthInfoItem.BloodLipidParaTwo);
				if (bloodLipidParaTwo > HealthStand.BloodLipidParaTwo_High || bloodLipidParaTwo < HealthStand.BloodLipidParaTwo_Low) {
					tv_BloodLipidParaTwo.SetTextColor (Resources.GetColor (Resource.Color.pink));
				}
			}

			//高密度脂蛋白胆固醇

			tv_BloodLipidParaThree.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaThree)?"-":healthInfoItem.BloodLipidParaThree;
			tv_BloodLipidParaThree_High.Text = HealthStand.BloodLipidParaThree_High.ToString ();
			tv_BloodLipidParaThree_Low.Text = HealthStand.BloodLipidParaThree_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaThree)) {
				var bloodLipidParaThree = Convert.ToDouble (healthInfoItem.BloodLipidParaThree);
				if (bloodLipidParaThree > HealthStand.BloodLipidParaThree_High || bloodLipidParaThree < HealthStand.BloodLipidParaThree_Low) {
					tv_BloodLipidParaThree.SetTextColor (Resources.GetColor (Resource.Color.pink));
				}
			}

			//甘油三酯
			tv_BloodLipidParaFour.Text = string.IsNullOrEmpty(healthInfoItem.BloodLipidParaFour)?"-":healthInfoItem.BloodLipidParaFour;
			tv_BloodLipidParaFour_High.Text = HealthStand.BloodLipidParaFour_High.ToString ();
			tv_BloodLipidParaFour_Low.Text = HealthStand.BloodLipidParaFour_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.BloodLipidParaFour)) {
				var bloodLipidParaFour = Convert.ToDouble (healthInfoItem.BloodLipidParaFour);
				if (bloodLipidParaFour > HealthStand.BloodLipidParaFour_High || bloodLipidParaFour < HealthStand.BloodLipidParaFour_Low) {
					tv_BloodLipidParaFour.SetTextColor (Resources.GetColor (Resource.Color.pink));
				}
			}
			//酸碱度
			tv_UrineRoutinePH.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutinePH)?"-":healthInfoItem.UrineRoutinePH;
			tv_UrineRoutinePH_High.Text = HealthStand.PH_High.ToString ();
			tv_UrineRoutinePH_Low.Text = HealthStand.PH_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutinePH)) {
				var urineRoutinePh = Convert.ToDouble (healthInfoItem.UrineRoutinePH);
				if (urineRoutinePh > HealthStand.PH_High || urineRoutinePh < HealthStand.PH_Low) {
					tv_UrineRoutinePH.SetTextColor (Resources.GetColor (Resource.Color.pink));
				}
			}

			//尿比重
			tv_UrineRoutineSG.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineSG)?"-":healthInfoItem.UrineRoutineSG;
			tv_UrineRoutineSG_High.Text = HealthStand.UrineRoutineSG_High.ToString ();
			tv_UrineRoutineSG_Low.Text = HealthStand.UrineRoutineSG_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutineSG)) {
				var urineRoutineSg = Convert.ToDouble (healthInfoItem.UrineRoutineSG);
				if (urineRoutineSg > HealthStand.UrineRoutineSG_High || urineRoutineSg < HealthStand.UrineRoutineSG_Low) {
					tv_UrineRoutineSG.SetTextColor (Resources.GetColor (Resource.Color.pink));
				}
			}

			//尿胆元
			tv_UrineRoutineURO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineURO)?"-":healthInfoItem.UrineRoutineURO;
			tv_UrineRoutineURO_High.Text = HealthStand.UrineRoutineURO_High.ToString ();
			tv_UrineRoutineURO_Low.Text = HealthStand.UrineRoutineURO_Low.ToString ();
			if (!string.IsNullOrEmpty (healthInfoItem.UrineRoutineURO)) {
				var urineRoutineUro = Convert.ToDouble (healthInfoItem.UrineRoutineURO);
				if (urineRoutineUro > HealthStand.UrineRoutineURO_High || urineRoutineUro < HealthStand.UrineRoutineURO_Low) {
					tv_UrineRoutineURO.SetTextColor (Resources.GetColor (Resource.Color.pink));
				}
			}
			//隐血
			tv_UrineRoutineBLO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineBLO)?"-":healthInfoItem.UrineRoutineBLO;
			//白细胞(WBC):(WBC/uL)
			tv_UrineRoutineWBC.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineWBC)?"-":healthInfoItem.UrineRoutineWBC;
			//尿蛋白(PRO)
			tv_UrineRoutineRPO.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutinePRO)?"-":healthInfoItem.UrineRoutinePRO;
			//尿糖(GLU)
			tv_UrineRoutineGLU.Text = string.IsNullOrEmpty(healthInfoItem.UrineRoutineGLU)?"-":healthInfoItem.UrineRoutineGLU;
			RunOnUiThread (() => {
				ProgressDialogUtil.StopProgressDialog();
			});
		}
	}
}

