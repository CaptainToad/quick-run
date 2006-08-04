<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrayIcon
    Inherits System.Windows.Forms.ApplicationContext

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrayIcon))
        Me.uiNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.uiContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.uiToolStripMenuItemSep1 = New System.Windows.Forms.ToolStripSeparator
        Me.uiToolStripMenuItemSep2 = New System.Windows.Forms.ToolStripSeparator
        Me.uiToolStripMenuItemSep3 = New System.Windows.Forms.ToolStripSeparator
        Me.uiExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uiQuickRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uiRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uiOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uiAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uiContextMenuStrip.SuspendLayout()
        '
        'uiNotifyIcon
        '
        Me.uiNotifyIcon.ContextMenuStrip = Me.uiContextMenuStrip
        Me.uiNotifyIcon.Icon = CType(resources.GetObject("uiNotifyIcon.Icon"), System.Drawing.Icon)
        Me.uiNotifyIcon.Text = "QuickRun"
        Me.uiNotifyIcon.Visible = True
        '
        'uiContextMenuStrip
        '
        Me.uiContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uiQuickRunToolStripMenuItem, Me.uiRunToolStripMenuItem, Me.uiToolStripMenuItemSep1, Me.uiOptionsToolStripMenuItem, Me.uiToolStripMenuItemSep2, Me.uiAboutToolStripMenuItem, Me.uiToolStripMenuItemSep3, Me.uiExitToolStripMenuItem})
        Me.uiContextMenuStrip.Name = "uiContextMenuStrip"
        Me.uiContextMenuStrip.Size = New System.Drawing.Size(146, 98)
        '
        'uiToolStripMenuItemSep1
        '
        Me.uiToolStripMenuItemSep1.Name = "uiToolStripMenuItemSep1"
        Me.uiToolStripMenuItemSep1.Size = New System.Drawing.Size(142, 6)
        '
        'uiToolStripMenuItemSep2
        '
        Me.uiToolStripMenuItemSep2.Name = "uiToolStripMenuItemSep2"
        Me.uiToolStripMenuItemSep2.Size = New System.Drawing.Size(142, 6)
        '
        'uiToolStripMenuItemSep3
        '
        Me.uiToolStripMenuItemSep3.Name = "uiToolStripMenuItemSep3"
        Me.uiToolStripMenuItemSep3.Size = New System.Drawing.Size(142, 6)
        '
        'uiExitToolStripMenuItem
        '
        Me.uiExitToolStripMenuItem.Name = "uiExitToolStripMenuItem"
        Me.uiExitToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.uiExitToolStripMenuItem.Text = "E&xit"
        '
        'uiQuickRunToolStripMenuItem
        '
        Me.uiQuickRunToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uiQuickRunToolStripMenuItem.Image = Global.QuickRun.My.Resources.Resources.lightning
        Me.uiQuickRunToolStripMenuItem.Name = "uiQuickRunToolStripMenuItem"
        Me.uiQuickRunToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.uiQuickRunToolStripMenuItem.Text = "&Quick Run..."
        '
        'uiRunToolStripMenuItem
        '
        Me.uiRunToolStripMenuItem.Image = Global.QuickRun.My.Resources.Resources.application_lightning
        Me.uiRunToolStripMenuItem.Name = "uiRunToolStripMenuItem"
        Me.uiRunToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.uiRunToolStripMenuItem.Text = "&Run..."
        '
        'uiOptionsToolStripMenuItem
        '
        Me.uiOptionsToolStripMenuItem.Image = Global.QuickRun.My.Resources.Resources.database_gear
        Me.uiOptionsToolStripMenuItem.Name = "uiOptionsToolStripMenuItem"
        Me.uiOptionsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.uiOptionsToolStripMenuItem.Text = "&Options"
        '
        'uiAboutToolStripMenuItem
        '
        Me.uiAboutToolStripMenuItem.Image = Global.QuickRun.My.Resources.Resources.help
        Me.uiAboutToolStripMenuItem.Name = "uiAboutToolStripMenuItem"
        Me.uiAboutToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.uiAboutToolStripMenuItem.Text = "&About"
        '
        'TrayIcon
        '
        Me.uiContextMenuStrip.ResumeLayout(False)

    End Sub
    Friend WithEvents uiNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents uiContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents uiQuickRunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uiRunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uiToolStripMenuItemSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uiToolStripMenuItemSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uiToolStripMenuItemSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uiExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uiOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uiAboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
