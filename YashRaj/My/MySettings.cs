using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh.My
{
	// Token: 0x0200005A RID: 90
	//[EditorBrowsable(EditorBrowsableState.Advanced)]
	//[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	//[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0026FE8C File Offset: 0x0026E28C
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0026FEAC File Offset: 0x0026E2AC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public DateTime MYDAYS
		{
			get
			{
				return Conversions.ToDate(this["MYDAYS"]);
			}
			set
			{
				this["MYDAYS"] = value;
			}
		}
	}
}
