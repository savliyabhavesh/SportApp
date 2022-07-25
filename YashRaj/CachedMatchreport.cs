using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000BB RID: 187
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedMatchreport : Component, ICachedReport
	{
		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00270F14 File Offset: 0x0026F314
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00270F24 File Offset: 0x0026F324
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x00270F28 File Offset: 0x0026F328
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00270F38 File Offset: 0x0026F338
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

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x00270F3C File Offset: 0x0026F33C
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00270F50 File Offset: 0x0026F350
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

		// Token: 0x0600207B RID: 8315 RVA: 0x00270F54 File Offset: 0x0026F354
		public virtual ReportDocument CreateReport()
		{
			return new Matchreport
			{
				Site = this.Site
			};
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00270F74 File Offset: 0x0026F374
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
