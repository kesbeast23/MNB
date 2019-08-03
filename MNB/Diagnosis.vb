Public Class Diagnosis

    Private Sub ProceedButton_Click(sender As Object, e As EventArgs) Handles ProceedButton.Click
        fever.Show()
        Me.Hide()
    End Sub

    Private Sub Diagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You will be asked a series of questions...")
        Timer1.Stop()
    End Sub
End Class