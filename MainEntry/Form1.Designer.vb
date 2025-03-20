<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblWel = New System.Windows.Forms.Label()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.lblDep = New System.Windows.Forms.Label()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWel
        '
        Me.lblWel.AutoSize = True
        Me.lblWel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWel.Location = New System.Drawing.Point(383, 38)
        Me.lblWel.Name = "lblWel"
        Me.lblWel.Size = New System.Drawing.Size(400, 25)
        Me.lblWel.TabIndex = 0
        Me.lblWel.Text = "WELCOME TO UENR VOTING SYSTEM"
        Me.lblWel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSign
        '
        Me.btnSign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSign.Location = New System.Drawing.Point(494, 573)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(173, 77)
        Me.btnSign.TabIndex = 1
        Me.btnSign.Text = "SIGN IN"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(150, 180)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(342, 339)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 3
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(693, 180)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(342, 339)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 4
        Me.pic2.TabStop = False
        '
        'lblDep
        '
        Me.lblDep.AutoSize = True
        Me.lblDep.Location = New System.Drawing.Point(256, 79)
        Me.lblDep.Name = "lblDep"
        Me.lblDep.Size = New System.Drawing.Size(763, 25)
        Me.lblDep.TabIndex = 6
        Me.lblDep.Text = "DEPARTMENT OF INFORMATION TECHNOLOGY AND DECISION SCIENCES"
        Me.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1193, 686)
        Me.Controls.Add(Me.lblDep)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.lblWel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "WELCOME PAGE"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWel As Label
    Friend WithEvents btnSign As Button
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents lblDep As Label
End Class
