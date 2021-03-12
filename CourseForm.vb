Public Class CourseForm
    Dim courses As New List(Of Course)
    Public student As Student
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If courseCodeTbx.Text = "" Or unitTbx.Text = "" Then
            MessageBox.Show("Please fill all fields")
        ElseIf courses.Count >= 8 Then
            MessageBox.Show("You have added enough courses")
        Else
            Dim courseCode As String = courseCodeTbx.Text
            Dim unit As String = unitTbx.Text
            Dim course = New Course(courseCode, unit)
            courses.Add(course)
            Dim item As ListViewItem = New ListViewItem()
            item.Text = course.courseCode + " (" + course.unit + " unit(s))"
            courseListView.Items.Add(item)
            courseCodeTbx.Text = ""
            unitTbx.Text = ""
        End If
    End Sub

    Private Sub unitTbx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unitTbx.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If courses.Count = 0 Then
            MessageBox.Show("Please add atleast one course")
        Else
            Dim calculatorForm As SGPACalculator = New SGPACalculator()
            calculatorForm.student = student
            calculatorForm.courses = courses
            calculatorForm.ShowDialog()
        End If
    End Sub

End Class