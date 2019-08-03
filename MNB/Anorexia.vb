Public Class Anorexia

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Cat_drooling.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Cat_nervous.Show()
        Me.Hide()
    End Sub

    Private Sub Anorexia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Does your cat have Anorexia?")
        Timer1.Stop()
    End Sub
End Class