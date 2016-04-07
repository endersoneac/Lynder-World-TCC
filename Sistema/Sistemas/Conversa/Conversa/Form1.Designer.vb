<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblNomeNPC = New System.Windows.Forms.Label()
        Me.lblNomePersonagem = New System.Windows.Forms.Label()
        Me.fotoPersonagem = New System.Windows.Forms.PictureBox()
        Me.fotoNPC = New System.Windows.Forms.PictureBox()
        Me.lblNomeConversa = New System.Windows.Forms.Label()
        Me.lblConversa = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.fotoPersonagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoNPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNomeNPC
        '
        Me.lblNomeNPC.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeNPC.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeNPC.ForeColor = System.Drawing.Color.White
        Me.lblNomeNPC.Location = New System.Drawing.Point(442, 220)
        Me.lblNomeNPC.Name = "lblNomeNPC"
        Me.lblNomeNPC.Size = New System.Drawing.Size(228, 18)
        Me.lblNomeNPC.TabIndex = 11
        Me.lblNomeNPC.Text = "Nome Personagem"
        Me.lblNomeNPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNomePersonagem
        '
        Me.lblNomePersonagem.BackColor = System.Drawing.Color.Transparent
        Me.lblNomePersonagem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomePersonagem.ForeColor = System.Drawing.Color.White
        Me.lblNomePersonagem.Location = New System.Drawing.Point(115, 220)
        Me.lblNomePersonagem.Name = "lblNomePersonagem"
        Me.lblNomePersonagem.Size = New System.Drawing.Size(228, 18)
        Me.lblNomePersonagem.TabIndex = 10
        Me.lblNomePersonagem.Text = "Nome Personagem"
        Me.lblNomePersonagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fotoPersonagem
        '
        Me.fotoPersonagem.Location = New System.Drawing.Point(154, 62)
        Me.fotoPersonagem.Name = "fotoPersonagem"
        Me.fotoPersonagem.Size = New System.Drawing.Size(150, 140)
        Me.fotoPersonagem.TabIndex = 8
        Me.fotoPersonagem.TabStop = False
        '
        'fotoNPC
        '
        Me.fotoNPC.Location = New System.Drawing.Point(481, 62)
        Me.fotoNPC.Name = "fotoNPC"
        Me.fotoNPC.Size = New System.Drawing.Size(150, 140)
        Me.fotoNPC.TabIndex = 7
        Me.fotoNPC.TabStop = False
        '
        'lblNomeConversa
        '
        Me.lblNomeConversa.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeConversa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeConversa.ForeColor = System.Drawing.Color.White
        Me.lblNomeConversa.Location = New System.Drawing.Point(194, 446)
        Me.lblNomeConversa.Name = "lblNomeConversa"
        Me.lblNomeConversa.Size = New System.Drawing.Size(397, 26)
        Me.lblNomeConversa.TabIndex = 12
        Me.lblNomeConversa.Text = "Nome Personagem"
        Me.lblNomeConversa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConversa
        '
        Me.lblConversa.BackColor = System.Drawing.Color.Transparent
        Me.lblConversa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversa.ForeColor = System.Drawing.Color.White
        Me.lblConversa.Location = New System.Drawing.Point(88, 338)
        Me.lblConversa.Name = "lblConversa"
        Me.lblConversa.Size = New System.Drawing.Size(609, 108)
        Me.lblConversa.TabIndex = 9
        Me.lblConversa.Text = "Nome Personagem"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "proximo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNomeNPC)
        Me.Controls.Add(Me.lblNomePersonagem)
        Me.Controls.Add(Me.fotoPersonagem)
        Me.Controls.Add(Me.fotoNPC)
        Me.Controls.Add(Me.lblNomeConversa)
        Me.Controls.Add(Me.lblConversa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fotoPersonagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoNPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNomeNPC As System.Windows.Forms.Label
    Friend WithEvents lblNomePersonagem As System.Windows.Forms.Label
    Friend WithEvents fotoPersonagem As System.Windows.Forms.PictureBox
    Friend WithEvents fotoNPC As System.Windows.Forms.PictureBox
    Friend WithEvents lblNomeConversa As System.Windows.Forms.Label
    Friend WithEvents lblConversa As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
