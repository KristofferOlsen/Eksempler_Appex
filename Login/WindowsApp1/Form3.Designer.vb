<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuValg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEndrePassord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShoutout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoggUt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHjelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblHilsen = New System.Windows.Forms.Label()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuValg, Me.mnuHjelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(428, 24)
        Me.mnuStrip.TabIndex = 1
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuValg
        '
        Me.mnuValg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEndrePassord, Me.mnuShoutout, Me.mnuLoggUt})
        Me.mnuValg.Name = "mnuValg"
        Me.mnuValg.Size = New System.Drawing.Size(41, 20)
        Me.mnuValg.Text = "Valg"
        '
        'mnuEndrePassord
        '
        Me.mnuEndrePassord.Name = "mnuEndrePassord"
        Me.mnuEndrePassord.Size = New System.Drawing.Size(148, 22)
        Me.mnuEndrePassord.Text = "Endre passord"
        '
        'mnuShoutout
        '
        Me.mnuShoutout.Name = "mnuShoutout"
        Me.mnuShoutout.Size = New System.Drawing.Size(148, 22)
        Me.mnuShoutout.Text = "Shoutout"
        '
        'mnuLoggUt
        '
        Me.mnuLoggUt.Name = "mnuLoggUt"
        Me.mnuLoggUt.Size = New System.Drawing.Size(148, 22)
        Me.mnuLoggUt.Text = "Logg ut"
        '
        'mnuHjelp
        '
        Me.mnuHjelp.Name = "mnuHjelp"
        Me.mnuHjelp.Size = New System.Drawing.Size(47, 20)
        Me.mnuHjelp.Text = "Hjelp"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 37)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(149, 123)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Ingenting spesielt her, desverre."
        '
        'lblHilsen
        '
        Me.lblHilsen.AutoSize = True
        Me.lblHilsen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHilsen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHilsen.Location = New System.Drawing.Point(12, 318)
        Me.lblHilsen.Name = "lblHilsen"
        Me.lblHilsen.Size = New System.Drawing.Size(158, 13)
        Me.lblHilsen.TabIndex = 3
        Me.lblHilsen.Text = "Mvh Kristoffer the greatest"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(428, 340)
        Me.Controls.Add(Me.lblHilsen)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.mnuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuValg As ToolStripMenuItem
    Friend WithEvents mnuEndrePassord As ToolStripMenuItem
    Friend WithEvents mnuShoutout As ToolStripMenuItem
    Friend WithEvents mnuLoggUt As ToolStripMenuItem
    Friend WithEvents mnuHjelp As ToolStripMenuItem
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblHilsen As Label
End Class
