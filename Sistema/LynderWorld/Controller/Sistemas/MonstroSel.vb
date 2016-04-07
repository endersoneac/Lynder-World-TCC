Public Class MonstroSel

    Private _monstro As MonstroModel
    Public Property Monstro() As MonstroModel
        Get
            Return _monstro
        End Get
        Set(ByVal value As MonstroModel)
            _monstro = value
        End Set
    End Property

End Class
