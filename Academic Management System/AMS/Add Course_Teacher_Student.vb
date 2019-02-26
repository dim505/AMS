Imports System.Data.OleDb



Public Class Add_Course_Teacher_Student
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Monday_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Register_Course.Click


        Dim RegisterCourseQuery As String = ""


        RegisterCourseQuery = "INSERT INTO   CourseInfo$(CourseID, CourseName, CourseDescription, TeacherFName, TeacherLName, TeacherID, DaysTaught, StartTime, EndTime, PreReq) " &
        "VALUES(" & "'" & CourseIDtxtbox.Text & "','" + CourseNameTxtbox.Text & "','" & CorDesTxtBox.Text & "','" &
        TeacherFirstNametxtbox.Text & "','" & TeacherLastNametxtbox.Text & "','" & TeacherIDtxtbox.Text & "','" & DaysTaughttxtbox.Text &
      "','" & StartTimeTxtBox.Text & "','" & EndTimeTxtbox.Text &
        "','" & PrereqTxtBox.Text & "')"







        SQLCommand.CommandText = RegisterCourseQuery




        Dim rowsAffected As Integer = 0


        rowsAffected = SQLCommand.ExecuteNonQuery()

        If (rowsAffected > 0) Then
            MsgBox("Course was registered successfully")
        Else
            MsgBox("Course registerion failed!!")
        End If





    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles CourseIDtxtbox.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles CourseNameTxtbox.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Prereq.Click

    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles PrereqTxtBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RegisterTeacher.Click
        Dim RegisterTeacherQuery As String = ""


        RegisterTeacherQuery = "INSERT INTO TeacherInfo$(ID, TeacherFName, TeacherLName, SSN, Address, City, State, PhoneNumber, DateOfBirth) " &
        "VALUES(" & "'" & AddTchIDtxtbox.Text & "','" & TFNametxtbox.Text & "','" &
       TLNametxtbox.Text & "','" & TSSNtxtbox.Text & "','" & TAddresstxtbox.Text & "','" & TCitytxtbox.Text &
      "','" & TStatetxtbox.Text & "','" & TPhoneNumbertxtbox.Text &
        "','" & AddTeacherDTP.Text & "')"








        SQLCommand.CommandText = RegisterTeacherQuery



        Dim rowsAffected As Integer = 0
        rowsAffected = SQLCommand.ExecuteNonQuery()


        If (rowsAffected > 0) Then
            MsgBox("Teacher was added successfully")
        Else
            MsgBox("Teacher adding failed!!")
        End If







    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TSSNtxtbox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Register_Student.Click


        Dim RegisterStudentQuery As String = ""


        RegisterStudentQuery = "INSERT INTO  StudentInfo$(ID, StudentFName, StudentLName, SSN, Address, City, State, PhoneNumber, DateOfBirth) " &
        "VALUES(" & "'" & StuIDTxtBox.Text & "','" & StuFNameTBox.Text & "','" &
       StuLNameTBox.Text & "','" & StuSSNTBox.Text & "','" & StuAddressTBox.Text & "','" & StuCityTBox.Text &
      "','" & StuStateTBox.Text & "','" & StuPhoneNumTBox.Text &
        "','" & StuDOBDTP.Text & "')"








        SQLCommand.CommandText = RegisterStudentQuery




        Dim rowsAffected As Integer = 0
        rowsAffected = SQLCommand.ExecuteNonQuery()


        If (rowsAffected > 0) Then
            MsgBox("Student was added successfully")
        Else
            MsgBox("Student adding failed!!")
        End If









    End Sub

    Private Sub Label26_Click_1(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles AddTchIDtxtbox.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TCitytxtbox_TextChanged(sender As Object, e As EventArgs) Handles TCitytxtbox.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles StuSSNTBox.TextChanged

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click


        Me.Hide()
        Main_Menu.Show()


    End Sub

    Private Sub Add_Course_Teacher_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class