Imports System.ComponentModel

Public Class Main_Menu


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Course_RegistrationBTNMM.Click
        'shows Course_Registration form
        Course_Registration.Show()
        'closes main form 
        Me.Close()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ReportBTN.Click
        'shows report form
        Reports.Show()
        'closes main form
        Me.Close()
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles AddStuTeaCourBTN.Click
        'shows Add_Course_Teacher_Student form
        Add_Course_Teacher_Student.Show()
        'closes main form
        Me.Close()


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles UpStuTeachCourBTN.Click
        'shows Update_Student_Teacher_Course_Info form
        Update_Student_Teacher_Course_Info.Show()
        'closes main form
        Me.Close()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles CourseHistory_GPALookUpBTN.Click
        'shows GPA_Academic_History_Look_Up form
        GPA_Academic_History_Look_Up.Show()
        'closes main form
        Me.Close()
    End Sub

    Private Sub MMExitBtn_Click(sender As Object, e As EventArgs) Handles MMExitBtn.Click
        'gracfully closes the application
        Application.Exit()

    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'test to see if current user logged in is a regular user 
        If (GlobalVariables.Role = "Regular User") Then

            'remove BTN background image 
            AddStuTeaCourBTN.BackgroundImage = Nothing
            'clears font 
            AddStuTeaCourBTN.Font = Nothing
            'sets btn text
            AddStuTeaCourBTN.Text = "Add Student/Teacher/Course (DISABLED)"
            'sets few font rules
            AddStuTeaCourBTN.Font = New Font("Microsoft Sans Serif", 13.8, FontStyle.Regular)
            'disables button 
            AddStuTeaCourBTN.Enabled = False


            'remove BTN background image 
            UpStuTeachCourBTN.BackgroundImage = Nothing
            'clears font 
            UpStuTeachCourBTN.Font = Nothing
            'sets btn text
            UpStuTeachCourBTN.Text = "Update Student/Teacher/Course (DISABLED)"
            'sets few font rules
            UpStuTeachCourBTN.Font = New Font("Microsoft Sans Serif", 13.8, FontStyle.Regular)
            'disables button 
            UpStuTeachCourBTN.Enabled = False


            'remove BTN background image 
            CourseHistory_GPALookUpBTN.BackgroundImage = Nothing
            'clears font 
            CourseHistory_GPALookUpBTN.Font = Nothing
            'sets btn text
            CourseHistory_GPALookUpBTN.Text = "Course History/GPA Look Up (DISABLED)"
            'sets few font rules
            CourseHistory_GPALookUpBTN.Font = New Font("Microsoft Sans Serif", 13.8, FontStyle.Regular)
            'disables button 
            CourseHistory_GPALookUpBTN.Enabled = False

            'disables menu 
            UserMaintToolStripMenuItem.Enabled = False


        End If
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        'SHOWS add user form when delete user sub menu is clicked 
        AddUserFrm.ShowDialog()

    End Sub



    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        'SHOWS del user form when delete user sub menu is clicked 
        DelUsrFrm.ShowDialog()
    End Sub


End Class
