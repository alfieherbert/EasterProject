<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        NameBox = New TextBox()
        AgeBox = New TextBox()
        HeightBox = New TextBox()
        MassBox = New TextBox()
        SaveButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SearchButton = New Button()
        SuspendLayout()
        ' 
        ' NameBox
        ' 
        NameBox.Location = New Point(108, 212)
        NameBox.Name = "NameBox"
        NameBox.Size = New Size(125, 27)
        NameBox.TabIndex = 0
        ' 
        ' AgeBox
        ' 
        AgeBox.Location = New Point(266, 212)
        AgeBox.Name = "AgeBox"
        AgeBox.Size = New Size(125, 27)
        AgeBox.TabIndex = 1
        ' 
        ' HeightBox
        ' 
        HeightBox.Location = New Point(434, 212)
        HeightBox.Name = "HeightBox"
        HeightBox.Size = New Size(125, 27)
        HeightBox.TabIndex = 2
        ' 
        ' MassBox
        ' 
        MassBox.Location = New Point(580, 212)
        MassBox.Name = "MassBox"
        MassBox.Size = New Size(125, 27)
        MassBox.TabIndex = 4
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(233, 327)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(94, 29)
        SaveButton.TabIndex = 5
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(147, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(302, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 7
        Label2.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(458, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 8
        Label3.Text = "Height (cm)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(619, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 9
        Label4.Text = "Mass (kg)"
        ' 
        ' SearchButton
        ' 
        SearchButton.Location = New Point(538, 327)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(94, 29)
        SearchButton.TabIndex = 10
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SearchButton)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SaveButton)
        Controls.Add(MassBox)
        Controls.Add(HeightBox)
        Controls.Add(AgeBox)
        Controls.Add(NameBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents HeightBox As TextBox
    Friend WithEvents MassBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchButton As Button
End Class
