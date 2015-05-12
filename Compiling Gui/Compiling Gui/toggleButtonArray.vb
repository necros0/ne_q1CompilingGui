Public Class toggleButtonArray
    Inherits System.Collections.CollectionBase

    Private ReadOnly HostForm As System.Windows.Forms.GroupBox

    Public Function addNewToggle() As System.Windows.Forms.CheckBox

        Dim newToggle As New System.Windows.Forms.CheckBox()

        Me.List.Add(newToggle) 'add to the list
        HostForm.Controls.Add(newToggle)
        AddHandler newToggle.CheckedChanged, AddressOf checkChangedHandler
       
        newToggle.Checked = False
        newToggle.Visible = False
        newToggle.Tag = Me.Count - 1
        newToggle.Appearance = Appearance.Button
        newToggle.Width = 96
        newToggle.Height = 24
        newToggle.ContextMenuStrip = mainWindow.compileOptionsEdit_menuStrip

        Return newToggle
    End Function

    Public Sub New(ByVal host As System.Windows.Forms.GroupBox)
        HostForm = host
    End Sub

    Public Sub checkChangedHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        mainWindow.updateMainWindow()
    End Sub

    Public Sub remove(ByVal index As Integer)
        'If Me.Count > 0 Then
        '    HostForm.Controls.Remove(Me(Me.Count)) ' - 1))
        '    Me.List.RemoveAt(Me.Count) ' - 1)
        'End If
        HostForm.Controls.Remove(Me(index))
        Me.List.RemoveAt(index)
    End Sub

    Default Public ReadOnly Property item(ByVal index As Integer) As System.Windows.Forms.CheckBox
        Get
            Return CType(Me.List.Item(index), System.Windows.Forms.CheckBox)
        End Get
    End Property
End Class
