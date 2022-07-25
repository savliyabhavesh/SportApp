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
using App.Service;

namespace YashAksh
{
    public partial class IMP_DATA : Form
    {
        public IMP_DATA()
        {
            this.txtid = new TextBox();
            this.extID = new TextBox();
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection oleDbConnection = new OleDbConnection();
                oleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\IMP\\dbCRICKET.mdb;Jet OLEDB:Database Password=rupeshk;";
                oleDbConnection.Open();
                string cmdText = "SELECT id, cl_name, cl_phone, cl_status, cl_balance_opeining, cl_balance_limit, cl_agent, cl_share_A_match, cl_share_A_session, cl_share_A_abandon, cl_share_A_tie, cl_share_A_transfer, cl_share_S_match, cl_share_S_session, cl_share_S_abandon, cl_share_S_tie, cl_share_S_transfer, cl_partner, cl_share_P_match, cl_share_P_session, cl_share_P_abandon, cl_share_P_tie, cl_share_P_transfer, cl_com_test,cl_com_50, cl_com_40, cl_com_20, cl_com_cup,cl_comission_session FROM(tblClient)";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, oleDbConnection);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                this.DataGridView1.Rows.Clear();
                while (oleDbDataReader.Read())
                {
                    int index = this.DataGridView1.Rows.Add();
                    this.DataGridView1.Rows[index].Cells[0].Value = oleDbDataReader["cl_name"].ToString();
                    this.DataGridView1.Rows[index].Cells[1].Value = oleDbDataReader["cl_phone"].ToString();
                    this.DataGridView1.Rows[index].Cells[2].Value = oleDbDataReader["cl_status"].ToString();
                    this.DataGridView1.Rows[index].Cells[3].Value = oleDbDataReader["cl_balance_opeining"].ToString();
                    this.DataGridView1.Rows[index].Cells[4].Value = oleDbDataReader["cl_balance_limit"].ToString();
                    this.DataGridView1.Rows[index].Cells[5].Value = oleDbDataReader["cl_share_S_match"].ToString();
                    this.DataGridView1.Rows[index].Cells[6].Value = oleDbDataReader["cl_share_S_session"].ToString();
                    this.DataGridView1.Rows[index].Cells[7].Value = oleDbDataReader["cl_share_S_abandon"].ToString();
                    this.DataGridView1.Rows[index].Cells[8].Value = oleDbDataReader["cl_share_S_tie"].ToString();
                    this.DataGridView1.Rows[index].Cells[9].Value = oleDbDataReader["cl_agent"].ToString();
                    this.DataGridView1.Rows[index].Cells[10].Value = oleDbDataReader["cl_share_A_match"].ToString();
                    this.DataGridView1.Rows[index].Cells[11].Value = oleDbDataReader["cl_share_A_session"].ToString();
                    this.DataGridView1.Rows[index].Cells[12].Value = oleDbDataReader["cl_share_A_abandon"].ToString();
                    this.DataGridView1.Rows[index].Cells[13].Value = oleDbDataReader["cl_share_A_tie"].ToString();
                    this.DataGridView1.Rows[index].Cells[14].Value = oleDbDataReader["cl_share_A_transfer"].ToString();
                    this.DataGridView1.Rows[index].Cells[15].Value = oleDbDataReader["cl_partner"].ToString();
                    this.DataGridView1.Rows[index].Cells[16].Value = oleDbDataReader["cl_share_P_match"].ToString();
                    this.DataGridView1.Rows[index].Cells[17].Value = oleDbDataReader["cl_share_P_session"].ToString();
                    this.DataGridView1.Rows[index].Cells[18].Value = oleDbDataReader["cl_share_P_abandon"].ToString();
                    this.DataGridView1.Rows[index].Cells[19].Value = oleDbDataReader["cl_share_P_tie"].ToString();
                    this.DataGridView1.Rows[index].Cells[20].Value = oleDbDataReader["cl_share_P_transfer"].ToString();
                    this.DataGridView1.Rows[index].Cells[21].Value = oleDbDataReader["cl_com_test"].ToString();
                    this.DataGridView1.Rows[index].Cells[22].Value = oleDbDataReader["cl_com_50"].ToString();
                    this.DataGridView1.Rows[index].Cells[23].Value = oleDbDataReader["cl_com_40"].ToString();
                    this.DataGridView1.Rows[index].Cells[24].Value = oleDbDataReader["cl_com_20"].ToString();
                    this.DataGridView1.Rows[index].Cells[25].Value = oleDbDataReader["cl_comission_session"].ToString();
                    this.Button2.Enabled = true;
                }
                oleDbConnection.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Module1.conn.State == ConnectionState.Closed)
                {
                    Module1.conn.Open();
                }
                try
                {
                    foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[0].Value, null, false))
                        {
                            if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[2].Value, "System", false))
                            {
                                if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[3].Value, 0, false))
                                {
                                    string cmdText = $"INSERT INTO OP_BAL (Party_name, Amount, chk, Type, dt)VALUES ('*SHRI MATCH', {dataGridViewRow.Cells[3].Value}, '0', 'Extra', '{DateTime.Now.Date}')";
                                    using (TransactionService transactionService = new TransactionService())
                                    {
                                        transactionService.Insert(cmdText);

                                    }
                                }
                            }
                            else
                            {
                                this.Atouid();
                                if (Module1.conn.State == ConnectionState.Closed)
                                {
                                    Module1.conn.Open();
                                }
                                string cmdText = $"INSERT INTO Newparty (ID, Party_name, Dhara, Status, SMS_charges, Balance_Limit, S_Match, S_Session, S_Abandon, S_Tie, Agent_Name, A_Match, A_Session, A_Abandon, A_Tie, P_Name, P_match, P_session, P_abandon, P_tie, C_Test, C_50, C_40, C_20, cl_share_P_transfer, cl_Agent_commi_Trsf, Comm_On_Hari, S_AKD, A_AKD, P_AKD, cl_com_test, cl_com_50, cl_com_40, cl_com_20, cl_com_cup)VALUES({this.txtid.Text}, '{dataGridViewRow.Cells[0].Value}', '{dataGridViewRow.Cells[1].Value}', '{dataGridViewRow.Cells[2].Value}', {dataGridViewRow.Cells[25].Value}, {dataGridViewRow.Cells[4].Value}, {dataGridViewRow.Cells[5].Value}, {dataGridViewRow.Cells[6].Value}, {dataGridViewRow.Cells[7].Value}, {dataGridViewRow.Cells[8].Value}, '{dataGridViewRow.Cells[9].Value}', {dataGridViewRow.Cells[10].Value}, {dataGridViewRow.Cells[11].Value}, {dataGridViewRow.Cells[12].Value}, {dataGridViewRow.Cells[13].Value}, '{dataGridViewRow.Cells[15].Value}', {dataGridViewRow.Cells[16].Value}, {dataGridViewRow.Cells[17].Value}, {dataGridViewRow.Cells[18].Value}, {dataGridViewRow.Cells[19].Value}, {dataGridViewRow.Cells[21].Value}, {dataGridViewRow.Cells[22].Value}, {dataGridViewRow.Cells[23].Value}, {dataGridViewRow.Cells[24].Value}, {dataGridViewRow.Cells[20].Value}, {dataGridViewRow.Cells[14].Value}, 0, 0, 0, 0, 0, 0, 0, 0, 0)";
                                object right = "Monday Final " + Conversions.ToString(DateTime.Now.Date);
                                string cmdText2 = $"INSERT INTO Trans(tns_party, tns_Amount, tns_Remark, tns_MatchID, tns_dt, tns_Type, tns_Vid, tns_Monday, tns_Sessionid, tns_ModifyID, tns_Monday_Final, tns_Hawala, tns_chk, tns_time) VALUES('{dataGridViewRow.Cells[0].Value}',0.00,'{right}','0','{DateTime.Now.Date}','Monday Settlement','0','0','0',0,'Yes','','0','{Strings.FormatDateTime(DateAndTime.TimeOfDay, DateFormat.LongTime)}')";
                                OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, Module1.conn);
                                oleDbCommand2.ExecuteNonQuery();
                                using (TransactionService transactionService = new TransactionService())
                                {
                                    transactionService.Insert(cmdText);

                                }
                                if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[3].Value, 0, false))
                                {
                                    cmdText = $"INSERT INTO OP_BAL (Party_name, Amount, chk, Type, dt)VALUES('{dataGridViewRow.Cells[0].Value}', {dataGridViewRow.Cells[3].Value}, '0', 'Extra', '{DateTime.Now.Date}')";
                                    using (TransactionService transactionService = new TransactionService())
                                    {
                                        transactionService.Insert(cmdText);

                                    }
                                }
                            }
                        }
                    }
                }
                finally
                {
                    //IEnumerator enumerator;
                    //if (enumerator is IDisposable)
                    //{
                    //	(enumerator as IDisposable).Dispose();
                    //}
                }
                Interaction.MsgBox("Data Import Sucessfully..?", MsgBoxStyle.OkOnly, null);
                this.DataGridView1.Rows.Clear();
                this.Button2.Enabled = false;
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

        public void Atouid()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(ID) from Newparty";
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
                        this.Entry_IDS();
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
        }


        public void Entry_IDS()
        {
            checked
            {
                try
                {
                    if (Module1.conn.State == ConnectionState.Closed)
                    {
                        Module1.conn.Open();
                    }
                    string cmdText = "select max(ID) from Trans";
                    OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
                    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())))
                    {
                        this.extID.Text = "1";
                    }
                    else
                    {
                        int num = Conversions.ToInteger(oleDbCommand.ExecuteScalar());
                        num++;
                        this.extID.Text = Conversions.ToString(num);
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


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Token: 0x04000866 RID: 2150
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        // Token: 0x04000867 RID: 2151
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000868 RID: 2152
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;

        // Token: 0x04000869 RID: 2153
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x0400086A RID: 2154
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x0400086B RID: 2155
        [AccessedThroughProperty("Panel2")]
        private Panel _Panel2;

        // Token: 0x0400086C RID: 2156
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;

        // Token: 0x0400086D RID: 2157
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;

        // Token: 0x0400086E RID: 2158
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;

        // Token: 0x0400086F RID: 2159
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;

        // Token: 0x04000870 RID: 2160
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;

        // Token: 0x04000871 RID: 2161
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;

        // Token: 0x04000872 RID: 2162
        [AccessedThroughProperty("Column6")]
        private DataGridViewTextBoxColumn _Column6;

        // Token: 0x04000873 RID: 2163
        [AccessedThroughProperty("Column7")]
        private DataGridViewTextBoxColumn _Column7;

        // Token: 0x04000874 RID: 2164
        [AccessedThroughProperty("Column8")]
        private DataGridViewTextBoxColumn _Column8;

        // Token: 0x04000875 RID: 2165
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;

        // Token: 0x04000876 RID: 2166
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;

        // Token: 0x04000877 RID: 2167
        [AccessedThroughProperty("Column11")]
        private DataGridViewTextBoxColumn _Column11;

        // Token: 0x04000878 RID: 2168
        [AccessedThroughProperty("Column12")]
        private DataGridViewTextBoxColumn _Column12;

        // Token: 0x04000879 RID: 2169
        [AccessedThroughProperty("Column13")]
        private DataGridViewTextBoxColumn _Column13;

        // Token: 0x0400087A RID: 2170
        [AccessedThroughProperty("Column14")]
        private DataGridViewTextBoxColumn _Column14;

        // Token: 0x0400087B RID: 2171
        [AccessedThroughProperty("Column15")]
        private DataGridViewTextBoxColumn _Column15;

        // Token: 0x0400087C RID: 2172
        [AccessedThroughProperty("Column16")]
        private DataGridViewTextBoxColumn _Column16;

        // Token: 0x0400087D RID: 2173
        [AccessedThroughProperty("Column17")]
        private DataGridViewTextBoxColumn _Column17;

        // Token: 0x0400087E RID: 2174
        [AccessedThroughProperty("Column18")]
        private DataGridViewTextBoxColumn _Column18;

        // Token: 0x0400087F RID: 2175
        [AccessedThroughProperty("Column19")]
        private DataGridViewTextBoxColumn _Column19;

        // Token: 0x04000880 RID: 2176
        [AccessedThroughProperty("Column20")]
        private DataGridViewTextBoxColumn _Column20;

        // Token: 0x04000881 RID: 2177
        [AccessedThroughProperty("Column21")]
        private DataGridViewTextBoxColumn _Column21;

        // Token: 0x04000882 RID: 2178
        [AccessedThroughProperty("Column22")]
        private DataGridViewTextBoxColumn _Column22;

        // Token: 0x04000883 RID: 2179
        [AccessedThroughProperty("Column23")]
        private DataGridViewTextBoxColumn _Column23;

        // Token: 0x04000884 RID: 2180
        [AccessedThroughProperty("Column24")]
        private DataGridViewTextBoxColumn _Column24;

        // Token: 0x04000885 RID: 2181
        [AccessedThroughProperty("Column25")]
        private DataGridViewTextBoxColumn _Column25;

        // Token: 0x04000886 RID: 2182
        [AccessedThroughProperty("Column26")]
        private DataGridViewTextBoxColumn _Column26;

        // Token: 0x04000887 RID: 2183
        private TextBox txtid;

        // Token: 0x04000888 RID: 2184
        private TextBox extID;
    }
}




