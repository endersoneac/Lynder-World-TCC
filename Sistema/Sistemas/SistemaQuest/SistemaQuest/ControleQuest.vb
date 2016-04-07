Public Class ControleQuest

    Public Function pegarQuest(ByVal quest As questModel, ByVal codigo As Integer) As questModel
        Dim questX As New questModel
        Select Case quest.idQuest
            Case 0
                questX.idQuest = 1
                questX.monstro = 1
                questX.qtdMonstro = 3
                questX.cidade = 0
                questX.npc = "Jão Tetão"
                questX.codPersonagem = codigo
                Return questX
            Case 1
                questX.idQuest = 2
                questX.monstro = 2
                questX.qtdMonstro = 5
                questX.cidade = 0
                questX.npc = "Jão Tetão"
                questX.codPersonagem = codigo
                Return questX
            Case 2
                questX.idQuest = 3
                questX.monstro = 3
                questX.qtdMonstro = 10
                questX.cidade = 0
                questX.npc = "Graviola"
                questX.codPersonagem = codigo
                Return questX
            Case Else
                questX.idQuest = 0
                Return questX
        End Select

        Return questX
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
End Class
