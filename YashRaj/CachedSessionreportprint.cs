using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000C2 RID: 194
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSessionreportprint : Component, ICachedReport
	{
		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x00271340 File Offset: 0x0026F740
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x00271350 File Offset: 0x0026F750
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

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x00271354 File Offset: 0x0026F754
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x00271364 File Offset: 0x0026F764
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

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x00271368 File Offset: 0x0026F768
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x0027137C File Offset: 0x0026F77C
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

		// Token: 0x060020C0 RID: 8384 RVA: 0x00271380 File Offset: 0x0026F780
		public virtual ReportDocument CreateReport()
		{
			return new Sessionreportprint
			{
				Site = this.Site
			};
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x002713A0 File Offset: 0x0026F7A0
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
