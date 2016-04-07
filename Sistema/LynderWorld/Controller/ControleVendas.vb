Public Class ControleVendas
    Dim val As New Validacao
    Dim din As New Dinheiro
    Public Function comprarPequenaHP(ByVal per As PersonagemModel) As PersonagemModel
        If din.verificarDinheiro() > 100 Then
            If per.PCuraPeq < 50 Then
                per.PCuraPeq = per.PCuraPeq + 1
            Else
                val.validarMensagem("Poções em excesso! você não pode comprar mais, use algumas.")
                per.PCuraPeq = 50
            End If
        Else
            val.validarMensagem("Dinheiro insuficiente para comprar poções!")
        End If
        Return per
    End Function

    Public Function comprarGrandeHP(ByVal per As PersonagemModel) As PersonagemModel
        If din.verificarDinheiro() > 500 Then
            If per.PCuraGra < 50 Then
                din.perderDinheiro(500)
                per.PCuraGra = per.PCuraGra + 1
            Else
                val.validarMensagem("Poções em excesso! você não pode comprar mais, use algumas.")
                per.PCuraGra = 50
            End If
        Else
            val.validarMensagem("Dinheiro insuficiente para comprar poções!")
        End If
        Return per
    End Function

    Public Function comprarPequenaMP(ByVal per As PersonagemModel) As PersonagemModel
        If din.verificarDinheiro() > 100 Then
            If per.PManaPeq < 50 Then
                din.perderDinheiro(100)
                per.PManaPeq = per.PManaPeq + 1
            Else
                val.validarMensagem("Poções em excesso! você não pode comprar mais, use algumas.")
                per.PManaPeq = 50
            End If
        Else
            val.validarMensagem("Dinheiro insuficiente para comprar poções!")
        End If
        Return per
    End Function

    Public Function comprarGrandeMP(ByVal per As PersonagemModel) As PersonagemModel
        If din.verificarDinheiro() > 500 Then
            If per.PManaGra < 50 Then
                din.perderDinheiro(500)
                per.PManaGra = per.PManaGra + 1
            Else
                val.validarMensagem("Poções em excesso! você não pode comprar mais, use algumas.")
                per.PManaGra = 50
            End If
        Else
            val.validarMensagem("Dinheiro insuficiente para comprar poções!")
        End If
        Return per
    End Function

    Public Function dormir(ByVal per As PersonagemModel) As PersonagemModel
        If din.verificarDinheiro() > 50 Then
            din.perderDinheiro(50)

        Else
            val.validarMensagem("Dinheiro insuficiente para pagar a estadia!")
        End If
        Return per
    End Function

End Class
