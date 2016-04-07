Imports MySql.Data.MySqlClient

Public Class Validacao
    Dim verificar As New UsuarioDAO
    Dim vLogin, vSenha As String
    Public idUser As Integer = 0

    Public Function validarLogin(ByVal login As String, ByVal senha As String) As Boolean

        If login = "admin" And senha = "123" Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function validarAcesso(ByVal login As String, ByVal senha As String) As Integer

        Dim dr As MySqlDataReader = verificar.Buscar(login, senha)

        While dr.Read()
            idUser = dr.Item(0)
            vLogin = dr.Item(1)
            vSenha = dr.Item(2)
        End While

        If vLogin = login And vSenha = senha Then
            Return idUser
        Else
            Return -1
        End If

    End Function

    Public Sub validarMensagem(ByVal mensagem As String)
        Dim msg As New mensagemform
        msg.lblMensagem.Text = mensagem
        msg.ShowDialog()
    End Sub

End Class
