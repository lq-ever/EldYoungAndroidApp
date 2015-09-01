using System;
using EldYoungAndroidApp.Common;

namespace EldYoungAndroidApp.Param
{
	/// <summary>
	/// 申请绑定监护人
	/// </summary>
	public class ApplyBindGuardianParam:BaseParam
	{
		public ApplyBindGuardianParam ()
		{
		}
		public override string Action {
			get {
				return "ApplyForGuardian";
			}
		}
		public override string ServiceName {
			get {
				return Global.GuardianUrl;
			}
		}

		public string ApplyContent {
			get;
			set;
		}
		public string EapplyContent {
			get{
				return EnDeCryptHelp.Encrypt (ApplyContent);
			}
		}
		public string UserId {
			get;
			set;
		}
		public string EuserId
		{
			get{
				return EnDeCryptHelp.Encrypt (UserId);
			}
		}
		public string GId {
			get;
			set;
		}
		public string Egid {
			get {
				return EnDeCryptHelp.Encrypt (GId);
			}
		}
		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction + EapplyContent + EuserId + Egid + Key, Key);
			}
		}
	}
}

