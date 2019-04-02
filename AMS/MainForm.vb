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

        If (GlobalVariables.Role = "Regular User") Then


            AddStuTeaCourBTN.BackgroundImage = Nothing
            AddStuTeaCourBTN.Font = Nothing
            AddStuTeaCourBTN.Text = "Add Student/Teacher/Course (DISABLED)"
            AddStuTeaCourBTN.Font = New Font("Microsoft Sans Serif", 13.8, FontStyle.Regular)
            AddStuTeaCourBTN.Enabled = False

            UpStuTeachCourBTN.BackgroundImage = Nothing
            UpStuTeachCourBTN.Font = Nothing
            UpStuTeachCourBTN.Text = "Update Student/Teacher/Course (DISABLED)"
            UpStuTeachCourBTN.Font = New Font("Microsoft Sans Serif", 13.8, FontStyle.Regular)
            UpStuTeachCourBTN.Enabled = False

            CourseHistory_GPALookUpBTN.BackgroundImage = Nothing
            CourseHistory_GPALookUpBTN.Font = Nothing
            CourseHistory_GPALookUpBTN.Text = "Course History/GPA Look Up (DISABLED)"
            CourseHistory_GPALookUpBTN.Font = New Font("Microsoft Sans Serif", 13.8, FontStyle.Regular)
            CourseHistory_GPALookUpBTN.Enabled = False


            UserMaintToolStripMenuItem.Enabled = False


        End If
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

        AddUserFrm.ShowDialog()

    End Sub



    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        DelUsrFrm.ShowDialog()
    End Sub


End Class