// Token: 0x170007D3 RID: 2003
// (get) Token: 0x0600142D RID: 5165 RVA: 0x00353A48 File Offset: 0x00351E48
// (set) Token: 0x0600142E RID: 5166 RVA: 0x00353A5C File Offset: 0x00351E5C
//internal virtual Label Label1
//{
//	get
//	{
//		return this._Label1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Label1 = value;
//	}
//}

// Token: 0x170007D4 RID: 2004
// (get) Token: 0x0600142F RID: 5167 RVA: 0x00353A68 File Offset: 0x00351E68
// (set) Token: 0x06001430 RID: 5168 RVA: 0x00353A7C File Offset: 0x00351E7C
//internal virtual Button Button1
//{
//	get
//	{
//		return this._Button1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button1_Click);
//		if (this._Button1 != null)
//		{
//			this._Button1.Click -= value2;
//		}
//		this._Button1 = value;
//		if (this._Button1 != null)
//		{
//			this._Button1.Click += value2;
//		}
//	}
//}

// Token: 0x170007D5 RID: 2005
// (get) Token: 0x06001431 RID: 5169 RVA: 0x00353AC8 File Offset: 0x00351EC8
// (set) Token: 0x06001432 RID: 5170 RVA: 0x00353ADC File Offset: 0x00351EDC
//internal virtual Panel Panel1
//{
//	get
//	{
//		return this._Panel1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel1 = value;
//	}
//}

