using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000B5 RID: 181
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedFinalTB_Report : Component, ICachedReport
	{
		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00270AE8 File Offset: 0x0026EEE8
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x00270AF8 File Offset: 0x0026EEF8
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00270AFC File Offset: 0x0026EEFC
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x00270B0C File Offset: 0x0026EF0C
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

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x00270B10 File Offset: 0x0026EF10
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x00270B24 File Offset: 0x0026EF24
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

		// Token: 0x0600203C RID: 8252 RVA: 0x00270B28 File Offset: 0x0026EF28
		public virtual ReportDocument CreateReport()
		{
			return new FinalTB_Report
			{
				Site = this.Site
			};
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00270B48 File Offset: 0x0026EF48
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
