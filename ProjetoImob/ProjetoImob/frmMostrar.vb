Imports System.Data.SqlClient

Public Class frmMostrar
    Private Sub frmMostrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.cliente_tb' table. You can move, or remove it, as needed.
        Me.Cliente_tbTableAdapter.Fill(Me.Database1DataSet1.cliente_tb)
        'TODO: This line of code loads data into the 'Database1DataSet.cliente' table. You can move, or remove it, as needed.
        Me.Cliente_tbTableAdapter.Fill(Me.Database1DataSet1.cliente_tb)


    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Public Sub FilterData(valueToSearch As String)
        'Dim a1 As New AcessaBanco()
        Dim c As New Caminho()
        Dim scn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + c.getEnderecoBanco("Database1.mdf") + "Integrated Security=True")
        Dim searchQuery As String = "SELECT * From cliente_tb WHERE cpf like '%" + TextBox1.Text + "%'"

        Dim command As New SqlCommand(searchQuery, scn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgvCliente.DataSource = table

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FilterData(TextBox1.Text)
    End Sub


End Class