Public Class Excessive_drinking

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Hair_loss.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Bloody_stool.Show()
        Me.Hide()
    End Sub

    Private Sub Excessive_drinking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Does your Dog drink excessively?")
        Timer1.Stop()
    End Sub
End Class