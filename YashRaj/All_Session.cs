using System;
using System.Collections;
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
	// Token: 0x0200000B RID: 11
	//[DesignerGenerated]
	public partial class All_Session : Form
	{
		// Token: 0x06000383 RID: 899 RVA: 0x0029CD78 File Offset: 0x0029B178
		public All_Session()
		{
			//base.Load += this.All_Session_Load;
			this.InitializeComponent();
		}


		// Token: 0x060003C4 RID: 964 RVA: 0x0029E958 File Offset: 0x0029CD58
		private void All_Session_Load(object sender, EventArgs e)
		{
			this.sessionrept();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0029E960 File Offset: 0x0029CD60
		public void sessionrept()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				this.DataGridView2.Rows.Clear();
				string cmdText = "Select * from ewSession ORDER BY Sr_No DESC";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				while (oleDbDataReader.Read())
				{
					int index = this.DataGridView2.Rows.Add();
					this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);
					this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
					this.DataGridView2.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
					this.DataGridView2.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
					this.DataGridView2.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
				}
				//this.DataGridView2.Rows[0].Cells[1].Selected = true;
				//this.DataGridView2.Select();
				//SendKeys.Send("{TAB}");
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

		// Token: 0x060003C6 RID: 966 RVA: 0x0029EB44 File Offset: 0x0029CF44
		private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					this.txtid.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
					Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
					Module1.sessionid = this.txtid.Text;
					this.declear = RuntimeHelpers.GetObjectValue(this.DataGridView2.CurrentRow.Cells[2].Value);
					this._MYdate = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[0].Value);
					this.Button14_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (e.KeyCode == Keys.Escape)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0029ED1C File Offset: 0x0029D11C
		private void Button14_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txtid.Text, "", false) == 0)
				{
					MessageBox.Show("select sesstion match ?", "Sesstion", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else
				{
					MyProject.Forms.Form3_SESSION.MdiParent = this.MdiParent;
					MyProject.Forms.Form3_SESSION.Show();
					this.Close();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0029EDB0 File Offset: 0x0029D1B0
		private void btnDeclare_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * from ewSession where Match_ID=", Module1.sessionid), " and Sr_No="), Module1.nehaid), " and Result='Declared'"));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					Interaction.MsgBox("Match is Declared?", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					//Module1.sessiondelc = "1";
					MyProject.Forms.Declear_New_Sesstions.MdiParent = this.MdiParent;					
					MyProject.Forms.Declear_New_Sesstions.Show();					
					this.Close();
				}
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

		// Token: 0x060003CA RID: 970 RVA: 0x0029EEB0 File Offset: 0x0029D2B0
		private void BtnUnDeclare_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(Module1.sessionid.ToString(), "0", false) == 0)
				{
					Interaction.MsgBox("Please Select Match..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Operators.CompareString(Module1.nehaid.ToString(), "0", false) == 0)
				{
					Interaction.MsgBox("Please Select Match..?", MsgBoxStyle.OkOnly, null);
				}
				else if (Interaction.MsgBox("Do you want to undeclare this match ", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string text = Conversions.ToDate(this._MYdate).ToString("yyyy-MM-dd");
					string cmdText = string.Concat(new string[]
					{
						"SELECT tns_MatchID, tns_Monday_Final, tns_Sessionid FROM Trans WHERE (tns_MatchID = ",
						Module1.sessionid.ToString(),
						") AND (tns_Monday_Final = 'Yes') AND (tns_Sessionid = ",
						Module1.nehaid.ToString(),
						")AND (tns_dt=#",
						text.ToString(),
						"#)"
					});
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					if (oleDbDataReader.Read())
					{
						Interaction.MsgBox("Records are settled or Monday final for this Session Match..?", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						oleDbCommand.Clone();
						oleDbDataReader.Close();
						cmdText = string.Concat(new string[]
						{
							"UPDATE ewSession set Result='UnDeclared',Remark='0' where Sr_No=",
							Module1.nehaid.ToString(),
							" and Match_ID=",
							Module1.sessionid.ToString(),
							""
						});
						oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						oleDbCommand.ExecuteNonQuery();
						cmdText = string.Concat(new string[]
						{
							"DELETE FROM Trans WHERE (tns_MatchID = ",
							Module1.sessionid.ToString(),
							") AND (tns_Sessionid = ",
							Module1.nehaid.ToString(),
							")AND (tns_dt=#",
							text.ToString(),
							"#)"
						});
						oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						oleDbCommand.ExecuteNonQuery();
						
						//cmdText = string.Concat(new string[]
						//{
						//	"DELETE from Session_mst where Match_ID=",
						//	Module1.sessionid.ToString(),
						//	" and Session_ID=",
						//	Module1.nehaid.ToString(),
						//	""
						//});
						//oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						//oleDbCommand.ExecuteNonQuery();
						//string text2 = "DELETE from AKD_mst where Session_ID=" + Module1.nehaid.ToString() + "";
						//oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						//oleDbCommand.ExecuteNonQuery();

						this.sessionrept();
					}
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

		// Token: 0x060003CB RID: 971 RVA: 0x0029F1A8 File Offset: 0x0029D5A8
		private void btnmodify_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * from ewSession where Match_ID=", Module1.sessionid), " and Sr_No="), Module1.nehaid), " and Result='Declared'"));
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					Interaction.MsgBox("Match is Declared?", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					MyProject.Forms.modifySession.MdiParent = this.MdiParent;
					MyProject.Forms.modifySession.Show();
					this.Close();
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

		// Token: 0x060003CC RID: 972 RVA: 0x0029F2B4 File Offset: 0x0029D6B4
		private void btndelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (Interaction.MsgBox("Do you want to delete this record", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
				{
					if (Module1.conn.State == ConnectionState.Closed)
					{
						Module1.conn.Open();
					}
					string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * from ewSession where Match_ID=", Module1.sessionid), " and Sr_No="), Module1.nehaid), " and Result='Declared'"));
					OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
					OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
					if (oleDbDataReader.Read())
					{
						Interaction.MsgBox("Match is Declared?", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						//string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("DELETE from Session_mst where Match_ID=", Module1.sessionid), " and Session_ID="), Module1.nehaid));
						//OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
						//oleDbCommand2.ExecuteNonQuery();

						string cmdText3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("DELETE from ewSession where Match_ID=", Module1.sessionid), " and Sr_No="), Module1.nehaid));
						OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
						oleDbCommand3.ExecuteNonQuery();
						string cmdText4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("DELETE from SessionTrans where S_Sr_No=", Module1.sessionid), " and Session_ID="), Module1.nehaid));
						OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText4, Module1.conn);
						oleDbCommand4.ExecuteNonQuery();
						this.sessionrept();
					}
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

		// Token: 0x060003CD RID: 973 RVA: 0x0029F484 File Offset: 0x0029D884
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0029F48C File Offset: 0x0029D88C
		private void Button13_Click(object sender, EventArgs e)
		{
			MyProject.Forms.New_Session.MdiParent = this.MdiParent;
			MyProject.Forms.New_Session.Show();
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0029F4B4 File Offset: 0x0029D8B4
		private void DataGridView2_MouseEnter(object sender, EventArgs e)
		{
			this.sessionrept();
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0029F4BC File Offset: 0x0029D8BC
		private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txtid.Text, "", false) == 0)
				{
					MessageBox.Show("select sesstion match ?", "Sesstion", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else
				{
					MyProject.Forms.Form3_SESSION.MdiParent = this.MdiParent;
					MyProject.Forms.Form3_SESSION.Show();
					MyProject.Forms.Form3_SESSION.Session_Size();
					this.Close();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0029F62C File Offset: 0x0029DA2C
		private void DataGridView2_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, null, false))
				{
					this.txtid.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
					Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
					Module1.sessionid = RuntimeHelpers.GetObjectValue(this.DataGridView2.CurrentRow.Cells[3].Value);
					this.declear = RuntimeHelpers.GetObjectValue(this.DataGridView2.CurrentRow.Cells[2].Value);
					this._MYdate = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[0].Value);
					//Module1.sessiondelc = "1";
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0029F75C File Offset: 0x0029DB5C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.Panel4.Visible)
				{
					this.Panel4.Visible = true;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0029F7B4 File Offset: 0x0029DBB4
		private void Button4_Click(object sender, EventArgs e)
		{
			this.Panel4.Visible = false;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0029F7C4 File Offset: 0x0029DBC4
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				DateTime dateTime = Conversions.ToDate(this.DateTimePicker1.Text);
				DateTime dateTime2 = Conversions.ToDate(this.DateTimePicker2.Text);
				string text = dateTime.ToString("yyyy-MM-dd");
				string text2 = dateTime2.ToString("yyyy-MM-dd");
				string cmdText = string.Concat(new string[]
				{
					"SELECT Sr_No, Dt FROM ewSession WHERE (Dt >=#",
					text.ToString(),
					"#) AND (Dt <=#",
					text2.ToString(),
					"#)"
				});
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
				DataSet dataSet = new DataSet();
				DataTable dataTable = new DataTable();
				oleDbDataAdapter.SelectCommand = new OleDbCommand(cmdText, Module1.conn);
				oleDbDataAdapter.Fill(dataSet);
				dataTable = dataSet.Tables[0];
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						cmdText = "DELETE FROM ewSession WHERE(ewSession.Sr_No = " + NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							0
						}, null).ToString() + ")";
						OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						oleDbCommand.ExecuteNonQuery();
						cmdText = "DELETE FROM SessionTrans WHERE(SessionTrans.Session_ID = " + NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							0
						}, null).ToString() + ")";
						oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						oleDbCommand.ExecuteNonQuery();
						cmdText = "DELETE FROM tablakd WHERE (tablakd.Session_ID = " + NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							0
						}, null).ToString() + ")";
						oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
						oleDbCommand.ExecuteNonQuery();
					}
				}
				finally
				{
					//IEnumerator enumerator;
					//if (enumerator is IDisposable)
					//{
					//	(enumerator as IDisposable).Dispose();
					//}
					Module1.conn.Close();
				}
				this.sessionrept();
				this.Panel4.Visible = false;
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

		// Token: 0x060003D6 RID: 982 RVA: 0x0029FA44 File Offset: 0x0029DE44
		private void DataGridView2_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, null, false))
				{
					this.txtid.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
					Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
					Module1.sessionid = RuntimeHelpers.GetObjectValue(this.DataGridView2.CurrentRow.Cells[3].Value);
					this.declear = RuntimeHelpers.GetObjectValue(this.DataGridView2.CurrentRow.Cells[2].Value);
					this._MYdate = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[0].Value);
					//Module1.sessiondelc = "1";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040001A0 RID: 416
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040001A1 RID: 417
		[AccessedThroughProperty("btndelete")]
		private Button _btndelete;

		// Token: 0x040001A2 RID: 418
		[AccessedThroughProperty("btnmodify")]
		private Button _btnmodify;

		// Token: 0x040001A3 RID: 419
		[AccessedThroughProperty("BtnUnDeclare")]
		private Button _BtnUnDeclare;

		// Token: 0x040001A4 RID: 420
		[AccessedThroughProperty("btnDeclare")]
		private Button _btnDeclare;

		// Token: 0x040001A5 RID: 421
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		// Token: 0x040001A6 RID: 422
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		// Token: 0x040001A7 RID: 423
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040001A8 RID: 424
		[AccessedThroughProperty("txtid")]
		private TextBox _txtid;

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("txtsessinID")]
		private TextBox _txtsessinID;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("txttyp")]
		private TextBox _txttyp;

		// Token: 0x040001AB RID: 427
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040001AC RID: 428
		[AccessedThroughProperty("txtunde")]
		private TextBox _txtunde;

		// Token: 0x040001AD RID: 429
		[AccessedThroughProperty("txtdeclar")]
		private TextBox _txtdeclar;

		// Token: 0x040001AE RID: 430
		[AccessedThroughProperty("sessionmdi")]
		private TextBox _sessionmdi;

		// Token: 0x040001AF RID: 431
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x040001B0 RID: 432
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040001B1 RID: 433
		[AccessedThroughProperty("DataGridView2")]
		private DataGridView _DataGridView2;

		// Token: 0x040001B2 RID: 434
		[AccessedThroughProperty("Column1")]
		private DataGridViewTextBoxColumn _Column1;

		// Token: 0x040001B3 RID: 435
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x040001B4 RID: 436
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn _Column3;

		// Token: 0x040001B5 RID: 437
		[AccessedThroughProperty("Column4")]
		private DataGridViewTextBoxColumn _Column4;

		// Token: 0x040001B6 RID: 438
		[AccessedThroughProperty("Column5")]
		private DataGridViewTextBoxColumn _Column5;

		// Token: 0x040001B7 RID: 439
		[AccessedThroughProperty("Panel4")]
		private Panel _Panel4;

		// Token: 0x040001B8 RID: 440
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x040001B9 RID: 441
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x040001BA RID: 442
		[AccessedThroughProperty("DateTimePicker2")]
		private DateTimePicker _DateTimePicker2;

		// Token: 0x040001BB RID: 443
		[AccessedThroughProperty("DateTimePicker1")]
		private DateTimePicker _DateTimePicker1;

		// Token: 0x040001BC RID: 444
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040001BD RID: 445
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040001BE RID: 446
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040001BF RID: 447
		private object declear;

		// Token: 0x040001C0 RID: 448
		public string _MYdate;
	}
}



