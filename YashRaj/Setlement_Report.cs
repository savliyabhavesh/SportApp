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
    public partial class Setlement_Report : Form
    {
        bool isaccountledgerload = false;

        public Setlement_Report()
        {
            this.InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Module1.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtname.Text, null, false) == 0)
                {
                    this.txtname.Focus();
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "SELECT Id, PartyName FROM (PartyMaster) WHERE (PartyName = '" + this.txtname.Text + "')";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Form fc = Application.OpenForms["AccountLedger"];
                        if (fc != null)
                            fc.Close();

                        Module1.tranID = this.txtname.Text;
                        MyProject.Forms.AccountLedger.MdiParent = this.MdiParent;
                        MyProject.Forms.AccountLedger.WindowState = FormWindowState.Maximized;
                        MyProject.Forms.AccountLedger.Show();
                        //this.Close();
                    }
                    else
                    {
                        this.txtname.Text = null;
                        this.txtname.Focus();
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

        private void Setlement_Report_Activated(object sender, EventArgs e)
        {
            try
            {
                isaccountledgerload = false;
                //this.WindowState = FormWindowState.Maximized;
                this.Page_Load(RuntimeHelpers.GetObjectValue(sender), e);
                this.lod_valu();
                this.txtname.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }


        private void Setlement_Report_Load(object sender, EventArgs e)
        {
            try
            {
                this.Label2.Text = "";
                this.WindowState = FormWindowState.Maximized;
                this.Label2.Hide();
                this.DataGridView2.Hide();
                this.txtdate.Hide();
                this.all_partname();
                this.txtname.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void all_partname()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT Id,PartyName FROM PartyMaster ORDER BY PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"])).ToString();
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

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtname.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
                }
                if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[4].Value, true, false))
                {
                    this.DataGridView1.CurrentRow.Cells[4].Value = false;
                }
                else
                {
                    this.DataGridView1.CurrentRow.Cells[4].Value = true;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private void txtmonday_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    this.Label2.Show();
                    this.Label2.Text = "Please Wait...";
                    this.DataGridView2.Rows.Clear();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    for (int i = 0; i <= this.DataGridView1.RowCount - 1; i++)
                    {
                        unchecked
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[4].Value, true, false))
                            {
                                //string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT Party_name, Amount, dt FROM (OP_BAL) WHERE (Party_name = '", this.DataGridView1.Rows[i].Cells[1].Value), "')"));
                                //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                                //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                                //double num3=0;
                                //while (oleDbDataReader.Read())
                                //{
                                //	if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader["Amount"])))
                                //	{
                                //		num3 = Convert.ToDouble(Operators.AddObject(num3, oleDbDataReader["Amount"]));
                                //	}
                                //}
                                //oleDbCommand.Clone();
                                //oleDbDataReader.Close();

                                string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        tns_Party, tns_Amount, tns_dt, tns_Type, tns_chk FROM(Trans) WHERE        (tns_Type <> 'Monday Settlement') AND (tns_chk = '0') AND (tns_Party = '", this.DataGridView1.Rows[i].Cells[1].Value), "')"));
                                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                                double num4 = 0;
                                while (oleDbDataReader2.Read())
                                {
                                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"])))
                                    {
                                        num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader2["tns_Amount"]));
                                    }
                                }
                                oleDbCommand2.Clone();
                                oleDbDataReader2.Close();
                                int index = this.DataGridView2.Rows.Add();
                                this.DataGridView2.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[i].Cells[1].Value);
                                this.DataGridView2.Rows[index].Cells[1].Value = Conversion.Val(num4); //+ Conversion.Val(num3);
                                this.DataGridView2.Rows[index].Cells[2].Value = "Monday Final " + this.txtdate.Text;
                                num4 = 0.0;
                                //num3 = 0.0;
                            }
                        }
                    }
                    if (MessageBox.Show("Do you want to make monday final..?", "FINAL", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Module1.conn.Close();
                        int num5 = 0;
                        int num6 = this.DataGridView2.RowCount - 1;
                        for (int j = num5; j <= num6; j++)
                        {
                            if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[j].Cells[0].Value, null, false))
                            {
                                string cmdText3 = $"INSERT INTO Trans(tns_Party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_Monday_Final, tns_time)VALUES('{this.DataGridView2.Rows[j].Cells[0].Value}',{this.DataGridView2.Rows[j].Cells[1].Value} ,'{this.DataGridView2.Rows[j].Cells[2].Value}',0,'{this.txtdate.Text}','Monday Settlement',0,1,0,'Yes','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    transactionService.Insert(cmdText3);
                                }
                            }
                        }
                        this.Update_Monday_Final();
                        MessageBox.Show("Monday Final Done..");
                        this.Page_Load(RuntimeHelpers.GetObjectValue(sender), e);
                        this.lod_valu();
                        this.Label2.Text = "";
                    }
                    else
                    {
                        this.Label2.Text = "";
                        this.DataGridView2.Rows.Clear();
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    this.Label2.Text = "";
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }


        public void Update_Monday_Final()
        {
            checked
            {
                try
                {
                    Module1.conn.Close();
                    for (int i = 0; i <= this.DataGridView1.Rows.Count; i++)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[4].Value, true, false))
                        {
                            string cmdText = $"update Trans set tns_Monday_Final='Yes' where tns_Party='{this.DataGridView1.Rows[i].Cells[1].Value.ToString()}'";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(cmdText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            Module1.tranID = this.txtname.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(new OleDbCommand
                //{
                //    CommandType = CommandType.Text,
                //  CommandText = "SELECT DISTINCT PartyMaster.Id, PartyMaster.PartyName, '' as Dhara, Trans.tns_Monday_Final FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) WHERE (Trans.tns_chk = '0') ORDER BY PartyMaster.PartyName",
                // CommandText = "SELECT * FROM (SELECT DISTINCT PartyMaster.Id, PartyMaster.PartyName, '' as Dhara, Trans.tns_Monday_Final FROM(PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) WHERE(Trans.tns_chk = '0') UNION SELECT DISTINCT PartyMaster.Id, PartyMaster.PartyName, '' as Dhara, 'No' as tns_Monday_Final  FROM PartyMaster WHERE PartyName NOT IN(SELECT DISTINCT PartyMaster.PartyName FROM(PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) WHERE(Trans.tns_chk = '0')) ) a ORDER BY a.PartyName",
                //    Connection = Module1.conn
                //});
                //DataTable dataTable = new DataTable();
                //oleDbDataAdapter.Fill(dataTable);
                //dataTable = this.DeleteDuplicateFromDataTable(dataTable, "PartyName");
                // this.DataGridView4.DataSource = dataTable;
                Module1.conn.Close();
                using (TransactionService transactionService = new TransactionService())
                {
                    DataTable dataTable = new DataTable();
                    //string CommandText = "SELECT DISTINCT PartyMaster.Id, PartyMaster.PartyName, '' as Dhara, Trans.tns_Monday_Final FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) WHERE (Trans.tns_chk = '0') ORDER BY PartyMaster.PartyName";
                    //string CommandText1 = "SELECT * FROM (SELECT DISTINCT PartyMaster.Id, PartyMaster.PartyName, '' as Dhara, Trans.tns_Monday_Final FROM(PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) WHERE(Trans.tns_chk = '0') UNION SELECT DISTINCT PartyMaster.Id, PartyMaster.PartyName, '' as Dhara, 'No' as tns_Monday_Final  FROM PartyMaster WHERE PartyName NOT IN(SELECT DISTINCT PartyMaster.PartyName FROM(PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) WHERE(Trans.tns_chk = '0')) ) a ORDER BY a.PartyName";
                    string strcmd = "SELECT DISTINCT partymaster.id,partymaster.partyname,'' AS Dhara,IIF( trans.tns_Monday_Final = 'Yes', trans.tns_Monday_Final, 'No') AS tns_Monday_Final FROM (partymaster LEFT JOIN trans ON partymaster.partyname = trans.tns_party) ORDER BY partymaster.partyname";
                    //dataTable = transactionService.Get(CommandText);
                    dataTable = transactionService.Get(strcmd);
                    dataTable = this.DeleteDuplicateFromDataTable(dataTable, "PartyName");
                    this.DataGridView4.DataSource = dataTable;
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

        protected DataTable DeleteDuplicateFromDataTable(DataTable dtDuplicate, string columnName)
        {
            Hashtable hashtable = new Hashtable();
            ArrayList arrayList = new ArrayList();
            try
            {
                foreach (object obj in dtDuplicate.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    if (hashtable.Contains(RuntimeHelpers.GetObjectValue(dataRow[columnName])))
                    {
                        arrayList.Add(dataRow);
                    }
                    else
                    {
                        hashtable.Add(RuntimeHelpers.GetObjectValue(dataRow[columnName]), string.Empty);
                    }
                }
            }
            catch (Exception ex1)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex1.Message);
            }
            finally
            {
                //IEnumerator enumerator;
                //if (enumerator is IDisposable)
                //{
                //	(enumerator as IDisposable).Dispose();
                //}
            }
            try
            {
                foreach (object obj2 in arrayList)
                {
                    DataRow row = (DataRow)obj2;
                    dtDuplicate.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
            finally
            {
                //IEnumerator enumerator2;
                //if (enumerator2 is IDisposable)
                //{
                //	(enumerator2 as IDisposable).Dispose();
                //}
            }
            return dtDuplicate;
        }

        public void lod_valu()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView4.RowCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (!Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[i].Cells[3].Value, null, false))
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[i].Cells[3].Value, "No", false))
                            {
                                int index = this.DataGridView1.Rows.Add();
                                this.DataGridView1.Rows[index].Cells[0].Value = this.DataGridView4.Rows[i].Cells[0].Value.ToString();
                                this.DataGridView1.Rows[index].Cells[1].Value = this.DataGridView4.Rows[i].Cells[1].Value.ToString();
                                //this.DataGridView1.Rows[index].Cells[2].Value = this.DataGridView4.Rows[i].Cells[2].Value.ToString();
                                this.DataGridView1.Rows[index].Cells[3].Value = this.DataGridView4.Rows[i].Cells[3].Value.ToString();
                                this.DataGridView1.Rows[index].Cells[4].Value = true;
                                this.DataGridView1.Rows[index].Cells[3].Style.BackColor = Color.DarkOrange;
                                this.DataGridView1.Rows[index].Cells[3].Style.ForeColor = Color.White;
                            }
                            else
                            {
                                int index2 = this.DataGridView1.Rows.Add();
                                this.DataGridView1.Rows[index2].Cells[0].Value = this.DataGridView4.Rows[i].Cells[0].Value.ToString();
                                this.DataGridView1.Rows[index2].Cells[1].Value = this.DataGridView4.Rows[i].Cells[1].Value.ToString();
                                //this.DataGridView1.Rows[index2].Cells[2].Value = this.DataGridView4.Rows[i].Cells[2].Value.ToString();
                                this.DataGridView1.Rows[index2].Cells[3].Value = this.DataGridView4.Rows[i].Cells[3].Value.ToString();
                                this.DataGridView1.Rows[index2].Cells[4].Value = false;
                                this.DataGridView1.Rows[index2].Cells[3].Style.BackColor = Color.Lime;
                                this.DataGridView1.Rows[index2].Cells[3].Style.ForeColor = Color.White;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
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

        
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    //SendKeys.Send("{TAB}");
                    if (isaccountledgerload == false)
                    {
                        this.DataGridView1_DoubleClick(RuntimeHelpers.GetObjectValue(sender), e);
                        isaccountledgerload = true;
                    }
                    
                }               
                else if (e.KeyCode == Keys.Escape)
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

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[1].Value, null, false))
                    {
                        Form fc = Application.OpenForms["AccountLedger"];
                        if (fc != null)
                            fc.Close();

                        this.txtname.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[1].Value);
                        Module1.tranID = this.txtname.Text;
                        AccountLedger accountLedger = new AccountLedger();
                        accountLedger.MdiParent = this.MdiParent;
                        accountLedger.WindowState = FormWindowState.Maximized;
                        accountLedger.Show();
                        //this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Setlement_Report_KeyDown(object sender, KeyEventArgs e)
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
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x04000D91 RID: 3473
        public string P_Dara;

        // Token: 0x04000D92 RID: 3474
        public string P_ID;

        // Token: 0x04000D93 RID: 3475
        public string SeltYes;

    }
}

