'imports namespace needed to exicute query against DB
Imports System.Data.OleDb



Public Class Add_Course_Teacher_Student


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Register_Course.Click





        'loops through all the textboxes in the active tab control page
        For Each TextBox In AddCourStuTeaTabControl.SelectedTab.Controls.OfType(Of TextBox)

            'tests if the textbox is null or has a white space 
            If (String.IsNullOrEmpty(TextBox.Text)) Then

                'notifes the user to input a value for that textbox 
                MsgBox("Please Input a Value")
                'marks the offfending textbox
                TextBox.Select()
                'Exits the current subprocedure 
                Exit Sub
            End If

        Next


            'declares string for SQL query and assigns Query value
            Dim RegisterCourseQuery As String = "INSERT INTO   CourseInfo$(CourseID, CourseName, CourseDescription, TeacherFName, TeacherLName, TeacherID, DaysTaught, StartTime, EndTime, PreReq) " &
        "VALUES(" & "'" & CourseIDtxtbox.Text & "','" + CourseNameTxtbox.Text & "','" & CorDesTxtBox.Text & "','" &
        TeacherFirstNametxtbox.Text & "','" & TeacherLastNametxtbox.Text & "','" & TeacherIDtxtbox.Text & "','" & DaysTaughttxtbox.Text &
      "','" & StartTimeTxtBox.Text & "','" & EndTimeTxtbox.Text &
        "','" & PrereqTxtBox.Text & "')"




        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RegisterCourseQuery



        'declares variable for rows affected after Query is run
        Dim rowsAffected As Integer = 0




        'exicutes the query and returns the number of rows affected
        rowsAffected = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that registration was successful, else it failed
        If (rowsAffected > 0) Then
            MsgBox("Course was registered successfully")
            'loops through and clears all textboxes after the entity is registered 
            For Each TextBox In AddCourStuTeaTabControl.SelectedTab.Controls.OfType(Of TextBox)

                TextBox.Text = ""
            Next
            'selects the first textbox incase they want to add something again 
            TeacherFirstNametxtbox.Select()


        Else
            MsgBox("Course registerion failed!!")
        End If



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RegisterTeacher.Click


        'loops through all the textboxes in the active tab control page
        For Each TextBox In AddCourStuTeaTabControl.SelectedTab.Controls.OfType(Of TextBox)

            'tests if the textbox is null or has a white space 
            If (String.IsNullOrEmpty(TextBox.Text)) Then

                'notifes the user to input a value for that textbox 
                MsgBox("Please Input a Value")
                'marks the offfending textbox active 
                TextBox.Select()
                'Exits the current subprocedure 
                Exit Sub
            End If

        Next



        'declares string for SQL query and assigns a Query value
        Dim RegisterTeacherQuery As String = "INSERT INTO TeacherInfo$(ID, TeacherFName, TeacherLName, SSN, Address, City, State, PhoneNumber, DateOfBirth) " &
        "VALUES(" & "'" & AddTchIDtxtbox.Text & "','" & TFNametxtbox.Text & "','" &
       TLNametxtbox.Text & "','" & TSSNtxtbox.Text & "','" & TAddresstxtbox.Text & "','" & TCitytxtbox.Text &
      "','" & TStatetxtbox.Text & "','" & TPhoneNumbertxtbox.Text &
        "','" & AddTeacherDTP.Text & "')"







        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RegisterTeacherQuery


        'declares variable for rows affected after Query is run
        Dim rowsAffected As Integer = 0

        'exicutes the query and returns the number of rows affected
        rowsAffected = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that registration was successful, else it failed
        If (rowsAffected > 0) Then
            MsgBox("Teacher was added successfully")
            'loops through and clears all textboxes after the entity is registered 
            For Each TextBox In AddCourStuTeaTabControl.SelectedTab.Controls.OfType(Of TextBox)

                TextBox.Text = ""
            Next
            'selects the first textbox incase they want to add something again 
            TFNametxtbox.Select()

        Else
            MsgBox("Teacher adding failed!!")
        End If







    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TSSNtxtbox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Register_Student.Click



        'loops through all the textboxes in the active tab control page
        For Each TextBox In AddCourStuTeaTabControl.SelectedTab.Controls.OfType(Of TextBox)

            'tests if the textbox is null or has a white space 
            If (String.IsNullOrEmpty(TextBox.Text)) Then

                'notifes the user to input a value for that textbox 
                MsgBox("Please Input a Value")
                'marks the offfending textbox active 
                TextBox.Select()
                'Exits the current subprocedure 
                Exit Sub
            End If

        Next





        'declares string for SQL query and assigns a Query value
        Dim RegisterStudentQuery As String = "INSERT INTO  StudentInfo$(ID, StudentFName, StudentLName, SSN, Address, City, State, PhoneNumber, DateOfBirth) " &
        "VALUES(" & "'" & StuIDTxtBox.Text & "','" & StuFNameTBox.Text & "','" &
       StuLNameTBox.Text & "','" & StuSSNTBox.Text & "','" & StuAddressTBox.Text & "','" & StuCityTBox.Text &
      "','" & StuStateTBox.Text & "','" & StuPhoneNumTBox.Text &
        "','" & StuDOBDTP.Text & "')"







        'sets sql command that will be exicuted against DB 
        SQLCommand.CommandText = RegisterStudentQuery



        'declares variable for rows affected after Query is run
        Dim rowsAffected As Integer = 0


        'exicutes the query and returns the number of rows affected
        rowsAffected = SQLCommand.ExecuteNonQuery()

        'if the returned value is greater than or equal to 1, it notifies the user that registration was successful, else it failed
        If (rowsAffected > 0) Then
            MsgBox("Student was added successfully")
            'loops through and clears all textboxes after the entity is registered 
            For Each TextBox In AddCourStuTeaTabControl.SelectedTab.Controls.OfType(Of TextBox)
                'CLEARS TEXTbox text
                TextBox.Text = ""
            Next
            'selects the first textbox incase they want to add something again 
            StuFNameTBox.Select()

        Else
            MsgBox("Student adding failed!!")
        End If









    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        'takes you back to Main Menu
        Main_Menu.Show()


        'closes current form
        Me.Close()


    End Sub

    Private Sub Add_Course_Teacher_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class