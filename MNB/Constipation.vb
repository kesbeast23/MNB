Public Class Constipation

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Timer2.Enabled = True
        MsgBox("You are symptoms of Shingellois", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Timer3.Enabled = True
        MsgBox("You are showing symptoms of Irritable Bowel Syndrome(IBS)", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Constipation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Are you experiencing some constipation?")
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You are symptoms of Shingellois?")
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You are showing symptoms of Irritable Bowel Syndrome(IBS)")
        Timer3.Stop()
    End Sub
End Class