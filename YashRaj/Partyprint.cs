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
	// Token: 0x02000063 RID: 99
	[DesignerCategory("code")]
	[XmlRoot("Partyprint")]
	[HelpKeyword("vs.data.DataSet")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[ToolboxItem(true)]
	[Serializable]
	public class Partyprint : DataSet
	{
		// Token: 0x06001B45 RID: 6981 RVA: 0x003973C4 File Offset: 0x003957C4
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Partyprint()
		{
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			this.EndInit();
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00397418 File Offset: 0x00395818
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Partyprint(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["DataTable1"] != null)
				{
					base.Tables.Add(new Partyprint.DataTable1DataTable(dataSet.Tables["DataTable1"]));
				}
				if (dataSet.Tables["MatchReport"] != null)
				{
					base.Tables.Add(new Partyprint.MatchReportDataTable(dataSet.Tables["MatchReport"]));
				}
				if (dataSet.Tables["SessionReport"] != null)
				{
					base.Tables.Add(new Partyprint.SessionReportDataTable(dataSet.Tables["SessionReport"]));
				}
				if (dataSet.Tables["ListViewData"] != null)
				{
					base.Tables.Add(new Partyprint.ListViewDataDataTable(dataSet.Tables["ListViewData"]));
				}
				if (dataSet.Tables["ListViewData1"] != null)
				{
					base.Tables.Add(new Partyprint.ListViewData1DataTable(dataSet.Tables["ListViewData1"]));
				}
				if (dataSet.Tables["FinalTB"] != null)
				{
					base.Tables.Add(new Partyprint.FinalTBDataTable(dataSet.Tables["FinalTB"]));
				}
				if (dataSet.Tables["Hawal"] != null)
				{
					base.Tables.Add(new Partyprint.HawalDataTable(dataSet.Tables["Hawal"]));
				}
				if (dataSet.Tables["CN"] != null)
				{
					base.Tables.Add(new Partyprint.CNDataTable(dataSet.Tables["CN"]));
				}
				if (dataSet.Tables["Pdata"] != null)
				{
					base.Tables.Add(new Partyprint.PdataDataTable(dataSet.Tables["Pdata"]));
				}
				if (dataSet.Tables["Trn"] != null)
				{
					base.Tables.Add(new Partyprint.TrnDataTable(dataSet.Tables["Trn"]));
				}
				if (dataSet.Tables["mbook"] != null)
				{
					base.Tables.Add(new Partyprint.mbookDataTable(dataSet.Tables["mbook"]));
				}
				if (dataSet.Tables["Conect_1"] != null)
				{
					base.Tables.Add(new Partyprint.Conect_1DataTable(dataSet.Tables["Conect_1"]));
				}
				if (dataSet.Tables["Conect_2"] != null)
				{
					base.Tables.Add(new Partyprint.Conect_2DataTable(dataSet.Tables["Conect_2"]));
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

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x003977D0 File Offset: 0x00395BD0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public Partyprint.DataTable1DataTable DataTable1
		{
			get
			{
				return this.tableDataTable1;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x003977E4 File Offset: 0x00395BE4
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Partyprint.MatchReportDataTable MatchReport
		{
			get
			{
				return this.tableMatchReport;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x003977F8 File Offset: 0x00395BF8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Partyprint.SessionReportDataTable SessionReport
		{
			get
			{
				return this.tableSessionReport;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0039780C File Offset: 0x00395C0C
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Partyprint.ListViewDataDataTable ListViewData
		{
			get
			{
				return this.tableListViewData;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00397820 File Offset: 0x00395C20
		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Partyprint.ListViewData1DataTable ListViewData1
		{
			get
			{
				return this.tableListViewData1;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00397834 File Offset: 0x00395C34
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Partyprint.FinalTBDataTable FinalTB
		{
			get
			{
				return this.tableFinalTB;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00397848 File Offset: 0x00395C48
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Partyprint.HawalDataTable Hawal
		{
			get
			{
				return this.tableHawal;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0039785C File Offset: 0x00395C5C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Partyprint.CNDataTable CN
		{
			get
			{
				return this.tableCN;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00397870 File Offset: 0x00395C70
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Partyprint.PdataDataTable Pdata
		{
			get
			{
				return this.tablePdata;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00397884 File Offset: 0x00395C84
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public Partyprint.TrnDataTable Trn
		{
			get
			{
				return this.tableTrn;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00397898 File Offset: 0x00395C98
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Partyprint.mbookDataTable mbook
		{
			get
			{
				return this.tablembook;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x003978AC File Offset: 0x00395CAC
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public Partyprint.Conect_1DataTable Conect_1
		{
			get
			{
				return this.tableConect_1;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x003978C0 File Offset: 0x00395CC0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Partyprint.Conect_2DataTable Conect_2
		{
			get
			{
				return this.tableConect_2;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x003978D4 File Offset: 0x00395CD4
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x003978E8 File Offset: 0x00395CE8
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x003978F4 File Offset: 0x00395CF4
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00397908 File Offset: 0x00395D08
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0039791C File Offset: 0x00395D1C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00397930 File Offset: 0x00395D30
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			Partyprint partyprint = (Partyprint)base.Clone();
			partyprint.InitVars();
			partyprint.SchemaSerializationMode = this.SchemaSerializationMode;
			return partyprint;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0039795C File Offset: 0x00395D5C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0039796C File Offset: 0x00395D6C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0039797C File Offset: 0x00395D7C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["DataTable1"] != null)
				{
					base.Tables.Add(new Partyprint.DataTable1DataTable(dataSet.Tables["DataTable1"]));
				}
				if (dataSet.Tables["MatchReport"] != null)
				{
					base.Tables.Add(new Partyprint.MatchReportDataTable(dataSet.Tables["MatchReport"]));
				}
				if (dataSet.Tables["SessionReport"] != null)
				{
					base.Tables.Add(new Partyprint.SessionReportDataTable(dataSet.Tables["SessionReport"]));
				}
				if (dataSet.Tables["ListViewData"] != null)
				{
					base.Tables.Add(new Partyprint.ListViewDataDataTable(dataSet.Tables["ListViewData"]));
				}
				if (dataSet.Tables["ListViewData1"] != null)
				{
					base.Tables.Add(new Partyprint.ListViewData1DataTable(dataSet.Tables["ListViewData1"]));
				}
				if (dataSet.Tables["FinalTB"] != null)
				{
					base.Tables.Add(new Partyprint.FinalTBDataTable(dataSet.Tables["FinalTB"]));
				}
				if (dataSet.Tables["Hawal"] != null)
				{
					base.Tables.Add(new Partyprint.HawalDataTable(dataSet.Tables["Hawal"]));
				}
				if (dataSet.Tables["CN"] != null)
				{
					base.Tables.Add(new Partyprint.CNDataTable(dataSet.Tables["CN"]));
				}
				if (dataSet.Tables["Pdata"] != null)
				{
					base.Tables.Add(new Partyprint.PdataDataTable(dataSet.Tables["Pdata"]));
				}
				if (dataSet.Tables["Trn"] != null)
				{
					base.Tables.Add(new Partyprint.TrnDataTable(dataSet.Tables["Trn"]));
				}
				if (dataSet.Tables["mbook"] != null)
				{
					base.Tables.Add(new Partyprint.mbookDataTable(dataSet.Tables["mbook"]));
				}
				if (dataSet.Tables["Conect_1"] != null)
				{
					base.Tables.Add(new Partyprint.Conect_1DataTable(dataSet.Tables["Conect_1"]));
				}
				if (dataSet.Tables["Conect_2"] != null)
				{
					base.Tables.Add(new Partyprint.Conect_2DataTable(dataSet.Tables["Conect_2"]));
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

		// Token: 0x06001B5D RID: 7005 RVA: 0x00397C9C File Offset: 0x0039609C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00397CD0 File Offset: 0x003960D0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00397CDC File Offset: 0x003960DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableDataTable1 = (Partyprint.DataTable1DataTable)base.Tables["DataTable1"];
			if (initTable && this.tableDataTable1 != null)
			{
				this.tableDataTable1.InitVars();
			}
			this.tableMatchReport = (Partyprint.MatchReportDataTable)base.Tables["MatchReport"];
			if (initTable && this.tableMatchReport != null)
			{
				this.tableMatchReport.InitVars();
			}
			this.tableSessionReport = (Partyprint.SessionReportDataTable)base.Tables["SessionReport"];
			if (initTable && this.tableSessionReport != null)
			{
				this.tableSessionReport.InitVars();
			}
			this.tableListViewData = (Partyprint.ListViewDataDataTable)base.Tables["ListViewData"];
			if (initTable && this.tableListViewData != null)
			{
				this.tableListViewData.InitVars();
			}
			this.tableListViewData1 = (Partyprint.ListViewData1DataTable)base.Tables["ListViewData1"];
			if (initTable && this.tableListViewData1 != null)
			{
				this.tableListViewData1.InitVars();
			}
			this.tableFinalTB = (Partyprint.FinalTBDataTable)base.Tables["FinalTB"];
			if (initTable && this.tableFinalTB != null)
			{
				this.tableFinalTB.InitVars();
			}
			this.tableHawal = (Partyprint.HawalDataTable)base.Tables["Hawal"];
			if (initTable && this.tableHawal != null)
			{
				this.tableHawal.InitVars();
			}
			this.tableCN = (Partyprint.CNDataTable)base.Tables["CN"];
			if (initTable && this.tableCN != null)
			{
				this.tableCN.InitVars();
			}
			this.tablePdata = (Partyprint.PdataDataTable)base.Tables["Pdata"];
			if (initTable && this.tablePdata != null)
			{
				this.tablePdata.InitVars();
			}
			this.tableTrn = (Partyprint.TrnDataTable)base.Tables["Trn"];
			if (initTable && this.tableTrn != null)
			{
				this.tableTrn.InitVars();
			}
			this.tablembook = (Partyprint.mbookDataTable)base.Tables["mbook"];
			if (initTable && this.tablembook != null)
			{
				this.tablembook.InitVars();
			}
			this.tableConect_1 = (Partyprint.Conect_1DataTable)base.Tables["Conect_1"];
			if (initTable && this.tableConect_1 != null)
			{
				this.tableConect_1.InitVars();
			}
			this.tableConect_2 = (Partyprint.Conect_2DataTable)base.Tables["Conect_2"];
			if (initTable && this.tableConect_2 != null)
			{
				this.tableConect_2.InitVars();
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00397F68 File Offset: 0x00396368
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			this.DataSetName = "Partyprint";
			this.Prefix = "";
			this.Namespace = "http://tempuri.org/Partyprint.xsd";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableDataTable1 = new Partyprint.DataTable1DataTable();
			base.Tables.Add(this.tableDataTable1);
			this.tableMatchReport = new Partyprint.MatchReportDataTable();
			base.Tables.Add(this.tableMatchReport);
			this.tableSessionReport = new Partyprint.SessionReportDataTable();
			base.Tables.Add(this.tableSessionReport);
			this.tableListViewData = new Partyprint.ListViewDataDataTable();
			base.Tables.Add(this.tableListViewData);
			this.tableListViewData1 = new Partyprint.ListViewData1DataTable();
			base.Tables.Add(this.tableListViewData1);
			this.tableFinalTB = new Partyprint.FinalTBDataTable();
			base.Tables.Add(this.tableFinalTB);
			this.tableHawal = new Partyprint.HawalDataTable();
			base.Tables.Add(this.tableHawal);
			this.tableCN = new Partyprint.CNDataTable();
			base.Tables.Add(this.tableCN);
			this.tablePdata = new Partyprint.PdataDataTable();
			base.Tables.Add(this.tablePdata);
			this.tableTrn = new Partyprint.TrnDataTable();
			base.Tables.Add(this.tableTrn);
			this.tablembook = new Partyprint.mbookDataTable();
			base.Tables.Add(this.tablembook);
			this.tableConect_1 = new Partyprint.Conect_1DataTable();
			base.Tables.Add(this.tableConect_1);
			this.tableConect_2 = new Partyprint.Conect_2DataTable();
			base.Tables.Add(this.tableConect_2);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00398110 File Offset: 0x00396510
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeDataTable1()
		{
			return false;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00398120 File Offset: 0x00396520
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeMatchReport()
		{
			return false;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00398130 File Offset: 0x00396530
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeSessionReport()
		{
			return false;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00398140 File Offset: 0x00396540
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeListViewData()
		{
			return false;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00398150 File Offset: 0x00396550
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeListViewData1()
		{
			return false;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00398160 File Offset: 0x00396560
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeFinalTB()
		{
			return false;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00398170 File Offset: 0x00396570
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeHawal()
		{
			return false;
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00398180 File Offset: 0x00396580
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeCN()
		{
			return false;
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00398190 File Offset: 0x00396590
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializePdata()
		{
			return false;
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x003981A0 File Offset: 0x003965A0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeTrn()
		{
			return false;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x003981B0 File Offset: 0x003965B0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializembook()
		{
			return false;
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x003981C0 File Offset: 0x003965C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeConect_1()
		{
			return false;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x003981D0 File Offset: 0x003965D0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeConect_2()
		{
			return false;
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x003981E0 File Offset: 0x003965E0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x003981F4 File Offset: 0x003965F4
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			Partyprint partyprint = new Partyprint();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = partyprint.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

		// Token: 0x04000BC1 RID: 3009
		private Partyprint.DataTable1DataTable tableDataTable1;

		// Token: 0x04000BC2 RID: 3010
		private Partyprint.MatchReportDataTable tableMatchReport;

		// Token: 0x04000BC3 RID: 3011
		private Partyprint.SessionReportDataTable tableSessionReport;

		// Token: 0x04000BC4 RID: 3012
		private Partyprint.ListViewDataDataTable tableListViewData;

		// Token: 0x04000BC5 RID: 3013
		private Partyprint.ListViewData1DataTable tableListViewData1;

		// Token: 0x04000BC6 RID: 3014
		private Partyprint.FinalTBDataTable tableFinalTB;

		// Token: 0x04000BC7 RID: 3015
		private Partyprint.HawalDataTable tableHawal;

		// Token: 0x04000BC8 RID: 3016
		private Partyprint.CNDataTable tableCN;

		// Token: 0x04000BC9 RID: 3017
		private Partyprint.PdataDataTable tablePdata;

		// Token: 0x04000BCA RID: 3018
		private Partyprint.TrnDataTable tableTrn;

		// Token: 0x04000BCB RID: 3019
		private Partyprint.mbookDataTable tablembook;

		// Token: 0x04000BCC RID: 3020
		private Partyprint.Conect_1DataTable tableConect_1;

		// Token: 0x04000BCD RID: 3021
		private Partyprint.Conect_2DataTable tableConect_2;

		// Token: 0x04000BCE RID: 3022
		private SchemaSerializationMode _schemaSerializationMode;

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06001B73 RID: 7027
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable1RowChangeEventHandler(object sender, Partyprint.DataTable1RowChangeEvent e);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06001B77 RID: 7031
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void MatchReportRowChangeEventHandler(object sender, Partyprint.MatchReportRowChangeEvent e);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06001B7B RID: 7035
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void SessionReportRowChangeEventHandler(object sender, Partyprint.SessionReportRowChangeEvent e);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06001B7F RID: 7039
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void ListViewDataRowChangeEventHandler(object sender, Partyprint.ListViewDataRowChangeEvent e);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06001B83 RID: 7043
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void ListViewData1RowChangeEventHandler(object sender, Partyprint.ListViewData1RowChangeEvent e);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06001B87 RID: 7047
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void FinalTBRowChangeEventHandler(object sender, Partyprint.FinalTBRowChangeEvent e);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06001B8B RID: 7051
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void HawalRowChangeEventHandler(object sender, Partyprint.HawalRowChangeEvent e);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06001B8F RID: 7055
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void CNRowChangeEventHandler(object sender, Partyprint.CNRowChangeEvent e);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06001B93 RID: 7059
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void PdataRowChangeEventHandler(object sender, Partyprint.PdataRowChangeEvent e);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06001B97 RID: 7063
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TrnRowChangeEventHandler(object sender, Partyprint.TrnRowChangeEvent e);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06001B9B RID: 7067
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void mbookRowChangeEventHandler(object sender, Partyprint.mbookRowChangeEvent e);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06001B9F RID: 7071
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Conect_1RowChangeEventHandler(object sender, Partyprint.Conect_1RowChangeEvent e);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06001BA3 RID: 7075
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Conect_2RowChangeEventHandler(object sender, Partyprint.Conect_2RowChangeEvent e);

		// Token: 0x02000071 RID: 113
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTable1DataTable : TypedTableBase<Partyprint.DataTable1Row>
		{
			// Token: 0x06001BA4 RID: 7076 RVA: 0x0039833C File Offset: 0x0039673C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable1DataTable()
			{
				this.TableName = "DataTable1";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001BA5 RID: 7077 RVA: 0x00398364 File Offset: 0x00396764
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			// Token: 0x06001BA6 RID: 7078 RVA: 0x00398410 File Offset: 0x00396810
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTable1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x00398420 File Offset: 0x00396820
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Party_nameColumn
			{
				get
				{
					return this.columnParty_name;
				}
			}

			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00398434 File Offset: 0x00396834
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DharaColumn
			{
				get
				{
					return this.columnDhara;
				}
			}

			// Token: 0x17000AB4 RID: 2740
			// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x00398448 File Offset: 0x00396848
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn StatusColumn
			{
				get
				{
					return this.columnStatus;
				}
			}

			// Token: 0x17000AB5 RID: 2741
			// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0039845C File Offset: 0x0039685C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Balance_LimitColumn
			{
				get
				{
					return this.columnBalance_Limit;
				}
			}

			// Token: 0x17000AB6 RID: 2742
			// (get) Token: 0x06001BAB RID: 7083 RVA: 0x00398470 File Offset: 0x00396870
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

			// Token: 0x17000AB7 RID: 2743
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.DataTable1Row this[int index]
			{
				get
				{
					return (Partyprint.DataTable1Row)this.Rows[index];
				}
			}

			// Token: 0x14000025 RID: 37
			// (add) Token: 0x06001BAD RID: 7085 RVA: 0x003984A8 File Offset: 0x003968A8
			// (remove) Token: 0x06001BAE RID: 7086 RVA: 0x003984C4 File Offset: 0x003968C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.DataTable1RowChangeEventHandler DataTable1RowChanging;

			// Token: 0x14000026 RID: 38
			// (add) Token: 0x06001BAF RID: 7087 RVA: 0x003984E0 File Offset: 0x003968E0
			// (remove) Token: 0x06001BB0 RID: 7088 RVA: 0x003984FC File Offset: 0x003968FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.DataTable1RowChangeEventHandler DataTable1RowChanged;

			// Token: 0x14000027 RID: 39
			// (add) Token: 0x06001BB1 RID: 7089 RVA: 0x00398518 File Offset: 0x00396918
			// (remove) Token: 0x06001BB2 RID: 7090 RVA: 0x00398534 File Offset: 0x00396934
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.DataTable1RowChangeEventHandler DataTable1RowDeleting;

			// Token: 0x14000028 RID: 40
			// (add) Token: 0x06001BB3 RID: 7091 RVA: 0x00398550 File Offset: 0x00396950
			// (remove) Token: 0x06001BB4 RID: 7092 RVA: 0x0039856C File Offset: 0x0039696C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.DataTable1RowChangeEventHandler DataTable1RowDeleted;

			// Token: 0x06001BB5 RID: 7093 RVA: 0x00398588 File Offset: 0x00396988
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDataTable1Row(Partyprint.DataTable1Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001BB6 RID: 7094 RVA: 0x00398598 File Offset: 0x00396998
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.DataTable1Row AddDataTable1Row(string Party_name, string Dhara, string Status, string Balance_Limit)
			{
				Partyprint.DataTable1Row dataTable1Row = (Partyprint.DataTable1Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Party_name,
					Dhara,
					Status,
					Balance_Limit
				};
				dataTable1Row.ItemArray = itemArray;
				this.Rows.Add(dataTable1Row);
				return dataTable1Row;
			}

			// Token: 0x06001BB7 RID: 7095 RVA: 0x003985E0 File Offset: 0x003969E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.DataTable1DataTable dataTable1DataTable = (Partyprint.DataTable1DataTable)base.Clone();
				dataTable1DataTable.InitVars();
				return dataTable1DataTable;
			}

			// Token: 0x06001BB8 RID: 7096 RVA: 0x00398600 File Offset: 0x00396A00
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.DataTable1DataTable();
			}

			// Token: 0x06001BB9 RID: 7097 RVA: 0x00398614 File Offset: 0x00396A14
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnParty_name = base.Columns["Party_name"];
				this.columnDhara = base.Columns["Dhara"];
				this.columnStatus = base.Columns["Status"];
				this.columnBalance_Limit = base.Columns["Balance_Limit"];
			}

			// Token: 0x06001BBA RID: 7098 RVA: 0x0039867C File Offset: 0x00396A7C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnParty_name = new DataColumn("Party_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParty_name);
				this.columnDhara = new DataColumn("Dhara", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDhara);
				this.columnStatus = new DataColumn("Status", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnStatus);
				this.columnBalance_Limit = new DataColumn("Balance_Limit", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBalance_Limit);
			}

			// Token: 0x06001BBB RID: 7099 RVA: 0x00398740 File Offset: 0x00396B40
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.DataTable1Row NewDataTable1Row()
			{
				return (Partyprint.DataTable1Row)this.NewRow();
			}

			// Token: 0x06001BBC RID: 7100 RVA: 0x00398758 File Offset: 0x00396B58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.DataTable1Row(builder);
			}

			// Token: 0x06001BBD RID: 7101 RVA: 0x0039876C File Offset: 0x00396B6C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.DataTable1Row);
			}

			// Token: 0x06001BBE RID: 7102 RVA: 0x00398784 File Offset: 0x00396B84
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DataTable1RowChangedEvent != null)
				{
					Partyprint.DataTable1RowChangeEventHandler dataTable1RowChangedEvent = this.DataTable1RowChangedEvent;
					if (dataTable1RowChangedEvent != null)
					{
						dataTable1RowChangedEvent(this, new Partyprint.DataTable1RowChangeEvent((Partyprint.DataTable1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BBF RID: 7103 RVA: 0x003987C8 File Offset: 0x00396BC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DataTable1RowChangingEvent != null)
				{
					Partyprint.DataTable1RowChangeEventHandler dataTable1RowChangingEvent = this.DataTable1RowChangingEvent;
					if (dataTable1RowChangingEvent != null)
					{
						dataTable1RowChangingEvent(this, new Partyprint.DataTable1RowChangeEvent((Partyprint.DataTable1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BC0 RID: 7104 RVA: 0x0039880C File Offset: 0x00396C0C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DataTable1RowDeletedEvent != null)
				{
					Partyprint.DataTable1RowChangeEventHandler dataTable1RowDeletedEvent = this.DataTable1RowDeletedEvent;
					if (dataTable1RowDeletedEvent != null)
					{
						dataTable1RowDeletedEvent(this, new Partyprint.DataTable1RowChangeEvent((Partyprint.DataTable1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BC1 RID: 7105 RVA: 0x00398850 File Offset: 0x00396C50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DataTable1RowDeletingEvent != null)
				{
					Partyprint.DataTable1RowChangeEventHandler dataTable1RowDeletingEvent = this.DataTable1RowDeletingEvent;
					if (dataTable1RowDeletingEvent != null)
					{
						dataTable1RowDeletingEvent(this, new Partyprint.DataTable1RowChangeEvent((Partyprint.DataTable1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BC2 RID: 7106 RVA: 0x00398894 File Offset: 0x00396C94
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable1Row(Partyprint.DataTable1Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001BC3 RID: 7107 RVA: 0x003988A4 File Offset: 0x00396CA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000BCF RID: 3023
			private DataColumn columnParty_name;

			// Token: 0x04000BD0 RID: 3024
			private DataColumn columnDhara;

			// Token: 0x04000BD1 RID: 3025
			private DataColumn columnStatus;

			// Token: 0x04000BD2 RID: 3026
			private DataColumn columnBalance_Limit;
		}

		// Token: 0x02000072 RID: 114
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class MatchReportDataTable : TypedTableBase<Partyprint.MatchReportRow>
		{
			// Token: 0x06001BC4 RID: 7108 RVA: 0x00398ABC File Offset: 0x00396EBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public MatchReportDataTable()
			{
				this.TableName = "MatchReport";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001BC5 RID: 7109 RVA: 0x00398AE4 File Offset: 0x00396EE4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal MatchReportDataTable(DataTable table)
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

			// Token: 0x06001BC6 RID: 7110 RVA: 0x00398B90 File Offset: 0x00396F90
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected MatchReportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AB8 RID: 2744
			// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00398BA0 File Offset: 0x00396FA0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn m_eidColumn
			{
				get
				{
					return this.columnm_eid;
				}
			}

			// Token: 0x17000AB9 RID: 2745
			// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00398BB4 File Offset: 0x00396FB4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn m_amtColumn
			{
				get
				{
					return this.columnm_amt;
				}
			}

			// Token: 0x17000ABA RID: 2746
			// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00398BC8 File Offset: 0x00396FC8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn m_rateColumn
			{
				get
				{
					return this.columnm_rate;
				}
			}

			// Token: 0x17000ABB RID: 2747
			// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00398BDC File Offset: 0x00396FDC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn m_teamColumn
			{
				get
				{
					return this.columnm_team;
				}
			}

			// Token: 0x17000ABC RID: 2748
			// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00398BF0 File Offset: 0x00396FF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn m_modeColumn
			{
				get
				{
					return this.columnm_mode;
				}
			}

			// Token: 0x17000ABD RID: 2749
			// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00398C04 File Offset: 0x00397004
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn m_partyColumn
			{
				get
				{
					return this.columnm_party;
				}
			}

			// Token: 0x17000ABE RID: 2750
			// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00398C18 File Offset: 0x00397018
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Sr_NoColumn
			{
				get
				{
					return this.columnSr_No;
				}
			}

			// Token: 0x17000ABF RID: 2751
			// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00398C2C File Offset: 0x0039702C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Date1Column
			{
				get
				{
					return this.columnDate1;
				}
			}

			// Token: 0x17000AC0 RID: 2752
			// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00398C40 File Offset: 0x00397040
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Team1Column
			{
				get
				{
					return this.columnTeam1;
				}
			}

			// Token: 0x17000AC1 RID: 2753
			// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00398C54 File Offset: 0x00397054
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00398C68 File Offset: 0x00397068
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeColumn
			{
				get
				{
					return this.columnType;
				}
			}

			// Token: 0x17000AC3 RID: 2755
			// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00398C7C File Offset: 0x0039707C
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

			// Token: 0x17000AC4 RID: 2756
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.MatchReportRow this[int index]
			{
				get
				{
					return (Partyprint.MatchReportRow)this.Rows[index];
				}
			}

			// Token: 0x14000029 RID: 41
			// (add) Token: 0x06001BD4 RID: 7124 RVA: 0x00398CB4 File Offset: 0x003970B4
			// (remove) Token: 0x06001BD5 RID: 7125 RVA: 0x00398CD0 File Offset: 0x003970D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.MatchReportRowChangeEventHandler MatchReportRowChanging;

			// Token: 0x1400002A RID: 42
			// (add) Token: 0x06001BD6 RID: 7126 RVA: 0x00398CEC File Offset: 0x003970EC
			// (remove) Token: 0x06001BD7 RID: 7127 RVA: 0x00398D08 File Offset: 0x00397108
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.MatchReportRowChangeEventHandler MatchReportRowChanged;

			// Token: 0x1400002B RID: 43
			// (add) Token: 0x06001BD8 RID: 7128 RVA: 0x00398D24 File Offset: 0x00397124
			// (remove) Token: 0x06001BD9 RID: 7129 RVA: 0x00398D40 File Offset: 0x00397140
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.MatchReportRowChangeEventHandler MatchReportRowDeleting;

			// Token: 0x1400002C RID: 44
			// (add) Token: 0x06001BDA RID: 7130 RVA: 0x00398D5C File Offset: 0x0039715C
			// (remove) Token: 0x06001BDB RID: 7131 RVA: 0x00398D78 File Offset: 0x00397178
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.MatchReportRowChangeEventHandler MatchReportRowDeleted;

			// Token: 0x06001BDC RID: 7132 RVA: 0x00398D94 File Offset: 0x00397194
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddMatchReportRow(Partyprint.MatchReportRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001BDD RID: 7133 RVA: 0x00398DA4 File Offset: 0x003971A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.MatchReportRow AddMatchReportRow(string m_eid, string m_amt, string m_rate, string m_team, string m_mode, string m_party, string Sr_No, string Date1, string Team1, string Name, string Type)
			{
				Partyprint.MatchReportRow matchReportRow = (Partyprint.MatchReportRow)this.NewRow();
				object[] itemArray = new object[]
				{
					m_eid,
					m_amt,
					m_rate,
					m_team,
					m_mode,
					m_party,
					Sr_No,
					Date1,
					Team1,
					Name,
					Type
				};
				matchReportRow.ItemArray = itemArray;
				this.Rows.Add(matchReportRow);
				return matchReportRow;
			}

			// Token: 0x06001BDE RID: 7134 RVA: 0x00398E14 File Offset: 0x00397214
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Partyprint.MatchReportDataTable matchReportDataTable = (Partyprint.MatchReportDataTable)base.Clone();
				matchReportDataTable.InitVars();
				return matchReportDataTable;
			}

			// Token: 0x06001BDF RID: 7135 RVA: 0x00398E34 File Offset: 0x00397234
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.MatchReportDataTable();
			}

			// Token: 0x06001BE0 RID: 7136 RVA: 0x00398E48 File Offset: 0x00397248
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnm_eid = base.Columns["m_eid"];
				this.columnm_amt = base.Columns["m_amt"];
				this.columnm_rate = base.Columns["m_rate"];
				this.columnm_team = base.Columns["m_team"];
				this.columnm_mode = base.Columns["m_mode"];
				this.columnm_party = base.Columns["m_party"];
				this.columnSr_No = base.Columns["Sr_No"];
				this.columnDate1 = base.Columns["Date1"];
				this.columnTeam1 = base.Columns["Team1"];
				this.columnName = base.Columns["Name"];
				this.columnType = base.Columns["Type"];
			}

			// Token: 0x06001BE1 RID: 7137 RVA: 0x00398F48 File Offset: 0x00397348
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnm_eid = new DataColumn("m_eid", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnm_eid);
				this.columnm_amt = new DataColumn("m_amt", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnm_amt);
				this.columnm_rate = new DataColumn("m_rate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnm_rate);
				this.columnm_team = new DataColumn("m_team", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnm_team);
				this.columnm_mode = new DataColumn("m_mode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnm_mode);
				this.columnm_party = new DataColumn("m_party", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnm_party);
				this.columnSr_No = new DataColumn("Sr_No", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSr_No);
				this.columnDate1 = new DataColumn("Date1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDate1);
				this.columnTeam1 = new DataColumn("Team1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTeam1);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnType = new DataColumn("Type", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnType);
				this.columnm_eid.AllowDBNull = false;
			}

			// Token: 0x06001BE2 RID: 7138 RVA: 0x00399150 File Offset: 0x00397550
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.MatchReportRow NewMatchReportRow()
			{
				return (Partyprint.MatchReportRow)this.NewRow();
			}

			// Token: 0x06001BE3 RID: 7139 RVA: 0x00399168 File Offset: 0x00397568
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.MatchReportRow(builder);
			}

			// Token: 0x06001BE4 RID: 7140 RVA: 0x0039917C File Offset: 0x0039757C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.MatchReportRow);
			}

			// Token: 0x06001BE5 RID: 7141 RVA: 0x00399194 File Offset: 0x00397594
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.MatchReportRowChangedEvent != null)
				{
					Partyprint.MatchReportRowChangeEventHandler matchReportRowChangedEvent = this.MatchReportRowChangedEvent;
					if (matchReportRowChangedEvent != null)
					{
						matchReportRowChangedEvent(this, new Partyprint.MatchReportRowChangeEvent((Partyprint.MatchReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BE6 RID: 7142 RVA: 0x003991D8 File Offset: 0x003975D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.MatchReportRowChangingEvent != null)
				{
					Partyprint.MatchReportRowChangeEventHandler matchReportRowChangingEvent = this.MatchReportRowChangingEvent;
					if (matchReportRowChangingEvent != null)
					{
						matchReportRowChangingEvent(this, new Partyprint.MatchReportRowChangeEvent((Partyprint.MatchReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BE7 RID: 7143 RVA: 0x0039921C File Offset: 0x0039761C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.MatchReportRowDeletedEvent != null)
				{
					Partyprint.MatchReportRowChangeEventHandler matchReportRowDeletedEvent = this.MatchReportRowDeletedEvent;
					if (matchReportRowDeletedEvent != null)
					{
						matchReportRowDeletedEvent(this, new Partyprint.MatchReportRowChangeEvent((Partyprint.MatchReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BE8 RID: 7144 RVA: 0x00399260 File Offset: 0x00397660
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.MatchReportRowDeletingEvent != null)
				{
					Partyprint.MatchReportRowChangeEventHandler matchReportRowDeletingEvent = this.MatchReportRowDeletingEvent;
					if (matchReportRowDeletingEvent != null)
					{
						matchReportRowDeletingEvent(this, new Partyprint.MatchReportRowChangeEvent((Partyprint.MatchReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001BE9 RID: 7145 RVA: 0x003992A4 File Offset: 0x003976A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveMatchReportRow(Partyprint.MatchReportRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001BEA RID: 7146 RVA: 0x003992B4 File Offset: 0x003976B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "MatchReportDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000BD7 RID: 3031
			private DataColumn columnm_eid;

			// Token: 0x04000BD8 RID: 3032
			private DataColumn columnm_amt;

			// Token: 0x04000BD9 RID: 3033
			private DataColumn columnm_rate;

			// Token: 0x04000BDA RID: 3034
			private DataColumn columnm_team;

			// Token: 0x04000BDB RID: 3035
			private DataColumn columnm_mode;

			// Token: 0x04000BDC RID: 3036
			private DataColumn columnm_party;

			// Token: 0x04000BDD RID: 3037
			private DataColumn columnSr_No;

			// Token: 0x04000BDE RID: 3038
			private DataColumn columnDate1;

			// Token: 0x04000BDF RID: 3039
			private DataColumn columnTeam1;

			// Token: 0x04000BE0 RID: 3040
			private DataColumn columnName;

			// Token: 0x04000BE1 RID: 3041
			private DataColumn columnType;
		}

		// Token: 0x02000073 RID: 115
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SessionReportDataTable : TypedTableBase<Partyprint.SessionReportRow>
		{
			// Token: 0x06001BEB RID: 7147 RVA: 0x003994CC File Offset: 0x003978CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public SessionReportDataTable()
			{
				this.TableName = "SessionReport";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001BEC RID: 7148 RVA: 0x003994F4 File Offset: 0x003978F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal SessionReportDataTable(DataTable table)
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

			// Token: 0x06001BED RID: 7149 RVA: 0x003995A0 File Offset: 0x003979A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected SessionReportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x06001BEE RID: 7150 RVA: 0x003995B0 File Offset: 0x003979B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Team1Column
			{
				get
				{
					return this.columnTeam1;
				}
			}

			// Token: 0x17000AC6 RID: 2758
			// (get) Token: 0x06001BEF RID: 7151 RVA: 0x003995C4 File Offset: 0x003979C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x003995D8 File Offset: 0x003979D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Sr_NoColumn
			{
				get
				{
					return this.columnSr_No;
				}
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x003995EC File Offset: 0x003979EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DtColumn
			{
				get
				{
					return this.columnDt;
				}
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00399600 File Offset: 0x00397A00
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn N_nameColumn
			{
				get
				{
					return this.columnN_name;
				}
			}

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00399614 File Offset: 0x00397A14
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeColumn
			{
				get
				{
					return this.columnType;
				}
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00399628 File Offset: 0x00397A28
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x17000ACC RID: 2764
			// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0039963C File Offset: 0x00397A3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn s_rateColumn
			{
				get
				{
					return this.columns_rate;
				}
			}

			// Token: 0x17000ACD RID: 2765
			// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00399650 File Offset: 0x00397A50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn s_amtColumn
			{
				get
				{
					return this.columns_amt;
				}
			}

			// Token: 0x17000ACE RID: 2766
			// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00399664 File Offset: 0x00397A64
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn S_RUNColumn
			{
				get
				{
					return this.columnS_RUN;
				}
			}

			// Token: 0x17000ACF RID: 2767
			// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00399678 File Offset: 0x00397A78
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn s_bildColumn
			{
				get
				{
					return this.columns_bild;
				}
			}

			// Token: 0x17000AD0 RID: 2768
			// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x0039968C File Offset: 0x00397A8C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn s_modColumn
			{
				get
				{
					return this.columns_mod;
				}
			}

			// Token: 0x17000AD1 RID: 2769
			// (get) Token: 0x06001BFA RID: 7162 RVA: 0x003996A0 File Offset: 0x00397AA0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn s_partyColumn
			{
				get
				{
					return this.columns_party;
				}
			}

			// Token: 0x17000AD2 RID: 2770
			// (get) Token: 0x06001BFB RID: 7163 RVA: 0x003996B4 File Offset: 0x00397AB4
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

			// Token: 0x17000AD3 RID: 2771
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.SessionReportRow this[int index]
			{
				get
				{
					return (Partyprint.SessionReportRow)this.Rows[index];
				}
			}

			// Token: 0x1400002D RID: 45
			// (add) Token: 0x06001BFD RID: 7165 RVA: 0x003996EC File Offset: 0x00397AEC
			// (remove) Token: 0x06001BFE RID: 7166 RVA: 0x00399708 File Offset: 0x00397B08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.SessionReportRowChangeEventHandler SessionReportRowChanging;

			// Token: 0x1400002E RID: 46
			// (add) Token: 0x06001BFF RID: 7167 RVA: 0x00399724 File Offset: 0x00397B24
			// (remove) Token: 0x06001C00 RID: 7168 RVA: 0x00399740 File Offset: 0x00397B40
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.SessionReportRowChangeEventHandler SessionReportRowChanged;

			// Token: 0x1400002F RID: 47
			// (add) Token: 0x06001C01 RID: 7169 RVA: 0x0039975C File Offset: 0x00397B5C
			// (remove) Token: 0x06001C02 RID: 7170 RVA: 0x00399778 File Offset: 0x00397B78
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.SessionReportRowChangeEventHandler SessionReportRowDeleting;

			// Token: 0x14000030 RID: 48
			// (add) Token: 0x06001C03 RID: 7171 RVA: 0x00399794 File Offset: 0x00397B94
			// (remove) Token: 0x06001C04 RID: 7172 RVA: 0x003997B0 File Offset: 0x00397BB0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.SessionReportRowChangeEventHandler SessionReportRowDeleted;

			// Token: 0x06001C05 RID: 7173 RVA: 0x003997CC File Offset: 0x00397BCC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddSessionReportRow(Partyprint.SessionReportRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001C06 RID: 7174 RVA: 0x003997DC File Offset: 0x00397BDC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.SessionReportRow AddSessionReportRow(string Team1, string Name, string Sr_No, string Dt, string N_name, string Type, string id, string s_rate, string s_amt, string S_RUN, string s_bild, string s_mod, string s_party)
			{
				Partyprint.SessionReportRow sessionReportRow = (Partyprint.SessionReportRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Team1,
					Name,
					Sr_No,
					Dt,
					N_name,
					Type,
					id,
					s_rate,
					s_amt,
					S_RUN,
					s_bild,
					s_mod,
					s_party
				};
				sessionReportRow.ItemArray = itemArray;
				this.Rows.Add(sessionReportRow);
				return sessionReportRow;
			}

			// Token: 0x06001C07 RID: 7175 RVA: 0x00399858 File Offset: 0x00397C58
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.SessionReportDataTable sessionReportDataTable = (Partyprint.SessionReportDataTable)base.Clone();
				sessionReportDataTable.InitVars();
				return sessionReportDataTable;
			}

			// Token: 0x06001C08 RID: 7176 RVA: 0x00399878 File Offset: 0x00397C78
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.SessionReportDataTable();
			}

			// Token: 0x06001C09 RID: 7177 RVA: 0x0039988C File Offset: 0x00397C8C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnTeam1 = base.Columns["Team1"];
				this.columnName = base.Columns["Name"];
				this.columnSr_No = base.Columns["Sr_No"];
				this.columnDt = base.Columns["Dt"];
				this.columnN_name = base.Columns["N_name"];
				this.columnType = base.Columns["Type"];
				this.columnid = base.Columns["id"];
				this.columns_rate = base.Columns["s_rate"];
				this.columns_amt = base.Columns["s_amt"];
				this.columnS_RUN = base.Columns["S_RUN"];
				this.columns_bild = base.Columns["s_bild"];
				this.columns_mod = base.Columns["s_mod"];
				this.columns_party = base.Columns["s_party"];
			}

			// Token: 0x06001C0A RID: 7178 RVA: 0x003999B8 File Offset: 0x00397DB8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnTeam1 = new DataColumn("Team1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTeam1);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnSr_No = new DataColumn("Sr_No", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSr_No);
				this.columnDt = new DataColumn("Dt", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDt);
				this.columnN_name = new DataColumn("N_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnN_name);
				this.columnType = new DataColumn("Type", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnType);
				this.columnid = new DataColumn("id", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columns_rate = new DataColumn("s_rate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columns_rate);
				this.columns_amt = new DataColumn("s_amt", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columns_amt);
				this.columnS_RUN = new DataColumn("S_RUN", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnS_RUN);
				this.columns_bild = new DataColumn("s_bild", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columns_bild);
				this.columns_mod = new DataColumn("s_mod", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columns_mod);
				this.columns_party = new DataColumn("s_party", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columns_party);
			}

			// Token: 0x06001C0B RID: 7179 RVA: 0x00399C10 File Offset: 0x00398010
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.SessionReportRow NewSessionReportRow()
			{
				return (Partyprint.SessionReportRow)this.NewRow();
			}

			// Token: 0x06001C0C RID: 7180 RVA: 0x00399C28 File Offset: 0x00398028
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.SessionReportRow(builder);
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x00399C3C File Offset: 0x0039803C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.SessionReportRow);
			}

			// Token: 0x06001C0E RID: 7182 RVA: 0x00399C54 File Offset: 0x00398054
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SessionReportRowChangedEvent != null)
				{
					Partyprint.SessionReportRowChangeEventHandler sessionReportRowChangedEvent = this.SessionReportRowChangedEvent;
					if (sessionReportRowChangedEvent != null)
					{
						sessionReportRowChangedEvent(this, new Partyprint.SessionReportRowChangeEvent((Partyprint.SessionReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C0F RID: 7183 RVA: 0x00399C98 File Offset: 0x00398098
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SessionReportRowChangingEvent != null)
				{
					Partyprint.SessionReportRowChangeEventHandler sessionReportRowChangingEvent = this.SessionReportRowChangingEvent;
					if (sessionReportRowChangingEvent != null)
					{
						sessionReportRowChangingEvent(this, new Partyprint.SessionReportRowChangeEvent((Partyprint.SessionReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C10 RID: 7184 RVA: 0x00399CDC File Offset: 0x003980DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SessionReportRowDeletedEvent != null)
				{
					Partyprint.SessionReportRowChangeEventHandler sessionReportRowDeletedEvent = this.SessionReportRowDeletedEvent;
					if (sessionReportRowDeletedEvent != null)
					{
						sessionReportRowDeletedEvent(this, new Partyprint.SessionReportRowChangeEvent((Partyprint.SessionReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C11 RID: 7185 RVA: 0x00399D20 File Offset: 0x00398120
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SessionReportRowDeletingEvent != null)
				{
					Partyprint.SessionReportRowChangeEventHandler sessionReportRowDeletingEvent = this.SessionReportRowDeletingEvent;
					if (sessionReportRowDeletingEvent != null)
					{
						sessionReportRowDeletingEvent(this, new Partyprint.SessionReportRowChangeEvent((Partyprint.SessionReportRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C12 RID: 7186 RVA: 0x00399D64 File Offset: 0x00398164
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveSessionReportRow(Partyprint.SessionReportRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001C13 RID: 7187 RVA: 0x00399D74 File Offset: 0x00398174
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SessionReportDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000BE6 RID: 3046
			private DataColumn columnTeam1;

			// Token: 0x04000BE7 RID: 3047
			private DataColumn columnName;

			// Token: 0x04000BE8 RID: 3048
			private DataColumn columnSr_No;

			// Token: 0x04000BE9 RID: 3049
			private DataColumn columnDt;

			// Token: 0x04000BEA RID: 3050
			private DataColumn columnN_name;

			// Token: 0x04000BEB RID: 3051
			private DataColumn columnType;

			// Token: 0x04000BEC RID: 3052
			private DataColumn columnid;

			// Token: 0x04000BED RID: 3053
			private DataColumn columns_rate;

			// Token: 0x04000BEE RID: 3054
			private DataColumn columns_amt;

			// Token: 0x04000BEF RID: 3055
			private DataColumn columnS_RUN;

			// Token: 0x04000BF0 RID: 3056
			private DataColumn columns_bild;

			// Token: 0x04000BF1 RID: 3057
			private DataColumn columns_mod;

			// Token: 0x04000BF2 RID: 3058
			private DataColumn columns_party;
		}

		// Token: 0x02000074 RID: 116
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class ListViewDataDataTable : TypedTableBase<Partyprint.ListViewDataRow>
		{
			// Token: 0x06001C14 RID: 7188 RVA: 0x00399F8C File Offset: 0x0039838C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public ListViewDataDataTable()
			{
				this.TableName = "ListViewData";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001C15 RID: 7189 RVA: 0x00399FB4 File Offset: 0x003983B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ListViewDataDataTable(DataTable table)
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

			// Token: 0x06001C16 RID: 7190 RVA: 0x0039A060 File Offset: 0x00398460
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected ListViewDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AD4 RID: 2772
			// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0039A070 File Offset: 0x00398470
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Sr_NoColumn
			{
				get
				{
					return this.columnSr_No;
				}
			}

			// Token: 0x17000AD5 RID: 2773
			// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0039A084 File Offset: 0x00398484
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AmountColumn
			{
				get
				{
					return this.columnAmount;
				}
			}

			// Token: 0x17000AD6 RID: 2774
			// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0039A098 File Offset: 0x00398498
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn RateColumn
			{
				get
				{
					return this.columnRate;
				}
			}

			// Token: 0x17000AD7 RID: 2775
			// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0039A0AC File Offset: 0x003984AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn FovrtColumn
			{
				get
				{
					return this.columnFovrt;
				}
			}

			// Token: 0x17000AD8 RID: 2776
			// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0039A0C0 File Offset: 0x003984C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ModeColumn
			{
				get
				{
					return this.columnMode;
				}
			}

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0039A0D4 File Offset: 0x003984D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn nameColumn
			{
				get
				{
					return this.columnname;
				}
			}

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0039A0E8 File Offset: 0x003984E8
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

			// Token: 0x17000ADB RID: 2779
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.ListViewDataRow this[int index]
			{
				get
				{
					return (Partyprint.ListViewDataRow)this.Rows[index];
				}
			}

			// Token: 0x14000031 RID: 49
			// (add) Token: 0x06001C1F RID: 7199 RVA: 0x0039A120 File Offset: 0x00398520
			// (remove) Token: 0x06001C20 RID: 7200 RVA: 0x0039A13C File Offset: 0x0039853C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewDataRowChangeEventHandler ListViewDataRowChanging;

			// Token: 0x14000032 RID: 50
			// (add) Token: 0x06001C21 RID: 7201 RVA: 0x0039A158 File Offset: 0x00398558
			// (remove) Token: 0x06001C22 RID: 7202 RVA: 0x0039A174 File Offset: 0x00398574
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewDataRowChangeEventHandler ListViewDataRowChanged;

			// Token: 0x14000033 RID: 51
			// (add) Token: 0x06001C23 RID: 7203 RVA: 0x0039A190 File Offset: 0x00398590
			// (remove) Token: 0x06001C24 RID: 7204 RVA: 0x0039A1AC File Offset: 0x003985AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewDataRowChangeEventHandler ListViewDataRowDeleting;

			// Token: 0x14000034 RID: 52
			// (add) Token: 0x06001C25 RID: 7205 RVA: 0x0039A1C8 File Offset: 0x003985C8
			// (remove) Token: 0x06001C26 RID: 7206 RVA: 0x0039A1E4 File Offset: 0x003985E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewDataRowChangeEventHandler ListViewDataRowDeleted;

			// Token: 0x06001C27 RID: 7207 RVA: 0x0039A200 File Offset: 0x00398600
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddListViewDataRow(Partyprint.ListViewDataRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001C28 RID: 7208 RVA: 0x0039A210 File Offset: 0x00398610
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.ListViewDataRow AddListViewDataRow(string Sr_No, string Amount, string Rate, string Fovrt, string Mode, string name)
			{
				Partyprint.ListViewDataRow listViewDataRow = (Partyprint.ListViewDataRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Sr_No,
					Amount,
					Rate,
					Fovrt,
					Mode,
					name
				};
				listViewDataRow.ItemArray = itemArray;
				this.Rows.Add(listViewDataRow);
				return listViewDataRow;
			}

			// Token: 0x06001C29 RID: 7209 RVA: 0x0039A264 File Offset: 0x00398664
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Partyprint.ListViewDataDataTable listViewDataDataTable = (Partyprint.ListViewDataDataTable)base.Clone();
				listViewDataDataTable.InitVars();
				return listViewDataDataTable;
			}

			// Token: 0x06001C2A RID: 7210 RVA: 0x0039A284 File Offset: 0x00398684
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.ListViewDataDataTable();
			}

			// Token: 0x06001C2B RID: 7211 RVA: 0x0039A298 File Offset: 0x00398698
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnSr_No = base.Columns["Sr_No"];
				this.columnAmount = base.Columns["Amount"];
				this.columnRate = base.Columns["Rate"];
				this.columnFovrt = base.Columns["Fovrt"];
				this.columnMode = base.Columns["Mode"];
				this.columnname = base.Columns["name"];
			}

			// Token: 0x06001C2C RID: 7212 RVA: 0x0039A32C File Offset: 0x0039872C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnSr_No = new DataColumn("Sr_No", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSr_No);
				this.columnAmount = new DataColumn("Amount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAmount);
				this.columnRate = new DataColumn("Rate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRate);
				this.columnFovrt = new DataColumn("Fovrt", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFovrt);
				this.columnMode = new DataColumn("Mode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMode);
				this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnname);
			}

			// Token: 0x06001C2D RID: 7213 RVA: 0x0039A448 File Offset: 0x00398848
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.ListViewDataRow NewListViewDataRow()
			{
				return (Partyprint.ListViewDataRow)this.NewRow();
			}

			// Token: 0x06001C2E RID: 7214 RVA: 0x0039A460 File Offset: 0x00398860
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.ListViewDataRow(builder);
			}

			// Token: 0x06001C2F RID: 7215 RVA: 0x0039A474 File Offset: 0x00398874
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.ListViewDataRow);
			}

			// Token: 0x06001C30 RID: 7216 RVA: 0x0039A48C File Offset: 0x0039888C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ListViewDataRowChangedEvent != null)
				{
					Partyprint.ListViewDataRowChangeEventHandler listViewDataRowChangedEvent = this.ListViewDataRowChangedEvent;
					if (listViewDataRowChangedEvent != null)
					{
						listViewDataRowChangedEvent(this, new Partyprint.ListViewDataRowChangeEvent((Partyprint.ListViewDataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C31 RID: 7217 RVA: 0x0039A4D0 File Offset: 0x003988D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ListViewDataRowChangingEvent != null)
				{
					Partyprint.ListViewDataRowChangeEventHandler listViewDataRowChangingEvent = this.ListViewDataRowChangingEvent;
					if (listViewDataRowChangingEvent != null)
					{
						listViewDataRowChangingEvent(this, new Partyprint.ListViewDataRowChangeEvent((Partyprint.ListViewDataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C32 RID: 7218 RVA: 0x0039A514 File Offset: 0x00398914
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ListViewDataRowDeletedEvent != null)
				{
					Partyprint.ListViewDataRowChangeEventHandler listViewDataRowDeletedEvent = this.ListViewDataRowDeletedEvent;
					if (listViewDataRowDeletedEvent != null)
					{
						listViewDataRowDeletedEvent(this, new Partyprint.ListViewDataRowChangeEvent((Partyprint.ListViewDataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C33 RID: 7219 RVA: 0x0039A558 File Offset: 0x00398958
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ListViewDataRowDeletingEvent != null)
				{
					Partyprint.ListViewDataRowChangeEventHandler listViewDataRowDeletingEvent = this.ListViewDataRowDeletingEvent;
					if (listViewDataRowDeletingEvent != null)
					{
						listViewDataRowDeletingEvent(this, new Partyprint.ListViewDataRowChangeEvent((Partyprint.ListViewDataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C34 RID: 7220 RVA: 0x0039A59C File Offset: 0x0039899C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveListViewDataRow(Partyprint.ListViewDataRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001C35 RID: 7221 RVA: 0x0039A5AC File Offset: 0x003989AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "ListViewDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000BF7 RID: 3063
			private DataColumn columnSr_No;

			// Token: 0x04000BF8 RID: 3064
			private DataColumn columnAmount;

			// Token: 0x04000BF9 RID: 3065
			private DataColumn columnRate;

			// Token: 0x04000BFA RID: 3066
			private DataColumn columnFovrt;

			// Token: 0x04000BFB RID: 3067
			private DataColumn columnMode;

			// Token: 0x04000BFC RID: 3068
			private DataColumn columnname;
		}

		// Token: 0x02000075 RID: 117
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class ListViewData1DataTable : TypedTableBase<Partyprint.ListViewData1Row>
		{
			// Token: 0x06001C36 RID: 7222 RVA: 0x0039A7C4 File Offset: 0x00398BC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ListViewData1DataTable()
			{
				this.TableName = "ListViewData1";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001C37 RID: 7223 RVA: 0x0039A7EC File Offset: 0x00398BEC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal ListViewData1DataTable(DataTable table)
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

			// Token: 0x06001C38 RID: 7224 RVA: 0x0039A898 File Offset: 0x00398C98
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected ListViewData1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000ADC RID: 2780
			// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0039A8A8 File Offset: 0x00398CA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Sr_NoColumn
			{
				get
				{
					return this.columnSr_No;
				}
			}

			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0039A8BC File Offset: 0x00398CBC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AmountColumn
			{
				get
				{
					return this.columnAmount;
				}
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0039A8D0 File Offset: 0x00398CD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn RateColumn
			{
				get
				{
					return this.columnRate;
				}
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0039A8E4 File Offset: 0x00398CE4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RunColumn
			{
				get
				{
					return this.columnRun;
				}
			}

			// Token: 0x17000AE0 RID: 2784
			// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0039A8F8 File Offset: 0x00398CF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ModeColumn
			{
				get
				{
					return this.columnMode;
				}
			}

			// Token: 0x17000AE1 RID: 2785
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0039A90C File Offset: 0x00398D0C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn BadliColumn
			{
				get
				{
					return this.columnBadli;
				}
			}

			// Token: 0x17000AE2 RID: 2786
			// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0039A920 File Offset: 0x00398D20
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nameColumn
			{
				get
				{
					return this.columnname;
				}
			}

			// Token: 0x17000AE3 RID: 2787
			// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0039A934 File Offset: 0x00398D34
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

			// Token: 0x17000AE4 RID: 2788
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.ListViewData1Row this[int index]
			{
				get
				{
					return (Partyprint.ListViewData1Row)this.Rows[index];
				}
			}

			// Token: 0x14000035 RID: 53
			// (add) Token: 0x06001C42 RID: 7234 RVA: 0x0039A96C File Offset: 0x00398D6C
			// (remove) Token: 0x06001C43 RID: 7235 RVA: 0x0039A988 File Offset: 0x00398D88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewData1RowChangeEventHandler ListViewData1RowChanging;

			// Token: 0x14000036 RID: 54
			// (add) Token: 0x06001C44 RID: 7236 RVA: 0x0039A9A4 File Offset: 0x00398DA4
			// (remove) Token: 0x06001C45 RID: 7237 RVA: 0x0039A9C0 File Offset: 0x00398DC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewData1RowChangeEventHandler ListViewData1RowChanged;

			// Token: 0x14000037 RID: 55
			// (add) Token: 0x06001C46 RID: 7238 RVA: 0x0039A9DC File Offset: 0x00398DDC
			// (remove) Token: 0x06001C47 RID: 7239 RVA: 0x0039A9F8 File Offset: 0x00398DF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewData1RowChangeEventHandler ListViewData1RowDeleting;

			// Token: 0x14000038 RID: 56
			// (add) Token: 0x06001C48 RID: 7240 RVA: 0x0039AA14 File Offset: 0x00398E14
			// (remove) Token: 0x06001C49 RID: 7241 RVA: 0x0039AA30 File Offset: 0x00398E30
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.ListViewData1RowChangeEventHandler ListViewData1RowDeleted;

			// Token: 0x06001C4A RID: 7242 RVA: 0x0039AA4C File Offset: 0x00398E4C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddListViewData1Row(Partyprint.ListViewData1Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x0039AA5C File Offset: 0x00398E5C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.ListViewData1Row AddListViewData1Row(string Sr_No, string Amount, string Rate, string Run, string Mode, string Badli, string name)
			{
				Partyprint.ListViewData1Row listViewData1Row = (Partyprint.ListViewData1Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Sr_No,
					Amount,
					Rate,
					Run,
					Mode,
					Badli,
					name
				};
				listViewData1Row.ItemArray = itemArray;
				this.Rows.Add(listViewData1Row);
				return listViewData1Row;
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x0039AAB4 File Offset: 0x00398EB4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.ListViewData1DataTable listViewData1DataTable = (Partyprint.ListViewData1DataTable)base.Clone();
				listViewData1DataTable.InitVars();
				return listViewData1DataTable;
			}

			// Token: 0x06001C4D RID: 7245 RVA: 0x0039AAD4 File Offset: 0x00398ED4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.ListViewData1DataTable();
			}

			// Token: 0x06001C4E RID: 7246 RVA: 0x0039AAE8 File Offset: 0x00398EE8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnSr_No = base.Columns["Sr_No"];
				this.columnAmount = base.Columns["Amount"];
				this.columnRate = base.Columns["Rate"];
				this.columnRun = base.Columns["Run"];
				this.columnMode = base.Columns["Mode"];
				this.columnBadli = base.Columns["Badli"];
				this.columnname = base.Columns["name"];
			}

			// Token: 0x06001C4F RID: 7247 RVA: 0x0039AB90 File Offset: 0x00398F90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnSr_No = new DataColumn("Sr_No", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSr_No);
				this.columnAmount = new DataColumn("Amount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAmount);
				this.columnRate = new DataColumn("Rate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRate);
				this.columnRun = new DataColumn("Run", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRun);
				this.columnMode = new DataColumn("Mode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMode);
				this.columnBadli = new DataColumn("Badli", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBadli);
				this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnname);
			}

			// Token: 0x06001C50 RID: 7248 RVA: 0x0039ACD8 File Offset: 0x003990D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.ListViewData1Row NewListViewData1Row()
			{
				return (Partyprint.ListViewData1Row)this.NewRow();
			}

			// Token: 0x06001C51 RID: 7249 RVA: 0x0039ACF0 File Offset: 0x003990F0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.ListViewData1Row(builder);
			}

			// Token: 0x06001C52 RID: 7250 RVA: 0x0039AD04 File Offset: 0x00399104
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.ListViewData1Row);
			}

			// Token: 0x06001C53 RID: 7251 RVA: 0x0039AD1C File Offset: 0x0039911C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ListViewData1RowChangedEvent != null)
				{
					Partyprint.ListViewData1RowChangeEventHandler listViewData1RowChangedEvent = this.ListViewData1RowChangedEvent;
					if (listViewData1RowChangedEvent != null)
					{
						listViewData1RowChangedEvent(this, new Partyprint.ListViewData1RowChangeEvent((Partyprint.ListViewData1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C54 RID: 7252 RVA: 0x0039AD60 File Offset: 0x00399160
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ListViewData1RowChangingEvent != null)
				{
					Partyprint.ListViewData1RowChangeEventHandler listViewData1RowChangingEvent = this.ListViewData1RowChangingEvent;
					if (listViewData1RowChangingEvent != null)
					{
						listViewData1RowChangingEvent(this, new Partyprint.ListViewData1RowChangeEvent((Partyprint.ListViewData1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C55 RID: 7253 RVA: 0x0039ADA4 File Offset: 0x003991A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ListViewData1RowDeletedEvent != null)
				{
					Partyprint.ListViewData1RowChangeEventHandler listViewData1RowDeletedEvent = this.ListViewData1RowDeletedEvent;
					if (listViewData1RowDeletedEvent != null)
					{
						listViewData1RowDeletedEvent(this, new Partyprint.ListViewData1RowChangeEvent((Partyprint.ListViewData1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C56 RID: 7254 RVA: 0x0039ADE8 File Offset: 0x003991E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ListViewData1RowDeletingEvent != null)
				{
					Partyprint.ListViewData1RowChangeEventHandler listViewData1RowDeletingEvent = this.ListViewData1RowDeletingEvent;
					if (listViewData1RowDeletingEvent != null)
					{
						listViewData1RowDeletingEvent(this, new Partyprint.ListViewData1RowChangeEvent((Partyprint.ListViewData1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C57 RID: 7255 RVA: 0x0039AE2C File Offset: 0x0039922C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveListViewData1Row(Partyprint.ListViewData1Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001C58 RID: 7256 RVA: 0x0039AE3C File Offset: 0x0039923C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "ListViewData1DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C01 RID: 3073
			private DataColumn columnSr_No;

			// Token: 0x04000C02 RID: 3074
			private DataColumn columnAmount;

			// Token: 0x04000C03 RID: 3075
			private DataColumn columnRate;

			// Token: 0x04000C04 RID: 3076
			private DataColumn columnRun;

			// Token: 0x04000C05 RID: 3077
			private DataColumn columnMode;

			// Token: 0x04000C06 RID: 3078
			private DataColumn columnBadli;

			// Token: 0x04000C07 RID: 3079
			private DataColumn columnname;
		}

		// Token: 0x02000076 RID: 118
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class FinalTBDataTable : TypedTableBase<Partyprint.FinalTBRow>
		{
			// Token: 0x06001C59 RID: 7257 RVA: 0x0039B054 File Offset: 0x00399454
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public FinalTBDataTable()
			{
				this.TableName = "FinalTB";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001C5A RID: 7258 RVA: 0x0039B07C File Offset: 0x0039947C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal FinalTBDataTable(DataTable table)
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

			// Token: 0x06001C5B RID: 7259 RVA: 0x0039B128 File Offset: 0x00399528
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected FinalTBDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AE5 RID: 2789
			// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0039B138 File Offset: 0x00399538
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn aColumn
			{
				get
				{
					return this.columna;
				}
			}

			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0039B14C File Offset: 0x0039954C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bColumn
			{
				get
				{
					return this.columnb;
				}
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0039B160 File Offset: 0x00399560
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cColumn
			{
				get
				{
					return this.columnc;
				}
			}

			// Token: 0x17000AE8 RID: 2792
			// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0039B174 File Offset: 0x00399574
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn dColumn
			{
				get
				{
					return this.columnd;
				}
			}

			// Token: 0x17000AE9 RID: 2793
			// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0039B188 File Offset: 0x00399588
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

			// Token: 0x17000AEA RID: 2794
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.FinalTBRow this[int index]
			{
				get
				{
					return (Partyprint.FinalTBRow)this.Rows[index];
				}
			}

			// Token: 0x14000039 RID: 57
			// (add) Token: 0x06001C62 RID: 7266 RVA: 0x0039B1C0 File Offset: 0x003995C0
			// (remove) Token: 0x06001C63 RID: 7267 RVA: 0x0039B1DC File Offset: 0x003995DC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.FinalTBRowChangeEventHandler FinalTBRowChanging;

			// Token: 0x1400003A RID: 58
			// (add) Token: 0x06001C64 RID: 7268 RVA: 0x0039B1F8 File Offset: 0x003995F8
			// (remove) Token: 0x06001C65 RID: 7269 RVA: 0x0039B214 File Offset: 0x00399614
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.FinalTBRowChangeEventHandler FinalTBRowChanged;

			// Token: 0x1400003B RID: 59
			// (add) Token: 0x06001C66 RID: 7270 RVA: 0x0039B230 File Offset: 0x00399630
			// (remove) Token: 0x06001C67 RID: 7271 RVA: 0x0039B24C File Offset: 0x0039964C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.FinalTBRowChangeEventHandler FinalTBRowDeleting;

			// Token: 0x1400003C RID: 60
			// (add) Token: 0x06001C68 RID: 7272 RVA: 0x0039B268 File Offset: 0x00399668
			// (remove) Token: 0x06001C69 RID: 7273 RVA: 0x0039B284 File Offset: 0x00399684
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.FinalTBRowChangeEventHandler FinalTBRowDeleted;

			// Token: 0x06001C6A RID: 7274 RVA: 0x0039B2A0 File Offset: 0x003996A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddFinalTBRow(Partyprint.FinalTBRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001C6B RID: 7275 RVA: 0x0039B2B0 File Offset: 0x003996B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.FinalTBRow AddFinalTBRow(string a, string b, string c, string d)
			{
				Partyprint.FinalTBRow finalTBRow = (Partyprint.FinalTBRow)this.NewRow();
				object[] itemArray = new object[]
				{
					a,
					b,
					c,
					d
				};
				finalTBRow.ItemArray = itemArray;
				this.Rows.Add(finalTBRow);
				return finalTBRow;
			}

			// Token: 0x06001C6C RID: 7276 RVA: 0x0039B2F8 File Offset: 0x003996F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.FinalTBDataTable finalTBDataTable = (Partyprint.FinalTBDataTable)base.Clone();
				finalTBDataTable.InitVars();
				return finalTBDataTable;
			}

			// Token: 0x06001C6D RID: 7277 RVA: 0x0039B318 File Offset: 0x00399718
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.FinalTBDataTable();
			}

			// Token: 0x06001C6E RID: 7278 RVA: 0x0039B32C File Offset: 0x0039972C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columna = base.Columns["a"];
				this.columnb = base.Columns["b"];
				this.columnc = base.Columns["c"];
				this.columnd = base.Columns["d"];
			}

			// Token: 0x06001C6F RID: 7279 RVA: 0x0039B394 File Offset: 0x00399794
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columna = new DataColumn("a", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columna);
				this.columnb = new DataColumn("b", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnb);
				this.columnc = new DataColumn("c", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnc);
				this.columnd = new DataColumn("d", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnd);
			}

			// Token: 0x06001C70 RID: 7280 RVA: 0x0039B458 File Offset: 0x00399858
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.FinalTBRow NewFinalTBRow()
			{
				return (Partyprint.FinalTBRow)this.NewRow();
			}

			// Token: 0x06001C71 RID: 7281 RVA: 0x0039B470 File Offset: 0x00399870
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.FinalTBRow(builder);
			}

			// Token: 0x06001C72 RID: 7282 RVA: 0x0039B484 File Offset: 0x00399884
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.FinalTBRow);
			}

			// Token: 0x06001C73 RID: 7283 RVA: 0x0039B49C File Offset: 0x0039989C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.FinalTBRowChangedEvent != null)
				{
					Partyprint.FinalTBRowChangeEventHandler finalTBRowChangedEvent = this.FinalTBRowChangedEvent;
					if (finalTBRowChangedEvent != null)
					{
						finalTBRowChangedEvent(this, new Partyprint.FinalTBRowChangeEvent((Partyprint.FinalTBRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C74 RID: 7284 RVA: 0x0039B4E0 File Offset: 0x003998E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.FinalTBRowChangingEvent != null)
				{
					Partyprint.FinalTBRowChangeEventHandler finalTBRowChangingEvent = this.FinalTBRowChangingEvent;
					if (finalTBRowChangingEvent != null)
					{
						finalTBRowChangingEvent(this, new Partyprint.FinalTBRowChangeEvent((Partyprint.FinalTBRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C75 RID: 7285 RVA: 0x0039B524 File Offset: 0x00399924
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.FinalTBRowDeletedEvent != null)
				{
					Partyprint.FinalTBRowChangeEventHandler finalTBRowDeletedEvent = this.FinalTBRowDeletedEvent;
					if (finalTBRowDeletedEvent != null)
					{
						finalTBRowDeletedEvent(this, new Partyprint.FinalTBRowChangeEvent((Partyprint.FinalTBRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C76 RID: 7286 RVA: 0x0039B568 File Offset: 0x00399968
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.FinalTBRowDeletingEvent != null)
				{
					Partyprint.FinalTBRowChangeEventHandler finalTBRowDeletingEvent = this.FinalTBRowDeletingEvent;
					if (finalTBRowDeletingEvent != null)
					{
						finalTBRowDeletingEvent(this, new Partyprint.FinalTBRowChangeEvent((Partyprint.FinalTBRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C77 RID: 7287 RVA: 0x0039B5AC File Offset: 0x003999AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveFinalTBRow(Partyprint.FinalTBRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001C78 RID: 7288 RVA: 0x0039B5BC File Offset: 0x003999BC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "FinalTBDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C0C RID: 3084
			private DataColumn columna;

			// Token: 0x04000C0D RID: 3085
			private DataColumn columnb;

			// Token: 0x04000C0E RID: 3086
			private DataColumn columnc;

			// Token: 0x04000C0F RID: 3087
			private DataColumn columnd;
		}

		// Token: 0x02000077 RID: 119
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class HawalDataTable : TypedTableBase<Partyprint.HawalRow>
		{
			// Token: 0x06001C79 RID: 7289 RVA: 0x0039B7D4 File Offset: 0x00399BD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public HawalDataTable()
			{
				this.TableName = "Hawal";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001C7A RID: 7290 RVA: 0x0039B7FC File Offset: 0x00399BFC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal HawalDataTable(DataTable table)
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

			// Token: 0x06001C7B RID: 7291 RVA: 0x0039B8A8 File Offset: 0x00399CA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected HawalDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AEB RID: 2795
			// (get) Token: 0x06001C7C RID: 7292 RVA: 0x0039B8B8 File Offset: 0x00399CB8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0039B8CC File Offset: 0x00399CCC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x06001C7E RID: 7294 RVA: 0x0039B8E0 File Offset: 0x00399CE0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column3Column
			{
				get
				{
					return this.columnColumn3;
				}
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0039B8F4 File Offset: 0x00399CF4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column4Column
			{
				get
				{
					return this.columnColumn4;
				}
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0039B908 File Offset: 0x00399D08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column5Column
			{
				get
				{
					return this.columnColumn5;
				}
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0039B91C File Offset: 0x00399D1C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column6Column
			{
				get
				{
					return this.columnColumn6;
				}
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0039B930 File Offset: 0x00399D30
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

			// Token: 0x17000AF2 RID: 2802
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.HawalRow this[int index]
			{
				get
				{
					return (Partyprint.HawalRow)this.Rows[index];
				}
			}

			// Token: 0x1400003D RID: 61
			// (add) Token: 0x06001C84 RID: 7300 RVA: 0x0039B968 File Offset: 0x00399D68
			// (remove) Token: 0x06001C85 RID: 7301 RVA: 0x0039B984 File Offset: 0x00399D84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.HawalRowChangeEventHandler HawalRowChanging;

			// Token: 0x1400003E RID: 62
			// (add) Token: 0x06001C86 RID: 7302 RVA: 0x0039B9A0 File Offset: 0x00399DA0
			// (remove) Token: 0x06001C87 RID: 7303 RVA: 0x0039B9BC File Offset: 0x00399DBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.HawalRowChangeEventHandler HawalRowChanged;

			// Token: 0x1400003F RID: 63
			// (add) Token: 0x06001C88 RID: 7304 RVA: 0x0039B9D8 File Offset: 0x00399DD8
			// (remove) Token: 0x06001C89 RID: 7305 RVA: 0x0039B9F4 File Offset: 0x00399DF4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.HawalRowChangeEventHandler HawalRowDeleting;

			// Token: 0x14000040 RID: 64
			// (add) Token: 0x06001C8A RID: 7306 RVA: 0x0039BA10 File Offset: 0x00399E10
			// (remove) Token: 0x06001C8B RID: 7307 RVA: 0x0039BA2C File Offset: 0x00399E2C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.HawalRowChangeEventHandler HawalRowDeleted;

			// Token: 0x06001C8C RID: 7308 RVA: 0x0039BA48 File Offset: 0x00399E48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddHawalRow(Partyprint.HawalRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001C8D RID: 7309 RVA: 0x0039BA58 File Offset: 0x00399E58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.HawalRow AddHawalRow(string Column1, string Column2, string Column3, string Column4, string Column5, string Column6)
			{
				Partyprint.HawalRow hawalRow = (Partyprint.HawalRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2,
					Column3,
					Column4,
					Column5,
					Column6
				};
				hawalRow.ItemArray = itemArray;
				this.Rows.Add(hawalRow);
				return hawalRow;
			}

			// Token: 0x06001C8E RID: 7310 RVA: 0x0039BAAC File Offset: 0x00399EAC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.HawalDataTable hawalDataTable = (Partyprint.HawalDataTable)base.Clone();
				hawalDataTable.InitVars();
				return hawalDataTable;
			}

			// Token: 0x06001C8F RID: 7311 RVA: 0x0039BACC File Offset: 0x00399ECC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.HawalDataTable();
			}

			// Token: 0x06001C90 RID: 7312 RVA: 0x0039BAE0 File Offset: 0x00399EE0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnColumn1 = base.Columns["Column1"];
				this.columnColumn2 = base.Columns["Column2"];
				this.columnColumn3 = base.Columns["Column3"];
				this.columnColumn4 = base.Columns["Column4"];
				this.columnColumn5 = base.Columns["Column5"];
				this.columnColumn6 = base.Columns["Column6"];
			}

			// Token: 0x06001C91 RID: 7313 RVA: 0x0039BB74 File Offset: 0x00399F74
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
				this.columnColumn5 = new DataColumn("Column5", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn5);
				this.columnColumn6 = new DataColumn("Column6", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnColumn6);
			}

			// Token: 0x06001C92 RID: 7314 RVA: 0x0039BC90 File Offset: 0x0039A090
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.HawalRow NewHawalRow()
			{
				return (Partyprint.HawalRow)this.NewRow();
			}

			// Token: 0x06001C93 RID: 7315 RVA: 0x0039BCA8 File Offset: 0x0039A0A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.HawalRow(builder);
			}

			// Token: 0x06001C94 RID: 7316 RVA: 0x0039BCBC File Offset: 0x0039A0BC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.HawalRow);
			}

			// Token: 0x06001C95 RID: 7317 RVA: 0x0039BCD4 File Offset: 0x0039A0D4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.HawalRowChangedEvent != null)
				{
					Partyprint.HawalRowChangeEventHandler hawalRowChangedEvent = this.HawalRowChangedEvent;
					if (hawalRowChangedEvent != null)
					{
						hawalRowChangedEvent(this, new Partyprint.HawalRowChangeEvent((Partyprint.HawalRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C96 RID: 7318 RVA: 0x0039BD18 File Offset: 0x0039A118
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.HawalRowChangingEvent != null)
				{
					Partyprint.HawalRowChangeEventHandler hawalRowChangingEvent = this.HawalRowChangingEvent;
					if (hawalRowChangingEvent != null)
					{
						hawalRowChangingEvent(this, new Partyprint.HawalRowChangeEvent((Partyprint.HawalRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C97 RID: 7319 RVA: 0x0039BD5C File Offset: 0x0039A15C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.HawalRowDeletedEvent != null)
				{
					Partyprint.HawalRowChangeEventHandler hawalRowDeletedEvent = this.HawalRowDeletedEvent;
					if (hawalRowDeletedEvent != null)
					{
						hawalRowDeletedEvent(this, new Partyprint.HawalRowChangeEvent((Partyprint.HawalRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C98 RID: 7320 RVA: 0x0039BDA0 File Offset: 0x0039A1A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.HawalRowDeletingEvent != null)
				{
					Partyprint.HawalRowChangeEventHandler hawalRowDeletingEvent = this.HawalRowDeletingEvent;
					if (hawalRowDeletingEvent != null)
					{
						hawalRowDeletingEvent(this, new Partyprint.HawalRowChangeEvent((Partyprint.HawalRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001C99 RID: 7321 RVA: 0x0039BDE4 File Offset: 0x0039A1E4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveHawalRow(Partyprint.HawalRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001C9A RID: 7322 RVA: 0x0039BDF4 File Offset: 0x0039A1F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "HawalDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C14 RID: 3092
			private DataColumn columnColumn1;

			// Token: 0x04000C15 RID: 3093
			private DataColumn columnColumn2;

			// Token: 0x04000C16 RID: 3094
			private DataColumn columnColumn3;

			// Token: 0x04000C17 RID: 3095
			private DataColumn columnColumn4;

			// Token: 0x04000C18 RID: 3096
			private DataColumn columnColumn5;

			// Token: 0x04000C19 RID: 3097
			private DataColumn columnColumn6;
		}

		// Token: 0x02000078 RID: 120
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CNDataTable : TypedTableBase<Partyprint.CNRow>
		{
			// Token: 0x06001C9B RID: 7323 RVA: 0x0039C00C File Offset: 0x0039A40C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CNDataTable()
			{
				this.TableName = "CN";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001C9C RID: 7324 RVA: 0x0039C034 File Offset: 0x0039A434
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal CNDataTable(DataTable table)
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

			// Token: 0x06001C9D RID: 7325 RVA: 0x0039C0E0 File Offset: 0x0039A4E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected CNDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x06001C9E RID: 7326 RVA: 0x0039C0F0 File Offset: 0x0039A4F0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0039C104 File Offset: 0x0039A504
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AmountColumn
			{
				get
				{
					return this.columnAmount;
				}
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0039C118 File Offset: 0x0039A518
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

			// Token: 0x17000AF6 RID: 2806
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.CNRow this[int index]
			{
				get
				{
					return (Partyprint.CNRow)this.Rows[index];
				}
			}

			// Token: 0x14000041 RID: 65
			// (add) Token: 0x06001CA2 RID: 7330 RVA: 0x0039C150 File Offset: 0x0039A550
			// (remove) Token: 0x06001CA3 RID: 7331 RVA: 0x0039C16C File Offset: 0x0039A56C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.CNRowChangeEventHandler CNRowChanging;

			// Token: 0x14000042 RID: 66
			// (add) Token: 0x06001CA4 RID: 7332 RVA: 0x0039C188 File Offset: 0x0039A588
			// (remove) Token: 0x06001CA5 RID: 7333 RVA: 0x0039C1A4 File Offset: 0x0039A5A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.CNRowChangeEventHandler CNRowChanged;

			// Token: 0x14000043 RID: 67
			// (add) Token: 0x06001CA6 RID: 7334 RVA: 0x0039C1C0 File Offset: 0x0039A5C0
			// (remove) Token: 0x06001CA7 RID: 7335 RVA: 0x0039C1DC File Offset: 0x0039A5DC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.CNRowChangeEventHandler CNRowDeleting;

			// Token: 0x14000044 RID: 68
			// (add) Token: 0x06001CA8 RID: 7336 RVA: 0x0039C1F8 File Offset: 0x0039A5F8
			// (remove) Token: 0x06001CA9 RID: 7337 RVA: 0x0039C214 File Offset: 0x0039A614
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.CNRowChangeEventHandler CNRowDeleted;

			// Token: 0x06001CAA RID: 7338 RVA: 0x0039C230 File Offset: 0x0039A630
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddCNRow(Partyprint.CNRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001CAB RID: 7339 RVA: 0x0039C240 File Offset: 0x0039A640
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.CNRow AddCNRow(string Name, string Amount)
			{
				Partyprint.CNRow cnrow = (Partyprint.CNRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Name,
					Amount
				};
				cnrow.ItemArray = itemArray;
				this.Rows.Add(cnrow);
				return cnrow;
			}

			// Token: 0x06001CAC RID: 7340 RVA: 0x0039C280 File Offset: 0x0039A680
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.CNDataTable cndataTable = (Partyprint.CNDataTable)base.Clone();
				cndataTable.InitVars();
				return cndataTable;
			}

			// Token: 0x06001CAD RID: 7341 RVA: 0x0039C2A0 File Offset: 0x0039A6A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.CNDataTable();
			}

			// Token: 0x06001CAE RID: 7342 RVA: 0x0039C2B4 File Offset: 0x0039A6B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnName = base.Columns["Name"];
				this.columnAmount = base.Columns["Amount"];
			}

			// Token: 0x06001CAF RID: 7343 RVA: 0x0039C2E4 File Offset: 0x0039A6E4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnAmount = new DataColumn("Amount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAmount);
			}

			// Token: 0x06001CB0 RID: 7344 RVA: 0x0039C34C File Offset: 0x0039A74C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.CNRow NewCNRow()
			{
				return (Partyprint.CNRow)this.NewRow();
			}

			// Token: 0x06001CB1 RID: 7345 RVA: 0x0039C364 File Offset: 0x0039A764
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.CNRow(builder);
			}

			// Token: 0x06001CB2 RID: 7346 RVA: 0x0039C378 File Offset: 0x0039A778
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.CNRow);
			}

			// Token: 0x06001CB3 RID: 7347 RVA: 0x0039C390 File Offset: 0x0039A790
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CNRowChangedEvent != null)
				{
					Partyprint.CNRowChangeEventHandler cnrowChangedEvent = this.CNRowChangedEvent;
					if (cnrowChangedEvent != null)
					{
						cnrowChangedEvent(this, new Partyprint.CNRowChangeEvent((Partyprint.CNRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CB4 RID: 7348 RVA: 0x0039C3D4 File Offset: 0x0039A7D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CNRowChangingEvent != null)
				{
					Partyprint.CNRowChangeEventHandler cnrowChangingEvent = this.CNRowChangingEvent;
					if (cnrowChangingEvent != null)
					{
						cnrowChangingEvent(this, new Partyprint.CNRowChangeEvent((Partyprint.CNRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CB5 RID: 7349 RVA: 0x0039C418 File Offset: 0x0039A818
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CNRowDeletedEvent != null)
				{
					Partyprint.CNRowChangeEventHandler cnrowDeletedEvent = this.CNRowDeletedEvent;
					if (cnrowDeletedEvent != null)
					{
						cnrowDeletedEvent(this, new Partyprint.CNRowChangeEvent((Partyprint.CNRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CB6 RID: 7350 RVA: 0x0039C45C File Offset: 0x0039A85C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CNRowDeletingEvent != null)
				{
					Partyprint.CNRowChangeEventHandler cnrowDeletingEvent = this.CNRowDeletingEvent;
					if (cnrowDeletingEvent != null)
					{
						cnrowDeletingEvent(this, new Partyprint.CNRowChangeEvent((Partyprint.CNRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CB7 RID: 7351 RVA: 0x0039C4A0 File Offset: 0x0039A8A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveCNRow(Partyprint.CNRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001CB8 RID: 7352 RVA: 0x0039C4B0 File Offset: 0x0039A8B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CNDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C1E RID: 3102
			private DataColumn columnName;

			// Token: 0x04000C1F RID: 3103
			private DataColumn columnAmount;
		}

		// Token: 0x02000079 RID: 121
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class PdataDataTable : TypedTableBase<Partyprint.PdataRow>
		{
			// Token: 0x06001CB9 RID: 7353 RVA: 0x0039C6C8 File Offset: 0x0039AAC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public PdataDataTable()
			{
				this.TableName = "Pdata";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001CBA RID: 7354 RVA: 0x0039C6F0 File Offset: 0x0039AAF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal PdataDataTable(DataTable table)
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

			// Token: 0x06001CBB RID: 7355 RVA: 0x0039C79C File Offset: 0x0039AB9C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected PdataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0039C7AC File Offset: 0x0039ABAC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Date1Column
			{
				get
				{
					return this.columnDate1;
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0039C7C0 File Offset: 0x0039ABC0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AmountColumn
			{
				get
				{
					return this.columnAmount;
				}
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0039C7D4 File Offset: 0x0039ABD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RemarkColumn
			{
				get
				{
					return this.columnRemark;
				}
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0039C7E8 File Offset: 0x0039ABE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn partyamountColumn
			{
				get
				{
					return this.columnpartyamount;
				}
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0039C7FC File Offset: 0x0039ABFC
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

			// Token: 0x17000AFC RID: 2812
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.PdataRow this[int index]
			{
				get
				{
					return (Partyprint.PdataRow)this.Rows[index];
				}
			}

			// Token: 0x14000045 RID: 69
			// (add) Token: 0x06001CC2 RID: 7362 RVA: 0x0039C834 File Offset: 0x0039AC34
			// (remove) Token: 0x06001CC3 RID: 7363 RVA: 0x0039C850 File Offset: 0x0039AC50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.PdataRowChangeEventHandler PdataRowChanging;

			// Token: 0x14000046 RID: 70
			// (add) Token: 0x06001CC4 RID: 7364 RVA: 0x0039C86C File Offset: 0x0039AC6C
			// (remove) Token: 0x06001CC5 RID: 7365 RVA: 0x0039C888 File Offset: 0x0039AC88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.PdataRowChangeEventHandler PdataRowChanged;

			// Token: 0x14000047 RID: 71
			// (add) Token: 0x06001CC6 RID: 7366 RVA: 0x0039C8A4 File Offset: 0x0039ACA4
			// (remove) Token: 0x06001CC7 RID: 7367 RVA: 0x0039C8C0 File Offset: 0x0039ACC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.PdataRowChangeEventHandler PdataRowDeleting;

			// Token: 0x14000048 RID: 72
			// (add) Token: 0x06001CC8 RID: 7368 RVA: 0x0039C8DC File Offset: 0x0039ACDC
			// (remove) Token: 0x06001CC9 RID: 7369 RVA: 0x0039C8F8 File Offset: 0x0039ACF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.PdataRowChangeEventHandler PdataRowDeleted;

			// Token: 0x06001CCA RID: 7370 RVA: 0x0039C914 File Offset: 0x0039AD14
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddPdataRow(Partyprint.PdataRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001CCB RID: 7371 RVA: 0x0039C924 File Offset: 0x0039AD24
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.PdataRow AddPdataRow(string Date1, string Amount, string Remark, string partyamount)
			{
				Partyprint.PdataRow pdataRow = (Partyprint.PdataRow)this.NewRow();
				object[] itemArray = new object[]
				{
					Date1,
					Amount,
					Remark,
					partyamount
				};
				pdataRow.ItemArray = itemArray;
				this.Rows.Add(pdataRow);
				return pdataRow;
			}

			// Token: 0x06001CCC RID: 7372 RVA: 0x0039C96C File Offset: 0x0039AD6C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Partyprint.PdataDataTable pdataDataTable = (Partyprint.PdataDataTable)base.Clone();
				pdataDataTable.InitVars();
				return pdataDataTable;
			}

			// Token: 0x06001CCD RID: 7373 RVA: 0x0039C98C File Offset: 0x0039AD8C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.PdataDataTable();
			}

			// Token: 0x06001CCE RID: 7374 RVA: 0x0039C9A0 File Offset: 0x0039ADA0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnDate1 = base.Columns["Date1"];
				this.columnAmount = base.Columns["Amount"];
				this.columnRemark = base.Columns["Remark"];
				this.columnpartyamount = base.Columns["partyamount"];
			}

			// Token: 0x06001CCF RID: 7375 RVA: 0x0039CA08 File Offset: 0x0039AE08
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnDate1 = new DataColumn("Date1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDate1);
				this.columnAmount = new DataColumn("Amount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAmount);
				this.columnRemark = new DataColumn("Remark", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRemark);
				this.columnpartyamount = new DataColumn("partyamount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpartyamount);
			}

			// Token: 0x06001CD0 RID: 7376 RVA: 0x0039CACC File Offset: 0x0039AECC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.PdataRow NewPdataRow()
			{
				return (Partyprint.PdataRow)this.NewRow();
			}

			// Token: 0x06001CD1 RID: 7377 RVA: 0x0039CAE4 File Offset: 0x0039AEE4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.PdataRow(builder);
			}

			// Token: 0x06001CD2 RID: 7378 RVA: 0x0039CAF8 File Offset: 0x0039AEF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.PdataRow);
			}

			// Token: 0x06001CD3 RID: 7379 RVA: 0x0039CB10 File Offset: 0x0039AF10
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.PdataRowChangedEvent != null)
				{
					Partyprint.PdataRowChangeEventHandler pdataRowChangedEvent = this.PdataRowChangedEvent;
					if (pdataRowChangedEvent != null)
					{
						pdataRowChangedEvent(this, new Partyprint.PdataRowChangeEvent((Partyprint.PdataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CD4 RID: 7380 RVA: 0x0039CB54 File Offset: 0x0039AF54
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.PdataRowChangingEvent != null)
				{
					Partyprint.PdataRowChangeEventHandler pdataRowChangingEvent = this.PdataRowChangingEvent;
					if (pdataRowChangingEvent != null)
					{
						pdataRowChangingEvent(this, new Partyprint.PdataRowChangeEvent((Partyprint.PdataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CD5 RID: 7381 RVA: 0x0039CB98 File Offset: 0x0039AF98
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.PdataRowDeletedEvent != null)
				{
					Partyprint.PdataRowChangeEventHandler pdataRowDeletedEvent = this.PdataRowDeletedEvent;
					if (pdataRowDeletedEvent != null)
					{
						pdataRowDeletedEvent(this, new Partyprint.PdataRowChangeEvent((Partyprint.PdataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CD6 RID: 7382 RVA: 0x0039CBDC File Offset: 0x0039AFDC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.PdataRowDeletingEvent != null)
				{
					Partyprint.PdataRowChangeEventHandler pdataRowDeletingEvent = this.PdataRowDeletingEvent;
					if (pdataRowDeletingEvent != null)
					{
						pdataRowDeletingEvent(this, new Partyprint.PdataRowChangeEvent((Partyprint.PdataRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CD7 RID: 7383 RVA: 0x0039CC20 File Offset: 0x0039B020
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovePdataRow(Partyprint.PdataRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001CD8 RID: 7384 RVA: 0x0039CC30 File Offset: 0x0039B030
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "PdataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C24 RID: 3108
			private DataColumn columnDate1;

			// Token: 0x04000C25 RID: 3109
			private DataColumn columnAmount;

			// Token: 0x04000C26 RID: 3110
			private DataColumn columnRemark;

			// Token: 0x04000C27 RID: 3111
			private DataColumn columnpartyamount;
		}

		// Token: 0x0200007A RID: 122
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class TrnDataTable : TypedTableBase<Partyprint.TrnRow>
		{
			// Token: 0x06001CD9 RID: 7385 RVA: 0x0039CE48 File Offset: 0x0039B248
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TrnDataTable()
			{
				this.TableName = "Trn";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001CDA RID: 7386 RVA: 0x0039CE70 File Offset: 0x0039B270
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal TrnDataTable(DataTable table)
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

			// Token: 0x06001CDB RID: 7387 RVA: 0x0039CF1C File Offset: 0x0039B31C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected TrnDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0039CF2C File Offset: 0x0039B32C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DColumn
			{
				get
				{
					return this.columnD;
				}
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0039CF40 File Offset: 0x0039B340
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn RColumn
			{
				get
				{
					return this.columnR;
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0039CF54 File Offset: 0x0039B354
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AColumn
			{
				get
				{
					return this.columnA;
				}
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0039CF68 File Offset: 0x0039B368
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CColumn
			{
				get
				{
					return this.columnC;
				}
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0039CF7C File Offset: 0x0039B37C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TColumn
			{
				get
				{
					return this.columnT;
				}
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0039CF90 File Offset: 0x0039B390
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

			// Token: 0x17000B03 RID: 2819
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.TrnRow this[int index]
			{
				get
				{
					return (Partyprint.TrnRow)this.Rows[index];
				}
			}

			// Token: 0x14000049 RID: 73
			// (add) Token: 0x06001CE3 RID: 7395 RVA: 0x0039CFC8 File Offset: 0x0039B3C8
			// (remove) Token: 0x06001CE4 RID: 7396 RVA: 0x0039CFE4 File Offset: 0x0039B3E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.TrnRowChangeEventHandler TrnRowChanging;

			// Token: 0x1400004A RID: 74
			// (add) Token: 0x06001CE5 RID: 7397 RVA: 0x0039D000 File Offset: 0x0039B400
			// (remove) Token: 0x06001CE6 RID: 7398 RVA: 0x0039D01C File Offset: 0x0039B41C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.TrnRowChangeEventHandler TrnRowChanged;

			// Token: 0x1400004B RID: 75
			// (add) Token: 0x06001CE7 RID: 7399 RVA: 0x0039D038 File Offset: 0x0039B438
			// (remove) Token: 0x06001CE8 RID: 7400 RVA: 0x0039D054 File Offset: 0x0039B454
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.TrnRowChangeEventHandler TrnRowDeleting;

			// Token: 0x1400004C RID: 76
			// (add) Token: 0x06001CE9 RID: 7401 RVA: 0x0039D070 File Offset: 0x0039B470
			// (remove) Token: 0x06001CEA RID: 7402 RVA: 0x0039D08C File Offset: 0x0039B48C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.TrnRowChangeEventHandler TrnRowDeleted;

			// Token: 0x06001CEB RID: 7403 RVA: 0x0039D0A8 File Offset: 0x0039B4A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTrnRow(Partyprint.TrnRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001CEC RID: 7404 RVA: 0x0039D0B8 File Offset: 0x0039B4B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.TrnRow AddTrnRow(string D, string R, string A, string C, string T)
			{
				Partyprint.TrnRow trnRow = (Partyprint.TrnRow)this.NewRow();
				object[] itemArray = new object[]
				{
					D,
					R,
					A,
					C,
					T
				};
				trnRow.ItemArray = itemArray;
				this.Rows.Add(trnRow);
				return trnRow;
			}

			// Token: 0x06001CED RID: 7405 RVA: 0x0039D104 File Offset: 0x0039B504
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Partyprint.TrnDataTable trnDataTable = (Partyprint.TrnDataTable)base.Clone();
				trnDataTable.InitVars();
				return trnDataTable;
			}

			// Token: 0x06001CEE RID: 7406 RVA: 0x0039D124 File Offset: 0x0039B524
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.TrnDataTable();
			}

			// Token: 0x06001CEF RID: 7407 RVA: 0x0039D138 File Offset: 0x0039B538
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnD = base.Columns["D"];
				this.columnR = base.Columns["R"];
				this.columnA = base.Columns["A"];
				this.columnC = base.Columns["C"];
				this.columnT = base.Columns["T"];
			}

			// Token: 0x06001CF0 RID: 7408 RVA: 0x0039D1B4 File Offset: 0x0039B5B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnD = new DataColumn("D", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnD);
				this.columnR = new DataColumn("R", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnR);
				this.columnA = new DataColumn("A", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnA);
				this.columnC = new DataColumn("C", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnC);
				this.columnT = new DataColumn("T", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnT);
			}

			// Token: 0x06001CF1 RID: 7409 RVA: 0x0039D2A4 File Offset: 0x0039B6A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.TrnRow NewTrnRow()
			{
				return (Partyprint.TrnRow)this.NewRow();
			}

			// Token: 0x06001CF2 RID: 7410 RVA: 0x0039D2BC File Offset: 0x0039B6BC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.TrnRow(builder);
			}

			// Token: 0x06001CF3 RID: 7411 RVA: 0x0039D2D0 File Offset: 0x0039B6D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.TrnRow);
			}

			// Token: 0x06001CF4 RID: 7412 RVA: 0x0039D2E8 File Offset: 0x0039B6E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TrnRowChangedEvent != null)
				{
					Partyprint.TrnRowChangeEventHandler trnRowChangedEvent = this.TrnRowChangedEvent;
					if (trnRowChangedEvent != null)
					{
						trnRowChangedEvent(this, new Partyprint.TrnRowChangeEvent((Partyprint.TrnRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CF5 RID: 7413 RVA: 0x0039D32C File Offset: 0x0039B72C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TrnRowChangingEvent != null)
				{
					Partyprint.TrnRowChangeEventHandler trnRowChangingEvent = this.TrnRowChangingEvent;
					if (trnRowChangingEvent != null)
					{
						trnRowChangingEvent(this, new Partyprint.TrnRowChangeEvent((Partyprint.TrnRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CF6 RID: 7414 RVA: 0x0039D370 File Offset: 0x0039B770
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TrnRowDeletedEvent != null)
				{
					Partyprint.TrnRowChangeEventHandler trnRowDeletedEvent = this.TrnRowDeletedEvent;
					if (trnRowDeletedEvent != null)
					{
						trnRowDeletedEvent(this, new Partyprint.TrnRowChangeEvent((Partyprint.TrnRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CF7 RID: 7415 RVA: 0x0039D3B4 File Offset: 0x0039B7B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TrnRowDeletingEvent != null)
				{
					Partyprint.TrnRowChangeEventHandler trnRowDeletingEvent = this.TrnRowDeletingEvent;
					if (trnRowDeletingEvent != null)
					{
						trnRowDeletingEvent(this, new Partyprint.TrnRowChangeEvent((Partyprint.TrnRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001CF8 RID: 7416 RVA: 0x0039D3F8 File Offset: 0x0039B7F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTrnRow(Partyprint.TrnRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001CF9 RID: 7417 RVA: 0x0039D408 File Offset: 0x0039B808
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "TrnDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C2C RID: 3116
			private DataColumn columnD;

			// Token: 0x04000C2D RID: 3117
			private DataColumn columnR;

			// Token: 0x04000C2E RID: 3118
			private DataColumn columnA;

			// Token: 0x04000C2F RID: 3119
			private DataColumn columnC;

			// Token: 0x04000C30 RID: 3120
			private DataColumn columnT;
		}

		// Token: 0x0200007B RID: 123
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class mbookDataTable : TypedTableBase<Partyprint.mbookRow>
		{
			// Token: 0x06001CFA RID: 7418 RVA: 0x0039D620 File Offset: 0x0039BA20
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public mbookDataTable()
			{
				this.TableName = "mbook";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001CFB RID: 7419 RVA: 0x0039D648 File Offset: 0x0039BA48
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal mbookDataTable(DataTable table)
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

			// Token: 0x06001CFC RID: 7420 RVA: 0x0039D6F4 File Offset: 0x0039BAF4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected mbookDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0039D704 File Offset: 0x0039BB04
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn pnameColumn
			{
				get
				{
					return this.columnpname;
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0039D718 File Offset: 0x0039BB18
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn t1Column
			{
				get
				{
					return this.columnt1;
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0039D72C File Offset: 0x0039BB2C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn t2Column
			{
				get
				{
					return this.columnt2;
				}
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0039D740 File Offset: 0x0039BB40
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn t3Column
			{
				get
				{
					return this.columnt3;
				}
			}

			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0039D754 File Offset: 0x0039BB54
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn t4Column
			{
				get
				{
					return this.columnt4;
				}
			}

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0039D768 File Offset: 0x0039BB68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn mnColumn
			{
				get
				{
					return this.columnmn;
				}
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0039D77C File Offset: 0x0039BB7C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn p1Column
			{
				get
				{
					return this.columnp1;
				}
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0039D790 File Offset: 0x0039BB90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn p2Column
			{
				get
				{
					return this.columnp2;
				}
			}

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0039D7A4 File Offset: 0x0039BBA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn p3Column
			{
				get
				{
					return this.columnp3;
				}
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0039D7B8 File Offset: 0x0039BBB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn p4Column
			{
				get
				{
					return this.columnp4;
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0039D7CC File Offset: 0x0039BBCC
			[Browsable(false)]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			// Token: 0x17000B0F RID: 2831
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.mbookRow this[int index]
			{
				get
				{
					return (Partyprint.mbookRow)this.Rows[index];
				}
			}

			// Token: 0x1400004D RID: 77
			// (add) Token: 0x06001D09 RID: 7433 RVA: 0x0039D804 File Offset: 0x0039BC04
			// (remove) Token: 0x06001D0A RID: 7434 RVA: 0x0039D820 File Offset: 0x0039BC20
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.mbookRowChangeEventHandler mbookRowChanging;

			// Token: 0x1400004E RID: 78
			// (add) Token: 0x06001D0B RID: 7435 RVA: 0x0039D83C File Offset: 0x0039BC3C
			// (remove) Token: 0x06001D0C RID: 7436 RVA: 0x0039D858 File Offset: 0x0039BC58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.mbookRowChangeEventHandler mbookRowChanged;

			// Token: 0x1400004F RID: 79
			// (add) Token: 0x06001D0D RID: 7437 RVA: 0x0039D874 File Offset: 0x0039BC74
			// (remove) Token: 0x06001D0E RID: 7438 RVA: 0x0039D890 File Offset: 0x0039BC90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.mbookRowChangeEventHandler mbookRowDeleting;

			// Token: 0x14000050 RID: 80
			// (add) Token: 0x06001D0F RID: 7439 RVA: 0x0039D8AC File Offset: 0x0039BCAC
			// (remove) Token: 0x06001D10 RID: 7440 RVA: 0x0039D8C8 File Offset: 0x0039BCC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.mbookRowChangeEventHandler mbookRowDeleted;

			// Token: 0x06001D11 RID: 7441 RVA: 0x0039D8E4 File Offset: 0x0039BCE4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddmbookRow(Partyprint.mbookRow row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001D12 RID: 7442 RVA: 0x0039D8F4 File Offset: 0x0039BCF4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.mbookRow AddmbookRow(string pname, string t1, string t2, string t3, string t4, string mn, string p1, string p2, string p3, string p4)
			{
				Partyprint.mbookRow mbookRow = (Partyprint.mbookRow)this.NewRow();
				object[] itemArray = new object[]
				{
					pname,
					t1,
					t2,
					t3,
					t4,
					mn,
					p1,
					p2,
					p3,
					p4
				};
				mbookRow.ItemArray = itemArray;
				this.Rows.Add(mbookRow);
				return mbookRow;
			}

			// Token: 0x06001D13 RID: 7443 RVA: 0x0039D95C File Offset: 0x0039BD5C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.mbookDataTable mbookDataTable = (Partyprint.mbookDataTable)base.Clone();
				mbookDataTable.InitVars();
				return mbookDataTable;
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x0039D97C File Offset: 0x0039BD7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.mbookDataTable();
			}

			// Token: 0x06001D15 RID: 7445 RVA: 0x0039D990 File Offset: 0x0039BD90
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnpname = base.Columns["pname"];
				this.columnt1 = base.Columns["t1"];
				this.columnt2 = base.Columns["t2"];
				this.columnt3 = base.Columns["t3"];
				this.columnt4 = base.Columns["t4"];
				this.columnmn = base.Columns["mn"];
				this.columnp1 = base.Columns["p1"];
				this.columnp2 = base.Columns["p2"];
				this.columnp3 = base.Columns["p3"];
				this.columnp4 = base.Columns["p4"];
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x0039DA7C File Offset: 0x0039BE7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnpname = new DataColumn("pname", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpname);
				this.columnt1 = new DataColumn("t1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnt1);
				this.columnt2 = new DataColumn("t2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnt2);
				this.columnt3 = new DataColumn("t3", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnt3);
				this.columnt4 = new DataColumn("t4", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnt4);
				this.columnmn = new DataColumn("mn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnmn);
				this.columnp1 = new DataColumn("p1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnp1);
				this.columnp2 = new DataColumn("p2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnp2);
				this.columnp3 = new DataColumn("p3", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnp3);
				this.columnp4 = new DataColumn("p4", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnp4);
			}

			// Token: 0x06001D17 RID: 7447 RVA: 0x0039DC4C File Offset: 0x0039C04C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.mbookRow NewmbookRow()
			{
				return (Partyprint.mbookRow)this.NewRow();
			}

			// Token: 0x06001D18 RID: 7448 RVA: 0x0039DC64 File Offset: 0x0039C064
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.mbookRow(builder);
			}

			// Token: 0x06001D19 RID: 7449 RVA: 0x0039DC78 File Offset: 0x0039C078
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.mbookRow);
			}

			// Token: 0x06001D1A RID: 7450 RVA: 0x0039DC90 File Offset: 0x0039C090
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.mbookRowChangedEvent != null)
				{
					Partyprint.mbookRowChangeEventHandler mbookRowChangeEventHandler = this.mbookRowChangedEvent;
					if (mbookRowChangeEventHandler != null)
					{
						mbookRowChangeEventHandler(this, new Partyprint.mbookRowChangeEvent((Partyprint.mbookRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D1B RID: 7451 RVA: 0x0039DCD4 File Offset: 0x0039C0D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.mbookRowChangingEvent != null)
				{
					Partyprint.mbookRowChangeEventHandler mbookRowChangeEventHandler = this.mbookRowChangingEvent;
					if (mbookRowChangeEventHandler != null)
					{
						mbookRowChangeEventHandler(this, new Partyprint.mbookRowChangeEvent((Partyprint.mbookRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D1C RID: 7452 RVA: 0x0039DD18 File Offset: 0x0039C118
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.mbookRowDeletedEvent != null)
				{
					Partyprint.mbookRowChangeEventHandler mbookRowChangeEventHandler = this.mbookRowDeletedEvent;
					if (mbookRowChangeEventHandler != null)
					{
						mbookRowChangeEventHandler(this, new Partyprint.mbookRowChangeEvent((Partyprint.mbookRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D1D RID: 7453 RVA: 0x0039DD5C File Offset: 0x0039C15C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.mbookRowDeletingEvent != null)
				{
					Partyprint.mbookRowChangeEventHandler mbookRowChangeEventHandler = this.mbookRowDeletingEvent;
					if (mbookRowChangeEventHandler != null)
					{
						mbookRowChangeEventHandler(this, new Partyprint.mbookRowChangeEvent((Partyprint.mbookRow)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D1E RID: 7454 RVA: 0x0039DDA0 File Offset: 0x0039C1A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovembookRow(Partyprint.mbookRow row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001D1F RID: 7455 RVA: 0x0039DDB0 File Offset: 0x0039C1B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "mbookDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C35 RID: 3125
			private DataColumn columnpname;

			// Token: 0x04000C36 RID: 3126
			private DataColumn columnt1;

			// Token: 0x04000C37 RID: 3127
			private DataColumn columnt2;

			// Token: 0x04000C38 RID: 3128
			private DataColumn columnt3;

			// Token: 0x04000C39 RID: 3129
			private DataColumn columnt4;

			// Token: 0x04000C3A RID: 3130
			private DataColumn columnmn;

			// Token: 0x04000C3B RID: 3131
			private DataColumn columnp1;

			// Token: 0x04000C3C RID: 3132
			private DataColumn columnp2;

			// Token: 0x04000C3D RID: 3133
			private DataColumn columnp3;

			// Token: 0x04000C3E RID: 3134
			private DataColumn columnp4;
		}

		// Token: 0x0200007C RID: 124
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class Conect_1DataTable : TypedTableBase<Partyprint.Conect_1Row>
		{
			// Token: 0x06001D20 RID: 7456 RVA: 0x0039DFC8 File Offset: 0x0039C3C8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Conect_1DataTable()
			{
				this.TableName = "Conect_1";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001D21 RID: 7457 RVA: 0x0039DFF0 File Offset: 0x0039C3F0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Conect_1DataTable(DataTable table)
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

			// Token: 0x06001D22 RID: 7458 RVA: 0x0039E09C File Offset: 0x0039C49C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected Conect_1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0039E0AC File Offset: 0x0039C4AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0039E0C0 File Offset: 0x0039C4C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0039E0D4 File Offset: 0x0039C4D4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column3Column
			{
				get
				{
					return this.columnColumn3;
				}
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0039E0E8 File Offset: 0x0039C4E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column4Column
			{
				get
				{
					return this.columnColumn4;
				}
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0039E0FC File Offset: 0x0039C4FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn JamaColumn
			{
				get
				{
					return this.columnJama;
				}
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0039E110 File Offset: 0x0039C510
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

			// Token: 0x17000B16 RID: 2838
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.Conect_1Row this[int index]
			{
				get
				{
					return (Partyprint.Conect_1Row)this.Rows[index];
				}
			}

			// Token: 0x14000051 RID: 81
			// (add) Token: 0x06001D2A RID: 7466 RVA: 0x0039E148 File Offset: 0x0039C548
			// (remove) Token: 0x06001D2B RID: 7467 RVA: 0x0039E164 File Offset: 0x0039C564
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_1RowChangeEventHandler Conect_1RowChanging;

			// Token: 0x14000052 RID: 82
			// (add) Token: 0x06001D2C RID: 7468 RVA: 0x0039E180 File Offset: 0x0039C580
			// (remove) Token: 0x06001D2D RID: 7469 RVA: 0x0039E19C File Offset: 0x0039C59C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_1RowChangeEventHandler Conect_1RowChanged;

			// Token: 0x14000053 RID: 83
			// (add) Token: 0x06001D2E RID: 7470 RVA: 0x0039E1B8 File Offset: 0x0039C5B8
			// (remove) Token: 0x06001D2F RID: 7471 RVA: 0x0039E1D4 File Offset: 0x0039C5D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_1RowChangeEventHandler Conect_1RowDeleting;

			// Token: 0x14000054 RID: 84
			// (add) Token: 0x06001D30 RID: 7472 RVA: 0x0039E1F0 File Offset: 0x0039C5F0
			// (remove) Token: 0x06001D31 RID: 7473 RVA: 0x0039E20C File Offset: 0x0039C60C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_1RowChangeEventHandler Conect_1RowDeleted;

			// Token: 0x06001D32 RID: 7474 RVA: 0x0039E228 File Offset: 0x0039C628
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddConect_1Row(Partyprint.Conect_1Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001D33 RID: 7475 RVA: 0x0039E238 File Offset: 0x0039C638
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.Conect_1Row AddConect_1Row(string Column1, string Column2, string Column3, string Column4, string Jama)
			{
				Partyprint.Conect_1Row conect_1Row = (Partyprint.Conect_1Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2,
					Column3,
					Column4,
					Jama
				};
				conect_1Row.ItemArray = itemArray;
				this.Rows.Add(conect_1Row);
				return conect_1Row;
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x0039E284 File Offset: 0x0039C684
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.Conect_1DataTable conect_1DataTable = (Partyprint.Conect_1DataTable)base.Clone();
				conect_1DataTable.InitVars();
				return conect_1DataTable;
			}

			// Token: 0x06001D35 RID: 7477 RVA: 0x0039E2A4 File Offset: 0x0039C6A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.Conect_1DataTable();
			}

			// Token: 0x06001D36 RID: 7478 RVA: 0x0039E2B8 File Offset: 0x0039C6B8
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

			// Token: 0x06001D37 RID: 7479 RVA: 0x0039E334 File Offset: 0x0039C734
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

			// Token: 0x06001D38 RID: 7480 RVA: 0x0039E424 File Offset: 0x0039C824
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.Conect_1Row NewConect_1Row()
			{
				return (Partyprint.Conect_1Row)this.NewRow();
			}

			// Token: 0x06001D39 RID: 7481 RVA: 0x0039E43C File Offset: 0x0039C83C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.Conect_1Row(builder);
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x0039E450 File Offset: 0x0039C850
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.Conect_1Row);
			}

			// Token: 0x06001D3B RID: 7483 RVA: 0x0039E468 File Offset: 0x0039C868
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.Conect_1RowChangedEvent != null)
				{
					Partyprint.Conect_1RowChangeEventHandler conect_1RowChangedEvent = this.Conect_1RowChangedEvent;
					if (conect_1RowChangedEvent != null)
					{
						conect_1RowChangedEvent(this, new Partyprint.Conect_1RowChangeEvent((Partyprint.Conect_1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D3C RID: 7484 RVA: 0x0039E4AC File Offset: 0x0039C8AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.Conect_1RowChangingEvent != null)
				{
					Partyprint.Conect_1RowChangeEventHandler conect_1RowChangingEvent = this.Conect_1RowChangingEvent;
					if (conect_1RowChangingEvent != null)
					{
						conect_1RowChangingEvent(this, new Partyprint.Conect_1RowChangeEvent((Partyprint.Conect_1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D3D RID: 7485 RVA: 0x0039E4F0 File Offset: 0x0039C8F0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.Conect_1RowDeletedEvent != null)
				{
					Partyprint.Conect_1RowChangeEventHandler conect_1RowDeletedEvent = this.Conect_1RowDeletedEvent;
					if (conect_1RowDeletedEvent != null)
					{
						conect_1RowDeletedEvent(this, new Partyprint.Conect_1RowChangeEvent((Partyprint.Conect_1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D3E RID: 7486 RVA: 0x0039E534 File Offset: 0x0039C934
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.Conect_1RowDeletingEvent != null)
				{
					Partyprint.Conect_1RowChangeEventHandler conect_1RowDeletingEvent = this.Conect_1RowDeletingEvent;
					if (conect_1RowDeletingEvent != null)
					{
						conect_1RowDeletingEvent(this, new Partyprint.Conect_1RowChangeEvent((Partyprint.Conect_1Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D3F RID: 7487 RVA: 0x0039E578 File Offset: 0x0039C978
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveConect_1Row(Partyprint.Conect_1Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001D40 RID: 7488 RVA: 0x0039E588 File Offset: 0x0039C988
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "Conect_1DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C43 RID: 3139
			private DataColumn columnColumn1;

			// Token: 0x04000C44 RID: 3140
			private DataColumn columnColumn2;

			// Token: 0x04000C45 RID: 3141
			private DataColumn columnColumn3;

			// Token: 0x04000C46 RID: 3142
			private DataColumn columnColumn4;

			// Token: 0x04000C47 RID: 3143
			private DataColumn columnJama;
		}

		// Token: 0x0200007D RID: 125
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class Conect_2DataTable : TypedTableBase<Partyprint.Conect_2Row>
		{
			// Token: 0x06001D41 RID: 7489 RVA: 0x0039E7A0 File Offset: 0x0039CBA0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Conect_2DataTable()
			{
				this.TableName = "Conect_2";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06001D42 RID: 7490 RVA: 0x0039E7C8 File Offset: 0x0039CBC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Conect_2DataTable(DataTable table)
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

			// Token: 0x06001D43 RID: 7491 RVA: 0x0039E874 File Offset: 0x0039CC74
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected Conect_2DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0039E884 File Offset: 0x0039CC84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column1Column
			{
				get
				{
					return this.columnColumn1;
				}
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x06001D45 RID: 7493 RVA: 0x0039E898 File Offset: 0x0039CC98
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Column2Column
			{
				get
				{
					return this.columnColumn2;
				}
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x06001D46 RID: 7494 RVA: 0x0039E8AC File Offset: 0x0039CCAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column3Column
			{
				get
				{
					return this.columnColumn3;
				}
			}

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0039E8C0 File Offset: 0x0039CCC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Column4Column
			{
				get
				{
					return this.columnColumn4;
				}
			}

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x06001D48 RID: 7496 RVA: 0x0039E8D4 File Offset: 0x0039CCD4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NevaColumn
			{
				get
				{
					return this.columnNeva;
				}
			}

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x06001D49 RID: 7497 RVA: 0x0039E8E8 File Offset: 0x0039CCE8
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

			// Token: 0x17000B1D RID: 2845
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.Conect_2Row this[int index]
			{
				get
				{
					return (Partyprint.Conect_2Row)this.Rows[index];
				}
			}

			// Token: 0x14000055 RID: 85
			// (add) Token: 0x06001D4B RID: 7499 RVA: 0x0039E920 File Offset: 0x0039CD20
			// (remove) Token: 0x06001D4C RID: 7500 RVA: 0x0039E93C File Offset: 0x0039CD3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_2RowChangeEventHandler Conect_2RowChanging;

			// Token: 0x14000056 RID: 86
			// (add) Token: 0x06001D4D RID: 7501 RVA: 0x0039E958 File Offset: 0x0039CD58
			// (remove) Token: 0x06001D4E RID: 7502 RVA: 0x0039E974 File Offset: 0x0039CD74
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_2RowChangeEventHandler Conect_2RowChanged;

			// Token: 0x14000057 RID: 87
			// (add) Token: 0x06001D4F RID: 7503 RVA: 0x0039E990 File Offset: 0x0039CD90
			// (remove) Token: 0x06001D50 RID: 7504 RVA: 0x0039E9AC File Offset: 0x0039CDAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_2RowChangeEventHandler Conect_2RowDeleting;

			// Token: 0x14000058 RID: 88
			// (add) Token: 0x06001D51 RID: 7505 RVA: 0x0039E9C8 File Offset: 0x0039CDC8
			// (remove) Token: 0x06001D52 RID: 7506 RVA: 0x0039E9E4 File Offset: 0x0039CDE4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Partyprint.Conect_2RowChangeEventHandler Conect_2RowDeleted;

			// Token: 0x06001D53 RID: 7507 RVA: 0x0039EA00 File Offset: 0x0039CE00
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddConect_2Row(Partyprint.Conect_2Row row)
			{
				this.Rows.Add(row);
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0039EA10 File Offset: 0x0039CE10
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.Conect_2Row AddConect_2Row(string Column1, string Column2, string Column3, string Column4, string Neva)
			{
				Partyprint.Conect_2Row conect_2Row = (Partyprint.Conect_2Row)this.NewRow();
				object[] itemArray = new object[]
				{
					Column1,
					Column2,
					Column3,
					Column4,
					Neva
				};
				conect_2Row.ItemArray = itemArray;
				this.Rows.Add(conect_2Row);
				return conect_2Row;
			}

			// Token: 0x06001D55 RID: 7509 RVA: 0x0039EA5C File Offset: 0x0039CE5C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Partyprint.Conect_2DataTable conect_2DataTable = (Partyprint.Conect_2DataTable)base.Clone();
				conect_2DataTable.InitVars();
				return conect_2DataTable;
			}

			// Token: 0x06001D56 RID: 7510 RVA: 0x0039EA7C File Offset: 0x0039CE7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Partyprint.Conect_2DataTable();
			}

			// Token: 0x06001D57 RID: 7511 RVA: 0x0039EA90 File Offset: 0x0039CE90
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnColumn1 = base.Columns["Column1"];
				this.columnColumn2 = base.Columns["Column2"];
				this.columnColumn3 = base.Columns["Column3"];
				this.columnColumn4 = base.Columns["Column4"];
				this.columnNeva = base.Columns["Neva"];
			}

			// Token: 0x06001D58 RID: 7512 RVA: 0x0039EB0C File Offset: 0x0039CF0C
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

			// Token: 0x06001D59 RID: 7513 RVA: 0x0039EBFC File Offset: 0x0039CFFC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.Conect_2Row NewConect_2Row()
			{
				return (Partyprint.Conect_2Row)this.NewRow();
			}

			// Token: 0x06001D5A RID: 7514 RVA: 0x0039EC14 File Offset: 0x0039D014
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Partyprint.Conect_2Row(builder);
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x0039EC28 File Offset: 0x0039D028
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Partyprint.Conect_2Row);
			}

			// Token: 0x06001D5C RID: 7516 RVA: 0x0039EC40 File Offset: 0x0039D040
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.Conect_2RowChangedEvent != null)
				{
					Partyprint.Conect_2RowChangeEventHandler conect_2RowChangedEvent = this.Conect_2RowChangedEvent;
					if (conect_2RowChangedEvent != null)
					{
						conect_2RowChangedEvent(this, new Partyprint.Conect_2RowChangeEvent((Partyprint.Conect_2Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D5D RID: 7517 RVA: 0x0039EC84 File Offset: 0x0039D084
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.Conect_2RowChangingEvent != null)
				{
					Partyprint.Conect_2RowChangeEventHandler conect_2RowChangingEvent = this.Conect_2RowChangingEvent;
					if (conect_2RowChangingEvent != null)
					{
						conect_2RowChangingEvent(this, new Partyprint.Conect_2RowChangeEvent((Partyprint.Conect_2Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D5E RID: 7518 RVA: 0x0039ECC8 File Offset: 0x0039D0C8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.Conect_2RowDeletedEvent != null)
				{
					Partyprint.Conect_2RowChangeEventHandler conect_2RowDeletedEvent = this.Conect_2RowDeletedEvent;
					if (conect_2RowDeletedEvent != null)
					{
						conect_2RowDeletedEvent(this, new Partyprint.Conect_2RowChangeEvent((Partyprint.Conect_2Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D5F RID: 7519 RVA: 0x0039ED0C File Offset: 0x0039D10C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.Conect_2RowDeletingEvent != null)
				{
					Partyprint.Conect_2RowChangeEventHandler conect_2RowDeletingEvent = this.Conect_2RowDeletingEvent;
					if (conect_2RowDeletingEvent != null)
					{
						conect_2RowDeletingEvent(this, new Partyprint.Conect_2RowChangeEvent((Partyprint.Conect_2Row)e.Row, e.Action));
					}
				}
			}

			// Token: 0x06001D60 RID: 7520 RVA: 0x0039ED50 File Offset: 0x0039D150
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveConect_2Row(Partyprint.Conect_2Row row)
			{
				this.Rows.Remove(row);
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x0039ED60 File Offset: 0x0039D160
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Partyprint partyprint = new Partyprint();
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
				xmlSchemaAttribute.FixedValue = partyprint.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "Conect_2DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = partyprint.GetSchemaSerializable();
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

			// Token: 0x04000C4C RID: 3148
			private DataColumn columnColumn1;

			// Token: 0x04000C4D RID: 3149
			private DataColumn columnColumn2;

			// Token: 0x04000C4E RID: 3150
			private DataColumn columnColumn3;

			// Token: 0x04000C4F RID: 3151
			private DataColumn columnColumn4;

			// Token: 0x04000C50 RID: 3152
			private DataColumn columnNeva;
		}

		// Token: 0x0200007E RID: 126
		public class DataTable1Row : DataRow
		{
			// Token: 0x06001D62 RID: 7522 RVA: 0x0039EF78 File Offset: 0x0039D378
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTable1Row(DataRowBuilder rb) : base(rb)
			{
				this.tableDataTable1 = (Partyprint.DataTable1DataTable)this.Table;
			}

			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0039EF94 File Offset: 0x0039D394
			// (set) Token: 0x06001D64 RID: 7524 RVA: 0x0039EFE0 File Offset: 0x0039D3E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Party_name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.Party_nameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Party_name' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.Party_nameColumn] = value;
				}
			}

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0039EFF4 File Offset: 0x0039D3F4
			// (set) Token: 0x06001D66 RID: 7526 RVA: 0x0039F040 File Offset: 0x0039D440
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Dhara
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.DharaColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dhara' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.DharaColumn] = value;
				}
			}

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0039F054 File Offset: 0x0039D454
			// (set) Token: 0x06001D68 RID: 7528 RVA: 0x0039F0A0 File Offset: 0x0039D4A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Status
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.StatusColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Status' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.StatusColumn] = value;
				}
			}

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x06001D69 RID: 7529 RVA: 0x0039F0B4 File Offset: 0x0039D4B4
			// (set) Token: 0x06001D6A RID: 7530 RVA: 0x0039F100 File Offset: 0x0039D500
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Balance_Limit
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableDataTable1.Balance_LimitColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Balance_Limit' in table 'DataTable1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableDataTable1.Balance_LimitColumn] = value;
				}
			}

			// Token: 0x06001D6B RID: 7531 RVA: 0x0039F114 File Offset: 0x0039D514
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsParty_nameNull()
			{
				return this.IsNull(this.tableDataTable1.Party_nameColumn);
			}

			// Token: 0x06001D6C RID: 7532 RVA: 0x0039F134 File Offset: 0x0039D534
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetParty_nameNull()
			{
				this[this.tableDataTable1.Party_nameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D6D RID: 7533 RVA: 0x0039F154 File Offset: 0x0039D554
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDharaNull()
			{
				return this.IsNull(this.tableDataTable1.DharaColumn);
			}

			// Token: 0x06001D6E RID: 7534 RVA: 0x0039F174 File Offset: 0x0039D574
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDharaNull()
			{
				this[this.tableDataTable1.DharaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D6F RID: 7535 RVA: 0x0039F194 File Offset: 0x0039D594
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsStatusNull()
			{
				return this.IsNull(this.tableDataTable1.StatusColumn);
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x0039F1B4 File Offset: 0x0039D5B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetStatusNull()
			{
				this[this.tableDataTable1.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D71 RID: 7537 RVA: 0x0039F1D4 File Offset: 0x0039D5D4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsBalance_LimitNull()
			{
				return this.IsNull(this.tableDataTable1.Balance_LimitColumn);
			}

			// Token: 0x06001D72 RID: 7538 RVA: 0x0039F1F4 File Offset: 0x0039D5F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetBalance_LimitNull()
			{
				this[this.tableDataTable1.Balance_LimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C55 RID: 3157
			private Partyprint.DataTable1DataTable tableDataTable1;
		}

		// Token: 0x0200007F RID: 127
		public class MatchReportRow : DataRow
		{
			// Token: 0x06001D73 RID: 7539 RVA: 0x0039F214 File Offset: 0x0039D614
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal MatchReportRow(DataRowBuilder rb) : base(rb)
			{
				this.tableMatchReport = (Partyprint.MatchReportDataTable)this.Table;
			}

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0039F230 File Offset: 0x0039D630
			// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0039F254 File Offset: 0x0039D654
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string m_eid
			{
				get
				{
					return Conversions.ToString(this[this.tableMatchReport.m_eidColumn]);
				}
				set
				{
					this[this.tableMatchReport.m_eidColumn] = value;
				}
			}

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0039F268 File Offset: 0x0039D668
			// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0039F2B4 File Offset: 0x0039D6B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string m_amt
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.m_amtColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'm_amt' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.m_amtColumn] = value;
				}
			}

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0039F2C8 File Offset: 0x0039D6C8
			// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0039F314 File Offset: 0x0039D714
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string m_rate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.m_rateColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'm_rate' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.m_rateColumn] = value;
				}
			}

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0039F328 File Offset: 0x0039D728
			// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0039F374 File Offset: 0x0039D774
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string m_team
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.m_teamColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'm_team' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.m_teamColumn] = value;
				}
			}

			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x06001D7C RID: 7548 RVA: 0x0039F388 File Offset: 0x0039D788
			// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0039F3D4 File Offset: 0x0039D7D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string m_mode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.m_modeColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'm_mode' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.m_modeColumn] = value;
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0039F3E8 File Offset: 0x0039D7E8
			// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0039F434 File Offset: 0x0039D834
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string m_party
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.m_partyColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'm_party' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.m_partyColumn] = value;
				}
			}

			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0039F448 File Offset: 0x0039D848
			// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0039F494 File Offset: 0x0039D894
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Sr_No
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.Sr_NoColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Sr_No' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.Sr_NoColumn] = value;
				}
			}

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0039F4A8 File Offset: 0x0039D8A8
			// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0039F4F4 File Offset: 0x0039D8F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Date1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.Date1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Date1' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.Date1Column] = value;
				}
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0039F508 File Offset: 0x0039D908
			// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0039F554 File Offset: 0x0039D954
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Team1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.Team1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Team1' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.Team1Column] = value;
				}
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0039F568 File Offset: 0x0039D968
			// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0039F5B4 File Offset: 0x0039D9B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.NameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.NameColumn] = value;
				}
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0039F5C8 File Offset: 0x0039D9C8
			// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0039F614 File Offset: 0x0039DA14
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Type
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableMatchReport.TypeColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Type' in table 'MatchReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableMatchReport.TypeColumn] = value;
				}
			}

			// Token: 0x06001D8A RID: 7562 RVA: 0x0039F628 File Offset: 0x0039DA28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ism_amtNull()
			{
				return this.IsNull(this.tableMatchReport.m_amtColumn);
			}

			// Token: 0x06001D8B RID: 7563 RVA: 0x0039F648 File Offset: 0x0039DA48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setm_amtNull()
			{
				this[this.tableMatchReport.m_amtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D8C RID: 7564 RVA: 0x0039F668 File Offset: 0x0039DA68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ism_rateNull()
			{
				return this.IsNull(this.tableMatchReport.m_rateColumn);
			}

			// Token: 0x06001D8D RID: 7565 RVA: 0x0039F688 File Offset: 0x0039DA88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Setm_rateNull()
			{
				this[this.tableMatchReport.m_rateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D8E RID: 7566 RVA: 0x0039F6A8 File Offset: 0x0039DAA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Ism_teamNull()
			{
				return this.IsNull(this.tableMatchReport.m_teamColumn);
			}

			// Token: 0x06001D8F RID: 7567 RVA: 0x0039F6C8 File Offset: 0x0039DAC8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setm_teamNull()
			{
				this[this.tableMatchReport.m_teamColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D90 RID: 7568 RVA: 0x0039F6E8 File Offset: 0x0039DAE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Ism_modeNull()
			{
				return this.IsNull(this.tableMatchReport.m_modeColumn);
			}

			// Token: 0x06001D91 RID: 7569 RVA: 0x0039F708 File Offset: 0x0039DB08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Setm_modeNull()
			{
				this[this.tableMatchReport.m_modeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D92 RID: 7570 RVA: 0x0039F728 File Offset: 0x0039DB28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ism_partyNull()
			{
				return this.IsNull(this.tableMatchReport.m_partyColumn);
			}

			// Token: 0x06001D93 RID: 7571 RVA: 0x0039F748 File Offset: 0x0039DB48
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Setm_partyNull()
			{
				this[this.tableMatchReport.m_partyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D94 RID: 7572 RVA: 0x0039F768 File Offset: 0x0039DB68
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSr_NoNull()
			{
				return this.IsNull(this.tableMatchReport.Sr_NoColumn);
			}

			// Token: 0x06001D95 RID: 7573 RVA: 0x0039F788 File Offset: 0x0039DB88
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSr_NoNull()
			{
				this[this.tableMatchReport.Sr_NoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D96 RID: 7574 RVA: 0x0039F7A8 File Offset: 0x0039DBA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsDate1Null()
			{
				return this.IsNull(this.tableMatchReport.Date1Column);
			}

			// Token: 0x06001D97 RID: 7575 RVA: 0x0039F7C8 File Offset: 0x0039DBC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetDate1Null()
			{
				this[this.tableMatchReport.Date1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D98 RID: 7576 RVA: 0x0039F7E8 File Offset: 0x0039DBE8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTeam1Null()
			{
				return this.IsNull(this.tableMatchReport.Team1Column);
			}

			// Token: 0x06001D99 RID: 7577 RVA: 0x0039F808 File Offset: 0x0039DC08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTeam1Null()
			{
				this[this.tableMatchReport.Team1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D9A RID: 7578 RVA: 0x0039F828 File Offset: 0x0039DC28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableMatchReport.NameColumn);
			}

			// Token: 0x06001D9B RID: 7579 RVA: 0x0039F848 File Offset: 0x0039DC48
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableMatchReport.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001D9C RID: 7580 RVA: 0x0039F868 File Offset: 0x0039DC68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTypeNull()
			{
				return this.IsNull(this.tableMatchReport.TypeColumn);
			}

			// Token: 0x06001D9D RID: 7581 RVA: 0x0039F888 File Offset: 0x0039DC88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTypeNull()
			{
				this[this.tableMatchReport.TypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C56 RID: 3158
			private Partyprint.MatchReportDataTable tableMatchReport;
		}

		// Token: 0x02000080 RID: 128
		public class SessionReportRow : DataRow
		{
			// Token: 0x06001D9E RID: 7582 RVA: 0x0039F8A8 File Offset: 0x0039DCA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SessionReportRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSessionReport = (Partyprint.SessionReportDataTable)this.Table;
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0039F8C4 File Offset: 0x0039DCC4
			// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0039F910 File Offset: 0x0039DD10
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Team1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.Team1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Team1' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.Team1Column] = value;
				}
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x0039F924 File Offset: 0x0039DD24
			// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0039F970 File Offset: 0x0039DD70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.NameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.NameColumn] = value;
				}
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x0039F984 File Offset: 0x0039DD84
			// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x0039F9D0 File Offset: 0x0039DDD0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Sr_No
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.Sr_NoColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Sr_No' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.Sr_NoColumn] = value;
				}
			}

			// Token: 0x17000B30 RID: 2864
			// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x0039F9E4 File Offset: 0x0039DDE4
			// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0039FA30 File Offset: 0x0039DE30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Dt
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.DtColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Dt' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.DtColumn] = value;
				}
			}

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0039FA44 File Offset: 0x0039DE44
			// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0039FA90 File Offset: 0x0039DE90
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string N_name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.N_nameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'N_name' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.N_nameColumn] = value;
				}
			}

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0039FAA4 File Offset: 0x0039DEA4
			// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0039FAF0 File Offset: 0x0039DEF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Type
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.TypeColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Type' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.TypeColumn] = value;
				}
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0039FB04 File Offset: 0x0039DF04
			// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0039FB50 File Offset: 0x0039DF50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string id
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.idColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.idColumn] = value;
				}
			}

			// Token: 0x17000B34 RID: 2868
			// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0039FB64 File Offset: 0x0039DF64
			// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0039FBB0 File Offset: 0x0039DFB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string s_rate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.s_rateColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 's_rate' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.s_rateColumn] = value;
				}
			}

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0039FBC4 File Offset: 0x0039DFC4
			// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0039FC10 File Offset: 0x0039E010
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string s_amt
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.s_amtColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 's_amt' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.s_amtColumn] = value;
				}
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0039FC24 File Offset: 0x0039E024
			// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0039FC70 File Offset: 0x0039E070
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string S_RUN
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.S_RUNColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'S_RUN' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.S_RUNColumn] = value;
				}
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0039FC84 File Offset: 0x0039E084
			// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x0039FCD0 File Offset: 0x0039E0D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string s_bild
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.s_bildColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 's_bild' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.s_bildColumn] = value;
				}
			}

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0039FCE4 File Offset: 0x0039E0E4
			// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x0039FD30 File Offset: 0x0039E130
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string s_mod
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.s_modColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 's_mod' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.s_modColumn] = value;
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0039FD44 File Offset: 0x0039E144
			// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x0039FD90 File Offset: 0x0039E190
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string s_party
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSessionReport.s_partyColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 's_party' in table 'SessionReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSessionReport.s_partyColumn] = value;
				}
			}

			// Token: 0x06001DB9 RID: 7609 RVA: 0x0039FDA4 File Offset: 0x0039E1A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTeam1Null()
			{
				return this.IsNull(this.tableSessionReport.Team1Column);
			}

			// Token: 0x06001DBA RID: 7610 RVA: 0x0039FDC4 File Offset: 0x0039E1C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTeam1Null()
			{
				this[this.tableSessionReport.Team1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DBB RID: 7611 RVA: 0x0039FDE4 File Offset: 0x0039E1E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSessionReport.NameColumn);
			}

			// Token: 0x06001DBC RID: 7612 RVA: 0x0039FE04 File Offset: 0x0039E204
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				this[this.tableSessionReport.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DBD RID: 7613 RVA: 0x0039FE24 File Offset: 0x0039E224
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSr_NoNull()
			{
				return this.IsNull(this.tableSessionReport.Sr_NoColumn);
			}

			// Token: 0x06001DBE RID: 7614 RVA: 0x0039FE44 File Offset: 0x0039E244
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSr_NoNull()
			{
				this[this.tableSessionReport.Sr_NoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DBF RID: 7615 RVA: 0x0039FE64 File Offset: 0x0039E264
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsDtNull()
			{
				return this.IsNull(this.tableSessionReport.DtColumn);
			}

			// Token: 0x06001DC0 RID: 7616 RVA: 0x0039FE84 File Offset: 0x0039E284
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetDtNull()
			{
				this[this.tableSessionReport.DtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DC1 RID: 7617 RVA: 0x0039FEA4 File Offset: 0x0039E2A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsN_nameNull()
			{
				return this.IsNull(this.tableSessionReport.N_nameColumn);
			}

			// Token: 0x06001DC2 RID: 7618 RVA: 0x0039FEC4 File Offset: 0x0039E2C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetN_nameNull()
			{
				this[this.tableSessionReport.N_nameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DC3 RID: 7619 RVA: 0x0039FEE4 File Offset: 0x0039E2E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsTypeNull()
			{
				return this.IsNull(this.tableSessionReport.TypeColumn);
			}

			// Token: 0x06001DC4 RID: 7620 RVA: 0x0039FF04 File Offset: 0x0039E304
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTypeNull()
			{
				this[this.tableSessionReport.TypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DC5 RID: 7621 RVA: 0x0039FF24 File Offset: 0x0039E324
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return this.IsNull(this.tableSessionReport.idColumn);
			}

			// Token: 0x06001DC6 RID: 7622 RVA: 0x0039FF44 File Offset: 0x0039E344
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidNull()
			{
				this[this.tableSessionReport.idColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DC7 RID: 7623 RVA: 0x0039FF64 File Offset: 0x0039E364
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iss_rateNull()
			{
				return this.IsNull(this.tableSessionReport.s_rateColumn);
			}

			// Token: 0x06001DC8 RID: 7624 RVA: 0x0039FF84 File Offset: 0x0039E384
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Sets_rateNull()
			{
				this[this.tableSessionReport.s_rateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DC9 RID: 7625 RVA: 0x0039FFA4 File Offset: 0x0039E3A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Iss_amtNull()
			{
				return this.IsNull(this.tableSessionReport.s_amtColumn);
			}

			// Token: 0x06001DCA RID: 7626 RVA: 0x0039FFC4 File Offset: 0x0039E3C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sets_amtNull()
			{
				this[this.tableSessionReport.s_amtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DCB RID: 7627 RVA: 0x0039FFE4 File Offset: 0x0039E3E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsS_RUNNull()
			{
				return this.IsNull(this.tableSessionReport.S_RUNColumn);
			}

			// Token: 0x06001DCC RID: 7628 RVA: 0x003A0004 File Offset: 0x0039E404
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetS_RUNNull()
			{
				this[this.tableSessionReport.S_RUNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DCD RID: 7629 RVA: 0x003A0024 File Offset: 0x0039E424
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Iss_bildNull()
			{
				return this.IsNull(this.tableSessionReport.s_bildColumn);
			}

			// Token: 0x06001DCE RID: 7630 RVA: 0x003A0044 File Offset: 0x0039E444
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sets_bildNull()
			{
				this[this.tableSessionReport.s_bildColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DCF RID: 7631 RVA: 0x003A0064 File Offset: 0x0039E464
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Iss_modNull()
			{
				return this.IsNull(this.tableSessionReport.s_modColumn);
			}

			// Token: 0x06001DD0 RID: 7632 RVA: 0x003A0084 File Offset: 0x0039E484
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sets_modNull()
			{
				this[this.tableSessionReport.s_modColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DD1 RID: 7633 RVA: 0x003A00A4 File Offset: 0x0039E4A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Iss_partyNull()
			{
				return this.IsNull(this.tableSessionReport.s_partyColumn);
			}

			// Token: 0x06001DD2 RID: 7634 RVA: 0x003A00C4 File Offset: 0x0039E4C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Sets_partyNull()
			{
				this[this.tableSessionReport.s_partyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C57 RID: 3159
			private Partyprint.SessionReportDataTable tableSessionReport;
		}

		// Token: 0x02000081 RID: 129
		public class ListViewDataRow : DataRow
		{
			// Token: 0x06001DD3 RID: 7635 RVA: 0x003A00E4 File Offset: 0x0039E4E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal ListViewDataRow(DataRowBuilder rb) : base(rb)
			{
				this.tableListViewData = (Partyprint.ListViewDataDataTable)this.Table;
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x003A0100 File Offset: 0x0039E500
			// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x003A014C File Offset: 0x0039E54C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Sr_No
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData.Sr_NoColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Sr_No' in table 'ListViewData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData.Sr_NoColumn] = value;
				}
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x003A0160 File Offset: 0x0039E560
			// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x003A01AC File Offset: 0x0039E5AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Amount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData.AmountColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Amount' in table 'ListViewData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData.AmountColumn] = value;
				}
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x003A01C0 File Offset: 0x0039E5C0
			// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x003A020C File Offset: 0x0039E60C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Rate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData.RateColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Rate' in table 'ListViewData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData.RateColumn] = value;
				}
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06001DDA RID: 7642 RVA: 0x003A0220 File Offset: 0x0039E620
			// (set) Token: 0x06001DDB RID: 7643 RVA: 0x003A026C File Offset: 0x0039E66C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Fovrt
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData.FovrtColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Fovrt' in table 'ListViewData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData.FovrtColumn] = value;
				}
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06001DDC RID: 7644 RVA: 0x003A0280 File Offset: 0x0039E680
			// (set) Token: 0x06001DDD RID: 7645 RVA: 0x003A02CC File Offset: 0x0039E6CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Mode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData.ModeColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Mode' in table 'ListViewData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData.ModeColumn] = value;
				}
			}

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x06001DDE RID: 7646 RVA: 0x003A02E0 File Offset: 0x0039E6E0
			// (set) Token: 0x06001DDF RID: 7647 RVA: 0x003A032C File Offset: 0x0039E72C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData.nameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'name' in table 'ListViewData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData.nameColumn] = value;
				}
			}

			// Token: 0x06001DE0 RID: 7648 RVA: 0x003A0340 File Offset: 0x0039E740
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSr_NoNull()
			{
				return this.IsNull(this.tableListViewData.Sr_NoColumn);
			}

			// Token: 0x06001DE1 RID: 7649 RVA: 0x003A0360 File Offset: 0x0039E760
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSr_NoNull()
			{
				this[this.tableListViewData.Sr_NoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DE2 RID: 7650 RVA: 0x003A0380 File Offset: 0x0039E780
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsAmountNull()
			{
				return this.IsNull(this.tableListViewData.AmountColumn);
			}

			// Token: 0x06001DE3 RID: 7651 RVA: 0x003A03A0 File Offset: 0x0039E7A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAmountNull()
			{
				this[this.tableListViewData.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DE4 RID: 7652 RVA: 0x003A03C0 File Offset: 0x0039E7C0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsRateNull()
			{
				return this.IsNull(this.tableListViewData.RateColumn);
			}

			// Token: 0x06001DE5 RID: 7653 RVA: 0x003A03E0 File Offset: 0x0039E7E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetRateNull()
			{
				this[this.tableListViewData.RateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DE6 RID: 7654 RVA: 0x003A0400 File Offset: 0x0039E800
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsFovrtNull()
			{
				return this.IsNull(this.tableListViewData.FovrtColumn);
			}

			// Token: 0x06001DE7 RID: 7655 RVA: 0x003A0420 File Offset: 0x0039E820
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetFovrtNull()
			{
				this[this.tableListViewData.FovrtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DE8 RID: 7656 RVA: 0x003A0440 File Offset: 0x0039E840
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsModeNull()
			{
				return this.IsNull(this.tableListViewData.ModeColumn);
			}

			// Token: 0x06001DE9 RID: 7657 RVA: 0x003A0460 File Offset: 0x0039E860
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetModeNull()
			{
				this[this.tableListViewData.ModeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DEA RID: 7658 RVA: 0x003A0480 File Offset: 0x0039E880
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsnameNull()
			{
				return this.IsNull(this.tableListViewData.nameColumn);
			}

			// Token: 0x06001DEB RID: 7659 RVA: 0x003A04A0 File Offset: 0x0039E8A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetnameNull()
			{
				this[this.tableListViewData.nameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C58 RID: 3160
			private Partyprint.ListViewDataDataTable tableListViewData;
		}

		// Token: 0x02000082 RID: 130
		public class ListViewData1Row : DataRow
		{
			// Token: 0x06001DEC RID: 7660 RVA: 0x003A04C0 File Offset: 0x0039E8C0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal ListViewData1Row(DataRowBuilder rb) : base(rb)
			{
				this.tableListViewData1 = (Partyprint.ListViewData1DataTable)this.Table;
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x06001DED RID: 7661 RVA: 0x003A04DC File Offset: 0x0039E8DC
			// (set) Token: 0x06001DEE RID: 7662 RVA: 0x003A0528 File Offset: 0x0039E928
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Sr_No
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData1.Sr_NoColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Sr_No' in table 'ListViewData1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData1.Sr_NoColumn] = value;
				}
			}

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x06001DEF RID: 7663 RVA: 0x003A053C File Offset: 0x0039E93C
			// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x003A0588 File Offset: 0x0039E988
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Amount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData1.AmountColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Amount' in table 'ListViewData1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData1.AmountColumn] = value;
				}
			}

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x003A059C File Offset: 0x0039E99C
			// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x003A05E8 File Offset: 0x0039E9E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Rate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData1.RateColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Rate' in table 'ListViewData1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData1.RateColumn] = value;
				}
			}

			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x003A05FC File Offset: 0x0039E9FC
			// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x003A0648 File Offset: 0x0039EA48
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Run
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData1.RunColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Run' in table 'ListViewData1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData1.RunColumn] = value;
				}
			}

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x003A065C File Offset: 0x0039EA5C
			// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x003A06A8 File Offset: 0x0039EAA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Mode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData1.ModeColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Mode' in table 'ListViewData1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData1.ModeColumn] = value;
				}
			}

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x003A06BC File Offset: 0x0039EABC
			// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x003A0708 File Offset: 0x0039EB08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Badli
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData1.BadliColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Badli' in table 'ListViewData1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData1.BadliColumn] = value;
				}
			}

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x003A071C File Offset: 0x0039EB1C
			// (set) Token: 0x06001DFA RID: 7674 RVA: 0x003A0768 File Offset: 0x0039EB68
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableListViewData1.nameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'name' in table 'ListViewData1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableListViewData1.nameColumn] = value;
				}
			}

			// Token: 0x06001DFB RID: 7675 RVA: 0x003A077C File Offset: 0x0039EB7C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSr_NoNull()
			{
				return this.IsNull(this.tableListViewData1.Sr_NoColumn);
			}

			// Token: 0x06001DFC RID: 7676 RVA: 0x003A079C File Offset: 0x0039EB9C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetSr_NoNull()
			{
				this[this.tableListViewData1.Sr_NoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DFD RID: 7677 RVA: 0x003A07BC File Offset: 0x0039EBBC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAmountNull()
			{
				return this.IsNull(this.tableListViewData1.AmountColumn);
			}

			// Token: 0x06001DFE RID: 7678 RVA: 0x003A07DC File Offset: 0x0039EBDC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetAmountNull()
			{
				this[this.tableListViewData1.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001DFF RID: 7679 RVA: 0x003A07FC File Offset: 0x0039EBFC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsRateNull()
			{
				return this.IsNull(this.tableListViewData1.RateColumn);
			}

			// Token: 0x06001E00 RID: 7680 RVA: 0x003A081C File Offset: 0x0039EC1C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetRateNull()
			{
				this[this.tableListViewData1.RateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E01 RID: 7681 RVA: 0x003A083C File Offset: 0x0039EC3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRunNull()
			{
				return this.IsNull(this.tableListViewData1.RunColumn);
			}

			// Token: 0x06001E02 RID: 7682 RVA: 0x003A085C File Offset: 0x0039EC5C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetRunNull()
			{
				this[this.tableListViewData1.RunColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E03 RID: 7683 RVA: 0x003A087C File Offset: 0x0039EC7C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsModeNull()
			{
				return this.IsNull(this.tableListViewData1.ModeColumn);
			}

			// Token: 0x06001E04 RID: 7684 RVA: 0x003A089C File Offset: 0x0039EC9C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetModeNull()
			{
				this[this.tableListViewData1.ModeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E05 RID: 7685 RVA: 0x003A08BC File Offset: 0x0039ECBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsBadliNull()
			{
				return this.IsNull(this.tableListViewData1.BadliColumn);
			}

			// Token: 0x06001E06 RID: 7686 RVA: 0x003A08DC File Offset: 0x0039ECDC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetBadliNull()
			{
				this[this.tableListViewData1.BadliColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E07 RID: 7687 RVA: 0x003A08FC File Offset: 0x0039ECFC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnameNull()
			{
				return this.IsNull(this.tableListViewData1.nameColumn);
			}

			// Token: 0x06001E08 RID: 7688 RVA: 0x003A091C File Offset: 0x0039ED1C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetnameNull()
			{
				this[this.tableListViewData1.nameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C59 RID: 3161
			private Partyprint.ListViewData1DataTable tableListViewData1;
		}

		// Token: 0x02000083 RID: 131
		public class FinalTBRow : DataRow
		{
			// Token: 0x06001E09 RID: 7689 RVA: 0x003A093C File Offset: 0x0039ED3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal FinalTBRow(DataRowBuilder rb) : base(rb)
			{
				this.tableFinalTB = (Partyprint.FinalTBDataTable)this.Table;
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x06001E0A RID: 7690 RVA: 0x003A0958 File Offset: 0x0039ED58
			// (set) Token: 0x06001E0B RID: 7691 RVA: 0x003A09A4 File Offset: 0x0039EDA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string a
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFinalTB.aColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'a' in table 'FinalTB' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFinalTB.aColumn] = value;
				}
			}

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06001E0C RID: 7692 RVA: 0x003A09B8 File Offset: 0x0039EDB8
			// (set) Token: 0x06001E0D RID: 7693 RVA: 0x003A0A04 File Offset: 0x0039EE04
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string b
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFinalTB.bColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'b' in table 'FinalTB' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFinalTB.bColumn] = value;
				}
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x06001E0E RID: 7694 RVA: 0x003A0A18 File Offset: 0x0039EE18
			// (set) Token: 0x06001E0F RID: 7695 RVA: 0x003A0A64 File Offset: 0x0039EE64
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string c
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFinalTB.cColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'c' in table 'FinalTB' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFinalTB.cColumn] = value;
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x06001E10 RID: 7696 RVA: 0x003A0A78 File Offset: 0x0039EE78
			// (set) Token: 0x06001E11 RID: 7697 RVA: 0x003A0AC4 File Offset: 0x0039EEC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string d
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFinalTB.dColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'd' in table 'FinalTB' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFinalTB.dColumn] = value;
				}
			}

			// Token: 0x06001E12 RID: 7698 RVA: 0x003A0AD8 File Offset: 0x0039EED8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsaNull()
			{
				return this.IsNull(this.tableFinalTB.aColumn);
			}

			// Token: 0x06001E13 RID: 7699 RVA: 0x003A0AF8 File Offset: 0x0039EEF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetaNull()
			{
				this[this.tableFinalTB.aColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E14 RID: 7700 RVA: 0x003A0B18 File Offset: 0x0039EF18
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsbNull()
			{
				return this.IsNull(this.tableFinalTB.bColumn);
			}

			// Token: 0x06001E15 RID: 7701 RVA: 0x003A0B38 File Offset: 0x0039EF38
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetbNull()
			{
				this[this.tableFinalTB.bColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E16 RID: 7702 RVA: 0x003A0B58 File Offset: 0x0039EF58
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IscNull()
			{
				return this.IsNull(this.tableFinalTB.cColumn);
			}

			// Token: 0x06001E17 RID: 7703 RVA: 0x003A0B78 File Offset: 0x0039EF78
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetcNull()
			{
				this[this.tableFinalTB.cColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E18 RID: 7704 RVA: 0x003A0B98 File Offset: 0x0039EF98
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsdNull()
			{
				return this.IsNull(this.tableFinalTB.dColumn);
			}

			// Token: 0x06001E19 RID: 7705 RVA: 0x003A0BB8 File Offset: 0x0039EFB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdNull()
			{
				this[this.tableFinalTB.dColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C5A RID: 3162
			private Partyprint.FinalTBDataTable tableFinalTB;
		}

		// Token: 0x02000084 RID: 132
		public class HawalRow : DataRow
		{
			// Token: 0x06001E1A RID: 7706 RVA: 0x003A0BD8 File Offset: 0x0039EFD8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal HawalRow(DataRowBuilder rb) : base(rb)
			{
				this.tableHawal = (Partyprint.HawalDataTable)this.Table;
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x06001E1B RID: 7707 RVA: 0x003A0BF4 File Offset: 0x0039EFF4
			// (set) Token: 0x06001E1C RID: 7708 RVA: 0x003A0C40 File Offset: 0x0039F040
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHawal.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'Hawal' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHawal.Column1Column] = value;
				}
			}

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06001E1D RID: 7709 RVA: 0x003A0C54 File Offset: 0x0039F054
			// (set) Token: 0x06001E1E RID: 7710 RVA: 0x003A0CA0 File Offset: 0x0039F0A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHawal.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'Hawal' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHawal.Column2Column] = value;
				}
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x06001E1F RID: 7711 RVA: 0x003A0CB4 File Offset: 0x0039F0B4
			// (set) Token: 0x06001E20 RID: 7712 RVA: 0x003A0D00 File Offset: 0x0039F100
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHawal.Column3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column3' in table 'Hawal' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHawal.Column3Column] = value;
				}
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06001E21 RID: 7713 RVA: 0x003A0D14 File Offset: 0x0039F114
			// (set) Token: 0x06001E22 RID: 7714 RVA: 0x003A0D60 File Offset: 0x0039F160
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHawal.Column4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column4' in table 'Hawal' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHawal.Column4Column] = value;
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06001E23 RID: 7715 RVA: 0x003A0D74 File Offset: 0x0039F174
			// (set) Token: 0x06001E24 RID: 7716 RVA: 0x003A0DC0 File Offset: 0x0039F1C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column5
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHawal.Column5Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column5' in table 'Hawal' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHawal.Column5Column] = value;
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06001E25 RID: 7717 RVA: 0x003A0DD4 File Offset: 0x0039F1D4
			// (set) Token: 0x06001E26 RID: 7718 RVA: 0x003A0E20 File Offset: 0x0039F220
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column6
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableHawal.Column6Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column6' in table 'Hawal' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableHawal.Column6Column] = value;
				}
			}

			// Token: 0x06001E27 RID: 7719 RVA: 0x003A0E34 File Offset: 0x0039F234
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableHawal.Column1Column);
			}

			// Token: 0x06001E28 RID: 7720 RVA: 0x003A0E54 File Offset: 0x0039F254
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn1Null()
			{
				this[this.tableHawal.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E29 RID: 7721 RVA: 0x003A0E74 File Offset: 0x0039F274
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableHawal.Column2Column);
			}

			// Token: 0x06001E2A RID: 7722 RVA: 0x003A0E94 File Offset: 0x0039F294
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn2Null()
			{
				this[this.tableHawal.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E2B RID: 7723 RVA: 0x003A0EB4 File Offset: 0x0039F2B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn3Null()
			{
				return this.IsNull(this.tableHawal.Column3Column);
			}

			// Token: 0x06001E2C RID: 7724 RVA: 0x003A0ED4 File Offset: 0x0039F2D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn3Null()
			{
				this[this.tableHawal.Column3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E2D RID: 7725 RVA: 0x003A0EF4 File Offset: 0x0039F2F4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn4Null()
			{
				return this.IsNull(this.tableHawal.Column4Column);
			}

			// Token: 0x06001E2E RID: 7726 RVA: 0x003A0F14 File Offset: 0x0039F314
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn4Null()
			{
				this[this.tableHawal.Column4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E2F RID: 7727 RVA: 0x003A0F34 File Offset: 0x0039F334
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn5Null()
			{
				return this.IsNull(this.tableHawal.Column5Column);
			}

			// Token: 0x06001E30 RID: 7728 RVA: 0x003A0F54 File Offset: 0x0039F354
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn5Null()
			{
				this[this.tableHawal.Column5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E31 RID: 7729 RVA: 0x003A0F74 File Offset: 0x0039F374
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn6Null()
			{
				return this.IsNull(this.tableHawal.Column6Column);
			}

			// Token: 0x06001E32 RID: 7730 RVA: 0x003A0F94 File Offset: 0x0039F394
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn6Null()
			{
				this[this.tableHawal.Column6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C5B RID: 3163
			private Partyprint.HawalDataTable tableHawal;
		}

		// Token: 0x02000085 RID: 133
		public class CNRow : DataRow
		{
			// Token: 0x06001E33 RID: 7731 RVA: 0x003A0FB4 File Offset: 0x0039F3B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal CNRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCN = (Partyprint.CNDataTable)this.Table;
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06001E34 RID: 7732 RVA: 0x003A0FD0 File Offset: 0x0039F3D0
			// (set) Token: 0x06001E35 RID: 7733 RVA: 0x003A101C File Offset: 0x0039F41C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableCN.NameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'CN' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableCN.NameColumn] = value;
				}
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06001E36 RID: 7734 RVA: 0x003A1030 File Offset: 0x0039F430
			// (set) Token: 0x06001E37 RID: 7735 RVA: 0x003A107C File Offset: 0x0039F47C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Amount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableCN.AmountColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Amount' in table 'CN' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableCN.AmountColumn] = value;
				}
			}

			// Token: 0x06001E38 RID: 7736 RVA: 0x003A1090 File Offset: 0x0039F490
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableCN.NameColumn);
			}

			// Token: 0x06001E39 RID: 7737 RVA: 0x003A10B0 File Offset: 0x0039F4B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableCN.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E3A RID: 7738 RVA: 0x003A10D0 File Offset: 0x0039F4D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsAmountNull()
			{
				return this.IsNull(this.tableCN.AmountColumn);
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x003A10F0 File Offset: 0x0039F4F0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetAmountNull()
			{
				this[this.tableCN.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C5C RID: 3164
			private Partyprint.CNDataTable tableCN;
		}

		// Token: 0x02000086 RID: 134
		public class PdataRow : DataRow
		{
			// Token: 0x06001E3C RID: 7740 RVA: 0x003A1110 File Offset: 0x0039F510
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal PdataRow(DataRowBuilder rb) : base(rb)
			{
				this.tablePdata = (Partyprint.PdataDataTable)this.Table;
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06001E3D RID: 7741 RVA: 0x003A112C File Offset: 0x0039F52C
			// (set) Token: 0x06001E3E RID: 7742 RVA: 0x003A1178 File Offset: 0x0039F578
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Date1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablePdata.Date1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Date1' in table 'Pdata' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablePdata.Date1Column] = value;
				}
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x06001E3F RID: 7743 RVA: 0x003A118C File Offset: 0x0039F58C
			// (set) Token: 0x06001E40 RID: 7744 RVA: 0x003A11D8 File Offset: 0x0039F5D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Amount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablePdata.AmountColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Amount' in table 'Pdata' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablePdata.AmountColumn] = value;
				}
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x06001E41 RID: 7745 RVA: 0x003A11EC File Offset: 0x0039F5EC
			// (set) Token: 0x06001E42 RID: 7746 RVA: 0x003A1238 File Offset: 0x0039F638
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Remark
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablePdata.RemarkColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Remark' in table 'Pdata' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablePdata.RemarkColumn] = value;
				}
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x06001E43 RID: 7747 RVA: 0x003A124C File Offset: 0x0039F64C
			// (set) Token: 0x06001E44 RID: 7748 RVA: 0x003A1298 File Offset: 0x0039F698
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string partyamount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablePdata.partyamountColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'partyamount' in table 'Pdata' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablePdata.partyamountColumn] = value;
				}
			}

			// Token: 0x06001E45 RID: 7749 RVA: 0x003A12AC File Offset: 0x0039F6AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsDate1Null()
			{
				return this.IsNull(this.tablePdata.Date1Column);
			}

			// Token: 0x06001E46 RID: 7750 RVA: 0x003A12CC File Offset: 0x0039F6CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDate1Null()
			{
				this[this.tablePdata.Date1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E47 RID: 7751 RVA: 0x003A12EC File Offset: 0x0039F6EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsAmountNull()
			{
				return this.IsNull(this.tablePdata.AmountColumn);
			}

			// Token: 0x06001E48 RID: 7752 RVA: 0x003A130C File Offset: 0x0039F70C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetAmountNull()
			{
				this[this.tablePdata.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E49 RID: 7753 RVA: 0x003A132C File Offset: 0x0039F72C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRemarkNull()
			{
				return this.IsNull(this.tablePdata.RemarkColumn);
			}

			// Token: 0x06001E4A RID: 7754 RVA: 0x003A134C File Offset: 0x0039F74C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRemarkNull()
			{
				this[this.tablePdata.RemarkColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E4B RID: 7755 RVA: 0x003A136C File Offset: 0x0039F76C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IspartyamountNull()
			{
				return this.IsNull(this.tablePdata.partyamountColumn);
			}

			// Token: 0x06001E4C RID: 7756 RVA: 0x003A138C File Offset: 0x0039F78C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpartyamountNull()
			{
				this[this.tablePdata.partyamountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C5D RID: 3165
			private Partyprint.PdataDataTable tablePdata;
		}

		// Token: 0x02000087 RID: 135
		public class TrnRow : DataRow
		{
			// Token: 0x06001E4D RID: 7757 RVA: 0x003A13AC File Offset: 0x0039F7AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TrnRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTrn = (Partyprint.TrnDataTable)this.Table;
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06001E4E RID: 7758 RVA: 0x003A13C8 File Offset: 0x0039F7C8
			// (set) Token: 0x06001E4F RID: 7759 RVA: 0x003A1414 File Offset: 0x0039F814
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string D
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableTrn.DColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'D' in table 'Trn' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableTrn.DColumn] = value;
				}
			}

			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x06001E50 RID: 7760 RVA: 0x003A1428 File Offset: 0x0039F828
			// (set) Token: 0x06001E51 RID: 7761 RVA: 0x003A1474 File Offset: 0x0039F874
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string R
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableTrn.RColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'R' in table 'Trn' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableTrn.RColumn] = value;
				}
			}

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x06001E52 RID: 7762 RVA: 0x003A1488 File Offset: 0x0039F888
			// (set) Token: 0x06001E53 RID: 7763 RVA: 0x003A14D4 File Offset: 0x0039F8D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string A
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableTrn.AColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'A' in table 'Trn' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableTrn.AColumn] = value;
				}
			}

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06001E54 RID: 7764 RVA: 0x003A14E8 File Offset: 0x0039F8E8
			// (set) Token: 0x06001E55 RID: 7765 RVA: 0x003A1534 File Offset: 0x0039F934
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string C
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableTrn.CColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'C' in table 'Trn' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableTrn.CColumn] = value;
				}
			}

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x06001E56 RID: 7766 RVA: 0x003A1548 File Offset: 0x0039F948
			// (set) Token: 0x06001E57 RID: 7767 RVA: 0x003A1594 File Offset: 0x0039F994
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string T
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableTrn.TColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'T' in table 'Trn' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableTrn.TColumn] = value;
				}
			}

			// Token: 0x06001E58 RID: 7768 RVA: 0x003A15A8 File Offset: 0x0039F9A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDNull()
			{
				return this.IsNull(this.tableTrn.DColumn);
			}

			// Token: 0x06001E59 RID: 7769 RVA: 0x003A15C8 File Offset: 0x0039F9C8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDNull()
			{
				this[this.tableTrn.DColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E5A RID: 7770 RVA: 0x003A15E8 File Offset: 0x0039F9E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRNull()
			{
				return this.IsNull(this.tableTrn.RColumn);
			}

			// Token: 0x06001E5B RID: 7771 RVA: 0x003A1608 File Offset: 0x0039FA08
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRNull()
			{
				this[this.tableTrn.RColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E5C RID: 7772 RVA: 0x003A1628 File Offset: 0x0039FA28
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsANull()
			{
				return this.IsNull(this.tableTrn.AColumn);
			}

			// Token: 0x06001E5D RID: 7773 RVA: 0x003A1648 File Offset: 0x0039FA48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetANull()
			{
				this[this.tableTrn.AColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E5E RID: 7774 RVA: 0x003A1668 File Offset: 0x0039FA68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCNull()
			{
				return this.IsNull(this.tableTrn.CColumn);
			}

			// Token: 0x06001E5F RID: 7775 RVA: 0x003A1688 File Offset: 0x0039FA88
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCNull()
			{
				this[this.tableTrn.CColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E60 RID: 7776 RVA: 0x003A16A8 File Offset: 0x0039FAA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTNull()
			{
				return this.IsNull(this.tableTrn.TColumn);
			}

			// Token: 0x06001E61 RID: 7777 RVA: 0x003A16C8 File Offset: 0x0039FAC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTNull()
			{
				this[this.tableTrn.TColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C5E RID: 3166
			private Partyprint.TrnDataTable tableTrn;
		}

		// Token: 0x02000088 RID: 136
		public class mbookRow : DataRow
		{
			// Token: 0x06001E62 RID: 7778 RVA: 0x003A16E8 File Offset: 0x0039FAE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal mbookRow(DataRowBuilder rb) : base(rb)
			{
				this.tablembook = (Partyprint.mbookDataTable)this.Table;
			}

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x06001E63 RID: 7779 RVA: 0x003A1704 File Offset: 0x0039FB04
			// (set) Token: 0x06001E64 RID: 7780 RVA: 0x003A1750 File Offset: 0x0039FB50
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string pname
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.pnameColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'pname' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.pnameColumn] = value;
				}
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x06001E65 RID: 7781 RVA: 0x003A1764 File Offset: 0x0039FB64
			// (set) Token: 0x06001E66 RID: 7782 RVA: 0x003A17B0 File Offset: 0x0039FBB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string t1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.t1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 't1' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.t1Column] = value;
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x06001E67 RID: 7783 RVA: 0x003A17C4 File Offset: 0x0039FBC4
			// (set) Token: 0x06001E68 RID: 7784 RVA: 0x003A1810 File Offset: 0x0039FC10
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string t2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.t2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 't2' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.t2Column] = value;
				}
			}

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x06001E69 RID: 7785 RVA: 0x003A1824 File Offset: 0x0039FC24
			// (set) Token: 0x06001E6A RID: 7786 RVA: 0x003A1870 File Offset: 0x0039FC70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string t3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.t3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 't3' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.t3Column] = value;
				}
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x06001E6B RID: 7787 RVA: 0x003A1884 File Offset: 0x0039FC84
			// (set) Token: 0x06001E6C RID: 7788 RVA: 0x003A18D0 File Offset: 0x0039FCD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string t4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.t4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 't4' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.t4Column] = value;
				}
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06001E6D RID: 7789 RVA: 0x003A18E4 File Offset: 0x0039FCE4
			// (set) Token: 0x06001E6E RID: 7790 RVA: 0x003A1930 File Offset: 0x0039FD30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string mn
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.mnColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'mn' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.mnColumn] = value;
				}
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06001E6F RID: 7791 RVA: 0x003A1944 File Offset: 0x0039FD44
			// (set) Token: 0x06001E70 RID: 7792 RVA: 0x003A1990 File Offset: 0x0039FD90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string p1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.p1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'p1' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.p1Column] = value;
				}
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x06001E71 RID: 7793 RVA: 0x003A19A4 File Offset: 0x0039FDA4
			// (set) Token: 0x06001E72 RID: 7794 RVA: 0x003A19F0 File Offset: 0x0039FDF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string p2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.p2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'p2' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.p2Column] = value;
				}
			}

			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x06001E73 RID: 7795 RVA: 0x003A1A04 File Offset: 0x0039FE04
			// (set) Token: 0x06001E74 RID: 7796 RVA: 0x003A1A50 File Offset: 0x0039FE50
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string p3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.p3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'p3' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.p3Column] = value;
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x06001E75 RID: 7797 RVA: 0x003A1A64 File Offset: 0x0039FE64
			// (set) Token: 0x06001E76 RID: 7798 RVA: 0x003A1AB0 File Offset: 0x0039FEB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string p4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tablembook.p4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'p4' in table 'mbook' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tablembook.p4Column] = value;
				}
			}

			// Token: 0x06001E77 RID: 7799 RVA: 0x003A1AC4 File Offset: 0x0039FEC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspnameNull()
			{
				return this.IsNull(this.tablembook.pnameColumn);
			}

			// Token: 0x06001E78 RID: 7800 RVA: 0x003A1AE4 File Offset: 0x0039FEE4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpnameNull()
			{
				this[this.tablembook.pnameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E79 RID: 7801 RVA: 0x003A1B04 File Offset: 0x0039FF04
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Ist1Null()
			{
				return this.IsNull(this.tablembook.t1Column);
			}

			// Token: 0x06001E7A RID: 7802 RVA: 0x003A1B24 File Offset: 0x0039FF24
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Sett1Null()
			{
				this[this.tablembook.t1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E7B RID: 7803 RVA: 0x003A1B44 File Offset: 0x0039FF44
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ist2Null()
			{
				return this.IsNull(this.tablembook.t2Column);
			}

			// Token: 0x06001E7C RID: 7804 RVA: 0x003A1B64 File Offset: 0x0039FF64
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Sett2Null()
			{
				this[this.tablembook.t2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E7D RID: 7805 RVA: 0x003A1B84 File Offset: 0x0039FF84
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ist3Null()
			{
				return this.IsNull(this.tablembook.t3Column);
			}

			// Token: 0x06001E7E RID: 7806 RVA: 0x003A1BA4 File Offset: 0x0039FFA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Sett3Null()
			{
				this[this.tablembook.t3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E7F RID: 7807 RVA: 0x003A1BC4 File Offset: 0x0039FFC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Ist4Null()
			{
				return this.IsNull(this.tablembook.t4Column);
			}

			// Token: 0x06001E80 RID: 7808 RVA: 0x003A1BE4 File Offset: 0x0039FFE4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Sett4Null()
			{
				this[this.tablembook.t4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E81 RID: 7809 RVA: 0x003A1C04 File Offset: 0x003A0004
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsmnNull()
			{
				return this.IsNull(this.tablembook.mnColumn);
			}

			// Token: 0x06001E82 RID: 7810 RVA: 0x003A1C24 File Offset: 0x003A0024
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetmnNull()
			{
				this[this.tablembook.mnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E83 RID: 7811 RVA: 0x003A1C44 File Offset: 0x003A0044
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Isp1Null()
			{
				return this.IsNull(this.tablembook.p1Column);
			}

			// Token: 0x06001E84 RID: 7812 RVA: 0x003A1C64 File Offset: 0x003A0064
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setp1Null()
			{
				this[this.tablembook.p1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E85 RID: 7813 RVA: 0x003A1C84 File Offset: 0x003A0084
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isp2Null()
			{
				return this.IsNull(this.tablembook.p2Column);
			}

			// Token: 0x06001E86 RID: 7814 RVA: 0x003A1CA4 File Offset: 0x003A00A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setp2Null()
			{
				this[this.tablembook.p2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E87 RID: 7815 RVA: 0x003A1CC4 File Offset: 0x003A00C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isp3Null()
			{
				return this.IsNull(this.tablembook.p3Column);
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x003A1CE4 File Offset: 0x003A00E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Setp3Null()
			{
				this[this.tablembook.p3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E89 RID: 7817 RVA: 0x003A1D04 File Offset: 0x003A0104
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool Isp4Null()
			{
				return this.IsNull(this.tablembook.p4Column);
			}

			// Token: 0x06001E8A RID: 7818 RVA: 0x003A1D24 File Offset: 0x003A0124
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Setp4Null()
			{
				this[this.tablembook.p4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C5F RID: 3167
			private Partyprint.mbookDataTable tablembook;
		}

		// Token: 0x02000089 RID: 137
		public class Conect_1Row : DataRow
		{
			// Token: 0x06001E8B RID: 7819 RVA: 0x003A1D44 File Offset: 0x003A0144
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Conect_1Row(DataRowBuilder rb) : base(rb)
			{
				this.tableConect_1 = (Partyprint.Conect_1DataTable)this.Table;
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x06001E8C RID: 7820 RVA: 0x003A1D60 File Offset: 0x003A0160
			// (set) Token: 0x06001E8D RID: 7821 RVA: 0x003A1DAC File Offset: 0x003A01AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_1.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'Conect_1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_1.Column1Column] = value;
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x06001E8E RID: 7822 RVA: 0x003A1DC0 File Offset: 0x003A01C0
			// (set) Token: 0x06001E8F RID: 7823 RVA: 0x003A1E0C File Offset: 0x003A020C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_1.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'Conect_1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_1.Column2Column] = value;
				}
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06001E90 RID: 7824 RVA: 0x003A1E20 File Offset: 0x003A0220
			// (set) Token: 0x06001E91 RID: 7825 RVA: 0x003A1E6C File Offset: 0x003A026C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_1.Column3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column3' in table 'Conect_1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_1.Column3Column] = value;
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06001E92 RID: 7826 RVA: 0x003A1E80 File Offset: 0x003A0280
			// (set) Token: 0x06001E93 RID: 7827 RVA: 0x003A1ECC File Offset: 0x003A02CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_1.Column4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column4' in table 'Conect_1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_1.Column4Column] = value;
				}
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x06001E94 RID: 7828 RVA: 0x003A1EE0 File Offset: 0x003A02E0
			// (set) Token: 0x06001E95 RID: 7829 RVA: 0x003A1F2C File Offset: 0x003A032C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Jama
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_1.JamaColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Jama' in table 'Conect_1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_1.JamaColumn] = value;
				}
			}

			// Token: 0x06001E96 RID: 7830 RVA: 0x003A1F40 File Offset: 0x003A0340
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableConect_1.Column1Column);
			}

			// Token: 0x06001E97 RID: 7831 RVA: 0x003A1F60 File Offset: 0x003A0360
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn1Null()
			{
				this[this.tableConect_1.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E98 RID: 7832 RVA: 0x003A1F80 File Offset: 0x003A0380
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableConect_1.Column2Column);
			}

			// Token: 0x06001E99 RID: 7833 RVA: 0x003A1FA0 File Offset: 0x003A03A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn2Null()
			{
				this[this.tableConect_1.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E9A RID: 7834 RVA: 0x003A1FC0 File Offset: 0x003A03C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn3Null()
			{
				return this.IsNull(this.tableConect_1.Column3Column);
			}

			// Token: 0x06001E9B RID: 7835 RVA: 0x003A1FE0 File Offset: 0x003A03E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn3Null()
			{
				this[this.tableConect_1.Column3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E9C RID: 7836 RVA: 0x003A2000 File Offset: 0x003A0400
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn4Null()
			{
				return this.IsNull(this.tableConect_1.Column4Column);
			}

			// Token: 0x06001E9D RID: 7837 RVA: 0x003A2020 File Offset: 0x003A0420
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn4Null()
			{
				this[this.tableConect_1.Column4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001E9E RID: 7838 RVA: 0x003A2040 File Offset: 0x003A0440
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsJamaNull()
			{
				return this.IsNull(this.tableConect_1.JamaColumn);
			}

			// Token: 0x06001E9F RID: 7839 RVA: 0x003A2060 File Offset: 0x003A0460
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetJamaNull()
			{
				this[this.tableConect_1.JamaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C60 RID: 3168
			private Partyprint.Conect_1DataTable tableConect_1;
		}

		// Token: 0x0200008A RID: 138
		public class Conect_2Row : DataRow
		{
			// Token: 0x06001EA0 RID: 7840 RVA: 0x003A2080 File Offset: 0x003A0480
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Conect_2Row(DataRowBuilder rb) : base(rb)
			{
				this.tableConect_2 = (Partyprint.Conect_2DataTable)this.Table;
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x003A209C File Offset: 0x003A049C
			// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x003A20E8 File Offset: 0x003A04E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column1
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_2.Column1Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column1' in table 'Conect_2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_2.Column1Column] = value;
				}
			}

			// Token: 0x17000B6C RID: 2924
			// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x003A20FC File Offset: 0x003A04FC
			// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x003A2148 File Offset: 0x003A0548
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column2
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_2.Column2Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column2' in table 'Conect_2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_2.Column2Column] = value;
				}
			}

			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x003A215C File Offset: 0x003A055C
			// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x003A21A8 File Offset: 0x003A05A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column3
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_2.Column3Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column3' in table 'Conect_2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_2.Column3Column] = value;
				}
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x003A21BC File Offset: 0x003A05BC
			// (set) Token: 0x06001EA8 RID: 7848 RVA: 0x003A2208 File Offset: 0x003A0608
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Column4
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_2.Column4Column]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Column4' in table 'Conect_2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_2.Column4Column] = value;
				}
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x003A221C File Offset: 0x003A061C
			// (set) Token: 0x06001EAA RID: 7850 RVA: 0x003A2268 File Offset: 0x003A0668
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Neva
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableConect_2.NevaColumn]);
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Neva' in table 'Conect_2' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableConect_2.NevaColumn] = value;
				}
			}

			// Token: 0x06001EAB RID: 7851 RVA: 0x003A227C File Offset: 0x003A067C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn1Null()
			{
				return this.IsNull(this.tableConect_2.Column1Column);
			}

			// Token: 0x06001EAC RID: 7852 RVA: 0x003A229C File Offset: 0x003A069C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn1Null()
			{
				this[this.tableConect_2.Column1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x003A22BC File Offset: 0x003A06BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn2Null()
			{
				return this.IsNull(this.tableConect_2.Column2Column);
			}

			// Token: 0x06001EAE RID: 7854 RVA: 0x003A22DC File Offset: 0x003A06DC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn2Null()
			{
				this[this.tableConect_2.Column2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001EAF RID: 7855 RVA: 0x003A22FC File Offset: 0x003A06FC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsColumn3Null()
			{
				return this.IsNull(this.tableConect_2.Column3Column);
			}

			// Token: 0x06001EB0 RID: 7856 RVA: 0x003A231C File Offset: 0x003A071C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetColumn3Null()
			{
				this[this.tableConect_2.Column3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001EB1 RID: 7857 RVA: 0x003A233C File Offset: 0x003A073C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsColumn4Null()
			{
				return this.IsNull(this.tableConect_2.Column4Column);
			}

			// Token: 0x06001EB2 RID: 7858 RVA: 0x003A235C File Offset: 0x003A075C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetColumn4Null()
			{
				this[this.tableConect_2.Column4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x06001EB3 RID: 7859 RVA: 0x003A237C File Offset: 0x003A077C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNevaNull()
			{
				return this.IsNull(this.tableConect_2.NevaColumn);
			}

			// Token: 0x06001EB4 RID: 7860 RVA: 0x003A239C File Offset: 0x003A079C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNevaNull()
			{
				this[this.tableConect_2.NevaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			// Token: 0x04000C61 RID: 3169
			private Partyprint.Conect_2DataTable tableConect_2;
		}

		// Token: 0x0200008B RID: 139
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable1RowChangeEvent : EventArgs
		{
			// Token: 0x06001EB5 RID: 7861 RVA: 0x003A23BC File Offset: 0x003A07BC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataTable1RowChangeEvent(Partyprint.DataTable1Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x003A23D4 File Offset: 0x003A07D4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.DataTable1Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x003A23E8 File Offset: 0x003A07E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C62 RID: 3170
			private Partyprint.DataTable1Row eventRow;

			// Token: 0x04000C63 RID: 3171
			private DataRowAction eventAction;
		}

		// Token: 0x0200008C RID: 140
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class MatchReportRowChangeEvent : EventArgs
		{
			// Token: 0x06001EB8 RID: 7864 RVA: 0x003A23FC File Offset: 0x003A07FC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public MatchReportRowChangeEvent(Partyprint.MatchReportRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x003A2414 File Offset: 0x003A0814
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.MatchReportRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x06001EBA RID: 7866 RVA: 0x003A2428 File Offset: 0x003A0828
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C64 RID: 3172
			private Partyprint.MatchReportRow eventRow;

			// Token: 0x04000C65 RID: 3173
			private DataRowAction eventAction;
		}

		// Token: 0x0200008D RID: 141
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class SessionReportRowChangeEvent : EventArgs
		{
			// Token: 0x06001EBB RID: 7867 RVA: 0x003A243C File Offset: 0x003A083C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public SessionReportRowChangeEvent(Partyprint.SessionReportRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x06001EBC RID: 7868 RVA: 0x003A2454 File Offset: 0x003A0854
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.SessionReportRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x06001EBD RID: 7869 RVA: 0x003A2468 File Offset: 0x003A0868
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C66 RID: 3174
			private Partyprint.SessionReportRow eventRow;

			// Token: 0x04000C67 RID: 3175
			private DataRowAction eventAction;
		}

		// Token: 0x0200008E RID: 142
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ListViewDataRowChangeEvent : EventArgs
		{
			// Token: 0x06001EBE RID: 7870 RVA: 0x003A247C File Offset: 0x003A087C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ListViewDataRowChangeEvent(Partyprint.ListViewDataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x06001EBF RID: 7871 RVA: 0x003A2494 File Offset: 0x003A0894
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.ListViewDataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x003A24A8 File Offset: 0x003A08A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C68 RID: 3176
			private Partyprint.ListViewDataRow eventRow;

			// Token: 0x04000C69 RID: 3177
			private DataRowAction eventAction;
		}

		// Token: 0x0200008F RID: 143
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ListViewData1RowChangeEvent : EventArgs
		{
			// Token: 0x06001EC1 RID: 7873 RVA: 0x003A24BC File Offset: 0x003A08BC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public ListViewData1RowChangeEvent(Partyprint.ListViewData1Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x003A24D4 File Offset: 0x003A08D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.ListViewData1Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x003A24E8 File Offset: 0x003A08E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C6A RID: 3178
			private Partyprint.ListViewData1Row eventRow;

			// Token: 0x04000C6B RID: 3179
			private DataRowAction eventAction;
		}

		// Token: 0x02000090 RID: 144
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class FinalTBRowChangeEvent : EventArgs
		{
			// Token: 0x06001EC4 RID: 7876 RVA: 0x003A24FC File Offset: 0x003A08FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public FinalTBRowChangeEvent(Partyprint.FinalTBRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x003A2514 File Offset: 0x003A0914
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.FinalTBRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x003A2528 File Offset: 0x003A0928
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C6C RID: 3180
			private Partyprint.FinalTBRow eventRow;

			// Token: 0x04000C6D RID: 3181
			private DataRowAction eventAction;
		}

		// Token: 0x02000091 RID: 145
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class HawalRowChangeEvent : EventArgs
		{
			// Token: 0x06001EC7 RID: 7879 RVA: 0x003A253C File Offset: 0x003A093C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public HawalRowChangeEvent(Partyprint.HawalRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x003A2554 File Offset: 0x003A0954
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.HawalRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x003A2568 File Offset: 0x003A0968
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C6E RID: 3182
			private Partyprint.HawalRow eventRow;

			// Token: 0x04000C6F RID: 3183
			private DataRowAction eventAction;
		}

		// Token: 0x02000092 RID: 146
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class CNRowChangeEvent : EventArgs
		{
			// Token: 0x06001ECA RID: 7882 RVA: 0x003A257C File Offset: 0x003A097C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CNRowChangeEvent(Partyprint.CNRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x06001ECB RID: 7883 RVA: 0x003A2594 File Offset: 0x003A0994
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.CNRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B7F RID: 2943
			// (get) Token: 0x06001ECC RID: 7884 RVA: 0x003A25A8 File Offset: 0x003A09A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C70 RID: 3184
			private Partyprint.CNRow eventRow;

			// Token: 0x04000C71 RID: 3185
			private DataRowAction eventAction;
		}

		// Token: 0x02000093 RID: 147
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class PdataRowChangeEvent : EventArgs
		{
			// Token: 0x06001ECD RID: 7885 RVA: 0x003A25BC File Offset: 0x003A09BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public PdataRowChangeEvent(Partyprint.PdataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x06001ECE RID: 7886 RVA: 0x003A25D4 File Offset: 0x003A09D4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.PdataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x06001ECF RID: 7887 RVA: 0x003A25E8 File Offset: 0x003A09E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C72 RID: 3186
			private Partyprint.PdataRow eventRow;

			// Token: 0x04000C73 RID: 3187
			private DataRowAction eventAction;
		}

		// Token: 0x02000094 RID: 148
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TrnRowChangeEvent : EventArgs
		{
			// Token: 0x06001ED0 RID: 7888 RVA: 0x003A25FC File Offset: 0x003A09FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public TrnRowChangeEvent(Partyprint.TrnRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x003A2614 File Offset: 0x003A0A14
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.TrnRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x003A2628 File Offset: 0x003A0A28
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C74 RID: 3188
			private Partyprint.TrnRow eventRow;

			// Token: 0x04000C75 RID: 3189
			private DataRowAction eventAction;
		}

		// Token: 0x02000095 RID: 149
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class mbookRowChangeEvent : EventArgs
		{
			// Token: 0x06001ED3 RID: 7891 RVA: 0x003A263C File Offset: 0x003A0A3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public mbookRowChangeEvent(Partyprint.mbookRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x003A2654 File Offset: 0x003A0A54
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.mbookRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x003A2668 File Offset: 0x003A0A68
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C76 RID: 3190
			private Partyprint.mbookRow eventRow;

			// Token: 0x04000C77 RID: 3191
			private DataRowAction eventAction;
		}

		// Token: 0x02000096 RID: 150
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class Conect_1RowChangeEvent : EventArgs
		{
			// Token: 0x06001ED6 RID: 7894 RVA: 0x003A267C File Offset: 0x003A0A7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Conect_1RowChangeEvent(Partyprint.Conect_1Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x003A2694 File Offset: 0x003A0A94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Partyprint.Conect_1Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x003A26A8 File Offset: 0x003A0AA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C78 RID: 3192
			private Partyprint.Conect_1Row eventRow;

			// Token: 0x04000C79 RID: 3193
			private DataRowAction eventAction;
		}

		// Token: 0x02000097 RID: 151
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class Conect_2RowChangeEvent : EventArgs
		{
			// Token: 0x06001ED9 RID: 7897 RVA: 0x003A26BC File Offset: 0x003A0ABC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Conect_2RowChangeEvent(Partyprint.Conect_2Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06001EDA RID: 7898 RVA: 0x003A26D4 File Offset: 0x003A0AD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Partyprint.Conect_2Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x06001EDB RID: 7899 RVA: 0x003A26E8 File Offset: 0x003A0AE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000C7A RID: 3194
			private Partyprint.Conect_2Row eventRow;

			// Token: 0x04000C7B RID: 3195
			private DataRowAction eventAction;
		}

		// Token: 0x02000098 RID: 152
		public class NewSessionDataTable
		{
		}
	}
}
