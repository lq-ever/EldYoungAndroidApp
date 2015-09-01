using System;
using System.Collections.Generic;
using EldYoungAndroidApp.Model.Guardian;

namespace EldYoungAndroidApp.Json
{
	public class GuardianInfoJson:BaseJson
	{
		public GuardianInfoJson ()
		{
			data = new GuardianListInfoDataJson ();
		}
		public GuardianListInfoDataJson data {
			get;
			set;
		}
	}

	public class GuardianListInfoDataJson
	{
		public GuardianListInfoDataJson()
		{
			items = new List<GuardianInfoListItem> ();
		}
		public int total {
			get;
			set;
		}
		public List<GuardianInfoListItem> items {
			get;
			set;
		}
	}
}

