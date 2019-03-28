Imports System.Data.OleDb
Imports System.Text
Imports System
Imports System.Security.Cryptography

Public Class LogIn




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




    Private Sub LoginCancelBTN_Click(sender As Object, e As EventArgs) Handles LoginCancelBTN.Click
        'gracfully closes the application
        Application.Exit()
    End Sub

    Private Sub LogInBtn_Click_1(sender As Object, e As EventArgs) Handles LogInBtn.Click


        If (String.IsNullOrWhiteSpace(LogInUserTxtBox.Text)) Then

            'notifes user they can't leave a blank user name
            MsgBox("Please Input UserName")
            'clears user name text box
            LogInUserTxtBox.Clear()
            'points cursor on textbox
            LogInUserTxtBox.Select()



        ElseIf (String.IsNullOrWhiteSpace(LoginPassTxtBox.Text)) Then


            'notifes user they can't leave a blank password
            MsgBox("Please Input Password")
            'clears password text box
            LoginPassTxtBox.Clear()
            'points cursor on textbox
            LoginPassTxtBox.Select()

        Else

            'sets sql command that will be exicuted against DB along with its parameters 
            SQLCommand.CommandText = "select * from LogInCreds where Rtrim(LTrim(UserName)) = ?"

            'declares datareader, this allows you to read rows of  data from a data source
            Dim reader As OleDbDataReader

            'clears any exisisting parameters as adding new ones do not over write the old ones 
            SQLCommand.Parameters.Clear()

            'declares the parameters for the SQl statement and assigns a value from the textboxs  
            With SQLCommand.Parameters
                .Add("@p0", OleDbType.VarChar).Value = LogInUserTxtBox.Text
            End With

            'declares a data reader so you can read a stream of data rows from a database and exicutes it 
            reader = SQLCommand.ExecuteReader()

            'reads rows from reader one row at a time
            While (reader.Read())
                'declares salted pass from DB
                Dim SaltHashPassword As String = reader.GetString(1)
                'declares salt used from DB
                Dim Salt As String = reader.GetString(2)
                'combines user guess password with the salt retrived from DB
                Dim UserGuessPass As String = Trim(Salt) + Trim(LoginPassTxtBox.Text)
                'Runs the guess password string through a gen hash functions and stores it in UsrGeussPassHash
                Dim UsrGeussPassHash As String = GenHash(UserGuessPass)

                'compares user geuss password hash with hash for account from DB
                If UsrGeussPassHash = SaltHashPassword Then

                    'shows main menu
                    Main_Menu.Show()
                    'closes current Form
                    Me.Close()

                Else
                    'notifes user username or password wrong
                    MsgBox("Invalid Username or Password")
                    'clears user name and password text boxes

                    LogInUserTxtBox.Clear()
                    LoginPassTxtBox.Clear()
                    'focuses cursor baack on the user text box
                    LogInUserTxtBox.Select()

                End If

            End While

            'closes reader object so it can be used else where in the program
            reader.Close()

        End If


    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call sub to start the DB connection 
        StartDBConnection()
    End Sub


End Class