//// Token: 0x17000185 RID: 389
//// (get) Token: 0x06000386 RID: 902 RVA: 0x0029E248 File Offset: 0x0029C648
//// (set) Token: 0x06000387 RID: 903 RVA: 0x0029E25C File Offset: 0x0029C65C
//internal virtual Button Button1
//{
//	get
//	{
//		return this._Button1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button1_Click);
//		if (this._Button1 != null)
//		{
//			this._Button1.Click -= value2;
//		}
//		this._Button1 = value;
//		if (this._Button1 != null)
//		{
//			this._Button1.Click += value2;
//		}
//	}
//}

//// Token: 0x17000186 RID: 390
//// (get) Token: 0x06000388 RID: 904 RVA: 0x0029E2A8 File Offset: 0x0029C6A8
//// (set) Token: 0x06000389 RID: 905 RVA: 0x0029E2BC File Offset: 0x0029C6BC
//internal virtual Button btndelete
//{
//	get
//	{
//		return this._btndelete;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.btndelete_Click);
//		if (this._btndelete != null)
//		{
//			this._btndelete.Click -= value2;
//		}
//		this._btndelete = value;
//		if (this._btndelete != null)
//		{
//			this._btndelete.Click += value2;
//		}
//	}
//}

//// Token: 0x17000187 RID: 391
//// (get) Token: 0x0600038A RID: 906 RVA: 0x0029E308 File Offset: 0x0029C708
//// (set) Token: 0x0600038B RID: 907 RVA: 0x0029E31C File Offset: 0x0029C71C
//internal virtual Button btnmodify
//{
//	get
//	{
//		return this._btnmodify;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.btnmodify_Click);
//		if (this._btnmodify != null)
//		{
//			this._btnmodify.Click -= value2;
//		}
//		this._btnmodify = value;
//		if (this._btnmodify != null)
//		{
//			this._btnmodify.Click += value2;
//		}
//	}
//}

