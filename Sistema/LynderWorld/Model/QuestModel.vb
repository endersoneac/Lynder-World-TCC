Public Class questModel

    Private indentificacaoQuest As Integer
    Private codigoPersonagem As Integer
    Private idMonstro As Integer
    Private quatidadeMonstros As Integer
    Private cidadeQuest As Integer
    Private dinheiroGanho As Integer
    Private expertGanho As Integer
    Private NPCQuest As New NpcModel


    Public Property npc() As NpcModel
        Get
            Return NPCQuest
        End Get
        Set(ByVal value As NpcModel)
            NPCQuest = value
        End Set
    End Property
    Public Property experiencia() As Integer
        Get
            Return expertGanho
        End Get
        Set(ByVal value As Integer)
            expertGanho = value
        End Set
    End Property
    Public Property dinheiro() As Integer
        Get
            Return dinheiroGanho
        End Get
        Set(ByVal value As Integer)
            dinheiroGanho = value
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
