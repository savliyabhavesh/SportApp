using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000A3 RID: 163
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedMatchDPP : Component, ICachedReport
	{
		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x0026FFC8 File Offset: 0x0026E3C8
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x0026FFD8 File Offset: 0x0026E3D8
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

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0026FFDC File Offset: 0x0026E3DC
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0026FFEC File Offset: 0x0026E3EC
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

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0026FFF0 File Offset: 0x0026E3F0
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x00270004 File Offset: 0x0026E404
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

		// Token: 0x06001F82 RID: 8066 RVA: 0x00270008 File Offset: 0x0026E408
		public virtual ReportDocument CreateReport()
		{
			return new MatchDPP
			{
				Site = this.Site
			};
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00270028 File Offset: 0x0026E428
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
