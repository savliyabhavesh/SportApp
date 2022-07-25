using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x02000012 RID: 18
	[XmlRoot("DataSet1")]
	[ToolboxItem(true)]
	[DesignerCategory("code")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class DataSet1 : DataSet
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x002D06E4 File Offset: 0x002CEAE4
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSet1()
		{
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			this.EndInit();
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x002D0738 File Offset: 0x002CEB38
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected DataSet1(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			if (this.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
			if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["Newparty"] != null)
				{
					base.Tables.Add(new DataSet1.NewpartyDataTable(dataSet.Tables["Newparty"]));
				}
				if (dataSet.Tables["DataTable1"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable1DataTable(dataSet.Tables["DataTable1"]));
				}
				if (dataSet.Tables["DataTable2"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable2DataTable(dataSet.Tables["DataTable2"]));
				}
				if (dataSet.Tables["DataTable3"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable3DataTable(dataSet.Tables["DataTable3"]));
				}
				if (dataSet.Tables["DataTable4"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable4DataTable(dataSet.Tables["DataTable4"]));
				}
				if (dataSet.Tables["DataTable5"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable5DataTable(dataSet.Tables["DataTable5"]));
				}
				if (dataSet.Tables["DataTable6"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable6DataTable(dataSet.Tables["DataTable6"]));
				}
				if (dataSet.Tables["DataTable7"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable7DataTable(dataSet.Tables["DataTable7"]));
				}
				if (dataSet.Tables["DataTable8"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable8DataTable(dataSet.Tables["DataTable8"]));
				}
				this.DataSetName = dataSet.DataSetName;
				this.Prefix = dataSet.Prefix;
				this.Namespace = dataSet.Namespace;
				this.Locale = dataSet.Locale;
				this.CaseSensitive = dataSet.CaseSensitive;
				this.EnforceConstraints = dataSet.EnforceConstraints;
				this.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				this.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			this.GetSerializationData(info, context);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x002D0A28 File Offset: 0x002CEE28
		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSet1.NewpartyDataTable Newparty
		{
			get
			{
				return this.tableNewparty;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x002D0A3C File Offset: 0x002CEE3C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSet1.DataTable1DataTable DataTable1
		{
			get
			{
				return this.tableDataTable1;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x002D0A50 File Offset: 0x002CEE50
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public DataSet1.DataTable2DataTable DataTable2
		{
			get
			{
				return this.tableDataTable2;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x002D0A64 File Offset: 0x002CEE64
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSet1.DataTable3DataTable DataTable3
		{
			get
			{
				return this.tableDataTable3;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x002D0A78 File Offset: 0x002CEE78
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public DataSet1.DataTable4DataTable DataTable4
		{
			get
			{
				return this.tableDataTable4;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x002D0A8C File Offset: 0x002CEE8C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSet1.DataTable5DataTable DataTable5
		{
			get
			{
				return this.tableDataTable5;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x002D0AA0 File Offset: 0x002CEEA0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSet1.DataTable6DataTable DataTable6
		{
			get
			{
				return this.tableDataTable6;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x002D0AB4 File Offset: 0x002CEEB4
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSet1.DataTable7DataTable DataTable7
		{
			get
			{
				return this.tableDataTable7;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x002D0AC8 File Offset: 0x002CEEC8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSet1.DataTable8DataTable DataTable8
		{
			get
			{
				return this.tableDataTable8;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x002D0ADC File Offset: 0x002CEEDC
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x002D0AF0 File Offset: 0x002CEEF0
		[Browsable(true)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x002D0AFC File Offset: 0x002CEEFC
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x002D0B10 File Offset: 0x002CEF10
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x002D0B24 File Offset: 0x002CEF24
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x002D0B38 File Offset: 0x002CEF38
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			DataSet1 dataSet = (DataSet1)base.Clone();
			dataSet.InitVars();
			dataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSet;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x002D0B64 File Offset: 0x002CEF64
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x002D0B74 File Offset: 0x002CEF74
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x002D0B84 File Offset: 0x002CEF84
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["Newparty"] != null)
				{
					base.Tables.Add(new DataSet1.NewpartyDataTable(dataSet.Tables["Newparty"]));
				}
				if (dataSet.Tables["DataTable1"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable1DataTable(dataSet.Tables["DataTable1"]));
				}
				if (dataSet.Tables["DataTable2"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable2DataTable(dataSet.Tables["DataTable2"]));
				}
				if (dataSet.Tables["DataTable3"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable3DataTable(dataSet.Tables["DataTable3"]));
				}
				if (dataSet.Tables["DataTable4"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable4DataTable(dataSet.Tables["DataTable4"]));
				}
				if (dataSet.Tables["DataTable5"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable5DataTable(dataSet.Tables["DataTable5"]));
				}
				if (dataSet.Tables["DataTable6"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable6DataTable(dataSet.Tables["DataTable6"]));
				}
				if (dataSet.Tables["DataTable7"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable7DataTable(dataSet.Tables["DataTable7"]));
				}
				if (dataSet.Tables["DataTable8"] != null)
				{
					base.Tables.Add(new DataSet1.DataTable8DataTable(dataSet.Tables["DataTable8"]));
				}
				this.DataSetName = dataSet.DataSetName;
				this.Prefix = dataSet.Prefix;
				this.Namespace = dataSet.Namespace;
				this.Locale = dataSet.Locale;
				this.CaseSensitive = dataSet.CaseSensitive;
				this.EnforceConstraints = dataSet.EnforceConstraints;
				this.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				this.ReadXml(reader);
				this.InitVars();
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x002D0DDC File Offset: 0x002CF1DC
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x002D0E10 File Offset: 0x002CF210
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x002D0E1C File Offset: 0x002CF21C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableNewparty = (DataSet1.NewpartyDataTable)base.Tables["Newparty"];
			if (initTable && this.tableNewparty != null)
			{
				this.tableNewparty.InitVars();
			}
			this.tableDataTable1 = (DataSet1.DataTable1DataTable)base.Tables["DataTable1"];
			if (initTable && this.tableDataTable1 != null)
			{
				this.tableDataTable1.InitVars();
			}
			this.tableDataTable2 = (DataSet1.DataTable2DataTable)base.Tables["DataTable2"];
			if (initTable && this.tableDataTable2 != null)
			{
				this.tableDataTable2.InitVars();
			}
			this.tableDataTable3 = (DataSet1.DataTable3DataTable)base.Tables["DataTable3"];
			if (initTable && this.tableDataTable3 != null)
			{
				this.tableDataTable3.InitVars();
			}
			this.tableDataTable4 = (DataSet1.DataTable4DataTable)base.Tables["DataTable4"];
			if (initTable && this.tableDataTable4 != null)
			{
				this.tableDataTable4.InitVars();
			}
			this.tableDataTable5 = (DataSet1.DataTable5DataTable)base.Tables["DataTable5"];
			if (initTable && this.tableDataTable5 != null)
			{
				this.tableDataTable5.InitVars();
			}
			this.tableDataTable6 = (DataSet1.DataTable6DataTable)base.Tables["DataTable6"];
			if (initTable && this.tableDataTable6 != null)
			{
				this.tableDataTable6.InitVars();
			}
			this.tableDataTable7 = (DataSet1.DataTable7DataTable)base.Tables["DataTable7"];
			if (initTable && this.tableDataTable7 != null)
			{
				this.tableDataTable7.InitVars();
			}
			this.tableDataTable8 = (DataSet1.DataTable8DataTable)base.Tables["DataTable8"];
			if (initTable && this.tableDataTable8 != null)
			{
				this.tableDataTable8.InitVars();
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x002D0FE4 File Offset: 0x002CF3E4
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "DataSet1";
			this.Prefix = "";
			this.Namespace = "http://tempuri.org/DataSet1.xsd";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableNewparty = new DataSet1.NewpartyDataTable();
			base.Tables.Add(this.tableNewparty);
			this.tableDataTable1 = new DataSet1.DataTable1DataTable();
			base.Tables.Add(this.tableDataTable1);
			this.tableDataTable2 = new DataSet1.DataTable2DataTable();
			base.Tables.Add(this.tableDataTable2);
			this.tableDataTable3 = new DataSet1.DataTable3DataTable();
			base.Tables.Add(this.tableDataTable3);
			this.tableDataTable4 = new DataSet1.DataTable4DataTable();
			base.Tables.Add(this.tableDataTable4);
			this.tableDataTable5 = new DataSet1.DataTable5DataTable();
			base.Tables.Add(this.tableDataTable5);
			this.tableDataTable6 = new DataSet1.DataTable6DataTable();
			base.Tables.Add(this.tableDataTable6);
			this.tableDataTable7 = new DataSet1.DataTable7DataTable();
			base.Tables.Add(this.tableDataTable7);
			this.tableDataTable8 = new DataSet1.DataTable8DataTable();
			base.Tables.Add(this.tableDataTable8);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x002D111C File Offset: 0x002CF51C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeNewparty()
		{
			return false;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x002D112C File Offset: 0x002CF52C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTable1()
		{
			return false;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x002D113C File Offset: 0x002CF53C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeDataTable2()
		{
			return false;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x002D114C File Offset: 0x002CF54C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeDataTable3()
		{
			return false;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x002D115C File Offset: 0x002CF55C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTable4()
		{
			return false;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x002D116C File Offset: 0x002CF56C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTable5()
		{
			return false;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x002D117C File Offset: 0x002CF57C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTable6()
		{
			return false;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x002D118C File Offset: 0x002CF58C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeDataTable7()
		{
			return false;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x002D119C File Offset: 0x002CF59C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeDataTable8()
		{
			return false;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x002D11AC File Offset: 0x002CF5AC
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x002D11C0 File Offset: 0x002CF5C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			DataSet1 dataSet = new DataSet1();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
					{
						XmlSchema xmlSchema = (XmlSchema)obj;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		// Token: 0x040002EF RID: 751
		private DataSet1.NewpartyDataTable tableNewparty;

		// Token: 0x040002F0 RID: 752
		private DataSet1.DataTable1DataTable tableDataTable1;

		// Token: 0x040002F1 RID: 753
		private DataSet1.DataTable2DataTable tableDataTable2;

		// Token: 0x040002F2 RID: 754
		private DataSet1.DataTable3DataTable tableDataTable3;

		// Token: 0x040002F3 RID: 755
		private DataSet1.DataTable4DataTable tableDataTable4;

		// Token: 0x040002F4 RID: 756
		private DataSet1.DataTable5DataTable tableDataTable5;

		// Token: 0x040002F5 RID: 757
		private DataSet1.DataTable6DataTable tableDataTable6;

		// Token: 0x040002F6 RID: 758
		private DataSet1.DataTable7DataTable tableDataTable7;

		// Token: 0x040002F7 RID: 759
		private DataSet1.DataTable8DataTable tableDataTable8;

		// Token: 0x040002F8 RID: 760
		private SchemaSerializationMode _schemaSerializationMode;

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060006A3 RID: 1699
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void NewpartyRowChangeEventHandler(object sender, DataSet1.NewpartyRowChangeEvent e);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060006A7 RID: 1703
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable1RowChangeEventHandler(object sender, DataSet1.DataTable1RowChangeEvent e);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060006AB RID: 1707
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable2RowChangeEventHandler(object sender, DataSet1.DataTable2RowChangeEvent e);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060006AF RID: 1711
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable3RowChangeEventHandler(object sender, DataSet1.DataTable3RowChangeEvent e);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060006B3 RID: 1715
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable4RowChangeEventHandler(object sender, DataSet1.DataTable4RowChangeEvent e);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060006B7 RID: 1719
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable5RowChangeEventHandler(object sender, DataSet1.DataTable5RowChangeEvent e);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060006BB RID: 1723
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable6RowChangeEventHandler(object sender, DataSet1.DataTable6RowChangeEvent e);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060006BF RID: 1727
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable7RowChangeEventHandler(object sender, DataSet1.DataTable7RowChangeEvent e);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060006C3 RID: 1731
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable8RowChangeEventHandler(object sender, DataSet1.DataTable8RowChangeEvent e);

		// Token: 0x0200001C RID: 28
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class NewpartyDataTable : TypedTableBase<DataSet1.NewpartyRow>
		{
			// Token: 0x060006C4 RID: 1732 RVA: 0x002D1308 File Offset: 0x002CF708
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public NewpartyDataTable()
			{
				this.TableName = "Newparty";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x002D1330 File Offset: 0x002CF730
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal NewpartyDataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x002D13DC File Offset: 0x002CF7DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected NewpartyDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x060006C7 RID: 1735 RVA: 0x002D13EC File Offset: 0x002CF7EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IDColumn
			{
				get
				{
					return this.columnID;
				}
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x060006C8 RID: 1736 RVA: 0x002D1400 File Offset: 0x002CF800
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Party_nameColumn
			{
				get
				{
					return this.columnParty_name;
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x060006C9 RID: 1737 RVA: 0x002D1414 File Offset: 0x002CF814
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DharaColumn
			{
				get
				{
					return this.columnDhara;
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x060006CA RID: 1738 RVA: 0x002D1428 File Offset: 0x002CF828
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Comm_On_HariColumn
			{
				get
				{
					return this.columnComm_On_Hari;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x060006CB RID: 1739 RVA: 0x002D143C File Offset: 0x002CF83C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn S_MatchColumn
			{
				get
				{
					return this.columnS_Match;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x060006CC RID: 1740 RVA: 0x002D1450 File Offset: 0x002CF850
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Agent_NameColumn
			{
				get
				{
					return this.columnAgent_Name;
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x060006CD RID: 1741 RVA: 0x002D1464 File Offset: 0x002CF864
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn A_MatchColumn
			{
				get
				{
					return this.columnA_Match;
				}
			}

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x060006CE RID: 1742 RVA: 0x002D1478 File Offset: 0x002CF878
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn P_NameColumn
			{
				get
				{
					return this.columnP_Name;
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x060006CF RID: 1743 RVA: 0x002D148C File Offset: 0x002CF88C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn P_matchColumn
			{
				get
				{
					return this.columnP_match;
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x060006D0 RID: 1744 RVA: 0x002D14A0 File Offset: 0x002CF8A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002CE RID: 718
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.NewpartyRow this[int index]
			{
				get
				{
					return (DataSet1.NewpartyRow)this.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x060006D2 RID: 1746 RVA: 0x002D14D8 File Offset: 0x002CF8D8
			// (remove) Token: 0x060006D3 RID: 1747 RVA: 0x002D14F4 File Offset: 0x002CF8F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.NewpartyRowChangeEventHandler NewpartyRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x060006D4 RID: 1748 RVA: 0x002D1510 File Offset: 0x002CF910
			// (remove) Token: 0x060006D5 RID: 1749 RVA: 0x002D152C File Offset: 0x002CF92C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.NewpartyRowChangeEventHandler NewpartyRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x060006D6 RID: 1750 RVA: 0x002D1548 File Offset: 0x002CF948
			// (remove) Token: 0x060006D7 RID: 1751 RVA: 0x002D1564 File Offset: 0x002CF964
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.NewpartyRowChangeEventHandler NewpartyRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x060006D8 RID: 1752 RVA: 0x002D1580 File Offset: 0x002CF980
			// (remove) Token: 0x060006D9 RID: 1753 RVA: 0x002D159C File Offset: 0x002CF99C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.NewpartyRowChangeEventHandler NewpartyRowDeleted;

			// Token: 0x060006DA RID: 1754 RVA: 0x002D15B8 File Offset: 0x002CF9B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddNewpartyRow(DataSet1.NewpartyRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x002D15C8 File Offset: 0x002CF9C8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.NewpartyRow AddNewpartyRow(int ID, string Party_name, string Dhara, decimal Comm_On_Hari, double S_Match, string Agent_Name, decimal A_Match, string P_Name, double P_match)
			{
				DataSet1.NewpartyRow newpartyRow = (DataSet1.NewpartyRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Party_name,
					Dhara,
					Comm_On_Hari,
					S_Match,
					Agent_Name,
					A_Match,
					P_Name,
					P_match
				};
				newpartyRow.ItemArray = itemArray;
				this.Rows.Add(newpartyRow);
				return newpartyRow;
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x002D1644 File Offset: 0x002CFA44
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.NewpartyRow FindByID(int ID)
			{
				return (DataSet1.NewpartyRow)this.Rows.Find(new object[]
				{
					ID
				});
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x002D1674 File Offset: 0x002CFA74
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSet1.NewpartyDataTable newpartyDataTable = (DataSet1.NewpartyDataTable)base.Clone();
				newpartyDataTable.InitVars();
				return newpartyDataTable;
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x002D1694 File Offset: 0x002CFA94
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.NewpartyDataTable();
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x002D16A8 File Offset: 0x002CFAA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnParty_name = base.Columns["Party_name"];
				this.columnDhara = base.Columns["Dhara"];
				this.columnComm_On_Hari = base.Columns["Comm_On_Hari"];
				this.columnS_Match = base.Columns["S_Match"];
				this.columnAgent_Name = base.Columns["Agent_Name"];
				this.columnA_Match = base.Columns["A_Match"];
				this.columnP_Name = base.Columns["P_Name"];
				this.columnP_match = base.Columns["P_match"];
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x002D177C File Offset: 0x002CFB7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnParty_name = new DataColumn("Party_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParty_name);
				this.columnDhara = new DataColumn("Dhara", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDhara);
				this.columnComm_On_Hari = new DataColumn("Comm_On_Hari", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnComm_On_Hari);
				this.columnS_Match = new DataColumn("S_Match", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columnS_Match);
				this.columnAgent_Name = new DataColumn("Agent_Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAgent_Name);
				this.columnA_Match = new DataColumn("A_Match", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnA_Match);
				this.columnP_Name = new DataColumn("P_Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnP_Name);
				this.columnP_match = new DataColumn("P_match", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columnP_match);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.columnParty_name.MaxLength = 255;
				this.columnDhara.MaxLength = 255;
				this.columnAgent_Name.MaxLength = 50;
				this.columnP_Name.MaxLength = 50;
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x002D1998 File Offset: 0x002CFD98
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.NewpartyRow NewNewpartyRow()
			{
				return (DataSet1.NewpartyRow)this.NewRow();
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x002D19B0 File Offset: 0x002CFDB0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.NewpartyRow(builder);
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x002D19C4 File Offset: 0x002CFDC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.NewpartyRow);
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x002D19DC File Offset: 0x002CFDDC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.NewpartyRowChangedEvent != null)
				//{
				//	DataSet1.NewpartyRowChangeEventHandler newpartyRowChangedEvent = this.NewpartyRowChangedEvent;
				//	if (newpartyRowChangedEvent != null)
				//	{
				//		newpartyRowChangedEvent(this, new DataSet1.NewpartyRowChangeEvent((DataSet1.NewpartyRow)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x002D1A20 File Offset: 0x002CFE20
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.NewpartyRowChangingEvent != null)
				//{
				//	DataSet1.NewpartyRowChangeEventHandler newpartyRowChangingEvent = this.NewpartyRowChangingEvent;
				//	if (newpartyRowChangingEvent != null)
				//	{
				//		newpartyRowChangingEvent(this, new DataSet1.NewpartyRowChangeEvent((DataSet1.NewpartyRow)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060006E6 RID: 1766 RVA: 0x002D1A64 File Offset: 0x002CFE64
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.NewpartyRowDeletedEvent != null)
				//{
				//	DataSet1.NewpartyRowChangeEventHandler newpartyRowDeletedEvent = this.NewpartyRowDeletedEvent;
				//	if (newpartyRowDeletedEvent != null)
				//	{
				//		newpartyRowDeletedEvent(this, new DataSet1.NewpartyRowChangeEvent((DataSet1.NewpartyRow)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x002D1AA8 File Offset: 0x002CFEA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.NewpartyRowDeletingEvent != null)
				//{
				//	DataSet1.NewpartyRowChangeEventHandler newpartyRowDeletingEvent = this.NewpartyRowDeletingEvent;
				//	if (newpartyRowDeletingEvent != null)
				//	{
				//		newpartyRowDeletingEvent(this, new DataSet1.NewpartyRowChangeEvent((DataSet1.NewpartyRow)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x002D1AEC File Offset: 0x002CFEEC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveNewpartyRow(DataSet1.NewpartyRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x002D1AFC File Offset: 0x002CFEFC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "NewpartyDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x040002F9 RID: 761
			private DataColumn columnID;

			// Token: 0x040002FA RID: 762
			private DataColumn columnParty_name;

			// Token: 0x040002FB RID: 763
			private DataColumn columnDhara;

			// Token: 0x040002FC RID: 764
			private DataColumn columnComm_On_Hari;

			// Token: 0x040002FD RID: 765
			private DataColumn columnS_Match;

			// Token: 0x040002FE RID: 766
			private DataColumn columnAgent_Name;

			// Token: 0x040002FF RID: 767
			private DataColumn columnA_Match;

			// Token: 0x04000300 RID: 768
			private DataColumn columnP_Name;

			// Token: 0x04000301 RID: 769
			private DataColumn columnP_match;
		}

		// Token: 0x0200001D RID: 29
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable1DataTable : TypedTableBase<DataSet1.DataTable1Row>
		{
			// Token: 0x060006EA RID: 1770 RVA: 0x002D1D14 File Offset: 0x002D0114
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable1DataTable()
			{
				this.TableName = "DataTable1";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x002D1D3C File Offset: 0x002D013C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable1DataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x002D1DE8 File Offset: 0x002D01E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected DataTable1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x060006ED RID: 1773 RVA: 0x002D1DF8 File Offset: 0x002D01F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x060006EE RID: 1774 RVA: 0x002D1E0C File Offset: 0x002D020C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x060006EF RID: 1775 RVA: 0x002D1E20 File Offset: 0x002D0220
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column3Column
			{
				get
				{
					return this.columnColumn3;
				}
			}

			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x060006F0 RID: 1776 RVA: 0x002D1E34 File Offset: 0x002D0234
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column4Column
			{
				get
				{
					return this.columnColumn4;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x060006F1 RID: 1777 RVA: 0x002D1E48 File Offset: 0x002D0248
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn JamaColumn
			{
				get
				{
					return this.columnJama;
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x060006F2 RID: 1778 RVA: 0x002D1E5C File Offset: 0x002D025C
			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002D5 RID: 725
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable1Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable1Row)this.Rows[index];
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x060006F4 RID: 1780 RVA: 0x002D1E94 File Offset: 0x002D0294
			// (remove) Token: 0x060006F5 RID: 1781 RVA: 0x002D1EB0 File Offset: 0x002D02B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable1RowChangeEventHandler DataTable1RowChanging;

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x060006F6 RID: 1782 RVA: 0x002D1ECC File Offset: 0x002D02CC
			// (remove) Token: 0x060006F7 RID: 1783 RVA: 0x002D1EE8 File Offset: 0x002D02E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable1RowChangeEventHandler DataTable1RowChanged;

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x060006F8 RID: 1784 RVA: 0x002D1F04 File Offset: 0x002D0304
			// (remove) Token: 0x060006F9 RID: 1785 RVA: 0x002D1F20 File Offset: 0x002D0320
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable1RowChangeEventHandler DataTable1RowDeleting;

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x060006FA RID: 1786 RVA: 0x002D1F3C File Offset: 0x002D033C
			// (remove) Token: 0x060006FB RID: 1787 RVA: 0x002D1F58 File Offset: 0x002D0358
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable1RowChangeEventHandler DataTable1RowDeleted;

			// Token: 0x060006FC RID: 1788 RVA: 0x002D1F74 File Offset: 0x002D0374
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDataTable1Row(DataSet1.DataTable1Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x060006FD RID: 1789 RVA: 0x002D1F84 File Offset: 0x002D0384
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable1Row AddDataTable1Row(string Column1, string Column2, string Column3, string Column4, string Jama)
			{
				DataSet1.DataTable1Row dataTable1Row = (DataSet1.DataTable1Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2,
					Column3,
					Column4,
					Jama
				};
				dataTable1Row.ItemArray = itemArray;
				this.Rows.Add(dataTable1Row);
				return dataTable1Row;
			}

			// Token: 0x060006FE RID: 1790 RVA: 0x002D1FD0 File Offset: 0x002D03D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSet1.DataTable1DataTable dataTable1DataTable = (DataSet1.DataTable1DataTable)base.Clone();
				dataTable1DataTable.InitVars();
				return dataTable1DataTable;
			}

			// Token: 0x060006FF RID: 1791 RVA: 0x002D1FF0 File Offset: 0x002D03F0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable1DataTable();
			}

			// Token: 0x06000700 RID: 1792 RVA: 0x002D2004 File Offset: 0x002D0404
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnColumn1 = base.Columns["Column1"];
				this.columnColumn2 = base.Columns["Column2"];
				this.columnColumn3 = base.Columns["Column3"];
				this.columnColumn4 = base.Columns["Column4"];
				this.columnJama = base.Columns["Jama"];
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x002D2080 File Offset: 0x002D0480
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnColumn1 = new DataColumn("Column1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn1);
				this.columnColumn2 = new DataColumn("Column2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn2);
				this.columnColumn3 = new DataColumn("Column3", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn3);
				this.columnColumn4 = new DataColumn("Column4", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn4);
				this.columnJama = new DataColumn("Jama", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnJama);
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x002D2170 File Offset: 0x002D0570
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable1Row NewDataTable1Row()
			{
				return (DataSet1.DataTable1Row)this.NewRow();
			}

			// Token: 0x06000703 RID: 1795 RVA: 0x002D2188 File Offset: 0x002D0588
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable1Row(builder);
			}

			// Token: 0x06000704 RID: 1796 RVA: 0x002D219C File Offset: 0x002D059C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable1Row);
			}

			// Token: 0x06000705 RID: 1797 RVA: 0x002D21B4 File Offset: 0x002D05B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable1RowChangedEvent != null)
				//{
				//	DataSet1.DataTable1RowChangeEventHandler dataTable1RowChangedEvent = this.DataTable1RowChangedEvent;
				//	if (dataTable1RowChangedEvent != null)
				//	{
				//		dataTable1RowChangedEvent(this, new DataSet1.DataTable1RowChangeEvent((DataSet1.DataTable1Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000706 RID: 1798 RVA: 0x002D21F8 File Offset: 0x002D05F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable1RowChangingEvent != null)
				//{
				//	DataSet1.DataTable1RowChangeEventHandler dataTable1RowChangingEvent = this.DataTable1RowChangingEvent;
				//	if (dataTable1RowChangingEvent != null)
				//	{
				//		dataTable1RowChangingEvent(this, new DataSet1.DataTable1RowChangeEvent((DataSet1.DataTable1Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x002D223C File Offset: 0x002D063C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable1RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable1RowChangeEventHandler dataTable1RowDeletedEvent = this.DataTable1RowDeletedEvent;
				//	if (dataTable1RowDeletedEvent != null)
				//	{
				//		dataTable1RowDeletedEvent(this, new DataSet1.DataTable1RowChangeEvent((DataSet1.DataTable1Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000708 RID: 1800 RVA: 0x002D2280 File Offset: 0x002D0680
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.DataTable1RowDeletingEvent != null)
				//{
				//	DataSet1.DataTable1RowChangeEventHandler dataTable1RowDeletingEvent = this.DataTable1RowDeletingEvent;
				//	if (dataTable1RowDeletingEvent != null)
				//	{
				//		dataTable1RowDeletingEvent(this, new DataSet1.DataTable1RowChangeEvent((DataSet1.DataTable1Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000709 RID: 1801 RVA: 0x002D22C4 File Offset: 0x002D06C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveDataTable1Row(DataSet1.DataTable1Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x0600070A RID: 1802 RVA: 0x002D22D4 File Offset: 0x002D06D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000306 RID: 774
			private DataColumn columnColumn1;

			// Token: 0x04000307 RID: 775
			private DataColumn columnColumn2;

			// Token: 0x04000308 RID: 776
			private DataColumn columnColumn3;

			// Token: 0x04000309 RID: 777
			private DataColumn columnColumn4;

			// Token: 0x0400030A RID: 778
			private DataColumn columnJama;
		}

		// Token: 0x0200001E RID: 30
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable2DataTable : TypedTableBase<DataSet1.DataTable2Row>
		{
			// Token: 0x0600070B RID: 1803 RVA: 0x002D24EC File Offset: 0x002D08EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable2DataTable()
			{
				this.TableName = "DataTable2";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600070C RID: 1804 RVA: 0x002D2514 File Offset: 0x002D0914
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable2DataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600070D RID: 1805 RVA: 0x002D25C0 File Offset: 0x002D09C0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected DataTable2DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x0600070E RID: 1806 RVA: 0x002D25D0 File Offset: 0x002D09D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x0600070F RID: 1807 RVA: 0x002D25E4 File Offset: 0x002D09E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x06000710 RID: 1808 RVA: 0x002D25F8 File Offset: 0x002D09F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column3Column
			{
				get
				{
					return this.columnColumn3;
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x06000711 RID: 1809 RVA: 0x002D260C File Offset: 0x002D0A0C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column4Column
			{
				get
				{
					return this.columnColumn4;
				}
			}

			// Token: 0x170002DA RID: 730
			// (get) Token: 0x06000712 RID: 1810 RVA: 0x002D2620 File Offset: 0x002D0A20
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NevaColumn
			{
				get
				{
					return this.columnNeva;
				}
			}

			// Token: 0x170002DB RID: 731
			// (get) Token: 0x06000713 RID: 1811 RVA: 0x002D2634 File Offset: 0x002D0A34
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002DC RID: 732
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable2Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable2Row)this.Rows[index];
				}
			}

			// Token: 0x14000009 RID: 9
			// (add) Token: 0x06000715 RID: 1813 RVA: 0x002D266C File Offset: 0x002D0A6C
			// (remove) Token: 0x06000716 RID: 1814 RVA: 0x002D2688 File Offset: 0x002D0A88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable2RowChangeEventHandler DataTable2RowChanging;

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x06000717 RID: 1815 RVA: 0x002D26A4 File Offset: 0x002D0AA4
			// (remove) Token: 0x06000718 RID: 1816 RVA: 0x002D26C0 File Offset: 0x002D0AC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable2RowChangeEventHandler DataTable2RowChanged;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x06000719 RID: 1817 RVA: 0x002D26DC File Offset: 0x002D0ADC
			// (remove) Token: 0x0600071A RID: 1818 RVA: 0x002D26F8 File Offset: 0x002D0AF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable2RowChangeEventHandler DataTable2RowDeleting;

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x0600071B RID: 1819 RVA: 0x002D2714 File Offset: 0x002D0B14
			// (remove) Token: 0x0600071C RID: 1820 RVA: 0x002D2730 File Offset: 0x002D0B30
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable2RowChangeEventHandler DataTable2RowDeleted;

			// Token: 0x0600071D RID: 1821 RVA: 0x002D274C File Offset: 0x002D0B4C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDataTable2Row(DataSet1.DataTable2Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x002D275C File Offset: 0x002D0B5C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable2Row AddDataTable2Row(string Column1, string Column2, string Column3, string Column4, string Neva)
			{
				DataSet1.DataTable2Row dataTable2Row = (DataSet1.DataTable2Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2,
					Column3,
					Column4,
					Neva
				};
				dataTable2Row.ItemArray = itemArray;
				this.Rows.Add(dataTable2Row);
				return dataTable2Row;
			}

			// Token: 0x0600071F RID: 1823 RVA: 0x002D27A8 File Offset: 0x002D0BA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSet1.DataTable2DataTable dataTable2DataTable = (DataSet1.DataTable2DataTable)base.Clone();
				dataTable2DataTable.InitVars();
				return dataTable2DataTable;
			}

			// Token: 0x06000720 RID: 1824 RVA: 0x002D27C8 File Offset: 0x002D0BC8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable2DataTable();
			}

			// Token: 0x06000721 RID: 1825 RVA: 0x002D27DC File Offset: 0x002D0BDC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnColumn1 = base.Columns["Column1"];
				this.columnColumn2 = base.Columns["Column2"];
				this.columnColumn3 = base.Columns["Column3"];
				this.columnColumn4 = base.Columns["Column4"];
				this.columnNeva = base.Columns["Neva"];
			}

			// Token: 0x06000722 RID: 1826 RVA: 0x002D2858 File Offset: 0x002D0C58
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnColumn1 = new DataColumn("Column1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn1);
				this.columnColumn2 = new DataColumn("Column2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn2);
				this.columnColumn3 = new DataColumn("Column3", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn3);
				this.columnColumn4 = new DataColumn("Column4", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn4);
				this.columnNeva = new DataColumn("Neva", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNeva);
			}

			// Token: 0x06000723 RID: 1827 RVA: 0x002D2948 File Offset: 0x002D0D48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable2Row NewDataTable2Row()
			{
				return (DataSet1.DataTable2Row)this.NewRow();
			}

			// Token: 0x06000724 RID: 1828 RVA: 0x002D2960 File Offset: 0x002D0D60
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable2Row(builder);
			}

			// Token: 0x06000725 RID: 1829 RVA: 0x002D2974 File Offset: 0x002D0D74
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable2Row);
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x002D298C File Offset: 0x002D0D8C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable2RowChangedEvent != null)
				//{
				//	DataSet1.DataTable2RowChangeEventHandler dataTable2RowChangedEvent = this.DataTable2RowChangedEvent;
				//	if (dataTable2RowChangedEvent != null)
				//	{
				//		dataTable2RowChangedEvent(this, new DataSet1.DataTable2RowChangeEvent((DataSet1.DataTable2Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000727 RID: 1831 RVA: 0x002D29D0 File Offset: 0x002D0DD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable2RowChangingEvent != null)
				//{
				//	DataSet1.DataTable2RowChangeEventHandler dataTable2RowChangingEvent = this.DataTable2RowChangingEvent;
				//	if (dataTable2RowChangingEvent != null)
				//	{
				//		dataTable2RowChangingEvent(this, new DataSet1.DataTable2RowChangeEvent((DataSet1.DataTable2Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x002D2A14 File Offset: 0x002D0E14
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable2RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable2RowChangeEventHandler dataTable2RowDeletedEvent = this.DataTable2RowDeletedEvent;
				//	if (dataTable2RowDeletedEvent != null)
				//	{
				//		dataTable2RowDeletedEvent(this, new DataSet1.DataTable2RowChangeEvent((DataSet1.DataTable2Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000729 RID: 1833 RVA: 0x002D2A58 File Offset: 0x002D0E58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
                //if (this.DataTable2RowDeletingEvent != null)
                //{
                //	DataSet1.DataTable2RowChangeEventHandler dataTable2RowDeletingEvent = this.DataTable2RowDeletingEvent;
                //	if (dataTable2RowDeletingEvent != null)
                //	{
                //		dataTable2RowDeletingEvent(this, new DataSet1.DataTable2RowChangeEvent((DataSet1.DataTable2Row)e.Row, e.Action));
                //	}
                //}
            }

            // Token: 0x0600072A RID: 1834 RVA: 0x002D2A9C File Offset: 0x002D0E9C
            [DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable2Row(DataSet1.DataTable2Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x002D2AAC File Offset: 0x002D0EAC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable2DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0400030F RID: 783
			private DataColumn columnColumn1;

			// Token: 0x04000310 RID: 784
			private DataColumn columnColumn2;

			// Token: 0x04000311 RID: 785
			private DataColumn columnColumn3;

			// Token: 0x04000312 RID: 786
			private DataColumn columnColumn4;

			// Token: 0x04000313 RID: 787
			private DataColumn columnNeva;
		}

		// Token: 0x0200001F RID: 31
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable3DataTable : TypedTableBase<DataSet1.DataTable3Row>
		{
			// Token: 0x0600072C RID: 1836 RVA: 0x002D2CC4 File Offset: 0x002D10C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable3DataTable()
			{
				this.TableName = "DataTable3";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600072D RID: 1837 RVA: 0x002D2CEC File Offset: 0x002D10EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable3DataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600072E RID: 1838 RVA: 0x002D2D98 File Offset: 0x002D1198
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTable3DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x0600072F RID: 1839 RVA: 0x002D2DA8 File Offset: 0x002D11A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateColumn
			{
				get
				{
					return this.columnDate;
				}
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x06000730 RID: 1840 RVA: 0x002D2DBC File Offset: 0x002D11BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RemarksColumn
			{
				get
				{
					return this.columnRemarks;
				}
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06000731 RID: 1841 RVA: 0x002D2DD0 File Offset: 0x002D11D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AmountColumn
			{
				get
				{
					return this.columnAmount;
				}
			}

			// Token: 0x170002E0 RID: 736
			// (get) Token: 0x06000732 RID: 1842 RVA: 0x002D2DE4 File Offset: 0x002D11E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Cournt_amountColumn
			{
				get
				{
					return this.columnCournt_amount;
				}
			}

			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x06000733 RID: 1843 RVA: 0x002D2DF8 File Offset: 0x002D11F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn OPNINGColumn
			{
				get
				{
					return this.columnOPNING;
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x06000734 RID: 1844 RVA: 0x002D2E0C File Offset: 0x002D120C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002E3 RID: 739
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable3Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable3Row)this.Rows[index];
				}
			}

			// Token: 0x1400000D RID: 13
			// (add) Token: 0x06000736 RID: 1846 RVA: 0x002D2E44 File Offset: 0x002D1244
			// (remove) Token: 0x06000737 RID: 1847 RVA: 0x002D2E60 File Offset: 0x002D1260
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable3RowChangeEventHandler DataTable3RowChanging;

			// Token: 0x1400000E RID: 14
			// (add) Token: 0x06000738 RID: 1848 RVA: 0x002D2E7C File Offset: 0x002D127C
			// (remove) Token: 0x06000739 RID: 1849 RVA: 0x002D2E98 File Offset: 0x002D1298
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable3RowChangeEventHandler DataTable3RowChanged;

			// Token: 0x1400000F RID: 15
			// (add) Token: 0x0600073A RID: 1850 RVA: 0x002D2EB4 File Offset: 0x002D12B4
			// (remove) Token: 0x0600073B RID: 1851 RVA: 0x002D2ED0 File Offset: 0x002D12D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable3RowChangeEventHandler DataTable3RowDeleting;

			// Token: 0x14000010 RID: 16
			// (add) Token: 0x0600073C RID: 1852 RVA: 0x002D2EEC File Offset: 0x002D12EC
			// (remove) Token: 0x0600073D RID: 1853 RVA: 0x002D2F08 File Offset: 0x002D1308
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable3RowChangeEventHandler DataTable3RowDeleted;

			// Token: 0x0600073E RID: 1854 RVA: 0x002D2F24 File Offset: 0x002D1324
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTable3Row(DataSet1.DataTable3Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x002D2F34 File Offset: 0x002D1334
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable3Row AddDataTable3Row(string _Date, string Remarks, string Amount, string Cournt_amount, string OPNING)
			{
				DataSet1.DataTable3Row dataTable3Row = (DataSet1.DataTable3Row)this.NewRow();
				object[] itemArray = new object[]
				{
					_Date,
					Remarks,
					Amount,
					Cournt_amount,
					OPNING
				};
				dataTable3Row.ItemArray = itemArray;
				this.Rows.Add(dataTable3Row);
				return dataTable3Row;
			}

			// Token: 0x06000740 RID: 1856 RVA: 0x002D2F80 File Offset: 0x002D1380
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSet1.DataTable3DataTable dataTable3DataTable = (DataSet1.DataTable3DataTable)base.Clone();
				dataTable3DataTable.InitVars();
				return dataTable3DataTable;
			}

			// Token: 0x06000741 RID: 1857 RVA: 0x002D2FA0 File Offset: 0x002D13A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable3DataTable();
			}

			// Token: 0x06000742 RID: 1858 RVA: 0x002D2FB4 File Offset: 0x002D13B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnDate = base.Columns["Date"];
				this.columnRemarks = base.Columns["Remarks"];
				this.columnAmount = base.Columns["Amount"];
				this.columnCournt_amount = base.Columns["Cournt_amount"];
				this.columnOPNING = base.Columns["OPNING"];
			}

			// Token: 0x06000743 RID: 1859 RVA: 0x002D3030 File Offset: 0x002D1430
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnDate = new DataColumn("Date", typeof(string), null, MappingType.Element);
				this.columnDate.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "DateColumn");
				this.columnDate.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnDate");
				this.columnDate.ExtendedProperties.Add("Generator_UserColumnName", "Date");
				base.Columns.Add(this.columnDate);
				this.columnRemarks = new DataColumn("Remarks", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRemarks);
				this.columnAmount = new DataColumn("Amount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAmount);
				this.columnCournt_amount = new DataColumn("Cournt_amount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCournt_amount);
				this.columnOPNING = new DataColumn("OPNING", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOPNING);
			}

			// Token: 0x06000744 RID: 1860 RVA: 0x002D316C File Offset: 0x002D156C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable3Row NewDataTable3Row()
			{
				return (DataSet1.DataTable3Row)this.NewRow();
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x002D3184 File Offset: 0x002D1584
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable3Row(builder);
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x002D3198 File Offset: 0x002D1598
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable3Row);
			}

			// Token: 0x06000747 RID: 1863 RVA: 0x002D31B0 File Offset: 0x002D15B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable3RowChangedEvent != null)
				//{
				//	DataSet1.DataTable3RowChangeEventHandler dataTable3RowChangedEvent = this.DataTable3RowChangedEvent;
				//	if (dataTable3RowChangedEvent != null)
				//	{
				//		dataTable3RowChangedEvent(this, new DataSet1.DataTable3RowChangeEvent((DataSet1.DataTable3Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000748 RID: 1864 RVA: 0x002D31F4 File Offset: 0x002D15F4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable3RowChangingEvent != null)
				//{
				//	DataSet1.DataTable3RowChangeEventHandler dataTable3RowChangingEvent = this.DataTable3RowChangingEvent;
				//	if (dataTable3RowChangingEvent != null)
				//	{
				//		dataTable3RowChangingEvent(this, new DataSet1.DataTable3RowChangeEvent((DataSet1.DataTable3Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000749 RID: 1865 RVA: 0x002D3238 File Offset: 0x002D1638
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable3RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable3RowChangeEventHandler dataTable3RowDeletedEvent = this.DataTable3RowDeletedEvent;
				//	if (dataTable3RowDeletedEvent != null)
				//	{
				//		dataTable3RowDeletedEvent(this, new DataSet1.DataTable3RowChangeEvent((DataSet1.DataTable3Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x0600074A RID: 1866 RVA: 0x002D327C File Offset: 0x002D167C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.DataTable3RowDeletingEvent != null)
				//{
				//	DataSet1.DataTable3RowChangeEventHandler dataTable3RowDeletingEvent = this.DataTable3RowDeletingEvent;
				//	if (dataTable3RowDeletingEvent != null)
				//	{
				//		dataTable3RowDeletingEvent(this, new DataSet1.DataTable3RowChangeEvent((DataSet1.DataTable3Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x002D32C0 File Offset: 0x002D16C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable3Row(DataSet1.DataTable3Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x002D32D0 File Offset: 0x002D16D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable3DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000318 RID: 792
			private DataColumn columnDate;

			// Token: 0x04000319 RID: 793
			private DataColumn columnRemarks;

			// Token: 0x0400031A RID: 794
			private DataColumn columnAmount;

			// Token: 0x0400031B RID: 795
			private DataColumn columnCournt_amount;

			// Token: 0x0400031C RID: 796
			private DataColumn columnOPNING;
		}

		// Token: 0x02000020 RID: 32
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable4DataTable : TypedTableBase<DataSet1.DataTable4Row>
		{
			// Token: 0x0600074D RID: 1869 RVA: 0x002D34E8 File Offset: 0x002D18E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable4DataTable()
			{
				this.TableName = "DataTable4";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x002D3510 File Offset: 0x002D1910
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable4DataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x002D35BC File Offset: 0x002D19BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTable4DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x06000750 RID: 1872 RVA: 0x002D35CC File Offset: 0x002D19CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x06000751 RID: 1873 RVA: 0x002D35E0 File Offset: 0x002D19E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x06000752 RID: 1874 RVA: 0x002D35F4 File Offset: 0x002D19F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column3Column
			{
				get
				{
					return this.columnColumn3;
				}
			}

			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x06000753 RID: 1875 RVA: 0x002D3608 File Offset: 0x002D1A08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002E8 RID: 744
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable4Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable4Row)this.Rows[index];
				}
			}

			// Token: 0x14000011 RID: 17
			// (add) Token: 0x06000755 RID: 1877 RVA: 0x002D3640 File Offset: 0x002D1A40
			// (remove) Token: 0x06000756 RID: 1878 RVA: 0x002D365C File Offset: 0x002D1A5C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowChanging;

			// Token: 0x14000012 RID: 18
			// (add) Token: 0x06000757 RID: 1879 RVA: 0x002D3678 File Offset: 0x002D1A78
			// (remove) Token: 0x06000758 RID: 1880 RVA: 0x002D3694 File Offset: 0x002D1A94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowChanged;

			// Token: 0x14000013 RID: 19
			// (add) Token: 0x06000759 RID: 1881 RVA: 0x002D36B0 File Offset: 0x002D1AB0
			// (remove) Token: 0x0600075A RID: 1882 RVA: 0x002D36CC File Offset: 0x002D1ACC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowDeleting;

			// Token: 0x14000014 RID: 20
			// (add) Token: 0x0600075B RID: 1883 RVA: 0x002D36E8 File Offset: 0x002D1AE8
			// (remove) Token: 0x0600075C RID: 1884 RVA: 0x002D3704 File Offset: 0x002D1B04
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable4RowChangeEventHandler DataTable4RowDeleted;

			// Token: 0x0600075D RID: 1885 RVA: 0x002D3720 File Offset: 0x002D1B20
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTable4Row(DataSet1.DataTable4Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x0600075E RID: 1886 RVA: 0x002D3730 File Offset: 0x002D1B30
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable4Row AddDataTable4Row(string Column1, string Column2, string Column3)
			{
				DataSet1.DataTable4Row dataTable4Row = (DataSet1.DataTable4Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2,
					Column3
				};
				dataTable4Row.ItemArray = itemArray;
				this.Rows.Add(dataTable4Row);
				return dataTable4Row;
			}

			// Token: 0x0600075F RID: 1887 RVA: 0x002D3774 File Offset: 0x002D1B74
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSet1.DataTable4DataTable dataTable4DataTable = (DataSet1.DataTable4DataTable)base.Clone();
				dataTable4DataTable.InitVars();
				return dataTable4DataTable;
			}

			// Token: 0x06000760 RID: 1888 RVA: 0x002D3794 File Offset: 0x002D1B94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable4DataTable();
			}

			// Token: 0x06000761 RID: 1889 RVA: 0x002D37A8 File Offset: 0x002D1BA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnColumn1 = base.Columns["Column1"];
				this.columnColumn2 = base.Columns["Column2"];
				this.columnColumn3 = base.Columns["Column3"];
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x002D37F8 File Offset: 0x002D1BF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnColumn1 = new DataColumn("Column1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn1);
				this.columnColumn2 = new DataColumn("Column2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn2);
				this.columnColumn3 = new DataColumn("Column3", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn3);
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x002D388C File Offset: 0x002D1C8C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable4Row NewDataTable4Row()
			{
				return (DataSet1.DataTable4Row)this.NewRow();
			}

			// Token: 0x06000764 RID: 1892 RVA: 0x002D38A4 File Offset: 0x002D1CA4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable4Row(builder);
			}

			// Token: 0x06000765 RID: 1893 RVA: 0x002D38B8 File Offset: 0x002D1CB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable4Row);
			}

			// Token: 0x06000766 RID: 1894 RVA: 0x002D38D0 File Offset: 0x002D1CD0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable4RowChangedEvent != null)
				//{
				//	DataSet1.DataTable4RowChangeEventHandler dataTable4RowChangedEvent = this.DataTable4RowChangedEvent;
				//	if (dataTable4RowChangedEvent != null)
				//	{
				//		dataTable4RowChangedEvent(this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000767 RID: 1895 RVA: 0x002D3914 File Offset: 0x002D1D14
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable4RowChangingEvent != null)
				//{
				//	DataSet1.DataTable4RowChangeEventHandler dataTable4RowChangingEvent = this.DataTable4RowChangingEvent;
				//	if (dataTable4RowChangingEvent != null)
				//	{
				//		dataTable4RowChangingEvent(this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000768 RID: 1896 RVA: 0x002D3958 File Offset: 0x002D1D58
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable4RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable4RowChangeEventHandler dataTable4RowDeletedEvent = this.DataTable4RowDeletedEvent;
				//	if (dataTable4RowDeletedEvent != null)
				//	{
				//		dataTable4RowDeletedEvent(this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000769 RID: 1897 RVA: 0x002D399C File Offset: 0x002D1D9C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.DataTable4RowDeletingEvent != null)
				//{
				//	DataSet1.DataTable4RowChangeEventHandler dataTable4RowDeletingEvent = this.DataTable4RowDeletingEvent;
				//	if (dataTable4RowDeletingEvent != null)
				//	{
				//		dataTable4RowDeletingEvent(this, new DataSet1.DataTable4RowChangeEvent((DataSet1.DataTable4Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x0600076A RID: 1898 RVA: 0x002D39E0 File Offset: 0x002D1DE0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable4Row(DataSet1.DataTable4Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x0600076B RID: 1899 RVA: 0x002D39F0 File Offset: 0x002D1DF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable4DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000321 RID: 801
			private DataColumn columnColumn1;

			// Token: 0x04000322 RID: 802
			private DataColumn columnColumn2;

			// Token: 0x04000323 RID: 803
			private DataColumn columnColumn3;
		}

		// Token: 0x02000021 RID: 33
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable5DataTable : TypedTableBase<DataSet1.DataTable5Row>
		{
			// Token: 0x0600076C RID: 1900 RVA: 0x002D3C08 File Offset: 0x002D2008
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable5DataTable()
			{
				base.ColumnChanging += this.DataTable5DataTable_ColumnChanging;
				this.TableName = "DataTable5";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600076D RID: 1901 RVA: 0x002D3C40 File Offset: 0x002D2040
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable5DataTable(DataTable table)
			{
				base.ColumnChanging += this.DataTable5DataTable_ColumnChanging;
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600076E RID: 1902 RVA: 0x002D3D00 File Offset: 0x002D2100
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTable5DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				base.ColumnChanging += this.DataTable5DataTable_ColumnChanging;
				this.InitVars();
			}

			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x0600076F RID: 1903 RVA: 0x002D3D24 File Offset: 0x002D2124
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x170002EA RID: 746
			// (get) Token: 0x06000770 RID: 1904 RVA: 0x002D3D38 File Offset: 0x002D2138
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x170002EB RID: 747
			// (get) Token: 0x06000771 RID: 1905 RVA: 0x002D3D4C File Offset: 0x002D214C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column3Column
			{
				get
				{
					return this.columnColumn3;
				}
			}

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06000772 RID: 1906 RVA: 0x002D3D60 File Offset: 0x002D2160
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002ED RID: 749
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable5Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable5Row)this.Rows[index];
				}
			}

			// Token: 0x14000015 RID: 21
			// (add) Token: 0x06000774 RID: 1908 RVA: 0x002D3D98 File Offset: 0x002D2198
			// (remove) Token: 0x06000775 RID: 1909 RVA: 0x002D3DB4 File Offset: 0x002D21B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable5RowChangeEventHandler DataTable5RowChanging;

			// Token: 0x14000016 RID: 22
			// (add) Token: 0x06000776 RID: 1910 RVA: 0x002D3DD0 File Offset: 0x002D21D0
			// (remove) Token: 0x06000777 RID: 1911 RVA: 0x002D3DEC File Offset: 0x002D21EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable5RowChangeEventHandler DataTable5RowChanged;

			// Token: 0x14000017 RID: 23
			// (add) Token: 0x06000778 RID: 1912 RVA: 0x002D3E08 File Offset: 0x002D2208
			// (remove) Token: 0x06000779 RID: 1913 RVA: 0x002D3E24 File Offset: 0x002D2224
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable5RowChangeEventHandler DataTable5RowDeleting;

			// Token: 0x14000018 RID: 24
			// (add) Token: 0x0600077A RID: 1914 RVA: 0x002D3E40 File Offset: 0x002D2240
			// (remove) Token: 0x0600077B RID: 1915 RVA: 0x002D3E5C File Offset: 0x002D225C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable5RowChangeEventHandler DataTable5RowDeleted;

			// Token: 0x0600077C RID: 1916 RVA: 0x002D3E78 File Offset: 0x002D2278
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTable5Row(DataSet1.DataTable5Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x0600077D RID: 1917 RVA: 0x002D3E88 File Offset: 0x002D2288
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable5Row AddDataTable5Row(string Column1, string Column2, string Column3)
			{
				DataSet1.DataTable5Row dataTable5Row = (DataSet1.DataTable5Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2,
					Column3
				};
				dataTable5Row.ItemArray = itemArray;
				this.Rows.Add(dataTable5Row);
				return dataTable5Row;
			}

			// Token: 0x0600077E RID: 1918 RVA: 0x002D3ECC File Offset: 0x002D22CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSet1.DataTable5DataTable dataTable5DataTable = (DataSet1.DataTable5DataTable)base.Clone();
				dataTable5DataTable.InitVars();
				return dataTable5DataTable;
			}

			// Token: 0x0600077F RID: 1919 RVA: 0x002D3EEC File Offset: 0x002D22EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable5DataTable();
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x002D3F00 File Offset: 0x002D2300
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnColumn1 = base.Columns["Column1"];
				this.columnColumn2 = base.Columns["Column2"];
				this.columnColumn3 = base.Columns["Column3"];
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x002D3F50 File Offset: 0x002D2350
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnColumn1 = new DataColumn("Column1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn1);
				this.columnColumn2 = new DataColumn("Column2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn2);
				this.columnColumn3 = new DataColumn("Column3", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn3);
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x002D3FE4 File Offset: 0x002D23E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable5Row NewDataTable5Row()
			{
				return (DataSet1.DataTable5Row)this.NewRow();
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x002D3FFC File Offset: 0x002D23FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable5Row(builder);
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x002D4010 File Offset: 0x002D2410
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable5Row);
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x002D4028 File Offset: 0x002D2428
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable5RowChangedEvent != null)
				//{
				//	DataSet1.DataTable5RowChangeEventHandler dataTable5RowChangedEvent = this.DataTable5RowChangedEvent;
				//	if (dataTable5RowChangedEvent != null)
				//	{
				//		dataTable5RowChangedEvent(this, new DataSet1.DataTable5RowChangeEvent((DataSet1.DataTable5Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x002D406C File Offset: 0x002D246C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable5RowChangingEvent != null)
				//{
				//	DataSet1.DataTable5RowChangeEventHandler dataTable5RowChangingEvent = this.DataTable5RowChangingEvent;
				//	if (dataTable5RowChangingEvent != null)
				//	{
				//		dataTable5RowChangingEvent(this, new DataSet1.DataTable5RowChangeEvent((DataSet1.DataTable5Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x002D40B0 File Offset: 0x002D24B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable5RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable5RowChangeEventHandler dataTable5RowDeletedEvent = this.DataTable5RowDeletedEvent;
				//	if (dataTable5RowDeletedEvent != null)
				//	{
				//		dataTable5RowDeletedEvent(this, new DataSet1.DataTable5RowChangeEvent((DataSet1.DataTable5Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000788 RID: 1928 RVA: 0x002D40F4 File Offset: 0x002D24F4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.DataTable5RowDeletingEvent != null)
				//{
				//	DataSet1.DataTable5RowChangeEventHandler dataTable5RowDeletingEvent = this.DataTable5RowDeletingEvent;
				//	if (dataTable5RowDeletingEvent != null)
				//	{
				//		dataTable5RowDeletingEvent(this, new DataSet1.DataTable5RowChangeEvent((DataSet1.DataTable5Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x06000789 RID: 1929 RVA: 0x002D4138 File Offset: 0x002D2538
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable5Row(DataSet1.DataTable5Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x002D4148 File Offset: 0x002D2548
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable5DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x002D4360 File Offset: 0x002D2760
			private void DataTable5DataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
			{
			}

			// Token: 0x04000328 RID: 808
			private DataColumn columnColumn1;

			// Token: 0x04000329 RID: 809
			private DataColumn columnColumn2;

			// Token: 0x0400032A RID: 810
			private DataColumn columnColumn3;
		}

		// Token: 0x02000022 RID: 34
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable6DataTable : TypedTableBase<DataSet1.DataTable6Row>
		{
			// Token: 0x0600078C RID: 1932 RVA: 0x002D4364 File Offset: 0x002D2764
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable6DataTable()
			{
				this.TableName = "DataTable6";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600078D RID: 1933 RVA: 0x002D438C File Offset: 0x002D278C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable6DataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600078E RID: 1934 RVA: 0x002D4438 File Offset: 0x002D2838
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected DataTable6DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x0600078F RID: 1935 RVA: 0x002D4448 File Offset: 0x002D2848
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NamesColumn
			{
				get
				{
					return this.columnNames;
				}
			}

			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06000790 RID: 1936 RVA: 0x002D445C File Offset: 0x002D285C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ClsColumn
			{
				get
				{
					return this.columnCls;
				}
			}

			// Token: 0x170002F0 RID: 752
			// (get) Token: 0x06000791 RID: 1937 RVA: 0x002D4470 File Offset: 0x002D2870
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002F1 RID: 753
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable6Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable6Row)this.Rows[index];
				}
			}

			// Token: 0x14000019 RID: 25
			// (add) Token: 0x06000793 RID: 1939 RVA: 0x002D44A8 File Offset: 0x002D28A8
			// (remove) Token: 0x06000794 RID: 1940 RVA: 0x002D44C4 File Offset: 0x002D28C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable6RowChangeEventHandler DataTable6RowChanging;

			// Token: 0x1400001A RID: 26
			// (add) Token: 0x06000795 RID: 1941 RVA: 0x002D44E0 File Offset: 0x002D28E0
			// (remove) Token: 0x06000796 RID: 1942 RVA: 0x002D44FC File Offset: 0x002D28FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable6RowChangeEventHandler DataTable6RowChanged;

			// Token: 0x1400001B RID: 27
			// (add) Token: 0x06000797 RID: 1943 RVA: 0x002D4518 File Offset: 0x002D2918
			// (remove) Token: 0x06000798 RID: 1944 RVA: 0x002D4534 File Offset: 0x002D2934
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable6RowChangeEventHandler DataTable6RowDeleting;

			// Token: 0x1400001C RID: 28
			// (add) Token: 0x06000799 RID: 1945 RVA: 0x002D4550 File Offset: 0x002D2950
			// (remove) Token: 0x0600079A RID: 1946 RVA: 0x002D456C File Offset: 0x002D296C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable6RowChangeEventHandler DataTable6RowDeleted;

			// Token: 0x0600079B RID: 1947 RVA: 0x002D4588 File Offset: 0x002D2988
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDataTable6Row(DataSet1.DataTable6Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x0600079C RID: 1948 RVA: 0x002D4598 File Offset: 0x002D2998
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable6Row AddDataTable6Row(string Names, string Cls)
			{
				DataSet1.DataTable6Row dataTable6Row = (DataSet1.DataTable6Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Names,
					Cls
				};
				dataTable6Row.ItemArray = itemArray;
				this.Rows.Add(dataTable6Row);
				return dataTable6Row;
			}

			// Token: 0x0600079D RID: 1949 RVA: 0x002D45D8 File Offset: 0x002D29D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSet1.DataTable6DataTable dataTable6DataTable = (DataSet1.DataTable6DataTable)base.Clone();
				dataTable6DataTable.InitVars();
				return dataTable6DataTable;
			}

			// Token: 0x0600079E RID: 1950 RVA: 0x002D45F8 File Offset: 0x002D29F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable6DataTable();
			}

			// Token: 0x0600079F RID: 1951 RVA: 0x002D460C File Offset: 0x002D2A0C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnNames = base.Columns["Names"];
				this.columnCls = base.Columns["Cls"];
			}

			// Token: 0x060007A0 RID: 1952 RVA: 0x002D463C File Offset: 0x002D2A3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnNames = new DataColumn("Names", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNames);
				this.columnCls = new DataColumn("Cls", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCls);
			}

			// Token: 0x060007A1 RID: 1953 RVA: 0x002D46A4 File Offset: 0x002D2AA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable6Row NewDataTable6Row()
			{
				return (DataSet1.DataTable6Row)this.NewRow();
			}

			// Token: 0x060007A2 RID: 1954 RVA: 0x002D46BC File Offset: 0x002D2ABC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable6Row(builder);
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x002D46D0 File Offset: 0x002D2AD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable6Row);
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x002D46E8 File Offset: 0x002D2AE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable6RowChangedEvent != null)
				//{
				//	DataSet1.DataTable6RowChangeEventHandler dataTable6RowChangedEvent = this.DataTable6RowChangedEvent;
				//	if (dataTable6RowChangedEvent != null)
				//	{
				//		dataTable6RowChangedEvent(this, new DataSet1.DataTable6RowChangeEvent((DataSet1.DataTable6Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x002D472C File Offset: 0x002D2B2C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable6RowChangingEvent != null)
				//{
				//	DataSet1.DataTable6RowChangeEventHandler dataTable6RowChangingEvent = this.DataTable6RowChangingEvent;
				//	if (dataTable6RowChangingEvent != null)
				//	{
				//		dataTable6RowChangingEvent(this, new DataSet1.DataTable6RowChangeEvent((DataSet1.DataTable6Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007A6 RID: 1958 RVA: 0x002D4770 File Offset: 0x002D2B70
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable6RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable6RowChangeEventHandler dataTable6RowDeletedEvent = this.DataTable6RowDeletedEvent;
				//	if (dataTable6RowDeletedEvent != null)
				//	{
				//		dataTable6RowDeletedEvent(this, new DataSet1.DataTable6RowChangeEvent((DataSet1.DataTable6Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007A7 RID: 1959 RVA: 0x002D47B4 File Offset: 0x002D2BB4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.DataTable6RowDeletingEvent != null)
				//{
				//	DataSet1.DataTable6RowChangeEventHandler dataTable6RowDeletingEvent = this.DataTable6RowDeletingEvent;
				//	if (dataTable6RowDeletingEvent != null)
				//	{
				//		dataTable6RowDeletingEvent(this, new DataSet1.DataTable6RowChangeEvent((DataSet1.DataTable6Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x002D47F8 File Offset: 0x002D2BF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable6Row(DataSet1.DataTable6Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x060007A9 RID: 1961 RVA: 0x002D4808 File Offset: 0x002D2C08
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable6DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0400032F RID: 815
			private DataColumn columnNames;

			// Token: 0x04000330 RID: 816
			private DataColumn columnCls;
		}

		// Token: 0x02000023 RID: 35
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable7DataTable : TypedTableBase<DataSet1.DataTable7Row>
		{
			// Token: 0x060007AA RID: 1962 RVA: 0x002D4A20 File Offset: 0x002D2E20
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable7DataTable()
			{
				this.TableName = "DataTable7";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x002D4A48 File Offset: 0x002D2E48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable7DataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x002D4AF4 File Offset: 0x002D2EF4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTable7DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x060007AD RID: 1965 RVA: 0x002D4B04 File Offset: 0x002D2F04
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x170002F3 RID: 755
			// (get) Token: 0x060007AE RID: 1966 RVA: 0x002D4B18 File Offset: 0x002D2F18
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x170002F4 RID: 756
			// (get) Token: 0x060007AF RID: 1967 RVA: 0x002D4B2C File Offset: 0x002D2F2C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x170002F5 RID: 757
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable7Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable7Row)this.Rows[index];
				}
			}

			// Token: 0x1400001D RID: 29
			// (add) Token: 0x060007B1 RID: 1969 RVA: 0x002D4B64 File Offset: 0x002D2F64
			// (remove) Token: 0x060007B2 RID: 1970 RVA: 0x002D4B80 File Offset: 0x002D2F80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable7RowChangeEventHandler DataTable7RowChanging;

			// Token: 0x1400001E RID: 30
			// (add) Token: 0x060007B3 RID: 1971 RVA: 0x002D4B9C File Offset: 0x002D2F9C
			// (remove) Token: 0x060007B4 RID: 1972 RVA: 0x002D4BB8 File Offset: 0x002D2FB8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable7RowChangeEventHandler DataTable7RowChanged;

			// Token: 0x1400001F RID: 31
			// (add) Token: 0x060007B5 RID: 1973 RVA: 0x002D4BD4 File Offset: 0x002D2FD4
			// (remove) Token: 0x060007B6 RID: 1974 RVA: 0x002D4BF0 File Offset: 0x002D2FF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable7RowChangeEventHandler DataTable7RowDeleting;

			// Token: 0x14000020 RID: 32
			// (add) Token: 0x060007B7 RID: 1975 RVA: 0x002D4C0C File Offset: 0x002D300C
			// (remove) Token: 0x060007B8 RID: 1976 RVA: 0x002D4C28 File Offset: 0x002D3028
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable7RowChangeEventHandler DataTable7RowDeleted;

			// Token: 0x060007B9 RID: 1977 RVA: 0x002D4C44 File Offset: 0x002D3044
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDataTable7Row(DataSet1.DataTable7Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x060007BA RID: 1978 RVA: 0x002D4C54 File Offset: 0x002D3054
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable7Row AddDataTable7Row(string Column1, string Column2)
			{
				DataSet1.DataTable7Row dataTable7Row = (DataSet1.DataTable7Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2
				};
				dataTable7Row.ItemArray = itemArray;
				this.Rows.Add(dataTable7Row);
				return dataTable7Row;
			}

			// Token: 0x060007BB RID: 1979 RVA: 0x002D4C94 File Offset: 0x002D3094
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSet1.DataTable7DataTable dataTable7DataTable = (DataSet1.DataTable7DataTable)base.Clone();
				dataTable7DataTable.InitVars();
				return dataTable7DataTable;
			}

			// Token: 0x060007BC RID: 1980 RVA: 0x002D4CB4 File Offset: 0x002D30B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable7DataTable();
			}

			// Token: 0x060007BD RID: 1981 RVA: 0x002D4CC8 File Offset: 0x002D30C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnColumn1 = base.Columns["Column1"];
				this.columnColumn2 = base.Columns["Column2"];
			}

			// Token: 0x060007BE RID: 1982 RVA: 0x002D4CF8 File Offset: 0x002D30F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnColumn1 = new DataColumn("Column1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn1);
				this.columnColumn2 = new DataColumn("Column2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn2);
			}

			// Token: 0x060007BF RID: 1983 RVA: 0x002D4D60 File Offset: 0x002D3160
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable7Row NewDataTable7Row()
			{
				return (DataSet1.DataTable7Row)this.NewRow();
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x002D4D78 File Offset: 0x002D3178
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable7Row(builder);
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x002D4D8C File Offset: 0x002D318C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable7Row);
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x002D4DA4 File Offset: 0x002D31A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable7RowChangedEvent != null)
				//{
				//	DataSet1.DataTable7RowChangeEventHandler dataTable7RowChangedEvent = this.DataTable7RowChangedEvent;
				//	if (dataTable7RowChangedEvent != null)
				//	{
				//		dataTable7RowChangedEvent(this, new DataSet1.DataTable7RowChangeEvent((DataSet1.DataTable7Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x002D4DE8 File Offset: 0x002D31E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable7RowChangingEvent != null)
				//{
				//	DataSet1.DataTable7RowChangeEventHandler dataTable7RowChangingEvent = this.DataTable7RowChangingEvent;
				//	if (dataTable7RowChangingEvent != null)
				//	{
				//		dataTable7RowChangingEvent(this, new DataSet1.DataTable7RowChangeEvent((DataSet1.DataTable7Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x002D4E2C File Offset: 0x002D322C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable7RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable7RowChangeEventHandler dataTable7RowDeletedEvent = this.DataTable7RowDeletedEvent;
				//	if (dataTable7RowDeletedEvent != null)
				//	{
				//		dataTable7RowDeletedEvent(this, new DataSet1.DataTable7RowChangeEvent((DataSet1.DataTable7Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x002D4E70 File Offset: 0x002D3270
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.DataTable7RowDeletingEvent != null)
				//{
				//	DataSet1.DataTable7RowChangeEventHandler dataTable7RowDeletingEvent = this.DataTable7RowDeletingEvent;
				//	if (dataTable7RowDeletingEvent != null)
				//	{
				//		dataTable7RowDeletingEvent(this, new DataSet1.DataTable7RowChangeEvent((DataSet1.DataTable7Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007C6 RID: 1990 RVA: 0x002D4EB4 File Offset: 0x002D32B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveDataTable7Row(DataSet1.DataTable7Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x002D4EC4 File Offset: 0x002D32C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable7DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000335 RID: 821
			private DataColumn columnColumn1;

			// Token: 0x04000336 RID: 822
			private DataColumn columnColumn2;
		}

		// Token: 0x02000024 RID: 36
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable8DataTable : TypedTableBase<DataSet1.DataTable8Row>
		{
			// Token: 0x060007C8 RID: 1992 RVA: 0x002D50DC File Offset: 0x002D34DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable8DataTable()
			{
				this.TableName = "DataTable8";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x002D5104 File Offset: 0x002D3504
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable8DataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x002D51B0 File Offset: 0x002D35B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected DataTable8DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x060007CB RID: 1995 RVA: 0x002D51C0 File Offset: 0x002D35C0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CUP_INFOColumn
			{
				get
				{
					return this.columnCUP_INFO;
				}
			}

			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x060007CC RID: 1996 RVA: 0x002D51D4 File Offset: 0x002D35D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Party_NameColumn
			{
				get
				{
					return this.columnParty_Name;
				}
			}

			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x060007CD RID: 1997 RVA: 0x002D51E8 File Offset: 0x002D35E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn _1Column
			{
				get
				{
					return this.column1;
				}
			}

			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x002D51FC File Offset: 0x002D35FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _2Column
			{
				get
				{
					return this.column2;
				}
			}

			// Token: 0x170002FA RID: 762
			// (get) Token: 0x060007CF RID: 1999 RVA: 0x002D5210 File Offset: 0x002D3610
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _3Column
			{
				get
				{
					return this.column3;
				}
			}

			// Token: 0x170002FB RID: 763
			// (get) Token: 0x060007D0 RID: 2000 RVA: 0x002D5224 File Offset: 0x002D3624
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn _4Column
			{
				get
				{
					return this.column4;
				}
			}

			// Token: 0x170002FC RID: 764
			// (get) Token: 0x060007D1 RID: 2001 RVA: 0x002D5238 File Offset: 0x002D3638
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _5Column
			{
				get
				{
					return this.column5;
				}
			}

			// Token: 0x170002FD RID: 765
			// (get) Token: 0x060007D2 RID: 2002 RVA: 0x002D524C File Offset: 0x002D364C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn _6Column
			{
				get
				{
					return this.column6;
				}
			}

			// Token: 0x170002FE RID: 766
			// (get) Token: 0x060007D3 RID: 2003 RVA: 0x002D5260 File Offset: 0x002D3660
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _7Column
			{
				get
				{
					return this.column7;
				}
			}

			// Token: 0x170002FF RID: 767
			// (get) Token: 0x060007D4 RID: 2004 RVA: 0x002D5274 File Offset: 0x002D3674
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn _8Column
			{
				get
				{
					return this.column8;
				}
			}

			// Token: 0x17000300 RID: 768
			// (get) Token: 0x060007D5 RID: 2005 RVA: 0x002D5288 File Offset: 0x002D3688
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn _9Column
			{
				get
				{
					return this.column9;
				}
			}

			// Token: 0x17000301 RID: 769
			// (get) Token: 0x060007D6 RID: 2006 RVA: 0x002D529C File Offset: 0x002D369C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn _10Column
			{
				get
				{
					return this.column10;
				}
			}

			// Token: 0x17000302 RID: 770
			// (get) Token: 0x060007D7 RID: 2007 RVA: 0x002D52B0 File Offset: 0x002D36B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _11Column
			{
				get
				{
					return this.column11;
				}
			}

			// Token: 0x17000303 RID: 771
			// (get) Token: 0x060007D8 RID: 2008 RVA: 0x002D52C4 File Offset: 0x002D36C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn _12Column
			{
				get
				{
					return this.column12;
				}
			}

			// Token: 0x17000304 RID: 772
			// (get) Token: 0x060007D9 RID: 2009 RVA: 0x002D52D8 File Offset: 0x002D36D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _13Column
			{
				get
				{
					return this.column13;
				}
			}

			// Token: 0x17000305 RID: 773
			// (get) Token: 0x060007DA RID: 2010 RVA: 0x002D52EC File Offset: 0x002D36EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _14Column
			{
				get
				{
					return this.column14;
				}
			}

			// Token: 0x17000306 RID: 774
			// (get) Token: 0x060007DB RID: 2011 RVA: 0x002D5300 File Offset: 0x002D3700
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn _15Column
			{
				get
				{
					return this.column15;
				}
			}

			// Token: 0x17000307 RID: 775
			// (get) Token: 0x060007DC RID: 2012 RVA: 0x002D5314 File Offset: 0x002D3714
			[DebuggerNonUserCode]
			[Browsable(false)]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x17000308 RID: 776
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable8Row this[int index]
			{
				get
				{
					return (DataSet1.DataTable8Row)this.Rows[index];
				}
			}

			// Token: 0x14000021 RID: 33
			// (add) Token: 0x060007DE RID: 2014 RVA: 0x002D534C File Offset: 0x002D374C
			// (remove) Token: 0x060007DF RID: 2015 RVA: 0x002D5368 File Offset: 0x002D3768
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable8RowChangeEventHandler DataTable8RowChanging;

			// Token: 0x14000022 RID: 34
			// (add) Token: 0x060007E0 RID: 2016 RVA: 0x002D5384 File Offset: 0x002D3784
			// (remove) Token: 0x060007E1 RID: 2017 RVA: 0x002D53A0 File Offset: 0x002D37A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable8RowChangeEventHandler DataTable8RowChanged;

			// Token: 0x14000023 RID: 35
			// (add) Token: 0x060007E2 RID: 2018 RVA: 0x002D53BC File Offset: 0x002D37BC
			// (remove) Token: 0x060007E3 RID: 2019 RVA: 0x002D53D8 File Offset: 0x002D37D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable8RowChangeEventHandler DataTable8RowDeleting;

			// Token: 0x14000024 RID: 36
			// (add) Token: 0x060007E4 RID: 2020 RVA: 0x002D53F4 File Offset: 0x002D37F4
			// (remove) Token: 0x060007E5 RID: 2021 RVA: 0x002D5410 File Offset: 0x002D3810
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSet1.DataTable8RowChangeEventHandler DataTable8RowDeleted;

			// Token: 0x060007E6 RID: 2022 RVA: 0x002D542C File Offset: 0x002D382C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDataTable8Row(DataSet1.DataTable8Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x060007E7 RID: 2023 RVA: 0x002D543C File Offset: 0x002D383C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable8Row AddDataTable8Row(string CUP_INFO, string Party_Name, string _1, string _2, string _3, string _4, string _5, string _6, string _7, string _8, string _9, string _10, string _11, string _12, string _13, string _14, string _15)
			{
				DataSet1.DataTable8Row dataTable8Row = (DataSet1.DataTable8Row)this.NewRow();
				object[] itemArray = new object[]
				{
					CUP_INFO,
					Party_Name,
					_1,
					_2,
					_3,
					_4,
					_5,
					_6,
					_7,
					_8,
					_9,
					_10,
					_11,
					_12,
					_13,
					_14,
					_15
				};
				dataTable8Row.ItemArray = itemArray;
				this.Rows.Add(dataTable8Row);
				return dataTable8Row;
			}

			// Token: 0x060007E8 RID: 2024 RVA: 0x002D54D0 File Offset: 0x002D38D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSet1.DataTable8DataTable dataTable8DataTable = (DataSet1.DataTable8DataTable)base.Clone();
				dataTable8DataTable.InitVars();
				return dataTable8DataTable;
			}

			// Token: 0x060007E9 RID: 2025 RVA: 0x002D54F0 File Offset: 0x002D38F0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSet1.DataTable8DataTable();
			}

			// Token: 0x060007EA RID: 2026 RVA: 0x002D5504 File Offset: 0x002D3904
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCUP_INFO = base.Columns["CUP_INFO"];
				this.columnParty_Name = base.Columns["Party_Name"];
				this.column1 = base.Columns["1"];
				this.column2 = base.Columns["2"];
				this.column3 = base.Columns["3"];
				this.column4 = base.Columns["4"];
				this.column5 = base.Columns["5"];
				this.column6 = base.Columns["6"];
				this.column7 = base.Columns["7"];
				this.column8 = base.Columns["8"];
				this.column9 = base.Columns["9"];
				this.column10 = base.Columns["10"];
				this.column11 = base.Columns["11"];
				this.column12 = base.Columns["12"];
				this.column13 = base.Columns["13"];
				this.column14 = base.Columns["14"];
				this.column15 = base.Columns["15"];
			}

			// Token: 0x060007EB RID: 2027 RVA: 0x002D5688 File Offset: 0x002D3A88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCUP_INFO = new DataColumn("CUP_INFO", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCUP_INFO);
				this.columnParty_Name = new DataColumn("Party_Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParty_Name);
				this.column1 = new DataColumn("1", typeof(string), null, MappingType.Element);
				this.column1.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column1");
				this.column1.ExtendedProperties.Add("Generator_UserColumnName", "1");
				base.Columns.Add(this.column1);
				this.column2 = new DataColumn("2", typeof(string), null, MappingType.Element);
				this.column2.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column2");
				this.column2.ExtendedProperties.Add("Generator_UserColumnName", "2");
				base.Columns.Add(this.column2);
				this.column3 = new DataColumn("3", typeof(string), null, MappingType.Element);
				this.column3.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column3");
				this.column3.ExtendedProperties.Add("Generator_UserColumnName", "3");
				base.Columns.Add(this.column3);
				this.column4 = new DataColumn("4", typeof(string), null, MappingType.Element);
				this.column4.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column4");
				this.column4.ExtendedProperties.Add("Generator_UserColumnName", "4");
				base.Columns.Add(this.column4);
				this.column5 = new DataColumn("5", typeof(string), null, MappingType.Element);
				this.column5.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column5");
				this.column5.ExtendedProperties.Add("Generator_UserColumnName", "5");
				base.Columns.Add(this.column5);
				this.column6 = new DataColumn("6", typeof(string), null, MappingType.Element);
				this.column6.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column6");
				this.column6.ExtendedProperties.Add("Generator_UserColumnName", "6");
				base.Columns.Add(this.column6);
				this.column7 = new DataColumn("7", typeof(string), null, MappingType.Element);
				this.column7.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column7");
				this.column7.ExtendedProperties.Add("Generator_UserColumnName", "7");
				base.Columns.Add(this.column7);
				this.column8 = new DataColumn("8", typeof(string), null, MappingType.Element);
				this.column8.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column8");
				this.column8.ExtendedProperties.Add("Generator_UserColumnName", "8");
				base.Columns.Add(this.column8);
				this.column9 = new DataColumn("9", typeof(string), null, MappingType.Element);
				this.column9.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column9");
				this.column9.ExtendedProperties.Add("Generator_UserColumnName", "9");
				base.Columns.Add(this.column9);
				this.column10 = new DataColumn("10", typeof(string), null, MappingType.Element);
				this.column10.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column10");
				this.column10.ExtendedProperties.Add("Generator_UserColumnName", "10");
				base.Columns.Add(this.column10);
				this.column11 = new DataColumn("11", typeof(string), null, MappingType.Element);
				this.column11.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column11");
				this.column11.ExtendedProperties.Add("Generator_UserColumnName", "11");
				base.Columns.Add(this.column11);
				this.column12 = new DataColumn("12", typeof(string), null, MappingType.Element);
				this.column12.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column12");
				this.column12.ExtendedProperties.Add("Generator_UserColumnName", "12");
				base.Columns.Add(this.column12);
				this.column13 = new DataColumn("13", typeof(string), null, MappingType.Element);
				this.column13.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column13");
				this.column13.ExtendedProperties.Add("Generator_UserColumnName", "13");
				base.Columns.Add(this.column13);
				this.column14 = new DataColumn("14", typeof(string), null, MappingType.Element);
				this.column14.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column14");
				this.column14.ExtendedProperties.Add("Generator_UserColumnName", "14");
				base.Columns.Add(this.column14);
				this.column15 = new DataColumn("15", typeof(string), null, MappingType.Element);
				this.column15.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column15");
				this.column15.ExtendedProperties.Add("Generator_UserColumnName", "15");
				base.Columns.Add(this.column15);
			}

			// Token: 0x060007EC RID: 2028 RVA: 0x002D5CA0 File Offset: 0x002D40A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable8Row NewDataTable8Row()
			{
				return (DataSet1.DataTable8Row)this.NewRow();
			}

			// Token: 0x060007ED RID: 2029 RVA: 0x002D5CB8 File Offset: 0x002D40B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSet1.DataTable8Row(builder);
			}

			// Token: 0x060007EE RID: 2030 RVA: 0x002D5CCC File Offset: 0x002D40CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSet1.DataTable8Row);
			}

			// Token: 0x060007EF RID: 2031 RVA: 0x002D5CE4 File Offset: 0x002D40E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				//if (this.DataTable8RowChangedEvent != null)
				//{
				//	DataSet1.DataTable8RowChangeEventHandler dataTable8RowChangedEvent = this.DataTable8RowChangedEvent;
				//	if (dataTable8RowChangedEvent != null)
				//	{
				//		dataTable8RowChangedEvent(this, new DataSet1.DataTable8RowChangeEvent((DataSet1.DataTable8Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007F0 RID: 2032 RVA: 0x002D5D28 File Offset: 0x002D4128
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				//if (this.DataTable8RowChangingEvent != null)
				//{
				//	DataSet1.DataTable8RowChangeEventHandler dataTable8RowChangingEvent = this.DataTable8RowChangingEvent;
				//	if (dataTable8RowChangingEvent != null)
				//	{
				//		dataTable8RowChangingEvent(this, new DataSet1.DataTable8RowChangeEvent((DataSet1.DataTable8Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x002D5D6C File Offset: 0x002D416C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				//if (this.DataTable8RowDeletedEvent != null)
				//{
				//	DataSet1.DataTable8RowChangeEventHandler dataTable8RowDeletedEvent = this.DataTable8RowDeletedEvent;
				//	if (dataTable8RowDeletedEvent != null)
				//	{
				//		dataTable8RowDeletedEvent(this, new DataSet1.DataTable8RowChangeEvent((DataSet1.DataTable8Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007F2 RID: 2034 RVA: 0x002D5DB0 File Offset: 0x002D41B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				//if (this.DataTable8RowDeletingEvent != null)
				//{
				//	DataSet1.DataTable8RowChangeEventHandler dataTable8RowDeletingEvent = this.DataTable8RowDeletingEvent;
				//	if (dataTable8RowDeletingEvent != null)
				//	{
				//		dataTable8RowDeletingEvent(this, new DataSet1.DataTable8RowChangeEvent((DataSet1.DataTable8Row)e.Row, e.Action));
				//	}
				//}
			}

			// Token: 0x060007F3 RID: 2035 RVA: 0x002D5DF4 File Offset: 0x002D41F4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable8Row(DataSet1.DataTable8Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x060007F4 RID: 2036 RVA: 0x002D5E04 File Offset: 0x002D4204
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle xmlSchemaParticle = xmlSchemaAny;
				decimal minOccurs = 0m;
				xmlSchemaParticle.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle xmlSchemaParticle2 = xmlSchemaAny2;
				minOccurs = 1m;
				xmlSchemaParticle2.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable8DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0400033B RID: 827
			private DataColumn columnCUP_INFO;

			// Token: 0x0400033C RID: 828
			private DataColumn columnParty_Name;

			// Token: 0x0400033D RID: 829
			private DataColumn column1;

			// Token: 0x0400033E RID: 830
			private DataColumn column2;

			// Token: 0x0400033F RID: 831
			private DataColumn column3;

			// Token: 0x04000340 RID: 832
			private DataColumn column4;

			// Token: 0x04000341 RID: 833
			private DataColumn column5;

			// Token: 0x04000342 RID: 834
			private DataColumn column6;

			// Token: 0x04000343 RID: 835
			private DataColumn column7;

			// Token: 0x04000344 RID: 836
			private DataColumn column8;

			// Token: 0x04000345 RID: 837
			private DataColumn column9;

			// Token: 0x04000346 RID: 838
			private DataColumn column10;

			// Token: 0x04000347 RID: 839
			private DataColumn column11;

			// Token: 0x04000348 RID: 840
			private DataColumn column12;

			// Token: 0x04000349 RID: 841
			private DataColumn column13;

			// Token: 0x0400034A RID: 842
			private DataColumn column14;

			// Token: 0x0400034B RID: 843
			private DataColumn column15;
		}

		// Token: 0x02000025 RID: 37
		public class NewpartyRow : DataRow
		{
			// Token: 0x060007F5 RID: 2037 RVA: 0x002D601C File Offset: 0x002D441C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal NewpartyRow(DataRowBuilder rb) : base(rb)
			{
				this.tableNewparty = (DataSet1.NewpartyDataTable)this.Table;
			}

			// Token: 0x17000309 RID: 777
			// (get) Token: 0x060007F6 RID: 2038 RVA: 0x002D6038 File Offset: 0x002D4438
			// (set) Token: 0x060007F7 RID: 2039 RVA: 0x002D605C File Offset: 0x002D445C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int ID
			{
				get
				{
					return Conversions.ToInteger(this[this.tableNewparty.IDColumn]);
				}
				set
				{
					this[this.tableNewparty.IDColumn] = value;
				}
			}

			// Token: 0x1700030A RID: 778
			// (get) Token: 0x060007F8 RID: 2040 RVA: 0x002D6078 File Offset: 0x002D4478
			// (set) Token: 0x060007F9 RID: 2041 RVA: 0x002D60C4 File Offset: 0x002D44C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Party_name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableNewparty.Party_nameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Party_name' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.Party_nameColumn] = value;
				}
			}

			// Token: 0x1700030B RID: 779
			// (get) Token: 0x060007FA RID: 2042 RVA: 0x002D60D8 File Offset: 0x002D44D8
			// (set) Token: 0x060007FB RID: 2043 RVA: 0x002D6124 File Offset: 0x002D4524
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Dhara
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableNewparty.DharaColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dhara' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.DharaColumn] = value;
				}
			}

			// Token: 0x1700030C RID: 780
			// (get) Token: 0x060007FC RID: 2044 RVA: 0x002D6138 File Offset: 0x002D4538
			// (set) Token: 0x060007FD RID: 2045 RVA: 0x002D6184 File Offset: 0x002D4584
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal Comm_On_Hari
			{
				get
				{
					decimal result;
					try
					{
						result = Conversions.ToDecimal(this[this.tableNewparty.Comm_On_HariColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Comm_On_Hari' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.Comm_On_HariColumn] = value;
				}
			}

			// Token: 0x1700030D RID: 781
			// (get) Token: 0x060007FE RID: 2046 RVA: 0x002D61A0 File Offset: 0x002D45A0
			// (set) Token: 0x060007FF RID: 2047 RVA: 0x002D61EC File Offset: 0x002D45EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public double S_Match
			{
				get
				{
					double result;
					try
					{
						result = Conversions.ToDouble(this[this.tableNewparty.S_MatchColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'S_Match' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.S_MatchColumn] = value;
				}
			}

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06000800 RID: 2048 RVA: 0x002D6208 File Offset: 0x002D4608
			// (set) Token: 0x06000801 RID: 2049 RVA: 0x002D6254 File Offset: 0x002D4654
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Agent_Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableNewparty.Agent_NameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Agent_Name' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.Agent_NameColumn] = value;
				}
			}

			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06000802 RID: 2050 RVA: 0x002D6268 File Offset: 0x002D4668
			// (set) Token: 0x06000803 RID: 2051 RVA: 0x002D62B4 File Offset: 0x002D46B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public decimal A_Match
			{
				get
				{
					decimal result;
					try
					{
						result = Conversions.ToDecimal(this[this.tableNewparty.A_MatchColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'A_Match' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.A_MatchColumn] = value;
				}
			}

			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06000804 RID: 2052 RVA: 0x002D62D0 File Offset: 0x002D46D0
			// (set) Token: 0x06000805 RID: 2053 RVA: 0x002D631C File Offset: 0x002D471C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string P_Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableNewparty.P_NameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'P_Name' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.P_NameColumn] = value;
				}
			}

			// Token: 0x17000311 RID: 785
			// (get) Token: 0x06000806 RID: 2054 RVA: 0x002D6330 File Offset: 0x002D4730
			// (set) Token: 0x06000807 RID: 2055 RVA: 0x002D637C File Offset: 0x002D477C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public double P_match
			{
				get
				{
					double result;
					try
					{
						result = Conversions.ToDouble(this[this.tableNewparty.P_matchColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'P_match' in table 'Newparty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableNewparty.P_matchColumn] = value;
				}
			}

			// Token: 0x06000808 RID: 2056 RVA: 0x002D6398 File Offset: 0x002D4798
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsParty_nameNull()
			{
				return this.IsNull(this.tableNewparty.Party_nameColumn);
			}

			// Token: 0x06000809 RID: 2057 RVA: 0x002D63B8 File Offset: 0x002D47B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetParty_nameNull()
			{
				this[this.tableNewparty.Party_nameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600080A RID: 2058 RVA: 0x002D63D8 File Offset: 0x002D47D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsDharaNull()
			{
				return this.IsNull(this.tableNewparty.DharaColumn);
			}

			// Token: 0x0600080B RID: 2059 RVA: 0x002D63F8 File Offset: 0x002D47F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDharaNull()
			{
				this[this.tableNewparty.DharaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600080C RID: 2060 RVA: 0x002D6418 File Offset: 0x002D4818
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsComm_On_HariNull()
			{
				return this.IsNull(this.tableNewparty.Comm_On_HariColumn);
			}

			// Token: 0x0600080D RID: 2061 RVA: 0x002D6438 File Offset: 0x002D4838
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetComm_On_HariNull()
			{
				this[this.tableNewparty.Comm_On_HariColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600080E RID: 2062 RVA: 0x002D6458 File Offset: 0x002D4858
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsS_MatchNull()
			{
				return this.IsNull(this.tableNewparty.S_MatchColumn);
			}

			// Token: 0x0600080F RID: 2063 RVA: 0x002D6478 File Offset: 0x002D4878
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetS_MatchNull()
			{
				this[this.tableNewparty.S_MatchColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000810 RID: 2064 RVA: 0x002D6498 File Offset: 0x002D4898
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAgent_NameNull()
			{
				return this.IsNull(this.tableNewparty.Agent_NameColumn);
			}

			// Token: 0x06000811 RID: 2065 RVA: 0x002D64B8 File Offset: 0x002D48B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetAgent_NameNull()
			{
				this[this.tableNewparty.Agent_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000812 RID: 2066 RVA: 0x002D64D8 File Offset: 0x002D48D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsA_MatchNull()
			{
				return this.IsNull(this.tableNewparty.A_MatchColumn);
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x002D64F8 File Offset: 0x002D48F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetA_MatchNull()
			{
				this[this.tableNewparty.A_MatchColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x002D6518 File Offset: 0x002D4918
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsP_NameNull()
			{
				return this.IsNull(this.tableNewparty.P_NameColumn);
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x002D6538 File Offset: 0x002D4938
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetP_NameNull()
			{
				this[this.tableNewparty.P_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000816 RID: 2070 RVA: 0x002D6558 File Offset: 0x002D4958
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsP_matchNull()
			{
				return this.IsNull(this.tableNewparty.P_matchColumn);
			}

			// Token: 0x06000817 RID: 2071 RVA: 0x002D6578 File Offset: 0x002D4978
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetP_matchNull()
			{
				this[this.tableNewparty.P_matchColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000350 RID: 848
			private DataSet1.NewpartyDataTable tableNewparty;
		}

		// Token: 0x02000026 RID: 38
		public class DataTable1Row : DataRow
		{
			// Token: 0x06000818 RID: 2072 RVA: 0x002D6598 File Offset: 0x002D4998
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable1Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable1 = (DataSet1.DataTable1DataTable)this.Table;
			}

			// Token: 0x17000312 RID: 786
			// (get) Token: 0x06000819 RID: 2073 RVA: 0x002D65B4 File Offset: 0x002D49B4
			// (set) Token: 0x0600081A RID: 2074 RVA: 0x002D6600 File Offset: 0x002D4A00
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.Column1Column] = value;
				}
			}

			// Token: 0x17000313 RID: 787
			// (get) Token: 0x0600081B RID: 2075 RVA: 0x002D6614 File Offset: 0x002D4A14
			// (set) Token: 0x0600081C RID: 2076 RVA: 0x002D6660 File Offset: 0x002D4A60
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.Column2Column] = value;
				}
			}

			// Token: 0x17000314 RID: 788
			// (get) Token: 0x0600081D RID: 2077 RVA: 0x002D6674 File Offset: 0x002D4A74
			// (set) Token: 0x0600081E RID: 2078 RVA: 0x002D66C0 File Offset: 0x002D4AC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.Column3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column3' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.Column3Column] = value;
				}
			}

			// Token: 0x17000315 RID: 789
			// (get) Token: 0x0600081F RID: 2079 RVA: 0x002D66D4 File Offset: 0x002D4AD4
			// (set) Token: 0x06000820 RID: 2080 RVA: 0x002D6720 File Offset: 0x002D4B20
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.Column4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column4' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.Column4Column] = value;
				}
			}

			// Token: 0x17000316 RID: 790
			// (get) Token: 0x06000821 RID: 2081 RVA: 0x002D6734 File Offset: 0x002D4B34
			// (set) Token: 0x06000822 RID: 2082 RVA: 0x002D6780 File Offset: 0x002D4B80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Jama
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.JamaColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Jama' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.JamaColumn] = value;
				}
			}

			// Token: 0x06000823 RID: 2083 RVA: 0x002D6794 File Offset: 0x002D4B94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableDataTable1.Column1Column);
			}

			// Token: 0x06000824 RID: 2084 RVA: 0x002D67B4 File Offset: 0x002D4BB4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn1Null()
			{
				this[this.tableDataTable1.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000825 RID: 2085 RVA: 0x002D67D4 File Offset: 0x002D4BD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableDataTable1.Column2Column);
			}

			// Token: 0x06000826 RID: 2086 RVA: 0x002D67F4 File Offset: 0x002D4BF4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn2Null()
			{
				this[this.tableDataTable1.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000827 RID: 2087 RVA: 0x002D6814 File Offset: 0x002D4C14
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn3Null()
			{
				return this.IsNull(this.tableDataTable1.Column3Column);
			}

			// Token: 0x06000828 RID: 2088 RVA: 0x002D6834 File Offset: 0x002D4C34
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn3Null()
			{
				this[this.tableDataTable1.Column3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000829 RID: 2089 RVA: 0x002D6854 File Offset: 0x002D4C54
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn4Null()
			{
				return this.IsNull(this.tableDataTable1.Column4Column);
			}

			// Token: 0x0600082A RID: 2090 RVA: 0x002D6874 File Offset: 0x002D4C74
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn4Null()
			{
				this[this.tableDataTable1.Column4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x002D6894 File Offset: 0x002D4C94
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsJamaNull()
			{
				return this.IsNull(this.tableDataTable1.JamaColumn);
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x002D68B4 File Offset: 0x002D4CB4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetJamaNull()
			{
				this[this.tableDataTable1.JamaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000351 RID: 849
			private DataSet1.DataTable1DataTable tableDataTable1;
		}

		// Token: 0x02000027 RID: 39
		public class DataTable2Row : DataRow
		{
			// Token: 0x0600082D RID: 2093 RVA: 0x002D68D4 File Offset: 0x002D4CD4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable2Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable2 = (DataSet1.DataTable2DataTable)this.Table;
			}

			// Token: 0x17000317 RID: 791
			// (get) Token: 0x0600082E RID: 2094 RVA: 0x002D68F0 File Offset: 0x002D4CF0
			// (set) Token: 0x0600082F RID: 2095 RVA: 0x002D693C File Offset: 0x002D4D3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable2.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'DataTable2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable2.Column1Column] = value;
				}
			}

			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06000830 RID: 2096 RVA: 0x002D6950 File Offset: 0x002D4D50
			// (set) Token: 0x06000831 RID: 2097 RVA: 0x002D699C File Offset: 0x002D4D9C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable2.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'DataTable2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable2.Column2Column] = value;
				}
			}

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x06000832 RID: 2098 RVA: 0x002D69B0 File Offset: 0x002D4DB0
			// (set) Token: 0x06000833 RID: 2099 RVA: 0x002D69FC File Offset: 0x002D4DFC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable2.Column3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column3' in table 'DataTable2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable2.Column3Column] = value;
				}
			}

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06000834 RID: 2100 RVA: 0x002D6A10 File Offset: 0x002D4E10
			// (set) Token: 0x06000835 RID: 2101 RVA: 0x002D6A5C File Offset: 0x002D4E5C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable2.Column4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column4' in table 'DataTable2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable2.Column4Column] = value;
				}
			}

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06000836 RID: 2102 RVA: 0x002D6A70 File Offset: 0x002D4E70
			// (set) Token: 0x06000837 RID: 2103 RVA: 0x002D6ABC File Offset: 0x002D4EBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Neva
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable2.NevaColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Neva' in table 'DataTable2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable2.NevaColumn] = value;
				}
			}

			// Token: 0x06000838 RID: 2104 RVA: 0x002D6AD0 File Offset: 0x002D4ED0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableDataTable2.Column1Column);
			}

			// Token: 0x06000839 RID: 2105 RVA: 0x002D6AF0 File Offset: 0x002D4EF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn1Null()
			{
				this[this.tableDataTable2.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600083A RID: 2106 RVA: 0x002D6B10 File Offset: 0x002D4F10
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableDataTable2.Column2Column);
			}

			// Token: 0x0600083B RID: 2107 RVA: 0x002D6B30 File Offset: 0x002D4F30
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn2Null()
			{
				this[this.tableDataTable2.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600083C RID: 2108 RVA: 0x002D6B50 File Offset: 0x002D4F50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn3Null()
			{
				return this.IsNull(this.tableDataTable2.Column3Column);
			}

			// Token: 0x0600083D RID: 2109 RVA: 0x002D6B70 File Offset: 0x002D4F70
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn3Null()
			{
				this[this.tableDataTable2.Column3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600083E RID: 2110 RVA: 0x002D6B90 File Offset: 0x002D4F90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn4Null()
			{
				return this.IsNull(this.tableDataTable2.Column4Column);
			}

			// Token: 0x0600083F RID: 2111 RVA: 0x002D6BB0 File Offset: 0x002D4FB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn4Null()
			{
				this[this.tableDataTable2.Column4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000840 RID: 2112 RVA: 0x002D6BD0 File Offset: 0x002D4FD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNevaNull()
			{
				return this.IsNull(this.tableDataTable2.NevaColumn);
			}

			// Token: 0x06000841 RID: 2113 RVA: 0x002D6BF0 File Offset: 0x002D4FF0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNevaNull()
			{
				this[this.tableDataTable2.NevaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000352 RID: 850
			private DataSet1.DataTable2DataTable tableDataTable2;
		}

		// Token: 0x02000028 RID: 40
		public class DataTable3Row : DataRow
		{
			// Token: 0x06000842 RID: 2114 RVA: 0x002D6C10 File Offset: 0x002D5010
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable3Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable3 = (DataSet1.DataTable3DataTable)this.Table;
			}

			// Token: 0x1700031C RID: 796
			// (get) Token: 0x06000843 RID: 2115 RVA: 0x002D6C2C File Offset: 0x002D502C
			// (set) Token: 0x06000844 RID: 2116 RVA: 0x002D6C78 File Offset: 0x002D5078
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _Date
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable3.DateColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Date' in table 'DataTable3' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable3.DateColumn] = value;
				}
			}

			// Token: 0x1700031D RID: 797
			// (get) Token: 0x06000845 RID: 2117 RVA: 0x002D6C8C File Offset: 0x002D508C
			// (set) Token: 0x06000846 RID: 2118 RVA: 0x002D6CD8 File Offset: 0x002D50D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Remarks
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable3.RemarksColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Remarks' in table 'DataTable3' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable3.RemarksColumn] = value;
				}
			}

			// Token: 0x1700031E RID: 798
			// (get) Token: 0x06000847 RID: 2119 RVA: 0x002D6CEC File Offset: 0x002D50EC
			// (set) Token: 0x06000848 RID: 2120 RVA: 0x002D6D38 File Offset: 0x002D5138
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Amount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable3.AmountColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Amount' in table 'DataTable3' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable3.AmountColumn] = value;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06000849 RID: 2121 RVA: 0x002D6D4C File Offset: 0x002D514C
			// (set) Token: 0x0600084A RID: 2122 RVA: 0x002D6D98 File Offset: 0x002D5198
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Cournt_amount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable3.Cournt_amountColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Cournt_amount' in table 'DataTable3' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable3.Cournt_amountColumn] = value;
				}
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x0600084B RID: 2123 RVA: 0x002D6DAC File Offset: 0x002D51AC
			// (set) Token: 0x0600084C RID: 2124 RVA: 0x002D6DF8 File Offset: 0x002D51F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string OPNING
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable3.OPNINGColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'OPNING' in table 'DataTable3' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable3.OPNINGColumn] = value;
				}
			}

			// Token: 0x0600084D RID: 2125 RVA: 0x002D6E0C File Offset: 0x002D520C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_DateNull()
			{
				return this.IsNull(this.tableDataTable3.DateColumn);
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x002D6E2C File Offset: 0x002D522C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_DateNull()
			{
				this[this.tableDataTable3.DateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600084F RID: 2127 RVA: 0x002D6E4C File Offset: 0x002D524C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsRemarksNull()
			{
				return this.IsNull(this.tableDataTable3.RemarksColumn);
			}

			// Token: 0x06000850 RID: 2128 RVA: 0x002D6E6C File Offset: 0x002D526C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRemarksNull()
			{
				this[this.tableDataTable3.RemarksColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000851 RID: 2129 RVA: 0x002D6E8C File Offset: 0x002D528C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsAmountNull()
			{
				return this.IsNull(this.tableDataTable3.AmountColumn);
			}

			// Token: 0x06000852 RID: 2130 RVA: 0x002D6EAC File Offset: 0x002D52AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAmountNull()
			{
				this[this.tableDataTable3.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000853 RID: 2131 RVA: 0x002D6ECC File Offset: 0x002D52CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCournt_amountNull()
			{
				return this.IsNull(this.tableDataTable3.Cournt_amountColumn);
			}

			// Token: 0x06000854 RID: 2132 RVA: 0x002D6EEC File Offset: 0x002D52EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCournt_amountNull()
			{
				this[this.tableDataTable3.Cournt_amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000855 RID: 2133 RVA: 0x002D6F0C File Offset: 0x002D530C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsOPNINGNull()
			{
				return this.IsNull(this.tableDataTable3.OPNINGColumn);
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x002D6F2C File Offset: 0x002D532C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetOPNINGNull()
			{
				this[this.tableDataTable3.OPNINGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000353 RID: 851
			private DataSet1.DataTable3DataTable tableDataTable3;
		}

		// Token: 0x02000029 RID: 41
		public class DataTable4Row : DataRow
		{
			// Token: 0x06000857 RID: 2135 RVA: 0x002D6F4C File Offset: 0x002D534C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable4Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable4 = (DataSet1.DataTable4DataTable)this.Table;
			}

			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000858 RID: 2136 RVA: 0x002D6F68 File Offset: 0x002D5368
			// (set) Token: 0x06000859 RID: 2137 RVA: 0x002D6FB4 File Offset: 0x002D53B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable4.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'DataTable4' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable4.Column1Column] = value;
				}
			}

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x0600085A RID: 2138 RVA: 0x002D6FC8 File Offset: 0x002D53C8
			// (set) Token: 0x0600085B RID: 2139 RVA: 0x002D7014 File Offset: 0x002D5414
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable4.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'DataTable4' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable4.Column2Column] = value;
				}
			}

			// Token: 0x17000323 RID: 803
			// (get) Token: 0x0600085C RID: 2140 RVA: 0x002D7028 File Offset: 0x002D5428
			// (set) Token: 0x0600085D RID: 2141 RVA: 0x002D7074 File Offset: 0x002D5474
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable4.Column3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column3' in table 'DataTable4' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable4.Column3Column] = value;
				}
			}

			// Token: 0x0600085E RID: 2142 RVA: 0x002D7088 File Offset: 0x002D5488
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableDataTable4.Column1Column);
			}

			// Token: 0x0600085F RID: 2143 RVA: 0x002D70A8 File Offset: 0x002D54A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn1Null()
			{
				this[this.tableDataTable4.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000860 RID: 2144 RVA: 0x002D70C8 File Offset: 0x002D54C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableDataTable4.Column2Column);
			}

			// Token: 0x06000861 RID: 2145 RVA: 0x002D70E8 File Offset: 0x002D54E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn2Null()
			{
				this[this.tableDataTable4.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000862 RID: 2146 RVA: 0x002D7108 File Offset: 0x002D5508
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn3Null()
			{
				return this.IsNull(this.tableDataTable4.Column3Column);
			}

			// Token: 0x06000863 RID: 2147 RVA: 0x002D7128 File Offset: 0x002D5528
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn3Null()
			{
				this[this.tableDataTable4.Column3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000354 RID: 852
			private DataSet1.DataTable4DataTable tableDataTable4;
		}

		// Token: 0x0200002A RID: 42
		public class DataTable5Row : DataRow
		{
			// Token: 0x06000864 RID: 2148 RVA: 0x002D7148 File Offset: 0x002D5548
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable5Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable5 = (DataSet1.DataTable5DataTable)this.Table;
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06000865 RID: 2149 RVA: 0x002D7164 File Offset: 0x002D5564
			// (set) Token: 0x06000866 RID: 2150 RVA: 0x002D71B0 File Offset: 0x002D55B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable5.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'DataTable5' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable5.Column1Column] = value;
				}
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06000867 RID: 2151 RVA: 0x002D71C4 File Offset: 0x002D55C4
			// (set) Token: 0x06000868 RID: 2152 RVA: 0x002D7210 File Offset: 0x002D5610
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable5.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'DataTable5' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable5.Column2Column] = value;
				}
			}

			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06000869 RID: 2153 RVA: 0x002D7224 File Offset: 0x002D5624
			// (set) Token: 0x0600086A RID: 2154 RVA: 0x002D7270 File Offset: 0x002D5670
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable5.Column3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column3' in table 'DataTable5' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable5.Column3Column] = value;
				}
			}

			// Token: 0x0600086B RID: 2155 RVA: 0x002D7284 File Offset: 0x002D5684
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableDataTable5.Column1Column);
			}

			// Token: 0x0600086C RID: 2156 RVA: 0x002D72A4 File Offset: 0x002D56A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn1Null()
			{
				this[this.tableDataTable5.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600086D RID: 2157 RVA: 0x002D72C4 File Offset: 0x002D56C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableDataTable5.Column2Column);
			}

			// Token: 0x0600086E RID: 2158 RVA: 0x002D72E4 File Offset: 0x002D56E4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn2Null()
			{
				this[this.tableDataTable5.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x0600086F RID: 2159 RVA: 0x002D7304 File Offset: 0x002D5704
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn3Null()
			{
				return this.IsNull(this.tableDataTable5.Column3Column);
			}

			// Token: 0x06000870 RID: 2160 RVA: 0x002D7324 File Offset: 0x002D5724
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn3Null()
			{
				this[this.tableDataTable5.Column3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000355 RID: 853
			private DataSet1.DataTable5DataTable tableDataTable5;
		}

		// Token: 0x0200002B RID: 43
		public class DataTable6Row : DataRow
		{
			// Token: 0x06000871 RID: 2161 RVA: 0x002D7344 File Offset: 0x002D5744
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable6Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable6 = (DataSet1.DataTable6DataTable)this.Table;
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000872 RID: 2162 RVA: 0x002D7360 File Offset: 0x002D5760
			// (set) Token: 0x06000873 RID: 2163 RVA: 0x002D73AC File Offset: 0x002D57AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Names
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable6.NamesColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Names' in table 'DataTable6' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable6.NamesColumn] = value;
				}
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000874 RID: 2164 RVA: 0x002D73C0 File Offset: 0x002D57C0
			// (set) Token: 0x06000875 RID: 2165 RVA: 0x002D740C File Offset: 0x002D580C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Cls
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable6.ClsColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Cls' in table 'DataTable6' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable6.ClsColumn] = value;
				}
			}

			// Token: 0x06000876 RID: 2166 RVA: 0x002D7420 File Offset: 0x002D5820
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNamesNull()
			{
				return this.IsNull(this.tableDataTable6.NamesColumn);
			}

			// Token: 0x06000877 RID: 2167 RVA: 0x002D7440 File Offset: 0x002D5840
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNamesNull()
			{
				this[this.tableDataTable6.NamesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000878 RID: 2168 RVA: 0x002D7460 File Offset: 0x002D5860
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsClsNull()
			{
				return this.IsNull(this.tableDataTable6.ClsColumn);
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x002D7480 File Offset: 0x002D5880
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetClsNull()
			{
				this[this.tableDataTable6.ClsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000356 RID: 854
			private DataSet1.DataTable6DataTable tableDataTable6;
		}

		// Token: 0x0200002C RID: 44
		public class DataTable7Row : DataRow
		{
			// Token: 0x0600087A RID: 2170 RVA: 0x002D74A0 File Offset: 0x002D58A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable7Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable7 = (DataSet1.DataTable7DataTable)this.Table;
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x0600087B RID: 2171 RVA: 0x002D74BC File Offset: 0x002D58BC
			// (set) Token: 0x0600087C RID: 2172 RVA: 0x002D7508 File Offset: 0x002D5908
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable7.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'DataTable7' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable7.Column1Column] = value;
				}
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x0600087D RID: 2173 RVA: 0x002D751C File Offset: 0x002D591C
			// (set) Token: 0x0600087E RID: 2174 RVA: 0x002D7568 File Offset: 0x002D5968
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable7.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'DataTable7' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable7.Column2Column] = value;
				}
			}

			// Token: 0x0600087F RID: 2175 RVA: 0x002D757C File Offset: 0x002D597C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableDataTable7.Column1Column);
			}

			// Token: 0x06000880 RID: 2176 RVA: 0x002D759C File Offset: 0x002D599C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn1Null()
			{
				this[this.tableDataTable7.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06000881 RID: 2177 RVA: 0x002D75BC File Offset: 0x002D59BC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableDataTable7.Column2Column);
			}

			// Token: 0x06000882 RID: 2178 RVA: 0x002D75DC File Offset: 0x002D59DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn2Null()
			{
				this[this.tableDataTable7.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000357 RID: 855
			private DataSet1.DataTable7DataTable tableDataTable7;
		}

		// Token: 0x0200002D RID: 45
		public class DataTable8Row : DataRow
		{
			// Token: 0x06000883 RID: 2179 RVA: 0x002D75FC File Offset: 0x002D59FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable8Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable8 = (DataSet1.DataTable8DataTable)this.Table;
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x06000884 RID: 2180 RVA: 0x002D7618 File Offset: 0x002D5A18
			// (set) Token: 0x06000885 RID: 2181 RVA: 0x002D7664 File Offset: 0x002D5A64
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CUP_INFO
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8.CUP_INFOColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CUP_INFO' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8.CUP_INFOColumn] = value;
				}
			}

			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06000886 RID: 2182 RVA: 0x002D7678 File Offset: 0x002D5A78
			// (set) Token: 0x06000887 RID: 2183 RVA: 0x002D76C4 File Offset: 0x002D5AC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Party_Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8.Party_NameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Party_Name' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8.Party_NameColumn] = value;
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x06000888 RID: 2184 RVA: 0x002D76D8 File Offset: 0x002D5AD8
			// (set) Token: 0x06000889 RID: 2185 RVA: 0x002D7724 File Offset: 0x002D5B24
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string _1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '1' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._1Column] = value;
				}
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x0600088A RID: 2186 RVA: 0x002D7738 File Offset: 0x002D5B38
			// (set) Token: 0x0600088B RID: 2187 RVA: 0x002D7784 File Offset: 0x002D5B84
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '2' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._2Column] = value;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x002D7798 File Offset: 0x002D5B98
			// (set) Token: 0x0600088D RID: 2189 RVA: 0x002D77E4 File Offset: 0x002D5BE4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string _3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '3' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._3Column] = value;
				}
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x0600088E RID: 2190 RVA: 0x002D77F8 File Offset: 0x002D5BF8
			// (set) Token: 0x0600088F RID: 2191 RVA: 0x002D7844 File Offset: 0x002D5C44
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string _4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '4' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._4Column] = value;
				}
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06000890 RID: 2192 RVA: 0x002D7858 File Offset: 0x002D5C58
			// (set) Token: 0x06000891 RID: 2193 RVA: 0x002D78A4 File Offset: 0x002D5CA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _5
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._5Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '5' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._5Column] = value;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06000892 RID: 2194 RVA: 0x002D78B8 File Offset: 0x002D5CB8
			// (set) Token: 0x06000893 RID: 2195 RVA: 0x002D7904 File Offset: 0x002D5D04
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _6
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._6Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '6' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._6Column] = value;
				}
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06000894 RID: 2196 RVA: 0x002D7918 File Offset: 0x002D5D18
			// (set) Token: 0x06000895 RID: 2197 RVA: 0x002D7964 File Offset: 0x002D5D64
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string _7
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._7Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '7' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._7Column] = value;
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06000896 RID: 2198 RVA: 0x002D7978 File Offset: 0x002D5D78
			// (set) Token: 0x06000897 RID: 2199 RVA: 0x002D79C4 File Offset: 0x002D5DC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _8
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._8Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '8' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._8Column] = value;
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06000898 RID: 2200 RVA: 0x002D79D8 File Offset: 0x002D5DD8
			// (set) Token: 0x06000899 RID: 2201 RVA: 0x002D7A24 File Offset: 0x002D5E24
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _9
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._9Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '9' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._9Column] = value;
				}
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x0600089A RID: 2202 RVA: 0x002D7A38 File Offset: 0x002D5E38
			// (set) Token: 0x0600089B RID: 2203 RVA: 0x002D7A84 File Offset: 0x002D5E84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string _10
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._10Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '10' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._10Column] = value;
				}
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x0600089C RID: 2204 RVA: 0x002D7A98 File Offset: 0x002D5E98
			// (set) Token: 0x0600089D RID: 2205 RVA: 0x002D7AE4 File Offset: 0x002D5EE4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _11
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._11Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '11' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._11Column] = value;
				}
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x0600089E RID: 2206 RVA: 0x002D7AF8 File Offset: 0x002D5EF8
			// (set) Token: 0x0600089F RID: 2207 RVA: 0x002D7B44 File Offset: 0x002D5F44
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _12
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._12Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '12' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._12Column] = value;
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x060008A0 RID: 2208 RVA: 0x002D7B58 File Offset: 0x002D5F58
			// (set) Token: 0x060008A1 RID: 2209 RVA: 0x002D7BA4 File Offset: 0x002D5FA4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string _13
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._13Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '13' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._13Column] = value;
				}
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x060008A2 RID: 2210 RVA: 0x002D7BB8 File Offset: 0x002D5FB8
			// (set) Token: 0x060008A3 RID: 2211 RVA: 0x002D7C04 File Offset: 0x002D6004
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string _14
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._14Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '14' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._14Column] = value;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x060008A4 RID: 2212 RVA: 0x002D7C18 File Offset: 0x002D6018
			// (set) Token: 0x060008A5 RID: 2213 RVA: 0x002D7C64 File Offset: 0x002D6064
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string _15
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable8._15Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column '15' in table 'DataTable8' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable8._15Column] = value;
				}
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x002D7C78 File Offset: 0x002D6078
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCUP_INFONull()
			{
				return this.IsNull(this.tableDataTable8.CUP_INFOColumn);
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x002D7C98 File Offset: 0x002D6098
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCUP_INFONull()
			{
				this[this.tableDataTable8.CUP_INFOColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008A8 RID: 2216 RVA: 0x002D7CB8 File Offset: 0x002D60B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsParty_NameNull()
			{
				return this.IsNull(this.tableDataTable8.Party_NameColumn);
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x002D7CD8 File Offset: 0x002D60D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetParty_NameNull()
			{
				this[this.tableDataTable8.Party_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x002D7CF8 File Offset: 0x002D60F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Is_1Null()
			{
				return this.IsNull(this.tableDataTable8._1Column);
			}

			// Token: 0x060008AB RID: 2219 RVA: 0x002D7D18 File Offset: 0x002D6118
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_1Null()
			{
				this[this.tableDataTable8._1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008AC RID: 2220 RVA: 0x002D7D38 File Offset: 0x002D6138
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_2Null()
			{
				return this.IsNull(this.tableDataTable8._2Column);
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x002D7D58 File Offset: 0x002D6158
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_2Null()
			{
				this[this.tableDataTable8._2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x002D7D78 File Offset: 0x002D6178
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Is_3Null()
			{
				return this.IsNull(this.tableDataTable8._3Column);
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x002D7D98 File Offset: 0x002D6198
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_3Null()
			{
				this[this.tableDataTable8._3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x002D7DB8 File Offset: 0x002D61B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Is_4Null()
			{
				return this.IsNull(this.tableDataTable8._4Column);
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x002D7DD8 File Offset: 0x002D61D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_4Null()
			{
				this[this.tableDataTable8._4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x002D7DF8 File Offset: 0x002D61F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_5Null()
			{
				return this.IsNull(this.tableDataTable8._5Column);
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x002D7E18 File Offset: 0x002D6218
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_5Null()
			{
				this[this.tableDataTable8._5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x002D7E38 File Offset: 0x002D6238
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Is_6Null()
			{
				return this.IsNull(this.tableDataTable8._6Column);
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x002D7E58 File Offset: 0x002D6258
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_6Null()
			{
				this[this.tableDataTable8._6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x002D7E78 File Offset: 0x002D6278
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_7Null()
			{
				return this.IsNull(this.tableDataTable8._7Column);
			}

			// Token: 0x060008B7 RID: 2231 RVA: 0x002D7E98 File Offset: 0x002D6298
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_7Null()
			{
				this[this.tableDataTable8._7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008B8 RID: 2232 RVA: 0x002D7EB8 File Offset: 0x002D62B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Is_8Null()
			{
				return this.IsNull(this.tableDataTable8._8Column);
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x002D7ED8 File Offset: 0x002D62D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Set_8Null()
			{
				this[this.tableDataTable8._8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008BA RID: 2234 RVA: 0x002D7EF8 File Offset: 0x002D62F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_9Null()
			{
				return this.IsNull(this.tableDataTable8._9Column);
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x002D7F18 File Offset: 0x002D6318
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Set_9Null()
			{
				this[this.tableDataTable8._9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008BC RID: 2236 RVA: 0x002D7F38 File Offset: 0x002D6338
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_10Null()
			{
				return this.IsNull(this.tableDataTable8._10Column);
			}

			// Token: 0x060008BD RID: 2237 RVA: 0x002D7F58 File Offset: 0x002D6358
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_10Null()
			{
				this[this.tableDataTable8._10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008BE RID: 2238 RVA: 0x002D7F78 File Offset: 0x002D6378
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_11Null()
			{
				return this.IsNull(this.tableDataTable8._11Column);
			}

			// Token: 0x060008BF RID: 2239 RVA: 0x002D7F98 File Offset: 0x002D6398
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_11Null()
			{
				this[this.tableDataTable8._11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008C0 RID: 2240 RVA: 0x002D7FB8 File Offset: 0x002D63B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Is_12Null()
			{
				return this.IsNull(this.tableDataTable8._12Column);
			}

			// Token: 0x060008C1 RID: 2241 RVA: 0x002D7FD8 File Offset: 0x002D63D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_12Null()
			{
				this[this.tableDataTable8._12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008C2 RID: 2242 RVA: 0x002D7FF8 File Offset: 0x002D63F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Is_13Null()
			{
				return this.IsNull(this.tableDataTable8._13Column);
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x002D8018 File Offset: 0x002D6418
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Set_13Null()
			{
				this[this.tableDataTable8._13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008C4 RID: 2244 RVA: 0x002D8038 File Offset: 0x002D6438
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_14Null()
			{
				return this.IsNull(this.tableDataTable8._14Column);
			}

			// Token: 0x060008C5 RID: 2245 RVA: 0x002D8058 File Offset: 0x002D6458
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_14Null()
			{
				this[this.tableDataTable8._14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x060008C6 RID: 2246 RVA: 0x002D8078 File Offset: 0x002D6478
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Is_15Null()
			{
				return this.IsNull(this.tableDataTable8._15Column);
			}

			// Token: 0x060008C7 RID: 2247 RVA: 0x002D8098 File Offset: 0x002D6498
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Set_15Null()
			{
				this[this.tableDataTable8._15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000358 RID: 856
			private DataSet1.DataTable8DataTable tableDataTable8;
		}

		// Token: 0x0200002E RID: 46
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class NewpartyRowChangeEvent : EventArgs
		{
			// Token: 0x060008C8 RID: 2248 RVA: 0x002D80B8 File Offset: 0x002D64B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public NewpartyRowChangeEvent(DataSet1.NewpartyRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x060008C9 RID: 2249 RVA: 0x002D80D0 File Offset: 0x002D64D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.NewpartyRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x060008CA RID: 2250 RVA: 0x002D80E4 File Offset: 0x002D64E4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000359 RID: 857
			private DataSet1.NewpartyRow eventRow;

			// Token: 0x0400035A RID: 858
			private DataRowAction eventAction;
		}

		// Token: 0x0200002F RID: 47
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable1RowChangeEvent : EventArgs
		{
			// Token: 0x060008CB RID: 2251 RVA: 0x002D80F8 File Offset: 0x002D64F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable1RowChangeEvent(DataSet1.DataTable1Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x060008CC RID: 2252 RVA: 0x002D8110 File Offset: 0x002D6510
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable1Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x060008CD RID: 2253 RVA: 0x002D8124 File Offset: 0x002D6524
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400035B RID: 859
			private DataSet1.DataTable1Row eventRow;

			// Token: 0x0400035C RID: 860
			private DataRowAction eventAction;
		}

		// Token: 0x02000030 RID: 48
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable2RowChangeEvent : EventArgs
		{
			// Token: 0x060008CE RID: 2254 RVA: 0x002D8138 File Offset: 0x002D6538
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable2RowChangeEvent(DataSet1.DataTable2Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x060008CF RID: 2255 RVA: 0x002D8150 File Offset: 0x002D6550
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable2Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x060008D0 RID: 2256 RVA: 0x002D8164 File Offset: 0x002D6564
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400035D RID: 861
			private DataSet1.DataTable2Row eventRow;

			// Token: 0x0400035E RID: 862
			private DataRowAction eventAction;
		}

		// Token: 0x02000031 RID: 49
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable3RowChangeEvent : EventArgs
		{
			// Token: 0x060008D1 RID: 2257 RVA: 0x002D8178 File Offset: 0x002D6578
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable3RowChangeEvent(DataSet1.DataTable3Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x060008D2 RID: 2258 RVA: 0x002D8190 File Offset: 0x002D6590
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable3Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x060008D3 RID: 2259 RVA: 0x002D81A4 File Offset: 0x002D65A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400035F RID: 863
			private DataSet1.DataTable3Row eventRow;

			// Token: 0x04000360 RID: 864
			private DataRowAction eventAction;
		}

		// Token: 0x02000032 RID: 50
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable4RowChangeEvent : EventArgs
		{
			// Token: 0x060008D4 RID: 2260 RVA: 0x002D81B8 File Offset: 0x002D65B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable4RowChangeEvent(DataSet1.DataTable4Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x060008D5 RID: 2261 RVA: 0x002D81D0 File Offset: 0x002D65D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable4Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x002D81E4 File Offset: 0x002D65E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000361 RID: 865
			private DataSet1.DataTable4Row eventRow;

			// Token: 0x04000362 RID: 866
			private DataRowAction eventAction;
		}

		// Token: 0x02000033 RID: 51
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable5RowChangeEvent : EventArgs
		{
			// Token: 0x060008D7 RID: 2263 RVA: 0x002D81F8 File Offset: 0x002D65F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable5RowChangeEvent(DataSet1.DataTable5Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x060008D8 RID: 2264 RVA: 0x002D8210 File Offset: 0x002D6610
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable5Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x060008D9 RID: 2265 RVA: 0x002D8224 File Offset: 0x002D6624
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000363 RID: 867
			private DataSet1.DataTable5Row eventRow;

			// Token: 0x04000364 RID: 868
			private DataRowAction eventAction;
		}

		// Token: 0x02000034 RID: 52
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable6RowChangeEvent : EventArgs
		{
			// Token: 0x060008DA RID: 2266 RVA: 0x002D8238 File Offset: 0x002D6638
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable6RowChangeEvent(DataSet1.DataTable6Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x060008DB RID: 2267 RVA: 0x002D8250 File Offset: 0x002D6650
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSet1.DataTable6Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x060008DC RID: 2268 RVA: 0x002D8264 File Offset: 0x002D6664
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000365 RID: 869
			private DataSet1.DataTable6Row eventRow;

			// Token: 0x04000366 RID: 870
			private DataRowAction eventAction;
		}

		// Token: 0x02000035 RID: 53
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable7RowChangeEvent : EventArgs
		{
			// Token: 0x060008DD RID: 2269 RVA: 0x002D8278 File Offset: 0x002D6678
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable7RowChangeEvent(DataSet1.DataTable7Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x060008DE RID: 2270 RVA: 0x002D8290 File Offset: 0x002D6690
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable7Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x060008DF RID: 2271 RVA: 0x002D82A4 File Offset: 0x002D66A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000367 RID: 871
			private DataSet1.DataTable7Row eventRow;

			// Token: 0x04000368 RID: 872
			private DataRowAction eventAction;
		}

		// Token: 0x02000036 RID: 54
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable8RowChangeEvent : EventArgs
		{
			// Token: 0x060008E0 RID: 2272 RVA: 0x002D82B8 File Offset: 0x002D66B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable8RowChangeEvent(DataSet1.DataTable8Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x060008E1 RID: 2273 RVA: 0x002D82D0 File Offset: 0x002D66D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSet1.DataTable8Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x060008E2 RID: 2274 RVA: 0x002D82E4 File Offset: 0x002D66E4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000369 RID: 873
			private DataSet1.DataTable8Row eventRow;

			// Token: 0x0400036A RID: 874
			private DataRowAction eventAction;
		}
	}
}
