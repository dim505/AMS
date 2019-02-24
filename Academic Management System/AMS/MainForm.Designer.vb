<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Course_RegistrationBTNMM = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CourseHistory_GPALookUpBTN = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 108)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add Student/Teacher/Course"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Course_RegistrationBTNMM
        '
        Me.Course_RegistrationBTNMM.Location = New System.Drawing.Point(418, 39)
        Me.Course_RegistrationBTNMM.Name = "Course_RegistrationBTNMM"
        Me.Course_RegistrationBTNMM.Size = New System.Drawing.Size(195, 108)
        Me.Course_RegistrationBTNMM.TabIndex = 3
        Me.Course_RegistrationBTNMM.Text = "Course Registration"
        Me.Course_RegistrationBTNMM.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(660, 39)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(204, 108)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Update Student/Teacher/Course"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CourseHistory_GPALookUpBTN
        '
        Me.CourseHistory_GPALookUpBTN.Location = New System.Drawing.Point(144, 200)
        Me.CourseHistory_GPALookUpBTN.Name = "CourseHistory_GPALookUpBTN"
        Me.CourseHistory_GPALookUpBTN.Size = New System.Drawing.Size(153, 108)
        Me.CourseHistory_GPALookUpBTN.TabIndex = 5
        Me.CourseHistory_GPALookUpBTN.Text = "Course History/GPA Look Up"
        Me.CourseHistory_GPALookUpBTN.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(711, 200)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(153, 108)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Schdule Look Up"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(518, 200)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(153, 108)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Schdule Look Up"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(326, 200)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(153, 108)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Transcript Look Up"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 492)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.CourseHistory_GPALookUpBTN)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Course_RegistrationBTNMM)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Course_RegistrationBTNMM As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents CourseHistory_GPALookUpBTN As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
End Class
