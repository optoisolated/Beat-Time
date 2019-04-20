Module BeatTime
    Function GetTimeZoneBias() 'Gets the current time zone offset from the OS
        Dim objWMIService = GetObject("winmgmts:\\.\root\cimv2")
        Dim colItems = objWMIService.ExecQuery("Select * From Win32_TimeZone")
        Dim rslt As Integer
        For Each objItem In colItems
            rslt = objItem.Bias * 60
        Next
        Return rslt
    End Function

    Function GetBeatTime(numdec As Integer) As String
        'Initial Calculations
        Dim YourOffset = GetTimeZoneBias()
        Dim YourOffsetH = GetTimeZoneBias() / 3600
        Dim UTCplus1 = 3600 - YourOffset
        Dim UTCplus1H = UTCplus1 / 3600

        Dim OffsetSign As String = ""
        Dim UTCplus1Sign As String = ""

        'Do the conversion
        Dim OffsetTime = DateAdd("s", UTCplus1, Now())
        Dim BeatTime = ((OffsetTime.Millisecond / 1000) + DatePart("s", OffsetTime) + DatePart("n", OffsetTime) * 60 + DatePart("h", OffsetTime) * 3600) / 86.4

        'Work out the signings (just to make things look pretty)
        If YourOffset < 0 Then OffsetSign = "-" Else OffsetSign = "+"
        If UTCplus1H < 0 Then UTCplus1Sign = "behind" Else UTCplus1Sign = "ahead of"

        'Output Beat Time
        'WScript.Echo "You are " & Abs(UTCplus1H) & " hours " & UTCPlus1Sign & " UTC+1 (UTC" & OffsetSign & YourOffsetH & ")"

        If BeatTime > 999.99 Then
            Return FormatNumber(0, numdec)
        Else
            Return FormatNumber(BeatTime, numdec)
        End If
    End Function

End Module
