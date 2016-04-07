Imports MySql.Data.MySqlClient

Public Class QuestController
    Public Function carregarQuest(ByVal personagem As PersonagemModel) As questModel
        Dim quest As New questModel
        Dim objdao As New QuestDAO
        Try
            Dim dr As MySqlDataReader = objdao.Buscar(personagem.cod)

            While dr.Read()
                quest.idQuest = dr.Item(0)
                quest.codPersonagem = dr.Item(1)
                quest.monstro = dr.Item(2)
                quest.qtdMonstro = dr.Item(3)
            End While

            Return quest
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Function gerarNovo(ByVal personagem As Integer) As questModel
        Try
            Dim objDAO As New QuestDAO
            Dim per As New PersonagemModel
            Dim quest As New questModel

            quest.idQuest = 0
            quest.qtdMonstro = 0
            quest.codPersonagem = personagem
            quest.monstro = 0

            objDAO.inserirDAO(quest)

            Return quest

        Catch ex As Exception
            Throw ex

        End Try
    End Function
End Class
