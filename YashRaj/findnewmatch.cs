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

namespace YashAksh
{
	// Token: 0x02000042 RID: 66
	//[DesignerGenerated]
	public partial class findnewmatch : Form
	{
		// Token: 0x06000D78 RID: 3448 RVA: 0x00311954 File Offset: 0x0030FD54
		public findnewmatch()
		{
			//base.KeyDown += this.findnewmatch_KeyDown;
			//base.Load += this.findnewmatch_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x003146A8 File Offset: 0x00312AA8
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x003146B0 File Offset: 0x00312AB0
		private void findnewmatch_Load(object sender, EventArgs e)
		{
			Module1.conn.Close();
			this.txtid.Text = Conversions.ToString(Module1.idnewmach);
			this.find();
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x003146D8 File Offset: 0x00312AD8
		public void find()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "select* from Newmatch where Sr_No=" + this.txtid.Text + "";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					this.txtid.Text = Conversions.ToString(oleDbDataReader[0]);
					this.txtdate.Text = Conversions.ToString(oleDbDataReader[1]);
					this.txtteam1.Text = Conversions.ToString(oleDbDataReader[2]);
					this.txtteam2.Text = Conversions.ToString(oleDbDataReader[3]);
					this.txttype.Text = Conversions.ToString(oleDbDataReader[4]);
					this.txth1.Text = Conversions.ToString(oleDbDataReader[5]);
					this.txth2.Text = Conversions.ToString(oleDbDataReader[6]);
					this.txth3.Text = Conversions.ToString(oleDbDataReader[7]);
					this.txth4.Text = Conversions.ToString(oleDbDataReader[8]);
					this.txth5.Text = Conversions.ToString(oleDbDataReader[9]);
					this.txth6.Text = Conversions.ToString(oleDbDataReader[10]);
					this.txth7.Text = Conversions.ToString(oleDbDataReader[11]);
					this.txth8.Text = Conversions.ToString(oleDbDataReader[12]);
					this.txth9.Text = Conversions.ToString(oleDbDataReader[13]);
					this.txth10.Text = Conversions.ToString(oleDbDataReader[14]);
					this.txth11.Text = Conversions.ToString(oleDbDataReader[15]);
					this.txth12.Text = Conversions.ToString(oleDbDataReader[16]);
					this.txth13.Text = Conversions.ToString(oleDbDataReader[17]);
					this.txth14.Text = Conversions.ToString(oleDbDataReader[18]);
					this.txth15.Text = Conversions.ToString(oleDbDataReader[19]);
					this.RedOnly();
				}
				else
				{
					Interaction.MsgBox("Record No", MsgBoxStyle.OkOnly, null);
				}
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

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00314980 File Offset: 0x00312D80
		public void RedOnly()
		{
			try
			{
				if (Operators.CompareString(this.txtid.Text, "", false) != 0)
				{
					this.txtid.ReadOnly = true;
				}
				if (Operators.CompareString(this.txtdate.Text, "", false) != 0)
				{
					this.txtdate.Enabled = false;
				}
				if (Operators.CompareString(this.txtteam1.Text, "", false) != 0)
				{
					this.txtteam1.Enabled = false;
				}
				if (Operators.CompareString(this.txtteam2.Text, "", false) != 0)
				{
					this.txtteam2.Enabled = false;
				}
				if (Operators.CompareString(this.txttype.Text, "", false) != 0)
				{
					this.txttype.Enabled = false;
				}
				if (Operators.CompareString(this.txth1.Text, "", false) != 0)
				{
					this.txth1.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth2.Text, "", false) != 0)
				{
					this.txth2.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth3.Text, "", false) != 0)
				{
					this.txth3.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth4.Text, "", false) != 0)
				{
					this.txth4.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth5.Text, "", false) != 0)
				{
					this.txth5.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth6.Text, "", false) != 0)
				{
					this.txth6.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth8.Text, "", false) != 0)
				{
					this.txth8.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth10.Text, "", false) != 0)
				{
					this.txth10.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth11.Text, "", false) != 0)
				{
					this.txth11.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth12.Text, "", false) != 0)
				{
					this.txth12.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth13.Text, "", false) != 0)
				{
					this.txth13.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth14.Text, "", false) != 0)
				{
					this.txth14.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth15.Text, "", false) != 0)
				{
					this.txth15.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth7.Text, "", false) != 0)
				{
					this.txth7.ReadOnly = true;
				}
				if (Operators.CompareString(this.txth9.Text, "", false) != 0)
				{
					this.txth9.ReadOnly = true;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00314CD4 File Offset: 0x003130D4
		private void findnewmatch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00314CE8 File Offset: 0x003130E8
		private void Update_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = string.Concat(new string[]
				{
					"Update  Newmatch set Team1='",
					this.txtteam1.Text,
					"', Name='",
					this.txtteam2.Text,
					"', Type='",
					this.txttype.Text,
					"', horse1='",
					this.txth1.Text,
					"', horse2='",
					this.txth2.Text,
					"', horse3='",
					this.txth3.Text,
					"', horse4='",
					this.txth4.Text,
					"', horse5='",
					this.txth5.Text,
					"', horse6='",
					this.txth6.Text,
					"', horse7='",
					this.txth7.Text,
					"', horse8='",
					this.txth8.Text,
					"', horse9='",
					this.txth9.Text,
					"', horse10='",
					this.txth10.Text,
					"', horse11='",
					this.txth11.Text,
					"', horse12='",
					this.txth12.Text,
					"', horse13='",
					this.txth13.Text,
					"', horse14='",
					this.txth14.Text,
					"', horse15='",
					this.txth15.Text,
					"' , Date1='",
					this.txtdate.Text,
					"'  Where Sr_No=",
					this.txtid.Text,
					""
				});
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				oleDbCommand.ExecuteNonQuery();
				Module1.conn.Close();
				MessageBox.Show(" Party Modify Sucessfully ");
				this.Close();
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

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00314F88 File Offset: 0x00313388
		private void txtteam1_TextChanged(object sender, EventArgs e)
		{
			this.txth1.Text = this.txtteam1.Text;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00314FA0 File Offset: 0x003133A0
		private void txtteam2_TextChanged(object sender, EventArgs e)
		{
			this.txth2.Text = this.txtteam2.Text;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00314FB8 File Offset: 0x003133B8
		private void txtid_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					SendKeys.Send("{Tab}");
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0400056E RID: 1390
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400056F RID: 1391
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000570 RID: 1392
		[AccessedThroughProperty("txth15")]
		private TextBox _txth15;

		// Token: 0x04000571 RID: 1393
		[AccessedThroughProperty("txth14")]
		private TextBox _txth14;

		// Token: 0x04000572 RID: 1394
		[AccessedThroughProperty("txth13")]
		private TextBox _txth13;

		// Token: 0x04000573 RID: 1395
		[AccessedThroughProperty("txth12")]
		private TextBox _txth12;

		// Token: 0x04000574 RID: 1396
		[AccessedThroughProperty("txth11")]
		private TextBox _txth11;

		// Token: 0x04000575 RID: 1397
		[AccessedThroughProperty("txth10")]
		private TextBox _txth10;

		// Token: 0x04000576 RID: 1398
		[AccessedThroughProperty("txth9")]
		private TextBox _txth9;

		// Token: 0x04000577 RID: 1399
		[AccessedThroughProperty("txth8")]
		private TextBox _txth8;

		// Token: 0x04000578 RID: 1400
		[AccessedThroughProperty("txth7")]
		private TextBox _txth7;

		// Token: 0x04000579 RID: 1401
		[AccessedThroughProperty("txth6")]
		private TextBox _txth6;

		// Token: 0x0400057A RID: 1402
		[AccessedThroughProperty("txth5")]
		private TextBox _txth5;

		// Token: 0x0400057B RID: 1403
		[AccessedThroughProperty("txth4")]
		private TextBox _txth4;

		// Token: 0x0400057C RID: 1404
		[AccessedThroughProperty("txth3")]
		private TextBox _txth3;

		// Token: 0x0400057D RID: 1405
		[AccessedThroughProperty("txth2")]
		private TextBox _txth2;

		// Token: 0x0400057E RID: 1406
		[AccessedThroughProperty("txth1")]
		private TextBox _txth1;

		// Token: 0x0400057F RID: 1407
		[AccessedThroughProperty("txttype")]
		private ComboBox _txttype;

		// Token: 0x04000580 RID: 1408
		[AccessedThroughProperty("txtteam2")]
		private ComboBox _txtteam2;

		// Token: 0x04000581 RID: 1409
		[AccessedThroughProperty("txtteam1")]
		private ComboBox _txtteam1;

		// Token: 0x04000582 RID: 1410
		[AccessedThroughProperty("txtdate")]
		private DateTimePicker _txtdate;

		// Token: 0x04000583 RID: 1411
		[AccessedThroughProperty("txtid")]
		private TextBox _txtid;

		// Token: 0x04000584 RID: 1412
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000585 RID: 1413
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000586 RID: 1414
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000587 RID: 1415
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000588 RID: 1416
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000589 RID: 1417
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x0400058A RID: 1418
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x0400058B RID: 1419
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x0400058C RID: 1420
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x0400058D RID: 1421
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x0400058E RID: 1422
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x0400058F RID: 1423
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000590 RID: 1424
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000591 RID: 1425
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000592 RID: 1426
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000593 RID: 1427
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000594 RID: 1428
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000595 RID: 1429
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000596 RID: 1430
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000597 RID: 1431
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000598 RID: 1432
		[AccessedThroughProperty("Update")]
		private Button _Update;

		// Token: 0x04000599 RID: 1433
		[AccessedThroughProperty("Button2")]
		private Button _Button2;
	}
}