//// Token: 0x17000188 RID: 392
//// (get) Token: 0x0600038C RID: 908 RVA: 0x0029E368 File Offset: 0x0029C768
//// (set) Token: 0x0600038D RID: 909 RVA: 0x0029E37C File Offset: 0x0029C77C
//internal virtual Button BtnUnDeclare
//{
//	get
//	{
//		return this._BtnUnDeclare;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.BtnUnDeclare_Click);
//		if (this._BtnUnDeclare != null)
//		{
//			this._BtnUnDeclare.Click -= value2;
//		}
//		this._BtnUnDeclare = value;
//		if (this._BtnUnDeclare != null)
//		{
//			this._BtnUnDeclare.Click += value2;
//		}
//	}
//}

//// Token: 0x17000189 RID: 393
//// (get) Token: 0x0600038E RID: 910 RVA: 0x0029E3C8 File Offset: 0x0029C7C8
//// (set) Token: 0x0600038F RID: 911 RVA: 0x0029E3DC File Offset: 0x0029C7DC
//internal virtual Button btnDeclare
//{
//	get
//	{
//		return this._btnDeclare;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.btnDeclare_Click);
//		if (this._btnDeclare != null)
//		{
//			this._btnDeclare.Click -= value2;
//		}
//		this._btnDeclare = value;
//		if (this._btnDeclare != null)
//		{
//			this._btnDeclare.Click += value2;
//		}
//	}
//}

