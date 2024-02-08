<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits MaterialSkin.Controls.MaterialForm

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
        AddGameModeApp = New Button()
        AddWorkModeApp = New Button()
        AddGameModeLink = New Button()
        AddWorkGameLink = New Button()
        lstWorkModeApps = New ListBox()
        lstWorkModeLinks = New ListBox()
        lstGameModeLinks = New ListBox()
        lstGameModeApps = New ListBox()
        btnSaveSettings = New Button()
        btnRemoveGameModeApp = New Button()
        btnRemoveGameModeLink = New Button()
        btnRemoveWorkModeLink = New Button()
        btnRemoveWorkModeApp = New Button()
        SuspendLayout()
        ' 
        ' AddGameModeApp
        ' 
        AddGameModeApp.Location = New Point(61, 43)
        AddGameModeApp.Name = "AddGameModeApp"
        AddGameModeApp.Size = New Size(154, 23)
        AddGameModeApp.TabIndex = 0
        AddGameModeApp.Text = "Add Game Mode App"
        AddGameModeApp.UseVisualStyleBackColor = True
        ' 
        ' AddWorkModeApp
        ' 
        AddWorkModeApp.Location = New Point(61, 213)
        AddWorkModeApp.Name = "AddWorkModeApp"
        AddWorkModeApp.Size = New Size(154, 23)
        AddWorkModeApp.TabIndex = 1
        AddWorkModeApp.Text = "Add Work Mode App"
        AddWorkModeApp.UseVisualStyleBackColor = True
        ' 
        ' AddGameModeLink
        ' 
        AddGameModeLink.Location = New Point(507, 43)
        AddGameModeLink.Name = "AddGameModeLink"
        AddGameModeLink.Size = New Size(154, 23)
        AddGameModeLink.TabIndex = 2
        AddGameModeLink.Text = "Add Game Mode link"
        AddGameModeLink.UseVisualStyleBackColor = True
        ' 
        ' AddWorkGameLink
        ' 
        AddWorkGameLink.Location = New Point(507, 213)
        AddWorkGameLink.Name = "AddWorkGameLink"
        AddWorkGameLink.Size = New Size(154, 23)
        AddWorkGameLink.TabIndex = 3
        AddWorkGameLink.Text = "Add Work Mode Link"
        AddWorkGameLink.UseVisualStyleBackColor = True
        ' 
        ' lstWorkModeApps
        ' 
        lstWorkModeApps.FormattingEnabled = True
        lstWorkModeApps.ItemHeight = 15
        lstWorkModeApps.Location = New Point(42, 253)
        lstWorkModeApps.Name = "lstWorkModeApps"
        lstWorkModeApps.Size = New Size(191, 94)
        lstWorkModeApps.TabIndex = 4
        ' 
        ' lstWorkModeLinks
        ' 
        lstWorkModeLinks.FormattingEnabled = True
        lstWorkModeLinks.ItemHeight = 15
        lstWorkModeLinks.Location = New Point(489, 253)
        lstWorkModeLinks.Name = "lstWorkModeLinks"
        lstWorkModeLinks.Size = New Size(191, 94)
        lstWorkModeLinks.TabIndex = 5
        ' 
        ' lstGameModeLinks
        ' 
        lstGameModeLinks.FormattingEnabled = True
        lstGameModeLinks.ItemHeight = 15
        lstGameModeLinks.Location = New Point(489, 83)
        lstGameModeLinks.Name = "lstGameModeLinks"
        lstGameModeLinks.Size = New Size(191, 94)
        lstGameModeLinks.TabIndex = 7
        ' 
        ' lstGameModeApps
        ' 
        lstGameModeApps.FormattingEnabled = True
        lstGameModeApps.ItemHeight = 15
        lstGameModeApps.Location = New Point(42, 83)
        lstGameModeApps.Name = "lstGameModeApps"
        lstGameModeApps.Size = New Size(191, 94)
        lstGameModeApps.TabIndex = 8
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Location = New Point(303, 399)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(113, 23)
        btnSaveSettings.TabIndex = 9
        btnSaveSettings.Text = "Save Settings"
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveGameModeApp
        ' 
        btnRemoveGameModeApp.Location = New Point(239, 119)
        btnRemoveGameModeApp.Name = "btnRemoveGameModeApp"
        btnRemoveGameModeApp.Size = New Size(75, 23)
        btnRemoveGameModeApp.TabIndex = 10
        btnRemoveGameModeApp.Text = "Remove"
        btnRemoveGameModeApp.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveGameModeLink
        ' 
        btnRemoveGameModeLink.Location = New Point(686, 119)
        btnRemoveGameModeLink.Name = "btnRemoveGameModeLink"
        btnRemoveGameModeLink.Size = New Size(75, 23)
        btnRemoveGameModeLink.TabIndex = 11
        btnRemoveGameModeLink.Text = "Remove"
        btnRemoveGameModeLink.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveWorkModeLink
        ' 
        btnRemoveWorkModeLink.Location = New Point(686, 293)
        btnRemoveWorkModeLink.Name = "btnRemoveWorkModeLink"
        btnRemoveWorkModeLink.Size = New Size(75, 23)
        btnRemoveWorkModeLink.TabIndex = 13
        btnRemoveWorkModeLink.Text = "Remove"
        btnRemoveWorkModeLink.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveWorkModeApp
        ' 
        btnRemoveWorkModeApp.Location = New Point(239, 293)
        btnRemoveWorkModeApp.Name = "btnRemoveWorkModeApp"
        btnRemoveWorkModeApp.Size = New Size(75, 23)
        btnRemoveWorkModeApp.TabIndex = 12
        btnRemoveWorkModeApp.Text = "Remove"
        btnRemoveWorkModeApp.UseVisualStyleBackColor = True
        ' 
        ' SettingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(781, 450)
        Controls.Add(btnRemoveWorkModeLink)
        Controls.Add(btnRemoveWorkModeApp)
        Controls.Add(btnRemoveGameModeLink)
        Controls.Add(btnRemoveGameModeApp)
        Controls.Add(btnSaveSettings)
        Controls.Add(lstGameModeApps)
        Controls.Add(lstGameModeLinks)
        Controls.Add(lstWorkModeLinks)
        Controls.Add(lstWorkModeApps)
        Controls.Add(AddWorkGameLink)
        Controls.Add(AddGameModeLink)
        Controls.Add(AddWorkModeApp)
        Controls.Add(AddGameModeApp)
        FormStyle = FormStyles.StatusAndActionBar_None
        Name = "SettingsForm"
        Padding = New Padding(3, 0, 3, 3)
        Text = "SettingsForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents AddGameModeApp As Button
    Friend WithEvents AddWorkModeApp As Button
    Friend WithEvents AddGameModeLink As Button
    Friend WithEvents AddWorkGameLink As Button
    Friend WithEvents lstWorkModeApps As ListBox
    Friend WithEvents lstWorkModeLinks As ListBox
    Friend WithEvents lstGameModeLinks As ListBox
    Friend WithEvents lstGameModeApps As ListBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnRemoveGameModeApp As Button
    Friend WithEvents btnRemoveGameModeLink As Button
    Friend WithEvents btnRemoveWorkModeLink As Button
    Friend WithEvents btnRemoveWorkModeApp As Button
End Class
