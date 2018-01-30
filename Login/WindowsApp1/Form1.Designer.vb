<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuAvslutt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHjelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBrukernavn = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.mnuStrip.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAvslutt, Me.mnuHjelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(206, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuAvslutt
        '
        Me.mnuAvslutt.Name = "mnuAvslutt"
        Me.mnuAvslutt.Size = New System.Drawing.Size(56, 20)
        Me.mnuAvslutt.Text = "Avslutt"
        '
        'mnuHjelp
        '
        Me.mnuHjelp.Name = "mnuHjelp"
        Me.mnuHjelp.Size = New System.Drawing.Size(47, 20)
        Me.mnuHjelp.Text = "Hjelp"
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.AutoSize = True
        Me.lblBrukernavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrukernavn.Location = New System.Drawing.Point(37, 15)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(100, 20)
        Me.lblBrukernavn.TabIndex = 1
        Me.lblBrukernavn.Text = "Brukernavn"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Location = New System.Drawing.Point(38, 47)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(100, 20)
        Me.txtBrukernavn.TabIndex = 2
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassord.Location = New System.Drawing.Point(37, 79)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(74, 20)
        Me.lblPassord.TabIndex = 3
        Me.lblPassord.Text = "Passord"
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(37, 111)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(100, 20)
        Me.txtPassord.TabIndex = 4
        Me.txtPassord.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(38, 137)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.lblBrukernavn)
        Me.Panel.Controls.Add(Me.btnLogin)
        Me.Panel.Controls.Add(Me.txtBrukernavn)
        Me.Panel.Controls.Add(Me.txtPassord)
        Me.Panel.Controls.Add(Me.lblPassord)
        Me.Panel.Location = New System.Drawing.Point(12, 36)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(182, 181)
        Me.Panel.TabIndex = 6
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(206, 229)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.mnuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(222, 268)
        Me.MinimumSize = New System.Drawing.Size(222, 268)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents lblBrukernavn As Label
    Friend WithEvents txtBrukernavn As TextBox
    Friend WithEvents lblPassord As Label
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents mnuHjelp As ToolStripMenuItem
    Friend WithEvents Panel As Panel
    Friend WithEvents mnuAvslutt As ToolStripMenuItem
End Class
