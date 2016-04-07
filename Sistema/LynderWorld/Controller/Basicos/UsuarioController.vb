Imports MySql.Data.MySqlClient

Public Class UsuarioController
    Dim userDAO As New UsuarioDAO
    Dim user As New UsuarioModel

    Public Function validarAcesso(ByVal login As String, ByVal senha As String) As UsuarioModel

        Try
            Dim dr As MySqlDataReader = userDAO.Buscar(login, senha)

            While dr.Read()
                user.codigo = dr.Item(0)
                user.login = dr.Item(1)
                user.senha = dr.Item(2)
                user.nome = dr.Item(3)
                user.email = dr.Item(4)
                user.ativo = dr.Item(5)
            End While

            If user.login = login And user.senha = senha Then
                Return user
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            Throw ex
        End Try


    End Function

End Class