//// Token: 0x1700018A RID: 394
//// (get) Token: 0x06000390 RID: 912 RVA: 0x0029E428 File Offset: 0x0029C828
//// (set) Token: 0x06000391 RID: 913 RVA: 0x0029E43C File Offset: 0x0029C83C
//internal virtual Button Button13
//{
//	get
//	{
//		return this._Button13;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button13_Click);
//		if (this._Button13 != null)
//		{
//			this._Button13.Click -= value2;
//		}
//		this._Button13 = value;
//		if (this._Button13 != null)
//		{
//			this._Button13.Click += value2;
//		}
//	}
//}

//// Token: 0x1700018B RID: 395
//// (get) Token: 0x06000392 RID: 914 RVA: 0x0029E488 File Offset: 0x0029C888
//// (set) Token: 0x06000393 RID: 915 RVA: 0x0029E49C File Offset: 0x0029C89C
//internal virtual Button Button14
//{
//	get
//	{
//		return this._Button14;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button14_Click);
//		if (this._Button14 != null)
//		{
//			this._Button14.Click -= value2;
//		}
//		this._Button14 = value;
//		if (this._Button14 != null)
//		{
//			this._Button14.Click += value2;
//		}
//	}
//}

//// Token: 0x1700018C RID: 396
//// (get) Token: 0x06000394 RID: 916 RVA: 0x0029E4E8 File Offset: 0x0029C8E8
//// (set) Token: 0x06000395 RID: 917 RVA: 0x0029E4FC File Offset: 0x0029C8FC
//internal virtual Panel Panel1
//{
//	get
//	{
//		return this._Panel1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel1 = value;
//	}
//}

