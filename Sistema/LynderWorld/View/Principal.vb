Public Class Principal

    Dim personagem As New PersonagemModel
    Dim controle As New PersonagemController

    Public Sub New(ByVal per As PersonagemModel)
        InitializeComponent()
        personagem = per
        carregarInfos(personagem)
    End Sub

    Sub carregarInfos(ByVal per As PersonagemModel)
        'Metodos para carregar as informações na tela...
        'Carrega imagem
        imagemPersonagem.Image = controle.verificarImagem(per.Aparencia)

        'Carrega Vida, Mana e Experiencia
        per.vida = controle.calcularVida(per.nivel, per.nvEquip)
        per.mana = controle.calcularMana(per.nivel, per.nvArma)
        per.expTotal = controle.calcularExperiencia(per.nivel)

        'Passa para a Label
        lblVida.Text = per.vidaAtual & " / " & per.vida
        lblMana.Text = per.manaAtual & " / " & per.mana
        lblExperiencia.Text = per.expert & " / " & per.expTotal
        
        'ProgressBar de VIDA
        pbVida.Maximum = 100
        pbVida.Value = ((100 * per.vidaAtual) \ per.vida)

        'ProgressBar de Experiencia
        pbExpert.Maximum = 100
        pbExpert.Value = ((100 * per.expert) \ per.expTotal)
        
        'ProgressBar de MANA
        pbMana.Maximum = 100
        pbMana.Value = ((100 * per.manaAtual) \ per.mana)

        'Passa o resto
        lblNivel.Text = per.nivel
        lblNome.Text = per.nome
        lblDinheiro.Text = per.dinheiro


    End Sub

    Private Sub btnArena_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArena.MouseEnter
        lblArena.Visible = True
    End Sub

    Private Sub btnArena_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArena.MouseLeave
        lblArena.Visible = False
    End Sub

    Private Sub btnMercador_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMercador.MouseEnter
        lblMercador.Visible = True
    End Sub

    Private Sub btnMercador_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMercador.MouseLeave
        lblMercador.Visible = False
    End Sub


    Private Sub btnFerreiro_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFerreiro.MouseEnter
        lblFerreiro.Visible = True
    End Sub

    Private Sub btnFerreiro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFerreiro.MouseLeave
        lblFerreiro.Visible = False
    End Sub


    Private Sub btnNpc_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPC.MouseEnter
        lblNpc.Visible = True
    End Sub

    Private Sub btnNpc_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPC.MouseLeave
        lblNpc.Visible = False
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub Principal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnFerreiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFerreiro.Click
        Dim ferro As New Ferreiro(personagem)
        ferro.ShowDialog()
    End Sub

    Private Sub btnMercador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMercador.Click
        Dim mercado As New Hospital(personagem)
        mercado.ShowDialog()
        personagem = mercado.buscar()
        carregarInfos(personagem)
    End Sub

    Private Sub btnArena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArena.Click
        Batalha.ShowDialog()
    End Sub

    Private Sub Principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
    End Sub
End Class