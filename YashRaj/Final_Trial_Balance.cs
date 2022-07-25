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
    public partial class Final_Trial_Balance : Form
    {
        public Final_Trial_Balance()
        {
            this._NevaTotals = 0.0;
            this.InitializeComponent();
        }

        private void Final_Trial_Balance_Activated(object sender, EventArgs e)
        {
            try
            {
                this.LoadData();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadData();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Final_Trial_Balance_KeyDown(object sender, KeyEventArgs e)
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

        private void Final_Trial_Balance_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtnu.Text = Module1.decimalnumberformat;
                this.filter.Hide();

                this.CheckBox1.Hide();
                this.Button4.Hide();
                this.txtname.Hide();
                this.txtnu.Hide();

                this.txtAgentName.Focus();

                this.combolod();
                this.LoadData();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadData();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        public void combolod()
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                string str = "Select * from PartyMaster";
                OleDbCommand OleDbCmd = new OleDbCommand(str, Module1.conn);
                OleDbDataReader OleDbDataRdr = OleDbCmd.ExecuteReader();
                while (OleDbDataRdr.Read())
                {
                    if (!this.txtAgentName.Items.Contains(RuntimeHelpers.GetObjectValue(OleDbDataRdr["AParty"]).ToString()))
                        this.txtAgentName.Items.Add(RuntimeHelpers.GetObjectValue(OleDbDataRdr["AParty"]));

                    if (!this.txtAgentName.Items.Contains(RuntimeHelpers.GetObjectValue(OleDbDataRdr["TParty"]).ToString()))
                        this.txtAgentName.Items.Add(RuntimeHelpers.GetObjectValue(OleDbDataRdr["TParty"]));
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

        private void LoadData()
        {
            checked
            {
                try
                {
                    this.DataGridView5.Rows.Clear();
                    this.DataGridView6.Rows.Clear();

                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }

                    double credittotal = 0;
                    double debittotal = 0;

                    string cmdText = string.Concat(new string[]
                    {
                        "SELECT PartyMaster.PartyName, SUM(tns_Amount) AS Amt, MIN(IIF(chk='1', 1, 0)) as ChkAmt FROM (PartyMaster INNER JOIN Trans ON PartyMaster.PartyName = Trans.tns_Party) ",
                        "WHERE (Trans.tns_chk = '0') AND (Trans.tns_Type <> 'Monday Settlement') ",
                        txtAgentName.Text != "" ? "AND (PartyMaster.AParty='"+ txtAgentName.Text +"' OR PartyMaster.TParty='" + txtAgentName.Text + "') " : " ",
                        "GROUP BY PartyMaster.PartyName ORDER BY PartyMaster.PartyName"
                    });

                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                    while (oleDbDataReader.Read())
                    {
                        //int index = this.DataGridView4.Rows.Add();
                        //this.DataGridView4.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]);
                        //this.DataGridView4.Rows[index].Cells[1].Value = oleDbDataReader["Amt"].ToString();
                        //this.DataGridView4.Rows[index].Cells[2].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(oleDbDataReader["ChkAmt"].ToString()));

                        if (RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"]).ToString() == "LD")
                        {
                            Console.WriteLine("");
                        }

                        double num = Conversion.Val(RuntimeHelpers.GetObjectValue(oleDbDataReader["Amt"]));

                        if (Module1.NumFormat == ".00")
                        {
                            if (Math.Abs(num) <= 0.01)
                                num = 0;
                        }

                        if (Module1.NumFormat == ".000")
                        {
                            if (Math.Abs(num) <= 0.001)
                                num = 0;
                        }
                        if(Module1.NumFormat == "")
                        {
                            if (Math.Abs(num) <= 1)
                                num = 0;
                        }


                        unchecked
                        {
                            if (num != 0)
                            {
                                if (num > 0)
                                {
                                    int index = this.DataGridView5.Rows.Add();
                                    this.DataGridView5.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"].ToString());
                                    this.DataGridView5.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                                    this.DataGridView5.Rows[index].Cells[2].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(oleDbDataReader["ChkAmt"].ToString()));
                                    credittotal += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index].Cells[1].Value)));
                                }
                                else
                                {
                                    int index = this.DataGridView6.Rows.Add();
                                    this.DataGridView6.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader["PartyName"].ToString());
                                    this.DataGridView6.Rows[index].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                                    this.DataGridView6.Rows[index].Cells[2].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(oleDbDataReader["ChkAmt"].ToString()));
                                    debittotal += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index].Cells[1].Value)));
                                }
                            }
                        }
                    }
                    oleDbCommand.Clone();
                    oleDbDataReader.Close();

                    this.total_jama();
                    this.total_neva();

                    this.lblCreditTotal.Text = Module1.SetNumFormat(Conversion.Val(credittotal), this.txtnu.Text);
                    this.lblDebitTotal.Text = Module1.SetNumFormat(Conversion.Val(debittotal), this.txtnu.Text);

                    ////cmdText = "SELECT PartyMaster.PartyName, SUM(OP_BAL.Amount) AS Expr2 FROM (PartyMaster INNER JOIN OP_BAL ON PartyMaster.PartyName = OP_BAL.Party_name) GROUP BY PartyMaster.PartyName ORDER BY PartyMaster.PartyName";
                    ////oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    ////OleDbDataReader oleDbDataReader2 = oleDbCommand.ExecuteReader();
                    ////while (oleDbDataReader2.Read())
                    ////{
                    ////	int index2 = this.DataGridView4.Rows.Add();
                    ////	this.DataGridView4.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(oleDbDataReader2["PartyName"]);
                    ////	this.DataGridView4.Rows[index2].Cells[1].Value = oleDbDataReader2["Expr2"].ToString();
                    ////}
                    ////oleDbCommand.Clone();
                    ////oleDbDataReader2.Close();

                    //cmdText = "SELECT Id, PartyName FROM PartyMaster ORDER BY PartyName";
                    //oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    //oleDbDataReader = oleDbCommand.ExecuteReader();
                    ////double num4=0;
                    ////double num5=0;
                    //while (oleDbDataReader.Read())
                    //{
                    //	double num = 0.0;
                    //	bool chkamt = false;
                    //	for (int i = 0; i <= this.DataGridView4.RowCount - 1; i++)
                    //	{
                    //		unchecked
                    //		{
                    //			if (Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[i].Cells[0].Value, oleDbDataReader["PartyName"], false))
                    //			{
                    //				num += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[1].Value)));
                    //				chkamt = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[i].Cells[2].Value));
                    //			}
                    //		}
                    //	}

                    //	unchecked
                    //	{
                    //		if (num != 0)
                    //		{
                    //			if (num < 0.0)
                    //			{
                    //				int index3 = this.DataGridView6.Rows.Add();
                    //				this.DataGridView6.Rows[index3].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                    //				this.DataGridView6.Rows[index3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                    //				//num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[1].Value)));
                    //			}
                    //			else 
                    //			{
                    //				int index4 = this.DataGridView5.Rows.Add();
                    //				this.DataGridView5.Rows[index4].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                    //				this.DataGridView5.Rows[index4].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                    //				//num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index4].Cells[1].Value)));
                    //			}

                    //			//if (num < 0.0)
                    //			//{
                    //			//	if (-1.0 > num)
                    //			//	{
                    //			//		int index3 = this.DataGridView6.Rows.Add();
                    //			//		this.DataGridView6.Rows[index3].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                    //			//		this.DataGridView6.Rows[index3].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                    //			//		num4 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[index3].Cells[1].Value)));
                    //			//	}
                    //			//}
                    //			//else if (1.0 < num)
                    //			//{
                    //			//	int index4 = this.DataGridView5.Rows.Add();
                    //			//	this.DataGridView5.Rows[index4].Cells[0].Value = oleDbDataReader["PartyName"].ToString();
                    //			//	this.DataGridView5.Rows[index4].Cells[1].Value = Module1.SetNumFormat(Conversion.Val(num), this.txtnu.Text);
                    //			//	num5 += Convert.ToDouble(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[index4].Cells[1].Value)));
                    //			//}
                    //		}
                    //	}
                    //}
                    //oleDbCommand.Clone();
                    //oleDbDataReader.Close(); 

                    ////this.lblCreditTotal.Text = Module1.SetNumFormat(Conversion.Val(num5), this.txtnu.Text);
                    ////this.lblDebitTotal.Text = Module1.SetNumFormat(Conversion.Val(num4), this.txtnu.Text);                    			
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
        }

        public void total_jama()
        {
            checked
            {
                try
                {
                    this.DataGridView10.Rows.Clear();
                    this.DataGridView10.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                    //int num8 = 0;
                    //for (int j = 0; j <= this.DataGridView5.RowCount - 1; j++)
                    //{
                    //    num8 = (int)Math.Round(Convert.ToDouble(j));
                    //}
                    //int num9 = (int)Math.Round(Conversion.Val(num8) / 2.0);
                    //num9++;

                    int num9 = (int)Math.Round(Conversion.Val(this.DataGridView5.RowCount) / 2) + 1;

                    for (int k = 0; k <= this.DataGridView5.RowCount; k++)
                    {
                        if (k < num9)
                        {
                            int index = this.DataGridView10.Rows.Add();
                            this.DataGridView10.Rows[index].Cells[0].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[k].Cells[2].Value));
                            this.DataGridView10.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[k].Cells[0].Value);
                            this.DataGridView10.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[k].Cells[1].Value)), this.txtnu.Text);
                        }
                        else
                        {
                            for (int l = 1; l <= this.DataGridView10.RowCount; l++)
                            {
                                this.DataGridView10.Rows[l].Cells[4].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[num9].Cells[2].Value));
                                this.DataGridView10.Rows[l].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[num9].Cells[0].Value);
                                this.DataGridView10.Rows[l].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView5.Rows[num9].Cells[1].Value)), this.txtnu.Text);
                                num9 = (int)Math.Round(unchecked((double)num9 + Convert.ToDouble(1)));
                            }
                        }
                    }
                    this.DataGridView10.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                finally
                {
                    this.DataGridView10.ClearSelection();
                }
            }
        }

        public void total_neva()
        {
            checked
            {
                try
                {
                    this.DataGridView20.Rows.Clear();
                    this.DataGridView20.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                    //double num3 = 0;
                    //for (int i = 0; i <= this.DataGridView6.RowCount - 1; i++)
                    //{
                    //    num3 = Convert.ToDouble(i);
                    //}
                    //int num4 = (int)Math.Round(Conversion.Val(num3) / 2.0);
                    //num4++;

                    int num4 = (int)Math.Round(Conversion.Val(this.DataGridView6.RowCount) / 2) + 1;

                    for (int j = 0; j <= this.DataGridView6.RowCount; j++)
                    {
                        if (j < num4)
                        {
                            int index = this.DataGridView20.Rows.Add();
                            this.DataGridView20.Rows[index].Cells[0].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[j].Cells[2].Value));
                            this.DataGridView20.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[j].Cells[0].Value);
                            this.DataGridView20.Rows[index].Cells[2].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[j].Cells[1].Value)), this.txtnu.Text);
                        }
                        else
                        {
                            for (int k = 1; k <= this.DataGridView20.RowCount; k++)
                            {
                                this.DataGridView20.Rows[k].Cells[4].Value = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[num4].Cells[2].Value));
                                this.DataGridView20.Rows[k].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[num4].Cells[0].Value);
                                this.DataGridView20.Rows[k].Cells[6].Value = Module1.SetNumFormat(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView6.Rows[num4].Cells[1].Value)), this.txtnu.Text);
                                num4 = (int)Math.Round(unchecked((double)num4 + Convert.ToDouble(1)));
                            }
                        }
                    }
                    this.DataGridView20.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                }
                finally
                {
                    this.DataGridView20.ClearSelection();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.CheckBox2.Checked)
                //{
                //	this.filter.Rows.Clear();
                //	this._NevaTotals = 0.0;
                //	this.Tow_Mindi_Hid_Print();
                //}
                //else
                //{

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

                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView10.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        dataTable.Rows.Add(new object[]
                        {
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[6].Value),
                            this.Label3.Text + "                       " + this.lblCreditTotal.Text
                        });
                    }
                }
                finally
                {
                }
                dataSet.Tables.Add(dataTable);

                try
                {
                    foreach (object obj2 in ((IEnumerable)this.DataGridView20.Rows))
                    {
                        DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                        dataTable2.Rows.Add(new object[]
                        {
                            RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[1].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[2].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[5].Value),
                            RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[6].Value),
                            this.Label4.Text + "                       " + this.lblDebitTotal.Text
                        });
                    }
                }
                finally
                {
                }
                dataSet.Tables.Add(dataTable2);

                print_view printView = new print_view();
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(Application.StartupPath + "\\RPT\\FinalTB_Report.rpt");
                reportDocument.SetDataSource(dataSet);
                printView.crystalReportViewer1.ReportSource = reportDocument;
                printView.ShowDialog();

                //dataSet.Tables.Add(dataTable2);
                //print_view printView = new print_view();
                //ReportDocument reportDocument = new ReportDocument();
                //reportDocument.Load(Application.StartupPath + "\\RPT\\FinalTB_Report.rpt");
                //reportDocument.SetDataSource(dataSet);
                //printView.crystalReportViewer1.ReportSource = reportDocument;
                //printView.ShowDialog();

                //}
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        //public void Tow_Mindi_Hid_Print()
        //{
        //	try
        //	{
        //		DataSet dataSet = new DataSet();
        //		DataGridView dataGridView = new DataGridView();
        //		dataGridView.Columns.Add("Column1", "Column1");
        //		dataGridView.Columns.Add("Column2", "Column2");
        //		dataGridView.Columns.Add("Column3", "Column3");
        //		dataGridView.Columns.Add("Column4", "Column4");
        //		dataGridView.Columns.Add("Jama", "Jama");
        //		double num=0;
        //		try
        //		{
        //			foreach (object obj in ((IEnumerable)this.DataGridView10.Rows))
        //			{
        //				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
        //				if (Operators.ConditionalCompareObjectGreater(dataGridViewRow.Cells[2].Value, 9, false))
        //				{
        //					string text = Conversions.ToString(dataGridViewRow.Cells[1].Value);
        //					string text2 = Conversions.ToString(dataGridViewRow.Cells[2].Value);
        //					num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
        //					this.filter.Rows.Add(new object[]
        //					{
        //						text,
        //						text2
        //					});
        //				}
        //			}
        //		}
        //		finally
        //		{					
        //		}

        //		try
        //		{
        //			foreach (object obj2 in ((IEnumerable)this.DataGridView20.Rows))
        //			{
        //				DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
        //				if (Operators.ConditionalCompareObjectGreater(dataGridViewRow2.Cells[6].Value, 9, false))
        //				{
        //					string text3 = Conversions.ToString(dataGridViewRow2.Cells[5].Value);
        //					string text4 = Conversions.ToString(dataGridViewRow2.Cells[6].Value);
        //					num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells[6].Value));
        //					this.filter.Rows.Add(new object[]
        //					{
        //						text3,
        //						text4
        //					});
        //				}
        //			}
        //		}
        //		finally
        //		{					
        //		}

        //		checked
        //		{

        //			int num4=0;
        //			for (int i = 0; i <= this.filter.RowCount - 1; i++)
        //			{
        //				num4 = (int)Math.Round(Convert.ToDouble(i));
        //			}
        //			int num5 = (int)Math.Round(Conversion.Val(num4) / 2.0);
        //			num5++;

        //			try
        //			{
        //				for (int j = 0; j <= this.filter.Rows.Count - 1; j++)
        //				{
        //					if (j <= num5)
        //					{
        //						int index = dataGridView.Rows.Add();
        //						dataGridView.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.filter.Rows[j].Cells[0].Value);
        //						dataGridView.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.filter.Rows[j].Cells[1].Value);
        //					}
        //					else
        //					{
        //						num5++;								
        //						for (int k = 1; k <= dataGridView.RowCount - 1; k++)
        //						{
        //							dataGridView.Rows[k].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.filter.Rows[num5].Cells[0].Value);
        //							dataGridView.Rows[k].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.filter.Rows[num5].Cells[1].Value);
        //							num5 = (int)Math.Round(unchecked((double)num5 + Convert.ToDouble(1)));
        //						}
        //					}
        //				}
        //			}
        //			catch (Exception ex)
        //			{
        //			}
        //			DataTable dataTable = new DataTable("DataTable1");
        //			dataTable.Columns.Add("Column1");
        //			dataTable.Columns.Add("Column2");
        //			dataTable.Columns.Add("Column3");
        //			dataTable.Columns.Add("Column4");
        //			dataTable.Columns.Add("Jama");
        //			try
        //			{
        //				foreach (object obj3 in ((IEnumerable)dataGridView.Rows))
        //				{
        //					DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
        //					dataTable.Rows.Add(new object[]
        //					{
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells[0].Value),
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells[1].Value),
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells[2].Value),
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells[3].Value),
        //						num
        //					});
        //				}
        //			}
        //			finally
        //			{

        //			}
        //			dataSet.Tables.Add(dataTable);
        //			this.Neva_Totla_RinkuBhaiya_Setcode();
        //			DataTable dataTable2 = new DataTable("DataTable2");
        //			dataTable2.Columns.Add("Column1");
        //			dataTable2.Columns.Add("Column2");
        //			dataTable2.Columns.Add("Column3");
        //			dataTable2.Columns.Add("Column4");
        //			dataTable2.Columns.Add("Neva");
        //			try
        //			{
        //				foreach (object obj4 in ((IEnumerable)this.DataGridView9.Rows))
        //				{
        //					DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
        //					dataTable2.Rows.Add(new object[]
        //					{
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells[0].Value),
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells[1].Value),
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells[2].Value),
        //						RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells[3].Value),
        //						this._NevaTotals
        //					});
        //				}
        //			}
        //			finally
        //			{

        //			}
        //			dataSet.Tables.Add(dataTable2);
        //			print_view printView = new print_view();
        //			ReportDocument reportDocument = new ReportDocument();
        //			reportDocument.Load(Application.StartupPath + "\\RPT\\FinalTB_Report.rpt");
        //			reportDocument.SetDataSource(dataSet);
        //			printView.crystalReportViewer1.ReportSource = reportDocument;
        //			printView.ShowDialog();
        //		}
        //	}
        //	catch (Exception ex2)
        //	{
        //		Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
        //	}
        //}

        //public void Neva_Totla_RinkuBhaiya_Setcode()
        //{
        //	this.DataGridView8.Rows.Clear();
        //	this.DataGridView9.Rows.Clear();
        //	try
        //	{
        //		foreach (object obj in ((IEnumerable)this.DataGridView20.Rows))
        //		{
        //			DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
        //			if (Operators.ConditionalCompareObjectLess(dataGridViewRow.Cells[2].Value, -9, false))
        //			{
        //				string value = Conversions.ToString(dataGridViewRow.Cells[1].Value);
        //				string value2 = Conversions.ToString(dataGridViewRow.Cells[2].Value);
        //				this._NevaTotals += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value));
        //				int index = this.DataGridView8.Rows.Add();
        //				this.DataGridView8.Rows[index].Cells[0].Value = value;
        //				this.DataGridView8.Rows[index].Cells[1].Value = value2;
        //			}
        //		}
        //	}
        //	finally
        //	{				
        //	}
        //	this.neva_nin();

        //	checked
        //	{
        //		double num3=0;
        //		for (int i = 0; i <= this.DataGridView8.RowCount - 1; i++)
        //		{
        //			num3 = Convert.ToDouble(i);
        //		}
        //		int num4 = (int)Math.Round(Conversion.Val(num3) / 2.0);
        //		num4++;
        //		int num5 = num4;

        //		try
        //		{
        //			for (int j = 0; j <= this.DataGridView8.Rows.Count - 1; j++)
        //			{
        //				if (j <= num5)
        //				{
        //					int index2 = this.DataGridView9.Rows.Add();
        //					this.DataGridView9.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[j].Cells[0].Value);
        //					this.DataGridView9.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[j].Cells[1].Value);
        //				}
        //				else
        //				{
        //					num4++;							
        //					for (int k = 1; k <= this.DataGridView9.Rows.Count - 1; k++)
        //					{
        //						this.DataGridView9.Rows[k].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[num4].Cells[0].Value);
        //						this.DataGridView9.Rows[k].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[num4].Cells[1].Value);
        //						num4 = (int)Math.Round(unchecked((double)num4 + Convert.ToDouble(1)));
        //					}
        //				}
        //			}
        //		}
        //		catch (Exception ex)
        //		{
        //		}
        //	}
        //}

        public void neva_nin()
        {
            try
            {
                foreach (object obj in ((IEnumerable)this.DataGridView20.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    if (Operators.ConditionalCompareObjectLess(dataGridViewRow.Cells[6].Value, -9, false))
                    {
                        string value = Conversions.ToString(dataGridViewRow.Cells[5].Value);
                        string value2 = Conversions.ToString(dataGridViewRow.Cells[6].Value);
                        this._NevaTotals += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[6].Value));
                        int index = this.DataGridView8.Rows.Add();
                        this.DataGridView8.Rows[index].Cells[0].Value = value;
                        this.DataGridView8.Rows[index].Cells[1].Value = value2;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
            finally
            {
            }
        }

        // Token: 0x04000504 RID: 1284
        private double _NevaTotals;

        private void DataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    string Strsql = "";
                    OleDbCommand Cmd;
                    if (e.ColumnIndex == 0 && this.DataGridView10.CurrentRow.Cells[1].Value != null)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView10.CurrentRow.Cells[0].Value, true, false))
                            this.DataGridView10.CurrentRow.Cells[0].Value = false;
                        else
                            this.DataGridView10.CurrentRow.Cells[0].Value = true;

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView10.CurrentRow.Cells[0].Value, true, false))
                        {
                            Strsql = $"UPDATE Trans SET chk = '1' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView10.CurrentRow.Cells[1].Value.ToString() }' ";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
                            }
                        }
                        else
                        {
                            Strsql = $"UPDATE Trans SET chk = '0' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView10.CurrentRow.Cells[1].Value.ToString() }' ";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
                            }
                        }
                    }

                    if (e.ColumnIndex == 4 && this.DataGridView10.CurrentRow.Cells[5].Value != null)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView10.CurrentRow.Cells[4].Value, true, false))
                            this.DataGridView10.CurrentRow.Cells[4].Value = false;
                        else
                            this.DataGridView10.CurrentRow.Cells[4].Value = true;

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView10.CurrentRow.Cells[4].Value, true, false))
                        {
                            Strsql = $"UPDATE Trans SET chk = '1' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView10.CurrentRow.Cells[4].Value.ToString() }' ";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
                            }
                        }
                        else
                        {
                            Strsql = $"UPDATE Trans SET chk = '0' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView10.CurrentRow.Cells[4].Value.ToString() }' ";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
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

        private void DataGridView20_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    string Strsql = "";
                    Module1.conn.Close();
                    if (e.ColumnIndex == 0 && this.DataGridView20.CurrentRow.Cells[1].Value != null)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView20.CurrentRow.Cells[0].Value, true, false))
                            this.DataGridView20.CurrentRow.Cells[0].Value = false;
                        else
                            this.DataGridView20.CurrentRow.Cells[0].Value = true;

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView20.CurrentRow.Cells[0].Value, true, false))
                        {
                            Strsql = $"UPDATE Trans SET chk = '1' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView20.CurrentRow.Cells[1].Value.ToString() }'";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
                            }
                        }
                        else
                        {
                            this.DataGridView20.CurrentRow.Cells[0].Value = true;
                            Strsql = $"UPDATE Trans SET chk = '0' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView20.CurrentRow.Cells[1].Value.ToString() }' ";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
                            }
                        }
                    }

                    if (e.ColumnIndex == 4 && this.DataGridView20.CurrentRow.Cells[5].Value != null)
                    {
                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView20.CurrentRow.Cells[4].Value, true, false))
                            this.DataGridView20.CurrentRow.Cells[4].Value = false;
                        else
                            this.DataGridView20.CurrentRow.Cells[4].Value = true;

                        if (Operators.ConditionalCompareObjectEqual(this.DataGridView20.CurrentRow.Cells[4].Value, true, false))
                        {
                            Strsql = $"UPDATE Trans SET chk = '1' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView20.CurrentRow.Cells[4].Value.ToString() }' ";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
                            }
                        }
                        else
                        {
                            Strsql = $"UPDATE Trans SET chk = '0' WHERE tns_chk = '0' AND tns_Type <> 'Monday Settlement' AND tns_party = '{ this.DataGridView20.CurrentRow.Cells[4].Value.ToString() }' ";
                            using (TransactionService transactionService = new TransactionService())
                            {
                                transactionService.Insert(Strsql);
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

        private void DataGridView10_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.ColumnIndex == 1 && this.DataGridView10.CurrentRow.Cells[1].Value != null)
                    {
                        Module1.tranID = this.DataGridView10.CurrentRow.Cells[1].Value.ToString();
                        AccountLedger accountLedger = new AccountLedger();
                        accountLedger.MdiParent = this.MdiParent;
                        accountLedger.WindowState = FormWindowState.Maximized;
                        accountLedger.Show();
                    }

                    if (e.ColumnIndex == 5 && this.DataGridView10.CurrentRow.Cells[5].Value != null)
                    {
                        Module1.tranID = this.DataGridView10.CurrentRow.Cells[5].Value.ToString();
                        AccountLedger accountLedger = new AccountLedger();
                        accountLedger.MdiParent = this.MdiParent;
                        accountLedger.WindowState = FormWindowState.Maximized;
                        accountLedger.Show();
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        private void DataGridView20_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.ColumnIndex == 1 && this.DataGridView20.CurrentRow.Cells[1].Value != null)
                    {
                        Module1.tranID = this.DataGridView20.CurrentRow.Cells[1].Value.ToString();
                        AccountLedger accountLedger = new AccountLedger();
                        accountLedger.MdiParent = this.MdiParent;
                        accountLedger.WindowState = FormWindowState.Maximized;
                        accountLedger.Show();
                    }

                    if (e.ColumnIndex == 5 && this.DataGridView20.CurrentRow.Cells[5].Value != null)
                    {
                        Module1.tranID = this.DataGridView20.CurrentRow.Cells[5].Value.ToString();
                        AccountLedger accountLedger = new AccountLedger();
                        accountLedger.MdiParent = this.MdiParent;
                        accountLedger.WindowState = FormWindowState.Maximized;
                        accountLedger.Show();
                    }
                }
                catch (Exception ex)
                {
                    App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
                }
            }
        }

        private void txtAgentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ComboBox cmbAgent = this.txtAgentName;
                this.AutoComplete(ref cmbAgent, e, false);
                this.txtAgentName = cmbAgent;
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
                        if (this.txtAgentName.SelectionStart <= 1)
                        {
                            this.txtAgentName.Text = "";
                            return;
                        }
                        if (this.txtAgentName.SelectionLength == 0)
                        {
                            text = this.txtAgentName.Text.Substring(0, this.txtAgentName.Text.Length - 1);
                        }
                        else
                        {
                            text = this.txtAgentName.Text.Substring(0, this.txtAgentName.SelectionStart - 1);
                        }
                    }
                    else if (this.txtAgentName.SelectionLength == 0)
                    {
                        text = this.txtAgentName.Text + Conversions.ToString(e.KeyChar);
                    }
                    else
                    {
                        text = this.txtAgentName.Text.Substring(0, this.txtAgentName.SelectionStart) + Conversions.ToString(e.KeyChar);
                    }
                    int num = this.txtAgentName.FindString(text);
                    if (num != -1)
                    {
                        this.txtAgentName.SelectedText = "";
                        this.txtAgentName.SelectedIndex = num;
                        this.txtAgentName.SelectionStart = text.Length;
                        this.txtAgentName.SelectionLength = this.txtAgentName.Text.Length;
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

        private void txtAgentName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.button5.Focus();
                }
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void DataGridView10_KeyDown(object sender, KeyEventArgs e)
        {
            checked
            {
                try
                {
                    if (e.KeyData == Keys.Enter)
                    {
                        int columnindex = DataGridView10.CurrentCell.ColumnIndex;
                        if ((columnindex == 1 || columnindex == 2) && this.DataGridView10.CurrentRow.Cells[1].Value != null)
                        {
                            Module1.tranID = this.DataGridView10.CurrentRow.Cells[1].Value.ToString();
                            AccountLedger accountLedger = new AccountLedger();
                            accountLedger.MdiParent = this.MdiParent;
                            accountLedger.WindowState = FormWindowState.Maximized;
                            accountLedger.Show();
                        }

                        if ((columnindex == 5 || columnindex == 6) && this.DataGridView10.CurrentRow.Cells[5].Value != null)
                        {
                            Module1.tranID = this.DataGridView10.CurrentRow.Cells[5].Value.ToString();
                            AccountLedger accountLedger = new AccountLedger();
                            accountLedger.MdiParent = this.MdiParent;
                            accountLedger.WindowState = FormWindowState.Maximized;
                            accountLedger.Show();
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

        private void DataGridView20_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int columnindex = DataGridView20.CurrentCell.ColumnIndex;
                    if ((columnindex == 1 || columnindex == 2) && this.DataGridView20.CurrentRow.Cells[1].Value != null)
                    {
                        Module1.tranID = this.DataGridView20.CurrentRow.Cells[1].Value.ToString();
                        AccountLedger accountLedger = new AccountLedger();
                        accountLedger.MdiParent = this.MdiParent;
                        accountLedger.WindowState = FormWindowState.Maximized;
                        accountLedger.Show();
                    }

                    if ((columnindex == 5 || columnindex == 6) && this.DataGridView20.CurrentRow.Cells[5].Value != null)
                    {
                        Module1.tranID = this.DataGridView20.CurrentRow.Cells[5].Value.ToString();
                        AccountLedger accountLedger = new AccountLedger();
                        accountLedger.MdiParent = this.MdiParent;
                        accountLedger.WindowState = FormWindowState.Maximized;
                        accountLedger.Show();
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


