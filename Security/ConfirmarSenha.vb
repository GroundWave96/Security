Public Class ConfirmarSenha
    Public EditarCadastro As EditarCadastro
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

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_senha.Text = senhae Then
            Me.EditarCadastro.HabilitarCampos()
            Me.Close()
        Else
            MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class