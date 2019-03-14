Imports System.Data.OleDb


Public Class Update_Student_Teacher_Course_Info


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpStuLookUpBTN.Click

        'declares SQL Query 
        Dim LookUpCourseQuery As String = "Select ID, StudentFName, StudentLName, SSN, Address, City, State, PhoneNumber, DateOfBirth from StudentInfo$ where ID=" & "'" & UpStuIDTxtBox.Text & "';"

        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = LookUpCourseQuery

        ' this combines the sql query with the Connection and builds a OleDbDataReader.
        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()



        'loop read through data 
        Do While (QueryResults.Read())

            'prepopulates all the text boxes from the query results
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
        'closes DB connection and data reader 
        QueryResults.Close()




    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles LookUpBTNCourseInfo.Click

        'declares string for SQL query and assigns a Query value
        Dim LookUpCourseQuery As String = "Select CourseID, CourseName, CourseDescription, TeacherFName, TeacherLName, TeacherID, DaysTaught, StartTime, EndTime, PreReq from CourseInfo$ where CourseID=" & "'" & UpdateCourseIDtxtbox.Text & "';"

        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = LookUpCourseQuery




        ' this combines the sql query with the Connection and builds a OleDbDataReader.
        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()



        'This loop reads through all the data 

        Do While (QueryResults.Read())


            'prepopulates all the text boxes from the query results
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

        'closes DB connection and data reader 
        QueryResults.Close()









    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles UpdateCourseBTN.Click

        'declares SQL Query 
        Dim UpdateQuery As String = "Update CourseInfo$ SET CourseID ='" & UpdateCourseIDtxtbox.Text & "', " & "CourseName ='" & UpdateCourseNameTxtbox.Text & "', " & "CourseDescription ='" &
        UpdateCorDesTxtBox.Text & "', " & "TeacherFName ='" & UpdateTeacherFirstNametxtbox.Text & "', " & "TeacherLName ='" & UpdateTeacherLastNametxtbox.Text & "', " &
        "TeacherID ='" & UpdateTeacherIDtxtbox.Text & "', " & "DaysTaught = '" & UpdateDaysTaughttxtbox.Text & "', " & "StartTime ='" & UpdateStartTimeTxtBox.Text & "', " & "EndTime ='" & UpdateEndTimeTxtbox.Text & "', " & "PreReq='" & UpdatePrereqTxtBox.Text & "'" & "where CourseID =" & "'" & UpdateCourseIDtxtbox.Text & "';"




        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = UpdateQuery


        'exicutes the query and returns the number of rows affected
        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that the update was successful, else it failed
        If (RowFlag > 0) Then
            MsgBox("Course info updated successfully")
        Else
            MsgBox("Course info update failed !!")
        End If







    End Sub

    Private Sub RemoveCourseBTN_Click(sender As Object, e As EventArgs) Handles RemoveCourseBTN.Click

        'declares string for SQL query and assigns Query value\
        Dim RemoveCourseQuery As String = "DELETE From CourseInfo$ where CourseID =" & "'" & UpdateCourseIDtxtbox.Text & "';"




        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RemoveCourseQuery

        'declares variable for rows affected after Query is run
        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        'exicutes the query and returns the number of rows affected
        If (RowFlag > 0) Then
            MsgBox("Course info deleted successfully")
        Else
            MsgBox("Course info deletion failed !!")
        End If








    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles UpStuTeachCourInfoMMBTN.Click

        'makes main form active 
        Main_Menu.Show()

        'closes current form
        Me.Close()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles UpTeachLookUpBtn.Click

        'declares string for SQL query and assigns Query value
        Dim LookUpCourseQuery As String = "Select ID, TeacherFName, TeacherLName,SSN, Address, City, State, PhoneNumber, DateOfBirth from TeacherInfo$ where ID=" & "'" & UpTeachIDTxtBox.Text & "';"



        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = LookUpCourseQuery

        ' this combines the sql query with the Connection and builds a OleDbDataReader.
        Dim QueryResults As OleDbDataReader = SQLCommand.ExecuteReader()


        'This loop reads through all the data 
        Do While (QueryResults.Read())


            'prepopulates all the text boxes from the query results
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

        'closes DB connection and data reader 
        QueryResults.Close()



    End Sub



    Private Sub UpTeachuPDATEBtn_Click(sender As Object, e As EventArgs) Handles UpTeachuPDATEBtn.Click


        'declares string for SQL query and assigns a Query value
        Dim UpdateQuery As String = "Update TeacherInfo$ SET ID ='" & UpTeachIDTxtBox.Text & "', " & "TeacherFName ='" & UpTeachFNameTxtBox.Text & "', " &
        "TeacherLName ='" & UpTeachLNameTxtBox.Text & "', " &
        "SSN ='" & UpTeachSSNTxtBox.Text & "', " &
        "Address ='" & UpTeachAddressTxtBox.Text & "', " &
        "City ='" & UpTeachCityTxtBox.Text & "', " &
        "State ='" & UpTeachStateTxtBox.Text & "', " &
        "PhoneNumber ='" & UpTeachPhoneTxtBox.Text & "', " &
        "DateOfBirth ='" & UpTeachDOBDTP.Text & "'" & "where ID =" & "'" & UpTeachIDTxtBox.Text & "';"



        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = UpdateQuery

        'exicutes the query and returns the number of rows affected
        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()


        'if the returned value is greater than or equal to 1, it notifies the user that update was successful, else it failed
        If (RowFlag > 0) Then
            MsgBox("Teacher info updated successfully")
        Else
            MsgBox("Teacher info update failed !!")
        End If




    End Sub

    Private Sub UpTeachRemoveBtn_Click(sender As Object, e As EventArgs) Handles UpTeachRemoveBtn.Click



        'declares SQL Query 
        Dim RemoveCourseQuery As String = "DELETE From TeacherInfo$ where ID =" & "'" & UpTeachIDTxtBox.Text & "';"




        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RemoveCourseQuery

        'exicutes the query and returns the number of rows affected
        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that delete was successful, else it failed
        If (RowFlag > 0) Then
            MsgBox("Teacher record deleted successfully")
        Else
            MsgBox("Teacher record deletion failed !!")
        End If




    End Sub

    Private Sub UpStuUpdateBTN_Click(sender As Object, e As EventArgs) Handles UpStuUpdateBTN.Click

        'declares SQL Query 
        Dim UpdateQuery As String = "Update StudentInfo$ SET ID ='" & UpStuIDTxtBox.Text & "', " & "StudentFName ='" & UpStuFNameTxtBox.Text & "', " &
            "StudentLName ='" & UpStuLNameTxtBox.Text & "', " &
            "SSN ='" & UpStuSSNTxtBox.Text & "', " &
            "Address ='" & UpStuAddressTxtBox.Text & "', " &
            "City ='" & UpStuCityTxtBox.Text & "', " &
            "State ='" & UpStuStateTxtBox.Text & "', " &
            "PhoneNumber ='" & UpStuPhoneNumTxtBox.Text & "', " &
            "DateOfBirth ='" & UpStuDTP.Text & "'" & "" & "where ID =" & "'" & UpStuIDTxtBox.Text & "';"

        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = UpdateQuery

        'exicutes the query and returns the number of rows affected
        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that update was successful, else it failed
        If (RowFlag > 0) Then
            MsgBox("Student info updated successfully")
        Else
            MsgBox("Student info update failed !!")
        End If





    End Sub

    Private Sub UpStuRemoveBTN_Click(sender As Object, e As EventArgs) Handles UpStuRemoveBTN.Click


        'declares string for SQL query and assigns a Query value
        Dim RemoveCourseQuery As String = "DELETE From StudentInfo$ where ID =" & "'" & UpStuIDTxtBox.Text & "';"




        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RemoveCourseQuery

        'exicutes the query and returns the number of rows affected
        Dim RowFlag As Integer = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that delete was successful, else it failed
        If (RowFlag > 0) Then
            MsgBox("Student record deleted successfully")
        Else
            MsgBox("Student record deletion failed !!")
        End If



    End Sub


End Class