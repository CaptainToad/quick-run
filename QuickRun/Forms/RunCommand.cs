using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace QuickRun.Forms
{
    public partial class RunCommand : Form
    {
        public RunCommand()
        {
            InitializeComponent();

            //Initialize event handlers
            uiButtonOK.Click += uiButtonOK_Click;
            uiButtonCancel.Click += uiButtonCancel_Click;
            uiButtonBrowse.Click += uiButtonBrowse_Click;
        }

        private void uiButtonOK_Click(object sender, EventArgs e)
        {
            ProcessStartInfo lProcessInfo = new ProcessStartInfo()
               {
                   FileName = uiTextBoxCommand.Text,
                   UseShellExecute = true,
                   ErrorDialog = true,
                   ErrorDialogParentHandle = Handle
               };

            try
            {
                Process.Start(lProcessInfo);
                Close();
            }
            catch (Exception ex)
            { }
        }

        private void uiButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void uiButtonBrowse_Click(object sender, EventArgs e)
        {
            if (uiOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uiTextBoxCommand.Text = uiOpenFileDialog.FileName;
            }
        }
    }
}
