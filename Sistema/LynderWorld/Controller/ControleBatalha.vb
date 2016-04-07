Public Class ControleBatalha

    Dim sorte As Random = New Random
    Dim mob As New MonstroModel
    Dim per As New PersonagemModel

    Public Function ataqueNormal(ByVal jogador As PersonagemModel) As Integer
        Dim dano, maximo, minimo As Integer

        minimo = (jogador.nivel * 5) + (jogador.nvArma ^ 3)
        maximo = (jogador.nivel * 7) + (jogador.nvArma ^ 3)

        dano = sorte.Next(minimo, maximo)
        dano = dano - mob.defesa
        Return dano
    End Function

    Public Function ataqueMonstro(ByVal monstro As MonstroModel) As Integer
        Dim dano, maximo, minimo As Integer

        minimo = (monstro.nivel * 5) + (monstro.ataque ^ 3)
        maximo = (monstro.nivel * 7) + (monstro.ataque ^ 3)

        dano = sorte.Next(minimo, maximo)
        dano = dano - (per.nvEquip * 3)
        Return dano
    End Function



End Class
