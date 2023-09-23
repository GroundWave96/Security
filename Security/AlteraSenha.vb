Imports System.Data.SqlClient

Public Class AlteraSenha
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
        Dim resp As Integer

        resp = MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub btn_minimizar_Click_1(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
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

    Private Sub btn_trocarSenha_Click(sender As Object, e As EventArgs) Handles btn_trocarSenha.Click
        If txt_senha.Text = txt_senhac.Text Then
            Atualizarsenha(reg_id)
            Me.Close() ' Fecha o formulário atual (Formulário de troca de senha)
            Dim loginForm As New Login()
            loginForm.Show()
        Else
            MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Atualizarsenha(id As Integer)
        OpenConnection()
        Dim sql As String = "UPDATE tb_cadastro SET senha = @senha WHERE Email = @email"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@email", emaile)
            cmd.Parameters.AddWithValue("@senha", txt_senha.Text)
            cmd.ExecuteNonQuery()
            MsgBox("senha atualizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Using
        CloseConnection()
    End Sub

End Class