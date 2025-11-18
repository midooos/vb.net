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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        NumericUpDown1 = New NumericUpDown()
        DataGridView1 = New DataGridView()
        Code = New DataGridViewTextBoxColumn()
        Nom = New DataGridViewTextBoxColumn()
        Prenom = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Label6 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(63, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 32)
        Label1.TabIndex = 0
        Label1.Text = "Ajouter un nouveau patient"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.Location = New Point(63, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label3.Location = New Point(50, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 32)
        Label3.TabIndex = 2
        Label3.Text = "Prénom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label4.Location = New Point(63, 304)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 32)
        Label4.TabIndex = 3
        Label4.Text = "Age"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(181, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(152, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(181, 221)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(152, 27)
        TextBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.DarkSlateBlue
        Button1.Location = New Point(104, 385)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 40)
        Button1.TabIndex = 7
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.DarkSlateBlue
        Button2.Location = New Point(243, 385)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 40)
        Button2.TabIndex = 9
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(181, 302)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 10
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Code, Nom, Prenom, Age})
        DataGridView1.Location = New Point(412, 132)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(609, 204)
        DataGridView1.TabIndex = 11
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.MinimumWidth = 6
        Code.Name = "Code"
        Code.Width = 125
        ' 
        ' Nom
        ' 
        Nom.HeaderText = "Nom"
        Nom.MinimumWidth = 6
        Nom.Name = "Nom"
        Nom.Width = 125
        ' 
        ' Prenom
        ' 
        Prenom.HeaderText = "Prénom"
        Prenom.MinimumWidth = 6
        Prenom.Name = "Prenom"
        Prenom.Width = 125
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.MinimumWidth = 6
        Age.Name = "Age"
        Age.Width = 125
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label5.Location = New Point(649, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 32)
        Label5.TabIndex = 10
        Label5.Text = "                  "
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F)
        Label6.Location = New Point(864, 409)
        Label6.Name = "Label6"
        Label6.Size = New Size(189, 32)
        Label6.TabIndex = 12
        Label6.Text = "                         "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Khaki
        ClientSize = New Size(1054, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(NumericUpDown1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prenom As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label6 As Label

End Class
