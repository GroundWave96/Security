Imports System.Data.SqlClient
Imports System.Net
Imports System.ServiceModel
Imports System.Windows

Public Class Cadastro
    'mover form
    Private Declare Function SendMessageW Lib "User32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    Private Declare Sub ReleaseCapture Lib "User32.dll" ()
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = 2

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessageW(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Dim resp As Integer

        resp = MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click
        btn_hide.Visible = False
        btn_view.Visible = True
        txt_senha.PasswordChar = "•"
        txt_senhac.PasswordChar = "•"
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        btn_hide.Visible = True
        btn_view.Visible = False
        txt_senha.PasswordChar = ""
        txt_senhac.PasswordChar = ""
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub txt_senhac_TextChanged(sender As Object, e As EventArgs) Handles txt_senhac.TextChanged
        If txt_senhac.Text <> txt_senha.Text Then
            checks.Visible = False
            unchecks.Visible = True
        Else
            checks.Visible = True
            unchecks.Visible = False
        End If
    End Sub

    Private Sub btn_cadastrar_Click_1(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        OpenConnection()

        ' Verifica se o ID já existe na tabela
        Dim cpfExistente As Boolean = VerificarCpfExistente(reg_id)
        Dim emailExistente As Boolean = VerificarEmailExistente(reg_id)
        Dim celExistente As Boolean = VerificarCelExistente(reg_id)
        validar()
        If valid = 1 Then
            If cpfExistente Then
                MsgBox("Já existe cadastro com esse numero de CPF", vbExclamation + vbOKOnly, "ATENÇÃO")
                MsgBox("Caso não se lembre da senha, tente o esqueci minha senha na tela de login", vbInformation + vbOKOnly, "AVISO")
            ElseIf emailExistente Then
                MsgBox("Esse E-mail já esta sendo utilizado por outro cadastro", vbExclamation + vbOKOnly, "ATENÇÃO")
            ElseIf celExistente Then
                MsgBox("Esse numero de Celular já esta sendo utilizado por outro cadastro", vbExclamation + vbOKOnly, "ATENÇÃO")
            Else
                salvar_cad()
                limpar()
                Me.Close()
                Login.Show()
                Login.txt_cpf.Focus()
            End If
        End If
        CloseConnection()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Try
            Dim WS = New Correios.AtendeClienteClient
            Dim resp = WS.consultaCEP(txt_cep.Text)
            txt_estado.Text = resp.uf
            txt_cidade.Text = resp.cidade
            txt_bairro.Text = resp.bairro
            txt_rua.Text = resp.end
        Catch ex As EndpointNotFoundException
            MessageBox.Show("Sem conexão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub salvar_cad()
        Dim sql = "INSERT INTO tb_cadastro (Nome, Email, Cpf, Senha, Cep, Uf, Cidade, Bairro, Rua, Celular, Num_comp, modo)
                      VALUES
                      (@Nome, @Email, @Cpf, @Senha, @Cep, @Uf, @Cidade, @Bairro, @Rua, @Celular, @Num_comp, @modo)"
        Using cmd = New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@Nome", txt_nome.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Email", txt_email.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Cpf", txt_cpf.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Senha", txt_senha.Text)
            cmd.Parameters.AddWithValue("@Cep", txt_cep.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Uf", txt_estado.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Cidade", txt_cidade.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Bairro", txt_bairro.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Rua", txt_rua.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Celular", txt_celular.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Num_comp", txt_num.Text.ToUpper())
            cmd.Parameters.AddWithValue("@modo", "0")
            cmd.ExecuteNonQuery()
            MsgBox("Dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Using
    End Sub

    Private Sub validar()

        Dim senha As String = txt_senha.Text
        Dim confirmacaoSenha As String = txt_senhac.Text
        If senha <> confirmacaoSenha Then
            MsgBox("As Senhas precisam ser Iguais", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            txt_senha.Focus()
            valid = 0
        ElseIf txt_senha.Text = "" Or txt_email.Text = "" Or txt_cpf.Text = "   .   .   -" Or txt_senhac.Text = "" Or txt_nome.Text = "" Or txt_celular.Text = "(  )       -" Or txt_cidade.Text = "" _
                Or txt_bairro.Text = "" Or txt_cep.Text = "     -" Or txt_estado.Text = "" Or txt_rua.Text = "" Or txt_num.Text = "" Then
            MsgBox(" Preencha todos os campos para se cadastrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            valid = 0
        Else
            valid = 1
        End If

    End Sub
    Private Function VerificarCpfExistente(id As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_cadastro WHERE Cpf = @cpf"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function
    Private Function VerificarEmailExistente(id As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_cadastro WHERE Email = @email"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function
    Private Function VerificarCelExistente(id As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_cadastro WHERE Celular = @cel"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@cel", txt_celular.Text)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function
    Private Sub limpar()
        txt_nome.Clear()
        txt_email.Clear()
        txt_cpf.Clear()
        txt_senha.Clear()
        txt_senhac.Clear()
        txt_cep.Clear()
        txt_estado.Clear()
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_rua.Clear()
        txt_celular.Clear()
        txt_num.Clear()
    End Sub
End Class
