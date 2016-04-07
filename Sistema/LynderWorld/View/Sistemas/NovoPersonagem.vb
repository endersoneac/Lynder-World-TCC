Public Class NovoPersonagem

    Dim pers As New PersonagemModel
    Dim personagemC As New PersonagemController
   
    Public Sub New(ByVal slot As Integer, ByVal user As Integer)
        pers.slot = slot
        pers.coduser = user
        InitializeComponent()
        listaAparencia.SelectedIndex = 0
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        pers.Aparencia = listaAparencia.SelectedIndex + 1
        pers.nome = txtNome.Text
        If txtNome.Text = Nothing Then
            Dim msg As New mensagemform("Insira o nome do personagem!!")
            msg.ShowDialog()
        Else
            Try

                personagemC.gerarNovo(pers)

                Dim msg As New mensagemform("Personagem criado com sucesso!")
                msg.ShowDialog()

            Catch ex As Exception
                Dim msg As New mensagemform("Não foi possível criar o personagem!")
                MsgBox("Erro Gerado: " & ex.Message)
                msg.ShowDialog()
            End Try

            Me.Close()
        End If
        
    End Sub

    Private Sub listaAparencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaAparencia.SelectedIndexChanged
        If listaAparencia.SelectedIndex = 0 Then
            fotinhoMarota.Image = My.Resources.per1
        ElseIf listaAparencia.SelectedIndex = 1 Then
            fotinhoMarota.Image = My.Resources.per2
        ElseIf listaAparencia.SelectedIndex = 2 Then
            fotinhoMarota.Image = My.Resources.per3
        ElseIf listaAparencia.SelectedIndex = 3 Then
            fotinhoMarota.Image = My.Resources.per4
        ElseIf listaAparencia.SelectedIndex = 4 Then
            fotinhoMarota.Image = My.Resources.per5
        ElseIf listaAparencia.SelectedIndex = 5 Then
            fotinhoMarota.Image = My.Resources.per6
        End If
    End Sub

    Private Sub NovoPersonagem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
    End Sub
End Class