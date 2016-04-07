Public Class UsuarioModel

    Private CodigoUsuario As Integer
    Private NomeUsuario As String
    Private CadastroAtivo As integer
    Private SenhaUsuario As String
    Private EmailUsuario As String
    Private LoginUsuario As String


    Public Property codigo() As Integer
        Get
            Return CodigoUsuario
        End Get
        Set(ByVal value As Integer)
            CodigoUsuario = value
        End Set
    End Property

    Public Property nome() As String
        Get
            Return NomeUsuario
        End Get
        Set(ByVal value As String)
            NomeUsuario = value
        End Set
    End Property

    Public Property ativo() As integer
        Get
            Return CadastroAtivo
        End Get
        Set(ByVal value As integer)
            CadastroAtivo = value
        End Set
    End Property

    Public Property senha() As String
        Get
            Return SenhaUsuario
        End Get
        Set(ByVal value As String)
            SenhaUsuario = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return EmailUsuario
        End Get
        Set(ByVal value As String)
            EmailUsuario = value
        End Set
    End Property

    Public Property login() As String
        Get
            Return LoginUsuario
        End Get
        Set(ByVal value As String)
            LoginUsuario = value
        End Set
    End Property
End Class
