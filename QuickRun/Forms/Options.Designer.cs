namespace QuickRun.Forms
{
    partial class Options
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
            this.uiTableLayoutPanelFormControls = new System.Windows.Forms.TableLayoutPanel();
            this.uiButtonOK = new System.Windows.Forms.Button();
            this.uiButtonCancel = new System.Windows.Forms.Button();
            this.uiGroupBoxStartup = new System.Windows.Forms.GroupBox();
            this.uiCheckBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.uiGroupBoxTools = new System.Windows.Forms.GroupBox();
            this.uiListViewTools = new System.Windows.Forms.ListView();
            this.uiTableLayoutPanelToolControls = new System.Windows.Forms.TableLayoutPanel();
            this.uiButtonRemove = new System.Windows.Forms.Button();
            this.uiButtonEdit = new System.Windows.Forms.Button();
            this.uiButtonAdd = new System.Windows.Forms.Button();
            this.uiTableLayoutPanelFormControls.SuspendLayout();
            this.uiGroupBoxStartup.SuspendLayout();
            this.uiGroupBoxTools.SuspendLayout();
            this.uiTableLayoutPanelToolControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanelFormControls
            // 
            this.uiTableLayoutPanelFormControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTableLayoutPanelFormControls.ColumnCount = 2;
            this.uiTableLayoutPanelFormControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanelFormControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanelFormControls.Controls.Add(this.uiButtonOK, 0, 0);
            this.uiTableLayoutPanelFormControls.Controls.Add(this.uiButtonCancel, 1, 0);
            this.uiTableLayoutPanelFormControls.Location = new System.Drawing.Point(277, 274);
            this.uiTableLayoutPanelFormControls.Name = "uiTableLayoutPanelFormControls";
            this.uiTableLayoutPanelFormControls.RowCount = 1;
            this.uiTableLayoutPanelFormControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanelFormControls.Size = new System.Drawing.Size(146, 29);
            this.uiTableLayoutPanelFormControls.TabIndex = 2;
            // 
            // uiButtonOK
            // 
            this.uiButtonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButtonOK.Location = new System.Drawing.Point(3, 3);
            this.uiButtonOK.Name = "uiButtonOK";
            this.uiButtonOK.Size = new System.Drawing.Size(67, 23);
            this.uiButtonOK.TabIndex = 0;
            this.uiButtonOK.Text = "OK";
            // 
            // uiButtonCancel
            // 
            this.uiButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButtonCancel.Location = new System.Drawing.Point(76, 3);
            this.uiButtonCancel.Name = "uiButtonCancel";
            this.uiButtonCancel.Size = new System.Drawing.Size(67, 23);
            this.uiButtonCancel.TabIndex = 1;
            this.uiButtonCancel.Text = "Cancel";
            // 
            // uiGroupBoxStartup
            // 
            this.uiGroupBoxStartup.Controls.Add(this.uiCheckBoxAutoStart);
            this.uiGroupBoxStartup.Location = new System.Drawing.Point(12, 12);
            this.uiGroupBoxStartup.Name = "uiGroupBoxStartup";
            this.uiGroupBoxStartup.Size = new System.Drawing.Size(411, 48);
            this.uiGroupBoxStartup.TabIndex = 0;
            this.uiGroupBoxStartup.TabStop = false;
            this.uiGroupBoxStartup.Text = "Start Up";
            // 
            // uiCheckBoxAutoStart
            // 
            this.uiCheckBoxAutoStart.AutoSize = true;
            this.uiCheckBoxAutoStart.Location = new System.Drawing.Point(6, 19);
            this.uiCheckBoxAutoStart.Name = "uiCheckBoxAutoStart";
            this.uiCheckBoxAutoStart.Size = new System.Drawing.Size(187, 17);
            this.uiCheckBoxAutoStart.TabIndex = 0;
            this.uiCheckBoxAutoStart.Text = "Start QuickRun at Windows logon";
            this.uiCheckBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // uiGroupBoxTools
            // 
            this.uiGroupBoxTools.Controls.Add(this.uiListViewTools);
            this.uiGroupBoxTools.Controls.Add(this.uiTableLayoutPanelToolControls);
            this.uiGroupBoxTools.Location = new System.Drawing.Point(12, 66);
            this.uiGroupBoxTools.Name = "uiGroupBoxTools";
            this.uiGroupBoxTools.Size = new System.Drawing.Size(408, 202);
            this.uiGroupBoxTools.TabIndex = 1;
            this.uiGroupBoxTools.TabStop = false;
            this.uiGroupBoxTools.Text = "QuickTools";
            // 
            // uiListViewTools
            // 
            this.uiListViewTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiListViewTools.Location = new System.Drawing.Point(3, 16);
            this.uiListViewTools.Name = "uiListViewTools";
            this.uiListViewTools.Size = new System.Drawing.Size(316, 183);
            this.uiListViewTools.TabIndex = 0;
            this.uiListViewTools.UseCompatibleStateImageBehavior = false;
            // 
            // uiTableLayoutPanelToolControls
            // 
            this.uiTableLayoutPanelToolControls.ColumnCount = 1;
            this.uiTableLayoutPanelToolControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanelToolControls.Controls.Add(this.uiButtonRemove, 0, 2);
            this.uiTableLayoutPanelToolControls.Controls.Add(this.uiButtonEdit, 0, 1);
            this.uiTableLayoutPanelToolControls.Controls.Add(this.uiButtonAdd, 0, 0);
            this.uiTableLayoutPanelToolControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiTableLayoutPanelToolControls.Location = new System.Drawing.Point(319, 16);
            this.uiTableLayoutPanelToolControls.Name = "uiTableLayoutPanelToolControls";
            this.uiTableLayoutPanelToolControls.RowCount = 3;
            this.uiTableLayoutPanelToolControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiTableLayoutPanelToolControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiTableLayoutPanelToolControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiTableLayoutPanelToolControls.Size = new System.Drawing.Size(86, 183);
            this.uiTableLayoutPanelToolControls.TabIndex = 1;
            // 
            // uiButtonRemove
            // 
            this.uiButtonRemove.Enabled = false;
            this.uiButtonRemove.Location = new System.Drawing.Point(3, 61);
            this.uiButtonRemove.Name = "uiButtonRemove";
            this.uiButtonRemove.Size = new System.Drawing.Size(80, 23);
            this.uiButtonRemove.TabIndex = 2;
            this.uiButtonRemove.Text = "Remove Tool";
            this.uiButtonRemove.UseVisualStyleBackColor = true;
            // 
            // uiButtonEdit
            // 
            this.uiButtonEdit.Enabled = false;
            this.uiButtonEdit.Location = new System.Drawing.Point(3, 32);
            this.uiButtonEdit.Name = "uiButtonEdit";
            this.uiButtonEdit.Size = new System.Drawing.Size(80, 23);
            this.uiButtonEdit.TabIndex = 1;
            this.uiButtonEdit.Text = "Edit Tool...";
            this.uiButtonEdit.UseVisualStyleBackColor = true;
            // 
            // uiButtonAdd
            // 
            this.uiButtonAdd.Location = new System.Drawing.Point(3, 3);
            this.uiButtonAdd.Name = "uiButtonAdd";
            this.uiButtonAdd.Size = new System.Drawing.Size(80, 23);
            this.uiButtonAdd.TabIndex = 0;
            this.uiButtonAdd.Text = "Add Tool...";
            this.uiButtonAdd.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.uiButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uiButtonCancel;
            this.ClientSize = new System.Drawing.Size(435, 315);
            this.Controls.Add(this.uiTableLayoutPanelFormControls);
            this.Controls.Add(this.uiGroupBoxStartup);
            this.Controls.Add(this.uiGroupBoxTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            this.uiTableLayoutPanelFormControls.ResumeLayout(false);
            this.uiGroupBoxStartup.ResumeLayout(false);
            this.uiGroupBoxStartup.PerformLayout();
            this.uiGroupBoxTools.ResumeLayout(false);
            this.uiTableLayoutPanelToolControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel uiTableLayoutPanelFormControls;
        internal System.Windows.Forms.Button uiButtonOK;
        internal System.Windows.Forms.Button uiButtonCancel;
        internal System.Windows.Forms.GroupBox uiGroupBoxStartup;
        internal System.Windows.Forms.CheckBox uiCheckBoxAutoStart;
        internal System.Windows.Forms.GroupBox uiGroupBoxTools;
        internal System.Windows.Forms.ListView uiListViewTools;
        internal System.Windows.Forms.TableLayoutPanel uiTableLayoutPanelToolControls;
        internal System.Windows.Forms.Button uiButtonRemove;
        internal System.Windows.Forms.Button uiButtonEdit;
        internal System.Windows.Forms.Button uiButtonAdd;
    }
}