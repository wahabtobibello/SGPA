<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.unitTbx = New System.Windows.Forms.TextBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.courseCodeTbx = New System.Windows.Forms.TextBox()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.courseListView = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Course Unit"
        '
        'unitTbx
        '
        Me.unitTbx.Location = New System.Drawing.Point(12, 163)
        Me.unitTbx.Name = "unitTbx"
        Me.unitTbx.Size = New System.Drawing.Size(206, 23)
        Me.unitTbx.TabIndex = 7
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(12, 207)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(206, 28)
        Me.addBtn.TabIndex = 12
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Enter your courses for the semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(132, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 30)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Student Course Form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Course Code"
        '
        'courseCodeTbx
        '
        Me.courseCodeTbx.Location = New System.Drawing.Point(12, 109)
        Me.courseCodeTbx.Name = "courseCodeTbx"
        Me.courseCodeTbx.Size = New System.Drawing.Size(206, 23)
        Me.courseCodeTbx.TabIndex = 6
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(132, 408)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(206, 28)
        Me.submitBtn.TabIndex = 12
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'courseListView
        '
        Me.courseListView.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.courseListView.HideSelection = False
        Me.courseListView.Location = New System.Drawing.Point(224, 91)
        Me.courseListView.Name = "courseListView"
        Me.courseListView.Size = New System.Drawing.Size(248, 247)
        Me.courseListView.TabIndex = 13
        Me.courseListView.UseCompatibleStateImageBehavior = False
        Me.courseListView.UseWaitCursor = True
        Me.courseListView.View = System.Windows.Forms.View.List
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.courseListView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.unitTbx)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.courseCodeTbx)
        Me.Name = "Form2"
        Me.Text = "k"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents unitTbx As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents courseCodeTbx As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents courseListView As ListView
    Friend WithEvents submitBtn As Button
End Class
