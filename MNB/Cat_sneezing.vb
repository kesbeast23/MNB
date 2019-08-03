Public Class Cat_sneezing

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Timer2.Enabled = True
        MsgBox("Your Cat is showing symptoms of Cat Flu", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Timer3.Enabled = True
        MsgBox("You should be sure of your cat's symptoms.Please try again...", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Cat_sneezing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Does your cat sneeze alot?")
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Your Cat is showing symptoms of Cat Flu")
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You should be sure of your cat's symptoms.Please try again...")
        Timer3.Stop()
    End Sub
End Class