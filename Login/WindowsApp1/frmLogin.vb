Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Brukernavn = "Haugaland" 'Standard brukernavn er "Haugaland", og dette kan ikke endres i applikasjonen.

        If PassordKeyWord = "" Then 'Dette gjør slikt at passordet starter som "Test" når den starter og hvis du bytter passord til ingenting
            PassordKeyWord = "Test"
        End If

        Passord = PassordKeyWord

        If txtBrukernavn.Text = Brukernavn And txtPassord.Text = Passord Then 'Hvis passordet er rett så vil applikasjonen føre deg til en annen form.
            MessageBox.Show("Du er logget inn.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassord.Text = ""
            Me.Hide()
            frmMain.Show()
        Else 'Derimot hvis det blir feil så visker den ut passord feltet og setter fokuset på passord tekstfeltet.
            MessageBox.Show("Feil brukernavn eller passord!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassord.Text = ""
            txtPassord.Focus()
        End If
    End Sub

    Private Sub mnuAvslutt_Click(sender As Object, e As EventArgs) Handles mnuAvslutt.Click 'Avslutt alternativet som ligger i menyen
        Dim Result = MessageBox.Show("Vil du avslutte nå?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mnuHjelp_Click(sender As Object, e As EventArgs) Handles mnuHjelp.Click 'Hjelp alternativet som ligger i menyen
        MessageBox.Show("Standard brukernavn er Haugaland, og passord er Test", "Hjelp", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class