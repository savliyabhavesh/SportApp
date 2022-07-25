using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using YashAksh.My;

namespace YashAksh
{
    public partial class Newpartymodify : Form
    {        
        private int TrafAgent;
        private int TrafPatner;        

        public Newpartymodify()
        {
            InitializeComponent();
        }

        // Token: 0x06001AD4 RID: 6868 RVA: 0x00393188 File Offset: 0x00391588
        private void Newpartymodify_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtoldPrtyname.Hide();
                this.TextBox9.Hide();
                this.TextBox4.Hide();
                //this.TextBox4.Text = Conversions.ToString(Module1.idnoumber);
                //this.TextBox1.Text = Module1.Namecustermar;
                //this.txtoldPrtyname.Text = Module1.Namecustermar.ToString();
                this.all_Show();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newparty where ID = " + this.TextBox4.Text + "";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.txtid1.Text = oleDbDataReader[0].ToString();
                    this.TextBox1.Text = oleDbDataReader[1].ToString();
                    this.TextBox9.Text = oleDbDataReader[1].ToString();
                    this.txtdara.Text = oleDbDataReader[2].ToString();
                    this.txtstatus.Text = oleDbDataReader[3].ToString();
                    this.txt2sms.Text = oleDbDataReader[4].ToString();
                    this.txt2commper.Text = oleDbDataReader[5].ToString();
                    this.txt2balancelimet.Text = oleDbDataReader[6].ToString();
                    this.txt4match.Text = oleDbDataReader[7].ToString();
                    this.txt4sessin.Text = oleDbDataReader[8].ToString();
                    this.txt4abandon.Text = oleDbDataReader[9].ToString();
                    this.txt4tie.Text = oleDbDataReader[10].ToString();
                    this.txtsadk.Text = oleDbDataReader[11].ToString();
                    this.txt3name.Text = oleDbDataReader[12].ToString();
                    this.txt3match.Text = oleDbDataReader[13].ToString();
                    this.txt3session.Text = oleDbDataReader[14].ToString();
                    this.txt3abandon.Text = oleDbDataReader[15].ToString();
                    this.txt3tie.Text = oleDbDataReader[16].ToString();
                    this.TextBox3.Text = oleDbDataReader[17].ToString();
                    this.txt5name.Text = oleDbDataReader[18].ToString();
                    this.txt5match.Text = oleDbDataReader[19].ToString();
                    this.txt5session.Text = oleDbDataReader[20].ToString();
                    this.txt5abandon.Text = oleDbDataReader[21].ToString();
                    this.txt5tie.Text = oleDbDataReader[22].ToString();
                    this.TextBox8.Text = oleDbDataReader["C_50"].ToString();
                    this.TextBox2.Text = oleDbDataReader[23].ToString();
                    this.TextBox5.Text = oleDbDataReader[24].ToString();
                    this.TextBox7.Text = oleDbDataReader[26].ToString();
                    this.TextBox6.Text = oleDbDataReader[27].ToString();
                    if (Operators.CompareString(oleDbDataReader["cl_Agent_commi_Trsf"].ToString(), "1", false) == 0)
                    {
                        this.commiAgent.Checked = true;
                    }
                    else
                    {
                        this.commiAgent.Checked = false;
                    }
                    if (Operators.CompareString(oleDbDataReader["cl_share_P_transfer"].ToString(), "1", false) == 0)
                    {
                        this.commipatner.Checked = true;
                    }
                    else
                    {
                        this.commipatner.Checked = false;
                    }
                }
                this.TextBox1.Focus();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001AD5 RID: 6869 RVA: 0x003935B0 File Offset: 0x003919B0
        public void all_Show()
        {
            try
            {
                this.txt3name.Items.Clear();
                this.txt5name.Items.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from Newparty";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.txt3name.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                    this.txt5name.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001AD6 RID: 6870 RVA: 0x003936A0 File Offset: 0x00391AA0
        public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            checked
            {
                string text;
                if (e.KeyChar == '\b')
                {
                    if (this.txt3name.SelectionStart <= 1)
                    {
                        this.txt3name.Text = "";
                        return;
                    }
                    if (this.txt3name.SelectionLength == 0)
                    {
                        text = this.txt3name.Text.Substring(0, this.txt3name.Text.Length - 1);
                    }
                    else
                    {
                        text = this.txt3name.Text.Substring(0, this.txt3name.SelectionStart - 1);
                    }
                }
                else if (this.txt3name.SelectionLength == 0)
                {
                    text = this.txt3name.Text + Conversions.ToString(e.KeyChar);
                }
                else
                {
                    text = this.txt3name.Text.Substring(0, this.txt3name.SelectionStart) + Conversions.ToString(e.KeyChar);
                }
                int num = this.txt3name.FindString(text);
                if (num != -1)
                {
                    this.txt3name.SelectedText = "";
                    this.txt3name.SelectedIndex = num;
                    this.txt3name.SelectionStart = text.Length;
                    this.txt3name.SelectionLength = this.txt3name.Text.Length;
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

        // Token: 0x06001AD7 RID: 6871 RVA: 0x003937FC File Offset: 0x00391BFC
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            checked
            {
                string text;
                if (e.KeyChar == '\b')
                {
                    if (this.txt5name.SelectionStart <= 1)
                    {
                        this.txt5name.Text = "";
                        return;
                    }
                    if (this.txt5name.SelectionLength == 0)
                    {
                        text = this.txt5name.Text.Substring(0, this.txt5name.Text.Length - 1);
                    }
                    else
                    {
                        text = this.txt5name.Text.Substring(0, this.txt5name.SelectionStart - 1);
                    }
                }
                else if (this.txt5name.SelectionLength == 0)
                {
                    text = this.txt5name.Text + Conversions.ToString(e.KeyChar);
                }
                else
                {
                    text = this.txt5name.Text.Substring(0, this.txt5name.SelectionStart) + Conversions.ToString(e.KeyChar);
                }
                int num = this.txt5name.FindString(text);
                if (num != -1)
                {
                    this.txt5name.SelectedText = "";
                    this.txt5name.SelectedIndex = num;
                    this.txt5name.SelectionStart = text.Length;
                    this.txt5name.SelectionLength = this.txt5name.Text.Length;
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


        // Token: 0x06001ADB RID: 6875 RVA: 0x00393964 File Offset: 0x00391D64
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "Select * from Newparty where Sr_No=",
                    this.txtid1.Text,
                    " and Customer_Name='",
                    this.TextBox1.Text,
                    "'"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.TextBox1.Text = Conversions.ToString(oleDbDataReader[1]);
                    this.txtid1.Text = Conversions.ToString(oleDbDataReader[0]);
                    this.txtdara.Text = Conversions.ToString(oleDbDataReader[2]);
                    this.txtstatus.Text = Conversions.ToString(oleDbDataReader[3]);
                    this.txt2sms.Text = Conversions.ToString(oleDbDataReader[4]);
                    this.txt2commper.Text = Conversions.ToString(oleDbDataReader[5]);
                    this.txt2balancelimet.Text = Conversions.ToString(oleDbDataReader[6]);
                    this.txt3name.Text = Conversions.ToString(oleDbDataReader[8]);
                    this.txt3match.Text = Conversions.ToString(oleDbDataReader[9]);
                    this.txt3session.Text = Conversions.ToString(oleDbDataReader[10]);
                    this.txt3abandon.Text = Conversions.ToString(oleDbDataReader[11]);
                    this.txt3tie.Text = Conversions.ToString(oleDbDataReader[12]);
                    this.txt4match.Text = Conversions.ToString(oleDbDataReader[13]);
                    this.txt4sessin.Text = Conversions.ToString(oleDbDataReader[4]);
                    this.txt4abandon.Text = Conversions.ToString(oleDbDataReader[15]);
                    this.txt4tie.Text = Conversions.ToString(oleDbDataReader[16]);
                    this.txt5name.Text = Conversions.ToString(oleDbDataReader[17]);
                    this.txt5match.Text = Conversions.ToString(oleDbDataReader[18]);
                    this.txt5session.Text = Conversions.ToString(oleDbDataReader[19]);
                    this.txt5abandon.Text = Conversions.ToString(oleDbDataReader[20]);
                    this.txt5tie.Text = Conversions.ToString(oleDbDataReader[21]);
                    this.txt6test.Text = Conversions.ToString(oleDbDataReader[22]);
                    this.txt650.Text = Conversions.ToString(oleDbDataReader[23]);
                    this.txt640.Text = Conversions.ToString(oleDbDataReader[24]);
                    this.txt620.Text = Conversions.ToString(oleDbDataReader[25]);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001ADC RID: 6876 RVA: 0x00393CA0 File Offset: 0x003920A0
        private void Button3_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Party_Report.MdiParent = this.MdiParent;
            MyProject.Forms.Party_Report.WindowState = FormWindowState.Maximized;
            MyProject.Forms.Party_Report.Show();
            this.Close();
        }

        // Token: 0x06001ADD RID: 6877 RVA: 0x00393CDC File Offset: 0x003920DC
        private void Uapdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.commiAgent.Checked)
                {
                    this.TrafAgent = Conversions.ToInteger("1");
                }
                else
                {
                    this.TrafAgent = Conversions.ToInteger("0");
                }
                if (this.commipatner.Checked)
                {
                    this.TrafPatner = Conversions.ToInteger("1");
                }
                else
                {
                    this.TrafPatner = Conversions.ToInteger("0");
                }
                if (Operators.CompareString(this.TextBox1.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Name information?", MsgBoxStyle.OkOnly, null);
                }
                else if (Operators.CompareString(this.txtdara.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Dhara information?", MsgBoxStyle.OkOnly, null);
                }
                else if (Operators.CompareString(this.txtstatus.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Staus information?", MsgBoxStyle.OkOnly, null);
                }
                else if (Operators.CompareString(this.TextBox9.Text, null, false) == 0)
                {
                    Interaction.MsgBox("Please fill Name information..?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    this.All_Clearr();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "update Newparty set Party_name='",
                        this.TextBox1.Text,
                        "', Dhara='",
                        this.txtdara.Text,
                        "',Status='",
                        this.txtstatus.Text,
                        "',SMS_charges=",
                        this.txt2sms.Text,
                        ",Comm_On_Hari=",
                        this.txt2commper.Text,
                        ",Balance_Limit=",
                        this.txt2balancelimet.Text,
                        ",S_Match=",
                        this.txt4match.Text,
                        ",S_Session=",
                        this.txt4sessin.Text,
                        ",S_Abandon=",
                        this.txt4abandon.Text,
                        ",S_Tie=",
                        this.txt4tie.Text,
                        ",S_AKD=",
                        this.txtsadk.Text,
                        ", Agent_Name='",
                        this.txt3name.Text,
                        "',A_Match=",
                        this.txt3match.Text,
                        ",A_Session=",
                        this.txt3session.Text,
                        ",A_Abandon=",
                        this.txt3abandon.Text,
                        ",A_Tie=",
                        this.txt3tie.Text,
                        ",A_AKD=",
                        this.TextBox3.Text,
                        ", P_Name='",
                        this.txt5name.Text,
                        "', P_match=",
                        this.txt5match.Text,
                        ", P_session=",
                        this.txt5session.Text,
                        ", P_abandon=",
                        this.txt5abandon.Text,
                        ",P_tie=",
                        this.txt5tie.Text,
                        ",P_AKD=",
                        this.TextBox2.Text,
                        ", C_Test=",
                        this.TextBox5.Text,
                        " , C_50=",
                        this.TextBox8.Text,
                        " , C_40=",
                        this.TextBox7.Text,
                        " , C_20=",
                        this.TextBox6.Text,
                        ",cl_share_P_transfer=",
                        Conversions.ToString(this.TrafPatner),
                        ",cl_Agent_commi_Trsf=",
                        Conversions.ToString(this.TrafAgent),
                        " where ID=",
                        this.txtid1.Text,
                        ""
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE Newparty SET Agent_Name = '",
                        this.TextBox1.Text,
                        "' WHERE (Newparty.Agent_Name = '",
                        this.txtoldPrtyname.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE Newparty SET P_Name = '",
                        this.TextBox1.Text,
                        "' WHERE (Newparty.P_Name = '",
                        this.txtoldPrtyname.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE MatchTrans SET m_party = '",
                        this.TextBox1.Text,
                        "' WHERE (m_party = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE Trans SET tns_party = '",
                        this.TextBox1.Text,
                        "' WHERE (tns_party = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE SessionTrans SET s_party = '",
                        this.TextBox1.Text,
                        "' WHERE (s_party = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE CupTrans SET m_party = '",
                        this.TextBox1.Text,
                        "' WHERE (m_party = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE MatchTrans1 SET m_party = '",
                        this.TextBox1.Text,
                        "' WHERE (m_party = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE OP_BAL SET Party_name = '",
                        this.TextBox1.Text,
                        "' WHERE (Party_name = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE tablakd SET Party_name = '",
                        this.TextBox1.Text,
                        "' WHERE (Party_name = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    cmdText = string.Concat(new string[]
                    {
                        "UPDATE Abdntie SET Party_Name = '",
                        this.TextBox1.Text,
                        "' WHERE (Party_Name = '",
                        this.TextBox9.Text,
                        "')"
                    });
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbCommand.ExecuteNonQuery();
                    MessageBox.Show("Party Modify Sucessfully..?");
                    MyProject.Forms.Match.lod_newPartyname();
                    MyProject.Forms.Form3_SESSION.Combolode_And_selfsession_Asession_Psession_parsenteg();
                    MyProject.Forms.CUP.lod_newPartyname();
                    MyProject.Forms.TransactionReport.name_lode();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06001ADE RID: 6878 RVA: 0x003944EC File Offset: 0x003928EC
        public void All_Clearr()
        {
            try
            {
                if (Operators.CompareString(this.txt2sms.Text, null, false) == 0)
                {
                    this.txt2sms.Text = "0";
                }
                if (Operators.CompareString(this.txt2commper.Text, null, false) == 0)
                {
                    this.txt2commper.Text = "0";
                }
                if (Operators.CompareString(this.txt2balancelimet.Text, null, false) == 0)
                {
                    this.txt2balancelimet.Text = "0";
                }
                if (Operators.CompareString(this.txt4match.Text, null, false) == 0)
                {
                    this.txt4match.Text = "0";
                }
                if (Operators.CompareString(this.txt4sessin.Text, null, false) == 0)
                {
                    this.txt4sessin.Text = "0";
                }
                if (Operators.CompareString(this.txt4abandon.Text, null, false) == 0)
                {
                    this.txt4abandon.Text = "0";
                }
                if (Operators.CompareString(this.txt4tie.Text, null, false) == 0)
                {
                    this.txt4tie.Text = "0";
                }
                if (Operators.CompareString(this.txtsadk.Text, null, false) == 0)
                {
                    this.txtsadk.Text = "0";
                }
                if (Operators.CompareString(this.txt3match.Text, null, false) == 0)
                {
                    this.txt3match.Text = "0";
                }
                if (Operators.CompareString(this.txt3session.Text, null, false) == 0)
                {
                    this.txt3session.Text = "0";
                }
                if (Operators.CompareString(this.txt3abandon.Text, null, false) == 0)
                {
                    this.txt3abandon.Text = "0";
                }
                if (Operators.CompareString(this.txt3tie.Text, null, false) == 0)
                {
                    this.txt3tie.Text = "0";
                }
                if (Operators.CompareString(this.TextBox3.Text, null, false) == 0)
                {
                    this.TextBox3.Text = "0";
                }
                if (Operators.CompareString(this.txt5match.Text, null, false) == 0)
                {
                    this.txt5match.Text = "0";
                }
                if (Operators.CompareString(this.txt5session.Text, null, false) == 0)
                {
                    this.txt5session.Text = "0";
                }
                if (Operators.CompareString(this.txt5abandon.Text, null, false) == 0)
                {
                    this.txt5abandon.Text = "0";
                }
                if (Operators.CompareString(this.txt5tie.Text, null, false) == 0)
                {
                    this.txt5tie.Text = "0";
                }
                if (Operators.CompareString(this.TextBox2.Text, null, false) == 0)
                {
                    this.TextBox2.Text = "0";
                }
                if (Operators.CompareString(this.TextBox5.Text, null, false) == 0)
                {
                    this.TextBox5.Text = "0";
                }
                if (Operators.CompareString(this.TextBox8.Text, null, false) == 0)
                {
                    this.TextBox8.Text = "0";
                }
                if (Operators.CompareString(this.TextBox7.Text, null, false) == 0)
                {
                    this.TextBox7.Text = "0";
                }
                if (Operators.CompareString(this.TextBox6.Text, null, false) == 0)
                {
                    this.TextBox6.Text = "0";
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001ADF RID: 6879 RVA: 0x00394864 File Offset: 0x00392C64
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.txt2sms.Text = Conversions.ToString(Conversion.Val(this.txt2sms.Text) - Conversion.Val(this.txt2sms.Text) - Conversion.Val(this.txt2sms.Text));
        }

        // Token: 0x06001AE0 RID: 6880 RVA: 0x003948B4 File Offset: 0x00392CB4
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.txt2commper.Text = Conversions.ToString(Conversion.Val(this.txt2commper.Text) - Conversion.Val(this.txt2commper.Text) - Conversion.Val(this.txt2commper.Text));
        }

        // Token: 0x06001AE1 RID: 6881 RVA: 0x00394904 File Offset: 0x00392D04
        private void txt3name_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox txt3name = this.txt3name;
            this.AutoComplete11(ref txt3name, e, false);
            this.txt3name = txt3name;
        }

        // Token: 0x06001AE2 RID: 6882 RVA: 0x0039492C File Offset: 0x00392D2C
        private void txt5name_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox txt5name = this.txt5name;
            this.AutoComplete(ref txt5name, e, false);
            this.txt5name = txt5name;
        }

        // Token: 0x06001AE3 RID: 6883 RVA: 0x00394954 File Offset: 0x00392D54
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtdara.Focus();
            }
        }

        // Token: 0x06001AE4 RID: 6884 RVA: 0x0039496C File Offset: 0x00392D6C
        private void txtdara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtstatus.Focus();
            }
        }

        // Token: 0x06001AE5 RID: 6885 RVA: 0x00394984 File Offset: 0x00392D84
        private void txtstatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt2sms.Focus();
            }
        }

        // Token: 0x06001AE6 RID: 6886 RVA: 0x0039499C File Offset: 0x00392D9C
        private void txt2sms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.RadioButton1.Focus();
            }
        }

        // Token: 0x06001AE7 RID: 6887 RVA: 0x003949B4 File Offset: 0x00392DB4
        private void RadioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.RadioButton2.Focus();
            }
        }

        // Token: 0x06001AE8 RID: 6888 RVA: 0x003949CC File Offset: 0x00392DCC
        private void RadioButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt2commper.Focus();
            }
        }

        // Token: 0x06001AE9 RID: 6889 RVA: 0x003949E4 File Offset: 0x00392DE4
        private void txt2commper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt2balancelimet.Focus();
            }
        }

        // Token: 0x06001AEA RID: 6890 RVA: 0x003949FC File Offset: 0x00392DFC
        private void txt2balancelimet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.CheckBox2.Focus();
            }
        }

        // Token: 0x06001AEB RID: 6891 RVA: 0x00394A14 File Offset: 0x00392E14
        private void CheckBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt4match.Focus();
            }
        }

        // Token: 0x06001AEC RID: 6892 RVA: 0x00394A2C File Offset: 0x00392E2C
        private void txt4match_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        // Token: 0x06001AED RID: 6893 RVA: 0x00394A44 File Offset: 0x00392E44
        private void txtsadk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt3name.Focus();
            }
        }

        // Token: 0x06001AEE RID: 6894 RVA: 0x00394A5C File Offset: 0x00392E5C
        private void txt3name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt3match.Focus();
            }
        }

        // Token: 0x06001AEF RID: 6895 RVA: 0x00394A74 File Offset: 0x00392E74
        private void txt3match_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{Tab}");
            }
        }

        // Token: 0x06001AF0 RID: 6896 RVA: 0x00394A8C File Offset: 0x00392E8C
        private void txt3tie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.TextBox3.Focus();
            }
        }

        // Token: 0x06001AF1 RID: 6897 RVA: 0x00394AA4 File Offset: 0x00392EA4
        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.commiAgent.Focus();
            }
        }

        // Token: 0x06001AF2 RID: 6898 RVA: 0x00394ABC File Offset: 0x00392EBC
        private void commiAgent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt5name.Focus();
            }
        }

        // Token: 0x06001AF3 RID: 6899 RVA: 0x00394AD4 File Offset: 0x00392ED4
        private void txt5name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txt5match.Focus();
            }
        }

        // Token: 0x06001AF4 RID: 6900 RVA: 0x00394AEC File Offset: 0x00392EEC
        private void txt5match_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{Tab}");
            }
        }

        // Token: 0x06001AF5 RID: 6901 RVA: 0x00394B04 File Offset: 0x00392F04
        private void txt5tie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.TextBox2.Focus();
            }
        }

        // Token: 0x06001AF6 RID: 6902 RVA: 0x00394B1C File Offset: 0x00392F1C
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.commipatner.Focus();
            }
        }

        // Token: 0x06001AF7 RID: 6903 RVA: 0x00394B34 File Offset: 0x00392F34
        private void commipatner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.TextBox5.Focus();
            }
        }

        // Token: 0x06001AF8 RID: 6904 RVA: 0x00394B4C File Offset: 0x00392F4C
        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.TextBox8.Focus();
            }
        }

        // Token: 0x06001AF9 RID: 6905 RVA: 0x00394B64 File Offset: 0x00392F64
        private void TextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.TextBox7.Focus();
            }
        }

        // Token: 0x06001AFA RID: 6906 RVA: 0x00394B7C File Offset: 0x00392F7C
        private void TextBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.TextBox6.Focus();
            }
        }

        // Token: 0x06001AFB RID: 6907 RVA: 0x00394B94 File Offset: 0x00392F94
        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.Uapdate.Focus();
            }
        }

        // Token: 0x06001AFC RID: 6908 RVA: 0x00394BAC File Offset: 0x00392FAC
        private void Uapdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.Button3.Focus();
            }
        }

        // Token: 0x06001AFD RID: 6909 RVA: 0x00394BC4 File Offset: 0x00392FC4
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            this.TextBox1.SelectAll();
        }
    }
}
