Public Class StudentBioDataForm
    Dim form2 As CourseForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim student As Student = New Student()
        student.fullName = fullNameTbx.Text
        student.faculty = facultyTbx.Text
        student.department = departmentTbx.Text
        student.matricNo = Convert.ToInt32(matricNoTbx.Text)
        student.year = Convert.ToInt32(yearTbx.Text)

        form2 = New CourseForm(student)
        form2.ShowDialog()
    End Sub

    Private Sub unitTbx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles matricNoTbx.KeyPress, yearTbx.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class