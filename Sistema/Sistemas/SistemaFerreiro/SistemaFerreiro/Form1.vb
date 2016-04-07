Public Class Form1
    Dim fe As New Ferreiro

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fe.NA = lblA.Text
        fe.Di = lblDinheiro.Text
        fe.forjarArma()
        lblA.Text = fe.NA

        lblDinheiro.Text = fe.Di()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fe.NAM = lblAm.Text
        fe.Di = lblDinheiro.Text
        fe.forjarArmadura()
        lblAm.Text = fe.NAM
        lblDinheiro.Text = fe.Di()
    End Sub
End Class
