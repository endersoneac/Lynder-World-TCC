Public Class Form1
    Dim pc As New Pocoes
    Public Sub label()
        pc.V = lblVida.Text
        pc.VM = lblVmax.Text
        pc.M = lblMana.Text
        pc.MAM = lblMMax.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        label()
        pc.PP()
        If lblVida.Text > 1000 Then
            MessageBox.Show("Sua Vida está completa!, não é necessario a utilização de poções.")
            lblVida.Text = 1000
        Else
            lblVida.Text = pc.V
        End If
        pc.conferi()
        lblVida.Text = pc.V
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        label()
        pc.PM()
        If lblVida.Text > 1000 Then
            MessageBox.Show("Sua Vida está completa!, não é necessario a utilização de poções.")
            lblVida.Text = 1000
        Else
            lblVida.Text = pc.V
        End If
        pc.conferi()
        lblVida.Text = pc.V
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        label()
        pc.MP()
        If lblMana.Text > 1000 Then
            MessageBox.Show("Sua mana está completa, não é necessario a utilização de poções")
        Else
            lblMana.Text = pc.M
        End If
        pc.conferir()
        lblMana.Text = pc.M
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        label()
        pc.MAME()
        If lblMana.Text > 1000 Then
            MessageBox.Show("Sua mana está completa, não é necessario a utilização de poções")
        Else
            lblMana.Text = pc.M
        End If
        pc.conferir()
        lblMana.Text = pc.M
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If lblVida.Text >= 1000 Then
            MessageBox.Show("Sua Vida está completa!, não é necessario a utilização de poções.")
            lblVida.Text = 1000
        Else
            lblVida.Text = 1000
        End If



        If lblMana.Text >= 1000 Then
            MessageBox.Show("Sua mana está completa, não é necessario a utilização de poções")
        Else
            lblMana.Text = 1000
        End If

    End Sub


End Class
