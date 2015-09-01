using System;
using System.Collections.Generic;
using EldYoungAndroidApp.Model;

namespace EldYoungAndroidApp.Json
{
	public class SearchGuardianListJson:BaseJson
	{
		public SearchGuardianListJson ()
		{
			data = new List<SearchGuardianListItem> ();
		}
		public List<SearchGuardianListItem> data {
			get;
			set;
		}
	}
}

