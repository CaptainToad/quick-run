<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.uiTableLayoutPanelFormControls = New System.Windows.Forms.TableLayoutPanel
        Me.uiButtonOK = New System.Windows.Forms.Button
        Me.uiButtonCancel = New System.Windows.Forms.Button
        Me.uiGroupBoxStartup = New System.Windows.Forms.GroupBox
        Me.uiCheckBoxAutoStart = New System.Windows.Forms.CheckBox
        Me.uiGroupBoxTools = New System.Windows.Forms.GroupBox
        Me.uiListViewTools = New System.Windows.Forms.ListView
        Me.uiTableLayoutPanelToolControls = New System.Windows.Forms.TableLayoutPanel
        Me.uiButtonRemove = New System.Windows.Forms.Button
        Me.uiButtonEdit = New System.Windows.Forms.Button
        Me.uiButtonAdd = New System.Windows.Forms.Button
        Me.uiTableLayoutPanelFormControls.SuspendLayout()
        Me.uiGroupBoxStartup.SuspendLayout()
        Me.uiGroupBoxTools.SuspendLayout()
        Me.uiTableLayoutPanelToolControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'uiTableLayoutPanelFormControls
        '
        Me.uiTableLayoutPanelFormControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uiTableLayoutPanelFormControls.ColumnCount = 2
        Me.uiTableLayoutPanelFormControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.uiTableLayoutPanelFormControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.uiTableLayoutPanelFormControls.Controls.Add(Me.uiButtonOK, 0, 0)
        Me.uiTableLayoutPanelFormControls.Controls.Add(Me.uiButtonCancel, 1, 0)
        Me.uiTableLayoutPanelFormControls.Location = New System.Drawing.Point(277, 274)
        Me.uiTableLayoutPanelFormControls.Name = "uiTableLayoutPanelFormControls"
        Me.uiTableLayoutPanelFormControls.RowCount = 1
        Me.uiTableLayoutPanelFormControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.uiTableLayoutPanelFormControls.Size = New System.Drawing.Size(146, 29)
        Me.uiTableLayoutPanelFormControls.TabIndex = 0
        '
        'uiButtonOK
        '
        Me.uiButtonOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.uiButtonOK.Location = New System.Drawing.Point(3, 3)
        Me.uiButtonOK.Name = "uiButtonOK"
        Me.uiButtonOK.Size = New System.Drawing.Size(67, 23)
        Me.uiButtonOK.TabIndex = 0
        Me.uiButtonOK.Text = "OK"
        '
        'uiButtonCancel
        '
        Me.uiButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.uiButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.uiButtonCancel.Location = New System.Drawing.Point(76, 3)
        Me.uiButtonCancel.Name = "uiButtonCancel"
        Me.uiButtonCancel.Size = New System.Drawing.Size(67, 23)
        Me.uiButtonCancel.TabIndex = 1
        Me.uiButtonCancel.Text = "Cancel"
        '
        'uiGroupBoxStartup
        '
        Me.uiGroupBoxStartup.Controls.Add(Me.uiCheckBoxAutoStart)
        Me.uiGroupBoxStartup.Location = New System.Drawing.Point(12, 12)
        Me.uiGroupBoxStartup.Name = "uiGroupBoxStartup"
        Me.uiGroupBoxStartup.Size = New System.Drawing.Size(411, 48)
        Me.uiGroupBoxStartup.TabIndex = 1
        Me.uiGroupBoxStartup.TabStop = False
        Me.uiGroupBoxStartup.Text = "Start Up"
        '
        'uiCheckBoxAutoStart
        '
        Me.uiCheckBoxAutoStart.AutoSize = True
        Me.uiCheckBoxAutoStart.Location = New System.Drawing.Point(6, 19)
        Me.uiCheckBoxAutoStart.Name = "uiCheckBoxAutoStart"
        Me.uiCheckBoxAutoStart.Size = New System.Drawing.Size(187, 17)
        Me.uiCheckBoxAutoStart.TabIndex = 0
        Me.uiCheckBoxAutoStart.Text = "Start QuickRun at Windows logon"
        Me.uiCheckBoxAutoStart.UseVisualStyleBackColor = True
        '
        'uiGroupBoxTools
        '
        Me.uiGroupBoxTools.Controls.Add(Me.uiListViewTools)
        Me.uiGroupBoxTools.Controls.Add(Me.uiTableLayoutPanelToolControls)
        Me.uiGroupBoxTools.Location = New System.Drawing.Point(12, 66)
        Me.uiGroupBoxTools.Name = "uiGroupBoxTools"
        Me.uiGroupBoxTools.Size = New System.Drawing.Size(408, 202)
        Me.uiGroupBoxTools.TabIndex = 2
        Me.uiGroupBoxTools.TabStop = False
        Me.uiGroupBoxTools.Text = "QuickTools"
        '
        'uiListViewTools
        '
        Me.uiListViewTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uiListViewTools.Location = New System.Drawing.Point(3, 16)
        Me.uiListViewTools.Name = "uiListViewTools"
        Me.uiListViewTools.Size = New System.Drawing.Size(316, 183)
        Me.uiListViewTools.TabIndex = 1
        Me.uiListViewTools.UseCompatibleStateImageBehavior = False
        '
        'uiTableLayoutPanelToolControls
        '
        Me.uiTableLayoutPanelToolControls.ColumnCount = 1
        Me.uiTableLayoutPanelToolControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.uiTableLayoutPanelToolControls.Controls.Add(Me.uiButtonRemove, 0, 2)
        Me.uiTableLayoutPanelToolControls.Controls.Add(Me.uiButtonEdit, 0, 1)
        Me.uiTableLayoutPanelToolControls.Controls.Add(Me.uiButtonAdd, 0, 0)
        Me.uiTableLayoutPanelToolControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.uiTableLayoutPanelToolControls.Location = New System.Drawing.Point(319, 16)
        Me.uiTableLayoutPanelToolControls.Name = "uiTableLayoutPanelToolControls"
        Me.uiTableLayoutPanelToolControls.RowCount = 3
        Me.uiTableLayoutPanelToolControls.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.uiTableLayoutPanelToolControls.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.uiTableLayoutPanelToolControls.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.uiTableLayoutPanelToolControls.Size = New System.Drawing.Size(86, 183)
        Me.uiTableLayoutPanelToolControls.TabIndex = 0
        '
        'uiButtonRemove
        '
        Me.uiButtonRemove.Enabled = False
        Me.uiButtonRemove.Location = New System.Drawing.Point(3, 61)
        Me.uiButtonRemove.Name = "uiButtonRemove"
        Me.uiButtonRemove.Size = New System.Drawing.Size(80, 23)
        Me.uiButtonRemove.TabIndex = 1
        Me.uiButtonRemove.Text = "Remove Tool"
        Me.uiButtonRemove.UseVisualStyleBackColor = True
        '
        'uiButtonEdit
        '
        Me.uiButtonEdit.Enabled = False
        Me.uiButtonEdit.Location = New System.Drawing.Point(3, 32)
        Me.uiButtonEdit.Name = "uiButtonEdit"
        Me.uiButtonEdit.Size = New System.Drawing.Size(80, 23)
        Me.uiButtonEdit.TabIndex = 1
        Me.uiButtonEdit.Text = "Edit Tool..."
        Me.uiButtonEdit.UseVisualStyleBackColor = True
        '
        'uiButtonAdd
        '
        Me.uiButtonAdd.Location = New System.Drawing.Point(3, 3)
        Me.uiButtonAdd.Name = "uiButtonAdd"
        Me.uiButtonAdd.Size = New System.Drawing.Size(80, 23)
        Me.uiButtonAdd.TabIndex = 0
        Me.uiButtonAdd.Text = "Add Tool..."
        Me.uiButtonAdd.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AcceptButton = Me.uiButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.uiButtonCancel
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.uiGroupBoxTools)
        Me.Controls.Add(Me.uiGroupBoxStartup)
        Me.Controls.Add(Me.uiTableLayoutPanelFormControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Options"
        Me.uiTableLayoutPanelFormControls.ResumeLayout(False)
        Me.uiGroupBoxStartup.ResumeLayout(False)
        Me.uiGroupBoxStartup.PerformLayout()
        Me.uiGroupBoxTools.ResumeLayout(False)
        Me.uiTableLayoutPanelToolControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uiTableLayoutPanelFormControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents uiButtonOK As System.Windows.Forms.Button
    Friend WithEvents uiButtonCancel As System.Windows.Forms.Button
    Friend WithEvents uiGroupBoxStartup As System.Windows.Forms.GroupBox
    Friend WithEvents uiCheckBoxAutoStart As System.Windows.Forms.CheckBox
    Friend WithEvents uiGroupBoxTools As System.Windows.Forms.GroupBox
    Friend WithEvents uiListViewTools As System.Windows.Forms.ListView
    Friend WithEvents uiTableLayoutPanelToolControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents uiButtonRemove As System.Windows.Forms.Button
    Friend WithEvents uiButtonEdit As System.Windows.Forms.Button
    Friend WithEvents uiButtonAdd As System.Windows.Forms.Button

End Class
