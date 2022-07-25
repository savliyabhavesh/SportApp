using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;

namespace YashAksh.DataSet1TableAdapters
{
	// Token: 0x02000038 RID: 56
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[ToolboxItem(true)]
	[HelpKeyword("vs.data.TableAdapterManager")]
	[DesignerCategory("code")]
	public class TableAdapterManager : Component
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x002DA388 File Offset: 0x002D8788
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x002DA39C File Offset: 0x002D879C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public TableAdapterManager.UpdateOrderOption UpdateOrder
		{
			get
			{
				return this._updateOrder;
			}
			set
			{
				this._updateOrder = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x002DA3A8 File Offset: 0x002D87A8
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x002DA3BC File Offset: 0x002D87BC
		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NewpartyTableAdapter NewpartyTableAdapter
		{
			get
			{
				return this._newpartyTableAdapter;
			}
			set
			{
				this._newpartyTableAdapter = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x002DA3C8 File Offset: 0x002D87C8
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x002DA3DC File Offset: 0x002D87DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return this._backupDataSetBeforeUpdate;
			}
			set
			{
				this._backupDataSetBeforeUpdate = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x002DA3E8 File Offset: 0x002D87E8
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x002DA428 File Offset: 0x002D8828
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public IDbConnection Connection
		{
			get
			{
				if (this._connection != null)
				{
					return this._connection;
				}
				if (this._newpartyTableAdapter != null && this._newpartyTableAdapter.Connection != null)
				{
					return this._newpartyTableAdapter.Connection;
				}
				return null;
			}
			set
			{
				this._connection = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x002DA434 File Offset: 0x002D8834
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TableAdapterInstanceCount
		{
			get
			{
				int num = 0;
				checked
				{
					if (this._newpartyTableAdapter != null)
					{
						num++;
					}
					return num;
				}
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x002DA450 File Offset: 0x002D8850
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateUpdatedRows(DataSet1 dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			int num = 0;
			checked
			{
				if (this._newpartyTableAdapter != null)
				{
					DataRow[] array = dataSet.Newparty.Select(null, null, DataViewRowState.ModifiedCurrent);
					array = this.GetRealUpdatedRows(array, allAddedRows);
					if (array != null && 0 < array.Length)
					{
						num += this._newpartyTableAdapter.Update(array);
						allChangedRows.AddRange(array);
					}
				}
				return num;
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x002DA4A0 File Offset: 0x002D88A0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateInsertedRows(DataSet1 dataSet, List<DataRow> allAddedRows)
		{
			int num = 0;
			checked
			{
				if (this._newpartyTableAdapter != null)
				{
					DataRow[] array = dataSet.Newparty.Select(null, null, DataViewRowState.Added);
					if (array != null && 0 < array.Length)
					{
						num += this._newpartyTableAdapter.Update(array);
						allAddedRows.AddRange(array);
					}
				}
				return num;
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x002DA4E8 File Offset: 0x002D88E8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateDeletedRows(DataSet1 dataSet, List<DataRow> allChangedRows)
		{
			int num = 0;
			checked
			{
				if (this._newpartyTableAdapter != null)
				{
					DataRow[] array = dataSet.Newparty.Select(null, null, DataViewRowState.Deleted);
					if (array != null && 0 < array.Length)
					{
						num += this._newpartyTableAdapter.Update(array);
						allChangedRows.AddRange(array);
					}
				}
				return num;
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x002DA530 File Offset: 0x002D8930
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			if (updatedRows == null || updatedRows.Length < 1)
			{
				return updatedRows;
			}
			if (allAddedRows == null || allAddedRows.Count < 1)
			{
				return updatedRows;
			}
			List<DataRow> list = new List<DataRow>();
			foreach (DataRow item in updatedRows)
			{
				if (!allAddedRows.Contains(item))
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x002DA584 File Offset: 0x002D8984
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual int UpdateAll(DataSet1 dataSet)
		{
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (!dataSet.HasChanges())
			{
				return 0;
			}
			if (this._newpartyTableAdapter != null && !this.MatchTableAdapterConnection(this._newpartyTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			IDbConnection connection = this.Connection;
			if (connection == null)
			{
				throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
			}
			bool flag = false;
			if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
			{
				connection.Close();
			}
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				flag = true;
			}
			IDbTransaction dbTransaction = connection.BeginTransaction();
			if (dbTransaction == null)
			{
				throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
			}
			List<DataRow> list = new List<DataRow>();
			List<DataRow> list2 = new List<DataRow>();
			List<DataAdapter> list3 = new List<DataAdapter>();
			Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
			int num = 0;
			DataSet dataSet2 = null;
			if (this.BackupDataSetBeforeUpdate)
			{
				dataSet2 = new DataSet();
				dataSet2.Merge(dataSet);
			}
			checked
			{
				try
				{
					if (this._newpartyTableAdapter != null)
					{
						dictionary.Add(this._newpartyTableAdapter, this._newpartyTableAdapter.Connection);
						this._newpartyTableAdapter.Connection = (OleDbConnection)connection;
						this._newpartyTableAdapter.Transaction = (OleDbTransaction)dbTransaction;
						if (this._newpartyTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							this._newpartyTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(this._newpartyTableAdapter.Adapter);
						}
					}
					if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
					{
						num += this.UpdateUpdatedRows(dataSet, list, list2);
						num += this.UpdateInsertedRows(dataSet, list2);
					}
					else
					{
						num += this.UpdateInsertedRows(dataSet, list2);
						num += this.UpdateUpdatedRows(dataSet, list, list2);
					}
					num += this.UpdateDeletedRows(dataSet, list);
					dbTransaction.Commit();
					if (0 < list2.Count)
					{
						DataRow[] array = new DataRow[list2.Count - 1 + 1];
						list2.CopyTo(array);
						foreach (DataRow dataRow in array)
						{
							dataRow.AcceptChanges();
						}
					}
					if (0 < list.Count)
					{
						DataRow[] array2 = new DataRow[list.Count - 1 + 1];
						list.CopyTo(array2);
						foreach (DataRow dataRow2 in array2)
						{
							dataRow2.AcceptChanges();
						}
					}
				}
				catch (Exception ex)
				{
					dbTransaction.Rollback();
					if (this.BackupDataSetBeforeUpdate)
					{
						dataSet.Clear();
						dataSet.Merge(dataSet2);
					}
					else if (0 < list2.Count)
					{
						DataRow[] array3 = new DataRow[list2.Count - 1 + 1];
						list2.CopyTo(array3);
						foreach (DataRow dataRow3 in array3)
						{
							dataRow3.AcceptChanges();
							dataRow3.SetAdded();
						}
					}
					throw ex;
				}
				finally
				{
					if (flag)
					{
						connection.Close();
					}
					if (this._newpartyTableAdapter != null)
					{
						this._newpartyTableAdapter.Connection = (OleDbConnection)dictionary[this._newpartyTableAdapter];
						this._newpartyTableAdapter.Transaction = null;
					}
					if (0 < list3.Count)
					{
						DataAdapter[] array4 = new DataAdapter[list3.Count - 1 + 1];
						list3.CopyTo(array4);
						foreach (DataAdapter dataAdapter in array4)
						{
							dataAdapter.AcceptChangesDuringUpdate = true;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x002DA8E0 File Offset: 0x002D8CE0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort<DataRow>(rows, new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x002DA8F0 File Offset: 0x002D8CF0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			return this._connection != null || (this.Connection == null || inputConnection == null) || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);
		}

		// Token: 0x04000370 RID: 880
		private TableAdapterManager.UpdateOrderOption _updateOrder;

		// Token: 0x04000371 RID: 881
		private NewpartyTableAdapter _newpartyTableAdapter;

		// Token: 0x04000372 RID: 882
		private bool _backupDataSetBeforeUpdate;

		// Token: 0x04000373 RID: 883
		private IDbConnection _connection;

		// Token: 0x02000039 RID: 57
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public enum UpdateOrderOption
		{
			// Token: 0x04000375 RID: 885
			InsertUpdateDelete,
			// Token: 0x04000376 RID: 886
			UpdateInsertDelete
		}

		// Token: 0x0200003A RID: 58
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			// Token: 0x0600090C RID: 2316 RVA: 0x002DA930 File Offset: 0x002D8D30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				this._relation = relation;
				if (childFirst)
				{
					this._childFirst = -1;
				}
				else
				{
					this._childFirst = 1;
				}
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x002DA954 File Offset: 0x002D8D54
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private DataRow GetRoot(DataRow row, ref int distance)
			{
				DataRow result = row;
				distance = 0;
				IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
				dictionary[row] = row;
				DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Default);
				checked
				{
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						distance++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default);
					}
					if (distance == 0)
					{
						dictionary.Clear();
						dictionary[row] = row;
						parentRow = row.GetParentRow(this._relation, DataRowVersion.Original);
						while (parentRow != null && !dictionary.ContainsKey(parentRow))
						{
							distance++;
							result = parentRow;
							dictionary[parentRow] = parentRow;
							parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original);
						}
					}
					return result;
				}
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x002DAA0C File Offset: 0x002D8E0C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Compare(DataRow row1, DataRow row2)
			{
				if (object.ReferenceEquals(row1, row2))
				{
					return 0;
				}
				if (row1 == null)
				{
					return -1;
				}
				if (row2 == null)
				{
					return 1;
				}
				int num = 0;
				DataRow root = this.GetRoot(row1, ref num);
				int value = 0;
				DataRow root2 = this.GetRoot(row2, ref value);
				if (object.ReferenceEquals(root, root2))
				{
					return checked(this._childFirst * num.CompareTo(value));
				}
				if (root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2))
				{
					return -1;
				}
				return 1;
			}

			// Token: 0x04000377 RID: 887
			private DataRelation _relation;

			// Token: 0x04000378 RID: 888
			private int _childFirst;
		}
	}
}
