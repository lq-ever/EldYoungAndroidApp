using System;

namespace EldYoungAndroidApp.Json
{
	public class RegisterJson:BaseJson
	{
		public RegisterJson ()
		{
			data = new LoginJsonData ();
		}
		public LoginJsonData data {
			get;
			set;
		}
	}
}

