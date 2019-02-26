Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient


Public Class GPA_Academic_History_Look_Up
    Private Sub LookUpGradesBTN_Click(sender As Object, e As EventArgs) Handles LookUpGradesBTN.Click

        Dim LookUpGPAHistory As String = ""


        LookUpGPAHistory = "Select StudentID, CourseID, Grade from StudentGrade$ where StudentID=" & "'" & AcaHisStuIDTxtBox.Text & "';"

        SQLCommand.CommandText = LookUpGPAHistory


        Dim reader As OleDbDataReader = SQLCommand.ExecuteReader()


        StuGPAGridView.DataSource = reader

        ' StuGPAGridView.DataBindings


        Do While (reader.Read())







        Loop

        'QueryResults.Close()











    End Sub

    Private Sub AcaHisStuIDTxtBox_TextChanged(sender As Object, e As EventArgs) Handles AcaHisStuIDTxtBox.TextChanged

    End Sub

    Private Sub StuGPAGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StuGPAGridView.CellContentClick

    End Sub
End Class