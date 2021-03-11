Public Class StudentBioDataForm
    Dim form2 As CourseForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If fullNameTbx.Text = "" Or facultyTbx.Text = "" Or departmentTbx.Text = "" Or matricNoTbx.Text = "" Or yearTbx.Text = "" Then
            MessageBox.Show("Please fill all fields")
        Else
            Dim student As Student = New Student()
            student.fullName = fullNameTbx.Text
            student.faculty = facultyTbx.Text
            student.department = departmentTbx.Text
            student.matricNo = Convert.ToInt32(matricNoTbx.Text)
            student.year = Convert.ToInt32(yearTbx.Text)

            form2 = New CourseForm()
            form2.student = student
            form2.ShowDialog()
        End If
    End Sub

    Private Sub unitTbx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles matricNoTbx.KeyPress, yearTbx.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class