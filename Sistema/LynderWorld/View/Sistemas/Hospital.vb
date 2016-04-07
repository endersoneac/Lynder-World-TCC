Public Class Hospital
    Dim per As New PersonagemModel
    Dim controle As New ControleVendas
    Dim personagemC As New PersonagemController

    Public Sub New(ByVal personagem As PersonagemModel)
        InitializeComponent()

        per = personagem
        carregar()
    End Sub

    Sub carregar()

        barraHP.Maximum = 100
        barraHP.Value = ((100 * per.vidaAtual) \ per.vida)

        barraMP.Maximum = 100
        barraMP.Value = ((100 * per.manaAtual) \ per.mana)

        lblHPP.Text = per.PCuraPeq
        lblHPG.Text = per.PCuraGra
        lblMPG.Text = per.PManaGra
        lblMPP.Text = per.PManaPeq
        lblSS.Text = per.PSuprema
        lblDinheiro.Text = per.dinheiro

    End Sub

    Public Function buscar() As PersonagemModel
        Return per
    End Function

    Private Sub GhostButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton2.Click
        Me.Close()
    End Sub

    Private Sub Hospital_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
        lblTitulo.Width = Me.Width
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnComprarHPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprarHPP.Click
        per = controle.comprarPequenaHP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnComprarHPG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprarHPG.Click
        per = controle.comprarGrandeHP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnComprarMPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprarMPP.Click
        per = controle.comprarPequenaMP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnComprarMPG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprarMPG.Click
        per = controle.comprarGrandeMP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnComprarSuprema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprarSuprema.Click
        per = controle.comprarSuprema(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnDormir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDormir.Click
        per = controle.dormir(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnVenderHPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenderHPP.Click
        per = controle.venderPequenaHP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnVenderHPG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenderHPG.Click
        per = controle.venderGrandeHP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnVenderMPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenderMPP.Click
        per = controle.venderPequenaMP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnVenderMPG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenderMPG.Click
        per = controle.venderGrandeMP(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnVenderSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenderSS.Click
        per = controle.venderSuprema(per)
        carregar()
        personagemC.salvar(per)
    End Sub
End Class