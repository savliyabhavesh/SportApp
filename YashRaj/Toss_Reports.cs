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
    [DesignerGenerated]
    public partial class Toss_Reports : Form
    {
        public Toss_Reports()
        {
            this.InitializeComponent();
        }


        private void Toss_Reports_Activated(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                this.testvalue();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private void Toss_Reports_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                //this.DataGridView1.Rows[0].Cells[1].Selected = true;
                //this.DataGridView1.Select();
                //SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        public void testvalue()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT Sr_No, Date1, Team1, Name, Type, horse1, horse2, horse3, horse4, horse5, horse6, horse7, horse8, horse9, horse10, horse11, horse12, horse13, horse14, horse15,Result, Remark, Type AS Expr1 FROM(Newmatch) WHERE (Type ='TOSS') ORDER BY Sr_No DESC";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader[0].ToString();
                    this.DataGridView1.Rows[index].Cells[1].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader[1].ToString()), DateFormat.ShortDate);
                    this.DataGridView1.Rows[index].Cells[2].Value = oleDbDataReader[2].ToString();
                    this.DataGridView1.Rows[index].Cells[3].Value = oleDbDataReader[3].ToString();
                    this.DataGridView1.Rows[index].Cells[4].Value = oleDbDataReader[4].ToString();
                    this.DataGridView1.Rows[index].Cells[5].Value = oleDbDataReader[20].ToString();
                }
                if (this.DataGridView1.RowCount != 0)
                {
                    this.TextBox6.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                    Module1.Matchdecalerd = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                    this.TextBox5.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                }
                Module1.conn.Close();
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


        private void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (Operators.CompareString(this.TextBox6.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please select Toss Match..?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    this.iodegrid();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private void DataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                this.TextBox6.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                Module1.Matchdecalerd = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                this.TextBox5.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }


        public void iodegrid()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.TextBox5.Text + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    Interaction.MsgBox("Toss is Declared ", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    Module1.modifymatchid = Conversions.ToInteger(this.TextBox5.Text);
                    MyProject.Forms.New_Match.MdiParent = this.MdiParent;
                    MyProject.Forms.New_Match.Show();

                    this.TextBox6.Text = null;
                    Module1.Matchdecalerd = 0;
                    this.TextBox5.Text = null;
                    Module1.idnewmach = 0;
                    Module1.machid = 0;

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


        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.TextBox6.Text = null;
                Module1.Matchdecalerd = 0;
                this.TextBox5.Text = null;
                Module1.idnewmach = 0;
                Module1.machid = 0;
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.TextBox6.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Module1.Matchdecalerd = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value.ToString());
                    this.TextBox5.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
                    if (Operators.CompareString(this.TextBox6.Text, "", false) == 0)
                    {
                        MessageBox.Show("Please select match ?", "Match", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        this.Hide();
                    }
                }
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                {
                    MessageBox.Show(" Please select match ?", "Match", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "SELECT Sr_No, Date1, Team1, Name, Type, horse1, horse2, horse3, horse4, Result, Remark FROM (Newmatch) WHERE (Sr_No = " + this.DataGridView1.CurrentRow.Cells[0].Value.ToString() + ") AND (Type = 'TOSS')";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        MyProject.Forms.Toss_Match.MdiParent = this.MdiParent;
                        MyProject.Forms.Toss_Match.testnu.Text = Conversions.ToString(oleDbDataReader["Sr_No"]);
                        MyProject.Forms.Toss_Match.Show();
                        this.TextBox6.Text = null;
                        Module1.Matchdecalerd = 0;
                        this.TextBox5.Text = null;
                        this.txtdecl.Text = null;
                        this.Close();
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

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private void btnmdeclare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.TextBox5.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please Select Toss Match Than Proced...?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "Select * from Newmatch where Sr_No=" + this.TextBox5.Text + " and Result='Declared' and Type= 'TOSS'";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Match is Declared ", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        MyProject.Forms.Toss_Delcler.MdiParent = this.MdiParent;
                        MyProject.Forms.Toss_Delcler.WindowState = FormWindowState.Maximized;
                        MyProject.Forms.Toss_Delcler.Show();
                        this.Close();
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


        private void UnDeclare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.TextBox5.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Please Select this match ", MsgBoxStyle.OkOnly, null);
                }
                else if (Interaction.MsgBox("Do you want to Un-Declared Match..?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "SELECT tns_MatchID, tns_Monday_Final, tns_Sessionid FROM Trans WHERE (tns_MatchID = " + this.TextBox5.Text + ") AND (tns_Monday_Final = 'Yes') AND (tns_Sessionid = 0)";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Records are settled or Monday final for this match", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        cmdText = $"DELETE FROM Trans WHERE tns_MatchID = {this.TextBox5.Text} AND tns_Sessionid = 0 ";
                        string cmdText1 = $"UPDATE Newmatch SET  Result = 'UnDeclared', Remark = '' WHERE Newmatch.Sr_No = {this.TextBox5.Text}";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText);
                            matchService.Update(cmdText1);
                        }
                        Interaction.MsgBox("Match is Un-Declared..?", MsgBoxStyle.OkOnly, null);
                        this.testvalue();
                        this.TextBox6.Text = null;
                        Module1.Matchdecalerd = 0;
                        this.TextBox5.Text = null;
                        this.txtdecl.Text = null;
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


        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.TextBox6.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Please select match?", MsgBoxStyle.OkOnly, null);
                }
                else if (Interaction.MsgBox("Do you want to delete this match", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "Select * from Newmatch where Sr_No=" + this.TextBox5.Text + " and Result='Declared'";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Match is Declared ", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = $"delete * from Newmatch where Sr_No={this.TextBox5.Text} ";
                        string cmdText3 = $"delete * from MatchTrans1 where m_id={this.TextBox5.Text} ";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText2);
                            matchService.Update(cmdText3);
                        }
                        this.testvalue();
                        this.TextBox6.Text = null;
                        Module1.Matchdecalerd = 0;
                        this.TextBox5.Text = null;
                        this.txtdecl.Text = null;
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

    }
}