// Token: 0x170007D6 RID: 2006
// (get) Token: 0x06001433 RID: 5171 RVA: 0x00353AE8 File Offset: 0x00351EE8
// (set) Token: 0x06001434 RID: 5172 RVA: 0x00353AFC File Offset: 0x00351EFC
//internal virtual Button Button3
//{
//	get
//	{
//		return this._Button3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button3_Click);
//		if (this._Button3 != null)
//		{
//			this._Button3.Click -= value2;
//		}
//		this._Button3 = value;
//		if (this._Button3 != null)
//		{
//			this._Button3.Click += value2;
//		}
//	}
//}

// Token: 0x170007D7 RID: 2007
// (get) Token: 0x06001435 RID: 5173 RVA: 0x00353B48 File Offset: 0x00351F48
// (set) Token: 0x06001436 RID: 5174 RVA: 0x00353B5C File Offset: 0x00351F5C
//internal virtual Button Button2
//{
//	get
//	{
//		return this._Button2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		EventHandler value2 = new EventHandler(this.Button2_Click);
//		if (this._Button2 != null)
//		{
//			this._Button2.Click -= value2;
//		}
//		this._Button2 = value;
//		if (this._Button2 != null)
//		{
//			this._Button2.Click += value2;
//		}
//	}
//}

