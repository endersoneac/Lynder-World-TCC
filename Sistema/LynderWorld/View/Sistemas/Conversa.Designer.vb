<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversa
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
        Me.lblNomeNPC = New System.Windows.Forms.Label()
        Me.lblNomePersonagem = New System.Windows.Forms.Label()
        Me.fotoPersonagem = New System.Windows.Forms.PictureBox()
        Me.fotoNPC = New System.Windows.Forms.PictureBox()
        Me.groupConversa = New LynderWorld.GhostGroupBox()
        Me.btnProximo = New LynderWorld.GhostButton()
        Me.lblNomeConversa = New System.Windows.Forms.Label()
        Me.btnVoltar = New LynderWorld.GhostButton()
        Me.lblConversa = New System.Windows.Forms.Label()
        Me.GhostTheme1.SuspendLayout()
        CType(Me.fotoPersonagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoNPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupConversa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.lblNomeNPC)
        Me.GhostTheme1.Controls.Add(Me.lblNomePersonagem)
        Me.GhostTheme1.Controls.Add(Me.fotoPersonagem)
        Me.GhostTheme1.Controls.Add(Me.fotoNPC)
        Me.GhostTheme1.Controls.Add(Me.groupConversa)
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
        'lblNomeNPC
        '
        Me.lblNomeNPC.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeNPC.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeNPC.ForeColor = System.Drawing.Color.White
        Me.lblNomeNPC.Location = New System.Drawing.Point(431, 221)
        Me.lblNomeNPC.Name = "lblNomeNPC"
        Me.lblNomeNPC.Size = New System.Drawing.Size(228, 18)
        Me.lblNomeNPC.TabIndex = 5
        Me.lblNomeNPC.Text = "Nome Personagem"
        Me.lblNomeNPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNomePersonagem
        '
        Me.lblNomePersonagem.BackColor = System.Drawing.Color.Transparent
        Me.lblNomePersonagem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomePersonagem.ForeColor = System.Drawing.Color.White
        Me.lblNomePersonagem.Location = New System.Drawing.Point(126, 221)
        Me.lblNomePersonagem.Name = "lblNomePersonagem"
        Me.lblNomePersonagem.Size = New System.Drawing.Size(228, 18)
        Me.lblNomePersonagem.TabIndex = 4
        Me.lblNomePersonagem.Text = "Nome Personagem"
        Me.lblNomePersonagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fotoPersonagem
        '
        Me.fotoPersonagem.Location = New System.Drawing.Point(165, 64)
        Me.fotoPersonagem.Name = "fotoPersonagem"
        Me.fotoPersonagem.Size = New System.Drawing.Size(150, 140)
        Me.fotoPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoPersonagem.TabIndex = 0
        Me.fotoPersonagem.TabStop = False
        '
        'fotoNPC
        '
        Me.fotoNPC.Location = New System.Drawing.Point(470, 64)
        Me.fotoNPC.Name = "fotoNPC"
        Me.fotoNPC.Size = New System.Drawing.Size(150, 140)
        Me.fotoNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoNPC.TabIndex = 0
        Me.fotoNPC.TabStop = False
        '
        'groupConversa
        '
        Me.groupConversa.Colors = New LynderWorld.Bloom(-1) {}
        Me.groupConversa.Controls.Add(Me.btnProximo)
        Me.groupConversa.Controls.Add(Me.lblNomeConversa)
        Me.groupConversa.Controls.Add(Me.btnVoltar)
        Me.groupConversa.Controls.Add(Me.lblConversa)
        Me.groupConversa.Customization = ""
        Me.groupConversa.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.groupConversa.Image = Nothing
        Me.groupConversa.Location = New System.Drawing.Point(85, 310)
        Me.groupConversa.Name = "groupConversa"
        Me.groupConversa.NoRounding = False
        Me.groupConversa.Size = New System.Drawing.Size(615, 185)
        Me.groupConversa.TabIndex = 3
        Me.groupConversa.Text = "Conversa"
        Me.groupConversa.Transparent = False
        '
        'btnProximo
        '
        Me.btnProximo.Color = System.Drawing.Color.Empty
        Me.btnProximo.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnProximo.Customization = ""
        Me.btnProximo.EnableGlass = True
        Me.btnProximo.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnProximo.Image = Nothing
        Me.btnProximo.Location = New System.Drawing.Point(5, 155)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.NoRounding = False
        Me.btnProximo.Size = New System.Drawing.Size(98, 26)
        Me.btnProximo.TabIndex = 7
        Me.btnProximo.Text = "Proximo"
        Me.btnProximo.Transparent = False
        '
        'lblNomeConversa
        '
        Me.lblNomeConversa.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeConversa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeConversa.ForeColor = System.Drawing.Color.White
        Me.lblNomeConversa.Location = New System.Drawing.Point(109, 155)
        Me.lblNomeConversa.Name = "lblNomeConversa"
        Me.lblNomeConversa.Size = New System.Drawing.Size(397, 26)
        Me.lblNomeConversa.TabIndex = 6
        Me.lblNomeConversa.Text = "Nome Personagem"
        Me.lblNomeConversa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltar
        '
        Me.btnVoltar.Color = System.Drawing.Color.Empty
        Me.btnVoltar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnVoltar.Customization = ""
        Me.btnVoltar.EnableGlass = True
        Me.btnVoltar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnVoltar.Image = Nothing
        Me.btnVoltar.Location = New System.Drawing.Point(512, 155)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.NoRounding = False
        Me.btnVoltar.Size = New System.Drawing.Size(98, 26)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.Transparent = False
        '
        'lblConversa
        '
        Me.lblConversa.BackColor = System.Drawing.Color.Transparent
        Me.lblConversa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversa.ForeColor = System.Drawing.Color.White
        Me.lblConversa.Location = New System.Drawing.Point(3, 32)
        Me.lblConversa.Name = "lblConversa"
        Me.lblConversa.Size = New System.Drawing.Size(609, 108)
        Me.lblConversa.TabIndex = 2
        Me.lblConversa.Text = "Nome Personagem"
        '
        'Conversa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Conversa"
        Me.Text = "Conversa"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        CType(Me.fotoPersonagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoNPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupConversa.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents groupConversa As LynderWorld.GhostGroupBox
    Friend WithEvents fotoNPC As System.Windows.Forms.PictureBox
    Friend WithEvents fotoPersonagem As System.Windows.Forms.PictureBox
    Friend WithEvents btnVoltar As LynderWorld.GhostButton
    Friend WithEvents lblConversa As System.Windows.Forms.Label
    Friend WithEvents lblNomeNPC As System.Windows.Forms.Label
    Friend WithEvents lblNomePersonagem As System.Windows.Forms.Label
    Friend WithEvents lblNomeConversa As System.Windows.Forms.Label
    Friend WithEvents btnProximo As LynderWorld.GhostButton
End Class
