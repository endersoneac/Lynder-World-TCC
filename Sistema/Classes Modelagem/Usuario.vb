Public Class Usuario

    Private Codigo As Integer
    Public Property cod() As Integer
        Get
            Return Codigo
        End Get
        Set(ByVal value As Integer)
            Codigo = value
        End Set
    End Property

    Private NomeUsuario As String
    Public Property nome() As String
        Get
            Return NomeUsuario
        End Get
        Set(ByVal value As String)
            NomeUsuario = value
        End Set
    End Property

    Private CadastroAtivo As Boolean
    Public Property ativo() As Boolean
        Get
            Return CadastroAtivo
        End Get
        Set(ByVal value As Boolean)
            CadastroAtivo = value
        End Set
    End Property

    Private SenhaUsuario As String
    Public Property senha() As String
        Get
            Return SenhaUsuario
        End Get
        Set(ByVal value As String)
            SenhaUsuario = value
        End Set
    End Property

    Private EmailUsuario As String
    Public Property email() As String
        Get
            Return EmailUsuario
        End Get
        Set(ByVal value As String)
            EmailUsuario = value
        End Set
    End Property

    Private LoginUsuario As String
    Public Property login() As String
        Get
            Return LoginUsuario
        End Get
        Set(ByVal value As String)
            LoginUsuario = value
        End Set
    End Property



End Class
