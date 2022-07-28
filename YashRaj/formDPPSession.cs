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
using App.Service;

namespace YashAksh
{
    // Token: 0x02000045 RID: 69
    //[DesignerGenerated]
    public partial class formDPPSession : Form
    {
        // Token: 0x06000FB8 RID: 4024 RVA: 0x00323CDC File Offset: 0x003220DC
        public formDPPSession()
        {
            //base.Load += this.formDPPSession_Load;
            //base.KeyDown += this.formDPPSession_KeyDown;
            //base.Activated += this.formDPPSession_Activated;
            //base.FormClosing += this.formDPPSession_FormClosing;
            this.InitializeComponent();
        }

        // Token: 0x06001062 RID: 4194 RVA: 0x00327D48 File Offset: 0x00326148
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from ewSession where Sr_No=" + Conversions.ToString(Module1.nehaid) + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Button2.Enabled = false;
                    this.Button3.Enabled = false;
                    this.Label5.Text = Conversions.ToString(Operators.ConcatenateObject("DECLARED RUN : ", oleDbDataReader["Remark"]));
                    this.txtrun.Text = Conversions.ToString(oleDbDataReader["Remark"]);
                }
                else
                {
                    this.Button2.Enabled = true;
                    this.Button3.Enabled = true;
                    this.Label5.Text = null;
                }
                Module1.conn.Close();
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