// Token: 0x170007D8 RID: 2008
// (get) Token: 0x06001437 RID: 5175 RVA: 0x00353BA8 File Offset: 0x00351FA8
// (set) Token: 0x06001438 RID: 5176 RVA: 0x00353BBC File Offset: 0x00351FBC
//internal virtual Panel Panel2
//{
//	get
//	{
//		return this._Panel2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Panel2 = value;
//	}
//}

// Token: 0x170007D9 RID: 2009
// (get) Token: 0x06001439 RID: 5177 RVA: 0x00353BC8 File Offset: 0x00351FC8
// (set) Token: 0x0600143A RID: 5178 RVA: 0x00353BDC File Offset: 0x00351FDC
//internal virtual DataGridView DataGridView1
//{
//	get
//	{
//		return this._DataGridView1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
//		if (this._DataGridView1 != null)
//		{
//			this._DataGridView1.CellContentClick -= value2;
//		}
//		this._DataGridView1 = value;
//		if (this._DataGridView1 != null)
//		{
//			this._DataGridView1.CellContentClick += value2;
//		}
//	}
//}

// Token: 0x170007DA RID: 2010
// (get) Token: 0x0600143B RID: 5179 RVA: 0x00353C28 File Offset: 0x00352028
// (set) Token: 0x0600143C RID: 5180 RVA: 0x00353C3C File Offset: 0x0035203C
//internal virtual DataGridViewTextBoxColumn Column1
//{
//	get
//	{
//		return this._Column1;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column1 = value;
//	}
//}

