Public Class LoginForm1

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = "" Then
            MsgBox("Digite o usuário!")
        End If

        If PasswordTextBox.Text = "" Then
            MsgBox("Digite a senha!")
        End If

        If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "Chacara@Curuça" Then
            Dim m1 As New mdiPrincipal

            Me.Hide()
            m1.Show()

        ElseIf UsernameTextBox.Text <> "" And PasswordTextBox.Text <> "" Then
            MsgBox("Usuário ou Senha incorreto(os)!")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