        // Token: 0x06001063 RID: 4195 RVA: 0x00327E60 File Offset: 0x00326260
        private void formDPPSession_Load(object sender, EventArgs e)
        {
            try
            {
                if (Module1.isratefirst == true)
                {
                    txtamount.Location = new Point(89, 31);
                    txtrate.Location = new Point(10, 31);

                    Label21.Text = "Amount";
                    Label22.Text = "Rate";

                    txtamount.TabIndex = 1;
                    txtrate.TabIndex = 0;
                }

                this.txtnu.Text = Module1.decimalnumberformat;
                this.Panel4.Hide();
                this.txtsid.Text = Conversions.ToString(Module1.sessionid);
                this.txtname.Text = Module1.dppname.ToString();

                this.dispayname_Match();
                this.txtparsent.Hide();
                this.txtp.Hide();
                this.TextBox2.Hide();
                this.txtnu.Hide();
                this.TextBox1.Hide();
                this.Run.Hide();
                this.Button1.Hide();

                this.combolodall();
                this.Decleard();
                //this.Label4.Text = Conversions.ToString(Module1.Session_Fipty1);
                this.listlode1();
                this.ALL_TOTAL();

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001064 RID: 4196 RVA: 0x00327FDC File Offset: 0x003263DC
        public void dispayname_Match()
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
                if (oleDbDataReader.Read())
                {
                    this.Label6.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("    ", oleDbDataReader[2]), " "), "VS"), " "), oleDbDataReader[3]));
                }
                string cmdText2 = "Select * from ewSession where Match_ID=" + this.txtsid.Text + " and Sr_No=" + Conversions.ToString(Module1.nehaid);
                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                while (oleDbDataReader2.Read())
                {
                    this.Label7.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(oleDbDataReader2[3], " "), "("), oleDbDataReader2[7]), ")"));
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

        // Token: 0x06001065 RID: 4197 RVA: 0x00328164 File Offset: 0x00326564
        public void listlode1()
        {
            checked
            {
                try
                {
                    this.DataGridView2.Rows.Clear();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT S_Sr_No, s_eid, s_page, s_rate, s_amt, S_RUN, s_bild, s_mod, s_party, s_yes, s_no, s_time, s_modify, s_checked, Session_ID, M_chk, s_date, modify_date, modify_time FROM SessionTrans WHERE (S_Sr_No = ", Module1.sessionid), ") AND (s_party = '"), this.txtname.Text), "') AND (Session_ID = "), Module1.nehaid), ")ORDER BY s_eid DESC"));
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    double value = 0;
                    while (oleDbDataReader.Read())
                    {
                        int num = this.DataGridView2.Rows.Add();
                        this.DataGridView2.Rows[num].Cells[0].Value = Conversions.ToBoolean(oleDbDataReader["M_chk"]);
                        this.DataGridView2.Rows[num].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                        if (Module1.isratefirst == true)
                        {
                            this.DataGridView2.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                            this.DataGridView2.Columns[3].HeaderText = "Amount";
                            this.DataGridView2.Rows[num].Cells[2].Value = Strings.Format(Conversion.Val(oleDbDataReader["s_rate"].ToString()), "0.0000");  //Convert.ToString(this.dr["m_rate"],"0.0000");
                            this.DataGridView2.Columns[2].HeaderText = "Rate";
                        }
                        else
                        {
                            this.DataGridView2.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                            this.DataGridView2.Rows[num].Cells[3].Value = Strings.Format(Conversion.Val(oleDbDataReader["s_rate"].ToString()), "0.0000");  //Convert.ToString(this.dr["m_rate"],"0.0000");
                        }
                        this.DataGridView2.Rows[num].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                        this.DataGridView2.Rows[num].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                        this.DataGridView2.Rows[num].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                        this.DataGridView2.Rows[num].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                        this.DataGridView2.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                        this.DataGridView2.Rows[num].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                        this.DataGridView2.Rows[num].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                        this.DataGridView2.Rows[num].Cells[11].Value = oleDbDataReader["s_date"].ToString();

                        this.DataGridView2.Rows[num].Cells[12].Value = oleDbDataReader["modify_time"].ToString();
                        this.DataGridView2.Rows[num].Cells[13].Value = oleDbDataReader["modify_date"].ToString();

                        if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_checked"].ToString(), "1", false))
                        {
                            this.DataGridView2.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                            //this.DataGridView2.Rows[num].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                        }
                        else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_modify"].ToString(), "1", false))
                        {
                            this.DataGridView2.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                            value += 1;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"].ToString(), "1", false))
                        {
                            this.DataGridView2.Rows[num].DefaultCellStyle.ForeColor = Color.LimeGreen;
                            value += 1;
                        }
                        else
                        {
                            value += 1;
                        }

                        //if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_checked"], "1", false))
                        //{
                        //	int num = this.DataGridView2.Rows.Add();
                        //	this.DataGridView2.Rows[num].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                        //	this.DataGridView2.Rows[num].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                        //	this.DataGridView2.Rows[num].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                        //	this.DataGridView2.Rows[num].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                        //	this.DataGridView2.Rows[num].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                        //	this.DataGridView2.Rows[num].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                        //	this.DataGridView2.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                        //	value = Convert.ToDouble(num + 1);
                        //}
                        //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["M_chk"], "1", false))
                        //{
                        //	int num2 = this.DataGridView2.Rows.Add();
                        //	this.DataGridView2.Rows[num2].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                        //	this.DataGridView2.Rows[num2].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num2].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num2].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                        //	this.DataGridView2.Rows[num2].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                        //	this.DataGridView2.Rows[num2].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                        //	this.DataGridView2.Rows[num2].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num2].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num2].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                        //	this.DataGridView2.Rows[num2].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                        //	value = Convert.ToDouble(num2 + 1);
                        //	this.DataGridView2.Rows[num2].Cells[0].Value = true;
                        //	this.DataGridView2.Rows[num2].DefaultCellStyle.BackColor = Color.LimeGreen;
                        //	this.DataGridView2.Rows[num2].DefaultCellStyle.ForeColor = Color.White;
                        //}
                        //else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_modify"], "1", false))
                        //{
                        //	int num3 = this.DataGridView2.Rows.Add();
                        //	this.DataGridView2.Rows[num3].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                        //	this.DataGridView2.Rows[num3].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num3].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num3].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                        //	this.DataGridView2.Rows[num3].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                        //	this.DataGridView2.Rows[num3].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                        //	this.DataGridView2.Rows[num3].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num3].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num3].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                        //	this.DataGridView2.Rows[num3].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                        //	value = Convert.ToDouble(num3 + 1);
                        //	this.DataGridView2.Rows[num3].DefaultCellStyle.ForeColor = Color.Blue;
                        //}
                        //else
                        //{
                        //	int num4 = this.DataGridView2.Rows.Add();
                        //	this.DataGridView2.Rows[num4].Cells[1].Value = oleDbDataReader["s_eid"].ToString();
                        //	this.DataGridView2.Rows[num4].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_amt"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num4].Cells[3].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_rate"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num4].Cells[4].Value = oleDbDataReader["S_RUN"].ToString();
                        //	this.DataGridView2.Rows[num4].Cells[5].Value = oleDbDataReader["s_mod"].ToString();
                        //	this.DataGridView2.Rows[num4].Cells[6].Value = oleDbDataReader["s_bild"].ToString();
                        //	this.DataGridView2.Rows[num4].Cells[7].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_yes"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num4].Cells[8].Value = Module1.SetNumFormat(Conversion.Val(oleDbDataReader["s_no"].ToString()), this.txtnu.Text);
                        //	this.DataGridView2.Rows[num4].Cells[9].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["s_time"].ToString()), DateFormat.LongTime);
                        //	this.DataGridView2.Rows[num4].Cells[10].Value = oleDbDataReader["s_page"].ToString();
                        //	value = Convert.ToDouble(num4 + 1);
                        //}
                    }
                    this.Label2.Text = "TOTAL ENTRY : " + Conversions.ToString(value);
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

        // Token: 0x06001066 RID: 4198 RVA: 0x00328DA8 File Offset: 0x003271A8
        private void btnshow_Click(object sender, EventArgs e)
        {
            this.listlode1();
            this.ALL_TOTAL();
        }

        // Token: 0x06001067 RID: 4199 RVA: 0x00328DB8 File Offset: 0x003271B8
        public void ALL_TOTAL()
        {
            double test = 0;
            double test1 = 0;
            double test2 = 0;
            double test3 = 0;
            checked
            {
                try
                {
                    this.DataGridView1.Columns.Clear();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    this.DataGridView1.Columns.Clear();
                    this.DataGridView1.Columns.Add("Column Name", "Run");
                    this.DataGridView1.Columns[0].Width = 100;
                    this.DataGridView1.Rows.Add(new object[]
                    {
                        " Total "
                    });
                    this.DataGridView1.Rows.Add(new object[]
                    {
                        " LD "
                    });
                    int i = 0;
                    this.DataGridView1.Columns[i].Width = 66;
                    int num = Conversions.ToInteger(this.txtrun.Text);
                    int num2 = (int)Math.Round(unchecked(Convert.ToDouble(this.txtrun.Text) + 40.0));
                    for (i = num; i <= num2; i++)
                    {
                        this.DataGridView1.Columns.Add("Column Name", Conversions.ToString(i));
                    }
                    string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT SessionTrans.id, SessionTrans.s_eid, SessionTrans.s_rate, SessionTrans.s_amt, SessionTrans.S_RUN, SessionTrans.s_bild, SessionTrans.s_mod, SessionTrans.s_yes, SessionTrans.s_no, SessionTrans.s_checked, PartyMaster.SSession, PartyMaster.PartyName, SessionTrans.S_Sr_No, SessionTrans.Session_ID FROM (SessionTrans INNER JOIN PartyMaster ON SessionTrans.s_party = PartyMaster.PartyName ) WHERE (PartyMaster.PartyName = '" + this.txtname.Text + "') AND (SessionTrans.s_checked <> 1) AND (SessionTrans.S_Sr_No = ", Module1.sessionid), ") AND (SessionTrans.Session_ID = "), Module1.nehaid), ")"));
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_checked"], "1", false))
                        {
                            double num3 = 0;
                            double num4 = 0;
                            double num5 = 0;
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["PartyName"], this.txtname.Text, false))
                                {
                                    num3 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SSession"])) / 100);
                                    num4 = Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"])) * Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["SSession"])) / 100);
                                }
                                num3 = Conversion.Val(num3) - Conversion.Val(num3) - Conversion.Val(num3);
                                num4 = Conversion.Val(num4) - Conversion.Val(num4) - Conversion.Val(num4);
                                num5 = Convert.ToDouble(Operators.SubtractObject(oleDbDataReader["S_RUN"], 1));
                            }
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["s_bild"], "0", false))
                            {
                                double num6 = Convert.ToDouble("0");
                                int num7 = 1;
                                int num8 = this.DataGridView1.Columns.Count - 1;
                                for (i = num7; i <= num8; i++)
                                {
                                    unchecked
                                    {
                                        if (Convert.ToDouble(this.DataGridView1.Columns[i].HeaderText) > num5)
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"])) + Conversion.Val(num3)));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num3)));
                                        }
                                        else
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"])) + Conversion.Val(num4)));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num4)));
                                        }
                                        this.DataGridView1.Rows[0].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[i].Value)), this.txtnu.Text);
                                        this.DataGridView1.Rows[1].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[i].Value)), this.txtnu.Text);
                                      
                                        test = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[i].Value)), this.txtnu.Text));
                                        test1 = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[i].Value)), this.txtnu.Text));
                                    }
                                }
                            }
                            else
                            {
                                double num6 = Convert.ToDouble(Operators.AddObject(Operators.AddObject(num5, oleDbDataReader["s_bild"]), 2));
                                int num9 = 1;
                                int num10 = this.DataGridView1.Columns.Count - 1;
                                for (i = num9; i <= num10; i++)
                                {
                                    unchecked
                                    {
                                        if (Convert.ToDouble(this.DataGridView1.Columns[i].HeaderText) > num5 & Convert.ToDouble(this.DataGridView1.Columns[i].HeaderText) < num6)
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_yes"])) + Conversion.Val(num3)));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num3)));
                                        }
                                        else
                                        {
                                            DataGridViewCell dataGridViewCell = this.DataGridView1.Rows[0].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["s_no"])) + Conversion.Val(num4)));
                                            dataGridViewCell = this.DataGridView1.Rows[1].Cells[i];
                                            dataGridViewCell.Value = Operators.AddObject(dataGridViewCell.Value, Convert.ToDouble(Conversion.Val(num4)));
                                        }
                                        this.DataGridView1.Rows[0].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[i].Value)), this.txtnu.Text);
                                        this.DataGridView1.Rows[1].Cells[i].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[i].Value)), this.txtnu.Text);
                                        
                                        test2 = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[i].Value)), this.txtnu.Text));
                                        test3 = Convert.ToDouble(Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[1].Cells[i].Value)), this.txtnu.Text));

                                    }
                                }
                            }
                        }
                    }
                    int num11 = 1;
                    do
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[0].Cells[num11].Value, 0, false))
                        {
                            this.DataGridView1.Rows[0].Cells[num11].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[0].Cells[num11].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[1].Cells[num11].Value, 0, false))
                        {
                            this.DataGridView1.Rows[1].Cells[num11].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView1.Rows[1].Cells[num11].Style.ForeColor = Color.Green;
                        }
                        num11++;
                    }
                    while (num11 <= 41);
                    this.DataGridView1.Rows[1].Visible = false;
                    double aa = test;
                    double aa1 = test1;
                    double aa2 = test2;
                    double aa3 = test3;

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

        // Token: 0x06001068 RID: 4200 RVA: 0x00329754 File Offset: 0x00327B54
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

        // Token: 0x06001069 RID: 4201 RVA: 0x003298B0 File Offset: 0x00327CB0
        public void combolodall()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.txtname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                    this.txtparsent.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[8]));
                    this.txtparty.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[1]));
                    this.Cstaus.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[3]));
                    this.txtself.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["SSession"]));
                    this.txtagent.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["ASession"]));
                    this.txtpatnar.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["TSession"]));
                    //this.txtt.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_Test"]));
                    //this.txtt_50.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_50"]));
                    //this.txtt_40.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_40"]));
                    //this.txtt_20.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["C_20"]));
                }
                string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from PartyMaster where PartyName='", Module1.dppname), "'"));
                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                if (oleDbDataReader2.Read())
                {
                    this.txtp.Text = Conversions.ToString(oleDbDataReader2[8]);
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

        // Token: 0x0600106A RID: 4202 RVA: 0x00329B0C File Offset: 0x00327F0C
        private void txtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtparsent.SelectedIndex = this.txtname.SelectedIndex;
                double value = Conversion.Val(0.01) * Conversion.Val(this.txtparsent.Text);
                this.TextBox2.Text = Conversions.ToString(value);
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600106B RID: 4203 RVA: 0x00329B68 File Offset: 0x00327F68
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

        // Token: 0x0600106C RID: 4204 RVA: 0x00329B90 File Offset: 0x00327F90
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.ConditionalCompareObjectEqual(Module1.myexit, "1", false))
                {
                    this.Close();
                }
                else
                {
                    MyProject.Forms.Form3_SESSION.MdiParent = this.MdiParent;
                    MyProject.Forms.Form3_SESSION.Session_Size();
                    MyProject.Forms.Form3_SESSION.Show();
                    MyProject.Forms.Form3_SESSION.Activate();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600106D RID: 4205 RVA: 0x00329C08 File Offset: 0x00328008
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

        // Token: 0x0600106E RID: 4206 RVA: 0x00329D80 File Offset: 0x00328180
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtmodify.Text, null, false) != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "Select * from SessionTrans where s_eid=",
                        this.txtmodify.Text,
                        " and S_Sr_No=",
                        this.txtsid.Text,
                        " and Session_ID=",
                        Conversions.ToString(Module1.nehaid),
                        " and s_checked=1"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        Interaction.MsgBox("Connot delete this record ", MsgBoxStyle.OkOnly, null);
                    }
                    else
                    {
                        string cmdText2 = string.Concat(new string[]
                        {
                            "SELECT S_Sr_No, s_eid, s_page, s_rate, s_amt, S_RUN, s_bild, s_mod, s_party, s_yes, s_no, s_time, s_modify, s_checked, Session_ID, M_chk FROM SessionTrans WHERE (S_Sr_No = ",
                            this.txtsid.Text,
                            ") AND (Session_ID = ",
                            Conversions.ToString(Module1.nehaid),
                            ") AND (s_eid = ",
                            this.txtmodify.Text,
                            ")"
                        });
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        if (oleDbDataReader2.Read())
                        {
                            if (Operators.ConditionalCompareObjectEqual(oleDbDataReader2["s_checked"], "1", false))
                            {
                                Interaction.MsgBox("Cannot edit this record.?", MsgBoxStyle.OkOnly, null);
                            }
                            else
                            {
                                this.Panel4.Show();
                                this.txtpage.Text = oleDbDataReader2["s_page"].ToString();
                                this.txtmyrun.Text = oleDbDataReader2["S_RUN"].ToString();
                                this.txtrate.Text = oleDbDataReader2["s_rate"].ToString();
                                this.txtamount.Text = oleDbDataReader2["s_amt"].ToString();
                                this.txtbild.Text = oleDbDataReader2["s_bild"].ToString();
                                this.txtmodeKL.Text = oleDbDataReader2["s_mod"].ToString();
                                this.txtparty.Text = oleDbDataReader2["s_party"].ToString();
                                this.txtK.Text = oleDbDataReader2["s_yes"].ToString();
                                this.txtL.Text = oleDbDataReader2["s_no"].ToString();

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

        // Token: 0x0600106F RID: 4207 RVA: 0x0032A084 File Offset: 0x00328484
        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.K__L();
                string cmdText = $"UPDATE SessionTrans SET s_page ={this.txtpage.Text}, s_rate ={this.txtrate.Text}, s_amt ={this.txtamount.Text}, S_RUN ={this.txtmyrun.Text}, s_bild ={this.txtbild.Text}, s_mod ='{this.txtmodeKL.Text}', s_party ='{this.txtparty.Text}', Status ='N', s_yes ={this.txtK.Text}, s_no ={this.txtL.Text}, modify_time ='{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', modify_date ='{Conversions.ToString(DateAndTime.Now.Date)}', s_modify =1, s_checked =0, totalpa =0, M_chk =0 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                using (SessionService sessionService = new SessionService())
                {
                    sessionService.Update(cmdText);
                }
                this.Panel4.Hide();
                this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
                this.txtmodify.Text = null;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001070 RID: 4208 RVA: 0x0032A288 File Offset: 0x00328688
        private void txtparty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cstaus.SelectedIndex = this.txtparty.SelectedIndex;
                this.txtself.SelectedIndex = this.txtparty.SelectedIndex;
                this.txtagent.SelectedIndex = this.txtparty.SelectedIndex;
                this.txtpatnar.SelectedIndex = this.txtparty.SelectedIndex;
                int num = checked((int)Math.Round(unchecked(Conversion.Val(this.txtself.Text) + Conversion.Val(this.txtagent.Text) + Conversion.Val(this.txtpatnar.Text))));
                this.txttotalsession.Text = Conversions.ToString(Conversion.Val(0.01) * Conversion.Val(num));
                //this.txtt.SelectedIndex = this.txtparty.SelectedIndex;
                //this.txtt_20.SelectedIndex = this.txtparty.SelectedIndex;
                //this.txtt_40.SelectedIndex = this.txtparty.SelectedIndex;
                //this.txtt_50.SelectedIndex = this.txtparty.SelectedIndex;
                //if (Operators.CompareString(this.Label4.Text, "50-50", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt_50.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "40-40", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt_40.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "20-20", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt_20.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "TEST", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = this.txtt.Text;
                //}
                //else if (Operators.CompareString(this.Label4.Text, "NO COMMISSION", false) == 0)
                //{
                //	this.txttotalcommsesion.Text = "0";
                //}
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001071 RID: 4209 RVA: 0x0032A4DC File Offset: 0x003288DC
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
                {
                    if (Operators.CompareString(this.txtmodify.Text, null, false) != 0)
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = string.Concat(new string[]
                        {
                        "Select * from SessionTrans where s_eid=",
                        this.txtmodify.Text,
                        " and S_Sr_No=",
                        this.txtsid.Text,
                        " and Session_ID=",
                        Conversions.ToString(Module1.nehaid),
                        " and s_checked=1"
                        });
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        if (oleDbDataReader.Read())
                        {
                            Interaction.MsgBox("Connot delete this record ", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            Module1.conn.Close();
                            string cmdText2 = $"update SessionTrans set s_checked=1, modify_time ='{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', modify_date ='{Conversions.ToString(DateAndTime.Now.Date)}' where s_eid={this.txtmodify.Text} and S_Sr_No={this.txtsid.Text} and Session_ID={Conversions.ToString(Module1.nehaid)}";
                            using (SessionService sessionService = new SessionService())
                            {
                                sessionService.Update(cmdText2);
                            }
                            this.btnshow_Click(RuntimeHelpers.GetObjectValue(sender), e);
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

        // Token: 0x06001072 RID: 4210 RVA: 0x0032A67C File Offset: 0x00328A7C
        private void Button9_Click(object sender, EventArgs e)
        {
            this.Panel4.Hide();
            this.txtmodify.Text = null;
        }

        // Token: 0x06001073 RID: 4211 RVA: 0x0032A698 File Offset: 0x00328A98
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.txtname.Text, null, false) != 0)
                {
                    this.listlode1_Print();
                    //Add RPT
                    //SDDPreport sddpreport = new SDDPreport();

                    DataSet dataSet = new DataSet();
                    dataSet.Tables.Add("ListViewData1");
                    DataColumnCollection columns = dataSet.Tables[0].Columns;
                    columns.Add("Sr_No", Type.GetType("System.String"));
                    columns.Add("Amount", Type.GetType("System.String"));
                    columns.Add("Rate", Type.GetType("System.String"));
                    columns.Add("Run", Type.GetType("System.String"));
                    columns.Add("Mode", Type.GetType("System.String"));
                    columns.Add("Badli", Type.GetType("System.String"));
                    columns.Add("name", Type.GetType("System.String"));
                    try
                    {
                        foreach (object obj in this.ListView2.Items)
                        {
                            ListViewItem listViewItem = (ListViewItem)obj;
                            DataRow dataRow = dataSet.Tables[0].NewRow();
                            dataRow[0] = listViewItem.SubItems[0].Text;
                            dataRow[1] = listViewItem.SubItems[1].Text;
                            dataRow[2] = listViewItem.SubItems[2].Text;
                            dataRow[3] = listViewItem.SubItems[3].Text;
                            dataRow[4] = listViewItem.SubItems[4].Text;
                            dataRow[5] = listViewItem.SubItems[5].Text;
                            dataRow[6] = listViewItem.SubItems[6].Text;
                            dataSet.Tables[0].Rows.Add(dataRow);
                        }
                    }
                    finally
                    {
                        Module1.conn.Close();
                    }
                    //Add RPT
                    //sddpreport.SetDataSource(dataSet);
                    //sddpreport.PrintToPrinter(0, false, 0, 0);

                    print_view printView = new print_view();
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(Application.StartupPath + "\\RPT\\SDDPreport.rpt");
                    reportDocument.SetDataSource(dataSet);
                    printView.crystalReportViewer1.ReportSource = reportDocument;
                    printView.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001074 RID: 4212 RVA: 0x0032A8E4 File Offset: 0x00328CE4
        public void listlode1_Print()
        {
            try
            {
                this.ListView2.Items.Clear();
                Module1.conn.Open();
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Select * from SessionTrans where S_Sr_No=", Module1.sessionid), " and s_party='"), this.txtname.Text), "' and Session_ID="), Module1.nehaid));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (!Operators.ConditionalCompareObjectEqual(oleDbDataReader[15], "1", false))
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem = (ListViewItem)NewLateBinding.LateGet(this.ListView2.Items, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[0])
                        }, null, null, null);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[5])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[4])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[6])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[8])
                        }, null, null, null, true);
                        NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
                        {
                            RuntimeHelpers.GetObjectValue(oleDbDataReader[7])
                        }, null, null, null, true);
                        listViewItem.SubItems.Add(this.txtname.Text);
                        listViewItem.SubItems[1].Text = Convert.ToDouble(listViewItem.SubItems[1].Text).ToString(this.txtnu.Text);
                        listViewItem.SubItems[2].Text = Convert.ToDouble(listViewItem.SubItems[2].Text).ToString(this.txtnu.Text);
                        listViewItem.BackColor = Color.White;
                    }
                }
                Module1.conn.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001075 RID: 4213 RVA: 0x0032AB9C File Offset: 0x00328F9C
        public void AutoComplete11(ref ComboBox cb, KeyPressEventArgs e, bool blnLimitToList = false)
        {
            try
            {
                checked
                {
                    string text;
                    if (e.KeyChar == '\b')
                    {
                        if (this.txtparty.SelectionStart <= 1)
                        {
                            this.txtparty.Text = "";
                            return;
                        }
                        if (this.txtparty.SelectionLength == 0)
                        {
                            text = this.txtparty.Text.Substring(0, this.txtparty.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart - 1);
                        }
                    }
                    else if (this.txtparty.SelectionLength == 0)
                    {
                        text = this.txtparty.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtparty.Text.Substring(0, this.txtparty.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtparty.FindString(text);
                    if (num != -1)
                    {
                        this.txtparty.SelectedText = "";
                        this.txtparty.SelectedIndex = num;
                        this.txtparty.SelectionStart = text.Length;
                        this.txtparty.SelectionLength = this.txtparty.Text.Length;
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
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001076 RID: 4214 RVA: 0x0032ACF8 File Offset: 0x003290F8
        private void txtparty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtparty = this.txtparty;
                this.AutoComplete11(ref txtparty, e, false);
                this.txtparty = txtparty;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001077 RID: 4215 RVA: 0x0032AD20 File Offset: 0x00329120
        private void txtpage_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x06001078 RID: 4216 RVA: 0x0032AD38 File Offset: 0x00329138
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (Operators.ConditionalCompareObjectEqual(Module1.myexit, "1", false))
                    {
                        this.Close();
                    }
                    else
                    {
                        Form3_SESSION form3_SESSION = new Form3_SESSION();
                        form3_SESSION.MdiParent = this.MdiParent;
                        form3_SESSION.Session_Size();
                        form3_SESSION.Show();
                        this.Close();
                    }
                }
                if (e.KeyCode == Keys.Return)
                {
                    this.listlode1();
                    this.ALL_TOTAL();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x06001079 RID: 4217 RVA: 0x0032ADF0 File Offset: 0x003291F0
        private void formDPPSession_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (Operators.ConditionalCompareObjectEqual(Module1.myexit, "1", false))
                    {
                        this.Close();
                    }
                    else
                    {
                        Form3_SESSION form3_SESSION = new Form3_SESSION();
                        form3_SESSION.MdiParent = this.MdiParent;
                        form3_SESSION.Session_Size();
                        form3_SESSION.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        // Token: 0x0600107A RID: 4218 RVA: 0x0032AE90 File Offset: 0x00329290
        private void txtrun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.ALL_TOTAL();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600107B RID: 4219 RVA: 0x0032AEDC File Offset: 0x003292DC
        private void formDPPSession_Activated(object sender, EventArgs e)
        {
            this.txtname.Focus();
        }


        // Token: 0x0600107D RID: 4221 RVA: 0x0032AF04 File Offset: 0x00329304
        private void formDPPSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3_SESSION form3_SESSION = new Form3_SESSION();
            form3_SESSION.Session_Size();
        }

        // Token: 0x0600107E RID: 4222 RVA: 0x0032AF18 File Offset: 0x00329318
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, true, false))
                    {
                        this.DataGridView2.CurrentRow.Cells[0].Value = false;
                    }
                    else
                    {
                        this.DataGridView2.CurrentRow.Cells[0].Value = true;
                    }
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, true, false))
                    {
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView2.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, false, false))
                    {
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView2.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600107F RID: 4223 RVA: 0x0032B1A0 File Offset: 0x003295A0
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[1].Value, null, false))
                {
                    this.txtmodify.Text = this.DataGridView2.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001080 RID: 4224 RVA: 0x0032B22C File Offset: 0x0032962C
        private void Button5_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView2.Rows.Count - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        this.DataGridView2.Rows[i].Cells[0].Value = true;
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[i].Cells[0].Value, true, false))
                        {
                            string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = { this.txtsid.Text } AND SessionTrans.s_eid = { this.DataGridView2.Rows[i].Cells[1].Value} AND SessionTrans.Session_ID = { Module1.nehaid}";
                            using (SessionService sessionService = new SessionService())
                            {
                                sessionService.Update(cmdText);
                            }
                            this.DataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.LimeGreen;
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

        // Token: 0x06001081 RID: 4225 RVA: 0x0032B3D0 File Offset: 0x003297D0
        private void txtparty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.Button8.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06001082 RID: 4226 RVA: 0x0032B424 File Offset: 0x00329824
        private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[1].Value, null, false))
                    {
                        this.txtmodify.Text = this.DataGridView2.CurrentRow.Cells[1].Value.ToString();
                    }
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, true, false))
                    {
                        this.DataGridView2.CurrentRow.Cells[0].Value = false;
                    }
                    else
                    {
                        this.DataGridView2.CurrentRow.Cells[0].Value = true;
                    }
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, true, false))
                    {
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView2.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, false, false))
                    {
                        string cmdText = $"UPDATE SessionTrans SET M_chk = 1 WHERE (SessionTrans.S_Sr_No = {this.txtsid.Text} AND SessionTrans.s_eid = {this.txtmodify.Text} AND SessionTrans.Session_ID = {Conversions.ToString(Module1.nehaid)}";
                        using (SessionService sessionService = new SessionService())
                        {
                            sessionService.Update(cmdText);
                        }
                        this.DataGridView2.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x0600107C RID: 4220 RVA: 0x0032AEEC File Offset: 0x003292EC
        private void txtmyrun_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtmodeKL.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    SendKeys.Send("{Tab}");
                    if (Module1.isamountfirst == true)
                    {
                        this.txtrate.SelectAll();
                    }
                    else
                    {
                        this.txtmyrun.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtrate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    SendKeys.Send("{Tab}");
                    if (Module1.isratefirst == true)
                    {
                        this.txtamount.SelectAll();
                    }
                    else
                    {
                        this.txtmyrun.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtmodeKL_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.txtparty.Focus();
                    this.txtparty.SelectAll();
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
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtrate_Leave(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (this.txtrate.Text != "")
            //        {
            //            string text = this.txtrate.Text;
            //            double num = (double)text.IndexOf(".");
            //            if (num < 0.0)
            //            {
            //                this.txtrate.Text = this.txtrate.Text.Replace(this.txtrate.Text, "." + this.txtrate.Text);
            //            }
            //            this.txtrate.Text = Module1.SetNumFormat(Conversion.Val(this.txtrate.Text), this.txtnu.Text);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            //        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            //    }
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
    }
}
