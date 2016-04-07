Public Class questModel

    Private indentificacaoQuest As Integer
    Private codigoPersonagem As Integer
    Private idMonstro As Integer
    Private quatidadeMonstros As Integer
    Private cidadeQuest As Integer
    Private nomeNPC As String

    Public Property npc() As String
        Get
            Return nomeNPC
        End Get
        Set(ByVal value As String)
            nomeNPC = value
        End Set
    End Property
    Public Property cidade() As Integer
        Get
            Return cidadeQuest
        End Get
        Set(ByVal value As Integer)
            cidadeQuest = value
        End Set
    End Property
    Public Property qtdMonstro() As Integer
        Get
            Return quatidadeMonstros
        End Get
        Set(ByVal value As Integer)
            quatidadeMonstros = value
        End Set
    End Property
    Public Property monstro() As Integer
        Get
            Return idMonstro
        End Get
        Set(ByVal value As Integer)
            idMonstro = value
        End Set
    End Property
    Public Property codPersonagem() As Integer
        Get
            Return codigoPersonagem
        End Get
        Set(ByVal value As Integer)
            codigoPersonagem = value
        End Set
    End Property
    Public Property idQuest() As Integer
        Get
            Return indentificacaoQuest
        End Get
        Set(ByVal value As Integer)
            indentificacaoQuest = value
        End Set
    End Property

End Class
