using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace YashAksh
{
	// Token: 0x020000B8 RID: 184
	public class mareport : ReportClass
	{
		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x00270CC4 File Offset: 0x0026F0C4
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x00270CD8 File Offset: 0x0026F0D8
		public override string ResourceName
		{
			get
			{
				return "mareport.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00270CDC File Offset: 0x0026F0DC
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x00270CEC File Offset: 0x0026F0EC
		public override bool NewGenerator
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00270CF0 File Offset: 0x0026F0F0
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x00270D04 File Offset: 0x0026F104
		public override string FullResourceName
		{
			get
			{
				return "YashAksh.mareport.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00270D08 File Offset: 0x0026F108
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x00270D28 File Offset: 0x0026F128
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x00270D48 File Offset: 0x0026F148
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x00270D68 File Offset: 0x0026F168
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x00270D88 File Offset: 0x0026F188
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}
	}
}
