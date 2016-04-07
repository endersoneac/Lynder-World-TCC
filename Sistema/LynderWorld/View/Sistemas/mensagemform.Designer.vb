<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mensagemform
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
        Me.btnNao = New LynderWorld.GhostButton()
        Me.btnSim = New LynderWorld.GhostButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.btnConfirmar = New LynderWorld.GhostButton()
        Me.GhostTheme1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.btnNao)
        Me.GhostTheme1.Controls.Add(Me.btnSim)
        Me.GhostTheme1.Controls.Add(Me.Panel1)
        Me.GhostTheme1.Controls.Add(Me.btnConfirmar)
        Me.GhostTheme1.Customization = ""
        Me.GhostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GhostTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostTheme1.Image = Nothing
        Me.GhostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.GhostTheme1.Movable = False
        Me.GhostTheme1.Name = "GhostTheme1"
        Me.GhostTheme1.NoRounding = False
        Me.GhostTheme1.ShowIcon = False
        Me.GhostTheme1.Sizable = False
        Me.GhostTheme1.Size = New System.Drawing.Size(450, 195)
        Me.GhostTheme1.SmartBounds = True
        Me.GhostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GhostTheme1.TabIndex = 0
        Me.GhostTheme1.Text = "Lynder World"
        Me.GhostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.Transparent = False
        '
        'btnNao
        '
        Me.btnNao.Color = System.Drawing.Color.Empty
        Me.btnNao.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnNao.Customization = ""
        Me.btnNao.EnableGlass = True
        Me.btnNao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNao.Image = Nothing
        Me.btnNao.Location = New System.Drawing.Point(229, 155)
        Me.btnNao.Name = "btnNao"
        Me.btnNao.NoRounding = False
        Me.btnNao.Size = New System.Drawing.Size(90, 28)
        Me.btnNao.TabIndex = 4
        Me.btnNao.Text = "Não"
        Me.btnNao.Transparent = False
        Me.btnNao.Visible = False
        '
        'btnSim
        '
        Me.btnSim.Color = System.Drawing.Color.Empty
        Me.btnSim.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnSim.Customization = ""
        Me.btnSim.EnableGlass = True
        Me.btnSim.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSim.Image = Nothing
        Me.btnSim.Location = New System.Drawing.Point(132, 155)
        Me.btnSim.Name = "btnSim"
        Me.btnSim.NoRounding = False
        Me.btnSim.Size = New System.Drawing.Size(90, 28)
        Me.btnSim.TabIndex = 3
        Me.btnSim.Text = "Sim"
        Me.btnSim.Transparent = False
        Me.btnSim.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblMensagem)
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 121)
        Me.Panel1.TabIndex = 2
        '
        'lblMensagem
        '
        Me.lblMensagem.BackColor = System.Drawing.Color.Transparent
        Me.lblMensagem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.ForeColor = System.Drawing.Color.White
        Me.lblMensagem.Location = New System.Drawing.Point(-4, 7)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(147, 18)
        Me.lblMensagem.TabIndex = 0
        Me.lblMensagem.Text = "Mensagem Aquiii"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Color = System.Drawing.Color.Empty
        Me.btnConfirmar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnConfirmar.Customization = ""
        Me.btnConfirmar.EnableGlass = True
        Me.btnConfirmar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnConfirmar.Image = Nothing
        Me.btnConfirmar.Location = New System.Drawing.Point(348, 155)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.NoRounding = False
        Me.btnConfirmar.Size = New System.Drawing.Size(90, 28)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.Transparent = False
        '
        'mensagemform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 195)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mensagemform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mensagemform"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents btnConfirmar As LynderWorld.GhostButton
    Public WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNao As LynderWorld.GhostButton
    Friend WithEvents btnSim As LynderWorld.GhostButton
End Class
