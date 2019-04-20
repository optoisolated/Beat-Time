Public Class frmBeatTime
    Const SnapSize = 25
    Private Sub tmrBeat_Tick(sender As Object, e As EventArgs) Handles tmrBeat.Tick
        UpdateDateTimes()
    End Sub

    Sub UpdateDateTimes()
        lblBeatTime.Text = "@" & GetBeatTime(2)
        'lblDateTime.Text = FormatDateTime(Now, DateFormat.GeneralDate) '& " (+" & FormatNumber(Now.Millisecond, 0) & " msec)"
        pbTime.Value = GetBeatTime(2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
        myProcess.PriorityClass = System.Diagnostics.ProcessPriorityClass.Idle

        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 5
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height + 5

        UpdateDateTimes()
    End Sub

    Private Sub frmBeatTime_Move(sender As Object, e As EventArgs) Handles Me.Move
        For Each screen As Screen In screen.AllScreens
            Dim rect As Rectangle = screen.WorkingArea

            If Me.Left <= rect.Left + SnapSize AndAlso Me.Left > rect.Left - SnapSize Then
                Me.Left = rect.Left
            ElseIf Me.Right >= rect.Right - SnapSize AndAlso Me.Right < rect.Right + SnapSize Then
                Me.Left = rect.Right - Me.Width
            End If

            If Me.Top <= rect.Top + SnapSize AndAlso Me.Top > rect.Top - SnapSize Then
                Me.Top = rect.Top
            ElseIf Me.Bottom >= rect.Bottom - SnapSize AndAlso Me.Bottom < rect.Bottom + SnapSize Then
                Me.Top = rect.Bottom - Me.Height
            End If
        Next
    End Sub
End Class
