Imports MySql.Data.MySqlClient
Public Class DAO
    'Private ReadOnly stringConexao As String = "server=127.0.0.1;user id=root;password=123456;database=lynder;allow zero datetime=true;"
    Private ReadOnly stringConexao As String = "server=sql2.freesqldatabase.com;user id=sql27073;password=eQ7*tR7%;database=sql27073;allow zero datetime=true;"
    Private comandoDAO As New MySqlCommand
    Private conexaoDAO As New MySqlConnection
    Private dataAdapterDAO As New MySqlDataAdapter

    Public ReadOnly Property conexao As MySqlConnection
        Get
            Return conexaoDAO
        End Get
    End Property

    Public Property comando As MySqlCommand
        Get
            Return comandoDAO
        End Get
        Set(ByVal value As MySqlCommand)
            comandoDAO = value
        End Set
    End Property

    Public Property dataAdapter As MySqlDataAdapter
        Get
            Return dataAdapterDAO
        End Get
        Set(ByVal value As MySqlDataAdapter)
            dataAdapterDAO = value
        End Set
    End Property

    Public Sub New()
        conexaoDAO = conectaBanco()
    End Sub

    Function conectaBanco() As MySqlConnection
        Return New MySqlConnection(stringConexao)
    End Function

    Function dataReaderMySQL(ByVal conexao As MySqlConnection, ByVal sql As String) As MySqlDataReader
        Return New MySqlCommand(sql, conexao).ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Function dataAdapterMySQL(ByVal conexao As MySqlConnection, ByVal SQL As String) As MySqlDataAdapter
        Return New MySqlDataAdapter(SQL, conexao)
    End Function

    Function dataSetMySQL(ByVal conexaoOLEDB As MySqlConnection, ByVal SQL As String) As DataSet
        Dim adapter As New MySqlDataAdapter
        Dim dataset As New DataSet
        adapter.Fill(dataset)
        Return dataset
    End Function

    Function dataSetMySQL(ByVal adapter As MySqlDataAdapter) As DataSet
        Dim dataset As New DataSet
        adapter.Fill(dataset)
        Return dataset
    End Function

    Function comandoMySQL(ByVal conexao As MySqlConnection, ByVal SQL As String) As MySqlCommand
        Dim cmd As MySqlCommand = conexao.CreateCommand
        cmd.CommandText = SQL
        cmd.CommandType = CommandType.Text
        Return cmd
    End Function

    Public Function retornoDataReader(ByVal strQuery As String) As MySqlDataReader

        Dim conexao As New MySqlConnection(stringConexao)
        Try
            conexao.Open()

            'Dim comando As New MySqlCommand()

            comando.CommandText = strQuery
            comando.CommandType = CommandType.Text
            comando.Connection = conexao

            Return comando.ExecuteReader()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