//// Token: 0x1700018D RID: 397
//// (get) Token: 0x06000396 RID: 918 RVA: 0x0029E508 File Offset: 0x0029C908
//// (set) Token: 0x06000397 RID: 919 RVA: 0x0029E51C File Offset: 0x0029C91C
//internal virtual TextBox txtid
//{
//	get
//	{
//		return this._txtid;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txtid = value;
//	}
//}

//// Token: 0x1700018E RID: 398
//// (get) Token: 0x06000398 RID: 920 RVA: 0x0029E528 File Offset: 0x0029C928
//// (set) Token: 0x06000399 RID: 921 RVA: 0x0029E53C File Offset: 0x0029C93C
//internal virtual TextBox txtsessinID
//{
//	get
//	{
//		return this._txtsessinID;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txtsessinID = value;
//	}
//}

//// Token: 0x1700018F RID: 399
//// (get) Token: 0x0600039A RID: 922 RVA: 0x0029E548 File Offset: 0x0029C948
//// (set) Token: 0x0600039B RID: 923 RVA: 0x0029E55C File Offset: 0x0029C95C
//internal virtual TextBox txttyp
//{
//	get
//	{
//		return this._txttyp;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txttyp = value;
//	}
//}

//// Token: 0x17000190 RID: 400
//// (get) Token: 0x0600039C RID: 924 RVA: 0x0029E568 File Offset: 0x0029C968
//// (set) Token: 0x0600039D RID: 925 RVA: 0x0029E57C File Offset: 0x0029C97C
//internal virtual TextBox TextBox1
//{
//	get
//	{
//		return this._TextBox1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._TextBox1 = value;
//	}
//}

//// Token: 0x17000191 RID: 401
//// (get) Token: 0x0600039E RID: 926 RVA: 0x0029E588 File Offset: 0x0029C988
//// (set) Token: 0x0600039F RID: 927 RVA: 0x0029E59C File Offset: 0x0029C99C
//internal virtual TextBox txtunde
//{
//	get
//	{
//		return this._txtunde;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txtunde = value;
//	}
//}

//// Token: 0x17000192 RID: 402
//// (get) Token: 0x060003A0 RID: 928 RVA: 0x0029E5A8 File Offset: 0x0029C9A8
//// (set) Token: 0x060003A1 RID: 929 RVA: 0x0029E5BC File Offset: 0x0029C9BC
//internal virtual TextBox txtdeclar
//{
//	get
//	{
//		return this._txtdeclar;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._txtdeclar = value;
//	}
//}

//// Token: 0x17000193 RID: 403
//// (get) Token: 0x060003A2 RID: 930 RVA: 0x0029E5C8 File Offset: 0x0029C9C8
//// (set) Token: 0x060003A3 RID: 931 RVA: 0x0029E5DC File Offset: 0x0029C9DC
//internal virtual TextBox sessionmdi
//{
//	get
//	{
//		return this._sessionmdi;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._sessionmdi = value;
//	}
//}

