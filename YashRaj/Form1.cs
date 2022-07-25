using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using App.Service;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using YashAksh.My;

namespace YashAksh
{
    [DesignerGenerated]
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Path.Combine(Application.StartupPath, "Image.jpg")))
                {
                    this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Image.jpg"));
                    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }

                var mnu = MenuStrip1.Items;
                mnu["mnuAdministrator"].Visible = BaseService.IsAdmin;

                this.txtdate.Hide();

                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from Settings";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    string strmobileNo = Conversions.ToString(oleDbDataReader["MobileNo"]);
                    this.Text = "SHUBH LABH   " + strmobileNo;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.BackupToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);

                Application.Exit();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void UserSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Setings
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void registrationInforamtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmRegistrationInfo
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Normal
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void licenseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmLicenseInfo
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Normal
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void NewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new New_Party
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void PartyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new Party_Report
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void MatchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Match_Report
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        private void SessionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Module1.machid = 0;
                new Session_Report
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        //private void NewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //	new New_Session
        //	{
        //		MdiParent = this,
        //		WindowState = FormWindowState.Maximized
        //	}.Show();
        //}


        //private void CupReportToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void SetlmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        private void ConnectingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new New_Connect
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void FinalTrialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Final_Trial_Balance
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void HawalaReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Hawala_Report
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        //private void FindSaudaEntryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //	new Frm_FinalSudaEntry
        //	{
        //		MdiParent = this,
        //		WindowState = FormWindowState.Maximized
        //	}.Show();
        //}

        private void MatchsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Match_Report
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void SessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Session_Report
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (Module1.conn.State == ConnectionState.Executing)
                    {
                        Module1.conn.Close();
                    }
                    else if (Module1.conn.State == ConnectionState.Fetching)
                    {
                        Module1.conn.Close();
                    }
                    else if (Module1.conn.State == ConnectionState.Open)
                    {
                        Module1.conn.Close();
                    }
                    else if (Module1.conn.State == ConnectionState.Broken)
                    {
                        Module1.conn.Close();
                    }
                    string text = $"{Application.StartupPath}\\DB\\{BaseService.DbName}";
                    string str = "C:\\Windows\\winyes";
                    object value = text;
                    string text2 = Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy");
                    string text3 = Module1.SetNumFormat(DateAndTime.Now, "h mm tt");
                    string text4 = "C:\\SHREE_BACKUP\\" + text2 + " " + text3;
                    Directory.CreateDirectory(text4);
                    object value2 = string.Concat(new string[]
                    {
                        text4,
                        "\\",
                        text2,
                        " ",
                        text3,
                        ".txt"
                    });
                    FileSystem.FileCopy(Conversions.ToString(value), Conversions.ToString(value2));
                    DirectoryInfo directoryInfo = new DirectoryInfo("C:\\SHREE_BACKUP\\");
                    directoryInfo.Attributes = FileAttributes.Hidden;
                    Directory.CreateDirectory(str + "\\" + Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy"));
                    object right = Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy");
                    object value3 = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(str + "\\", right), "\\"), Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy")), ".mdb");
                    FileSystem.FileCopy(Conversions.ToString(value), Conversions.ToString(value3));
                    ProjectData.EndApp();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox("Please Run Software  Mouse Rigth Button CLICK Run As Administator?", MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                Module1.conn.Close();
            }
        }

        //private void BetfairToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //	new Bit
        //	{
        //		MdiParent = this,
        //		WindowState = FormWindowState.Maximized
        //	}.Show();
        //}

        private void MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Match
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        //private void StandardSessionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void StandardSessionToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //	MyProject.Forms.Form3_SESSION.Show();
        //}

        private void StandardMacthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Match match = new Match();
            match.Show();
        }


        //private void Form1_Load(object sender, EventArgs e)
        //{
        //	try
        //	{
        //		try
        //		{
        //			this.Text = Module1.SerialNO.ToString() + "  * SHREE GAJANAN *";
        //		}
        //		catch (Exception ex)
        //		{
        //			this.Text = "* SHREE GAJANAN *";
        //		}
        //		Module1.conn = _ParthavI1516.OledbConn;
        //		if (Module1.conn.State == ConnectionState.Open)
        //		{
        //			Module1.conn.Close();
        //		}

        //		if (Module1.conn.State == ConnectionState.Closed)
        //		{
        //			Module1.conn.Open();
        //		}
        //		string cmdText = "SELECT        Match_ID FROM Session_mst WHERE(Session_ID = 1)";
        //		OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
        //		OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
        //		if (oleDbDataReader.Read())
        //		{
        //			mod_serial_id._mindi_hide = oleDbDataReader["Match_ID"].ToString();
        //		}
        //	}
        //	catch (Exception ex2)
        //	{
        //		Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //	finally
        //	{
        //		Module1.conn.Close();
        //	}
        //}


        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string dt = DateTime.Now.ToString("dd-MM-yyyy");
                string dFolder = "C:\\ShubhLabh";
                if (!Directory.Exists(dFolder))
                {
                    Directory.CreateDirectory(dFolder);
                }

                var dir = new DirectoryInfo(dFolder);
                dir.Attributes = FileAttributes.Hidden;

                if (!Directory.Exists(dFolder + "\\" + dt))
                {
                    Directory.CreateDirectory(dFolder + "\\" + dt);
                }

                string sDirPath = Application.StartupPath + "\\DB";
                string sFilePath = $"{Application.StartupPath}\\DB\\{BaseService.DbName}";

                if (Directory.Exists(sDirPath) && File.Exists(sFilePath))
                {
                    FileSystem.FileCopy(sFilePath, dFolder + "\\" + dt + "\\" + DateTime.Now.ToString("dd MMMM, yyyy hh mm tt") + ".txt");
                }

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox("Please Run Software Mouse Rigth Button CLICK Run As Administator?", MsgBoxStyle.OkOnly, null);
            }
        }

        private void onlineBackupToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath;
            string Backupmgs = CommonOperation.BackupDb(filepath, BaseService.MobileNo);
            MessageBox.Show(Backupmgs);
        }
        private void onlineBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath;
            string Backupmgs = CommonOperation.BackupDb(filepath, BaseService.MobileNo);
            MessageBox.Show(Backupmgs);
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                login.Show();
                //MyProject.Forms.Login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        //private void Button1_Click(object sender, EventArgs e)
        //{
        //}

        //[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //	try
        //	{
        //		if (Module1.conn.State == ConnectionState.Executing)
        //		{
        //			Module1.conn.Close();
        //		}
        //		else if (Module1.conn.State == ConnectionState.Fetching)
        //		{
        //			Module1.conn.Close();
        //		}
        //		else if (Module1.conn.State == ConnectionState.Open)
        //		{
        //			Module1.conn.Close();
        //		}
        //		else if (Module1.conn.State == ConnectionState.Broken)
        //		{
        //			Module1.conn.Close();
        //		}
        //		string text = Application.StartupPath + "\\DB\\MY_DB.mdb";
        //		string str = "C:\\Windows\\winyes";
        //		object value = text;
        //		string text2 = Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy");
        //		string text3 = Module1.SetNumFormat(DateAndTime.Now, "h mm tt");
        //		string text4 = "C:\\SHREE_BACKUP\\" + text2 + " " + text3;
        //		Directory.CreateDirectory(text4);
        //		object value2 = string.Concat(new string[]
        //		{
        //			text4,
        //			"\\",
        //			text2,
        //			" ",
        //			text3,
        //			".txt"
        //		});
        //		FileSystem.FileCopy(Conversions.ToString(value), Conversions.ToString(value2));
        //		DirectoryInfo directoryInfo = new DirectoryInfo("C:\\SHREE_BACKUP\\");
        //		directoryInfo.Attributes = FileAttributes.Hidden;
        //		object right = Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy");
        //		object value3 = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(str + "\\", right), "\\"), Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy")), ".mdb");
        //		try
        //		{
        //			_ParthavI1516.LoginID = Module1.SerialNO;
        //			_ParthavI1516.Login_Conectiong();
        //		}
        //		catch (Exception ex)
        //		{
        //		}
        //		try
        //		{
        //			_ParthavI1516.LoginID = Module1.SerialNO;
        //			_ParthavI1516.Login_Password();
        //			if (Operators.CompareString(_ParthavI1516.LoginYes, "Yes", false) == 0)
        //			{
        //				MyProject.Forms.Boolk_MSG.Label2.Text = _ParthavI1516.LoginPassmsg;
        //				MyProject.Forms.Boolk_MSG.ShowDialog();
        //			}
        //			else if (Operators.CompareString(_ParthavI1516.LoginYes, "Yes1", false) == 0)
        //			{
        //				MyProject.Forms.MSG_ALL.Label2.Text = _ParthavI1516.LoginPassmsg;
        //				MyProject.Forms.MSG_ALL.ShowDialog();
        //			}
        //			_ParthavI1516.LoginYes = "";
        //		}
        //		catch (Exception ex2)
        //		{
        //		}
        //		FileSystem.FileCopy(Conversions.ToString(value), Conversions.ToString(value3));
        //		Directory.CreateDirectory(str + "\\" + Module1.SetNumFormat(DateAndTime.Now, "dd MMMM, yyyy"));
        //	}
        //	catch (Exception ex3)
        //	{
        //		Interaction.MsgBox("Please Run Software  Mouse Rigth Button CLICK Run As Administator?", MsgBoxStyle.OkOnly, null);
        //	}
        //	finally
        //	{
        //		Module1.conn.Close();
        //		ProjectData.EndApp();
        //	}
        //}

        //private void AKDToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void SessionReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //	new All_Session
        //	{
        //		MdiParent = this,
        //		WindowState = FormWindowState.Maximized
        //	}.Show();
        //}

        private void NewConnectingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new New_Connect
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void TossReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Toss_Reports
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new New_Match
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new Setlement_Report
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new Cup_Report
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        //private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //	new All_Session
        //	{
        //		MdiParent = this,
        //		WindowState = FormWindowState.Maximized
        //	}.Show();
        //}

        private void ClearDataKeepClBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Want to Clear Data And Keep Balance...?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Are You Finally Sure Want to Clear Data And Keep Balance...?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = "";
                        OleDbCommand oleDbCommand;

                        cmdText = "delete * from Newmatch";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from Abdntie";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from CupTrans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from ewSession";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from MatchTrans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from MatchTrans1";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from SessionTrans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from BadlaTrn";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "update tb_MYID set tb_MID=0, tb_SID=0";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        cmdText = "update PartyMaster set OpeningBalance=0";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();


                        cmdText = "SELECT PartyMaster.PartyName, SUM(tns_Amount) AS Amt FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_Party) WHERE (Trans.tns_chk = '0') AND (Trans.tns_Type <> 'Monday Settlement') GROUP BY PartyMaster.PartyName ORDER BY PartyMaster.PartyName";
                        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmdText, Module1.conn);
                        DataTable dt = new DataTable();
                        oleDbDataAdapter.Fill(dt);

                        cmdText = "delete * from Trans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        cmdText = "ALTER TABLE Trans ALTER COLUMN Id COUNTER (1, 1)";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        try
                        {
                            if (dt.Rows.Count != 0 && dt != null)
                            {
                                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                                {
                                    string cmdText32 = string.Concat(new string[]
                                    {
                                        "INSERT INTO Trans ([tns_party], [tns_Amount], [tns_Remark], [tns_MatchID], [tns_dt], [tns_Type], [tns_Vid], [tns_Monday], [tns_Sessionid], [tns_ModifyID], [tns_Monday_Final], [tns_Hawala], [tns_chk], [tns_time])",
                                        "VALUES ('" + dt.Rows[i]["PartyName"].ToString() + "', " + Conversion.Val(dt.Rows[i]["Amt"]) + ", 'Previous Closing Balance', 0, '" + this.txtdate.Text + "', 'OP_BAL', '0', '0', 0, 0, 'No', '', '0' ,'" + Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime) + "')"
                                    });
                                    OleDbCommand oleDbCommand32 = new OleDbCommand(cmdText32, Module1.conn);
                                    oleDbCommand32.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                        }


                        //cmdText = "SELECT PartyMaster.PartyName, SUM(tns_Amount) AS Expr1, Trans.tns_chk, Trans.tns_Type FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_Party) GROUP BY PartyMaster.PartyName, Trans.tns_chk, Trans.tns_Type HAVING (Trans.tns_chk = '0') AND (Trans.tns_Type <> 'Monday Settlement') ORDER BY PartyMaster.PartyName";
                        //OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, Module1.conn);
                        //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                        //DataSet dataSet = new DataSet();
                        //DataTable dataTable = new DataTable();
                        //oleDbDataAdapter.SelectCommand = new OleDbCommand(cmdText, Module1.conn);
                        //oleDbDataAdapter.Fill(dataSet);
                        //dataTable = dataSet.Tables[0];
                        //try
                        //{
                        //	foreach (object obj in dataTable.Rows)
                        //	{
                        //		object objectValue = RuntimeHelpers.GetObjectValue(obj);
                        //		string cmdText2 = string.Concat(new string[]
                        //		{

                        //			"INSERT INTO OP_BAL (Party_name, Amount, chk, Type, dt) VALUES ('",
                        //			NewLateBinding.LateIndexGet(objectValue, new object[]
                        //			{
                        //				0
                        //			}, null).ToString(),
                        //			"',",
                        //			NewLateBinding.LateIndexGet(objectValue, new object[]
                        //			{
                        //				1
                        //			}, null).ToString(),
                        //			",'",
                        //			NewLateBinding.LateIndexGet(objectValue, new object[]
                        //			{
                        //				2
                        //			}, null).ToString(),
                        //			"','",
                        //			NewLateBinding.LateIndexGet(objectValue, new object[]
                        //			{
                        //				3
                        //			}, null).ToString(),
                        //			"','",
                        //			Conversions.ToString(DateAndTime.Now.Date),
                        //			"')"
                        //		});
                        //		OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText2, Module1.conn);
                        //		oleDbCommand3.ExecuteNonQuery();
                        //	}
                        //}
                        //catch (Exception ex)
                        //{

                        //}

                        //string cmdText3 = "delete * from Trans Where tns_Type <> 'Monday Settlement' OR tns_Amount<> 0 OR tns_Monday<>'0'";
                        //OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText3, Module1.conn);
                        //oleDbCommand4.ExecuteNonQuery();

                        Interaction.MsgBox("Transaction Data Clear Successfully");
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

        private void ClearAllBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Want to Clear All Balance...?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Are You Finally Sure Want to Clear All Balance...?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = "";
                        OleDbCommand oleDbCommand;

                        //string cmdText = "delete * from OP_BAL";
                        //OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        //oleDbCommand.ExecuteNonQuery();

                        cmdText = "update PartyMaster set OpeningBalance=0";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        cmdText = "delete * from Trans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        cmdText = "ALTER TABLE Trans ALTER COLUMN Id COUNTER (1, 1)";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        //string cmdText2 = "delete from Trans Where tns_Type <> 'Monday Settlement' OR tns_Amount <> 0 OR tns_Monday <> '0'";
                        //OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        //oleDbCommand2.ExecuteNonQuery();

                        Interaction.MsgBox("Balance Data Clear Successfully");
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

        private void ClearProgrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Want to Clear Programe...?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Are You Finally Sure Want to Clear Programe...?", "Hello", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = "delete * from Newmatch";
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from Abdntie";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from CupTrans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from ewSession";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from MatchTrans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from MatchTrans1";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from SessionTrans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        cmdText = "delete * from BadlaTrn";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        //cmdText = "delete * from OP_BAL";
                        //oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        //oleDbCommand.ExecuteNonQuery();

                        //cmdText = "SELECT ID, PartyName FROM PartyMaster WHERE (ID = 1)";
                        //oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        //OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        //string text = "";
                        //if (oleDbDataReader.Read())
                        //{
                        //    text = oleDbDataReader["PartyName"].ToString();
                        //}

                        cmdText = "delete * from PartyMaster Where (ID <> 1) ";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        cmdText = "delete * from Trans";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        oleDbCommand.Clone();

                        cmdText = "ALTER TABLE Trans ALTER COLUMN Id COUNTER (1, 1)";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();

                        cmdText = "update tb_MYID set tb_MID=0, tb_SID=0, tb_PID=1";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbCommand.ExecuteNonQuery();
                        oleDbCommand.Clone();

                        Interaction.MsgBox("Clear Programe Successfully");
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

        private void ImportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new IMP_DATA
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                }.Show();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void SupportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void CR64BITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://downloads.businessobjects.com/akdlm/cr4vs2010/CRforVS_redist_install_64bit_13_0_1.zip");
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void CR32BITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://downloads.businessobjects.com/akdlm/cr4vs2010/CRforVS_redist_install_32bit_13_0_1.zip");
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void FRWORKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.microsoft.com/en-in/download/details.aspx?id=17851");
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //for (int x = 0; x < Application.OpenForms.Count; x++)
            //{
            //	if (Application.OpenForms[x] != this)
            //		Application.OpenForms[x].Close();
            //}
            //Application.Restart();
        }

       



        //private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        //{
        //	try
        //	{
        //		MyProject.Forms.Form3_SESSION.txtamount.Focus();
        //	}
        //	catch (Exception ex)
        //	{
        //		Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //}

        //private void NewModifyPartyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void NewMatchToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void MatchReportToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        //{
        //}

        //private void SessionReportToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void CupReportToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void ConnectingToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void BakupDataToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void FindSaudaEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void HawalaReportToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void SettlementReportToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void FinalTrialBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //}

        //private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //}

        //private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        //{
        //}

        //private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void ConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

    }
}
