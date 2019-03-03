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
        Me.ReportsGridView = New System.Windows.Forms.DataGridView()
        Me.Student_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ReportSelComboBox = New System.Windows.Forms.ComboBox()
        Me.RunRptBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ReportsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectReportlbl
        '
        Me.SelectReportlbl.AutoSize = True
        Me.SelectReportlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectReportlbl.Location = New System.Drawing.Point(109, 30)
        Me.SelectReportlbl.Name = "SelectReportlbl"
        Me.SelectReportlbl.Size = New System.Drawing.Size(293, 36)
        Me.SelectReportlbl.TabIndex = 1
        Me.SelectReportlbl.Text = "Please Select Report"
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
        Me.ReportSelComboBox.Location = New System.Drawing.Point(418, 42)
        Me.ReportSelComboBox.Name = "ReportSelComboBox"
        Me.ReportSelComboBox.Size = New System.Drawing.Size(418, 24)
        Me.ReportSelComboBox.TabIndex = 11
        '
        'RunRptBtn
        '
        Me.RunRptBtn.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.RunRptBtn.Location = New System.Drawing.Point(913, 146)
        Me.RunRptBtn.Name = "RunRptBtn"
        Me.RunRptBtn.Size = New System.Drawing.Size(148, 111)
        Me.RunRptBtn.TabIndex = 12
        Me.RunRptBtn.Text = "Run"
        Me.RunRptBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(913, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 108)
        Me.Button2.TabIndex = 146
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 494)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RunRptBtn)
        Me.Controls.Add(Me.ReportSelComboBox)
        Me.Controls.Add(Me.ReportsGridView)
        Me.Controls.Add(Me.SelectReportlbl)
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.ReportsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectReportlbl As Label
    Friend WithEvents ReportsGridView As DataGridView
    Friend WithEvents Student_ID As DataGridViewTextBoxColumn
    Friend WithEvents Course_ID As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ReportSelComboBox As ComboBox
    Friend WithEvents RunRptBtn As Button
    Friend WithEvents Button2 As Button
End Class
