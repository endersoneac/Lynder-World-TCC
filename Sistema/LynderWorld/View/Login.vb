Public Class Login
    Dim val As New UsuarioController
    Dim user As New UsuarioModel

    Sub validar()
        Try
            user = val.validarAcesso(txtLogin.Text, txtSenha.Text)
            If Not user.nome = "" Then
                Dim load As New Loading(user)
                load.Show()
                Me.Hide()
            Else
                Dim msg As New mensagemform("Acesso negado!" & vbCrLf & "Verifique as informações e tente novamente.")
                msg.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim msg As New mensagemform("Erro ao tentar conectar ao servidor!")
            msg.ShowDialog()
        End Try
    End Sub


    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub GhostButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton1.Click
        System.Diagnostics.Process.Start("http://localhost/lynder/registro.html")
        'System.Diagnostics.Process.Start("C:/xampp/htdocs/lynder/registro.html")
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        validar()
    End Sub

    Private Sub Login_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    'Validar ao pressionar Enter
    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown, txtLogin.KeyDown
        If e.KeyCode = Keys.Return Then
            validar()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' My.Computer.Audio.Play(My.Resources.principal, AudioPlayMode.BackgroundLoop)
        Me.Icon = My.Resources.favicon
    End Sub
End Class