Public Class Form1
    Dim mensagens(4) As String
    Dim controle As New ControleConversa
    Dim conversa As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mensagens = controle.retornaMensagens()
        conversa = 0
        verificarMensagens()
    End Sub

    Sub verificarMensagens()
        lblConversa.Text = mensagens(conversa)
        conversa += 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conversa < 4 Then
            verificarMensagens()
        Else
            verificarMensagens()
            Button1.Enabled = False
        End If

    End Sub
End Class
