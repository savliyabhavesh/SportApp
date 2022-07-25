using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace YashAksh
{
	// Token: 0x020000B2 RID: 178
	public class final_R : ReportClass
	{
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x00270898 File Offset: 0x0026EC98
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x002708AC File Offset: 0x0026ECAC
		public override string ResourceName
		{
			get
			{
				return "final_R.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x002708B0 File Offset: 0x0026ECB0
		// (set) Token: 0x06002018 RID: 8216 RVA: 0x002708C0 File Offset: 0x0026ECC0
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

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x002708C4 File Offset: 0x0026ECC4
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x002708D8 File Offset: 0x0026ECD8
		public override string FullResourceName
		{
			get
			{
				return "YashAksh.final_R.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x002708DC File Offset: 0x0026ECDC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x002708FC File Offset: 0x0026ECFC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x0027091C File Offset: 0x0026ED1C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0027093C File Offset: 0x0026ED3C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x0027095C File Offset: 0x0026ED5C
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
