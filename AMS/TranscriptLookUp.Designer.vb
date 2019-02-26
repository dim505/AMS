<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TranscriptLookUp
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
        Me.TransLookUpTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TransLookUpTxtBox
        '
        Me.TransLookUpTxtBox.Location = New System.Drawing.Point(298, 51)
        Me.TransLookUpTxtBox.Name = "TransLookUpTxtBox"
        Me.TransLookUpTxtBox.Size = New System.Drawing.Size(311, 22)
        Me.TransLookUpTxtBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student ID"
        '
        'TranscriptLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 494)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TransLookUpTxtBox)
        Me.Name = "TranscriptLookUp"
        Me.Text = "TranscriptLookUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TransLookUpTxtBox As TextBox
    Friend WithEvents Label1 As Label
End Class
