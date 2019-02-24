Public Class Course_Registration
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Course_Registation_BTN.Click




        Dim RegisterStudentWithCourseQuery As String = ""


        RegisterStudentWithCourseQuery = "INSERT INTO CourseRegistration$(StudentID, CourseID) " &
        "VALUES(" & "'" & CRStuIDTxtBox.Text & "','" & CRCourseIDtxtBox.Text & "','" & "')"








        SQLCommand.CommandText = RegisterStudentWithCourseQuery


        Dim rowsAffected As Integer = 0
        rowsAffected = SQLCommand.ExecuteNonQuery()


        If (rowsAffected > 0) Then
            MsgBox("Student was successfully added to the Course")
        Else
            MsgBox("Student adding failed!!")
        End If




    End Sub

    Private Sub Course_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Main_Menu.Show()


    End Sub
End Class