//// Token: 0x17000194 RID: 404
//// (get) Token: 0x060003A4 RID: 932 RVA: 0x0029E5E8 File Offset: 0x0029C9E8
//// (set) Token: 0x060003A5 RID: 933 RVA: 0x0029E5FC File Offset: 0x0029C9FC
//internal virtual Panel Panel2
//{
//	get
//	{
//		return this._Panel2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel2 = value;
//	}
//}

//// Token: 0x17000195 RID: 405
//// (get) Token: 0x060003A6 RID: 934 RVA: 0x0029E608 File Offset: 0x0029CA08
//// (set) Token: 0x060003A7 RID: 935 RVA: 0x0029E61C File Offset: 0x0029CA1C
//internal virtual Label Label1
//{
//	get
//	{
//		return this._Label1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label1 = value;
//	}
//}

//// Token: 0x17000196 RID: 406
//// (get) Token: 0x060003A8 RID: 936 RVA: 0x0029E628 File Offset: 0x0029CA28
//// (set) Token: 0x060003A9 RID: 937 RVA: 0x0029E63C File Offset: 0x0029CA3C
//internal virtual DataGridView DataGridView2
//{
//	get
//	{
//		return this._DataGridView2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		MouseEventHandler value2 = new MouseEventHandler(this.DataGridView2_MouseClick_1);
//		MouseEventHandler value3 = new MouseEventHandler(this.DataGridView2_MouseDoubleClick_1);
//		EventHandler value4 = new EventHandler(this.DataGridView2_SelectionChanged);
//		KeyEventHandler value5 = new KeyEventHandler(this.DataGridView2_KeyDown);
//		if (this._DataGridView2 != null)
//		{
//			this._DataGridView2.MouseClick -= value2;
//			this._DataGridView2.MouseDoubleClick -= value3;
//			this._DataGridView2.SelectionChanged -= value4;
//			this._DataGridView2.KeyDown -= value5;
//		}
//		this._DataGridView2 = value;
//		if (this._DataGridView2 != null)
//		{
//			this._DataGridView2.MouseClick += value2;
//			this._DataGridView2.MouseDoubleClick += value3;
//			this._DataGridView2.SelectionChanged += value4;
//			this._DataGridView2.KeyDown += value5;
//		}
//	}
//}

//// Token: 0x17000197 RID: 407
//// (get) Token: 0x060003AA RID: 938 RVA: 0x0029E6F8 File Offset: 0x0029CAF8
//// (set) Token: 0x060003AB RID: 939 RVA: 0x0029E70C File Offset: 0x0029CB0C
//internal virtual DataGridViewTextBoxColumn Column1
//{
//	get
//	{
//		return this._Column1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column1 = value;
//	}
//}

//// Token: 0x17000198 RID: 408
//// (get) Token: 0x060003AC RID: 940 RVA: 0x0029E718 File Offset: 0x0029CB18
//// (set) Token: 0x060003AD RID: 941 RVA: 0x0029E72C File Offset: 0x0029CB2C
//internal virtual DataGridViewTextBoxColumn Column2
//{
//	get
//	{
//		return this._Column2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column2 = value;
//	}
//}

//// Token: 0x17000199 RID: 409
//// (get) Token: 0x060003AE RID: 942 RVA: 0x0029E738 File Offset: 0x0029CB38
//// (set) Token: 0x060003AF RID: 943 RVA: 0x0029E74C File Offset: 0x0029CB4C
//internal virtual DataGridViewTextBoxColumn Column3
//{
//	get
//	{
//		return this._Column3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column3 = value;
//	}
//}

//// Token: 0x1700019A RID: 410
//// (get) Token: 0x060003B0 RID: 944 RVA: 0x0029E758 File Offset: 0x0029CB58
//// (set) Token: 0x060003B1 RID: 945 RVA: 0x0029E76C File Offset: 0x0029CB6C
//internal virtual DataGridViewTextBoxColumn Column4
//{
//	get
//	{
//		return this._Column4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column4 = value;
//	}
//}