// Token: 0x170007DB RID: 2011
// (get) Token: 0x0600143D RID: 5181 RVA: 0x00353C48 File Offset: 0x00352048
// (set) Token: 0x0600143E RID: 5182 RVA: 0x00353C5C File Offset: 0x0035205C
//internal virtual DataGridViewTextBoxColumn Column2
//{
//	get
//	{
//		return this._Column2;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column2 = value;
//	}
//}

// Token: 0x170007DC RID: 2012
// (get) Token: 0x0600143F RID: 5183 RVA: 0x00353C68 File Offset: 0x00352068
// (set) Token: 0x06001440 RID: 5184 RVA: 0x00353C7C File Offset: 0x0035207C
//internal virtual DataGridViewTextBoxColumn Column3
//{
//	get
//	{
//		return this._Column3;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column3 = value;
//	}
//}

// Token: 0x170007DD RID: 2013
// (get) Token: 0x06001441 RID: 5185 RVA: 0x00353C88 File Offset: 0x00352088
// (set) Token: 0x06001442 RID: 5186 RVA: 0x00353C9C File Offset: 0x0035209C
//internal virtual DataGridViewTextBoxColumn Column4
//{
//	get
//	{
//		return this._Column4;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column4 = value;
//	}
//}

// Token: 0x170007DE RID: 2014
// (get) Token: 0x06001443 RID: 5187 RVA: 0x00353CA8 File Offset: 0x003520A8
// (set) Token: 0x06001444 RID: 5188 RVA: 0x00353CBC File Offset: 0x003520BC
//internal virtual DataGridViewTextBoxColumn Column5
//{
//	get
//	{
//		return this._Column5;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column5 = value;
//	}
//}

// Token: 0x170007DF RID: 2015
// (get) Token: 0x06001445 RID: 5189 RVA: 0x00353CC8 File Offset: 0x003520C8
// (set) Token: 0x06001446 RID: 5190 RVA: 0x00353CDC File Offset: 0x003520DC
//internal virtual DataGridViewTextBoxColumn Column6
//{
//	get
//	{
//		return this._Column6;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column6 = value;
//	}
//}

// Token: 0x170007E0 RID: 2016
// (get) Token: 0x06001447 RID: 5191 RVA: 0x00353CE8 File Offset: 0x003520E8
// (set) Token: 0x06001448 RID: 5192 RVA: 0x00353CFC File Offset: 0x003520FC
//internal virtual DataGridViewTextBoxColumn Column7
//{
//	get
//	{
//		return this._Column7;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column7 = value;
//	}
//}

