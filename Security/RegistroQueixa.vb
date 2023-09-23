Imports System.Data.SqlClient

Public Class RegistroQueixa
    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        OpenConnection()
        validar()
        If valid = 1 Then
            salvar_queixa()
            limpar()
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

        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub salvar_queixa()
        Dim sql = "INSERT INTO tb_ocorrencia (registrador, Data, Hora, Tipo, CEP, UF, Cidade, Bairro, Rua, Num, Info, Solicitante)
                      VALUES
                      (@registrador, @Data, @Hora, @Tipo, @CEP, @UF, @Cidade, @Bairro, @Rua, @Num, @Info, @Solicitante)"
        Using cmd = New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@registrador", cpfe)
            cmd.Parameters.AddWithValue("@Data ", txt_data.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Hora", txt_hora.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Tipo", cmb_tipo.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@CEP", txt_cep.Text.ToUpper())
            cmd.Parameters.AddWithValue("@UF", txt_estado.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Cidade", txt_cidade.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Bairro", txt_bairro.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Rua", txt_rua.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Num", txt_num.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Info", txt_info.Text.ToUpper())
            cmd.Parameters.AddWithValue("@Solicitante", txt_cpf.Text.ToUpper())
            cmd.ExecuteNonQuery()
            MsgBox("Ocorrência gravada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Using
    End Sub

    Private Sub validar()

        If txt_data.Text = "" Or txt_hora.Text = "" Or txt_cpf.Text = "   .   .   -" Or txt_cidade.Text = "" Or txt_info.Text = "" Or txt_bairro.Text = "" Or txt_cep.Text = "     -" Or txt_estado.Text = "" Or txt_rua.Text = "" Or txt_num.Text = "" Or cmb_tipo.SelectedItem Is Nothing Then

            MsgBox("Preencha todos os campos para se cadastrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            valid = 0
        Else
            valid = 1
        End If

    End Sub

    Private Sub limpar()
        txt_data.Clear()
        txt_hora.Clear()
        txt_cpf.Clear()
        txt_info.Clear()
        txt_cep.Clear()
        txt_estado.Clear()
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_rua.Clear()
        txt_num.Clear()
        cmb_tipo.SelectedIndex = -1
    End Sub
End Class