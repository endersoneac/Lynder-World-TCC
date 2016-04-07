Public Class mensagemform

    Dim confirmar As Boolean

    Public Sub New(ByVal msg As String)
        InitializeComponent()
        lblMensagem.Text = msg
    End Sub

    Public Sub New(ByVal msg As String, ByVal imput As Boolean)
        InitializeComponent()
        lblMensagem.Text = msg
        btnConfirmar.Visible = False
        btnSim.Visible = True
        btnNao.Visible = True
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Me.Close()
    End Sub

    Private Sub mensagemform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.favicon
        lblMensagem.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnSim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSim.Click
        confirmar = True
        Me.Close()
    End Sub

    Private Sub btnNão_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNao.Click
        confirmar = False
        Me.Close()
    End Sub

    Public Function verificarBotao() As Boolean
        Return confirmar
    End Function
End Class