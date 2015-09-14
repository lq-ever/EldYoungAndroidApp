using System;
using EldYoungAndroidApp.Common;

namespace EldYoungAndroidApp.Param
{
	public class HeadImgPostParam:BaseParam
	{
		public HeadImgPostParam ()
		{
		}
		public override string Action {
			get {
				return string.Empty;
			}
		}
		public override string ServiceName {
			get {
				return Global.HeadImgUrl;
			}
		}
		public string UId {
			get;
			set;
		}

		public string Euid
		{
			get{
				return EnDeCryptHelp.Encrypt (UId);
			}
		}
		public string ImageStr {
			get;
			set;
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Euid + Key, Key);
			}
		}

	}
}

