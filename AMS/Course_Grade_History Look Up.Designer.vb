﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GPA_Academic_History_Look_Up
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LookUpGradesBTN = New System.Windows.Forms.Button()
        Me.StuGPAGridView = New System.Windows.Forms.DataGridView()
        Me.Student_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcaHisStuIDTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        CType(Me.StuGPAGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookUpGradesBTN
        '
        Me.LookUpGradesBTN.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LookUpGradesBTN.Location = New System.Drawing.Point(795, 154)
        Me.LookUpGradesBTN.Name = "LookUpGradesBTN"
        Me.LookUpGradesBTN.Size = New System.Drawing.Size(148, 131)
        Me.LookUpGradesBTN.TabIndex = 8
        Me.LookUpGradesBTN.Text = "Look Up"
        Me.LookUpGradesBTN.UseVisualStyleBackColor = True
        '
        'StuGPAGridView
        '
        Me.StuGPAGridView.AllowUserToAddRows = False
        Me.StuGPAGridView.AllowUserToDeleteRows = False
        Me.StuGPAGridView.AllowUserToOrderColumns = True
        Me.StuGPAGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StuGPAGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StuGPAGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Student_ID, Me.Course_ID, Me.Grade})
        Me.StuGPAGridView.Location = New System.Drawing.Point(93, 154)
        Me.StuGPAGridView.Name = "StuGPAGridView"
        Me.StuGPAGridView.ReadOnly = True
        Me.StuGPAGridView.RowTemplate.Height = 24
        Me.StuGPAGridView.Size = New System.Drawing.Size(684, 276)
        Me.StuGPAGridView.TabIndex = 7
        '
        'Student_ID
        '
        Me.Student_ID.HeaderText = "Student ID"
        Me.Student_ID.Name = "Student_ID"
        Me.Student_ID.ReadOnly = True
        Me.Student_ID.Visible = False
        '
        'Course_ID
        '
        Me.Course_ID.HeaderText = "Course ID"
        Me.Course_ID.Name = "Course_ID"
        Me.Course_ID.ReadOnly = True
        Me.Course_ID.Visible = False
        '
        'Grade
        '
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.Visible = False
        '
        'AcaHisStuIDTxtBox
        '
        Me.AcaHisStuIDTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcaHisStuIDTxtBox.Location = New System.Drawing.Point(267, 94)
        Me.AcaHisStuIDTxtBox.Multiline = True
        Me.AcaHisStuIDTxtBox.Name = "AcaHisStuIDTxtBox"
        Me.AcaHisStuIDTxtBox.Size = New System.Drawing.Size(188, 36)
        Me.AcaHisStuIDTxtBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Student ID"
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnMainMenu.Location = New System.Drawing.Point(795, 310)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(148, 120)
        Me.BtnMainMenu.TabIndex = 147
        Me.BtnMainMenu.Text = "Main Menu"
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'GPA_Academic_History_Look_Up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 536)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Controls.Add(Me.LookUpGradesBTN)
        Me.Controls.Add(Me.StuGPAGridView)
        Me.Controls.Add(Me.AcaHisStuIDTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GPA_Academic_History_Look_Up"
        Me.Text = "Course/Grade History Look Up"
        CType(Me.StuGPAGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LookUpGradesBTN As Button
    Friend WithEvents StuGPAGridView As DataGridView
    Friend WithEvents AcaHisStuIDTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Student_ID As DataGridViewTextBoxColumn
    Friend WithEvents Course_ID As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents BtnMainMenu As Button
End Class
