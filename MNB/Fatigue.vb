Public Class Fatigue

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Timer2.Enabled = True
        MsgBox("You are showing symptoms of Malaria", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Timer3.Enabled = True
        MsgBox("You must be really sure of your symptoms.please try again", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Fatigue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Do you have some fatigue?")
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You are showing symptoms of Malaria")
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You must be really sure of your symptoms.please try again")
        Timer3.Stop()
    End Sub
End Class