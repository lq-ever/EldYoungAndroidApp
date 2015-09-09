using System;
using System.Collections.Generic;
using EldYoungAndroidApp.Model;

namespace EldYoungAndroidApp.Json
{
	public class LoginJson:BaseJson
	{
		public LoginJson ()
		{
			data = new LoginJsonData ();
		}
		public LoginJsonData data {
			get;
			set;
		}
	}

	public class LoginJsonData
	{
		public LoginJsonData()
		{
			Table = new List<PersonInfoItem> ();
		}
		public List<PersonInfoItem> Table {
			get;
			set;
		}
	}

}

