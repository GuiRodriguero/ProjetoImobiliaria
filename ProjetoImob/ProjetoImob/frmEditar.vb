Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc


Public Class frmEditar
    Dim sexo As String

    Private Sub frmEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If (rdbFem.Checked = True) Then
            sexo = rdbFem.Text
        Else
            sexo = rdbMasc.Text
        End If

        Dim a1 As New AcessaBanco()
        a1.abreConexao()

        a1.setSql("Update [dbo].[cliente_tb] set nome = '" + txtNome.Text + "', sexo = '" + sexo + "', data = '" + dtpNascimento.Value + "', tel_fixo= '" + txtTelFixo.Text + "', tel_movel= '" + txtTelMovel.Text + "', estado_civil= '" + cbxEstadoCivil.Text + "', rg= '" + txtRg.Text + "', cpf= '" + txtCpf.Text + "', email= '" + txtEmail.Text + "', rua= '" + txtRua.Text + "', numero='" + txtN.Text + "', complemeto= '" + txtComplemento.Text + "', cep= '" + txtCep.Text + "', tipo_funcionario= '" + cbxFuncionario.Text + "', nome_empresa= '" + txtNomeEmpresa.Text + "', cnpj= '" + txtCnpj.Text + "', n_pis= '" + txtNpis.Text + "', profissao= '" + txtProfissao.Text + "', cargo = '" + txtCargo.Text + "', renda_familiar= '" + txtRenda.Text + "', interesse_imovel= '" + txtInteresse.Text + "', anexo1= '" + txtArquivo1.Text + "', anexo2= '" + txtArquivo2.Text + "', anexo3= '" + txtArquivo3.Text + "', anexo4= '" + txtArquivo4.Text + "', anexo5= '" + txtArquivo5.Text + "', anexo6= '" + txtArquivo6.Text + "', anexo7= '" + txtArquivo7.Text + "', anexo8= '" + txtArquivo8.Text + "', anexo9= '" + txtArquivo9.Text + "', anexo10= '" + txtArquivo10.Text + "', anexo11= '" + txtArquivo11.Text + "', anexo12= '" + txtArquivo12.Text + "', anexo13= '" + txtArquivo13.Text + "', anexo14= '" + txtArquivo14.Text + "', anexo15= '" + txtArquivo15.Text + "', anexo16= '" + txtArquivo16.Text + "', anexo17= '" + txtArquivo17.Text + "', anexo18= '" + txtArquivo18.Text + "', anexo19= '" + txtArquivo19.Text + "', anexo20= '" + txtArquivo20.Text + "', anexo21= '" + txtArquivo21.Text + "',anexo22= '" + txtArquivo22.Text + "', anexo23= '" + txtArquivo23.Text + "', anexo24= '" + txtArquivo24.Text + "' where cpf = '" + txtCpf.Text + "'")
        a1.executa()
        a1.fechaConexao()

        MsgBox("Informações Atualizadas com Sucesso!")
        Me.Close()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnAnexar_Click(sender As System.Object, e As System.EventArgs) Handles btnAnexar1.Click

        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        For Each arquivo As [String] In ofd1.FileNames
            txtArquivo1.Text += arquivo & vbNewLine
        Next
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCpf.Text = "" Then
            MsgBox("Favor, digite o CPF")
        Else
            Dim a1 As New AcessaBanco()
            a1.abreConexao()

            a1.setSql("SELECT * From cliente_tb where cpf like '" + txtCpf.Text + "'")



            Dim dados As SqlDataReader
            dados = a1.consulta()
            Do While (dados.Read())


                txtNome.Text = dados.GetValue(1).ToString()

                If dados.GetValue(2).ToString = "Masculino" Then
                    rdbMasc.Checked = True
                Else
                    rdbFem.Checked = True
                End If

                dtpNascimento.Value = dados.GetValue(3)

                txtTelFixo.Text = dados.GetValue(4).ToString()

                txtTelMovel.Text = dados.GetValue(5).ToString()

                cbxEstadoCivil.Text = dados.GetValue(6).ToString()

                txtRg.Text = dados.GetValue(7).ToString()

                txtCpf.Text = dados.GetValue(8).ToString()

                txtEmail.Text = dados.GetValue(9).ToString()

                txtRua.Text = dados.GetValue(10).ToString()

                txtN.Text = dados.GetValue(11).ToString()

                txtComplemento.Text = dados.GetValue(12).ToString()

                txtCep.Text = dados.GetValue(13).ToString()

                txtCidade.Text = dados.GetValue(14).ToString()

                txtBairro.Text = dados.GetValue(15).ToString()

                cbxFuncionario.Text = dados.GetValue(16).ToString()

                txtNomeEmpresa.Text = dados.GetValue(17).ToString()

                txtCnpj.Text = dados.GetValue(18).ToString()

                txtNpis.Text = dados.GetValue(19).ToString()

                txtProfissao.Text = dados.GetValue(20).ToString()

                txtCargo.Text = dados.GetValue(21).ToString()

                txtRenda.Text = dados.GetValue(22).ToString()

                txtInteresse.Text = dados.GetValue(23).ToString()

                txtArquivo1.Text = dados.GetValue(24).ToString()

                txtArquivo2.Text = dados.GetValue(25).ToString()

                txtArquivo3.Text = dados.GetValue(26).ToString()

                txtArquivo4.Text = dados.GetValue(27).ToString()

                txtArquivo5.Text = dados.GetValue(28).ToString()

                txtArquivo6.Text = dados.GetValue(29).ToString()

                txtArquivo7.Text = dados.GetValue(30).ToString()

                txtArquivo8.Text = dados.GetValue(31).ToString()

                txtArquivo9.Text = dados.GetValue(32).ToString()

                txtArquivo10.Text = dados.GetValue(33).ToString()

                txtArquivo11.Text = dados.GetValue(34).ToString()

                txtArquivo12.Text = dados.GetValue(35).ToString()

                txtArquivo13.Text = dados.GetValue(36).ToString()

                txtArquivo14.Text = dados.GetValue(37).ToString()

                txtArquivo15.Text = dados.GetValue(38).ToString()

                txtArquivo16.Text = dados.GetValue(39).ToString()

                txtArquivo17.Text = dados.GetValue(40).ToString()

                txtArquivo18.Text = dados.GetValue(41).ToString()

                txtArquivo19.Text = dados.GetValue(42).ToString()

                txtArquivo20.Text = dados.GetValue(43).ToString()

                txtArquivo21.Text = dados.GetValue(44).ToString()

                txtArquivo22.Text = dados.GetValue(42).ToString()

                txtArquivo23.Text = dados.GetValue(46).ToString()

                txtArquivo24.Text = dados.GetValue(47).ToString()

            Loop
            a1.fechaConexao()
        End If
    End Sub
End Class