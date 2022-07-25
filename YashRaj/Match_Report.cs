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
    public partial class Match_Report : Form
    {
        public Match_Report()
        {
            this.InitializeComponent();
        }

        private void Match_Report_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.testvalue();
        }

        // Token: 0x060015C9 RID: 5577 RVA: 0x00363EA4 File Offset: 0x003622A4
        private void Match_Report_Load(object sender, EventArgs e)
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
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.machid == 0)
                {
                    MessageBox.Show("Please select match ?", "Match", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
                    MyProject.Forms.Session_Report.Show();
                    MyProject.Forms.Match.MdiParent = this.MdiParent;
                    MyProject.Forms.Match.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Session_Report session_Report = new Session_Report();
            //session_Report.CheckOPenSession();
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.TextBox6.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Please select match ?", MsgBoxStyle.OkOnly, null);
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
                    Interaction.MsgBox("Match is Declared ", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    Module1.modifymatchid = Conversions.ToInteger(this.TextBox5.Text);
                    New_Match new_Match = new New_Match();
                    new_Match.MdiParent = this.MdiParent;
                    new_Match.Show();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        public void matchbok()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.listid.Text + "";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    Module1.matchbooklist = Conversions.ToInteger(oleDbDataReader[0]);
                    Match_Book match_Book = new Match_Book();
                    match_Book.MdiParent = this.MdiParent;
                    match_Book.WindowState = FormWindowState.Maximized;
                    match_Book.Show();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        //private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        //{
        //	try
        //	{
        //		if (Module1.conn.State == ConnectionState.Closed)
        //		{
        //			Module1.conn.Open();
        //		}
        //		string selectCommandText = "Select * from   Newmatch ";
        //		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
        //		DataSet dataSet = new DataSet();
        //		oleDbDataAdapter.Fill(dataSet, "dt");
        //		DataRow dataRow = dataSet.Tables["dt"].Rows[this.DataGridView1.CurrentRow.Index];
        //		this.TextBox5.Text = Conversions.ToString(dataRow[0]);
        //		this.listid.Text = Conversions.ToString(dataRow[0]);
        //		this.idno();
        //	}
        //	catch (Exception ex)
        //	{
        //		//Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //	finally
        //	{
        //		Module1.conn.Close();
        //	}
        //}

        public void idno()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string selectCommandText = "Select *from   Newmatch ";
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                DataSet dataSet = new DataSet();
                oleDbDataAdapter.Fill(dataSet, "dt");
                DataRow dataRow = dataSet.Tables["dt"].Rows[this.DataGridView1.CurrentRow.Index];
                this.TextBox6.Text = Conversions.ToString(dataRow[0]);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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
                if (Operators.CompareString(this.TextBox5.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Please select match?", MsgBoxStyle.OkOnly, null);
                }
                else if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Interaction.MsgBox("Be careful. It will delete this match data. Are you sure?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }

                        string cmdText = "select Sr_No,Result from Newmatch where Sr_No=" + this.TextBox5.Text + " and Result='Declared'";
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {
                            Interaction.MsgBox("Match is Declared ", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            string cmdText1 = string.Concat(new string[]
                            {
                                " delete * from Newmatch where Sr_No=" + this.TextBox5.Text + "; ",
                                " delete * from MatchTrans where m_id=" + this.TextBox5.Text + "; ",
                                " delete * from MatchTrans1 where m_id=" + this.TextBox5.Text + "; ",
                                " delete * from ewSession where Match_ID=" + this.TextBox5.Text + "; ",
                                " delete * from SessionTrans where S_Sr_No=" + this.TextBox5.Text + "; ",
                                " delete * from Abdntie where Match_ID=" + this.TextBox5.Text +"; ",
                                " delete * from Trans where tns_MatchID=" + this.TextBox5.Text +""
                            });
                            string[] sqlStatements = cmdText1.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string statement in sqlStatements)
                            {
                                Module1.conn.Close();
                                using (MatchService matchService = new MatchService())
                                {
                                    matchService.Update(statement);
                                }
                            }
                            Interaction.MsgBox("Delete Match Successfully");
                            this.testvalue();
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

        public void testvalue()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT Sr_No, Date1, Team1, Name, Type, horse1, horse2, horse3, horse4, horse5, horse6, horse7, horse8, horse9, horse10, horse11, horse12, horse13, horse14, horse15,Result, Remark, Type AS Expr1 FROM(Newmatch) WHERE (Type <> 'CUP') AND (Type <> 'TOSS') ORDER BY Sr_No DESC";
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
                    this.DataGridView1.Rows[0].Cells[1].Selected = true;
                    this.TextBox6.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                    Module1.Matchdecalerd = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                    this.listid.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                    this.TextBox5.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                    this.txtdecl.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[5].Value);
                    Module1.machid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                    this._MYdate = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
                    this.DataGridView1.Focus();
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

        private void btnmdeclare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.TextBox5.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Select the Name", MsgBoxStyle.OkOnly, null);
                }
                else
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
                        frommatchDecleard frommatchDecleard = new frommatchDecleard();
                        frommatchDecleard.MdiParent = this.MdiParent;
                        frommatchDecleard.WindowState = FormWindowState.Maximized;
                        frommatchDecleard.Show();
                        //this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        public void Decaler()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.TextBox5.Text + " ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    Module1.mdeclare = Conversions.ToInteger(oleDbDataReader[0]);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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
                if (Operators.CompareString(this.TextBox6.Text, "", false) == 0)
                {
                    Interaction.MsgBox("select the match", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    ////this.matchbok();
                    Module1.chkmatchbook = true;
                    Module1.matchbooklist = Conversions.ToInteger(this.listid.Text);
                    MyProject.Forms.Match_Book.MdiParent = this.MdiParent;
                    MyProject.Forms.Match_Book.WindowState = FormWindowState.Maximized;
                    MyProject.Forms.Match_Book.Show();
                    //this.Close();

                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Match_Report_KeyDown(object sender, KeyEventArgs e)
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

        private void UnDeclare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.TextBox5.Text, "", false) == 0)
                {
                    Interaction.MsgBox(" Please Select this match ", MsgBoxStyle.OkOnly, null);
                }
                else if (Interaction.MsgBox("Do you want to Un-Declared Match..?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string text = Conversions.ToDate(this._MYdate).ToString("yyyy-MM-dd");
                    string cmdText = string.Concat(new string[]
                    {
                        "SELECT tns_MatchID, tns_Monday_Final, tns_Sessionid FROM Trans WHERE (tns_MatchID = ",
                        this.TextBox5.Text,
                        ") AND (tns_Monday_Final = 'Yes') AND (tns_Sessionid = 0) "
						//AND (tns_dt=#",
						//text.ToString(),
						//"#)"
					});
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

        private void DataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                this.TextBox6.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                Module1.Matchdecalerd = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                this.listid.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                this.TextBox5.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                this.txtdecl.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[5].Value);
                Module1.machid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                this._MYdate = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        //private void Match_Report_MouseEnter(object sender, EventArgs e)
        //{	
        //	this.WindowState = FormWindowState.Maximized;
        //}

        private void Match_Report_MaximumSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void DataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                this.Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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
                    this.listid.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.TextBox5.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.txtdecl.Text = this.DataGridView1.CurrentRow.Cells[5].Value.ToString();
                    Module1.machid = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                    this._MYdate = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);

                    if (Module1.machid == 0)
                    {
                        MessageBox.Show("Please select match ?", "Match", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
                        MyProject.Forms.Session_Report.Show();
                        MyProject.Forms.Match.MdiParent = this.MdiParent;
                        MyProject.Forms.Match.Show();
                        this.Close();
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
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Panel4.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Do you want to delete match by given date range???", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
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
                    "#) AND (Type <> 'CUP')"
                    });
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                    DataSet dataSet = new DataSet();
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.SelectCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbDataAdapter.Fill(dataSet);
                    dataTable = dataSet.Tables[0];
                    try
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            string strMatchId = Conversions.ToString(dataTable.Rows[i]["Sr_No"]);
                            string cmdText1 = string.Concat(new string[]
                            {
                                " delete * from Newmatch where Sr_No=" + strMatchId + "; ",
                                " delete * from MatchTrans where m_id=" + strMatchId + "; ",
                                " delete * from MatchTrans1 where m_id=" + strMatchId + "; ",
                                " delete * from ewSession where Match_ID=" + strMatchId + "; ",
                                " delete * from SessionTrans where S_Sr_No=" + strMatchId + "; ",
                                " delete * from Abdntie where Match_ID=" + strMatchId +""
                            });
                            string[] sqlStatements = cmdText1.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                            OleDbTransaction transaction = Module1.conn.BeginTransaction();
                            foreach (string statement in sqlStatements)
                            {
                                using (MatchService matchService = new MatchService())
                                {
                                    matchService.Update(statement);
                                }
                            }
                            transaction.Commit();
                        }
                    }
                    finally
                    {
                        Module1.conn.Close();
                    }
                    this.Panel4.Visible = false;
                    this.testvalue();
                    Interaction.MsgBox("Delete Match Successfully");
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x0400093B RID: 2363
        public string _MYdate;

    }
}
