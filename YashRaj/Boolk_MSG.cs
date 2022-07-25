using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SHAI9167111516;

namespace YashAksh
{
	// Token: 0x0200004F RID: 79
	[DesignerGenerated]
	public partial class Boolk_MSG : Form
	{
		// Token: 0x06001494 RID: 5268 RVA: 0x00355F04 File Offset: 0x00354304
		public Boolk_MSG()
		{
			this.InitializeComponent();
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x003563F0 File Offset: 0x003547F0
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00356404 File Offset: 0x00354804
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00356410 File Offset: 0x00354810
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00356424 File Offset: 0x00354824
		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00356430 File Offset: 0x00354830
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x00356444 File Offset: 0x00354844
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00356450 File Offset: 0x00354850
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x00356464 File Offset: 0x00354864
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x003564B0 File Offset: 0x003548B0
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x003564C4 File Offset: 0x003548C4
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x003564D0 File Offset: 0x003548D0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Application.StartupPath + "\\DB\\MY_DB.mdb";
				string str = Application.StartupPath + "\\DB\\";
				object value = text;
				Directory.CreateDirectory(str + "\\DB\\");
				object value2 = str + "\\DB\\Error.tmp";
				FileSystem.FileCopy(Conversions.ToString(value), Conversions.ToString(value2));
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				directoryInfo.Attributes = FileAttributes.Hidden;
				DirectoryInfo directoryInfo2 = new DirectoryInfo(Application.StartupPath + "\\DB\\DB");
				directoryInfo2.Attributes = FileAttributes.Hidden;
				_ParthavI1516._Logout();
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "SELECT        Field1  FROM Donotopne";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				int num;
				if (oleDbDataReader.Read())
				{
					num = Conversions.ToInteger(oleDbDataReader["Field1"].ToString());
				}
				if (num > 1)
				{
					this.abc();
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
			finally
			{
				Module1.conn.Close();
				ProjectData.EndApp();
			}
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0035663C File Offset: 0x00354A3C
		public void abc()
		{
			try
			{
				if (Module1.conn.State == ConnectionState.Closed)
				{
					Module1.conn.Open();
				}
				string cmdText = "UPDATE       Donotopne SET      Field1 = '0'";
				OleDbCommand oleDbCommand = new OleDbCommand(cmdText, Module1.conn);
				oleDbCommand.ExecuteNonQuery();
				Module1.conn.Close();
				Module1.conn.Dispose();
				string path = Application.StartupPath + "\\DB\\MY_DB.mdb";
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				directoryInfo.Attributes = FileAttributes.Normal;
				Process.Start(Application.StartupPath + "\\SHAI151691.bat");
				Process.Start(Application.StartupPath + "\\SHAI151691.bat");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000897 RID: 2199
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000898 RID: 2200
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000899 RID: 2201
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400089A RID: 2202
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400089B RID: 2203
		[AccessedThroughProperty("Label3")]
		private Label _Label3;
	}
}
