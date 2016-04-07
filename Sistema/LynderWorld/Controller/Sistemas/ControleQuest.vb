Public Class ControleQuest

    Public Function pegarQuest(ByVal quest As questModel, ByVal codigo As Integer) As questModel
        Select Case quest.idQuest
            Case 0
                quest.idQuest = 1
                quest.monstro = 1
                quest.qtdMonstro = 3
                quest.cidade = 0
                quest.codPersonagem = codigo
                quest.npc = gerarNPC()
                Return quest
            Case 1
			
            Case Else
        End Select

        Return quest
    End Function

    Public Function verificarQuest(ByVal quest As questModel) As Boolean
        If quest.qtdMonstro = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verificarBatalha(ByVal quest As questModel, ByVal monstro As Integer) As questModel

        If quest.qtdMonstro > 0 And quest.monstro = monstro Then
            quest.qtdMonstro -= 1
        End If

        Return quest
    End Function

    Public Function premiacaoQuest(ByVal quest As questModel, ByVal personagem As PersonagemModel) As PersonagemModel
        Dim per As New PersonagemModel
        quest.dinheiro = 50 * ((2 ^ quest.idQuest) \ 2)
        quest.experiencia = 100 * ((2 ^ quest.idQuest) \ 2)

        per = personagem

        per.expert += quest.experiencia
        per.dinheiro += quest.dinheiro

        Return per
    End Function

    Public Function gerarNPC() As NpcModel
        Dim npc As New NpcModel

        'Select Case 
        ' Case 1
        Dim mensagem(9) As String
        npc.nome = "Drake Stonp"
        npc.imagem = My.Resources.ferreiro
        mensagem(0) = "Olá, poderia me ajudar?"
        mensagem(1) = "Diga logo o que quer."
        mensagem(2) = "Como eu poderia ajudar vocês?"
        mensagem(3) = "Primeiro acabe com estes bandidos que se dizem soldados!"
        mensagem(4) = "Tudo bem, mas e depois?"
        mensagem(5) = "Consiga a armadura de Lynder e derrote o reino de meredin."
        mensagem(6) = "Onde consigo esta armadura senhor?"
        mensagem(7) = "Eu não sei, você terá de descobrir sozinho!"
        mensagem(8) = "Agora acabe com estes 5 soldados bandidos que nos roubam..."

        npc.mensagem = mensagem
        ' Case 2
        ' Case 3
        '  Case 4
        '  Case 5
        '  Case 6
        '  Case 7
        '  Case 8
        '  Case 9
        '  Case 10
        '   Case 11
        '   Case 12
        '   Case 13
        '   Case 14
        '   Case 15
        '   Case Else
        ' End Select


        Return npc
    End Function

End Class
