Public Class ControleConversa
    Dim mensagem(4) As String
    Dim sorte As Random = New Random

    Public Function retornaMensagens() As String()
        gerarMensagem()

        Return mensagem
    End Function

    Public Sub gerarMensagem()
        Dim msg As Integer = sorte.Next(0, 5)
        Select Case msg
            Case 1
                mensagem(0) = "Bom dia senhor!"
                mensagem(1) = "Saia daqui visitante!"
                mensagem(2) = "Tudo bem..."
                mensagem(3) = "e não volte mais!"
                mensagem(4) = "não voltarei."
            Case 2
                mensagem(0) = "Olá senhor!"
                mensagem(1) = "Você é um forasteiro, não pode ficar aqui!"
                mensagem(2) = "ta bom estou indo."
                mensagem(3) = "e não volte mais!"
                mensagem(4) = "não voltarei."
            Case 3
                mensagem(0) = "Bom dia, poderia me dar uma informação?"
                mensagem(1) = "Gostaria de te ajudar, mas não posso..."
                mensagem(2) = "ta bom estou indo."
                mensagem(3) = "e não volte mais!"
                mensagem(4) = "não voltarei."
            Case 4
                mensagem(0) = "Bom dia senhor!"
                mensagem(1) = "Bom dia, poderia me dar uma esmola?"
                mensagem(2) = "Não tenho nada no momento."
                mensagem(3) = "e então suma de minha vila!"
                mensagem(4) = "ok."
            Case Else
                mensagem(0) = "Bom dia senhor!"
                mensagem(1) = "Bom dia, poderia me dar uma esmola?"
                mensagem(2) = "Não tenho nada no momento."
                mensagem(3) = "e então suma de minha vila!"
                mensagem(4) = "ok."
        End Select


    End Sub



End Class
