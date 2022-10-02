using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using YashAksh.My;
using App.Service;
using System.Linq;

namespace YashAksh
{
    // Token: 0x02000044 RID: 68
    //[DesignerGenerated]
    public partial class Form3_SESSION : Form
    {

        private double numbar;
        private double Yes1;
        private double No1;
        public bool ismodify = false;
        public int trnid = 0;

        private string localnehaid = "";

        private double BalanceAmount;

        private double Hours1;
        private double Hours2;
        private double Rtotal1;
        private double Rtotal2;
        private double Rtotal3;
        private double Rtotal4;

        public Form3_SESSION()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000F81 RID: 3969 RVA: 0x0031F0CC File Offset: 0x0031D4CC
        public void aatextbox_Hide()
        {
            try
            {
                this.txtdate.Hide();
                this.txtsid.Hide();
                this.sid.Hide();
                this.Button8.Hide();
                this.Button9.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
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

        // Token: 0x06000F83 RID: 3971 RVA: 0x0031F290 File Offset: 0x0031D690
        private void Form3_SESSION_Activated(object sender, EventArgs e)
        {
            try
            {
                this.my_Positions();

                if (Module1.isratefirst == true)
                {
                    this.txtrate.Focus();
                    this.txtrate.SelectAll();
                }
                else
                {
                    this.txtamount.Focus();
                    this.txtamount.SelectAll();
                }

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000F84 RID: 3972 RVA: 0x0031F2D8 File Offset: 0x0031D6D8
        private void Form3_SESSION_Load(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Module1.isratefirst == true)
                    {
                        txtamount.Location = new Point(158, 31);
                        txtrate.Location = new Point(66, 31);

                        Label21.Text = "Amount";
                        Label22.Text = "Rate";

                        txtamount.TabIndex = 1;
                        txtrate.TabIndex = 0;
                    }

                    ControlExtension.Draggable(Panel10, true);
                    this.aatextbox_Hide();
                    this.txtsid.Text = Conversions.ToString(Module1.sessionid);
                    this.localnehaid = Conversions.ToString(Module1.nehaid);
                    this.txtnu.Text = Module1.decimalnumberformat;
                    this.Decleard();
                    this.button11.Enabled = false;

                    //this.Refresh_All();

                    this.cmbCommType.Text = Module1.commtype;
                    this.txtrate.Text = "1";

                    if (Module1.isratefirst == true)
                    {
                        this.txtrate.Focus();
                    }
                    else
                    {
                        this.txtamount.Focus();
                    }

                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06000F85 RID: 3973 RVA: 0x0031F584 File Offset: 0x0031D984
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from ewSession where Sr_No=" + Conversions.ToString(this.localnehaid) + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.btnModify.Enabled = false;
                    this.btndelete.Enabled = false;
                    this.txtpartiname.Enabled = false;
                    this.button11.Enabled = false;
                }
                else
                {
                    this.btnModify.Enabled = true;
                    this.btndelete.Enabled = true;
                    this.txtpartiname.Enabled = true;
                    this.button11.Enabled = true;
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

        // Token: 0x06000F86 RID: 3974 RVA: 0x0031F660 File Offset: 0x0031DA60
        public async Task AutoNumbear_Sr_ID()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(s_eid) from SessionTrans where S_Sr_No=" + this.txtsid.Text + " and Session_ID=" + Conversions.ToString(this.localnehaid);
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        this.sid.Text = "1";
                    }
                    else
                    {
                        int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        num++;
                        this.sid.Text = Conversions.ToString(num);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError("Form3_SESSION->AutoNumbear_Sr_ID", ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        // Token: 0x06000F87 RID: 3975 RVA: 0x0031F738 File Offset: 0x0031DB38
        public async Task Enty_Show_all()
        {
            checked
            {
                try
                {
                    this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string selectCommandText = "";
                    if (Module1.isamountfirst == true)
                    {
                        selectCommandText = string.Concat(new string[]
                        {
                            "SELECT s_eid AS Sr_No, s_amt AS Amount, s_rate AS Rate, S_RUN AS Run, s_mod AS Mode, s_party AS Party_Name, s_bild AS Badli, s_yes AS Yes, s_no AS [No], s_time AS [Time], s_page AS Page_No, s_checked,  s_modify, M_chk, s_date as [Date], Comission, modify_time, modify_date FROM SessionTrans WHERE (S_Sr_No = ",
                            this.txtsid.Text,
                            ") AND (Session_ID = ",
                            Conversions.ToString(this.localnehaid),
                            ") ORDER BY s_eid DESC"
                        });
                    }

                    if (Module1.isratefirst == true)
                    {
                        selectCommandText = string.Concat(new string[]
                        {
                            "SELECT s_eid AS Sr_No, s_rate AS Rate, s_amt AS Amount,S_RUN AS Run, s_mod AS Mode, s_party AS Party_Name, s_bild AS Badli, s_yes AS Yes, s_no AS [No], s_time AS [Time], s_page AS Page_No, s_checked,  s_modify, M_chk, s_date as [Date], Comission, modify_time, modify_date FROM SessionTrans WHERE (S_Sr_No = ",
                            this.txtsid.Text,
                            ") AND (Session_ID = ",
                            Conversions.ToString(this.localnehaid),
                            ") ORDER BY s_eid DESC"
                        });
                    }

                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                    DataSet dataSet = new DataSet();
                    oleDbDataAdapter.Fill(dataSet, "Table1");
                    this.DataGridView3.AutoGenerateColumns = true;
                    this.DataGridView3.DataSource = dataSet;
                    this.DataGridView3.DataMember = "Table1";
                    this.DataGridView3.Columns["Run"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["Mode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["Party_Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["Yes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["Amount"].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView3.Columns["Yes"].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView3.Columns["No"].DefaultCellStyle.Format = Module1.NumFormat;
                    this.DataGridView3.Columns["Time"].DefaultCellStyle.Format = "T";
                    this.DataGridView3.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["Comission"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.DataGridView3.Columns["modify_time"].HeaderText = "Modify Time";
                    this.DataGridView3.Columns["modify_date"].HeaderText = "Modify Date";
                    this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    for (int i = 0; i <= this.DataGridView3.RowCount - 1; i++)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[11].Value, "1", false))
                        {
                            this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            //this.DataGridView3.Rows[i].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[12].Value, "1", false))
                        {
                            this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[13].Value, "1", false))
                        {
                            this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.LimeGreen;
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError("Form3_SESSION->Entry_Show_all", ex.Message);
                }
                finally
                {
                    Module1.conn.Close();
                }
            }
        }

        // Token: 0x06000F88 RID: 3976 RVA: 0x0031FAF8 File Offset: 0x0031DEF8
        private async Task Datagrid_Format()
        {
            checked
            {
                try
                {
                    this.DataGridView3.Columns[11].Visible = false;
                    this.DataGridView3.Columns[12].Visible = false;
                    this.DataGridView3.Columns[13].Visible = false;
                    this.DataGridView3.Columns["Sr_No"].Width = 40;
                    this.DataGridView3.Columns["Run"].Width = 43;
                    this.DataGridView3.Columns["Amount"].Width = 95;
                    this.DataGridView3.Columns["Rate"].Width = 43;
                    this.DataGridView3.Columns["Mode"].Width = 25;
                    this.DataGridView3.Columns["Party_Name"].Width = 170;
                    this.DataGridView3.Columns["Badli"].Visible = false;
                    this.DataGridView3.Columns["Yes"].Width = 100;
                    this.DataGridView3.Columns["No"].Width = 100;
                    this.DataGridView3.Columns["Time"].Width = 130;
                    this.DataGridView3.Columns["Date"].Width = 100;
                    this.DataGridView3.Columns["modify_time"].Width = 130;
                    this.DataGridView3.Columns["modify_date"].Width = 100;
                    this.DataGridView3.Columns["Comission"].Width = 90;
                    this.DataGridView3.Columns["Page_No"].Visible = false;

                    for (int i = 0; i <= this.DataGridView3.RowCount - 1; i++)
                    {
                        if (!Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridView3.Rows[i].Cells[11].Value, 0, false), Operators.CompareObjectEqual(this.DataGridView3.Rows[i].Cells[12].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridView3.Rows[i].Cells[13].Value, 0, false))))
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[11].Value, "1", false))
                            {
                                this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                                //this.DataGridView3.Rows[i].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                            }
                            else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[12].Value, "1", false))
                            {
                                this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                            }
                            else if (Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[i].Cells[13].Value, "1", false))
                            {
                                this.DataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.LimeGreen;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError("Form3_SESSION->Datagrid_format", ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06000F89 RID: 3977 RVA: 0x0031FEC8 File Offset: 0x0031E2C8
        public async Task dispayname_Match()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from Newmatch where Sr_No=" + this.txtsid.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.lblDispay.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("    ", oleDbDataReader[2]), " "), "VS"), " "), oleDbDataReader[3]));
                }
                string cmdText2 = "Select * from ewSession where Match_ID=" + this.txtsid.Text + " and Sr_No=" + Conversions.ToString(this.localnehaid);
                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                while (oleDbDataReader2.Read())
                {
                    this.Label1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader2[3], " "), "("), oleDbDataReader2[7]), ")"));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Form3_SESSION->displayname_Match", ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06000F8A RID: 3978 RVA: 0x00320084 File Offset: 0x0031E484
        private void Button19_Click(object sender, EventArgs e)
        {
            try
            {
                MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
                MyProject.Forms.Session_Report.Show();
                this.Close();

                //if (Operators.CompareString(Module1.sessiondelc, "1", false) == 0)
                //{
                //	MyProject.Forms.All_Session.MdiParent = this.MdiParent;
                //	MyProject.Forms.All_Session.WindowState = FormWindowState.Maximized;
                //	MyProject.Forms.All_Session.Show();
                //	this.Close();
                //}
                //else
                //{
                //	MyProject.Forms.Session_Report.sessionrept();
                //	MyProject.Forms.Session_Report.MdiParent = this.MdiParent;
                //	MyProject.Forms.Session_Report.Show();
                //	this.Close();
                //}
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000F8B RID: 3979 RVA: 0x00320148 File Offset: 0x0031E548
        private void btnok_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Operators.CompareString(this.txtamount.Text, "", false) == 0)
                    {
                        MessageBox.Show("Please Insert Amount", "Hello", MessageBoxButtons.OK);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please Insrt Rate", (MsgBoxStyle)Conversions.ToInteger("Hello"), MessageBoxButtons.OK);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.txtrun.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please Insrt Run", (MsgBoxStyle)Conversions.ToInteger("Hello"), MessageBoxButtons.OK);
                        this.txtrun.Focus();
                    }
                    else if (Operators.CompareString(this.txtmodeKL.Text, null, false) == 0)
                    {
                        this.txtmodeKL.Focus();
                    }
                    else if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please Insrt Party Name", MsgBoxStyle.OkOnly, null);
                        this.txtpartiname.Focus();
                    }
                    else if (Operators.CompareString(this.txtpartiname.Text, null, false) != 0)
                    {
                        this.K__L();
                        this.AutoNumbear_Sr_ID();
                        this.InsertData();
                        this.Refresh_All();
                        MY_BALANCE_LIMIT();
                        this.cmbCommType.Text = Module1.commtype;
                        //this.txtrate.Text = "1";						
                        this.txtpartiname.Text = null;

                        if (Module1.isratefirst == true)
                        {
                            this.txtrate.Focus();
                            this.txtrate.SelectAll();
                        }
                        else
                        {
                            this.txtamount.Focus();
                            this.txtamount.SelectAll();
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

        //public void MY_BALANCE_LIMIT()
        //{
        //    try
        //    {
        //        double BalanceLimit = 0;
        //        if (Module1.conn.State == ConnectionState.Closed)
        //        {
        //            Module1.conn.Open();
        //        }

        //        string cmdText1 = "SELECT PartyMaster.PartyName, PartyMaster.BalanceLimit FROM PartyMaster WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') ORDER BY PartyMaster.PartyName";
        //        OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, Module1.conn);
        //        OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
        //        while (oleDbDataReader1.Read())
        //        {
        //            BalanceLimit = Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader1["BalanceLimit"]));
        //        }
        //        if (BalanceLimit > 0)
        //        {
        //            if (Module1.conn.State == ConnectionState.Closed)
        //            {
        //                Module1.conn.Open();
        //            }
        //            double num = 0.0;
        //            double sessionAmount = 0.0;
        //            double numCell0 = 0.0;
        //            double numCell1 = 0.0;
        //            double numCell2 = 0.0;
        //            double numCell3 = 0.0;
        //            double nuCellFinal = 0.0;

        //            string cmdText = "SELECT SUM(tns_Amount) AS ClosingBalanceAmount, tns_Party FROM Trans WHERE (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Party = '" + this.txtpartiname.Text + "') GROUP BY tns_Party ";
        //            OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
        //            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
        //            while (oleDbDataReader.Read())
        //            {
        //                num += Convert.ToDouble(oleDbDataReader["ClosingBalanceAmount"]);
        //            }

        //            string str = "SELECT PartyMaster.PartyName, Min(SessionTrans.S_RUN) as MinRun, Max(SessionTrans.S_RUN) as MaxRun FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') AND (SessionTrans.s_checked = 0) AND (SessionTrans.Session_ID IN (select Sr_no from ewSession where Match_id = " + this.txtsid.Text + " )) AND (SessionTrans.S_Sr_No = " + this.txtsid.Text + ") GROUP BY PartyMaster.PartyName HAVING Min(SessionTrans.S_RUN) > 0 AND Max(SessionTrans.S_RUN) > 0";
        //            OleDbCommand oleDbCommandBal = new OleDbCommand(str, Module1.conn);
        //            OleDbDataReader oleDbReaderBal = oleDbCommandBal.ExecuteReader();
        //            while (oleDbReaderBal.Read())
        //            {
        //                int MinRun = Conversions.ToInteger(oleDbReaderBal["MinRun"] == null ? 0 : oleDbReaderBal["MinRun"]);
        //                int MaxRun = Conversions.ToInteger(oleDbReaderBal["MaxRun"] == null ? 0 : oleDbReaderBal["MaxRun"]);

        //                if (MinRun > 0 && MaxRun > 0)
        //                {
        //                    GenrateGridRow_From_To((MinRun - 1), (MaxRun + 1));
        //                }
        //            }


        //            this.dataGridView8.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //            this.dataGridView8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


        //            /// Start - For Session Balance Limit
        //            string cmdTextSession = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SSession, PartyMaster.SSessionCommi, PartyMaster.ASession, PartyMaster.ASessionCommi, PartyMaster.TSession, PartyMaster.TSessionCommi, SessionTrans.S_Sr_No, SessionTrans.s_checked, SessionTrans.Session_ID, SessionTrans.s_yes, SessionTrans.s_no, SessionTrans.S_RUN, SessionTrans.s_amt, SessionTrans.s_rate, SessionTrans.s_mod, SessionTrans.s_bild, SessionTrans.Comission FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') AND (SessionTrans.s_checked = 0) AND (SessionTrans.Session_ID IN (select Sr_no from ewSession where Result <> 'Declared' AND Match_id = " + this.txtsid.Text + " )) AND (SessionTrans.S_Sr_No = " + this.txtsid.Text + ")";
        //            OleDbCommand oleDbCommandSession = new OleDbCommand(cmdTextSession, Module1.conn);
        //            OleDbDataReader oleDbDataReaderSession = oleDbCommandSession.ExecuteReader();
        //            while (oleDbDataReaderSession.Read())
        //            {
        //                double after_selfld = Convert.ToDouble(oleDbDataReaderSession["SSession"]);
        //                double after_totalld = Convert.ToDouble(Operators.AddObject(oleDbDataReaderSession["ASession"], oleDbDataReaderSession["TSession"]));
        //                double totalcommi = Convert.ToDouble(oleDbDataReaderSession["SSessionCommi"]) + Convert.ToDouble(oleDbDataReaderSession["ASessionCommi"]) + Convert.ToDouble(oleDbDataReaderSession["TSessionCommi"]);

        //                string comm = Conversions.ToString(oleDbDataReaderSession["Comission"]);
        //                string status = Conversions.ToString(oleDbDataReaderSession["Status"]);
        //                double run = Convert.ToDouble(oleDbDataReaderSession["S_RUN"]) - 1;
        //                double amt = Convert.ToDouble(oleDbDataReaderSession["s_amt"]);
        //                double rate = Convert.ToDouble(oleDbDataReaderSession["s_rate"]);

        //                double yes = Convert.ToDouble(oleDbDataReaderSession["s_yes"]);
        //                double no = Convert.ToDouble(oleDbDataReaderSession["s_no"]);

        //                double num9 = Conversion.Val(yes) * Conversion.Val(after_selfld) / 100 - yes;
        //                double num10 = Conversion.Val(no) * Conversion.Val(after_selfld) / 100 - no;
        //                double num11 = num9 - num9 - num9;
        //                double num12 = num10 - num10 - num10;
        //                double num13 = Conversion.Val(num9) * Conversion.Val(after_totalld) / 100 - num9;
        //                double num14 = Conversion.Val(num10) * Conversion.Val(after_totalld) / 100 - num10;

        //                if (comm == "YES")
        //                {
        //                    double commamt = 0;
        //                    if (num13 > num14)
        //                    {
        //                        commamt = num14 - num14 - num14;
        //                    }
        //                    else
        //                    {
        //                        commamt = num14;
        //                    }

        //                    if (status == "Booky")
        //                    {
        //                        if (num13 > 0)
        //                        {
        //                            this.Yes1 = Conversion.Val(num13) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }
        //                        else
        //                        {
        //                            this.Yes1 = Conversion.Val(num13) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }

        //                        if (num14 > 0)
        //                        {
        //                            this.No1 = Conversion.Val(num14) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }
        //                        else
        //                        {
        //                            this.No1 = Conversion.Val(num14) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }
        //                    }
        //                    else if (status == "Regular")
        //                    {
        //                        if (num13 > 0)
        //                        {
        //                            this.Yes1 = Conversion.Val(num13) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }
        //                        else
        //                        {
        //                            this.Yes1 = Conversion.Val(num13) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }

        //                        if (num14 > 0)
        //                        {
        //                            this.No1 = Conversion.Val(num14) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }
        //                        else
        //                        {
        //                            this.No1 = Conversion.Val(num14) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    this.Yes1 = Conversion.Val(num13);
        //                    this.No1 = Conversion.Val(num14);
        //                }

        //                checked
        //                {
        //                    for (int i = 0; i <= this.dataGridView8.Rows.Count - 1; i++)
        //                    {
        //                        if (Operators.ConditionalCompareObjectGreater(this.dataGridView8.Rows[i].Cells[0].Value, run, false))
        //                        {
        //                            if (Operators.CompareString(status, "Regular", false) == 0)
        //                            {
        //                                DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[3];
        //                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
        //                            }
        //                            else if (Operators.CompareString(status, "Booky", false) == 0)
        //                            {
        //                                DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[4];
        //                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
        //                            }
        //                        }
        //                        else if (Operators.CompareString(status, "Regular", false) == 0)
        //                        {
        //                            DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[3];
        //                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
        //                        }
        //                        else if (Operators.CompareString(status, "Booky", false) == 0)
        //                        {
        //                            DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[4];
        //                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
        //                        }
        //                        this.dataGridView8.Rows[i].Cells[1].Value = Strings.Format(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dataGridView8.Rows[i].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.dataGridView8.Rows[i].Cells[4].Value))), this.txtnu.Text);
        //                    }
        //                }

        //            }
        //            //oleDbCommandSession.Clone();
        //            //oleDbDataReaderSession.Close();

        //            //this.formatdatagrid();
        //            this.dataGridView8.Columns[0].Width = 51;
        //            this.dataGridView8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        //            if (dataGridView8.Rows.Count > 0)
        //            {
        //                //double _sessionAmount = 0;
        //                //Convert.ToDouble(dataGridView8.Rows.Cast<DataGridViewRow>().Max(r => double.TryParse(r.Cells[3].Value.ToString(),out _sessionAmount)?_sessionAmount :0));
        //                //sessionAmount = _sessionAmount;

        //                DataTable dt = new DataTable();

        //                //Adding the Columns.
        //                dt.Columns.Add("RUN", typeof(int));
        //                dt.Columns.Add("NP", typeof(double));
        //                dt.Columns.Add("DM", typeof(double));
        //                dt.Columns.Add("RG", typeof(double));
        //                dt.Columns.Add("BK", typeof(double));

        //                //Adding the Rows.
        //                foreach (DataGridViewRow row in dataGridView8.Rows)
        //                {
        //                    dt.Rows.Add();
        //                    foreach (DataGridViewCell cell in row.Cells)
        //                    {
        //                        if (cell.Value != null)
        //                        {
        //                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
        //                        }
        //                        else
        //                        {
        //                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = (0).ToString();
        //                        }
        //                    }
        //                }
        //                sessionAmount = dt.AsEnumerable().Max(row => Convert.ToDouble(row["RG"]));
        //            }
        //            /// End - For Session Balance Limit


        //            ////Start - For Match Balance LImit
        //            string cmdTextMatch = string.Concat(new string[]
        //            {
        //            "SELECT * FROM (",
        //            "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatchCommi, PartyMaster.SMatch HAVING (PartyMaster.PartyName = '",
        //            this.txtpartiname.Text,
        //            "') AND (MatchTrans.m_id = ",
        //            this.txtsid.Text,
        //            ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus')) ",
        //            " UNION ALL ",
        //            "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) WHERE (PartyMaster.PartyName = '",
        //            this.txtpartiname.Text,
        //            "') AND (MatchTrans.m_id = ",
        //            this.txtsid.Text,
        //            ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('Entry Wise')) ",
        //            ") ORDER BY PartyMaster.PartyName"
        //            });
        //            OleDbCommand oleDbCommandMatch = new OleDbCommand(cmdTextMatch, Module1.conn);
        //            OleDbDataReader oleDbDataReaderMatch = oleDbCommandMatch.ExecuteReader();
        //            while (oleDbDataReaderMatch.Read())
        //            {
        //                string status = Conversions.ToString(oleDbDataReaderMatch["Status"]);
        //                double smatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderMatch["SMatch"])));
        //                double smatchcommi = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderMatch["SMatchCommi"])));

        //                double exp1 = Conversion.Val(oleDbDataReaderMatch["Expr1"]);
        //                double exp2 = Conversion.Val(oleDbDataReaderMatch["Expr2"]);
        //                double exp3 = Conversion.Val(oleDbDataReaderMatch["Expr3"]);
        //                double exp4 = Conversion.Val(oleDbDataReaderMatch["Expr4"]);

        //                double exp1_total = 0, exp1_selfld = 0, exp1_afterldcommi = 0;
        //                double exp2_total = 0, exp2_selfld = 0, exp2_afterldcommi = 0;
        //                double exp3_total = 0, exp3_selfld = 0, exp3_afterldcommi = 0;
        //                double exp4_total = 0, exp4_selfld = 0, exp4_afterldcommi = 0;

        //                exp1_total = exp1;
        //                exp1_selfld = exp1 * smatch;
        //                exp1_selfld = (exp1 * smatch) - (exp1 * smatch) - (exp1 * smatch);
        //                exp1_afterldcommi = exp1 - (exp1 * smatch);
        //                if (!Operators.ConditionalCompareObjectLess(exp1_afterldcommi, 0, false) && status == "Regular")
        //                {
        //                    double num1 = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num1));
        //                }
        //                if (!Operators.ConditionalCompareObjectGreater(exp1_afterldcommi, 0, false) && status == "Booky")
        //                {
        //                    double num1 = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num1));
        //                }
        //                numCell0 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell0)), Conversion.Val(exp1_afterldcommi)), this.txtnu.Text));

        //                exp2_total = exp2;
        //                exp2_selfld = exp2 * smatch;
        //                exp2_selfld = (exp2 * smatch) - (exp2 * smatch) - (exp2 * smatch);
        //                exp2_afterldcommi = exp2 - (exp2 * smatch);
        //                if (!Operators.ConditionalCompareObjectLess(exp2_afterldcommi, 0, false) && status == "Regular")
        //                {
        //                    double num1 = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num1));
        //                }
        //                if (!Operators.ConditionalCompareObjectGreater(exp2_afterldcommi, 0, false) && status == "Booky")
        //                {
        //                    double num1 = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num1));
        //                }
        //                numCell1 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell1)), Conversion.Val(exp2_afterldcommi)), this.txtnu.Text));

        //                exp3_total = exp3;
        //                exp3_selfld = exp3 * smatch;
        //                exp3_selfld = (exp3 * smatch) - (exp3 * smatch) - (exp3 * smatch);
        //                exp3_afterldcommi = exp3 - (exp3 * smatch);
        //                if (!Operators.ConditionalCompareObjectLess(exp3_afterldcommi, 0, false) && status == "Regular")
        //                {
        //                    double num1 = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num1));
        //                }
        //                if (!Operators.ConditionalCompareObjectGreater(exp3_afterldcommi, 0, false) && status == "Booky")
        //                {
        //                    double num1 = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num1));
        //                }
        //                numCell2 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell2)), Conversion.Val(exp3_afterldcommi)), this.txtnu.Text));

        //                exp4_total = exp4;
        //                exp4_selfld = exp4 * smatch;
        //                exp4_selfld = (exp4 * smatch) - (exp4 * smatch) - (exp4 * smatch);
        //                exp4_afterldcommi = exp4 - (exp4 * smatch);
        //                if (!Operators.ConditionalCompareObjectLess(exp4_afterldcommi, 0, false) && status == "Regular")
        //                {
        //                    double num1 = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num1));
        //                }
        //                if (!Operators.ConditionalCompareObjectGreater(exp4_afterldcommi, 0, false) && status == "Booky")
        //                {
        //                    double num1 = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
        //                    exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num1));
        //                }
        //                numCell3 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell3)), Conversion.Val(exp4_afterldcommi)), this.txtnu.Text));
        //            }
        //            ////End - For Match Balance LImit
        //            nuCellFinal = Math.Max(numCell0, Math.Max(numCell1, numCell2));


        //            Module1.balancelimits = "Yes";
        //            this.Hours1 = Conversion.Val(nuCellFinal) + Conversion.Val(sessionAmount);
        //            double num42 = 0;
        //            if (0.0 > this.Hours1)
        //            {
        //                num42 = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(this.Hours1) + Conversion.Val(num), this.txtnu.Text));
        //            }
        //            else if (0.0 < this.Hours1)
        //            {
        //                num42 = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(this.Hours1) - Conversion.Val(num), this.txtnu.Text));
        //            }
        //            //double num43 = 0;
        //            //if (0.0 > this.Hours2)
        //            //{
        //            //    num43 = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(this.Hours2) + Conversion.Val(num) + Conversion.Val(num), this.txtnu.Text));
        //            //}
        //            //else if (0.0 < this.Hours2)
        //            //{
        //            //    num43 = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(this.Hours2) - Conversion.Val(num) + Conversion.Val(num), this.txtnu.Text));
        //            //}

        //            //if (Operators.CompareString(this.DataGridView1.Columns[6].HeaderText, this.cmbteam.Text, false) == 0)
        //            //{
        //            //    this.Label5.Text = "BALANCE IS : " + Module1.SetNumFormat(Conversion.Val(num42), this.txtnu.Text);
        //            //}
        //            //else if (Operators.CompareString(this.DataGridView1.Columns[7].HeaderText, this.cmbteam.Text, false) == 0)
        //            //{
        //            //    this.Label5.Text = "BALANCE IS : " + Module1.SetNumFormat(Conversion.Val(num43), this.txtnu.Text);
        //            //}

        //            this.BalanceAmount = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(Hours1) - Conversion.Val(num42), this.txtnu.Text));
        //            if (Hours1 > this.BalanceAmount)
        //            {
        //                Balance_Message balance_Message = new Balance_Message();
        //                balance_Message.BalanceLimit = Module1.SetNumFormat(Conversion.Val(num42), this.txtnu.Text);
        //                balance_Message.ShowDialog();
        //                this.txtpartiname.Text = null;

        //                if (Module1.isratefirst == true)
        //                {
        //                    this.txtrate.Focus();
        //                }
        //                else
        //                {
        //                    this.txtamount.Focus();
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
        //        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //    }
        //    finally
        //    {
        //        Module1.conn.Close();
        //    }
        //}

        public void MY_BALANCE_LIMIT()
        {
            try
            {
                double BalanceLimit = 0;
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }

                string cmdText1 = "SELECT PartyMaster.PartyName, PartyMaster.BalanceLimit FROM PartyMaster WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, Module1.conn);
                OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
                while (oleDbDataReader1.Read())
                {
                    BalanceLimit = Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader1["BalanceLimit"]));
                }
                if (BalanceLimit > 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    double num = 0.0;
                    double sessionAmount = 0.0;
                    double numCell0 = 0.0;
                    double numCell1 = 0.0;
                    double numCell2 = 0.0;
                    double numCell3 = 0.0;
                    double nuCellFinal = 0.0;
                    double finalsessionamount = 0;
                    double FinalBalanceLimit = 0;

                    string cmdText = "SELECT SUM(tns_Amount) AS ClosingBalanceAmount, tns_Party FROM Trans WHERE (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Party = '" + this.txtpartiname.Text + "') GROUP BY tns_Party ";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        num += Convert.ToDouble(oleDbDataReader["ClosingBalanceAmount"]);
                    }

                    FinalBalanceLimit = BalanceLimit + num;

                    /// Start - For Session Balance Limit
                    string strsessionlimit = "SELECT Newmatch.Sr_No FROM Newmatch WHERE Result <> 'Declared'";
                    OleDbCommand oleDbCommandSessionLimit = new OleDbCommand(strsessionlimit, Module1.conn);
                    OleDbDataReader oleDbReaderSessionLimit = oleDbCommandSessionLimit.ExecuteReader();
                    while (oleDbReaderSessionLimit.Read())
                    {
                        int match_id = 0;
                        match_id = Conversions.ToInteger(oleDbReaderSessionLimit["Sr_No"]);
                        bool isvalid = false;

                        string str1 = "SELECT Sr_No FROM ewSession WHERE Match_ID = " + match_id + " AND Result <> 'Declared' ";
                        OleDbCommand oleDbSes = new OleDbCommand(str1, Module1.conn);
                        OleDbDataReader oleDbReaderSes = oleDbSes.ExecuteReader();
                        while (oleDbReaderSes.Read())
                        {
                            int ses_id = 0;
                            ses_id = Conversions.ToInteger(oleDbReaderSes["Sr_No"]);

                            string str = "SELECT s_party, Min(S_RUN) as MinRun, Max(S_RUN) as MaxRun FROM (SessionTrans) WHERE (s_party = '" + this.txtpartiname.Text + "') AND (s_checked = 0) AND (Session_ID = " + ses_id + ") GROUP BY s_party HAVING Min(S_RUN) > 0 AND Max(S_RUN) > 0";
                            OleDbCommand oleDbCommandBal = new OleDbCommand(str, Module1.conn);
                            OleDbDataReader oleDbReaderBal = oleDbCommandBal.ExecuteReader();
                            while (oleDbReaderBal.Read())
                            {
                                isvalid = true;
                                int MinRun = Conversions.ToInteger(oleDbReaderBal["MinRun"] == null ? 0 : oleDbReaderBal["MinRun"]);
                                int MaxRun = Conversions.ToInteger(oleDbReaderBal["MaxRun"] == null ? 0 : oleDbReaderBal["MaxRun"]);

                                if (MinRun > 0 && MaxRun > 0)
                                {
                                    GenrateGridRow_From_To((MinRun - 1), (MaxRun + 1));
                                }
                            }

                            string cmdTextSession = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SSession, PartyMaster.SSessionCommi, PartyMaster.ASession, PartyMaster.ASessionCommi, PartyMaster.TSession, PartyMaster.TSessionCommi, SessionTrans.S_Sr_No, SessionTrans.s_checked, SessionTrans.Session_ID, SessionTrans.s_yes, SessionTrans.s_no, SessionTrans.S_RUN, SessionTrans.s_amt, SessionTrans.s_rate, SessionTrans.s_mod, SessionTrans.s_bild, SessionTrans.Comission FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') AND (SessionTrans.s_checked = 0) AND (SessionTrans.Session_ID = " + ses_id + ") ";
                            OleDbCommand oleDbCommandSession = new OleDbCommand(cmdTextSession, Module1.conn);
                            OleDbDataReader oleDbDataReaderSession = oleDbCommandSession.ExecuteReader();
                            while (oleDbDataReaderSession.Read())
                            {
                                double after_selfld = Convert.ToDouble(oleDbDataReaderSession["SSession"]);
                                double after_totalld = Convert.ToDouble(Operators.AddObject(oleDbDataReaderSession["ASession"], oleDbDataReaderSession["TSession"]));
                                double totalcommi = Convert.ToDouble(oleDbDataReaderSession["SSessionCommi"]); ////+ Convert.ToDouble(oleDbDataReaderSession["ASessionCommi"]) + Convert.ToDouble(oleDbDataReaderSession["TSessionCommi"]);

                                string comm = Conversions.ToString(oleDbDataReaderSession["Comission"]);
                                string status = Conversions.ToString(oleDbDataReaderSession["Status"]);
                                double run = Convert.ToDouble(oleDbDataReaderSession["S_RUN"]) - 1;
                                double amt = Convert.ToDouble(oleDbDataReaderSession["s_amt"]);
                                double rate = Convert.ToDouble(oleDbDataReaderSession["s_rate"]);

                                double yes = Convert.ToDouble(oleDbDataReaderSession["s_yes"]);
                                double no = Convert.ToDouble(oleDbDataReaderSession["s_no"]);

                                double num9 = Conversion.Val(yes) * Conversion.Val(after_selfld) / 100 - yes;
                                double num10 = Conversion.Val(no) * Conversion.Val(after_selfld) / 100 - no;
                                //double num11 = num9 - num9 - num9;
                                //double num12 = num10 - num10 - num10;

                                //double num13 = Conversion.Val(num9) * Conversion.Val(after_totalld) / 100 - num9;
                                //double num14 = Conversion.Val(num10) * Conversion.Val(after_totalld) / 100 - num10;
                                double num13 = num9;
                                double num14 = num10;

                                if (comm == "YES")
                                {
                                    double commamt = 0;
                                    if (num13 > num14)
                                    {
                                        commamt = num14 - num14 - num14;
                                    }
                                    else
                                    {
                                        commamt = num14;
                                    }

                                    if (status == "Booky")
                                    {
                                        if (num13 > 0)
                                        {
                                            this.Yes1 = Conversion.Val(num13) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.Yes1 = Conversion.Val(num13) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }

                                        if (num14 > 0)
                                        {
                                            this.No1 = Conversion.Val(num14) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.No1 = Conversion.Val(num14) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                    }
                                    else if (status == "Regular")
                                    {
                                        if (num13 > 0)
                                        {
                                            this.Yes1 = Conversion.Val(num13) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.Yes1 = Conversion.Val(num13) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }

                                        if (num14 > 0)
                                        {
                                            this.No1 = Conversion.Val(num14) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                        else
                                        {
                                            this.No1 = Conversion.Val(num14) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                                        }
                                    }
                                }
                                else
                                {
                                    this.Yes1 = Conversion.Val(num13);
                                    this.No1 = Conversion.Val(num14);
                                }

                                checked
                                {
                                    for (int i = 0; i <= this.dataGridView8.Rows.Count - 1; i++)
                                    {
                                        if (Operators.ConditionalCompareObjectGreater(this.dataGridView8.Rows[i].Cells[0].Value, run, false))
                                        {
                                            if (Operators.CompareString(status, "Regular", false) == 0)
                                            {
                                                DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[3];
                                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
                                            }
                                            else if (Operators.CompareString(status, "Booky", false) == 0)
                                            {
                                                DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[4];
                                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
                                            }
                                        }
                                        else if (Operators.CompareString(status, "Regular", false) == 0)
                                        {
                                            DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[3];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
                                        }
                                        else if (Operators.CompareString(status, "Booky", false) == 0)
                                        {
                                            DataGridViewCell dataGridViewCell = this.dataGridView8.Rows[i].Cells[4];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
                                        }
                                        this.dataGridView8.Rows[i].Cells[1].Value = Strings.Format(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(this.dataGridView8.Rows[i].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.dataGridView8.Rows[i].Cells[4].Value))), this.txtnu.Text);
                                    }
                                }

                                this.dataGridView8.Columns[0].Width = 51;
                                this.dataGridView8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                                if (dataGridView8.Rows.Count > 0)
                                {
                                    DataTable dt = new DataTable();
                                    dt.Columns.Add("RUN", typeof(int));
                                    dt.Columns.Add("NP", typeof(double));
                                    dt.Columns.Add("DM", typeof(double));
                                    dt.Columns.Add("RG", typeof(double));
                                    dt.Columns.Add("BK", typeof(double));

                                    foreach (DataGridViewRow row in dataGridView8.Rows)
                                    {
                                        dt.Rows.Add();
                                        foreach (DataGridViewCell cell in row.Cells)
                                        {
                                            if (cell.Value != null)
                                            {
                                                dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                                            }
                                            else
                                            {
                                                dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = (0).ToString();
                                            }
                                        }
                                    }
                                    finalsessionamount = dt.AsEnumerable().Max(row => Convert.ToDouble(row["RG"]));
                                }
                            }
                            if (isvalid == true)
                            {
                                sessionAmount += finalsessionamount;
                            }
                        }
                    }
                    /// End - For Session Balance Limit


                    ////Start - For Match Balance LImit
                    string cmdTextMatch = string.Concat(new string[]
                    {
                    "SELECT * FROM (",
                    "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, SUM(MatchTrans.m_team1) AS Expr1, SUM(MatchTrans.m_team2) AS Expr2, SUM(MatchTrans.m_team3) AS Expr3, SUM(MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, PartyMaster.SMatchCommi, PartyMaster.SMatch HAVING (PartyMaster.PartyName = '",
                    this.txtpartiname.Text,
                    "') AND (MatchTrans.m_id IN (SELECT DISTINCT Sr_No FROM Newmatch WHERE Result <> 'Declared') ",
                    //this.testnu.Text,
                    ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('No Commission','Match Total Minus')) ",
                    " UNION ALL ",
                    "SELECT PartyMaster.PartyName, PartyMaster.MatchCommiType, PartyMaster.Status, MatchTrans.m_id, MatchTrans.m_checked, (MatchTrans.m_team1) AS Expr1, (MatchTrans.m_team2) AS Expr2, (MatchTrans.m_team3) AS Expr3, (MatchTrans.m_team4)  AS Expr4, PartyMaster.SMatchCommi, PartyMaster.SMatch FROM (MatchTrans INNER JOIN PartyMaster ON MatchTrans.m_party = PartyMaster.PartyName) WHERE (PartyMaster.PartyName = '",
                    this.txtpartiname.Text,
                    "') AND (MatchTrans.m_id IN (SELECT DISTINCT Sr_No FROM Newmatch WHERE Result <> 'Declared') ",
                    //this.testnu.Text,
                    ") AND (MatchTrans.m_checked = 0) AND (PartyMaster.MatchCommiType IN ('Entry Wise')) ",
                    ") ORDER BY PartyMaster.PartyName"
                    });
                    OleDbCommand oleDbCommandMatch = new OleDbCommand(cmdTextMatch, Module1.conn);
                    OleDbDataReader oleDbDataReaderMatch = oleDbCommandMatch.ExecuteReader();
                    while (oleDbDataReaderMatch.Read())
                    {
                        string status = Conversions.ToString(oleDbDataReaderMatch["Status"]);
                        double smatch = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderMatch["SMatch"])));
                        double smatchcommi = Conversion.Val(Conversion.Val(0.01) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReaderMatch["SMatchCommi"])));

                        double exp1 = Conversion.Val(oleDbDataReaderMatch["Expr1"]);
                        double exp2 = Conversion.Val(oleDbDataReaderMatch["Expr2"]);
                        double exp3 = Conversion.Val(oleDbDataReaderMatch["Expr3"]);
                        double exp4 = Conversion.Val(oleDbDataReaderMatch["Expr4"]);

                        double exp1_total = 0, exp1_selfld = 0, exp1_afterldcommi = 0;
                        double exp2_total = 0, exp2_selfld = 0, exp2_afterldcommi = 0;
                        double exp3_total = 0, exp3_selfld = 0, exp3_afterldcommi = 0;
                        double exp4_total = 0, exp4_selfld = 0, exp4_afterldcommi = 0;

                        numCell0 = 0;
                        numCell1 = 0;
                        numCell2 = 0;

                        exp1_total = exp1;
                        exp1_selfld = exp1 * smatch;
                        exp1_selfld = (exp1 * smatch) - (exp1 * smatch) - (exp1 * smatch);
                        exp1_afterldcommi = exp1 - (exp1 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp1_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
                            exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp1_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp1_afterldcommi) * Conversion.Val(smatchcommi);
                            exp1_afterldcommi = Conversion.Val(Operators.SubtractObject(exp1_afterldcommi, num1));
                        }
                        numCell0 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell0)), Conversion.Val(exp1_afterldcommi)), this.txtnu.Text));

                        exp2_total = exp2;
                        exp2_selfld = exp2 * smatch;
                        exp2_selfld = (exp2 * smatch) - (exp2 * smatch) - (exp2 * smatch);
                        exp2_afterldcommi = exp2 - (exp2 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp2_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
                            exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp2_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp2_afterldcommi) * Conversion.Val(smatchcommi);
                            exp2_afterldcommi = Conversion.Val(Operators.SubtractObject(exp2_afterldcommi, num1));
                        }
                        numCell1 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell1)), Conversion.Val(exp2_afterldcommi)), this.txtnu.Text));

                        exp3_total = exp3;
                        exp3_selfld = exp3 * smatch;
                        exp3_selfld = (exp3 * smatch) - (exp3 * smatch) - (exp3 * smatch);
                        exp3_afterldcommi = exp3 - (exp3 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp3_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
                            exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp3_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp3_afterldcommi) * Conversion.Val(smatchcommi);
                            exp3_afterldcommi = Conversion.Val(Operators.SubtractObject(exp3_afterldcommi, num1));
                        }
                        numCell2 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell2)), Conversion.Val(exp3_afterldcommi)), this.txtnu.Text));

                        exp4_total = exp4;
                        exp4_selfld = exp4 * smatch;
                        exp4_selfld = (exp4 * smatch) - (exp4 * smatch) - (exp4 * smatch);
                        exp4_afterldcommi = exp4 - (exp4 * smatch);
                        if (!Operators.ConditionalCompareObjectLess(exp4_afterldcommi, 0, false) && status == "Regular")
                        {
                            double num1 = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
                            exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num1));
                        }
                        if (!Operators.ConditionalCompareObjectGreater(exp4_afterldcommi, 0, false) && status == "Booky")
                        {
                            double num1 = Conversion.Val(exp4_afterldcommi) * Conversion.Val(smatchcommi);
                            exp4_afterldcommi = Conversion.Val(Operators.SubtractObject(exp4_afterldcommi, num1));
                        }
                        numCell3 = Convert.ToDouble(Module1.SetNumFormat(Operators.AddObject(Conversion.Val(RuntimeHelpers.GetObjectValue(numCell3)), Conversion.Val(exp4_afterldcommi)), this.txtnu.Text));
                        nuCellFinal += Math.Max(numCell0, Math.Max(numCell1, numCell2));
                    }
                    ////End - For Match Balance LImit
                    //nuCellFinal = Math.Max(numCell0, Math.Max(numCell1, numCell2));


                    this.Hours1 = Conversion.Val(nuCellFinal) + Conversion.Val(sessionAmount);
                    if (Hours1 > FinalBalanceLimit)
                    {
                        double limit = Hours1 - FinalBalanceLimit;
                        Balance_Message balance_Message = new Balance_Message();
                        balance_Message.BalanceLimit = Module1.SetNumFormat(Conversion.Val(limit), this.txtnu.Text);
                        balance_Message.ShowDialog();
                        this.txtpartiname.Text = null;

                        if (Module1.isratefirst == true)
                        {
                            this.txtrate.Focus();
                        }
                        else
                        {
                            this.txtamount.Focus();
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

        private async Task GenrateGridRow_From_To(int from, int to)
        {
            try
            {
                this.dataGridView8.Rows.Clear();
                for (int i = from; i <= to; i++)
                {
                    this.dataGridView8.Columns[0].Width = 50;
                    int index = this.dataGridView8.Rows.Add();
                    this.dataGridView8.Rows[index].Cells[0].Value = i;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Form3_SESSION->GenerateGridRow", ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        //private async Task GenrateGridRowSession(int run)
        //{
        //    try
        //    {
        //        this.dataGridView8.Rows.Clear();
        //        int num = 0;
        //        int num2 = (int)(Math.Round(unchecked(run + 0.0)) - 1);
        //        for (int i = num; i <= num2; i++)
        //        {
        //            this.dataGridView8.Columns[0].Width = 50;
        //            int index = this.dataGridView8.Rows.Add();
        //            this.dataGridView8.Rows[index].Cells[0].Value = i;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        App.Utility.ErrorLog.LogError("Form3_SESSION->GenerateGridRow", ex.Message);
        //        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //    }
        //}
        
        public void formatdatagrid()
        {
            checked
            {
                try
                {
                    for (int i = 0; i <= this.datagridmen.Rows.Count - 1; i++)
                    {
                        if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[1].Value, 0, false))
                        {
                            this.datagridmen.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.datagridmen.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                        }

                        //if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[2].Value, 0, false))
                        //{
                        //	this.datagridmen.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                        //}
                        //else
                        //{
                        //	this.datagridmen.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                        //}

                        if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[3].Value, 0, false))
                        {
                            this.datagridmen.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.datagridmen.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                        }

                        if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[4].Value, 0, false))
                        {
                            this.datagridmen.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.datagridmen.Rows[i].Cells[4].Style.ForeColor = Color.Green;
                        }
                    }

                    for (int i = 0; i <= this.datagridmen.Rows.Count - 1; i++)
                    {
                        this.datagridmen.Rows[i].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[1].Value)), this.txtnu.Text);
                        //this.datagridmen.Rows[i].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[2].Value)), this.txtnu.Text);
                        this.datagridmen.Rows[i].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[3].Value)), this.txtnu.Text);
                        this.datagridmen.Rows[i].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[4].Value)), this.txtnu.Text);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06000F8D RID: 3981 RVA: 0x003207E0 File Offset: 0x0031EBE0
        public void K__L()
        {
            try
            {
                if (Operators.CompareString(this.txtmodeKL.Text, "K", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text));
                    this.txtL.Text = this.txtamount.Text;
                }
                if (Operators.CompareString(this.txtmodeKL.Text, "L", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtL.Text = Conversions.ToString(Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text));
                }
                if (Operators.CompareString(this.txtmodeKL.Text, "N", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text) - Conversion.Val(this.txtK.Text));
                    this.txtL.Text = this.txtamount.Text;
                }
                if (Operators.CompareString(this.txtmodeKL.Text, "Y", false) == 0)
                {
                    this.txtK.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                    this.txtL.Text = Conversions.ToString(Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text) - Convert.ToDouble(this.txtamount.Text));
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000F8E RID: 3982 RVA: 0x00320958 File Offset: 0x0031ED58
        public void InsertData()
        {
            try
            {
                string cmdText = $"INSERT INTO SessionTrans (S_Sr_No, s_eid, s_page, s_rate, s_amt, S_RUN, s_bild, s_mod, s_party, Status, s_yes, s_no, s_time, s_modify, s_checked, Comission, totalpa, Session_ID, M_chk, s_date)VALUES ({this.txtsid.Text},{this.sid.Text},{this.txtpage.Text},{this.txtrate.Text},{this.txtamount.Text},{this.txtrun.Text},{this.txtbild.Text},'{this.txtmodeKL.Text}','{this.txtpartiname.Text}','N', {this.txtK.Text},{this.txtL.Text},'{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}',0,0,'{this.cmbCommType.Text}',0,{Conversions.ToString(this.localnehaid)},0,'{this.txtdate.Text}')";
                using (TransactionService transactionService = new TransactionService())
                {
                    transactionService.Insert(cmdText);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        //// Token: 0x06000F8F RID: 3983 RVA: 0x00320B3C File Offset: 0x0031EF3C
        //public void Grid_Lode()
        //{
        //    try
        //    {
        //        if (Operators.CompareString(this.txtrun.Text, "", false) == 0 & Operators.CompareString(this.txtrate.Text, "", false) == 0 & Operators.CompareString(this.txtamount.Text, "", false) == 0)
        //        {
        //            MessageBox.Show("Run Rate Amount", "Run", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //        }
        //        else
        //        {
        //            int index = this.DataGridView3.Rows.Add();
        //            this.DataGridView3.Rows[index].Cells[0].Value = this.sid.Text;
        //            this.DataGridView3.Rows[index].Cells[1].Value = this.txtrun.Text;
        //            this.DataGridView3.Rows[index].Cells[2].Value = this.txtamount.Text;
        //            this.DataGridView3.Rows[index].Cells[3].Value = this.txtrate.Text;
        //            this.DataGridView3.Rows[index].Cells[4].Value = this.txtbild.Text;
        //            this.DataGridView3.Rows[index].Cells[5].Value = this.txtmodeKL.Text;
        //            this.DataGridView3.Rows[index].Cells[6].Value = this.txtpartiname.Text;
        //            this.DataGridView3.Rows[index].Cells[7].Value = this.txtK.Text;
        //            this.DataGridView3.Rows[index].Cells[8].Value = this.txtL.Text;
        //            this.DataGridView3.Rows[index].Cells[9].Value = this.txttime.Text;
        //            this.DataGridView3.Rows[index].Cells[10].Value = this.txtpage.Text;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
        //        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //    }
        //}

        // Token: 0x06000F92 RID: 3986 RVA: 0x00320E78 File Offset: 0x0031F278
        public async Task Combolode_And_selfsession_Asession_Psession_parsenteg()
        {
            try
            {
                //this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster ORDER BY PartyName";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.txtpartiname.Items.Clear();
                this.cmbPartyName.Items.Clear();
                while (oleDbDataReader.Read())
                {
                    //if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "1", false))
                    //{
                    //	if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "2", false))
                    //	{
                    //		if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[0], "3", false))
                    //		{
                    //int index = this.DataGridView1.Rows.Add();
                    //this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader[1].ToString();
                    this.txtpartiname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1])).ToString();
                    this.cmbPartyName.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1])).ToString();
                    //this.Cstaus.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Status"])).ToString();
                    //this.txtSelf.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["SSession"])).ToString();
                    //this.txtAgent.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["ASession"])).ToString();
                    //this.txtThirdParty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["TSession"])).ToString();
                    //this.txtt.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_Test"])).ToString();
                    //this.txtt_50.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_50"])).ToString();
                    //this.txtt_40.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_40"])).ToString();
                    //this.txtt_20.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_20"])).ToString();
                    //		}
                    //	}
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

        // Token: 0x06000F93 RID: 3987 RVA: 0x00321138 File Offset: 0x0031F538
        public void AutoComplete(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtpartiname.SelectionStart <= 1)
                        {
                            this.txtpartiname.Text = "";
                            return;
                        }
                        if (this.txtpartiname.SelectionLength == 0)
                        {
                            text = this.txtpartiname.Text.Substring(0, this.txtpartiname.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtpartiname.Text.Substring(0, this.txtpartiname.SelectionStart - 1);
                        }
                    }
                    else if (this.txtpartiname.SelectionLength == 0)
                    {
                        text = this.txtpartiname.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtpartiname.Text.Substring(0, this.txtpartiname.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtpartiname.FindString(text);
                    if (num != -1)
                    {
                        this.txtpartiname.SelectedText = "";
                        this.txtpartiname.SelectedIndex = num;
                        this.txtpartiname.SelectionStart = text.Length;
                        this.txtpartiname.SelectionLength = this.txtpartiname.Text.Length;
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

        // Token: 0x06000F93 RID: 3987 RVA: 0x00321138 File Offset: 0x0031F538
        public void AutoCompleteBadla(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.cmbPartyName.SelectionStart <= 1)
                        {
                            this.cmbPartyName.Text = "";
                            return;
                        }
                        if (this.cmbPartyName.SelectionLength == 0)
                        {
                            text = this.cmbPartyName.Text.Substring(0, this.cmbPartyName.Text.Length - 1);
                        }
                        else
                        {
                            text = this.cmbPartyName.Text.Substring(0, this.cmbPartyName.SelectionStart - 1);
                        }
                    }
                    else if (this.cmbPartyName.SelectionLength == 0)
                    {
                        text = this.cmbPartyName.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.cmbPartyName.Text.Substring(0, this.cmbPartyName.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.cmbPartyName.FindString(text);
                    if (num != -1)
                    {
                        this.cmbPartyName.SelectedText = "";
                        this.cmbPartyName.SelectedIndex = num;
                        this.cmbPartyName.SelectionStart = text.Length;
                        this.cmbPartyName.SelectionLength = this.cmbPartyName.Text.Length;
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

        //// Token: 0x06000F94 RID: 3988 RVA: 0x00321294 File Offset: 0x0031F694
        //private void txtparty_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //	try
        //	{
        //		ComboBox txtpartiname = this.txtpartiname;
        //		this.AutoComplete(ref txtpartiname, e, false);
        //		this.txtpartiname = txtpartiname;
        //		Module1.CustBalance = 0.0;
        //		Module1.TotalAmount = 0.0;
        //		Module1.TotalAmount += Convert.ToDouble(this.txtamount.Text);
        //		this.Customer_OpningBalance();
        //	}
        //	catch (Exception ex)
        //	{
        //		Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //}

        // Token: 0x06000F95 RID: 3989 RVA: 0x00321324 File Offset: 0x0031F724
        public void Customer_OpningBalance()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                double num = 0.0;
                double num1 = 0.0;
                this.lblOP.Text = "0";
                //string cmdText = "SELECT PartyMaster.PartyName, SUM(Trans.tns_Amount) AS Expr1 FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) GROUP BY PartyMaster.PartyName, Trans.tns_chk, Trans.tns_Type HAVING (Trans.tns_chk = '0') AND (Trans.tns_Type <> 'Monday Settlement') AND (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') ORDER BY PartyMaster.PartyName";
                string cmdText = "SELECT SUM(tns_Amount) AS ColsingBalanceAmount, tns_Party FROM Trans WHERE (tns_chk = '0') AND (tns_Type <> 'Monday Settlement') AND (tns_Party = '" + this.txtpartiname.Text + "') GROUP BY tns_Party ";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader["ColsingBalanceAmount"]));
                }
                string cmdText1 = "SELECT PartyMaster.PartyName,  PartyMaster.OpeningBalance FROM PartyMaster WHERE (PartyMaster.PartyName = '" + this.txtpartiname.Text + "') ORDER BY PartyMaster.PartyName";
                OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, Module1.conn);
                OleDbDataReader oleDbDataReader1 = oleDbCommand1.ExecuteReader();
                while (oleDbDataReader1.Read())
                {
                    num1 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(oleDbDataReader1["OpeningBalance"]));
                }

                this.lblOP.Text = Module1.SetNumFormat(Conversion.Val(num - num1), this.txtnu.Text);
                if (Convert.ToDouble(this.lblOP.Text) < 0.0)
                {
                    this.lblOP.ForeColor = Color.Red;
                }
                else
                {
                    this.lblOP.ForeColor = Color.Green;
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

        // Token: 0x06000F96 RID: 3990 RVA: 0x003214A8 File Offset: 0x0031F8A8
        private void txtmodeKL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.K__L();
        }

        // Token: 0x06000F97 RID: 3991 RVA: 0x003214B0 File Offset: 0x0031F8B0
        private void txtrun_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtrun.Text, "1", false) == 0 || Operators.CompareString(this.txtrun.Text, "2", false) == 0)
                {
                    this.TextBox1.Text = "1";
                }
                else
                {
                    this.TextBox1.Text = Conversions.ToString(Conversion.Val(this.txtrun.Text) - 9.0);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000F9B RID: 3995 RVA: 0x00321830 File Offset: 0x0031FC30
        private void DataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView3.CurrentRow.Cells[0].Value, null, false))
                {
                    this.numbar = Convert.ToDouble(this.DataGridView3.CurrentRow.Cells[0].Value.ToString());
                    Module1.dppname = this.DataGridView3.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06000F9C RID: 3996 RVA: 0x003218E4 File Offset: 0x0031FCE4
        private void Button22_Click(object sender, EventArgs e)
        {
            try
            {
                this.Refresh_All();

                this.cmbCommType.Text = Module1.commtype;
                this.txtrate.Text = "1";

                if (Module1.isratefirst == true)
                {
                    this.txtrate.Focus();
                }
                else
                {
                    this.txtamount.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private async Task Refresh_All()
        {
            checked
            {
                try
                {
                    await this.GenrateGridRow(Conversions.ToInteger(this.TextBox1.Text));
                    await this.Combolode_And_selfsession_Asession_Psession_parsenteg();
                    await this.dispayname_Match();
                    await this.Enty_Show_all();
                    await this.AutoNumbear_Sr_ID();
                    //await this.Regular_New();
                    //await this.SetColor();
                    //await this.Datagrid_Format();
                    this.LoadData();
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError("Form3_SESSION->Refresh_All", ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        private async Task LoadData()
        {
            try
            {
                await this.Regular_New();
                await this.SetColor();
                await this.Datagrid_Format();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Form3_SESSION->LoadData", ex.Message);
            }
        }

        // Token: 0x06000F9E RID: 3998 RVA: 0x00321AAC File Offset: 0x0031FEAC
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    //string cmdText = $"SELECT S_Sr_No, s_eid, S_RUN, s_bild, s_checked, Session_ID FROM SessionTrans WHERE (S_Sr_No = {this.txtsid.Text})";
                    string cmdText = string.Concat(new string[]
                    {
                        "SELECT S_Sr_No, s_eid, S_RUN, s_bild, s_checked, Session_ID FROM SessionTrans WHERE (S_Sr_No = ",
                        this.txtsid.Text,
                        ") AND (s_eid = ",
                        Conversions.ToString(this.numbar),
                        ") AND (Session_ID = ",
                        Conversions.ToString(this.localnehaid),
                        ") AND (s_checked = 1)"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Cannot Delete this Record..?", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        Module1.conn.Close();
                        cmdText = $"update SessionTrans SET s_checked=1, modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', modify_date = '{this.txtdate.Text}' where s_eid={this.numbar.ToString()} and S_Sr_No={this.txtsid.Text} and Session_ID={Conversions.ToString(this.localnehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        //this.Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
                        this.Refresh_All();


                        this.cmbCommType.Text = Module1.commtype;
                        this.txtrate.Text = "1";

                        if (Module1.isratefirst == true)
                        {
                            this.txtrate.Focus();
                        }
                        else
                        {
                            this.txtamount.Focus();
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

        // Token: 0x06000F9F RID: 3999 RVA: 0x00321C30 File Offset: 0x00320030
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "SELECT S_Sr_No, s_eid, s_page, s_rate, s_amt, S_RUN, s_bild, s_mod, s_party, Status, s_yes, s_no, s_time, s_modify, s_checked, Session_ID, M_chk, s_date, Comission FROM SessionTrans WHERE (S_Sr_No = ",
                    this.txtsid.Text,
                    ") AND (s_eid = ",
                    this.numbar.ToString(),
                    ") AND (Session_ID = ",
                    Conversions.ToString(this.localnehaid),
                    ")"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_checked"], "1", false))
                    {
                        Interaction.MsgBox("Cannot edit this record..?", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        this.ismodify = true;
                        this.sid.Text = oleDbDataReader["s_eid"].ToString();
                        this.txtpage.Text = oleDbDataReader["s_page"].ToString();
                        this.txtrun.Text = oleDbDataReader["S_RUN"].ToString();
                        this.txtrate.Text = oleDbDataReader["s_rate"].ToString();
                        this.txtamount.Text = oleDbDataReader["s_amt"].ToString();
                        this.txtbild.Text = oleDbDataReader["s_bild"].ToString();
                        this.txtmodeKL.Text = oleDbDataReader["s_mod"].ToString();
                        this.txtpartiname.Text = oleDbDataReader["s_party"].ToString();
                        this.txtK.Text = oleDbDataReader["s_yes"].ToString();
                        this.txtL.Text = oleDbDataReader["s_no"].ToString();
                        this.cmbCommType.Text = oleDbDataReader["Comission"].ToString();
                        this.btnok.Hide();
                        this.Button8.Show();
                        this.Button9.Show();

                        if (Module1.isratefirst == true)
                        {
                            this.txtrate.Focus();
                        }
                        else
                        {
                            this.txtamount.Focus();
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

        // Token: 0x06000FA1 RID: 4001 RVA: 0x00321F58 File Offset: 0x00320358
        public void Session_Size()
        {
            try
            {
                this.Size = new Size(732, 659);
                int x = checked(Screen.PrimaryScreen.WorkingArea.Width - 738);
                int y = 0; //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
                Point location = new Point(x, y);
                this.Location = location;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000FA2 RID: 4002 RVA: 0x00321FF0 File Offset: 0x003203F0
        private async Task SetColor()
        {
            checked
            {
                try
                {
                    for (int i = 0; i <= this.datagridmen.Rows.Count - 1; i++)
                    {
                        if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[1].Value, 0, false))
                        {
                            this.datagridmen.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.datagridmen.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                        }

                        //if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[2].Value, 0, false))
                        //{
                        //	this.datagridmen.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                        //}
                        //else
                        //{
                        //	this.datagridmen.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                        //}

                        if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[3].Value, 0, false))
                        {
                            this.datagridmen.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.datagridmen.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                        }

                        if (Operators.ConditionalCompareObjectLess(this.datagridmen.Rows[i].Cells[4].Value, 0, false))
                        {
                            this.datagridmen.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.datagridmen.Rows[i].Cells[4].Style.ForeColor = Color.Green;
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError("Form3_SESSION->SetColor", ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06000FA3 RID: 4003 RVA: 0x003222A0 File Offset: 0x003206A0
        private void Button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.ConditionalCompareObjectEqual(Module1.dppname, "", false))
                {
                    Interaction.MsgBox("Please Select Party Name Than Proced..?", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    fromAgentSession fromAgentSession = new fromAgentSession();
                    fromAgentSession.MdiParent = this.MdiParent;
                    fromAgentSession.WindowState = FormWindowState.Maximized;
                    fromAgentSession.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06000FA4 RID: 4004 RVA: 0x00322308 File Offset: 0x00320708
        private void Button8_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Operators.CompareString(this.txtamount.Text, "", false) == 0)
                    {
                        MessageBox.Show("Please Insert Amount", "Hello", MessageBoxButtons.OK);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please Insrt Rate", (MsgBoxStyle)Conversions.ToInteger("Hello"), MessageBoxButtons.OK);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.txtrun.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please Insrt Run", (MsgBoxStyle)Conversions.ToInteger("Hello"), MessageBoxButtons.OK);
                        this.txtrun.Focus();
                    }
                    else if (Operators.CompareString(this.txtmodeKL.Text, null, false) == 0)
                    {
                        this.txtmodeKL.Focus();
                    }
                    else if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please Insrt Party Name", (MsgBoxStyle)Conversions.ToInteger("Hello"), MessageBoxButtons.OK);
                        this.txtpartiname.Focus();
                    }
                    else if (Operators.CompareString(this.txtpartiname.Text, null, false) != 0)
                    {
                        this.K__L();
                        string cmdText = $"UPDATE SessionTrans SET s_page = {this.txtpage.Text}, s_rate = {this.txtrate.Text}, s_amt = {this.txtamount.Text}, S_RUN = {this.txtrun.Text}, s_bild = {this.txtbild.Text}, s_mod = '{this.txtmodeKL.Text}', s_party = '{this.txtpartiname.Text}', s_yes = {this.txtK.Text}, s_no = {this.txtL.Text}, modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', Comission = '{this.cmbCommType.Text}', modify_date = '{this.txtdate.Text}', s_modify = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.sid.Text} AND SessionTrans.Session_ID = {Conversions.ToString(this.localnehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.Refresh_All();
                        MY_BALANCE_LIMIT();
                        this.btnok.Show();
                        this.Button8.Hide();
                        this.Button9.Hide();
                        this.cmbCommType.Text = Module1.commtype;
                        this.txtrate.Text = "1";
                        this.txtamount.Text = "";
                        this.txtpartiname.Text = null;

                        if (Module1.isratefirst == true)
                        {
                            this.txtrate.Focus();
                        }
                        else
                        {
                            this.txtamount.Focus();
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
                    this.ismodify = false;
                }
            }
        }

        // Token: 0x06000FA5 RID: 4005 RVA: 0x0032274C File Offset: 0x00320B4C
        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnok.Show();
                this.Button8.Hide();
                this.Button9.Hide();
                this.cmbCommType.Text = Module1.commtype;
                this.txtrate.Text = "1";
                this.txtamount.Text = "";
                this.txtpartiname.Text = null;

                if (Module1.isratefirst == true)
                {
                    this.txtrate.Focus();
                }
                else
                {
                    this.txtamount.Focus();
                }

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                this.ismodify = false;
                Module1.conn.Close();
            }
        }

        // Token: 0x06000FA6 RID: 4006 RVA: 0x003227C0 File Offset: 0x00320BC0
        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string selectCommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select n.Team1,n.Name,e.Sr_No,e.Dt,e.N_name,e.Type,Cint(s_eid) AS id,s.s_rate,s.s_amt,s.S_RUN,s.s_bild,s.s_mod,s.s_party from Newmatch n,ewSession e,SessionTrans s where n.Sr_No=", this.txtsid.Text), " and e.Sr_No="), this.localnehaid), " and e.Match_ID="), this.txtsid.Text), " and s.S_Sr_No="), this.txtsid.Text), " and s.Session_ID="), this.localnehaid), " and s.s_checked=0 Order by s.id desc"));
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                oleDbDataAdapter.Fill(dataTable);

                //Add RPT
                //Sessionreportprint sessionreportprint = new Sessionreportprint();
                //sessionreportprint.SetDataSource(dataTable);
                //sessionreportprint.PrintToPrinter(0, false, 0, 0);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\Sessionreportprint.rpt");
                reportDocument.SetDataSource(dataTable);
                printView.crystalReportViewer1.ReportSource = reportDocument;
                printView.ShowDialog();

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

        // Token: 0x06000FA7 RID: 4007 RVA: 0x003228D4 File Offset: 0x00320CD4
        private void txtmodeKL_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                try
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        if (Operators.CompareString(this.txtmodeKL.Text, null, false) == 0)
                        {
                            this.Focus();
                        }
                        else
                        {
                            SendKeys.Send("{Tab}");
                        }
                    }
                    if (e.KeyCode == Keys.NumPad1)
                    {
                        this.txtmodeKL.SelectedItem = "K";
                    }
                    if (e.KeyCode == Keys.NumPad2)
                    {
                        this.txtmodeKL.SelectedItem = "L";
                    }
                    if (e.KeyCode == Keys.NumPad2)
                    {
                        this.txtmodeKL.SelectedItem = "Y";
                    }
                    if (e.KeyCode == Keys.NumPad2)
                    {
                        this.txtmodeKL.SelectedItem = "N";
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
            }
        }

        // Token: 0x06000FA9 RID: 4009 RVA: 0x00322A00 File Offset: 0x00320E00
        private void DataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Operators.ConditionalCompareObjectEqual(Module1.dppname, "", false))
                {
                    Interaction.MsgBox("Sorry Select Record", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    MyProject.Forms.formDPPSession.MdiParent = this.MdiParent;
                    MyProject.Forms.formDPPSession.WindowState = FormWindowState.Maximized;
                    MyProject.Forms.formDPPSession.Show();
                }
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
            }
        }

        // Token: 0x06000FAA RID: 4010 RVA: 0x00322A64 File Offset: 0x00320E64
        public async Task Regular_New()
        {
            try
            {
                this.datagridmen.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.datagridmen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SSession, PartyMaster.SSessionCommi, PartyMaster.ASession, PartyMaster.ASessionCommi, PartyMaster.TSession, PartyMaster.TSessionCommi, SessionTrans.S_Sr_No, SessionTrans.s_checked, SessionTrans.Session_ID, SessionTrans.s_yes, SessionTrans.s_no, SessionTrans.S_RUN, SessionTrans.s_amt, SessionTrans.s_rate, SessionTrans.s_mod, SessionTrans.s_bild, SessionTrans.Comission FROM (PartyMaster INNER JOIN SessionTrans ON PartyMaster.PartyName = SessionTrans.s_party) WHERE (SessionTrans.s_checked = 0) AND (SessionTrans.Session_ID = ",
                    Conversions.ToString(this.localnehaid),
                    ") AND (SessionTrans.S_Sr_No = ",
                    this.txtsid.Text,
                    ")"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    double after_selfld = Convert.ToDouble(oleDbDataReader["SSession"]);
                    double after_totalld = Convert.ToDouble(Operators.AddObject(oleDbDataReader["ASession"], oleDbDataReader["TSession"]));
                    double totalcommi = Convert.ToDouble(oleDbDataReader["SSessionCommi"]) + Convert.ToDouble(oleDbDataReader["ASessionCommi"]) + Convert.ToDouble(oleDbDataReader["TSessionCommi"]);

                    string comm = Conversions.ToString(oleDbDataReader["Comission"]);
                    string status = Conversions.ToString(oleDbDataReader["Status"]);
                    double run = Convert.ToDouble(oleDbDataReader["S_RUN"]) - 1;
                    double amt = Convert.ToDouble(oleDbDataReader["s_amt"]);
                    double rate = Convert.ToDouble(oleDbDataReader["s_rate"]);

                    double yes = Convert.ToDouble(oleDbDataReader["s_yes"]);
                    double no = Convert.ToDouble(oleDbDataReader["s_no"]);

                    double num9 = Conversion.Val(yes) * Conversion.Val(after_selfld) / 100 - yes;
                    double num10 = Conversion.Val(no) * Conversion.Val(after_selfld) / 100 - no;
                    double num11 = num9 - num9 - num9;
                    double num12 = num10 - num10 - num10;
                    double num13 = Conversion.Val(num9) * Conversion.Val(after_totalld) / 100 - num9;
                    double num14 = Conversion.Val(num10) * Conversion.Val(after_totalld) / 100 - num10;

                    if (comm == "YES")
                    {
                        double commamt = 0;
                        if (num13 > num14)
                        {
                            commamt = num14 - num14 - num14;
                        }
                        else
                        {
                            commamt = num14;
                        }

                        if (status == "Booky")
                        {
                            if (num13 > 0)
                            {
                                this.Yes1 = Conversion.Val(num13) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }
                            else
                            {
                                this.Yes1 = Conversion.Val(num13) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }

                            if (num14 > 0)
                            {
                                this.No1 = Conversion.Val(num14) + (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }
                            else
                            {
                                this.No1 = Conversion.Val(num14) - (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }
                        }
                        else if (status == "Regular")
                        {
                            if (num13 > 0)
                            {
                                this.Yes1 = Conversion.Val(num13) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }
                            else
                            {
                                this.Yes1 = Conversion.Val(num13) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }

                            if (num14 > 0)
                            {
                                this.No1 = Conversion.Val(num14) - (Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }
                            else
                            {
                                this.No1 = Conversion.Val(num14) + (-Conversion.Val(commamt) * Conversion.Val(totalcommi) / 100);
                            }
                        }
                    }
                    else
                    {
                        this.Yes1 = Conversion.Val(num13);
                        this.No1 = Conversion.Val(num14);
                    }

                    checked
                    {
                        for (int i = 0; i <= this.datagridmen.Rows.Count - 1; i++)
                        {
                            if (Operators.ConditionalCompareObjectGreater(this.datagridmen.Rows[i].Cells[0].Value, run, false))
                            {
                                if (Operators.CompareString(status, "Regular", false) == 0)
                                {
                                    DataGridViewCell dataGridViewCell = this.datagridmen.Rows[i].Cells[3];
                                    dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
                                }
                                else if (Operators.CompareString(status, "Booky", false) == 0)
                                {
                                    DataGridViewCell dataGridViewCell = this.datagridmen.Rows[i].Cells[4];
                                    dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.Yes1));
                                }
                            }
                            else if (Operators.CompareString(status, "Regular", false) == 0)
                            {
                                DataGridViewCell dataGridViewCell = this.datagridmen.Rows[i].Cells[3];
                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
                            }
                            else if (Operators.CompareString(status, "Booky", false) == 0)
                            {
                                DataGridViewCell dataGridViewCell = this.datagridmen.Rows[i].Cells[4];
                                dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Conversion.Val(this.No1));
                            }
                            this.datagridmen.Rows[i].Cells[1].Value = Strings.Format(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[4].Value))), this.txtnu.Text);
                        }
                    }

                }
                oleDbCommand.Clone();
                oleDbDataReader.Close();

                if (chkIsBadla.Checked == true)
                {
                    checked
                    {
                        for (int i = 0; i <= this.datagridmen.Rows.Count - 1; i++)
                        {
                            double run = Conversion.Val(this.datagridmen.Rows[i].Cells[0].Value);
                            string str = "SELECT PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SSession, PartyMaster.ASession, PartyMaster.TSession, BadlaTrn.m_id, BadlaTrn.s_id, BadlaTrn.run, SUM(BadlaTrn.amt) as amount FROM (PartyMaster INNER JOIN BadlaTrn ON PartyMaster.PartyName = BadlaTrn.party) WHERE BadlaTrn.m_id = " + this.txtsid.Text + " AND BadlaTrn.s_id = " + Conversions.ToString(this.localnehaid) + " GROUP BY PartyMaster.PartyName, PartyMaster.Status, PartyMaster.SSession, PartyMaster.ASession, PartyMaster.TSession, BadlaTrn.m_id, BadlaTrn.s_id, BadlaTrn.run HAVING (BadlaTrn.run = " + run + ")";
                            OleDbCommand oleDbCmd = new OleDbCommand(str, Module1.conn);
                            OleDbDataReader oleDbDataRdr = oleDbCmd.ExecuteReader();
                            while (oleDbDataRdr.Read())
                            {
                                string status = Conversions.ToString(oleDbDataRdr["Status"]);
                                double amt1 = Convert.ToDouble(oleDbDataRdr["amount"]);
                                double sld = Convert.ToDouble(oleDbDataRdr["SSession"]);
                                double totalld = Convert.ToDouble(Operators.AddObject(oleDbDataRdr["ASession"], oleDbDataRdr["TSession"]));

                                double num99 = Conversion.Val(amt1) * Conversion.Val(sld) / 100 - Conversion.Val(amt1);
                                double badlaamt = Conversion.Val(num99) * Conversion.Val(totalld) / 100 - Conversion.Val(num99);

                                if (Operators.CompareString(status, "Regular", false) == 0)
                                {
                                    DataGridViewCell dataGridViewCell = this.datagridmen.Rows[i].Cells[3];
                                    dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, badlaamt);
                                }
                                else if (Operators.CompareString(status, "Booky", false) == 0)
                                {
                                    DataGridViewCell dataGridViewCell = this.datagridmen.Rows[i].Cells[4];
                                    dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, badlaamt);
                                }
                                this.datagridmen.Rows[i].Cells[1].Value = Module1.SetNumFormat(unchecked(Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridmen.Rows[i].Cells[4].Value))), this.txtnu.Text);

                            }
                            oleDbCmd.Clone();
                            oleDbDataRdr.Close();
                        }
                    }
                }

                this.formatdatagrid();
                this.datagridmen.Columns[0].Width = 51;
                this.datagridmen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Form3_SESSION->Regular_New", ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        // Token: 0x06000FAB RID: 4011 RVA: 0x003237D8 File Offset: 0x00321BD8
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        this.GenrateGridRow(Conversions.ToInteger(this.TextBox1.Text));
                        this.Regular_New();
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06000FAD RID: 4013 RVA: 0x003238B0 File Offset: 0x00321CB0
        private void txtpage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtpage.Text, null, false) == 0)
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

        private void cmbCommType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.cmbCommType.Text, null, false) == 0)
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

        // Token: 0x06000FAE RID: 4014 RVA: 0x00323920 File Offset: 0x00321D20
        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
                        SendKeys.Send("{Tab}");
                        if (Module1.isamountfirst == true)
                        {
                            //this.txtrate.Focus();
                            this.txtrate.SelectAll();
                        }
                        else
                        {
                            //this.txtrun.Focus();
                            this.txtrun.SelectAll();
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

        // Token: 0x06000FAF RID: 4015 RVA: 0x0032399C File Offset: 0x00321D9C
        private void txtrate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                        if (Module1.isratefirst == true)
                        {
                            this.txtamount.SelectAll();
                        }
                        else
                        {
                            //this.txtrun.Focus();
                            this.txtrun.SelectAll();
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

        // Token: 0x06000FB0 RID: 4016 RVA: 0x00323A18 File Offset: 0x00321E18
        private void txtrun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtrun.Text, null, false) == 0)
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

        // Token: 0x06000FB1 RID: 4017 RVA: 0x00323A88 File Offset: 0x00321E88
        private void txtbild_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtbild.Text, null, false) == 0)
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

        // Token: 0x06000FB5 RID: 4021 RVA: 0x00323B88 File Offset: 0x00321F88
        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Button10.Text = "&Full Screen";
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Button10.Text = "&Haf-Screen";
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtpartiname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (ismodify == false)
                    {
                        if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                        {
                            this.Focus();
                        }
                        else
                        {
                            //this.btnok_Click(sender, e);
                            this.btnok.Focus();
                        }
                    }
                    else
                    {
                        this.Button8.Focus();
                    }
                }

                if (e.KeyCode == Keys.Back)
                {
                    this.txtpartiname.Text = null;
                    this.txtpartiname.Focus();
                }
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
                Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtpartiname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (this.txtamount.Text != "")
                {
                    ComboBox txtpartiname = this.txtpartiname;
                    this.AutoComplete(ref txtpartiname, e, false);
                    this.txtpartiname = txtpartiname;

                    Module1.CustBalance = 0.0;
                    Module1.TotalAmount = 0.0;
                    Module1.TotalAmount += Convert.ToDouble(this.txtamount.Text);
                    //this.Customer_OpningBalance();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private async Task GenrateGridRow(int run)
        {
            try
            {
                this.datagridmen.Rows.Clear();
                int num = Conversions.ToInteger(run);
                int num2 = (int)(Math.Round(unchecked(run + 50.0)) - 1);
                for (int i = num; i <= num2; i++)
                {
                    this.datagridmen.Columns[0].Width = 50;
                    int index = this.datagridmen.Rows.Add();
                    this.datagridmen.Rows[index].Cells[0].Value = i;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError("Form3_SESSION->GenerateGridRow", ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void LoadBadla()
        {
            try
            {
                this.DataGridView7.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select B1.trn_id, B1.run as ours, (select run from BadlaTrn B2 where B2.trn_id = B1.trn_id and B2.type = 'Opp') as opp, B1.amt, B1.party from BadlaTrn B1 where B1.type = 'Our' and B1.m_id = " + this.txtsid.Text + " and B1.s_id = " + Conversions.ToString(this.localnehaid) + " order by trn_id";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView7.Rows.Add();
                    this.DataGridView7.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["trn_id"].ToString());
                    this.DataGridView7.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["ours"].ToString());
                    this.DataGridView7.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["opp"].ToString());
                    this.DataGridView7.Rows[index].Cells[3].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(oleDbDataReader["amt"]), Module1.decimalnumberformat);
                    this.DataGridView7.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["party"].ToString());
                }
                this.DataGridView7.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView7.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView7.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView7.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DataGridView7.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel10.Visible = true;
                this.txtOursRun.Focus();
                this.LoadBadla();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.trnid != 0)
                {
                    if (Interaction.MsgBox("Are you sure want to delete badla?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }

                        string cmdText = $"delete * from BadlaTrn where trn_id = { this.trnid } ";
                        using (TemptblService temptblService = new TemptblService())
                        {
                            temptblService.Update(cmdText);
                        }
                        this.txtOursRun.Focus();
                        this.trnid = 0;
                        this.LoadBadla();
                        this.GenrateGridRow(Conversions.ToInteger(this.TextBox1.Text));
                        this.Regular_New();
                        this.SetColor();
                    }
                }
                else
                {
                    Interaction.MsgBox("First Select Record To Delete", MsgBoxStyle.OkOnly, null);
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

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtOursRun.Text == "" || this.txtOppRun.Text == "" || this.txtAmt.Text == "" || this.cmbPartyName.Text == "")
                {
                    MessageBox.Show("Please Insert Proper Data", "Hello", MessageBoxButtons.OK);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string cmdTextcommon = "select max(trn_id) from BadlaTrn";
                    OleDbCommand oleDbCommandcommon = new OleDbCommand(cmdTextcommon, Module1.conn);
                    checked
                    {
                        int trnid = 0;
                        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommandcommon.ExecuteScalar())))
                        {
                            trnid = 1;
                        }
                        else
                        {
                            trnid = Conversions.ToInteger(oleDbCommandcommon.ExecuteScalar());
                            trnid++;
                        }

                        Module1.conn.Close();
                        string cmdText = $"INSERT INTO BadlaTrn (m_id, s_id, run, amt, type, party, trn_id, [dt], [time] ) Values ({this.txtsid.Text},{Conversions.ToString(this.localnehaid)},{this.txtOursRun.Text},{this.txtAmt.Text},'Our','{this.cmbPartyName.Text}',{Conversions.ToString(trnid)},'{this.txtdate.Text}','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";

                        string cmdText2 = $"INSERT INTO BadlaTrn (m_id, s_id, run, amt, type, party, trn_id, [dt], [time] ) Values ({this.txtsid.Text},{Conversions.ToString(this.localnehaid)},{this.txtOppRun.Text},{Conversions.ToString(Conversion.Val(this.txtAmt.Text) - Conversion.Val(this.txtAmt.Text) - Conversion.Val(this.txtAmt.Text))},'Opp','{this.cmbPartyName.Text}',{Conversions.ToString(trnid)},'{this.txtdate.Text}','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
                        using (TemptblService temptblService = new TemptblService())
                        {
                            temptblService.Update(cmdText);
                            temptblService.Update(cmdText2);
                        }
                    }

                    this.LoadBadla();
                    this.GenrateGridRow(Conversions.ToInteger(this.TextBox1.Text));
                    this.Regular_New();
                    this.SetColor();

                    this.txtOursRun.Focus();
                    this.txtOursRun.Text = "";
                    this.txtOppRun.Text = "";
                    this.txtAmt.Text = "";
                    this.cmbPartyName.Text = "";
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

        private void btnNo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Panel10.Visible = false;
                this.txtOursRun.Text = "";
                this.txtOppRun.Text = "";
                this.txtAmt.Text = "";
                this.cmbPartyName.Text = "";

                if (Module1.isratefirst == true)
                {
                    this.txtrate.Focus();
                }
                else
                {
                    this.txtamount.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void txtOursRun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtOursRun.Text, null, false) == 0)
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

        private void txtOppRun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtOppRun.Text, null, false) == 0)
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

        private void txtAmt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtAmt.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        this.txtAmt.Text = Module1.SetNumFormat(Conversion.Val(this.txtAmt.Text), this.txtnu.Text);
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

        private void cmbPartyName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.cmbPartyName.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        btnYes.Focus();
                        //SendKeys.Send("{Tab}");
                    }
                }

                if (e.KeyCode == Keys.Back)
                {
                    this.cmbPartyName.Text = null;
                    this.cmbPartyName.Focus();
                }
            }
            catch (Exception ex2)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex2.Message);
                Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void cmbPartyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox cmbPartyName = this.cmbPartyName;
                this.AutoCompleteBadla(ref cmbPartyName, e, false);
                this.cmbPartyName = cmbPartyName;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void DataGridView7_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView7.CurrentRow.Cells[0].Value, null, false))
                {
                    this.trnid = Conversions.ToInteger(this.DataGridView7.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void All_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Form3_SESSION_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                MyProject.Forms.Match.Activate();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                if (Module1.isratefirst == true)
                {
                    txtrate.Focus();
                    txtrate.SelectAll();
                }
                else
                {
                    txtamount.Focus();
                    txtamount.SelectAll();
                }
            }
        }

        private void chkIsBadla_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkIsBadla.Checked == true)
                {
                    this.button11.Enabled = true;
                }
                else
                {
                    this.button11.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Form3_SESSION_Shown(object sender, EventArgs e)
        {
            Refresh_All();
        }

        private void txtrun_Enter(object sender, EventArgs e)
        {
            this.txtrun.SelectAll();
        }

        private void txtrate_Enter(object sender, EventArgs e)
        {
            this.txtrate.SelectAll();
        }

        private void txtamount_Enter(object sender, EventArgs e)
        {
            this.txtamount.SelectAll();
        }

        private void txtpartiname_Leave(object sender, EventArgs e)
        {
            if (this.txtpartiname.Text != "")
            {
                bool itemExists = false;
                foreach (var item in this.txtpartiname.Items)
                {
                    if (item.Equals(this.txtpartiname.Text))
                    {
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    this.txtpartiname.Text = "";
                    this.txtpartiname.Focus();
                }
            }
        }
    }
}
