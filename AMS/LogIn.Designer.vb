<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginCancelBTN = New System.Windows.Forms.Button()
        Me.LogInBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogInUserTxtBox = New System.Windows.Forms.TextBox()
        Me.LoginPassTxtBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(399, 385)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoginCancelBTN
        '
        Me.LoginCancelBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginCancelBTN.Location = New System.Drawing.Point(674, 331)
        Me.LoginCancelBTN.Name = "LoginCancelBTN"
        Me.LoginCancelBTN.Size = New System.Drawing.Size(196, 91)
        Me.LoginCancelBTN.TabIndex = 4
        Me.LoginCancelBTN.Text = "Cancel"
        Me.LoginCancelBTN.UseVisualStyleBackColor = True
        '
        'LogInBtn
        '
        Me.LogInBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInBtn.Location = New System.Drawing.Point(438, 331)
        Me.LogInBtn.Name = "LogInBtn"
        Me.LogInBtn.Size = New System.Drawing.Size(190, 91)
        Me.LogInBtn.TabIndex = 5
        Me.LogInBtn.Text = "Log In"
        Me.LogInBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(417, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'LogInUserTxtBox
        '
        Me.LogInUserTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInUserTxtBox.Location = New System.Drawing.Point(624, 109)
        Me.LogInUserTxtBox.Name = "LogInUserTxtBox"
        Me.LogInUserTxtBox.Size = New System.Drawing.Size(223, 38)
        Me.LogInUserTxtBox.TabIndex = 8
        '
        'LoginPassTxtBox
        '
        Me.LoginPassTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPassTxtBox.Location = New System.Drawing.Point(624, 184)
        Me.LoginPassTxtBox.Name = "LoginPassTxtBox"
        Me.LoginPassTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPassTxtBox.Size = New System.Drawing.Size(223, 38)
        Me.LoginPassTxtBox.TabIndex = 9
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 466)
        Me.Controls.Add(Me.LoginPassTxtBox)
        Me.Controls.Add(Me.LogInUserTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogInBtn)
        Me.Controls.Add(Me.LoginCancelBTN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "LogIn"
        Me.Text = "Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginCancelBTN As Button
    Friend WithEvents LogInBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogInUserTxtBox As TextBox
    Friend WithEvents LoginPassTxtBox As TextBox
End Class
