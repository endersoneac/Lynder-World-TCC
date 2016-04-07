Imports MySql.Data.MySqlClient

Public Class LoadingController
    Dim perc As New PersonagemModel
    Dim pDAO As New PersonagemDAO
    Public Function carregarSlot(ByVal id As Integer, ByVal slot As Integer) As PersonagemModel

        Try
            Dim dr As MySqlDataReader = pDAO.Buscar(id, slot)

            While dr.Read()
                perc.cod = dr.Item(0)
                perc.coduser = dr.Item(1)
                perc.nome = dr.Item(2)
                perc.nivel = dr.Item(3)
                perc.dinheiro = dr.Item(4)
                perc.expert = dr.Item(5)
                perc.nvArma = dr.Item(6)
                perc.nvEquip = dr.Item(7)
                perc.Aparencia = dr.Item(8)
                perc.PCuraPeq = dr.Item(9)
                perc.PCuraGra = dr.Item(10)
                perc.PManaPeq = dr.Item(11)
                perc.PManaGra = dr.Item(12)
                perc.PSuprema = dr.Item(13)
                perc.cidade = dr.Item(14)
                perc.slot = dr.Item(15)
            End While

            Return perc
        Catch ex As Exception
            Return Nothing
            Throw ex
        End Try


    End Function

End Class
