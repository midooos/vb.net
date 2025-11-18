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
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        NumericUpDown1 = New NumericUpDown()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        ComboBox4 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        GroupBox3 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DataGridView1 = New DataGridView()
        Ligne = New DataGridViewTextBoxColumn()
        Départ = New DataGridViewTextBoxColumn()
        Arrivé = New DataGridViewTextBoxColumn()
        Heure_Départ = New DataGridViewTextBoxColumn()
        Heure_Arrivé = New DataGridViewTextBoxColumn()
        Places = New DataGridViewTextBoxColumn()
        Options = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        ErrorProvider1 = New ErrorProvider(components)
        ge = New Label()
        Label8 = New Label()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(576, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(ComboBox4)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 13F)
        GroupBox1.ForeColor = SystemColors.Highlight
        GroupBox1.Location = New Point(40, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(699, 530)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Information du trajet"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(506, 99)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 138)
        Button1.TabIndex = 14
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(172, 417)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 36)
        NumericUpDown1.TabIndex = 13
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(171, 355)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(290, 36)
        DateTimePicker2.TabIndex = 12
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.Location = New Point(171, 287)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(290, 36)
        DateTimePicker1.TabIndex = 11
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"bizerte ", "manzel jmil", "alia"})
        ComboBox4.Location = New Point(171, 150)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(151, 38)
        ComboBox4.TabIndex = 10
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"tunis ", "manzel abderahman", "manzel borguiba"})
        ComboBox2.Location = New Point(171, 228)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 38)
        ComboBox2.TabIndex = 8
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(171, 87)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 38)
        ComboBox1.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 355)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 30)
        Label7.TabIndex = 6
        Label7.Text = "heure d'arrivé"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 419)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 30)
        Label6.TabIndex = 5
        Label6.Text = "places"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 30)
        Label5.TabIndex = 4
        Label5.Text = "ville départ"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 30)
        Label4.TabIndex = 3
        Label4.Text = "ville d'arrivé"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 287)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 30)
        Label3.TabIndex = 2
        Label3.Text = "heure départ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 30)
        Label2.TabIndex = 1
        Label2.Text = "Ligne"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Font = New Font("Segoe UI", 13F)
        GroupBox2.ForeColor = SystemColors.Highlight
        GroupBox2.Location = New Point(920, 74)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(432, 249)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Option"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(37, 107)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(68, 34)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "wifi"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(37, 170)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(147, 34)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "bus à étage"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(37, 51)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(154, 34)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "climatisation"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton3)
        GroupBox3.Controls.Add(RadioButton2)
        GroupBox3.Controls.Add(RadioButton1)
        GroupBox3.Font = New Font("Segoe UI", 13F)
        GroupBox3.ForeColor = SystemColors.Highlight
        GroupBox3.Location = New Point(920, 349)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(432, 229)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Type de trajet"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(32, 118)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(107, 34)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "express"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(32, 172)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(119, 34)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "noctume"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(32, 65)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(109, 34)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "régulier"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Ligne, Départ, Arrivé, Heure_Départ, Heure_Arrivé, Places, Options, Type})
        DataGridView1.Location = New Point(40, 624)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1235, 164)
        DataGridView1.TabIndex = 4
        ' 
        ' Ligne
        ' 
        Ligne.HeaderText = "Ligne"
        Ligne.MinimumWidth = 6
        Ligne.Name = "Ligne"
        Ligne.Width = 125
        ' 
        ' Départ
        ' 
        Départ.HeaderText = "Départ"
        Départ.MinimumWidth = 6
        Départ.Name = "Départ"
        Départ.Width = 125
        ' 
        ' Arrivé
        ' 
        Arrivé.HeaderText = "Arrivé"
        Arrivé.MinimumWidth = 6
        Arrivé.Name = "Arrivé"
        Arrivé.Width = 125
        ' 
        ' Heure_Départ
        ' 
        Heure_Départ.HeaderText = "Heure_Départ"
        Heure_Départ.MinimumWidth = 6
        Heure_Départ.Name = "Heure_Départ"
        Heure_Départ.Width = 125
        ' 
        ' Heure_Arrivé
        ' 
        Heure_Arrivé.HeaderText = "Heure_Arrivé"
        Heure_Arrivé.MinimumWidth = 6
        Heure_Arrivé.Name = "Heure_Arrivé"
        Heure_Arrivé.Width = 125
        ' 
        ' Places
        ' 
        Places.HeaderText = "Places"
        Places.MinimumWidth = 6
        Places.Name = "Places"
        Places.Width = 125
        ' 
        ' Options
        ' 
        Options.HeaderText = "Options"
        Options.MinimumWidth = 6
        Options.Name = "Options"
        Options.Width = 125
        ' 
        ' Type
        ' 
        Type.HeaderText = "Type"
        Type.MinimumWidth = 6
        Type.Name = "Type"
        Type.Width = 125
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ge
        ' 
        ge.AutoSize = True
        ge.Font = New Font("Segoe UI", 15F)
        ge.ForeColor = Color.Red
        ge.Location = New Point(548, 17)
        ge.Name = "ge"
        ge.Size = New Size(199, 35)
        ge.TabIndex = 5
        ge.Text = "Gestion du trajet"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1101, 584)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 20)
        Label8.TabIndex = 6
        Label8.Text = "                            "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(1423, 800)
        Controls.Add(Label8)
        Controls.Add(ge)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ligne As DataGridViewTextBoxColumn
    Friend WithEvents Départ As DataGridViewTextBoxColumn
    Friend WithEvents Arrivé As DataGridViewTextBoxColumn
    Friend WithEvents Heure_Départ As DataGridViewTextBoxColumn
    Friend WithEvents Heure_Arrivé As DataGridViewTextBoxColumn
    Friend WithEvents Places As DataGridViewTextBoxColumn
    Friend WithEvents Options As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents ge As Label

End Class
