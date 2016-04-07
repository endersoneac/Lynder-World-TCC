Public Class Ferreiro
    Dim per As New PersonagemModel
    Dim controle As New ControleFerreiro
    Dim personagemC As New PersonagemController

    Public Sub New(ByVal personagem As PersonagemModel)
        InitializeComponent()
        per = personagem
        carregar()
    End Sub

    Sub carregar()
        lblArma.Text = per.durArma
        lblEquip.Text = per.durEquip
        lblNvArma.Text = per.nvArma
        lblNvEquip.Text = per.nvEquip
        lblDinheiro.Text = per.dinheiro
    End Sub
    Private Sub GhostButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton2.Click
        Me.Close()
    End Sub

    Private Sub Ferreiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
    End Sub

    Private Sub btnRepararArma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepararArma.Click
        per = controle.repararArma(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnRepararEquip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepararEquip.Click
        per = controle.repararEquip(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnAprimorarArma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprimorarArma.Click
        per = controle.forjarArma(per)
        carregar()
        personagemC.salvar(per)
    End Sub

    Private Sub btnAprimorarEquip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprimorarEquip.Click
        per = controle.forjarEquipamento(per)
        carregar()
        personagemC.salvar(per)
    End Sub
End Class