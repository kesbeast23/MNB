Public Class Cat_weightloss

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Anorexia.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Cat_nasal_discharge.Show()
        Me.Hide()
    End Sub

    Private Sub Cat_weightloss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Did your cat lose weight?")
        Timer1.Stop()
    End Sub
End Class