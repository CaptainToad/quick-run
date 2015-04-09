using QuickRun.Classes;
using QuickRun.DataSources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace QuickRun.Forms
{
    public partial class RunTool : Form
    {
        public RunTool()
        {
            InitializeComponent();

            //Initialise event handlers
            uiButtonOK.Click += uiButtonOK_Click;
            uiButtonCancel.Click += uiButtonCancel_Click;
            this.Load += RunTool_Load;
        }

        private const string XML_DATA_FILE = "Tools.xml";
        private readonly Tools _Tools = new Tools();
        private CustomAutoCompleteCollection _ToolsAutocomplete;

        private void uiButtonOK_Click(object sender, EventArgs e)
        {
            ProcessStartInfo lProcessInfo = new ProcessStartInfo();
            string lPath = _ToolsAutocomplete.GetValue(uiTextBoxCommand.Text, "path");

            if (string.IsNullOrEmpty(lPath))
            {
                uiErrorProvider.SetError(uiTextBoxCommand, "That QuickTool ID does not exist.");
                uiTextBoxCommand.Text = string.Empty;
            }

            lProcessInfo.FileName = lPath;
            lProcessInfo.UseShellExecute = true;
            lProcessInfo.ErrorDialog = true;
            lProcessInfo.ErrorDialogParentHandle = Handle;

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

        private void RunTool_Load(object sender, EventArgs e)
        {
            try
            {
                _Tools.ReadXml(XMLDataFilePath, XmlReadMode.IgnoreSchema);
            }
            catch (Exception ex)
            { }

            _ToolsAutocomplete = new CustomAutoCompleteCollection(_Tools.QuickRun.CreateDataReader(), "shortname");
            uiTextBoxCommand.AutoCompleteCustomSource = _ToolsAutocomplete;
            uiTextBoxCommand.Focus();
        }

        private static string XMLDataFilePath
        {
            get
            {
                string lReturn = Path.Combine(Application.StartupPath, XML_DATA_FILE);

                return lReturn;
            }
        }
    }
}
