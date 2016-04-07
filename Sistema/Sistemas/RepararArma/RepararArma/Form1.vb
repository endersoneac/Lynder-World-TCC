Public Class Form1
    Dim Re As New Reparar
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Re.Arma = lblNivelArma.Text
        Re.Dura = lblDurabilidade.Text
        Re.Din = lbldinheiro.Text

        lblNivelArma.Text = Re.Arma
        lblDurabilidade.Text = Re.Dura
        lbldinheiro.Text = Re.Din
        Re.Reparo(lbldinheiro.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Re.Arma = lblNivelArma.Text
        Re.Dura = lblDurabilidade.Text
        Re.Din = lbldinheiro.Text

        lblNivelArma.Text = Re.Arma
        lblDurabilidade.Text = Re.Dura
        lbldinheiro.Text = Re.Din
        Re.CalculaReparo()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lblDurabilidade.Text = 10
    End Sub
End Class
