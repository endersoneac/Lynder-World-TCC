Public Class CidadeModel
    Private nomeCidade As String
    Private idCidade As Integer
    Private nivelMaximoCidade As Integer
    Private nivelMinimoCidade As Integer
    Private bossCidade As New MonstroModel


    Public Property boss() As MonstroModel
        Get
            Return bossCidade
        End Get
        Set(ByVal value As MonstroModel)
            bossCidade = value
        End Set
    End Property
    Public Property nvMinimo() As Integer
        Get
            Return nivelMinimoCidade
        End Get
        Set(ByVal value As Integer)
            nivelMinimoCidade = value
        End Set
    End Property
    Public Property nvMaximo() As Integer
        Get
            Return nivelMaximoCidade
        End Get
        Set(ByVal value As Integer)
            nivelMaximoCidade = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return idCidade
        End Get
        Set(ByVal value As Integer)
            idCidade = value
        End Set
    End Property
    Public Property nome() As String
        Get
            Return nomeCidade
        End Get
        Set(ByVal value As String)
            nomeCidade = value
        End Set
    End Property
End Class
