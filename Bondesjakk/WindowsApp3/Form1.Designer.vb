<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicTacToe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicTacToe))
        Me.btnNyRunde = New System.Windows.Forms.Button()
        Me.lblOverskrift = New System.Windows.Forms.Label()
        Me.lblRute1 = New System.Windows.Forms.Label()
        Me.lblRute2 = New System.Windows.Forms.Label()
        Me.lblRute3 = New System.Windows.Forms.Label()
        Me.lblRute6 = New System.Windows.Forms.Label()
        Me.lblRute7 = New System.Windows.Forms.Label()
        Me.lblRute8 = New System.Windows.Forms.Label()
        Me.lblRute5 = New System.Windows.Forms.Label()
        Me.lblRute4 = New System.Windows.Forms.Label()
        Me.lblRute9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuValg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShoutout = New System.Windows.Forms.ToolStripMenuItem()
        Me.RandomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAvslutt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHjelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNyRunde
        '
        Me.btnNyRunde.Location = New System.Drawing.Point(80, 227)
        Me.btnNyRunde.Name = "btnNyRunde"
        Me.btnNyRunde.Size = New System.Drawing.Size(75, 30)
        Me.btnNyRunde.TabIndex = 0
        Me.btnNyRunde.Text = "Ny Runde"
        Me.btnNyRunde.UseVisualStyleBackColor = True
        '
        'lblOverskrift
        '
        Me.lblOverskrift.AutoSize = True
        Me.lblOverskrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverskrift.Location = New System.Drawing.Point(48, 34)
        Me.lblOverskrift.Name = "lblOverskrift"
        Me.lblOverskrift.Size = New System.Drawing.Size(134, 25)
        Me.lblOverskrift.TabIndex = 2
        Me.lblOverskrift.Text = "Bondesjakk"
        '
        'lblRute1
        '
        Me.lblRute1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute1.Location = New System.Drawing.Point(8, 9)
        Me.lblRute1.Name = "lblRute1"
        Me.lblRute1.Size = New System.Drawing.Size(40, 40)
        Me.lblRute1.TabIndex = 3
        '
        'lblRute2
        '
        Me.lblRute2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute2.Location = New System.Drawing.Point(54, 9)
        Me.lblRute2.Name = "lblRute2"
        Me.lblRute2.Size = New System.Drawing.Size(40, 40)
        Me.lblRute2.TabIndex = 4
        '
        'lblRute3
        '
        Me.lblRute3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute3.Location = New System.Drawing.Point(100, 9)
        Me.lblRute3.Name = "lblRute3"
        Me.lblRute3.Size = New System.Drawing.Size(40, 40)
        Me.lblRute3.TabIndex = 5
        '
        'lblRute6
        '
        Me.lblRute6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute6.Location = New System.Drawing.Point(100, 55)
        Me.lblRute6.Name = "lblRute6"
        Me.lblRute6.Size = New System.Drawing.Size(40, 40)
        Me.lblRute6.TabIndex = 6
        '
        'lblRute7
        '
        Me.lblRute7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute7.Location = New System.Drawing.Point(8, 101)
        Me.lblRute7.Name = "lblRute7"
        Me.lblRute7.Size = New System.Drawing.Size(40, 40)
        Me.lblRute7.TabIndex = 7
        '
        'lblRute8
        '
        Me.lblRute8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute8.Location = New System.Drawing.Point(54, 101)
        Me.lblRute8.Name = "lblRute8"
        Me.lblRute8.Size = New System.Drawing.Size(40, 40)
        Me.lblRute8.TabIndex = 8
        '
        'lblRute5
        '
        Me.lblRute5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute5.Location = New System.Drawing.Point(54, 55)
        Me.lblRute5.Name = "lblRute5"
        Me.lblRute5.Size = New System.Drawing.Size(40, 40)
        Me.lblRute5.TabIndex = 9
        '
        'lblRute4
        '
        Me.lblRute4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute4.Location = New System.Drawing.Point(8, 55)
        Me.lblRute4.Name = "lblRute4"
        Me.lblRute4.Size = New System.Drawing.Size(40, 40)
        Me.lblRute4.TabIndex = 10
        '
        'lblRute9
        '
        Me.lblRute9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRute9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRute9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRute9.Location = New System.Drawing.Point(100, 101)
        Me.lblRute9.Name = "lblRute9"
        Me.lblRute9.Size = New System.Drawing.Size(40, 40)
        Me.lblRute9.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblRute2)
        Me.Panel1.Controls.Add(Me.lblRute9)
        Me.Panel1.Controls.Add(Me.lblRute1)
        Me.Panel1.Controls.Add(Me.lblRute4)
        Me.Panel1.Controls.Add(Me.lblRute3)
        Me.Panel1.Controls.Add(Me.lblRute5)
        Me.Panel1.Controls.Add(Me.lblRute6)
        Me.Panel1.Controls.Add(Me.lblRute8)
        Me.Panel1.Controls.Add(Me.lblRute7)
        Me.Panel1.Location = New System.Drawing.Point(41, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 150)
        Me.Panel1.TabIndex = 12
        '
        'mnuStrip
        '
        Me.mnuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuValg, Me.mnuHjelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(237, 24)
        Me.mnuStrip.TabIndex = 13
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuValg
        '
        Me.mnuValg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShoutout, Me.RandomToolStripMenuItem, Me.mnuAvslutt})
        Me.mnuValg.Name = "mnuValg"
        Me.mnuValg.Size = New System.Drawing.Size(41, 20)
        Me.mnuValg.Text = "Valg"
        '
        'mnuShoutout
        '
        Me.mnuShoutout.Name = "mnuShoutout"
        Me.mnuShoutout.Size = New System.Drawing.Size(123, 22)
        Me.mnuShoutout.Text = "Shoutout"
        '
        'RandomToolStripMenuItem
        '
        Me.RandomToolStripMenuItem.Name = "RandomToolStripMenuItem"
        Me.RandomToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.RandomToolStripMenuItem.Text = "Random"
        '
        'mnuAvslutt
        '
        Me.mnuAvslutt.Name = "mnuAvslutt"
        Me.mnuAvslutt.Size = New System.Drawing.Size(123, 22)
        Me.mnuAvslutt.Text = "Avslutt"
        '
        'mnuHjelp
        '
        Me.mnuHjelp.Name = "mnuHjelp"
        Me.mnuHjelp.Size = New System.Drawing.Size(47, 20)
        Me.mnuHjelp.Text = "Hjelp"
        '
        'frmTicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(237, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblOverskrift)
        Me.Controls.Add(Me.btnNyRunde)
        Me.Controls.Add(Me.mnuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(253, 300)
        Me.MinimumSize = New System.Drawing.Size(253, 300)
        Me.Name = "frmTicTacToe"
        Me.Text = "Bondesjakk"
        Me.Panel1.ResumeLayout(False)
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNyRunde As Button
    Friend WithEvents lblOverskrift As Label
    Friend WithEvents lblRute1 As Label
    Friend WithEvents lblRute2 As Label
    Friend WithEvents lblRute3 As Label
    Friend WithEvents lblRute6 As Label
    Friend WithEvents lblRute7 As Label
    Friend WithEvents lblRute8 As Label
    Friend WithEvents lblRute5 As Label
    Friend WithEvents lblRute4 As Label
    Friend WithEvents lblRute9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuValg As ToolStripMenuItem
    Friend WithEvents mnuShoutout As ToolStripMenuItem
    Friend WithEvents mnuAvslutt As ToolStripMenuItem
    Friend WithEvents RandomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHjelp As ToolStripMenuItem
End Class
