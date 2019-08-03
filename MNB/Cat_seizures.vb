Public Class Cat_seizures

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Timer2.Enabled = True
        MsgBox("Your Cat is showing symptoms of Panleukopenia", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Cat_sneezing.Show()
        Me.Hide()
    End Sub

    Private Sub Cat_seizures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Does your cat have any seizures?")
        Timer1.Stop()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Your Cat is showing symptoms of Panleukopenia")
        Timer2.Stop()
    End Sub
End Class