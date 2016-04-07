Imports MySql.Data.MySqlClient

Public Class PersonagemDAO
    Dim objDAO As New DAO

    Function Buscar(ByVal idUser As Integer, ByVal slot As Integer) As MySqlDataReader
        Dim sql As String = "select * from personagem where idUser = '" & idUser & "' and slot = '" & slot & "';"
        Return objDAO.retornoDataReader(sql)
    End Function

    'Inserção no banco
    Function inserirDAO(ByVal personagem As PersonagemModel) As Boolean
        Dim SQL As String = "insert into personagem(nome, nivel, experiencia, nvArma, nvEquip, dinheiro, aparencia, cidade, vidaAtual, manaAtual, PocaoHPP, PocaoHPG, PocaoMPP, PocaoMPG, PocaoSS, codUser, slot)" & _
                           " values(@nome, @nivel, @experiencia, @nvArma, @nvEquip, @dinheiro, @aparencia, @cidade, @vidaAtual, @manaAtual, @PocaoHPP, @PocaoHPG, @PocaoMPP, @PocaoMPG, @PocaoSS, @codUser, @slot)"
        Dim objDAO As New DAO
        Try
            objDAO.conexao.Open()
            objDAO.comando = objDAO.comandoMySQL(objDAO.conexao, SQL)

            objDAO.comando.Parameters.Add(New MySqlParameter("@nome", MySqlDbType.VarChar, 45))
            objDAO.comando.Parameters.Add(New MySqlParameter("@nivel", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@nvArma", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@nvEquip", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@dinheiro", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@aparencia", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@cidade", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@vidaAtual", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@manaAtual", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@PocaoHPP", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@PocaoHPG", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@PocaoMPP", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@PocaoMPG", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@PocaoSS", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@codUser", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@slot", MySqlDbType.Int32))

            objDAO.comando.Parameters("@nome").Value = personagem.nome
            objDAO.comando.Parameters("@nivel").Value = personagem.nivel
            objDAO.comando.Parameters("@nvArma").Value = personagem.nvArma
            objDAO.comando.Parameters("@nvEquip").Value = personagem.nvEquip
            objDAO.comando.Parameters("@dinheiro").Value = personagem.dinheiro
            objDAO.comando.Parameters("@cidade").Value = personagem.cidade
            objDAO.comando.Parameters("@vidaAtual").Value = personagem.vidaAtual
            objDAO.comando.Parameters("@manaAtual").Value = personagem.manaAtual
            objDAO.comando.Parameters("@PocaoHPP").Value = personagem.PCuraPeq
            objDAO.comando.Parameters("@PocaoHPG").Value = personagem.PCuraGra
            objDAO.comando.Parameters("@PocaoMPP").Value = personagem.PManaPeq
            objDAO.comando.Parameters("@PocaoMPG").Value = personagem.PManaGra
            objDAO.comando.Parameters("@PocaoSS").Value = personagem.PSuprema
            objDAO.comando.Parameters("@codUser").Value = personagem.coduser
            objDAO.comando.Parameters("@slot").Value = personagem.slot


            objDAO.comando.ExecuteNonQuery()
            objDAO.comando.Parameters.Clear()
            Return True

        Catch ex As Exception
            Throw ex
            Return False
        Finally
            objDAO.conexao.Close()
        End Try
    End Function




End Class
