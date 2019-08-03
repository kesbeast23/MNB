Public Class fever

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Dim objformVomiting As New Vomiting()
        objformVomiting.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Dim objformDiarrhoea As New Diarrhoea()
        objformDiarrhoea.Show()
        Me.Hide()
    End Sub

    Private Sub fever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Do you have fever?")
        Timer1.Stop()
    End Sub
End Class