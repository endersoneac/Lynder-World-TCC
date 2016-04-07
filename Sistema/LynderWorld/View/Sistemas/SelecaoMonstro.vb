Public Class SelecaoMonstro
    Public monstro As New MonstroModel
    Dim conM As New MonstroController
    Dim aparencia As Byte
    Public per1 As New PersonagemModel
    Dim idCidade As Integer
    Dim nv1(3) As Integer
    Dim nom(3) As String


    Public Sub New(ByVal per As PersonagemModel)
        InitializeComponent()
        per1 = per
       
        idCidade = 1
        receber()
        
    End Sub
    Private Sub receber()
        Dim espaco As String = "            "
        Dim nv() As Integer = conM.sortearNivel(idCidade)
        'lista1.MultiColumn
        'recebe nivel dos Adversarios
        nv1(0) = nv(0)
        nv1(1) = nv(1)
        nv1(2) = nv(2)
        'recebe nome dos Adversarios
        nom(0) = "Gnef"
        nom(1) = "Zaell"
        nom(2) = "Zare"
        'recebe nome e nivel na list
        lista1.Items(0) = nv(0).ToString("00") & espaco & "Gnef"
        lista1.Items(1) = nv(1).ToString("00") & espaco & "Zaell"
        lista1.Items(2) = nv(2).ToString("00") & espaco & "Zare"
    End Sub
    'lista 2
    Private Sub receber1()
        Dim espaco As String = "            "
        Dim nv() As Integer = conM.sortearNivel(idCidade)
        'lista1.MultiColumn
        'recebe nivel dos Adversarios
        nv1(0) = nv(0)
        nv1(1) = nv(1)
        nv1(2) = nv(2)
        'recebe nome dos Adversarios
        nom(0) = "Tokle"
        nom(1) = "Trioh"
        nom(2) = "Druli"
        'recebe nome e nivel na list
        lista2.Items(0) = nv(0).ToString("00") & espaco & "Tokle"
        lista2.Items(1) = nv(1).ToString("00") & espaco & "Trioh"
        lista2.Items(2) = nv(2).ToString("00") & espaco & "Druli"
    End Sub

    Private Sub receber2()
        Dim espaco As String = "            "
        Dim nv() As Integer = conM.sortearNivel(idCidade)
        'lista1.MultiColumn
        'recebe nivel dos Adversarios
        nv1(0) = nv(0)
        nv1(1) = nv(1)
        nv1(2) = nv(2)
        'recebe nome dos Adversarios
        nom(0) = "Kedda"
        nom(1) = "Smeke"
        nom(2) = "Zivog"
        'recebe nome e nivel na list
        lista3.Items(0) = nv(0).ToString("00") & espaco & "Kedda"
        lista3.Items(1) = nv(1).ToString("00") & espaco & "Smeke"
        lista3.Items(2) = nv(2).ToString("00") & espaco & "Zivog"
    End Sub

    Private Sub receber3()
        Dim espaco As String = "            "
        Dim nv() As Integer = conM.sortearNivel(idCidade)
        'lista1.MultiColumn
        'recebe nivel dos Adversarios
        nv1(0) = nv(0)
        nv1(1) = nv(1)
        nv1(2) = nv(2)
        'recebe nome dos Adversarios
        nom(0) = "Zhark"
        nom(1) = "Ethoblas"
        nom(2) = "Brazzo"
        'recebe nome e nivel na list
        lista4.Items(0) = nv(0).ToString("00") & espaco & "Zhark"
        lista4.Items(1) = nv(1).ToString("00") & espaco & "Ethoblas"
        lista4.Items(2) = nv(2).ToString("00") & espaco & "Brazzo"
    End Sub

    Private Sub receber4()
        Dim espaco As String = "            "
        Dim nv() As Integer = conM.sortearNivel(idCidade)
        'lista1.MultiColumn
        'recebe nivel dos Adversarios
        nv1(0) = nv(0)
        nv1(1) = nv(1)
        nv1(2) = nv(2)
        'recebe nome dos Adversarios
        nom(0) = "Ripper"
        nom(1) = "Vraslo"
        nom(2) = "Fronon"
        'recebe nome e nivel na list
        lista5.Items(0) = nv(0).ToString("00") & espaco & "Ripper"
        lista5.Items(1) = nv(1).ToString("00") & espaco & "Vraslo"
        lista5.Items(2) = nv(2).ToString("00") & espaco & "Fronon"
    End Sub

 
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnDesafiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesafiar.Click
        monstro.nome = lblNomeMonstro.Text
        monstro.nivel = lblNivelMonstro.Text
        monstro.aparencia = aparencia

        monstro = conM.calcularVidaMonstro(monstro)
        Dim arena As New Batalha(per1, monstro)
        arena.ShowDialog()
        per1 = arena.retornaResultado()
    End Sub
    'Lista recebe nome, aparencia e nivel do Adversario

    Private Sub lista1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista1.SelectedIndexChanged
        comparar()
    End Sub
    Private Sub comparar()
        If lista1.SelectedIndex = 0 Then
            lblNomeMonstro.Text = nom(0)
            lblNivelMonstro.Text = nv1(0)
            pbAdversario.Image = conM.verificarImagem(1)
            aparencia = 1
            btnDesafiar.Enabled = True
        ElseIf lista1.SelectedIndex = 1 Then
            lblNomeMonstro.Text = nom(1)
            lblNivelMonstro.Text = nv1(1)
            pbAdversario.Image = conM.verificarImagem(2)
            aparencia = 2
            btnDesafiar.Enabled = True
        ElseIf lista1.SelectedIndex = 2 Then
            lblNomeMonstro.Text = nom(2)
            lblNivelMonstro.Text = nv1(2)
            pbAdversario.Image = conM.verificarImagem(3)
            aparencia = 3
            btnDesafiar.Enabled = True

        End If
    End Sub


    Private Sub CompararCidade()
        If TabCidade.SelectedIndex = 0 Then
            idCidade = 1
            receber()
        ElseIf TabCidade.SelectedIndex = 1 Then
            idCidade = 2
            receber1()
        ElseIf TabCidade.SelectedIndex = 2 Then
            idCidade = 3
            receber2()
        ElseIf TabCidade.SelectedIndex = 3 Then
            idCidade = 4
            receber3()
        ElseIf TabCidade.SelectedIndex = 4 Then
            idCidade = 5
            receber4()
        End If
    End Sub
    Private Sub comparar1()
        If lista2.SelectedIndex = 0 Then
            lblNomeMonstro.Text = nom(0)
            lblNivelMonstro.Text = nv1(0)
            pbAdversario.Image = conM.verificarImagem(4)
            'pbAdversario.Image = My.Resources.Adversario4
            aparencia = 4
            btnDesafiar.Enabled = True
        ElseIf lista2.SelectedIndex = 1 Then
            lblNomeMonstro.Text = nom(1)
            lblNivelMonstro.Text = nv1(1)
            pbAdversario.Image = conM.verificarImagem(5)
            'pbAdversario.Image = My.Resources.Adversario5
            aparencia = 5
            btnDesafiar.Enabled = True
        Else
            lblNomeMonstro.Text = nom(2)
            lblNivelMonstro.Text = nv1(2)
            pbAdversario.Image = conM.verificarImagem(6)
            'pbAdversario.Image = My.Resources.Adversario6
            aparencia = 6
            btnDesafiar.Enabled = True
        End If
    End Sub
    Private Sub comparar2()
        If lista3.SelectedIndex = 0 Then
            lblNomeMonstro.Text = nom(0)
            lblNivelMonstro.Text = nv1(0)
            pbAdversario.Image = conM.verificarImagem(7)
            ' pbAdversario.Image = My.Resources.Adversario7
            aparencia = 7
            btnDesafiar.Enabled = True
        ElseIf lista3.SelectedIndex = 1 Then
            lblNomeMonstro.Text = nom(1)
            lblNivelMonstro.Text = nv1(1)
            pbAdversario.Image = conM.verificarImagem(8)
            '  pbAdversario.Image = My.Resources.Adversario8
            aparencia = 8
            btnDesafiar.Enabled = True
        Else
            lblNomeMonstro.Text = nom(2)
            lblNivelMonstro.Text = nv1(2)
            pbAdversario.Image = conM.verificarImagem(9)
            ' pbAdversario.Image = My.Resources.Adversario9
            aparencia = 9
            btnDesafiar.Enabled = True
        End If
    End Sub
    Private Sub comparar3()
        If lista4.SelectedIndex = 0 Then
            lblNomeMonstro.Text = nom(0)
            lblNivelMonstro.Text = nv1(0)
            pbAdversario.Image = conM.verificarImagem(10)
            '  pbAdversario.Image = My.Resources.Adversario10
            aparencia = 10
            btnDesafiar.Enabled = True
        ElseIf lista4.SelectedIndex = 1 Then
            lblNomeMonstro.Text = nom(1)
            lblNivelMonstro.Text = nv1(1)
            pbAdversario.Image = conM.verificarImagem(11)
            ' pbAdversario.Image = My.Resources.Adversario11
            aparencia = 11
            btnDesafiar.Enabled = True
        Else
            lblNomeMonstro.Text = nom(2)
            lblNivelMonstro.Text = nv1(2)
            pbAdversario.Image = conM.verificarImagem(12)
            ' pbAdversario.Image = My.Resources.Adversario12
            aparencia = 12
            btnDesafiar.Enabled = True
        End If
    End Sub

    Private Sub comparar4()
        If lista5.SelectedIndex = 0 Then
            lblNomeMonstro.Text = nom(0)
            lblNivelMonstro.Text = nv1(0)
            pbAdversario.Image = conM.verificarImagem(13)
            '  pbAdversario.Image = My.Resources.Adversario13
            aparencia = 13
            btnDesafiar.Enabled = True
        ElseIf lista5.SelectedIndex = 1 Then
            lblNomeMonstro.Text = nom(1)
            lblNivelMonstro.Text = nv1(1)
            pbAdversario.Image = conM.verificarImagem(14)
            ' pbAdversario.Image = My.Resources.Adversario14
            aparencia = 14
            btnDesafiar.Enabled = True
        Else
            lblNomeMonstro.Text = nom(2)
            lblNivelMonstro.Text = nv1(2)
            pbAdversario.Image = conM.verificarImagem(15)
            '   pbAdversario.Image = My.Resources.Adversario15
            aparencia = 15
            btnDesafiar.Enabled = True
        End If
    End Sub


    Private Sub TabCidade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabCidade.SelectedIndexChanged
        CompararCidade()
    End Sub

    Private Sub lista2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista2.SelectedIndexChanged
        comparar1()
    End Sub

    Private Sub lista3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista3.SelectedIndexChanged
        comparar2()
    End Sub

    Private Sub lista4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista4.SelectedIndexChanged
        comparar3()
    End Sub

    Private Sub lista5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista5.SelectedIndexChanged
        comparar4()
    End Sub

    Public Function retornaResultado() As PersonagemModel
        Return per1
    End Function
   
End Class