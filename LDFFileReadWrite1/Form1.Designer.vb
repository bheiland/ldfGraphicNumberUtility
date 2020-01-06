<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonSelectFile = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabelFileName = New System.Windows.Forms.Label()
        Me.ButtonScan = New System.Windows.Forms.Button()
        Me.ListViewCharacters = New System.Windows.Forms.ListView()
        Me.LabelFontName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelTotalInkML = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownLineToReplace = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDownGraphicLineToScan = New System.Windows.Forms.NumericUpDown()
        Me.ListViewGraphics = New System.Windows.Forms.ListView()
        Me.TextBoxStartRecord = New System.Windows.Forms.TextBox()
        Me.TextBoxEndRecord = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OpenFileDialogBitmap = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxBmpPreview = New System.Windows.Forms.PictureBox()
        Me.ButtonAutoAddGraphics = New System.Windows.Forms.Button()
        Me.MyFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnOutputTableToFile = New System.Windows.Forms.Button()
        Me.ButtonAddDict = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ListViewDictionary = New System.Windows.Forms.ListView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClearDictionaryFile = New System.Windows.Forms.Button()
        Me.ListViewUndefinedCodes = New System.Windows.Forms.ListView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CheckBoxIncludeFirstVersion = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPalletIdTo1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxOutputMakeupMatching = New System.Windows.Forms.CheckBox()
        Me.TextBoxOutputEveryMakeupMatching = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLineToReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownGraphicLineToScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBmpPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSelectFile
        '
        Me.ButtonSelectFile.Location = New System.Drawing.Point(24, 23)
        Me.ButtonSelectFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ButtonSelectFile.Name = "ButtonSelectFile"
        Me.ButtonSelectFile.Size = New System.Drawing.Size(324, 44)
        Me.ButtonSelectFile.TabIndex = 0
        Me.ButtonSelectFile.Text = "Select LDF Files"
        Me.ButtonSelectFile.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 133)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(888, 1104)
        Me.TextBox1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LabelFileName
        '
        Me.LabelFileName.AutoSize = True
        Me.LabelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFileName.Location = New System.Drawing.Point(360, 33)
        Me.LabelFileName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelFileName.Name = "LabelFileName"
        Me.LabelFileName.Size = New System.Drawing.Size(2, 27)
        Me.LabelFileName.TabIndex = 2
        '
        'ButtonScan
        '
        Me.ButtonScan.Enabled = False
        Me.ButtonScan.Location = New System.Drawing.Point(1908, 17)
        Me.ButtonScan.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ButtonScan.Name = "ButtonScan"
        Me.ButtonScan.Size = New System.Drawing.Size(186, 44)
        Me.ButtonScan.TabIndex = 3
        Me.ButtonScan.Text = "Start Process"
        Me.ButtonScan.UseVisualStyleBackColor = True
        '
        'ListViewCharacters
        '
        Me.ListViewCharacters.Location = New System.Drawing.Point(2116, 13)
        Me.ListViewCharacters.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ListViewCharacters.MultiSelect = False
        Me.ListViewCharacters.Name = "ListViewCharacters"
        Me.ListViewCharacters.Size = New System.Drawing.Size(158, 50)
        Me.ListViewCharacters.TabIndex = 5
        Me.ListViewCharacters.UseCompatibleStateImageBehavior = False
        Me.ListViewCharacters.Visible = False
        '
        'LabelFontName
        '
        Me.LabelFontName.AutoSize = True
        Me.LabelFontName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFontName.Location = New System.Drawing.Point(74, 965)
        Me.LabelFontName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelFontName.Name = "LabelFontName"
        Me.LabelFontName.Size = New System.Drawing.Size(0, 36)
        Me.LabelFontName.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(522, 1083)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 158)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'labelTotalInkML
        '
        Me.labelTotalInkML.AutoSize = True
        Me.labelTotalInkML.Location = New System.Drawing.Point(1808, 660)
        Me.labelTotalInkML.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.labelTotalInkML.Name = "labelTotalInkML"
        Me.labelTotalInkML.Size = New System.Drawing.Size(0, 25)
        Me.labelTotalInkML.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1514, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Data Line to Replace"
        '
        'NumericUpDownLineToReplace
        '
        Me.NumericUpDownLineToReplace.Location = New System.Drawing.Point(1760, 179)
        Me.NumericUpDownLineToReplace.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NumericUpDownLineToReplace.Maximum = New Decimal(New Integer() {144, 0, 0, 0})
        Me.NumericUpDownLineToReplace.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownLineToReplace.Name = "NumericUpDownLineToReplace"
        Me.NumericUpDownLineToReplace.Size = New System.Drawing.Size(98, 31)
        Me.NumericUpDownLineToReplace.TabIndex = 19
        Me.NumericUpDownLineToReplace.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1514, 138)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Graphic Line To Check"
        '
        'NumericUpDownGraphicLineToScan
        '
        Me.NumericUpDownGraphicLineToScan.Location = New System.Drawing.Point(1760, 135)
        Me.NumericUpDownGraphicLineToScan.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NumericUpDownGraphicLineToScan.Maximum = New Decimal(New Integer() {144, 0, 0, 0})
        Me.NumericUpDownGraphicLineToScan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownGraphicLineToScan.Name = "NumericUpDownGraphicLineToScan"
        Me.NumericUpDownGraphicLineToScan.Size = New System.Drawing.Size(98, 31)
        Me.NumericUpDownGraphicLineToScan.TabIndex = 25
        Me.NumericUpDownGraphicLineToScan.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'ListViewGraphics
        '
        Me.ListViewGraphics.Location = New System.Drawing.Point(1522, 285)
        Me.ListViewGraphics.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ListViewGraphics.MultiSelect = False
        Me.ListViewGraphics.Name = "ListViewGraphics"
        Me.ListViewGraphics.Size = New System.Drawing.Size(568, 389)
        Me.ListViewGraphics.TabIndex = 26
        Me.ListViewGraphics.UseCompatibleStateImageBehavior = False
        '
        'TextBoxStartRecord
        '
        Me.TextBoxStartRecord.Location = New System.Drawing.Point(94, 83)
        Me.TextBoxStartRecord.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBoxStartRecord.Name = "TextBoxStartRecord"
        Me.TextBoxStartRecord.Size = New System.Drawing.Size(76, 31)
        Me.TextBoxStartRecord.TabIndex = 29
        Me.TextBoxStartRecord.Text = "0"
        '
        'TextBoxEndRecord
        '
        Me.TextBoxEndRecord.Location = New System.Drawing.Point(388, 83)
        Me.TextBoxEndRecord.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBoxEndRecord.Name = "TextBoxEndRecord"
        Me.TextBoxEndRecord.Size = New System.Drawing.Size(106, 31)
        Me.TextBoxEndRecord.TabIndex = 30
        Me.TextBoxEndRecord.Text = "9999999"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(324, 90)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 25)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "End"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 88)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 25)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Start"
        '
        'OpenFileDialogBitmap
        '
        Me.OpenFileDialogBitmap.FileName = "OpenFileDialog2"
        '
        'PictureBoxBmpPreview
        '
        Me.PictureBoxBmpPreview.Location = New System.Drawing.Point(522, 1083)
        Me.PictureBoxBmpPreview.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBoxBmpPreview.Name = "PictureBoxBmpPreview"
        Me.PictureBoxBmpPreview.Size = New System.Drawing.Size(296, 179)
        Me.PictureBoxBmpPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxBmpPreview.TabIndex = 35
        Me.PictureBoxBmpPreview.TabStop = False
        Me.PictureBoxBmpPreview.Visible = False
        '
        'ButtonAutoAddGraphics
        '
        Me.ButtonAutoAddGraphics.Location = New System.Drawing.Point(952, 1023)
        Me.ButtonAutoAddGraphics.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ButtonAutoAddGraphics.Name = "ButtonAutoAddGraphics"
        Me.ButtonAutoAddGraphics.Size = New System.Drawing.Size(210, 44)
        Me.ButtonAutoAddGraphics.TabIndex = 39
        Me.ButtonAutoAddGraphics.Text = "AutoAddGraphics"
        Me.ButtonAutoAddGraphics.UseVisualStyleBackColor = True
        '
        'MyFolderBrowser
        '
        Me.MyFolderBrowser.SelectedPath = "c:\jobs\"
        Me.MyFolderBrowser.ShowNewFolderButton = False
        '
        'btnOutputTableToFile
        '
        Me.btnOutputTableToFile.Location = New System.Drawing.Point(1522, 229)
        Me.btnOutputTableToFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOutputTableToFile.Name = "btnOutputTableToFile"
        Me.btnOutputTableToFile.Size = New System.Drawing.Size(240, 44)
        Me.btnOutputTableToFile.TabIndex = 42
        Me.btnOutputTableToFile.Text = "Output table to file"
        Me.btnOutputTableToFile.UseVisualStyleBackColor = True
        '
        'ButtonAddDict
        '
        Me.ButtonAddDict.Location = New System.Drawing.Point(980, 17)
        Me.ButtonAddDict.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ButtonAddDict.Name = "ButtonAddDict"
        Me.ButtonAddDict.Size = New System.Drawing.Size(462, 44)
        Me.ButtonAddDict.TabIndex = 43
        Me.ButtonAddDict.Text = "Add Dictionary File"
        Me.ButtonAddDict.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'ListViewDictionary
        '
        Me.ListViewDictionary.Location = New System.Drawing.Point(952, 192)
        Me.ListViewDictionary.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ListViewDictionary.Name = "ListViewDictionary"
        Me.ListViewDictionary.Size = New System.Drawing.Size(506, 1044)
        Me.ListViewDictionary.TabIndex = 44
        Me.ListViewDictionary.UseCompatibleStateImageBehavior = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1522, 688)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(578, 260)
        Me.TextBox3.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1358, 133)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.MaxLength = 3
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 31)
        Me.TextBox2.TabIndex = 46
        Me.TextBox2.Text = "102"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(948, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Global font for characters > 255"
        '
        'ButtonClearDictionaryFile
        '
        Me.ButtonClearDictionaryFile.Location = New System.Drawing.Point(980, 69)
        Me.ButtonClearDictionaryFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ButtonClearDictionaryFile.Name = "ButtonClearDictionaryFile"
        Me.ButtonClearDictionaryFile.Size = New System.Drawing.Size(462, 44)
        Me.ButtonClearDictionaryFile.TabIndex = 48
        Me.ButtonClearDictionaryFile.Text = "Clear Dictionary File"
        Me.ButtonClearDictionaryFile.UseVisualStyleBackColor = True
        '
        'ListViewUndefinedCodes
        '
        Me.ListViewUndefinedCodes.Location = New System.Drawing.Point(2106, 285)
        Me.ListViewUndefinedCodes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ListViewUndefinedCodes.MultiSelect = False
        Me.ListViewUndefinedCodes.Name = "ListViewUndefinedCodes"
        Me.ListViewUndefinedCodes.Size = New System.Drawing.Size(168, 389)
        Me.ListViewUndefinedCodes.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewUndefinedCodes.TabIndex = 49
        Me.ListViewUndefinedCodes.UseCompatibleStateImageBehavior = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1522, 967)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(578, 269)
        Me.TextBox4.TabIndex = 50
        '
        'CheckBoxIncludeFirstVersion
        '
        Me.CheckBoxIncludeFirstVersion.AutoSize = True
        Me.CheckBoxIncludeFirstVersion.Location = New System.Drawing.Point(12, 50)
        Me.CheckBoxIncludeFirstVersion.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CheckBoxIncludeFirstVersion.Name = "CheckBoxIncludeFirstVersion"
        Me.CheckBoxIncludeFirstVersion.Size = New System.Drawing.Size(231, 29)
        Me.CheckBoxIncludeFirstVersion.TabIndex = 51
        Me.CheckBoxIncludeFirstVersion.Text = "Include 1st Makeup"
        Me.CheckBoxIncludeFirstVersion.UseVisualStyleBackColor = True
        '
        'CheckBoxPalletIdTo1
        '
        Me.CheckBoxPalletIdTo1.AutoSize = True
        Me.CheckBoxPalletIdTo1.Location = New System.Drawing.Point(12, 94)
        Me.CheckBoxPalletIdTo1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CheckBoxPalletIdTo1.Name = "CheckBoxPalletIdTo1"
        Me.CheckBoxPalletIdTo1.Size = New System.Drawing.Size(181, 29)
        Me.CheckBoxPalletIdTo1.TabIndex = 52
        Me.CheckBoxPalletIdTo1.Text = "Pallet ID's to 1"
        Me.CheckBoxPalletIdTo1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBoxPalletIdTo1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxPalletIdTo1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxIncludeFirstVersion)
        Me.GroupBox1.Location = New System.Drawing.Point(2116, 688)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(356, 138)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Occurance File Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxOutputEveryMakeupMatching)
        Me.GroupBox2.Controls.Add(Me.CheckBoxOutputMakeupMatching)
        Me.GroupBox2.Location = New System.Drawing.Point(2116, 848)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 134)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Every Occurance Settings"
        '
        'CheckBoxOutputMakeupMatching
        '
        Me.CheckBoxOutputMakeupMatching.AutoSize = True
        Me.CheckBoxOutputMakeupMatching.Location = New System.Drawing.Point(18, 40)
        Me.CheckBoxOutputMakeupMatching.Name = "CheckBoxOutputMakeupMatching"
        Me.CheckBoxOutputMakeupMatching.Size = New System.Drawing.Size(285, 29)
        Me.CheckBoxOutputMakeupMatching.TabIndex = 0
        Me.CheckBoxOutputMakeupMatching.Text = "Output Makeup Matching"
        Me.CheckBoxOutputMakeupMatching.UseVisualStyleBackColor = True
        '
        'TextBoxOutputEveryMakeupMatching
        '
        Me.TextBoxOutputEveryMakeupMatching.Location = New System.Drawing.Point(19, 90)
        Me.TextBoxOutputEveryMakeupMatching.Name = "TextBoxOutputEveryMakeupMatching"
        Me.TextBoxOutputEveryMakeupMatching.Size = New System.Drawing.Size(282, 31)
        Me.TextBoxOutputEveryMakeupMatching.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2496, 1281)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ListViewUndefinedCodes)
        Me.Controls.Add(Me.ButtonClearDictionaryFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ListViewDictionary)
        Me.Controls.Add(Me.ButtonAddDict)
        Me.Controls.Add(Me.btnOutputTableToFile)
        Me.Controls.Add(Me.ButtonAutoAddGraphics)
        Me.Controls.Add(Me.PictureBoxBmpPreview)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxEndRecord)
        Me.Controls.Add(Me.TextBoxStartRecord)
        Me.Controls.Add(Me.ListViewGraphics)
        Me.Controls.Add(Me.NumericUpDownGraphicLineToScan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumericUpDownLineToReplace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelTotalInkML)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelFontName)
        Me.Controls.Add(Me.ListViewCharacters)
        Me.Controls.Add(Me.ButtonScan)
        Me.Controls.Add(Me.LabelFileName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonSelectFile)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MinimumSize = New System.Drawing.Size(1428, 827)
        Me.Name = "Form1"
        Me.Text = "LDFGraphicNumberUtility"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLineToReplace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownGraphicLineToScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBmpPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSelectFile As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelFileName As System.Windows.Forms.Label
    Friend WithEvents ButtonScan As System.Windows.Forms.Button
    Friend WithEvents ListViewCharacters As System.Windows.Forms.ListView
    Friend WithEvents LabelFontName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents labelTotalInkML As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownLineToReplace As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownGraphicLineToScan As System.Windows.Forms.NumericUpDown
    Friend WithEvents ListViewGraphics As System.Windows.Forms.ListView
    Friend WithEvents TextBoxStartRecord As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndRecord As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogBitmap As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBoxBmpPreview As System.Windows.Forms.PictureBox
    Public WithEvents ButtonAutoAddGraphics As System.Windows.Forms.Button
    Friend WithEvents MyFolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnOutputTableToFile As System.Windows.Forms.Button
    Friend WithEvents ButtonAddDict As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListViewDictionary As System.Windows.Forms.ListView
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonClearDictionaryFile As Button
    Friend WithEvents ListViewUndefinedCodes As ListView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBoxIncludeFirstVersion As CheckBox
    Friend WithEvents CheckBoxPalletIdTo1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxOutputMakeupMatching As CheckBox
    Friend WithEvents TextBoxOutputEveryMakeupMatching As TextBox
End Class
