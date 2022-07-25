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
    // Token: 0x0200005E RID: 94
    //[DesignerGenerated]
    public partial class New_Session : Form
    {
        // Token: 0x06001915 RID: 6421 RVA: 0x0038540C File Offset: 0x0038380C
        public New_Session()
        {
            this.InitializeComponent();
        }

        private void New_Session_Activated(object sender, EventArgs e)
        {
            try
            {
                this.my_Positions();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001937 RID: 6455 RVA: 0x00386308 File Offset: 0x00384708
        private void New_Session_Load(object sender, EventArgs e)
        {
            try
            {
                this.CAPITAL();
                this.IDNO();
                this.txtcommi.Text = "YES";
                this.ModifySession();
                this.txtsessin.Focus();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void ModifySession()
        {
            try
            {
                if (Module1.modifysessionid != 0 && Module1.modifysessionname != "")
                {
                    txtid.Text = Module1.modifysessionid.ToString();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "Select * from ewSession where Sr_No = " + txtid.Text + "";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        txtsessin.Text = Conversions.ToString(oleDbDataReader["N_name"]);
                        dtpdate.Text = Conversions.ToString(oleDbDataReader["Dt"]);
                        txtcommi.Text = Conversions.ToString(oleDbDataReader["Type"]);
                    }
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
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

        // Token: 0x06001938 RID: 6456 RVA: 0x00386360 File Offset: 0x00384760
        public void my_Positions()
        {
            try
            {
                Size size = new Size(732, 659);
                this.Size = size;
                int x = checked(Screen.PrimaryScreen.WorkingArea.Width - 738);
                int y = 0; //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
                Point location = new Point(x, y);
                this.Location = location;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001939 RID: 6457 RVA: 0x003863FC File Offset: 0x003847FC
        public void IDNO()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(tb_SID) from tb_MYID";
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
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        // Token: 0x0600193A RID: 6458 RVA: 0x003864BC File Offset: 0x003848BC
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsessin.Text == "")
                {
                    Interaction.MsgBox("Please Fill Session Name?", MsgBoxStyle.OkOnly, null);
                    this.txtsessin.Focus();
                }
                else
                {
                    int maxCount = 0;
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string str = $"select max(comm) from ewSession where N_name = '{this.txtsessin.Text}' and Match_ID = {Module1.machid} ";
                    OleDbCommand oleDbCommand = new OleDbCommand(str, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        maxCount = 0;
                    }
                    else
                    {
                        int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        num++;
                        maxCount = num;
                    }
                    Module1.conn.Close();
                    string strname = maxCount != 0 ? this.txtsessin.Text + " (" + maxCount.ToString() + ")" : this.txtsessin.Text;

                    string cmdText = $"insert into ewSession Values({this.txtid.Text},{Module1.machid}, '{this.dtpdate.Text}','{strname}' ,'','{maxCount}',0,'{this.txtcommi.Text}')";
                    string cmdText1 = $"UPDATE tb_MYID SET tb_SID = {this.txtid.Text}";
                    using (SessionService sessionService = new SessionService())
                    {
                        sessionService.Update(cmdText);
                        sessionService.Update(cmdText1);
                    }
                    Interaction.MsgBox("Record Saved", MsgBoxStyle.OkOnly, null);
                    //MyProject.Forms.Session_Report.sessionrept();
                    this.Close();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtsessin.Text == "")
                {
                    Interaction.MsgBox("Please Fill Session Name?", MsgBoxStyle.OkOnly, null);
                    this.txtsessin.Focus();
                }
                else
                {
                    string cmdText = $"update ewSession set N_name='{this.txtsessin.Text}',Type='{this.txtcommi.Text}', Dt='{this.dtpdate.Text}' where Sr_No={txtid.Text}";
                    string cmdText1 = $"UPDATE SessionTrans SET Comission='{this.txtcommi.Text}' WHERE Session_ID={txtid.Text}";
                    using (SessionService sessionService = new SessionService())
                    {
                        sessionService.Update(cmdText);
                        sessionService.Update(cmdText1);
                    }

                    Interaction.MsgBox("Record Updated", MsgBoxStyle.OkOnly, null);
                    //MyProject.Forms.Session_Report.sessionrept();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600193B RID: 6459 RVA: 0x00386650 File Offset: 0x00384A50
        public void CAPITAL()
        {
            try
            {
                this.txtid.CharacterCasing = CharacterCasing.Upper;
                this.txtsessin.CharacterCasing = CharacterCasing.Upper;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600193C RID: 6460 RVA: 0x003866A4 File Offset: 0x00384AA4
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Token: 0x0600193E RID: 6462 RVA: 0x003866B0 File Offset: 0x00384AB0
        private void txtsessin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtsessin.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600193F RID: 6463 RVA: 0x00386720 File Offset: 0x00384B20
        private void txtdate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.dtpdate.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001940 RID: 6464 RVA: 0x00386790 File Offset: 0x00384B90
        private void txtcommi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtcommi.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        //this.Button2.Focus();
                        SendKeys.Send("{Tab}");
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void New_Session_Deactivate(object sender, EventArgs e)
        {
            try
            {
                Module1.modifysessionid = 0;
                Module1.modifysessionname = "";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void New_Session_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Module1.modifysessionid = 0;
                Module1.modifysessionname = "";
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

    }
}
