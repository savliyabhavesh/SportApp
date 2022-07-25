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
	// Token: 0x020000A0 RID: 160
	[DesignerGenerated]
	public partial class fromMatchdpp : Form
	{
		// Token: 0x06001F5D RID: 8029 RVA: 0x003A6298 File Offset: 0x003A4698
		public fromMatchdpp()
		{
			base.Load += this.fromMatchdpp_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x003A6448 File Offset: 0x003A4848
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x003A645C File Offset: 0x003A485C
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x003A6468 File Offset: 0x003A4868
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x003A647C File Offset: 0x003A487C
		internal virtual MatchDPP MatchDPP1
		{
			get
			{
				return this._MatchDPP1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MatchDPP1 = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x003A6488 File Offset: 0x003A4888
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x003A64B8 File Offset: 0x003A48B8
		public static fromMatchdpp GlobalForm
		{
			get
			{
				if (fromMatchdpp.m_GlobalForm == null || fromMatchdpp.m_GlobalForm.IsDisposed)
				{
					fromMatchdpp.m_GlobalForm = new fromMatchdpp();
				}
				return fromMatchdpp.m_GlobalForm;
			}
			set
			{
				fromMatchdpp.m_GlobalForm = value;
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x003A64C0 File Offset: 0x003A48C0
		private void fromMatchdpp_Load(object sender, EventArgs e)
		{
			try
			{
				this.WindowState = FormWindowState.Maximized;
				string selectCommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select n.Team1,n.Name,n.Type,n.Date1,n.Sr_No,m.m_eid,m.m_amt,m.m_rate,m.m_team,m.m_mode,m.m_party from Newmatch n,MatchTrans m where n.Sr_No=" + Conversions.ToString(Module1.machid) + " and m.m_id=" + Conversions.ToString(Module1.machid) + " and m.m_party='", Module1.name1), "' and m_checked=0"));
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
				DataTable dataTable = new DataTable();
				dataTable.Clear();
				oleDbDataAdapter.Fill(dataTable);
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load("C:\\Report\\MatchDPP.rpt");
				reportDocument.SetDataSource(dataTable);
				this.CrystalReportViewer1.ReportSource = reportDocument;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04000CAF RID: 3247
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000CB0 RID: 3248
		[AccessedThroughProperty("MatchDPP1")]
		private MatchDPP _MatchDPP1;

		// Token: 0x04000CB1 RID: 3249
		private static fromMatchdpp m_GlobalForm;
	}
}
