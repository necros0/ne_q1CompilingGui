<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWindow))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoldersSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainWindowMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunQuakeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.qbspGroupBox = New System.Windows.Forms.GroupBox()
        Me.compileOptionsAdd_menuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.add_addMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.useQbsp = New System.Windows.Forms.CheckBox()
        Me.qbsp_commandLineTextbox = New System.Windows.Forms.TextBox()
        Me.pauseAfterQbsp = New System.Windows.Forms.CheckBox()
        Me.compileOptionsEdit_menuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.edit_editMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.edit_removeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.visGroupBox = New System.Windows.Forms.GroupBox()
        Me.useVis = New System.Windows.Forms.CheckBox()
        Me.vis_commandLineTextbox = New System.Windows.Forms.TextBox()
        Me.pauseAfterVis = New System.Windows.Forms.CheckBox()
        Me.lightGroupBox = New System.Windows.Forms.GroupBox()
        Me.useLight = New System.Windows.Forms.CheckBox()
        Me.light_commandLineTextbox = New System.Windows.Forms.TextBox()
        Me.pauseAfterLight = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.browseMaps = New System.Windows.Forms.Button()
        Me.mapFileTextbox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.runEngine = New System.Windows.Forms.CheckBox()
        Me.pauseAfterCompiling = New System.Windows.Forms.CheckBox()
        Me.engineArgsTextbox = New System.Windows.Forms.TextBox()
        Me.browseEnginesButton = New System.Windows.Forms.Button()
        Me.engineTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PointfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.useSkip = New System.Windows.Forms.CheckBox()
        Me.mainWindowMenuStrip.SuspendLayout()
        Me.qbspGroupBox.SuspendLayout()
        Me.compileOptionsAdd_menuStrip.SuspendLayout()
        Me.compileOptionsEdit_menuStrip.SuspendLayout()
        Me.visGroupBox.SuspendLayout()
        Me.lightGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'FoldersSetupToolStripMenuItem
        '
        Me.FoldersSetupToolStripMenuItem.Name = "FoldersSetupToolStripMenuItem"
        Me.FoldersSetupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FoldersSetupToolStripMenuItem.Text = "Preferences"
        '
        'mainWindowMenuStrip
        '
        Me.mainWindowMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.SettingsToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.mainWindowMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainWindowMenuStrip.Name = "mainWindowMenuStrip"
        Me.mainWindowMenuStrip.Size = New System.Drawing.Size(652, 24)
        Me.mainWindowMenuStrip.TabIndex = 0
        Me.mainWindowMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileToolStripMenuItem, Me.PointfileToolStripMenuItem, Me.RunQuakeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C"
        Me.CompileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'RunQuakeToolStripMenuItem
        '
        Me.RunQuakeToolStripMenuItem.Name = "RunQuakeToolStripMenuItem"
        Me.RunQuakeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R"
        Me.RunQuakeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RunQuakeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RunQuakeToolStripMenuItem.Text = "Run Quake"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderSetupToolStripMenuItem})
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'FolderSetupToolStripMenuItem
        '
        Me.FolderSetupToolStripMenuItem.Name = "FolderSetupToolStripMenuItem"
        Me.FolderSetupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FolderSetupToolStripMenuItem.Text = "Folder Setup"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'qbspGroupBox
        '
        Me.qbspGroupBox.ContextMenuStrip = Me.compileOptionsAdd_menuStrip
        Me.qbspGroupBox.Controls.Add(Me.useSkip)
        Me.qbspGroupBox.Controls.Add(Me.useQbsp)
        Me.qbspGroupBox.Controls.Add(Me.qbsp_commandLineTextbox)
        Me.qbspGroupBox.Controls.Add(Me.pauseAfterQbsp)
        Me.qbspGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.qbspGroupBox.Name = "qbspGroupBox"
        Me.qbspGroupBox.Size = New System.Drawing.Size(313, 157)
        Me.qbspGroupBox.TabIndex = 1
        Me.qbspGroupBox.TabStop = False
        Me.qbspGroupBox.Text = "QBSP"
        '
        'compileOptionsAdd_menuStrip
        '
        Me.compileOptionsAdd_menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add_addMenuItem})
        Me.compileOptionsAdd_menuStrip.Name = "compileOptions_menuStrip"
        Me.compileOptionsAdd_menuStrip.Size = New System.Drawing.Size(97, 26)
        '
        'add_addMenuItem
        '
        Me.add_addMenuItem.Name = "add_addMenuItem"
        Me.add_addMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.add_addMenuItem.Text = "Add"
        '
        'useQbsp
        '
        Me.useQbsp.AutoSize = True
        Me.useQbsp.BackColor = System.Drawing.Color.Transparent
        Me.useQbsp.Location = New System.Drawing.Point(40, 0)
        Me.useQbsp.Name = "useQbsp"
        Me.useQbsp.Size = New System.Drawing.Size(15, 14)
        Me.useQbsp.TabIndex = 2
        Me.useQbsp.UseVisualStyleBackColor = False
        '
        'qbsp_commandLineTextbox
        '
        Me.qbsp_commandLineTextbox.BackColor = System.Drawing.Color.White
        Me.qbsp_commandLineTextbox.Enabled = False
        Me.qbsp_commandLineTextbox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qbsp_commandLineTextbox.ForeColor = System.Drawing.Color.Black
        Me.qbsp_commandLineTextbox.Location = New System.Drawing.Point(6, 19)
        Me.qbsp_commandLineTextbox.Multiline = True
        Me.qbsp_commandLineTextbox.Name = "qbsp_commandLineTextbox"
        Me.qbsp_commandLineTextbox.ReadOnly = True
        Me.qbsp_commandLineTextbox.Size = New System.Drawing.Size(300, 41)
        Me.qbsp_commandLineTextbox.TabIndex = 0
        Me.qbsp_commandLineTextbox.Text = "qbsp.exe"
        '
        'pauseAfterQbsp
        '
        Me.pauseAfterQbsp.AutoSize = True
        Me.pauseAfterQbsp.BackColor = System.Drawing.Color.Transparent
        Me.pauseAfterQbsp.Location = New System.Drawing.Point(249, 5)
        Me.pauseAfterQbsp.Name = "pauseAfterQbsp"
        Me.pauseAfterQbsp.Size = New System.Drawing.Size(56, 17)
        Me.pauseAfterQbsp.TabIndex = 1
        Me.pauseAfterQbsp.Text = "Pause"
        Me.pauseAfterQbsp.UseVisualStyleBackColor = False
        '
        'compileOptionsEdit_menuStrip
        '
        Me.compileOptionsEdit_menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.edit_editMenuItem, Me.edit_removeMenuItem})
        Me.compileOptionsEdit_menuStrip.Name = "compileOptionsEdit_menuStrip"
        Me.compileOptionsEdit_menuStrip.Size = New System.Drawing.Size(118, 48)
        '
        'edit_editMenuItem
        '
        Me.edit_editMenuItem.Name = "edit_editMenuItem"
        Me.edit_editMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.edit_editMenuItem.Text = "Edit"
        '
        'edit_removeMenuItem
        '
        Me.edit_removeMenuItem.Name = "edit_removeMenuItem"
        Me.edit_removeMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.edit_removeMenuItem.Text = "Remove"
        '
        'visGroupBox
        '
        Me.visGroupBox.ContextMenuStrip = Me.compileOptionsAdd_menuStrip
        Me.visGroupBox.Controls.Add(Me.useVis)
        Me.visGroupBox.Controls.Add(Me.vis_commandLineTextbox)
        Me.visGroupBox.Controls.Add(Me.pauseAfterVis)
        Me.visGroupBox.Location = New System.Drawing.Point(12, 190)
        Me.visGroupBox.Name = "visGroupBox"
        Me.visGroupBox.Size = New System.Drawing.Size(313, 157)
        Me.visGroupBox.TabIndex = 2
        Me.visGroupBox.TabStop = False
        Me.visGroupBox.Text = "VIS"
        '
        'useVis
        '
        Me.useVis.AutoSize = True
        Me.useVis.BackColor = System.Drawing.Color.Transparent
        Me.useVis.Location = New System.Drawing.Point(28, 0)
        Me.useVis.Name = "useVis"
        Me.useVis.Size = New System.Drawing.Size(15, 14)
        Me.useVis.TabIndex = 3
        Me.useVis.UseVisualStyleBackColor = False
        '
        'vis_commandLineTextbox
        '
        Me.vis_commandLineTextbox.BackColor = System.Drawing.Color.White
        Me.vis_commandLineTextbox.Enabled = False
        Me.vis_commandLineTextbox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vis_commandLineTextbox.Location = New System.Drawing.Point(6, 19)
        Me.vis_commandLineTextbox.Multiline = True
        Me.vis_commandLineTextbox.Name = "vis_commandLineTextbox"
        Me.vis_commandLineTextbox.ReadOnly = True
        Me.vis_commandLineTextbox.Size = New System.Drawing.Size(300, 41)
        Me.vis_commandLineTextbox.TabIndex = 0
        Me.vis_commandLineTextbox.Text = "vis.exe"
        '
        'pauseAfterVis
        '
        Me.pauseAfterVis.AutoSize = True
        Me.pauseAfterVis.BackColor = System.Drawing.Color.Transparent
        Me.pauseAfterVis.Location = New System.Drawing.Point(250, 5)
        Me.pauseAfterVis.Name = "pauseAfterVis"
        Me.pauseAfterVis.Size = New System.Drawing.Size(56, 17)
        Me.pauseAfterVis.TabIndex = 2
        Me.pauseAfterVis.Text = "Pause"
        Me.pauseAfterVis.UseVisualStyleBackColor = False
        '
        'lightGroupBox
        '
        Me.lightGroupBox.ContextMenuStrip = Me.compileOptionsAdd_menuStrip
        Me.lightGroupBox.Controls.Add(Me.useLight)
        Me.lightGroupBox.Controls.Add(Me.light_commandLineTextbox)
        Me.lightGroupBox.Controls.Add(Me.pauseAfterLight)
        Me.lightGroupBox.Location = New System.Drawing.Point(331, 27)
        Me.lightGroupBox.Name = "lightGroupBox"
        Me.lightGroupBox.Size = New System.Drawing.Size(313, 157)
        Me.lightGroupBox.TabIndex = 3
        Me.lightGroupBox.TabStop = False
        Me.lightGroupBox.Text = "LIGHT"
        '
        'useLight
        '
        Me.useLight.AutoSize = True
        Me.useLight.BackColor = System.Drawing.Color.Transparent
        Me.useLight.Location = New System.Drawing.Point(43, 0)
        Me.useLight.Name = "useLight"
        Me.useLight.Size = New System.Drawing.Size(15, 14)
        Me.useLight.TabIndex = 3
        Me.useLight.UseVisualStyleBackColor = False
        '
        'light_commandLineTextbox
        '
        Me.light_commandLineTextbox.BackColor = System.Drawing.Color.White
        Me.light_commandLineTextbox.Enabled = False
        Me.light_commandLineTextbox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.light_commandLineTextbox.Location = New System.Drawing.Point(6, 19)
        Me.light_commandLineTextbox.Multiline = True
        Me.light_commandLineTextbox.Name = "light_commandLineTextbox"
        Me.light_commandLineTextbox.ReadOnly = True
        Me.light_commandLineTextbox.Size = New System.Drawing.Size(300, 41)
        Me.light_commandLineTextbox.TabIndex = 0
        Me.light_commandLineTextbox.Text = "light.exe"
        '
        'pauseAfterLight
        '
        Me.pauseAfterLight.AutoSize = True
        Me.pauseAfterLight.BackColor = System.Drawing.Color.Transparent
        Me.pauseAfterLight.Location = New System.Drawing.Point(250, 5)
        Me.pauseAfterLight.Name = "pauseAfterLight"
        Me.pauseAfterLight.Size = New System.Drawing.Size(56, 17)
        Me.pauseAfterLight.TabIndex = 2
        Me.pauseAfterLight.Text = "Pause"
        Me.pauseAfterLight.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.browseMaps)
        Me.GroupBox1.Controls.Add(Me.mapFileTextbox)
        Me.GroupBox1.Location = New System.Drawing.Point(331, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 48)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Map"
        '
        'browseMaps
        '
        Me.browseMaps.Location = New System.Drawing.Point(279, 19)
        Me.browseMaps.Name = "browseMaps"
        Me.browseMaps.Size = New System.Drawing.Size(27, 20)
        Me.browseMaps.TabIndex = 1
        Me.browseMaps.Text = "..."
        Me.browseMaps.UseVisualStyleBackColor = True
        '
        'mapFileTextbox
        '
        Me.mapFileTextbox.Location = New System.Drawing.Point(6, 19)
        Me.mapFileTextbox.Name = "mapFileTextbox"
        Me.mapFileTextbox.Size = New System.Drawing.Size(267, 20)
        Me.mapFileTextbox.TabIndex = 0
        Me.mapFileTextbox.Text = "C:\"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.runEngine)
        Me.GroupBox2.Controls.Add(Me.pauseAfterCompiling)
        Me.GroupBox2.Controls.Add(Me.engineArgsTextbox)
        Me.GroupBox2.Controls.Add(Me.browseEnginesButton)
        Me.GroupBox2.Controls.Add(Me.engineTextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 103)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quake Engine"
        '
        'runEngine
        '
        Me.runEngine.AutoSize = True
        Me.runEngine.BackColor = System.Drawing.Color.Transparent
        Me.runEngine.Location = New System.Drawing.Point(141, 80)
        Me.runEngine.Name = "runEngine"
        Me.runEngine.Size = New System.Drawing.Size(81, 17)
        Me.runEngine.TabIndex = 4
        Me.runEngine.Text = "Run Quake"
        Me.runEngine.UseVisualStyleBackColor = False
        '
        'pauseAfterCompiling
        '
        Me.pauseAfterCompiling.AutoSize = True
        Me.pauseAfterCompiling.BackColor = System.Drawing.Color.Transparent
        Me.pauseAfterCompiling.Location = New System.Drawing.Point(6, 80)
        Me.pauseAfterCompiling.Name = "pauseAfterCompiling"
        Me.pauseAfterCompiling.Size = New System.Drawing.Size(129, 17)
        Me.pauseAfterCompiling.TabIndex = 3
        Me.pauseAfterCompiling.Text = "Pause After Compiling"
        Me.pauseAfterCompiling.UseVisualStyleBackColor = False
        '
        'engineArgsTextbox
        '
        Me.engineArgsTextbox.Location = New System.Drawing.Point(6, 55)
        Me.engineArgsTextbox.Name = "engineArgsTextbox"
        Me.engineArgsTextbox.Size = New System.Drawing.Size(300, 20)
        Me.engineArgsTextbox.TabIndex = 2
        '
        'browseEnginesButton
        '
        Me.browseEnginesButton.Location = New System.Drawing.Point(279, 19)
        Me.browseEnginesButton.Name = "browseEnginesButton"
        Me.browseEnginesButton.Size = New System.Drawing.Size(27, 20)
        Me.browseEnginesButton.TabIndex = 1
        Me.browseEnginesButton.Text = "..."
        Me.browseEnginesButton.UseVisualStyleBackColor = True
        '
        'engineTextbox
        '
        Me.engineTextbox.Location = New System.Drawing.Point(6, 19)
        Me.engineTextbox.Name = "engineTextbox"
        Me.engineTextbox.Size = New System.Drawing.Size(267, 20)
        Me.engineTextbox.TabIndex = 0
        Me.engineTextbox.Text = "C:\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Command-line Arguments"
        '
        'PointfileToolStripMenuItem
        '
        Me.PointfileToolStripMenuItem.Name = "PointfileToolStripMenuItem"
        Me.PointfileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PointfileToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PointfileToolStripMenuItem.Text = "Pointfile"
        '
        'useSkip
        '
        Me.useSkip.AutoSize = True
        Me.useSkip.BackColor = System.Drawing.SystemColors.Control
        Me.useSkip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.useSkip.Location = New System.Drawing.Point(76, -1)
        Me.useSkip.Name = "useSkip"
        Me.useSkip.Size = New System.Drawing.Size(50, 17)
        Me.useSkip.TabIndex = 3
        Me.useSkip.Text = "SKIP"
        Me.useSkip.UseVisualStyleBackColor = False
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 354)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lightGroupBox)
        Me.Controls.Add(Me.visGroupBox)
        Me.Controls.Add(Me.qbspGroupBox)
        Me.Controls.Add(Me.mainWindowMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compiling Gui"
        Me.mainWindowMenuStrip.ResumeLayout(False)
        Me.mainWindowMenuStrip.PerformLayout()
        Me.qbspGroupBox.ResumeLayout(False)
        Me.qbspGroupBox.PerformLayout()
        Me.compileOptionsAdd_menuStrip.ResumeLayout(False)
        Me.compileOptionsEdit_menuStrip.ResumeLayout(False)
        Me.visGroupBox.ResumeLayout(False)
        Me.visGroupBox.PerformLayout()
        Me.lightGroupBox.ResumeLayout(False)
        Me.lightGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoldersSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainWindowMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents qbspGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents qbsp_commandLineTextbox As System.Windows.Forms.TextBox
    Friend WithEvents compileOptionsAdd_menuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents add_addMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents compileOptionsEdit_menuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents edit_editMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents edit_removeMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents visGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents vis_commandLineTextbox As System.Windows.Forms.TextBox
    Friend WithEvents lightGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents light_commandLineTextbox As System.Windows.Forms.TextBox
    Friend WithEvents pauseAfterQbsp As System.Windows.Forms.CheckBox
    Friend WithEvents CompileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents browseMaps As System.Windows.Forms.Button
    Friend WithEvents mapFileTextbox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pauseAfterVis As System.Windows.Forms.CheckBox
    Friend WithEvents pauseAfterLight As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pauseAfterCompiling As System.Windows.Forms.CheckBox
    Friend WithEvents engineArgsTextbox As System.Windows.Forms.TextBox
    Friend WithEvents browseEnginesButton As System.Windows.Forms.Button
    Friend WithEvents engineTextbox As System.Windows.Forms.TextBox
    Friend WithEvents RunQuakeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents runEngine As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents useQbsp As System.Windows.Forms.CheckBox
    Friend WithEvents useVis As System.Windows.Forms.CheckBox
    Friend WithEvents useLight As System.Windows.Forms.CheckBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents useSkip As System.Windows.Forms.CheckBox

End Class
