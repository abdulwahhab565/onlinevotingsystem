<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lvVoters = New Label()
        btnAddCandidate = New Button()
        btnEditCandidate = New Button()
        btnDeleteCandidate = New Button()
        btnLogout = New Button()
        txtName = New TextBox()
        cmbPosition = New ComboBox()
        lvCandidates = New ListView()
        lvVoter = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(208, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 19)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN DASHBOARD"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(21, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 17)
        Label2.TabIndex = 1
        Label2.Text = "MANAGE CANDIDATE :"
        ' 
        ' lvVoters
        ' 
        lvVoters.AutoSize = True
        lvVoters.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lvVoters.ForeColor = Color.Green
        lvVoters.Location = New Point(21, 336)
        lvVoters.Name = "lvVoters"
        lvVoters.Size = New Size(143, 17)
        lvVoters.TabIndex = 2
        lvVoters.Text = "MANAGE VOTER :"
        ' 
        ' btnAddCandidate
        ' 
        btnAddCandidate.BackColor = Color.Green
        btnAddCandidate.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCandidate.ForeColor = Color.White
        btnAddCandidate.Location = New Point(229, 94)
        btnAddCandidate.Name = "btnAddCandidate"
        btnAddCandidate.Size = New Size(50, 38)
        btnAddCandidate.TabIndex = 4
        btnAddCandidate.Text = "ADD"
        btnAddCandidate.UseVisualStyleBackColor = False
        ' 
        ' btnEditCandidate
        ' 
        btnEditCandidate.BackColor = Color.Green
        btnEditCandidate.Font = New Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditCandidate.ForeColor = Color.White
        btnEditCandidate.Location = New Point(295, 94)
        btnEditCandidate.Name = "btnEditCandidate"
        btnEditCandidate.Size = New Size(75, 38)
        btnEditCandidate.TabIndex = 5
        btnEditCandidate.Text = "EDIT"
        btnEditCandidate.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCandidate
        ' 
        btnDeleteCandidate.BackColor = Color.Green
        btnDeleteCandidate.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteCandidate.ForeColor = Color.White
        btnDeleteCandidate.Location = New Point(393, 94)
        btnDeleteCandidate.Name = "btnDeleteCandidate"
        btnDeleteCandidate.Size = New Size(75, 37)
        btnDeleteCandidate.TabIndex = 6
        btnDeleteCandidate.Text = "DELETE"
        btnDeleteCandidate.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Green
        btnLogout.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(254, 493)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(93, 34)
        btnLogout.TabIndex = 9
        btnLogout.Text = "LOG OUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(208, 58)
        txtName.Name = "txtName"
        txtName.Size = New Size(179, 23)
        txtName.TabIndex = 10
        ' 
        ' cmbPosition
        ' 
        cmbPosition.FormattingEnabled = True
        cmbPosition.Location = New Point(408, 59)
        cmbPosition.Name = "cmbPosition"
        cmbPosition.Size = New Size(152, 23)
        cmbPosition.TabIndex = 11
        ' 
        ' lvCandidates
        ' 
        lvCandidates.FullRowSelect = True
        lvCandidates.Location = New Point(21, 148)
        lvCandidates.MultiSelect = False
        lvCandidates.Name = "lvCandidates"
        lvCandidates.Size = New Size(539, 160)
        lvCandidates.TabIndex = 12
        lvCandidates.UseCompatibleStateImageBehavior = False
        ' 
        ' lvVoter
        ' 
        lvVoter.FullRowSelect = True
        lvVoter.Location = New Point(21, 371)
        lvVoter.MultiSelect = False
        lvVoter.Name = "lvVoter"
        lvVoter.Size = New Size(539, 116)
        lvVoter.TabIndex = 13
        lvVoter.UseCompatibleStateImageBehavior = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(586, 539)
        Controls.Add(lvVoter)
        Controls.Add(lvCandidates)
        Controls.Add(cmbPosition)
        Controls.Add(txtName)
        Controls.Add(btnLogout)
        Controls.Add(btnDeleteCandidate)
        Controls.Add(btnEditCandidate)
        Controls.Add(btnAddCandidate)
        Controls.Add(lvVoters)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "ADMIN DASHBOARD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvVoters As Label
    Friend WithEvents btnAddCandidate As Button
    Friend WithEvents btnEditCandidate As Button
    Friend WithEvents btnDeleteCandidate As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents lvCandidates As ListView
    Friend WithEvents lvVoter As ListView
End Class
