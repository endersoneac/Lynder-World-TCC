Public Class Personagem

    Dim controle As New PersonagemController
    Dim personagem1, personagem2, personagem3, selecionado As New PersonagemModel
    Dim usuario As New UsuarioModel

    Public Sub New(ByVal per1 As PersonagemModel, ByVal per2 As PersonagemModel, ByVal per3 As PersonagemModel, ByVal user As UsuarioModel)

        personagem1 = per1
        personagem2 = per2
        personagem3 = per3
        usuario = user

        InitializeComponent()

        verificar()
    End Sub

    Sub verificar()
        If controle.verificarPersonagem(personagem1) = True Then
            foto1.Image = controle.verificarImagem(personagem1.Aparencia)
            lblNome1.Text = personagem1.nome
            btnDeletar1.Visible = True
            btnNovo1.Visible = False
        Else
            foto1.Image = controle.verificarImagem(7)
            lblNome1.Text = "((Crie Seu Personagem!))"
            btnDeletar1.Visible = False
            btnNovo1.Visible = True
        End If

        If controle.verificarPersonagem(personagem2) = True Then
            foto2.Image = controle.verificarImagem(personagem2.Aparencia)
            lblNome2.Text = personagem2.nome
            btnDeletar2.Visible = True
            btnNovo2.Visible = False
        Else
            foto2.Image = controle.verificarImagem(7)
            lblNome2.Text = "((Crie Seu Personagem!))"
            btnDeletar2.Visible = False
            btnNovo2.Visible = True
        End If

        If controle.verificarPersonagem(personagem3) = True Then
            foto3.Image = controle.verificarImagem(personagem3.Aparencia)
            lblNome3.Text = personagem3.nome
            btnDeletar3.Visible = True
            btnNovo3.Visible = False
        Else
            foto3.Image = controle.verificarImagem(7)
            lblNome3.Text = "((Crie Seu Personagem!))"
            btnDeletar3.Visible = False
            btnNovo3.Visible = True
        End If
    End Sub


    Sub Atualizar()
        personagem1 = controle.carregarSlot(usuario.codigo, 1)
        personagem2 = controle.carregarSlot(usuario.codigo, 2)
        personagem3 = controle.carregarSlot(usuario.codigo, 3)
        verificar()

        lblExp.Text = "--"
        lblNv.Text = "--"
        lblNvArma.Text = "--"
        lblNvEquip.Text = "--"
        lblNome.Text = "--"
        lblDinheiro.Text = "--"

        selecionado = Nothing
        btnEntrar.Enabled = False
    End Sub


    Private Sub Personagem_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim jogo As New Principal(selecionado)
        jogo.Show()
        Me.Hide()
    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click
        Dim novopersonagem As New NovoPersonagem(1, usuario.codigo)
        novopersonagem.ShowDialog()
    End Sub

    Private Sub Personagem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
    End Sub

    Private Sub slot1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slot1.Click, lblNome1.Click, foto1.Click
        If controle.verificarPersonagem(personagem1) = True Then
            carregarInformacoes(personagem1)
        Else
            Dim novopersonagem As New NovoPersonagem(1, usuario.codigo)
            novopersonagem.ShowDialog()
            Atualizar()
        End If
    End Sub

    Public Sub carregarInformacoes(ByVal personagem As PersonagemModel)
        lblExp.Text = personagem.expert
        lblNv.Text = personagem.nivel
        lblNvArma.Text = personagem.nvArma
        lblNvEquip.Text = personagem.nvEquip
        lblNome.Text = personagem.nome
        lblDinheiro.Text = personagem.dinheiro
        selecionado = personagem
        btnEntrar.Enabled = True
    End Sub

    Private Sub slot2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slot2.Click, lblNome2.Click, foto2.Click
        If controle.verificarPersonagem(personagem2) = True Then
            carregarInformacoes(personagem2)
        Else
            Dim novopersonagem As New NovoPersonagem(2, usuario.codigo)
            novopersonagem.ShowDialog()
            Atualizar()
        End If
    End Sub

    Private Sub slot3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slot3.Click, lblNome3.Click, foto3.Click
        If controle.verificarPersonagem(personagem3) = True Then
            carregarInformacoes(personagem3)
        Else
            Dim novopersonagem As New NovoPersonagem(3, usuario.codigo)
            novopersonagem.ShowDialog()
            Atualizar()
        End If
    End Sub

    Private Sub btnDeletar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletar1.Click
        Dim confirmar As New mensagemform("Deseja realmente deletar o Personagem?", True)
        confirmar.ShowDialog()
        If confirmar.verificarBotao Then
            If controle.deletar(personagem1) = True Then
                Atualizar()
                Dim msg As New mensagemform("Personagem deletado com Sucesso!")
                msg.ShowDialog()
            Else
                Dim msg As New mensagemform("Não foi possível deletar o Personagem!")
                msg.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnDeletar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletar2.Click
        Dim confirmar As New mensagemform("Deseja realmente deletar o Personagem?", True)
        confirmar.ShowDialog()
        If confirmar.verificarBotao Then
            If controle.deletar(personagem2) = True Then
                Atualizar()
                Dim msg As New mensagemform("Personagem deletado com Sucesso!")
                msg.ShowDialog()
            Else
                Dim msg As New mensagemform("Não foi possível deletar o Personagem!")
                msg.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnDeletar3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeletar3.Click
        Dim confirmar As New mensagemform("Deseja realmente deletar o Personagem?", True)
        confirmar.ShowDialog()
        If confirmar.verificarBotao Then
            If controle.deletar(personagem3) = True Then
                Atualizar()
                Dim msg As New mensagemform("Personagem deletado com Sucesso!")
                msg.ShowDialog()
            Else
                Dim msg As New mensagemform("Não foi possível deletar o Personagem!")
                msg.ShowDialog()
            End If
        End If
    End Sub
End Class