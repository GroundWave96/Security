Imports System.Data.SqlClient
Imports System.ServiceModel
Imports Security.Correios

Public Class EditarCadastro
    Public verificado As Boolean
    Public Sub HabilitarCampos()
        txt_nome.Enabled = True
        txt_cpf.Enabled = True
        txt_email.Enabled = True
        txt_celular.Enabled = True
        txt_cep.Enabled = True
        txt_estado.Enabled = True
        txt_cidade.Enabled = True
        txt_bairro.Enabled = True
        txt_rua.Enabled = True
        txt_num.Enabled = True
        btn_editar.Enabled = True
        btn_editarSenha.Enabled = True
    End Sub
    Private Sub EditarCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfirmarSenha.EditarCadastro = Me
        ConfirmarSenha.Show()
        ConfirmarSenha.BringToFront()
        Dim cpf As String = cpfe
        ' Consulta os dados no banco de dados
        Dim query As String = $"SELECT Cpf, Nome, Email, Cep, Uf, Cidade, Bairro, Rua, Celular, Num_comp FROM tb_cadastro WHERE Cpf = '{cpf}'"
        OpenConnection()
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            ' Preenche os campos TextBox com os valores obtidos
            txt_cpf.Text = reader("Cpf").ToString()
            txt_nome.Text = reader("nome").ToString()
            txt_email.Text = reader("email").ToString()
            txt_cep.Text = reader("Cep").ToString()
            txt_estado.Text = reader("Uf").ToString()
            txt_cidade.Text = reader("Cidade").ToString()
            txt_bairro.Text = reader("Bairro").ToString()
            txt_rua.Text = reader("Rua").ToString()
            txt_celular.Text = reader("Celular").ToString()
            txt_num.Text = reader("Num_comp").ToString()
        End If
        CloseConnection()

    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        OpenConnection()

        ' Verifica se o CPF já existe na tabela
        Dim cpfExistente As Boolean = VerificarCPFExistente(txt_cpf.Text)
        Dim emailExistente As Boolean = VerificarEmailExistente(txt_email.Text)
        Dim celExistente As Boolean = VerificarCelExistente(txt_celular.Text)

        validar()

        If valid = 1 Then
            If cpfExistente <> "0" Then
                ' CPF existente, realizar atualização dos dados
                If AtualizarDados(txt_cpf.Text) Then
                Else
                    MsgBox("Erro ao atualizar os dados!", vbExclamation + vbOKOnly, "ATENÇÃO")
                End If
            Else
                ' CPF não existente, realizar gravação dos dados
                If emailExistente AndAlso VerificarEmailExistente(txt_email.Text) Then
                    MsgBox("Esse E-mail já está sendo utilizado por outro cadastro", vbExclamation + vbOKOnly, "ATENÇÃO")
                ElseIf celExistente AndAlso VerificarCelExistente(txt_celular.Text) Then
                    MsgBox("Esse número de Celular já está sendo utilizado por outro cadastro", vbExclamation + vbOKOnly, "ATENÇÃO")

                End If
            End If
        End If

        txt_cpf.Focus()
        CloseConnection()
    End Sub

    Private Sub btn_editarSenha_Click(sender As Object, e As EventArgs) Handles btn_editarSenha.Click
        EditarSenha.Show()
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
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function AtualizarDados(cpf As String) As Boolean
        Try
            Dim sql As String = "UPDATE tb_cadastro SET Nome = @nome, Email = @email,
                            Cep = @cep, Uf = @uf, Cidade = @cidade,
                            Bairro = @bairro, Rua = @rua, Celular = @celular,
                            Num_comp = @num_comp WHERE Cpf = @cpf"
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@cpf", cpfe)
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text.ToUpper())
                cmd.Parameters.AddWithValue("@email", txt_email.Text.ToUpper())
                cmd.Parameters.AddWithValue("@cep", txt_cep.Text.ToUpper())
                cmd.Parameters.AddWithValue("@uf", txt_estado.Text.ToUpper())
                cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text.ToUpper())
                cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text.ToUpper())
                cmd.Parameters.AddWithValue("@rua", txt_rua.Text.ToUpper())
                cmd.Parameters.AddWithValue("@celular", txt_celular.Text.ToUpper())
                cmd.Parameters.AddWithValue("@num_comp", txt_num.Text.ToUpper())
                cmd.ExecuteNonQuery()
                MsgBox("Dados atualizados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Return True
            End Using
        Catch ex As System.Exception
            MsgBox("Erro ao atualizar os dados: " + ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Return False
        End Try
    End Function


    Private Function VerificarCPFExistente(cpf As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_cadastro WHERE Cpf = @cpf"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@cpf", cpf)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function


    Private Sub validar()

        If txt_email.Text = "" Or txt_cpf.Text = "   .   .   -" Or txt_nome.Text = "" Or txt_celular.Text = "(  )       -" Or txt_cidade.Text = "" _
                Or txt_bairro.Text = "" Or txt_cep.Text = "     -" Or txt_estado.Text = "" Or txt_rua.Text = "" Or txt_num.Text = "" Then
            MsgBox(" Preencha todos os campos para se cadastrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            valid = 0
        Else
            valid = 1
        End If

    End Sub

    Private Function VerificarEmailExistente(email As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_cadastro WHERE Email = @email"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@email", email)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Function VerificarCelExistente(celular As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_cadastro WHERE Celular = @celular"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@celular", celular)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function
End Class