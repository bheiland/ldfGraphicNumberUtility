<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLineToReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownGraphicLineToScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBmpPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSelectFile
        '
        Me.ButtonSelectFile.Location = New System.Drawing.Point(12, 12)
        Me.ButtonSelectFile.Name = "ButtonSelectFile"
        Me.ButtonSelectFile.Size = New System.Drawing.Size(162, 23)
        Me.ButtonSelectFile.TabIndex = 0
        Me.ButtonSelectFile.Text = "Select Files"
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
        Me.ListViewCharacters.Location = New System.Drawing.Point(966, 114)
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
        Me.TextBox3.Size = New System.Drawing.Size(291, 287)
        Me.TextBox3.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(679, 69)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 666)
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
        Me.MinimumSize = New System.Drawing.Size(727, 464)
        Me.Name = "Form1"
        Me.Text = "LDFGraphicNumberUtility"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLineToReplace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownGraphicLineToScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBmpPreview, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
