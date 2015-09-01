using System;
using System.Collections.Generic;
using EldYoungAndroidApp.Model;

namespace EldYoungAndroidApp.Json
{
	public class GetApplyInfoJson:BaseJson
	{
		public GetApplyInfoJson ()
		{
			data = new List<GetApplyInfoListItem> ();
		}
		public List<GetApplyInfoListItem> data {
			get;
			set;
		}
	}
}

