<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
    Inherits System.Windows.Forms.Form

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
        LoadButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' LoadButton
        ' 
        LoadButton.FlatAppearance.BorderColor = Color.Black
        LoadButton.FlatAppearance.BorderSize = 2
        LoadButton.FlatStyle = FlatStyle.Flat
        LoadButton.Font = New Font("Times New Roman", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoadButton.Location = New Point(97, 354)
        LoadButton.Name = "LoadButton"
        LoadButton.Padding = New Padding(6)
        LoadButton.Size = New Size(450, 101)
        LoadButton.TabIndex = 0
        LoadButton.Text = "Load Object Demo"
        LoadButton.TextAlign = ContentAlignment.TopLeft
        LoadButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.FlatAppearance.BorderColor = Color.Black
        ExitButton.FlatAppearance.BorderSize = 2
        ExitButton.FlatStyle = FlatStyle.Flat
        ExitButton.Font = New Font("Times New Roman", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(594, 354)
        ExitButton.Name = "ExitButton"
        ExitButton.Padding = New Padding(6)
        ExitButton.Size = New Size(442, 101)
        ExitButton.TabIndex = 1
        ExitButton.Text = "EXIT"
        ExitButton.TextAlign = ContentAlignment.TopLeft
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1164, 812)
        Controls.Add(ExitButton)
        Controls.Add(LoadButton)
        Name = "Welcome"
        Padding = New Padding(8)
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadButton As Button
    Friend WithEvents ExitButton As Button

End Class
