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
    public partial class Cup_Report : Form
    {
        public Cup_Report()
        {
            this.InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cup_Report_Activated(object sender, EventArgs e)
        {
            try
            {
                this.ShowCUPall();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void Cup_Report_Load(object sender, EventArgs e)
        {
            try
            {
                //this.WindowState = FormWindowState.Maximized;				
                //this.DataGridView1.Rows[0].Cells[1].Selected = true;
                //this.DataGridView1.Select();
                //SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                {
                    this.cupid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Module1.IDCUP = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.cupid.ToString(), null, false) == 0)
                {
                    Interaction.MsgBox("Please Select Match Than Proced..?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "Select * from Newmatch where Sr_No=" + Conversions.ToString(this.cupid) + " and Result='Declared'";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Match is Declared ", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        Module1.modifymatchid = this.cupid;
                        //MyProject.Forms.Cup_Modify.MdiParent = this.MdiParent;
                        //MyProject.Forms.Cup_Modify.Show();
                        New_Match new_Match = new New_Match();
                        new_Match.MdiParent = this.MdiParent;
                        new_Match.Show();
                        //this.Close();
                    }
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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Operators.CompareString(this.cupid.ToString(), null, false) == 0)
                    {
                        Interaction.MsgBox("Please Select Match Than Proced..?", MsgBoxStyle.OkOnly, null);
                    }
                    else if (Interaction.MsgBox("Do you want to delete this match", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = "Select * from Newmatch where Sr_No=" + Conversions.ToString(this.cupid) + " and Result='Declared'";
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {
                            Interaction.MsgBox("Match is Declared ", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            string cmdText2 = $"DELETE from Newmatch where Sr_No={ this.cupid.ToString() }";

                            string cmdText3 = $"DELETE from CupTrans where m_id={ this.cupid.ToString() }";
                            using (NewMatchService newMatchService = new NewMatchService())
                            {
                                newMatchService.Update(cmdText2);
                                newMatchService.Update(cmdText3);
                            }
                            this.ShowCUPall();
                        }
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

        public void ShowCUPall()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Type='CUP' ORDER BY Sr_No DESC";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader[0].ToString();
                    this.DataGridView1.Rows[index].Cells[1].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader[1].ToString()), DateFormat.ShortDate);
                    this.DataGridView1.Rows[index].Cells[2].Value = oleDbDataReader[4].ToString();
                    this.DataGridView1.Rows[index].Cells[3].Value = oleDbDataReader[2].ToString();
                    this.DataGridView1.Rows[index].Cells[4].Value = oleDbDataReader[3].ToString();
                    this.DataGridView1.Rows[index].Cells[5].Value = oleDbDataReader[20].ToString();
                }
                if (this.DataGridView1.RowCount != 0)
                {
                    this.DataGridView1.Rows[0].Cells[1].Selected = true;
                    this.DataGridView1.Focus();
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

        private void btnmatchbook_Click(object sender, EventArgs e)
        {
            try
            {
                Cup_match_Book cup_Match_Book = new Cup_match_Book();
                cup_Match_Book.MdiParent = this.MdiParent;
                cup_Match_Book.WindowState = FormWindowState.Maximized;
                cup_Match_Book.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Cup_Report_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
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
                if (Module1.IDCUP == 0)
                {
                    Interaction.MsgBox("Select Match?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    MyProject.Forms.CUP.MdiParent = this.MdiParent;
                    MyProject.Forms.CUP.WindowState = FormWindowState.Maximized;
                    MyProject.Forms.CUP.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                fromCUP_Winar fromCUP_Winar = new fromCUP_Winar();
                fromCUP_Winar.MdiParent = this.MdiParent;
                fromCUP_Winar.WindowState = FormWindowState.Maximized;
                fromCUP_Winar.Show();
                //this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void btnundclard_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = new TextBox();
                textBox.Text = this.cupid.ToString();
                if (Operators.CompareString(textBox.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please Select Cup Than Proced..?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Interaction.MsgBox("Do you want to Un-Declared Match..?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes && Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "SELECT tns_MatchID, tns_Monday_Final, tns_Sessionid FROM Trans WHERE (tns_MatchID = " + textBox.Text + ") AND (tns_Monday_Final = 'Yes') AND (tns_Sessionid = 0)";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Records are settled or Monday final for this match", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        cmdText = $"DELETE FROM Trans WHERE tns_MatchID = {textBox.Text} AND tns_Sessionid = 0 ";

                        string cmdText1 = $"UPDATE Newmatch SET Result = 'UnDeclared', Remark = '' WHERE Newmatch.Sr_No = {textBox.Text} ";

                        string cmdText2 = $"UPDATE CupTrans SET M_Tem_Out = 0 WHERE m_id = {textBox.Text} ";

                        using (TransactionService transactionService = new TransactionService())
                        {
                            transactionService.Insert(cmdText);
                            transactionService.Insert(cmdText1);
                            transactionService.Insert(cmdText2);
                        }
                        Interaction.MsgBox("Match is Un-Declared..?", MsgBoxStyle.OkOnly, null);
                        this.ShowCUPall();
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
                if (Module1.IDCUP == 0)
                {
                    Interaction.MsgBox("Select Match?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    MyProject.Forms.CUP.MdiParent = this.MdiParent;
                    MyProject.Forms.CUP.WindowState = FormWindowState.Maximized;
                    MyProject.Forms.CUP.Show();
                    this.Close();
                }
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
                    if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, null, false))
                    {
                        this.cupid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                        Module1.IDCUP = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value.ToString());
                        if (Module1.IDCUP == 0)
                        {
                            Interaction.MsgBox("Select Match?", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            MyProject.Forms.CUP.MdiParent = this.MdiParent;
                            MyProject.Forms.CUP.WindowState = FormWindowState.Maximized;
                            MyProject.Forms.CUP.Show();
                            this.Close();
                        }
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
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel4.Visible = false;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
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
                    "SELECT Sr_No, Date1, Type FROM Newmatch WHERE (Date1 >=#",
                    text.ToString(),
                    "#) AND (Date1 <=#",
                    text2.ToString(),
                    "#) AND (Type = 'CUP') "
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
                        cmdText = "DELETE FROM Newmatch WHERE(Newmatch.Sr_No = " + NewLateBinding.LateIndexGet(objectValue, new object[]
                        {
                            0
                        }, null).ToString() + ")";
                        string cmdText1 = "DELETE FROM CupTrans WHERE(CupTrans.m_id = " + NewLateBinding.LateIndexGet(objectValue, new object[]
                        {
                            0
                        }, null).ToString() + ")";
                        using (NewMatchService newMatchService = new NewMatchService())
                        {
                            newMatchService.Update(cmdText);
                            newMatchService.Update(cmdText1);
                        }
                    }
                }
                finally
                {
                    //IEnumerator enumerator;
                    //if (enumerator is IDisposable)
                    //{
                    //	(enumerator as IDisposable).Dispose();
                    //}
                }
                this.Panel4.Visible = false;
                this.ShowCUPall();
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

        // Token: 0x0400022C RID: 556
        private int cupid;

    }
}
