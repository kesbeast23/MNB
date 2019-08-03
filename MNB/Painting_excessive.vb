Public Class Painting_excessive

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Timer2.Enabled = True
        MsgBox("Your Dog is showing symptoms of a liver disease", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Timer3.Enabled = True
        MsgBox("You should be sure your Dog is showing symptoms.Please try again", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Painting_excessive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Is your dog painting excessively?")
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Your Dog is showing symptoms of a liver disease")
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You should be sure your Dog is showing symptoms.Please try again")
        Timer3.Stop()
    End Sub
End Class