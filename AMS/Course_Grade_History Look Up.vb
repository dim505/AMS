Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient


Public Class GPA_Academic_History_Look_Up

    Private Sub LookUpGradesBTN_Click(sender As Object, e As EventArgs) Handles LookUpGradesBTN.Click



        Dim RowsAffected As Integer
        'declares string for SQL query and assigns a Query value
        Dim LookUpGPAHistory As String = "
        select StuInfo.StudentFName +  ' ' + StuInfo.StudentLName as [Student Name], StuGd.StudentID as [Student ID], CI.CourseName as [Course Name], StuGd.CourseID as [Course ID], StuGd.Grade  
        from StudentInfo$ as StuInfo
        inner join StudentGrade$ as StuGd
        on StuInfo.ID = StuGd.StudentID
		inner join CourseInfo$ as CI
		on CI.CourseID = StuGd.CourseID
        where StuInfo.ID =" & "'" & AcaHisStuIDTxtBox.Text & "';"


        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = LookUpGPAHistory

        'declaring OleDbDataAdapte: contains data commands and a database connection to exicute against DB 
        Dim DataAdpt As OleDbDataAdapter = New OleDbDataAdapter(SQLCommand)


        'declaring new instance of a data table 
        Dim DtStuResults As DataTable = New DataTable()





        'filling the data table fron the query results
        DataAdpt.Fill(DtStuResults)



        'returns back number of rows returned 
        RowsAffected = DtStuResults.Rows().Count()

        'tests to see if any rows are turned
        If (RowsAffected > 0) Then

            'binds the data table to the data source of the grid view Thus prepopulating it with data 
            StuGPAGridView.DataSource = DtStuResults

        Else
            'notifies it would not find anything
            MsgBox("Could Not Find Student ID")
            'clears the current textbox
            AcaHisStuIDTxtBox.Clear()
            'it select ths textbox for another entry
            AcaHisStuIDTxtBox.Select()


        End If







        'closes DB connection and data reader 
        DataAdpt.Dispose()


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        'makes main form active 
        Main_Menu.Show()
        'closes current form
        Me.Close()

    End Sub
End Class