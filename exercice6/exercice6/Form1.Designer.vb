<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(123, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 28)
        Label1.TabIndex = 0
        Label1.Text = "nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(123, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 28)
        Label2.TabIndex = 1
        Label2.Text = "prenom"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(257, 108)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(612, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(257, 189)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(257, 269)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(123, 276)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 28)
        Label4.TabIndex = 6
        Label4.Text = "Note"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8.25F)
        Label5.Location = New Point(204, 337)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 17)
        Label5.TabIndex = 7
        Label5.Text = "               "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 8.25F)
        Label6.Location = New Point(204, 394)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 17)
        Label6.TabIndex = 8
        Label6.Text = "               "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(555, 156)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 56)
        Button1.TabIndex = 9
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(555, 237)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 59)
        Button2.TabIndex = 10
        Button2.Text = "Calculer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1066, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
