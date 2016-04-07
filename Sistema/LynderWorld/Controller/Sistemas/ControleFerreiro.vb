Public Class ControleFerreiro
    Function repararArma(ByVal per As PersonagemModel) As PersonagemModel
        Dim custo As Integer = ((100 - per.durArma) * (per.nvArma + 5)) \ 4

        If per.durArma = 100 Then
            Dim msg As New mensagemform("Não é necessário reparos!")
            msg.ShowDialog()
        Else
            If per.dinheiro >= custo Then
                Dim msg As New mensagemform("Você deseja reparar a arma ao custo de: " & custo & " ?", True)
                msg.ShowDialog()
                If msg.verificarBotao() Then
                    Dim curado As New mensagemform("Reparos efetuados com Sucesso!")
                    curado.ShowDialog()
                    per.durArma = 100
                    per.dinheiro -= custo
                End If
            Else
                Dim msg As New mensagemform("Dinheiro insuficiente para reparar!" & vbCrLf & "Dinheiro Necessário: " & custo)
                msg.ShowDialog()
            End If
        End If

        Return per
    End Function

    Function repararEquip(ByVal per As PersonagemModel) As PersonagemModel
        Dim custo As Integer = ((100 - per.durEquip) * (per.nvEquip + 7)) \ 3

        If per.durEquip = 100 Then
            Dim msg As New mensagemform("Não é necessário reparos!")
            msg.ShowDialog()
        Else
            If per.dinheiro >= custo Then
                Dim msg As New mensagemform("Você deseja reparar a arma ao custo de: " & custo & " ?", True)
                msg.ShowDialog()
                If msg.verificarBotao() Then
                    Dim curado As New mensagemform("Reparos efetuados com Sucesso!")
                    curado.ShowDialog()
                    per.durEquip = 100
                    per.dinheiro -= custo
                End If
            Else
                Dim msg As New mensagemform("Dinheiro insuficiente para reparar!" & vbCrLf & "Dinheiro Necessário: " & custo)
                msg.ShowDialog()
            End If
        End If

        Return per
    End Function

    Public Function forjarArma(ByVal per As PersonagemModel) As PersonagemModel
        Dim custo As Integer = 53 * per.nvArma

        If per.durEquip = 999 Then
            Dim msg As New mensagemform("Você chegou ao nível Maximo!")
            msg.ShowDialog()
        Else
            If per.dinheiro >= custo Then
                Dim msg As New mensagemform("Você deseja refinar a arma ao custo de: " & custo & " ?", True)
                msg.ShowDialog()
                If msg.verificarBotao() Then
                    Dim curado As New mensagemform("Arma refinada com sucesso!" & vbCrLf & "Houve uma perda de durabilidade: 'Colocar Sorteador'")
                    curado.ShowDialog()
                    per.nvArma += 1
                    per.dinheiro -= custo
                End If
            Else
                Dim msg As New mensagemform("Dinheiro insuficiente para refinar!" & vbCrLf & "Dinheiro Necessário: " & custo)
                msg.ShowDialog()
            End If
        End If
        Return per
    End Function
    'forjar armadura

    Public Function forjarEquipamento(ByVal per As PersonagemModel) As PersonagemModel
        Dim custo As Integer = 77 * per.nvEquip

        If per.durEquip = 999 Then
            Dim msg As New mensagemform("Você chegou ao nível Maximo!")
            msg.ShowDialog()
        Else
            If per.dinheiro >= custo Then
                Dim msg As New mensagemform("Você deseja refinar o equipamento ao custo de: " & custo & " ?", True)
                msg.ShowDialog()
                If msg.verificarBotao() Then
                    Dim curado As New mensagemform("Equipamento refinado com sucesso!" & vbCrLf & "Houve uma perda de durabilidade: 'Colocar Sorteador'")
                    curado.ShowDialog()
                    per.nvEquip += 1
                    per.dinheiro -= custo
                End If
            Else
                Dim msg As New mensagemform("Dinheiro insuficiente para refinar!" & vbCrLf & "Dinheiro Necessário: " & custo)
                msg.ShowDialog()
            End If
        End If
        Return per
    End Function


End Class
