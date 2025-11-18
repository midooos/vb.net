<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        GroupBox1 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        isBoisson = New ListBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Segoe UI", 14F)
        GroupBox1.Location = New Point(42, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(357, 282)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Choix de plat"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 10F)
        RadioButton3.Location = New Point(42, 197)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(71, 27)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Pates"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 10F)
        RadioButton2.Location = New Point(42, 127)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(82, 27)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Burger"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 10F)
        RadioButton1.Location = New Point(42, 66)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(70, 27)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pizza"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Font = New Font("Segoe UI", 14F)
        GroupBox2.Location = New Point(42, 408)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(357, 282)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Supplement"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 10F)
        CheckBox3.Location = New Point(42, 221)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(86, 27)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "dessert"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 10F)
        CheckBox2.Location = New Point(42, 149)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(69, 27)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "frites"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 10F)
        CheckBox1.Location = New Point(42, 85)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(96, 27)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "fromage"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(698, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 32)
        Label1.TabIndex = 2
        Label1.Text = "Boisson"
        ' 
        ' isBoisson
        ' 
        isBoisson.FormattingEnabled = True
        isBoisson.Location = New Point(822, 70)
        isBoisson.Name = "isBoisson"
        isBoisson.Size = New Size(247, 44)
        isBoisson.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(615, 268)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 32)
        Label2.TabIndex = 4
        Label2.Text = "Facture"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.ForeColor = Color.Brown
        Button1.Location = New Point(716, 561)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 49)
        Button1.TabIndex = 5
        Button1.Text = "Commande"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.ForeColor = Color.Brown
        Button2.Location = New Point(915, 561)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 49)
        Button2.TabIndex = 6
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1364, 731)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(isBoisson)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents isBoisson As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

    Private Sub restaurant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
