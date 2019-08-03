Public Class Diarrhoea

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Dim objformVomit As New Vomit()
        objformVomit.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Dim objformStiffNeck As New StiffNeck()
        objformStiffNeck.Show()
        Me.Hide()
    End Sub

    Private Sub Diarrhoea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Do you have diarrhea?")
        Timer1.Stop()
    End Sub
End Class