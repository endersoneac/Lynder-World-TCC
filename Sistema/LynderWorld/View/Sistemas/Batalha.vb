Public Class Batalha

    Dim controle As New ControleBatalha
    Dim per1 As New PersonagemModel
    Dim mon1 As New MonstroModel
    Dim controleMonstro As New MonstroController
    Dim controlePersonagem As New PersonagemController
    Dim num As Integer
    Dim gasto As Integer


    'Dim selMon As New SelecaoMonstro(per1)
    Dim n1 As String
    
    Public Sub New(ByVal per As PersonagemModel, ByVal monstro As MonstroModel)
        InitializeComponent()
        per1 = per
        mon1 = monstro
    End Sub

    Private Sub esconderListas()
        listItem.Visible = False
        listMagia.Visible = False
    End Sub
   

    Private Sub selecionaItem()
        Dim form As New mensagemform("Você não possui poções para usar!!!")
        
        If listItem.SelectedIndex = 0 Then
            If per1.PCuraPeq > 0 Then
                per1.PCuraPeq -= 1
                per1.vidaAtual += 50
            Else
                form.ShowDialog()
            End If
        ElseIf listItem.SelectedIndex = 1 Then
            If per1.PCuraGra > 0 Then
                per1.PCuraGra -= 1
                per1.vidaAtual += 200
            Else
                form.ShowDialog()
            End If
        ElseIf listItem.SelectedIndex = 2 Then
            If per1.PManaPeq > 0 Then
                per1.PManaPeq -= 1
                per1.manaAtual += 50
            Else
                form.ShowDialog()
            End If
        ElseIf listItem.SelectedIndex = 3 Then
            If per1.PManaGra > 0 Then
                per1.PManaGra -= 1
                per1.manaAtual += 200
            Else
                form.ShowDialog()
            End If
        ElseIf listItem.SelectedIndex = 4 Then
            If per1.PSuprema > 0 Then
                per1.PSuprema -= 1
                per1.vidaAtual = per1.vida
                per1.manaAtual = per1.mana
            Else
                form.ShowDialog()
            End If
        End If
        If per1.vidaAtual > per1.vida Then
            per1.vidaAtual = per1.vida
        End If
        If per1.manaAtual > per1.mana Then
            per1.manaAtual = per1.mana
        End If
        'carrega informações do personagem atualizado
        carregarInfos(per1, mon1)
        controlePersonagem.salvar(per1)

    End Sub



    Private Function selecionaMagia() As Integer

        If listMagia.SelectedIndex = 0 Then
            'MsgBox("1")
            num = 1
            gasto = 60
        ElseIf listMagia.SelectedIndex = 1 Then
            'MsgBox("2")
            num = 2
            gasto = 120
        ElseIf listMagia.SelectedIndex = 2 Then
            'MsgBox("3")
            num = 3
            gasto = 240
        ElseIf listMagia.SelectedIndex = 3 Then
            'MsgBox("4")
            num = 4
            gasto = 480
        ElseIf listMagia.SelectedIndex = 4 Then
            'MsgBox("5")
            num = 5
            gasto = 960
        ElseIf listMagia.SelectedIndex = 5 Then
            'MsgBox("6")
            num = 6
            gasto = 1920
        Else
            'MsgBox("Fudeu")
            num = 0
            gasto = 0
        End If
        num = controle.danoMagia(num)
        Return num
    End Function

    Private Sub ma()
        listMagia.Items.Clear()
        Dim nivel As Integer = per1.nivel
        If nivel < 5 Then
            listMagia.Items.Add("Golpe Fulminante")
        ElseIf nivel >= 5 And nivel < 10 Then
            listMagia.Items.Add("Golpe Fulminante")
            listMagia.Items.Add("Ataque das Laminas")
        ElseIf nivel >= 10 And nivel < 20 Then
            listMagia.Items.Add("Golpe Fulminante")
            listMagia.Items.Add("Ataque das Laminas")
            listMagia.Items.Add("Sombras Destruidoras")
        ElseIf nivel >= 20 And nivel < 30 Then
            listMagia.Items.Add("Golpe Fulminante")
            listMagia.Items.Add("Ataque das Laminas")
            listMagia.Items.Add("Sombras Destruidoras")
            listMagia.Items.Add("Mestre das Sombras")
        ElseIf nivel >= 30 And nivel < 40 Then
            listMagia.Items.Add("Golpe Fulminante")
            listMagia.Items.Add("Ataque das Laminas")
            listMagia.Items.Add("Sombras Destruidoras")
            listMagia.Items.Add("Mestre das Sombras")
            listMagia.Items.Add("Laminas Velozes")
        ElseIf nivel >= 50 Then
            listMagia.Items.Add("Golpe Fulminante")
            listMagia.Items.Add("Ataque das Laminas")
            listMagia.Items.Add("Sombras Destruidoras")
            listMagia.Items.Add("Mestre das Sombras")
            listMagia.Items.Add("Laminas Velozes")
            listMagia.Items.Add("Golpe Brutal")
        End If
    End Sub


    Private Sub btnMagia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagia.Click
        If listMagia.Visible = False Then
            esconderListas()
            listMagia.Visible = True
        Else
            esconderListas()
        End If
        ma()
        controlePersonagem.salvar(per1)
    End Sub

    Private Sub GhostButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem.Click
        If listItem.Visible = False Then
            esconderListas()
            listItem.Visible = True
        Else
            esconderListas()
        End If
    End Sub

    Private Sub btnAtacar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtacar.Click
        ' controle.ataqueNormal(per1, mon1)
        mon1.vidaAtual -= controle.ataqueNormal(per1, mon1)
        ' MsgBox(controle.ataqueNormal(per1, mon1))

        If mon1.vidaAtual <= 0 Then
            'Atualizar Monstro
            mon1.vidaAtual = 0
            carregarInfos(per1, mon1)
            Dim exp As Integer = controle.calcularExp(mon1)
            Dim din As Integer = controle.calcularDinheiro(mon1)
            lblDinheiro.Text = din
            lblExperiencia.Text = exp
            'Termina o processo...
            telaConclusao.Show()
            terminar("Você ganhou a batalha!", My.Resources.medieval2)
            per1.dinheiro += din
            per1.expert += exp
            controlePersonagem.verificaNivel(per1)

        Else
            per1.vidaAtual -= controle.ataqueMonstro(mon1, per1)
            If per1.vidaAtual <= 0 Then
                'Atualizar Personagem
                per1.vidaAtual = 0
                carregarInfos(per1, mon1)
                per1.vidaAtual = 1

                'Termina o processo...
                terminar("Você foi derrotado!", My.Resources.medieval58)
            End If
            'teste aqui!!!
            'MsgBox(controle.ataqueNormal(per1, mon1))
            controlePersonagem.salvar(per1)
            carregarInfos(per1, mon1)

            End If
    End Sub

    Private Sub btnDesistir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesistir.Click
        controlePersonagem.salvar(per1)
        Me.Close()
    End Sub

    Private Sub Batalha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.favicon
        gpbMonstro.Text = mon1.nome
        carregarInfos(per1, mon1)
    End Sub
    Private Sub carregarInfos(ByVal per As PersonagemModel, ByVal mon As MonstroModel)
        'retirar isso aew!!
        'Dim n As Integer = controleMonstro.Receber(per.nome)


        pbJogador.Image = controlePersonagem.verificarImagem(per.Aparencia)
        gpbJogador.Text = per.nome
        'progress bar da vida 
        pbVida.Maximum = 100
        pbVida.Value = ((100 * per.vidaAtual) \ per.vida)
        'progress bar da mana 
        pbMana.Maximum = 100
        pbMana.Value = ((100 * per.manaAtual) \ per.mana)
        'Passa para a Label
        lblVida.Text = per.vidaAtual & " / " & per.vida
        lblMana.Text = per.manaAtual & " / " & per.mana

        pbMonstro.Image = controleMonstro.verificarImagem(mon.aparencia)
        pbVidaMonstro.Maximum = 100
        pbVidaMonstro.Value = ((100 * mon.vidaAtual) \ mon.vida)
        lblVidaMonstro.Text = mon.vidaAtual & " / " & mon.vida
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        controlePersonagem.salvar(per1)
        Me.Close()
    End Sub

    Public Function retornaResultado() As PersonagemModel
        Return per1
    End Function

    Private Sub terminar(ByVal msg As String, ByVal foto As Image)
        esconderListas()
        btnAtacar.Visible = False
        btnDesistir.Visible = False
        btnMagia.Visible = False
        btnItem.Visible = False
        controlePersonagem.salvar(per1)
        telaConclusao.Text = msg
        fotoFinal.Image = foto
        telaConclusao.Show()
    End Sub

    
    Private Sub listMagia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listMagia.SelectedIndexChanged
        selecionaMagia()
        If per1.manaAtual < gasto Then
            Dim mensagem As New mensagemform("Você não passui mana suficiente para usar Magia!!!")
            'per1.manaAtual = 0
            mensagem.ShowDialog()
        Else
            mon1.vidaAtual -= selecionaMagia()
            per1.manaAtual -= gasto
            'MsgBox(selecionaMagia)

            If mon1.vidaAtual <= 0 Then
                'Atualizar Monstro
                mon1.vidaAtual = 0
                carregarInfos(per1, mon1)
                Dim exp As Integer = controle.calcularExp(mon1)
                Dim din As Integer = controle.calcularDinheiro(mon1)
                lblDinheiro.Text = din
                lblExperiencia.Text = exp
                'Termina o processo...
                telaConclusao.Show()
                terminar("Você ganhou a batalha!", My.Resources.medieval2)
                per1.dinheiro += din
                per1.expert += exp
                controlePersonagem.verificaNivel(per1)

            Else
                per1.vidaAtual -= controle.ataqueMonstro(mon1, per1)
                If per1.vidaAtual <= 0 Then
                    'Atualizar Personagem
                    per1.vidaAtual = 0
                    carregarInfos(per1, mon1)
                    per1.vidaAtual = 1

                    'Termina o processo...
                    terminar("Você foi derrotado!", My.Resources.medieval58)
                End If
                controlePersonagem.salvar(per1)
                carregarInfos(per1, mon1)

            End If
        End If
        
    End Sub

    Private Sub listItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listItem.SelectedIndexChanged
        selecionaItem()
        controlePersonagem.salvar(per1)
    End Sub
End Class