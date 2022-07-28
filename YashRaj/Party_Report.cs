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
    // Token: 0x02000061 RID: 97
    [DesignerGenerated]
    public partial class Party_Report : Form
    {
        public Party_Report()
        {
            this.InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Module1.modifypartyid = 0;
                Module1.modifypartyname = "";

                New_Party new_Party = new New_Party();
                new_Party.MdiParent = this.MdiParent;
                new_Party.WindowState = FormWindowState.Maximized;
                new_Party.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Party_Report_Activated(object sender, EventArgs e)
        {
            try
            {
                this.LoadGrid();
                this.txtname_TextChanged(RuntimeHelpers.GetObjectValue(sender), e);
                this.txtname.Focus();
                this.txtname.SelectAll();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Party_Report_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
                this.ComboBox1.Hide();
                this.txtid.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void LoadGrid()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                this.ComboBox1.Items.Clear();
                this.txtname.Items.Clear();
                string cmdText = "SELECT Id, PartyName, Status, BalanceLimit, MatchCommiType, SMatch, SMatchCommi, AParty, AMatch, AMatchCommi, TParty, TMatch, TMatchCommi FROM PartyMaster WHERE Id<>1 ORDER BY PartyName";
                OleDbCommand selectCommand = new OleDbCommand(cmdText, Module1.conn);
                oleDbDataAdapter.SelectCommand = selectCommand;
                oleDbDataAdapter.Fill(ds);
                dt = ds.Tables[0];

                this.DataGridView1.DataSource = dt;
                this.DataGridView1.Columns["Id"].Width = 50;
                this.DataGridView1.Columns["PartyName"].Width = 150;
                this.DataGridView1.Columns["Status"].Width = 100;
                this.DataGridView1.Columns["BalanceLimit"].Width = 120;
                this.DataGridView1.Columns["BalanceLimit"].HeaderText = "Balance Limit";
                this.DataGridView1.Columns["BalanceLimit"].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns["BalanceLimit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView1.Columns["MatchCommiType"].Width = 150;
                this.DataGridView1.Columns["MatchCommiType"].HeaderText = "Match Commission Type";

                this.DataGridView1.Columns["SMatch"].HeaderText = "Self LD";
                this.DataGridView1.Columns["SMatch"].DefaultCellStyle.Format = "0.00";
                this.DataGridView1.Columns["SMatch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView1.Columns["SMatchCommi"].HeaderText = "Self Match Commi";
                this.DataGridView1.Columns["SMatchCommi"].DefaultCellStyle.Format = "0.00";
                this.DataGridView1.Columns["SMatchCommi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.DataGridView1.Columns["AParty"].Width = 150;
                this.DataGridView1.Columns["AParty"].HeaderText = "Agent Party";
                this.DataGridView1.Columns["AMatch"].HeaderText = "Agent LD";
                this.DataGridView1.Columns["AMatch"].DefaultCellStyle.Format = "0.00";
                this.DataGridView1.Columns["AMatch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView1.Columns["AMatchCommi"].HeaderText = "Agent Match Commi";
                this.DataGridView1.Columns["AMatchCommi"].DefaultCellStyle.Format = "0.00";
                this.DataGridView1.Columns["AMatchCommi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.DataGridView1.Columns["TParty"].Width = 150;
                this.DataGridView1.Columns["TParty"].HeaderText = "ThirdParty";
                this.DataGridView1.Columns["TMatch"].HeaderText = "ThirdParty LD";
                this.DataGridView1.Columns["TMatch"].DefaultCellStyle.Format = "0.00";
                this.DataGridView1.Columns["TMatch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView1.Columns["TMatchCommi"].HeaderText = "ThirdParty Match Commi";
                this.DataGridView1.Columns["TMatchCommi"].DefaultCellStyle.Format = "0.00";
                this.DataGridView1.Columns["TMatchCommi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                try
                {
                    foreach (object obj in ds.Tables[0].Rows)
                    {
                        DataRow dataRow = (DataRow)obj;
                        this.ComboBox1.Items.Add(dataRow["Id"].ToString());
                        this.txtname.Items.Add(dataRow["PartyName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
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

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.Label3.Text, null, false) != 0)
                {
                    Module1.modifypartyid = Conversions.ToInteger(this.txtid.Text);
                    Module1.modifypartyname = Conversions.ToString(this.txtname.Text);
                    New_Party new_Party = new New_Party();
                    new_Party.MdiParent = this.MdiParent;
                    new_Party.WindowState = FormWindowState.Maximized;
                    new_Party.Show();
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

        private void Party_Report_KeyDown(object sender, KeyEventArgs e)
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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtid.Text, "", false) != 0)
                {
                    if (Interaction.MsgBox("Are you sure want to delete this Party", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        if (Operators.CompareString(this.txtid.Text, "1", false) == 0)
                        {
                            Interaction.MsgBox("Cannot Delete this Party", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            if (Conversion.Val(this.Label3.Text) == 0)
                            {
                                this.DeleteRecord();
                            }
                            else
                            {
                                Interaction.MsgBox("Cannot Delete this Party Bcoz Party Balance Exist", MsgBoxStyle.OkOnly, null);
                            }
                        }
                        //else if (Operators.CompareString(this.Label3.Text, null, false) != 0)
                        //{
                        //	if (Operators.CompareString(this.Label3.Text, "0.00", false) == 0)
                        //	{
                        //		this.delete_customer();
                        //	}
                        //	else if (Operators.CompareString(this.Label3.Text, "0", false) == 0)
                        //	{
                        //		this.delete_customer();
                        //	}
                        //	else
                        //	{
                        //		Interaction.MsgBox("Cannot Delete this Party Name", MsgBoxStyle.OkOnly, null);
                        //	}
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteRecord()
        {
            try
            {
                string cmdText = $"delete from PartyMaster where Id={this.txtid.Text}";
                using (PartyMasterService partyMasterService = new PartyMasterService())
                {
                    partyMasterService.Update(cmdText);
                }
                    Interaction.MsgBox("Record Delete Sucessfully.. ?", MsgBoxStyle.OkOnly, null);
                this.LoadGrid();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                DataSet dataSet = new DataSet();
                string cmdText = "SELECT Id, PartyName, SMatch, SMatchCommi, AParty, AMatch, AMatchCommi, TParty, TMatch, TMatchCommi FROM PartyMaster ORDER BY PartyName ";
                OleDbCommand selectCommand = new OleDbCommand(cmdText, Module1.conn);
                oleDbDataAdapter.SelectCommand = selectCommand;
                oleDbDataAdapter.Fill(dataSet, "PartyMaster");
                //CrystalReport1 crystalReport = new CrystalReport1();
                //crystalReport.SetDataSource(dataSet);
                //crystalReport.PrintToPrinter(0, false, 0, 0);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    try
                    {
                        if (Operators.CompareString(this.Label3.Text, null, false) != 0)
                        {
                            //this.iodegrid();
                            Module1.modifypartyid = Conversions.ToInteger(this.txtid.Text);
                            Module1.modifypartyname = Conversions.ToString(this.txtname.Text);

                            MyProject.Forms.New_Party.MdiParent = this.MdiParent;
                            MyProject.Forms.New_Party.WindowState = FormWindowState.Maximized;
                            MyProject.Forms.New_Party.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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

        private void txtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ComboBox1.SelectedIndex = this.txtname.SelectedIndex;
                this.txtid.Text = this.ComboBox1.Text;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

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
        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.btnmodify_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
                this.txtname.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
                this.txtid.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtname.Text, null, false) == 0)
                {
                    this.Label3.Text = "";
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    double num = 0.0;
                    string cmdText = "SELECT SUM(tns_Amount) AS ColsingBalanceAmount, tns_Party FROM Trans WHERE (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Party = '" + this.txtname.Text + "') GROUP BY tns_Party ";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        num += Convert.ToDouble(oleDbDataReader["ColsingBalanceAmount"]);
                    }
                    this.Label3.Text = Module1.SetNumFormat(Conversion.Val(num), Module1.NumFormat);

                    //string cmdText = "SELECT id, tns_Party, SUM(tns_Amount) AS Expr1, tns_Type, tns_chk FROM(Trans) GROUP BY ID, tns_Party, tns_Type, tns_chk HAVING        (tns_Type <> 'Monday Settlement') AND (tns_chk = '0') AND (tns_Party = '" + this.txtname.Text + "')";
                    //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    //double num=0;
                    //while (oleDbDataReader.Read())
                    //{
                    //	num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]));
                    //}
                    //string cmdText2 = "SELECT Party_name, SUM(Amount) AS Expr1, chk FROM(OP_BAL) GROUP BY Party_name, chk HAVING (Party_name = '" + this.txtname.Text + "')";
                    //OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    //OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                    //double num2=0;
                    //while (oleDbDataReader2.Read())
                    //{
                    //	num2 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"]));
                    //}

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

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[1].Value, null, false))
                    {
                        this.txtname.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
                        this.txtid.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);

                        this.btnmodify_Click(RuntimeHelpers.GetObjectValue(sender), e);
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtname.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
                    this.txtid.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }
    }
}
