namespace QuickRun.Forms
{
    partial class RunCommand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uiButtonBrowse = new System.Windows.Forms.Button();
            this.uiButtonOK = new System.Windows.Forms.Button();
            this.uiButtonCancel = new System.Windows.Forms.Button();
            this.uiTextBoxCommand = new System.Windows.Forms.TextBox();
            this.uiLabelOpen = new System.Windows.Forms.Label();
            this.uiLabel = new System.Windows.Forms.Label();
            this.uiPictureBox = new System.Windows.Forms.PictureBox();
            this.uiOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uiTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanel
            // 
            this.uiTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTableLayoutPanel.ColumnCount = 3;
            this.uiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.uiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.uiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.uiTableLayoutPanel.Controls.Add(this.uiButtonBrowse, 2, 0);
            this.uiTableLayoutPanel.Controls.Add(this.uiButtonOK, 0, 0);
            this.uiTableLayoutPanel.Controls.Add(this.uiButtonCancel, 1, 0);
            this.uiTableLayoutPanel.Location = new System.Drawing.Point(75, 112);
            this.uiTableLayoutPanel.Name = "uiTableLayoutPanel";
            this.uiTableLayoutPanel.RowCount = 1;
            this.uiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel.Size = new System.Drawing.Size(257, 29);
            this.uiTableLayoutPanel.TabIndex = 3;
            // 
            // uiButtonBrowse
            // 
            this.uiButtonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButtonBrowse.Location = new System.Drawing.Point(171, 3);
            this.uiButtonBrowse.Name = "uiButtonBrowse";
            this.uiButtonBrowse.Size = new System.Drawing.Size(83, 23);
            this.uiButtonBrowse.TabIndex = 2;
            this.uiButtonBrowse.Text = "&Browse...";
            // 
            // uiButtonOK
            // 
            this.uiButtonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButtonOK.Location = new System.Drawing.Point(3, 3);
            this.uiButtonOK.Name = "uiButtonOK";
            this.uiButtonOK.Size = new System.Drawing.Size(78, 23);
            this.uiButtonOK.TabIndex = 0;
            this.uiButtonOK.Text = "OK";
            // 
            // uiButtonCancel
            // 
            this.uiButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButtonCancel.Location = new System.Drawing.Point(87, 3);
            this.uiButtonCancel.Name = "uiButtonCancel";
            this.uiButtonCancel.Size = new System.Drawing.Size(78, 23);
            this.uiButtonCancel.TabIndex = 1;
            this.uiButtonCancel.Text = "Cancel";
            // 
            // uiTextBoxCommand
            // 
            this.uiTextBoxCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uiTextBoxCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.uiTextBoxCommand.Location = new System.Drawing.Point(53, 63);
            this.uiTextBoxCommand.Name = "uiTextBoxCommand";
            this.uiTextBoxCommand.Size = new System.Drawing.Size(279, 20);
            this.uiTextBoxCommand.TabIndex = 2;
            // 
            // uiLabelOpen
            // 
            this.uiLabelOpen.AutoSize = true;
            this.uiLabelOpen.Location = new System.Drawing.Point(12, 63);
            this.uiLabelOpen.Name = "uiLabelOpen";
            this.uiLabelOpen.Size = new System.Drawing.Size(33, 13);
            this.uiLabelOpen.TabIndex = 1;
            this.uiLabelOpen.Text = "&Open";
            // 
            // uiLabel
            // 
            this.uiLabel.Location = new System.Drawing.Point(50, 12);
            this.uiLabel.Name = "uiLabel";
            this.uiLabel.Size = new System.Drawing.Size(282, 32);
            this.uiLabel.TabIndex = 0;
            this.uiLabel.Text = "Type the name of a program, folder, document, or internet resource and QuickRun w" +
    "ill open it for you.";
            // 
            // uiPictureBox
            // 
            this.uiPictureBox.Image = global::QuickRun.Properties.Resources.textfield_rename;
            this.uiPictureBox.Location = new System.Drawing.Point(12, 12);
            this.uiPictureBox.Name = "uiPictureBox";
            this.uiPictureBox.Size = new System.Drawing.Size(32, 32);
            this.uiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiPictureBox.TabIndex = 6;
            this.uiPictureBox.TabStop = false;
            // 
            // uiOpenFileDialog
            // 
            this.uiOpenFileDialog.Filter = "Programs|*.exe;*.bat;*.cmd;*.pif;*.com|All files|*.*";
            this.uiOpenFileDialog.Title = "Open File";
            // 
            // RunCommand
            // 
            this.AcceptButton = this.uiButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uiButtonCancel;
            this.ClientSize = new System.Drawing.Size(344, 153);
            this.Controls.Add(this.uiTableLayoutPanel);
            this.Controls.Add(this.uiTextBoxCommand);
            this.Controls.Add(this.uiLabelOpen);
            this.Controls.Add(this.uiLabel);
            this.Controls.Add(this.uiPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunCommand";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Run";
            this.uiTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel uiTableLayoutPanel;
        internal System.Windows.Forms.Button uiButtonBrowse;
        internal System.Windows.Forms.Button uiButtonOK;
        internal System.Windows.Forms.Button uiButtonCancel;
        internal System.Windows.Forms.TextBox uiTextBoxCommand;
        internal System.Windows.Forms.Label uiLabelOpen;
        internal System.Windows.Forms.Label uiLabel;
        internal System.Windows.Forms.PictureBox uiPictureBox;
        internal System.Windows.Forms.OpenFileDialog uiOpenFileDialog;
    }
}