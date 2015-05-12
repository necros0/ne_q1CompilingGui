Public Class prefs

    Private Sub setConvertMapVisibility()
        If mapNeedsConverting.Checked() = True Then
            convTextBox.ReadOnly = False
            convArgsTextBox.ReadOnly = False

            convertGroupBox1.Visible = True
            convertGroupBox2.Visible = True

            convertMainGroupBox.Height() = 99 'Size() = 372, 99
        Else
            convTextBox.ReadOnly = True
            convArgsTextBox.ReadOnly = True

            convertGroupBox1.Visible = False
            convertGroupBox2.Visible = False

            convertMainGroupBox.Height() = 42 'Size() = 372, 99
        End If
    End Sub

    Private Sub mapNeedsConverting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mapNeedsConverting.CheckedChanged
        setConvertMapVisibility()
    End Sub

    Private Sub prefsDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prefsDone.Click
        Me.Close()
    End Sub

    Private Sub browseToolsFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseToolsFolder.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog

        With folderBrowserDialog1

            .RootFolder = Environment.SpecialFolder.MyComputer
            .SelectedPath = toolsFolderTextbox.Text()
            .Description = "Select the folder containing your tools."

            If .ShowDialog = 1 Then
                toolsFolderTextbox.Text() = .SelectedPath
            End If
        End With
    End Sub

    Private Sub prefs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        toolsFolder = toolsFolderTextbox.Text()
        workingFolder = workingFolderTextbox.Text()
        outputFolder = outputFolderTextbox.Text()

        qbspFilename = qbspTextbox.Text()
        qbspArgs = qbspArgsTextbox.Text()

        visFilename = visTextbox.Text()
        visArgs = visArgsTextbox.Text()

        lightFilename = lightTextbox.Text()
        lightArgs = lightArgsTextbox.Text()

        skipFilename = skipTextbox.Text()
        skipArgs = skipArgsTextbox.Text()

        convertMap = mapNeedsConverting.Checked
        convFilename = convTextBox.Text()
        convArgs = convArgsTextBox.Text()

        pointFileRenamePts = pointFileRenamePtsRadioButton.Checked
        pointFileRenameLin = pointFileRenameLinRadioButton.Checked

        mainWindow.Show()
        mainWindow.updateMainWindow()
    End Sub


    Private Sub prefs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        toolsFolderTextbox.Text() = toolsFolder
        workingFolderTextbox.Text() = workingFolder
        outputFolderTextbox.Text() = outputFolder

        qbspTextbox.Text() = qbspFilename
        qbspArgsTextbox.Text() = qbspArgs

        visTextbox.Text() = visFilename
        visArgsTextbox.Text() = visArgs

        lightTextbox.Text() = lightFilename
        lightArgsTextbox.Text() = lightArgs

        skipTextbox.Text() = skipFilename
        skipArgsTextbox.Text() = skipArgs

        mapNeedsConverting.Checked = convertMap
        setConvertMapVisibility() 'set appropriate visibility settings...
        convTextBox.Text() = convFilename
        convArgsTextBox.Text() = convArgs

        If pointFileRenamePts = False And pointFileRenameLin = False Then 'both are false (unchecked)
            pointFileRenamePts = True 'default to pts
        End If

        pointFileRenamePtsRadioButton.Checked = pointFileRenamePts
        pointFileRenameLinRadioButton.Checked = pointFileRenameLin
    End Sub


    Private Sub browseWorkingFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseWorkingFolder.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog

        With folderBrowserDialog1

            .RootFolder = Environment.SpecialFolder.MyComputer
            .SelectedPath = workingFolderTextbox.Text()
            .Description = "Select the folder to compile in."

            If .ShowDialog = 1 Then
                workingFolderTextbox.Text() = .SelectedPath
            End If
        End With
    End Sub

    Private Sub browseOutputFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseOutputFolder.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog

        With folderBrowserDialog1

            .RootFolder = Environment.SpecialFolder.MyComputer
            .SelectedPath = outputFolderTextbox.Text()
            .Description = "Select the folder to compile in."

            If .ShowDialog = 1 Then
                outputFolderTextbox.Text() = .SelectedPath
            End If
        End With
    End Sub

End Class