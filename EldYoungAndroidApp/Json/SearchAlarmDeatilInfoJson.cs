﻿using System;
using System.Collections.Generic;
using EldYoungAndroidApp.Model.Alarm;

namespace EldYoungAndroidApp.Json
{
	public class SearchAlarmDeatilInfoJson:BaseJson
	{
		public SearchAlarmDeatilInfoJson ()
		{
			data = new AlarmDetaildataJson ();
		}
		public AlarmDetaildataJson data {
			get;
			set;
		}
	}

	public class AlarmDetaildataJson
	{
		public AlarmDetaildataJson()
		{
			detail = new List<AlarmInfoDetailItem> ();
			handdetail = new List<AlarmInfoHandDetailItem> ();
		}

		public List<AlarmInfoDetailItem> detail {
			get;
			set;
		}
		public List<AlarmInfoHandDetailItem> handdetail {
			get;
			set;
		}
	}
}

