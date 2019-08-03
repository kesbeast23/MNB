Public Class Dog_vomiting

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Excessive_drinking.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Depression.Show()
        Me.Hide()
    End Sub

    Private Sub Dog_vomiting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Does your dog vomit?")
        Timer1.Stop()
    End Sub
End Class