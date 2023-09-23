Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Recupera
    'mover form
    Private Declare Function SendMessageW Lib "User32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    Private Declare Sub ReleaseCapture Lib "User32.dll" ()
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = 2
    Dim randomCode As String
    Public Shared toUser As String

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

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        OpenConnection()
        Dim emailExistente As Boolean = verificar_email(reg_id)
        If emailExistente Then
            Dim from, pass, messageBody As String
            Dim rand As Random = New Random()
            randomCode = (rand.Next(999999)).ToString()
            Dim message As MailMessage = New MailMessage()
            toUser = txt_email.Text
            from = "naoresponda40@gmail.com"
            pass = "uvhhfrvveusoxfvn"
            messageBody = "Seu código para alterar a senha é " + randomCode
            message.To.Add(toUser)
            message.From = New MailAddress(from)
            message.Body = messageBody
            message.Subject = "Security - Alterar Senha"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = smtp.DeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)
            Try
                smtp.Send(message)
                MessageBox.Show("Cheque seu e-mail e insira o código!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Não foi possivel enviar o e-mail!" + vbNewLine + "Erro: "(ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MsgBox("Este E-mail '" & txt_email.Text & "' não consta em nosso banco de dados", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If

        CloseConnection()

    End Sub
    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        If txt_codigo.Text.Equals(randomCode) Then
            toUser = txt_email.Text
            Dim AlteraSenha As AlteraSenha = New AlteraSenha()
            AlteraSenha.Show()
            Me.Hide()
            Dim sc As Recupera = New Recupera()
            sc.Hide()
        Else
            MessageBox.Show("Código Inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Function verificar_email(id As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_cadastro WHERE Email = @email"
        Using cmd As New SqlCommand(sql, connection)
            emaile = txt_email.Text
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

End Class