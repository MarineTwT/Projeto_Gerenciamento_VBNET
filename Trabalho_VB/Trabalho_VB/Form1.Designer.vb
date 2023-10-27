<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripMenuItem, Me.AlterarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AdicionarToolStripMenuItem.Text = "Adicionar"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Tan
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListView1.Location = New System.Drawing.Point(0, 285)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(202, 167)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lista de Funcionários:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.MaskedTextBox2)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(318, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 164)
        Me.Panel1.TabIndex = 4
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.Tan
        Me.MaskedTextBox2.Location = New System.Drawing.Point(115, 104)
        Me.MaskedTextBox2.Mask = "00000-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.ReadOnly = True
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Tan
        Me.TextBox5.Location = New System.Drawing.Point(115, 130)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.Tan
        Me.MaskedTextBox1.Location = New System.Drawing.Point(115, 78)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ReadOnly = True
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 15
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Telefone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data da fundação:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Tan
        Me.TextBox2.Location = New System.Drawing.Point(115, 29)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 42)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Endereço:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Tan
        Me.TextBox1.Location = New System.Drawing.Point(115, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(388, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Empresa"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TextBox9)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox10)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(572, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 164)
        Me.Panel2.TabIndex = 10
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Tan
        Me.TextBox6.Location = New System.Drawing.Point(115, 107)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 42)
        Me.TextBox6.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Descrição:"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Tan
        Me.TextBox7.Location = New System.Drawing.Point(115, 81)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Classificação:"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Tan
        Me.TextBox8.Location = New System.Drawing.Point(115, 55)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Subgênero"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Tan
        Me.TextBox9.Location = New System.Drawing.Point(115, 29)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Gênero:"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Tan
        Me.TextBox10.Location = New System.Drawing.Point(115, 3)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Nome:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(656, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Jogo"
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.Tan
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(22, 54)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(257, 164)
        Me.ListView2.TabIndex = 12
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(99, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Lista de Projetos:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(718, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label14 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Button1 As Button
End Class
