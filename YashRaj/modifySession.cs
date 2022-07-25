using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using YashAksh.My;

namespace YashAksh
{
	// Token: 0x020000C6 RID: 198
	//[DesignerGenerated]
	public partial class modifySession : Form
	{
		// Token: 0x0600211E RID: 8478 RVA: 0x003A960C File Offset: 0x003A7A0C
		public modifySession()
		{
			//base.Load += this.modifySession_Load;
			this.InitializeComponent();
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x003AA3B8 File Offset: 0x003A87B8
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x003AA3C0 File Offset: 0x003A87C0
		private void modifySession_Load(object sender, EventArgs e)
		{
			this.txtid.Text = Conversions.ToString(Module1.nehaid);
			this.findid();
			this.txtsessionname.Focus();
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x003AA3EC File Offset: 0x003A87EC
		public void findid()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = Conversions.ToString(Operators.ConcatenateObject("Select * from ewSession where Sr_No=" + this.txtid.Text + " and Match_ID=", Module1.sessionid));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.txtid.Text = Conversions.ToString(oleDbDataReader[0]);
					this.txtsessionname.Text = Conversions.ToString(oleDbDataReader[3]);
					this.txtdate.Text = Conversions.ToString(oleDbDataReader[2]);
					this.txtcommi.Text = Conversions.ToString(oleDbDataReader[7]);
				}
				else
				{
					Interaction.MsgBox("Record No", MsgBoxStyle.OkOnly, null);
				}
				Module1.conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x003AA514 File Offset: 0x003A8914
		private void BTNMODIFY_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = Conversions.ToString(Operators.ConcatenateObject("update ewSession set N_name='" + this.txtsessionname.Text + "',Type='" + this.txtcommi.Text + "', Dt='" + this.txtdate.Text + "' where Sr_No=" + this.txtid.Text + " and Match_ID=", Module1.sessionid));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				oleDbCommand.ExecuteNonQuery();
				Interaction.MsgBox("Record Saved", MsgBoxStyle.OkOnly, null);
								
				MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
				MyProject.Forms.Session_Report.Show();
				this.Close();

				//if (Operators.CompareString(Module1.sessiondelc, "1", false) == 0)
				//{
				//	MyProject.Forms.All_Session.MdiParent = this.MdiParent;
				//	MyProject.Forms.All_Session.WindowState = FormWindowState.Maximized;
				//	MyProject.Forms.All_Session.Show();
				//	this.Close();
				//}
				//else
				//{
				//	MyProject.Forms.Session_Report.sessionrept();
				//	MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
				//	MyProject.Forms.Session_Report.Show();
				//	this.Close();
				//}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x003AA6BC File Offset: 0x003A8ABC
		private void txtid_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					this.txtsessionname.Focus();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x003AA710 File Offset: 0x003A8B10
		private void txtsessionname_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					this.txtdate.Focus();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x003AA764 File Offset: 0x003A8B64
		private void txtdate_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					this.txtcommi.Focus();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x003AA7B8 File Offset: 0x003A8BB8
		private void txtcommi_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					this.BTNMODIFY.Focus();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04000CD9 RID: 3289
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000CDA RID: 3290
		[AccessedThroughProperty("txtid")]
		private TextBox _txtid;

		// Token: 0x04000CDB RID: 3291
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000CDC RID: 3292
		[AccessedThroughProperty("txtcommi")]
		private ComboBox _txtcommi;

		// Token: 0x04000CDD RID: 3293
		[AccessedThroughProperty("txtsessionname")]
		private TextBox _txtsessionname;

		// Token: 0x04000CDE RID: 3294
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000CDF RID: 3295
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000CE0 RID: 3296
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000CE1 RID: 3297
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000CE2 RID: 3298
		[AccessedThroughProperty("BTNMODIFY")]
		private Button _BTNMODIFY;

		// Token: 0x04000CE3 RID: 3299
		[AccessedThroughProperty("txtdate")]
		private DateTimePicker _txtdate;

		// Token: 0x04000CE4 RID: 3300
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
