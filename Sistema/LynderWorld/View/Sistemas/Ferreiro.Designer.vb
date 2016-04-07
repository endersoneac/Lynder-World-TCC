<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ferreiro
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
        Me.lblDinheiro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMsgFerreiro = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GhostButton2 = New LynderWorld.GhostButton()
        Me.groupEquip = New LynderWorld.GhostGroupBox()
        Me.lblNvArma = New System.Windows.Forms.Label()
        Me.lblArma = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAprimorarArma = New LynderWorld.GhostButton()
        Me.btnRepararArma = New LynderWorld.GhostButton()
        Me.GhostGroupBox1 = New LynderWorld.GhostGroupBox()
        Me.lblNvEquip = New System.Windows.Forms.Label()
        Me.lblEquip = New System.Windows.Forms.Label()
        Me.btnAprimorarEquip = New LynderWorld.GhostButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRepararEquip = New LynderWorld.GhostButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GhostTheme1.SuspendLayout()
        Me.groupEquip.SuspendLayout()
        Me.GhostGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.lblDinheiro)
        Me.GhostTheme1.Controls.Add(Me.Label4)
        Me.GhostTheme1.Controls.Add(Me.lblMsgFerreiro)
        Me.GhostTheme1.Controls.Add(Me.lblTitulo)
        Me.GhostTheme1.Controls.Add(Me.GhostButton2)
        Me.GhostTheme1.Controls.Add(Me.groupEquip)
        Me.GhostTheme1.Controls.Add(Me.GhostGroupBox1)
        Me.GhostTheme1.Controls.Add(Me.PictureBox1)
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
        Me.GhostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GhostTheme1.TabIndex = 0
        Me.GhostTheme1.Text = "Lynder World"
        Me.GhostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.Transparent = False
        '
        'lblDinheiro
        '
        Me.lblDinheiro.AutoSize = True
        Me.lblDinheiro.BackColor = System.Drawing.Color.Transparent
        Me.lblDinheiro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinheiro.ForeColor = System.Drawing.Color.White
        Me.lblDinheiro.Location = New System.Drawing.Point(445, 180)
        Me.lblDinheiro.Name = "lblDinheiro"
        Me.lblDinheiro.Size = New System.Drawing.Size(50, 16)
        Me.lblDinheiro.TabIndex = 7
        Me.lblDinheiro.Text = "------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(373, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dinheiro:"
        '
        'lblMsgFerreiro
        '
        Me.lblMsgFerreiro.AutoSize = True
        Me.lblMsgFerreiro.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgFerreiro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgFerreiro.ForeColor = System.Drawing.Color.White
        Me.lblMsgFerreiro.Location = New System.Drawing.Point(178, 115)
        Me.lblMsgFerreiro.Name = "lblMsgFerreiro"
        Me.lblMsgFerreiro.Size = New System.Drawing.Size(429, 18)
        Me.lblMsgFerreiro.TabIndex = 5
        Me.lblMsgFerreiro.Text = "O que você deseja em minha oficina, forasteiro!?!?"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(3, 55)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(293, 44)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Ferreiro de Morgambar"
        '
        'GhostButton2
        '
        Me.GhostButton2.Color = System.Drawing.Color.Empty
        Me.GhostButton2.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostButton2.Customization = ""
        Me.GhostButton2.EnableGlass = True
        Me.GhostButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton2.Image = Nothing
        Me.GhostButton2.Location = New System.Drawing.Point(667, 520)
        Me.GhostButton2.Name = "GhostButton2"
        Me.GhostButton2.NoRounding = False
        Me.GhostButton2.Size = New System.Drawing.Size(105, 30)
        Me.GhostButton2.TabIndex = 3
        Me.GhostButton2.Text = "Voltar"
        Me.GhostButton2.Transparent = False
        '
        'groupEquip
        '
        Me.groupEquip.Colors = New LynderWorld.Bloom(-1) {}
        Me.groupEquip.Controls.Add(Me.lblNvArma)
        Me.groupEquip.Controls.Add(Me.lblArma)
        Me.groupEquip.Controls.Add(Me.Label3)
        Me.groupEquip.Controls.Add(Me.Label2)
        Me.groupEquip.Controls.Add(Me.btnAprimorarArma)
        Me.groupEquip.Controls.Add(Me.btnRepararArma)
        Me.groupEquip.Customization = ""
        Me.groupEquip.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.groupEquip.Image = Nothing
        Me.groupEquip.Location = New System.Drawing.Point(376, 199)
        Me.groupEquip.Name = "groupEquip"
        Me.groupEquip.NoRounding = False
        Me.groupEquip.Size = New System.Drawing.Size(384, 133)
        Me.groupEquip.TabIndex = 2
        Me.groupEquip.Text = "Espadas e Armas"
        Me.groupEquip.Transparent = False
        '
        'lblNvArma
        '
        Me.lblNvArma.AutoSize = True
        Me.lblNvArma.BackColor = System.Drawing.Color.Transparent
        Me.lblNvArma.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNvArma.ForeColor = System.Drawing.Color.White
        Me.lblNvArma.Location = New System.Drawing.Point(344, 4)
        Me.lblNvArma.Name = "lblNvArma"
        Me.lblNvArma.Size = New System.Drawing.Size(32, 16)
        Me.lblNvArma.TabIndex = 5
        Me.lblNvArma.Text = "999"
        '
        'lblArma
        '
        Me.lblArma.AutoSize = True
        Me.lblArma.BackColor = System.Drawing.Color.Transparent
        Me.lblArma.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArma.ForeColor = System.Drawing.Color.White
        Me.lblArma.Location = New System.Drawing.Point(236, 80)
        Me.lblArma.Name = "lblArma"
        Me.lblArma.Size = New System.Drawing.Size(29, 16)
        Me.lblArma.TabIndex = 4
        Me.lblArma.Text = "---"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(265, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "/ 100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(180, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Resistência:"
        '
        'btnAprimorarArma
        '
        Me.btnAprimorarArma.Color = System.Drawing.Color.Empty
        Me.btnAprimorarArma.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnAprimorarArma.Customization = ""
        Me.btnAprimorarArma.EnableGlass = True
        Me.btnAprimorarArma.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAprimorarArma.Image = Nothing
        Me.btnAprimorarArma.Location = New System.Drawing.Point(42, 43)
        Me.btnAprimorarArma.Name = "btnAprimorarArma"
        Me.btnAprimorarArma.NoRounding = False
        Me.btnAprimorarArma.Size = New System.Drawing.Size(111, 30)
        Me.btnAprimorarArma.TabIndex = 1
        Me.btnAprimorarArma.Text = "Refinar"
        Me.btnAprimorarArma.Transparent = False
        '
        'btnRepararArma
        '
        Me.btnRepararArma.Color = System.Drawing.Color.Empty
        Me.btnRepararArma.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnRepararArma.Customization = ""
        Me.btnRepararArma.EnableGlass = True
        Me.btnRepararArma.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnRepararArma.Image = Nothing
        Me.btnRepararArma.Location = New System.Drawing.Point(42, 79)
        Me.btnRepararArma.Name = "btnRepararArma"
        Me.btnRepararArma.NoRounding = False
        Me.btnRepararArma.Size = New System.Drawing.Size(111, 30)
        Me.btnRepararArma.TabIndex = 0
        Me.btnRepararArma.Text = "Reparar"
        Me.btnRepararArma.Transparent = False
        '
        'GhostGroupBox1
        '
        Me.GhostGroupBox1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostGroupBox1.Controls.Add(Me.lblNvEquip)
        Me.GhostGroupBox1.Controls.Add(Me.lblEquip)
        Me.GhostGroupBox1.Controls.Add(Me.btnAprimorarEquip)
        Me.GhostGroupBox1.Controls.Add(Me.Label5)
        Me.GhostGroupBox1.Controls.Add(Me.btnRepararEquip)
        Me.GhostGroupBox1.Controls.Add(Me.Label6)
        Me.GhostGroupBox1.Customization = ""
        Me.GhostGroupBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostGroupBox1.Image = Nothing
        Me.GhostGroupBox1.Location = New System.Drawing.Point(376, 338)
        Me.GhostGroupBox1.Name = "GhostGroupBox1"
        Me.GhostGroupBox1.NoRounding = False
        Me.GhostGroupBox1.Size = New System.Drawing.Size(384, 133)
        Me.GhostGroupBox1.TabIndex = 1
        Me.GhostGroupBox1.Text = "Equipamentos"
        Me.GhostGroupBox1.Transparent = False
        '
        'lblNvEquip
        '
        Me.lblNvEquip.AutoSize = True
        Me.lblNvEquip.BackColor = System.Drawing.Color.Transparent
        Me.lblNvEquip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNvEquip.ForeColor = System.Drawing.Color.White
        Me.lblNvEquip.Location = New System.Drawing.Point(344, 4)
        Me.lblNvEquip.Name = "lblNvEquip"
        Me.lblNvEquip.Size = New System.Drawing.Size(32, 16)
        Me.lblNvEquip.TabIndex = 6
        Me.lblNvEquip.Text = "999"
        '
        'lblEquip
        '
        Me.lblEquip.AutoSize = True
        Me.lblEquip.BackColor = System.Drawing.Color.Transparent
        Me.lblEquip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquip.ForeColor = System.Drawing.Color.White
        Me.lblEquip.Location = New System.Drawing.Point(236, 85)
        Me.lblEquip.Name = "lblEquip"
        Me.lblEquip.Size = New System.Drawing.Size(29, 16)
        Me.lblEquip.TabIndex = 7
        Me.lblEquip.Text = "---"
        '
        'btnAprimorarEquip
        '
        Me.btnAprimorarEquip.Color = System.Drawing.Color.Empty
        Me.btnAprimorarEquip.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnAprimorarEquip.Customization = ""
        Me.btnAprimorarEquip.EnableGlass = True
        Me.btnAprimorarEquip.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAprimorarEquip.Image = Nothing
        Me.btnAprimorarEquip.Location = New System.Drawing.Point(40, 43)
        Me.btnAprimorarEquip.Name = "btnAprimorarEquip"
        Me.btnAprimorarEquip.NoRounding = False
        Me.btnAprimorarEquip.Size = New System.Drawing.Size(111, 30)
        Me.btnAprimorarEquip.TabIndex = 3
        Me.btnAprimorarEquip.Text = "Refinar"
        Me.btnAprimorarEquip.Transparent = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(265, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "/ 100"
        '
        'btnRepararEquip
        '
        Me.btnRepararEquip.Color = System.Drawing.Color.Empty
        Me.btnRepararEquip.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnRepararEquip.Customization = ""
        Me.btnRepararEquip.EnableGlass = True
        Me.btnRepararEquip.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnRepararEquip.Image = Nothing
        Me.btnRepararEquip.Location = New System.Drawing.Point(40, 79)
        Me.btnRepararEquip.Name = "btnRepararEquip"
        Me.btnRepararEquip.NoRounding = False
        Me.btnRepararEquip.Size = New System.Drawing.Size(111, 30)
        Me.btnRepararEquip.TabIndex = 2
        Me.btnRepararEquip.Text = "Reparar"
        Me.btnRepararEquip.Transparent = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(180, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Resistência:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LynderWorld.My.Resources.Resources.ferreiro
        Me.PictureBox1.Location = New System.Drawing.Point(24, 199)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 272)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Ferreiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ferreiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ferreiro"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.GhostTheme1.PerformLayout()
        Me.groupEquip.ResumeLayout(False)
        Me.groupEquip.PerformLayout()
        Me.GhostGroupBox1.ResumeLayout(False)
        Me.GhostGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents groupEquip As LynderWorld.GhostGroupBox
    Friend WithEvents btnAprimorarArma As LynderWorld.GhostButton
    Friend WithEvents btnRepararArma As LynderWorld.GhostButton
    Friend WithEvents GhostGroupBox1 As LynderWorld.GhostGroupBox
    Friend WithEvents btnAprimorarEquip As LynderWorld.GhostButton
    Friend WithEvents btnRepararEquip As LynderWorld.GhostButton
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GhostButton2 As LynderWorld.GhostButton
    Friend WithEvents lblNvArma As System.Windows.Forms.Label
    Friend WithEvents lblArma As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNvEquip As System.Windows.Forms.Label
    Friend WithEvents lblEquip As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMsgFerreiro As System.Windows.Forms.Label
    Friend WithEvents lblDinheiro As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
