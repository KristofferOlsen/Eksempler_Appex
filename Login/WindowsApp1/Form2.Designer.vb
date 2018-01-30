<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndrePassord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndrePassord))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnEndre = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.txtGammeltPassord = New System.Windows.Forms.TextBox()
        Me.txtNyttPassord = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(16, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(164, 71)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Skriv inn gammelt passord"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(20, 226)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(66, 23)
        Me.btnAvbryt.TabIndex = 1
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'btnEndre
        '
        Me.btnEndre.Location = New System.Drawing.Point(102, 226)
        Me.btnEndre.Name = "btnEndre"
        Me.btnEndre.Size = New System.Drawing.Size(65, 23)
        Me.btnEndre.TabIndex = 2
        Me.btnEndre.Text = "Endre"
        Me.btnEndre.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.btnEndre)
        Me.Panel.Controls.Add(Me.txtNyttPassord)
        Me.Panel.Controls.Add(Me.btnAvbryt)
        Me.Panel.Controls.Add(Me.txtGammeltPassord)
        Me.Panel.Controls.Add(Me.lblHeader)
        Me.Panel.Location = New System.Drawing.Point(12, 12)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(191, 270)
        Me.Panel.TabIndex = 3
        '
        'txtGammeltPassord
        '
        Me.txtGammeltPassord.Location = New System.Drawing.Point(20, 86)
        Me.txtGammeltPassord.Name = "txtGammeltPassord"
        Me.txtGammeltPassord.Size = New System.Drawing.Size(147, 20)
        Me.txtGammeltPassord.TabIndex = 4
        '
        'txtNyttPassord
        '
        Me.txtNyttPassord.Location = New System.Drawing.Point(20, 193)
        Me.txtNyttPassord.Name = "txtNyttPassord"
        Me.txtNyttPassord.Size = New System.Drawing.Size(147, 20)
        Me.txtNyttPassord.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 71)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Skriv inn nytt passord"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEndrePassord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(215, 294)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEndrePassord"
        Me.Text = "Endring"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnAvbryt As Button
    Friend WithEvents btnEndre As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents txtGammeltPassord As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNyttPassord As TextBox
End Class
