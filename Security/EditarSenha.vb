Imports System.Data.SqlClient

Public Class EditarSenha
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

    Private Sub btn_fechar_Click_1(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()
    End Sub

    Private Sub btn_minimizar_Click_1(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click
        btn_hide.Visible = False
        btn_view.Visible = True
        txt_senha.PasswordChar = "•"
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        btn_hide.Visible = True
        btn_view.Visible = False
        txt_senha.PasswordChar = ""
    End Sub

    Private Sub btn_hiden_Click(sender As Object, e As EventArgs) Handles btn_hiden.Click
        btn_hide.Visible = False
        btn_view.Visible = True
        txt_senhan.PasswordChar = "•"
        txt_senhanc.PasswordChar = "•"
    End Sub

    Private Sub btn_viewn_Click(sender As Object, e As EventArgs) Handles btn_viewn.Click
        btn_hide.Visible = True
        btn_view.Visible = False
        txt_senhan.PasswordChar = ""
        txt_senhanc.PasswordChar = ""
    End Sub

    Private Sub btn_entrar_Click_1(sender As Object, e As EventArgs) Handles btn_alterar.Click
        If txt_senhan.Text = txt_senhanc.Text Then
            Atualizarsenha(reg_id)
            Me.Close() ' Fecha o formulário atual (Formulário de troca de senha)

        Else
            MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txt_senhanc_TextChanged(sender As Object, e As EventArgs) Handles txt_senhanc.TextChanged
        If txt_senhanc.Text <> txt_senhan.Text Then
            checks.Visible = False
            unchecks.Visible = True
        Else
            checks.Visible = True
            unchecks.Visible = False
        End If
    End Sub

    Private Sub EditarSenha_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_senha.Text = senhae
    End Sub
    Private Sub Atualizarsenha(id As Integer)
        OpenConnection()
        Dim sql As String = "UPDATE tb_cadastro SET senha = @senha WHERE Cpf = @cpf"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@cpf", cpfe)
            cmd.Parameters.AddWithValue("@senha", txt_senhan.Text)
            cmd.ExecuteNonQuery()
            MsgBox("senha atualizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Using
        CloseConnection()
    End Sub
End Class