Public Class LoginForm1

    ' TODO: Inserir c�digo para realizar autentica��o personalizada utilizando o nome de usu�rio e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de seguran�a personalizada pode ser anexada � entidade de seguran�a da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal � a implementa��o de IPrincipal usada para realizar a autentica��o. 
    ' Subsequentemente, My.User ir� retornar informa��es de identifica��o encapsuladas num objeto CustomPrincipal
    ' como nome de usu�rio, nome de exibi��o etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = "" Then
            MsgBox("Digite o usu�rio!")
        End If

        If PasswordTextBox.Text = "" Then
            MsgBox("Digite a senha!")
        End If

        If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "Chacara@Curu�a" Then
            Dim m1 As New mdiPrincipal

            Me.Hide()
            m1.Show()

        ElseIf UsernameTextBox.Text <> "" And PasswordTextBox.Text <> "" Then
            MsgBox("Usu�rio ou Senha incorreto(os)!")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
