Imports MySql.Data.MySqlClient
Public Class login
    Dim dao As New DAO
    Function Buscar(usuario As String, senha As String) As MySqlDataReader
        Dim sql As String = "select login, senha from usuario where login = '" & usuario & "' and senha = '" & senha & "';"
        Return dao.retornoDataReader(sql)
    End Function



End Class
