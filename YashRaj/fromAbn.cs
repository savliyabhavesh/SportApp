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
using App.Service;

namespace YashAksh
{
    // Token: 0x02000047 RID: 71
    //[DesignerGenerated]
    public partial class fromAbn : Form
    {
        // Token: 0x06001089 RID: 4233 RVA: 0x0032B85C File Offset: 0x00329C5C
        public fromAbn()
        {
            this.InitializeComponent();
        }

        // Token: 0x06001116 RID: 4374 RVA: 0x0032EFA0 File Offset: 0x0032D3A0
        private void fromAbn_Activated(object sender, EventArgs e)
        {
            this.txtamount.Focus();
        }

        // Token: 0x06001117 RID: 4375 RVA: 0x0032EFB0 File Offset: 0x0032D3B0
        private void fromAbn_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView1.Columns[0].Width = 150;
                this.txtmatchID.Text = Conversions.ToString(Module1.machid);
                this.txtnu.Text = Module1.decimalnumberformat;

                this.BTNOK.Show();
                this.Button7.Hide();
                this.Button9.Hide();

                this.DataGridView1.Rows.Add(new object[]
                {
                "ABDN"
                });
                this.DataGridView1.Rows.Add(new object[]
                {
                "Non-ABDN"
                });
                this.DataGridView1.Rows.Add(new object[]
                {
                "Tie"
                });
                this.DataGridView1.Rows.Add(new object[]
                {
                "Non-Tie"
                });
                this.all_lode();
                this.CheckBox2.Hide();
                this.lod_newPartyname();
                this.show_Tranjaction();
                this.Button15_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.srno();
                this.txtABDN.Text = "0";
                this.txtNonABDN.Text = "0";
                this.txtTie.Text = "0";
                this.txtNontie.Text = "0";
                this.Regular_All_Tems();
                this.Regular_total();
                this.Regular_Tie_Non_Tie();
                this.Regular_Tile_total();
                this.Booky_All_Tems();
                this.Booky_total();
                this.Booky_Tie_Non_Tie();
                this.Booky_Tile_total();
                this.All_Total();
                this.Decleard();
                this.txtamount.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001118 RID: 4376 RVA: 0x0032F1D4 File Offset: 0x0032D5D4
        public void formatdaatgrid()
        {
            try
            {
                this.DataGridView1.Columns[1].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[2].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[3].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[4].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[5].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[6].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[7].DefaultCellStyle.Format = Module1.NumFormat;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001119 RID: 4377 RVA: 0x0032F328 File Offset: 0x0032D728
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.txtmatchID.Text + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Button8.Enabled = false;
                    this.btndalete.Enabled = false;
                    this.BTNOK.Enabled = false;
                }
                else
                {
                    this.Button8.Enabled = true;
                    this.btndalete.Enabled = true;
                    this.BTNOK.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600111A RID: 4378 RVA: 0x0032F414 File Offset: 0x0032D814
        public void all_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.txtmatchID.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", oleDbDataReader[4]), " )"), "       "), oleDbDataReader[2]), " "), " VS "), " "), oleDbDataReader[3]), "      "), oleDbDataReader[1]));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600111C RID: 4380 RVA: 0x0032F5D8 File Offset: 0x0032D9D8
        public void show_Tranjaction()
        {
            try
            {
                this.DataGridView3.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Abdntie where Match_ID=" + this.txtmatchID.Text + " Order By ID desc";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView3.Rows.Add();
                    this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
                    this.DataGridView3.Rows[index].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]), this.txtnu.Text);
                    this.DataGridView3.Rows[index].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), this.txtnu.Text);
                    this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    this.DataGridView3.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    this.DataGridView3.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    this.DataGridView3.Rows[index].Cells[6].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[10]), this.txtnu.Text);
                    this.DataGridView3.Rows[index].Cells[7].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[11]), this.txtnu.Text);
                    this.DataGridView3.Rows[index].Cells[8].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]), this.txtnu.Text);
                    this.DataGridView3.Rows[index].Cells[9].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[13]), this.txtnu.Text);
                    this.DataGridView3.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
                    this.DataGridView3.Rows[index].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
                    this.DataGridView3.Rows[index].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[16]);

                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "1", false))
                    {
                        this.DataGridView3.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                        //this.DataGridView3.Rows[index].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                    }
                    else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["A_Modify"], "1", false))
                    {
                        this.DataGridView3.Rows[index].DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                    {
                        this.DataGridView3.Rows[index].DefaultCellStyle.ForeColor = Color.Lime;
                    }



                    //if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "1", false))
                    //{
                    //	int index = this.DataGridView3.Rows.Add();
                    //	this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
                    //	this.DataGridView3.Rows[index].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    //	this.DataGridView3.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    //	this.DataGridView3.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    //	this.DataGridView3.Rows[index].Cells[6].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[10]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index].Cells[7].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[11]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index].Cells[8].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index].Cells[9].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[13]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
                    //	this.DataGridView3.Rows[index].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
                    //	this.DataGridView3.Rows[index].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[16]);
                    //	this.DataGridView3.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                    //}
                    //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                    //{
                    //	int index2 = this.DataGridView3.Rows.Add();
                    //	this.DataGridView3.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
                    //	this.DataGridView3.Rows[index2].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index2].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    //	this.DataGridView3.Rows[index2].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    //	this.DataGridView3.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    //	this.DataGridView3.Rows[index2].Cells[6].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[10]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index2].Cells[7].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[11]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index2].Cells[8].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index2].Cells[9].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[13]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index2].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
                    //	this.DataGridView3.Rows[index2].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
                    //	this.DataGridView3.Rows[index2].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[16]);
                    //	this.DataGridView3.Rows[index2].DefaultCellStyle.ForeColor = Color.Blue;
                    //}
                    //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["A_Modify"], "1", false))
                    //{
                    //	int index3 = this.DataGridView3.Rows.Add();
                    //	this.DataGridView3.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
                    //	this.DataGridView3.Rows[index3].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index3].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index3].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    //	this.DataGridView3.Rows[index3].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    //	this.DataGridView3.Rows[index3].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    //	this.DataGridView3.Rows[index3].Cells[6].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[10]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index3].Cells[7].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[11]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index3].Cells[8].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index3].Cells[9].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[13]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index3].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
                    //	this.DataGridView3.Rows[index3].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
                    //	this.DataGridView3.Rows[index3].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[16]);
                    //	this.DataGridView3.Rows[index3].DefaultCellStyle.ForeColor = Color.Blue;
                    //}
                    //else
                    //{
                    //	int index4 = this.DataGridView3.Rows.Add();
                    //	this.DataGridView3.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[0]);
                    //	this.DataGridView3.Rows[index4].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index4].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[4]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index4].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    //	this.DataGridView3.Rows[index4].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    //	this.DataGridView3.Rows[index4].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    //	this.DataGridView3.Rows[index4].Cells[6].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[10]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index4].Cells[7].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[11]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index4].Cells[8].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[12]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index4].Cells[9].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader[13]), this.txtnu.Text);
                    //	this.DataGridView3.Rows[index4].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[9]);
                    //	this.DataGridView3.Rows[index4].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[1]);
                    //	this.DataGridView3.Rows[index4].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[16]);
                    //}
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600111D RID: 4381 RVA: 0x003302A0 File Offset: 0x0032E6A0
        private void btnExit_Click(object sender, EventArgs e)
        {
            //MyProject.Forms.Match.MdiParent = this.MdiParent;
            //MyProject.Forms.Match.Show();
            this.Close();
        }

        // Token: 0x0600111E RID: 4382 RVA: 0x003302CC File Offset: 0x0032E6CC
        public void ABN_And_Tie()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select sum(SAbandon)+sum(AAbandon)+sum(TAbandon) from PartyMaster where PartyName='" + this.txtparty.Text + "' ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                {
                    double num = Convert.ToDouble(oleDbCommand.ExecuteScalar());
                    this.txtabp.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600111F RID: 4383 RVA: 0x003303AC File Offset: 0x0032E7AC
        public void Tie_and_parsent()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select sum(STie)+sum(ATie)+sum(TTie)from PartyMaster where PartyName='" + this.txtparty.Text + "' ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                {
                    double num = Convert.ToDouble(oleDbCommand.ExecuteScalar());
                    this.txtabp.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001120 RID: 4384 RVA: 0x00330498 File Offset: 0x0032E898
        private void BTNOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtparty_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                if (Operators.CompareString(this.txtparty.Text, "", false) == 0)
                {
                    MessageBox.Show("Enter Party Name");
                }
                else
                {
                    this.txtteam_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                    this.srno();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = $"Insert Into Abdntie values ({this.txtid.Text},{this.txtmatchID.Text},'{this.txtpage.Text}',{this.txtamount.Text},{this.txtrate.Text},'{this.txtteam.Text}','{this.txtmode.Text}','{this.txtparty.Text}','{Conversions.ToString(DateAndTime.Now.Date)}' ,'{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}','{this.txtABDN.Text}','{this.txtNonABDN.Text}','{this.txtTie.Text}','{this.txtNontie.Text}','{Conversions.ToString(DateAndTime.Now.Date)}','{this.txtregular.Text}','0','{this.txtabp.Text}',0,0)";
                    using (AbdntieService abdntieService = new AbdntieService())
                    {
                        abdntieService.Update(cmdText);
                    }
                    this.show_Tranjaction();
                }
                this.txtABDN.Text = "0";
                this.txtNonABDN.Text = "0";
                this.txtTie.Text = "0";
                this.txtNontie.Text = "0";

                this.Regular_All_Tems();
                this.Regular_total();
                this.Regular_Tie_Non_Tie();
                this.Regular_Tile_total();
                this.Booky_All_Tems();
                this.Booky_total();
                this.Booky_Tie_Non_Tie();
                this.Booky_Tile_total();

                this.All_Total();
                this.DataGridView1.DefaultCellStyle.Format = this.txtnu.Text;
                this.txtamount.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001121 RID: 4385 RVA: 0x00330820 File Offset: 0x0032EC20
        public void ABDN_parsent_update()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = $"update Abdntie set A_P='{this.txtabp.Text}' where Party_Name='{this.txtparty.Text}'And Team='{this.txtteam.Text}'and DARA='{this.txtregular.Text}";
                using (AbdntieService abdntieService = new AbdntieService())
                {
                    abdntieService.Update(cmdText);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001122 RID: 4386 RVA: 0x0033090C File Offset: 0x0032ED0C
        public void ABDN()
        {
            try
            {
                this.txttotal.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                if (Operators.CompareString(this.txtteam.Text, "ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtABDN.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtNonABDN.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtNonABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtNonABDN.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtABDN.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-ABDN", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtNonABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtABDN.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001123 RID: 4387 RVA: 0x00330C00 File Offset: 0x0032F000
        public void Tie()
        {
            try
            {
                this.txttotal.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                if (Operators.CompareString(this.txtteam.Text, "Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtTie.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtNontie.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtTie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtNontie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "K", false) == 0)
                {
                    this.txtNontie.Text = Conversions.ToString(Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text) - Conversion.Val(this.txttotal.Text));
                    this.txtTie.Text = this.txtamount.Text;
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-Tie", false) == 0 & Operators.CompareString(this.txtmode.Text, "L", false) == 0)
                {
                    this.txtNontie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtTie.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001124 RID: 4388 RVA: 0x00330EF4 File Offset: 0x0032F2F4
        public void lod_newPartyname()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "1", false))
                    {
                        int index = this.DataGridView2.Rows.Add();
                        this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                        this.txtparty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                        this.txtregular.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Status"]));
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001125 RID: 4389 RVA: 0x00331070 File Offset: 0x0032F470
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtparty.SelectionStart <= 1)
                        {
                            this.txtparty.Text = "";
                            return;
                        }
                        if (this.txtparty.SelectionLength == 0)
                        {
                            text = this.txtparty.Text.Substring(0, this.txtparty.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart - 1);
                        }
                    }
                    else if (this.txtparty.SelectionLength == 0)
                    {
                        text = this.txtparty.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtparty.FindString(text);
                    if (num != -1)
                    {
                        this.txtparty.SelectedText = "";
                        this.txtparty.SelectedIndex = num;
                        this.txtparty.SelectionStart = text.Length;
                        this.txtparty.SelectionLength = this.txtparty.Text.Length;
                        e.Handled = true;
                    }
                    else if (blnLimitToList)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001126 RID: 4390 RVA: 0x003311CC File Offset: 0x0032F5CC
        private void txtparty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtparty = this.txtparty;
                this.AutoComplete(ref txtparty, e, false);
                this.txtparty = txtparty;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001128 RID: 4392 RVA: 0x00331440 File Offset: 0x0032F840
        public void hide_all()
        {
            try
            {
                this.txtregular.Hide();
                this.txtABDN.Hide();
                this.txtNonABDN.Hide();
                this.txtABDN.Hide();
                this.txttotal.Hide();
                this.txtNontie.Hide();
                this.txtmatchID.Hide();
                this.txtime.Hide();
                this.txtmatchID.Hide();
                this.txtNontie.Hide();
                this.txtTie.Hide();
                this.txtid.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001129 RID: 4393 RVA: 0x003314D4 File Offset: 0x0032F8D4
        private void txtparty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtregular.SelectedIndex = this.txtparty.SelectedIndex;
                if (Operators.CompareString(this.txtteam.Text, "ABDN", false) == 0)
                {
                    this.ABN_And_Tie();
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-ABDN", false) == 0)
                {
                    this.ABN_And_Tie();
                }
                else if (Operators.CompareString(this.txtteam.Text, "Tie", false) == 0)
                {
                    this.Tie_and_parsent();
                }
                else if (Operators.CompareString(this.txtteam.Text, "Non-Tie", false) == 0)
                {
                    this.Tie_and_parsent();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600112A RID: 4394 RVA: 0x0033157C File Offset: 0x0032F97C
        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView1.Rows[0].Cells[1].Value = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[4].Value))) + this.txtnu.Text;
                this.DataGridView1.Rows[1].Cells[1].Value = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[4].Value))) + this.txtnu.Text;
                this.DataGridView1.Rows[2].Cells[1].Value = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[2].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[2].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[2].Cells[4].Value))) + this.txtnu.Text;
                this.DataGridView1.Rows[3].Cells[1].Value = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[3].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[3].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[3].Cells[4].Value))) + this.txtnu.Text;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600112B RID: 4395 RVA: 0x003318A8 File Offset: 0x0032FCA8
        private void srno()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select max(ID) from Abdntie where Match_ID=" + this.txtmatchID.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                double num = 0.0;
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                {
                    num = Convert.ToDouble(oleDbCommand.ExecuteScalar());
                }
                num += 1.0;
                this.txtid.Text = Conversions.ToString(num);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600112C RID: 4396 RVA: 0x00331978 File Offset: 0x0032FD78
        private void DataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, null, false))
                {
                    this.txtdelete.Text = Conversions.ToString(this.DataGridView3.CurrentRow.Cells[0].Value);
                    Module1.sonu = RuntimeHelpers.GetObjectValue(this.DataGridView3.CurrentRow.Cells[5].Value);
                    this.delete = Conversions.ToInteger(this.DataGridView3.CurrentRow.Cells[12].Value);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0600112D RID: 4397 RVA: 0x00331A48 File Offset: 0x0032FE48
        private void txtamount_Leave(object sender, EventArgs e)
        {
            try
            {
                //this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
                if (this.txtamount.Text != "")
                {
                    this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0600112E RID: 4398 RVA: 0x00331A7C File Offset: 0x0032FE7C
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DPP_AbnTie dPP_AbnTie = new DPP_AbnTie();
                dPP_AbnTie.MdiParent = this.MdiParent;
                dPP_AbnTie.WindowState = FormWindowState.Maximized;
                dPP_AbnTie.Show();
                //this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0600112F RID: 4399 RVA: 0x00331AB8 File Offset: 0x0032FEB8
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Agent_abntie agent_Abntie = new Agent_abntie();
                agent_Abntie.Show();

                //MyProject.Forms.Agent_abntie.MdiParent = this.MdiParent;
                //MyProject.Forms.Agent_abntie.WindowState = FormWindowState.Maximized;
                //MyProject.Forms.Agent_abntie.Show();
                //this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001131 RID: 4401 RVA: 0x00331B40 File Offset: 0x0032FF40
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                New_Party new_Party = new New_Party();
                new_Party.MdiParent = this.MdiParent;
                new_Party.WindowState = FormWindowState.Maximized;
                new_Party.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001133 RID: 4403 RVA: 0x00331B6C File Offset: 0x0032FF6C
        private void btndalete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double)this.delete == Convert.ToDouble("1"))
                {
                    Interaction.MsgBox("Sorry this record not delete", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = $"update Abdntie set Delete_CHK=1 where Match_ID={this.txtmatchID.Text} and ID={this.txtdelete.Text}";
                    using (AbdntieService abdntieService = new AbdntieService())
                    {
                        abdntieService.Update(cmdText);
                    }
                    this.DataGridView3.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                    this.Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.Regular_All_Tems();
                    this.Regular_total();
                    this.Regular_Tie_Non_Tie();
                    this.Regular_Tile_total();
                    this.Booky_All_Tems();
                    this.Booky_total();
                    this.Booky_Tie_Non_Tie();
                    this.Booky_Tile_total();
                    this.All_Total();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001134 RID: 4404 RVA: 0x00331CC0 File Offset: 0x003300C0
        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtdelete.Text, "", false) == 0)
                {
                    Interaction.MsgBox("select Record", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "Select * from Abdntie where Match_ID=",
                        this.txtmatchID.Text,
                        " and ID=",
                        this.txtdelete.Text,
                        ""
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "1", false))
                        {
                            Interaction.MsgBox("can not edit this record", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            this.BTNOK.Hide();
                            this.Button7.Show();
                            this.Button9.Show();
                            this.txtid.Text = Conversions.ToString(oleDbDataReader[0]);
                            this.txtamount.Text = Conversions.ToString(oleDbDataReader[3]);
                            this.txtrate.Text = Conversions.ToString(oleDbDataReader[4]);
                            this.txtteam.Text = Conversions.ToString(oleDbDataReader[5]);
                            this.txtmode.Text = Conversions.ToString(oleDbDataReader[6]);
                            this.txtime.Text = Conversions.ToString(oleDbDataReader["Time"]);
                            this.txtABDN.Text = Conversions.ToString(oleDbDataReader[10]);
                            this.txtNonABDN.Text = Conversions.ToString(oleDbDataReader[11]);
                            this.txtTie.Text = Conversions.ToString(oleDbDataReader[12]);
                            this.txtNontie.Text = Conversions.ToString(oleDbDataReader[13]);
                            this.txtpage.Text = Conversions.ToString(oleDbDataReader[2]);
                            this.txtparty.Text = Conversions.ToString(oleDbDataReader[7]);
                            this.txtparty_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                        }
                    }
                    Module1.conn.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001135 RID: 4405 RVA: 0x00331F70 File Offset: 0x00330370
        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.BTNOK.Show();
                this.Button7.Hide();
                this.Button9.Hide();

                txtamount.Focus();
                txtamount.Text = "";
                txtrate.Text = "";
                txtparty.Text = "";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001136 RID: 4406 RVA: 0x00331FC0 File Offset: 0x003303C0
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Open)
                {
                    Module1.conn.Close();
                }
                if (Operators.CompareString(this.txtparty.Text, "", false) == 0)
                {
                    MessageBox.Show("Party Name");
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = $"delete* from Abdntie where Match_ID={this.txtmatchID.Text} and ID={this.txtdelete.Text}";
                    using (AbdntieService abdntieService = new AbdntieService())
                    {
                        abdntieService.Update(cmdText);
                    }
                    this.txtparty_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                    if (Operators.CompareString(this.txtparty.Text, "", false) == 0)
                    {
                        MessageBox.Show("Party Name");
                    }
                    else
                    {
                        this.txtteam_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText2 = $"Insert Into Abdntie values ({this.txtid.Text},{this.txtmatchID.Text},'{this.txtpage.Text}',{this.txtamount.Text},{this.txtrate.Text},'{this.txtteam.Text}','{this.txtmode.Text}','{this.txtparty.Text}','{Conversions.ToString(DateAndTime.Now.Date)}' ,'{this.txtime.Text}','{this.txtABDN.Text}','{this.txtNonABDN.Text}','{this.txtTie.Text}','{this.txtNontie.Text}','{Conversions.ToString(DateAndTime.Now.Date)}','{this.txtregular.Text}','0','{this.txtabp.Text}',0,0)";

                        string cmdText3 = $"update  Abdntie set A_Modify=1 where Match_ID={this.txtmatchID.Text} and ID={this.txtdelete.Text}";
                        using (AbdntieService abdntieService = new AbdntieService())
                        {
                            abdntieService.Update(cmdText2);
                            abdntieService.Update(cmdText3);
                        }
                        this.ABDN_parsent_update();
                        this.show_Tranjaction();
                    }
                    this.txtABDN.Text = "0";
                    this.txtNonABDN.Text = "0";
                    this.txtTie.Text = "0";
                    this.txtNontie.Text = "0";
                    this.srno();
                    this.Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    this.BTNOK.Show();
                    this.Button7.Hide();
                    this.Button9.Hide();
                    this.Regular_All_Tems();
                    this.Regular_total();
                    this.Regular_Tie_Non_Tie();
                    this.Regular_Tile_total();
                    this.Booky_All_Tems();
                    this.Booky_total();
                    this.Booky_Tie_Non_Tie();
                    this.Booky_Tile_total();
                    this.All_Total();


                    txtamount.Focus();
                    txtamount.Text = "";
                    txtrate.Text = "";
                    txtparty.Text = "";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001137 RID: 4407 RVA: 0x00332438 File Offset: 0x00330838
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                this.DataGridView1.Rows.Add(new object[]
                {
                "ABDN"
                });
                this.DataGridView1.Rows.Add(new object[]
                {
                "Non-ABDN"
                });
                this.DataGridView1.Rows.Add(new object[]
                {
                "Tie"
                });
                this.DataGridView1.Rows.Add(new object[]
                {
                "Non-Tie"
                });

                this.txtnu.Text = Module1.decimalnumberformat;
                this.CheckBox2.Hide();
                this.lod_newPartyname();
                this.show_Tranjaction();
                this.Button15_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.srno();
                this.txtABDN.Text = "0";
                this.txtNonABDN.Text = "0";
                this.txtTie.Text = "0";
                this.txtNontie.Text = "0";
                this.Regular_All_Tems();
                this.Regular_total();
                this.Regular_Tie_Non_Tie();
                this.Regular_Tile_total();
                this.Booky_All_Tems();
                this.Booky_total();
                this.Booky_Tie_Non_Tie();
                this.Booky_Tile_total();
                this.All_Total();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001138 RID: 4408 RVA: 0x003325D0 File Offset: 0x003309D0
        private void fromAbn_MouseEnter(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        // Token: 0x0600113E RID: 4414 RVA: 0x00332654 File Offset: 0x00330A54
        private void txtteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ABDN();
                this.Tie();
                if (Operators.CompareString(this.txtteam.Text, "ABDN", false) == 0)
                {
                    this.txtTie.Text = "0";
                    this.txtNontie.Text = "0";
                }
                if (Operators.CompareString(this.txtteam.Text, "Non-ABDN", false) == 0)
                {
                    this.txtTie.Text = "0";
                    this.txtNontie.Text = "0";
                }
                if (Operators.CompareString(this.txtteam.Text, "Tie", false) == 0)
                {
                    this.txtABDN.Text = "0";
                    this.txtNonABDN.Text = "0";
                }
                if (Operators.CompareString(this.txtteam.Text, "Non-Tie", false) == 0)
                {
                    this.txtABDN.Text = "0";
                    this.txtNonABDN.Text = "0";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600113F RID: 4415 RVA: 0x00332754 File Offset: 0x00330B54
        private void txtparty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtparty.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        this.BTNOK.Focus();
                        this.Button7.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001140 RID: 4416 RVA: 0x003327D0 File Offset: 0x00330BD0
        private void txtrate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtrate.Text != "")
                {
                    string text = this.txtrate.Text;
                    double num = (double)text.IndexOf(".");
                    if (num < 0.0)
                    {
                        this.txtrate.Text = this.txtrate.Text.Replace(this.txtrate.Text, "." + this.txtrate.Text);
                    }
                    this.txtrate.Text = Module1.SetNumFormat(Conversion.Val(this.txtrate.Text), this.txtnu.Text);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001141 RID: 4417 RVA: 0x0033289C File Offset: 0x00330C9C
        private void DataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DPP_AbnTie dPP_AbnTie = new DPP_AbnTie();
                dPP_AbnTie.MdiParent = this.MdiParent;
                dPP_AbnTie.WindowState = FormWindowState.Maximized;
                dPP_AbnTie.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001142 RID: 4418 RVA: 0x00332900 File Offset: 0x00330D00
        public void Regular_All_Tems()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView4.Rows.Clear();
                string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SAbandon, PartyMaster.AAbandon, PartyMaster.TAbandon, Abdntie.Match_ID, SUM(Abdntie.ABDN) AS Expr4, SUM(Abdntie.Non_ABDN) AS Expr5, Abdntie.Delete_CHK FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.PartyName, PartyMaster.Status, Abdntie.Match_ID, Abdntie.Delete_CHK, PartyMaster.SAbandon, PartyMaster.AAbandon, PartyMaster.TAbandon HAVING (Abdntie.Delete_CHK = '0') AND (PartyMaster.Status = 'Regular') AND (Abdntie.Match_ID = " + this.txtmatchID.Text + ")";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    //double num = Convert.ToDouble(Operators.AddObject(Operators.AddObject(oleDbDataReader["Expr1"], oleDbDataReader["Expr2"]), oleDbDataReader["Expr3"]));
                    //double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    //double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    //double num4 = Conversion.Val(0.01) * Conversion.Val(num);
                    //double num5 = Conversion.Val(num4) * Conversion.Val(num2) - Conversion.Val(num2);
                    //double num6 = Conversion.Val(num4) * Conversion.Val(num3) - Conversion.Val(num3);
                    //this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                    //this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);

                    double num = Conversion.Val(0.01) * Convert.ToDouble(oleDbDataReader["SAbandon"]);
                    double num1 = Conversion.Val(0.01) * Convert.ToDouble(Operators.AddObject((oleDbDataReader["AAbandon"]), oleDbDataReader["TAbandon"]));

                    double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);

                    double num5 = Conversion.Val(num) * Conversion.Val(num2) - Conversion.Val(num2);
                    double num6 = Conversion.Val(num) * Conversion.Val(num3) - Conversion.Val(num3);

                    double num7 = Conversion.Val(num1) * Conversion.Val(num5) - Conversion.Val(num5);
                    double num8 = Conversion.Val(num1) * Conversion.Val(num6) - Conversion.Val(num6);

                    int index = this.DataGridView4.Rows.Add();
                    this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num7); //- Conversion.Val(num7) - Conversion.Val(num7);
                    this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num8); //- Conversion.Val(num8) - Conversion.Val(num8);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001143 RID: 4419 RVA: 0x00332B44 File Offset: 0x00330F44
        public void Regular_total()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView4.RowCount - 1;
                    double num3 = 0;
                    double num4 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[0].Value));
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[1].Value));
                        }
                    }
                    this.DataGridView1.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView1.Rows[1].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x06001144 RID: 4420 RVA: 0x00332C78 File Offset: 0x00331078
        public void Regular_Tie_Non_Tie()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView4.Rows.Clear();
                string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.STie, PartyMaster.ATie, PartyMaster.TTie, Abdntie.Match_ID, SUM(Abdntie.Tie) AS Expr4, SUM(Abdntie.Non_Tie) AS Expr5, Abdntie.Delete_CHK FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.PartyName, PartyMaster.Status, Abdntie.Match_ID, Abdntie.Delete_CHK, PartyMaster.STie, PartyMaster.ATie, PartyMaster.TTie HAVING (Abdntie.Delete_CHK = '0') AND (Abdntie.Match_ID = " + this.txtmatchID.Text + ") AND (PartyMaster.Status = 'Regular')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    //double num = Convert.ToDouble(Operators.AddObject(Operators.AddObject(oleDbDataReader["Expr1"], oleDbDataReader["Expr2"]), oleDbDataReader["Expr3"]));
                    //double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    //double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    //double num4 = Conversion.Val(0.01) * Conversion.Val(num);
                    //double num5 = Conversion.Val(num4) * Conversion.Val(num2) - Conversion.Val(num2);
                    //double num6 = Conversion.Val(num4) * Conversion.Val(num3) - Conversion.Val(num3);
                    //int index = this.DataGridView4.Rows.Add();
                    //this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                    //this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);

                    double num = Conversion.Val(0.01) * Convert.ToDouble(oleDbDataReader["STie"]);
                    double num1 = Conversion.Val(0.01) * Convert.ToDouble(Operators.AddObject((oleDbDataReader["ATie"]), oleDbDataReader["TTie"]));

                    double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);

                    double num5 = Conversion.Val(num) * Conversion.Val(num2) - Conversion.Val(num2);
                    double num6 = Conversion.Val(num) * Conversion.Val(num3) - Conversion.Val(num3);

                    double num7 = Conversion.Val(num1) * Conversion.Val(num5) - Conversion.Val(num5);
                    double num8 = Conversion.Val(num1) * Conversion.Val(num6) - Conversion.Val(num6);

                    int index = this.DataGridView4.Rows.Add();
                    this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num7); //- Conversion.Val(num7) - Conversion.Val(num7);
                    this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num8); //- Conversion.Val(num8) - Conversion.Val(num8);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001145 RID: 4421 RVA: 0x00332EBC File Offset: 0x003312BC
        public void Regular_Tile_total()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView4.RowCount - 1;
                    double num3 = 0;
                    double num4 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[0].Value));
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[1].Value));
                        }
                    }
                    this.DataGridView1.Rows[2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView1.Rows[3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x0600114A RID: 4426 RVA: 0x003336E0 File Offset: 0x00331AE0
        public void Booky_All_Tems()
        {
            try
            {
                this.DataGridView4.Rows.Clear();
                string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SAbandon, PartyMaster.AAbandon, PartyMaster.TAbandon, Abdntie.Match_ID, SUM(Abdntie.ABDN) AS Expr4, SUM(Abdntie.Non_ABDN) AS Expr5, Abdntie.Delete_CHK FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.PartyName, PartyMaster.Status, Abdntie.Match_ID, Abdntie.Delete_CHK, PartyMaster.SAbandon, PartyMaster.AAbandon, PartyMaster.TAbandon HAVING (Abdntie.Delete_CHK = '0') AND (PartyMaster.Status = 'Booky') AND (Abdntie.Match_ID = " + this.txtmatchID.Text + ")";
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    //double num = Convert.ToDouble(Operators.AddObject(Operators.AddObject(oleDbDataReader["Expr1"], oleDbDataReader["Expr2"]), oleDbDataReader["Expr3"]));
                    //double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    //double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    //double num4 = Conversion.Val(0.01) * Conversion.Val(num);
                    //int index = this.DataGridView4.Rows.Add();
                    //double num5 = Conversion.Val(num4) * Conversion.Val(num2) - Conversion.Val(num2);
                    //double num6 = Conversion.Val(num4) * Conversion.Val(num3) - Conversion.Val(num3);
                    //this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                    //this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);

                    double num = Conversion.Val(0.01) * Convert.ToDouble(oleDbDataReader["SAbandon"]);
                    double num1 = Conversion.Val(0.01) * Convert.ToDouble(Operators.AddObject((oleDbDataReader["AAbandon"]), oleDbDataReader["TAbandon"]));

                    double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);

                    double num5 = Conversion.Val(num) * Conversion.Val(num2) - Conversion.Val(num2);
                    double num6 = Conversion.Val(num) * Conversion.Val(num3) - Conversion.Val(num3);

                    double num7 = Conversion.Val(num1) * Conversion.Val(num5) - Conversion.Val(num5);
                    double num8 = Conversion.Val(num1) * Conversion.Val(num6) - Conversion.Val(num6);

                    int index = this.DataGridView4.Rows.Add();
                    this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num7); //- Conversion.Val(num7) - Conversion.Val(num7);
                    this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num8); //- Conversion.Val(num8) - Conversion.Val(num8);
                }
                Module1.conn.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600114B RID: 4427 RVA: 0x0033392C File Offset: 0x00331D2C
        public void Booky_total()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView4.RowCount - 1;
                    double num3 = 0;
                    double num4 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[0].Value));
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[1].Value));
                        }
                    }
                    this.DataGridView1.Rows[0].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView1.Rows[1].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x0600114C RID: 4428 RVA: 0x00333A60 File Offset: 0x00331E60
        public void All_Total()
        {
            try
            {
                this.DataGridView1.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[4].Value)), this.txtnu.Text);
                this.DataGridView1.Rows[1].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[4].Value)), this.txtnu.Text);
                this.DataGridView1.Rows[2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[2].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[2].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[2].Cells[4].Value)), this.txtnu.Text);
                this.DataGridView1.Rows[3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[3].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[3].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[3].Cells[4].Value)), this.txtnu.Text);
                int num = 0;
                checked
                {
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[num].Cells[1].Value, 0, false))
                        {
                            this.DataGridView1.Rows[num].Cells[1].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[num].Cells[1].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[num].Cells[2].Value, 0, false))
                        {
                            this.DataGridView1.Rows[num].Cells[2].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[num].Cells[2].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[num].Cells[3].Value, 0, false))
                        {
                            this.DataGridView1.Rows[num].Cells[3].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[num].Cells[3].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[num].Cells[4].Value, 0, false))
                        {
                            this.DataGridView1.Rows[num].Cells[4].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[num].Cells[4].Style.ForeColor = Color.Green;
                        }
                        num++;
                    }
                    while (num <= 3);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600114D RID: 4429 RVA: 0x00333FB4 File Offset: 0x003323B4
        public void Booky_Tie_Non_Tie()
        {
            try
            {
                this.DataGridView4.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.STie, PartyMaster.ATie, PartyMaster.TTie, Abdntie.Match_ID, SUM(Abdntie.Tie) AS Expr4, SUM(Abdntie.Non_Tie) AS Expr5, Abdntie.Delete_CHK FROM (PartyMaster INNER JOIN Abdntie ON PartyMaster.PartyName = Abdntie.Party_Name) GROUP BY PartyMaster.PartyName, PartyMaster.Status, Abdntie.Match_ID, Abdntie.Delete_CHK, PartyMaster.STie, PartyMaster.ATie, PartyMaster.TTie HAVING    (Abdntie.Delete_CHK = '0') AND (Abdntie.Match_ID = " + this.txtmatchID.Text + ") AND (PartyMaster.Status = 'Booky')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    //double num = Convert.ToDouble(Operators.AddObject(Operators.AddObject(oleDbDataReader["Expr1"], oleDbDataReader["Expr2"]), oleDbDataReader["Expr3"]));
                    //double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    //double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);
                    //double num4 = Conversion.Val(0.01) * Conversion.Val(num);
                    //int index = this.DataGridView4.Rows.Add();
                    //double num5 = Conversion.Val(num4) * Conversion.Val(num2) - Conversion.Val(num2);
                    //double num6 = Conversion.Val(num4) * Conversion.Val(num3) - Conversion.Val(num3);
                    //this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num5) - Conversion.Val(num5) - Conversion.Val(num5);
                    //this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num6) - Conversion.Val(num6) - Conversion.Val(num6);

                    double num = Conversion.Val(0.01) * Convert.ToDouble(oleDbDataReader["STie"]);
                    double num1 = Conversion.Val(0.01) * Convert.ToDouble(Operators.AddObject((oleDbDataReader["ATie"]), oleDbDataReader["TTie"]));

                    double num2 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                    double num3 = Convert.ToDouble(oleDbDataReader["Expr5"]);

                    double num5 = Conversion.Val(num) * Conversion.Val(num2) - Conversion.Val(num2);
                    double num6 = Conversion.Val(num) * Conversion.Val(num3) - Conversion.Val(num3);

                    double num7 = Conversion.Val(num1) * Conversion.Val(num5) - Conversion.Val(num5);
                    double num8 = Conversion.Val(num1) * Conversion.Val(num6) - Conversion.Val(num6);

                    int index = this.DataGridView4.Rows.Add();
                    this.DataGridView4.Rows[index].Cells[0].Value = Conversion.Val(num7); //- Conversion.Val(num7) - Conversion.Val(num7);
                    this.DataGridView4.Rows[index].Cells[1].Value = Conversion.Val(num8); //- Conversion.Val(num8) - Conversion.Val(num8);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0600114E RID: 4430 RVA: 0x003341F8 File Offset: 0x003325F8
        public void Booky_Tile_total()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView4.RowCount - 1;
                    double num3 = 0;
                    double num4 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[0].Value));
                            num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[1].Value));
                        }
                    }
                    this.DataGridView1.Rows[2].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView1.Rows[3].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x0600114F RID: 4431 RVA: 0x0033432C File Offset: 0x0033272C
        private void txtmode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Strings.Chr(Conversions.ToInteger("1")))
                {
                    this.txtmode.Text = "L";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001151 RID: 4433 RVA: 0x003343C8 File Offset: 0x003327C8
        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001152 RID: 4434 RVA: 0x00334458 File Offset: 0x00332858
        private void txtrate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001153 RID: 4435 RVA: 0x003344E8 File Offset: 0x003328E8
        private void txtteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtteam.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001154 RID: 4436 RVA: 0x00334558 File Offset: 0x00332958
        private void txtmode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtmode.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{tab}");
                    }
                }
                if (e.KeyCode == Keys.NumPad1)
                {
                    this.txtmode.SelectedItem = "K";
                }
                if (e.KeyCode == Keys.NumPad2)
                {
                    this.txtmode.SelectedItem = "L";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void All_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x04000722 RID: 1826
        private int delete;
    }
}
