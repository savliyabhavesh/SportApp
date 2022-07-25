using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000B7 RID: 183
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedHReport : Component, ICachedReport
	{
		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x00270C4C File Offset: 0x0026F04C
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x00270C5C File Offset: 0x0026F05C
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

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x00270C60 File Offset: 0x0026F060
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x00270C70 File Offset: 0x0026F070
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

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x00270C74 File Offset: 0x0026F074
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x00270C88 File Offset: 0x0026F088
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

		// Token: 0x06002051 RID: 8273 RVA: 0x00270C8C File Offset: 0x0026F08C
		public virtual ReportDocument CreateReport()
		{
			return new HReport
			{
				Site = this.Site
			};
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00270CAC File Offset: 0x0026F0AC
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
