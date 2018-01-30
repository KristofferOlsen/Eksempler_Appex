<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKalkis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKalkis))
        Me.txtFelt1 = New System.Windows.Forms.TextBox()
        Me.btnPluss = New System.Windows.Forms.Button()
        Me.txtFelt2 = New System.Windows.Forms.TextBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuValg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShoutout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAvslutt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHjelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFelt1
        '
        Me.txtFelt1.Location = New System.Drawing.Point(46, 3)
        Me.txtFelt1.Name = "txtFelt1"
        Me.txtFelt1.Size = New System.Drawing.Size(100, 20)
        Me.txtFelt1.TabIndex = 0
        '
        'btnPluss
        '
        Me.btnPluss.Location = New System.Drawing.Point(46, 29)
        Me.btnPluss.Name = "btnPluss"
        Me.btnPluss.Size = New System.Drawing.Size(20, 20)
        Me.btnPluss.TabIndex = 1
        Me.btnPluss.Text = "+"
        Me.btnPluss.UseVisualStyleBackColor = True
        '
        'txtFelt2
        '
        Me.txtFelt2.Location = New System.Drawing.Point(46, 55)
        Me.txtFelt2.Name = "txtFelt2"
        Me.txtFelt2.Size = New System.Drawing.Size(100, 20)
        Me.txtFelt2.TabIndex = 5
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(72, 29)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(20, 20)
        Me.btnMinus.TabIndex = 2
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(126, 29)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(20, 20)
        Me.btnTimes.TabIndex = 4
        Me.btnTimes.Text = "X"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(100, 29)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(20, 20)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'lblEqual
        '
        Me.lblEqual.AutoSize = True
        Me.lblEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqual.Location = New System.Drawing.Point(86, 78)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(18, 20)
        Me.lblEqual.TabIndex = 6
        Me.lblEqual.Text = "="
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(20, 98)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(158, 56)
        Me.lblAnswer.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 157)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMain.Controls.Add(Me.btnRandom)
        Me.pnlMain.Controls.Add(Me.txtFelt1)
        Me.pnlMain.Controls.Add(Me.btnPluss)
        Me.pnlMain.Controls.Add(Me.btnClear)
        Me.pnlMain.Controls.Add(Me.txtFelt2)
        Me.pnlMain.Controls.Add(Me.lblAnswer)
        Me.pnlMain.Controls.Add(Me.btnMinus)
        Me.pnlMain.Controls.Add(Me.lblEqual)
        Me.pnlMain.Controls.Add(Me.btnTimes)
        Me.pnlMain.Controls.Add(Me.btnDivide)
        Me.pnlMain.Location = New System.Drawing.Point(12, 34)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(200, 185)
        Me.pnlMain.TabIndex = 9
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(3, 157)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(75, 23)
        Me.btnRandom.TabIndex = 8
        Me.btnRandom.Text = "Random"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'mnuStrip
        '
        Me.mnuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuValg, Me.mnuHjelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(224, 24)
        Me.mnuStrip.TabIndex = 10
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuValg
        '
        Me.mnuValg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShoutout, Me.mnuAvslutt})
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
        'frmKalkis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(224, 231)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.mnuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(240, 270)
        Me.MinimumSize = New System.Drawing.Size(240, 270)
        Me.Name = "frmKalkis"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Kalkis"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFelt1 As TextBox
    Friend WithEvents btnPluss As Button
    Friend WithEvents txtFelt2 As TextBox
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnTimes As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents lblEqual As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuValg As ToolStripMenuItem
    Friend WithEvents mnuAvslutt As ToolStripMenuItem
    Friend WithEvents mnuShoutout As ToolStripMenuItem
    Friend WithEvents btnRandom As Button
    Friend WithEvents mnuHjelp As ToolStripMenuItem
End Class
