Public Class Pocoes

    Private Pequena As Integer
    Public Property Pe() As Integer
        Get
            Return Pequena
        End Get
        Set(ByVal value As Integer)
            Pequena = value
        End Set
    End Property

    Private Media As Integer
    Public Property Med() As Integer
        Get
            Return Media
        End Get
        Set(ByVal value As Integer)
            Media = value
        End Set
    End Property

    Private Suprema As Integer
    Public Property Su() As Integer
        Get
            Return Suprema
        End Get
        Set(ByVal value As Integer)
            Suprema = value
        End Set
    End Property

    Private VMax As Integer
    Public Property VM() As Integer
        Get
            Return VMax
        End Get
        Set(ByVal value As Integer)
            VMax = value
        End Set
    End Property

    Private Vida As Integer
    Public Property V() As Integer
        Get
            Return Vida
        End Get
        Set(ByVal value As Integer)
            Vida = value
        End Set
    End Property

    Private ManaP As Integer
    Public Property MAP() As Integer
        Get
            Return ManaP
        End Get
        Set(ByVal value As Integer)
            ManaP = value
        End Set
    End Property

    Private ManaM As Integer
    Public Property MAM() As Integer
        Get
            Return ManaM
        End Get
        Set(ByVal value As Integer)
            ManaM = value
        End Set
    End Property

    Private ManaSuprema As Integer
    Public Property MASu() As Integer
        Get
            Return ManaSuprema
        End Get
        Set(ByVal value As Integer)
            ManaSuprema = value
        End Set
    End Property

    Private Mana As Integer
    Public Property M() As Integer
        Get
            Return Mana
        End Get
        Set(ByVal value As Integer)
            Mana = value
        End Set
    End Property

    Private ManaMax As Integer
    Public Property MM() As Integer
        Get
            Return ManaMax
        End Get
        Set(ByVal value As Integer)
            ManaMax = value
        End Set
    End Property
    'vidas
    Public Sub PP()
        Me.Pe = 50
        Me.V = V + Pe
    End Sub
    Public Sub PM()
        Me.Med = 200
        Me.V = V + Med
    End Sub
    Public Sub PS()
        Me.V = V + Su
    End Sub
    'manas
    Public Sub MP()
        Me.MAP = 50
        Me.M = M + MAP
    End Sub
    Public Sub MAME()
        Me.MAM = 200
        Me.M = M + MAM
    End Sub
    Public Sub MS()
        Me.MASu = MM
        Me.M = M + MASu
    End Sub

    Public Sub conferi()
        If V > 1000 Then
            MessageBox.Show("Sua Vida está completa!, não é necessario a utilização de poções.")
            V = 1000
        End If
    End Sub
    Public Sub conferir()
        If M > 1000 Then
            MessageBox.Show("Sua mana está completa, não é necessario a utilização de poções")
            M = 1000
        End If
    End Sub

End Class
