Public Class Depression

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Coughing.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Drooling_excessive.Show()
        Me.Hide()
    End Sub

    Private Sub Depression_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Does your dog look depressed?")
        Timer1.Stop()
    End Sub
End Class