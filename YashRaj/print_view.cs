using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using App.Service;

namespace YashAksh
{
    // Token: 0x020000BC RID: 188
    //[DesignerGenerated]
    public partial class print_view : Form
    {
        // Token: 0x0600207D RID: 8317 RVA: 0x003A6B3C File Offset: 0x003A4F3C
        public print_view()
        {
            //base.Load += this.print_view_Load;
            this.InitializeComponent();
        }

        // Token: 0x06002082 RID: 8322 RVA: 0x003A6CC8 File Offset: 0x003A50C8
        private void print_view_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
            }
        }

        private void print_view_KeyDown(object sender, KeyEventArgs e)
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

        private void crystalReportViewer1_KeyDown(object sender, KeyEventArgs e)
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

        // Token: 0x04000CBB RID: 3259
        //[AccessedThroughProperty("CrystalReportViewer1")]
        //private CrystalReportViewer _CrystalReportViewer1;
    }
}
