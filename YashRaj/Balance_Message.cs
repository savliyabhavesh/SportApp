using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace YashAksh
{
	// Token: 0x0200000C RID: 12
	//[DesignerGenerated]
	public partial class Balance_Message : Form
	{
		public string BalanceLimit;
		public Balance_Message()
		{
			this.InitializeComponent();
		}
		private void Balance_Message_Load(object sender, EventArgs e)
		{
			label3.Text = BalanceLimit.ToString();
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;
    }
}
