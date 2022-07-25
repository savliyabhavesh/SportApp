using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000A7 RID: 167
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class Cachedbookprint : Component, ICachedReport
	{
		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0027012C File Offset: 0x0026E52C
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0027013C File Offset: 0x0026E53C
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

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x00270140 File Offset: 0x0026E540
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00270150 File Offset: 0x0026E550
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

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00270154 File Offset: 0x0026E554
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00270168 File Offset: 0x0026E568
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

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0027016C File Offset: 0x0026E56C
		public virtual ReportDocument CreateReport()
		{
			return new bookprint
			{
				Site = this.Site
			};
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0027018C File Offset: 0x0026E58C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
