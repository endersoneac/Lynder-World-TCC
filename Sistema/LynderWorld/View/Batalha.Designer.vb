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
        Me.listItem = New LynderWorld.GhostListBoxPretty()
        Me.listMagia = New LynderWorld.GhostListBoxPretty()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDesistir = New LynderWorld.GhostButton()
        Me.GhostButton3 = New LynderWorld.GhostButton()
        Me.btnMagia = New LynderWorld.GhostButton()
        Me.btnAtacar = New LynderWorld.GhostButton()
        Me.GhostGroupBox2 = New LynderWorld.GhostGroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Thief3ProgressBar3 = New LynderWorld.Thief3ProgressBar()
        Me.Thief3ProgressBar4 = New LynderWorld.Thief3ProgressBar()
        Me.GhostGroupBox1 = New LynderWorld.GhostGroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Thief3ProgressBar2 = New LynderWorld.Thief3ProgressBar()
        Me.Thief3ProgressBar1 = New LynderWorld.Thief3ProgressBar()
        Me.GhostTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GhostGroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GhostGroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.listItem)
        Me.GhostTheme1.Controls.Add(Me.listMagia)
        Me.GhostTheme1.Controls.Add(Me.PictureBox1)
        Me.GhostTheme1.Controls.Add(Me.btnDesistir)
        Me.GhostTheme1.Controls.Add(Me.GhostButton3)
        Me.GhostTheme1.Controls.Add(Me.btnMagia)
        Me.GhostTheme1.Controls.Add(Me.btnAtacar)
        Me.GhostTheme1.Controls.Add(Me.GhostGroupBox2)
        Me.GhostTheme1.Controls.Add(Me.GhostGroupBox1)
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
        Me.listItem.Colors = New LynderWorld.Bloom(-1) {}
        Me.listItem.Customization = ""
        Me.listItem.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.listItem.Image = Nothing
        Me.listItem.Items = New String() {"Poção de Cura", "Poção de Mana", "Poção Suprema"}
        Me.listItem.Location = New System.Drawing.Point(389, 413)
        Me.listItem.Name = "listItem"
        Me.listItem.NoRounding = False
        Me.listItem.Size = New System.Drawing.Size(145, 67)
        Me.listItem.TabIndex = 7
        Me.listItem.Text = "GhostListBoxPretty2"
        Me.listItem.Transparent = False
        Me.listItem.Visible = False
        '
        'listMagia
        '
        Me.listMagia.Colors = New LynderWorld.Bloom(-1) {}
        Me.listMagia.Customization = ""
        Me.listMagia.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.listMagia.Image = Nothing
        Me.listMagia.Items = New String() {"Golpe Fulminante", "Ataque das Laminas", "Sombras Destruidoras", "Mestre das Sombras", "Laminas Velozes", "Golpe Brutal"}
        Me.listMagia.Location = New System.Drawing.Point(250, 355)
        Me.listMagia.Name = "listMagia"
        Me.listMagia.NoRounding = False
        Me.listMagia.Size = New System.Drawing.Size(145, 125)
        Me.listMagia.TabIndex = 6
        Me.listMagia.Text = "GhostListBoxPretty1"
        Me.listMagia.Transparent = False
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
        'GhostButton3
        '
        Me.GhostButton3.Color = System.Drawing.Color.Empty
        Me.GhostButton3.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostButton3.Customization = ""
        Me.GhostButton3.EnableGlass = True
        Me.GhostButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton3.Image = Nothing
        Me.GhostButton3.Location = New System.Drawing.Point(407, 486)
        Me.GhostButton3.Name = "GhostButton3"
        Me.GhostButton3.NoRounding = False
        Me.GhostButton3.Size = New System.Drawing.Size(109, 32)
        Me.GhostButton3.TabIndex = 4
        Me.GhostButton3.Text = "Item"
        Me.GhostButton3.Transparent = False
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
        'GhostGroupBox2
        '
        Me.GhostGroupBox2.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostGroupBox2.Controls.Add(Me.PictureBox3)
        Me.GhostGroupBox2.Controls.Add(Me.Thief3ProgressBar3)
        Me.GhostGroupBox2.Controls.Add(Me.Thief3ProgressBar4)
        Me.GhostGroupBox2.Customization = ""
        Me.GhostGroupBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostGroupBox2.Image = Nothing
        Me.GhostGroupBox2.Location = New System.Drawing.Point(438, 40)
        Me.GhostGroupBox2.Name = "GhostGroupBox2"
        Me.GhostGroupBox2.NoRounding = False
        Me.GhostGroupBox2.Size = New System.Drawing.Size(304, 402)
        Me.GhostGroupBox2.TabIndex = 1
        Me.GhostGroupBox2.Text = "Monstro"
        Me.GhostGroupBox2.Transparent = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(72, 77)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 135)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
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
        'Thief3ProgressBar4
        '
        Me.Thief3ProgressBar4.Image = Nothing
        Me.Thief3ProgressBar4.Location = New System.Drawing.Point(19, 338)
        Me.Thief3ProgressBar4.Maximum = 0
        Me.Thief3ProgressBar4.Name = "Thief3ProgressBar4"
        Me.Thief3ProgressBar4.NoRounding = False
        Me.Thief3ProgressBar4.Size = New System.Drawing.Size(267, 16)
        Me.Thief3ProgressBar4.TabIndex = 2
        Me.Thief3ProgressBar4.Text = "Thief3ProgressBar4"
        Me.Thief3ProgressBar4.Value = 1
        '
        'GhostGroupBox1
        '
        Me.GhostGroupBox1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostGroupBox1.Controls.Add(Me.PictureBox2)
        Me.GhostGroupBox1.Controls.Add(Me.Thief3ProgressBar2)
        Me.GhostGroupBox1.Controls.Add(Me.Thief3ProgressBar1)
        Me.GhostGroupBox1.Customization = ""
        Me.GhostGroupBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostGroupBox1.Image = Nothing
        Me.GhostGroupBox1.Location = New System.Drawing.Point(42, 40)
        Me.GhostGroupBox1.Name = "GhostGroupBox1"
        Me.GhostGroupBox1.NoRounding = False
        Me.GhostGroupBox1.Size = New System.Drawing.Size(304, 402)
        Me.GhostGroupBox1.TabIndex = 0
        Me.GhostGroupBox1.Text = "Jogador"
        Me.GhostGroupBox1.Transparent = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(66, 77)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 135)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Thief3ProgressBar2
        '
        Me.Thief3ProgressBar2.Image = Nothing
        Me.Thief3ProgressBar2.Location = New System.Drawing.Point(19, 373)
        Me.Thief3ProgressBar2.Maximum = 0
        Me.Thief3ProgressBar2.Name = "Thief3ProgressBar2"
        Me.Thief3ProgressBar2.NoRounding = False
        Me.Thief3ProgressBar2.Size = New System.Drawing.Size(267, 16)
        Me.Thief3ProgressBar2.TabIndex = 1
        Me.Thief3ProgressBar2.Text = "Thief3ProgressBar2"
        Me.Thief3ProgressBar2.Value = 1
        '
        'Thief3ProgressBar1
        '
        Me.Thief3ProgressBar1.Image = Nothing
        Me.Thief3ProgressBar1.Location = New System.Drawing.Point(19, 338)
        Me.Thief3ProgressBar1.Maximum = 0
        Me.Thief3ProgressBar1.Name = "Thief3ProgressBar1"
        Me.Thief3ProgressBar1.NoRounding = False
        Me.Thief3ProgressBar1.Size = New System.Drawing.Size(267, 16)
        Me.Thief3ProgressBar1.TabIndex = 0
        Me.Thief3ProgressBar1.Text = "Thief3ProgressBar1"
        Me.Thief3ProgressBar1.Value = 1
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
        Me.GhostGroupBox2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GhostGroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents btnDesistir As LynderWorld.GhostButton
    Friend WithEvents GhostButton3 As LynderWorld.GhostButton
    Friend WithEvents btnMagia As LynderWorld.GhostButton
    Friend WithEvents btnAtacar As LynderWorld.GhostButton
    Friend WithEvents GhostGroupBox2 As LynderWorld.GhostGroupBox
    Friend WithEvents GhostGroupBox1 As LynderWorld.GhostGroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Thief3ProgressBar3 As LynderWorld.Thief3ProgressBar
    Friend WithEvents Thief3ProgressBar4 As LynderWorld.Thief3ProgressBar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Thief3ProgressBar2 As LynderWorld.Thief3ProgressBar
    Friend WithEvents Thief3ProgressBar1 As LynderWorld.Thief3ProgressBar
    Friend WithEvents listItem As LynderWorld.GhostListBoxPretty
    Friend WithEvents listMagia As LynderWorld.GhostListBoxPretty
End Class
