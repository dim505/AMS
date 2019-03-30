﻿Imports System.Security.Cryptography
Imports System.Text

Public Class AddUserFrm
    Private ReadOnly Utility As Object






    Private Sub AddUsrCreateBtn_Click(sender As Object, e As EventArgs) Handles AddUsrCreateBtn.Click


        'compares password in both text boxes and makes sure they are the same
        'notifes end user, reset password textbox
        If (AddUsrPassTxtbox.Text <> AddUsrCnfirmPassTxt.Text) Then
            MsgBox("Passwords do not match. Please retype your passwords")

            AddUsrPassTxtbox.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()


        End If

        'Gets the generated salt string from function
        Dim GenSaltStr = GenSalt()
        'combines salt with inputted password
        Dim PasswordString = Trim(GenSaltStr) + Trim(AddUsrPassTxtbox.Text)
        'generates password hash and returns it back into a variable
        Dim PassHashStr = GenHash(PasswordString)

        'declares string for SQL query and assigns Query value
        Dim AddUserQuery As String = "INSERT INTO LogInCreds (UserName, Password, salt) values (" & "'" & AddUsrTxtbx.Text & "','" & PassHashStr & "','" & GenSaltStr & "'" & " )"

        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = AddUserQuery

        'declares variable for rows affected after Query is run
        Dim rowsAffected As Integer = 0

        'exicutes the query and returns the number of rows affected
        rowsAffected = SQLCommand.ExecuteNonQuery()


        'test to see if sql query was exicuted properly
        If (rowsAffected > 0) Then
            MsgBox("User was registered successfully")
            'loops through and clears all textboxes after the entity is registered 
            AddUsrPassTxtbox.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()


        Else
            'notfies user and clears out the password textbox

            MsgBox("User registerion failed!!")

            AddUsrPassTxtbox.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()


        End If








    End Sub

    Private Sub AddUsrCancelBtn_Click(sender As Object, e As EventArgs) Handles AddUsrCancelBtn.Click
        'closes current form
        Me.Close()

    End Sub

End Class