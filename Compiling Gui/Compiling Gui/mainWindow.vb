Public Class mainWindow

    Dim qbspTogglesArray As toggleButtonArray
    Dim visTogglesArray As toggleButtonArray
    Dim lightTogglesArray As toggleButtonArray

    Private Sub mainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'save settings in /config.ini
        Dim iniFilePath As String = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
        Dim configFile As String = iniFilePath + "\config.ini"
        Dim buffer As String
        Dim toggleState As Integer

        If doNotSaveSettings = False Then
            Dim objWriter As New System.IO.StreamWriter(configFile)

            objWriter.WriteLine("*bsp")
            objWriter.WriteLine(qbspFilename)
            objWriter.WriteLine(qbspArgs)
            objWriter.WriteLine()

            objWriter.WriteLine("*vis")
            objWriter.WriteLine(visFilename)
            objWriter.WriteLine(visArgs)
            objWriter.WriteLine()

            objWriter.WriteLine("*lit")
            objWriter.WriteLine(lightFilename)
            objWriter.WriteLine(lightArgs)
            objWriter.WriteLine()

            objWriter.WriteLine("*skip")
            objWriter.WriteLine(skipFilename)
            objWriter.WriteLine(skipArgs)
            objWriter.WriteLine(useSkip.Checked())
            objWriter.WriteLine()

            objWriter.WriteLine("*tools")
            objWriter.WriteLine(toolsFolder)

            objWriter.WriteLine("*work")
            objWriter.WriteLine(workingFolder)

            objWriter.WriteLine("*output")
            objWriter.WriteLine(outputFolder)

            objWriter.WriteLine("*lastMap")
            'objWriter.WriteLine(mapFilename)
            objWriter.WriteLine(mapFileTextBox.Text)

            objWriter.WriteLine()

            objWriter.WriteLine("*convert")
            objWriter.WriteLine(convertMap.ToString)
            objWriter.WriteLine(convFilename)
            objWriter.WriteLine(convArgs)

            objWriter.WriteLine()

            objWriter.WriteLine("*pointfile")
            objWriter.WriteLine(pointFileRenamePts) 'it will only ever be one or the other though, so this is kind of a dumb way to save it.
            objWriter.WriteLine(pointFileRenameLin)

            objWriter.WriteLine()

            objWriter.WriteLine("*chk")
            objWriter.WriteLine(pauseAfterQbsp.Checked())
            objWriter.WriteLine(useQbsp.Checked())
            objWriter.WriteLine(pauseAfterVis.Checked())
            objWriter.WriteLine(useVis.Checked())
            objWriter.WriteLine(pauseAfterLight.Checked())
            objWriter.WriteLine(useLight.Checked())
            objWriter.WriteLine(pauseAfterCompiling.Checked())
            objWriter.WriteLine(runEngine.Checked())

            objWriter.WriteLine()

            objWriter.WriteLine("*engine")
            objWriter.WriteLine(engineTextbox.Text())
            objWriter.WriteLine(engineArgsTextbox.Text())

            objWriter.WriteLine()

            '=================================================================
            objWriter.WriteLine("*blockStart_bsp")
            Dim currentArrayCount As Integer = 0
            For currentArrayCount = 0 To qbspTogglesArray.Count - 1
                If qbspTogglesArray(currentArrayCount).Checked = True Then
                    toggleState = 1
                Else
                    toggleState = 0
                End If
                buffer = CStr(toggleState) + qbspTogglesArray(currentArrayCount).Text
                objWriter.WriteLine(buffer)
            Next
            objWriter.WriteLine("*blockEnd_bsp")

            objWriter.WriteLine()
            '=================================================================
            objWriter.WriteLine("*blockStart_vis")
            currentArrayCount = 0
            For currentArrayCount = 0 To visTogglesArray.Count - 1
                If visTogglesArray(currentArrayCount).Checked = True Then
                    toggleState = 1
                Else
                    toggleState = 0
                End If
                buffer = CStr(toggleState) + visTogglesArray(currentArrayCount).Text
                objWriter.WriteLine(buffer)
            Next
            objWriter.WriteLine("*blockEnd_vis")

            objWriter.WriteLine()

            objWriter.WriteLine("*blockStart_lit")
            currentArrayCount = 0
            For currentArrayCount = 0 To lightTogglesArray.Count - 1
                If lightTogglesArray(currentArrayCount).Checked = True Then
                    toggleState = 1
                Else
                    toggleState = 0
                End If
                buffer = CStr(toggleState) + lightTogglesArray(currentArrayCount).Text
                objWriter.WriteLine(buffer)
            Next
            objWriter.WriteLine("*blockEnd_lit")


            objWriter.Close() 'finished writing file, close
        End If

    End Sub

    Private Sub mainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iniFilePath As String = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
        Dim configFile As String = iniFilePath + "\config.ini"
        Dim buffer As String = ""

        qbspTogglesArray = New toggleButtonArray(qbspGroupBox)
        visTogglesArray = New toggleButtonArray(visGroupBox)
        lightTogglesArray = New toggleButtonArray(lightGroupBox)

        If Dir(configFile) <> "" Then
            Dim objReader As New System.IO.StreamReader(configFile)
            Try
                While objReader.EndOfStream = False
                    buffer = objReader.ReadLine()

                    If buffer = "*bsp" Then
                        qbspFilename = objReader.ReadLine()
                        qbspArgs = objReader.ReadLine()
                    ElseIf buffer = "*vis" Then
                        visFilename = objReader.ReadLine()
                        visArgs = objReader.ReadLine()
                    ElseIf buffer = "*lit" Then
                        lightFilename = objReader.ReadLine()
                        lightArgs = objReader.ReadLine()
                    ElseIf buffer = "*skip" Then
                        skipFilename = objReader.ReadLine()
                        skipArgs = objReader.ReadLine()
                        useSkip.Checked() = objReader.ReadLine()
                    ElseIf buffer = "*tools" Then
                        toolsFolder = objReader.ReadLine()
                    ElseIf buffer = "*work" Then
                        workingFolder = objReader.ReadLine()
                    ElseIf buffer = "*output" Then
                        outputFolder = objReader.ReadLine()
                    ElseIf buffer = "*lastMap" Then
                        mapFilename = objReader.ReadLine()
                    ElseIf buffer = "*convert" Then
                        buffer = objReader.ReadLine()
                        If buffer.Substring(0, 1) = "T" Then
                            convertMap = True
                        Else
                            convertMap = False
                        End If
                        convFilename = objReader.ReadLine()
                        convArgs = objReader.ReadLine()
                    ElseIf buffer = "*pointfile" Then
                        pointFileRenamePts = objReader.ReadLine()
                        pointFileRenameLin = objReader.ReadLine()
                    ElseIf buffer = "*chk" Then
                        pauseAfterQbsp.Checked() = objReader.ReadLine()
                        useQbsp.Checked() = objReader.ReadLine()
                        pauseAfterVis.Checked() = objReader.ReadLine()
                        useVis.Checked() = objReader.ReadLine()
                        pauseAfterLight.Checked() = objReader.ReadLine()
                        useLight.Checked() = objReader.ReadLine()
                        pauseAfterCompiling.Checked() = objReader.ReadLine()
                        runEngine.Checked() = objReader.ReadLine()
                    ElseIf buffer = "*engine" Then
                        engineTextbox.Text() = objReader.ReadLine()
                        engineArgsTextbox.Text = objReader.ReadLine()

                    ElseIf buffer = "*blockStart_bsp" Then
                        buffer = objReader.ReadLine()
                        While buffer <> "*blockEnd_bsp"
                            addToggleButton(qbspTogglesArray, buffer.Remove(0, 1), qbspTogglesArray.Count, buffer.Substring(0, 1))
                            buffer = objReader.ReadLine()
                        End While
                    ElseIf buffer = "*blockStart_vis" Then
                        buffer = objReader.ReadLine()
                        While buffer <> "*blockEnd_vis"
                            addToggleButton(visTogglesArray, buffer.Remove(0, 1), visTogglesArray.Count, buffer.Substring(0, 1))
                            buffer = objReader.ReadLine()
                        End While
                    ElseIf buffer = "*blockStart_lit" Then
                        buffer = objReader.ReadLine()
                        While buffer <> "*blockEnd_lit"
                            addToggleButton(lightTogglesArray, buffer.Remove(0, 1), lightTogglesArray.Count, buffer.Substring(0, 1))
                            buffer = objReader.ReadLine()
                        End While
                    End If

                End While
                objReader.Close()
            Catch
                MsgBox("Couldn't load your previous settings: there was a problem parsing your config.ini file.  Try launching the program again.  If that is unsuccessful, restore the default config.ini that came with this program.", MsgBoxStyle.Critical, "Error")
                objReader.Close()
                Me.Close()
            End Try
        Else
            createDefaultConfigFile()
            doNotSaveSettings = True
            MsgBox("Config.ini not present, could not load any previous settings.  Restart the program to continue with default settings.", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If


        updateMainWindow()

    End Sub
  

    Private Sub FolderSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderSetupToolStripMenuItem.Click
        Me.Hide()
        prefs.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub updateMainWindow() 'update all the stuff here...
        Dim currentArgCount As Integer = 0

        qbsp_commandLineTextbox.Text() = qbspFilename
        If qbspArgs <> "" Then 'add permanent args
            qbsp_commandLineTextbox.Text() = qbsp_commandLineTextbox.Text() + " " + qbspArgs
        End If

        vis_commandLineTextbox.Text() = visFilename
        If visArgs <> "" Then 'add permanent args
            vis_commandLineTextbox.Text() = vis_commandLineTextbox.Text() + " " + visArgs
        End If

        light_commandLineTextbox.Text() = lightFilename
        If lightArgs <> "" Then 'add permanent args
            light_commandLineTextbox.Text() = light_commandLineTextbox.Text() + " " + lightArgs
        End If

        mapFileTextbox.Text() = mapFilename

        While currentArgCount < qbspTogglesArray.Count 'add optional args
            If qbspTogglesArray(currentArgCount).Checked = True Then
                qbsp_commandLineTextbox.Text() = qbsp_commandLineTextbox.Text() + " " + qbspTogglesArray(currentArgCount).Text
            End If
            currentArgCount = currentArgCount + 1
        End While

        currentArgCount = 0 'reset
        While currentArgCount < visTogglesArray.Count 'add optional args
            If visTogglesArray(currentArgCount).Checked = True Then
                vis_commandLineTextbox.Text() = vis_commandLineTextbox.Text() + " " + visTogglesArray(currentArgCount).Text
            End If
            currentArgCount = currentArgCount + 1
        End While

        currentArgCount = 0 'reset
        While currentArgCount < lightTogglesArray.Count 'add optional args
            If lightTogglesArray(currentArgCount).Checked = True Then
                light_commandLineTextbox.Text() = light_commandLineTextbox.Text() + " " + lightTogglesArray(currentArgCount).Text
            End If
            currentArgCount = currentArgCount + 1
        End While

    End Sub

    Public Sub addToggleButton(ByVal currentTogglesArray As toggleButtonArray, ByVal text As String, ByVal arrayCount As Integer, ByVal toggleState As Integer)
        Dim newToggle As CheckBox

        newToggle = currentTogglesArray.addNewToggle()
        newToggle.Text() = text
        newToggle.Location = New Point(6 + (96 * (arrayCount Mod 3) + 6 * (arrayCount Mod 3)), 66 + (24 * Math.Floor(arrayCount / 3)) + (6 * Math.Floor(arrayCount / 3)))
        newToggle.Checked = toggleState
        newToggle.Visible = True
    End Sub

    Private Sub add_addMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_addMenuItem.Click

        Dim currentTogglesArray As toggleButtonArray
        Dim toggleArray_currentNum As Integer
        'Dim newToggle As CheckBox
        Dim newToggleArg As String

        If compileOptionsAdd_menuStrip.SourceControl.Text = "QBSP" Then
            toggleArray_currentNum = qbspTogglesArray.Count
            currentTogglesArray = qbspTogglesArray
        ElseIf compileOptionsAdd_menuStrip.SourceControl.Text = "VIS" Then
            toggleArray_currentNum = visTogglesArray.Count
            currentTogglesArray = visTogglesArray
        Else 'If compileOptionsAdd_menuStrip.SourceControl.Text = "LIGHT" Then
            toggleArray_currentNum = lightTogglesArray.Count
            currentTogglesArray = lightTogglesArray
        End If

        If toggleArray_currentNum < 9 Then 'don't allow more than 9 buttons because there's no room
            newToggleArg = InputBox("Enter Argument:", "New Args", "")
            If newToggleArg <> "" Then 'dont do this if the user presses cancel or doesn't write anything (cancels returns "")
                'newToggle = currentTogglesArray.addNewToggle()
                'newToggle.Text() = newToggleArg
                'newToggle.Location = New Point(6 + (96 * (toggleArray_currentNum Mod 3) + 6 * (toggleArray_currentNum Mod 3)), 66 + (24 * Math.Floor(toggleArray_currentNum / 3)) + (6 * Math.Floor(toggleArray_currentNum / 3)))
                addToggleButton(currentTogglesArray, newToggleArg, toggleArray_currentNum, 0)
            End If
        End If



    End Sub

    Private Sub edit_editMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_editMenuItem.Click
        Dim newToggleArg As String
        Dim selectedToggle As CheckBox

        selectedToggle = compileOptionsEdit_menuStrip.SourceControl

        newToggleArg = InputBox("Enter new Argument:", "New Args", selectedToggle.Text)
        If newToggleArg <> "" Then
            selectedToggle.Text = newToggleArg
        End If

        updateMainWindow() 'update after edits
    End Sub

    Private Sub edit_removeMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_removeMenuItem.Click
        Dim selectedToggle As CheckBox
        Dim selectedToggleArray As toggleButtonArray
        Dim currentToggle As CheckBox
        Dim currentArgCount As Integer = 0


        selectedToggle = compileOptionsEdit_menuStrip.SourceControl 'get the button we're right clicking.
        'MsgBox(selectedToggle.Parent.Text, MsgBoxStyle.Critical, "")
        If selectedToggle.Parent.Text = "QBSP" Then
            selectedToggleArray = qbspTogglesArray
        ElseIf selectedToggle.Parent.Text = "VIS" Then
            selectedToggleArray = visTogglesArray
        Else
            selectedToggleArray = lightTogglesArray
        End If

        selectedToggleArray.remove(selectedToggle.Tag) 'aannnd get rid of it.

        While currentArgCount < selectedToggleArray.Count 'rearrange the buttons and update the tags to match
            currentToggle = selectedToggleArray(currentArgCount)
            currentToggle.Location = New Point(6 + (96 * (currentArgCount Mod 3) + 6 * (currentArgCount Mod 3)), 66 + (24 * Math.Floor(currentArgCount / 3)) + (6 * Math.Floor(currentArgCount / 3)))
            currentToggle.Tag = currentArgCount
            currentArgCount = currentArgCount + 1
        End While

        updateMainWindow() 'update after all the cleanup
    End Sub

    Private Sub CompileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompileToolStripMenuItem.Click
        Dim objWriter As New System.IO.StreamWriter(workingFolder + "\compile.bat")
        Dim buffer As String
        Dim arrayCounter As Integer

        Dim tempMapFile As String
        Dim tempMapArg As String
        Dim tempEngineName As String

        mapFilename = mapFileTextbox.Text
        tempMapFile = mapFilename.Substring(mapFilename.LastIndexOf("\") + 1, mapFilename.Length - (5 + mapFilename.LastIndexOf("\")))
        'Swapped with above: Make the run command use the filename in the textbox and not require using the dialog box
        'tempMapFile = mapFileTextbox.Text.Substring(mapFileTextbox.Text.LastIndexOf("\") + 1, mapFileTextbox.Text.Length - (5 + mapFileTextbox.Text.LastIndexOf("\")))


        objWriter.WriteLine("@echo off")

        objWriter.WriteLine()

        objWriter.WriteLine("cd\")
        objWriter.WriteLine("cd " + workingFolder)

        objWriter.WriteLine()

        'objWriter.WriteLine("echo Clearing out old files...")
        'objWriter.WriteLine("del " + tempMapFile + ".pts")
        'objWriter.WriteLine("del " + tempMapFile + ".prt")
        'objWriter.WriteLine("del " + tempMapFile + ".vis")

        objWriter.WriteLine()

        objWriter.WriteLine("echo Copying Files...")
        objWriter.WriteLine("copy " + mapFilename + " " + workingFolder)

        objWriter.WriteLine()
        objWriter.WriteLine()

        objWriter.WriteLine("echo Converting map...")
        If convertMap = True Then
            objWriter.WriteLine(toolsFolder + "\" + convFilename + " " + convArgs + " " + tempMapFile)
            objWriter.WriteLine("move /y " + tempMapFile + ".out " + tempMapFile + ".map")
        End If

        objWriter.WriteLine()
        objWriter.WriteLine()

        If useQbsp.Checked = True Then
            '=================================================================
            objWriter.WriteLine("echo --------------QBSP--------------")
            buffer = toolsFolder + "\" + qbspFilename
            If qbspArgs <> "" Then
                buffer = buffer + " " + qbspArgs
            End If

            arrayCounter = 0
            While arrayCounter < qbspTogglesArray.Count
                If qbspTogglesArray(arrayCounter).Checked = True Then
                    buffer = buffer + " " + qbspTogglesArray(arrayCounter).Text
                End If
                arrayCounter = arrayCounter + 1
            End While

            buffer = buffer + " " + tempMapFile
            objWriter.WriteLine(buffer)
            '=================================================================
            If useSkip.Checked = True Then
                objWriter.WriteLine("echo --------------SKIP--------------")
                buffer = toolsFolder + "\" + skipFilename
                If skipArgs <> "" Then
                    buffer = buffer + " " + skipArgs
                End If
                buffer = buffer + " " + tempMapFile
                objWriter.WriteLine(buffer)
            End If
            If pauseAfterQbsp.Checked = True Then
                objWriter.WriteLine("pause")
            End If
            objWriter.WriteLine()
        End If

        If useVis.Checked = True Then
            '=================================================================
            objWriter.WriteLine("echo --------------VIS---------------")
            buffer = toolsFolder + "\" + visFilename
            If visArgs <> "" Then
                buffer = buffer + " " + visArgs
            End If

            arrayCounter = 0
            While arrayCounter < visTogglesArray.Count
                If visTogglesArray(arrayCounter).Checked = True Then
                    buffer = buffer + " " + visTogglesArray(arrayCounter).Text
                End If
                arrayCounter = arrayCounter + 1
            End While

            buffer = buffer + " " + tempMapFile
            objWriter.WriteLine(buffer)
            '=================================================================
            If pauseAfterVis.Checked = True Then
                objWriter.WriteLine("pause")
            End If
            objWriter.WriteLine()
        End If

        If useLight.Checked = True Then
            '=================================================================
            objWriter.WriteLine("echo -------------LIGHT--------------")
            buffer = toolsFolder + "\" + lightFilename
            If lightArgs <> "" Then
                buffer = buffer + " " + lightArgs
            End If

            arrayCounter = 0
            While arrayCounter < lightTogglesArray.Count
                If lightTogglesArray(arrayCounter).Checked = True Then
                    buffer = buffer + " " + lightTogglesArray(arrayCounter).Text
                End If
                arrayCounter = arrayCounter + 1
            End While

            buffer = buffer + " " + tempMapFile
            objWriter.WriteLine(buffer)
            '=================================================================
            If pauseAfterLight.Checked = True Then
                objWriter.WriteLine("pause")
            End If
            objWriter.WriteLine()
        End If

        objWriter.WriteLine("copy " + tempMapFile + ".bsp " + outputFolder)
        objWriter.WriteLine("copy " + tempMapFile + ".pts " + outputFolder) 'pts files into output folder for engine pointfile builtin
        objWriter.WriteLine("copy " + tempMapFile + ".lit " + outputFolder) 'lit files for coloured lighting

        If pauseAfterCompiling.Checked = True Then
            objWriter.WriteLine("pause")
        End If

        If runEngine.Checked = True Then
            tempEngineName = engineTextbox.Text '.Substring(mapFilename.LastIndexOf("\") + 1, mapFilename.Length - (5 + mapFilename.LastIndexOf("\")))

            Try
                If outputFolder.Contains("\maps\") Then 'maps are in a subfolder of maps.
                    tempMapArg = outputFolder.Substring(outputFolder.LastIndexOf("\maps\") + 5)
                    tempMapArg = tempMapArg.Substring(1)
                    tempMapArg = tempMapArg.Replace("\", "/") + "/" + tempMapFile
                Else 'no subfolder, just put the name after +map
                    tempMapArg = tempMapFile
                End If

            Catch
                MsgBox("An error occured when trying to determine how to launch your map with the engine.  Check the output folder settings.  Using default map launch parameters.", MsgBoxStyle.Critical, "Error")
                tempMapArg = tempMapFile
            End Try
 

            objWriter.WriteLine("cd\")
            objWriter.WriteLine("cd " + tempEngineName.Substring(0, tempEngineName.LastIndexOf("\")))
            objWriter.WriteLine(tempEngineName.Substring(tempEngineName.LastIndexOf("\") + 1, tempEngineName.Length - (5 + tempEngineName.LastIndexOf("\"))) + " " + engineArgsTextbox.Text + " +map " + tempMapArg)
        End If




        objWriter.Close()

        System.Diagnostics.Process.Start(workingFolder + "\compile.bat")

    End Sub

    Private Sub browseMaps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseMaps.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Open..."
        OpenFileDialog1.Filter = "Map File(*.map)|*.map"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mapFilename = OpenFileDialog1.FileName
            updateMainWindow()
        End If
        ' MsgBox(mapFilename, MsgBoxStyle.Exclamation, "")
    End Sub

    Private Sub browseEnginesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseEnginesButton.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Open..."
        OpenFileDialog1.Filter = "Engine Executable(*.exe)|*.exe|Batch Files(*.bat)|*.bat"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            engineTextbox.Text() = OpenFileDialog1.FileName
            updateMainWindow()
        End If
    End Sub

    Private Sub RunQuakeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunQuakeToolStripMenuItem.Click
        'System.Diagnostics.Process.Start(engineTextbox.Text(), engineArgsTextbox.Text())
        'system.Diagnostics.Process.Start(
        Dim tempEngineName As String
        Dim objWriter As New System.IO.StreamWriter(workingFolder + "\run.bat")
        Dim tempMapArg As String
        Dim tempMapFile As String

        'tempEngineName = engineTextbox.Text '.Substring(mapFilename.LastIndexOf("\") + 1, mapFilename.Length - (5 + mapFilename.LastIndexOf("\")))

        'objWriter.WriteLine("cd\")
        'objWriter.WriteLine("cd " + tempEngineName.Substring(0, tempEngineName.LastIndexOf("\")))
        'objWriter.WriteLine(tempEngineName.Substring(tempEngineName.LastIndexOf("\") + 1, tempEngineName.Length - (5 + tempEngineName.LastIndexOf("\"))) + " " + engineArgsTextbox.Text)

        'tempMapFile = mapFilename.Substring(mapFilename.LastIndexOf("\") + 1, mapFilename.Length - (5 + mapFilename.LastIndexOf("\")))
        'Swapped with above: Make the run command use the filename in the textbox and not require using the dialog box
        tempMapFile = mapFileTextbox.Text.Substring(mapFileTextbox.Text.LastIndexOf("\") + 1, mapFileTextbox.Text.Length - (5 + mapFileTextbox.Text.LastIndexOf("\")))

        tempEngineName = engineTextbox.Text '.Substring(mapFilename.LastIndexOf("\") + 1, mapFilename.Length - (5 + mapFilename.LastIndexOf("\")))

        Try
            If outputFolder.Contains("\maps\") Then 'maps are in a subfolder of maps.
                tempMapArg = outputFolder.Substring(outputFolder.LastIndexOf("\maps\") + 5)
                tempMapArg = tempMapArg.Substring(1)
                tempMapArg = tempMapArg.Replace("\", "/") + "/" + tempMapFile
            Else 'no subfolder, just put the name after +map
                tempMapArg = tempMapFile
            End If

        Catch
            MsgBox("An error occured when trying to determine how to launch your map with the engine.  Check the output folder settings.  Using default map launch parameters.", MsgBoxStyle.Critical, "Error")
            tempMapArg = tempMapFile
        End Try


        objWriter.WriteLine("cd\")
        objWriter.WriteLine("cd " + tempEngineName.Substring(0, tempEngineName.LastIndexOf("\")))
        objWriter.WriteLine(tempEngineName.Substring(tempEngineName.LastIndexOf("\") + 1, tempEngineName.Length - (5 + tempEngineName.LastIndexOf("\"))) + " " + engineArgsTextbox.Text + " +map " + tempMapArg)

        objWriter.Close()

        System.Diagnostics.Process.Start(workingFolder + "\run.bat")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("ne_q1spCompilingGui v1.0.3, C. Jones ('necros')", MsgBoxStyle.Information, "About")
    End Sub

    Private Sub PointfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointfileToolStripMenuItem.Click
        Dim pointfileDestination As String
        Dim pointfileSource As String
        Dim pointfileExtension As String
        Dim mapFileSource As String

        Dim mapFileSourceDate As Date
        Dim pointfileSourceDate As Date
        Dim msgResult As Microsoft.VisualBasic.MsgBoxResult

        Dim filesExist As Boolean
        filesExist = True 'init this

        pointfileExtension = ".pts"
        If pointFileRenamePts = True Then
            pointfileExtension = ".pts"
        ElseIf pointFileRenameLin = True Then
            pointfileExtension = ".lin"
        End If

        mapFilename = mapFileTextbox.Text
        mapFileSource = workingFolder + "\" + mapFilename.Substring(mapFilename.LastIndexOf("\") + 1, mapFilename.Length - (5 + mapFilename.LastIndexOf("\"))) + ".map"
        pointfileSource = workingFolder + "\" + mapFilename.Substring(mapFilename.LastIndexOf("\") + 1, mapFilename.Length - (5 + mapFilename.LastIndexOf("\"))) + ".pts"

        pointfileDestination = mapFilename.Substring(0, mapFilename.LastIndexOfAny(".")) + pointfileExtension

        If My.Computer.FileSystem.FileExists(mapFileSource) And My.Computer.FileSystem.FileExists(pointfileSource) Then
            mapFileSourceDate = Microsoft.VisualBasic.FileDateTime(mapFileSource)
            pointfileSourceDate = Microsoft.VisualBasic.FileDateTime(pointfileSource)

            msgResult = MsgBoxResult.Ok 'cheap hack:  this is set to 'ok' before we even get the message box.  that way, if the files match timestamps, it will trip the file copy if statement below anyway
            If mapFileSourceDate > pointfileSourceDate Then
                msgResult = MsgBox("Map file last modified date: " + mapFileSourceDate + " is newer than " + pointfileSourceDate + ".  Copy older pointfile anyway?", MsgBoxStyle.OkCancel, "Pointfile is older than Map file.")
            End If

            If msgResult = MsgBoxResult.Ok Then
                Try
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(pointfileSource, pointfileDestination, True) 'copies working folder pointfile to source folder
                Catch ex As System.IO.FileNotFoundException
                    MsgBox("No pointfile found.", MsgBoxStyle.Information, "")
                Catch ex As System.UnauthorizedAccessException
                    MsgBox("You do not have the required permissions.", MsgBoxStyle.Information, "")
                Catch
                    MsgBox("Some other error occured that was not taken into account.  Sorry!", MsgBoxStyle.Information, "")
                End Try
            End If
        Else
            MsgBox("The map file and/or pointfile are not present in the working folder.  Compile the map at least once before you can copy the pointfile.", MsgBoxStyle.Information, "")
        End If




    End Sub
End Class
