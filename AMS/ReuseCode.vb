Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text


Public Module ReuseCode


    'Defines connection String 
    Dim connectionStr As String = "provider=SQLOLEDB;Data Source=DESKTOP-N2G2IND;Initial Catalog=AMS;Integrated security=SSPI; MultipleActiveResultSets=true"
    'declares OleDbConnection  instance, represents open connection to DB
    Public dbConnection As OleDbConnection = New OleDbConnection(connectionStr)
    'declares OleDbCommand, represents the Sql command that is going to exicuted against the DB
    Public SQLCommand As OleDbCommand = New OleDbCommand()


    'declares public class and property to store user role to determine access rights 
    Public Class GlobalVariables
        Public Shared Role As String
    End Class

    Public Function GenSalt() As String

        'declares object that can generate salt 
        Dim SaltGen = New RNGCryptoServiceProvider()
        'declares salt size
        Dim SaltSize = 24
        'converts salt size to a byte
        Dim SaltSizeByte(SaltSize) As Byte
        'generates salt hash
        SaltGen.GetNonZeroBytes(SaltSizeByte)


        'declares object able to create string 
        Dim stringBuilder As New StringBuilder
        'loops through and builds the string from the byte hash 
        For i As Integer = 0 To SaltSizeByte.Length - 1
            stringBuilder.Append(SaltSizeByte(i).ToString("X2"))
        Next
        'returns the salt string
        Return stringBuilder.ToString()




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

