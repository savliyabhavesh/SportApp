using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000C0 RID: 192
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedSDDPreport : Component, ICachedReport
	{
		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x002711DC File Offset: 0x0026F5DC
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x002711EC File Offset: 0x0026F5EC
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

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x002711F0 File Offset: 0x0026F5F0
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00271200 File Offset: 0x0026F600
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00271204 File Offset: 0x0026F604
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x00271218 File Offset: 0x0026F618
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

		// Token: 0x060020AB RID: 8363 RVA: 0x0027121C File Offset: 0x0026F61C
		public virtual ReportDocument CreateReport()
		{
			return new SDDPreport
			{
				Site = this.Site
			};
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0027123C File Offset: 0x0026F63C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
