<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnSubmit = New Button()
        Button2 = New Button()
        Button3 = New Button()
        cboPresident = New ComboBox()
        cboFinancialSecretary = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(37, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 19)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO THE VOTER DASHBOARD" & vbCrLf
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(310, 17)
        Label2.TabIndex = 1
        Label2.Text = "SELECT YOUR PREFERRED CANDIDATE:" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(28, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 17)
        Label3.TabIndex = 2
        Label3.Text = "PRESIDENT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(28, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 17)
        Label4.TabIndex = 3
        Label4.Text = "FINANCIAL SECRETARY"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnSubmit.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.Green
        btnSubmit.Location = New Point(28, 251)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(115, 35)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "SUBMIT VOTE"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Green
        Button2.Location = New Point(149, 244)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 48)
        Button2.TabIndex = 5
        Button2.Text = "VIEW RESULTS"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Green
        Button3.Location = New Point(282, 254)
        Button3.Name = "Button3"
        Button3.Size = New Size(89, 29)
        Button3.TabIndex = 6
        Button3.Text = "PREVIOUS"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' cboPresident
        ' 
        cboPresident.FormattingEnabled = True
        cboPresident.Location = New Point(37, 120)
        cboPresident.Name = "cboPresident"
        cboPresident.Size = New Size(294, 23)
        cboPresident.TabIndex = 7
        ' 
        ' cboFinancialSecretary
        ' 
        cboFinancialSecretary.FormattingEnabled = True
        cboFinancialSecretary.Location = New Point(37, 196)
        cboFinancialSecretary.Name = "cboFinancialSecretary"
        cboFinancialSecretary.Size = New Size(294, 23)
        cboFinancialSecretary.TabIndex = 8
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(410, 317)
        Controls.Add(cboFinancialSecretary)
        Controls.Add(cboPresident)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnSubmit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "VOTER DASHBOARD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cboPresident As ComboBox
    Friend WithEvents cboFinancialSecretary As ComboBox
End Class
