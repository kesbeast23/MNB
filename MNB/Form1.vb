Imports System.IO
Imports System.Net.Sockets

Public Class Form1

    Dim Listener As New TcpListener(44444)
    Dim client As TcpClient
    Dim message As String = ""
    Dim tts

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Listener.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listener.Start()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Listener.Pending = True Then
                message = ""
                client = Listener.AcceptTcpClient()
                Dim reader As New StreamReader(client.GetStream())
                While reader.Peek > -1
                    message = message + Convert.ToChar(reader.Read()).ToString
                End While
                Me.Focus()
                TextBox4.Text = (TextBox4.Text + message + vbCrLf)
                tts = CreateObject("sapi.spvoice")
                tts.speak(message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Enter name,enter IP address and enter message.", MsgBoxStyle.Exclamation)
            Else
                client = New TcpClient(TextBox2.Text, 44444)
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write(TextBox1.Text + "says:" + TextBox3.Text)
                writer.Flush()
                TextBox3.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
