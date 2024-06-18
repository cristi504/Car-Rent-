<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AccessibleDescription = ""
        ComboBox1.AccessibleName = ""
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"BMW", "Mercedes-Benz", "Audi", "Volkswagen", "Renault", "Opel", "Dacia", "Toyota", "Skoda", "Seat"})
        ComboBox1.Location = New Point(33, 114)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(289, 40)
        ComboBox1.TabIndex = 0
        ComboBox1.Text = "Marca"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(328, 114)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(334, 40)
        ComboBox2.TabIndex = 1
        ComboBox2.Text = "Model"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(782, 141)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(400, 39)
        DateTimePicker1.TabIndex = 2
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(782, 204)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(400, 39)
        DateTimePicker2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 32)
        Label1.TabIndex = 4
        Label1.Text = "Alegeti un Autoturism"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(923, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 32)
        Label2.TabIndex = 5
        Label2.Text = "Alegeti o data"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(879, 450)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 46)
        Button1.TabIndex = 6
        Button1.Text = "Previzualizare"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(941, 294)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(114, 39)
        TextBox1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(782, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 32)
        Label3.TabIndex = 8
        Label3.Text = "Perioada"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1132, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 32)
        Label4.TabIndex = 9
        Label4.Text = "zile"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(941, 358)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(114, 39)
        TextBox2.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(804, 365)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 32)
        Label5.TabIndex = 11
        Label5.Text = "Pret"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1110, 365)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 32)
        Label6.TabIndex = 12
        Label6.Text = "Euro"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(835, 523)
        Button2.Name = "Button2"
        Button2.Size = New Size(289, 46)
        Button2.TabIndex = 13
        Button2.Text = "Confirma rezervarea"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(835, 587)
        Button3.Name = "Button3"
        Button3.Size = New Size(289, 46)
        Button3.TabIndex = 14
        Button3.Text = "Sterge rezervarea"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 204)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(650, 350)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(179, 587)
        Button4.Name = "Button4"
        Button4.Size = New Size(268, 83)
        Button4.TabIndex = 16
        Button4.Text = "Vezi masina"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1449, 814)
        Controls.Add(Button4)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Car rent details"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
End Class
