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
using App.Service;

namespace YashAksh
{
    // Token: 0x0200003C RID: 60
    //[DesignerGenerated]
    public partial class DPP_AbnTie : Form
    {
        // Token: 0x0600098B RID: 2443 RVA: 0x002E205C File Offset: 0x002E045C
        public DPP_AbnTie()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000A3A RID: 2618 RVA: 0x002E5EE0 File Offset: 0x002E42E0
        private void Button6_Click(object sender, EventArgs e)
        {
            //MyProject.Forms.fromAbn.MdiParent = this.MdiParent;
            //MyProject.Forms.fromAbn.WindowState = FormWindowState.Maximized;			
            //MyProject.Forms.fromAbn.Show();
            this.Close();
        }

        // Token: 0x06000A3B RID: 2619 RVA: 0x002E5F3C File Offset: 0x002E433C
        private void DPP_AbnTie_Activated(object sender, EventArgs e)
        {
            this.txtname.Focus();
        }

        // Token: 0x06000A3C RID: 2620 RVA: 0x002E5F4C File Offset: 0x002E434C
        private void DPP_Match_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    //MyProject.Forms.fromAbn.MdiParent = this.MdiParent;
                    //MyProject.Forms.fromAbn.WindowState = FormWindowState.Maximized;				
                    //MyProject.Forms.fromAbn.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06000A3E RID: 2622 RVA: 0x002E6058 File Offset: 0x002E4458
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
                    this.btnmodify.Enabled = false;
                    this.Button3.Enabled = false;
                }
                else
                {
                    this.btnmodify.Enabled = true;
                    this.Button3.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06000A3F RID: 2623 RVA: 0x002E611C File Offset: 0x002E451C
        private void DPP_Match_Load(object sender, EventArgs e)
        {
            try
            {
                this.CheckBox1.Hide();
                this.txtmatchID.Text = Conversions.ToString(Module1.machid);
                this.txtnu.Text = Module1.decimalnumberformat;
                this.colore.Hide();
                this.Panel5.Hide();
                this.ComboBox1.Hide();
                this.smatch.Hide();
                this.amatch.Hide();
                this.txtparsent.Hide();
                this.txtTie.Hide();
                this.testnu.Hide();
                this.Button5.Hide();
                this.txtnu.Hide();
                this.CheckBox2.Hide();

                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows.Add();
                this.DataGridView3.Rows.Add();
                this.DataGridView3.Rows.Add();

                this.CheckBox1.Checked = true;
                this.testnu.Text = Conversions.ToString(Module1.machid);
                this.combolod();
                this.txtname.Text = "";
                this.txtname.Text = Conversions.ToString(Module1.sonu);
                this.txtname_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                this.listlode();
                this.DataGridView3.DefaultCellStyle.Format = this.txtnu.Text;
                this.Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Decleard();
                this.DataGridView3.DefaultCellStyle.Format = this.txtnu.Text;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A40 RID: 2624 RVA: 0x002E635C File Offset: 0x002E475C
        public void listlode()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    this.DataGridView1.Rows.Clear();
                    double value = 0.0;
                    string cmdText = string.Concat(new string[]
                    {
                        "SELECT ID, Match_ID, Page_No, Amount, Rate, Team, Mode, Party_Name, [Date], [Time], ABDN, Non_ABDN, Tie, Non_Tie, Date1, Delete_CHK, A_Modify, M_chk FROM Abdntie WHERE        (Match_ID = ",
                        this.testnu.Text,
                        ") AND (Party_Name = '",
                        this.txtname.Text,
                        "')ORDER BY ID DESC"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {

                        int num = this.DataGridView1.Rows.Add();
                        this.DataGridView1.Rows[num].Cells[1].Value = oleDbDataReader["ID"].ToString();
                        this.DataGridView1.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                        this.DataGridView1.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                        this.DataGridView1.Rows[num].Cells[4].Value = oleDbDataReader["Team"].ToString();
                        this.DataGridView1.Rows[num].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                        this.DataGridView1.Rows[num].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                        this.DataGridView1.Rows[num].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                        this.DataGridView1.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                        this.DataGridView1.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                        this.DataGridView1.Rows[num].Cells[10].Value = oleDbDataReader["Time"].ToString();
                        this.DataGridView1.Rows[num].Cells[11].Value = oleDbDataReader["Date"].ToString();
                        this.DataGridView1.Rows[num].Cells[12].Value = oleDbDataReader["Page_No"].ToString();

                        if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Delete_CHK"], "1", false))
                        {
                            this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                            //this.DataGridView1.Rows[num].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                        }
                        else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                        {
                            this.DataGridView1.Rows[num].Cells[0].Value = true;
                            this.DataGridView1.Rows[num].DefaultCellStyle.BackColor = Color.LimeGreen;
                            this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.White;
                            value = (double)(num + 1);
                        }
                        else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["A_Modify"], "1", false))
                        {
                            this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                            value = (double)(num + 1);
                        }
                        else
                        {
                            value = (double)(num + 1);
                        }

                        //if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Delete_CHK"], "1", false))
                        //{
                        //	int num = this.DataGridView1.Rows.Add();
                        //	this.DataGridView1.Rows[num].Cells[1].Value = oleDbDataReader["ID"].ToString();
                        //	this.DataGridView1.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num].Cells[4].Value = oleDbDataReader["Team"].ToString();
                        //	this.DataGridView1.Rows[num].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                        //	this.DataGridView1.Rows[num].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num].Cells[10].Value = oleDbDataReader["Time"].ToString();
                        //	this.DataGridView1.Rows[num].Cells[11].Value = oleDbDataReader["Date"].ToString();
                        //	this.DataGridView1.Rows[num].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                        //	this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                        //	value = (double)(num + 1);
                        //}
                        //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                        //{
                        //	int num2 = this.DataGridView1.Rows.Add();
                        //	this.DataGridView1.Rows[num2].Cells[1].Value = oleDbDataReader["ID"].ToString();
                        //	this.DataGridView1.Rows[num2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num2].Cells[4].Value = oleDbDataReader["Team"].ToString();
                        //	this.DataGridView1.Rows[num2].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                        //	this.DataGridView1.Rows[num2].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num2].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num2].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num2].Cells[10].Value = oleDbDataReader["Time"].ToString();
                        //	this.DataGridView1.Rows[num2].Cells[11].Value = oleDbDataReader["Date"].ToString();
                        //	this.DataGridView1.Rows[num2].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                        //	this.DataGridView1.Rows[num2].Cells[0].Value = true;
                        //	this.DataGridView1.Rows[num2].DefaultCellStyle.BackColor = Color.LimeGreen;
                        //	this.DataGridView1.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
                        //	value = (double)(num2 + 1);
                        //}
                        //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["A_Modify"], "1", false))
                        //{
                        //	int num3 = this.DataGridView1.Rows.Add();
                        //	this.DataGridView1.Rows[num3].Cells[1].Value = oleDbDataReader["ID"].ToString();
                        //	this.DataGridView1.Rows[num3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num3].Cells[4].Value = oleDbDataReader["Team"].ToString();
                        //	this.DataGridView1.Rows[num3].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                        //	this.DataGridView1.Rows[num3].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num3].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num3].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num3].Cells[10].Value = oleDbDataReader["Time"].ToString();
                        //	this.DataGridView1.Rows[num3].Cells[11].Value = oleDbDataReader["Date"].ToString();
                        //	this.DataGridView1.Rows[num3].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                        //	this.DataGridView1.Rows[num3].DefaultCellStyle.ForeColor = Color.Blue;
                        //	value = (double)(num3 + 1);
                        //}
                        //else
                        //{
                        //	int num4 = this.DataGridView1.Rows.Add();
                        //	this.DataGridView1.Rows[num4].Cells[1].Value = oleDbDataReader["ID"].ToString();
                        //	this.DataGridView1.Rows[num4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Amount"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num4].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num4].Cells[4].Value = oleDbDataReader["Team"].ToString();
                        //	this.DataGridView1.Rows[num4].Cells[5].Value = oleDbDataReader["Mode"].ToString();
                        //	this.DataGridView1.Rows[num4].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num4].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_ABDN"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num4].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num4].Cells[9].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["Non_Tie"].ToString()), this.txtnu.Text);
                        //	this.DataGridView1.Rows[num4].Cells[10].Value = oleDbDataReader["Time"].ToString();
                        //	this.DataGridView1.Rows[num4].Cells[11].Value = oleDbDataReader["Date"].ToString();
                        //	this.DataGridView1.Rows[num4].Cells[12].Value = oleDbDataReader["Page_No"].ToString();
                        //	value = (double)(num4 + 1);
                        //}
                    }
                    this.Label4.Text = "TOTAL ENTRY : " + Conversions.ToString(value);
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        // Token: 0x06000A41 RID: 2625 RVA: 0x002E71C0 File Offset: 0x002E55C0
        public void combolod()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                    this.smatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"]));
                    this.amatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"]));
                    this.pmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"]));
                    this.txtparty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                    this.txtregular.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Status"]));
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

        // Token: 0x06000A42 RID: 2626 RVA: 0x002E731C File Offset: 0x002E571C
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtname.SelectionStart <= 1)
                        {
                            this.txtname.Text = "";
                            return;
                        }
                        if (this.txtname.SelectionLength == 0)
                        {
                            text = this.txtname.Text.Substring(0, this.txtname.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtname.Text.Substring(0, this.txtname.SelectionStart - 1);
                        }
                    }
                    else if (this.txtname.SelectionLength == 0)
                    {
                        text = this.txtname.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtname.Text.Substring(0, this.txtname.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtname.FindString(text);
                    if (num != -1)
                    {
                        this.txtname.SelectedText = "";
                        this.txtname.SelectedIndex = num;
                        this.txtname.SelectionStart = text.Length;
                        this.txtname.SelectionLength = this.txtname.Text.Length;
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
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A43 RID: 2627 RVA: 0x002E7478 File Offset: 0x002E5878
        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtname = this.txtname;
                this.AutoComplete(ref txtname, e, false);
                this.txtname = txtname;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A44 RID: 2628 RVA: 0x002E74A0 File Offset: 0x002E58A0
        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listlode();
                this.Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.txtname.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A45 RID: 2629 RVA: 0x002E74FC File Offset: 0x002E58FC
        public void all_CUP_Lode()
        {
            try
            {
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView2.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView3.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView3.Rows.Add(new object[]
                {
                    ""
                });
                this.DataGridView3.Rows.Add(new object[]
                {
                    ""
                });
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000A46 RID: 2630 RVA: 0x002E75FC File Offset: 0x002E59FC
        private void txtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.smatch.SelectedIndex = this.txtname.SelectedIndex;
                this.amatch.SelectedIndex = this.txtname.SelectedIndex;
                int num = checked((int)Math.Round(Conversion.Val(this.smatch.Text)));
                double value = Conversion.Val(0.01) * Conversion.Val(num);
                this.txtparsent.Text = Conversions.ToString(value);
                double value2 = Conversion.Val(0.01) * Conversion.Val(this.amatch.Text);
                this.txttie1.Text = Conversions.ToString(value2);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000A47 RID: 2631 RVA: 0x002E76B4 File Offset: 0x002E5AB4
        private void colore_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[0].Cells[0].Value, 0, false))
                {
                    this.DataGridView2.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView2.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[0].Cells[1].Value, 0, false))
                {
                    this.DataGridView2.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView2.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[0].Cells[2].Value, 0, false))
                {
                    this.DataGridView2.Rows[0].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView2.Rows[0].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[0].Cells[3].Value, 0, false))
                {
                    this.DataGridView2.Rows[0].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView2.Rows[0].Cells[3].Style.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000A48 RID: 2632 RVA: 0x002E78E0 File Offset: 0x002E5CE0
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                OleDbCommand oleDbCommand;
                checked
                {
                    do
                    {
                        this.DataGridView3.Rows[0].Cells[num].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[num].Value)), this.txtnu.Text);
                        this.DataGridView3.Rows[1].Cells[num].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[num].Value)), this.txtnu.Text);
                        this.DataGridView2.Rows[1].Cells[num].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[num].Value)), this.txtnu.Text);
                        num++;
                    }
                    while (num <= 3);
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "select sum(ABDN)from Abdntie where Match_ID=",
                        this.testnu.Text,
                        " and Party_Name='",
                        this.txtname.Text,
                        "' and Delete_CHK='0'"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                }
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                {
                    double num2 = Convert.ToDouble(oleDbCommand.ExecuteScalar());
                    this.DataGridView3.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num2), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[0].Value = Conversion.Val(num2) * Conversion.Val(this.txtparsent.Text);
                    this.DataGridView3.Rows[1].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[0].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[0].Value));
                }
                string cmdText2 = string.Concat(new string[]
                {
                    " select sum(Non_ABDN)from Abdntie where Match_ID=",
                    this.testnu.Text,
                    " and Party_Name='",
                    this.txtname.Text,
                    "'and Delete_CHK='0'"
                });
                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
                {
                    double num3 = Convert.ToDouble(oleDbCommand2.ExecuteScalar());
                    this.DataGridView3.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[1].Value = Conversion.Val(num3) * Conversion.Val(this.txtparsent.Text);
                    this.DataGridView3.Rows[1].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[1].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[1].Value));
                }
                string cmdText3 = string.Concat(new string[]
                {
                    " select sum(Tie)from Abdntie where Match_ID=",
                    this.testnu.Text,
                    " and Party_Name='",
                    this.txtname.Text,
                    "'and Delete_CHK='0'"
                });
                OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand3.ExecuteScalar())))
                {
                    double num4 = Convert.ToDouble(oleDbCommand3.ExecuteScalar());
                    this.DataGridView3.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[2].Value = Conversion.Val(num4) * Conversion.Val(this.txttie1.Text);
                    this.DataGridView3.Rows[1].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[2].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[2].Value));
                }
                string cmdText4 = string.Concat(new string[]
                {
                    " select sum(Non_Tie)from Abdntie where Match_ID=",
                    this.testnu.Text,
                    " and Party_Name='",
                    this.txtname.Text,
                    "'and Delete_CHK='0'"
                });
                OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText4, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand4.ExecuteScalar())))
                {
                    double num5 = Convert.ToDouble(oleDbCommand4.ExecuteScalar());
                    this.DataGridView3.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                    this.DataGridView3.Rows[1].Cells[3].Value = Conversion.Val(num5) * Conversion.Val(this.txttie1.Text);
                    this.DataGridView3.Rows[1].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[3].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[1].Cells[3].Value));
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[1].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[1].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[1].Cells[3].Style.ForeColor = Color.Green;
                }
                this.DataGridView3.DefaultCellStyle.Format = this.txtnu.Text;
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

        // Token: 0x06000A49 RID: 2633 RVA: 0x002E8594 File Offset: 0x002E6994
        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmodify.Text, null, false) != 0)
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
                        this.txtmodify.Text,
                        " and Delete_CHK='1'"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("con not edit this record", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = "Select * from Abdntie where Match_ID=" + this.txtmatchID.Text + " and ID=" + this.txtmodify.Text;
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        while (oleDbDataReader2.Read())
                        {
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader2[16], "1", false))
                            {
                                Interaction.MsgBox("can not edit this record", MsgBoxStyle.OkOnly, null);
                            }
                            else
                            {
                                this.Panel5.Show();
                                this.txtid.Text = Conversions.ToString(oleDbDataReader2[0]);
                                this.txtamount.Text = Conversions.ToString(oleDbDataReader2[3]);
                                this.txtrate.Text = Conversions.ToString(oleDbDataReader2[4]);
                                this.txtteam.Text = Conversions.ToString(oleDbDataReader2[5]);
                                this.txtmode.Text = Conversions.ToString(oleDbDataReader2[6]);
                                this.txtparty.Text = Conversions.ToString(oleDbDataReader2[7]);
                                this.txtABDN.Text = Conversions.ToString(oleDbDataReader2[10]);
                                this.txtNonABDN.Text = Conversions.ToString(oleDbDataReader2[11]);
                                this.txtTie.Text = Conversions.ToString(oleDbDataReader2[12]);
                                this.txtNontie.Text = Conversions.ToString(oleDbDataReader2[13]);
                                this.txtime.Text = Conversions.ToString(oleDbDataReader2["Time"]);
                                this.txtpage.Text = Conversions.ToString(oleDbDataReader2[2]);
                                this.txtparty.Text = Conversions.ToString(oleDbDataReader2[7]);
                                this.txtparty_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                            }
                        }
                        txtamount.Focus();
                    }
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

        // Token: 0x06000A4A RID: 2634 RVA: 0x002E8874 File Offset: 0x002E6C74
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdText = $"delete from Abdntie where Match_ID={ this.txtmatchID.Text } and ID={ this.txtmodify.Text}";
                this.txtteam_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
                string cmdText2 = string.Concat(new string[]
                {
                    "Insert Into Abdntie values (",
                    this.txtid.Text,
                    ",",
                    this.txtmatchID.Text,
                    ",'",
                    this.txtpage.Text,
                    "',",
                    this.txtamount.Text,
                    ",",
                    this.txtrate.Text,
                    ",'",
                    this.txtteam.Text,
                    "','",
                    this.txtmode.Text,
                    "','",
                    this.txtparty.Text,
                    "','",
                    Conversions.ToString(DateAndTime.Now.Date),
                    "' ,'",
                    this.txtime.Text,
                    "','",
                    this.txtABDN.Text,
                    "','",
                    this.txtNonABDN.Text,
                    "','",
                    this.txtTie.Text,
                    "','",
                    this.txtNontie.Text,
                    "','",
                    Conversions.ToString(DateAndTime.Now.Date),
                    "','",
                    this.txtregular.Text,
                    "','0','",
                    this.txtabp.Text,
                    "',1,0)"
                });
                using (AbdntieService abdntieService = new AbdntieService())
                {
                    abdntieService.Update(cmdText);
                    abdntieService.Update(cmdText2);
                }
                this.txtname.Text = this.txtparty.Text;
                this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.Panel5.Hide();
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
            }
        }

        // Token: 0x06000A4B RID: 2635 RVA: 0x002E8B68 File Offset: 0x002E6F68
        public void ABDN12()
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
                this.txtTie.Text = "0";
                this.txtNontie.Text = "0";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A4C RID: 2636 RVA: 0x002E8E7C File Offset: 0x002E727C
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

        // Token: 0x06000A4D RID: 2637 RVA: 0x002E9170 File Offset: 0x002E7570
        public void ABDN_parsent_update()
        {
            try
            {
                string cmdText = $"update Abdntie set A_P='{this.txtabp.Text}' where Party_Name='{this.txtparty.Text}' And Team='{this.txtteam.Text}'and DARA='{this.txtregular.Text}'";
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
            }
        }

        // Token: 0x06000A4E RID: 2638 RVA: 0x002E925C File Offset: 0x002E765C
        private void txtparty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtregular.SelectedIndex = this.txtparty.SelectedIndex;
                this.smatch.SelectedIndex = this.txtparty.SelectedIndex;
                this.amatch.SelectedIndex = this.txtparty.SelectedIndex;
                this.pmatch.SelectedIndex = this.txtparty.SelectedIndex;
                int num = checked((int)Math.Round(unchecked(Conversion.Val(this.smatch.Text) + Conversion.Val(this.amatch.Text) + Conversion.Val(this.pmatch.Text))));
                this.txtabp.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num));
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A4F RID: 2639 RVA: 0x002E9358 File Offset: 0x002E7758
        private void txtteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ABDN12();
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

        // Token: 0x06000A50 RID: 2640 RVA: 0x002E9458 File Offset: 0x002E7858
        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel5.Hide();
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A51 RID: 2641 RVA: 0x002E9474 File Offset: 0x002E7874
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmodify.Text, "", false) != 0)
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
                        this.txtmodify.Text,
                        " and Delete_CHK='1'"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Connot delete this Record..?", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = $"update  Abdntie set Delete_CHK=1 where Match_ID={this.txtmatchID.Text} and ID={this.txtmodify.Text}";
                        using (AbdntieService abdntieService = new AbdntieService())
                        {
                            abdntieService.Update(cmdText2);
                        }
                        Interaction.MsgBox("Record delete", MsgBoxStyle.OkOnly, null);
                        this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    }
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

        // Token: 0x06000A52 RID: 2642 RVA: 0x002E9600 File Offset: 0x002E7A00
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtname.Text, null, false) != 0)
                {
                    this.ListView2.Items.Clear();
                    this.listlode_print();
                    mareport mareport = new mareport();
                    DataSet dataSet = new DataSet();
                    dataSet.Tables.Add("ListViewData");
                    DataColumnCollection columns = dataSet.Tables[0].Columns;
                    columns.Add("Sr_No", Type.GetType("System.String"));
                    columns.Add("Amount", Type.GetType("System.String"));
                    columns.Add("Rate", Type.GetType("System.String"));
                    columns.Add("Favour", Type.GetType("System.String"));
                    columns.Add("Mode", Type.GetType("System.String"));
                    columns.Add("name", Type.GetType("System.String"));
                    try
                    {
                        foreach (object obj in this.ListView2.Items)
                        {
                            ListViewItem listViewItem = (ListViewItem)obj;
                            DataRow dataRow = dataSet.Tables[0].NewRow();
                            dataRow[0] = listViewItem.SubItems[0].Text;
                            dataRow[1] = listViewItem.SubItems[1].Text;
                            dataRow[2] = listViewItem.SubItems[2].Text;
                            dataRow[3] = listViewItem.SubItems[3].Text;
                            dataRow[4] = listViewItem.SubItems[4].Text;
                            dataRow[5] = listViewItem.SubItems[5].Text;
                            dataSet.Tables[0].Rows.Add(dataRow);
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
                    mareport.SetDataSource(dataSet);
                    mareport.PrintToPrinter(0, false, 0, 0);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000A53 RID: 2643 RVA: 0x002E9820 File Offset: 0x002E7C20
        public void listlode_print()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "Select * from Abdntie where Match_ID=",
                    this.testnu.Text,
                    " and Party_Name='",
                    this.txtname.Text,
                    "'"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "1", false))
                    {
                        if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "0", false))
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem = (ListViewItem)NewLateBinding.LateGet(this.ListView2.Items, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[0])
                            }, null, null, null);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[3])
                            }, null, null, null, true);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[4])
                            }, null, null, null, true);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[5])
                            }, null, null, null, true);
                            NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader[6])
                            }, null, null, null, true);
                            listViewItem.SubItems.Add(this.txtname.Text);
                            listViewItem.BackColor = Color.White;
                        }
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

        // Token: 0x06000A54 RID: 2644 RVA: 0x002E9A60 File Offset: 0x002E7E60
        public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
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

        // Token: 0x06000A55 RID: 2645 RVA: 0x002E9BBC File Offset: 0x002E7FBC
        private void txtparty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtparty = this.txtparty;
                this.AutoComplete11(ref txtparty, e, false);
                this.txtparty = txtparty;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000A56 RID: 2646 RVA: 0x002E9BE4 File Offset: 0x002E7FE4
        private void txtpage_KeyDown(object sender, KeyEventArgs e)
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
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000A57 RID: 2647 RVA: 0x002E9BFC File Offset: 0x002E7FFC
        private void txtparty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.Button7.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000A58 RID: 2648 RVA: 0x002E9C14 File Offset: 0x002E8014
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000A59 RID: 2649 RVA: 0x002E9C78 File Offset: 0x002E8078
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.ColumnIndex == 0)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = false;
                        }
                        else
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = true;
                        }
                        int num = 0;
                        int num2 = this.DataGridView1.Rows.Count - 1;
                        double num3 = 0;
                        double num4 = 0;
                        double num5 = 0;
                        double num6 = 0;
                        for (int i = num; i <= num2; i++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, true, false))
                                {
                                    num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[6].Value));
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[7].Value));
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[8].Value));
                                    num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[9].Value));
                                }
                            }
                        }
                        this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, true, false))
                        {
                            string cmdText = $"UPDATE Abdntie SET M_chk = 1 WHERE Match_ID = { this.testnu.Text } AND ID = { this.DataGridView1.CurrentRow.Cells[1].Value}";
                            using (AbdntieService abdntieService = new AbdntieService())
                            {
                                abdntieService.Update(cmdText);
                            }
                                this.DataGridView1.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, false, false))
                        {

                            string cmdText = $"UPDATE Abdntie SET M_chk = 0 WHERE Match_ID ={this.testnu.Text } AND ID = { this.DataGridView1.CurrentRow.Cells[1].Value}";
                            using (AbdntieService abdntieService = new AbdntieService())
                            {
                                abdntieService.Update(cmdText);
                            }
                            this.DataGridView1.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                }
            }
        }

        // Token: 0x06000A5A RID: 2650 RVA: 0x002EA108 File Offset: 0x002E8508
        private void Button1_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView1.Rows.Count - 1;
                    double num3 = 0;
                    double num4 = 0;
                    double num5 = 0;
                    double num6 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        this.DataGridView1.Rows[i].Cells[0].Value = true;
                        unchecked
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, true, false))
                            {
                                num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[6].Value));
                                num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[7].Value));
                                num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[8].Value));
                                num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[9].Value));
                                string cmdText = $"UPDATE Abdntie SET M_chk = 1 WHERE Match_ID = { this.testnu.Text }AND ID ={this.DataGridView1.Rows[i].Cells[1].Value}";
                                using (AbdntieService abdntieService = new AbdntieService())
                                {
                                    abdntieService.Update(cmdText);
                                }
                                    this.DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                            }
                        }
                    }
                    this.DataGridView2.Rows[0].Cells[0].Value = Module1.SetNumFormat(Conversion.Val(num3), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(num6), this.txtnu.Text);
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                }
            }
        }

        // Token: 0x06000A5B RID: 2651 RVA: 0x002EA464 File Offset: 0x002E8864
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtmodify.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtrate.Focus();
                    this.txtrate.SelectAll();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtrate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtteam.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtmode.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtmode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtparty.Focus();
                    this.txtparty.SelectAll();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtrate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtrate.Text != "")
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

        private void txtamount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtamount.Text != "")
                {
                    this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), Module1.decimalnumberformat);
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
    }
}
