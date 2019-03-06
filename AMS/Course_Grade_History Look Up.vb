Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient


Public Class GPA_Academic_History_Look_Up

    Private Sub LookUpGradesBTN_Click(sender As Object, e As EventArgs) Handles LookUpGradesBTN.Click
        'declares string for SQL query and assigns a Query value
        Dim LookUpGPAHistory As String = "
        select StuInfo.StudentFName, StuInfo.StudentLName, StuGd.StudentID, StuGd.CourseID, StuGd.Grade  
        from StudentInfo$ as StuInfo
        inner join StudentGrade$ as StuGd
        on StuInfo.ID = StuGd.StudentID
        where StuInfo.ID =" & "'" & AcaHisStuIDTxtBox.Text & "';"


        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = LookUpGPAHistory

        'declaring OleDbDataAdapte: contains data commands and a database connection to exicute against DB 
        Dim DataAdpt As OleDbDataAdapter = New OleDbDataAdapter(SQLCommand)
        'declaring new instance of a data table 
        Dim DtStuResults As DataTable = New DataTable()
        'filling the data table fron the query results
        DataAdpt.Fill(DtStuResults)
        'binds the data table to the data source of the grid view Thus prepopulating it with data 
        StuGPAGridView.DataSource = DtStuResults

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

        'hides current form
        Me.Hide()
        'makes main form active 
        Main_Menu.Show()
    End Sub
End Class