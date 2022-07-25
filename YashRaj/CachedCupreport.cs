using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000B1 RID: 177
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedCupreport : Component, ICachedReport
	{
		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x00270820 File Offset: 0x0026EC20
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x00270830 File Offset: 0x0026EC30
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

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x00270834 File Offset: 0x0026EC34
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x00270844 File Offset: 0x0026EC44
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

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00270848 File Offset: 0x0026EC48
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x0027085C File Offset: 0x0026EC5C
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

		// Token: 0x06002012 RID: 8210 RVA: 0x00270860 File Offset: 0x0026EC60
		public virtual ReportDocument CreateReport()
		{
			return new Cupreport
			{
				Site = this.Site
			};
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00270880 File Offset: 0x0026EC80
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
