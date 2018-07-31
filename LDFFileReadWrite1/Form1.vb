Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections

Public Class Form1
    Const GROUPSEP As Integer = 29
    Const RECSEP As Integer = 30
    Const UNITSEP As Integer = 31
    Dim CharCountsTotal(255) As Long
    Dim PixelsPerChar(255) As Long
    Dim PixelsPerCharWithSkip(255) As Long
    Dim UniqueBitmapCodes() As String
    Dim BitmapRecordNumberFirstOccurance() As Long
    Dim DataLineStringLongest() As String
    Dim DataLineLongestRecordNumber() As Long
    Dim BitmapCounts() As Long
    Dim BitmapPaths() As String
    Dim BitmapDarkPixels() As Long
    Dim BitmapDarkPixelsWithSkip() As Long
    Dim Filepaths() As String
    Dim BitmapElements As Integer = 0
    Dim clickedindex As Integer = 0
    Dim lookupDict As New Dictionary(Of String, String)()
    Dim missingCodeDictionary As New Dictionary(Of String, String)()
    Dim calculatedMostLinesFilled As Int32
    Dim firstVersionOccuranceNonGraphic As New Dictionary(Of String, Integer)()


    Dim runOnce As Boolean = True
    Dim firstOccurancePath As String = "c:\FirstOccuranceFile"
    ' Dim firstrun As Boolean = False

    Private m_SortingColumn As ColumnHeader



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arr(3) As String
        ListViewCharacters.View = View.Details
        ListViewCharacters.GridLines = True
        ListViewCharacters.FullRowSelect = True
        ListViewCharacters.Columns.Add("Column1", 60)
        ListViewCharacters.Columns.Add("Column2", 60)
        ListViewCharacters.Columns.Add("Column3", 70)
        ListViewCharacters.Columns.Add("Column4", 70)
        ListViewCharacters.Columns.Add("Column5", 100)
        ListViewCharacters.Columns.Add("Column6", 60)
        ListViewCharacters.Columns.Add("Column7", 60)

        ListViewDictionary.View = View.Details
        ListViewDictionary.GridLines = True
        ListViewDictionary.FullRowSelect = True
        ListViewDictionary.Columns.Add("Key", 60)
        ListViewDictionary.Columns.Add("Char", 60)
        ListViewDictionary.Columns.Add("Hex", 60)
        ListViewDictionary.Columns.Add("Value", 60)
        Dim tt As New ToolTip()

        ListViewUndefinedCodes.View = View.Details
        ListViewUndefinedCodes.GridLines = True
        ListViewUndefinedCodes.FullRowSelect = True
        ListViewUndefinedCodes.Columns.Add("Missing Codes", 120)

        ListViewGraphics.View = View.Details
        ListViewGraphics.GridLines = True
        ListViewGraphics.FullRowSelect = True
        ListViewGraphics.Columns.Add("String", 70)
        ListViewGraphics.Columns.Add("Count", 70)
        'ListViewGraphics.Columns.Add("Pixels/Bitmap", 50)

        'ListViewGraphics.Columns.Add("Pixels/Total", 60)
        'ListViewGraphics.Columns.Add("Ink/pl", 80)
        'ListViewGraphics.Columns.Add("Ink/ml", 80)
        'ListViewGraphics.Columns.Add("Bitmap Path", 100)
        ListViewGraphics.Columns.Add("First Occurance", 100)


        'TextBox2.Text = ""
        'If runOnce = True Then
        '    runOnce = False
        '    lookupDict.Add("0001", "a")
        '    lookupDict.Add("0002", "b")
        '    lookupDict.Add("0003", "b")
        '    lookupDict.Add("0004", "d")
        '    lookupDict.Add("0005", "e")
        '    lookupDict.Add("0006", "f")
        '    lookupDict.Add("0007", "g")
        '    lookupDict.Add("0008", "h")
        '    lookupDict.Add("0009", "i")
        '    lookupDict.Add("0010", "j")
        'End If
        'For Each ikey As String In lookupDict.Keys

        '    arr(0) = ikey
        '    arr(1) = lookupDict(ikey)
        '    arr(2) = str_to_hex(lookupDict(ikey))

        '    Dim item = New ListViewItem(arr)

        '    ListViewDictionary.Items.Add(item)
        'Next
        ' Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonSelectFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectFile.Click


        'OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Filter = "txt files (*.txt|*.txt|All Files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Title = "Please Selected an LDF File"

        OpenFileDialog1.ShowDialog()





    End Sub


    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Filepaths = OpenFileDialog1.FileNames
        LabelFileName.Text = OpenFileDialog1.FileName
        ButtonScan.Enabled = True
        ShowRecord(1)
    End Sub


    Private Sub ButtonScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonScan.Click
        'Dim FileToOpen As String
        Dim LDFReader As StreamReader
        ' Dim LDFWriter As StreamWriter
        Dim LDFWriterPath As String
        ' Dim DataWriter As StreamWriter
        Dim dataWriterPath As String = "C:\jobs\test.txt"
        Dim FoundRecordStart As Integer
        Dim FoundRecordEnd As Integer
        Dim ActiveRecord As String
        Dim PartialBuffer As String
        Dim BufferLength As Integer = 4096 '4096 '8192
        Dim Buffer(BufferLength) As Char
        Dim BufferString As String
        Dim BufferCount As Integer
        Dim CompleteRecordFound As Boolean
        Dim RecordCount As Integer
        Dim LineData(144) As String
        Dim TextBoxLabel As String
        Dim OutputRecordLabel As String
        Dim index As Integer
        Dim CharCounts(255) As Long
        ' Dim charIndex As Integer
        Dim arr(6) As String
        Dim boolLdfReaderUsed As Boolean
        Dim bitmapName As String
        boolLdfReaderUsed = False
        ReDim CharCountsTotal(255)
        ReDim BitmapCounts(0)
        ReDim DataLineStringLongest(0)
        ReDim DataLineLongestRecordNumber(0)
        ListViewCharacters.Items.Clear()
        Dim filepath As String
        Dim BitmapIndex As Integer
        Dim BitmapNameFound As Boolean = False
        ' Dim counts As Integer
        'Dim startRecord As Integer
        ' Dim endRecord As Integer
        Dim ldfRecordNumber As Integer
        Dim ldfRecordHeaderVersion As String
        Dim CountRecord As Boolean

        'Dim DataFromLineToCheckLength As String
        Dim LineToCheckLength As Integer = 3
        ' Dim DataFromAlternateLineToCheckLength As String
        Dim AlternateLineToCheckLength = 2
        Dim StringToOutput As String = ""
        Dim wStream = Nothing
        Dim labelLength As Integer
        Dim firstoccuranceLDFstring As String = ""
        Dim FirstOccurance As Boolean = False
        Dim firstVersionOccurance As Boolean = False
        Dim filepath1 As FileInfo

        Dim mostFilledLinesOfData(64) As String
        Dim mostFilledLinesOfDataValue(64) As Int32
        Dim mostFilledLinesOfDataIndex As Integer

        Static Dim warned As Boolean
        Static Dim warned2 As Boolean
        mostFilledLinesOfDataIndex = 0

        UniqueBitmapCodes(0) = vbNull
        missingCodeDictionary.Clear()
        firstVersionOccuranceNonGraphic.Clear()
        ListViewUndefinedCodes.Items.Clear()
        BitmapElements = 0
        warned = False
        warned2 = False
        For Each filepath In Filepaths
            LabelFileName.Text = filepath
            BufferCount = 0
            RecordCount = 0
            FoundRecordStart = 1
            PartialBuffer = ""
            ButtonScan.Enabled = False
            My.Application.DoEvents()
            'LDFReader = New StreamReader(LabelFileName.Text)
            LDFReader = New StreamReader(filepath, System.Text.Encoding.Default, True)
            Dim fileInfo As New FileInfo(filepath)
            filepath1 = fileInfo
            LDFWriterPath = fileInfo.Directory.ToString + "\ModifiedFiles\"
            If Not Directory.Exists(LDFWriterPath) Then
                Directory.CreateDirectory(LDFWriterPath)
            End If

            LDFWriterPath = LDFWriterPath + fileInfo.Name
            firstOccurancePath = fileInfo.Directory.ToString + "\ModifiedFiles\" + "FirstOccurrenceFile.txt"
            wStream = New FileStream(LDFWriterPath, FileMode.OpenOrCreate, FileAccess.Write)
            Using LDFWriter As StreamWriter = New StreamWriter(wStream, Encoding.Default)
                ' MessageBox.Show(LDFWriterPath)
                NumericUpDownLineToReplace.Enabled = False
                If Not (LDFReader Is Nothing) Then
                    While LDFReader.Peek() >= 0
                        ReDim Buffer(BufferLength)
                        LDFReader.ReadBlock(Buffer, 0, Buffer.Length - 1)
                        CompleteRecordFound = True
                        BufferCount += 1
                        BufferString = Buffer
                        BufferString = PartialBuffer & BufferString

                        My.Application.DoEvents()
                        While CompleteRecordFound = True
                            FoundRecordEnd = FoundStringPositon(FoundRecordStart + 2, BufferString, Chr(RECSEP).ToString)
                            If FoundRecordEnd > 0 Then
                                CompleteRecordFound = True
                                ActiveRecord = Mid$(BufferString, FoundRecordStart, FoundRecordEnd - FoundRecordStart)
                                FoundRecordStart = FoundRecordEnd
                                RecordCount += 1
                                LineData = ParseRecord(ActiveRecord)
                                ldfRecordNumber = Val(Mid(LineData(0), 4, 9))
                                ldfRecordHeaderVersion = Mid(LineData(0), 36, 12).Trim


                                Dim smatch As Boolean = ((Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) Like "####")
                                If smatch = True Then
                                    If lookupDict.ContainsKey(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) = True Then
                                        If warned2 = False Then

                                            If (Not String.IsNullOrWhiteSpace(LineData(NumericUpDownLineToReplace.Value))) Then
                                                MessageBox.Show("CAUTION replacing non empty line of data '" + LineData(NumericUpDownLineToReplace.Value) + "' You will only be warned once!")
                                                warned2 = True
                                            End If
                                        End If
                                        If (Int(lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4))) > 255) Then
                                            LineData(NumericUpDownLineToReplace.Value) = "^PF" + TextBox2.Text + "^X" + Chr(Int(lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) Mod 255))
                                        Else

                                            LineData(NumericUpDownLineToReplace.Value) = Chr(Int(lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) Mod 255))
                                        End If
                                        'LineData(NumericUpDownLineToReplace.Value) = lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4))
                                        'LineData(32) = LineData(32) + Chr(GROUPSEP)
                                    Else
                                        If missingCodeDictionary.ContainsKey(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) = True Then
                                            warned = True
                                        Else
                                            missingCodeDictionary.Add(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4), " ")
                                            warned = False
                                            ListViewUndefinedCodes.Items.Add(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4))
                                        End If
                                        If warned = False Then

                                            'warned = True
                                            MessageBox.Show("No dictionary entry for " + Microsoft.VisualBasic.Left(LineData(17), 4) + " There will be only one warning per code")
                                        End If

                                    End If
                                Else
                                    'this record does not have four digit code check for first occurance of version
                                    If firstVersionOccuranceNonGraphic.ContainsKey(ldfRecordHeaderVersion) = True Then
                                        firstVersionOccurance = False
                                    Else
                                        firstVersionOccuranceNonGraphic.Add(ldfRecordHeaderVersion, mostFilledLinesOfDataIndex)
                                        mostFilledLinesOfDataIndex += 1
                                        firstVersionOccurance = True
                                    End If
                                End If


                                If ldfRecordNumber >= Val(TextBoxStartRecord.Text) And ldfRecordNumber <= Val(TextBoxEndRecord.Text) Then
                                    CountRecord = True
                                Else
                                    CountRecord = False
                                End If
                                'DataFromLineToCheckLength = LineData(LineToCheckLength).Trim
                                'If Len(DataFromLineToCheckLength) > 19 Then
                                '    Debug.Print(ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(19).Trim)
                                '    TextBox2.Text = ldfRecordNumber & "," & TextBox2.Text
                                '    StringToOutput = StringToOutput & ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(19).Trim & vbCrLf
                                'End If
                                bitmapName = LineData(NumericUpDownGraphicLineToScan.Value).Trim
                                FirstOccurance = False
                                If Len(bitmapName) > 0 And CountRecord Then
                                    ReDim Preserve UniqueBitmapCodes(BitmapElements)
                                    ReDim Preserve BitmapCounts(BitmapElements)
                                    ReDim Preserve BitmapDarkPixels(BitmapElements)
                                    ReDim Preserve BitmapDarkPixelsWithSkip(BitmapElements)
                                    ReDim Preserve BitmapPaths(BitmapElements)
                                    BitmapNameFound = False
                                    For BitmapIndex = 0 To BitmapElements
                                        If bitmapName = UniqueBitmapCodes(BitmapIndex) Then
                                            BitmapCounts(BitmapIndex) += 1
                                            BitmapNameFound = True
                                            FirstOccurance = False
                                            Exit For
                                        End If
                                    Next
                                    If (BitmapNameFound = False) And (smatch = True) Then
                                        ReDim Preserve UniqueBitmapCodes(BitmapElements)
                                        ReDim Preserve BitmapRecordNumberFirstOccurance(BitmapElements)
                                        ReDim Preserve DataLineStringLongest(BitmapElements)
                                        ReDim Preserve DataLineLongestRecordNumber(BitmapElements)
                                        UniqueBitmapCodes(BitmapIndex - 1) = bitmapName.ToString
                                        BitmapRecordNumberFirstOccurance(BitmapIndex - 1) = ldfRecordNumber
                                        'DataLineLongestRecordNumber(BitmapIndex - 1) = ldfRecordNumber
                                        'DataLineStringLongest(BitmapIndex - 1) = ((LineData(NumericUpDownLineToScan.Value).ToString).Trim)
                                        BitmapCounts(BitmapIndex - 1) = 1
                                        BitmapElements += 1
                                        FirstOccurance = True
                                    Else
                                        '        Dim tempstring As String = (LineData(NumericUpDownLineToScan.Value).ToString).Trim
                                        '        If Len((LineData(NumericUpDownLineToScan.Value).ToString).Trim) > Len(DataLineStringLongest(BitmapIndex)) Then
                                        '            DataLineLongestRecordNumber(BitmapIndex) = ldfRecordNumber
                                        '            DataLineStringLongest(BitmapIndex) = ((LineData(NumericUpDownLineToScan.Value).ToString).Trim)
                                        '        End If
                                        '        If tempstring.Length > 0 Then
                                        '            If tempstring.Substring(tempstring.Length - 1, 1) <> "," Then
                                        '                ' TextBox2.Text = ldfRecordNumber & "," & TextBox2.Text
                                        '            End If
                                        '        End If
                                    End If
                                End If
                                If CountRecord Then  ' Record is within the range user selected to count
                                    'CharCounts = CountCharacters(LineData(NumericUpDownLineToScan.Value).ToString)

                                    'For charIndex = 0 To 255
                                    '    CharCountsTotal(charIndex) += CharCounts(charIndex)
                                    '    counts = CharCountsTotal(charIndex)
                                    '    If counts > 0 And counts = CharCounts(charIndex) Then
                                    '        FindPixelsPerChar(charIndex)
                                    '        'Debug.Print(CharCountsTotal(charIndex))
                                    '    End If
                                    'Next
                                    '  Insert code here to write out ldf data
                                    OutputRecordLabel = ""
                                    calculatedMostLinesFilled = 0
                                    For index = 0 To LineData.Length - 2
                                        OutputRecordLabel = OutputRecordLabel & LineData(index) + Chr(GROUPSEP)
                                        If Not (String.IsNullOrEmpty((LineData(index).Trim))) Then
                                            calculatedMostLinesFilled = calculatedMostLinesFilled + (1 << index)
                                        End If
                                    Next
                                    If firstVersionOccuranceNonGraphic.ContainsKey(ldfRecordHeaderVersion) = True Then
                                        If calculatedMostLinesFilled > mostFilledLinesOfDataValue(firstVersionOccuranceNonGraphic(ldfRecordHeaderVersion)) Then
                                            mostFilledLinesOfDataValue(firstVersionOccuranceNonGraphic(ldfRecordHeaderVersion)) = calculatedMostLinesFilled
                                            mostFilledLinesOfData(firstVersionOccuranceNonGraphic(ldfRecordHeaderVersion)) = OutputRecordLabel
                                        End If

                                    Else
                                        firstVersionOccuranceNonGraphic.Add(ldfRecordHeaderVersion, mostFilledLinesOfDataIndex)
                                        mostFilledLinesOfDataValue(firstVersionOccuranceNonGraphic(ldfRecordHeaderVersion)) = calculatedMostLinesFilled
                                        mostFilledLinesOfData(firstVersionOccuranceNonGraphic(ldfRecordHeaderVersion)) = OutputRecordLabel
                                        mostFilledLinesOfDataIndex += 1

                                    End If

                                    OutputRecordLabel = OutputRecordLabel & LineData(LineData.Length - 1) '+ Chr(10)

                                        LDFWriter.Write(OutputRecordLabel)
                                        'If FirstOccurance = True Then
                                        '    OutputRecordLabel = ""
                                        '    LineData(0) = LineData(0).Replace("Q", " ")
                                        '    For index = 0 To LineData.Length - 2
                                        '        OutputRecordLabel = OutputRecordLabel & LineData(index).ToString + Chr(GROUPSEP)
                                        '    Next
                                        '    OutputRecordLabel = OutputRecordLabel & LineData(LineData.Length - 1).ToString + Chr(10)
                                        '    firstoccuranceLDFstring = firstoccuranceLDFstring + OutputRecordLabel
                                        'End If
                                        'TextBox1.Text = TextBoxLabel




                                        If RecordCount Mod 3000 = False Then
                                            TextBoxLabel = ""
                                            For index = 0 To LineData.Length - 1
                                                TextBoxLabel = TextBoxLabel & "[" & index & "] " & LineData(index) + Environment.NewLine
                                            Next
                                            TextBox1.Text = TextBoxLabel
                                            UpdateListviewItems()
                                        End If
                                        If ((FirstOccurance = True) Or (firstVersionOccurance = True)) Then
                                            OutputRecordLabel = ""
                                            LineData(0) = LineData(0).Replace("Q", " ")
                                            For index = 0 To LineData.Length - 2
                                                OutputRecordLabel = OutputRecordLabel & LineData(index) + Chr(GROUPSEP)
                                            Next
                                            OutputRecordLabel = OutputRecordLabel & LineData(LineData.Length - 1) '+ Chr(10)
                                            firstoccuranceLDFstring = firstoccuranceLDFstring + OutputRecordLabel
                                        End If
                                    End If
                                Else
                                PartialBuffer = Mid$(BufferString, FoundRecordStart, Len(BufferString) - FoundRecordStart)
                                FoundRecordStart = 1
                                CompleteRecordFound = False
                            End If
                        End While
                    End While
                    If PartialBuffer.Length > 10 And FoundRecordEnd < 1 Then
                        ActiveRecord = PartialBuffer

                        RecordCount += 1
                        For i = 0 To LineData.Length - 1
                            LineData(i) = ""
                        Next
                        LineData = ParseRecord(ActiveRecord)
                        ldfRecordNumber = Val(Mid(LineData(0), 4, 9))
                        ldfRecordHeaderVersion = Mid(LineData(0), 36, 12).Trim
                        Dim smatch As Boolean = ((Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) Like "####")
                        If smatch = True Then
                            If lookupDict.ContainsKey(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) = True Then
                                If warned2 = False Then

                                    If (Not String.IsNullOrWhiteSpace(LineData(NumericUpDownLineToReplace.Value))) Then
                                        MessageBox.Show("CAUTION replacing non empty line of data '" + LineData(NumericUpDownLineToReplace.Value) + "' You will only be warned once!")
                                        warned2 = True
                                    End If
                                End If
                                If (Int(lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4))) > 255) Then
                                    LineData(NumericUpDownLineToReplace.Value) = "^PF" + TextBox2.Text + "^X" + Chr(Int(lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) Mod 255))
                                Else

                                    LineData(NumericUpDownLineToReplace.Value) = Chr(Int(lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) Mod 255))
                                End If
                                'LineData(NumericUpDownLineToReplace.Value) = lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4))
                                'LineData(32) = LineData(32) + Chr(GROUPSEP)
                            Else
                                If missingCodeDictionary.ContainsKey(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) = True Then
                                    warned = True
                                Else
                                    missingCodeDictionary.Add(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4), " ")
                                    warned = False
                                End If
                                If warned = False Then

                                    'warned = True
                                    MessageBox.Show("No dictionary entry for " + Microsoft.VisualBasic.Left(LineData(17), 4) + " There will be only one warning per code")
                                End If

                            End If
                        Else
                            'this record does not have four digit code check for first occurance of version
                            If firstVersionOccuranceNonGraphic.ContainsKey(ldfRecordHeaderVersion) = True Then
                                firstVersionOccurance = False
                            Else
                                firstVersionOccuranceNonGraphic.Add(ldfRecordHeaderVersion, 0)
                                firstVersionOccurance = True
                            End If

                        End If


                        'If smatch = True Then
                        '    If lookupDict.ContainsKey(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4)) = True Then
                        '        If warned2 = False Then
                        '            If (Not String.IsNullOrWhiteSpace(LineData(NumericUpDownLineToReplace.Value))) Then
                        '                MessageBox.Show("CAUTION replacing non empty line of data '" + LineData(NumericUpDownLineToReplace.Value) + "' You will only be warned once!")
                        '                warned2 = True
                        '            End If
                        '        End If
                        '        LineData(NumericUpDownLineToReplace.Value) = lookupDict(Microsoft.VisualBasic.Left(LineData(NumericUpDownGraphicLineToScan.Value), 4))
                        '        'LineData(32) = LineData(32) + Chr(GROUPSEP)
                        '    Else
                        '        If warned = False Then

                        '            warned = True
                        '            MessageBox.Show("No dictionary entry for " + Microsoft.VisualBasic.Left(LineData(17), 4) + " There will be only one warning")
                        '        End If

                        '    End If
                        'End If
                        If ldfRecordNumber >= Val(TextBoxStartRecord.Text) And ldfRecordNumber <= Val(TextBoxEndRecord.Text) Then
                            CountRecord = True
                        Else
                            CountRecord = False
                        End If
                        If CountRecord Then
                            OutputRecordLabel = ""
                            labelLength = 0
                            calculatedMostLinesFilled = 0
                            For index = 0 To LineData.Length - 2
                                OutputRecordLabel = OutputRecordLabel & LineData(index) + Chr(GROUPSEP)
                                labelLength = labelLength + LineData(index).Length
                                If Not (String.IsNullOrEmpty((LineData(index).Trim))) Then
                                    calculatedMostLinesFilled = calculatedMostLinesFilled + (1 << index)
                                End If

                            Next
                            TextBox4.Text = ""
                            For index = 0 To mostFilledLinesOfDataIndex - 1
                                TextBox4.Text += mostFilledLinesOfData(index)
                            Next
                            firstVersionOccuranceNonGraphic(ldfRecordHeaderVersion) = calculatedMostLinesFilled
                            OutputRecordLabel = OutputRecordLabel & LineData(LineData.Length - 1)
                            If (FirstOccurance = True) Then
                                If BitmapNameFound = False Then
                                    firstoccuranceLDFstring = firstoccuranceLDFstring + OutputRecordLabel
                                End If
                            End If
                            labelLength = labelLength + LineData(LineData.Length - 1).Length
                            OutputRecordLabel = OutputRecordLabel.Replace(vbNullChar, "")
                            'LDFWriter.Write(OutputRecordLabel, 0, OutputRecordLabel.Length)
                            'LDFWriter.Write(
                            'LDFWriter.Write(OutputRecordLabel, OutputRecordLabel, labelLength)
                            LDFWriter.Write(OutputRecordLabel)
                            LDFWriter.Flush()
                            LDFWriter.Close()


                            'OutputRecordLabel = ""
                            'For index = 0 To LineData.Length - 2
                            '    OutputRecordLabel = OutputRecordLabel & LineData(index).ToString + Chr(GROUPSEP)
                            'Next
                            'OutputRecordLabel = OutputRecordLabel & LineData(LineData.Length - 1)

                            'LDFWriter.Write(OutputRecordLabel)
                            'CharCounts = CountCharacters(LineData(NumericUpDownLineToScan.Value).ToString)
                            'For charIndex = 0 To 255
                            '    CharCountsTotal(charIndex) += CharCounts(charIndex)
                            '    If CharCountsTotal(charIndex).ToString = "1" Then
                            '        FindPixelsPerChar(charIndex)
                            '    End If
                            'Next
                            'DataFromLineToCheckLength = LineData(LineToCheckLength).Trim
                            'If Len(DataFromLineToCheckLength) > 19 Then
                            '    Debug.Print(ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(1).Trim)
                            '    TextBox2.Text = ldfRecordNumber & "," & TextBox2.Text
                            '    StringToOutput = StringToOutput & ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(19).Trim & vbCrLf
                            'End If
                            bitmapName = LineData(NumericUpDownGraphicLineToScan.Value).Trim
                            FirstOccurance = False
                            If Len(bitmapName) > 0 Then
                                ReDim Preserve UniqueBitmapCodes(BitmapElements)
                                ReDim Preserve BitmapCounts(BitmapElements)
                                ReDim Preserve BitmapDarkPixels(BitmapElements)
                                ReDim Preserve BitmapDarkPixelsWithSkip(BitmapElements)
                                ReDim Preserve BitmapPaths(BitmapElements)

                                BitmapNameFound = False
                                For BitmapIndex = 0 To BitmapElements
                                    If bitmapName = UniqueBitmapCodes(BitmapIndex) Then
                                        BitmapCounts(BitmapIndex) += 1
                                        BitmapNameFound = True
                                        Exit For
                                    End If
                                Next
                                If (BitmapNameFound = False) And (smatch = True) Then
                                    BitmapElements += 1
                                    ReDim Preserve UniqueBitmapCodes(BitmapElements)
                                    ReDim Preserve BitmapRecordNumberFirstOccurance(BitmapElements)
                                    ReDim Preserve DataLineStringLongest(BitmapElements)
                                    ReDim Preserve DataLineLongestRecordNumber(BitmapElements)
                                    UniqueBitmapCodes(BitmapIndex - 1) = bitmapName.ToString
                                    BitmapRecordNumberFirstOccurance(BitmapIndex - 1) = ldfRecordNumber
                                    ' DataLineLongestRecordNumber(BitmapIndex - 1) = ldfRecordNumber
                                    'DataLineStringLongest(BitmapIndex - 1) = ((LineData(NumericUpDownLineToScan.Value).ToString).Trim)

                                    BitmapCounts(BitmapIndex - 1) = 1

                                    'Else
                                    '    Dim tempstring As String = (LineData(NumericUpDownLineToScan.Value).ToString).Trim
                                    '    If Len((LineData(NumericUpDownLineToScan.Value).ToString).Trim) > Len(DataLineStringLongest(BitmapIndex)) Then
                                    '        DataLineLongestRecordNumber(BitmapIndex) = ldfRecordNumber
                                    '        DataLineStringLongest(BitmapIndex) = ((LineData(NumericUpDownLineToScan.Value).ToString).Trim)
                                    '    End If
                                    '    'If tempstring.Length > 0 Then


                                    '    '    If tempstring.Substring(tempstring.Length - 1, 1) <> "," Then
                                    '    '        ' TextBox2.Text = ldfRecordNumber & "," & TextBox2.Text
                                    '    '    End If
                                    '    'End If
                                End If

                            End If
                        End If
                    End If
                End If
            End Using
            LDFReader.Close()
            LDFReader.Dispose()
            'LDFWriter.Close()
            'LDFWriter.Dispose()
        Next
        TextBoxLabel = ""
        For index = 0 To LineData.Length - 1
            TextBoxLabel = TextBoxLabel & "[" & index & "] " & LineData(index) + Environment.NewLine
        Next

        UpdateListviewItems()
        ' LDFWriterPath = filepath1.Directory.ToString + "\MFirstOccurances"
        'wStream = New FileStream(LDFWriterPath, FileMode.OpenOrCreate, FileAccess.Write)
        ' Using LDFWriter As StreamWriter = New StreamWriter(wStream, Encoding.Default)
        TextBox3.Text = firstoccuranceLDFstring

        wStream = New FileStream(firstOccurancePath, FileMode.OpenOrCreate, FileAccess.Write)
        Using LDFWriter As StreamWriter = New StreamWriter(wStream, Encoding.Default)
            LDFWriter.Write(firstoccuranceLDFstring)
            LDFWriter.Flush()
            LDFWriter.Close()
        End Using
        TextBox1.Text = TextBoxLabel
        'If (Len(StringToOutput) > 0) Then
        '    'dataWriterPath = "test.txt"
        '    Using DataWriter As New StreamWriter(dataWriterPath)
        '        DataWriter.Write(StringToOutput)
        '    End Using
        'End If
        StringToOutput = ""

        ButtonScan.Enabled = True
        NumericUpDownLineToReplace.Enabled = True
    End Sub
    Private Function CountCharacters(ByVal RecordLine As String) As Long()
        Dim Characters(255) As Long
        Dim Length As Integer = Len(RecordLine)
        Dim CopyOfRecordLine As String = RecordLine
        Dim CheckChar As String
        Dim intCheckchar As Integer


        Characters(0) = 0
        Do Until Len(CopyOfRecordLine) = 0
            CheckChar = CopyOfRecordLine.Chars(0)
            intCheckchar = System.Text.Encoding.UTF8.GetBytes(CheckChar)(0)
            Characters(intCheckchar) = CopyOfRecordLine.ToString.Count - CopyOfRecordLine.Replace(CheckChar, "").Count
            CopyOfRecordLine = CopyOfRecordLine.Replace(CheckChar, "")
        Loop
        Return Characters
    End Function


    Private Sub FindAllPixelsPerChar()
        Dim Index As Integer
        Dim dpi As Integer
        Dim fontName As String
        Dim fontStyle As System.Drawing.FontStyle
        Dim Fontsize As Single
        'Dim skipValue As Integer
        Dim localPixelsPerChar(2) As Integer
        dpi = SelectedDPI()


        Dim bmp As New Bitmap(600, 600, Imaging.PixelFormat.Format24bppRgb)
        bmp.SetResolution(dpi, dpi)
        'If RadioButtonSkipLineYes.Checked Then
        '    skipValue = 3
        'Else
        '    skipValue = 1
        'End If
        ReDim PixelsPerChar(255)
        ReDim PixelsPerCharWithSkip(255)
        For Index = 32 To 255
            bmp = New Bitmap(600, 600, Imaging.PixelFormat.Format24bppRgb)
            bmp.SetResolution(dpi, dpi)
            Using G = Graphics.FromImage(bmp)
                G.Clear(Color.White)
                G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                G.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
                fontName = LabelFontName.Font.Name.ToString
                fontStyle = LabelFontName.Font.Style
                Fontsize = 8
                Using F As New Font(fontName, Fontsize, fontStyle)
                    Using B As New SolidBrush(Color.Black)
                        G.DrawString(Chr(Index).ToString, F, B, 20, 20)

                    End Using
                End Using
                'bmp = Trim(bmp)
                ' PixelsPerChar(Index) = PixelDarkerThanColorLevelCount(bmp, 12, skipValue)
                localPixelsPerChar = PixelDarkerThanColorLevelCountArray(bmp, 12, 1)
                PixelsPerChar(Index) = localPixelsPerChar(0)
                PixelsPerCharWithSkip(Index) = localPixelsPerChar(1)
                PictureBox1.Image = bmp

                ' Debug.Print(Index) 
                'Debug.Print(PixelsPerChar(Index))
                My.Application.DoEvents()
            End Using
        Next

    End Sub
    Private Function SelectedDPI() As Integer
        Dim dpi As Integer
        dpi = 600
        Return dpi

    End Function




    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown


    End Sub
    Public Sub UpdateListviewItems()
        Dim index As Integer
        Dim arr(7) As String
        Dim item As ListViewItem
        Dim mlInkTotalForAllChar As Double
        Dim mlInkTotalForChar As Double
        ' Dim mlInkTotalForAllBitmaps As Double
        'Dim mlInkTotalForBitmaps As Double
        ListViewCharacters.Items.Clear()
        For index = 0 To 255
            If CharCountsTotal(index) > 0 Then
                arr(0) = Chr(index).ToString 'char Human readable
                arr(1) = index.ToString 'ascii value
                arr(2) = CharCountsTotal(index).ToString 'total characters
                If 1 = True Then
                    arr(3) = PixelsPerChar(index) 'pixels per char
                    arr(4) = PixelsPerChar(index) * CharCountsTotal(index) 'total pixels
                    arr(5) = PixelsPerChar(index) * CharCountsTotal(index) * 1
                    mlInkTotalForChar = (PixelsPerChar(index) * CharCountsTotal(index) * 1) / 1000000000
                Else
                    arr(3) = PixelsPerCharWithSkip(index) 'pixels per char
                    arr(4) = PixelsPerCharWithSkip(index) * CharCountsTotal(index) 'total pixels
                    arr(5) = PixelsPerCharWithSkip(index) * CharCountsTotal(index) * 1
                    mlInkTotalForChar = (PixelsPerCharWithSkip(index) * CharCountsTotal(index) * 1) / 1000000000

                End If

                mlInkTotalForAllChar = mlInkTotalForAllChar + mlInkTotalForChar
                arr(6) = mlInkTotalForChar.ToString
                item = New ListViewItem(arr)

                ListViewCharacters.Items.Add(item)
                'TextBoxLabel = TextBoxLabel & Chr(index) & " (" & index & ") " & CharCountsTotal(index).ToString + Environment.NewLine
                labelTotalInkML.Text = mlInkTotalForAllChar.ToString
            End If
        Next
        ListViewGraphics.Items.Clear()
        ReDim arr(2)
        If BitmapElements > 0 Then
            For index = 0 To UniqueBitmapCodes.Count - 2
                arr(0) = UniqueBitmapCodes(index)
                arr(1) = BitmapCounts(index)
                'If 1 = True Then
                '    arr(2) = BitmapDarkPixels(index)
                '    arr(3) = BitmapDarkPixels(index) * BitmapCounts(index)
                '    arr(4) = BitmapDarkPixels(index) * BitmapCounts(index) * 1
                '    arr(5) = BitmapDarkPixels(index) * BitmapCounts(index) * 1 / 1000000000

                '    mlInkTotalForBitmaps = BitmapDarkPixels(index) * BitmapCounts(index) * 1 / 1000000000
                'Else
                '    arr(2) = BitmapDarkPixelsWithSkip(index)
                '    arr(3) = BitmapDarkPixelsWithSkip(index) * BitmapCounts(index)
                '    arr(4) = BitmapDarkPixelsWithSkip(index) * BitmapCounts(index) * 1
                '    arr(5) = BitmapDarkPixelsWithSkip(index) * BitmapCounts(index) * 1 / 1000000000

                '    mlInkTotalForBitmaps = BitmapDarkPixelsWithSkip(index) * BitmapCounts(index) * 1 / 1000000000

                'End If
                arr(2) = BitmapRecordNumberFirstOccurance(index)
                'arr(6) = BitmapPaths(index)
                'arr(7) = BitmapRecordNumberFirstOccurance(index)
                'If index = 0 Then
                '    TextBoxOutputString.Text = BitmapRecordNumberFirstOccurance(index)
                '    TextBoxOutputString2.Text = DataLineLongestRecordNumber(index)
                'Else
                '    TextBoxOutputString.Text = TextBoxOutputString.Text & "," & BitmapRecordNumberFirstOccurance(index)
                '    TextBoxOutputString2.Text = TextBoxOutputString2.Text & "," & DataLineLongestRecordNumber(index)
                'End If
                'mlInkTotalForAllBitmaps += mlInkTotalForBitmaps
                'labelInkTotalGraphics.Text = mlInkTotalForAllBitmaps
                'LabelInkTotalAll.Text = mlInkTotalForAllBitmaps + mlInkTotalForAllChar
                item = New ListViewItem(arr)
                ListViewGraphics.Items.Add(item)

            Next
        End If
    End Sub




    Private Sub NumericUpDownPLDrop_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateListviewItems()
    End Sub

    Private Sub ListViewGraphics_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewGraphics.ColumnClick
        Dim new_sorting_column As ColumnHeader = ListViewGraphics.Columns(e.Column)
        Dim sort_order As System.Windows.Forms.SortOrder
        'Dim counter As Integer
        Dim outputString As String
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If new_sorting_column.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith(">") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If
        ListViewGraphics.ListViewItemSorter = New clsListViewSorter(e.Column, sort_order)
        ListViewGraphics.Sort()
        outputString = ""
        'For counter = 0 To ListViewGraphics.Items.Count - 1
        '    Debug.Print(ListViewGraphics.Items(counter).SubItems(7).Text)
        '    If counter < 1 Then
        '        outputString = ListViewGraphics.Items(counter).SubItems(7).Text
        '    Else
        '        outputString = outputString & "," & ListViewGraphics.Items(counter).SubItems(7).Text
        '    End If

        'Next
        'TextBoxOutputString.Text = outputString
        ' outputString = ""



    End Sub

    Private Sub ListViewCharacters_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewCharacters.ColumnClick
        Dim new_sorting_column As ColumnHeader = ListViewCharacters.Columns(e.Column)
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If new_sorting_column.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith(">") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If
        ListViewCharacters.ListViewItemSorter = New clsListViewSorter(e.Column, sort_order)
        ListViewCharacters.Sort()
    End Sub

    Private Sub ListViewCharacters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewCharacters.SelectedIndexChanged
        Dim Index As Integer
        Dim dpi As Integer
        Dim fontName As String
        Dim fontStyle As System.Drawing.FontStyle
        Dim Fontsize As Single
        Dim localPixelsPerChar(2) As Integer
        ' Dim item As ListViewItem

        dpi = SelectedDPI()
        'ButtonSelectFont.Enabled = False

        Dim bmp As New Bitmap(600, 600, Imaging.PixelFormat.Format24bppRgb)
        bmp.SetResolution(dpi, dpi)

        If ListViewCharacters.SelectedItems.Count > 0 Then


            Index = Val(ListViewCharacters.SelectedItems(0).SubItems(1).Text)
            bmp = New Bitmap(600, 600, Imaging.PixelFormat.Format24bppRgb)
            bmp.SetResolution(dpi, dpi)
            Using G = Graphics.FromImage(bmp)
                G.Clear(Color.White)
                G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                G.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
                fontName = LabelFontName.Font.Name.ToString
                fontStyle = LabelFontName.Font.Style
                Fontsize = 8
                Using F As New Font(fontName, Fontsize, fontStyle)
                    Using B As New SolidBrush(Color.Black)
                        G.DrawString(Chr(Index).ToString, F, B, 20, 20)

                    End Using
                End Using
                bmp = Trim(bmp)
                'pixelsPerChar(Index) = PixelDarkerThanColorLevelCount(bmp, 12)
                localPixelsPerChar = PixelDarkerThanColorLevelCountArray(bmp, 12, 3)
                PixelsPerChar(Index) = localPixelsPerChar(0)
                PixelsPerCharWithSkip(Index) = localPixelsPerChar(1)

                PictureBox1.Image = bmp

                ' Debug.Print(Index) 
                'Debug.Print(PixelsPerChar(Index))
                My.Application.DoEvents()
            End Using

            ' ButtonSelectFont.Enabled = True
        End If
    End Sub

    Private Sub FindPixelsPerChar(ByVal intCharacter As Integer, Optional ByVal SkipLineInterval As Integer = 0)
        Dim Index As Integer
        Dim dpi As Integer
        Dim fontName As String
        Dim fontStyle As System.Drawing.FontStyle
        Dim Fontsize As Single
        'Dim item As ListViewItem
        'Dim skipValue As Integer
        Dim localPixelsPerChar(2) As Integer
        Index = intCharacter
        dpi = SelectedDPI()
        'ButtonSelectFont.Enabled = False
        'If RadioButtonSkipLineYes.Checked Then
        '    skipValue = 3
        'Else
        '    skipValue = 1
        'End If

        Dim bmp As New Bitmap(600, 600, Imaging.PixelFormat.Format24bppRgb)
        bmp.SetResolution(dpi, dpi)

        ' If ListViewCharacters.SelectedItems.Count > 0 Then


        'Index = Val(ListViewCharacters.SelectedItems(0).SubItems(1).Text)
        bmp = New Bitmap(600, 600, Imaging.PixelFormat.Format24bppRgb)
        bmp.SetResolution(dpi, dpi)
        Using G = Graphics.FromImage(bmp)
            G.Clear(Color.White)
            G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            G.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
            fontName = LabelFontName.Font.Name.ToString
            fontStyle = LabelFontName.Font.Style
            Fontsize = 8
            Using F As New Font(fontName, Fontsize, fontStyle)
                Using B As New SolidBrush(Color.Black)
                    G.DrawString(Chr(Index).ToString, F, B, 20, 20)

                End Using
            End Using
            'bmp = Trim(bmp)
            'PixelsPerChar(Index) = PixelDarkerThanColorLevelCount(bmp, 12, skipValue)
            localPixelsPerChar = PixelDarkerThanColorLevelCountArray(bmp, 12, 3)
            PixelsPerChar(Index) = localPixelsPerChar(0)
            PixelsPerCharWithSkip(Index) = localPixelsPerChar(1)
            PictureBox1.Image = bmp

            ' Debug.Print(Index) 
            'Debug.Print(PixelsPerChar(Index))
            My.Application.DoEvents()
        End Using

        ' ButtonSelectFont.Enabled = True
        'End If
    End Sub

    Private Sub TextBoxStartRecord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxStartRecord.Click
        TextBoxStartRecord.SelectAll()
    End Sub

    Private Sub TextBoxStartRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxStartRecord.GotFocus
        TextBoxStartRecord.SelectAll()

    End Sub

    Private Sub TextBoxStartRecord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxStartRecord.KeyPress
        ' 97-122 ascii simple letters
        '65 - 90 Capital letters
        '48-57 numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub







    Private Sub TextBoxEndRecord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxEndRecord.Click
        TextBoxEndRecord.SelectAll()
    End Sub

    Private Sub TextBoxEndRecord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxEndRecord.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxEndRecord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxEndRecord.TextChanged

    End Sub



    Private Sub ListViewGraphics_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewGraphics.DoubleClick
        'Dim listboxitem As String
        'Dim index As Integer
        ''OpenFileDialogBitmap.InitialDirectory = "C:\"
        'listboxitem = ListViewGraphics.SelectedItems(0).Text
        'If listboxitem > "" Then
        '    For index = 0 To UniqueBitmapCodes.Count - 1
        '        If UniqueBitmapCodes(index) = listboxitem Then
        '            clickedindex = index
        '            Exit For
        '        End If
        '    Next
        '    OpenFileDialogBitmap.Multiselect = False
        '    OpenFileDialogBitmap.Filter = "bmp files (*.bmp|*.bmp|BMP Files (*.bmp)|*.bmp"
        '    OpenFileDialogBitmap.FilterIndex = 2
        '    OpenFileDialogBitmap.RestoreDirectory = True
        '    OpenFileDialogBitmap.Title = "Please Selected a Bitmap File"

        '    OpenFileDialogBitmap.ShowDialog()
        ' Dim bmp As New Bitmap(BitmapPaths(clickedindex))
        'BitmapDarkPixels(clickedindex) = PixelDarkerThanColorLevelCount(bmp, 12, 1)
        'UpdateListviewItems()
        'End If
    End Sub

    Private Sub ListViewGraphics_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewGraphics.FontChanged

    End Sub

    Private Sub ListViewGraphics_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewGraphics.SelectedIndexChanged
        'Dim bmpPath As String
        'If ListViewGraphics.SelectedItems.Count > 0 Then
        '    With ListViewGraphics

        '        bmpPath = .SelectedItems(0).SubItems().Text
        '        If bmpPath <> "" Then


        '            Dim bmp As New Bitmap(bmpPath)
        '            PictureBoxBmpPreview.Image = bmp
        '        End If
        '    End With
        'End If

    End Sub

    Private Sub OpenFileDialogBitmap_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenFileDialogBitmap.Disposed

    End Sub

    Private Sub OpenFileDialogBitmap_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogBitmap.FileOk
        BitmapPaths(clickedindex) = OpenFileDialogBitmap.FileName
        Dim bmp As New Bitmap(BitmapPaths(clickedindex))
        Dim dpi As Integer
        'Dim skipValue As Integer
        dpi = SelectedDPI()
        'ButtonSelectFont.Enabled = False
        'If RadioButtonSkipLineYes.Checked Then
        '    skipValue = 3
        'Else
        '    skipValue = 1
        'End If
        ' Debug.Print(bmp.HorizontalResolution)
        ' Debug.Print(bmp.VerticalResolution)
        ' Debug.Print(bmp.Width)
        ' Debug.Print(bmp.Height)
        ' Debug.Print(PixelDarkerThanColorLevelCount(bmp, 12, 1))

        Dim scaleFactor As Single = (SelectedDPI() / bmp.HorizontalResolution)
        Dim scaledBitmap As New Bitmap(CInt(bmp.Width * scaleFactor), CInt(bmp.Height * scaleFactor))
        Dim scaledGraphic As Graphics = Graphics.FromImage(scaledBitmap)
        Dim darkPixels(2) As Integer
        scaledGraphic.DrawImage(bmp, 0, 0, scaledBitmap.Width + 1, scaledBitmap.Height + 1)
        scaledBitmap.SetResolution(600, 600)
        'Debug.Print(scaledBitmap.HorizontalResolution)
        'Debug.Print(scaledBitmap.VerticalResolution)
        ' Debug.Print(scaledBitmap.Width)
        ' Debug.Print(scaledBitmap.Height)
        ' Debug.Print(PixelDarkerThanColorLevelCount(scaledBitmap, 12, 1))
        PictureBoxBmpPreview.Image = scaledBitmap
        PictureBoxBmpPreview.Visible = True
        'BitmapDarkPixels(clickedindex) = PixelDarkerThanColorLevelCount(scaledBitmap, 12, skipValue)
        darkPixels = PixelDarkerThanColorLevelCountArray(scaledBitmap, 12, 3)
        BitmapDarkPixels(clickedindex) = darkPixels(0)
        BitmapDarkPixelsWithSkip(clickedindex) = darkPixels(1)
        UpdateListviewItems()
    End Sub

    Private Sub PictureBoxBmpPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxBmpPreview.Click
        PictureBoxBmpPreview.Visible = False
    End Sub

    Private Sub NumericUpDownGraphicLineToScan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownGraphicLineToScan.ValueChanged
        ReDim UniqueBitmapCodes(0)
        ReDim BitmapPaths(0)
        ReDim BitmapCounts(0)
        ReDim BitmapDarkPixels(0)
        ReDim BitmapDarkPixelsWithSkip(0)
        BitmapElements = 0
        'ListViewGraphics.Items.Clear()
    End Sub

    Private Sub RadioButtonSkipLineYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub ButtonAutoAddGraphics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAutoAddGraphics.Click
        ' Dim listboxitem As String
        Dim index As Integer
        Dim graphicsfolderpath As String
        Dim graphicPathName As String
        'Dim MyFolderBrowser As New System.Windows.Forms.FolderBrowserDialog
        Dim sortedindex As Integer
        Dim listboxitem1 As String
        ' Description that displays above the dialog box control. 
        If System.IO.Directory.Exists(My.Settings.lastFolderBrowserPath2) Then
            MyFolderBrowser.SelectedPath = My.Settings.lastFolderBrowserPath2
        End If
        MyFolderBrowser.Description = "Select the Graphics Folder"
        MyFolderBrowser.ShowNewFolderButton = False


        ' Sets the root folder where the browsing starts from 
        'MyFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer
        Dim dlgResult As DialogResult = MyFolderBrowser.ShowDialog()

        If dlgResult = Windows.Forms.DialogResult.OK Then
            graphicsfolderpath = MyFolderBrowser.SelectedPath
            My.Settings.lastFolderBrowserPath2 = graphicsfolderpath

        Else
            Exit Sub
        End If

        For index = 0 To ListViewGraphics.Items.Count - 1
            graphicPathName = graphicsfolderpath & "\" & ListViewGraphics.Items(index).Text & ".bmp"
            listboxitem1 = ListViewGraphics.Items(index).Text
            If File.Exists(graphicPathName) Then
                For sortedindex = 0 To UniqueBitmapCodes.Count - 1
                    If UniqueBitmapCodes(sortedindex) = listboxitem1 Then
                        clickedindex = sortedindex
                        Exit For
                    End If
                Next
                Dim bmp As New Bitmap(graphicPathName)
                BitmapPaths(clickedindex) = graphicPathName
                'Dim bmp As New Bitmap(BitmapPaths(clickedindex))
                Dim dpi As Integer
                ' Dim skipValue As Integer
                dpi = SelectedDPI()
                'ButtonSelectFont.Enabled = False
                'If RadioButtonSkipLineYes.Checked Then
                '    skipValue = 3
                'Else
                '    skipValue = 1
                'End If
                ' Debug.Print(bmp.HorizontalResolution)
                ' Debug.Print(bmp.VerticalResolution)
                ' Debug.Print(bmp.Width)
                ' Debug.Print(bmp.Height)
                ' Debug.Print(PixelDarkerThanColorLevelCount(bmp, 12, 1))

                Dim scaleFactor As Single = (SelectedDPI() / bmp.HorizontalResolution)
                Dim scaledBitmap As New Bitmap(CInt(bmp.Width * scaleFactor), CInt(bmp.Height * scaleFactor))
                Dim scaledGraphic As Graphics = Graphics.FromImage(scaledBitmap)
                Dim darkPixels(2) As Integer
                scaledGraphic.DrawImage(bmp, 0, 0, scaledBitmap.Width + 1, scaledBitmap.Height + 1)
                scaledBitmap.SetResolution(600, 600)
                'Debug.Print(scaledBitmap.HorizontalResolution)
                'Debug.Print(scaledBitmap.VerticalResolution)
                ' Debug.Print(scaledBitmap.Width)
                ' Debug.Print(scaledBitmap.Height)
                ' Debug.Print(PixelDarkerThanColorLevelCount(scaledBitmap, 12, 1))
                PictureBoxBmpPreview.Image = scaledBitmap
                PictureBoxBmpPreview.Visible = True
                'BitmapDarkPixels(clickedindex) = PixelDarkerThanColorLevelCount(scaledBitmap, 12, skipValue)
                darkPixels = PixelDarkerThanColorLevelCountArray(scaledBitmap, 12, 3)
                BitmapDarkPixels(clickedindex) = darkPixels(0)
                BitmapDarkPixelsWithSkip(clickedindex) = darkPixels(1)
                Application.DoEvents()
            End If
            ' UpdateListviewItems()
        Next
        UpdateListviewItems()
        ''OpenFileDialogBitmap.InitialDirectory = "C:\"
        'listboxitem = ListViewGraphics.SelectedItems(0).Text
        'If listboxitem > "" Then
        '    For index = 0 To UniqueBitmapCodes.Count - 1
        '        If UniqueBitmapCodes(index) = listboxitem Then
        '            clickedindex = index
        '            Exit For
        '        End If
        '    Next
        '    OpenFileDialogBitmap.Multiselect = False
        '    OpenFileDialogBitmap.Filter = "bmp files (*.bmp|*.bmp|BMP Files (*.bmp)|*.bmp"
        '    OpenFileDialogBitmap.FilterIndex = 2
        '    OpenFileDialogBitmap.RestoreDirectory = True
        '    OpenFileDialogBitmap.Title = "Please Selected a Bitmap File"

        '    OpenFileDialogBitmap.ShowDialog()
        '    Dim bmp As New Bitmap(BitmapPaths(index))
        '    'BitmapDarkPixels(clickedindex) = PixelDarkerThanColorLevelCount(bmp, 12, 1)
        '    'UpdateListviewItems()
        'End If
    End Sub
    Private Sub ShowRecord(ByVal RecordNumber As Long)
        'Dim FileToOpen As String
        Dim LDFReader As FileStream
        ' Dim DataWriter As StreamWriter
        Dim dataWriterPath As String = "C:\jobs\test.txt"
        Dim FoundRecordStart As Integer
        Dim FoundRecordEnd As Integer
        Dim ActiveRecord As String
        Dim PartialBuffer As String
        Dim BufferLength As Integer = 1048576 '524288 '8192
        Dim Buffer(BufferLength) As Byte
        Dim BufferString As String
        Dim BufferCount As Integer
        Dim CompleteRecordFound As Boolean
        Dim RecordCount As Integer
        Dim LineData(144) As String
        Dim TextBoxLabel As String
        Dim index As Integer
        Dim CharCounts(255) As Long
        Dim charIndex As Integer
        Dim arr(6) As String
        Dim boolLdfReaderUsed As Boolean
        Dim bitmapName As String
        boolLdfReaderUsed = False
        'Dim item As ListViewItem
        'Dim mlInkTotalForChar As Double
        'Dim mlInkTotalForAllChar As Double
        ReDim CharCountsTotal(255)
        'ReDim UniqueBitmapCodes(0)
        ReDim BitmapCounts(0)
        ReDim DataLineStringLongest(0)
        ReDim DataLineLongestRecordNumber(0)
        'ReDim BitmapDarkPixels(0)
        ' ReDim BitmapPaths(0)
        ListViewCharacters.Items.Clear()
        Dim filepath As String
        Dim BitmapIndex As Integer
        Dim BitmapNameFound As Boolean = False
        'Dim counts As Integer
        'Dim startRecord As Integer
        ' Dim endRecord As Integer
        Dim ldfRecordNumber As Integer
        Dim CountRecord As Boolean

        Dim DataFromLineToCheckLength As String
        Dim LineToCheckLength As Integer = 25
        'Dim DataFromAlternateLineToCheckLength As String
        Dim AlternateLineToCheckLength = 3
        Dim StringToOutput As String = ""
        'TextBox2.Text = ""
        BitmapElements = 0
        ' BitmapElements = 0
        filepath = Filepaths(0)

        LabelFileName.Text = filepath


        BufferCount = 0
        RecordCount = 0
        FoundRecordStart = 1
        PartialBuffer = ""
        ButtonScan.Enabled = False
        My.Application.DoEvents()
        'LDFReader = New StreamReader(LabelFileName.Text)
        LDFReader = New FileStream(filepath, FileMode.Open, FileAccess.Read)
        NumericUpDownLineToReplace.Enabled = False
        If Not (LDFReader Is Nothing) Then
            'If LDFReader.Peek() >= 0 Then
            ReDim Buffer(BufferLength)
            LDFReader.Read(Buffer, 0, Buffer.Length - 1)
            CompleteRecordFound = True
            BufferCount += 1
            BufferString = Encoding.Default.GetString(Buffer, 0, Buffer.Length)
            BufferString = PartialBuffer & BufferString

            My.Application.DoEvents()
            While CompleteRecordFound = True
                FoundRecordEnd = FoundStringPositon(FoundRecordStart + 2, BufferString, Chr(RECSEP).ToString)
                If FoundRecordEnd > 0 Then
                    CompleteRecordFound = True
                    ActiveRecord = Mid$(BufferString, FoundRecordStart, FoundRecordEnd - FoundRecordStart)

                    FoundRecordStart = FoundRecordEnd
                    RecordCount += 1

                    LineData = ParseRecord(ActiveRecord)
                    ldfRecordNumber = Val(Mid(LineData(0), 4, 9))
                    If ldfRecordNumber >= Val(TextBoxStartRecord.Text) And ldfRecordNumber <= Val(TextBoxEndRecord.Text) Then
                        CountRecord = True
                    Else
                        CountRecord = False
                    End If
                    ' DataFromLineToCheckLength = LineData(LineToCheckLength).Trim
                    'If Len(DataFromLineToCheckLength) > 19 Then
                    '    Debug.Print(ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(19).Trim)
                    '    TextBox2.Text = ldfRecordNumber & "," & TextBox2.Text
                    '    StringToOutput = StringToOutput & ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(19).Trim & vbCrLf
                    'End If
                    ' bitmapName = LineData(NumericUpDownGraphicLineToScan.Value).Trim



                    ' CharCounts = CountCharacters(LineData(NumericUpDownLineToScan.Value).ToString)


                    TextBoxLabel = ""
                    For index = 0 To LineData.Length - 1
                        TextBoxLabel = TextBoxLabel & "[" & index & "] " & LineData(index).ToString + Environment.NewLine
                    Next

                    TextBox1.Text = TextBoxLabel
                    Exit While



                Else
                    PartialBuffer = Mid$(BufferString, FoundRecordStart, Len(BufferString) - FoundRecordStart)
                    FoundRecordStart = 1

                    CompleteRecordFound = False



                End If
            End While

            If PartialBuffer.Length > 10 And FoundRecordEnd < 1 Then
                ActiveRecord = PartialBuffer

                RecordCount += 1

                LineData = ParseRecord(ActiveRecord)
                ldfRecordNumber = Val(Mid(LineData(0), 4, 9))
                If ldfRecordNumber >= Val(TextBoxStartRecord.Text) And ldfRecordNumber <= Val(TextBoxEndRecord.Text) Then
                    CountRecord = True
                Else
                    CountRecord = False
                End If
                If CountRecord Then
                    CharCounts = CountCharacters(LineData(NumericUpDownLineToReplace.Value).ToString)
                    For charIndex = 0 To 255
                        CharCountsTotal(charIndex) += CharCounts(charIndex)
                        If CharCountsTotal(charIndex).ToString = "1" Then
                            FindPixelsPerChar(charIndex)
                        End If
                    Next
                    DataFromLineToCheckLength = LineData(LineToCheckLength).Trim
                    If Len(DataFromLineToCheckLength) > 19 Then
                        Debug.Print(ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(19).Trim)
                        ' TextBox2.Text = ldfRecordNumber & "," & TextBox2.Text
                        StringToOutput = StringToOutput & ldfRecordNumber & "," & DataFromLineToCheckLength & "," & LineData(AlternateLineToCheckLength).Trim & "," & LineData(19).Trim & vbCrLf
                    End If
                    bitmapName = LineData(NumericUpDownGraphicLineToScan.Value).Trim
                    If Len(bitmapName) > 0 Then
                        ReDim Preserve UniqueBitmapCodes(BitmapElements)
                        ReDim Preserve BitmapCounts(BitmapElements)
                        ReDim Preserve BitmapDarkPixels(BitmapElements)
                        ReDim Preserve BitmapDarkPixelsWithSkip(BitmapElements)
                        ReDim Preserve BitmapPaths(BitmapElements)

                        BitmapNameFound = False
                        For BitmapIndex = 0 To BitmapElements
                            If bitmapName = UniqueBitmapCodes(BitmapIndex) Then
                                BitmapCounts(BitmapIndex) += 1
                                BitmapNameFound = True
                                Exit For
                            End If
                        Next
                        If BitmapNameFound = False Then
                            ReDim Preserve UniqueBitmapCodes(BitmapElements)
                            ReDim Preserve BitmapRecordNumberFirstOccurance(BitmapElements)
                            ReDim Preserve DataLineStringLongest(BitmapElements)
                            ReDim Preserve DataLineLongestRecordNumber(BitmapElements)
                            UniqueBitmapCodes(BitmapIndex - 1) = bitmapName.ToString
                            BitmapRecordNumberFirstOccurance(BitmapIndex - 1) = ldfRecordNumber
                            DataLineLongestRecordNumber(BitmapIndex - 1) = ldfRecordNumber
                            DataLineStringLongest(BitmapIndex - 1) = ((LineData(NumericUpDownLineToReplace.Value).ToString).Trim)

                            BitmapCounts(BitmapIndex - 1) = 1
                            BitmapElements += 1
                        Else
                            Dim tempstring As String = (LineData(NumericUpDownLineToReplace.Value).ToString).Trim
                            If Len((LineData(NumericUpDownLineToReplace.Value).ToString).Trim) > Len(DataLineStringLongest(BitmapIndex)) Then
                                DataLineLongestRecordNumber(BitmapIndex) = ldfRecordNumber
                                DataLineStringLongest(BitmapIndex) = ((LineData(NumericUpDownLineToReplace.Value).ToString).Trim)
                            End If
                            If tempstring.Length > 0 Then


                                If tempstring.Substring(tempstring.Length - 1, 1) <> "," Then
                                    ' TextBox2.Text = ldfRecordNumber & "," & TextBox2.Text
                                End If
                            End If
                        End If

                    End If
                End If
            End If
        End If
        'End If
        Me.NumericUpDownLineToReplace.Maximum = LineData.Length - 1
        Me.NumericUpDownGraphicLineToScan.Maximum = LineData.Length - 1
        LDFReader.Dispose()

        TextBoxLabel = ""
        For index = 0 To LineData.Length - 1
            TextBoxLabel = TextBoxLabel & "[" & index & "] " & LineData(index).ToString + Environment.NewLine
        Next

        UpdateListviewItems()
        TextBox1.Text = TextBoxLabel
        If Len(StringToOutput) > 0 Then
            dataWriterPath = "test.txt"
            Using DataWriter As New StreamWriter(dataWriterPath)
                DataWriter.Write(StringToOutput)
            End Using
        End If
        StringToOutput = ""

        ButtonScan.Enabled = True
        NumericUpDownLineToReplace.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

   
    Private Sub btnOutputTableToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutputTableToFile.Click
        Dim desktopPath = My.Computer.FileSystem.SpecialDirectories.Desktop

        ' Concatenate desktop path and file name
        Dim filePath = desktopPath & "/GraphicsList.txt"
        Using writer As New StreamWriter(filePath)
            For Each item As ListViewItem In Me.ListViewGraphics.Items
                'If item.BackColor = Color.LightGreen Then
                'For index = 0 To item.SubItems.Count - 1
                For index = 0 To 2
                    If index = 0 Or index = 1 Or index = 7 Then
                        If index > 0 Then
                            writer.Write(", ")
                        End If

                        writer.Write(item.SubItems(index).Text)
                    End If

                Next
                writer.WriteLine()
                ' End If
            Next
        End Using


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAddDict.Click

        OpenFileDialog2.Multiselect = False
        OpenFileDialog2.Filter = "txt files (*.txt|*.txt|All Files (*.*)|*.*"
        OpenFileDialog2.FilterIndex = 2
        OpenFileDialog2.InitialDirectory = My.Settings.LastDictionaryLocation
        OpenFileDialog2.RestoreDirectory = True
        OpenFileDialog2.Title = "Please Selected a Dictionary File"

        OpenFileDialog2.ShowDialog()
    End Sub
    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Dim allLines As String() = File.ReadAllLines(OpenFileDialog2.FileName, Encoding.Default)

        Dim fileInfo As New FileInfo(OpenFileDialog2.FileName)
        My.Settings.LastDictionaryLocation = fileInfo.Directory.ToString
        Dim arr(3) As String
        'lookupDict.Clear()
        For i = 0 To allLines.Count - 1
            Dim singleLine As String() = (allLines(i).Split(vbTab))
            If lookupDict.ContainsKey(singleLine(0).ToString) Then
                MessageBox.Show("Duplicate Key in Dictionary file" + allLines(i).ToString)
            Else
                lookupDict.Add(singleLine(0).ToString, singleLine(2).ToString)
            End If

        Next
        'For i = 0 To allLines.Count - 1 Step 4
        '    If lookupDict.ContainsKey(allLines(i).ToString) Then
        '        MessageBox.Show("Duplicate Key in Dictionary file" + allLines(i).ToString)
        '    Else
        '        lookupDict.Add(allLines(i).ToString, allLines(i + 3).ToString)
        '    End If

        'Next
        For Each ikey As String In lookupDict.Keys

            arr(0) = ikey
            arr(1) = Chr(Int(lookupDict(ikey)) Mod 255)
            'arr(2) = str_to_hex(lookupDict(ikey))
            arr(2) = str_to_hex(arr(1))
            arr(3) = lookupDict(ikey)

            Dim item = New ListViewItem(arr)
            ' ListViewDictionary.Items.Clear()
            ListViewDictionary.Items.Add(item)
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.Text = Microsoft.VisualBasic.Right("000" + TextBox2.Text, 3)
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        'TextBox2.Text = Microsoft.VisualBasic.Right("000" + TextBox2.Text, 3)

    End Sub

    Private Sub ButtonClearDictionaryFile_Click_1(sender As Object, e As EventArgs) Handles ButtonClearDictionaryFile.Click
        lookupDict.Clear()
        ListViewDictionary.Items.Clear()
    End Sub

    Private Sub ListViewUndefinedCodes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewUndefinedCodes.SelectedIndexChanged

    End Sub
End Class
