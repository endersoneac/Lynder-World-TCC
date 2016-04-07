Imports MySql.Data.MySqlClient

Public Class QuestDAO
    Dim objDAO As New DAO

    Function Buscar(ByVal personagem As Integer) As MySqlDataReader
        Dim sql As String = "select idQuest, idPersonagem, idMonstro, qtdMonstro from quest where idPersonagem = '" & Personagem & "';"
        Return objDAO.retornoDataReader(sql)
    End Function

    Function inserirDAO(ByVal quest As questModel) As Boolean
        Dim SQL As String = "insert into quest(idQuest, idPersonagem, idMonstro, qtdMonstro)" & _
                           " values(@idQuest, @idPersonagem, @idMonstro, @qtdMonstro)"
        Try
            Dim objDAO As New DAO

            objDAO.conexao.Open()
            objDAO.comando = objDAO.comandoMySQL(objDAO.conexao, SQL)

            objDAO.comando.Parameters.Add(New MySqlParameter("@idQuest", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@idPersonagem", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@idMonstro", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@qtdMonstro", MySqlDbType.Int32))

            objDAO.comando.Parameters("@idQuest").Value = quest.idQuest
            objDAO.comando.Parameters("@idPersonagem").Value = quest.codPersonagem
            objDAO.comando.Parameters("@idMonstro").Value = quest.monstro
            objDAO.comando.Parameters("@qtdMonstro").Value = quest.qtdMonstro

            objDAO.comando.ExecuteNonQuery()
            objDAO.comando.Parameters.Clear()
            Return True

        Catch ex As Exception
            Throw ex
            Return False
        Finally
            If objDAO.conexao.State = ConnectionState.Open Then
                objDAO.conexao.Close()
            End If
        End Try
    End Function

End Class
