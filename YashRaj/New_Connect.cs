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
    public partial class New_Connect : Form
    {
        public New_Connect()
        {
            this.InitializeComponent();
        }

        private void New_Connect_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataGridView5.Hide();
                this.DataGridView5Jama.Hide();
                this.DataGridView6.Hide();
                this.WindowState = FormWindowState.Maximized;
                this.txtsessionID.Hide();
                this.txtmatchID.Hide();
                this.ComboBox1.Hide();
                if (Module1.conn.State == ConnectionState.Open)
                {
                    Module1.conn.Close();
                }
                this.Delc();
                this.session_Decleard();

                Module1.DtMatch = new DataTable();
                Module1.DtMatch.Columns.Add("PartyName");
                Module1.DtMatch.Columns.Add("AParty");
                Module1.DtMatch.Columns.Add("TParty");
                Module1.DtMatch.Columns.Add("Expr1");

            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void Delc()
        {
            try
            {
                this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from Newmatch where Result='Declared' order by Sr_No desc";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.DataGridView1.Rows.Clear();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[1].Value = oleDbDataReader["Sr_No"].ToString();
                    this.DataGridView1.Rows[index].Cells[2].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Date1"].ToString()), DateFormat.ShortDate);
                    this.DataGridView1.Rows[index].Cells[3].Value = oleDbDataReader["horse1"].ToString() + " VS " + oleDbDataReader["horse2"].ToString();
                    this.DataGridView1.Rows[index].Cells[4].Value = oleDbDataReader["Type"].ToString();
                    this.DataGridView1.Rows[index].Cells[5].Value = oleDbDataReader["Remark"].ToString();
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

        public void session_Decleard()
        {
            try
            {
                this.DataGridView2.Rows.Clear();
                this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from ewSession where Result='Declared' Order By Sr_No desc";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView2.Rows.Add();
                    this.DataGridView2.Rows[index].Cells[1].Value = oleDbDataReader["Sr_No"].ToString();
                    this.DataGridView2.Rows[index].Cells[2].Value = oleDbDataReader["Match_ID"].ToString();
                    this.DataGridView2.Rows[index].Cells[3].Value = Strings.FormatDateTime(Conversions.ToDate(oleDbDataReader["Dt"].ToString()), DateFormat.ShortDate);
                    this.DataGridView2.Rows[index].Cells[4].Value = oleDbDataReader["N_Name"].ToString();
                    this.DataGridView2.Rows[index].Cells[5].Value = oleDbDataReader["Remark"].ToString();
                }
                this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridView1.Rows.Count != 0)
            {
                try
                {
                    this.txtmatchID.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
                    this.txtsessionID.Text = "0";
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        private void btnCannectings_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    Module1.DtMatch.Rows.Clear();
                    this.txtjuma.Text = "0.00";
                    this.txtneva.Text = "0.00";
                    this.DataGridView3.Rows.Clear();
                    this.DataGridView4.Rows.Clear();
                    this.DataGridView5.Rows.Clear();
                    this.DataGridView6.Rows.Clear();
                    this.DataGridView5Jama.Rows.Clear();
                    this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                    if (!this.chkdate.Checked & !this.CheckBox1.Checked & !this.CheckBox3.Checked)
                    {
                        this.match_and_Session();
                        this.Jama_Total();
                        this.Neva_Total();
                        this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    else if (this.chkdate.Checked & !this.CheckBox1.Checked & !this.CheckBox3.Checked)
                    {
                        DateTime dateTime = Conversions.ToDate(this.DTPicker1.Text);
                        DateTime dateTime2 = Conversions.ToDate(this.DTPicker2.Text);
                        string text = dateTime.ToString("yyyy-MM-dd");
                        string text2 = dateTime2.ToString("yyyy-MM-dd");
                        int num = 0;
                        int num2 = this.DataGridView1.Rows.Count - 1;
                        for (int i = num; i <= num2; i++)
                        {
                            //if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(this.DataGridView1.Rows[i].Cells[2].Value, this.DTPicker1.Text, false), Operators.CompareObjectLessEqual(this.DataGridView1.Rows[i].Cells[2].Value, this.DTPicker2.Text, false))))							
                            if (Conversions.ToDate(this.DataGridView1.Rows[i].Cells[2].Value) >= dateTime && Conversions.ToDate(this.DataGridView1.Rows[i].Cells[2].Value) <= dateTime2)
                            {
                                this.DataGridView1.Rows[i].Cells[0].Value = true;
                            }
                            else
                            {
                                this.DataGridView1.Rows[i].Cells[0].Value = false;
                            }
                        }
                        int num3 = 0;
                        int num4 = this.DataGridView2.Rows.Count - 1;
                        for (int j = num3; j <= num4; j++)
                        {
                            //if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(this.DataGridView2.Rows[j].Cells[3].Value, this.DTPicker1.Text, false), Operators.CompareObjectLessEqual(this.DataGridView2.Rows[j].Cells[3].Value, this.DTPicker2.Text, false))))
                            if (Conversions.ToDate(this.DataGridView2.Rows[j].Cells[3].Value) >= dateTime && Conversions.ToDate(this.DataGridView2.Rows[j].Cells[3].Value) <= dateTime2)
                            {
                                this.DataGridView2.Rows[j].Cells[0].Value = true;
                            }
                            else
                            {
                                this.DataGridView2.Rows[j].Cells[0].Value = false;
                            }
                        }
                        TextBox textBox = new TextBox();
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText = string.Concat(new string[]
                        {
                            "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, SUM(tns_Amount) AS Expr1, Trans.tns_MatchID, Trans.tns_dt FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_Party) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, Trans.tns_MatchID, Trans.tns_dt HAVING (Trans.tns_MatchID <> 0) AND (Trans.tns_dt >=#",
                            text.ToString(),
                            "#) AND (Trans.tns_dt <=#",
                            text2.ToString(),
                            "#)"
                        });
                        OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                        while (oleDbDataReader.Read())
                        {
                            int index = this.DataGridView5Jama.Rows.Add();
                            this.DataGridView5Jama.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                            this.DataGridView5Jama.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]);

                            Module1.DtMatch.Rows.Add(new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader["AParty"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader["TParty"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])
                            });
                        }
                        cmdText = "SELECT PartyName, Id FROM PartyMaster ORDER BY PartyName";
                        oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                        oleDbDataReader = oleDbCommand.ExecuteReader();
                        double num8 = 0;
                        double num9 = 0;
                        while (oleDbDataReader.Read())
                        {
                            double num5 = 0.0;
                            string left = "";
                            for (int k = 0; k <= this.DataGridView5Jama.Rows.Count - 1; k++)
                            {
                                unchecked
                                {
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView5Jama.Rows[k].Cells[0].Value, oleDbDataReader["PartyName"], false))
                                    {
                                        left = "1";
                                        num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5Jama.Rows[k].Cells[1].Value));
                                    }
                                }
                            }
                            unchecked
                            {
                                if (Operators.CompareString(left, "1", false) == 0)
                                {
                                    if (num5 < 0.0)
                                    {
                                        int index2 = this.DataGridView6.Rows.Add();
                                        this.DataGridView6.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                        this.DataGridView6.Rows[index2].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), Module1.decimalnumberformat);
                                        num8 += Convert.ToDouble(num5);
                                    }
                                    else
                                    {
                                        int index3 = this.DataGridView5.Rows.Add();
                                        this.DataGridView5.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                        this.DataGridView5.Rows[index3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), Module1.decimalnumberformat);
                                        num9 += Convert.ToDouble(num5);
                                    }
                                }
                                left = "0";
                            }
                        }
                        this.Jama_Total();
                        this.Neva_Total();
                        this.txtjuma.Text = Module1.SetNumFormat(Conversion.Val(num9), Module1.decimalnumberformat);
                        this.txtneva.Text = Module1.SetNumFormat(Conversion.Val(num8), Module1.decimalnumberformat);
                        this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    else if (this.CheckBox1.Checked)
                    {
                        DateTime dateTime3 = Conversions.ToDate(this.DTPicker1.Text);
                        DateTime dateTime4 = Conversions.ToDate(this.DTPicker2.Text);
                        string text3 = dateTime3.ToString("yyyy-MM-dd");
                        string text4 = dateTime4.ToString("yyyy-MM-dd");

                        for (int l = 0; l <= this.DataGridView1.Rows.Count - 1; l++)
                        {
                            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(this.DataGridView1.Rows[l].Cells[2].Value, this.DTPicker1.Text, false), Operators.CompareObjectLessEqual(this.DataGridView1.Rows[l].Cells[2].Value, this.DTPicker2.Text, false))))
                            {
                                this.DataGridView1.Rows[l].Cells[0].Value = true;
                            }
                            else
                            {
                                this.DataGridView1.Rows[l].Cells[0].Value = false;
                            }
                        }
                        TextBox textBox2 = new TextBox();
                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText2 = string.Concat(new string[]
                        {
                            "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, SUM(Trans.tns_Amount) AS Expr1, Trans.tns_MatchID, Trans.tns_dt FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_party) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, Trans.tns_MatchID, Trans.tns_dt, Trans.tns_Sessionid HAVING (Trans.tns_dt >=#",
                            text3.ToString(),
                            "#) AND (Trans.tns_dt <=#",
                            text4.ToString(),
                            "#) AND (Trans.tns_MatchID <> 0) AND (Trans.tns_Sessionid = 0)"
                        });
                        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        OleDbDataReader oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        while (oleDbDataReader2.Read())
                        {
                            int index4 = this.DataGridView5Jama.Rows.Add();
                            this.DataGridView5Jama.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["PartyName"]);
                            this.DataGridView5Jama.Rows[index4].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"]);

                            Module1.DtMatch.Rows.Add(new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader2["PartyName"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader2["AParty"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader2["TParty"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader2["Expr1"])
                            });
                        }
                        cmdText2 = "SELECT PartyName, Id FROM PartyMaster ORDER BY PartyName";
                        oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                        oleDbDataReader2 = oleDbCommand2.ExecuteReader();
                        double num15 = 0;
                        double num16 = 0;
                        while (oleDbDataReader2.Read())
                        {
                            double num12 = 0.0;

                            string left2 = "";
                            for (int m = 0; m <= this.DataGridView5Jama.Rows.Count - 1; m++)
                            {
                                unchecked
                                {
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView5Jama.Rows[m].Cells[0].Value, oleDbDataReader2["PartyName"], false))
                                    {
                                        left2 = "1";
                                        num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5Jama.Rows[m].Cells[1].Value));
                                    }
                                }
                            }
                            unchecked
                            {
                                if (Operators.CompareString(left2, "1", false) == 0)
                                {
                                    if (num12 < 0.0)
                                    {
                                        int index5 = this.DataGridView6.Rows.Add();
                                        this.DataGridView6.Rows[index5].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["PartyName"]);
                                        this.DataGridView6.Rows[index5].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num12), Module1.decimalnumberformat);
                                        num15 += Convert.ToDouble(num12);
                                    }
                                    else
                                    {
                                        int index6 = this.DataGridView5.Rows.Add();
                                        this.DataGridView5.Rows[index6].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["PartyName"]);
                                        this.DataGridView5.Rows[index6].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num12), Module1.decimalnumberformat);
                                        num16 += Convert.ToDouble(num12);
                                    }
                                }
                                left2 = "0";
                            }
                        }
                        this.Jama_Total();
                        this.Neva_Total();
                        this.txtjuma.Text = Module1.SetNumFormat(Conversion.Val(num16), Module1.decimalnumberformat);
                        this.txtneva.Text = Module1.SetNumFormat(Conversion.Val(num15), Module1.decimalnumberformat);
                        this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    else if (this.CheckBox3.Checked)
                    {
                        DateTime dateTime5 = Conversions.ToDate(this.DTPicker1.Text);
                        DateTime dateTime6 = Conversions.ToDate(this.DTPicker2.Text);
                        string text5 = dateTime5.ToString("yyyy-MM-dd");
                        string text6 = dateTime6.ToString("yyyy-MM-dd");

                        for (int n = 0; n <= this.DataGridView2.Rows.Count - 1; n++)
                        {
                            if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(this.DataGridView2.Rows[n].Cells[3].Value, this.DTPicker1.Text, false), Operators.CompareObjectLessEqual(this.DataGridView2.Rows[n].Cells[3].Value, this.DTPicker2.Text, false))))
                            {
                                this.DataGridView2.Rows[n].Cells[0].Value = true;
                            }
                            else
                            {
                                this.DataGridView2.Rows[n].Cells[0].Value = false;
                            }
                        }

                        if (Module1.conn.State == ConnectionState.Closed)
                        {
                            Module1.conn.Open();
                        }
                        string cmdText3 = string.Concat(new string[]
                        {
                            "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, SUM(Trans.tns_Amount) AS Expr1, Trans.tns_dt, Trans.tns_Type FROM (PartyMaster INNER JOIN  Trans ON PartyMaster.PartyName = Trans.tns_party) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, Trans.tns_dt, Trans.tns_Type HAVING (Trans.tns_dt >=#",
                            text5.ToString(),
                            "#) AND (Trans.tns_dt <=#",
                            text6.ToString(),
                            "#) AND (Trans.tns_Type = 'Session')"
                        });
                        OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                        OleDbDataReader oleDbDataReader3 = oleDbCommand3.ExecuteReader();
                        while (oleDbDataReader3.Read())
                        {
                            int index7 = this.DataGridView5Jama.Rows.Add();
                            this.DataGridView5Jama.Rows[index7].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader3["PartyName"]);
                            this.DataGridView5Jama.Rows[index7].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader3["Expr1"]);

                            Module1.DtMatch.Rows.Add(new object[]
                            {
                                RuntimeHelpers.GetObjectValue(oleDbDataReader3["PartyName"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader3["AParty"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader3["TParty"]),
                                RuntimeHelpers.GetObjectValue(oleDbDataReader3["Expr1"])
                            });
                        }
                        cmdText3 = "SELECT PartyName, Id FROM PartyMaster ORDER BY PartyName";
                        oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                        oleDbDataReader3 = oleDbCommand3.ExecuteReader();
                        double num23 = 0;
                        double num24 = 0;
                        while (oleDbDataReader3.Read())
                        {
                            double num19 = 0.0;
                            string left3 = "";
                            for (int num22 = 0; num22 <= this.DataGridView5Jama.Rows.Count - 1; num22++)
                            {
                                unchecked
                                {
                                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView5Jama.Rows[num22].Cells[0].Value, oleDbDataReader3["PartyName"], false))
                                    {
                                        left3 = "1";
                                        num19 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5Jama.Rows[num22].Cells[1].Value));
                                    }
                                }
                            }
                            unchecked
                            {
                                if (Operators.CompareString(left3, "1", false) == 0)
                                {
                                    if (num19 < 0.0)
                                    {
                                        int index8 = this.DataGridView6.Rows.Add();
                                        this.DataGridView6.Rows[index8].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader3["PartyName"]);
                                        this.DataGridView6.Rows[index8].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num19), Module1.decimalnumberformat);
                                        num23 += Convert.ToDouble(num19);
                                    }
                                    else
                                    {
                                        int index9 = this.DataGridView5.Rows.Add();
                                        this.DataGridView5.Rows[index9].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader3["PartyName"]);
                                        this.DataGridView5.Rows[index9].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num19), Module1.decimalnumberformat);
                                        num24 += Convert.ToDouble(num19);
                                    }
                                }
                                left3 = "0";
                            }
                        }
                        this.Jama_Total();
                        this.Neva_Total();
                        this.txtjuma.Text = Module1.SetNumFormat(Conversion.Val(num24), Module1.decimalnumberformat);
                        this.txtneva.Text = Module1.SetNumFormat(Conversion.Val(num23), Module1.decimalnumberformat);
                        this.DataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        this.DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        public void Match_IDS()
        {
            try
            {
                if (Operators.CompareString(this.txtmatchID.Text, null, false) != 0)
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    this.ComboBox1.Items.Clear();
                    string cmdText = string.Concat(new string[]
                    {
                        "select * from Trans Where MatchID=",
                        this.txtmatchID.Text,
                        "and Sessionid=",
                        this.txtsessionID.Text,
                        " order by Party"
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        this.ComboBox1.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Party"]));
                    }
                    short num = 0;
                    short num2 = checked((short)(this.ComboBox1.Items.Count - 2));
                    for (int num3 = num; num3 <= num2; num3 += 1)
                    {
                        short num4;
                        int num5;
                        checked
                        {
                            num4 = (short)(this.ComboBox1.Items.Count - 1);
                            num5 = num3 + 1;
                        }
                        for (short num6 = num4; num6 >= num5; num6 += -1)
                        {
                            if (Operators.CompareString(this.ComboBox1.Items[(int)num3].ToString(), this.ComboBox1.Items[(int)num6].ToString(), false) == 0)
                            {
                                this.ComboBox1.Items.RemoveAt((int)num6);
                            }
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

        private void DataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridView2.Rows.Count != 0)
            {
                try
                {
                    this.txtsessionID.Text = this.DataGridView2.CurrentRow.Cells[1].Value.ToString();
                    this.txtmatchID.Text = this.DataGridView2.CurrentRow.Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    DataSet dataSet = new DataSet();
                    DataTable dataTable = new DataTable("DataTable1");
                    dataTable.Columns.Add("Column1");
                    dataTable.Columns.Add("Column2");
                    dataTable.Columns.Add("Column3");
                    dataTable.Columns.Add("Column4");
                    dataTable.Columns.Add("Jama");
                    DataTable dataTable2 = new DataTable("DataTable2");
                    dataTable2.Columns.Add("Column1");
                    dataTable2.Columns.Add("Column2");
                    dataTable2.Columns.Add("Column3");
                    dataTable2.Columns.Add("Column4");
                    dataTable2.Columns.Add("Neva");
                    DataTable dataTable3 = new DataTable("DataTable7");
                    dataTable3.Columns.Add("Column1");
                    dataTable3.Columns.Add("Column2");
                    try
                    {
                        foreach (object obj in ((IEnumerable)this.DataGridView4.Rows))
                        {
                            DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                            dataTable.Rows.Add(new object[]
                            {
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[4].Value),
                                this.Label7.Text + "                            " + this.txtjuma.Text
                            });
                        }
                    }
                    finally
                    {
                    }
                    dataSet.Tables.Add(dataTable);

                    try
                    {
                        foreach (object obj2 in ((IEnumerable)this.DataGridView3.Rows))
                        {
                            DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                            dataTable2.Rows.Add(new object[]
                            {
                                RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[0].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[1].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[3].Value),
                                RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[4].Value),
                                this.Label9.Text + "                            " + this.txtneva.Text
                            });
                        }
                    }
                    finally
                    {
                    }
                    dataSet.Tables.Add(dataTable2);

                    dataTable3.Rows.Add(new object[]
                    {
                        "MATCH :-"
                    });
                    int num = 0;
                    int num2 = this.DataGridView1.RowCount - 1;
                    for (int i = num; i <= num2; i++)
                    {
                        if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[1].Value, null, false))
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, true, false))
                            {
                                dataTable3.Rows.Add(new object[]
                                {
                                    Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DataGridView1.Rows[i].Cells[3].Value, "  =   "), this.DataGridView1.Rows[i].Cells[5].Value), ", ")
                                });
                            }
                        }
                    }
                    //dataTable3.Rows.Add(new object[0]);
                    //dataTable3.Rows.Add(new object[0]);
                    //dataTable3.Rows.Add(new object[0]);
                    //dataTable3.Rows.Add(new object[]
                    //{
                    //    "SESSION :-"
                    //});
                    //int num3 = 0;
                    //int num4 = this.DataGridView2.RowCount - 1;
                    //for (int j = num3; j <= num4; j++)
                    //{
                    //    if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[j].Cells[1].Value, null, false))
                    //    {
                    //        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[j].Cells[0].Value, true, false))
                    //        {
                    //            dataTable3.Rows.Add(new object[]
                    //            {
                    //                Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DataGridView2.Rows[j].Cells[4].Value, " =    "), this.DataGridView2.Rows[j].Cells[5].Value), ", ")
                    //            });
                    //        }
                    //    }
                    //}
                    dataSet.Tables.Add(dataTable3);

                    print_view printView = new print_view();
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(Application.StartupPath + "\\RPT\\C_Report.rpt");
                    reportDocument.SetDataSource(dataSet);
                    printView.crystalReportViewer1.ReportSource = reportDocument;
                    printView.ShowDialog();
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void match_and_Session()
        {
            checked
            {
                try
                {
                    this.DataGridView5.Rows.Clear();
                    this.DataGridView6.Rows.Clear();
                    this.DataGridView4.Rows.Clear();
                    this.DataGridView3.Rows.Clear();
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    string cmdText;
                    OleDbCommand oleDbCommand;
                    OleDbDataReader oleDbDataReader;
                    for (int i = 0; i <= this.DataGridView1.RowCount - 1; i++)
                    {
                        if (!Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[1].Value, null, false))
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[i].Cells[0].Value, true, false))
                            {
                                cmdText = "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, SUM(tns_Amount) AS Expr1, Trans.tns_MatchID, Trans.tns_Sessionid FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_Party) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, Trans.tns_MatchID, Trans.tns_Sessionid HAVING (Trans.tns_MatchID = " + this.DataGridView1.Rows[i].Cells[1].Value.ToString() + ") AND (Trans.tns_Sessionid = 0)";
                                oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                                oleDbDataReader = oleDbCommand.ExecuteReader();
                                while (oleDbDataReader.Read())
                                {
                                    int index = this.DataGridView5Jama.Rows.Add();
                                    this.DataGridView5Jama.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                    this.DataGridView5Jama.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]);

                                    Module1.DtMatch.Rows.Add(new object[]
                                    {
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]),
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["AParty"]),
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["TParty"]),
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])
                                    });
                                }
                            }
                        }
                    }

                    for (int j = 0; j <= this.DataGridView2.RowCount - 1; j++)
                    {
                        if (!Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[j].Cells[1].Value, null, false))
                        {
                            if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[j].Cells[0].Value, true, false))
                            {
                                cmdText = string.Concat(new string[]
                                {
                                    "SELECT PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, SUM(tns_Amount) AS Expr1, Trans.tns_MatchID, Trans.tns_Sessionid FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_Party) GROUP BY PartyMaster.PartyName, PartyMaster.AParty, PartyMaster.TParty, Trans.tns_MatchID, Trans.tns_Sessionid HAVING (Trans.tns_MatchID = ",
                                    this.DataGridView2.Rows[j].Cells[2].Value.ToString(),
                                    ") AND (Trans.tns_Sessionid = ",
                                    this.DataGridView2.Rows[j].Cells[1].Value.ToString(),
                                    ")"
                                });
                                oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                                oleDbDataReader = oleDbCommand.ExecuteReader();
                                while (oleDbDataReader.Read())
                                {
                                    int index2 = this.DataGridView5Jama.Rows.Add();
                                    this.DataGridView5Jama.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                    this.DataGridView5Jama.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"]);

                                    Module1.DtMatch.Rows.Add(new object[]
                                    {
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]),
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["AParty"]),
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["TParty"]),
                                        RuntimeHelpers.GetObjectValue(oleDbDataReader["Expr1"])
                                    });
                                }
                            }
                        }
                    }
                    cmdText = "SELECT PartyName, Id FROM PartyMaster ORDER BY PartyName";
                    oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    oleDbDataReader = oleDbCommand.ExecuteReader();
                    double num8 = 0;
                    double num9 = 0;
                    while (oleDbDataReader.Read())
                    {
                        double num5 = 0.0;

                        string left = "";
                        for (int k = 0; k <= this.DataGridView5Jama.Rows.Count - 1; k++)
                        {
                            unchecked
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView5Jama.Rows[k].Cells[0].Value, oleDbDataReader["PartyName"], false))
                                {
                                    left = "1";
                                    num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5Jama.Rows[k].Cells[1].Value));
                                }
                            }
                        }
                        unchecked
                        {
                            if (Operators.CompareString(left, "1", false) == 0)
                            {
                                if (num5 < 0.0)
                                {
                                    int index3 = this.DataGridView6.Rows.Add();
                                    this.DataGridView6.Rows[index3].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                    this.DataGridView6.Rows[index3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), Module1.decimalnumberformat);
                                    num8 += Convert.ToDouble(num5);
                                }
                                else
                                {
                                    int index4 = this.DataGridView5.Rows.Add();
                                    this.DataGridView5.Rows[index4].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                                    this.DataGridView5.Rows[index4].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num5), Module1.decimalnumberformat);
                                    num9 += Convert.ToDouble(num5);
                                }
                            }
                            left = "0";
                        }
                    }
                    this.txtjuma.Text = Module1.SetNumFormat(Conversion.Val(num9), Module1.decimalnumberformat);
                    this.txtneva.Text = Module1.SetNumFormat(Conversion.Val(num8), Module1.decimalnumberformat);
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

        public void Jama_Total()
        {
            checked
            {
                try
                {
                    int num3 = 0;
                    for (int i = 0; i <= this.DataGridView5.RowCount - 1; i++)
                    {
                        num3 = (int)Math.Round(Convert.ToDouble(i));
                    }
                    int num4 = (int)Math.Round(Conversion.Val(num3) / 2.0);
                    num4 += 2;

                    for (int j = 0; j <= this.DataGridView5.RowCount - 1; j++)
                    {
                        if (j < num4)
                        {
                            int index = this.DataGridView4.Rows.Add();
                            this.DataGridView4.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[j].Cells[0].Value);
                            this.DataGridView4.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[j].Cells[1].Value)), Module1.decimalnumberformat);
                        }
                        else
                        {
                            for (int k = 0; k <= this.DataGridView5.RowCount - 1; k++)
                            {
                                this.DataGridView4.Rows[k].Cells[3].Value = this.DataGridView5.Rows[num4].Cells[0].Value.ToString();
                                this.DataGridView4.Rows[k].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[num4].Cells[1].Value)), Module1.decimalnumberformat);
                                num4 = (int)Math.Round(unchecked((double)num4 + Convert.ToDouble(1)));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
            }
        }

        public void Neva_Total()
        {
            checked
            {
                try
                {
                    int num3 = 0;
                    for (int i = 0; i <= this.DataGridView6.RowCount - 1; i++)
                    {
                        num3 = (int)Math.Round(Convert.ToDouble(i));
                    }
                    int num4 = (int)Math.Round(Conversion.Val(num3) / 2.0);
                    num4 += 2;

                    for (int j = 0; j <= this.DataGridView6.RowCount - 1; j++)
                    {
                        if (j < num4)
                        {
                            int index = this.DataGridView3.Rows.Add();
                            this.DataGridView3.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[j].Cells[0].Value);
                            this.DataGridView3.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[j].Cells[1].Value)), Module1.decimalnumberformat);
                        }
                        else
                        {
                            for (int k = 0; k <= this.DataGridView3.RowCount - 1; k++)
                            {
                                this.DataGridView3.Rows[k].Cells[3].Value = this.DataGridView6.Rows[num4].Cells[0].Value.ToString();
                                this.DataGridView3.Rows[k].Cells[4].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[num4].Cells[1].Value)), Module1.decimalnumberformat);
                                num4 = (int)Math.Round(unchecked((double)num4 + Convert.ToDouble(1)));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count != 0)
            {
                checked
                {
                    try
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView1.CurrentRow.Cells[0].Value, true, false))
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = false;
                            for (int i = 0; i <= this.DataGridView2.Rows.Count - 1; i++)
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[i].Cells[2].Value, this.DataGridView1.CurrentRow.Cells[1].Value, false))
                                {
                                    this.DataGridView2.Rows[i].Cells[0].Value = false;
                                }
                            }
                        }
                        else
                        {
                            this.DataGridView1.CurrentRow.Cells[0].Value = true;
                            for (int j = 0; j <= this.DataGridView2.Rows.Count - 1; j++)
                            {
                                if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[j].Cells[2].Value, this.DataGridView1.CurrentRow.Cells[1].Value, false))
                                {
                                    this.DataGridView2.Rows[j].Cells[0].Value = true;
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
        }

        private void DataGridView2_Click(object sender, EventArgs e)
        {
            if (DataGridView2.Rows.Count != 0)
            {
                try
                {
                    if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.CurrentRow.Cells[0].Value, true, false))
                    {
                        this.DataGridView2.CurrentRow.Cells[0].Value = false;
                    }
                    else
                    {
                        this.DataGridView2.CurrentRow.Cells[0].Value = true;
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            try
            {
                Agent_Connect agent_Connect = new Agent_Connect();
                agent_Connect.ShowDialog();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }
    }
}
