<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Batalha
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
        Me.listItem = New LynderWorld.GhostListboxLessPretty()
        Me.listMagia = New LynderWorld.GhostListboxLessPretty()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDesistir = New LynderWorld.GhostButton()
        Me.btnItem = New LynderWorld.GhostButton()
        Me.btnMagia = New LynderWorld.GhostButton()
        Me.btnAtacar = New LynderWorld.GhostButton()
        Me.gpbMonstro = New LynderWorld.GhostGroupBox()
        Me.lblVidaMonstro = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbMonstro = New System.Windows.Forms.PictureBox()
        Me.Thief3ProgressBar3 = New LynderWorld.Thief3ProgressBar()
        Me.pbVidaMonstro = New LynderWorld.Thief3ProgressBar()
        Me.gpbJogador = New LynderWorld.GhostGroupBox()
        Me.lblMana = New System.Windows.Forms.Label()
        Me.pbJogador = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbMana = New LynderWorld.Thief3ProgressBar()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbVida = New LynderWorld.Thief3ProgressBar()
        Me.telaConclusao = New LynderWorld.GhostGroupBox()
        Me.lblExperiencia = New System.Windows.Forms.Label()
        Me.lblDinheiro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fotoFinal = New System.Windows.Forms.PictureBox()
        Me.btnContinuar = New LynderWorld.GhostButton()
        Me.GhostTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbMonstro.SuspendLayout()
        CType(Me.pbMonstro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbJogador.SuspendLayout()
        CType(Me.pbJogador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.telaConclusao.SuspendLayout()
        CType(Me.fotoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.telaConclusao)
        Me.GhostTheme1.Controls.Add(Me.listItem)
        Me.GhostTheme1.Controls.Add(Me.listMagia)
        Me.GhostTheme1.Controls.Add(Me.PictureBox1)
        Me.GhostTheme1.Controls.Add(Me.btnDesistir)
        Me.GhostTheme1.Controls.Add(Me.btnItem)
        Me.GhostTheme1.Controls.Add(Me.btnMagia)
        Me.GhostTheme1.Controls.Add(Me.btnAtacar)
        Me.GhostTheme1.Controls.Add(Me.gpbMonstro)
        Me.GhostTheme1.Controls.Add(Me.gpbJogador)
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
        'listItem
        '
        Me.listItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.listItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.listItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.listItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.listItem.FormattingEnabled = True
        Me.listItem.IntegralHeight = False
        Me.listItem.ItemHeight = 20
        Me.listItem.Items.AddRange(New Object() {"Cura Pequena", "Cura Grande", "Mana Pequena", "Mana Grande", "Poção Suprema"})
        Me.listItem.Location = New System.Drawing.Point(407, 377)
        Me.listItem.Name = "listItem"
        Me.listItem.Size = New System.Drawing.Size(109, 96)
        Me.listItem.TabIndex = 10
        Me.listItem.Visible = False
        '
        'listMagia
        '
        Me.listMagia.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.listMagia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMagia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.listMagia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.listMagia.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.listMagia.FormattingEnabled = True
        Me.listMagia.IntegralHeight = False
        Me.listMagia.ItemHeight = 20
        Me.listMagia.Location = New System.Drawing.Point(268, 378)
        Me.listMagia.Name = "listMagia"
        Me.listMagia.Size = New System.Drawing.Size(109, 96)
        Me.listMagia.TabIndex = 9
        Me.listMagia.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LynderWorld.My.Resources.Resources.vs1
        Me.PictureBox1.Location = New System.Drawing.Point(352, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnDesistir
        '
        Me.btnDesistir.Color = System.Drawing.Color.Empty
        Me.btnDesistir.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnDesistir.Customization = ""
        Me.btnDesistir.EnableGlass = True
        Me.btnDesistir.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnDesistir.Image = Nothing
        Me.btnDesistir.Location = New System.Drawing.Point(546, 486)
        Me.btnDesistir.Name = "btnDesistir"
        Me.btnDesistir.NoRounding = False
        Me.btnDesistir.Size = New System.Drawing.Size(109, 32)
        Me.btnDesistir.TabIndex = 5
        Me.btnDesistir.Text = "Desistir"
        Me.btnDesistir.Transparent = False
        '
        'btnItem
        '
        Me.btnItem.Color = System.Drawing.Color.Empty
        Me.btnItem.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnItem.Customization = ""
        Me.btnItem.EnableGlass = True
        Me.btnItem.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnItem.Image = Nothing
        Me.btnItem.Location = New System.Drawing.Point(407, 486)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.NoRounding = False
        Me.btnItem.Size = New System.Drawing.Size(109, 32)
        Me.btnItem.TabIndex = 4
        Me.btnItem.Text = "Item"
        Me.btnItem.Transparent = False
        '
        'btnMagia
        '
        Me.btnMagia.Color = System.Drawing.Color.Empty
        Me.btnMagia.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnMagia.Customization = ""
        Me.btnMagia.EnableGlass = True
        Me.btnMagia.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMagia.Image = Nothing
        Me.btnMagia.Location = New System.Drawing.Point(268, 486)
        Me.btnMagia.Name = "btnMagia"
        Me.btnMagia.NoRounding = False
        Me.btnMagia.Size = New System.Drawing.Size(109, 32)
        Me.btnMagia.TabIndex = 3
        Me.btnMagia.Text = "Magia"
        Me.btnMagia.Transparent = False
        '
        'btnAtacar
        '
        Me.btnAtacar.Color = System.Drawing.Color.Empty
        Me.btnAtacar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnAtacar.Customization = ""
        Me.btnAtacar.EnableGlass = True
        Me.btnAtacar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAtacar.Image = Nothing
        Me.btnAtacar.Location = New System.Drawing.Point(129, 486)
        Me.btnAtacar.Name = "btnAtacar"
        Me.btnAtacar.NoRounding = False
        Me.btnAtacar.Size = New System.Drawing.Size(109, 32)
        Me.btnAtacar.TabIndex = 2
        Me.btnAtacar.Text = "Atacar"
        Me.btnAtacar.Transparent = False
        '
        'gpbMonstro
        '
        Me.gpbMonstro.Colors = New LynderWorld.Bloom(-1) {}
        Me.gpbMonstro.Controls.Add(Me.lblVidaMonstro)
        Me.gpbMonstro.Controls.Add(Me.Label2)
        Me.gpbMonstro.Controls.Add(Me.pbMonstro)
        Me.gpbMonstro.Controls.Add(Me.Thief3ProgressBar3)
        Me.gpbMonstro.Controls.Add(Me.pbVidaMonstro)
        Me.gpbMonstro.Customization = ""
        Me.gpbMonstro.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gpbMonstro.Image = Nothing
        Me.gpbMonstro.Location = New System.Drawing.Point(438, 40)
        Me.gpbMonstro.Name = "gpbMonstro"
        Me.gpbMonstro.NoRounding = False
        Me.gpbMonstro.Size = New System.Drawing.Size(304, 402)
        Me.gpbMonstro.TabIndex = 1
        Me.gpbMonstro.Text = "Monstro"
        Me.gpbMonstro.Transparent = False
        '
        'lblVidaMonstro
        '
        Me.lblVidaMonstro.AutoSize = True
        Me.lblVidaMonstro.BackColor = System.Drawing.Color.Transparent
        Me.lblVidaMonstro.ForeColor = System.Drawing.Color.White
        Me.lblVidaMonstro.Location = New System.Drawing.Point(60, 322)
        Me.lblVidaMonstro.Name = "lblVidaMonstro"
        Me.lblVidaMonstro.Size = New System.Drawing.Size(108, 13)
        Me.lblVidaMonstro.TabIndex = 19
        Me.lblVidaMonstro.Text = "minimo / maximo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Vida:"
        '
        'pbMonstro
        '
        Me.pbMonstro.Location = New System.Drawing.Point(72, 77)
        Me.pbMonstro.Name = "pbMonstro"
        Me.pbMonstro.Size = New System.Drawing.Size(160, 135)
        Me.pbMonstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMonstro.TabIndex = 3
        Me.pbMonstro.TabStop = False
        '
        'Thief3ProgressBar3
        '
        Me.Thief3ProgressBar3.Image = Nothing
        Me.Thief3ProgressBar3.Location = New System.Drawing.Point(19, 373)
        Me.Thief3ProgressBar3.Maximum = 0
        Me.Thief3ProgressBar3.Name = "Thief3ProgressBar3"
        Me.Thief3ProgressBar3.NoRounding = False
        Me.Thief3ProgressBar3.Size = New System.Drawing.Size(267, 16)
        Me.Thief3ProgressBar3.TabIndex = 3
        Me.Thief3ProgressBar3.Text = "Thief3ProgressBar3"
        Me.Thief3ProgressBar3.Value = 1
        '
        'pbVidaMonstro
        '
        Me.pbVidaMonstro.Image = Nothing
        Me.pbVidaMonstro.Location = New System.Drawing.Point(19, 338)
        Me.pbVidaMonstro.Maximum = 0
        Me.pbVidaMonstro.Name = "pbVidaMonstro"
        Me.pbVidaMonstro.NoRounding = False
        Me.pbVidaMonstro.Size = New System.Drawing.Size(267, 16)
        Me.pbVidaMonstro.TabIndex = 2
        Me.pbVidaMonstro.Text = "Thief3ProgressBar4"
        Me.pbVidaMonstro.Value = 1
        '
        'gpbJogador
        '
        Me.gpbJogador.Colors = New LynderWorld.Bloom(-1) {}
        Me.gpbJogador.Controls.Add(Me.lblMana)
        Me.gpbJogador.Controls.Add(Me.pbJogador)
        Me.gpbJogador.Controls.Add(Me.Label8)
        Me.gpbJogador.Controls.Add(Me.pbMana)
        Me.gpbJogador.Controls.Add(Me.lblVida)
        Me.gpbJogador.Controls.Add(Me.Label6)
        Me.gpbJogador.Controls.Add(Me.pbVida)
        Me.gpbJogador.Customization = ""
        Me.gpbJogador.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.gpbJogador.Image = Nothing
        Me.gpbJogador.Location = New System.Drawing.Point(42, 40)
        Me.gpbJogador.Name = "gpbJogador"
        Me.gpbJogador.NoRounding = False
        Me.gpbJogador.Size = New System.Drawing.Size(304, 402)
        Me.gpbJogador.TabIndex = 0
        Me.gpbJogador.Text = "Jogador"
        Me.gpbJogador.Transparent = False
        '
        'lblMana
        '
        Me.lblMana.AutoSize = True
        Me.lblMana.BackColor = System.Drawing.Color.Transparent
        Me.lblMana.ForeColor = System.Drawing.Color.White
        Me.lblMana.Location = New System.Drawing.Point(53, 357)
        Me.lblMana.Name = "lblMana"
        Me.lblMana.Size = New System.Drawing.Size(108, 13)
        Me.lblMana.TabIndex = 16
        Me.lblMana.Text = "minimo / maximo"
        '
        'pbJogador
        '
        Me.pbJogador.Location = New System.Drawing.Point(66, 77)
        Me.pbJogador.Name = "pbJogador"
        Me.pbJogador.Size = New System.Drawing.Size(160, 135)
        Me.pbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbJogador.TabIndex = 2
        Me.pbJogador.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Mana:"
        '
        'pbMana
        '
        Me.pbMana.Image = Nothing
        Me.pbMana.Location = New System.Drawing.Point(19, 373)
        Me.pbMana.Maximum = 100
        Me.pbMana.Name = "pbMana"
        Me.pbMana.NoRounding = False
        Me.pbMana.Size = New System.Drawing.Size(267, 16)
        Me.pbMana.TabIndex = 1
        Me.pbMana.Text = "Thief3ProgressBar2"
        Me.pbMana.Value = 1
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.BackColor = System.Drawing.Color.Transparent
        Me.lblVida.ForeColor = System.Drawing.Color.White
        Me.lblVida.Location = New System.Drawing.Point(53, 322)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(108, 13)
        Me.lblVida.TabIndex = 14
        Me.lblVida.Text = "minimo / maximo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Vida:"
        '
        'pbVida
        '
        Me.pbVida.Image = Nothing
        Me.pbVida.Location = New System.Drawing.Point(19, 338)
        Me.pbVida.Maximum = 100
        Me.pbVida.Name = "pbVida"
        Me.pbVida.NoRounding = False
        Me.pbVida.Size = New System.Drawing.Size(267, 16)
        Me.pbVida.TabIndex = 0
        Me.pbVida.Text = "Thief3ProgressBar1"
        Me.pbVida.Value = 1
        '
        'telaConclusao
        '
        Me.telaConclusao.Colors = New LynderWorld.Bloom(-1) {}
        Me.telaConclusao.Controls.Add(Me.lblExperiencia)
        Me.telaConclusao.Controls.Add(Me.lblDinheiro)
        Me.telaConclusao.Controls.Add(Me.Label4)
        Me.telaConclusao.Controls.Add(Me.Label3)
        Me.telaConclusao.Controls.Add(Me.Label1)
        Me.telaConclusao.Controls.Add(Me.fotoFinal)
        Me.telaConclusao.Controls.Add(Me.btnContinuar)
        Me.telaConclusao.Customization = ""
        Me.telaConclusao.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.telaConclusao.Image = Nothing
        Me.telaConclusao.Location = New System.Drawing.Point(42, 40)
        Me.telaConclusao.Name = "telaConclusao"
        Me.telaConclusao.NoRounding = False
        Me.telaConclusao.Size = New System.Drawing.Size(700, 498)
        Me.telaConclusao.TabIndex = 8
        Me.telaConclusao.Text = "GhostGroupBox1"
        Me.telaConclusao.Transparent = False
        Me.telaConclusao.Visible = False
        '
        'lblExperiencia
        '
        Me.lblExperiencia.AutoSize = True
        Me.lblExperiencia.BackColor = System.Drawing.Color.Transparent
        Me.lblExperiencia.ForeColor = System.Drawing.Color.White
        Me.lblExperiencia.Location = New System.Drawing.Point(359, 405)
        Me.lblExperiencia.Name = "lblExperiencia"
        Me.lblExperiencia.Size = New System.Drawing.Size(13, 13)
        Me.lblExperiencia.TabIndex = 18
        Me.lblExperiencia.Text = "?"
        '
        'lblDinheiro
        '
        Me.lblDinheiro.AutoSize = True
        Me.lblDinheiro.BackColor = System.Drawing.Color.Transparent
        Me.lblDinheiro.ForeColor = System.Drawing.Color.White
        Me.lblDinheiro.Location = New System.Drawing.Point(150, 405)
        Me.lblDinheiro.Name = "lblDinheiro"
        Me.lblDinheiro.Size = New System.Drawing.Size(13, 13)
        Me.lblDinheiro.TabIndex = 17
        Me.lblDinheiro.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(275, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 34)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Premios!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(275, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Experiencia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Dinheiro:"
        '
        'fotoFinal
        '
        Me.fotoFinal.BackColor = System.Drawing.Color.Transparent
        Me.fotoFinal.Location = New System.Drawing.Point(69, 46)
        Me.fotoFinal.Name = "fotoFinal"
        Me.fotoFinal.Size = New System.Drawing.Size(562, 308)
        Me.fotoFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoFinal.TabIndex = 0
        Me.fotoFinal.TabStop = False
        '
        'btnContinuar
        '
        Me.btnContinuar.Color = System.Drawing.Color.Empty
        Me.btnContinuar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnContinuar.Customization = ""
        Me.btnContinuar.EnableGlass = True
        Me.btnContinuar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnContinuar.Image = Nothing
        Me.btnContinuar.Location = New System.Drawing.Point(270, 465)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.NoRounding = False
        Me.btnContinuar.Size = New System.Drawing.Size(160, 23)
        Me.btnContinuar.TabIndex = 1
        Me.btnContinuar.Text = "Voltar para Arena"
        Me.btnContinuar.Transparent = False
        '
        'Batalha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Batalha"
        Me.Text = "Batalha"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbMonstro.ResumeLayout(False)
        Me.gpbMonstro.PerformLayout()
        CType(Me.pbMonstro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbJogador.ResumeLayout(False)
        Me.gpbJogador.PerformLayout()
        CType(Me.pbJogador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.telaConclusao.ResumeLayout(False)
        Me.telaConclusao.PerformLayout()
        CType(Me.fotoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents btnDesistir As LynderWorld.GhostButton
    Friend WithEvents btnItem As LynderWorld.GhostButton
    Friend WithEvents btnMagia As LynderWorld.GhostButton
    Friend WithEvents btnAtacar As LynderWorld.GhostButton
    Friend WithEvents gpbMonstro As LynderWorld.GhostGroupBox
    Friend WithEvents gpbJogador As LynderWorld.GhostGroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbMonstro As System.Windows.Forms.PictureBox
    Friend WithEvents Thief3ProgressBar3 As LynderWorld.Thief3ProgressBar
    Friend WithEvents pbVidaMonstro As LynderWorld.Thief3ProgressBar
    Friend WithEvents pbJogador As System.Windows.Forms.PictureBox
    Friend WithEvents pbMana As LynderWorld.Thief3ProgressBar
    Friend WithEvents pbVida As LynderWorld.Thief3ProgressBar
    Friend WithEvents lblMana As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblVida As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblVidaMonstro As System.Windows.Forms.Label
    Friend WithEvents telaConclusao As LynderWorld.GhostGroupBox
    Friend WithEvents btnContinuar As LynderWorld.GhostButton
    Friend WithEvents fotoFinal As System.Windows.Forms.PictureBox
    Friend WithEvents lblExperiencia As System.Windows.Forms.Label
    Friend WithEvents lblDinheiro As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listMagia As LynderWorld.GhostListboxLessPretty
    Friend WithEvents listItem As LynderWorld.GhostListboxLessPretty
End Class
