Imports System
Imports System.IO
Imports System.Security

Public Class frmCliente

    Dim sexo As String

    Private Sub frmCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAnexar_Click(sender As System.Object, e As System.EventArgs) Handles btnAnexar1.Click

        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo1.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnCadastrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCadastrar.Click

        If (rdbFem.Checked = True) Then
            sexo = rdbFem.Text
        Else
            sexo = rdbMasc.Text
        End If

        Dim a1 As New AcessaBanco()
        a1.abreConexao()

        a1.setSql("Insert into [dbo].[cliente_tb] (nome, sexo, data, tel_fixo, tel_movel, estado_civil, rg, cpf, email, rua, numero, complemeto, cep, cidade, bairro, tipo_funcionario, nome_empresa, cnpj, n_pis, profissao, cargo, renda_familiar, interesse_imovel, anexo1, anexo2, anexo3, anexo4, anexo5, anexo6, anexo7, anexo8, anexo9, anexo10, anexo11, anexo12, anexo13, anexo14, anexo15, anexo16, anexo17, anexo18, anexo19, anexo20, anexo21, anexo22, anexo23, anexo24) values('" + txtNome.Text + "', '" + sexo + "', '" + dtpNascimento.Text + "','" + txtTelFixo.Text + "', '" + txtTelMovel.Text + "', '" + cbxEstadoCivil.Text + "', '" + txtRg.Text + "', '" + txtCpf.Text + "', '" + txtEmail.Text + "', '" + txtRua.Text + "', '" + txtN.Text + "', '" + txtComplemento.Text + "', '" + txtCep.Text + "', '" + txtCidade.Text + "', '" + txtCep.Text + "', '" + cbxFuncionario.Text + "', '" + txtNomeEmpresa.Text + "', '" + txtCnpj.Text + "', '" + txtNpis.Text + "', '" + txtProfissao.Text + "','" + txtCargo.Text + "', '" + txtRenda.Text + "', '" + txtInteresse.Text + "', '" + txtArquivo1.Text + "', '" + txtArquivo2.Text + "', '" + txtArquivo3.Text + "', '" + txtArquivo4.Text + "', '" + txtArquivo5.Text + "', '" + txtArquivo6.Text + "', '" + txtArquivo7.Text + "', '" + txtArquivo8.Text + "', '" + txtArquivo9.Text + "', '" + txtArquivo10.Text + "', '" + txtArquivo11.Text + "', '" + txtArquivo12.Text + "', '" + txtArquivo13.Text + "', '" + txtArquivo14.Text + "', '" + txtArquivo15.Text + "', '" + txtArquivo16.Text + "', '" + txtArquivo17.Text + "', '" + txtArquivo18.Text + "', '" + txtArquivo19.Text + "', '" + txtArquivo20.Text + "', '" + txtArquivo21.Text + "', '" + txtArquivo21.Text + "', '" + txtArquivo23.Text + "', '" + txtArquivo24.Text + "')")

        a1.executa()
        a1.fechaConexao()

        MsgBox("Cliente Cadastrado com Sucesso!!")

        Me.Close()
    End Sub

    Private Sub btnAnexar2_Click(sender As System.Object, e As System.EventArgs) Handles btnAnexar2.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo2.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar3_Click(sender As System.Object, e As System.EventArgs) Handles btnAnexar3.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo3.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar4_Click(sender As Object, e As EventArgs) Handles btnAnexar4.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo4.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar5_Click(sender As Object, e As EventArgs) Handles btnAnexar5.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo5.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar6_Click(sender As Object, e As EventArgs) Handles btnAnexar6.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo6.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar7_Click(sender As Object, e As EventArgs) Handles btnAnexar7.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo7.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar8_Click(sender As Object, e As EventArgs) Handles btnAnexar8.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo8.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar9_Click(sender As Object, e As EventArgs) Handles btnAnexar9.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo9.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar10_Click(sender As Object, e As EventArgs) Handles btnAnexar10.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo10.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar11_Click(sender As Object, e As EventArgs) Handles btnAnexar11.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo11.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar12_Click(sender As Object, e As EventArgs) Handles btnAnexar12.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo12.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar13_Click(sender As Object, e As EventArgs) Handles btnAnexar13.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo13.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar14_Click(sender As Object, e As EventArgs) Handles btnAnexar14.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo14.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar15_Click(sender As Object, e As EventArgs) Handles btnAnexar15.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo15.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar16_Click(sender As Object, e As EventArgs) Handles btnAnexar16.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo16.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar17_Click(sender As Object, e As EventArgs) Handles btnAnexar17.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo17.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar18_Click(sender As Object, e As EventArgs) Handles btnAnexar18.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo18.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar19_Click(sender As Object, e As EventArgs) Handles btnAnexar19.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo19.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar20_Click(sender As Object, e As EventArgs) Handles btnAnexar20.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo20.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar21_Click(sender As Object, e As EventArgs) Handles btnAnexar21.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo21.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar22_Click(sender As Object, e As EventArgs) Handles btnAnexar22.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo22.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar23_Click(sender As Object, e As EventArgs) Handles btnAnexar23.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo23.Text += arquivo & vbNewLine
        Next
    End Sub

    Private Sub btnAnexar24_Click(sender As Object, e As EventArgs) Handles btnAnexar24.Click
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo24.Text += arquivo & vbNewLine
        Next
    End Sub


    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'ver se cpf já esta cadastado
    End Sub
End Class
