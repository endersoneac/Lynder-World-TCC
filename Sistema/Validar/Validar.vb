Imports MySql.Data.MySqlClient

Public Class Validar
    Dim verificar As New login
    Dim vLogin, vSenha As String

    Public Function validarLogin(ByVal login As String, ByVal senha As String) As Boolean
        Dim dr As MySqlDataReader = verificar.Buscar(login, senha)

        While dr.Read()
            vLogin = dr.Item(0)
            vSenha = dr.Item(1)
        End While

        If vLogin = login And vSenha = senha Then
            carregarInformacoes()
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub carregarInformacoes()

    End Sub

End Class