// Token: 0x170007E1 RID: 2017
// (get) Token: 0x06001449 RID: 5193 RVA: 0x00353D08 File Offset: 0x00352108
// (set) Token: 0x0600144A RID: 5194 RVA: 0x00353D1C File Offset: 0x0035211C
//internal virtual DataGridViewTextBoxColumn Column8
//{
//	get
//	{
//		return this._Column8;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column8 = value;
//	}
//}

// Token: 0x170007E2 RID: 2018
// (get) Token: 0x0600144B RID: 5195 RVA: 0x00353D28 File Offset: 0x00352128
// (set) Token: 0x0600144C RID: 5196 RVA: 0x00353D3C File Offset: 0x0035213C
//internal virtual DataGridViewTextBoxColumn Column9
//{
//	get
//	{
//		return this._Column9;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column9 = value;
//	}
//}

// Token: 0x170007E3 RID: 2019
// (get) Token: 0x0600144D RID: 5197 RVA: 0x00353D48 File Offset: 0x00352148
// (set) Token: 0x0600144E RID: 5198 RVA: 0x00353D5C File Offset: 0x0035215C
//internal virtual DataGridViewTextBoxColumn Column10
//{
//	get
//	{
//		return this._Column10;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column10 = value;
//	}
//}

// Token: 0x170007E4 RID: 2020
// (get) Token: 0x0600144F RID: 5199 RVA: 0x00353D68 File Offset: 0x00352168
// (set) Token: 0x06001450 RID: 5200 RVA: 0x00353D7C File Offset: 0x0035217C
//internal virtual DataGridViewTextBoxColumn Column11
//{
//	get
//	{
//		return this._Column11;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column11 = value;
//	}
//}

// Token: 0x170007E5 RID: 2021
// (get) Token: 0x06001451 RID: 5201 RVA: 0x00353D88 File Offset: 0x00352188
// (set) Token: 0x06001452 RID: 5202 RVA: 0x00353D9C File Offset: 0x0035219C
//internal virtual DataGridViewTextBoxColumn Column12
//{
//	get
//	{
//		return this._Column12;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column12 = value;
//	}
//}

// Token: 0x170007E6 RID: 2022
// (get) Token: 0x06001453 RID: 5203 RVA: 0x00353DA8 File Offset: 0x003521A8
// (set) Token: 0x06001454 RID: 5204 RVA: 0x00353DBC File Offset: 0x003521BC
//internal virtual DataGridViewTextBoxColumn Column13
//{
//	get
//	{
//		return this._Column13;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column13 = value;
//	}
//}

// Token: 0x170007E7 RID: 2023
// (get) Token: 0x06001455 RID: 5205 RVA: 0x00353DC8 File Offset: 0x003521C8
// (set) Token: 0x06001456 RID: 5206 RVA: 0x00353DDC File Offset: 0x003521DC
//internal virtual DataGridViewTextBoxColumn Column14
//{
//	get
//	{
//		return this._Column14;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column14 = value;
//	}
//}

// Token: 0x170007E8 RID: 2024
// (get) Token: 0x06001457 RID: 5207 RVA: 0x00353DE8 File Offset: 0x003521E8
// (set) Token: 0x06001458 RID: 5208 RVA: 0x00353DFC File Offset: 0x003521FC
//internal virtual DataGridViewTextBoxColumn Column15
//{
//	get
//	{
//		return this._Column15;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column15 = value;
//	}
//}

// Token: 0x170007E9 RID: 2025
// (get) Token: 0x06001459 RID: 5209 RVA: 0x00353E08 File Offset: 0x00352208
// (set) Token: 0x0600145A RID: 5210 RVA: 0x00353E1C File Offset: 0x0035221C
//internal virtual DataGridViewTextBoxColumn Column16
//{
//	get
//	{
//		return this._Column16;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column16 = value;
//	}
//}

// Token: 0x170007EA RID: 2026
// (get) Token: 0x0600145B RID: 5211 RVA: 0x00353E28 File Offset: 0x00352228
// (set) Token: 0x0600145C RID: 5212 RVA: 0x00353E3C File Offset: 0x0035223C
//internal virtual DataGridViewTextBoxColumn Column17
//{
//	get
//	{
//		return this._Column17;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column17 = value;
//	}
//}

