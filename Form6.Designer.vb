<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtAdminID = New TextBox()
        txtAdminPassword = New TextBox()
        btnAdminLogin = New Button()
        btnClose = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(118, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(20, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 17)
        Label1.TabIndex = 1
        Label1.Text = "ADMIN ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(20, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 17)
        Label2.TabIndex = 2
        Label2.Text = "PASSWORD"
        ' 
        ' txtAdminID
        ' 
        txtAdminID.Location = New Point(20, 151)
        txtAdminID.Name = "txtAdminID"
        txtAdminID.Size = New Size(270, 23)
        txtAdminID.TabIndex = 3
        ' 
        ' txtAdminPassword
        ' 
        txtAdminPassword.Location = New Point(20, 225)
        txtAdminPassword.Name = "txtAdminPassword"
        txtAdminPassword.Size = New Size(270, 23)
        txtAdminPassword.TabIndex = 4
        txtAdminPassword.UseSystemPasswordChar = True
        ' 
        ' btnAdminLogin
        ' 
        btnAdminLogin.BackColor = Color.Green
        btnAdminLogin.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdminLogin.ForeColor = Color.White
        btnAdminLogin.Location = New Point(53, 275)
        btnAdminLogin.Name = "btnAdminLogin"
        btnAdminLogin.Size = New Size(75, 31)
        btnAdminLogin.TabIndex = 5
        btnAdminLogin.Text = "LOGIN"
        btnAdminLogin.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(172, 275)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 31)
        btnClose.TabIndex = 6
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(326, 342)
        Controls.Add(btnClose)
        Controls.Add(btnAdminLogin)
        Controls.Add(txtAdminPassword)
        Controls.Add(txtAdminID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form6"
        Text = "ADMIN LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdminID As TextBox
    Friend WithEvents txtAdminPassword As TextBox
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents btnClose As Button
End Class
