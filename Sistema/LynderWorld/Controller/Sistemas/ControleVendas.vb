Public Class ControleVendas

    Public Function comprarPequenaHP(ByVal per As PersonagemModel) As PersonagemModel
        If per.dinheiro >= 100 Then
            If per.PCuraPeq < 50 Then
                per.dinheiro -= 100
                per.PCuraPeq += 1
            Else
                Dim msg As New mensagemform("Poções em excesso! você não pode comprar mais!")
                msg.ShowDialog()
                per.PCuraPeq = 50
            End If
        Else
            Dim msg As New mensagemform("Dinheiro insuficiente para comprar poções!")
            msg.ShowDialog()
        End If
        Return per
    End Function

    Public Function comprarGrandeHP(ByVal per As PersonagemModel) As PersonagemModel
        If per.dinheiro >= 500 Then
            If per.PCuraGra < 50 Then
                per.dinheiro -= 500
                per.PCuraGra += 1
            Else
                Dim msg As New mensagemform("Poções em excesso! você não pode comprar mais!")
                msg.ShowDialog()
                per.PCuraGra = 50
            End If
        Else
            Dim msg As New mensagemform("Dinheiro insuficiente para comprar poções!")
            msg.ShowDialog()
        End If
        Return per
    End Function

    Public Function comprarPequenaMP(ByVal per As PersonagemModel) As PersonagemModel
        If per.dinheiro >= 100 Then
            If per.PManaPeq < 50 Then
                per.dinheiro -= 100
                per.PManaPeq += 1
            Else
                Dim msg As New mensagemform("Poções em excesso! você não pode comprar mais!")
                msg.ShowDialog()
                per.PManaPeq = 50
            End If
        Else
            Dim msg As New mensagemform("Dinheiro insuficiente para comprar poções!")
            msg.ShowDialog()
        End If
        Return per
    End Function

    Public Function comprarGrandeMP(ByVal per As PersonagemModel) As PersonagemModel
        If per.dinheiro >= 500 Then
            If per.PManaGra < 50 Then
                per.dinheiro -= 500
                per.PManaGra += 1
            Else
                Dim msg As New mensagemform("Poções em excesso! você não pode comprar mais!")
                msg.ShowDialog()
                per.PManaGra = 50
            End If
        Else
            Dim msg As New mensagemform("Dinheiro insuficiente para comprar poções!")
            msg.ShowDialog()
        End If
        Return per
    End Function

    Public Function comprarSuprema(ByVal per As PersonagemModel) As PersonagemModel
        If per.dinheiro >= 10000 Then
            If per.PSuprema < 50 Then
                per.dinheiro -= 10000
                per.PSuprema += 1
            Else
                Dim msg As New mensagemform("Poções em excesso! você não pode comprar mais!")
                msg.ShowDialog()
                per.PSuprema = 50
            End If
        Else
            Dim msg As New mensagemform("Dinheiro insuficiente para comprar poções!")
            msg.ShowDialog()
        End If
        Return per
    End Function


    Public Function venderPequenaHP(ByVal per As PersonagemModel) As PersonagemModel
        If per.PCuraPeq > 0 Then
            per.dinheiro += 50
            per.PCuraPeq -= 1
        Else
            Dim msg As New mensagemform("Poções insuficientes para efetuar a venda!")
            msg.ShowDialog()
            per.PCuraPeq = 0
        End If
        Return per
    End Function

    Public Function venderGrandeHP(ByVal per As PersonagemModel) As PersonagemModel
        If per.PCuraGra > 0 Then
            per.dinheiro += 250
            per.PCuraGra -= 1
        Else
            Dim msg As New mensagemform("Poções insuficientes para efetuar a venda!")
            msg.ShowDialog()
            per.PCuraGra = 0
        End If
        Return per
    End Function

    Public Function venderPequenaMP(ByVal per As PersonagemModel) As PersonagemModel
        If per.PManaPeq > 0 Then
            per.dinheiro += 50
            per.PManaPeq -= 1
        Else
            Dim msg As New mensagemform("Poções insuficientes para efetuar a venda!")
            msg.ShowDialog()
            per.PManaPeq = 0
        End If
        Return per
    End Function

    Public Function venderGrandeMP(ByVal per As PersonagemModel) As PersonagemModel
        If per.PManaGra > 0 Then
            per.dinheiro += 250
            per.PManaGra -= 1
        Else
            Dim msg As New mensagemform("Poções insuficientes para efetuar a venda!")
            msg.ShowDialog()
            per.PManaGra = 0
        End If
        Return per
    End Function

    Public Function venderSuprema(ByVal per As PersonagemModel) As PersonagemModel
        If per.PSuprema > 0 Then
            per.dinheiro += 3000
            per.PSuprema -= 1
        Else
            Dim msg As New mensagemform("Poções insuficientes para efetuar a venda!")
            msg.ShowDialog()
            per.PSuprema = 0
        End If
        Return per
    End Function


    Public Function dormir(ByVal per As PersonagemModel) As PersonagemModel
        Dim custo As Integer = (((per.mana - per.manaAtual) + (per.vida - per.vidaAtual * 2)) \ 4) * 7
        If custo < 0 Then
            custo *= -1
        End If
        If per.vidaAtual <= 0 Then
            Dim msg As New mensagemform("Não é necessário descançar!")
            msg.ShowDialog()
        Else
            If per.dinheiro >= custo Then
                Dim msg As New mensagemform("Você deseja descançar ao custo de: " & custo & " ?", True)
                msg.ShowDialog()
                If msg.verificarBotao() Then
                    Dim curado As New mensagemform("Curado com Sucesso!")
                    curado.ShowDialog()
                    per.manaAtual = per.mana
                    per.vidaAtual = per.vida
                    per.dinheiro -= custo
                End If
            Else
                Dim msg As New mensagemform("Dinheiro insuficiente para descansar!")
                msg.ShowDialog()
            End If
        End If
        Return per
    End Function
End Class
