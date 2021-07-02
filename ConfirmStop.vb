Public Class ConfirmStop

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click


        System.IO.File.WriteAllText(Form1.writePath.Text, Form1.logInfo)
        Form1.StopLogging()

        'Me.Close()

    End Sub

    Public Sub Wait(milliseconds As Integer)
        'Dim t As New Timer
        Dim currentTime As Integer = 0
        't.Start()

        While Not currentTime = milliseconds
            currentTime += 1
        End While

    End Sub
End Class