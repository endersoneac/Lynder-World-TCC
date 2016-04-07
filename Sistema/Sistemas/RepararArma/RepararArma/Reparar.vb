Public Class Reparar
    Private Durabilidade As String
    Public Property Dura() As String
        Get
            Return Durabilidade
        End Get
        Set(ByVal value As String)
            Durabilidade = value
        End Set
    End Property

    Private NivelArma As String
    Public Property Arma() As String
        Get
            Return NivelArma
        End Get
        Set(ByVal value As String)
            NivelArma = value
        End Set
    End Property

    Private CustoReparacao As String
    Public Property Reparacao() As String
        Get
            Return CustoReparacao
        End Get
        Set(ByVal value As String)
            CustoReparacao = value
        End Set
    End Property

    Private Dinheiro As String
    Public Property Din() As String
        Get
            Return Dinheiro
        End Get
        Set(ByVal value As String)
            Dinheiro = value
        End Set
    End Property


    Public Sub CalculaReparo()
        Reparacao = ((100 - Dura) * Arma) / 2
    End Sub
    Public Sub Reparo(ByVal dinheiro As Integer)
        Reparacao = ((100 - Dura) * Arma) \ 4
        Dim confirm = MessageBox.Show("O custo do reparo é igual a: " & Reparacao & " Deseja realmente reparar?", "Confirmação", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            If dinheiro >= Reparacao Then
                MessageBox.Show("Reparado com sucesso!")
                Form1.lbldinheiro.Text = Form1.lbldinheiro.Text - Reparacao
                Form1.lblDurabilidade.Text = 100
            Else
                MessageBox.Show("Seu dinheiro não é suficiente!")
            End If
        End If
    End Sub




End Class
