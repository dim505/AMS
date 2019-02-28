Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportSelComboBox.Items.Clear()
        ReportSelComboBox.Items.Add("All students with grades of 85 and higher")
        ReportSelComboBox.Items.Add("All teachers who teach courses")
        ReportSelComboBox.Text = "Select from..."
    End Sub

    Private Sub ReportsFrmRunBTN_Click(sender As Object, e As EventArgs) Handles MyBaseFrmRunBTN.Click

        Dim ReportSqlStr As String

        If (ReportSelComboBox.Text = "All teachers who teach courses") Then


            ReportSqlStr = "Select TeaInfo.TeacherFName, TeaInfo.TeacherLName, CourTeaBy.CourseID, CourInfo.[CourseName]
                            From CourseTeachedBy$ As CourTeaBy
                            Left Join TeacherInfo$ AS TeaInfo
                            On CourTeaBy.TeacherID = TeaInfo.ID
                            inner Join CourseInfo$ as CourInfo
                            On CourTeaBy.CourseID = CourInfo.CourseID"

        Else

            MsgBox("Please Select a Report to Run")


        End If







        SQLCommand.CommandText = ReportSqlStr
        SQLCommand.CommandType = CommandType.Text

        Dim DataAdpt As OleDbDataAdapter = New OleDbDataAdapter(SQLCommand)
        Dim DtStuResults As DataTable = New DataTable()
        DataAdpt.Fill(DtStuResults)
        ReportsGridView.DataSource = DtStuResults











    End Sub


End Class