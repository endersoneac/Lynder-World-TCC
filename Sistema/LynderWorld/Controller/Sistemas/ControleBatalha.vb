Public Class ControleBatalha

    Dim sorte As Random = New Random

    Public Function ataqueNormal(ByVal jogador As PersonagemModel, ByVal monstro As MonstroModel) As Integer
        Dim dano, maximo, minimo, Defesa, def As Integer

        minimo = (jogador.nivel * 5) + (jogador.nvArma * 4)
        maximo = (jogador.nivel * 7) + (jogador.nvArma * 4)
        def = sorte.Next(0, monstro.nivel * 7)
        Defesa = (def \ monstro.vida) ^ 3

        dano = sorte.Next(minimo, maximo)
        dano = dano - Defesa
        Return dano
    End Function

    Public Function ataqueMonstro(ByVal monstro As MonstroModel, ByVal per As PersonagemModel) As Integer
        Dim dano, maximo, minimo As Integer

        minimo = (monstro.nivel * 5) + (monstro.ataque ^ 3)
        maximo = (monstro.nivel * 7) + (monstro.ataque ^ 4)

        dano = sorte.Next(minimo, maximo)
        dano = dano - (per.nvEquip * 3)
        Return dano
    End Function
    Public Function calcularExp(ByVal monstro As MonstroModel) As Integer
        Dim exp As Integer
        exp = (monstro.nivel * 80) \ 2
        Return exp
    End Function

    Public Function calcularDinheiro(ByVal monstro As MonstroModel) As Integer
        Dim din As Integer
        din = (monstro.nivel * 100) \ 2
        Return din
    End Function
    Public Function verificarMagia(ByVal per As PersonagemModel) As String()
        Dim magia(6) As String
        Dim nivel As Integer = per.nivel
        If nivel >= 5 And nivel < 10 Then
            magia = {"Golpe Fulminante", "Ataque das Laminas"}
        ElseIf nivel >= 10 And nivel < 20 Then
            magia = {"Golpe Fulminante", "Ataque das Laminas", "Sombras Destruidoras"}
        ElseIf nivel >= 20 And nivel < 30 Then
            magia = {"Golpe Fulminante", "Ataque das Laminas", "Sombras Destruidoras", "Mestre das Sombras"}
        ElseIf nivel >= 30 And nivel < 40 Then
            magia = {"Golpe Fulminante", "Ataque das Laminas", "Sombras Destruidoras", "Mestre das Sombras", "Laminas Velozes"}
        ElseIf nivel >= 50 Then
            magia = {"Golpe Fulminante", "Ataque das Laminas", "Sombras Destruidoras", "Mestre das Sombras", "Laminas Velozes", "Golpe Brutal"}
        End If
        Return magia
    End Function
    Public Function danoMagia(ByVal num As Integer) As Integer
        Dim dano As Integer
        Select Case num
            Case 1
                dano = 50
            Case 2
                dano = 120
            Case 3
                dano = 240
            Case 4
                dano = 500
            Case 5
                dano = 1000
            Case 6
                dano = 3000
            Case Else
                dano = 0
        End Select

        Return dano
    End Function






End Class
