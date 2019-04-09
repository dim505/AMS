<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserFrm
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
        Me.AddUsrTxtbx = New System.Windows.Forms.MaskedTextBox()
        Me.AddUsrCnfirmPassTxt = New System.Windows.Forms.MaskedTextBox()
        Me.AddUsrPassTxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.AddUsrCreateBtn = New System.Windows.Forms.Button()
        Me.AddUsrCancelBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddUsrRoleCmbx = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'AddUsrTxtbx
        '
        Me.AddUsrTxtbx.Location = New System.Drawing.Point(140, 13)
        Me.AddUsrTxtbx.Name = "AddUsrTxtbx"
        Me.AddUsrTxtbx.Size = New System.Drawing.Size(161, 22)
        Me.AddUsrTxtbx.TabIndex = 0
        '
        'AddUsrCnfirmPassTxt
        '
        Me.AddUsrCnfirmPassTxt.Location = New System.Drawing.Point(140, 125)
        Me.AddUsrCnfirmPassTxt.Name = "AddUsrCnfirmPassTxt"
        Me.AddUsrCnfirmPassTxt.Size = New System.Drawing.Size(161, 22)
        Me.AddUsrCnfirmPassTxt.TabIndex = 3
        Me.AddUsrCnfirmPassTxt.UseSystemPasswordChar = True
        '
        'AddUsrPassTxtbox
        '
        Me.AddUsrPassTxtbox.Location = New System.Drawing.Point(140, 69)
        Me.AddUsrPassTxtbox.Name = "AddUsrPassTxtbox"
        Me.AddUsrPassTxtbox.Size = New System.Drawing.Size(161, 22)
        Me.AddUsrPassTxtbox.TabIndex = 2
        Me.AddUsrPassTxtbox.UseSystemPasswordChar = True
        '
        'AddUsrCreateBtn
        '
        Me.AddUsrCreateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUsrCreateBtn.Location = New System.Drawing.Point(25, 224)
        Me.AddUsrCreateBtn.Name = "AddUsrCreateBtn"
        Me.AddUsrCreateBtn.Size = New System.Drawing.Size(151, 83)
        Me.AddUsrCreateBtn.TabIndex = 5
        Me.AddUsrCreateBtn.Text = "Create"
        Me.AddUsrCreateBtn.UseVisualStyleBackColor = True
        '
        'AddUsrCancelBtn
        '
        Me.AddUsrCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUsrCancelBtn.Location = New System.Drawing.Point(182, 224)
        Me.AddUsrCancelBtn.Name = "AddUsrCancelBtn"
        Me.AddUsrCancelBtn.Size = New System.Drawing.Size(137, 83)
        Me.AddUsrCancelBtn.TabIndex = 6
        Me.AddUsrCancelBtn.Text = "Cancel"
        Me.AddUsrCancelBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 47)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 68)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Confirm Password"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Role"
        '
        'AddUsrRoleCmbx
        '
        Me.AddUsrRoleCmbx.FormattingEnabled = True
        Me.AddUsrRoleCmbx.Location = New System.Drawing.Point(140, 183)
        Me.AddUsrRoleCmbx.Name = "AddUsrRoleCmbx"
        Me.AddUsrRoleCmbx.Size = New System.Drawing.Size(161, 24)
        Me.AddUsrRoleCmbx.TabIndex = 4
        '
        'AddUserFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 329)
        Me.Controls.Add(Me.AddUsrRoleCmbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddUsrCancelBtn)
        Me.Controls.Add(Me.AddUsrCreateBtn)
        Me.Controls.Add(Me.AddUsrPassTxtbox)
        Me.Controls.Add(Me.AddUsrCnfirmPassTxt)
        Me.Controls.Add(Me.AddUsrTxtbx)
        Me.Name = "AddUserFrm"
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddUsrTxtbx As MaskedTextBox
    Friend WithEvents AddUsrCnfirmPassTxt As MaskedTextBox
    Friend WithEvents AddUsrPassTxtbox As MaskedTextBox
    Friend WithEvents AddUsrCreateBtn As Button
    Friend WithEvents AddUsrCancelBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AddUsrRoleCmbx As ComboBox
End Class
