using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000C4 RID: 196
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedT_report : Component, ICachedReport
	{
		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x002714A4 File Offset: 0x0026F8A4
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x002714B4 File Offset: 0x0026F8B4
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

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x002714B8 File Offset: 0x0026F8B8
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x002714C8 File Offset: 0x0026F8C8
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

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x002714CC File Offset: 0x0026F8CC
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x002714E0 File Offset: 0x0026F8E0
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

		// Token: 0x060020D5 RID: 8405 RVA: 0x002714E4 File Offset: 0x0026F8E4
		public virtual ReportDocument CreateReport()
		{
			return new T_report
			{
				Site = this.Site
			};
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00271504 File Offset: 0x0026F904
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
