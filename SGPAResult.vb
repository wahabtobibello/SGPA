Public Class SGPAResult
    Public student As Student
    Public sgpa As Double

    Private Sub SGPAResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Add("Full Name: " + Me.student.fullName)
        ListView1.Items.Add("Faculty: " + Me.student.faculty)
        ListView1.Items.Add("Department: " + Me.student.department)
        ListView1.Items.Add("Matric Number: " + Me.student.matricNo.ToString())
        ListView1.Items.Add("Year: " + Me.student.year.ToString())
        ListView1.Items.Add("SGPA: " + Me.sgpa.ToString())
    End Sub
End Class