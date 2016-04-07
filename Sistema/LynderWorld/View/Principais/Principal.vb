Public Class Principal

    Dim pers As New PersonagemModel
    Dim controle As New PersonagemController
    Dim valido As Boolean
    Dim quest As New questModel
    Dim cidade As New CidadeModel

    Sub New(ByVal per As PersonagemModel, ByVal qst As questModel)
        Dim cidadeC As New ControleCidade
        InitializeComponent()
        pers = per
        quest = qst

        cidade = cidadeC.retornaCidade(pers.cidade)
        carregarInfos(pers)
    End Sub

    

    Sub carregarInfos(ByVal per As PersonagemModel)
        'Metodos para carregar as informações na tela...
        'Carrega imagem
        imagemPersonagem.Image = controle.verificarImagem(per.Aparencia)

        'Carrega Vida, Mana e Experiencia
        per.vida = controle.calcularVida(per.nivel, per.nvEquip)
        per.mana = controle.calcularMana(per.nivel, per.nvArma)
        per.expTotal = controle.calcularExperiencia(per.nivel)

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

        'Passa para a Label
        lblVida.Text = per.vidaAtual & " / " & per.vida
        lblMana.Text = per.manaAtual & " / " & per.mana
        lblExperiencia.Text = per.expert & " / " & per.expTotal

        lblCidade.Text = cidade.nome

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
        valido = True
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Principal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not valido Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnFerreiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFerreiro.Click
        Dim ferro As New Ferreiro(pers)
        ferro.ShowDialog()
        pers = ferro.buscar()
        carregarInfos(pers)
    End Sub

    Private Sub btnMercador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMercador.Click
        Dim mercado As New Hospital(pers)
        mercado.ShowDialog()
        pers = mercado.buscar()
        carregarInfos(pers)
    End Sub

    Private Sub btnArena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArena.Click
        Dim selecaoMonstro As New SelecaoMonstro(pers)
        selecaoMonstro.ShowDialog()
        pers = selecaoMonstro.retornaResultado()
        carregarInfos(pers)
    End Sub

    Private Sub Principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
    End Sub

    Private Sub btnNPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPC.Click
        Dim bar As New Bar(pers)
        bar.ShowDialog()
    End Sub

End Class