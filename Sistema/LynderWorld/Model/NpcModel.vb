Public Class NpcModel

    Private nomeNPC As String
    Private mensagens() As String
    Private imagemNPC As Image

    Public Property imagem() As Image
        Get
            Return imagemNPC
        End Get
        Set(ByVal value As Image)
            imagemNPC = value
        End Set
    End Property
    Public Property mensagem() As String()
        Get
            Return mensagens
        End Get
        Set(ByVal value As String())
            mensagens = value
        End Set
    End Property
    Public Property nome() As String
        Get
            Return nomeNPC
        End Get
        Set(ByVal value As String)
            nomeNPC = value
        End Set
    End Property

End Class
