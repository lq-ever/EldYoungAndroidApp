using System;
using EldYoungAndroidApp.Common;

namespace EldYoungAndroidApp.Param
{
	/// <summary>
	/// 搜索会员
	/// </summary>
	public class SearchGuardianParam:BaseParam
	{
		public SearchGuardianParam ()
		{
		}
		public override string Action {
			get {
				return "SearchUserInforByCondition";
			}
		}
		public override string ServiceName {
			get {
				return Global.GuardianUrl;
			}
		}
		public string Condition {
			get;
			set;
		}
		public string Econdition
		{
			get{
				return EnDeCryptHelp.Encrypt (Condition);
			}
		}
		public string Guid {
			get;
			set;
		}
		public string Eguid
		{
			get{
				return EnDeCryptHelp.Encrypt(Guid);
			}
		}

		public override string Md5 {
			get {
				return EnDeCryptHelp.MD5Encrypt (Eaction + Econdition +Eguid+ Key, Key);
			}
		} 
	}
}

