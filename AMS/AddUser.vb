Public Class AddUserFrm
    Private Sub AddUsrCreateBtn_Click(sender As Object, e As EventArgs) Handles AddUsrCreateBtn.Click

        If (AddUsrPassTxtbox.Text <> AddUsrCnfirmPassTxt.Text) Then
            MsgBox("Passwords do not match. Please retype your passwords")

            AddUsrPassTxtbox.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()




        End If




        'declares string for SQL query and assigns Query value
        Dim AddUserQuery As String = ''




        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = AddUserQuery



        'declares variable for rows affected after Query is run
        Dim rowsAffected As Integer = 0




        'exicutes the query and returns the number of rows affected
        rowsAffected = SQLCommand.ExecuteNonQuery()


        If (rowsAffected > 0) Then
            MsgBox("User was registered successfully")
            'loops through and clears all textboxes after the entity is registered 


        Else
            MsgBox("User registerion failed!!")

            AddUsrPassTxtbox.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()


        End If








    End Sub

    Private Sub AddUsrCancelBtn_Click(sender As Object, e As EventArgs) Handles AddUsrCancelBtn.Click
        Me.Close()

    End Sub
End Class