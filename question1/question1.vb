Public Class question1
    Dim marks(9) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        marks(0) = Val(txt1.Text)
        marks(1) = Val(txt2.Text)
        marks(2) = Val(txt3.Text)
        marks(3) = Val(txt4.Text)
        marks(4) = Val(txt5.Text)
        marks(5) = Val(txt6.Text)
        marks(6) = Val(txt7.Text)
        marks(7) = Val(txt8.Text)
        marks(8) = Val(txt9.Text)
        marks(9) = Val(txt10.Text)

        gbx1.Enabled = False

    End Sub

    Private Sub btnall_Click(sender As Object, e As EventArgs) Handles btnall.Click
        lblall.Text = ""
        For Each mark In marks
            lblall.Text += mark.ToString() + ","
        Next

    End Sub

    Private Sub btnmax_Click(sender As Object, e As EventArgs) Handles btnmax.Click
        lblmax.Text = marks.Max()
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        lblmin.Text = marks.Min()
    End Sub

    Private Sub btnavg_Click(sender As Object, e As EventArgs) Handles btnavg.Click
        lblavg.Text = marks.Average()
    End Sub
End Class
