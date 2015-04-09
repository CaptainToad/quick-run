using QuickRun.DataSources;
using QuickRun.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuickRun.Classes
{
    partial class TrayIcon
    {
        private readonly Tools _XMLData = new Tools();

        private void uiExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunCommand lRunForm = new RunCommand();

            lRunForm.Location = CalculatePosition(lRunForm);

            lRunForm.Show();
        }

        private void uiQuickRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunTool lRunForm = new RunTool();

            lRunForm.Location = CalculatePosition(lRunForm);

            lRunForm.Show();
        }

        private void uiNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                uiQuickRunToolStripMenuItem.PerformClick();
            }
        }

        public TrayIcon()
        {
            ///This call is required by the Windows Form Designer.
            InitializeComponent();

            //Add event handlers
            this.uiExitToolStripMenuItem.Click += uiExitToolStripMenuItem_Click;
            this.uiRunToolStripMenuItem.Click += uiRunToolStripMenuItem_Click;
            this.uiQuickRunToolStripMenuItem.Click += uiQuickRunToolStripMenuItem_Click;
            this.uiNotifyIcon.MouseDoubleClick += uiNotifyIcon_MouseDoubleClick;
            this.uiOptionsToolStripMenuItem.Click+= uiOptionsToolStripMenuItem_Click;

            ///Add any initialization after the InitializeComponent() call.
            uiAboutToolStripMenuItem.Enabled = false;
        }

        private void uiOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options lOptions = new Options();
            Dictionary<string, string> lSettings = new Dictionary<String, String>();

            lSettings["AutoStart"] = Program.AutoStart.ToString();

            lOptions.Settings = lSettings;
            lOptions.Location = CalculatePosition(lOptions);
            if (lOptions.ShowDialog() == DialogResult.OK)
            {
                Program.AutoStart = bool.Parse(lSettings["AutoStart"]);
            }
        }

        private static Point CalculatePosition(Form form)
        {
            return (new Point(Screen.PrimaryScreen.WorkingArea.Right - form.Width, Screen.PrimaryScreen.WorkingArea.Bottom - form.Height));
        }

        private void OpenDataFile()
        {
            _XMLData.ReadXml(Path.Combine(Application.StartupPath, "Tools.xml"), XmlReadMode.IgnoreSchema);
        }

        private void CloseDataFile()
        {
            _XMLData.WriteXml(Path.Combine(Application.StartupPath, "Tools.xml"));
            _XMLData.Dispose();
        }

        private void AddTool(string name, string path, string icon, string shortName)
        {
            _XMLData.QuickRun.AddQuickRunRow(name, path, icon, shortName);
        }
    }
}