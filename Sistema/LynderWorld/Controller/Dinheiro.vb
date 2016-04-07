Public Class Dinheiro
    Dim dinheiro As Integer
    Dim confirma As Double
    Dim teste As Double
    Dim trap As ControleTrapaca

    Public Function confirmarValor() As Boolean
        teste = dinheiro * 3
        If confirma = teste Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verificarDinheiro() As Integer
        Return dinheiro
    End Function


    Public Sub ganharDinheiro(ByVal recebido As Integer)
        If confirmarValor() = True Then
            dinheiro = dinheiro + recebido
            confirma = dinheiro * 3
        Else
            trap.trapacaDetectada(1)
        End If
    End Sub

    Public Sub perderDinheiro(ByVal perdido As Integer)
        If confirmarValor() = True Then
            dinheiro = dinheiro - perdido
            confirma = dinheiro * 3
        Else
            trap.trapacaDetectada(1)
        End If
    End Sub


End Class
