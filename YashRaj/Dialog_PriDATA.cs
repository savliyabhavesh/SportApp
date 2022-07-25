using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using App.Service;

namespace YashAksh
{
    public partial class Dialog_PriDATA : Form
    {
        public Dialog_PriDATA()
        {
            try
            {
                base.Load += this.Dialog_PriDATA_Load;
                this.InitializeComponent();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }


        private void OK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                App.Utility.ErrorLog.LogError(BaseService.GetMethodDetails(), ex.Message);
            }
        }

        private void Dialog_PriDATA_Load(object sender, EventArgs e)
        {
        }

        //private CrystalReportViewer _CrystalReportViewer1;

        //[AccessedThroughProperty("Privesdata1")]
        //private Privesdata _Privesdata1;
    }
}
