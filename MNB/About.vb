Public Class About

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("K5824 General Medical Diagnosis system is an extension to a person's health.")
        Voice.Speak("I am a significant necessity in the life we leave today.")
        Voice.Speak("A way we can keep up as Botswana.")
        Voice.Speak("I can get how the user is feeling and help identify the problem.")
        Voice.Speak("I am not only able to diagnose human diseases but also those of our pets,specifically the cat and the dog.")
        Voice.Speak("I was created by a young computer enthusiast.Who believes he can use technology to solve the problems that the world faces everyday.")
        Voice.Speak("He believes he can use technology to change the way we see the world")
        Voice.Speak("It is his passion and innovation that drives him and he wpuld like to thank you for using  me")
        Voice.Speak("You are part of something big..")
        Timer1.Stop()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
