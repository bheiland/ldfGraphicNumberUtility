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
        Me.TextBoxOutputEveryMakeupMatching = New System.Windows.Forms.TextBox()
        Me.CheckBoxOutputMakeupMatching = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownDataLineForDataMatrixEncoding = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxAppendDataMatrix = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLineToReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownGraphicLineToScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBmpPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDownDataLineForDataMatrixEncoding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSelectFile
        '
        Me.ButtonSelectFile.Location = New System.Drawing.Point(12, 12)
        Me.ButtonSelectFile.Name = "ButtonSelectFile"
        Me.ButtonSelectFile.Size = New System.Drawing.Size(162, 23)
        Me.ButtonSelectFile.TabIndex = 0
        Me.ButtonSelectFile.Text = "Select LDF Files"
        Me.ButtonSelectFile.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 69)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(446, 576)
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
        Me.LabelFileName.Location = New System.Drawing.Point(180, 17)
        Me.LabelFileName.Name = "LabelFileName"
        Me.LabelFileName.Size = New System.Drawing.Size(2, 15)
        Me.LabelFileName.TabIndex = 2
        '
        'ButtonScan
        '
        Me.ButtonScan.Enabled = False
        Me.ButtonScan.Location = New System.Drawing.Point(954, 9)
        Me.ButtonScan.Name = "ButtonScan"
        Me.ButtonScan.Size = New System.Drawing.Size(93, 23)
        Me.ButtonScan.TabIndex = 3
        Me.ButtonScan.Text = "Start Process"
        Me.ButtonScan.UseVisualStyleBackColor = True
        '
        'ListViewCharacters
        '
        Me.ListViewCharacters.HideSelection = False
        Me.ListViewCharacters.Location = New System.Drawing.Point(1058, 7)
        Me.ListViewCharacters.MultiSelect = False
        Me.ListViewCharacters.Name = "ListViewCharacters"
        Me.ListViewCharacters.Size = New System.Drawing.Size(81, 28)
        Me.ListViewCharacters.TabIndex = 5
        Me.ListViewCharacters.UseCompatibleStateImageBehavior = False
        Me.ListViewCharacters.Visible = False
        '
        'LabelFontName
        '
        Me.LabelFontName.AutoSize = True
        Me.LabelFontName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFontName.Location = New System.Drawing.Point(37, 502)
        Me.LabelFontName.Name = "LabelFontName"
        Me.LabelFontName.Size = New System.Drawing.Size(0, 18)
        Me.LabelFontName.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(261, 563)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 82)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'labelTotalInkML
        '
        Me.labelTotalInkML.AutoSize = True
        Me.labelTotalInkML.Location = New System.Drawing.Point(904, 343)
        Me.labelTotalInkML.Name = "labelTotalInkML"
        Me.labelTotalInkML.Size = New System.Drawing.Size(0, 13)
        Me.labelTotalInkML.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(757, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Data Line to Replace"
        '
        'NumericUpDownLineToReplace
        '
        Me.NumericUpDownLineToReplace.Location = New System.Drawing.Point(880, 93)
        Me.NumericUpDownLineToReplace.Maximum = New Decimal(New Integer() {144, 0, 0, 0})
        Me.NumericUpDownLineToReplace.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownLineToReplace.Name = "NumericUpDownLineToReplace"
        Me.NumericUpDownLineToReplace.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDownLineToReplace.TabIndex = 19
        Me.NumericUpDownLineToReplace.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(757, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Graphic Line To Check"
        '
        'NumericUpDownGraphicLineToScan
        '
        Me.NumericUpDownGraphicLineToScan.Location = New System.Drawing.Point(880, 70)
        Me.NumericUpDownGraphicLineToScan.Maximum = New Decimal(New Integer() {144, 0, 0, 0})
        Me.NumericUpDownGraphicLineToScan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownGraphicLineToScan.Name = "NumericUpDownGraphicLineToScan"
        Me.NumericUpDownGraphicLineToScan.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDownGraphicLineToScan.TabIndex = 25
        Me.NumericUpDownGraphicLineToScan.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'ListViewGraphics
        '
        Me.ListViewGraphics.HideSelection = False
        Me.ListViewGraphics.Location = New System.Drawing.Point(761, 148)
        Me.ListViewGraphics.MultiSelect = False
        Me.ListViewGraphics.Name = "ListViewGraphics"
        Me.ListViewGraphics.Size = New System.Drawing.Size(286, 204)
        Me.ListViewGraphics.TabIndex = 26
        Me.ListViewGraphics.UseCompatibleStateImageBehavior = False
        '
        'TextBoxStartRecord
        '
        Me.TextBoxStartRecord.Location = New System.Drawing.Point(47, 43)
        Me.TextBoxStartRecord.Name = "TextBoxStartRecord"
        Me.TextBoxStartRecord.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxStartRecord.TabIndex = 29
        Me.TextBoxStartRecord.Text = "0"
        '
        'TextBoxEndRecord
        '
        Me.TextBoxEndRecord.Location = New System.Drawing.Point(194, 43)
        Me.TextBoxEndRecord.Name = "TextBoxEndRecord"
        Me.TextBoxEndRecord.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxEndRecord.TabIndex = 30
        Me.TextBoxEndRecord.Text = "9999999"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(162, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "End"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Start"
        '
        'OpenFileDialogBitmap
        '
        Me.OpenFileDialogBitmap.FileName = "OpenFileDialog2"
        '
        'PictureBoxBmpPreview
        '
        Me.PictureBoxBmpPreview.Location = New System.Drawing.Point(261, 563)
        Me.PictureBoxBmpPreview.Name = "PictureBoxBmpPreview"
        Me.PictureBoxBmpPreview.Size = New System.Drawing.Size(148, 93)
        Me.PictureBoxBmpPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxBmpPreview.TabIndex = 35
        Me.PictureBoxBmpPreview.TabStop = False
        Me.PictureBoxBmpPreview.Visible = False
        '
        'ButtonAutoAddGraphics
        '
        Me.ButtonAutoAddGraphics.Location = New System.Drawing.Point(476, 532)
        Me.ButtonAutoAddGraphics.Name = "ButtonAutoAddGraphics"
        Me.ButtonAutoAddGraphics.Size = New System.Drawing.Size(105, 23)
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
        Me.btnOutputTableToFile.Location = New System.Drawing.Point(761, 119)
        Me.btnOutputTableToFile.Name = "btnOutputTableToFile"
        Me.btnOutputTableToFile.Size = New System.Drawing.Size(120, 23)
        Me.btnOutputTableToFile.TabIndex = 42
        Me.btnOutputTableToFile.Text = "Output table to file"
        Me.btnOutputTableToFile.UseVisualStyleBackColor = True
        '
        'ButtonAddDict
        '
        Me.ButtonAddDict.Location = New System.Drawing.Point(490, 9)
        Me.ButtonAddDict.Name = "ButtonAddDict"
        Me.ButtonAddDict.Size = New System.Drawing.Size(231, 23)
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
        Me.ListViewDictionary.HideSelection = False
        Me.ListViewDictionary.Location = New System.Drawing.Point(476, 100)
        Me.ListViewDictionary.Name = "ListViewDictionary"
        Me.ListViewDictionary.Size = New System.Drawing.Size(255, 545)
        Me.ListViewDictionary.TabIndex = 44
        Me.ListViewDictionary.UseCompatibleStateImageBehavior = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(761, 358)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(291, 137)
        Me.TextBox3.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(679, 69)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.MaxLength = 3
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(52, 20)
        Me.TextBox2.TabIndex = 46
        Me.TextBox2.Text = "102"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Global font for characters > 255"
        '
        'ButtonClearDictionaryFile
        '
        Me.ButtonClearDictionaryFile.Location = New System.Drawing.Point(490, 36)
        Me.ButtonClearDictionaryFile.Name = "ButtonClearDictionaryFile"
        Me.ButtonClearDictionaryFile.Size = New System.Drawing.Size(231, 23)
        Me.ButtonClearDictionaryFile.TabIndex = 48
        Me.ButtonClearDictionaryFile.Text = "Clear Dictionary File"
        Me.ButtonClearDictionaryFile.UseVisualStyleBackColor = True
        '
        'ListViewUndefinedCodes
        '
        Me.ListViewUndefinedCodes.HideSelection = False
        Me.ListViewUndefinedCodes.Location = New System.Drawing.Point(1053, 148)
        Me.ListViewUndefinedCodes.MultiSelect = False
        Me.ListViewUndefinedCodes.Name = "ListViewUndefinedCodes"
        Me.ListViewUndefinedCodes.Size = New System.Drawing.Size(86, 204)
        Me.ListViewUndefinedCodes.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewUndefinedCodes.TabIndex = 49
        Me.ListViewUndefinedCodes.UseCompatibleStateImageBehavior = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(761, 503)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(291, 142)
        Me.TextBox4.TabIndex = 50
        '
        'CheckBoxIncludeFirstVersion
        '
        Me.CheckBoxIncludeFirstVersion.AutoSize = True
        Me.CheckBoxIncludeFirstVersion.Location = New System.Drawing.Point(6, 26)
        Me.CheckBoxIncludeFirstVersion.Name = "CheckBoxIncludeFirstVersion"
        Me.CheckBoxIncludeFirstVersion.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxIncludeFirstVersion.TabIndex = 51
        Me.CheckBoxIncludeFirstVersion.Text = "Include 1st Makeup"
        Me.CheckBoxIncludeFirstVersion.UseVisualStyleBackColor = True
        '
        'CheckBoxPalletIdTo1
        '
        Me.CheckBoxPalletIdTo1.AutoSize = True
        Me.CheckBoxPalletIdTo1.Location = New System.Drawing.Point(6, 49)
        Me.CheckBoxPalletIdTo1.Name = "CheckBoxPalletIdTo1"
        Me.CheckBoxPalletIdTo1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBoxPalletIdTo1.TabIndex = 52
        Me.CheckBoxPalletIdTo1.Text = "Pallet ID's to 1"
        Me.CheckBoxPalletIdTo1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBoxPalletIdTo1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxPalletIdTo1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxIncludeFirstVersion)
        Me.GroupBox1.Location = New System.Drawing.Point(1058, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 72)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Occurance File Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxOutputEveryMakeupMatching)
        Me.GroupBox2.Controls.Add(Me.CheckBoxOutputMakeupMatching)
        Me.GroupBox2.Location = New System.Drawing.Point(1058, 441)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(178, 70)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Every Occurance Settings"
        '
        'TextBoxOutputEveryMakeupMatching
        '
        Me.TextBoxOutputEveryMakeupMatching.Location = New System.Drawing.Point(10, 47)
        Me.TextBoxOutputEveryMakeupMatching.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxOutputEveryMakeupMatching.Name = "TextBoxOutputEveryMakeupMatching"
        Me.TextBoxOutputEveryMakeupMatching.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxOutputEveryMakeupMatching.TabIndex = 1
        '
        'CheckBoxOutputMakeupMatching
        '
        Me.CheckBoxOutputMakeupMatching.AutoSize = True
        Me.CheckBoxOutputMakeupMatching.Location = New System.Drawing.Point(9, 21)
        Me.CheckBoxOutputMakeupMatching.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxOutputMakeupMatching.Name = "CheckBoxOutputMakeupMatching"
        Me.CheckBoxOutputMakeupMatching.Size = New System.Drawing.Size(147, 17)
        Me.CheckBoxOutputMakeupMatching.TabIndex = 0
        Me.CheckBoxOutputMakeupMatching.Text = "Output Makeup Matching"
        Me.CheckBoxOutputMakeupMatching.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NumericUpDownDataLineForDataMatrixEncoding)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.CheckBoxAppendDataMatrix)
        Me.GroupBox3.Location = New System.Drawing.Point(1058, 516)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 117)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DataMatrix Encoding"
        '
        'NumericUpDownDataLineForDataMatrixEncoding
        '
        Me.NumericUpDownDataLineForDataMatrixEncoding.Location = New System.Drawing.Point(123, 47)
        Me.NumericUpDownDataLineForDataMatrixEncoding.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownDataLineForDataMatrixEncoding.Name = "NumericUpDownDataLineForDataMatrixEncoding"
        Me.NumericUpDownDataLineForDataMatrixEncoding.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDownDataLineForDataMatrixEncoding.TabIndex = 2
        Me.NumericUpDownDataLineForDataMatrixEncoding.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Line To Encode"
        '
        'CheckBoxAppendDataMatrix
        '
        Me.CheckBoxAppendDataMatrix.AutoSize = True
        Me.CheckBoxAppendDataMatrix.Location = New System.Drawing.Point(10, 18)
        Me.CheckBoxAppendDataMatrix.Name = "CheckBoxAppendDataMatrix"
        Me.CheckBoxAppendDataMatrix.Size = New System.Drawing.Size(165, 17)
        Me.CheckBoxAppendDataMatrix.TabIndex = 0
        Me.CheckBoxAppendDataMatrix.Text = "Append DataMatrix Encoding"
        Me.CheckBoxAppendDataMatrix.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 697)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.MinimumSize = New System.Drawing.Size(722, 449)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDownDataLineForDataMatrixEncoding, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NumericUpDownDataLineForDataMatrixEncoding As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxAppendDataMatrix As CheckBox
End Class
