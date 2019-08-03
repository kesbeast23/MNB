Public Class frmMenu

    Shared Property open As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AnimalButton.Click
        Pet.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Hide()
        Timer2.Stop()
    End Sub

    Private Sub personButton_Click(sender As Object, e As EventArgs) Handles personButton.Click
        Dim objformDiagnosis As New Diagnosis()
        objformDiagnosis.Show()
        Me.Hide()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Voice
        Voice = CreateObject("SAPI.spvoice")
        Voice.Speak("welcome to K5824 General Medical Diagnosis system")
        Voice.Speak("How can i help you?")
        Timer2.Stop()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkAutoSlide_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAutoSlide.CheckedChanged
        If ChkAutoSlide.Checked = True Then
            Timer3.Enabled = True
        Else
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ' create a number between a certain value and becomes the interval

        Dim max As Integer = 5000
        Dim rnd As New Random

        Dim rand As Integer = rnd.Next(10, max + 1)

        Dim i As Integer = 1

        Dim number(max - 1) As Integer



        For i = 0 To max - 1

            If number(i) = rand Then

                rand = rnd.Next(1, max + 1)

                i = -1

            ElseIf number(i) = 0 Then

                number(i) = rand

                rand = rnd.Next(1, max + 1)

                If i = max - 1 Then

                    Exit For

                End If

                i = -1

            End If

        Next

        Timer3.Interval = number(i)

        i += 1

        ChangeImage()

    End Sub

    Private Sub ChangeImage()


        Static Dim iImage1 As Integer



        Select Case iImage1
            Case 0



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img1

                iImage1 += 1

            Case 1



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img1

                iImage1 += 1

            Case 2



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img5

                iImage1 += 1

            Case 3



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img2

                iImage1 += 1

            Case 4



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img3

                iImage1 += 1

            Case 5



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img4

                iImage1 += 1

            Case 6



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img7

                iImage1 += 1

            Case 7



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img6

                iImage1 += 1

            Case 8



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img8

                iImage1 += 1

            Case 9



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img10

                iImage1 += 1

            Case 10



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img9

                iImage1 += 1

            Case 11



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img12

                iImage1 += 1

            Case 12



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.hjghgc___Copy

                iImage1 += 1

            Case 13



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.zcx

                iImage1 += 1

            Case 14



                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.ad

                iImage1 += 1

            Case 15


                pbNewImage.Visible = True

                pbNewImage.Image = My.Resources.img12

                iImage1 = 0


        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class