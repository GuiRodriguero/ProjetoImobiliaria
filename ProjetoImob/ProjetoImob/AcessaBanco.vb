Imports System.Data.SqlClient

Public Class AcessaBanco
    Private sql As String
    Private conecta As String
    Private conexao As SqlConnection
    Private sqlConsulta As SqlCommand

    Public Sub New()
        Dim c As New Caminho 'composição

        conecta = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + c.getEnderecoBanco("Database1.mdf") + ";Integrated Security=True"
        sql = ""
        sqlConsulta = New SqlCommand 'agregação
        'MsgBox(conecta)
        conexao = New SqlConnection(conecta) 'agregação
    End Sub

    Public Sub setSql(ByVal _sql As String)
        sql = _sql
    End Sub

    Public Function getSql() As String
        Return sql
    End Function

    Public Sub abreConexao()
        conexao.Open()
        sqlConsulta.Connection = conexao
    End Sub

    Public Sub executa()
        Dim linhasAfetadas As Integer
        sqlConsulta.CommandText = sql
        linhasAfetadas = sqlConsulta.ExecuteNonQuery
    End Sub
    Public Sub fechaConexao()
        conexao.Close()
    End Sub


    Public Function consulta() As SqlDataReader
        sqlConsulta.CommandText = sql
        Return (sqlConsulta.ExecuteReader())
    End Function
End Class








