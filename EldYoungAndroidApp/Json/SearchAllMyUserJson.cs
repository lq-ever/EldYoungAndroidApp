using System;
using System.Collections.Generic;
using EldYoungAndroidApp.Model.Alarm;

namespace EldYoungAndroidApp.Json
{
	public class SearchAllMyUserJson:BaseJson
	{
		public SearchAllMyUserJson ()
		{
			data = new List<AllMyUserListItem> ();
		}
		public List<AllMyUserListItem> data {
			get;
			set;
		}
	}



}

