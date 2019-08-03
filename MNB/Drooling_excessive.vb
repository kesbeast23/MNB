Public Class Drooling_excessive

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Aggression.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Timer2.Enabled = True
        MsgBox("You should be sure of your dog's symptoms.Please try again...", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Drooling_excessive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Does your Dog drool excessively?")
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You should be sure of your dog's symptoms.Please try again...")
        Timer2.Stop()
    End Sub
End Class