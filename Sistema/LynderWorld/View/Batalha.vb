Public Class Batalha

    Dim controle As New ControleBatalha
    Dim per1 As New PersonagemModel
    Dim mon1 As New MonstroModel

    Sub esconderListas()
        listItem.Visible = False
        listMagia.Visible = False
    End Sub


    Private Sub btnMagia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagia.Click
        If listMagia.Visible = False Then
            esconderListas()
            listMagia.Visible = True
        Else
            esconderListas()
        End If
        
    End Sub

    Private Sub GhostButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GhostButton3.Click
        If listItem.Visible = False Then
            esconderListas()
            listItem.Visible = True
        Else
            esconderListas()
        End If
    End Sub

    Private Sub btnAtacar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtacar.Click
        controle.ataqueNormal(per1)
        controle.ataqueMonstro(mon1)
    End Sub

    Private Sub btnDesistir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesistir.Click
        Me.Close()
    End Sub

    Private Sub Batalha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
    End Sub
End Class