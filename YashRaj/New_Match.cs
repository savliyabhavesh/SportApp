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
using App.Service;

namespace YashAksh
{
    // Token: 0x0200005C RID: 92
    [DesignerGenerated]
    public partial class New_Match : Form
    {
        public New_Match()
        {
            this.InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Match_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
                this.txtdate.Text = Conversions.ToString(DateAndTime.Now.Date);
                this.allcapitalward();
                this.Atouid();
                this.ModifyMatch();
                this.txtteam1.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void ModifyMatch()
        {
            try
            {
                if (Conversions.ToInteger(Module1.modifymatchid) != 0)
                {
                    this.txtid.Text = Module1.modifymatchid.ToString();
                    if (Module1.conn.State == ConnectionState.Open)
                    {
                        Module1.conn.Close();
                    }
                    Module1.conn.Open();
                    string cmdText = "Select * from Newmatch where Sr_No=" + this.txtid.Text + "";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        //this.txtid.Text = Conversions.ToString(oleDbDataReader[0]);
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
                        //this.RedOnly();
                    }
                    else
                    {
                        Interaction.MsgBox("Record No", MsgBoxStyle.OkOnly, null);
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

        public void Atouid()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(tb_MID) from tb_MYID";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        this.txtid.Text = "1";
                    }
                    else
                    {
                        int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        num++;
                        this.txtid.Text = Conversions.ToString(num);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.txttype_Leave(RuntimeHelpers.GetObjectValue(sender), e);
                if (Operators.CompareString(this.txtid.Text, null, false) == 0
                    || Operators.CompareString(this.txtdate.Text, null, false) == 0
                    || Operators.CompareString(this.txtteam1.Text, null, false) == 0
                    || Operators.CompareString(this.txtteam2.Text, null, false) == 0
                    || Operators.CompareString(this.txttype.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill all information ?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string str = "Select * from Newmatch Where Sr_No=" + this.txtid.Text + "";
                    OleDbCommand oleDbCmd = new OleDbCommand(str, Module1.conn);
                    OleDbDataReader oleDbDataRdr = oleDbCmd.ExecuteReader();

                    if (oleDbDataRdr.Read())
                    {
                        string cmdText = $"Update Newmatch set Team1='{this.txtteam1.Text}', Name='{this.txtteam2.Text}', Type='{this.txttype.Text}', horse1='{this.txth1.Text}', horse2='{this.txth2.Text}', horse3='{this.txth3.Text}', horse4='{this.txth4.Text}', horse5='{this.txth5.Text}', horse6='{this.txth6.Text}', horse7='{this.txth7.Text}', horse8='{this.txth8.Text}', horse9='{this.txth9.Text}', horse10='{this.txth10.Text}', horse11='{this.txth11.Text}', horse12='{this.txth12.Text}', horse13='{this.txth13.Text}', horse14='{this.txth14.Text}', horse15='{this.txth15.Text}' , Date1='{this.txtdate.Text}'  Where Sr_No={this.txtid.Text}";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText);
                        }

                        Interaction.MsgBox("Record Updated", MsgBoxStyle.OkOnly, null);
                        this.Close();
                    }
                    else
                    {
                        string strcurrenttime = Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime);
                        string cmdText = $"insert into NewMatch Values({this.txtid.Text},'{this.txtdate.Text}','{this.txtteam1.Text}','{this.txtteam2.Text}','{this.txttype.Text}','{this.txth1.Text}','{this.txth2.Text}','{this.txth3.Text}','{this.txth4.Text}','{this.txth5.Text}','{this.txth6.Text}','{this.txth7.Text}','{this.txth8.Text}','{this.txth9.Text}','{this.txth10.Text}','{this.txth11.Text}','{this.txth12.Text}','{this.txth13.Text}','{this.txth14.Text}','{this.txth15.Text}','','','{strcurrenttime}')";
                        string cmdText1 = $"UPDATE tb_MYID SET tb_MID = {this.txtid.Text}";
                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText);
                            matchService.Update(cmdText1);
                        }

                        Interaction.MsgBox("Record Saved", MsgBoxStyle.OkOnly, null);
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
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void allcapitalward()
        {
            try
            {
                this.txtid.CharacterCasing = CharacterCasing.Upper;
                this.txtteam1.CharacterCasing = CharacterCasing.Upper;
                this.txtteam2.CharacterCasing = CharacterCasing.Upper;
                this.txth1.CharacterCasing = CharacterCasing.Upper;
                this.txth2.CharacterCasing = CharacterCasing.Upper;
                this.txth3.CharacterCasing = CharacterCasing.Upper;
                this.txth4.CharacterCasing = CharacterCasing.Upper;
                this.txth5.CharacterCasing = CharacterCasing.Upper;
                this.txth6.CharacterCasing = CharacterCasing.Upper;
                this.txth7.CharacterCasing = CharacterCasing.Upper;
                this.txth8.CharacterCasing = CharacterCasing.Upper;
                this.txth9.CharacterCasing = CharacterCasing.Upper;
                this.txth10.CharacterCasing = CharacterCasing.Upper;
                this.txth11.CharacterCasing = CharacterCasing.Upper;
                this.txth12.CharacterCasing = CharacterCasing.Upper;
                this.txth13.CharacterCasing = CharacterCasing.Upper;
                this.txth14.CharacterCasing = CharacterCasing.Upper;
                this.txth15.CharacterCasing = CharacterCasing.Upper;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtteam1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txth1.Text = this.txtteam1.Text;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtteam2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txth2.Text = this.txtteam2.Text;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void New_Match_KeyDown(object sender, KeyEventArgs e)
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

        private void txttype_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txttype.Text, "TEST", false) == 0)
                {
                    this.txth3.Text = "DRW";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

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
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void New_Match_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Module1.modifymatchid = 0;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void New_Match_Deactivate(object sender, EventArgs e)
        {
            try
            {
                Module1.modifymatchid = 0;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }
    }

}

