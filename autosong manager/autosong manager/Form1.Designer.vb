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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label6 = New Label()
        Button3 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(401, 54)
        Label1.TabIndex = 0
        Label1.Text = "Auto Song Manager"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 1
        Label2.Text = "Stato servizio:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(363, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 2
        Label3.Text = "V. 1.0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(128, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 3
        Label4.Text = "Avviato"
        Label4.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(128, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 20)
        Label5.TabIndex = 4
        Label5.Text = "Spento"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(47, 104)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 5
        Button1.Text = "Avvia Servizio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(134, 150)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(193, 27)
        TextBox1.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Location = New Point(214, 104)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 40)
        Button2.TabIndex = 7
        Button2.Text = "Spegni Servizio"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 157)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 20)
        Label6.TabIndex = 8
        Label6.Text = "Percorso song.txt:"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(333, 149)
        Button3.Name = "Button3"
        Button3.Size = New Size(74, 29)
        Button3.TabIndex = 9
        Button3.Text = "Copia"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 2000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 194)
        Controls.Add(Button3)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Auto Song Manager"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer

End Class
