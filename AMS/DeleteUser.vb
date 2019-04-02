Imports System.Data.OleDb

Public Class DelUsrFrm
    Private Sub DelUsrLookUpBTN_Click(sender As Object, e As EventArgs) Handles DelUsrLookUpBTN.Click
        'declares SQL Query 
        Dim LookUpCourseQuery As String = "Select * from LogInCreds where UserName=" & "'" & DelUsrTxtbx.Text & "';"

        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = LookUpCourseQuery

        ' this combines the sql query with the Connection and builds a OleDbDataReader.
        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()




        If (QueryResults.HasRows) Then



            'loop read through data 
            Do While (QueryResults.Read())

                'prepopulates all the text boxes from the query results
                DelUsrTxtbx.Text = QueryResults.GetString(0)


            Loop
            'turns text box green signaifying secuess
            DelUsrTxtbx.BackColor = Color.LightGreen
            MsgBox("User Found!")

        Else


            MsgBox("Could not Find User ID")
            'turns textbox red signafying failure
            DelUsrTxtbx.BackColor = Color.Red


        End If



        'closes DB connection and data reader 
        QueryResults.Close()
    End Sub

    Private Sub DelUsrDelBTN_Click(sender As Object, e As EventArgs) Handles DelUsrDelBTN.Click



        'declares string for SQL query and assigns a Query value
        Dim RemoveCourseQuery As String = "DELETE From LogInCreds where UserName =" & "'" & DelUsrTxtbx.Text & "';"




        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RemoveCourseQuery

        'exicutes the query and returns the number of rows affected
        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that delete was successful, else it failed
        If (RowFlag > 0) Then
            MsgBox("User was deleted successfully")


            ''clears textboxes and returns it back to white 
            DelUsrTxtbx.Text = ""
            DelUsrTxtbx.BackColor = Color.FloralWhite
            DelUsrTxtbx.Select()



        Else
            MsgBox("User deletion failed !!")
        End If



    End Sub
End Class