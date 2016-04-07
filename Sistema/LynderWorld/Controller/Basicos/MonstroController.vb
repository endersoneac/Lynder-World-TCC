Imports MySql.Data.MySqlClient

Public Class MonstroController
    Dim novo As Integer
    Dim sorteador As Random = New Random
   

    Public Function verificarImagem(ByVal aparencia As Integer) As Image

        Select Case aparencia
            Case 1
                Return My.Resources.adv1
            Case 2
                Return My.Resources.adv2
            Case 3
                Return My.Resources.adv3
            Case 4
                Return My.Resources.adv4
            Case 5
                Return My.Resources.adv5
            Case 6
                Return My.Resources.adv6
            Case 7
                Return My.Resources.adv7
            Case 8
                Return My.Resources.adv8
            Case 9
                Return My.Resources.adv9
            Case 10
                Return My.Resources.adv10
            Case 11
                Return My.Resources.adv11
            Case 12
                Return My.Resources.adv12
            Case 13
                Return My.Resources.adv13
            Case 14
                Return My.Resources.adv14
            Case 15
                Return My.Resources.adv15
            Case Else
                Return My.Resources.faceA
        End Select

    End Function
    Function calcularVidaMonstro(ByVal mon As MonstroModel) As MonstroModel
        mon.vida = mon.nivel * 99
        mon.vidaAtual = mon.vida
        Return mon
    End Function

    Function sortearNivel(ByVal idCidade As Integer) As Integer()
        Dim nivel(3) As Integer
        Dim max As Integer
        Dim min As Integer
        If idCidade = 1 Then
            min = 1
            max = 3
        ElseIf idCidade = 2 Then
            min = 4
            max = 8
        ElseIf idCidade = 3 Then
            min = 13
            max = 18
        ElseIf idCidade = 4 Then
            min = 25
            max = 35
        ElseIf idCidade = 5 Then
            min = 40
            max = 70
        Else
            Application.Exit()
        End If
        nivel(0) = sorteador.Next(min, (max + 1))
        nivel(1) = sorteador.Next(min, (max + 1))
        nivel(2) = sorteador.Next(min, (max + 1))
        Return nivel
    End Function
End Class
