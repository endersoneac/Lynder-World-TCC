Public Class Ferreiro
    Dim nivelArma As Integer
    Dim nivelArmadura As Integer
    Dim dinheiro As Integer
    Dim custo As Integer
    Dim custoA As Integer




    Public Property NAM() As Integer
        Get
            NAM = nivelArmadura
        End Get
        Set(ByVal value As Integer)
            nivelArmadura = value
        End Set
    End Property

    Public Property NA() As Integer
        Get
            NA = nivelArma
        End Get
        Set(ByVal value As Integer)
            nivelArma = value
        End Set
    End Property

    Public Property Di() As Integer
        Get
            Di = dinheiro
        End Get
        Set(ByVal value As Integer)
            dinheiro = value
        End Set
    End Property

    Public Property Co() As Integer
        Get
            Co = custo
        End Get
        Set(ByVal value As Integer)
            custo = value
        End Set
    End Property

    Public Property CoA() As Integer
        Get
            CoA = custoA
        End Get
        Set(ByVal value As Integer)
            custoA = value
        End Set
    End Property


    'funções
    'função forjar arma
    Public Function forjarArma() As Boolean
        Co = 50 * NA
        If Co <= Di Then
            NA += 1
            Di -= custo
        Else
            MessageBox.Show("você não possui dinheiro suficiente!!")
        End If
        
        Return True
    End Function
    'forjar armadura

    Public Function forjarArmadura() As Boolean
        CoA = 50 * NA
        If CoA <= Di Then
            NAM += 1
            Di -= custo
        Else
            MessageBox.Show("você não possui dinheiro suficiente!!")
        End If
        Return True
    End Function



End Class
