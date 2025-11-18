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
        GroupBox1 = New GroupBox()
        RadioButton1 = New RadioButton()
        rdChemise = New RadioButton()
        rdrobe = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox3 = New GroupBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        vetement = New DataGridViewTextBoxColumn()
        typedenetoyage = New DataGridViewTextBoxColumn()
        suppléments = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        NumericUpDown1 = New NumericUpDown()
        ErrorProvider1 = New ErrorProvider(components)
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(rdChemise)
        GroupBox1.Controls.Add(rdrobe)
        GroupBox1.Font = New Font("Segoe UI", 13F)
        GroupBox1.Location = New Point(50, 58)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(315, 264)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Choix vetement"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(16, 120)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(121, 34)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pantallon"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' rdChemise
        ' 
        rdChemise.AutoSize = True
        rdChemise.Location = New Point(16, 192)
        rdChemise.Name = "rdChemise"
        rdChemise.Size = New Size(117, 34)
        rdChemise.TabIndex = 2
        rdChemise.TabStop = True
        rdChemise.Text = "Chemise"
        rdChemise.UseVisualStyleBackColor = True
        ' 
        ' rdrobe
        ' 
        rdrobe.AutoSize = True
        rdrobe.Location = New Point(16, 54)
        rdrobe.Name = "rdrobe"
        rdrobe.Size = New Size(84, 34)
        rdrobe.TabIndex = 0
        rdrobe.TabStop = True
        rdrobe.Text = "Robe"
        rdrobe.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton5)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Font = New Font("Segoe UI", 13F)
        GroupBox2.Location = New Point(392, 71)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(314, 251)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "type de netoyage"
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(34, 189)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(136, 34)
        RadioButton6.TabIndex = 3
        RadioButton6.TabStop = True
        RadioButton6.Text = "Repassage"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(34, 124)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(102, 34)
        RadioButton5.TabIndex = 2
        RadioButton5.TabStop = True
        RadioButton5.Text = "Lavage"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(34, 59)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(190, 34)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Nettoyage à sec"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CheckBox2)
        GroupBox3.Controls.Add(CheckBox1)
        GroupBox3.Font = New Font("Segoe UI", 13F)
        GroupBox3.Location = New Point(50, 360)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(644, 205)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Suppléments"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 13F)
        CheckBox2.Location = New Point(342, 97)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(131, 34)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Anti tache"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 13F)
        CheckBox1.Location = New Point(64, 97)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(149, 34)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Défroissage"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F)
        Label1.Location = New Point(782, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 30)
        Label1.TabIndex = 3
        Label1.Text = "Nombre d'article"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {vetement, typedenetoyage, suppléments, Nombre})
        DataGridView1.Location = New Point(729, 260)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(605, 305)
        DataGridView1.TabIndex = 5
        ' 
        ' vetement
        ' 
        vetement.HeaderText = "vetement"
        vetement.MinimumWidth = 6
        vetement.Name = "vetement"
        vetement.Width = 125
        ' 
        ' typedenetoyage
        ' 
        typedenetoyage.HeaderText = "type de netoyage"
        typedenetoyage.MinimumWidth = 6
        typedenetoyage.Name = "typedenetoyage"
        typedenetoyage.Width = 125
        ' 
        ' suppléments
        ' 
        suppléments.HeaderText = "suppléments"
        suppléments.MinimumWidth = 6
        suppléments.Name = "suppléments"
        suppléments.Width = 125
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 6
        Nombre.Name = "Nombre"
        Nombre.Width = 125
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(1056, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 41)
        Button1.TabIndex = 6
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(1179, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 40)
        Button2.TabIndex = 7
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(792, 138)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 8
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(1123, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 13
        Label2.Text = "           "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(1216, 645)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 10
        Label3.Text = "        "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(511, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(308, 35)
        Label4.TabIndex = 14
        Label4.Text = "Nettoyage des vétements"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(1361, 715)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NumericUpDown1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents pantallon As RadioButton
    Friend WithEvents rdrobe As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents vetement As DataGridViewTextBoxColumn
    Friend WithEvents typedenetoyage As DataGridViewTextBoxColumn
    Friend WithEvents suppléments As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider



    Friend WithEvents rdChemise As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
