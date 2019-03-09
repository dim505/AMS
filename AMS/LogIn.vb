Imports System.Data.OleDb

Public Class LogIn

    Private Sub LoginCancelBTN_Click(sender As Object, e As EventArgs) Handles LoginCancelBTN.Click
        'gracfully closes the application
        Application.Exit()
    End Sub

    Private Sub LogInBtn_Click_1(sender As Object, e As EventArgs) Handles LogInBtn.Click








        'sets sql command that will be exicuted against DB 


        SQLCommand.CommandText = "select * from LogInCreds where UserName = @username and Password = @password"
        SQLCommand.Parameters.AddWithValue("@username", LogInUserTxtBox.Text)
        SQLCommand.Parameters.AddWithValue("@password", LoginPassTxtBox.Text)





        'declares variable for rows affected after Query is run
        Dim rowsAffected As Integer = 0


        'exicutes the query and returns the number of rows affected


        'rowsAffected = SQLCommand.ExecuteNonQuery()




        Dim reader As OleDbDataReader = SQLCommand.ExecuteReader()




        'if the returned value is greater than or equal to 1, it notifies the user that registration was successful, else it failed
        If (reader.HasRows) Then

            MsgBox("Login Secuessfull")
            Me.Hide()


        Else
            MsgBox("Invalid Username or Password")
        End If

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call sub to start the DB connection 
        StartDBConnection()
    End Sub

    Private Sub LogInUserTxtBox_TextChanged(sender As Object, e As EventArgs) Handles LogInUserTxtBox.TextChanged

    End Sub

    Private Sub LoginPassTxtBox_TextChanged(sender As Object, e As EventArgs) Handles LoginPassTxtBox.TextChanged

    End Sub
End Class