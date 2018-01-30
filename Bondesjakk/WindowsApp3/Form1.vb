Public Class frmTicTacToe
    Public Green = RGB(0, 255, 0)
    Private Sub mnuShoutout_Click(sender As Object, e As EventArgs) Handles mnuShoutout.Click 'Bringer opp meldingen for midler jeg brukte for å fullføre programmet.
        MessageBox.Show("Shoutout and thanks to Stack Overflow a site where learn, share and build careers. " _
                        & "Also thanks to Softicons for the icon to this program", caption:="Shoutout")
    End Sub

    Private Sub mnuHjelp_Click(sender As Object, e As EventArgs) 'Bringer opp meldingen for hvordan programmet brukes.
        MessageBox.Show("Et klikk med musetasten = X. " _
                        & "Dobbel klikk med musetasten = O.", caption:="Hjelp")
    End Sub

    Private Sub mnuAvslutt_Click(sender As Object, e As EventArgs) Handles mnuAvslutt.Click 'Når knappen i menyen klikkes på så kommer opp meldingen for om du vil avluttet programmet, hvis ja så stenges programmet.
        Dim result = MessageBox.Show("Vil du avslutte programmet?", "Bondesjakk", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub RandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandomToolStripMenuItem.Click 'Når knappen trykkes så vil alle rutene bli fyllt ut helt tilfeldig (Ikke ment for å være rettferdig!)
        Dim value1 As Integer 'Setter disse verdiene som tall
        Dim value2 As Integer
        Dim value3 As Integer
        Dim value4 As Integer
        Dim value5 As Integer
        Dim value6 As Integer
        Dim value7 As Integer
        Dim value8 As Integer
        Dim value9 As Integer

        Randomize() 'Selve funksjonen til å generere tall

        value1 = Math.Round(Rnd() * 100)
        value2 = Math.Round(Rnd() * 100)
        value3 = Math.Round(Rnd() * 100)
        value4 = Math.Round(Rnd() * 100)
        value5 = Math.Round(Rnd() * 100)
        value6 = Math.Round(Rnd() * 100)
        value7 = Math.Round(Rnd() * 100)
        value8 = Math.Round(Rnd() * 100)
        value9 = Math.Round(Rnd() * 100)

        If value1 < 49 Then 'Grunnen til 49 er pga. det er ikke muligt å få tallet 100, men hvis tallet er 49 eller under så blir det X hvis høyere så O
            lblRute1.Text = "X"
        Else
            lblRute1.Text = "O"
        End If

        If value2 < 49 Then
            lblRute2.Text = "X"
        Else
            lblRute2.Text = "O"
        End If

        If value3 < 49 Then
            lblRute3.Text = "X"
        Else
            lblRute3.Text = "O"
        End If

        If value4 < 49 Then
            lblRute4.Text = "X"
        Else
            lblRute4.Text = "O"
        End If

        If value5 < 49 Then
            lblRute5.Text = "X"
        Else
            lblRute5.Text = "O"
        End If

        If value6 < 49 Then
            lblRute6.Text = "X"
        Else
            lblRute6.Text = "O"
        End If

        If value7 < 49 Then
            lblRute7.Text = "X"
        Else
            lblRute7.Text = "O"
        End If

        If value8 < 49 Then
            lblRute8.Text = "X"
        Else
            lblRute8.Text = "O"
        End If

        If value9 < 49 Then
            lblRute9.Text = "X"
        Else
            lblRute9.Text = "O"
        End If
    End Sub

    Private Sub lblRute1_Click(sender As Object, e As EventArgs) Handles lblRute1.Click 'Alt under er hvis du klikker en eller to gagner så får du X eller O (Det er en helt nede)
        lblRute1.Text = "X"
    End Sub

    Private Sub lblRute1_DoubleClick(sender As Object, e As EventArgs) Handles lblRute1.DoubleClick
        lblRute1.Text = "O"
    End Sub

    Private Sub lblRute2_Click(sender As Object, e As EventArgs) Handles lblRute2.Click
        lblRute2.Text = "X"
    End Sub

    Private Sub lblRute2_DoubleClick(sender As Object, e As EventArgs) Handles lblRute2.DoubleClick
        lblRute2.Text = "O"
    End Sub

    Private Sub lblRute3_Click(sender As Object, e As EventArgs) Handles lblRute3.Click
        lblRute3.Text = "X"
    End Sub

    Private Sub lblRute3_DoubleClick(sender As Object, e As EventArgs) Handles lblRute3.DoubleClick
        lblRute3.Text = "O"
    End Sub

    Private Sub lblRute4_Click(sender As Object, e As EventArgs) Handles lblRute4.Click
        lblRute4.Text = "X"
    End Sub

    Private Sub lblRute4_DoubleClick(sender As Object, e As EventArgs) Handles lblRute4.DoubleClick
        lblRute4.Text = "O"
    End Sub

    Private Sub lblRute5_Click(sender As Object, e As EventArgs) Handles lblRute5.Click
        lblRute5.Text = "X"
    End Sub

    Private Sub lblRute5_DoubleClick(sender As Object, e As EventArgs) Handles lblRute5.DoubleClick
        lblRute5.Text = "O"
    End Sub
    Private Sub lblRute6_Click(sender As Object, e As EventArgs) Handles lblRute6.Click
        lblRute6.Text = "X"
    End Sub

    Private Sub lblRute6_DoubleClick(sender As Object, e As EventArgs) Handles lblRute6.DoubleClick
        lblRute6.Text = "O"
    End Sub

    Private Sub lblRute7_Click(sender As Object, e As EventArgs) Handles lblRute7.Click
        lblRute7.Text = "X"
    End Sub

    Private Sub lblRute7_DoubleClick(sender As Object, e As EventArgs) Handles lblRute7.DoubleClick
        lblRute7.Text = "O"
    End Sub

    Private Sub lblRute8_Click(sender As Object, e As EventArgs) Handles lblRute8.Click
        lblRute8.Text = "X"
    End Sub

    Private Sub lblRute8_DoubleClick(sender As Object, e As EventArgs) Handles lblRute8.DoubleClick
        lblRute8.Text = "O"
    End Sub

    Private Sub lblRute9_Click(sender As Object, e As EventArgs) Handles lblRute9.Click
        lblRute9.Text = "X"
    End Sub

    Private Sub lblRute9_DoubleClick(sender As Object, e As EventArgs) Handles lblRute9.DoubleClick
        lblRute9.Text = "O"
    End Sub

    Private Sub btnNyRunde_Click(sender As Object, e As EventArgs) Handles btnNyRunde.Click 'Gjør at alle rutene blir klarert og klar til bruk igjen
        lblRute1.Text = ""
        lblRute2.Text = ""
        lblRute3.Text = ""
        lblRute4.Text = ""
        lblRute5.Text = ""
        lblRute6.Text = ""
        lblRute7.Text = ""
        lblRute8.Text = ""
        lblRute9.Text = ""
    End Sub
End Class
