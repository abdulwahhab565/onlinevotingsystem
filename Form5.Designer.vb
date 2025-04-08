<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label4 = New Label()
        Label6 = New Label()
        Label13 = New Label()
        btnClose = New Button()
        lvResults = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        lblPresWinner = New Label()
        lblSecWinner = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(153, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 19)
        Label1.TabIndex = 0
        Label1.Text = "ELECTION RESULTS"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(101, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 5
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(303, 184)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 15)
        Label13.TabIndex = 12
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnClose.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(205, 357)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 32)
        btnClose.TabIndex = 18
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lvResults
        ' 
        lvResults.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        lvResults.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvResults.Location = New Point(12, 54)
        lvResults.Name = "lvResults"
        lvResults.Size = New Size(467, 216)
        lvResults.TabIndex = 21
        lvResults.UseCompatibleStateImageBehavior = False
        lvResults.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Candidate Name"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Vote Count"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 100
        ' 
        ' lblPresWinner
        ' 
        lblPresWinner.AutoSize = True
        lblPresWinner.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPresWinner.ForeColor = Color.Green
        lblPresWinner.Location = New Point(12, 294)
        lblPresWinner.Name = "lblPresWinner"
        lblPresWinner.Size = New Size(143, 17)
        lblPresWinner.TabIndex = 22
        lblPresWinner.Text = "Presidential Winner:"
        ' 
        ' lblSecWinner
        ' 
        lblSecWinner.AutoSize = True
        lblSecWinner.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSecWinner.ForeColor = Color.Green
        lblSecWinner.Location = New Point(12, 327)
        lblSecWinner.Name = "lblSecWinner"
        lblSecWinner.Size = New Size(189, 17)
        lblSecWinner.TabIndex = 23
        lblSecWinner.Text = "Financial Secretary Winner:"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(491, 401)
        Controls.Add(lblSecWinner)
        Controls.Add(lblPresWinner)
        Controls.Add(lvResults)
        Controls.Add(btnClose)
        Controls.Add(Label13)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "ELECTION RESULTS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lvResults As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lblPresWinner As Label
    Friend WithEvents lblSecWinner As Label
End Class
