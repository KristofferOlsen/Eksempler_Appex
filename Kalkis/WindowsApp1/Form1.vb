Public Class frmKalkis
    Private Sub frmKalkis_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Når applikasjonen starter så vil første tekstbok bli fokusert, og begge vil være tomme.
        txtFelt1.Focus()
        txtFelt1.Text = ""
        txtFelt2.Text = ""
    End Sub

    Private Sub btnPluss_Click(sender As Object, e As EventArgs) Handles btnPluss.Click 'Hvis du trykker på + knappen så vil tekstboks 1 og 2 pluesset sammen.
        txtFelt1.Focus()

        Dim Felt1 As Double
        Dim Felt2 As Double
        Dim Answer As Double

        If txtFelt1.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt1 = Double.Parse(txtFelt1.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If
        If txtFelt2.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt2 = Double.Parse(txtFelt2.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If

        Answer = Felt1 + Felt2 'Mattestykket blir utført

        lblAnswer.Text = Answer 'Svaret blir sendt til lable-en
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click 'Hvis du trykker på - knappen så vil tekstboks 1 minusert av tekstboks 2.
        txtFelt1.Focus()

        Dim Felt1 As Double
        Dim Felt2 As Double
        Dim Answer As Double

        If txtFelt1.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt1 = Double.Parse(txtFelt1.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If
        If txtFelt2.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt2 = Double.Parse(txtFelt2.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If

        Answer = Felt1 - Felt2 'Mattestykket blir utført

        lblAnswer.Text = Answer 'Svaret blir sendt til lable-en
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click 'Hvis du trykker på / knappen så vil tekstboks 1 bli delt på tekstboks 2.
        txtFelt1.Focus()

        Dim Felt1 As Double
        Dim Felt2 As Double
        Dim Answer As Double

        If txtFelt1.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt1 = Double.Parse(txtFelt1.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If
        If txtFelt2.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt2 = Double.Parse(txtFelt2.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If

        Answer = Felt1 / Felt2 'Mattestykket blir utført

        lblAnswer.Text = Answer 'Svaret blir sendt til lable-en
    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click 'Hvis du trykker på X knappen så vil tekstboks 1 og 2 ganget sammen.
        txtFelt1.Focus()

        Dim Felt1 As Double
        Dim Felt2 As Double
        Dim Answer As Double

        If txtFelt1.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt1 = Double.Parse(txtFelt1.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If
        If txtFelt2.Text = "" Then 'Hvis tekstfeltet er tomt så vil ingenting skje.

        Else
            Felt2 = Double.Parse(txtFelt2.Text) 'Hvis tekstfeltet er fyllt med et tall så vil den fortsette.
        End If

        Answer = Felt1 * Felt2 'Mattestykket blir utført

        lblAnswer.Text = Answer 'Svaret blir sendt til lable-en
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'Når knappen trykkes så vil svaret bli visket ut, dette gjelder også tekstboksene.
        txtFelt1.Focus()
        lblAnswer.Text = ""
        txtFelt1.Text = ""
        txtFelt2.Text = ""
    End Sub

    Private Sub txtFelt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFelt1.KeyPress 'Dette gjør slikt at bokstaver, symboler og ingenting kan ikke bli brukt.
        If e.KeyChar = "," Then 'Hvis hendelsen taste trykk skjer så vil det bli håndtert slikt at det bare blir akseptert tall eller 1 komma.
            e.Handled = (CType(sender, TextBox).Text.IndexOf(",") <> -1) 'Her kan du også se at "," er akseptert
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1) 'Her ser du de aksepterte tallene
        End If
    End Sub

    Private Sub txtFelt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFelt2.KeyPress 'Dette gjør slikt at bokstaver, symboler og ingenting kan ikke bli brukt.
        If e.KeyChar = "," Then 'Hvis hendelsen taste trykk skjer så vil det bli håndtert slikt at det bare blir akseptert tall eller 1 komma.
            e.Handled = (CType(sender, TextBox).Text.IndexOf(",") <> -1) 'Her kan du også se at "," er akseptert
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1) 'Her ser du de aksepterte tallene
        End If
    End Sub

    Private Sub mnuShoutout_Click(sender As Object, e As EventArgs) Handles mnuShoutout.Click 'Dette vil åpne en melding med midler jeg brukte for å fullføre programmet.
        MessageBox.Show("Shoutout and thanks to Stack Overflow a site where to learn, share and build careers. Also thanks to Softicons for the icon to this program",
                        "Shoutout", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuAvslutt_Click(sender As Object, e As EventArgs) Handles mnuAvslutt.Click 'Åpner melding som spør om du vil avlutte, hvis ja så avslutter programmet.
        Dim result = MessageBox.Show("Vil du avslutte programmet?", "Avslutt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mnuHjelp_Click_1(sender As Object, e As EventArgs) Handles mnuHjelp.Click 'Åpner hjelp meldingen, her får du oversikt over rekke funksjoner.
        MessageBox.Show("Skriv inn tallene i teksboksene. " _
                & "Også klikker du på knappene med enten +,-,/,X. Så får du resultatet under erlik tegnet.", "Hjelp",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click 'Når knappen trykkes så vil det ble et tilfeldig generert et tall i hver tekstboks
        Dim Felt1 As Double
        Dim Felt2 As Double

        Randomize() 'Selve funksjonen som genererer tallet

        Felt1 = Rnd() * 100 'Dette gjør at tallet blir tilfeldig generert via klokke slett, då vil ikke det bli det samme tallet hele tiden
        Felt2 = Rnd() * 100

        txtFelt1.Text = Math.Round(Felt1) 'Denne funksjonen gjør at tallet blir avrundet, eller så ville tallet ha flere desimaler.
        txtFelt2.Text = Math.Round(Felt2)
    End Sub
End Class