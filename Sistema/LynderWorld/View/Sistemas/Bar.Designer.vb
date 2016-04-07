<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnVoltar = New LynderWorld.GhostButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupNPC3 = New LynderWorld.GhostGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConversar3 = New LynderWorld.GhostButton()
        Me.foto3 = New System.Windows.Forms.PictureBox()
        Me.groupNPC2 = New LynderWorld.GhostGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConversar2 = New LynderWorld.GhostButton()
        Me.foto2 = New System.Windows.Forms.PictureBox()
        Me.groupNPC1 = New LynderWorld.GhostGroupBox()
        Me.lblMsgFerreiro = New System.Windows.Forms.Label()
        Me.btnConversar1 = New LynderWorld.GhostButton()
        Me.foto1 = New System.Windows.Forms.PictureBox()
        Me.GhostTheme1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupNPC3.SuspendLayout()
        CType(Me.foto3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupNPC2.SuspendLayout()
        CType(Me.foto2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupNPC1.SuspendLayout()
        CType(Me.foto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.Panel1)
        Me.GhostTheme1.Controls.Add(Me.btnVoltar)
        Me.GhostTheme1.Controls.Add(Me.PictureBox1)
        Me.GhostTheme1.Controls.Add(Me.groupNPC3)
        Me.GhostTheme1.Controls.Add(Me.groupNPC2)
        Me.GhostTheme1.Controls.Add(Me.groupNPC1)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 61)
        Me.Panel1.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(-1, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(248, 44)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Bar de Morgambar"
        '
        'btnVoltar
        '
        Me.btnVoltar.Color = System.Drawing.Color.Empty
        Me.btnVoltar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnVoltar.Customization = ""
        Me.btnVoltar.EnableGlass = True
        Me.btnVoltar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnVoltar.Image = Nothing
        Me.btnVoltar.Location = New System.Drawing.Point(646, 516)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.NoRounding = False
        Me.btnVoltar.Size = New System.Drawing.Size(126, 34)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LynderWorld.My.Resources.Resources.bar
        Me.PictureBox1.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'groupNPC3
        '
        Me.groupNPC3.Colors = New LynderWorld.Bloom(-1) {}
        Me.groupNPC3.Controls.Add(Me.Label3)
        Me.groupNPC3.Controls.Add(Me.btnConversar3)
        Me.groupNPC3.Controls.Add(Me.foto3)
        Me.groupNPC3.Customization = ""
        Me.groupNPC3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.groupNPC3.Image = Nothing
        Me.groupNPC3.Location = New System.Drawing.Point(379, 376)
        Me.groupNPC3.Name = "groupNPC3"
        Me.groupNPC3.NoRounding = False
        Me.groupNPC3.Size = New System.Drawing.Size(393, 135)
        Me.groupNPC3.TabIndex = 2
        Me.groupNPC3.Text = "Nome Terceiro NPC"
        Me.groupNPC3.Transparent = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(117, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Venha comigo, aqui é perigoso!"
        '
        'btnConversar3
        '
        Me.btnConversar3.Color = System.Drawing.Color.Empty
        Me.btnConversar3.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnConversar3.Customization = ""
        Me.btnConversar3.EnableGlass = True
        Me.btnConversar3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnConversar3.Image = Nothing
        Me.btnConversar3.Location = New System.Drawing.Point(177, 91)
        Me.btnConversar3.Name = "btnConversar3"
        Me.btnConversar3.NoRounding = False
        Me.btnConversar3.Size = New System.Drawing.Size(126, 34)
        Me.btnConversar3.TabIndex = 4
        Me.btnConversar3.Text = "Conversar"
        Me.btnConversar3.Transparent = False
        '
        'foto3
        '
        Me.foto3.Location = New System.Drawing.Point(11, 30)
        Me.foto3.Name = "foto3"
        Me.foto3.Size = New System.Drawing.Size(100, 95)
        Me.foto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto3.TabIndex = 0
        Me.foto3.TabStop = False
        '
        'groupNPC2
        '
        Me.groupNPC2.Colors = New LynderWorld.Bloom(-1) {}
        Me.groupNPC2.Controls.Add(Me.Label2)
        Me.groupNPC2.Controls.Add(Me.btnConversar2)
        Me.groupNPC2.Controls.Add(Me.foto2)
        Me.groupNPC2.Customization = ""
        Me.groupNPC2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.groupNPC2.Image = Nothing
        Me.groupNPC2.Location = New System.Drawing.Point(379, 235)
        Me.groupNPC2.Name = "groupNPC2"
        Me.groupNPC2.NoRounding = False
        Me.groupNPC2.Size = New System.Drawing.Size(393, 135)
        Me.groupNPC2.TabIndex = 1
        Me.groupNPC2.Text = "Nome Segundo NPC"
        Me.groupNPC2.Transparent = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(117, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Você trará discordia a nossa cidade!"
        '
        'btnConversar2
        '
        Me.btnConversar2.Color = System.Drawing.Color.Empty
        Me.btnConversar2.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnConversar2.Customization = ""
        Me.btnConversar2.EnableGlass = True
        Me.btnConversar2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnConversar2.Image = Nothing
        Me.btnConversar2.Location = New System.Drawing.Point(177, 91)
        Me.btnConversar2.Name = "btnConversar2"
        Me.btnConversar2.NoRounding = False
        Me.btnConversar2.Size = New System.Drawing.Size(126, 34)
        Me.btnConversar2.TabIndex = 3
        Me.btnConversar2.Text = "Conversar"
        Me.btnConversar2.Transparent = False
        '
        'foto2
        '
        Me.foto2.Location = New System.Drawing.Point(11, 30)
        Me.foto2.Name = "foto2"
        Me.foto2.Size = New System.Drawing.Size(100, 95)
        Me.foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto2.TabIndex = 1
        Me.foto2.TabStop = False
        '
        'groupNPC1
        '
        Me.groupNPC1.Colors = New LynderWorld.Bloom(-1) {}
        Me.groupNPC1.Controls.Add(Me.lblMsgFerreiro)
        Me.groupNPC1.Controls.Add(Me.btnConversar1)
        Me.groupNPC1.Controls.Add(Me.foto1)
        Me.groupNPC1.Customization = ""
        Me.groupNPC1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.groupNPC1.Image = Nothing
        Me.groupNPC1.Location = New System.Drawing.Point(379, 94)
        Me.groupNPC1.Name = "groupNPC1"
        Me.groupNPC1.NoRounding = False
        Me.groupNPC1.Size = New System.Drawing.Size(393, 135)
        Me.groupNPC1.TabIndex = 0
        Me.groupNPC1.Text = "Nome Primeiro NPC"
        Me.groupNPC1.Transparent = False
        '
        'lblMsgFerreiro
        '
        Me.lblMsgFerreiro.AutoSize = True
        Me.lblMsgFerreiro.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgFerreiro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgFerreiro.ForeColor = System.Drawing.Color.White
        Me.lblMsgFerreiro.Location = New System.Drawing.Point(117, 41)
        Me.lblMsgFerreiro.Name = "lblMsgFerreiro"
        Me.lblMsgFerreiro.Size = New System.Drawing.Size(258, 18)
        Me.lblMsgFerreiro.TabIndex = 6
        Me.lblMsgFerreiro.Text = "Nojento saia de nossa cidade!"
        '
        'btnConversar1
        '
        Me.btnConversar1.Color = System.Drawing.Color.Empty
        Me.btnConversar1.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnConversar1.Customization = ""
        Me.btnConversar1.EnableGlass = True
        Me.btnConversar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnConversar1.Image = Nothing
        Me.btnConversar1.Location = New System.Drawing.Point(177, 91)
        Me.btnConversar1.Name = "btnConversar1"
        Me.btnConversar1.NoRounding = False
        Me.btnConversar1.Size = New System.Drawing.Size(126, 34)
        Me.btnConversar1.TabIndex = 2
        Me.btnConversar1.Text = "Conversar"
        Me.btnConversar1.Transparent = False
        '
        'foto1
        '
        Me.foto1.Location = New System.Drawing.Point(11, 30)
        Me.foto1.Name = "foto1"
        Me.foto1.Size = New System.Drawing.Size(100, 95)
        Me.foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto1.TabIndex = 1
        Me.foto1.TabStop = False
        '
        'Bar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bar"
        Me.Text = "Bar"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupNPC3.ResumeLayout(False)
        Me.groupNPC3.PerformLayout()
        CType(Me.foto3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupNPC2.ResumeLayout(False)
        Me.groupNPC2.PerformLayout()
        CType(Me.foto2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupNPC1.ResumeLayout(False)
        Me.groupNPC1.PerformLayout()
        CType(Me.foto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents groupNPC3 As LynderWorld.GhostGroupBox
    Friend WithEvents groupNPC2 As LynderWorld.GhostGroupBox
    Friend WithEvents groupNPC1 As LynderWorld.GhostGroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVoltar As LynderWorld.GhostButton
    Friend WithEvents btnConversar3 As LynderWorld.GhostButton
    Friend WithEvents foto3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConversar2 As LynderWorld.GhostButton
    Friend WithEvents foto2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConversar1 As LynderWorld.GhostButton
    Friend WithEvents foto1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMsgFerreiro As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
