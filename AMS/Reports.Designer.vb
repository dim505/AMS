<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SelectReportlbl = New System.Windows.Forms.Label()
        Me.ReportsFrmRunBTN = New System.Windows.Forms.Button()
        Me.ReportsGridView = New System.Windows.Forms.DataGridView()
        Me.Student_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ReportSelComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.ReportsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectReportlbl
        '
        Me.SelectReportlbl.AutoSize = True
        Me.SelectReportlbl.Location = New System.Drawing.Point(117, 51)
        Me.SelectReportlbl.Name = "SelectReportlbl"
        Me.SelectReportlbl.Size = New System.Drawing.Size(141, 17)
        Me.SelectReportlbl.TabIndex = 1
        Me.SelectReportlbl.Text = "Please Select Report"
        '
        'ReportsFrmRunBTN
        '
        Me.ReportsFrmRunBTN.Location = New System.Drawing.Point(872, 196)
        Me.ReportsFrmRunBTN.Name = "ReportsFrmRunBTN"
        Me.ReportsFrmRunBTN.Size = New System.Drawing.Size(75, 120)
        Me.ReportsFrmRunBTN.TabIndex = 10
        Me.ReportsFrmRunBTN.Text = "RUN"
        Me.ReportsFrmRunBTN.UseVisualStyleBackColor = True
        '
        'ReportsGridView
        '
        Me.ReportsGridView.AllowUserToAddRows = False
        Me.ReportsGridView.AllowUserToDeleteRows = False
        Me.ReportsGridView.AllowUserToOrderColumns = True
        Me.ReportsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Student_ID, Me.Course_ID, Me.Grade})
        Me.ReportsGridView.Location = New System.Drawing.Point(152, 109)
        Me.ReportsGridView.Name = "ReportsGridView"
        Me.ReportsGridView.ReadOnly = True
        Me.ReportsGridView.RowTemplate.Height = 24
        Me.ReportsGridView.Size = New System.Drawing.Size(684, 276)
        Me.ReportsGridView.TabIndex = 9
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
        'ReportSelComboBox
        '
        Me.ReportSelComboBox.FormattingEnabled = True
        Me.ReportSelComboBox.Location = New System.Drawing.Point(330, 42)
        Me.ReportSelComboBox.Name = "ReportSelComboBox"
        Me.ReportSelComboBox.Size = New System.Drawing.Size(418, 24)
        Me.ReportSelComboBox.TabIndex = 11
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 494)
        Me.Controls.Add(Me.ReportSelComboBox)
        Me.Controls.Add(Me.ReportsFrmRunBTN)
        Me.Controls.Add(Me.ReportsGridView)
        Me.Controls.Add(Me.SelectReportlbl)
        Me.Name = "Reports"
        Me.Text = "Transcript LookUp"
        CType(Me.ReportsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectReportlbl As Label
    Friend WithEvents ReportsFrmRunBTN As Button
    Friend WithEvents ReportsGridView As DataGridView
    Friend WithEvents Student_ID As DataGridViewTextBoxColumn
    Friend WithEvents Course_ID As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ReportSelComboBox As ComboBox
End Class