//// Token: 0x1700019B RID: 411
//// (get) Token: 0x060003B2 RID: 946 RVA: 0x0029E778 File Offset: 0x0029CB78
//// (set) Token: 0x060003B3 RID: 947 RVA: 0x0029E78C File Offset: 0x0029CB8C
//internal virtual DataGridViewTextBoxColumn Column5
//{
//	get
//	{
//		return this._Column5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column5 = value;
//	}
//}

//// Token: 0x1700019C RID: 412
//// (get) Token: 0x060003B4 RID: 948 RVA: 0x0029E798 File Offset: 0x0029CB98
//// (set) Token: 0x060003B5 RID: 949 RVA: 0x0029E7AC File Offset: 0x0029CBAC
//internal virtual Panel Panel4
//{
//	get
//	{
//		return this._Panel4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel4 = value;
//	}
//}

//// Token: 0x1700019D RID: 413
//// (get) Token: 0x060003B6 RID: 950 RVA: 0x0029E7B8 File Offset: 0x0029CBB8
//// (set) Token: 0x060003B7 RID: 951 RVA: 0x0029E7CC File Offset: 0x0029CBCC
//internal virtual Button Button4
//{
//	get
//	{
//		return this._Button4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button4_Click);
//		if (this._Button4 != null)
//		{
//			this._Button4.Click -= value2;
//		}
//		this._Button4 = value;
//		if (this._Button4 != null)
//		{
//			this._Button4.Click += value2;
//		}
//	}
//}

//// Token: 0x1700019E RID: 414
//// (get) Token: 0x060003B8 RID: 952 RVA: 0x0029E818 File Offset: 0x0029CC18
//// (set) Token: 0x060003B9 RID: 953 RVA: 0x0029E82C File Offset: 0x0029CC2C
//internal virtual Button Button3
//{
//	get
//	{
//		return this._Button3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button3_Click);
//		if (this._Button3 != null)
//		{
//			this._Button3.Click -= value2;
//		}
//		this._Button3 = value;
//		if (this._Button3 != null)
//		{
//			this._Button3.Click += value2;
//		}
//	}
//}

//// Token: 0x1700019F RID: 415
//// (get) Token: 0x060003BA RID: 954 RVA: 0x0029E878 File Offset: 0x0029CC78
//// (set) Token: 0x060003BB RID: 955 RVA: 0x0029E88C File Offset: 0x0029CC8C
//internal virtual DateTimePicker DateTimePicker2
//{
//	get
//	{
//		return this._DateTimePicker2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DateTimePicker2 = value;
//	}
//}

//// Token: 0x170001A0 RID: 416
//// (get) Token: 0x060003BC RID: 956 RVA: 0x0029E898 File Offset: 0x0029CC98
//// (set) Token: 0x060003BD RID: 957 RVA: 0x0029E8AC File Offset: 0x0029CCAC
//internal virtual DateTimePicker DateTimePicker1
//{
//	get
//	{
//		return this._DateTimePicker1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._DateTimePicker1 = value;
//	}
//}

//// Token: 0x170001A1 RID: 417
//// (get) Token: 0x060003BE RID: 958 RVA: 0x0029E8B8 File Offset: 0x0029CCB8
//// (set) Token: 0x060003BF RID: 959 RVA: 0x0029E8CC File Offset: 0x0029CCCC
//internal virtual Label Label3
//{
//	get
//	{
//		return this._Label3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label3 = value;
//	}
//}

//// Token: 0x170001A2 RID: 418
//// (get) Token: 0x060003C0 RID: 960 RVA: 0x0029E8D8 File Offset: 0x0029CCD8
//// (set) Token: 0x060003C1 RID: 961 RVA: 0x0029E8EC File Offset: 0x0029CCEC
//internal virtual Label Label2
//{
//	get
//	{
//		return this._Label2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label2 = value;
//	}
//}

//// Token: 0x170001A3 RID: 419
//// (get) Token: 0x060003C2 RID: 962 RVA: 0x0029E8F8 File Offset: 0x0029CCF8
//// (set) Token: 0x060003C3 RID: 963 RVA: 0x0029E90C File Offset: 0x0029CD0C
//internal virtual Button Button2
//{
//	get
//	{
//		return this._Button2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button2_Click);
//		if (this._Button2 != null)
//		{
//			this._Button2.Click -= value2;
//		}
//		this._Button2 = value;
//		if (this._Button2 != null)
//		{
//			this._Button2.Click += value2;
//		}
//	}
//}