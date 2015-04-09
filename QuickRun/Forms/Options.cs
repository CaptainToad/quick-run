using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuickRun.Forms
{
    public partial class Options : Form
    {
        public Dictionary<string, string> Settings = new Dictionary<string, string>();

        public Options()
        {
            InitializeComponent();

            //Initialise event handlers
            uiButtonOK.Click += uiButtonOK_Click;
            uiButtonCancel.Click += uiButtonCancel_Click;
            uiCheckBoxAutoStart.CheckedChanged += uiCheckBoxAutoStart_CheckedChanged;
            this.Load += Options_Load;
        }

        private void uiButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void uiButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void uiCheckBoxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            Settings["AutoStart"] = uiCheckBoxAutoStart.Checked.ToString();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            uiCheckBoxAutoStart.Checked = bool.Parse(Settings["AutoStart"]);
        }
    }
}
