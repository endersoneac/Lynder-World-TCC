Public Class ControleCidade

    Dim cidade

    Public Function retornaCidade(ByVal id As Integer) As CidadeModel
        Dim cidade As New CidadeModel
        'Verifica a cidade atual e o boss da mesma...
        Select Case id
            Case 0
                'Gera a cidade de morgambar
                cidade.nome = "Morgambar"
                cidade.nvMinimo = 1
                cidade.nvMaximo = 3

                'Gera boss de Morgambar
                cidade.boss.aparencia = 30
                cidade.boss.codigo = 30
                cidade.boss.nome = "Throes"
                cidade.boss.nivel = 5

            Case 1
                cidade.nome = "Krasland"
                cidade.nvMinimo = 4
                cidade.nvMaximo = 8

                cidade.boss.aparencia = 31
                cidade.boss.codigo = 31
                cidade.boss.nome = "Drobok"
                cidade.boss.nivel = 10
            Case 2
                cidade.nome = "Micronio"
                cidade.nvMinimo = 13
                cidade.nvMaximo = 18

                cidade.boss.aparencia = 32
                cidade.boss.codigo = 32
                cidade.boss.nome = "Kros"
                cidade.boss.nivel = 20
            Case 3
                cidade.nome = "Krospena"
                cidade.nvMinimo = 25
                cidade.nvMaximo = 35

                cidade.boss.aparencia = 33
                cidade.boss.codigo = 33
                cidade.boss.nome = "Genon"
                cidade.boss.nivel = 40
            Case 4
                cidade.nome = "Zerkaife"
                cidade.nvMinimo = 40
                cidade.nvMaximo = 75

                cidade.boss.aparencia = 34
                cidade.boss.codigo = 34
                cidade.boss.nome = "Zheno"
                cidade.boss.nivel = 80
            Case 5
                cidade.nome = "Meredin"
                cidade.nvMinimo = 100
                cidade.nvMaximo = 300

                cidade.boss.aparencia = 35
                cidade.boss.codigo = 35
                cidade.boss.nome = "Valaion"
                cidade.boss.nivel = 500
            Case Else
                Application.Exit()
        End Select

        Return cidade
    End Function


End Class
