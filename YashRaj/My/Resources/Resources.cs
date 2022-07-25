using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh.My.Resources
{
	// Token: 0x02000059 RID: 89
	[StandardModule]
	[HideModuleName]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal sealed class Resources
	{
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0026FC90 File Offset: 0x0026E090
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("YashAksh.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0026FCD0 File Offset: 0x0026E0D0
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0026FCE4 File Offset: 0x0026E0E4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0026FCEC File Offset: 0x0026E0EC
		internal static Bitmap background_learner
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("background-learner", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x0026FD1C File Offset: 0x0026E11C
		internal static Bitmap GN
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("GN", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0026FD4C File Offset: 0x0026E14C
		internal static Bitmap sai_gold_full
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("sai_gold_full", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x0026FD7C File Offset: 0x0026E17C
		internal static Bitmap Untitled
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Untitled", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x04000A29 RID: 2601
		private static ResourceManager resourceMan;

		// Token: 0x04000A2A RID: 2602
		private static CultureInfo resourceCulture;
	}
}
