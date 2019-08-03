Public Class Vomit

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Dim objformAbdominalCramps As New AbdominalCramps()
        objformAbdominalCramps.Show()
        Me.Hide()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Timer2.Enabled = True
        MsgBox("You must be sure of your symtoms..please try again", MsgBoxStyle.Information, "Conclusion")
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Vomit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("Do you vomit?")
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("You must be sure of your symtoms..please try again")
        Timer2.Stop()
    End Sub
End Class