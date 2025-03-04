Public Class fenetreExemple1
    Private Sub ButtonCalcul_Click(sender As Object, e As EventArgs) Handles ButtonCalcul.Click
        TextResultat.Text = Convert.ToString(Convert.ToInt16(TextNombre1.Text) + Convert.ToInt16(TextNombre2.Text))
    End Sub
End Class
