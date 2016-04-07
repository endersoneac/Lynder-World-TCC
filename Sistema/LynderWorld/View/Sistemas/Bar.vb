Public Class Bar
    Dim gerador As New GeraNPC
    Dim npcQuest As New ControleQuest
    Dim npc1, npc2, npc3 As New NpcModel
    Dim per As New PersonagemModel

    Public Sub New(ByVal personagem As PersonagemModel)
        InitializeComponent()

        per = personagem
        gerarNPC()
        carregarNPC()

        Me.Icon = My.Resources.favicon
        lblTitulo.Width = Panel1.Width
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub gerarNPC()
        Dim sorte As Random = New Random
        Dim quest As Integer = sorte.Next(0, 3)

        Select Case quest
            Case 0
                npc1 = npcQuest.gerarNPC()
                npc2 = gerador.gerarNPC()
                npc3 = gerador.gerarNPC()
            Case 1
                npc1 = gerador.gerarNPC()
                npc2 = npcQuest.gerarNPC()
                npc3 = gerador.gerarNPC()
            Case 2
                npc1 = gerador.gerarNPC()
                npc2 = gerador.gerarNPC()
                npc3 = npcQuest.gerarNPC()
            Case Else
                npc1 = gerador.gerarNPC()
                npc2 = gerador.gerarNPC()
                npc3 = gerador.gerarNPC()
        End Select

        
    End Sub

    Private Sub carregarNPC()
        foto1.Image = npc1.imagem
        foto2.Image = npc2.imagem
        foto3.Image = npc3.imagem
        groupNPC1.Text = npc1.nome
        groupNPC2.Text = npc2.nome
        groupNPC3.Text = npc3.nome
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub Bar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
        lblTitulo.Width = Panel1.Width
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnConversar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConversar1.Click
        Dim conversa As New Conversa(per, npc1)
        conversa.ShowDialog()
    End Sub

    Private Sub btnConversar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConversar2.Click
        Dim conversa As New Conversa(per, npc2)
        conversa.ShowDialog()
    End Sub

    Private Sub btnConversar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConversar3.Click
        Dim conversa As New Conversa(per, npc3)
        conversa.ShowDialog()
    End Sub
End Class