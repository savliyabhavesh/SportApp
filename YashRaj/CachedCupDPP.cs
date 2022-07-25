using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace YashAksh
{
	// Token: 0x020000AF RID: 175
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedCupDPP : Component, ICachedReport
	{
		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x002706BC File Offset: 0x0026EABC
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x002706CC File Offset: 0x0026EACC
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

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x002706D0 File Offset: 0x0026EAD0
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x002706E0 File Offset: 0x0026EAE0
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

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x002706E4 File Offset: 0x0026EAE4
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x002706F8 File Offset: 0x0026EAF8
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

		// Token: 0x06001FFD RID: 8189 RVA: 0x002706FC File Offset: 0x0026EAFC
		public virtual ReportDocument CreateReport()
		{
			return new CupDPP
			{
				Site = this.Site
			};
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0027071C File Offset: 0x0026EB1C
		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}
	}
}
