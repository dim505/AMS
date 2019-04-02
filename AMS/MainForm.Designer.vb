<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AddStuTeaCourBTN = New System.Windows.Forms.Button()
        Me.Course_RegistrationBTNMM = New System.Windows.Forms.Button()
        Me.UpStuTeachCourBTN = New System.Windows.Forms.Button()
        Me.CourseHistory_GPALookUpBTN = New System.Windows.Forms.Button()
        Me.ReportBTN = New System.Windows.Forms.Button()
        Me.MMExitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MMPanel = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserMaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MMPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddStuTeaCourBTN
        '
        Me.AddStuTeaCourBTN.BackgroundImage = Global.AMS.My.Resources.Resources.ADD
        Me.AddStuTeaCourBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddStuTeaCourBTN.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStuTeaCourBTN.Location = New System.Drawing.Point(33, 30)
        Me.AddStuTeaCourBTN.Name = "AddStuTeaCourBTN"
        Me.AddStuTeaCourBTN.Size = New System.Drawing.Size(272, 165)
        Me.AddStuTeaCourBTN.TabIndex = 1
        Me.AddStuTeaCourBTN.Text = "Add Student/Teacher/Course"
        Me.AddStuTeaCourBTN.UseVisualStyleBackColor = True
        '
        'Course_RegistrationBTNMM
        '
        Me.Course_RegistrationBTNMM.BackgroundImage = Global.AMS.My.Resources.Resources.Registration
        Me.Course_RegistrationBTNMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Course_RegistrationBTNMM.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Course_RegistrationBTNMM.Location = New System.Drawing.Point(311, 202)
        Me.Course_RegistrationBTNMM.Name = "Course_RegistrationBTNMM"
        Me.Course_RegistrationBTNMM.Size = New System.Drawing.Size(214, 155)
        Me.Course_RegistrationBTNMM.TabIndex = 3
        Me.Course_RegistrationBTNMM.Text = "Course Registration"
        Me.Course_RegistrationBTNMM.UseVisualStyleBackColor = True
        '
        'UpStuTeachCourBTN
        '
        Me.UpStuTeachCourBTN.BackgroundImage = Global.AMS.My.Resources.Resources.update
        Me.UpStuTeachCourBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpStuTeachCourBTN.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.UpStuTeachCourBTN.Location = New System.Drawing.Point(531, 30)
        Me.UpStuTeachCourBTN.Name = "UpStuTeachCourBTN"
        Me.UpStuTeachCourBTN.Size = New System.Drawing.Size(239, 165)
        Me.UpStuTeachCourBTN.TabIndex = 4
        Me.UpStuTeachCourBTN.Text = "Update Student/Teacher/Course"
        Me.UpStuTeachCourBTN.UseVisualStyleBackColor = True
        '
        'CourseHistory_GPALookUpBTN
        '
        Me.CourseHistory_GPALookUpBTN.BackgroundImage = Global.AMS.My.Resources.Resources.GPA
        Me.CourseHistory_GPALookUpBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CourseHistory_GPALookUpBTN.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CourseHistory_GPALookUpBTN.Location = New System.Drawing.Point(33, 202)
        Me.CourseHistory_GPALookUpBTN.Name = "CourseHistory_GPALookUpBTN"
        Me.CourseHistory_GPALookUpBTN.Size = New System.Drawing.Size(272, 155)
        Me.CourseHistory_GPALookUpBTN.TabIndex = 5
        Me.CourseHistory_GPALookUpBTN.Text = "Course History/GPA Look Up"
        Me.CourseHistory_GPALookUpBTN.UseVisualStyleBackColor = True
        '
        'ReportBTN
        '
        Me.ReportBTN.BackgroundImage = Global.AMS.My.Resources.Resources.mis_report
        Me.ReportBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReportBTN.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ReportBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportBTN.Location = New System.Drawing.Point(311, 31)
        Me.ReportBTN.Name = "ReportBTN"
        Me.ReportBTN.Size = New System.Drawing.Size(214, 165)
        Me.ReportBTN.TabIndex = 10
        Me.ReportBTN.Text = "Reports"
        Me.ReportBTN.UseVisualStyleBackColor = True
        '
        'MMExitBtn
        '
        Me.MMExitBtn.BackgroundImage = Global.AMS.My.Resources.Resources._exit1
        Me.MMExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MMExitBtn.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.MMExitBtn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.MMExitBtn.Location = New System.Drawing.Point(531, 202)
        Me.MMExitBtn.Name = "MMExitBtn"
        Me.MMExitBtn.Size = New System.Drawing.Size(239, 155)
        Me.MMExitBtn.TabIndex = 11
        Me.MMExitBtn.Text = "Exit"
        Me.MMExitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(110, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(873, 69)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Academic Management System"
        '
        'MMPanel
        '
        Me.MMPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.MMPanel.Controls.Add(Me.AddStuTeaCourBTN)
        Me.MMPanel.Controls.Add(Me.Course_RegistrationBTNMM)
        Me.MMPanel.Controls.Add(Me.MMExitBtn)
        Me.MMPanel.Controls.Add(Me.UpStuTeachCourBTN)
        Me.MMPanel.Controls.Add(Me.ReportBTN)
        Me.MMPanel.Controls.Add(Me.CourseHistory_GPALookUpBTN)
        Me.MMPanel.Location = New System.Drawing.Point(122, 106)
        Me.MMPanel.Name = "MMPanel"
        Me.MMPanel.Size = New System.Drawing.Size(861, 383)
        Me.MMPanel.TabIndex = 13
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMaintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1039, 28)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserMaintToolStripMenuItem
        '
        Me.UserMaintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem})
        Me.UserMaintToolStripMenuItem.Name = "UserMaintToolStripMenuItem"
        Me.UserMaintToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.UserMaintToolStripMenuItem.Text = "User Maint."
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 506)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MMPanel)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        Me.MMPanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddStuTeaCourBTN As Button
    Friend WithEvents Course_RegistrationBTNMM As Button
    Friend WithEvents UpStuTeachCourBTN As Button
    Friend WithEvents CourseHistory_GPALookUpBTN As Button
    Friend WithEvents ReportBTN As Button
    Friend WithEvents MMExitBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MMPanel As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserMaintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
End Class
