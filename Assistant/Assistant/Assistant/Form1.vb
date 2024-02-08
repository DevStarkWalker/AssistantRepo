Imports System.IO
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Form1
    Inherits MaterialForm

    Public gameModeApps As List(Of String) ' Arrays of strings, these will be the paths to the specified apps in a text file
    Public workModeApps As List(Of String)

    Public gameModeLinks As List(Of String) ' Arrays of strings, these will be the URL addresses specified in a text file
    Public workModeLinks As List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load settings from file when the application starts
        SettingsForm.LoadSettingsFromFile()
    End Sub

    Private Sub btnWorkMode_Click(sender As Object, e As EventArgs) Handles btnWorkMode.Click
        ' Open specified apps
        If workModeApps IsNot Nothing AndAlso workModeApps.Count > 0 Then
            For Each appPath In workModeApps
                OpenApplication(appPath)
            Next
        Else
            MessageBox.Show("No apps specified for Work Mode.", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Check if there are links to open
        If workModeLinks IsNot Nothing AndAlso workModeLinks.Count > 0 Then
            For Each url In workModeLinks
                OpenURL(url)
            Next
        Else
            MessageBox.Show("No links specified for Work Mode.", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnGameMode_Click(sender As Object, e As EventArgs) Handles btnGameMode.Click
        ' Open specified apps
        If gameModeApps IsNot Nothing AndAlso gameModeApps.Count > 0 Then
            For Each appPath In gameModeApps
                OpenApplication(appPath)
            Next
        Else
            MessageBox.Show("No apps specified for Game Mode.", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If gameModeLinks IsNot Nothing AndAlso gameModeLinks.Count > 0 Then
            For Each url In gameModeLinks
                OpenURL(url)
            Next
        Else
            MessageBox.Show("No links specified for Game Mode.", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub OpenApplication(appPath As String)
        If Not String.IsNullOrEmpty(appPath) Then
            Try
                Process.Start(appPath)
                ' MessageBox.Show($"Opened: {appPath}", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error opening {appPath}: {ex.Message}", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub OpenURL(url As String)
        If Not String.IsNullOrEmpty(url) Then
            Try
                Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", url)
                ' MessageBox.Show($"Opened: {url} in Chrome", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error opening {url}: {ex.Message}", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function GetPathsFromTextFile(filePath As String) As String()
        Try
            ' Read all lines from the specified text file
            Return File.ReadAllLines(filePath).Select(Function(line) line.Trim()).ToArray()
        Catch ex As Exception
            MessageBox.Show($"Error reading {filePath}: {ex.Message}", "Application Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New String() {}
        End Try
    End Function

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ' Create an instance of SettingsForm
        Using settingsForm As New SettingsForm()


            ' Show the form as a dialog (blocks interaction with other forms until closed)
            If settingsForm.ShowDialog() = DialogResult.OK Then
                gameModeApps = settingsForm.GameModeApps
                workModeApps = settingsForm.WorkModeApps
                gameModeLinks = settingsForm.GameModeLinks
                workModeLinks = settingsForm.WorkModeLinks
            End If
        End Using ' The 'Using' statement ensures that resources are properly released

        ' No need to manually dispose of the form, 'Using' takes care of it
    End Sub
End Class
