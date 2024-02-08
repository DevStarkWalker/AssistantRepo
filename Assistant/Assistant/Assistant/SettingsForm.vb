Imports System.IO

Public Class SettingsForm
    Inherits MaterialSkin.Controls.MaterialForm
    ' Public properties to store selected items
    Public Property SelectedGameModeApp As String
    Public Property SelectedWorkModeApp As String
    Public Property GameModeLinks As List(Of String) = New List(Of String)()
    Public Property WorkModeLinks As List(Of String) = New List(Of String)()
    Public Property GameModeApps As List(Of String) = New List(Of String)()
    Public Property WorkModeApps As List(Of String) = New List(Of String)()

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load settings from file when the application starts
        LoadSettingsFromFile()

        ' Set apps first
        SetGameModeApps(GameModeApps)
        SetWorkModeApps(WorkModeApps)

        ' Set links after setting apps
        SetGameModeLinks(GameModeLinks)
        SetWorkModeLinks(WorkModeLinks)
    End Sub

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

    Private Sub AddLinkToList(listBox As ListBox, linksList As List(Of String))
        Dim newLink As String = InputBox("Enter a new link:", "Add Link")
        If Not String.IsNullOrEmpty(newLink) Then
            listBox.Items.Add(newLink)

            ' Ensure linksList is initialized before adding the new link
            If linksList Is Nothing Then
                linksList = New List(Of String)()
            End If

            linksList.Add(newLink) ' Add the new link to the corresponding list
        End If
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click

        ' Save settings and close the form
        Form1.gameModeApps = GameModeApps
        Form1.workModeApps = WorkModeApps
        SetGameModeLinks(lstGameModeLinks.Items.OfType(Of String).ToList())
        SetWorkModeLinks(lstWorkModeLinks.Items.OfType(Of String).ToList())
        SaveSettingsToFile()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub AddGameModeApp_Click(sender As Object, e As EventArgs) Handles AddGameModeApp.Click
        AddAppToList(lstGameModeApps)
        SetGameModeApps(lstGameModeApps.Items.OfType(Of String).ToList())
    End Sub

    Private Sub AddGameModeLink_Click(sender As Object, e As EventArgs) Handles AddGameModeLink.Click
        AddLinkToList(lstGameModeLinks, GameModeLinks)
    End Sub

    Private Sub AddWorkModeApp_Click(sender As Object, e As EventArgs) Handles AddWorkModeApp.Click
        AddAppToList(lstWorkModeApps)
        SetWorkModeApps(lstWorkModeApps.Items.OfType(Of String).ToList())
    End Sub

    Private Sub AddWorkModeLink_Click(sender As Object, e As EventArgs) Handles AddWorkGameLink.Click
        AddLinkToList(lstWorkModeLinks, WorkModeLinks)
    End Sub

    Public Sub SetGameModeLinks(links As List(Of String))
        GameModeLinks.Clear()
        GameModeLinks.AddRange(links)
        UpdateListBox(lstGameModeLinks, GameModeLinks)
    End Sub

    Public Sub SetWorkModeLinks(links As List(Of String))
        WorkModeLinks.Clear()
        WorkModeLinks.AddRange(links)
        UpdateListBox(lstWorkModeLinks, WorkModeLinks)
    End Sub

    Public Sub SaveSettingsToFile()
        ' Get the path to the project folder
        Dim projectFolderPath As String = Application.StartupPath
        Debug.WriteLine(projectFolderPath)

        ' Save Game Mode links and app paths
        File.WriteAllLines(Path.Combine(projectFolderPath, "L&P", "GameModeLinks.txt"), GameModeLinks.ToArray())
        File.WriteAllLines(Path.Combine(projectFolderPath, "L&P", "GameModeApps.txt"), GameModeApps.ToArray())

        ' Save Work Mode links and app paths
        File.WriteAllLines(Path.Combine(projectFolderPath, "L&P", "WorkModeLinks.txt"), WorkModeLinks.ToArray())
        File.WriteAllLines(Path.Combine(projectFolderPath, "L&P", "WorkModeApps.txt"), WorkModeApps.ToArray())
    End Sub

    Public Sub LoadSettingsFromFile()
        ' Get the path to the project folder
        Dim projectFolderPath As String = Application.StartupPath

        ' Load Game Mode links and app paths
        GameModeLinks = New List(Of String)(File.ReadAllLines(Path.Combine(projectFolderPath, "L&P", "GameModeLinks.txt")))
        GameModeApps = New List(Of String)(File.ReadAllLines(Path.Combine(projectFolderPath, "L&P", "GameModeApps.txt")))

        ' Load Work Mode links and app paths
        WorkModeLinks = New List(Of String)(File.ReadAllLines(Path.Combine(projectFolderPath, "L&P", "WorkModeLinks.txt")))
        WorkModeApps = New List(Of String)(File.ReadAllLines(Path.Combine(projectFolderPath, "L&P", "WorkModeApps.txt")))

        Form1.gameModeLinks = GameModeLinks
        Form1.gameModeApps = GameModeApps
        Form1.workModeLinks = WorkModeLinks
        Form1.workModeApps = WorkModeApps

    End Sub

    Private Sub RemoveSelectedItems(listBox As ListBox, list As List(Of String))
        ' Remove selected items from the list and update the ListBox
        For Each selectedItem As String In listBox.SelectedItems.Cast(Of String).ToList()
            list.Remove(selectedItem)
            listBox.Items.Remove(selectedItem)
        Next
    End Sub

    Private Sub RemoveSelectedGameModeApps()
        RemoveSelectedItems(lstGameModeApps, GameModeApps)
    End Sub

    Private Sub RemoveSelectedWorkModeApps()
        RemoveSelectedItems(lstWorkModeApps, WorkModeApps)
    End Sub

    Private Sub RemoveSelectedGameModeLinks()
        RemoveSelectedItems(lstGameModeLinks, GameModeLinks)
    End Sub

    Private Sub RemoveSelectedWorkModeLinks()
        RemoveSelectedItems(lstWorkModeLinks, WorkModeLinks)
    End Sub

    ' Add corresponding event handlers for remove buttons
    Private Sub btnRemoveGameModeApp_Click(sender As Object, e As EventArgs) Handles btnRemoveGameModeApp.Click
        RemoveSelectedGameModeApps()
    End Sub

    Private Sub btnRemoveWorkModeApp_Click(sender As Object, e As EventArgs) Handles btnRemoveWorkModeApp.Click
        RemoveSelectedWorkModeApps()
    End Sub

    Private Sub btnRemoveGameModeLink_Click(sender As Object, e As EventArgs) Handles btnRemoveGameModeLink.Click
        RemoveSelectedGameModeLinks()
    End Sub

    Private Sub btnRemoveWorkModeLink_Click(sender As Object, e As EventArgs) Handles btnRemoveWorkModeLink.Click
        RemoveSelectedWorkModeLinks()
    End Sub


End Class

