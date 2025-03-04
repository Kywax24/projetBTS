Public Class Exercice21
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonFermer.Click
        Close()
    End Sub

    Private Sub txtNbr1_Leave(sender As Object, e As EventArgs) Handles txtNbr1.Leave, txtNbr2.Leave

        If (txtNbr1.Text = "") Then
            txtNbr1.Focus()
        ElseIf (txtNbr2.Text = "") Then
            txtNbr2.Focus()
        Else
            Dim x As Int16
            Dim y As Int16
            x = txtNbr1.Text
            y = txtNbr2.Text

            If x > y Then
                MessageBox.Show("Le nombre " & x & " est supérieur au nombre " & y & ".")
            Else
                MessageBox.Show("Le nombre " & x & " est inférieur au nombre " & y & ".")
            End If
        End If



    End Sub

End Class
