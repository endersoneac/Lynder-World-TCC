Imports MySql.Data.MySqlClient

Public Class PersonagemDAO
    Dim objDAO As New DAO

    Function Buscar(ByVal idUser As Integer, ByVal slot As Integer) As MySqlDataReader
        Dim sql As String = "select * from personagem where idUser = '" & idUser & "' and slot = '" & slot & "';"
        Return objDAO.retornoDataReader(sql)
    End Function

End Class
