using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000AB RID: 171
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedCrystalReport1 : Component, ICachedReport
	{
		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x002703F4 File Offset: 0x0026E7F4
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00270404 File Offset: 0x0026E804
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00270408 File Offset: 0x0026E808
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00270418 File Offset: 0x0026E818
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0027041C File Offset: 0x0026E81C
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00270430 File Offset: 0x0026E830
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

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00270434 File Offset: 0x0026E834
		public virtual ReportDocument CreateReport()
		{
			return new CrystalReport1
			{
				Site = this.Site
			};
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00270454 File Offset: 0x0026E854
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
