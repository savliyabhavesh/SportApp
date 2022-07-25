using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh.My
{
	// Token: 0x0200005B RID: 91
	[StandardModule]
	[DebuggerNonUserCode]
	[HideModuleName]
	[CompilerGenerated]
	internal sealed class MySettingsProperty
	{
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0026FEC0 File Offset: 0x0026E2C0
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