// Token: 0x170007EB RID: 2027
// (get) Token: 0x0600145D RID: 5213 RVA: 0x00353E48 File Offset: 0x00352248
// (set) Token: 0x0600145E RID: 5214 RVA: 0x00353E5C File Offset: 0x0035225C
//internal virtual DataGridViewTextBoxColumn Column18
//{
//	get
//	{
//		return this._Column18;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column18 = value;
//	}
//}

// Token: 0x170007EC RID: 2028
// (get) Token: 0x0600145F RID: 5215 RVA: 0x00353E68 File Offset: 0x00352268
// (set) Token: 0x06001460 RID: 5216 RVA: 0x00353E7C File Offset: 0x0035227C
//internal virtual DataGridViewTextBoxColumn Column19
//{
//	get
//	{
//		return this._Column19;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column19 = value;
//	}
//}

// Token: 0x170007ED RID: 2029
// (get) Token: 0x06001461 RID: 5217 RVA: 0x00353E88 File Offset: 0x00352288
// (set) Token: 0x06001462 RID: 5218 RVA: 0x00353E9C File Offset: 0x0035229C
//internal virtual DataGridViewTextBoxColumn Column20
//{
//	get
//	{
//		return this._Column20;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column20 = value;
//	}
//}

// Token: 0x170007EE RID: 2030
// (get) Token: 0x06001463 RID: 5219 RVA: 0x00353EA8 File Offset: 0x003522A8
// (set) Token: 0x06001464 RID: 5220 RVA: 0x00353EBC File Offset: 0x003522BC
//internal virtual DataGridViewTextBoxColumn Column21
//{
//	get
//	{
//		return this._Column21;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column21 = value;
//	}
//}

// Token: 0x170007EF RID: 2031
// (get) Token: 0x06001465 RID: 5221 RVA: 0x00353EC8 File Offset: 0x003522C8
// (set) Token: 0x06001466 RID: 5222 RVA: 0x00353EDC File Offset: 0x003522DC
//internal virtual DataGridViewTextBoxColumn Column22
//{
//	get
//	{
//		return this._Column22;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column22 = value;
//	}
//}

// Token: 0x170007F0 RID: 2032
// (get) Token: 0x06001467 RID: 5223 RVA: 0x00353EE8 File Offset: 0x003522E8
// (set) Token: 0x06001468 RID: 5224 RVA: 0x00353EFC File Offset: 0x003522FC
//internal virtual DataGridViewTextBoxColumn Column23
//{
//	get
//	{
//		return this._Column23;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column23 = value;
//	}
//}

// Token: 0x170007F1 RID: 2033
// (get) Token: 0x06001469 RID: 5225 RVA: 0x00353F08 File Offset: 0x00352308
// (set) Token: 0x0600146A RID: 5226 RVA: 0x00353F1C File Offset: 0x0035231C
//internal virtual DataGridViewTextBoxColumn Column24
//{
//	get
//	{
//		return this._Column24;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column24 = value;
//	}
//}

// Token: 0x170007F2 RID: 2034
// (get) Token: 0x0600146B RID: 5227 RVA: 0x00353F28 File Offset: 0x00352328
// (set) Token: 0x0600146C RID: 5228 RVA: 0x00353F3C File Offset: 0x0035233C
//internal virtual DataGridViewTextBoxColumn Column25
//{
//	get
//	{
//		return this._Column25;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column25 = value;
//	}
//}

// Token: 0x170007F3 RID: 2035
// (get) Token: 0x0600146D RID: 5229 RVA: 0x00353F48 File Offset: 0x00352348
// (set) Token: 0x0600146E RID: 5230 RVA: 0x00353F5C File Offset: 0x0035235C
//internal virtual DataGridViewTextBoxColumn Column26
//{
//	get
//	{
//		return this._Column26;
//	}
//	[MethodImpl(MethodImplOptions.Synchronized)]
//	set
//	{
//		this._Column26 = value;
//	}
//}

