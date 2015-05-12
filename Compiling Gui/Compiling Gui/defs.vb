Module defs
    'Structure argListItem
    '    Public arg As String
    '    'Public materialLabel As String
    'End Structure

    'Public qbspOptionalArgs(9) As argListItem
    Public doNotSaveSettings As Boolean = False

    Public outputFolder As String 'where to put the bsp files.
    Public workingFolder As String
    Public toolsFolder As String 'where are mah toolz?
    Public sourceFolder As String

    Public mapFilename As String

    Public qbspFilename As String 'the filenames for the tools
    Public visFilename As String
    Public lightFilename As String
    Public skipFilename As String

    Public qbspArgs As String
    Public visArgs As String
    Public lightArgs As String
    Public skipArgs As String

    Public convertMap As Boolean
    Public convFilename As String
    Public convArgs As String

    Public pointFileRenamePts As Boolean
    Public pointFileRenameLin As Boolean

    'Public pauseBSP As Boolean
    'Public pauseVIS As Boolean
    'Public pauseLIT As Boolean

    Public engine As String
    Public engineArgs As String
    'Public pauseAfterAll As Boolean
    'Public runEngine As Boolean

    Public Sub createDefaultConfigFile()
        Dim iniFilePath As String = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
        Dim configFile As String = iniFilePath + "\config.ini"
        Dim objWriter As New System.IO.StreamWriter(configFile)
        'write the factory defaults...

        objWriter.WriteLine("*bsp")
        objWriter.WriteLine("qbsp.exe")
        objWriter.WriteLine()
        objWriter.WriteLine()
        objWriter.WriteLine("*vis")
        objWriter.WriteLine("vis.exe")
        objWriter.WriteLine()
        objWriter.WriteLine()
        objWriter.WriteLine("*lit")
        objWriter.WriteLine("light.exe")
        objWriter.WriteLine()
        objWriter.WriteLine()
        objWriter.WriteLine("*tools")
        objWriter.WriteLine("C:\tools")
        objWriter.WriteLine("*work")
        objWriter.WriteLine("C:\work")
        objWriter.WriteLine("*output")
        objWriter.WriteLine("C:\maps")
        objWriter.WriteLine("*lastmap")
        objWriter.WriteLine("C:\source\source.map")
        objWriter.WriteLine()
        objWriter.WriteLine("*convert")
        objWriter.WriteLine("False")
        objWriter.WriteLine("map converter")
        objWriter.WriteLine()
        objWriter.WriteLine()
        objWriter.WriteLine("*pointfile")
        objWriter.WriteLine("True") 'defaults to .pts
        objWriter.WriteLine("False")
        objWriter.WriteLine()
        objWriter.WriteLine("*chk")
        objWriter.WriteLine("False")
        objWriter.WriteLine("False")
        objWriter.WriteLine("False")
        objWriter.WriteLine("False")
        objWriter.WriteLine("False")
        objWriter.WriteLine("False")
        objWriter.WriteLine("False")
        objWriter.WriteLine("False")
        objWriter.WriteLine()
        objWriter.WriteLine("*engine")
        objWriter.WriteLine("engine")
        objWriter.WriteLine()
        objWriter.WriteLine()
        objWriter.WriteLine("*blockStart_bsp")
        objWriter.WriteLine("0-onlyents")
        objWriter.WriteLine("*blockEnd_bsp")
        objWriter.WriteLine()
        objWriter.WriteLine("*blockStart_vis")
        objWriter.WriteLine("1-fast")
        objWriter.WriteLine("0-level 4")
        objWriter.WriteLine("*blockEnd_vis")
        objWriter.WriteLine()
        objWriter.WriteLine("*blockStart_lit")
        objWriter.WriteLine("0-extra")
        objWriter.WriteLine("*blockEnd_lit")
        'objWriter.WriteLine()
        'objWriter.WriteLine("")


        objWriter.Close()
    End Sub

End Module
