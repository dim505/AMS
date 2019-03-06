Public Class Main_Menu


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Course_RegistrationBTNMM.Click
        'hides current form
        Course_Registration.Show()
        'makes main form active 
        Me.Hide()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ReportBTN.Click
        'hides current form
        Reports.Show()
        'makes main form active 
        Me.Hide()
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'hides current form
        Add_Course_Teacher_Student.Show()
        'makes main form active 
        Me.Hide()


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call sub to start the DB connection 
        StartDBConnection()


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        'hides current form
        Update_Student_Teacher_Course_Info.Show()
        'makes main form active 
        Me.Hide()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles CourseHistory_GPALookUpBTN.Click
        'hides current form
        GPA_Academic_History_Look_Up.Show()
        'makes main form active 
        Me.Hide()
    End Sub

    Private Sub MMExitBtn_Click(sender As Object, e As EventArgs) Handles MMExitBtn.Click
        'gracfully closes the application
        Application.Exit()

    End Sub


End Class
