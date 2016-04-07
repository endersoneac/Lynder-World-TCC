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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.lblMana = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblVmax = New System.Windows.Forms.Label()
        Me.lblMMax = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pequena"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 52)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Media"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(35, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 52)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Pequena"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(102, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 52)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Media"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vida"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(226, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mana"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Vida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mana:"
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.Location = New System.Drawing.Point(58, 25)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(19, 13)
        Me.lblVida.TabIndex = 8
        Me.lblVida.Text = "10"
        '
        'lblMana
        '
        Me.lblMana.AutoSize = True
        Me.lblMana.Location = New System.Drawing.Point(58, 58)
        Me.lblMana.Name = "lblMana"
        Me.lblMana.Size = New System.Drawing.Size(19, 13)
        Me.lblMana.TabIndex = 9
        Me.lblMana.Text = "10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "/"
        '
        'lblVmax
        '
        Me.lblVmax.AutoSize = True
        Me.lblVmax.Location = New System.Drawing.Point(103, 24)
        Me.lblVmax.Name = "lblVmax"
        Me.lblVmax.Size = New System.Drawing.Size(31, 13)
        Me.lblVmax.TabIndex = 12
        Me.lblVmax.Text = "1000"
        '
        'lblMMax
        '
        Me.lblMMax.AutoSize = True
        Me.lblMMax.Location = New System.Drawing.Point(104, 57)
        Me.lblMMax.Name = "lblMMax"
        Me.lblMMax.Size = New System.Drawing.Size(31, 13)
        Me.lblMMax.TabIndex = 13
        Me.lblMMax.Text = "1000"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(188, 189)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 52)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Suprema"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 266)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lblMMax)
        Me.Controls.Add(Me.lblVmax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMana)
        Me.Controls.Add(Me.lblVida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Public WithEvents lblVmax As System.Windows.Forms.Label
    Public WithEvents lblMMax As System.Windows.Forms.Label
    Public WithEvents lblVida As System.Windows.Forms.Label
    Public WithEvents lblMana As System.Windows.Forms.Label

End Class
