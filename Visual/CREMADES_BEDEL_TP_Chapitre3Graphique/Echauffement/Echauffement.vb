Public Class Echauffement
    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If (txtNombre.Text <> "") Then
            Dim x As Int16
            x = Convert.ToInt32(txtNombre.Text) Mod 3
            If x = 0 Then
                MessageBox.Show("Ce nombre est un multiple de 3")
            Else
                MessageBox.Show("Ce nombre n’est pas multiple de 3")
            End If
        End If

    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            bFermer.focus()
        End If
    End Sub

    Private Sub bFermer_Click(sender As Object, e As EventArgs) Handles bFermer.Click
        Close()
    End Sub
End Class
