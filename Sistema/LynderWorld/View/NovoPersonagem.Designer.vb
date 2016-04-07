<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoPersonagem
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
        Me.fotinhoMarota = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listaAparencia = New LynderWorld.GhostListboxLessPretty()
        Me.btnCancelar = New LynderWorld.GhostButton()
        Me.btnConfirmar = New LynderWorld.GhostButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New LynderWorld.GhostTextBox()
        Me.GhostTheme1.SuspendLayout()
        CType(Me.fotinhoMarota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.fotinhoMarota)
        Me.GhostTheme1.Controls.Add(Me.Label2)
        Me.GhostTheme1.Controls.Add(Me.listaAparencia)
        Me.GhostTheme1.Controls.Add(Me.btnCancelar)
        Me.GhostTheme1.Controls.Add(Me.btnConfirmar)
        Me.GhostTheme1.Controls.Add(Me.Label1)
        Me.GhostTheme1.Controls.Add(Me.txtNome)
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
        'fotinhoMarota
        '
        Me.fotinhoMarota.BackColor = System.Drawing.SystemColors.Control
        Me.fotinhoMarota.Image = Global.LynderWorld.My.Resources.Resources.per5
        Me.fotinhoMarota.Location = New System.Drawing.Point(402, 211)
        Me.fotinhoMarota.Name = "fotinhoMarota"
        Me.fotinhoMarota.Size = New System.Drawing.Size(130, 123)
        Me.fotinhoMarota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotinhoMarota.TabIndex = 6
        Me.fotinhoMarota.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(253, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Aparência:"
        '
        'listaAparencia
        '
        Me.listaAparencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.listaAparencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listaAparencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.listaAparencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.listaAparencia.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.listaAparencia.FormattingEnabled = True
        Me.listaAparencia.IntegralHeight = False
        Me.listaAparencia.ItemHeight = 20
        Me.listaAparencia.Items.AddRange(New Object() {"Masculino 1", "Masculino 2", "Masculino 3", "Feminino 1", "Feminino 2", "Feminino 3"})
        Me.listaAparencia.Location = New System.Drawing.Point(256, 211)
        Me.listaAparencia.Name = "listaAparencia"
        Me.listaAparencia.Size = New System.Drawing.Size(120, 123)
        Me.listaAparencia.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Color = System.Drawing.Color.Empty
        Me.btnCancelar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnCancelar.Customization = ""
        Me.btnCancelar.EnableGlass = True
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCancelar.Image = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(647, 511)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.NoRounding = False
        Me.btnCancelar.Size = New System.Drawing.Size(107, 29)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Transparent = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Color = System.Drawing.Color.Empty
        Me.btnConfirmar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnConfirmar.Customization = ""
        Me.btnConfirmar.EnableGlass = True
        Me.btnConfirmar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnConfirmar.Image = Nothing
        Me.btnConfirmar.Location = New System.Drawing.Point(31, 511)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.NoRounding = False
        Me.btnConfirmar.Size = New System.Drawing.Size(107, 29)
        Me.btnConfirmar.TabIndex = 2
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do personagem:"
        '
        'txtNome
        '
        Me.txtNome.Customization = "/////wAAAP8AAAD/Wlpa/w=="
        Me.txtNome.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtNome.Image = Nothing
        Me.txtNome.Location = New System.Drawing.Point(132, 127)
        Me.txtNome.MaxLength = 15
        Me.txtNome.Multiline = False
        Me.txtNome.Name = "txtNome"
        Me.txtNome.NoRounding = False
        Me.txtNome.ReadOnly = False
        Me.txtNome.Size = New System.Drawing.Size(523, 24)
        Me.txtNome.TabIndex = 0
        Me.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNome.Transparent = False
        Me.txtNome.UseSystemPasswordChar = False
        '
        'NovoPersonagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NovoPersonagem"
        Me.Text = "NovoPersonagem"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.GhostTheme1.PerformLayout()
        CType(Me.fotinhoMarota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents fotinhoMarota As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listaAparencia As LynderWorld.GhostListboxLessPretty
    Friend WithEvents btnCancelar As LynderWorld.GhostButton
    Friend WithEvents btnConfirmar As LynderWorld.GhostButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNome As LynderWorld.GhostTextBox
End Class
