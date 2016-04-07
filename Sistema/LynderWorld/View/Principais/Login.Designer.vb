<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.GhostButton1 = New LynderWorld.GhostButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSair = New LynderWorld.GhostButton()
        Me.btnEntrar = New LynderWorld.GhostButton()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.GhostTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.GhostButton1)
        Me.GhostTheme1.Controls.Add(Me.Label2)
        Me.GhostTheme1.Controls.Add(Me.Label1)
        Me.GhostTheme1.Controls.Add(Me.PictureBox1)
        Me.GhostTheme1.Controls.Add(Me.btnSair)
        Me.GhostTheme1.Controls.Add(Me.btnEntrar)
        Me.GhostTheme1.Controls.Add(Me.txtSenha)
        Me.GhostTheme1.Controls.Add(Me.txtLogin)
        Me.GhostTheme1.Customization = ""
        Me.GhostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GhostTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostTheme1.Image = Nothing
        Me.GhostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.GhostTheme1.Movable = True
        Me.GhostTheme1.Name = "GhostTheme1"
        Me.GhostTheme1.NoRounding = False
        Me.GhostTheme1.ShowIcon = False
        Me.GhostTheme1.Sizable = False
        Me.GhostTheme1.Size = New System.Drawing.Size(338, 362)
        Me.GhostTheme1.SmartBounds = True
        Me.GhostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GhostTheme1.TabIndex = 0
        Me.GhostTheme1.Text = "Login - Lynder World"
        Me.GhostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.Transparent = False
        '
        'GhostButton1
        '
        Me.GhostButton1.Color = System.Drawing.Color.Empty
        Me.GhostButton1.Colors = New LynderWorld.Bloom(-1) {}
        Me.GhostButton1.Customization = ""
        Me.GhostButton1.EnableGlass = True
        Me.GhostButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton1.Image = Nothing
        Me.GhostButton1.Location = New System.Drawing.Point(127, 313)
        Me.GhostButton1.Name = "GhostButton1"
        Me.GhostButton1.NoRounding = False
        Me.GhostButton1.Size = New System.Drawing.Size(84, 26)
        Me.GhostButton1.TabIndex = 7
        Me.GhostButton1.Text = "Registrar"
        Me.GhostButton1.Transparent = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LynderWorld.My.Resources.Resources.EvilHard
        Me.PictureBox1.Location = New System.Drawing.Point(33, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Color = System.Drawing.Color.Empty
        Me.btnSair.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnSair.Customization = ""
        Me.btnSair.EnableGlass = True
        Me.btnSair.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSair.Image = Nothing
        Me.btnSair.Location = New System.Drawing.Point(223, 313)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.NoRounding = False
        Me.btnSair.Size = New System.Drawing.Size(84, 26)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.Transparent = False
        '
        'btnEntrar
        '
        Me.btnEntrar.Color = System.Drawing.Color.Empty
        Me.btnEntrar.Colors = New LynderWorld.Bloom(-1) {}
        Me.btnEntrar.Customization = ""
        Me.btnEntrar.EnableGlass = True
        Me.btnEntrar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnEntrar.Image = Nothing
        Me.btnEntrar.Location = New System.Drawing.Point(31, 313)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.NoRounding = False
        Me.btnEntrar.Size = New System.Drawing.Size(84, 26)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.Transparent = False
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(32, 265)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSenha.Size = New System.Drawing.Size(276, 20)
        Me.txtSenha.TabIndex = 1
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(32, 210)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(276, 20)
        Me.txtLogin.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 362)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.GhostTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As LynderWorld.GhostTheme
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSair As LynderWorld.GhostButton
    Friend WithEvents btnEntrar As LynderWorld.GhostButton
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GhostButton1 As LynderWorld.GhostButton
End Class
