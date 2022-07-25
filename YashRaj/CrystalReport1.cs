using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace YashAksh
{
	// Token: 0x020000AA RID: 170
	public class CrystalReport1 : ReportClass
	{
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00270308 File Offset: 0x0026E708
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0027031C File Offset: 0x0026E71C
		public override string ResourceName
		{
			get
			{
				return "CrystalReport1.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00270320 File Offset: 0x0026E720
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00270330 File Offset: 0x0026E730
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00270334 File Offset: 0x0026E734
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00270348 File Offset: 0x0026E748
		public override string FullResourceName
		{
			get
			{
				return "YashAksh.CrystalReport1.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0027034C File Offset: 0x0026E74C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0027036C File Offset: 0x0026E76C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0027038C File Offset: 0x0026E78C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x002703AC File Offset: 0x0026E7AC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x002703CC File Offset: 0x0026E7CC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}
	}
}
