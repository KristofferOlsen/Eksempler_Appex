Public Class frmEndrePassord
    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click 'Avbryt knappen vil føre deg tilbake til pålogget formen uten å ha gjort noen endringer.
        Me.Close()
    End Sub

    Private Sub btnEndre_Click(sender As Object, e As EventArgs) Handles btnEndre.Click
        If txtGammeltPassord.Text = PassordKeyWord Then 'Når knappen blir trykket på så vil passordet bli endret, men bare hvis det gamle passordet stemmer.
            Dim result = MessageBox.Show("Vil du utføre endringen av passordet?", "Endring av passord", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                PassordKeyWord = txtNyttPassord.Text
                Me.Close()
            End If
        Else
            MessageBox.Show("Gammle passordet stemmte ikke!", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error) 'En melding vil komme opp at passordet stemte ikke.
        End If
    End Sub
End Class