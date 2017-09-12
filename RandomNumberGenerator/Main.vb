Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data

Public Class Main

    Dim ravenClient = New RavenClient("https://70c460dc237841ba8dfb44b366326cf1:6778d55f32b04c51a8540f25808ee1d7@sentry.io/216241")

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '// See SDK documentation for language specific usage.
            ravenClient.config()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim randomValue1 = CInt(Math.Floor((1 - 69 + 1) * Rnd())) + 69
            TextBox1.Text = randomValue1
            Dim randomValue2 = CInt(Math.Floor((1 - 69 + 1) * Rnd())) + 69
            TextBox2.Text = randomValue2
            Dim randomValue3 = CInt(Math.Floor((1 - 69 + 1) * Rnd())) + 69
            TextBox3.Text = randomValue3
            Dim randomValue4 = CInt(Math.Floor((1 - 69 + 1) * Rnd())) + 69
            TextBox4.Text = randomValue4
            Dim randomValue5 = CInt(Math.Floor((1 - 69 + 1) * Rnd())) + 69
            TextBox5.Text = randomValue5
            Dim randomValue6 = CInt(Math.Floor((1 - 26 + 1) * Rnd())) + 26
            TextBox6.Text = randomValue6
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            YUCLICKME.Show()
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class
