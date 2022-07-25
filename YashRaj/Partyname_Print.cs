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
	// Token: 0x02000062 RID: 98
	[DesignerGenerated]
	public partial class Partyname_Print : Form
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x00396EB8 File Offset: 0x003952B8
		public Partyname_Print()
		{
			base.Load += this.Partyname_Print_Load;
			base.MouseEnter += this.Partyname_Print_MouseEnter;
			this.InitializeComponent();
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x003971E4 File Offset: 0x003955E4
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x003971F8 File Offset: 0x003955F8
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00397204 File Offset: 0x00395604
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00397218 File Offset: 0x00395618
		internal virtual CrystalReportViewer CrystalReportViewer1
		{
			get
			{
				return this._CrystalReportViewer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CrystalReportViewer1_Load);
				if (this._CrystalReportViewer1 != null)
				{
					this._CrystalReportViewer1.Load -= value2;
				}
				this._CrystalReportViewer1 = value;
				if (this._CrystalReportViewer1 != null)
				{
					this._CrystalReportViewer1.Load += value2;
				}
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00397264 File Offset: 0x00395664
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x00397278 File Offset: 0x00395678
		internal virtual CrystalReport1 CrystalReport11
		{
			get
			{
				return this._CrystalReport11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CrystalReport11 = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00397284 File Offset: 0x00395684
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x00397298 File Offset: 0x00395698
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x003972E4 File Offset: 0x003956E4
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x00397314 File Offset: 0x00395714
		public static Partyname_Print GlobalForm
		{
			get
			{
				if (Partyname_Print.m_GlobalForm == null || Partyname_Print.m_GlobalForm.IsDisposed)
				{
					Partyname_Print.m_GlobalForm = new Partyname_Print();
				}
				return Partyname_Print.m_GlobalForm;
			}
			set
			{
				Partyname_Print.m_GlobalForm = value;
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0039731C File Offset: 0x0039571C
		private void Partyname_Print_Load(object sender, EventArgs e)
		{
			try
			{
				this.WindowState = FormWindowState.Maximized;
				string selectCommandText = "select* from Newparty";
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
				DataTable dataTable = new DataTable();
				dataTable.Clear();
				oleDbDataAdapter.Fill(dataTable);
				ReportDocument reportDocument = new ReportDocument();
				reportDocument.Load("C:\\Report\\CrystalReport1.rpt");
				reportDocument.SetDataSource(dataTable);
				this.CrystalReportViewer1.ReportSource = reportDocument;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x003973AC File Offset: 0x003957AC
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x003973B4 File Offset: 0x003957B4
		private void Partyname_Print_MouseEnter(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x003973C0 File Offset: 0x003957C0
		private void CrystalReportViewer1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000BBC RID: 3004
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000BBD RID: 3005
		[AccessedThroughProperty("CrystalReportViewer1")]
		private CrystalReportViewer _CrystalReportViewer1;

		// Token: 0x04000BBE RID: 3006
		[AccessedThroughProperty("CrystalReport11")]
		private CrystalReport1 _CrystalReport11;

		// Token: 0x04000BBF RID: 3007
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000BC0 RID: 3008
		private static Partyname_Print m_GlobalForm;
	}
}
