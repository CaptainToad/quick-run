using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRun.Classes
{
    partial class TrayIcon : ApplicationContext
    {

        ///Form override dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            _XMLData.Dispose();
            base.Dispose(disposing);
        }

        ///Required by the Windows Form Designer
        private IContainer components;

        ///NOTE: The following procedure is required by the Windows Form Designer
        ///It can be modified using the Windows Form Designer.  
        ///Do not modify it using the code editor.
        private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayIcon));
        this.uiNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
        this.uiContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.uiToolStripMenuItemSep1 = new System.Windows.Forms.ToolStripSeparator();
        this.uiToolStripMenuItemSep2 = new System.Windows.Forms.ToolStripSeparator();
        this.uiToolStripMenuItemSep3 = new System.Windows.Forms.ToolStripSeparator();
        this.uiExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.uiQuickRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.uiRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.uiOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.uiAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.uiContextMenuStrip.SuspendLayout();
        ///
        ///uiNotifyIcon
        ///
        this.uiNotifyIcon.ContextMenuStrip = this.uiContextMenuStrip;
        this.uiNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("uiNotifyIcon.Icon")));
        this.uiNotifyIcon.Text = "QuickRun";
        this.uiNotifyIcon.Visible = true;
        ///
        ///uiContextMenuStrip
        ///
        this.uiContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.uiQuickRunToolStripMenuItem, this.uiRunToolStripMenuItem, this.uiToolStripMenuItemSep1, this.uiOptionsToolStripMenuItem, this.uiToolStripMenuItemSep2, this.uiAboutToolStripMenuItem, this.uiToolStripMenuItemSep3, this.uiExitToolStripMenuItem});
        this.uiContextMenuStrip.Name = "uiContextMenuStrip";
        this.uiContextMenuStrip.Size = new System.Drawing.Size(146, 98);
        ///
        ///uiToolStripMenuItemSep1
        ///
        this.uiToolStripMenuItemSep1.Name = "uiToolStripMenuItemSep1";
        this.uiToolStripMenuItemSep1.Size = new System.Drawing.Size(142, 6);
        ///
        ///uiToolStripMenuItemSep2
        ///
        this.uiToolStripMenuItemSep2.Name = "uiToolStripMenuItemSep2";
        this.uiToolStripMenuItemSep2.Size = new System.Drawing.Size(142, 6);
        ///
        ///uiToolStripMenuItemSep3
        ///
        this.uiToolStripMenuItemSep3.Name = "uiToolStripMenuItemSep3";
        this.uiToolStripMenuItemSep3.Size = new System.Drawing.Size(142, 6);
        ///
        ///uiExitToolStripMenuItem
        ///
        this.uiExitToolStripMenuItem.Name = "uiExitToolStripMenuItem";
        this.uiExitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.uiExitToolStripMenuItem.Text = "E&xit";
        ///
        ///uiQuickRunToolStripMenuItem
        ///
        this.uiQuickRunToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.uiQuickRunToolStripMenuItem.Image = global::QuickRun.Properties.Resources.lightning;
        this.uiQuickRunToolStripMenuItem.Name = "uiQuickRunToolStripMenuItem";
        this.uiQuickRunToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.uiQuickRunToolStripMenuItem.Text = "&Quick Run...";
        ///
        ///uiRunToolStripMenuItem
        ///
        this.uiRunToolStripMenuItem.Image = global::QuickRun.Properties.Resources.application_lightning;
        this.uiRunToolStripMenuItem.Name = "uiRunToolStripMenuItem";
        this.uiRunToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.uiRunToolStripMenuItem.Text = "&Run...";
        ///
        ///uiOptionsToolStripMenuItem
        ///
        this.uiOptionsToolStripMenuItem.Image = global::QuickRun.Properties.Resources.database_gear;
        this.uiOptionsToolStripMenuItem.Name = "uiOptionsToolStripMenuItem";
        this.uiOptionsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.uiOptionsToolStripMenuItem.Text = "&Options";
        ///
        ///uiAboutToolStripMenuItem
        ///
        this.uiAboutToolStripMenuItem.Image = global::QuickRun.Properties.Resources.help;
        this.uiAboutToolStripMenuItem.Name = "uiAboutToolStripMenuItem";
        this.uiAboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.uiAboutToolStripMenuItem.Text = "&About";
        ///
        ///TrayIcon
        ///
        this.uiContextMenuStrip.ResumeLayout(false);
    }
        protected System.Windows.Forms.NotifyIcon uiNotifyIcon;
        protected System.Windows.Forms.ContextMenuStrip uiContextMenuStrip;
        protected System.Windows.Forms.ToolStripMenuItem uiQuickRunToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem uiRunToolStripMenuItem;
        protected System.Windows.Forms.ToolStripSeparator uiToolStripMenuItemSep1;
        protected System.Windows.Forms.ToolStripSeparator uiToolStripMenuItemSep2;
        protected System.Windows.Forms.ToolStripSeparator uiToolStripMenuItemSep3;
        protected System.Windows.Forms.ToolStripMenuItem uiExitToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem uiOptionsToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem uiAboutToolStripMenuItem;

    }
}
