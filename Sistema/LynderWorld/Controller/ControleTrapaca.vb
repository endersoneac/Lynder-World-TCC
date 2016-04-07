Public Class ControleTrapaca
    Dim msg As Validacao
    Public Sub trapacaDetectada(ByVal cod As Integer)

        msg.validarMensagem("Tentativa de trapaça detectada! relatório enviado.")
        'Application.Exit()
    End Sub

    Public Sub enviarRelatorio(ByVal cod As Integer, ByVal codUser As Integer)
        Dim mensagem As String
        Select Case cod
            Case 1
                mensagem = "Detectado tentativa de uso de ferramentas para manipular o Dinheiro"
            Case 2
                mensagem = "Detectado tentativa de uso de ferramentas para manipular o Ranking"
            Case 3
                mensagem = "Detectado tentativa de uso de ferramentas para manipular o Nivel"
            Case 4
                mensagem = "Detectado tentativa de uso de ferramentas para manipular a Experiencia"
        End Select

        'colocar metodo de enviar para o banco

    End Sub
End Class
