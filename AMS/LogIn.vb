Imports System.Data.OleDb

Public Class LogIn

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
            SQLCommand.CommandText = "select * from LogInCreds where Rtrim(LTrim(UserName)) = ? and Rtrim(LTrim(Password)) = ?"
            'declares datareader, this allows you to read rows of  data from a data source
            Dim reader As OleDbDataReader

            'clears any exisisting parameters as adding new ones do not over write the old ones 
            SQLCommand.Parameters.Clear()

            'declares the parameters for the SQl statement and assigns a value from the textboxs  
            With SQLCommand.Parameters
                .Add("@p0", OleDbType.VarChar).Value = LogInUserTxtBox.Text
                .Add("@p1", OleDbType.VarChar).Value = LoginPassTxtBox.Text
            End With

            'declares a data reader so you can read a stream of data rows from a database and exicutes it 
            reader = SQLCommand.ExecuteReader()

            'if the query returns any results, it will show Main menu, if not, it will display error
            If (reader.HasRows) Then

                'shows main menu
                Main_Menu.Show()
                'hides current Form
                Me.Hide()
            Else
                'notifes user username or password wrong
                MsgBox("Invalid Username or Password")
                'clears user name and password text boxes

                LogInUserTxtBox.Clear()
                LoginPassTxtBox.Clear()
                'focuses cursor baack on the user text box
                LogInUserTxtBox.Select()


            End If
            'closes reader object so it can be used else where in the program
            reader.Close()

        End If




    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call sub to start the DB connection 
        StartDBConnection()
    End Sub


End Class