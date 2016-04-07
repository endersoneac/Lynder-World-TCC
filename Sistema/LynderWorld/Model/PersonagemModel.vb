Public Class PersonagemModel

    Private Codigo As Integer
    Private NomePersonagem As String
    Private CodigoUsuario As String
    Private PSupremaPersonagem As Integer
    Private PManaPersonagemPequena As Integer
    Private PCuraPersonagemPequena As Integer
    Private CidadePersonagem As Byte
    Private AparenciaPersonagem As Byte
    Private DinheiroPersonagem As Integer
    Private NvEquipPersonagem As Integer
    Private NvArmaPersonagem As Integer
    Private ExperienciaPersonagem As Integer
    Private NivelPersonagem As Integer
    Private SlotPersonagem As Byte
    Private PManaPersonagemGrande As Integer
    Private PCuraPersonagemGrande As Integer
    Private vidaAtualPersonagem As Integer
    Private manaAtualPersonagem As Integer
    Private durabilidadeArma As Integer
    Private durabilidadeEquipamento As Integer
    Private vidaTotal As Integer
    Private manaTotal As Integer
    Private experienciaTotalPersonagem As Integer


    Public Property expTotal() As Integer
        Get
            Return experienciaTotalPersonagem
        End Get
        Set(ByVal value As Integer)
            experienciaTotalPersonagem = value
        End Set
    End Property
    Public Property mana() As Integer
        Get
            Return manaTotal
        End Get
        Set(ByVal value As Integer)
            manaTotal = value
        End Set
    End Property
    Public Property vida() As Integer
        Get
            Return vidaTotal
        End Get
        Set(ByVal value As Integer)
            vidaTotal = value
        End Set
    End Property
    Public Property durEquip() As Integer
        Get
            Return durabilidadeEquipamento
        End Get
        Set(ByVal value As Integer)
            durabilidadeEquipamento = value
        End Set
    End Property
    Public Property durArma() As Integer
        Get
            Return durabilidadeArma
        End Get
        Set(ByVal value As Integer)
            durabilidadeArma = value
        End Set
    End Property
    Public Property manaAtual() As Integer
        Get
            Return manaAtualPersonagem
        End Get
        Set(ByVal value As Integer)
            manaAtualPersonagem = value
        End Set
    End Property
    Public Property vidaAtual() As Integer
        Get
            Return vidaAtualPersonagem
        End Get
        Set(ByVal value As Integer)
            vidaAtualPersonagem = value
        End Set
    End Property
    Public Property PCuraGra() As Integer
        Get
            Return PCuraPersonagemGrande
        End Get
        Set(ByVal value As Integer)
            PCuraPersonagemGrande = value
        End Set
    End Property
    Public Property PManaGra() As Integer
        Get
            Return PManaPersonagemGrande
        End Get
        Set(ByVal value As Integer)
            PManaPersonagemGrande = value
        End Set
    End Property
    Public Property cod() As Integer
        Get
            Return Codigo
        End Get
        Set(ByVal value As Integer)
            Codigo = value
        End Set
    End Property
    Public Property nome() As String
        Get
            Return NomePersonagem
        End Get
        Set(ByVal value As String)
            NomePersonagem = value
        End Set
    End Property
    Public Property nivel() As Integer
        Get
            Return NivelPersonagem
        End Get
        Set(ByVal value As Integer)
            NivelPersonagem = value
        End Set
    End Property
    Public Property expert() As Integer
        Get
            Return ExperienciaPersonagem
        End Get
        Set(ByVal value As Integer)
            ExperienciaPersonagem = value
        End Set
    End Property
    Public Property nvArma() As Integer
        Get
            Return NvArmaPersonagem
        End Get
        Set(ByVal value As Integer)
            NvArmaPersonagem = value
        End Set
    End Property
    Public Property nvEquip() As Integer
        Get
            Return NvEquipPersonagem
        End Get
        Set(ByVal value As Integer)
            NvEquipPersonagem = value
        End Set
    End Property
    Public Property dinheiro() As Integer
        Get
            Return DinheiroPersonagem
        End Get
        Set(ByVal value As Integer)
            DinheiroPersonagem = value
        End Set
    End Property
    Public Property Aparencia() As Byte
        Get
            Return AparenciaPersonagem
        End Get
        Set(ByVal value As Byte)
            AparenciaPersonagem = value
        End Set
    End Property
    Public Property cidade() As Byte
        Get
            Return CidadePersonagem
        End Get
        Set(ByVal value As Byte)
            CidadePersonagem = value
        End Set
    End Property
    Public Property PCuraPeq() As Integer
        Get
            Return PCuraPersonagemPequena
        End Get
        Set(ByVal value As Integer)
            PCuraPersonagemPequena = value
        End Set
    End Property
    Public Property PManaPeq() As Integer
        Get
            Return PManaPersonagemPequena
        End Get
        Set(ByVal value As Integer)
            PManaPersonagemPequena = value
        End Set
    End Property
    Public Property PSuprema() As Integer
        Get
            Return PSupremaPersonagem
        End Get
        Set(ByVal value As Integer)
            PSupremaPersonagem = value
        End Set
    End Property
    Public Property coduser() As String
        Get
            Return CodigoUsuario
        End Get
        Set(ByVal value As String)
            CodigoUsuario = value
        End Set
    End Property
    Public Property slot() As Byte
        Get
            Return SlotPersonagem
        End Get
        Set(ByVal value As Byte)
            SlotPersonagem = value
        End Set
    End Property

End Class
