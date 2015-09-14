using System;

namespace EldYoungAndroidApp.Json
{
	public class HeadImgJson:BaseJson
	{
		public HeadImgJson ()
		{
			data = new ImgJsonData ();
		}
		public ImgJsonData data {
			get;
			set;
		}
	}
	public class ImgJsonData
	{
		public string HeadImgUrl {
			get;
			set;
		}
	}
}

