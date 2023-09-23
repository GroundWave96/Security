Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.ServiceModel

Public Class CadastrarOficial
    Private excluirExecutado As Boolean = False
    Private Sub CadastrarOficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                Else
                    salvar_cad()
                End If
            End If
            limpar()
        End If

        txt_cpf.Focus()
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
            txt_num.Focus()

        Catch ex As EndpointNotFoundException
            MessageBox.Show("Sem conexão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
    Private Sub txt_senhac_TextChanged(sender As Object, e As EventArgs) Handles txt_senhac.TextChanged
        If txt_senhac.Text <> txt_senha.Text Then
            checks.Visible = False
            unchecks.Visible = True
        Else
            checks.Visible = True
            unchecks.Visible = False
        End If
    End Sub

    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        pnl_cadastrar.Visible = True
        btn_novo.BackColor = Color.FromArgb(169, 169, 169)
        btn_cadastros.BackColor = Color.FromArgb(128, 128, 128)
    End Sub

    Private Sub btn_cadastros_Click(sender As Object, e As EventArgs) Handles btn_cadastros.Click
        pnl_cadastrar.Visible = False
        btn_cadastros.BackColor = Color.FromArgb(169, 169, 169)
        btn_novo.BackColor = Color.FromArgb(128, 128, 128)
        dgv_preencher()
    End Sub



    Private Sub pnl_cadastrar_VisibleChanged(sender As Object, e As EventArgs) Handles pnl_cadastrar.VisibleChanged
        Dim selectedRow As DataGridViewRow = dgv_cadastros.CurrentRow
        If selectedRow IsNot Nothing AndAlso Not selectedRow.IsNewRow Then
            ' Verifica se a coluna "Column5" está sendo clicada
            Dim columnIndex As Integer = dgv_cadastros.Columns("Column5").Index
            If dgv_cadastros.CurrentCell.ColumnIndex = columnIndex AndAlso dgv_cadastros.CurrentCell.RowIndex = selectedRow.Index Then
                ' Coluna "Column5" está sendo clicada para editar
                Dim cpf As String = selectedRow.Cells("Column2").Value.ToString()
                ' Consulta os dados no banco de dados
                Dim query As String = $"SELECT Cpf, Nome, Email, Senha, Cep, Uf, Cidade, Bairro, Rua, Celular, Num_comp FROM tb_cadastro WHERE Cpf = '{cpf}'"
                OpenConnection()
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Preenche os campos TextBox com os valores obtidos
                    txt_cpf.Text = reader("Cpf").ToString()
                    txt_nome.Text = reader("nome").ToString()
                    txt_email.Text = reader("email").ToString()
                    txt_senha.Text = reader("senha").ToString()
                    txt_senhac.Text = reader("senha").ToString()
                    txt_cep.Text = reader("Cep").ToString()
                    txt_estado.Text = reader("Uf").ToString()
                    txt_cidade.Text = reader("Cidade").ToString()
                    txt_bairro.Text = reader("Bairro").ToString()
                    txt_rua.Text = reader("Rua").ToString()
                    txt_celular.Text = reader("Celular").ToString()
                    txt_num.Text = reader("Num_comp").ToString()
                Else
                    ' Caso não haja correspondência no banco de dados, limpa os campos TextBox
                    txt_nome.Text = ""
                    txt_email.Text = ""
                    txt_senha.Text = ""
                    txt_senhac.Text = ""
                    txt_cep.Text = ""
                    txt_estado.Text = ""
                    txt_cidade.Text = ""
                    txt_bairro.Text = ""
                    txt_rua.Text = ""
                    txt_celular.Text = ""
                    txt_num.Text = ""
                End If
                reader.Close()
                CloseConnection()
            Else
                ' Caso a coluna "Column5" não esteja sendo clicada, limpa os campos TextBox
                txt_nome.Text = ""
                txt_email.Text = ""
                txt_senha.Text = ""
                txt_senhac.Text = ""
                txt_cep.Text = ""
                txt_estado.Text = ""
                txt_cidade.Text = ""
                txt_bairro.Text = ""
                txt_rua.Text = ""
                txt_celular.Text = ""
                txt_num.Text = ""
            End If
        Else
            ' Caso não haja uma linha selecionada, limpa os campos TextBox
            txt_nome.Text = ""
            txt_email.Text = ""
            txt_senha.Text = ""
            txt_senhac.Text = ""
            txt_cep.Text = ""
            txt_estado.Text = ""
            txt_cidade.Text = ""
            txt_bairro.Text = ""
            txt_rua.Text = ""
            txt_celular.Text = ""
            txt_num.Text = ""
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
            If cmb_tipo.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cmb_tipo.SelectedItem.ToString()) Then
                ' ComboBox foi selecionada, execute a ação aqui
                If cmb_tipo.SelectedItem.ToString() = "Aten" Then
                    valor_cbm = "1"
                Else
                    valor_cbm = "2"
                End If
                valid = 1
            End If
        End If

    End Sub

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
            cmd.Parameters.AddWithValue("@modo", valor_cbm)
            cmd.ExecuteNonQuery()
            MsgBox("Dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Using
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Dim cpf As String = txt_cpf.Text
        ' Consulta os dados no banco de dados
        Dim query As String = $"SELECT Cpf, Nome, Email, Senha, Cep, Uf, Cidade, Bairro, Rua, Celular, Num_comp FROM tb_cadastro WHERE Cpf = '{cpf}'"
        OpenConnection()
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            ' Preenche os campos TextBox com os valores obtidos
            txt_cpf.Text = reader("Cpf").ToString()
            txt_nome.Text = reader("nome").ToString()
            txt_email.Text = reader("email").ToString()
            txt_senha.Text = reader("senha").ToString()
            txt_senhac.Text = reader("senha").ToString()
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

    Private Function AtualizarDados(cpf As String) As Boolean
        Try
            Dim sql As String = "UPDATE tb_cadastro SET Nome = @nome, Email = @email,
                             Senha = @senha, Cep = @cep, Uf = @uf, Cidade = @cidade,
                             Bairro = @bairro, Rua = @rua, Celular = @celular,
                             Num_comp = @num_comp, modo = @modo WHERE Cpf = @cpf"
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@cpf", cpf)
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text.ToUpper())
                cmd.Parameters.AddWithValue("@email", txt_email.Text.ToUpper())
                cmd.Parameters.AddWithValue("@senha", txt_senha.Text)
                cmd.Parameters.AddWithValue("@cep", txt_cep.Text.ToUpper())
                cmd.Parameters.AddWithValue("@uf", txt_estado.Text.ToUpper())
                cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text.ToUpper())
                cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text.ToUpper())
                cmd.Parameters.AddWithValue("@rua", txt_rua.Text.ToUpper())
                cmd.Parameters.AddWithValue("@celular", txt_celular.Text.ToUpper())
                cmd.Parameters.AddWithValue("@num_comp", txt_num.Text.ToUpper())
                cmd.Parameters.AddWithValue("@modo", valor_cbm)
                cmd.ExecuteNonQuery()
                MsgBox("Dados atualizados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Return True
            End Using
        Catch ex As Exception
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

    Private Sub dgv_cadastros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cadastros.CellContentClick
        If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 Then
            pnl_cadastrar.Visible = True
            btn_novo.BackColor = Color.FromArgb(169, 169, 169)
            btn_cadastros.BackColor = Color.FromArgb(128, 128, 128)
        ElseIf e.ColumnIndex = 5 AndAlso e.RowIndex >= 0 Then
            If Not excluirExecutado Then
                excluirExecutado = True

                ' Exibe uma caixa de diálogo de confirmação
                Dim result As DialogResult = MessageBox.Show("Deseja realmente excluir este cadastro?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Obtém o ID do cadastro a ser excluído
                    Dim cpf As String = dgv_cadastros.Rows(e.RowIndex).Cells("Column2").Value

                    Try
                        ' Abre a conexão com o banco de dados
                        OpenConnection()

                        ' Executa o comando SQL para excluir o cadastro
                        Dim sql As String = "DELETE FROM tb_cadastro WHERE cpf = @cpf"
                        Using cmd As New SqlCommand(sql, connection)
                            cmd.Parameters.AddWithValue("@cpf", cpf)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Remove a linha da DataGridView
                        dgv_cadastros.Rows.RemoveAt(e.RowIndex)

                        ' Exibe uma mensagem de sucesso
                        MsgBox("Cadastro excluído com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Catch ex As Exception
                        MsgBox("Erro ao excluir o cadastro.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Finally
                        ' Fecha a conexão com o banco de dados
                        CloseConnection()
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub dgv_preencher()
        OpenConnection()

        AddHandler dgv_cadastros.CellContentClick, AddressOf dgv_cadastros_CellContentClick
        Dim sql = "SELECT * FROM tb_cadastro WHERE modo <> 0"
        Using da = New SqlDataAdapter(sql, connection)
            Using dt = New DataTable()
                da.Fill(dt)
                dgv_cadastros.Rows.Clear()
                For Each row As DataRow In dt.Rows
                    Dim index As Integer = dgv_cadastros.Rows.Add()
                    dgv_cadastros.Rows(index).Cells("Column1").Value = row("Nome")
                    dgv_cadastros.Rows(index).Cells("Column2").Value = row("Cpf")
                    dgv_cadastros.Rows(index).Cells("Column3").Value = row("Email")
                    dgv_cadastros.Rows(index).Cells("Column4").Value = row("Celular")
                    Dim modo As Integer = CInt(row("modo"))
                Next row
            End Using
        End Using
        CloseConnection()
    End Sub
End Class
