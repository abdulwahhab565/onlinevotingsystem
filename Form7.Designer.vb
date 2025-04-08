<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        btnUpdatePasswords = New Button()
        btnClose = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnUpdatePasswords
        ' 
        btnUpdatePasswords.BackColor = Color.Green
        btnUpdatePasswords.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdatePasswords.ForeColor = Color.White
        btnUpdatePasswords.Location = New Point(55, 65)
        btnUpdatePasswords.Name = "btnUpdatePasswords"
        btnUpdatePasswords.Size = New Size(184, 31)
        btnUpdatePasswords.TabIndex = 0
        btnUpdatePasswords.Text = "UPDATE PASSWORD"
        btnUpdatePasswords.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(121, 121)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 30)
        btnClose.TabIndex = 1
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(74, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 19)
        Label1.TabIndex = 2
        Label1.Text = "HASH PASSWORD"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(316, 203)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        Controls.Add(btnUpdatePasswords)
        Name = "Form7"
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUpdatePasswords As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
End Class
