Public Class GeraNPC
    Dim sorte As Random = New Random
    Dim num As Integer

    Public Function gerarNPC() As NpcModel
        Dim npc As New NpcModel

        npc.nome = gerarNome()
        npc.mensagem = gerarMensagem()
        npc.imagem = gerarImagem()

        Return npc
    End Function

    Private Function gerarImagem() As Image
        num = sorte.Next(0, 5)
        Select Case num
            Case 0
                Return My.Resources.npc1
            Case 1
                Return My.Resources.npc2
            Case 2
                Return My.Resources.npc3
            Case 3
                Return My.Resources.npc4
            Case 4
                Return My.Resources.npc5
            Case Else
                Return My.Resources.faceA
        End Select
    End Function

    Private Function gerarNome() As String
        Dim nome As String
        num = sorte.Next(0, 5)

        Select Case num
            Case 0
                nome = "Gillian"
            Case 1
                nome = "Jack"
            Case 2
                nome = "Jones"
            Case 3
                nome = "Lothar"
            Case 4
                nome = "Razar"
            Case Else
                nome = "Morfeu"
        End Select

        num = sorte.Next(0, 5)

        Select Case num
            Case 0
                nome = nome & " Daewron"
            Case 1
                nome = nome & " Kaldeum"
            Case 2
                nome = nome & " Brakior"
            Case 3
                nome = nome & " Magnus"
            Case 4
                nome = nome & " Deckard"
            Case Else
                nome = nome & " Akaratt"
        End Select

        Return nome
    End Function

    Private Function gerarMensagem() As String()
        Dim mensagem(5) As String
        Dim msg As Integer = sorte.Next(0, 5)

        Select Case msg
            Case 1
                mensagem(1) = "Saia daqui forasteiro, já temos problemas de mais!"
                mensagem(2) = "Não quero gerar discordia, estou indo!"
                mensagem(3) = "Nunca mais volte!"
                mensagem(4) = "Não voltarei."
            Case 2
                mensagem(1) = "Você é um forasteiro, não pode ficar aqui!"
                mensagem(2) = "Já estou indo, covarde."
                mensagem(3) = "Não volte mais!"
                mensagem(4) = "Não voltarei."
            Case 3
                mensagem(1) = "Gostaria de te ajudar, mas não posso..."
                mensagem(2) = "Já estou indo."
                mensagem(3) = "obrigado pela compreensão!"
                mensagem(4) = "Tudo bem."
            Case 4
                mensagem(1) = "Bom dia, poderia me dar uma esmola?"
                mensagem(2) = "Não tenho nada no momento."
                mensagem(3) = "Então suma de minha vila!"
                mensagem(4) = "Tudo bem estou indo."
            Case Else
                mensagem(1) = "Suma de minha vila!"
                mensagem(2) = "Não tenho como fazer isso!"
                mensagem(3) = "Teremos discórdia com você por aqui!"
                mensagem(4) = "Tudo bem, já estou indo."
        End Select

        msg = sorte.Next(0, 6)
        Select Case msg
            Case 1
                mensagem(0) = "Olá senhor!"
            Case 2
                mensagem(0) = "Boa dia senhor!"
            Case 3
                mensagem(0) = "Poderia me dar uma informação?"
            Case 4
                mensagem(0) = "Com licença, poderia me dar uma informação?"
            Case 5
                mensagem(0) = "Você mora por aqui?"
            Case Else
                mensagem(0) = "Poderia me ajudar?"
        End Select

        Return mensagem
    End Function

End Class
