Public Class Pet

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        If Me.DogRadioButton.Checked = True Then
            Dog_vomiting.Show()
            Me.Close()
        ElseIf Me.CatRadioButton.Checked = True Then
            Cat_weightloss.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Pet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Choose the pet you want me to diagnose")
        Timer1.Stop()
    End Sub
End Class