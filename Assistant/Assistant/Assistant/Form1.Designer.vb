<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnWorkMode = New Button()
        btnGameMode = New Button()
        Label1 = New Label()
        btnSettings = New Button()
        SuspendLayout()
        ' 
        ' btnWorkMode
        ' 
        btnWorkMode.Location = New Point(19, 81)
        btnWorkMode.Name = "btnWorkMode"
        btnWorkMode.Size = New Size(125, 79)
        btnWorkMode.TabIndex = 0
        btnWorkMode.Text = "Work Mode"
        btnWorkMode.UseVisualStyleBackColor = True
        ' 
        ' btnGameMode
        ' 
        btnGameMode.Location = New Point(163, 81)
        btnGameMode.Name = "btnGameMode"
        btnGameMode.Size = New Size(125, 79)
        btnGameMode.TabIndex = 1
        btnGameMode.Text = "Game Mode"
        btnGameMode.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 30)
        Label1.TabIndex = 2
        Label1.Text = "Welcome Dev!" & vbCrLf & "What can I get started for you?" & vbCrLf
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnSettings
        ' 
        btnSettings.ForeColor = SystemColors.WindowText
        btnSettings.Location = New Point(1, 0)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(75, 23)
        btnSettings.TabIndex = 3
        btnSettings.Text = "Settings..."
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(306, 241)
        Controls.Add(btnSettings)
        Controls.Add(Label1)
        Controls.Add(btnGameMode)
        Controls.Add(btnWorkMode)
        ForeColor = SystemColors.ActiveCaptionText
        FormStyle = FormStyles.ActionBar_None
        Name = "Form1"
        Padding = New Padding(3, 24, 3, 3)
        Text = "Assistant"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnWorkMode As Button
    Friend WithEvents btnGameMode As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSettings As Button

End Class
