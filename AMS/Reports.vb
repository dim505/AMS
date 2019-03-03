Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient




Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportSelComboBox.Items.Clear()
        ReportSelComboBox.Items.Add("All students with grades of 80 and higher")
        ReportSelComboBox.Items.Add("All teachers who teach courses")
        ReportSelComboBox.Text = "Select from..."
    End Sub

    Private Sub RunRptBtn_Click(sender As Object, e As EventArgs) Handles RunRptBtn.Click


        Dim ReportSqlStr As String = "test"

        If (ReportSelComboBox.Text = "All teachers who teach courses") Then


            ReportSqlStr = "Select TeaInfo.TeacherFName, TeaInfo.TeacherLName, CourTeaBy.CourseID, CourInfo.[CourseName]
                            From CourseTeachedBy$ As CourTeaBy
                            Left Join TeacherInfo$ AS TeaInfo
                            On CourTeaBy.TeacherID = TeaInfo.ID
                            inner Join CourseInfo$ as CourInfo
                            On CourTeaBy.CourseID = CourInfo.CourseID"
        ElseIf (ReportSelComboBox.Text = "All students with grades of 80 and higher") Then

            ReportSqlStr = "Select StuInfo.[StudentFName], StuInfo.[StudentLName], stuGrd.[StudentID], stuGrd.[CourseID], stuGrd.[Grade]
                            from [StudentInfo$] As StuInfo
                            Left Join [StudentGrade$] as stuGrd
                            On StuInfo.ID = stuGrd.[StudentID]
                            where stuGrd.Grade Is Not null And stuGrd.Grade >= 80"

        Else

            MsgBox("Please Select a Report to Run")


        End If



        If (Not (String.IsNullOrEmpty(ReportSqlStr))) Then

            SQLCommand.CommandText = ReportSqlStr
            SQLCommand.CommandType = CommandType.Text

            Dim DataAdpt As OleDbDataAdapter = New OleDbDataAdapter(SQLCommand)
            Dim DtRptResults As DataTable = New DataTable()
            DataAdpt.Fill(DtRptResults)
            ReportsGridView.DataSource = DtRptResults

        End If








    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub
End Class