Public Class SettingsForm
    ' Public properties to store selected items
    Public Property SelectedGameModeApp As String
    Public Property SelectedWorkModeApp As String
    Public Property GameModeLinks As List(Of String)
    Public Property WorkModeLinks As List(Of String)
    Public Property GameModeApps As List(Of String)
    Public Property WorkModeApps As List(Of String)


    Public Sub SetGameModeApps(items As List(Of String))
        GameModeApps = items
        UpdateListBox(lstGameModeApps, items)
    End Sub

    Public Sub SetWorkModeApps(items As List(Of String))
        WorkModeApps = items
        UpdateListBox(lstWorkModeApps, items)
    End Sub
    Private Sub UpdateListBox(listBox As ListBox, items As List(Of String))
        listBox.Items.Clear()
        For Each item In items
            listBox.Items.Add(item)
        Next
    End Sub

    Private Sub AddAppToList(listBox As ListBox)
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Executable Files|*.exe"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            listBox.Items.Add(openFileDialog.FileName)
        End If
    End Sub

    Private Sub AddLinkToList(listBox As ListBox)
        Dim newLink As String = InputBox("Enter a new link:", "Add Link")
        If Not String.IsNullOrEmpty(newLink) Then
            listBox.Items.Add(newLink)
        End If
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click

        ' Save settings and close the form
        Form1.gameModeApps = GameModeApps
        Form1.workModeApps = WorkModeApps
        Form1.gameModeLinks = GameModeLinks
        Form1.workModeLinks = WorkModeLinks
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub AddGameModeApp_Click(sender As Object, e As EventArgs) Handles AddGameModeApp.Click
        AddAppToList(lstGameModeApps)
        SetGameModeApps(lstGameModeApps.Items.OfType(Of String).ToList())
    End Sub

    Private Sub AddGameModeLink_Click(sender As Object, e As EventArgs) Handles AddGameModeLink.Click
        AddLinkToList(lstWorkModeLinks)
    End Sub

    Private Sub AddWorkModeApp_Click(sender As Object, e As EventArgs) Handles AddWorkModeApp.Click
        AddAppToList(lstWorkModeApps)
        SetWorkModeApps(lstWorkModeApps.Items.OfType(Of String).ToList())
    End Sub

    Private Sub AddWorkModeLink_Click(sender As Object, e As EventArgs) Handles AddWorkGameLink.Click
        AddLinkToList(lstWorkModeLinks)
    End Sub

End Class

