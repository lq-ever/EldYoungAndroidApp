using System;
using System.Collections.Generic;
using EldYoungAndroidApp.Model;

namespace EldYoungAndroidApp.Json
{
	public class GetMyInfoJson:BaseJson
	{
		public GetMyInfoJson ()
		{
			data = new List<PersonInfoItem>();
		}
		public  List<PersonInfoItem> data {
			get;
			set;
		}
	}
//	public class MyInfoJsonData
//	{
//		public MyInfoJsonData()
//		{
//			Table = new List<PersonInfoItem> ();
//		}
//		public List<PersonInfoItem> Table {
//			get;
//			set;
//		}
//	}
}

