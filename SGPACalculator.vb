Public Class SGPACalculator
    Public student As Student
    Public courses As New List(Of Course)
    Dim scores As New List(Of Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text
        Dim scores As List(Of String) = input.Split(",").ToList()
        If (scores.Count <> courses.Count) Then
            MessageBox.Show("You have entered an invalid amount of courses")
        Else
            Try
                Me.scores.Clear()
                ListView1.Items.Clear()
                For i As Integer = 0 To scores.Count - 1
                    Dim score As Integer = Convert.ToInt32(scores.ElementAt(i).Trim())
                    Me.scores.Add(score)
                    Dim listItem As ListViewItem = New ListViewItem()
                    listItem.Text = courses.ElementAt(i).courseCode + " - " + Me.scores.ElementAt(i).ToString()
                    ListView1.Items.Add(listItem)
                Next
            Catch ex As Exception
                MessageBox.Show("Invalid scores entered")
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gradePoints As List(Of Integer) = New List(Of Integer)
        For i As Integer = 0 To Me.scores.Count - 1
            gradePoints.Add(Me.GetGradePoint(Me.scores.ElementAt(i)))
        Next

        Dim totalGradePoint As Integer = 0
        Dim totalUnit As Integer = 0
        For i As Integer = 0 To gradePoints.Count - 1
            totalGradePoint += gradePoints.ElementAt(i) * courses.ElementAt(i).unit
            totalUnit += courses.ElementAt(i).unit
        Next
        Dim sgpa As Double = Math.Round(totalGradePoint / totalUnit, 2)
        Dim resultPage As SGPAResult = New SGPAResult()
        resultPage.student = Me.student
        resultPage.sgpa = sgpa
        resultPage.ShowDialog()
    End Sub

    Private Function GetGradePoint(score As Integer) As Integer
        Select Case score
            Case 70 To 100
                Return 5
            Case 60 To 69
                Return 4
            Case 50 To 59
                Return 3
            Case 45 To 49
                Return 2
            Case 40 To 44
                Return 1
            Case Else
                Return 0
        End Select
    End Function
End Class