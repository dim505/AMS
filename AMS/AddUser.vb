Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class AddUserFrm
    Private ReadOnly Utility As Object






    Private Sub AddUsrCreateBtn_Click(sender As Object, e As EventArgs) Handles AddUsrCreateBtn.Click




        'declares SQL Query 
        Dim LookUpUsr As String = "select * from LoginCreds where UserName = " & "'" & AddUsrTxtbx.Text & "';"

        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = LookUpUsr

        ' this combines the sql query with the Connection and builds a OleDbDataReader.
        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()


        If (QueryResults.HasRows) Then
            MsgBox("Please Choose Another Username")
            AddUsrTxtbx.Clear()
            AddUsrTxtbx.Select()
            'closes DB connection and data reader 
            QueryResults.Close()
            Exit Sub

        End If



        'closes DB connection and data reader 
        QueryResults.Close()




        If (String.IsNullOrWhiteSpace(AddUsrTxtbx.Text)) Then

            MsgBox("Please Input a User Name")
            AddUsrTxtbx.Clear()
            AddUsrTxtbx.Select()
            Exit Sub
            'compares password in both text boxes and makes sure they are the same also enforces that both password fields are typed in
            'notifes end user, reset password textbox
        ElseIf (AddUsrPassTxtbox.Text <> AddUsrCnfirmPassTxt.Text Or (String.IsNullOrWhiteSpace(AddUsrPassTxtbox.Text) Or String.IsNullOrWhiteSpace(AddUsrCnfirmPassTxt.Text))) Then
            'alerts user
            MsgBox("Passwords do not match. Please retype your passwords")

            'clears out passwod textboxes
            AddUsrPassTxtbox.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()
            Exit Sub

        ElseIf (AddUsrRoleCmbx.Text = "Select from...") Then
            MsgBox("Please Select A Role")
            AddUsrRoleCmbx.Select()
            Exit Sub


        End If

        'Gets the generated salt string from function
        Dim GenSaltStr = GenSalt()
        'combines salt with inputted password
        Dim PasswordString = Trim(GenSaltStr) + Trim(AddUsrPassTxtbox.Text)
        'generates password hash and returns it back into a variable
        Dim PassHashStr = GenHash(PasswordString)

        'declares string for SQL query and assigns Query value
        Dim AddUserQuery As String = "INSERT INTO LogInCreds values (" & "'" & AddUsrTxtbx.Text & "','" & PassHashStr & "','" & GenSaltStr & "','" & AddUsrRoleCmbx.Text & "'" & " )"

        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = AddUserQuery

        'declares variable for rows affected after Query is run
        Dim rowsAffected As Integer = 0

        'exicutes the query and returns the number of rows affected
        rowsAffected = SQLCommand.ExecuteNonQuery()


        'test to see if sql query was exicuted properly
        If (rowsAffected > 0) Then
            'notifies user 
            MsgBox("User was registered successfully")
            ' clears all textboxes after the entity is registered 
            AddUsrTxtbx.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()
            AddUsrRoleCmbx.Text = "Select from..."
            AddUsrTxtbx.Clear()


        Else
            'notfies user and clears out the textboxs

            MsgBox("User registration failed!!")
            AddUsrTxtbx.Select()
            AddUsrPassTxtbox.Clear()
            AddUsrCnfirmPassTxt.Clear()
            AddUsrRoleCmbx.Text = "Select from..."
            AddUsrTxtbx.Clear()


        End If





        'closes DB connection and data reader 
        QueryResults.Close()



    End Sub

    Private Sub AddUsrCancelBtn_Click(sender As Object, e As EventArgs) Handles AddUsrCancelBtn.Click
        'closes current form
        Me.Close()

    End Sub

    Private Sub AddUserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this prepoplates the dropbox with report options
        AddUsrRoleCmbx.Items.Clear()
        AddUsrRoleCmbx.Items.Add("Administrator")
        AddUsrRoleCmbx.Items.Add("Regular User")
        AddUsrRoleCmbx.Text = "Select from..."


    End Sub
End Class