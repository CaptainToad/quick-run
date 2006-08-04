<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RunCommand
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
        Me.uiTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.uiButtonBrowse = New System.Windows.Forms.Button
        Me.uiButtonOK = New System.Windows.Forms.Button
        Me.uiButtonCancel = New System.Windows.Forms.Button
        Me.uiPictureBox = New System.Windows.Forms.PictureBox
        Me.uiLabel = New System.Windows.Forms.Label
        Me.uiLabelOpen = New System.Windows.Forms.Label
        Me.uiTextBoxCommand = New System.Windows.Forms.TextBox
        Me.uiOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.uiTableLayoutPanel.SuspendLayout()
        CType(Me.uiPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uiTableLayoutPanel
        '
        Me.uiTableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uiTableLayoutPanel.ColumnCount = 3
        Me.uiTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.uiTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.uiTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.uiTableLayoutPanel.Controls.Add(Me.uiButtonBrowse, 2, 0)
        Me.uiTableLayoutPanel.Controls.Add(Me.uiButtonOK, 0, 0)
        Me.uiTableLayoutPanel.Controls.Add(Me.uiButtonCancel, 1, 0)
        Me.uiTableLayoutPanel.Location = New System.Drawing.Point(75, 112)
        Me.uiTableLayoutPanel.Name = "uiTableLayoutPanel"
        Me.uiTableLayoutPanel.RowCount = 1
        Me.uiTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.uiTableLayoutPanel.Size = New System.Drawing.Size(257, 29)
        Me.uiTableLayoutPanel.TabIndex = 3
        '
        'uiButtonBrowse
        '
        Me.uiButtonBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uiButtonBrowse.Location = New System.Drawing.Point(171, 3)
        Me.uiButtonBrowse.Name = "uiButtonBrowse"
        Me.uiButtonBrowse.Size = New System.Drawing.Size(83, 23)
        Me.uiButtonBrowse.TabIndex = 2
        Me.uiButtonBrowse.Text = "&Browse..."
        '
        'uiButtonOK
        '
        Me.uiButtonOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uiButtonOK.Location = New System.Drawing.Point(3, 3)
        Me.uiButtonOK.Name = "uiButtonOK"
        Me.uiButtonOK.Size = New System.Drawing.Size(78, 23)
        Me.uiButtonOK.TabIndex = 0
        Me.uiButtonOK.Text = "OK"
        '
        'uiButtonCancel
        '
        Me.uiButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.uiButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uiButtonCancel.Location = New System.Drawing.Point(87, 3)
        Me.uiButtonCancel.Name = "uiButtonCancel"
        Me.uiButtonCancel.Size = New System.Drawing.Size(78, 23)
        Me.uiButtonCancel.TabIndex = 1
        Me.uiButtonCancel.Text = "Cancel"
        '
        'uiPictureBox
        '
        Me.uiPictureBox.Image = Global.Pantheon.Utilities.My.Resources.Resources.textfield_rename
        Me.uiPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.uiPictureBox.Name = "uiPictureBox"
        Me.uiPictureBox.Size = New System.Drawing.Size(32, 32)
        Me.uiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.uiPictureBox.TabIndex = 1
        Me.uiPictureBox.TabStop = False
        '
        'uiLabel
        '
        Me.uiLabel.Location = New System.Drawing.Point(50, 12)
        Me.uiLabel.Name = "uiLabel"
        Me.uiLabel.Size = New System.Drawing.Size(282, 32)
        Me.uiLabel.TabIndex = 0
        Me.uiLabel.Text = "Type the name of a program, folder, document, or internet resource and QuickRun w" & _
            "ill open it for you."
        '
        'uiLabelOpen
        '
        Me.uiLabelOpen.AutoSize = True
        Me.uiLabelOpen.Location = New System.Drawing.Point(12, 63)
        Me.uiLabelOpen.Name = "uiLabelOpen"
        Me.uiLabelOpen.Size = New System.Drawing.Size(33, 13)
        Me.uiLabelOpen.TabIndex = 1
        Me.uiLabelOpen.Text = "&Open"
        '
        'uiTextBoxCommand
        '
        Me.uiTextBoxCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.uiTextBoxCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.uiTextBoxCommand.Location = New System.Drawing.Point(53, 63)
        Me.uiTextBoxCommand.Name = "uiTextBoxCommand"
        Me.uiTextBoxCommand.Size = New System.Drawing.Size(279, 20)
        Me.uiTextBoxCommand.TabIndex = 2
        '
        'uiOpenFileDialog
        '
        Me.uiOpenFileDialog.Filter = "Programs|*.exe;*.bat;*.cmd;*.pif;*.com|All files|*.*"
        Me.uiOpenFileDialog.Title = "Open File"
        '
        'Run
        '
        Me.AcceptButton = Me.uiButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.uiButtonCancel
        Me.ClientSize = New System.Drawing.Size(344, 153)
        Me.Controls.Add(Me.uiTextBoxCommand)
        Me.Controls.Add(Me.uiLabelOpen)
        Me.Controls.Add(Me.uiLabel)
        Me.Controls.Add(Me.uiPictureBox)
        Me.Controls.Add(Me.uiTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Run"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Run"
        Me.uiTableLayoutPanel.ResumeLayout(False)
        CType(Me.uiPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uiTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents uiButtonOK As System.Windows.Forms.Button
    Friend WithEvents uiButtonCancel As System.Windows.Forms.Button
    Friend WithEvents uiButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents uiPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents uiLabel As System.Windows.Forms.Label
    Friend WithEvents uiLabelOpen As System.Windows.Forms.Label
    Friend WithEvents uiTextBoxCommand As System.Windows.Forms.TextBox
    Friend WithEvents uiOpenFileDialog As System.Windows.Forms.OpenFileDialog

End Class
