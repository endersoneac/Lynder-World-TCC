Imports MySql.Data.MySqlClient

Public Class PersonagemController
    Dim objDAO As New PersonagemDAO

    Function verificarPersonagem(ByVal per As PersonagemModel) As Boolean
        Dim pers As New PersonagemModel
        pers = per

        If pers.cod = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function carregarSlot(ByVal id As Integer, ByVal slot As Integer) As PersonagemModel
        Dim perc As New PersonagemModel
        Try
            Dim dr As MySqlDataReader = objDAO.Buscar(id, slot)

            While dr.Read()
                perc.cod = dr.Item(0)
                perc.nome = dr.Item(1)
                perc.nivel = dr.Item(2)
                perc.expert = dr.Item(3)
                perc.nvArma = dr.Item(4)
                perc.nvEquip = dr.Item(5)
                perc.dinheiro = dr.Item(6)
                perc.Aparencia = dr.Item(7)
                perc.cidade = dr.Item(8)
                perc.vidaAtual = dr.Item(9)
                perc.manaAtual = dr.Item(10)
                perc.PCuraPeq = dr.Item(11)
                perc.PCuraGra = dr.Item(12)
                perc.PManaPeq = dr.Item(13)
                perc.PManaGra = dr.Item(14)
                perc.PSuprema = dr.Item(15)
                perc.coduser = dr.Item(16)
                perc.slot = dr.Item(17)
                perc.durArma = dr.Item(18)
                perc.durEquip = dr.Item(19)
            End While

            Return perc
        Catch ex As Exception
            Return Nothing
            Throw ex
        End Try
    End Function

    Public Function gerarNovo(ByVal pers As PersonagemModel) As Boolean
        Try
            Dim per As New PersonagemModel

            'Automatico
            per.nome = pers.nome
            per.Aparencia = pers.Aparencia
            per.nivel = 1
            per.nvEquip = 1
            per.nvArma = 1
            per.PCuraPeq = 1
            per.PCuraGra = 0
            per.PManaGra = 0
            per.PManaPeq = 1
            per.PSuprema = 0

            per.cidade = 0

            per.slot = pers.slot
            per.coduser = pers.coduser

            'calculos
            per.expert = 1
            per.expTotal = calcularExperiencia(per.nivel)
            per.vidaAtual = calcularVida(per.nivel, per.nvEquip)
            per.manaAtual = calcularMana(per.nivel, per.nvArma)
            per.mana = per.manaAtual
            per.vida = per.vidaAtual
            per.durArma = 100
            per.durEquip = 100

            objDAO.inserirDAO(per)

            Return True

        Catch ex As Exception
            Throw ex
            Return False
        End Try


    End Function

    Function calcularVida(ByVal nivel As Integer, ByVal nvArmadura As Integer) As Integer
        Dim total As Integer = 0

        total = nivel * 47
        total += nvArmadura * 53

        Return total
    End Function

    Function calcularExperiencia(ByVal nivel As Integer) As Integer
        Dim exp As Integer

        exp = ((50 * nivel + 97) * nivel)

        Return exp
    End Function

    Function calcularMana(ByVal nivel As Integer, ByVal nvArma As Integer) As Integer
        Dim mana

        mana = nivel * 29
        mana += nvArma * 35

        Return mana
    End Function

    Public Function deletar(ByVal personagem As PersonagemModel) As Boolean
        Return objDAO.deleteDAO(personagem)
    End Function

    Public Function verificarImagem(ByVal aparencia As Integer) As Image

        Select Case aparencia
            Case 1
                Return My.Resources.per1
            Case 2
                Return My.Resources.per2
            Case 3
                Return My.Resources.per3
            Case 4
                Return My.Resources.per4
            Case 5
                Return My.Resources.per5
            Case 6
                Return My.Resources.per6
            Case Else
                Return My.Resources.faceA
        End Select

    End Function

    Public Function verificaNivel(ByVal personagem As PersonagemModel) As PersonagemModel
        If personagem.expert >= personagem.expTotal Then
            personagem.nivel += 1
            personagem.expTotal = calcularExperiencia(personagem.nivel)
        End If

        Return personagem
    End Function


    Public Function salvar(ByVal per As PersonagemModel) As Boolean
        Try
            objDAO.updateDAO(per)
            Return True
        Catch ex As Exception
            Return False
            Throw ex
        End Try
    End Function

End Class
