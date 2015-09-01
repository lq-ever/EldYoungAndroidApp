using System;
using EldYoungAndroidApp.Model.Alarm;
using System.Collections.Generic;

namespace EldYoungAndroidApp.Json
{
	public class SearchAlarmInfoJson:BaseJson
	{
		public SearchAlarmInfoJson ()
		{
			data = new AlarmInfoListdataJson ();
		}
		public AlarmInfoListdataJson data {
			get;
			set;
		}

	}
	public class AlarmInfoListdataJson
	{
		public AlarmInfoListdataJson()
		{
			items = new List<AlarmInfoListItem> ();
		}
		public int total {
			get;
			set;
		}

		public List<AlarmInfoListItem> items {
			get;
			set;
		}
	}


}

