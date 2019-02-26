<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course_Registration
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
        Me.CRStuIDTxtBox = New System.Windows.Forms.TextBox()
        Me.Course_Registation_BTN = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CRCourseIDtxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CRStuIDTxtBox
        '
        Me.CRStuIDTxtBox.Location = New System.Drawing.Point(444, 79)
        Me.CRStuIDTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CRStuIDTxtBox.Name = "CRStuIDTxtBox"
        Me.CRStuIDTxtBox.Size = New System.Drawing.Size(259, 22)
        Me.CRStuIDTxtBox.TabIndex = 133
        '
        'Course_Registation_BTN
        '
        Me.Course_Registation_BTN.Location = New System.Drawing.Point(233, 313)
        Me.Course_Registation_BTN.Name = "Course_Registation_BTN"
        Me.Course_Registation_BTN.Size = New System.Drawing.Size(376, 55)
        Me.Course_Registation_BTN.TabIndex = 131
        Me.Course_Registation_BTN.Text = "Register"
        Me.Course_Registation_BTN.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(650, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(376, 55)
        Me.Button2.TabIndex = 144
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CRCourseIDtxtBox
        '
        Me.CRCourseIDtxtBox.Location = New System.Drawing.Point(444, 122)
        Me.CRCourseIDtxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CRCourseIDtxtBox.Name = "CRCourseIDtxtBox"
        Me.CRCourseIDtxtBox.Size = New System.Drawing.Size(217, 22)
        Me.CRCourseIDtxtBox.TabIndex = 141
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 25)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Course ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Student ID"
        '
        'Course_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 504)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CRCourseIDtxtBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CRStuIDTxtBox)
        Me.Controls.Add(Me.Course_Registation_BTN)
        Me.Name = "Course_Registration"
        Me.Text = "Course_Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRStuIDTxtBox As TextBox
    Friend WithEvents Course_Registation_BTN As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CRCourseIDtxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
