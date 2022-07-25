using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000BE RID: 190
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedPrivesdata : Component, ICachedReport
	{
		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x00271078 File Offset: 0x0026F478
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x00271088 File Offset: 0x0026F488
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

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x0027108C File Offset: 0x0026F48C
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x0027109C File Offset: 0x0026F49C
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

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x002710A0 File Offset: 0x0026F4A0
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x002710B4 File Offset: 0x0026F4B4
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

		// Token: 0x06002096 RID: 8342 RVA: 0x002710B8 File Offset: 0x0026F4B8
		public virtual ReportDocument CreateReport()
		{
			return new Privesdata
			{
				Site = this.Site
			};
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x002710D8 File Offset: 0x0026F4D8
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
