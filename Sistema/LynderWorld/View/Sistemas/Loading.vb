Public Class Loading
    Dim carregou As Boolean = False

    Dim per1, per2, per3 As New PersonagemModel
    Dim user As New UsuarioModel
    Dim lc As New PersonagemController

    Public Sub New(ByVal usuario As UsuarioModel)
        InitializeComponent()
        Me.user = usuario
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pbLoading.Value < 100 Then
            pbLoading.Value = pbLoading.Value + 1
        Else
            Timer1.Enabled = False
            Dim formSelecao As New Personagem(per1, per2, per3, user)
            formSelecao.Show()
            carregou = True
            Me.Close()
        End If
        If pbLoading.Value = 20 Then
            PictureBox1.Image = My.Resources.medieval61
        ElseIf pbLoading.Value = 40 Then
            PictureBox1.Image = My.Resources.medieval3
        ElseIf pbLoading.Value = 60 Then
            PictureBox1.Image = My.Resources.medieval2
        ElseIf pbLoading.Value = 80 Then
            PictureBox1.Image = My.Resources.medieval58
        End If

        If pbLoading.Value = 20 Then
            per1 = lc.carregarSlot(user.codigo, 1)
            Label1.Text = "Checando informações"
        ElseIf pbLoading.Value = 40 Then
            per2 = lc.carregarSlot(user.codigo, 2)
        ElseIf pbLoading.Value = 60 Then
            per3 = lc.carregarSlot(user.codigo, 3)
            Label1.Text = "Carregando dados"
        ElseIf pbLoading.Value = 80 Then
            Label1.Text = "Dados carregados com sucesso!"
        ElseIf pbLoading.Value = 90 Then
            Label1.Text = "Iniciando aplicação"
        End If

    End Sub

    Private Sub Loading_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If carregou = False Then
            Dim msg As New mensagemform("Erro ao tentar carregar informações dos personagens!")
            msg.ShowDialog()
            Application.Exit()
        End If
    End Sub


    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.favicon
        Timer1.Enabled = True
    End Sub
End Class