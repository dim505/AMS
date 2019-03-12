Imports System.ComponentModel

Public Class Main_Menu


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Course_RegistrationBTNMM.Click
        'shows Course_Registration form
        Course_Registration.Show()
        'hides main form 
        Me.Hide()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ReportBTN.Click
        'shows report form
        Reports.Show()
        'hides main form
        Me.Hide()
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles AddStuTeaCourBTN.Click
        'shows Add_Course_Teacher_Student form
        Add_Course_Teacher_Student.Show()
        'hides main form
        Me.Hide()


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles UpStuTeachCourBTN.Click
        'shows Update_Student_Teacher_Course_Info form
        Update_Student_Teacher_Course_Info.Show()
        'hides main form
        Me.Hide()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles CourseHistory_GPALookUpBTN.Click
        'shows GPA_Academic_History_Look_Up form
        GPA_Academic_History_Look_Up.Show()
        'hides main form
        Me.Hide()
    End Sub

    Private Sub MMExitBtn_Click(sender As Object, e As EventArgs) Handles MMExitBtn.Click
        'gracfully closes the application
        Application.Exit()

    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Main_Menu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class
