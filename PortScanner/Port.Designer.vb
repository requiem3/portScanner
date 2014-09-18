<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Port
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Port))
        Me.Scan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.StartCB = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StopCB = New System.Windows.Forms.NumericUpDown()
        Me.lbPorts = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.StartCB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StopCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Scan
        '
        Me.Scan.Location = New System.Drawing.Point(28, 164)
        Me.Scan.Name = "Scan"
        Me.Scan.Size = New System.Drawing.Size(100, 25)
        Me.Scan.TabIndex = 0
        Me.Scan.Text = "Scan"
        Me.Scan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Target IP:"
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(12, 49)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(136, 20)
        Me.TB1.TabIndex = 2
        '
        'StartCB
        '
        Me.StartCB.Location = New System.Drawing.Point(73, 98)
        Me.StartCB.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.StartCB.Name = "StartCB"
        Me.StartCB.Size = New System.Drawing.Size(55, 20)
        Me.StartCB.TabIndex = 3
        Me.StartCB.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Start at:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Stop at:"
        '
        'StopCB
        '
        Me.StopCB.Location = New System.Drawing.Point(73, 124)
        Me.StopCB.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.StopCB.Name = "StopCB"
        Me.StopCB.Size = New System.Drawing.Size(55, 20)
        Me.StopCB.TabIndex = 6
        Me.StopCB.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'lbPorts
        '
        Me.lbPorts.FormattingEnabled = True
        Me.lbPorts.Location = New System.Drawing.Point(154, 33)
        Me.lbPorts.Name = "lbPorts"
        Me.lbPorts.Size = New System.Drawing.Size(193, 173)
        Me.lbPorts.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 212)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(336, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Port
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 240)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbPorts)
        Me.Controls.Add(Me.StopCB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StartCB)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Scan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Port"
        Me.Text = "Port Scanner"
        CType(Me.StartCB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StopCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Scan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB1 As System.Windows.Forms.TextBox
    Friend WithEvents StartCB As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StopCB As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbPorts As System.Windows.Forms.ListBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
