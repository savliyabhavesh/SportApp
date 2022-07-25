using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace YashAksh.DataSet1TableAdapters
{
	// Token: 0x02000037 RID: 55
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[ToolboxItem(true)]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class NewpartyTableAdapter : Component
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x002D82F8 File Offset: 0x002D66F8
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x002D830C File Offset: 0x002D670C
		internal virtual OleDbDataAdapter _adapter
		{
			get
			{
				return this.__adapter;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__adapter = value;
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x002D8318 File Offset: 0x002D6718
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NewpartyTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x002D8328 File Offset: 0x002D6728
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal OleDbDataAdapter Adapter
		{
			get
			{
				if (this._adapter == null)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x002D834C File Offset: 0x002D674C
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x002D8370 File Offset: 0x002D6770
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal OleDbConnection Connection
		{
			get
			{
				if (this._connection == null)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				if (this.Adapter.InsertCommand != null)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				if (this.Adapter.DeleteCommand != null)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				if (this.Adapter.UpdateCommand != null)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						if (this.CommandCollection[i] != null)
						{
							this.CommandCollection[i].Connection = value;
						}
					}
				}
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x002D840C File Offset: 0x002D680C
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x002D8420 File Offset: 0x002D6820
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal OleDbTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						this.CommandCollection[i].Transaction = this._transaction;
					}
					if (this.Adapter != null && this.Adapter.DeleteCommand != null)
					{
						this.Adapter.DeleteCommand.Transaction = this._transaction;
					}
					if (this.Adapter != null && this.Adapter.InsertCommand != null)
					{
						this.Adapter.InsertCommand.Transaction = this._transaction;
					}
					if (this.Adapter != null && this.Adapter.UpdateCommand != null)
					{
						this.Adapter.UpdateCommand.Transaction = this._transaction;
					}
				}
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x002D84DC File Offset: 0x002D68DC
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected OleDbCommand[] CommandCollection
		{
			get
			{
				if (this._commandCollection == null)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x002D8500 File Offset: 0x002D6900
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x002D8514 File Offset: 0x002D6914
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x002D8520 File Offset: 0x002D6920
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new OleDbDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "Newparty";
			dataTableMapping.ColumnMappings.Add("ID", "ID");
			dataTableMapping.ColumnMappings.Add("Party_name", "Party_name");
			dataTableMapping.ColumnMappings.Add("Dhara", "Dhara");
			dataTableMapping.ColumnMappings.Add("Comm_On_Hari", "Comm_On_Hari");
			dataTableMapping.ColumnMappings.Add("S_Match", "S_Match");
			dataTableMapping.ColumnMappings.Add("Agent_Name", "Agent_Name");
			dataTableMapping.ColumnMappings.Add("A_Match", "A_Match");
			dataTableMapping.ColumnMappings.Add("P_Name", "P_Name");
			dataTableMapping.ColumnMappings.Add("P_match", "P_match");
			this._adapter.TableMappings.Add(dataTableMapping);
			this._adapter.DeleteCommand = new OleDbCommand();
			this._adapter.DeleteCommand.Connection = this.Connection;
			this._adapter.DeleteCommand.CommandText = "DELETE FROM `Newparty` WHERE ((`ID` = ?) AND ((? = 1 AND `Party_name` IS NULL) OR (`Party_name` = ?)) AND ((? = 1 AND `Dhara` IS NULL) OR (`Dhara` = ?)) AND ((? = 1 AND `Comm_On_Hari` IS NULL) OR (`Comm_On_Hari` = ?)) AND ((? = 1 AND `S_Match` IS NULL) OR (`S_Match` = ?)) AND ((? = 1 AND `Agent_Name` IS NULL) OR (`Agent_Name` = ?)) AND ((? = 1 AND `A_Match` IS NULL) OR (`A_Match` = ?)) AND ((? = 1 AND `P_Name` IS NULL) OR (`P_Name` = ?)) AND ((? = 1 AND `P_match` IS NULL) OR (`P_match` = ?)))";
			this._adapter.DeleteCommand.CommandType = CommandType.Text;
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Party_name", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Party_name", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Party_name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Party_name", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Dhara", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Dhara", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Dhara", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Dhara", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Comm_On_Hari", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Comm_On_Hari", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Comm_On_Hari", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "Comm_On_Hari", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_S_Match", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "S_Match", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_S_Match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "S_Match", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_Agent_Name", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Agent_Name", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Agent_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Agent_Name", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_A_Match", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "A_Match", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_A_Match", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "A_Match", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_P_Name", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "P_Name", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_P_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "P_Name", DataRowVersion.Original, false, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("IsNull_P_match", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "P_match", DataRowVersion.Original, true, null));
			this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_P_match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "P_match", DataRowVersion.Original, false, null));
			this._adapter.InsertCommand = new OleDbCommand();
			this._adapter.InsertCommand.Connection = this.Connection;
			this._adapter.InsertCommand.CommandText = "INSERT INTO `Newparty` (`ID`, `Party_name`, `Dhara`, `Comm_On_Hari`, `S_Match`, `Agent_Name`, `A_Match`, `P_Name`, `P_match`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this._adapter.InsertCommand.CommandType = CommandType.Text;
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Party_name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Party_name", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Dhara", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Dhara", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Comm_On_Hari", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "Comm_On_Hari", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("S_Match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "S_Match", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Agent_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Agent_Name", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("A_Match", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "A_Match", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("P_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "P_Name", DataRowVersion.Current, false, null));
			this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("P_match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "P_match", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand = new OleDbCommand();
			this._adapter.UpdateCommand.Connection = this.Connection;
			this._adapter.UpdateCommand.CommandText = "UPDATE `Newparty` SET `ID` = ?, `Party_name` = ?, `Dhara` = ?, `Comm_On_Hari` = ?, `S_Match` = ?, `Agent_Name` = ?, `A_Match` = ?, `P_Name` = ?, `P_match` = ? WHERE ((`ID` = ?) AND ((? = 1 AND `Party_name` IS NULL) OR (`Party_name` = ?)) AND ((? = 1 AND `Dhara` IS NULL) OR (`Dhara` = ?)) AND ((? = 1 AND `Comm_On_Hari` IS NULL) OR (`Comm_On_Hari` = ?)) AND ((? = 1 AND `S_Match` IS NULL) OR (`S_Match` = ?)) AND ((? = 1 AND `Agent_Name` IS NULL) OR (`Agent_Name` = ?)) AND ((? = 1 AND `A_Match` IS NULL) OR (`A_Match` = ?)) AND ((? = 1 AND `P_Name` IS NULL) OR (`P_Name` = ?)) AND ((? = 1 AND `P_match` IS NULL) OR (`P_match` = ?)))";
			this._adapter.UpdateCommand.CommandType = CommandType.Text;
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Party_name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Party_name", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Dhara", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Dhara", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Comm_On_Hari", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "Comm_On_Hari", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("S_Match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "S_Match", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Agent_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Agent_Name", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("A_Match", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "A_Match", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("P_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "P_Name", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("P_match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "P_match", DataRowVersion.Current, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_ID", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "ID", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Party_name", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Party_name", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Party_name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Party_name", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Dhara", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Dhara", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Dhara", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Dhara", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Comm_On_Hari", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Comm_On_Hari", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Comm_On_Hari", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "Comm_On_Hari", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_S_Match", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "S_Match", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_S_Match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "S_Match", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_Agent_Name", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "Agent_Name", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Agent_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "Agent_Name", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_A_Match", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "A_Match", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_A_Match", OleDbType.Currency, 0, ParameterDirection.Input, 0, 0, "A_Match", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_P_Name", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "P_Name", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_P_Name", OleDbType.VarWChar, 0, ParameterDirection.Input, 0, 0, "P_Name", DataRowVersion.Original, false, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("IsNull_P_match", OleDbType.Integer, 0, ParameterDirection.Input, 0, 0, "P_match", DataRowVersion.Original, true, null));
			this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_P_match", OleDbType.Double, 0, ParameterDirection.Input, 0, 0, "P_match", DataRowVersion.Original, false, null));
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x002D9144 File Offset: 0x002D7544
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitConnection()
		{
			this._connection = new OleDbConnection();
			this._connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\bin\\x86\\Debug\\DB\\MYDB.mdb;Persist Security Info=True";
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x002D9164 File Offset: 0x002D7564
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitCommandCollection()
		{
			this._commandCollection = new OleDbCommand[1];
			this._commandCollection[0] = new OleDbCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT        ID, Party_name, Dhara, Comm_On_Hari, S_Match, Agent_Name, A_Match, P_Name, P_match\r\nFROM            Newparty\r\nWHERE        (ID <> 1) AND (ID <> 2) AND (ID <> 3) AND (ID <> 4)\r\nORDER BY Party_name";
			this._commandCollection[0].CommandType = CommandType.Text;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x002D91C0 File Offset: 0x002D75C0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(DataSet1.NewpartyDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x002D91FC File Offset: 0x002D75FC
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DebuggerNonUserCode]
		public virtual DataSet1.NewpartyDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			DataSet1.NewpartyDataTable newpartyDataTable = new DataSet1.NewpartyDataTable();
			this.Adapter.Fill(newpartyDataTable);
			return newpartyDataTable;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x002D9230 File Offset: 0x002D7630
		[HelpKeyword("vs.data.TableAdapter")]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual int Update(DataSet1.NewpartyDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x002D924C File Offset: 0x002D764C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataSet1 dataSet)
		{
			return this.Adapter.Update(dataSet, "Newparty");
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x002D926C File Offset: 0x002D766C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DebuggerNonUserCode]
		public virtual int Update(DataRow dataRow)
		{
			return this.Adapter.Update(new DataRow[]
			{
				dataRow
			});
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x002D9290 File Offset: 0x002D7690
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DebuggerNonUserCode]
		public virtual int Update(DataRow[] dataRows)
		{
			return this.Adapter.Update(dataRows);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x002D92AC File Offset: 0x002D76AC
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		public virtual int Delete(int? Original_ID, string Original_Party_name, string Original_Dhara, decimal? Original_Comm_On_Hari, double? Original_S_Match, string Original_Agent_Name, decimal? Original_A_Match, string Original_P_Name, double? Original_P_match)
		{
			if (Original_ID != null)
			{
				this.Adapter.DeleteCommand.Parameters[0].Value = Original_ID.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[0].Value = DBNull.Value;
			}
			if (Original_Party_name == null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_Party_name;
			}
			if (Original_Dhara == null)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_Dhara;
			}
			if (Original_Comm_On_Hari != null)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_Comm_On_Hari.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			if (Original_S_Match != null)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_S_Match.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			if (Original_Agent_Name == null)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_Agent_Name;
			}
			if (Original_A_Match != null)
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 0;
				this.Adapter.DeleteCommand.Parameters[12].Value = Original_A_Match.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 1;
				this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
			}
			if (Original_P_Name == null)
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 1;
				this.Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 0;
				this.Adapter.DeleteCommand.Parameters[14].Value = Original_P_Name;
			}
			if (Original_P_match != null)
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 0;
				this.Adapter.DeleteCommand.Parameters[16].Value = Original_P_match.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 1;
				this.Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
			}
			ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
			if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.DeleteCommand.Connection.Open();
			}
			int result;
			try
			{
				int num = this.Adapter.DeleteCommand.ExecuteNonQuery();
				result = num;
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					this.Adapter.DeleteCommand.Connection.Close();
				}
			}
			return result;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x002D9804 File Offset: 0x002D7C04
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Insert(int? ID, string Party_name, string Dhara, decimal? Comm_On_Hari, double? S_Match, string Agent_Name, decimal? A_Match, string P_Name, double? P_match)
		{
			if (ID != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = ID.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (Party_name == null)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = Party_name;
			}
			if (Dhara == null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = Dhara;
			}
			if (Comm_On_Hari != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = Comm_On_Hari.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (S_Match != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = S_Match.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Agent_Name == null)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = Agent_Name;
			}
			if (A_Match != null)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = A_Match.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			if (P_Name == null)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = P_Name;
			}
			if (P_match != null)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = P_match.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			ConnectionState state = this.Adapter.InsertCommand.Connection.State;
			if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.InsertCommand.Connection.Open();
			}
			int result;
			try
			{
				int num = this.Adapter.InsertCommand.ExecuteNonQuery();
				result = num;
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					this.Adapter.InsertCommand.Connection.Close();
				}
			}
			return result;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x002D9B3C File Offset: 0x002D7F3C
		[DataObjectMethod(DataObjectMethodType.Update, true)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(int? ID, string Party_name, string Dhara, decimal? Comm_On_Hari, double? S_Match, string Agent_Name, decimal? A_Match, string P_Name, double? P_match, int? Original_ID, string Original_Party_name, string Original_Dhara, decimal? Original_Comm_On_Hari, double? Original_S_Match, string Original_Agent_Name, decimal? Original_A_Match, string Original_P_Name, double? Original_P_match)
		{
			if (ID != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = ID.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (Party_name == null)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = Party_name;
			}
			if (Dhara == null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = Dhara;
			}
			if (Comm_On_Hari != null)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = Comm_On_Hari.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			if (S_Match != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = S_Match.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Agent_Name == null)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = Agent_Name;
			}
			if (A_Match != null)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = A_Match.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			if (P_Name == null)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = P_Name;
			}
			if (P_match != null)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = P_match.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			if (Original_ID != null)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = Original_ID.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			if (Original_Party_name == null)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 1;
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 0;
				this.Adapter.UpdateCommand.Parameters[11].Value = Original_Party_name;
			}
			if (Original_Dhara == null)
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 1;
				this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 0;
				this.Adapter.UpdateCommand.Parameters[13].Value = Original_Dhara;
			}
			if (Original_Comm_On_Hari != null)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 0;
				this.Adapter.UpdateCommand.Parameters[15].Value = Original_Comm_On_Hari.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 1;
				this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
			}
			if (Original_S_Match != null)
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 0;
				this.Adapter.UpdateCommand.Parameters[17].Value = Original_S_Match.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 1;
				this.Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
			}
			if (Original_Agent_Name == null)
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 1;
				this.Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 0;
				this.Adapter.UpdateCommand.Parameters[19].Value = Original_Agent_Name;
			}
			if (Original_A_Match != null)
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 0;
				this.Adapter.UpdateCommand.Parameters[21].Value = Original_A_Match.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 1;
				this.Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
			}
			if (Original_P_Name == null)
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 1;
				this.Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 0;
				this.Adapter.UpdateCommand.Parameters[23].Value = Original_P_Name;
			}
			if (Original_P_match != null)
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 0;
				this.Adapter.UpdateCommand.Parameters[25].Value = Original_P_match.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 1;
				this.Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
			}
			ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
			if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.UpdateCommand.Connection.Open();
			}
			int result;
			try
			{
				int num = this.Adapter.UpdateCommand.ExecuteNonQuery();
				result = num;
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					this.Adapter.UpdateCommand.Connection.Close();
				}
			}
			return result;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x002DA34C File Offset: 0x002D874C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Update, true)]
		public virtual int Update(string Party_name, string Dhara, decimal? Comm_On_Hari, double? S_Match, string Agent_Name, decimal? A_Match, string P_Name, double? P_match, int? Original_ID, string Original_Party_name, string Original_Dhara, decimal? Original_Comm_On_Hari, double? Original_S_Match, string Original_Agent_Name, decimal? Original_A_Match, string Original_P_Name, double? Original_P_match)
		{
			return this.Update(Original_ID, Party_name, Dhara, Comm_On_Hari, S_Match, Agent_Name, A_Match, P_Name, P_match, Original_ID, Original_Party_name, Original_Dhara, Original_Comm_On_Hari, Original_S_Match, Original_Agent_Name, Original_A_Match, Original_P_Name, Original_P_match);
		}

		// Token: 0x0400036B RID: 875
		[AccessedThroughProperty("_adapter")]
		private OleDbDataAdapter __adapter;

		// Token: 0x0400036C RID: 876
		private OleDbConnection _connection;

		// Token: 0x0400036D RID: 877
		private OleDbTransaction _transaction;

		// Token: 0x0400036E RID: 878
		private OleDbCommand[] _commandCollection;

		// Token: 0x0400036F RID: 879
		private bool _clearBeforeFill;
	}
}
