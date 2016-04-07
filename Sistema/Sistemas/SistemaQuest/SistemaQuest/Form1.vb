Public Class Form1
    Dim monstro As Integer
    Dim quest As New questModel
    Dim controle As New ControleQuest

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        monstro = 1
        quest = controle.verificarBatalha(quest, monstro)
        If controle.verificarQuest(quest) And quest.monstro = monstro Then
            MsgBox("Você terminou a quest!!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        monstro = 2
        quest = controle.verificarBatalha(quest, monstro)
        If controle.verificarQuest(quest) And quest.monstro = monstro Then
            MsgBox("Você terminou a quest!!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        monstro = 3
        quest = controle.verificarBatalha(quest, monstro)
        If controle.verificarQuest(quest) And quest.monstro = monstro Then
            MsgBox("Você terminou a quest!!")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If controle.verificarQuest(quest) Then
            quest = controle.pegarQuest(quest, 1)
        End If
    End Sub
End Class
