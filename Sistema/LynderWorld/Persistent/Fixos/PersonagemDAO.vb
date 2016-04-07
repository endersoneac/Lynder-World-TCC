Imports MySql.Data.MySqlClient

Public Class PersonagemDAO
    Dim objDAO As New DAO

    Function Buscar(ByVal codUser As Integer, ByVal slot As Integer) As MySqlDataReader
        Dim sql As String = "select * from personagem where codUser = '" & codUser & "' and slot = '" & slot & "';"
        Return objDAO.retornoDataReader(sql)
    End Function

    'Inserção no banco
    Function inserirDAO(ByVal personagem As PersonagemModel) As Boolean
        Dim SQL As String = "insert into personagem(nome, nivel, experiencia, nvArma, nvEquip, dinheiro, aparencia, cidade, vidaAtual, manaAtual, PocaoHPP, PocaoHPG, PocaoMPP, PocaoMPG, PocaoSS, codUser, slot, durArma, durEquip)" & _
                           " values(@nome, @nivel, @experiencia, @nvArma, @nvEquip, @dinheiro, @aparencia, @cidade, @vidaAtual, @manaAtual, @PocaoHPP, @PocaoHPG, @PocaoMPP, @PocaoMPG, @PocaoSS, @codUser, @slot, @durArma, @durEquip)"
        Try
            Dim objDAO As New DAO

            objDAO.conexao.Open()
            objDAO.comando = objDAO.comandoMySQL(objDAO.conexao, SQL)

            objDAO.comando.Parameters.Add(New MySqlParameter("@nome", MySqlDbType.VarChar, 45))
            objDAO.comando.Parameters.Add(New MySqlParameter("@nivel", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@experiencia", MySqlDbType.Int32))
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
            objDAO.comando.Parameters.Add(New MySqlParameter("@durArma", MySqlDbType.Int32))
            objDAO.comando.Parameters.Add(New MySqlParameter("@durEquip", MySqlDbType.Int32))

            objDAO.comando.Parameters("@nome").Value = personagem.nome
            objDAO.comando.Parameters("@nivel").Value = personagem.nivel
            objDAO.comando.Parameters("@experiencia").Value = personagem.expert
            objDAO.comando.Parameters("@nvArma").Value = personagem.nvArma
            objDAO.comando.Parameters("@nvEquip").Value = personagem.nvEquip
            objDAO.comando.Parameters("@dinheiro").Value = personagem.dinheiro
            objDAO.comando.Parameters("@aparencia").Value = personagem.Aparencia
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
            objDAO.comando.Parameters("@durArma").Value = personagem.durArma
            objDAO.comando.Parameters("@durEquip").Value = personagem.durEquip

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

    Function updateDAO(ByVal personagem As PersonagemModel) As Boolean
        Dim SQL As String = "Update personagem" & _
                            " set nome = '" & personagem.nome & "'," & _
                            " nivel = '" & personagem.nivel & "'," & _
                            " experiencia = '" & personagem.expert & "'," & _
                            " nvArma = '" & personagem.nvArma & "'," & _
                            " nvEquip = '" & personagem.nvEquip & "'," & _
                            " dinheiro = '" & personagem.dinheiro & "'," & _
                            " cidade = '" & personagem.cidade & "'," & _
                            " vidaAtual = '" & personagem.vidaAtual & "'," & _
                            " manaAtual = '" & personagem.manaAtual & "'," & _
                            " PocaoHPP = '" & personagem.PCuraPeq & "'," & _
                            " PocaoHPG = '" & personagem.PCuraGra & "'," & _
                            " PocaoMPP = '" & personagem.PManaPeq & "'," & _
                            " PocaoMPG = '" & personagem.PManaGra & "'," & _
                            " PocaoSS = '" & personagem.PSuprema & "'," & _
                            " codUser = '" & personagem.coduser & "'," & _
                            " slot = '" & personagem.slot & "'," & _
                            " durArma = '" & personagem.durArma & "'," & _
                            " durEquip = '" & personagem.durEquip & "'" & _
                            " where idPersonagem = " & personagem.cod

        Try
            objdao.conexao.Open()
            objdao.comando = objdao.comandoMySQL(objdao.conexao, SQL)
            objdao.comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            If objdao.conexao.State = ConnectionState.Open Then
                objdao.conexao.Close()
            End If
        End Try
    End Function

    Function deleteDAO(ByVal personagem As PersonagemModel) As Boolean
        Dim SQL As String = "delete from personagem where idpersonagem = " & personagem.cod
        Try
            objdao.conexao.Open()
            objdao.comando = objdao.comandoMySQL(objdao.conexao, SQL)
            objdao.comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception
            Return False
        Finally
            If objdao.conexao.State = ConnectionState.Open Then
                objdao.conexao.Close()
            End If
        End Try
    End Function


End Class
