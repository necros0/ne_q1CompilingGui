<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prefs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.toolsFolderTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.browseToolsFolder = New System.Windows.Forms.Button()
        Me.qbspTextbox = New System.Windows.Forms.TextBox()
        Me.visTextbox = New System.Windows.Forms.TextBox()
        Me.lightTextbox = New System.Windows.Forms.TextBox()
        Me.convertMainGroupBox = New System.Windows.Forms.GroupBox()
        Me.convertGroupBox2 = New System.Windows.Forms.GroupBox()
        Me.convArgsTextBox = New System.Windows.Forms.TextBox()
        Me.convertGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.convTextBox = New System.Windows.Forms.TextBox()
        Me.mapNeedsConverting = New System.Windows.Forms.CheckBox()
        Me.prefsDone = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lightArgsTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.visArgsTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.qbspArgsTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.browseWorkingFolder = New System.Windows.Forms.Button()
        Me.workingFolderTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.browseOutputFolder = New System.Windows.Forms.Button()
        Me.outputFolderTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.pointFileRenameLinRadioButton = New System.Windows.Forms.RadioButton()
        Me.pointFileRenamePtsRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.skipTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.skipArgsTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.convertMainGroupBox.SuspendLayout()
        Me.convertGroupBox2.SuspendLayout()
        Me.convertGroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolsFolderTextbox
        '
        Me.toolsFolderTextbox.Location = New System.Drawing.Point(6, 19)
        Me.toolsFolderTextbox.Name = "toolsFolderTextbox"
        Me.toolsFolderTextbox.Size = New System.Drawing.Size(327, 20)
        Me.toolsFolderTextbox.TabIndex = 0
        Me.toolsFolderTextbox.Text = "C:\"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.browseToolsFolder)
        Me.GroupBox1.Controls.Add(Me.toolsFolderTextbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools folder"
        '
        'browseToolsFolder
        '
        Me.browseToolsFolder.Location = New System.Drawing.Point(339, 19)
        Me.browseToolsFolder.Name = "browseToolsFolder"
        Me.browseToolsFolder.Size = New System.Drawing.Size(27, 20)
        Me.browseToolsFolder.TabIndex = 1
        Me.browseToolsFolder.Text = "..."
        Me.browseToolsFolder.UseVisualStyleBackColor = True
        '
        'qbspTextbox
        '
        Me.qbspTextbox.Location = New System.Drawing.Point(6, 19)
        Me.qbspTextbox.Name = "qbspTextbox"
        Me.qbspTextbox.Size = New System.Drawing.Size(102, 20)
        Me.qbspTextbox.TabIndex = 0
        Me.qbspTextbox.Text = "qbsp.exe"
        '
        'visTextbox
        '
        Me.visTextbox.Location = New System.Drawing.Point(6, 19)
        Me.visTextbox.Name = "visTextbox"
        Me.visTextbox.Size = New System.Drawing.Size(102, 20)
        Me.visTextbox.TabIndex = 0
        Me.visTextbox.Text = "vis.exe"
        '
        'lightTextbox
        '
        Me.lightTextbox.Location = New System.Drawing.Point(6, 19)
        Me.lightTextbox.Name = "lightTextbox"
        Me.lightTextbox.Size = New System.Drawing.Size(102, 20)
        Me.lightTextbox.TabIndex = 0
        Me.lightTextbox.Text = "light.exe"
        '
        'convertMainGroupBox
        '
        Me.convertMainGroupBox.Controls.Add(Me.convertGroupBox2)
        Me.convertMainGroupBox.Controls.Add(Me.convertGroupBox1)
        Me.convertMainGroupBox.Controls.Add(Me.mapNeedsConverting)
        Me.convertMainGroupBox.Location = New System.Drawing.Point(390, 12)
        Me.convertMainGroupBox.Name = "convertMainGroupBox"
        Me.convertMainGroupBox.Size = New System.Drawing.Size(372, 99)
        Me.convertMainGroupBox.TabIndex = 2
        Me.convertMainGroupBox.TabStop = False
        Me.convertMainGroupBox.Text = "Supplementary"
        '
        'convertGroupBox2
        '
        Me.convertGroupBox2.Controls.Add(Me.convArgsTextBox)
        Me.convertGroupBox2.Location = New System.Drawing.Point(126, 41)
        Me.convertGroupBox2.Name = "convertGroupBox2"
        Me.convertGroupBox2.Size = New System.Drawing.Size(240, 50)
        Me.convertGroupBox2.TabIndex = 2
        Me.convertGroupBox2.TabStop = False
        Me.convertGroupBox2.Text = "Command-line Arguments"
        Me.convertGroupBox2.Visible = False
        '
        'convArgsTextBox
        '
        Me.convArgsTextBox.Location = New System.Drawing.Point(6, 19)
        Me.convArgsTextBox.Name = "convArgsTextBox"
        Me.convArgsTextBox.ReadOnly = True
        Me.convArgsTextBox.Size = New System.Drawing.Size(228, 20)
        Me.convArgsTextBox.TabIndex = 0
        Me.convArgsTextBox.Text = "-f32"
        '
        'convertGroupBox1
        '
        Me.convertGroupBox1.Controls.Add(Me.convTextBox)
        Me.convertGroupBox1.Location = New System.Drawing.Point(6, 41)
        Me.convertGroupBox1.Name = "convertGroupBox1"
        Me.convertGroupBox1.Size = New System.Drawing.Size(114, 50)
        Me.convertGroupBox1.TabIndex = 1
        Me.convertGroupBox1.TabStop = False
        Me.convertGroupBox1.Text = "Map Converter"
        Me.convertGroupBox1.Visible = False
        '
        'convTextBox
        '
        Me.convTextBox.Location = New System.Drawing.Point(6, 19)
        Me.convTextBox.Name = "convTextBox"
        Me.convTextBox.ReadOnly = True
        Me.convTextBox.Size = New System.Drawing.Size(102, 20)
        Me.convTextBox.TabIndex = 0
        Me.convTextBox.Text = "convmap.exe"
        '
        'mapNeedsConverting
        '
        Me.mapNeedsConverting.AutoSize = True
        Me.mapNeedsConverting.Location = New System.Drawing.Point(6, 19)
        Me.mapNeedsConverting.Name = "mapNeedsConverting"
        Me.mapNeedsConverting.Size = New System.Drawing.Size(224, 17)
        Me.mapNeedsConverting.TabIndex = 0
        Me.mapNeedsConverting.Text = "Map must be converted before compiling?"
        Me.mapNeedsConverting.UseVisualStyleBackColor = True
        '
        'prefsDone
        '
        Me.prefsDone.Location = New System.Drawing.Point(667, 273)
        Me.prefsDone.Name = "prefsDone"
        Me.prefsDone.Size = New System.Drawing.Size(95, 24)
        Me.prefsDone.TabIndex = 6
        Me.prefsDone.Text = "Done"
        Me.prefsDone.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lightTextbox)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 131)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(114, 50)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "LIGHT"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lightArgsTextbox)
        Me.GroupBox9.Location = New System.Drawing.Point(126, 131)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 50)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Command-line Arguments"
        '
        'lightArgsTextbox
        '
        Me.lightArgsTextbox.Location = New System.Drawing.Point(6, 19)
        Me.lightArgsTextbox.Name = "lightArgsTextbox"
        Me.lightArgsTextbox.Size = New System.Drawing.Size(228, 20)
        Me.lightArgsTextbox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.visTextbox)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 50)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VIS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.visArgsTextbox)
        Me.GroupBox3.Location = New System.Drawing.Point(126, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 50)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Command-line Arguments"
        '
        'visArgsTextbox
        '
        Me.visArgsTextbox.Location = New System.Drawing.Point(6, 19)
        Me.visArgsTextbox.Name = "visArgsTextbox"
        Me.visArgsTextbox.Size = New System.Drawing.Size(228, 20)
        Me.visArgsTextbox.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox12)
        Me.GroupBox4.Controls.Add(Me.GroupBox13)
        Me.GroupBox4.Controls.Add(Me.GroupBox11)
        Me.GroupBox4.Controls.Add(Me.GroupBox10)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.GroupBox9)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(372, 244)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Compilers"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.qbspArgsTextbox)
        Me.GroupBox11.Location = New System.Drawing.Point(126, 19)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(240, 50)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Command-line Arguments"
        '
        'qbspArgsTextbox
        '
        Me.qbspArgsTextbox.Location = New System.Drawing.Point(6, 19)
        Me.qbspArgsTextbox.Name = "qbspArgsTextbox"
        Me.qbspArgsTextbox.Size = New System.Drawing.Size(228, 20)
        Me.qbspArgsTextbox.TabIndex = 0
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.qbspTextbox)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(114, 50)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "QBSP"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.browseWorkingFolder)
        Me.GroupBox5.Controls.Add(Me.workingFolderTextbox)
        Me.GroupBox5.Location = New System.Drawing.Point(390, 117)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(372, 48)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Working Folder"
        '
        'browseWorkingFolder
        '
        Me.browseWorkingFolder.Location = New System.Drawing.Point(339, 19)
        Me.browseWorkingFolder.Name = "browseWorkingFolder"
        Me.browseWorkingFolder.Size = New System.Drawing.Size(27, 20)
        Me.browseWorkingFolder.TabIndex = 1
        Me.browseWorkingFolder.Text = "..."
        Me.browseWorkingFolder.UseVisualStyleBackColor = True
        '
        'workingFolderTextbox
        '
        Me.workingFolderTextbox.Location = New System.Drawing.Point(6, 19)
        Me.workingFolderTextbox.Name = "workingFolderTextbox"
        Me.workingFolderTextbox.Size = New System.Drawing.Size(327, 20)
        Me.workingFolderTextbox.TabIndex = 0
        Me.workingFolderTextbox.Text = "C:\"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.browseOutputFolder)
        Me.GroupBox6.Controls.Add(Me.outputFolderTextbox)
        Me.GroupBox6.Location = New System.Drawing.Point(390, 171)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(372, 48)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Output Folder"
        '
        'browseOutputFolder
        '
        Me.browseOutputFolder.Location = New System.Drawing.Point(339, 19)
        Me.browseOutputFolder.Name = "browseOutputFolder"
        Me.browseOutputFolder.Size = New System.Drawing.Size(27, 20)
        Me.browseOutputFolder.TabIndex = 1
        Me.browseOutputFolder.Text = "..."
        Me.browseOutputFolder.UseVisualStyleBackColor = True
        '
        'outputFolderTextbox
        '
        Me.outputFolderTextbox.Location = New System.Drawing.Point(6, 19)
        Me.outputFolderTextbox.Name = "outputFolderTextbox"
        Me.outputFolderTextbox.Size = New System.Drawing.Size(327, 20)
        Me.outputFolderTextbox.TabIndex = 0
        Me.outputFolderTextbox.Text = "C:\"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.pointFileRenamePtsRadioButton)
        Me.GroupBox7.Controls.Add(Me.pointFileRenameLinRadioButton)
        Me.GroupBox7.Location = New System.Drawing.Point(390, 258)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(114, 46)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Pointfile Extension"
        '
        'pointFileRenameLinRadioButton
        '
        Me.pointFileRenameLinRadioButton.AutoSize = True
        Me.pointFileRenameLinRadioButton.Location = New System.Drawing.Point(70, 19)
        Me.pointFileRenameLinRadioButton.Name = "pointFileRenameLinRadioButton"
        Me.pointFileRenameLinRadioButton.Size = New System.Drawing.Size(38, 17)
        Me.pointFileRenameLinRadioButton.TabIndex = 9
        Me.pointFileRenameLinRadioButton.Text = ".lin"
        Me.pointFileRenameLinRadioButton.UseVisualStyleBackColor = True
        '
        'pointFileRenamePtsRadioButton
        '
        Me.pointFileRenamePtsRadioButton.AutoSize = True
        Me.pointFileRenamePtsRadioButton.Checked = True
        Me.pointFileRenamePtsRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.pointFileRenamePtsRadioButton.Name = "pointFileRenamePtsRadioButton"
        Me.pointFileRenamePtsRadioButton.Size = New System.Drawing.Size(42, 17)
        Me.pointFileRenamePtsRadioButton.TabIndex = 10
        Me.pointFileRenamePtsRadioButton.TabStop = True
        Me.pointFileRenamePtsRadioButton.Text = ".pts"
        Me.pointFileRenamePtsRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.skipTextbox)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 187)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(114, 50)
        Me.GroupBox12.TabIndex = 6
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Skip Removal"
        '
        'skipTextbox
        '
        Me.skipTextbox.Location = New System.Drawing.Point(6, 19)
        Me.skipTextbox.Name = "skipTextbox"
        Me.skipTextbox.Size = New System.Drawing.Size(102, 20)
        Me.skipTextbox.TabIndex = 0
        Me.skipTextbox.Text = "skip.exe"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.skipArgsTextbox)
        Me.GroupBox13.Location = New System.Drawing.Point(126, 187)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(240, 50)
        Me.GroupBox13.TabIndex = 7
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Command-line Arguments"
        '
        'skipArgsTextbox
        '
        Me.skipArgsTextbox.Location = New System.Drawing.Point(6, 19)
        Me.skipArgsTextbox.Name = "skipArgsTextbox"
        Me.skipArgsTextbox.Size = New System.Drawing.Size(228, 20)
        Me.skipArgsTextbox.TabIndex = 0
        '
        'prefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 316)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.prefsDone)
        Me.Controls.Add(Me.convertMainGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "prefs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.convertMainGroupBox.ResumeLayout(False)
        Me.convertMainGroupBox.PerformLayout()
        Me.convertGroupBox2.ResumeLayout(False)
        Me.convertGroupBox2.PerformLayout()
        Me.convertGroupBox1.ResumeLayout(False)
        Me.convertGroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents toolsFolderTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents qbspTextbox As System.Windows.Forms.TextBox
    Friend WithEvents visTextbox As System.Windows.Forms.TextBox
    Friend WithEvents lightTextbox As System.Windows.Forms.TextBox
    Friend WithEvents convertMainGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents convTextBox As System.Windows.Forms.TextBox
    Friend WithEvents mapNeedsConverting As System.Windows.Forms.CheckBox
    Friend WithEvents convertGroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents convArgsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents convertGroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents prefsDone As System.Windows.Forms.Button
    Friend WithEvents browseToolsFolder As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lightArgsTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents visArgsTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents qbspArgsTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents browseWorkingFolder As System.Windows.Forms.Button
    Friend WithEvents workingFolderTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents browseOutputFolder As System.Windows.Forms.Button
    Friend WithEvents outputFolderTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents pointFileRenameLinRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents pointFileRenamePtsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents skipTextbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents skipArgsTextbox As System.Windows.Forms.TextBox
End Class
