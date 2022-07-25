using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000A9 RID: 169
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedC_Report : Component, ICachedReport
	{
		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00270290 File Offset: 0x0026E690
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x002702A0 File Offset: 0x0026E6A0
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

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x002702A4 File Offset: 0x0026E6A4
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x002702B4 File Offset: 0x0026E6B4
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

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x002702B8 File Offset: 0x0026E6B8
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x002702CC File Offset: 0x0026E6CC
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

		// Token: 0x06001FBE RID: 8126 RVA: 0x002702D0 File Offset: 0x0026E6D0
		public virtual ReportDocument CreateReport()
		{
			return new C_Report
			{
				Site = this.Site
			};
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x002702F0 File Offset: 0x0026E6F0
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
