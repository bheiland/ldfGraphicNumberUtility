Module Strings
    Const GROUPSEP As Integer = 29
    Const RECSEP As Integer = 30
    Const UNITSEP As Integer = 31
    Public Function FoundStringPositon(ByVal StartPoint As Integer, ByVal SearchString As String, ByVal SearchChar As String)
        FoundStringPositon = InStr(StartPoint, SearchString, SearchChar, CompareMethod.Binary)
    End Function

    Public Function ParseRecord(ByVal Record As String) As String()
        Dim GroupSepA As Integer
        Dim GroupSepB As Integer
        Dim CurrentLine As String
        Dim LineData() As String
        Dim LineCount As Integer

        LineCount = 0
        ReDim Preserve LineData(1)
        LineData(LineCount) = ""
        GroupSepA = 0
        GroupSepB = FoundStringPositon(GroupSepA + 1, Record, Chr(GROUPSEP))
        Do While GroupSepB > 0

            GroupSepB = FoundStringPositon(GroupSepA + 1, Record, Chr(GROUPSEP))
            If (GroupSepB > 0) Then
                CurrentLine = Mid(Record, GroupSepA + 1, GroupSepB - (GroupSepA + 1))
                ReDim Preserve LineData(0 To LineCount)
                LineData(LineCount) = ""
                LineData(LineCount) = CurrentLine
                LineCount += 1
            Else
                If (GroupSepA + 1 < Len(Record)) Then
                    CurrentLine = (Mid(Record, GroupSepA + 1, Record.Length - (GroupSepA)))
                    ReDim Preserve LineData(0 To LineCount)
                    LineData(LineCount) = ""
                    LineData(LineCount) = CurrentLine '  last line found
                Else
                    ReDim Preserve LineData(0 To LineCount)
                    LineData(LineCount) = ""
                End If
            End If
                GroupSepA = GroupSepB
        Loop
        'Do While LineCount < 128
        '    LineCount += 1
        '    ReDim Preserve LineData(0 To LineCount)
        '    LineData(LineCount) = ""
        'Loop
        Return LineData
    End Function
    Function str_to_hex(p_str As Object) As Object
        Dim x As Long
        Dim resp As Object
        Dim tmp As String
        resp = vbNull
        For x = 1 To Len(p_str)
            tmp = Mid$(p_str, x, 1)
            resp = Hex(Asc(tmp))
        Next
        str_to_hex = resp
    End Function


End Module
