using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x0200009F RID: 159
	[DesignerGenerated]
	public partial class fromcupdppPrint : Form
	{
		// Token: 0x06001F55 RID: 8021 RVA: 0x003A5FE0 File Offset: 0x003A43E0
		public fromcupdppPrint()
		{
			base.Load += this.fromcupdppPrint_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x003A6164 File Offset: 0x003A4564
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x003A6178 File Offset: 0x003A4578
		internal virtual CrystalReportViewer CrystalReportViewer1
		{
			get
			{
				return this._CrystalReportViewer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CrystalReportViewer1 = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x003A6184 File Offset: 0x003A4584
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x003A61B4 File Offset: 0x003A45B4
		public static fromcupdppPrint GlobalForm
		{
			get
			{
				if (fromcupdppPrint.m_GlobalForm == null || fromcupdppPrint.m_GlobalForm.IsDisposed)
				{
					fromcupdppPrint.m_GlobalForm = new fromcupdppPrint();
				}
				return fromcupdppPrint.m_GlobalForm;
			}
			set
			{
				fromcupdppPrint.m_GlobalForm = value;
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x003A61BC File Offset: 0x003A45BC
		private void fromcupdppPrint_Load(object sender, EventArgs e)
		{
			try
			{
				this.WindowState = FormWindowState.Maximized;
				string selectCommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select n.Team1,n.Name,n.Type,n.Date1,n.Sr_No,c.m_eid,c.m_amt,c.m_rate,c.m_team,c.m_mode,c.m_party from Newmatch n,CupTrans c where n.Sr_No=" + Conversions.ToString(Module1.IDCUP) + " and c.m_id=" + Conversions.ToString(Module1.IDCUP) + " and c.m_party='", Module1.name1), "' and m_checked=0"));
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
				DataTable dataTable = new DataTable();
				dataTable.Clear();
				oleDbDataAdapter.Fill(dataTable);
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load("C:\\Report\\CupDPP.rpt");
				reportDocument.SetDataSource(dataTable);
				this.CrystalReportViewer1.ReportSource = reportDocument;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04000CAC RID: 3244
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000CAD RID: 3245
		private static fromcupdppPrint m_GlobalForm;
	}
}
