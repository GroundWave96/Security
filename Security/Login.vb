Imports System.Data.SqlClient

Public Class Login
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

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Cadastro.Show()
        Me.Hide()
    End Sub

    Private Sub btn_esqueci_Click(sender As Object, e As EventArgs) Handles btn_esqueci.Click
        Recupera.Show()
        Me.Hide()
    End Sub

    Private Sub btn_entrar_Click_1(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim username As String = txt_cpf.Text
        Dim password As String = txt_senha.Text
        senhae = txt_senha.Text
        If txt_cpf.Text = "   .   .   -" Or txt_senha.Text = "" Then
            MessageBox.Show("Por favor, preencha todos os campos!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf AuthenticateUser(username, password) Then
            MsgBox("Bem vindo(a), " & nomee & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            If validar_modo = 0 Then
                Me.Hide()
                Programa.Show()
            ElseIf validar_modo = 1 Then 'Login do planejador
                Me.Hide()
                ProgramaAtend.Show()
            ElseIf validar_modo = 2 Then 'Login do planejador
                Me.Hide()
                ProgramaPlan.Show()
            End If

        Else
            MessageBox.Show("Usuário e/ou senha incorreto(s)." & System.Environment.NewLine & "          Tente novamente!", "Dados incorretos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_senha.Clear()
            txt_senha.Focus()
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = $"SELECT * FROM tb_cadastro WHERE Cpf = @username AND senha = @password"
        Using connection As New SqlConnection(Mod_geral.strCon)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        ' Obter o valor da coluna "Nome" e atribuir à variável pública "nomee"
                        Mod_geral.nomee = reader.GetString(reader.GetOrdinal("Nome"))

                        ' Obter o valor da coluna "Cpf" e atribuir à variável pública "cpfe"
                        Mod_geral.cpfe = reader.GetString(reader.GetOrdinal("Cpf"))

                        ' Obter o valor da coluna "modo" e atribuir à variável pública "modoV"
                        Mod_geral.validar_modo = reader.GetByte(reader.GetOrdinal("modo")).ToString()
                    End While

                    reader.Close()
                    Return True
                Else
                    reader.Close()
                    Return False
                End If
            End Using
        End Using
    End Function


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            OpenConnection()
        Catch ex As Exception
            MessageBox.Show("Sem conexão com o banco de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
