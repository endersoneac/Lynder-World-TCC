<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.GhostTheme1 = New LynderWorld.GhostTheme()
        Me.pbExpert = New LynderWorld.Thief3ProgressBar()
        Me.GhostButton1 = New LynderWorld.GhostButton()
        Me.btnSair = New LynderWorld.GhostButton()
        Me.GhostTabControl1 = New LynderWorld.GhostTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblNpc = New System.Windows.Forms.Label()
        Me.lblFerreiro = New System.Windows.Forms.Label()
        Me.lblMercador = New System.Windows.Forms.Label()
        Me.lblArena = New System.Windows.Forms.Label()
        Me.btnNPC = New LynderWorld.GhostButton()
        Me.btnFerreiro = New LynderWorld.GhostButton()
        Me.btnMercador = New LynderWorld.GhostButton()
        Me.btnArena = New LynderWorld.GhostButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblExperiencia = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMana = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbMana = New LynderWorld.Thief3ProgressBar()
        Me.pbVida = New LynderWorld.Thief3ProgressBar()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.imagemPersonagem = New System.Windows.Forms.PictureBox()
        Me.lblDinheiro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GhostTheme1.SuspendLayout()
        Me.GhostTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.imagemPersonagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.lblDinheiro)
        Me.GhostTheme1.Controls.Add(Me.Label4)
        Me.GhostTheme1.Controls.Add(Me.pbExpert)
        Me.GhostTheme1.Controls.Add(Me.GhostButton1)
        Me.GhostTheme1.Controls.Add(Me.btnSair)
        Me.GhostTheme1.Controls.Add(Me.GhostTabControl1)
        Me.GhostTheme1.Controls.Add(Me.lblExperiencia)
        Me.GhostTheme1.Controls.Add(Me.Label10)
        Me.GhostTheme1.Controls.Add(Me.lblMana)
        Me.GhostTheme1.Controls.Add(Me.Label8)
        Me.GhostTheme1.Controls.Add(Me.lblVida)
        Me.GhostTheme1.Controls.Add(Me.Label6)
        Me.GhostTheme1.Controls.Add(Me.pbMana)
        Me.GhostTheme1.Controls.Add(Me.pbVida)
        Me.GhostTheme1.Controls.Add(Me.lblNivel)
        Me.GhostTheme1.Controls.Add(Me.Label3)
        Me.GhostTheme1.Controls.Add(Me.Label2)
        Me.GhostTheme1.Controls.Add(Me.lblNome)
        Me.GhostTheme1.Controls.Add(Me.imagemPersonagem)
        Me.GhostTheme1.Customization = ""
        Me.GhostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GhostTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostTheme1.Image = Nothing
        Me.GhostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.GhostTheme1.Movable = True
        Me.GhostTheme1.Name = "GhostTheme1"
        Me.GhostTheme1.NoRounding = False
        Me.GhostTheme1.ShowIcon = False
        Me.GhostTheme1.Sizable = True
        Me.GhostTheme1.Size = New System.Drawing.Size(784, 562)
        Me.GhostTheme1.SmartBounds = True
        Me.GhostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.GhostTheme1.TabIndex = 0
        Me.GhostTheme1.Text = "Lynder World"
        Me.GhostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.Transparent = False
        '
        'pbExpert
        '
        Me.pbExpert.Image = Nothing
        Me.pbExpert.Location = New System.Drawing.Point(153, 159)
        Me.pbExpert.Maximum = 0
        Me.pbExpert.Name = "pbExpert"
        Me.pbExpert.NoRounding = False
        Me.pbExpert.Size = New System.Drawing.Size(273, 13)
        Me.pbExpert.TabIndex = 18
        Me.pbExpert.Text = "Thief3ProgressBar1"
        Me.pbExpert.Value = 1
        '
        'GhostButton1
        '
        Me.GhostButton1.Color = System.Drawing.Color.Empty
        Me.GhostButton1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostButton1.Customization = ""
        Me.GhostButton1.EnableGlass = True
        Me.GhostButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton1.Image = Nothing
        Me.GhostButton1.Location = New System.Drawing.Point(649, 70)
        Me.GhostButton1.Name = "GhostButton1"
        Me.GhostButton1.NoRounding = False
        Me.GhostButton1.Size = New System.Drawing.Size(106, 27)
        Me.GhostButton1.TabIndex = 17
        Me.GhostButton1.Text = "Configurações"
        Me.GhostButton1.Transparent = False
        '
        'btnSair
        '
        Me.btnSair.Color = System.Drawing.Color.Empty
        Me.btnSair.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnSair.Customization = ""
        Me.btnSair.EnableGlass = True
        Me.btnSair.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSair.Image = Nothing
        Me.btnSair.Location = New System.Drawing.Point(649, 259)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.NoRounding = False
        Me.btnSair.Size = New System.Drawing.Size(110, 27)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.Transparent = False
        '
        'GhostTabControl1
        '
        Me.GhostTabControl1.Controls.Add(Me.TabPage1)
        Me.GhostTabControl1.Controls.Add(Me.TabPage2)
        Me.GhostTabControl1.Location = New System.Drawing.Point(21, 311)
        Me.GhostTabControl1.Name = "GhostTabControl1"
        Me.GhostTabControl1.SelectedIndex = 0
        Me.GhostTabControl1.Size = New System.Drawing.Size(738, 239)
        Me.GhostTabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblNpc)
        Me.TabPage1.Controls.Add(Me.lblFerreiro)
        Me.TabPage1.Controls.Add(Me.lblMercador)
        Me.TabPage1.Controls.Add(Me.lblArena)
        Me.TabPage1.Controls.Add(Me.btnNPC)
        Me.TabPage1.Controls.Add(Me.btnFerreiro)
        Me.TabPage1.Controls.Add(Me.btnMercador)
        Me.TabPage1.Controls.Add(Me.btnArena)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(730, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cidade"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblNpc
        '
        Me.lblNpc.AutoSize = True
        Me.lblNpc.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNpc.Location = New System.Drawing.Point(274, 163)
        Me.lblNpc.Name = "lblNpc"
        Me.lblNpc.Size = New System.Drawing.Size(304, 23)
        Me.lblNpc.TabIndex = 7
        Me.lblNpc.Text = "- Descobertas e investigações."
        Me.lblNpc.Visible = False
        '
        'lblFerreiro
        '
        Me.lblFerreiro.AutoSize = True
        Me.lblFerreiro.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFerreiro.Location = New System.Drawing.Point(274, 116)
        Me.lblFerreiro.Name = "lblFerreiro"
        Me.lblFerreiro.Size = New System.Drawing.Size(269, 23)
        Me.lblFerreiro.TabIndex = 6
        Me.lblFerreiro.Text = "- Fortalecer equipamentos."
        Me.lblFerreiro.Visible = False
        '
        'lblMercador
        '
        Me.lblMercador.AutoSize = True
        Me.lblMercador.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercador.Location = New System.Drawing.Point(274, 70)
        Me.lblMercador.Name = "lblMercador"
        Me.lblMercador.Size = New System.Drawing.Size(225, 23)
        Me.lblMercador.TabIndex = 5
        Me.lblMercador.Text = "- Mercador de poçoes."
        Me.lblMercador.Visible = False
        '
        'lblArena
        '
        Me.lblArena.AutoSize = True
        Me.lblArena.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArena.Location = New System.Drawing.Point(274, 24)
        Me.lblArena.Name = "lblArena"
        Me.lblArena.Size = New System.Drawing.Size(205, 23)
        Me.lblArena.TabIndex = 4
        Me.lblArena.Text = "- Arena de batalhas."
        Me.lblArena.Visible = False
        '
        'btnNPC
        '
        Me.btnNPC.Color = System.Drawing.Color.Empty
        Me.btnNPC.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnNPC.Customization = ""
        Me.btnNPC.EnableGlass = True
        Me.btnNPC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnNPC.Image = Nothing
        Me.btnNPC.Location = New System.Drawing.Point(28, 161)
        Me.btnNPC.Name = "btnNPC"
        Me.btnNPC.NoRounding = False
        Me.btnNPC.Size = New System.Drawing.Size(110, 27)
        Me.btnNPC.TabIndex = 3
        Me.btnNPC.Text = "NPC"
        Me.btnNPC.Transparent = False
        '
        'btnFerreiro
        '
        Me.btnFerreiro.Color = System.Drawing.Color.Empty
        Me.btnFerreiro.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnFerreiro.Customization = ""
        Me.btnFerreiro.EnableGlass = True
        Me.btnFerreiro.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnFerreiro.Image = Nothing
        Me.btnFerreiro.Location = New System.Drawing.Point(28, 114)
        Me.btnFerreiro.Name = "btnFerreiro"
        Me.btnFerreiro.NoRounding = False
        Me.btnFerreiro.Size = New System.Drawing.Size(110, 27)
        Me.btnFerreiro.TabIndex = 2
        Me.btnFerreiro.Text = "Ferreiro"
        Me.btnFerreiro.Transparent = False
        '
        'btnMercador
        '
        Me.btnMercador.Color = System.Drawing.Color.Empty
        Me.btnMercador.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnMercador.Customization = ""
        Me.btnMercador.EnableGlass = True
        Me.btnMercador.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMercador.Image = Nothing
        Me.btnMercador.Location = New System.Drawing.Point(28, 68)
        Me.btnMercador.Name = "btnMercador"
        Me.btnMercador.NoRounding = False
        Me.btnMercador.Size = New System.Drawing.Size(110, 27)
        Me.btnMercador.TabIndex = 1
        Me.btnMercador.Text = "Mercador"
        Me.btnMercador.Transparent = False
        '
        'btnArena
        '
        Me.btnArena.Color = System.Drawing.Color.Empty
        Me.btnArena.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnArena.Customization = ""
        Me.btnArena.EnableGlass = True
        Me.btnArena.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnArena.Image = Nothing
        Me.btnArena.Location = New System.Drawing.Point(28, 22)
        Me.btnArena.Name = "btnArena"
        Me.btnArena.NoRounding = False
        Me.btnArena.Size = New System.Drawing.Size(110, 27)
        Me.btnArena.TabIndex = 0
        Me.btnArena.Text = "Arena"
        Me.btnArena.Transparent = False
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(730, 210)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mapa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblExperiencia
        '
        Me.lblExperiencia.AutoSize = True
        Me.lblExperiencia.BackColor = System.Drawing.Color.Transparent
        Me.lblExperiencia.ForeColor = System.Drawing.Color.White
        Me.lblExperiencia.Location = New System.Drawing.Point(234, 143)
        Me.lblExperiencia.Name = "lblExperiencia"
        Me.lblExperiencia.Size = New System.Drawing.Size(111, 13)
        Me.lblExperiencia.TabIndex = 15
        Me.lblExperiencia.Text = "Atual / Necessário"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(150, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Experiência:"
        '
        'lblMana
        '
        Me.lblMana.AutoSize = True
        Me.lblMana.BackColor = System.Drawing.Color.Transparent
        Me.lblMana.ForeColor = System.Drawing.Color.White
        Me.lblMana.Location = New System.Drawing.Point(55, 247)
        Me.lblMana.Name = "lblMana"
        Me.lblMana.Size = New System.Drawing.Size(108, 13)
        Me.lblMana.TabIndex = 12
        Me.lblMana.Text = "minimo / maximo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Mana:"
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.BackColor = System.Drawing.Color.Transparent
        Me.lblVida.ForeColor = System.Drawing.Color.White
        Me.lblVida.Location = New System.Drawing.Point(55, 197)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(108, 13)
        Me.lblVida.TabIndex = 10
        Me.lblVida.Text = "minimo / maximo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Vida:"
        '
        'pbMana
        '
        Me.pbMana.Image = Nothing
        Me.pbMana.Location = New System.Drawing.Point(21, 263)
        Me.pbMana.Maximum = 100
        Me.pbMana.Name = "pbMana"
        Me.pbMana.NoRounding = False
        Me.pbMana.Size = New System.Drawing.Size(113, 23)
        Me.pbMana.TabIndex = 8
        Me.pbMana.Text = "Thief3ProgressBar2"
        Me.pbMana.Value = 50
        '
        'pbVida
        '
        Me.pbVida.Image = Nothing
        Me.pbVida.Location = New System.Drawing.Point(21, 213)
        Me.pbVida.Maximum = 100
        Me.pbVida.Name = "pbVida"
        Me.pbVida.NoRounding = False
        Me.pbVida.Size = New System.Drawing.Size(113, 23)
        Me.pbVida.TabIndex = 7
        Me.pbVida.Text = "Thief3ProgressBar1"
        Me.pbVida.Value = 50
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.BackColor = System.Drawing.Color.Transparent
        Me.lblNivel.ForeColor = System.Drawing.Color.White
        Me.lblNivel.Location = New System.Drawing.Point(191, 109)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(17, 13)
        Me.lblNivel.TabIndex = 4
        Me.lblNivel.Text = "--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(150, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nível:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(150, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(Cidade Atual)"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.Color.Transparent
        Me.lblNome.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.White
        Me.lblNome.Location = New System.Drawing.Point(150, 70)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(161, 18)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome Personagem"
        '
        'imagemPersonagem
        '
        Me.imagemPersonagem.Location = New System.Drawing.Point(21, 70)
        Me.imagemPersonagem.Name = "imagemPersonagem"
        Me.imagemPersonagem.Size = New System.Drawing.Size(113, 102)
        Me.imagemPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagemPersonagem.TabIndex = 0
        Me.imagemPersonagem.TabStop = False
        '
        'lblDinheiro
        '
        Me.lblDinheiro.AutoSize = True
        Me.lblDinheiro.BackColor = System.Drawing.Color.Transparent
        Me.lblDinheiro.ForeColor = System.Drawing.Color.White
        Me.lblDinheiro.Location = New System.Drawing.Point(211, 127)
        Me.lblDinheiro.Name = "lblDinheiro"
        Me.lblDinheiro.Size = New System.Drawing.Size(17, 13)
        Me.lblDinheiro.TabIndex = 20
        Me.lblDinheiro.Text = "--"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(150, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Dinheiro:"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.GhostTheme1.PerformLayout()
        Me.GhostTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.imagemPersonagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents lblNivel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents imagemPersonagem As System.Windows.Forms.PictureBox
    Friend WithEvents pbVida As LynderWorld.Thief3ProgressBar
    Friend WithEvents pbMana As LynderWorld.Thief3ProgressBar
    Friend WithEvents GhostTabControl1 As LynderWorld.GhostTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblNpc As System.Windows.Forms.Label
    Friend WithEvents lblFerreiro As System.Windows.Forms.Label
    Friend WithEvents lblMercador As System.Windows.Forms.Label
    Friend WithEvents lblArena As System.Windows.Forms.Label
    Friend WithEvents btnNPC As LynderWorld.GhostButton
    Friend WithEvents btnFerreiro As LynderWorld.GhostButton
    Friend WithEvents btnMercador As LynderWorld.GhostButton
    Friend WithEvents btnArena As LynderWorld.GhostButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblExperiencia As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMana As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblVida As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSair As LynderWorld.GhostButton
    Friend WithEvents GhostButton1 As LynderWorld.GhostButton
    Friend WithEvents pbExpert As LynderWorld.Thief3ProgressBar
    Friend WithEvents lblDinheiro As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
