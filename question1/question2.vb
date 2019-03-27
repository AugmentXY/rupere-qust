Public Class question2

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblsms.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem

            Case "Anopa"
                txtmod.Text = "Advanced VB.Net"
                lblsms.Text = "Anopa's favorate module is Advanced VB.Net"
            Case "Tinerufaro"
                txtmod.Text = "Java"
                lblsms.Text = "Tinerufaro's favorate module is  Java"
            Case "Anotida"
                txtmod.Text = "C#"
                lblsms.Text = "Anotida's favorate module is  C#"
            Case "Tinevimbo"
                txtmod.Text = "ANN"
                lblsms.Text = "Tinevimbo's favorate module is ANN"
            Case "Anotidaishe"
                txtmod.Text = "JBeans"
                lblsms.Text = "Anotidaishe's favorate module is JBeans"
        End Select
    End Sub

    Private Sub question2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class