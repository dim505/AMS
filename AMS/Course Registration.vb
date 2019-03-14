Public Class Course_Registration


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Course_Registation_BTN.Click



        'declares string for SQL query and assigns Query value
        Dim RegisterStudentWithCourseQuery As String = "INSERT INTO CourseRegistration$(StudentID, CourseID) " &
        "VALUES(" & "'" & CRStuIDTxtBox.Text & "','" & CRCourseIDtxtBox.Text & "')"







        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RegisterStudentWithCourseQuery

        'declares value for rows affected after Query is run
        Dim rowsAffected As Integer = 0

        'exicutes the query and returns the number of rows affected
        rowsAffected = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than 1, it notifies user that registration was successful, else it failed
        If (rowsAffected > 0) Then
            MsgBox("Student was successfully added to the Course")
        Else
            MsgBox("Student adding failed!!")
        End If




    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'takes you back to Main Menu
        Main_Menu.Show()
        'closes current form
        Me.Close()



    End Sub


End Class