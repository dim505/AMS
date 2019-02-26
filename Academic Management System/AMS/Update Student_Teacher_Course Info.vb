Imports System.Data.OleDb


Public Class Update_Student_Teacher_Course_Info
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles Update_Teacher_Info.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpStuLookUpBTN.Click


        Dim LookUpCourseQuery As String = ""


        LookUpCourseQuery = "Select ID, StudentFName, StudentLName, SSN, Address, City, State, PhoneNumber, DateOfBirth from StudentInfo$ where ID=" & "'" & UpStuIDTxtBox.Text & "';"

        SQLCommand.CommandText = LookUpCourseQuery


        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()




        Do While (QueryResults.Read())

            UpStuIDTxtBox.Text = QueryResults.GetString(0)
            UpStuFNameTxtBox.Text = QueryResults.GetString(1)
            UpStuLNameTxtBox.Text = QueryResults.GetString(2)
            UpStuSSNTxtBox.Text = QueryResults.GetString(3)

            UpStuAddressTxtBox.Text = QueryResults.GetString(4)
            UpStuCityTxtBox.Text = QueryResults.GetString(5)
            UpStuStateTxtBox.Text = QueryResults.GetString(6)
            UpStuPhoneNumTxtBox.Text = QueryResults.GetString(7)
            UpStuDTP.Text = QueryResults.GetString(8)

        Loop

        QueryResults.Close()




    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles LookUpBTNCourseInfo.Click


        Dim LookUpCourseQuery As String = ""


        LookUpCourseQuery = "Select CourseID, CourseName, CourseDescription, TeacherFName, TeacherLName, TeacherID, DaysTaught, StartTime, EndTime, PreReq from CourseInfo$ where CourseID=" & "'" & UpdateCourseIDtxtbox.Text & "';"

        SQLCommand.CommandText = LookUpCourseQuery






        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()




        Do While (QueryResults.Read())



            UpdateCourseIDtxtbox.Text = QueryResults.GetString(0)
            UpdateCourseNameTxtbox.Text = QueryResults.GetString(1)
            UpdateCorDesTxtBox.Text = QueryResults.GetString(2)
            UpdateTeacherFirstNametxtbox.Text = QueryResults.GetString(3)
            UpdateTeacherLastNametxtbox.Text = QueryResults.GetString(4)
            UpdateTeacherIDtxtbox.Text = QueryResults.GetString(5)
            UpdateDaysTaughttxtbox.Text = QueryResults.GetString(6)
            UpdateStartTimeTxtBox.Text = QueryResults.GetString(7)
            UpdateEndTimeTxtbox.Text = QueryResults.GetString(8)
            UpdatePrereqTxtBox.Text = QueryResults.GetString(9)






        Loop

        QueryResults.Close()









    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles UpdateCourseBTN.Click


        Dim UpdateQuery As String = ""


        UpdateQuery = "Update CourseInfo$ SET CourseID ='" & UpdateCourseIDtxtbox.Text & "', " & "CourseName ='" & UpdateCourseNameTxtbox.Text & "', " & "CourseDescription ='" &
        UpdateCorDesTxtBox.Text & "', " & "TeacherFName ='" & UpdateTeacherFirstNametxtbox.Text & "', " & "TeacherLName ='" & UpdateTeacherLastNametxtbox.Text & "', " &
        "TeacherID ='" & UpdateTeacherIDtxtbox.Text & "', " & "DaysTaught = '" & UpdateDaysTaughttxtbox.Text & "', " & "StartTime ='" & UpdateStartTimeTxtBox.Text & "', " & "EndTime ='" & UpdateEndTimeTxtbox.Text & "', " & "PreReq='" & UpdatePrereqTxtBox.Text & "'" & "where CourseID =" & "'" & UpdateCourseIDtxtbox.Text & "';"





        SQLCommand.CommandText = UpdateQuery


        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        If (RowFlag > 0) Then
            MsgBox("Course info updated successfully")
        Else
            MsgBox("Course info update failed !!")
        End If







    End Sub

    Private Sub RemoveCourseBTN_Click(sender As Object, e As EventArgs) Handles RemoveCourseBTN.Click


        Dim RemoveCourseQuery As String = ""


        RemoveCourseQuery = "DELETE From CourseInfo$ where CourseID =" & "'" & UpdateCourseIDtxtbox.Text & "';"





        SQLCommand.CommandText = RemoveCourseQuery


        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()


        If (RowFlag > 0) Then
            MsgBox("Course info deleted successfully")
        Else
            MsgBox("Course info deletion failed !!")
        End If








    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click


        Me.Hide()
        Main_Menu.Show()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles UpTeachLookUpBtn.Click


        Dim LookUpCourseQuery As String = ""


        LookUpCourseQuery = "Select ID, TeacherFName, TeacherLName,SSN, Address, City, State, PhoneNumber, DateOfBirth from TeacherInfo$ where ID=" & "'" & UpTeachIDTxtBox.Text & "';"

        SQLCommand.CommandText = LookUpCourseQuery


        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()




        Do While (QueryResults.Read())



            UpTeachIDTxtBox.Text = QueryResults.GetString(0)
            UpTeachFNameTxtBox.Text = QueryResults.GetString(1)
            UpTeachLNameTxtBox.Text = QueryResults.GetString(2)
            UpTeachSSNTxtBox.Text = QueryResults.GetString(3)
            UpTeachAddressTxtBox.Text = QueryResults.GetString(4)
            UpTeachCityTxtBox.Text = QueryResults.GetString(5)
            UpTeachStateTxtBox.Text = QueryResults.GetString(6)
            UpTeachPhoneTxtBox.Text = QueryResults.GetString(7)
            UpTeachDOBDTP.Text = QueryResults.GetString(8)

        Loop

        QueryResults.Close()



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles UpTeachSSNTxtBox.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles UpTeachIDTxtBox.TextChanged

    End Sub

    Private Sub UpTeachuPDATEBtn_Click(sender As Object, e As EventArgs) Handles UpTeachuPDATEBtn.Click
        Dim UpdateQuery As String = ""


        UpdateQuery = "Update TeacherInfo$ SET ID ='" & UpTeachIDTxtBox.Text & "', " & "TeacherFName ='" & UpTeachFNameTxtBox.Text & "', " &
        "TeacherLName ='" & UpTeachLNameTxtBox.Text & "', " &
        "SSN ='" & UpTeachSSNTxtBox.Text & "', " &
        "Address ='" & UpTeachAddressTxtBox.Text & "', " &
        "City ='" & UpTeachCityTxtBox.Text & "', " &
        "State ='" & UpTeachStateTxtBox.Text & "', " &
        "PhoneNumber ='" & UpTeachPhoneTxtBox.Text & "', " &
        "DateOfBirth ='" & UpTeachDOBDTP.Text & "'" & "where ID =" & "'" & UpTeachIDTxtBox.Text & "';"















        SQLCommand.CommandText = UpdateQuery


        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        If (RowFlag > 0) Then
            MsgBox("Teacher info updated successfully")
        Else
            MsgBox("Teacher info update failed !!")
        End If




    End Sub

    Private Sub UpTeachRemoveBtn_Click(sender As Object, e As EventArgs) Handles UpTeachRemoveBtn.Click




        Dim RemoveCourseQuery As String = ""


        RemoveCourseQuery = "DELETE From TeacherInfo$ where ID =" & "'" & UpTeachIDTxtBox.Text & "';"





        SQLCommand.CommandText = RemoveCourseQuery


        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()


        If (RowFlag > 0) Then
            MsgBox("Teacher record deleted successfully")
        Else
            MsgBox("Teacher record deletion failed !!")
        End If




    End Sub

    Private Sub UpStuUpdateBTN_Click(sender As Object, e As EventArgs) Handles UpStuUpdateBTN.Click


        Dim UpdateQuery As String = ""








        UpdateQuery = "Update StudentInfo$ SET ID ='" & UpStuIDTxtBox.Text & "', " & "StudentFName ='" & UpStuFNameTxtBox.Text & "', " &
            "StudentLName ='" & UpStuLNameTxtBox.Text & "', " &
            "SSN ='" & UpStuSSNTxtBox.Text & "', " &
            "Address ='" & UpStuAddressTxtBox.Text & "', " &
            "City ='" & UpStuCityTxtBox.Text & "', " &
            "State ='" & UpStuStateTxtBox.Text & "', " &
            "PhoneNumber ='" & UpStuPhoneNumTxtBox.Text & "', " &
            "DateOfBirth ='" & UpStuDTP.Text & "'" & "" & "where ID =" & "'" & UpStuIDTxtBox.Text & "';"















        SQLCommand.CommandText = UpdateQuery


        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        If (RowFlag > 0) Then
            MsgBox("Student info updated successfully")
        Else
            MsgBox("Student info update failed !!")
        End If





    End Sub

    Private Sub UpStuRemoveBTN_Click(sender As Object, e As EventArgs) Handles UpStuRemoveBTN.Click



        Dim RemoveCourseQuery As String = ""


        RemoveCourseQuery = "DELETE From StudentInfo$ where ID =" & "'" & UpStuIDTxtBox.Text & "';"





        SQLCommand.CommandText = RemoveCourseQuery


        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()


        If (RowFlag > 0) Then
            MsgBox("Student record deleted successfully")
        Else
            MsgBox("Student record deletion failed !!")
        End If



    End Sub
End Class