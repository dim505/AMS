Imports System.Security.Cryptography
Imports System.Text

Public Class AddUserFrm
    Private ReadOnly Utility As Object

    ''Combine these 2 functions into a class 

    Public Function GenSalt() As String
        Dim SaltGen = New RNGCryptoServiceProvider()
        Dim SaltSize = 24
        Dim SaltSizeByte(SaltSize) As Byte

        SaltGen.GetNonZeroBytes(SaltSizeByte)

        Dim GensaltString = Utility.GetString(SaltSizeByte)
        Return GensaltString




    End Function



    Public Function GenHash(PasswordString As String) As String
        'declares the hash generator
        Dim HashGenerator As SHA256 = SHA256Managed.Create()
        'converts password string to btyes --needed before computing the hash
        Dim PasswordBytes = System.Text.Encoding.Unicode.GetBytes(PasswordString)
        'generates the hash
        Dim GeneratedHash = HashGenerator.ComputeHash(PasswordBytes)
        'declares StringBuilder instance
        Dim stringBuilder As New StringBuilder
        'loops through and builds the string from the byte hash 
        For i As Integer = 0 To GeneratedHash.Length - 1
            stringBuilder.Append(GeneratedHash(i).ToString("X2"))
        Next
        'returns the password string
        Return stringBuilder.ToString()

    End Function






    Private Sub AddUsrCreateBtn_Click(sender As Object, e As EventArgs) Handles AddUsrCreateBtn.Click









        If (AddUsrPassTxtbox.Text <> AddUsrCnfirmPassTxt.Text) Then
            MsgBox("Passwords do not match. Please retype your passwords")

            AddUsrPassTxtbox.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()


        End If


        Dim GenSaltStr = GenSalt()
        Dim PasswordString = Trim(GenSaltStr) + Trim(AddUsrPassTxtbox.Text)
        Dim PassHashStr = GenHash(PasswordString)

        'declares string for SQL query and assigns Query value
        Dim AddUserQuery As String = "INSERT INTO LogInCreds (UserName, Password, salt) 
        values (" & "'" & AddUsrTxtbx.Text & "','" & " '" & AddUsrPassTxtbox.Text & "','" & PassHashStr & "','" & " ')"

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