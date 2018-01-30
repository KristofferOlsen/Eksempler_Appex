Public Class frmMain
    Private Sub mnuEndrePassord_Click(sender As Object, e As EventArgs) Handles mnuEndrePassord.Click 'Når du velger dette alternativet i menyen så åpnes det en ny form for endring av passord. Det vil midlertidlg gjøre den forgje formen ikke interaktiv så lenge denne formen er oppe.
        frmEndrePassord.ShowDialog()
    End Sub

    Private Sub mnuShoutout_Click(sender As Object, e As EventArgs) Handles mnuShoutout.Click 'Dette alternativet vil få opp en melding som inneholder brukfulle kilder jeg brukte.
        MessageBox.Show("Shoutout and thanks to Stack Overflow a site where learn, share and build careers. Also thanks to Softicons for the icon to this program",
                        "Shoutout", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuLoggUt_Click(sender As Object, e As EventArgs) Handles mnuLoggUt.Click 'Du blir avlogget, altså du blir sendt tilbake til  login formen igjen.
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub mnuHjelp_Click(sender As Object, e As EventArgs) Handles mnuHjelp.Click 'En informasjons melding kommer opp for hva du kan gjøre i denne formen.
        MessageBox.Show("Gå i valg for å endre passord, se shoutout-en, eller for å logge ut.", "Hjelp", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

  
End Class