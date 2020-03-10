Public Class Caminho
    Private endereco As String
    Private arquivoInfo As System.IO.FileInfo

    Public Sub New()
        endereco = ""
        arquivoInfo = Nothing
    End Sub

    Public Function getEndereco(ByVal arquivo As String) As String
        arquivoInfo = My.Computer.FileSystem.GetFileInfo(arquivo)
        endereco = arquivoInfo.FullName
        Return endereco
    End Function

    Public Function getEnderecoBanco(ByVal arquivo As String) As String
        arquivoInfo = My.Computer.FileSystem.GetFileInfo(arquivo)
        endereco = arquivoInfo.DirectoryName
        endereco = endereco.Substring(0, endereco.IndexOf("\bin\Debug")) +
                "\" + arquivo
        'MsgBox("Endereço = " & endereco)
        Return endereco
    End Function

End Class
