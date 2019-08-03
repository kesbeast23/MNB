Public Class AbdominalCramps

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Constipation.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Timer2.Enabled = True
        MsgBox("You are symptoms of Cholera", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub AbdominalCramps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Do you have any abdominal cramps?")
        Timer1.Stop()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You are symptoms of Cholera")
        Timer2.Stop()
    End Sub
End Class