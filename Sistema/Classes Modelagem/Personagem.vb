Public Class Personagem

    Private Codigo As Integer
    Public Property cod() As Integer
        Get
            Return Codigo
        End Get
        Set(ByVal value As Integer)
            Codigo = value
        End Set
    End Property

    Private NomePersonagem As String
    Public Property nome() As String
        Get
            Return NomePersonagem
        End Get
        Set(ByVal value As String)
            NomePersonagem = value
        End Set
    End Property

    Private NivelPersonagem As Integer
    Public Property nivel() As Integer
        Get
            Return NivelPersonagem
        End Get
        Set(ByVal value As Integer)
            NivelPersonagem = value
        End Set
    End Property

    Private ExperienciaPersonagem As Integer
    Public Property expert() As Integer
        Get
            Return ExperienciaPersonagem
        End Get
        Set(ByVal value As Integer)
            ExperienciaPersonagem = value
        End Set
    End Property

    Private NvArmaPersonagem As Integer
    Public Property nvArma() As Integer
        Get
            Return NvArmaPersonagem
        End Get
        Set(ByVal value As Integer)
            NvArmaPersonagem = value
        End Set
    End Property

    Private NvEquipPersonagem As Integer
    Public Property nvEquip() As Integer
        Get
            Return NvEquipPersonagem
        End Get
        Set(ByVal value As Integer)
            NvEquipPersonagem = value
        End Set
    End Property

    Private ClassePersonagem As Byte
    Public Property classe() As Byte
        Get
            Return ClassePersonagem
        End Get
        Set(ByVal value As Byte)
            ClassePersonagem = value
        End Set
    End Property

    Private DinheiroPersonagem As Integer
    Public Property dinheiro() As Integer
        Get
            Return DinheiroPersonagem
        End Get
        Set(ByVal value As Integer)
            DinheiroPersonagem = value
        End Set
    End Property

    Private AparenciaPersonagem As Byte
    Public Property Aparencia() As Byte
        Get
            Return AparenciaPersonagem
        End Get
        Set(ByVal value As Byte)
            AparenciaPersonagem = value
        End Set
    End Property

    Private CidadePersonagem As Byte
    Public Property cidade() As Byte
        Get
            Return CidadePersonagem
        End Get
        Set(ByVal value As Byte)
            CidadePersonagem = value
        End Set
    End Property

    Private PCuraPersonagem As Integer
    Public Property PCura() As Integer
        Get
            Return PCuraPersonagem
        End Get
        Set(ByVal value As Integer)
            PCuraPersonagem = value
        End Set
    End Property

    Private PManaPersonagem As Integer
    Public Property PMana() As Integer
        Get
            Return PManaPersonagem
        End Get
        Set(ByVal value As Integer)
            PManaPersonagem = value
        End Set
    End Property

    Private PSuprema As Integer
    Public Property PSuprema() As Integer
        Get
            Return PSuprema
        End Get
        Set(ByVal value As Integer)
            PSuprema = value
        End Set
    End Property




End Class
