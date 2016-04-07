Public Class MonstroModel

    Private codigoMonstro As Integer
    Private nomeMonstro As String
    Private nivelMonstro As Integer
    Private vidaMonstro As Integer
    Private dinheiroMonstro As Integer
    Private defesaMonstro As Integer
    Private expMontro As Integer
    Private ataqueMonstro As Integer
    Private aparenciaMonstro As Byte
    Private vidaAtualMonstro As Integer

    Public Property vidaAtual() As Integer
        Get
            Return vidaAtualMonstro
        End Get
        Set(ByVal value As Integer)
            vidaAtualMonstro = value
        End Set
    End Property
    Public Property aparencia() As Byte
        Get
            Return aparenciaMonstro
        End Get
        Set(ByVal value As Byte)
            aparenciaMonstro = value
        End Set
    End Property
    Public Property ataque() As String
        Get
            Return ataqueMonstro
        End Get
        Set(ByVal value As String)
            ataqueMonstro = value
        End Set
    End Property
    Public Property exp() As Integer
        Get
            Return expMontro
        End Get
        Set(ByVal value As Integer)
            expMontro = value
        End Set
    End Property
    Public Property defesa() As Integer
        Get
            Return defesaMonstro
        End Get
        Set(ByVal value As Integer)
            defesaMonstro = value
        End Set
    End Property
    Public Property dinheiro() As Integer
        Get
            Return dinheiroMonstro
        End Get
        Set(ByVal value As Integer)
            dinheiroMonstro = value
        End Set
    End Property
    Public Property vida() As Integer
        Get
            Return vidaMonstro
        End Get
        Set(ByVal value As Integer)
            vidaMonstro = value
        End Set
    End Property
    Public Property nivel() As Integer
        Get
            Return nivelMonstro
        End Get
        Set(ByVal value As Integer)
            nivelMonstro = value
        End Set
    End Property
    Public Property nome() As String
        Get
            Return nomeMonstro
        End Get
        Set(ByVal value As String)
            nomeMonstro = value
        End Set
    End Property
    Public Property codigo() As Integer
        Get
            Return codigoMonstro
        End Get
        Set(ByVal value As Integer)
            codigoMonstro = value
        End Set
    End Property

End Class
