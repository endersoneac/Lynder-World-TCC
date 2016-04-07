Public Class Form1
    Dim validar As New Validar
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If validar.validarLogin(txtLogin.Text, txtSenha.Text) = True Then
            MsgBox("FUNCIONOU!")
        Else
            MsgBox("NAO FUNCIONOU!")
        End If
    End Sub
End Class
