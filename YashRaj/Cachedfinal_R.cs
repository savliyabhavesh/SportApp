using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000B3 RID: 179
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class Cachedfinal_R : Component, ICachedReport
	{
		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x00270984 File Offset: 0x0026ED84
		// (set) Token: 0x06002022 RID: 8226 RVA: 0x00270994 File Offset: 0x0026ED94
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

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x00270998 File Offset: 0x0026ED98
		// (set) Token: 0x06002024 RID: 8228 RVA: 0x002709A8 File Offset: 0x0026EDA8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x002709AC File Offset: 0x0026EDAC
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x002709C0 File Offset: 0x0026EDC0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x06002027 RID: 8231 RVA: 0x002709C4 File Offset: 0x0026EDC4
		public virtual ReportDocument CreateReport()
		{
			return new final_R
			{
				Site = this.Site
			};
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x002709E4 File Offset: 0x0026EDE4
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
