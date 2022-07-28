using System;
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
    // Token: 0x020000CB RID: 203
    //[DesignerGenerated]
    public partial class Toss_Match : Form
    {
        public bool ismodify = false;

        // Token: 0x06002327 RID: 8999 RVA: 0x003BAAE0 File Offset: 0x003B8EE0
        public Toss_Match()
        {
            this.InitializeComponent();
        }

        private void Toss_Match_Activated(object sender, EventArgs e)
        {
            if (Operators.CompareString(this.testnu.Text, "", false) == 0)
            {
                MessageBox.Show("Record No");
            }
            else
            {
                this.all_lode();
            }
            this.sr_NoAuto();
            this.testnu.Hide();
            this.listboxlode();
            this.lod_newPartyname();
            this.hidetextbox();
            this.GenerateGrid();
            this.WindowState = FormWindowState.Maximized;

            checked
            {
                this.TOTAL_ALL();
                this.netK();
                this.netL();
                this.Net_Postion();
                this.Colore();
                this.Decleard();

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


        // Token: 0x06002416 RID: 9238 RVA: 0x003C0AF0 File Offset: 0x003BEEF0
        private void Toss_Match_Load(object sender, EventArgs e)
        {
            try
            {
                if (Module1.isratefirst == true)
                {
                    txtamount.Location = new Point(83, 29);
                    txtrate.Location = new Point(7, 29);

                    Label12.Text = "Amount";
                    Label11.Text = "Rate";

                    txtamount.TabIndex = 1;
                    txtrate.TabIndex = 0;
                }

                this.txtnu.Text = Module1.decimalnumberformat;
                //this.Label1.Text = Conversions.ToString(this.txtamount.Focus());
                this.DataGridView6.Rows.Add();
                this.DataGridView6.Rows.Add();
                this.DataGridView6.Rows.Add();
                this.DataGridView6.Rows.Add();
                this.Button5.Hide();
                this.Button1.Hide();
                this.TextBox6.Hide();
                this.MaximizeBox = false;
                //this.WindowState = FormWindowState.Normal;

                Size size = new Size(630, 659);
                this.Size = size;
                int x = 0;
                int y = 0;
                //Solve Error
                //int x = (-(((Screen.PrimaryScreen.WorkingArea.Width == 0) > false) ? 1 : 0)) ? 1 : 0;
                //int y = (-(((Screen.PrimaryScreen.WorkingArea.Height == 0) > false) ? 1 : 0)) ? 1 : 0;
                Point location = new Point(x, y);
                this.Location = location;


                if (Operators.CompareString(this.testnu.Text, "", false) == 0)
                {
                    MessageBox.Show("Record No");
                }
                else
                {
                    this.all_lode();
                }
                this.sr_NoAuto();
                this.testnu.Hide();
                this.listboxlode();
                this.lod_newPartyname();
                this.hidetextbox();
                this.GenerateGrid();


                checked
                {
                    this.TOTAL_ALL();
                    this.netK();
                    this.netL();
                    this.Net_Postion();
                    this.Colore();
                    this.Decleard();

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
        }

        private void GenerateGrid()
        {
            try
            {
                //this.DataGridView3.Rows.Clear();
                //this.DataGridView3.Rows.Add(new object[]
                //{
                //		""
                //});

                //this.DataGridView3.ClearSelection();

                this.DataGridView2.Rows.Clear();
                if (Module1.isntposition == true)
                {
                    this.DataGridView2.Rows.Add(new object[]
                    {
                    "Net Total"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                    ""
                    });
                    this.DataGridView2.Rows.Add(new object[]
                {
                    "Regular"
                });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                    "Booky"
                    });

                    this.DataGridView2.Rows[1].Height = 5;
                    this.DataGridView2.Rows[1].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    this.DataGridView2.Rows.Add(new object[]
                {
                    "Regular"
                });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                    "Booky"
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                    ""
                    });
                    this.DataGridView2.Rows.Add(new object[]
                    {
                    "Net Total"
                    });

                    this.DataGridView2.Rows[2].Height = 5;
                    this.DataGridView2.Rows[2].DefaultCellStyle.BackColor = Color.Gray;
                }
                this.DataGridView2.ClearSelection();

                int num = 1;
                do
                {
                    if (Module1.isntposition == true)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[0].Cells[num].Value, "", false))
                        {
                            this.DataGridView2.Rows[0].Cells[num].Value = "0" + this.txtnu.Text;
                        }
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[2].Cells[num].Value, "", false))
                        {
                            this.DataGridView2.Rows[2].Cells[num].Value = "0" + this.txtnu.Text;
                        }
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[3].Cells[num].Value, "", false))
                        {
                            this.DataGridView2.Rows[3].Cells[num].Value = "0" + this.txtnu.Text;
                        }
                        num++;
                    }
                    else
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[3].Cells[num].Value, "", false))
                        {
                            this.DataGridView2.Rows[3].Cells[num].Value = "0" + this.txtnu.Text;
                        }
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[0].Cells[num].Value, "", false))
                        {
                            this.DataGridView2.Rows[0].Cells[num].Value = "0" + this.txtnu.Text;
                        }
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[1].Cells[num].Value, "", false))
                        {
                            this.DataGridView2.Rows[1].Cells[num].Value = "0" + this.txtnu.Text;
                        }
                        num++;
                    }
                }
                while (num <= 4);

                if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, "", false) == 0)
                {
                    this.DataGridView2.Columns[3].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, "", false) == 0)
                {
                    this.DataGridView2.Columns[4].Visible = false;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002417 RID: 9239 RVA: 0x003C10A8 File Offset: 0x003BF4A8
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.CheckBox3.Checked)
                {
                    this.Timer1.Enabled = true;
                }
                else if (!this.CheckBox3.Checked)
                {
                    this.Timer1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002418 RID: 9240 RVA: 0x003C10E0 File Offset: 0x003BF4E0
        public void all_lode()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "Select* from Newmatch where Sr_No=" + this.testnu.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.Label1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", oleDbDataReader[4]), " )"), "  "), oleDbDataReader[2]), " "), "  VS  "), "  "), oleDbDataReader[3]), " "), oleDbDataReader[1]));
                    this.DataGridView2.Columns[1].HeaderText = Conversions.ToString(oleDbDataReader[5]);
                    this.DataGridView2.Columns[2].HeaderText = Conversions.ToString(oleDbDataReader[6]);
                    this.DataGridView2.Columns[3].HeaderText = Conversions.ToString(oleDbDataReader[7]);
                    this.DataGridView2.Columns[4].HeaderText = Conversions.ToString(oleDbDataReader[8]);
                    this.DataGridView3.Columns[0].HeaderText = Conversions.ToString(oleDbDataReader[5]);
                    this.DataGridView3.Columns[1].HeaderText = Conversions.ToString(oleDbDataReader[6]);
                    this.DataGridView3.Columns[2].HeaderText = Conversions.ToString(oleDbDataReader[7]);
                    this.DataGridView3.Columns[3].HeaderText = Conversions.ToString(oleDbDataReader[8]);
                    this.DataGridView3.Columns[4].HeaderText = Conversions.ToString(oleDbDataReader[9]);
                    this.DataGridView1.Columns[6].HeaderText = Conversions.ToString(oleDbDataReader[5]);
                    this.DataGridView1.Columns[7].HeaderText = Conversions.ToString(oleDbDataReader[6]);
                    this.DataGridView1.Columns[8].HeaderText = Conversions.ToString(oleDbDataReader[7]);
                    this.DataGridView1.Columns[9].HeaderText = Conversions.ToString(oleDbDataReader[8]);
                    this.DataGridView6.Rows[0].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                    this.DataGridView6.Rows[1].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    this.DataGridView6.Rows[2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    this.DataGridView6.Rows[3].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
                    this.cmbteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[5]));
                    this.cmbteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[6]));
                    this.cmbteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[7]));
                    this.cmbteam.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader[8]));
                    if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                    {
                        this.DataGridView1.Columns[8].Visible = false;
                    }
                    if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                    {
                        this.DataGridView1.Columns[9].Visible = false;
                    }
                }
                Module1.conn.Close();
                if (Operators.CompareString(this.DataGridView3.Columns[2].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[2].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView3.Columns[3].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[3].Visible = false;
                }
                if (Operators.CompareString(this.DataGridView3.Columns[4].HeaderText, null, false) == 0)
                {
                    this.DataGridView3.Columns[4].Visible = false;
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

        // Token: 0x0600241A RID: 9242 RVA: 0x003C16F0 File Offset: 0x003BFAF0
        public void sr_NoAuto()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(m_eid)from MatchTrans1 where m_id=" + this.testnu.Text;
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        this.txtsrno.Text = "1";
                    }
                    else
                    {
                        int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        num++;
                        this.txtsrno.Text = Conversions.ToString(num);
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

        // Token: 0x0600241B RID: 9243 RVA: 0x003C17C0 File Offset: 0x003BFBC0
        public void listboxlode()
        {
            try
            {
                this.DataGridView1.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select* from MatchTrans1 where m_id=" + this.testnu.Text + " Order By m_eid desc";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    int num = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[num].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[2]);

                    if (Module1.isratefirst == true)
                    {
                        this.DataGridView1.Columns[2].HeaderText = "Amount";
                        this.DataGridView1.Rows[num].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
                        this.DataGridView1.Columns[2].DefaultCellStyle.Format = Module1.NumFormat;

                        this.DataGridView1.Columns[1].HeaderText = "Rate";
                        this.DataGridView1.Rows[num].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                        this.DataGridView1.Columns[1].DefaultCellStyle.Format = "0.0000";
                    }
                    else
                    {
                        this.DataGridView1.Rows[num].Cells[1].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[4]);
                        this.DataGridView1.Columns[1].DefaultCellStyle.Format = Module1.NumFormat;
                        this.DataGridView1.Rows[num].Cells[2].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[5]);
                        this.DataGridView1.Columns[2].DefaultCellStyle.Format = "0.0000";
                    }

                    this.DataGridView1.Rows[num].Cells[3].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[6]);
                    this.DataGridView1.Rows[num].Cells[4].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[7]);
                    this.DataGridView1.Rows[num].Cells[5].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[8]);
                    this.DataGridView1.Rows[num].Cells[6].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[12]);
                    this.DataGridView1.Rows[num].Cells[7].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[13]);
                    if (!this.DataGridView1.Columns[8].Visible)
                    {
                        this.DataGridView1.Rows[num].Cells[8].Value = "";
                    }
                    else
                    {
                        this.DataGridView1.Rows[num].Cells[8].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[14]);
                    }
                    if (!this.DataGridView1.Columns[9].Visible)
                    {
                        this.DataGridView1.Rows[num].Cells[9].Value = "";
                    }
                    else
                    {
                        this.DataGridView1.Rows[num].Cells[9].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[15]);
                    }
                    this.DataGridView1.Rows[num].Cells[10].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[11]);
                    this.DataGridView1.Rows[num].Cells[11].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[3]);
                    this.DataGridView1.Rows[num].Cells[12].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[10]);
                    this.DataGridView1.Rows[num].Cells[13].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader[17]);

                    this.DataGridView1.Rows[num].Cells[14].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["modify_time"]);
                    this.DataGridView1.Rows[num].Cells[15].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["modify_date"]);

                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[17], "1", false))
                    {
                        this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Red;
                        //this.DataGridView1.Rows[num].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                    }
                    else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[16], "1", false))
                    {
                        this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Blue;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(oleDbDataReader[19], "1", false))
                    {
                        this.DataGridView1.Rows[num].DefaultCellStyle.ForeColor = Color.Lime;
                    }
                }
                Module1.conn.Close();

                this.DataGridView1.Columns[6].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[7].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[8].DefaultCellStyle.Format = Module1.NumFormat;
                this.DataGridView1.Columns[9].DefaultCellStyle.Format = Module1.NumFormat;
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

        // Token: 0x0600241C RID: 9244 RVA: 0x003C2698 File Offset: 0x003C0A98
        public void lod_newPartyname()
        {
            try
            {
                this.Cmboid.Items.Clear();
                this.txtpartiname.Items.Clear();
                this.cmbostus.Items.Clear();
                this.smatch.Items.Clear();
                this.amatch.Items.Clear();
                this.tmatch.Items.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select * from PartyMaster";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    this.Cmboid.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Id"]));
                    this.txtpartiname.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]));
                    this.cmbostus.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["Status"]));
                    this.smatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["SMatch"]));
                    this.amatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["AMatch"]));
                    this.tmatch.Items.Add(RuntimeHelpers.GetObjectValue(oleDbDataReader["TMatch"]));
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

        // Token: 0x0600241D RID: 9245 RVA: 0x003C2854 File Offset: 0x003C0C54
        public void hidetextbox()
        {
            try
            {
                this.TextBox4.Hide();
                this.TextBox5.Hide();
                this.Cmboid.Hide();
                this.PTextBox7.Hide();
                this.ATextBox5.Hide();
                this.STextBox4.Hide();
                this.txtR.Hide();
                this.txtD.Hide();
                this.txtB.Hide();
                this.Label2.Hide();
                this.Label24.Hide();
                this.txtind.Hide();
                this.txtsut.Hide();
                this.TextBox6.Hide();
                this.txtdate.Hide();
                this.txttime.Hide();
                this.txtsrno.Hide();
                this.txtpak.Hide();
                this.txtend.Hide();
                this.txtsut.Hide();
                this.Label22.Hide();
                this.Label23.Hide();
                this.Label24.Hide();
                this.cmbostus.Hide();

                this.subtotal.Hide();
                this.smatch.Hide();
                this.amatch.Hide();
                this.tmatch.Hide();
                this.id.Hide();
                this.txtdemo.Hide();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600241E RID: 9246 RVA: 0x003C29F0 File Offset: 0x003C0DF0
        public void TOTAL_ALL()
        {
            try
            {
                this.Regular_All_Tems();
                this.Regular_Total();
                this.Booky_All_Tems();
                this.Booky_Total();
                //this.Dummy_All_tems();
                //this.Dummy_Total();
                this.netK();
                this.netL();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600241F RID: 9247 RVA: 0x003C2A24 File Offset: 0x003C0E24
        public void netK()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[0].Cells[0].Value), "' and m_mode='K'  and m_checked=0"));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                {
                    double num = Convert.ToDouble(oleDbCommand.ExecuteScalar());
                    this.DataGridView6.Rows[0].Cells[1].Value = Module1.SetNumFormat(num, this.txtnu.Text);
                    string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[1].Cells[0].Value), "' and m_mode='K'  and m_checked=0"));
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
                    {
                        double num2 = Convert.ToDouble(oleDbCommand2.ExecuteScalar());
                        this.DataGridView6.Rows[1].Cells[1].Value = Module1.SetNumFormat(num2, this.txtnu.Text);
                    }
                    string cmdText3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[2].Cells[0].Value), "' and m_mode='K'  and m_checked=0"));
                    OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand3.ExecuteScalar())))
                    {
                        double num3 = Convert.ToDouble(oleDbCommand3.ExecuteScalar());
                        this.DataGridView6.Rows[2].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                    }
                    string cmdText4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[3].Cells[0].Value), "' and m_mode='K'  and m_checked=0"));
                    OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText4, Module1.conn);
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand4.ExecuteScalar())))
                    {
                        double num4 = Convert.ToDouble(oleDbCommand4.ExecuteScalar());
                        this.DataGridView6.Rows[3].Cells[1].Value = Module1.SetNumFormat(num4, this.txtnu.Text);
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

        // Token: 0x06002420 RID: 9248 RVA: 0x003C2D9C File Offset: 0x003C119C
        public void netL()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[0].Cells[0].Value), "' and m_mode='L'  and m_checked=0"));
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                {
                    double num = Convert.ToDouble(oleDbCommand.ExecuteScalar());
                    this.DataGridView6.Rows[0].Cells[2].Value = Module1.SetNumFormat(num, this.txtnu.Text);
                    string cmdText2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[1].Cells[0].Value), "' and m_mode='L'  and m_checked=0"));
                    OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand2.ExecuteScalar())))
                    {
                        double num2 = Convert.ToDouble(oleDbCommand2.ExecuteScalar());
                        this.DataGridView6.Rows[1].Cells[2].Value = Module1.SetNumFormat(num2, this.txtnu.Text);
                    }
                    string cmdText3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[2].Cells[0].Value), "' and m_mode='L'  and m_checked=0"));
                    OleDbCommand oleDbCommand3 = new OleDbCommand(cmdText3, Module1.conn);
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand3.ExecuteScalar())))
                    {
                        double num3 = Convert.ToDouble(oleDbCommand3.ExecuteScalar());
                        this.DataGridView6.Rows[2].Cells[2].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                    }
                    string cmdText4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Select sum(m_amt)from MatchTrans1 where m_id=" + this.testnu.Text + " and m_team='", this.DataGridView6.Rows[3].Cells[0].Value), "' and m_mode='L'  and m_checked=0"));
                    OleDbCommand oleDbCommand4 = new OleDbCommand(cmdText4, Module1.conn);
                    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand4.ExecuteScalar())))
                    {
                        double num4 = Convert.ToDouble(oleDbCommand4.ExecuteScalar());
                        this.DataGridView6.Rows[3].Cells[2].Value = Module1.SetNumFormat(num4, this.txtnu.Text);
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

        // Token: 0x06002421 RID: 9249 RVA: 0x003C3114 File Offset: 0x003C1514
        public void Net_Postion()
        {
            try
            {
                if (Module1.isntposition == true)
                {
                    this.DataGridView2.Rows[0].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[1].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[1].Value));
                    this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[1].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[2].Value));
                    this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[2].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[0].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[3].Value));
                    this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[3].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[0].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[2].Cells[4].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[4].Value));
                    this.DataGridView2.Rows[0].Cells[4].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[4].Value), this.txtnu.Text);
                }
                else
                {
                    this.DataGridView2.Rows[3].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[1].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[1].Value));
                    this.DataGridView2.Rows[3].Cells[1].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[1].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[3].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[2].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[2].Value));
                    this.DataGridView2.Rows[3].Cells[2].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[2].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[3].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[3].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[3].Value));
                    this.DataGridView2.Rows[3].Cells[3].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[3].Value), this.txtnu.Text);
                    this.DataGridView2.Rows[3].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[0].Cells[4].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[1].Cells[4].Value));
                    this.DataGridView2.Rows[3].Cells[4].Value = Module1.SetNumFormat(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[3].Cells[4].Value), this.txtnu.Text);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002422 RID: 9250 RVA: 0x003C39D4 File Offset: 0x003C1DD4
        public void Regular_All_Tems()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.Status, SUM(PartyMaster.SMatch) AS Expr5, SUM(PartyMaster.AMatch) AS Expr6, SUM(PartyMaster.TMatch) AS Expr7, MatchTrans1.m_id, MatchTrans1.m_eid, MatchTrans1.m_page, MatchTrans1.m_party, SUM(MatchTrans1.m_team1) AS Expr1,SUM(MatchTrans1.m_team2) AS Expr2, SUM(MatchTrans1.m_team3) AS Expr3, SUM(MatchTrans1.m_team4) AS Expr4, MatchTrans1.m_checked FROM (PartyMaster INNER JOIN MatchTrans1 ON PartyMaster.PartyName = MatchTrans1.m_party) GROUP BY PartyMaster.PartyName, PartyMaster.Status, MatchTrans1.m_id, MatchTrans1.m_eid, MatchTrans1.m_page, MatchTrans1.m_party, MatchTrans1.m_checked HAVING        (MatchTrans1.m_id = " + this.testnu.Text + ") AND (MatchTrans1.m_checked =0)";
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Status"], "Regular", false))
                    {
                        double num = Convert.ToDouble(oleDbDataReader["Expr5"]);
                        double num2 = Convert.ToDouble(oleDbDataReader["Expr6"]);
                        double num3 = Convert.ToDouble(oleDbDataReader["Expr7"]);
                        double num4 = Conversion.Val(num2) + Conversion.Val(num3);
                        this.Rtotal1 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                        this.Rtotal2 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                        this.Rtotal3 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                        this.Rtotal4 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                        int index = this.DataGridView5.Rows.Add();
                        double num5 = Conversion.Val(this.Rtotal1) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal1);
                        double num6 = Conversion.Val(this.Rtotal2) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal2);
                        double num7 = Conversion.Val(this.Rtotal3) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal3);
                        double num8 = Conversion.Val(this.Rtotal4) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal4);
                        double num10 = 0;
                        if (num5 < 0.0)
                        {
                            double num9 = Conversion.Val(num5) * Conversion.Val(num10) / 100;
                            double num11 = Conversion.Val(num5) + Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9);
                            double num12 = Conversion.Val(num11) * Conversion.Val(num) / 100 - Conversion.Val(num11);
                            double num13 = Conversion.Val(num12) * Conversion.Val(num4) / 100 - num12;
                            this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                        }
                        else
                        {
                            double num14 = Conversion.Val(num5) * Conversion.Val(num) / 100 - Conversion.Val(num5);
                            double num15 = Conversion.Val(num14) * Conversion.Val(num4) / 100 - num14;
                            this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
                        }
                        if (num6 < 0.0)
                        {
                            double num16 = Conversion.Val(num6) * Conversion.Val(num10) / 100;
                            double num17 = Conversion.Val(num6) + Conversion.Val(num16) - Conversion.Val(num16) - Conversion.Val(num16);
                            double num18 = Conversion.Val(num17) * Conversion.Val(num) / 100 - Conversion.Val(num17);
                            double num19 = Conversion.Val(num18) * Conversion.Val(num4) / 100 - num18;
                            this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19);
                        }
                        else
                        {
                            double num20 = Conversion.Val(num6) * Conversion.Val(num) / 100 - Conversion.Val(num6);
                            double num21 = Conversion.Val(num20) * Conversion.Val(num4) / 100 - num20;
                            this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num21) - Conversion.Val(num21) - Conversion.Val(num21);
                        }
                        if (num7 < 0.0)
                        {
                            double num22 = Conversion.Val(num7) * Conversion.Val(num10) / 100;
                            double num23 = Conversion.Val(num7) + Conversion.Val(num22) - Conversion.Val(num22) - Conversion.Val(num22);
                            double num24 = Conversion.Val(num23) * Conversion.Val(num) / 100 - Conversion.Val(num23);
                            double num25 = Conversion.Val(num24) * Conversion.Val(num4) / 100 - num24;
                            this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25);
                        }
                        else
                        {
                            double num26 = Conversion.Val(num7) * Conversion.Val(num) / 100 - Conversion.Val(num7);
                            double num27 = Conversion.Val(num26) * Conversion.Val(num4) / 100 - num26;
                            this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num27) - Conversion.Val(num27) - Conversion.Val(num27);
                        }
                        if (num8 < 0.0)
                        {
                            double num28 = Conversion.Val(num8) * Conversion.Val(num10) / 100;
                            double num29 = Conversion.Val(num8) + Conversion.Val(num28) - Conversion.Val(num28) - Conversion.Val(num28);
                            double num30 = Conversion.Val(num29) * Conversion.Val(num) / 100 - Conversion.Val(num29);
                            double num31 = Conversion.Val(num30) * Conversion.Val(num4) / 100 - num30;
                            this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num31) - Conversion.Val(num31) - Conversion.Val(num31);
                        }
                        else
                        {
                            double num32 = Conversion.Val(num8) * Conversion.Val(num) / 100 - Conversion.Val(num8);
                            double num33 = Conversion.Val(num32) * Conversion.Val(num4) / 100 - num32;
                            this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num33) - Conversion.Val(num33) - Conversion.Val(num33);
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

        // Token: 0x06002423 RID: 9251 RVA: 0x003C4354 File Offset: 0x003C2754
        public void Regular_Total()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView5.RowCount - 1;
                    double num3 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[0].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                    }
                    int num4 = 0;
                    int num5 = this.DataGridView5.RowCount - 1;
                    double num6 = 0;
                    for (int j = num4; j <= num5; j++)
                    {
                        unchecked
                        {
                            num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[j].Cells[1].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[2].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[2].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                    }

                    int num7 = 0;
                    int num8 = this.DataGridView5.RowCount - 1;
                    double num9 = 0;
                    for (int k = num7; k <= num8; k++)
                    {
                        unchecked
                        {
                            num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[k].Cells[2].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[3].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[3].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                    }
                    int num10 = 0;
                    int num11 = this.DataGridView5.RowCount - 1;
                    double num12 = 0;
                    for (int l = num10; l <= num11; l++)
                    {
                        unchecked
                        {
                            num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[l].Cells[3].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[2].Cells[4].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[0].Cells[4].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06002424 RID: 9252 RVA: 0x003C45B8 File Offset: 0x003C29B8
        public void Booky_All_Tems()
        {
            try
            {
                this.DataGridView5.Rows.Clear();
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyMaster.PartyName, PartyMaster.Status, SUM(PartyMaster.SMatch) AS Expr5, SUM(PartyMaster.AMatch) AS Expr6, SUM(PartyMaster.TMatch) AS Expr7, MatchTrans1.m_id, MatchTrans1.m_eid, MatchTrans1.m_page, MatchTrans1.m_party, SUM(MatchTrans1.m_team1) AS Expr1,SUM(MatchTrans1.m_team2) AS Expr2, SUM(MatchTrans1.m_team3) AS Expr3, SUM(MatchTrans1.m_team4) AS Expr4, MatchTrans1.m_checked FROM (PartyMaster INNER JOIN MatchTrans1 ON PartyMaster.PartyName = MatchTrans1.m_party) GROUP BY PartyMaster.PartyName, PartyMaster.Status, MatchTrans1.m_id, MatchTrans1.m_eid, MatchTrans1.m_page, MatchTrans1.m_party, MatchTrans1.m_checked HAVING (MatchTrans1.m_id = " + this.testnu.Text + ") AND (MatchTrans1.m_checked = 0)";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (oleDbDataReader.Read())
                {
                    if (Operators.ConditionalCompareObjectEqual(oleDbDataReader["Status"], "Booky", false))
                    {
                        double num = Convert.ToDouble(oleDbDataReader["Expr5"]);
                        double num2 = Convert.ToDouble(oleDbDataReader["Expr6"]);
                        double num3 = Convert.ToDouble(oleDbDataReader["Expr7"]);
                        double num4 = Conversion.Val(num2) + Conversion.Val(num3);
                        this.Rtotal1 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                        this.Rtotal2 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                        this.Rtotal3 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                        this.Rtotal4 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                        int index = this.DataGridView5.Rows.Add();
                        double num5 = Conversion.Val(this.Rtotal1) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal1);
                        double num6 = Conversion.Val(this.Rtotal2) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal2);
                        double num7 = Conversion.Val(this.Rtotal3) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal3);
                        double num8 = Conversion.Val(this.Rtotal4) * Conversion.Val(0) / 100 - Conversion.Val(this.Rtotal4);
                        double num10 = 0;
                        if (num5 < 0.0)
                        {
                            double num9 = Conversion.Val(num5) * Conversion.Val(num10) / 100;
                            double num11 = Conversion.Val(num5) + Conversion.Val(num9) - Conversion.Val(num9) - Conversion.Val(num9);
                            double num12 = Conversion.Val(num11) * Conversion.Val(num) / 100 - Conversion.Val(num11);
                            double num13 = Conversion.Val(num12) * Conversion.Val(num4) / 100 - num12;
                            this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num13) - Conversion.Val(num13) - Conversion.Val(num13);
                        }
                        else
                        {
                            double num14 = Conversion.Val(num5) * Conversion.Val(num) / 100 - Conversion.Val(num5);
                            double num15 = Conversion.Val(num14) * Conversion.Val(num4) / 100 - num14;
                            this.DataGridView5.Rows[index].Cells[0].Value = Conversion.Val(num15) - Conversion.Val(num15) - Conversion.Val(num15);
                        }
                        if (num6 < 0.0)
                        {
                            double num16 = Conversion.Val(num6) * Conversion.Val(num10) / 100;
                            double num17 = Conversion.Val(num6) + Conversion.Val(num16) - Conversion.Val(num16) - Conversion.Val(num16);
                            double num18 = Conversion.Val(num17) * Conversion.Val(num) / 100 - Conversion.Val(num17);
                            double num19 = Conversion.Val(num18) * Conversion.Val(num4) / 100 - num18;
                            this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num19) - Conversion.Val(num19) - Conversion.Val(num19);
                        }
                        else
                        {
                            double num20 = Conversion.Val(num6) * Conversion.Val(num) / 100 - Conversion.Val(num6);
                            double num21 = Conversion.Val(num20) * Conversion.Val(num4) / 100 - num20;
                            this.DataGridView5.Rows[index].Cells[1].Value = Conversion.Val(num21) - Conversion.Val(num21) - Conversion.Val(num21);
                        }
                        if (num7 < 0.0)
                        {
                            double num22 = Conversion.Val(num7) * Conversion.Val(num10) / 100;
                            double num23 = Conversion.Val(num7) + Conversion.Val(num22) - Conversion.Val(num22) - Conversion.Val(num22);
                            double num24 = Conversion.Val(num23) * Conversion.Val(num) / 100 - Conversion.Val(num23);
                            double num25 = Conversion.Val(num24) * Conversion.Val(num4) / 100 - num24;
                            this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num25) - Conversion.Val(num25) - Conversion.Val(num25);
                        }
                        else
                        {
                            double num26 = Conversion.Val(num7) * Conversion.Val(num) / 100 - Conversion.Val(num7);
                            double num27 = Conversion.Val(num26) * Conversion.Val(num4) / 100 - num26;
                            this.DataGridView5.Rows[index].Cells[2].Value = Conversion.Val(num27) - Conversion.Val(num27) - Conversion.Val(num27);
                        }
                        if (num8 < 0.0)
                        {
                            double num28 = Conversion.Val(num8) * Conversion.Val(num10) / 100;
                            double num29 = Conversion.Val(num8) + Conversion.Val(num28) - Conversion.Val(num28) - Conversion.Val(num28);
                            double num30 = Conversion.Val(num29) * Conversion.Val(num) / 100 - Conversion.Val(num29);
                            double num31 = Conversion.Val(num30) * Conversion.Val(num4) / 100 - num30;
                            this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num31) - Conversion.Val(num31) - Conversion.Val(num31);
                        }
                        else
                        {
                            double num32 = Conversion.Val(num8) * Conversion.Val(num) / 100 - Conversion.Val(num8);
                            double num33 = Conversion.Val(num32) * Conversion.Val(num4) / 100 - num32;
                            this.DataGridView5.Rows[index].Cells[3].Value = Conversion.Val(num33) - Conversion.Val(num33) - Conversion.Val(num33);
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

        // Token: 0x06002425 RID: 9253 RVA: 0x003C4F38 File Offset: 0x003C3338
        public void Booky_Total()
        {
            checked
            {
                try
                {
                    int num = 0;
                    int num2 = this.DataGridView5.RowCount - 1;
                    double num3 = 0;
                    for (int i = num; i <= num2; i++)
                    {
                        unchecked
                        {
                            num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[i].Cells[0].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[1].Value = Module1.SetNumFormat(num3, this.txtnu.Text);
                    }
                    int num4 = 0;
                    int num5 = this.DataGridView5.RowCount - 1;
                    double num6 = 0;
                    for (int j = num4; j <= num5; j++)
                    {
                        unchecked
                        {
                            num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[j].Cells[1].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[2].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[2].Value = Module1.SetNumFormat(num6, this.txtnu.Text);
                    }
                    int num7 = 0;
                    int num8 = this.DataGridView5.RowCount - 1;
                    double num9 = 0;
                    for (int k = num7; k <= num8; k++)
                    {
                        unchecked
                        {
                            num9 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[k].Cells[2].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[3].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[3].Value = Module1.SetNumFormat(num9, this.txtnu.Text);
                    }
                    int num10 = 0;
                    int num11 = this.DataGridView5.RowCount - 1;
                    double num12 = 0;
                    for (int l = num10; l <= num11; l++)
                    {
                        unchecked
                        {
                            num12 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[l].Cells[3].Value));
                        }
                    }
                    if (Module1.isntposition == true)
                    {
                        this.DataGridView2.Rows[3].Cells[4].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                    }
                    else
                    {
                        this.DataGridView2.Rows[1].Cells[4].Value = Module1.SetNumFormat(num12, this.txtnu.Text);
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        // Token: 0x06002428 RID: 9256 RVA: 0x003C5EB4 File Offset: 0x003C42B4
        public void Colore()
        {
            checked
            {
                try
                {
                    for (int i = 0; i <= this.DataGridView2.RowCount - 1; i++)
                    {
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[1].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[2].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[2].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[3].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[3].Style.ForeColor = Color.Green;
                        }
                        if (Operators.ConditionalCompareObjectLess(this.DataGridView2.Rows[i].Cells[4].Value, 0, false))
                        {
                            this.DataGridView2.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            this.DataGridView2.Rows[i].Cells[4].Style.ForeColor = Color.Green;
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

        // Token: 0x06002429 RID: 9257 RVA: 0x003C6138 File Offset: 0x003C4538
        public void Decleard()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "select* from Newmatch where Sr_No=" + this.testnu.Text + " and Result='Declared'";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                if (oleDbDataReader.Read())
                {
                    this.btnmodify.Enabled = false;
                    this.btndelete.Enabled = false;
                    this.btnok.Enabled = false;
                    this.txtpartiname.Enabled = false;
                }
                else
                {
                    this.btnmodify.Enabled = true;
                    this.btndelete.Enabled = true;
                    this.btnok.Enabled = true;
                    this.txtpartiname.Enabled = true;
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

        // Token: 0x0600242A RID: 9258 RVA: 0x003C6220 File Offset: 0x003C4620
        private void btnok_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Name information?", MsgBoxStyle.OkOnly, null);
                        this.txtpartiname.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                    {
                        Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
                    {
                        Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Team information?", MsgBoxStyle.OkOnly, null);
                        this.cmbteam.Focus();
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Mode information?", MsgBoxStyle.OkOnly, null);
                        this.ComboBox2.Focus();
                    }
                    else
                    {
                        this.GenerateGrid();

                        this.ComboBox2_Leave(RuntimeHelpers.GetObjectValue(sender), e);
                        if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                        {
                            this.txtsut.Text = "0";
                        }
                        if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                        {
                            this.txtind.Text = "0";
                        }

                        string cmdText = $"INSERT INTO MatchTrans1(m_id, m_eid, m_page, m_amt, m_rate, m_team, m_mode, m_party, Status, m_dt, m_time, m_team1, m_team2, m_team3, m_team4, Modify, m_checked, M_P, M_chk)VALUES({this.testnu.Text},{this.txtsrno.Text},'{this.txtpage.Text}',{this.txtamount.Text},{this.txtrate.Text},'{this.cmbteam.Text}','{this.ComboBox2.Text}','{this.txtpartiname.Text}','{this.cmbostus.Text}','{this.txtdate.Text}','{this.txttime.Text}',{this.txtpak.Text},{this.txtend.Text},{this.txtsut.Text},{this.txtind.Text},'0','0','0',0)";
                        using (TransactionService transactionService = new TransactionService())
                        {
                            transactionService.Insert(cmdText);
                        }
                        this.listboxlode();
                        this.TOTAL_ALL();
                        this.Net_Postion();
                        this.Colore();
                        this.sr_NoAuto();
                        Module1.name1 = this.txtpartiname.Text.ToString();
                        this.Partposion();

                        this.txtpartiname.Text = "";
                        this.txtamount.Text = "";
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
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Token: 0x0600242B RID: 9259 RVA: 0x003C690C File Offset: 0x003C4D0C
        private void ComboBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Operators.CompareString(this.DataGridView2.Columns[1].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(-Conversion.Val(this.txtrate.Text) * Conversion.Val(this.txtamount.Text));
                        this.txtend.Text = this.txtamount.Text;
                        this.txtind.Text = this.txtamount.Text;
                        this.txtsut.Text = this.txtamount.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView2.Columns[2].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(-Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtpak.Text = this.txtamount.Text;
                        this.txtind.Text = this.txtamount.Text;
                        this.txtsut.Text = this.txtamount.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView2.Columns[3].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtsut.Text = Conversions.ToString(-Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtind.Text = this.txtamount.Text;
                        this.txtend.Text = this.txtamount.Text;
                        this.txtpak.Text = this.txtamount.Text;
                    }
                }
                else if (Operators.CompareString(this.DataGridView2.Columns[4].HeaderText, this.cmbteam.Text, false) == 0)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtend.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtpak.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                        this.txtsut.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text) - Conversion.Val(this.txtamount.Text));
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        this.txtind.Text = Conversions.ToString(Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtind.Text = Conversions.ToString(-Conversion.Val(this.txtamount.Text) * Conversion.Val(this.txtrate.Text));
                        this.txtsut.Text = this.txtamount.Text;
                        this.txtend.Text = this.txtamount.Text;
                        this.txtpak.Text = this.txtamount.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        public void Partposion()

        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                this.DataGridView3.Rows.Clear();
                this.DataGridView3.Rows.Add();
                string cmdText = string.Concat(new string[]
                {
                    "SELECT PartyMaster.PartyName, PartyMaster.SMatchCommi, PartyMaster.SMatch, SUM(MatchTrans1.m_team1) AS Expr1, SUM(MatchTrans1.m_team2) AS Expr2, SUM(MatchTrans1.m_team3) AS Expr3, SUM(MatchTrans1.m_team4) AS Expr4, MatchTrans1.m_id, MatchTrans1.m_checked FROM (MatchTrans1 INNER JOIN PartyMaster ON MatchTrans1.m_party = PartyMaster.PartyName) GROUP BY PartyMaster.PartyName, PartyMaster.SMatchCommi, PartyMaster.SMatch, MatchTrans1.m_id, MatchTrans1.m_checked HAVING (MatchTrans1.m_id =",
                    this.testnu.Text,
                    ") AND (PartyMaster.PartyName ='",
                    Module1.name1.ToString(),
                    "') AND (MatchTrans1.m_checked <> 1)"
                });
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                double num14 = 0;
                double num19 = 0;
                double num24 = 0;
                double num29 = 0;
                while (oleDbDataReader.Read())
                {
                    num14 = Convert.ToDouble(oleDbDataReader["Expr1"]);
                    num19 = Convert.ToDouble(oleDbDataReader["Expr2"]);
                    num24 = Convert.ToDouble(oleDbDataReader["Expr3"]);
                    num29 = Convert.ToDouble(oleDbDataReader["Expr4"]);
                }

                this.DataGridView3.Rows[0].Cells[0].Value = Module1.SetNumFormat(num14, this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[1].Value = Module1.SetNumFormat(num19, this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[2].Value = Module1.SetNumFormat(num24, this.txtnu.Text);
                this.DataGridView3.Rows[0].Cells[3].Value = Module1.SetNumFormat(num29, this.txtnu.Text);
                this.postions_Colur();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
            finally
            {
                this.DataGridView3.ClearSelection();
                Module1.conn.Close();
            }
        }

        // Token: 0x0600242D RID: 9261 RVA: 0x003C7710 File Offset: 0x003C5B10
        public void postions_Colur()
        {
            try
            {
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[0].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[0].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[1].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[1].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[2].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[2].Style.ForeColor = Color.Green;
                }
                if (Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[0].Cells[3].Value, 0, false))
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.DataGridView3.Rows[0].Cells[3].Style.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        //// Token: 0x0600242E RID: 9262 RVA: 0x003C7974 File Offset: 0x003C5D74
        //public void update_parsent()
        //{
        //	try
        //	{
        //		if (Module1.conn.State == ConnectionState.Closed)
        //		{
        //			Module1.conn.Open();
        //		}
        //		string cmdText = string.Concat(new string[]
        //		{
        //			"update MatchTrans1 set M_P='",
        //			this.txtmpar.Text,
        //			"'where m_party='",
        //			this.txtpartiname.Text,
        //			"' and Status='",
        //			this.cmbostus.Text,
        //			"'"
        //		});
        //		OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
        //		oleDbCommand.ExecuteNonQuery();
        //	}
        //	catch (Exception ex)
        //	{
        //		Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //	finally
        //	{
        //		Module1.conn.Close();
        //	}
        //}

        // Token: 0x0600242F RID: 9263 RVA: 0x003C7A48 File Offset: 0x003C5E48
        private void Button1_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    if (Operators.CompareString(this.txtpartiname.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Name information?", MsgBoxStyle.OkOnly, null);
                        this.txtpartiname.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                    {
                        Interaction.MsgBox("Please fill Amount information?", MsgBoxStyle.OkOnly, null);
                        this.txtamount.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
                    {
                        Interaction.MsgBox("Please fill Rate information?", MsgBoxStyle.OkOnly, null);
                        this.txtrate.Focus();
                    }
                    else if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Team information?", MsgBoxStyle.OkOnly, null);
                        this.cmbteam.Focus();
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, null, false) == 0)
                    {
                        Interaction.MsgBox("Please fill Mode information?", MsgBoxStyle.OkOnly, null);
                        this.ComboBox2.Focus();
                    }
                    else //if (Module1.TotalAmount > Module1.CustBalance)
                    {

                        this.GenerateGrid();

                        this.ComboBox2_Leave(RuntimeHelpers.GetObjectValue(sender), e);
                        if (Operators.CompareString(this.DataGridView1.Columns[8].HeaderText, "", false) == 0)
                        {
                            this.txtsut.Text = "0";
                        }
                        if (Operators.CompareString(this.DataGridView1.Columns[9].HeaderText, "", false) == 0)
                        {
                            this.txtind.Text = "0";
                        }
                        string cmdText2 = $"UPDATE MatchTrans1 SET m_page = '{this.txtpage.Text}', m_amt = {this.txtamount.Text}, m_rate = {this.txtrate.Text}, m_team = '{this.cmbteam.Text}', m_mode = '{this.ComboBox2.Text}', m_party = '{this.txtpartiname.Text}', modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}', m_team1 =  {this.txtpak.Text}, m_team2 = {this.txtend.Text}, m_team3 ={this.txtsut.Text}, m_team4 ={this.txtind.Text}, Modify = '1' WHERE MatchTrans1.m_id = {this.testnu.Text} AND MatchTrans1.m_eid = {this.txtsrno.Text}";

                        using (MatchService matchService = new MatchService())
                        {
                            matchService.Update(cmdText2);
                        }

                        this.listboxlode();
                        this.TOTAL_ALL();
                        this.Net_Postion();
                        this.Colore();
                        this.sr_NoAuto();
                        Module1.name1 = this.txtpartiname.Text.ToString();
                        this.Partposion();
                        //this.Panel2.BackColor = Color.Transparent;
                        this.btnok.Show();
                        this.ismodify = false;
                        this.Button5.Hide();
                        this.Button1.Hide();

                        this.txtpartiname.Text = "";
                        this.txtamount.Text = "";
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
            }
        }

        // Token: 0x06002430 RID: 9264 RVA: 0x003C81EC File Offset: 0x003C65EC
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Panel2.BackColor = Color.Transparent;
                this.btnok.Show();
                this.ismodify = false;
                this.Button5.Hide();
                this.Button1.Hide();
                this.txtpage.Text = "1";
                this.txtamount.Text = null;
                this.txtrate.Text = null;
                this.cmbteam.Text = null;
                this.ComboBox2.Text = null;
                this.txtpartiname.Text = null;
                this.cmbostus.Text = null;
                this.txtdate.Text = null;
                this.txttime.Text = null;
                this.txtpak.Text = null;
                this.txtend.Text = null;
                this.txtsut.Text = null;
                this.txtind.Text = null;

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

        // Token: 0x06002431 RID: 9265 RVA: 0x003C8310 File Offset: 0x003C6710
        private void txtpartiname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cmboid.SelectedIndex = this.txtpartiname.SelectedIndex;
                this.cmbostus.SelectedIndex = this.txtpartiname.SelectedIndex;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtpage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.txtpage.Text, null, false) != 0)
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

        // Token: 0x06002433 RID: 9267 RVA: 0x003C848C File Offset: 0x003C688C
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
                    else if (Operators.CompareString(this.txtamount.Text, ".00", false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{Tab}");
                        if (Module1.isamountfirst == true)
                        {
                            this.txtrate.SelectAll();
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

        // Token: 0x06002434 RID: 9268 RVA: 0x003C851C File Offset: 0x003C691C
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
                    else if (Operators.CompareString(this.txtrate.Text, ".00", false) == 0)
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
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002435 RID: 9269 RVA: 0x003C85AC File Offset: 0x003C69AC
        private void cmbteam_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.cmbteam.Text, null, false) == 0)
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

        // Token: 0x06002436 RID: 9270 RVA: 0x003C861C File Offset: 0x003C6A1C
        private void txtamount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtamount.Text != "")
                {
                    this.txtamount.Text = Module1.SetNumFormat(Conversion.Val(this.txtamount.Text), this.txtnu.Text);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002437 RID: 9271 RVA: 0x003C8650 File Offset: 0x003C6A50
        private void txtrate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.txtrate.Text != "")
                {
                    string text = this.txtrate.Text;
                    double num = (double)text.IndexOf(".");
                    if (num < 0.0)
                    {
                        this.txtrate.Text = this.txtrate.Text.Replace(this.txtrate.Text, "." + this.txtrate.Text);
                    }
                   // this.txtrate.Text = Module1.SetNumFormat(Conversion.Val(this.txtrate.Text), this.txtnu.Text);
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002438 RID: 9272 RVA: 0x003C871C File Offset: 0x003C6B1C
        private void ComboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (Operators.CompareString(this.ComboBox2.Text, null, false) == 0)
                    {
                        this.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{tab}");
                    }
                }
                if (e.KeyCode == Keys.NumPad1)
                {
                    this.ComboBox2.SelectedItem = "K";
                }
                else if (e.KeyCode == Keys.NumPad2)
                {
                    this.ComboBox2.SelectedItem = "L";
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
                            this.btnok.Focus();
                        }
                    }
                    else
                    {
                        this.Button1.Focus();
                    }
                }

                if (e.KeyCode == Keys.Back)
                {
                    this.txtpartiname.Text = null;
                    this.txtpartiname.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void txtpartiname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox txtpartiname = this.txtpartiname;
                this.AutoComplete(ref txtpartiname, e, false);
                this.txtpartiname = txtpartiname;

                Module1.TotalAmount = 0.0;
                Module1.CustBalance = 0.0;
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string cmdText = "SELECT PartyName, SMatch, AMatch, TMatch FROM (PartyMaster) WHERE (PartyName = '" + this.txtpartiname.Text + "')";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                Module1.TotalAmount = 0.0;
                if (oleDbDataReader.Read())
                {
                    double num = Convert.ToDouble(Operators.AddObject(Operators.AddObject(oleDbDataReader["SMatch"], oleDbDataReader["AMatch"]), oleDbDataReader["TMatch"]));
                    if (Operators.CompareString(this.ComboBox2.Text, "L", false) == 0)
                    {
                        double num2 = Convert.ToDouble(this.txtamount.Text) * Convert.ToDouble(this.txtrate.Text);
                        double num3 = num2 * 0.0 / 100;
                        double num4 = num2 - num3;
                        double num5 = num4 * num / 100;
                        double value = num4 - num5;
                        Module1.TotalAmount += Convert.ToDouble(value);
                    }
                    else if (Operators.CompareString(this.ComboBox2.Text, "K", false) == 0)
                    {
                        double num6 = Convert.ToDouble(this.txtamount.Text);
                        double num7 = num6 * 0.0 / 100;
                        double num8 = num6 - num7;
                        double num9 = num8 * num / 100;
                        double value2 = num8 - num9;
                        Module1.TotalAmount += Convert.ToDouble(value2);
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


        // Token: 0x0600243C RID: 9276 RVA: 0x003C8AEC File Offset: 0x003C6EEC
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

        // Token: 0x0600243D RID: 9277 RVA: 0x003C8C48 File Offset: 0x003C7048
        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double)this.deletedrecord == Convert.ToDouble("1"))
                {
                    Interaction.MsgBox("can not edit Record", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = string.Concat(new string[]
                    {
                        "select* from MatchTrans1 where m_id=",
                        this.testnu.Text,
                        " and m_eid=",
                        Conversions.ToString(this.deleteno),
                        " "
                    });
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    if (oleDbDataReader.Read())
                    {
                        //this.Panel2.BackColor = Color.LightSkyBlue;
                        this.btnok.Hide();
                        this.ismodify = true;
                        this.Button5.Show();
                        this.Button1.Show();
                        this.id.Text = Conversions.ToString(oleDbDataReader[0]);
                        this.testnu.Text = Conversions.ToString(oleDbDataReader[1]);
                        this.txtsrno.Text = Conversions.ToString(oleDbDataReader[2]);
                        this.txtpage.Text = Conversions.ToString(oleDbDataReader[3]);
                        this.txtamount.Text = Conversions.ToString(oleDbDataReader[4]);
                        this.txtrate.Text = Conversions.ToString(oleDbDataReader[5]);
                        this.cmbteam.Text = Conversions.ToString(oleDbDataReader[6]);
                        this.ComboBox2.Text = Conversions.ToString(oleDbDataReader[7]);
                        this.cmbostus.Text = Conversions.ToString(oleDbDataReader[9]);
                        this.txtdate.Text = Conversions.ToString(oleDbDataReader[10]);
                        this.txttime.Text = Conversions.ToString(oleDbDataReader[11]);
                        this.txtpak.Text = Conversions.ToString(oleDbDataReader[12]);
                        this.txtend.Text = Conversions.ToString(oleDbDataReader[13]);
                        this.txtsut.Text = Conversions.ToString(oleDbDataReader[14]);
                        this.txtind.Text = Conversions.ToString(oleDbDataReader[15]);

                        this.txtpartiname.Text = Conversions.ToString(oleDbDataReader[8]);
                        this.Cmboid.SelectedIndex = this.txtpartiname.SelectedIndex;
                        this.cmbostus.SelectedIndex = this.txtpartiname.SelectedIndex;
                        this.smatch.SelectedIndex = this.txtpartiname.SelectedIndex;
                        this.amatch.SelectedIndex = this.txtpartiname.SelectedIndex;
                        this.tmatch.SelectedIndex = this.txtpartiname.SelectedIndex;
                        this.subtotal.Text = Conversions.ToString(Conversion.Val(this.smatch.Text) + Conversion.Val(this.amatch.Text) + Conversion.Val(this.tmatch.Text));

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

        // Token: 0x0600243E RID: 9278 RVA: 0x003C8FD4 File Offset: 0x003C73D4
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure want to delete?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
            {
                checked
                {
                    try
                    {
                        //int value = Conversions.ToInteger("1");
                        if ((double)this.deletedrecord == Convert.ToDouble("1"))
                        {
                            Interaction.MsgBox("Can not delete record", MsgBoxStyle.OkOnly, null);
                        }
                        else
                        {
                            string cmdText = $"Update MatchTrans1 Set m_checked=1, modify_date = '{Conversions.ToString(DateAndTime.Now.Date)}', modify_time = '{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}' where m_id={this.testnu.Text} and m_eid={Conversions.ToString(this.deleteno)}";
                            using (MatchService matchService = new MatchService())
                            {
                                matchService.Update(cmdText);
                            }

                                this.GenerateGrid();

                            //this.TOTAL_ALL();
                            //this.netK();
                            //this.netL();
                            //this.Net_Postion();
                            //this.Colore();

                            this.listboxlode();
                            this.TOTAL_ALL();
                            this.Net_Postion();
                            this.Colore();
                            this.sr_NoAuto();
                            Module1.name1 = this.txtpartiname.Text.ToString();
                            this.Partposion();
                            //this.Panel2.BackColor = Color.Transparent;
                            this.btnok.Show();
                            this.ismodify = false;
                            this.Button5.Hide();
                            this.Button1.Hide();

                            this.txtpartiname.Text = "";
                            this.txtamount.Text = "";
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
                }
            }
        }

        // Token: 0x0600243F RID: 9279 RVA: 0x003C93BC File Offset: 0x003C77BC
        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.deleteno = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[0].Value);
                this.deletedrecord = Conversions.ToInteger(this.DataGridView1.CurrentRow.Cells[13].Value);
                Module1.name1 = RuntimeHelpers.GetObjectValue(this.DataGridView1.CurrentRow.Cells[5].Value);
                Module1.tossmatchid = Conversions.ToInteger(this.testnu.Text);
                this.Label7.Text = "Party Position Of   " + this.txtpartiname.Text;
                this.Partposion();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                MessageBox.Show("Sorry? Close Match ", "Confrm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!Operators.ConditionalCompareObjectEqual(Module1.name1, "", false))
                {
                    MyProject.Forms.DPP_Toss.MdiParent = this.MdiParent;
                    MyProject.Forms.DPP_Toss.WindowState = FormWindowState.Maximized;
                    MyProject.Forms.DPP_Toss.Show();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }


        // Token: 0x06002442 RID: 9282 RVA: 0x003C9AB8 File Offset: 0x003C7EB8
        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                Toss_Reports toss_Reports = new Toss_Reports();
                toss_Reports.MdiParent = this.MdiParent;
                toss_Reports.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x06002443 RID: 9283 RVA: 0x003C9B20 File Offset: 0x003C7F20
        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string selectCommandText = string.Concat(new string[]
                {
                    "select n.Team1,n.Name,n.Type,n.Date1,n.Sr_No,m.m_eid,m.m_amt,m.m_rate,m.m_team,m.m_mode,m.m_party from Newmatch n,MatchTrans1 m where n.Sr_No=",
                    this.testnu.Text,
                    " and m.m_id=",
                    this.testnu.Text,
                    " and m_checked=0"
                });
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, Module1.conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                oleDbDataAdapter.Fill(dataTable);

                //Add RPT
                //Matchreport matchreport = new Matchreport();
                //matchreport.SetDataSource(dataTable);
                //MyProject.Forms.print_view.CrystalReportViewer1.ReportSource = matchreport;

                //Module1.conn.Close();
                //MyProject.Forms.print_view.ShowDialog();
                //MyProject.Forms.print_view.Dispose();

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\Matchreport.rpt");
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

        private void Toss_Match_KeyDown(object sender, KeyEventArgs e)
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

        // Token: 0x04000E4B RID: 3659
        private double Rtotal1;

        // Token: 0x04000E4C RID: 3660
        private double Rtotal2;

        // Token: 0x04000E4D RID: 3661
        private double Rtotal3;

        // Token: 0x04000E4E RID: 3662
        private double Rtotal4;

        // Token: 0x04000E5D RID: 3677
        private int deleteno;

        // Token: 0x04000E5E RID: 3678
        private int deletedrecord;

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
