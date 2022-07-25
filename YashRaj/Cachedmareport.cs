using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000B9 RID: 185
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class Cachedmareport : Component, ICachedReport
	{
		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x00270DB0 File Offset: 0x0026F1B0
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00270DC0 File Offset: 0x0026F1C0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual bool IsCacheable
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x00270DC4 File Offset: 0x0026F1C4
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x00270DD4 File Offset: 0x0026F1D4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual bool ShareDBLogonInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x00270DD8 File Offset: 0x0026F1D8
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x00270DEC File Offset: 0x0026F1EC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual TimeSpan CacheTimeOut
		{
			get
			{
				return CachedReportConstants.DEFAULT_TIMEOUT;
			}
			set
			{
			}
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00270DF0 File Offset: 0x0026F1F0
		public virtual ReportDocument CreateReport()
		{
			return new mareport
			{
				Site = this.Site
			};
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00270E10 File Offset: 0x0026F210
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
