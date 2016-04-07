Imports MySql.Data.MySqlClient

Public Class UsuarioDAO
    Dim objDAO As New DAO

    Function Buscar(ByVal usuario As String, ByVal senha As String) As MySqlDataReader
        Dim sql As String = "select idUser, login, senha, nome, email, ativo from usuario where login = '" & usuario & "' and senha = '" & senha & "';"
        Return objDAO.retornoDataReader(sql)
    End Function
End Class
