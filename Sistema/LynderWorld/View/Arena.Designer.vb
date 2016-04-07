<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arena
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
        Me.lblMsgFerreiro = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listMonstros = New LynderWorld.GhostListBoxPretty()
        Me.btnVoltar = New LynderWorld.GhostButton()
        Me.GhostTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.lblMsgFerreiro)
        Me.GhostTheme1.Controls.Add(Me.PictureBox1)
        Me.GhostTheme1.Controls.Add(Me.Label1)
        Me.GhostTheme1.Controls.Add(Me.listMonstros)
        Me.GhostTheme1.Controls.Add(Me.btnVoltar)
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
        'lblMsgFerreiro
        '
        Me.lblMsgFerreiro.AutoSize = True
        Me.lblMsgFerreiro.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgFerreiro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgFerreiro.ForeColor = System.Drawing.Color.White
        Me.lblMsgFerreiro.Location = New System.Drawing.Point(100, 81)
        Me.lblMsgFerreiro.Name = "lblMsgFerreiro"
        Me.lblMsgFerreiro.Size = New System.Drawing.Size(583, 18)
        Me.lblMsgFerreiro.TabIndex = 7
        Me.lblMsgFerreiro.Text = "Aqui você não terá chance de vitórias, entao prepare-se para morrer!!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(337, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(402, 366)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 44)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Arena de Batalhas"
        '
        'listMonstros
        '
        Me.listMonstros.Colors = New LynderWorld.Bloom(-1) {}
        Me.listMonstros.Customization = ""
        Me.listMonstros.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.listMonstros.Image = Nothing
        Me.listMonstros.Items = New String() {""}
        Me.listMonstros.Location = New System.Drawing.Point(46, 193)
        Me.listMonstros.Name = "listMonstros"
        Me.listMonstros.NoRounding = False
        Me.listMonstros.Size = New System.Drawing.Size(261, 306)
        Me.listMonstros.TabIndex = 2
        Me.listMonstros.Text = "GhostListBoxPretty1"
        Me.listMonstros.Transparent = False
        '
        'btnVoltar
        '
        Me.btnVoltar.Color = System.Drawing.Color.Empty
        Me.btnVoltar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnVoltar.Customization = ""
        Me.btnVoltar.EnableGlass = True
        Me.btnVoltar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnVoltar.Image = Nothing
        Me.btnVoltar.Location = New System.Drawing.Point(650, 518)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.NoRounding = False
        Me.btnVoltar.Size = New System.Drawing.Size(122, 32)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.Transparent = False
        '
        'Arena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Arena"
        Me.Text = "Arena"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.GhostTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents btnVoltar As LynderWorld.GhostButton
    Friend WithEvents listMonstros As LynderWorld.GhostListBoxPretty
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMsgFerreiro As System.Windows.Forms.Label
End Class
