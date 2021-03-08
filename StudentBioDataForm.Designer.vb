<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentBioDataForm
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
        Me.fullNameTbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.facultyTbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.yearTbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.matricNoTbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.departmentTbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'fullNameTbx
        '
        Me.fullNameTbx.Location = New System.Drawing.Point(141, 120)
        Me.fullNameTbx.Name = "fullNameTbx"
        Me.fullNameTbx.Size = New System.Drawing.Size(206, 23)
        Me.fullNameTbx.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name"
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(141, 397)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(206, 28)
        Me.submitBtn.TabIndex = 5
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Faculty"
        '
        'facultyTbx
        '
        Me.facultyTbx.Location = New System.Drawing.Point(141, 174)
        Me.facultyTbx.Name = "facultyTbx"
        Me.facultyTbx.Size = New System.Drawing.Size(206, 23)
        Me.facultyTbx.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Year"
        '
        'yearTbx
        '
        Me.yearTbx.Location = New System.Drawing.Point(141, 353)
        Me.yearTbx.Name = "yearTbx"
        Me.yearTbx.Size = New System.Drawing.Size(206, 23)
        Me.yearTbx.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Matriculation Number"
        '
        'matricNoTbx
        '
        Me.matricNoTbx.Location = New System.Drawing.Point(141, 293)
        Me.matricNoTbx.Name = "matricNoTbx"
        Me.matricNoTbx.Size = New System.Drawing.Size(206, 23)
        Me.matricNoTbx.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(141, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Department"
        '
        'departmentTbx
        '
        Me.departmentTbx.Location = New System.Drawing.Point(141, 234)
        Me.departmentTbx.Name = "departmentTbx"
        Me.departmentTbx.Size = New System.Drawing.Size(206, 23)
        Me.departmentTbx.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(141, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 30)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Student Biodata Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Enter your student details"
        '
        'Form1
        '
        Me.AcceptButton = Me.submitBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.departmentTbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.matricNoTbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.yearTbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.facultyTbx)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fullNameTbx)
        Me.Name = "Form1"
        Me.Text = "Submit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fullNameTbx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents submitBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents facultyTbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents matricNoTbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents departmentTbx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents yearTbx As TextBox
End Class
