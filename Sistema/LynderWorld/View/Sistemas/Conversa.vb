Public Class Conversa
    Dim posicoes, pos As Integer
    Dim per As New PersonagemModel
    Dim npc As New NpcModel
    Dim controle As New PersonagemController
    Dim geradorNPC As New GeraNPC


    Public Sub New(ByVal personagem As PersonagemModel, ByVal npcM As NpcModel)
        InitializeComponent()

        per = personagem
        npc = npcM
        btnProximo.Visible = True
        Dim posicoes As Integer = npc.mensagem.Length
        carregarInfos(personagem, npc, posicoes)
    End Sub

    Private Sub carregarInfos(ByVal perc As PersonagemModel, ByVal npcM As NpcModel, ByVal posicoes As Integer)
        Dim mensagens(posicoes) As String
        mensagens = npc.mensagem
        fotoNPC.Image = npc.imagem
        fotoPersonagem.Image = controle.verificarImagem(perc.Aparencia)
        lblNomeNPC.Text = npc.nome
        lblNomePersonagem.Text = perc.nome
        pos = 0
        lblConversa.Text = mensagens(pos)
        lblNomeConversa.Text = per.nome()
        pos = 1
    End Sub

    Private Sub proximo()
        If lblNomeConversa.Text = per.nome Then
            lblNomeConversa.Text = npc.nome()
        ElseIf lblNomeConversa.Text = npc.nome Then
            lblNomeConversa.Text = per.nome
        End If
        lblConversa.Text = npc.mensagem(pos)
        pos += 1
    End Sub

    Private Sub btnProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProximo.Click
        If pos < (npc.mensagem.Length - 2) Then
            proximo()
        Else
            proximo()
            btnProximo.Visible = False
        End If

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
End Class