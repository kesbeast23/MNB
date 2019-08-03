Public Class Vomiting

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Dim objformNasal_Congestion As New Nasal_Congestion()
        objformNasal_Congestion.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Dim objformFatigue As New Fatigue()
        objformFatigue.Show()
        Me.Hide()
    End Sub

    Private Sub Vomiting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Do you vomit?")
        Timer1.Stop()
    End Sub
End Class