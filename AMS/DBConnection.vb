Imports System.Data.OleDb



Public Module DBConnection

    'Defines connection String 
    Dim connectionStr As String = "provider=SQLOLEDB;Data Source=DESKTOP-N2G2IND;Initial Catalog=AMS;uid=DESKTOP-N2G2IND\bob;pwd=Ccleaner123!@;Integrated security=SSPI; MultipleActiveResultSets=true"
    'declares OleDbConnection  instance, represents open connection to DB
    Public dbConnection As OleDbConnection = New OleDbConnection(connectionStr)
    'declares OleDbCommand, represents the Sql command that is going to exicuted against the DB
    Public SQLCommand As OleDbCommand = New OleDbCommand()





    Public Sub StartDBConnection()


        'Does a try catch when trying to open a Db connection, if it fails, it will say The Application has Successfully Connected To The Database else connection was successful 
        Try
            dbConnection.Open()
            SQLCommand.Connection = dbConnection

        Catch ex As Exception
            MsgBox("Database Connection Failed", , "Connection Notification")
        End Try

        If (dbConnection.State = ConnectionState.Open) Then
            MsgBox("The Application has Successfully Connected To The Database", , "Connection Notification")
        End If

    End Sub





End Module

