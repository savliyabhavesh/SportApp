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
    // Token: 0x020000C5 RID: 197
    [DesignerGenerated]
    public partial class Session_Report : Form
    {
        public Session_Report()
        {
            this.InitializeComponent();
    }
        private void Session_Report_Activated(object sender, EventArgs e)
        {
            try
            {
                this.sessionrept();
                this.my_Positions();
                //try
                //{
                //	this.DataGridView2.Rows[0].Cells[0].Selected = true;
                //	this.DataGridView2.Focus();
                //	//SendKeys.Send("{Tab}");					
                //}
                //catch (Exception ex)
                //{
                //	//this.DataGridView2.Rows[0].Cells[0].Selected = true;
                //	//this.DataGridView2.Focus();
                //}
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
                Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
            }
        }
        private void Session_Report_Load(object sender, EventArgs e)
        {
            try
            {
                //this.WindowState = FormWindowState.Maximized;
                this.txtMatchId.Text = Conversions.ToString(Module1.machid);
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
                Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void sessionrept()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "";
                if (Conversions.ToString(this.txtMatchId.Text) != "" && Conversions.ToString(this.txtMatchId.Text) != "0")
                {
                    cmdText = "Select * from ewSession where Match_ID=" + this.txtMatchId.Text.ToString() + " ORDER BY Sr_No DESC";
                }
                else
                {
                    cmdText = "Select * from ewSession ORDER BY Sr_No DESC";
                    Button13.Enabled = false;
                }

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView2.Rows.Add();
                    //this.DataGridView2.RowCount = 5;
                    this.DataGridView2.Rows[index].Cells[0].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Dt"].ToString()), DateFormat.ShortDate);
                    this.DataGridView2.Rows[index].Cells[1].Value = oleDbDataReader["N_name"].ToString();
                    this.DataGridView2.Rows[index].Cells[2].Value = oleDbDataReader["Result"].ToString();
                    this.DataGridView2.Rows[index].Cells[3].Value = oleDbDataReader["Match_ID"].ToString();
                    this.DataGridView2.Rows[index].Cells[4].Value = oleDbDataReader["Sr_No"].ToString();
                    this.DataGridView2.Rows[index].Cells[5].Value = oleDbDataReader["Type"].ToString();
                }

                if (this.DataGridView2.RowCount != 0)
                {
                    this.DataGridView2.Rows[0].Cells[1].Selected = true;
                    if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[3].Value, null, false))
                    {
                        this.txtid.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
                        Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                        Module1.sessionid = this.txtid.Text;
                        Module1.commtype = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[5].Value);
                        this._MYdate = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[0].Value);

                        Module1.modifysessionid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                        Module1.modifysessionname = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[1].Value);
                    }
                    this.DataGridView2.Focus();
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

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * from ewSession where Match_ID=", Module1.sessionid.ToString()), " and Sr_No="), Module1.nehaid.ToString()), " and Result='Declared'".ToString()));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    MessageBox.Show("Match is Declared..?", "Hello", MessageBoxButtons.OK);
                }
                else
                {
                    Declear_New_Sesstions declear_New_Sesstions = new Declear_New_Sesstions();
                    declear_New_Sesstions._my_Positions();
                    declear_New_Sesstions.MdiParent = this.MdiParent;
                    declear_New_Sesstions.Show();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        private void BtnUnDeclare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(Module1.sessionid.ToString(), "0", false) == 0)
                {
                    Interaction.MsgBox("Please Select Session..?", MsgBoxStyle.OkOnly, null);
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
                        ") "
						//AND (tns_dt=#",
						//text.ToString(),
						//"#)"
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
                        cmdText = $"UPDATE ewSession set Result='UnDeclared',Remark='' where Sr_No={Module1.nehaid.ToString()} and Match_ID={Module1.sessionid.ToString()}";
                        string cmdText1 = $"DELETE FROM Trans WHERE tns_MatchID = {Module1.sessionid.ToString()} AND tns_Sessionid = {Module1.nehaid.ToString()} ";
                        using (TransactionService transactionService = new TransactionService())
                        {
                            transactionService.Insert(cmdText);
                            transactionService.Insert(cmdText1);
                        }
                        this.sessionrept();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                MyProject.Forms.Match.Match_Max_Mini();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * from ewSession where Match_ID=", Module1.sessionid.ToString()), " and Sr_No=".ToString()), Module1.nehaid.ToString()), " and Result='Declared'".ToString()));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    Interaction.MsgBox("Match is Declared?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    New_Session new_Session = new New_Session();
                    new_Session.MdiParent = this.MdiParent;
                    new_Session.my_Positions();
                    new_Session.Show();

                    //MyProject.Forms.modifySession.MdiParent = this.MdiParent;
                    //MyProject.Forms.modifySession.WindowState = FormWindowState.Maximized;                    
                    //MyProject.Forms.modifySession.Show();
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

                        string cmdText3 = $"DELETE from ewSession where Match_ID={Module1.sessionid} and Sr_No={Module1.nehaid}";
                        string cmdText4 = $"DELETE from SessionTrans where S_Sr_No={Module1.sessionid} and Session_ID={Module1.nehaid}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText3);
                            sessionService.Update(cmdText4);
                        }
                        this.sessionrept();
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

        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[3].Value, null, false))
                {
                    this.txtid.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
                    Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                    Module1.sessionid = this.txtid.Text;
                    this._MYdate = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[0].Value);
                    //Module1.sessiondelc = null;

                    Module1.modifysessionid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                    Module1.modifysessionname = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[1].Value);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtid.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
                    Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                    Module1.sessionid = this.txtid.Text;
                    Module1.commtype = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[5].Value);
                    this._MYdate = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[0].Value);

                    Module1.modifysessionid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                    Module1.modifysessionname = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[1].Value);

                    //Form3_SESSION form3_SESSION = new Form3_SESSION();
                    //form3_SESSION.MdiParent = this.MdiParent;
                    //form3_SESSION.Show();
                    MyProject.Forms.Form3_SESSION.MdiParent = this.MdiParent;
                    MyProject.Forms.Form3_SESSION.Show();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void DataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[3].Value, null, false))
                {
                    this.txtid.Text = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[3].Value);
                    Module1.nehaid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                    Module1.sessionid = this.txtid.Text;
                    Module1.commtype = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[5].Value);
                    this._MYdate = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[0].Value);

                    Module1.modifysessionid = Conversions.ToInteger(this.DataGridView2.CurrentRow.Cells[4].Value);
                    Module1.modifysessionname = Conversions.ToString(this.DataGridView2.CurrentRow.Cells[1].Value);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

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
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void my_Positions()
        {
            try
            {
                Size size = new Size(732, 659);
                this.Size = size;
                int x = checked(Screen.PrimaryScreen.WorkingArea.Width - 738);
                int y = 0;
                //Solve Error
                //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
                Point location = new Point(x, y);
                this.Location = location;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                Module1.modifysessionid = 0;
                Module1.modifysessionname = "";
                New_Session new_Session = new New_Session();
                new_Session.MdiParent = this.MdiParent;
                new_Session.my_Positions();
                new_Session.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x04000CD6 RID: 3286
        public string _MYdate;

        private void Session_Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                MyProject.Forms.Match.Activate();
            }
        }
    }
}

