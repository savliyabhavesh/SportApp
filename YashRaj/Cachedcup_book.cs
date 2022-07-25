using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000AD RID: 173
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class Cachedcup_book : Component, ICachedReport
	{
		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00270558 File Offset: 0x0026E958
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x00270568 File Offset: 0x0026E968
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

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x0027056C File Offset: 0x0026E96C
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x0027057C File Offset: 0x0026E97C
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

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00270580 File Offset: 0x0026E980
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x00270594 File Offset: 0x0026E994
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

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00270598 File Offset: 0x0026E998
		public virtual ReportDocument CreateReport()
		{
			return new cup_book
			{
				Site = this.Site
			};
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x002705B8 File Offset: 0x0026E9B8
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
