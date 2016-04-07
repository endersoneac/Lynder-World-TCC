Public Class SeleçãoMonstro
    Dim monstro As New MonstroModel
    Dim arena As New Batalha
    

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnDesafiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesafiar.Click
        monstro.nome = lblNomeMonstro.Text
        monstro.nivel = lblNivelMonstro.Text
        Batalha.ShowDialog()
    End Sub

    'label recebe o nome do adversario 
    Private Sub lblM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM1.Click
        lblNomeMonstro.Text = lblM1.Text
        lblNivelMonstro.Text = lblN1.Text
        pbAdversario.Image = My.Resources.Adversario1
    End Sub

    Private Sub lblM2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM2.Click
        lblNomeMonstro.Text = lblM2.Text
        lblNivelMonstro.Text = lblN2.Text
        pbAdversario.Image = My.Resources.Adversario2
    End Sub

    Private Sub lblM3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM3.Click
        lblNomeMonstro.Text = lblM3.Text
        lblNivelMonstro.Text = lblN3.Text
        pbAdversario.Image = My.Resources.Adversario3
    End Sub

    Private Sub lblM4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM4.Click
        lblNomeMonstro.Text = lblM4.Text
        lblNivelMonstro.Text = lblN4.Text
        pbAdversario.Image = My.Resources.Adversario4
    End Sub

    Private Sub lblM5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM5.Click
        lblNomeMonstro.Text = lblM5.Text
        lblNivelMonstro.Text = lblN15.Text
        pbAdversario.Image = My.Resources.Adversario5
    End Sub

    Private Sub lblM6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM6.Click
        lblNomeMonstro.Text = lblM6.Text
        lblNivelMonstro.Text = lblN6.Text
        pbAdversario.Image = My.Resources.Adversario6
    End Sub

    Private Sub lblM7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM7.Click
        lblNomeMonstro.Text = lblM7.Text
        lblNivelMonstro.Text = lblN7.Text
        pbAdversario.Image = My.Resources.Adversario7
    End Sub

    Private Sub lblM8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM8.Click
        lblNomeMonstro.Text = lblM8.Text
        lblNivelMonstro.Text = lblN8.Text
        pbAdversario.Image = My.Resources.Adversario8
    End Sub

    Private Sub lblM9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM9.Click
        lblNomeMonstro.Text = lblM9.Text
        lblNivelMonstro.Text = lblN9.Text
        pbAdversario.Image = My.Resources.Adversario9
    End Sub

    Private Sub lblM10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM10.Click
        lblNomeMonstro.Text = lblM10.Text
        lblNivelMonstro.Text = lblN10.Text
        pbAdversario.Image = My.Resources.Adversario10
    End Sub

    Private Sub lblM11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM11.Click
        lblNomeMonstro.Text = lblM11.Text
        lblNivelMonstro.Text = lblN11.Text
        pbAdversario.Image = My.Resources.Adversario11
    End Sub

    Private Sub lblM12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM12.Click
        lblNomeMonstro.Text = lblM12.Text
        lblNivelMonstro.Text = lblN12.Text
        pbAdversario.Image = My.Resources.Adversario12
    End Sub

    Private Sub lblM13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM13.Click
        lblNomeMonstro.Text = lblM13.Text
        lblNivelMonstro.Text = lblN13.Text
        pbAdversario.Image = My.Resources.Adversario13
    End Sub

    Private Sub lblM14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM14.Click
        lblNomeMonstro.Text = lblM14.Text
        lblNivelMonstro.Text = lblN14.Text
        pbAdversario.Image = My.Resources.Adversario14
    End Sub

    Private Sub lblM15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblM15.Click
        lblNomeMonstro.Text = lblM15.Text
        lblNivelMonstro.Text = lblN15.Text
        pbAdversario.Image = My.Resources.Adversario15
    End Sub
End Class