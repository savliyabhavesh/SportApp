using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using YashAksh.My;

using System.Runtime.InteropServices;
using App.Service;
// add these six lines inside your class

namespace YashAksh
{
    public partial class AccountLedger : Form
    {
        private double modifyid = 0;
        private bool isdataload = false;
        public AccountLedger()
        {
            this.InitializeComponent();
        }

        private void AccountLedger_Activated(object sender, EventArgs e)
        {
            try
            {
                //this.txtPartyName.Focus();
                this.txttraName.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void AccountLedger_Load(object sender, EventArgs e)
        {
            try
            {
                ControlExtension.Draggable(panel2, true);
                this.WindowState = FormWindowState.Maximized;
                this.DataGridView1.Rows.Clear();
                this.txtPartyName.Text = Conversions.ToString(Module1.tranID);
                this.name_lode();
                this.txtremark.CharacterCasing = CharacterCasing.Upper;

                this.Opening_Balance();
                this.Button4.Hide();
                this.Button5.Hide();

                this.txttraName.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void name_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyName, ID FROM (PartyMaster) ORDER BY PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.txttraName.Items.Clear();
                this.txtPartyName.Items.Clear();
                while (oleDbDataReader.Read())
                {
                    this.txttraName.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"])).ToString();
                    this.txtPartyName.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"])).ToString();
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

        private void btnoldrecord_Click(object sender, EventArgs e)
        {
            try
            {
                Module1.tranID = this.txtPartyName.Text.ToString();
                MyProject.Forms.PrevoiusData.MdiParent = this.MdiParent;
                MyProject.Forms.PrevoiusData.WindowState = FormWindowState.Maximized;
                MyProject.Forms.PrevoiusData.Show();
                //MyProject.Forms.PrevoiusData.MdiParent = this.MdiParent;
                //MyProject.Forms.PrevoiusData.WindowState = FormWindowState.Maximized;
                //MyProject.Forms.PrevoiusData.Show();
                ////this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.DataGridView1.Rows.Count > 0)
                {
                    if (this.DataGridView1.CurrentRow.Cells[3].Value.ToString() == "CR" || this.DataGridView1.CurrentRow.Cells[3].Value.ToString() == "DR")
                    {
                        modifyid = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[8].Value));
                    }
                    else
                    {
                        modifyid = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtPartyName.SelectionStart <= 1)
                        {
                            this.txtPartyName.Text = "";
                            return;
                        }
                        if (this.txtPartyName.SelectionLength == 0)
                        {
                            text = this.txtPartyName.Text.Substring(0, this.txtPartyName.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtPartyName.Text.Substring(0, this.txtPartyName.SelectionStart - 1);
                        }
                    }
                    else if (this.txtPartyName.SelectionLength == 0)
                    {
                        text = this.txtPartyName.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtPartyName.Text.Substring(0, this.txtPartyName.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtPartyName.FindString(text);
                    if (num != -1)
                    {
                        this.txtPartyName.SelectedText = "";
                        this.txtPartyName.SelectedIndex = num;
                        this.txtPartyName.SelectionStart = text.Length;
                        this.txtPartyName.SelectionLength = this.txtPartyName.Text.Length;
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
            }
        }

        public void AutoComplete1(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txttraName.SelectionStart <= 1)
                        {
                            this.txttraName.Text = "";
                            return;
                        }
                        if (this.txttraName.SelectionLength == 0)
                        {
                            text = this.txttraName.Text.Substring(0, this.txttraName.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txttraName.Text.Substring(0, this.txttraName.SelectionStart - 1);
                        }
                    }
                    else if (this.txttraName.SelectionLength == 0)
                    {
                        text = this.txttraName.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txttraName.Text.Substring(0, this.txttraName.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txttraName.FindString(text);
                    if (num != -1)
                    {
                        this.txttraName.SelectedText = "";
                        this.txttraName.SelectedIndex = num;
                        this.txttraName.SelectionStart = text.Length;
                        this.txttraName.SelectionLength = this.txttraName.Text.Length;
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
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        
        {
            try
            {
                if (Operators.CompareString(this.txttraName.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Insert the Party Name ?", MsgBoxStyle.OkOnly, null);
                    this.txttraName.Focus();
                }
                else if (Operators.CompareString(this.txtPartyName.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Insert the Party Name ?", MsgBoxStyle.OkOnly, null);
                    this.txtPartyName.Focus();
                }
                else if (Conversion.Val(this.txtamount.Text) == 0)
                {
                    Interaction.MsgBox("Please Insert Amount ?", MsgBoxStyle.OkOnly, null);
                    this.txtamount.Focus();
                }
                else if (Operators.CompareString(this.txttraName.Text, this.txtPartyName.Text, false) == 0)
                {
                    Interaction.MsgBox("Party Name Same Not Allow ?", MsgBoxStyle.OkOnly, null);
                    this.txttraName.Text = null;
                    this.txttraName.Focus();
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select * from PartyMaster where PartyName='" + this.txttraName.Text + "'";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    string text;
                    if (Operators.CompareString(this.txtremark.Text, null, false) == 0)
                    {
                        text = " ";
                    }
                    else
                    {
                        text = " (" + this.txtremark.Text + ")";
                    }
                    if (oleDbDataReader.Read())
                    {
                        this.DataGridView5.Rows.Clear();
                        this.DataGridView5.Rows.Add();
                        this.DataGridView5.Rows.Add();

                        this.DataGridView5.Rows[0].Cells[0].Value = this.txttraName.Text;
                        this.DataGridView5.Rows[0].Cells[1].Value = Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text);
                        this.DataGridView5.Rows[0].Cells[2].Value = this.txtPartyName.Text + text.ToString();
                        this.DataGridView5.Rows[0].Cells[3].Value = "0";

                        this.DataGridView5.Rows[1].Cells[0].Value = this.txtPartyName.Text;
                        this.DataGridView5.Rows[1].Cells[1].Value = this.txtamount.Text;
                        this.DataGridView5.Rows[1].Cells[2].Value = this.txttraName.Text + text.ToString();
                        this.DataGridView5.Rows[1].Cells[3].Value = "1";

                        string cmdText2 = "select max(tns_ModifyID) from Trans";
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        checked
                        {
                            int num;
                            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
                            {
                                num = Conversions.ToInteger("1");
                            }
                            else
                            {
                                num = Conversions.ToInteger(oleDbCommand2.ExecuteScalar());
                                num++;
                            }
                            this.TextBox4.Text = Conversions.ToString(num);
                            try
                            {
                                foreach (object obj in ((IEnumerable)this.DataGridView5.Rows))
                                {
                                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                                    if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                                    {
                                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, 0, false))
                                        {
                                            if (Module1.conn.State == ConnectionState.Closed)
                                            {
                                                Module1.conn.Open();
                                            }

                                            string cmdText3 = "insert into Trans(tns_Party,tns_Amount,tns_Remark,tns_MatchID,tns_dt,tns_Type,tns_Vid,tns_Monday,tns_Sessionid,tns_ModifyID,tns_Monday_Final,tns_Hawala,tns_chk,tns_time,tns_date) values(@tns_Party,@tns_Amount,@tns_Remark,@tns_matchid,@tns_dt,@tns_type,@tns_vid,@tns_monday,@tns_sessionid,@tns_ModifyID,@tns_Monday_Final,@tns_Hawala,@tns_chk,@tns_time,@tns_date)";
                                            OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                                            oleDbCommand3.Parameters.AddWithValue("@tns_Party", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
                                            oleDbCommand3.Parameters.AddWithValue("@tns_Amount", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
                                            oleDbCommand3.Parameters.AddWithValue("@tns_Remark", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
                                            oleDbCommand3.Parameters.AddWithValue("@tns_matchid", "0");
                                            oleDbCommand3.Parameters.AddWithValue("@tns_dt", this.txtdate.Text);
                                            oleDbCommand3.Parameters.AddWithValue("@tns_type", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)) > 0 ? "CR" : "DR");
                                            oleDbCommand3.Parameters.AddWithValue("@tns_vid", "0");
                                            oleDbCommand3.Parameters.AddWithValue("@tns_monday", "0");
                                            oleDbCommand3.Parameters.AddWithValue("@tns_sessionid", "0");
                                            oleDbCommand3.Parameters.AddWithValue("@tns_ModifyID", this.TextBox4.Text);
                                            oleDbCommand3.Parameters.AddWithValue("@tns_Monday_Final", "No");
                                            oleDbCommand3.Parameters.AddWithValue("@tns_Hawala", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value));
                                            oleDbCommand3.Parameters.AddWithValue("@tns_chk", "0");
                                            oleDbCommand3.Parameters.AddWithValue("@tns_time", Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime));
                                            oleDbCommand3.Parameters.AddWithValue("@tns_date", this.txtdate.Text);
                                            oleDbCommand3.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {

                            }

                            this.txttraName.Focus();
                            this.Opening_Balance();

                            this.txttraName.Text = null;
                            this.txtamount.Text = "";
                            this.txtremark.Text = "";
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("Please Create A/C Than Proced...?", MsgBoxStyle.OkOnly, null);
                        this.txttraName.Text = null;
                        this.txttraName.Focus();
                    }
                }
                this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        private void Monday_Final_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPartyName.Text != "" && this.DataGridView1.RowCount != 0)
                {
                    if (MessageBox.Show("Do You Want to Make Monday Settlement..?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (this.DataGridView1.Rows[this.DataGridView1.RowCount - 1].Cells[3].Value.ToString() == "Monday Settlement")
                        {
                            Interaction.MsgBox("Monday Final Already Done You Can not make..!", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            if (Module1.conn.State == ConnectionState.Closed)
                            {
                                Module1.conn.Open();
                            }

                            string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT tns_Party, tns_Amount, tns_dt, tns_Type, tns_chk FROM(Trans) WHERE        (tns_Type <> 'Monday Settlement') AND (tns_chk = '0') AND (tns_Party = '", this.txtPartyName.Text), "')"));
                            OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText2, Module1.conn);
                            OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
                            double num4 = 0;
                            while (oleDbDataReader1.Read())
                            {
                                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader1["tns_Amount"])))
                                {
                                    num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader1["tns_Amount"]));
                                }
                            }

                            string remark = "Monday Final " + this.txtdate.Text;
                            //string cmdText = "INSERT INTO Trans(tns_Party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_Monday_Final, tns_time) VALUES ('" + this.txtPartyName.Text + "'," + this.lblCloseBalance.Text + ",'" + remark + "',0,'" + this.txtdate.Text + "','Monday Settlement',0,1,0,'Yes','" + Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) + "')";
                            string cmdText = "INSERT INTO Trans(tns_Party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_Monday_Final, tns_time) VALUES ('" + this.txtPartyName.Text + "'," + Conversion.Val(num4) + ",'" + remark + "',0,'" + this.txtdate.Text + "','Monday Settlement',0,1,0,'Yes','" + Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) + "')";
                            OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, Module1.conn);
                            oleDbCommand2.ExecuteNonQuery();

                            cmdText = "update Trans set tns_Monday_Final='Yes' where tns_Monday_Final='No' and tns_Party='" + this.txtPartyName.Text + "'";
                            OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText, Module1.conn);
                            oleDbCommand3.ExecuteNonQuery();                            

                            this.Opening_Balance();
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("Either Party Name is Blank Or Party Data Not Exist", MsgBoxStyle.OkOnly, null);
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

        private void txtmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (modifyid != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string str = "SELECT Id,tns_Party FROM Trans WHERE (tns_Type IN ('CR','DR')) AND (tns_Monday_Final = 'Yes') AND (tns_ModifyID = " + modifyid + ")";
                    OleDbCommand oleDbCmd = new OleDbCommand(str, Module1.conn);
                    OleDbDataReader oleDbDataRdr = oleDbCmd.ExecuteReader();
                    if (!oleDbDataRdr.Read())
                    {
                        string cmdText = "SELECT tns_Party, tns_Amount, tns_Remark, tns_ModifyID, tns_chk, tns_Type FROM Trans WHERE (tns_Type IN ('CR','DR')) AND (tns_chk = '0') AND (tns_ModifyID = " + modifyid + ")";
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {

                            if (Operators.CompareString(oleDbDataReader["tns_Party"].ToString(), this.txtPartyName.Text, false) == 0)
                            {
                                cmdText = "SELECT tns_Party, tns_Amount, tns_Remark, tns_ModifyID, tns_chk, tns_Type FROM Trans WHERE (tns_Type IN ('CR','DR')) AND (tns_chk = '0') AND (tns_ModifyID = " + modifyid + ") ORDER BY ID DESC";
                                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, Module1.conn);
                                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                                if (oleDbDataReader2.Read())
                                {
                                    this.txttraName.Text = oleDbDataReader2["tns_Party"].ToString();
                                    this.txtamount.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"])));
                                    string text = oleDbDataReader2["tns_Remark"].ToString();
                                    string text2 = text.Replace(this.txtPartyName.Text, "");
                                    this.txtremark.Text = text2.ToString();
                                    this.Button4.Show();
                                    this.Button5.Show();
                                    this.Button6.Hide();
                                    this.txttraName.Focus();
                                }
                            }
                            else
                            {
                                this.txttraName.Text = oleDbDataReader["tns_Party"].ToString();
                                this.txtamount.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Amount"])));
                                string text3 = oleDbDataReader["tns_Remark"].ToString();
                                string text4 = text3.Replace(this.txtPartyName.Text, "");
                                this.txtremark.Text = text4.ToString();
                                this.Button4.Show();
                                this.Button5.Show();
                                this.Button6.Hide();
                                this.txttraName.Focus();
                            }
                        }
                        else
                        {
                            Interaction.MsgBox("Cannot modify this Records ? Please Try..?", MsgBoxStyle.OkOnly, null);
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("Cannot Modify this Entry Bcoz Opposite Entry Monday Final..?", MsgBoxStyle.OkOnly, null);
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

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (modifyid != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string str = "SELECT Id,tns_Party FROM Trans WHERE (tns_Type IN ('CR','DR')) AND (tns_Monday_Final = 'Yes') AND (tns_ModifyID = " + modifyid + ")";
                    OleDbCommand oleDbCmd = new OleDbCommand(str, Module1.conn);
                    OleDbDataReader oleDbDataRdr = oleDbCmd.ExecuteReader();
                    if (!oleDbDataRdr.Read())
                    {
                        if (Interaction.MsgBox("Do you want to delete this Record", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                        {
                            if (Interaction.MsgBox("Are you sure want to delete this Entry", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                            {
                                string cmdText = "select tns_ModifyID,tns_chk from Trans where tns_ModifyID=" + modifyid + " and tns_chk='1'";
                                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                                if (oleDbDataReader.Read())
                                {
                                    Interaction.MsgBox("Cannot delete this records?", MsgBoxStyle.OkOnly, null);
                                }
                                else
                                {
                                    string cmdText2 = "update Trans set tns_chk='1',modify_time='" + Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) + "', modify_date='" + this.txtdate.Text + "' where tns_ModifyID=" + modifyid + " ";
                                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                                    oleDbCommand2.ExecuteNonQuery();
                                    this.Opening_Balance();
                                }
                            }
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("Cannot Delete this Entry Bcoz Opposite Entry Monday Final..?", MsgBoxStyle.OkOnly, null);
                    }
                }
                modifyid = 0;
                Button4.Visible = false;
                Button5.Visible = false;
                Button6.Visible = true;
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

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                //MyProject.Forms.Setlement_Report.MdiParent = this.MdiParent;
                //MyProject.Forms.Setlement_Report.WindowState = FormWindowState.Maximized;
                //MyProject.Forms.Setlement_Report.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void Opening_Balance()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                string str = "";
                OleDbCommand oleDbCmd;

                str = "DELETE FROM temptbl";
                oleDbCmd = new OleDbCommand(str, Module1.conn);
                oleDbCmd.ExecuteNonQuery();

                str = "ALTER TABLE temptbl ALTER COLUMN RowId COUNTER (1, 1)";
                oleDbCmd = new OleDbCommand(str, Module1.conn);
                oleDbCmd.ExecuteNonQuery();

                str = string.Concat(new string[]
                {
                    "INSERT INTO temptbl (Id,tns_party,tns_dt,tns_Remark,tns_Type,tns_MatchID,tns_ModifyID,tns_Monday_Final,tns_chk,Amt,horse1,horse2,chk,modify,tns_time)",
                    "SELECT Id,tns_party,tns_dt,tns_Remark,tns_Type,tns_MatchID,tns_ModifyID,tns_Monday_Final,tns_chk,Amt,horse1,horse2,chk,modify,tns_time FROM (",

                        " SELECT Id,tns_party,tns_dt,tns_Remark,tns_Type,tns_MatchID,tns_ModifyID,tns_Monday_Final,tns_chk,tns_Amount as Amt,'' as horse1,'' as horse2,chk,modify,tns_time",
                        " FROM Trans t",
                        " WHERE(tns_party = '" + this.txtPartyName.Text + "') AND (tns_MatchID = 0) AND (tns_Type <> 'BALANCE') AND (tns_Monday_Final = 'No') AND (tns_chk = '0')",

                        " UNION ALL ",

                        " SELECT 0 as Id,tns_party,tns_dt,'' as tns_Remark,'Match' as tns_Type,tns_MatchID,tns_ModifyID,tns_Monday_Final,tns_chk,SUM(tns_Amount) as Amt,n.horse1,n.horse2,chk,modify,MAX(tns_time)",
                        " FROM Trans t",
                        " INNER JOIN Newmatch n on t.tns_MatchID = n.Sr_No",
                        " WHERE (tns_party = '" + this.txtPartyName.Text + "') AND (tns_MatchID <> 0) AND (tns_Monday_Final = 'No') AND (tns_chk = '0')",
                        " GROUP BY tns_party,tns_dt,tns_MatchID,tns_ModifyID,tns_Monday_Final,tns_chk,n.horse1,n.horse2,chk,modify",

                        " UNION ALL ",

                        " SELECT Id,tns_party,tns_dt,tns_Remark,tns_Type,tns_MatchID,tns_ModifyID,tns_Monday_Final,tns_chk,tns_Amount as Amt,'' as horse1,'' as horse2,chk,modify,tns_time",
                        " FROM Trans t",
                        " WHERE(tns_party = '" + this.txtPartyName.Text + "') AND (tns_MatchID = 0) AND (tns_Monday = '1') AND (tns_Monday_Final = 'Yes') AND (tns_chk = '0')",
                        " AND (Id = (SELECT MAX(ID) FROM Trans T WHERE (t.tns_party = '" + this.txtPartyName.Text + "') AND (T.tns_MatchID = 0) AND (T.tns_Monday = '1') AND (T.tns_Monday_Final = 'Yes')))",

                    ") ORDER BY tns_dt,tns_time "
                });
                oleDbCmd = new OleDbCommand(str, Module1.conn);
                oleDbCmd.ExecuteNonQuery();

                //string cmdText = "SELECT Party_name, SUM(Amount) AS Expr1,dt FROM(OP_BAL) GROUP BY Party_name,dt HAVING (Party_name = '" + this.txtPartyName.Text + "')";
                //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                //DateTime? expression = null;
                //while (oleDbDataReader.Read())
                //{
                //    this.dblClosingBalance += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
                //    lblCloseBalance.Text = dblClosingBalance.ToString();
                //    expression = Conversions.ToDate(oleDbDataReader["dt"]);
                //    double num = Convert.ToDouble(oleDbDataReader["Expr1"]);
                //}


                this.DataGridView1.Rows.Clear();
                string cmdText2 = "SELECT T1.RowId, T1.Id, T1.tns_dt, T1.tns_Remark, T1.tns_Type, T1.tns_MatchID, T1.tns_ModifyID, IIF(T1.Amt > 0, ABS(T1.Amt), 0) as Credit, IIF(T1.Amt < 0, ABS(T1.Amt), 0) as Debit, (SELECT SUM(IIF(T2.Amt > 0, ABS(T2.Amt), 0) - IIF(T2.Amt < 0, ABS(T2.Amt), 0)) FROM temptbl T2 WHERE T2.tns_party = T1.tns_party AND T2.RowId <= T1.RowId) AS Balance, horse1, horse2, tns_chk, chk, modify, tns_time FROM temptbl T1 WHERE tns_party = '" + txtPartyName.Text + "' ORDER BY T1.RowId";
                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();

                while (oleDbDataReader2.Read())
                {
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["Id"]);
                    this.DataGridView1.Rows[index].Cells[1].Value = Strings.FormatDateTime(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_dt"])), DateFormat.ShortDate);

                    if (oleDbDataReader2["tns_Remark"].ToString() == "" && Conversion.Val(oleDbDataReader2["tns_MatchID"]) > 0)
                    {
                        this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_MatchID"].ToString()) + " - " + RuntimeHelpers.GetObjectValue(oleDbDataReader2["horse1"].ToString()) + " vs " + RuntimeHelpers.GetObjectValue(oleDbDataReader2["horse2"].ToString());
                    }
                    else
                    {
                        this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Remark"].ToString());
                    }

                    this.DataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Type"].ToString());
                    this.DataGridView1.Rows[index].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Credit"])), Module1.decimalnumberformat);
                    double num = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Debit"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Debit"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Debit"]));
                    this.DataGridView1.Rows[index].Cells[5].Value = Module1.SetNumFormat(Conversion.Val(num), Module1.decimalnumberformat);
                    this.DataGridView1.Rows[index].Cells[6].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Balance"]), Module1.decimalnumberformat);
                    this.DataGridView1.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_MatchID"].ToString());
                    this.DataGridView1.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_ModifyID"].ToString());
                    this.DataGridView1.Rows[index].Cells[9].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(oleDbDataReader2["chk"].ToString()));
                    ///this.DataGridView1.Rows[index].Cells[10].Value = Strings.FormatDateTime(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_dt"])), DateFormat.ShortDate);
                    this.DataGridView1.Rows[index].Cells[11].Value = Strings.FormatDateTime(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_time"])), DateFormat.LongTime);

                    this.lblCloseBalance.Text = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Balance"]), Module1.decimalnumberformat);


                    if (Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Balance"])) > 0)
                    {
                        this.lblCloseBalance.ForeColor = Color.Green;
                    }
                    else if (Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Balance"])) < 0)
                    {
                        this.lblCloseBalance.ForeColor = Color.Red;
                    }

                    if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_chk"].ToString())) == 1.0)
                    {
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                        //this.DataGridView1.Rows[index].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                    }
                    else if (Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader2["modify"].ToString())) == 1.0)
                    {
                        this.DataGridView1.Rows[index].DefaultCellStyle.ForeColor = Color.Blue;
                    }
                }


                if (this.DataGridView1.RowCount != 0)
                {
                    this.DataGridView1[0, 0].Selected = false;
                    this.DataGridView1[0, this.DataGridView1.Rows.Count - 1].Selected = true;
                    this.DataGridView1.FirstDisplayedScrollingRowIndex = this.DataGridView1.RowCount - 1;
                }
                else
                {
                    this.lblCloseBalance.Text = Module1.SetNumFormat(0, Module1.decimalnumberformat);
                }


                this.txttraName.Text = null;
                this.txtamount.Text = "";
                this.txtremark.Text = "";

                this.panel2.Visible = false;

                //string cmdText3 = "SELECT tns_Party, tns_dt, tns_Monday, tns_Monday_Final, tns_chk, tns_Type FROM(Trans) GROUP BY tns_Party, tns_dt, tns_Monday, tns_Monday_Final, tns_chk, tns_Type HAVING        (tns_Party = '" + this.txtPartyName.Text + "') AND (tns_Monday = '1') AND (tns_Monday_Final = 'Yes') AND (tns_chk = '0') AND (tns_Type = 'Monday Settlement') ORDER BY tns_dt DESC";
                //OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                //OleDbDataReader oleDbDataReader3 = oleDbCommand3.ExecuteReader();
                //if (oleDbDataReader3.Read())
                //{
                //    expression = Conversions.ToDate(Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader3["tns_dt"]), DateFormat.ShortDate));
                //}
                //oleDbCommand.Dispose();
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

        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && Conversion.Val(this.txtamount.Text) != 0)
                {
                    this.txtremark.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void txtremark_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (this.Button4.Visible)
                    {
                        this.Button4.Focus();
                    }
                    else
                    {
                        this.Button6.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                modifyid = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[8].Value));
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable("DataTable1");
                //DataSet dataSet = new DataSet();
                dataTable.Columns.Add("Party");
                dataTable.Columns.Add("Date");
                dataTable.Columns.Add("Remarks");
                dataTable.Columns.Add("TnsType");
                dataTable.Columns.Add("Credit");
                dataTable.Columns.Add("Debit");
                dataTable.Columns.Add("Balance");
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, null, false))
                        {
                            dataTable.Rows.Add(new object[]
                            {
                                txtPartyName.Text.ToString(),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[4].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[6].Value)
                            });
                        }
                    }
                }
                finally
                {
                }

                //dataSet.Tables.Add(dataTable);
                //DataTable dataTable2 = new DataTable("DataTable4");
                //dataTable2.Columns.Add("Column1");
                //dataTable2.Columns.Add("Column2");
                //dataTable2.Columns.Add("Column3");

                //dataSet.Tables.Add(dataTable2);
                //DataTable dataTable3 = new DataTable("DataTable5");
                //dataTable3.Columns.Add("Column1");
                //dataTable3.Columns.Add("Column2");
                //dataTable3.Columns.Add("Column3");                
                //dataSet.Tables.Add(dataTable3);

                //Add RPT
                //ReportDocument reportDocument = new T_report();
                //reportDocument.SetDataSource(dataSet);
                //reportDocument.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\T_report.rpt");
                reportDocument.SetDataSource(dataTable);
                printView.crystalReportViewer1.ReportSource = reportDocument;
                printView.ShowDialog();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        //private void txtname_KeyDown(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        if (e.KeyCode == Keys.Return)
        //        {
        //            if (Operators.CompareString(this.txtPartyName.Text, null, false) == 0)
        //            {
        //                this.Focus();
        //            }
        //            else
        //            {                        
        //                this.Opening_Balance();
        //                this.lblCloseBalance.Text = Module1.SetNumFormat(Conversion.Val(this.lblCloseBalance.Text), Module1.decimalnumberformat);
        //            }
        //        }
        //        if (e.KeyCode == Keys.Back)
        //        {
        //            this.txtPartyName.Text = null;
        //            this.Focus();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //    }
        //}

        private void txtPartyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtPartyName = this.txtPartyName;
                this.AutoComplete(ref txtPartyName, e, false);
                this.txtPartyName = txtPartyName;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtPartyName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.isdataload = true;
                    this.Opening_Balance();
                    this.txttraName.Focus();
                    this.isdataload = false;
                }
                if (e.KeyCode == Keys.Back)
                {
                    this.txtPartyName.Text = null;
                    this.txtPartyName.Focus();
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

        //private void txttraName_Enter(object sender, EventArgs e)
        //{
        //    NewLateBinding.LateCall(sender, null, "SelectAll", new object[0], null, null, null, true);
        //}

        private void txttraName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return && this.txttraName.Text != "" && this.txttraName.Text != null)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select sum(tns_Amount) AS amt from Trans where tns_Party='" + this.txttraName.Text + "' and tns_Type<>'Monday Settlement' and tns_Monday='0'and tns_chk='0'";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    double num = 0;
                    while (oleDbDataReader.Read())
                    {
                        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader["amt"])))
                        {
                            num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["amt"]));
                        }
                    }
                    this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(num), Module1.NumFormat);
                    this.txtamount.Focus();
                    this.txtamount.SelectAll();
                }
                if (e.KeyCode == Keys.Back)
                {
                    this.txttraName.Text = null;
                    this.txttraName.Focus();
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

        private void txttraName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txttraName = this.txttraName;
                this.AutoComplete1(ref txttraName, e, false);
                this.txttraName = txttraName;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.modifyid = 0;
                this.Button4.Hide();
                this.Button5.Hide();
                this.Button6.Show();
                this.txttraName.Text = null;
                this.txtamount.Text = "";
                this.txtremark.Text = "";
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
                if (Operators.CompareString(this.txttraName.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Insert the Party Name ?", MsgBoxStyle.OkOnly, null);
                    this.txttraName.Focus();
                }
                else if (Operators.CompareString(this.txtPartyName.Text, "", false) == 0)
                {
                    Interaction.MsgBox("Insert the Party Name ?", MsgBoxStyle.OkOnly, null);
                    this.txtPartyName.Focus();
                }
                else if (Conversion.Val(this.txtamount.Text) == 0)
                {
                    Interaction.MsgBox("Please Insert Amount ?", MsgBoxStyle.OkOnly, null);
                    this.txtamount.Focus();
                }
                else if (Operators.CompareString(this.txttraName.Text, this.txtPartyName.Text, false) == 0)
                {
                    Interaction.MsgBox("Party Name Same Not Allow ?", MsgBoxStyle.OkOnly, null);
                    this.txttraName.Text = null;
                    this.txttraName.Focus();
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string text2 = "";
                    if (Operators.CompareString(this.txtremark.Text, null, false) != 0)
                    {
                        string text = this.txtremark.Text;
                        int num = text.IndexOf("(");
                        if (num > -1)
                        {
                            text2 = this.txtremark.Text;
                        }
                        else
                        {
                            text2 = " (" + this.txtremark.Text + ")";
                        }
                    }
                    string cmdText2 = "select PartyName from PartyMaster where PartyName='" + this.txttraName.Text + "'";
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand2.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {                        
                        double dblAmount = Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text);
                        string cmdText5 = $"Update Trans set tns_Party = '{this.txttraName.Text}',tns_Amount = {dblAmount},tns_Remark = '{this.txtPartyName.Text + text2.ToString()}',tns_Type = '{((dblAmount) > 0 ? "CR" : "DR")}',tns_Hawala = '0',modify = '1',modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}',modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' where tns_ModifyID = {modifyid} and tns_Party <> '{txtPartyName.Text}'";
                        OleDbCommand oledb5 = new OleDbCommand(cmdText5, Module1.conn);
                        oledb5.ExecuteNonQuery();

                        string cmdText6 = $"Update Trans set tns_Amount = {this.txtamount.Text},tns_Remark = '{this.txttraName.Text + text2.ToString()}',tns_Type = '{((Convert.ToDecimal(this.txtamount.Text)) > 0 ? "CR" : "DR")}',tns_Hawala = '1',modify = '1',modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}',modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' where tns_ModifyID = {modifyid} and tns_Party = '{txtPartyName.Text}'";
                        OleDbCommand oledb6 = new OleDbCommand(cmdText6, Module1.conn);
                        oledb6.ExecuteNonQuery();

                        this.Opening_Balance();
                        this.modifyid = 0;
                        this.Button4.Hide();
                        this.Button5.Hide();
                        this.Button6.Show();
                        this.txttraName.Text = "";
                        this.txtamount.Text = "";
                        this.txtremark.Text = "";

                        this.txttraName.Focus();
                    }
                    else
                    {
                        Interaction.MsgBox("Please Create A/C Than Proced...?", MsgBoxStyle.OkOnly, null);
                        this.txttraName.Text = null;
                        this.txttraName.Focus();
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.ColumnIndex == 9)
                    {
                        string Strsql = "";
                        OleDbCommand Cmd;

                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[9].Value, true, false))
                        {
                            this.DataGridView1.CurrentRow.Cells[9].Value = false;
                        }
                        else
                        {
                            this.DataGridView1.CurrentRow.Cells[9].Value = true;
                        }

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[9].Value, true, false))
                        {
                            if (Conversion.Val(this.DataGridView1.CurrentRow.Cells[0].Value) == 0 && Conversion.Val(this.DataGridView1.CurrentRow.Cells[7].Value) != 0)
                            {
                                Strsql = "UPDATE Trans SET chk = '1' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "' AND tns_MatchID = " + Conversion.Val(this.DataGridView1.CurrentRow.Cells[7].Value) + " ";
                            }
                            else
                            {
                                Strsql = "UPDATE Trans SET chk = '1' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "' AND Id = " + Conversion.Val(this.DataGridView1.CurrentRow.Cells[0].Value) + " ";
                            }
                            Cmd = new OleDbCommand(Strsql, Module1.conn);
                            Cmd.ExecuteNonQuery();
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[9].Value, false, false))
                        {
                            if (Conversion.Val(this.DataGridView1.CurrentRow.Cells[0].Value) == 0 && Conversion.Val(this.DataGridView1.CurrentRow.Cells[7].Value) != 0)
                            {
                                Strsql = "UPDATE Trans SET chk = '0' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "' AND tns_MatchID = " + Conversion.Val(this.DataGridView1.CurrentRow.Cells[7].Value) + " ";
                            }
                            else
                            {
                                Strsql = "UPDATE Trans SET chk = '0' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "' AND Id = " + Conversion.Val(this.DataGridView1.CurrentRow.Cells[0].Value) + " ";
                            }
                            Cmd = new OleDbCommand(Strsql, Module1.conn);
                            Cmd.ExecuteNonQuery();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    string Strsql = "";
                    OleDbCommand Cmd;

                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    for (int i = 0; i <= this.DataGridView1.Rows.Count - 1; i++)
                    {
                        unchecked
                        {
                            //if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[9].Value, false, false))
                            //{
                            //    if (Conversion.Val(this.DataGridView1.Rows[i].Cells[0].Value) == 0 && Conversion.Val(this.DataGridView1.Rows[i].Cells[7].Value) != 0)
                            //    {
                            //        Strsql = "UPDATE Trans SET chk = '1' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "' AND tns_MatchID = " + Conversion.Val(this.DataGridView1.Rows[i].Cells[7].Value) + " ";

                            //    }
                            //    else
                            //    {
                            //        Strsql = "UPDATE Trans SET chk = '1' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "'";
                            //        Strsql = "UPDATE Trans SET chk = '1' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "' AND Id = " + Conversion.Val(this.DataGridView1.Rows[i].Cells[0].Value) + " ";
                            //    }
                            //    Cmd = new OleDbCommand(Strsql, Module1.conn);
                            //    Cmd.ExecuteNonQuery();
                            //    this.DataGridView1.Rows[i].Cells[9].Value = true;
                            //}
                            this.DataGridView1.Rows[i].Cells[9].Value = true;
                        }
                    }
                    Strsql = "UPDATE Trans SET chk = '1' WHERE tns_Chk='0' AND tns_party = '" + txtPartyName.Text + "'";
                    Cmd = new OleDbCommand(Strsql, Module1.conn);
                    Cmd.ExecuteNonQuery();

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
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                if (Conversion.Val(this.DataGridView1.CurrentRow.Cells[7].Value) == 0 || Conversion.Val(this.DataGridView1.CurrentRow.Cells[7].Value) <= 0)
                {
                    this.panel2.Visible = false;
                }
                else
                {
                    this.panel2.Visible = true;
                    this.DataGridView4.Rows.Clear();

                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    //string cmdText = "SELECT tns_Party, tns_Type, tns_chk, tns_MatchID, tns_Remark, tns_Amount AS Expr1,tns_Sessionid FROM(Trans) GROUP BY tns_Party, tns_Type, tns_chk, tns_MatchID, tns_Remark, ID, tns_Amount,tns_Sessionid HAVING (tns_Party = '" + this.txtPartyName.Text + "') AND (tns_chk = '0') AND (tns_MatchID = " + this.DataGridView1.CurrentRow.Cells[7].Value + ") ORDER BY tns_Type, Id";
                    string cmdText = "SELECT tns_Party, tns_Type, tns_chk, tns_MatchID, tns_Remark, tns_Sessionid, SUM(tns_Amount) AS Expr1 FROM (Trans) GROUP BY tns_Party, tns_Type, tns_chk, tns_MatchID, tns_Remark, tns_Sessionid HAVING (tns_Party = '" + this.txtPartyName.Text + "') AND (tns_chk = '0') AND (tns_MatchID = " + this.DataGridView1.CurrentRow.Cells[7].Value + ") ORDER BY tns_Type,tns_Sessionid";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    double num = 0;
                    while (oleDbDataReader.Read())
                    {
                        int index = this.DataGridView4.Rows.Add();
                        this.DataGridView4.Rows[index].Cells[0].Value = oleDbDataReader["tns_Remark"].ToString();
                        this.DataGridView4.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])), Module1.decimalnumberformat);
                        this.DataGridView4.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_MatchID"]);
                        this.DataGridView4.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Type"]);
                        this.DataGridView4.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["tns_Sessionid"]);
                        num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
                    }
                    this.DataGridView4.Rows[0].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(num), Module1.decimalnumberformat);

                    checked
                    {
                        for (int i = 0; i <= this.DataGridView4.RowCount - 1; i++)
                        {
                            if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[i].Cells[1].Value, 0, false))
                            {
                                this.DataGridView4.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView4.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                            }

                            if (Operators.ConditionalCompareObjectLess(this.DataGridView4.Rows[i].Cells[2].Value, 0, false))
                            {
                                this.DataGridView4.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.DataGridView4.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                            }
                        }
                        this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
        }

        private void DataGridView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, null, false))
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "Match", false))
                    {
                        Module1.machid = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[3].Value.ToString());
                        Module1.name1 = this.txtPartyName.Text;
                        MyProject.Forms.DPP_Match.MdiParent = this.MdiParent;
                        MyProject.Forms.DPP_Match.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "ABDN", false))
                    {
                        Module1.machid = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[3].Value.ToString());
                        Module1.sonu = this.txtPartyName.Text;
                        MyProject.Forms.DPP_AbnTie.MdiParent = this.MdiParent;
                        MyProject.Forms.DPP_AbnTie.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "CUP", false))
                    {
                        Module1.IDCUP = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[3].Value.ToString());
                        Module1.name1 = this.txtPartyName.Text;
                        MyProject.Forms.DPP_CUP.MdiParent = this.MdiParent;
                        MyProject.Forms.DPP_CUP.Show();
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.CurrentRow.Cells[4].Value, "Session", false))
                    {
                        Module1.sessionid = this.DataGridView4.CurrentRow.Cells[3].Value.ToString();
                        Module1.nehaid = Conversions.ToInteger(this.DataGridView4.CurrentRow.Cells[5].Value.ToString());
                        Module1.dppname = this.txtPartyName.Text;
                        Module1.myexit = "1";
                        MyProject.Forms.formDPPSession.MdiParent = this.MdiParent;
                        MyProject.Forms.formDPPSession.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void AccountLedger_KeyDown(object sender, KeyEventArgs e)
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

        private void txtPartyName_Leave(object sender, EventArgs e)
        {
            if (this.txtPartyName.Text != "")
            {
                if (this.isdataload == false)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string cmdText = "SELECT Id,PartyName FROM (PartyMaster) WHERE PartyName = '" + this.txtPartyName.Text + "'";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        this.Opening_Balance();
                    }
                    else
                    {
                        this.DataGridView1.Rows.Clear();
                        Interaction.MsgBox("Party Name Not Valid", MsgBoxStyle.OkOnly, null);
                    }
                }                
            }            
        }
    }
}
