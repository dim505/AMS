Imports System.Data.OleDb



Public Module Utility


    Dim connectionStr As String = "provider=SQLOLEDB;Data Source=DESKTOP-N2G2IND;Initial Catalog=AMS;uid=DESKTOP-N2G2IND\bob;pwd=Ccleaner123!@;Integrated security=SSPI; MultipleActiveResultSets=true"
    Public dbConnection As OleDbConnection = New OleDbConnection(connectionStr)
    Public SQLCommand As OleDbCommand = New OleDbCommand()



    Public Sub StartDBConnection()


        'dbConnection.ConnectionString = connectionStr
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

