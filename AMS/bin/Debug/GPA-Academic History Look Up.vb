Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient


Public Class GPA_Academic_History_Look_Up

    Private Sub LookUpGradesBTN_Click(sender As Object, e As EventArgs) Handles LookUpGradesBTN.Click

        Dim LookUpGPAHistory As String = "Select StudentID, CourseID, Grade from StudentGrade$ where StudentID=" & "'" & AcaHisStuIDTxtBox.Text & "';"

        SQLCommand.CommandText = LookUpGPAHistory
        SQLCommand.CommandType = CommandType.Text

        Dim DataAdpt As OleDbDataAdapter = New OleDbDataAdapter(SQLCommand)
        Dim DtStuResults As DataTable = New DataTable()
        DataAdpt.Fill(DtStuResults)
        StuGPAGridView.DataSource = DtStuResults














    End Sub

    Private Sub StuGPAGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StuGPAGridView.CellContentClick

    End Sub
End Class