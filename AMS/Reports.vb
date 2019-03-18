Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient




Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this prepoplates the dropbox with report options
        ReportSelComboBox.Items.Clear()
        ReportSelComboBox.Items.Add("All students with grades of 80 and higher")
        ReportSelComboBox.Items.Add("All teachers who teach courses")
        ReportSelComboBox.Text = "Select from..."
    End Sub

    Private Sub RunRptBtn_Click(sender As Object, e As EventArgs) Handles RunRptBtn.Click

        'declares report sql query
        Dim ReportSqlStr As String = ""


        'checks what report was selected and  gives the SQLStr the appropriate query 
        If (ReportSelComboBox.Text = "All teachers who teach courses") Then


            ReportSqlStr = "Select TeaInfo.TeacherFName + '  ' + TeaInfo.TeacherLName as [Teacher Name], CourTeaBy.CourseID as [Course ID], CourInfo.[CourseName] as [Course Name]
                            From CourseTeachedBy$ As CourTeaBy
                            Left Join TeacherInfo$ AS TeaInfo
                            On CourTeaBy.TeacherID = TeaInfo.ID
                            inner Join CourseInfo$ as CourInfo
                            On CourTeaBy.CourseID = CourInfo.CourseID"

        ElseIf (ReportSelComboBox.Text = "All students with grades of 80 and higher") Then

            ReportSqlStr = "Select StuInfo.[StudentFName] + '  '+ StuInfo.[StudentLName] as [Student Name], stuGrd.[StudentID] as [Student ID], stuGrd.[CourseID] as [Course ID], stuGrd.[Grade]
                            from [StudentInfo$] As StuInfo
                            Left Join [StudentGrade$] as stuGrd
                            On StuInfo.ID = stuGrd.[StudentID]
                            where stuGrd.Grade Is Not null And stuGrd.Grade >= 80"

        Else

            MsgBox("Please Select a Report to Run")


        End If


        'checks to see if there is a value in ReportSqlStr, if there is, then it populates the data grid view 
        If (Not (String.IsNullOrEmpty(ReportSqlStr))) Then

            'sets sql command that will be exicuted against DB 
            SQLCommand.CommandText = ReportSqlStr

            'declaring OleDbDataAdapte: contains data commands and a database connection to exicute against DB 
            Dim DataAdpt As OleDbDataAdapter = New OleDbDataAdapter(SQLCommand)
            'declaring new instance of a data table 
            Dim DtRptResults As DataTable = New DataTable()
            'filling the data table from the query results
            DataAdpt.Fill(DtRptResults)
            'binds the data table to the data source of the grid view Thus prepopulating it with data 
            ReportsGridView.DataSource = DtRptResults
            'closes DB connection and data reader 
            DataAdpt.Dispose()


        End If








    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RptfrmMMBtn.Click
        'makes main form active 
        Main_Menu.Show()
        'closes current form
        Me.Close()

    End Sub
End Class