﻿using System;

namespace EldYoungAndroidApp
{
	public class AlarmTypeItem
	{
		public AlarmTypeItem ()
		{
		}
		public string AlarmTypeId {
			get;
			set;
		}
		public string AlarmTypeDesc {
			get;
			set;
		}
		public override string ToString ()
		{
			return AlarmTypeDesc;
		}
	}
}

