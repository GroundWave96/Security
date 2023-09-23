Public Class ProgramaPlan
    'mover form
    Private Declare Function SendMessageW Lib "User32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    Private Declare Sub ReleaseCapture Lib "User32.dll" ()
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = 2
    Private Sub adjusttext()
        Dim fit As Boolean = False
        Dim cursize As Single
        Dim sizestep As Single = 1
        Do Until fit
            cursize += sizestep
            Dim fnt As Font = New Font(lbl_nome.Font.Name, cursize)
            Dim textsize As Size = TextRenderer.MeasureText(lbl_nome.Text, fnt)
            If textsize.Height >= lbl_nome.Height Or textsize.Width >= lbl_nome.Width Or lbl_nome.Height = 0 Or lbl_nome.Width = 0 Then
                fit = True
                If textsize.Width > lbl_nome.Width Then
                    cursize -= sizestep
                End If
                If textsize.Height > lbl_nome.Height Then
                    cursize -= sizestep
                End If
            End If
        Loop
        If cursize >= 0 Then
            lbl_nome.Font = New Font(lbl_nome.Font.Name, cursize)
            Application.DoEvents()
        End If
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessageW(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub lbl_titulo_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbl_titulo.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessageW(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Programa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = "" & nomee & "" 'NOME DO USUARIO PELO BANCO DE DADOS ----------------------------------------------------------------------
        adjusttext()

        pnlNav.Height = btn_inicio.Height
        pnlNav.Top = btn_inicio.Top
        pnlNav.Left = btn_inicio.Left
        btn_inicio.BackColor = Color.FromArgb(169, 169, 169)
        btn_inicio.ForeColor = Color.FromArgb(0, 0, 0)
        btn_inicio.Image = My.Resources.homeb

        lbl_titulo.Text = "Início"
        pnl_formulario.Controls.Clear()
        Dim inicio As Inicio = New Inicio()
        inicio.TopLevel = False
        pnl_formulario.Controls.Add(inicio)
        inicio.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        inicio.Dock = DockStyle.Fill
        inicio.Show()

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp As Integer

        resp = MessageBox.Show("Tem certeza que deseja deslogar?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp = vbYes Then
            Me.Close()
            Login.Show()
            Login.txt_cpf.Clear()
            Login.txt_senha.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        pnlNav.Height = btn_inicio.Height
        pnlNav.Top = btn_inicio.Top
        pnlNav.Left = btn_inicio.Left
        btn_inicio.BackColor = Color.FromArgb(169, 169, 169)
        btn_inicio.ForeColor = Color.FromArgb(0, 0, 0)
        btn_inicio.Image = My.Resources.homeb

        lbl_titulo.Text = "Início"
        pnl_formulario.Controls.Clear()
        Dim inicio As Inicio = New Inicio()
        inicio.TopLevel = False
        pnl_formulario.Controls.Add(inicio)
        inicio.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        inicio.Dock = DockStyle.Fill
        inicio.Show()

        ConfirmarSenha.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_relatorio.Click
        pnlNav.Height = btn_relatorio.Height
        pnlNav.Top = btn_relatorio.Top
        pnlNav.Left = btn_relatorio.Left
        btn_relatorio.BackColor = Color.FromArgb(169, 169, 169)
        btn_relatorio.ForeColor = Color.FromArgb(0, 0, 0)
        btn_inicio.BackColor = Color.FromArgb(128, 128, 128)
        btn_inicio.ForeColor = Color.FromArgb(107, 235, 54)
        btn_inicio.Image = My.Resources.homeIco
        btn_relatorio.Image = My.Resources.formsb

        lbl_titulo.Text = "Relatório"
        pnl_formulario.Controls.Clear()
        Dim relatorio As Relatorio = New Relatorio()
        relatorio.TopLevel = False
        pnl_formulario.Controls.Add(relatorio)
        relatorio.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        relatorio.Dock = DockStyle.Fill
        relatorio.Show()


        ConfirmarSenha.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        pnlNav.Height = btn_cadastrar.Height
        pnlNav.Top = btn_cadastrar.Top
        pnlNav.Left = btn_cadastrar.Left
        btn_cadastrar.BackColor = Color.FromArgb(169, 169, 169)
        btn_cadastrar.ForeColor = Color.FromArgb(0, 0, 0)
        btn_inicio.BackColor = Color.FromArgb(128, 128, 128)
        btn_inicio.ForeColor = Color.FromArgb(107, 235, 54)
        btn_inicio.Image = My.Resources.homeIco
        btn_cadastrar.Image = My.Resources.pencilb

        lbl_titulo.Text = "Cadastrar Oficial"
        pnl_formulario.Controls.Clear()
        Dim cadastrar As CadastrarOficial = New CadastrarOficial()
        cadastrar.TopLevel = False
        pnl_formulario.Controls.Add(cadastrar)
        cadastrar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        cadastrar.Dock = DockStyle.Fill
        cadastrar.Show()

        ConfirmarSenha.Close()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        pnlNav.Height = btn_editar.Height
        pnlNav.Top = btn_editar.Top
        pnlNav.Left = btn_editar.Left
        btn_editar.BackColor = Color.FromArgb(169, 169, 169)
        btn_editar.ForeColor = Color.FromArgb(0, 0, 0)
        btn_inicio.BackColor = Color.FromArgb(128, 128, 128)
        btn_inicio.ForeColor = Color.FromArgb(107, 235, 54)
        btn_inicio.Image = My.Resources.homeIco
        btn_editar.Image = My.Resources.pencilb

        lbl_titulo.Text = "Editar Cadastro"
        pnl_formulario.Controls.Clear()
        Dim editar As EditarCadastro = New EditarCadastro()
        editar.TopLevel = False
        pnl_formulario.Controls.Add(editar)
        editar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        editar.Dock = DockStyle.Fill
        editar.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_config.Click
        pnlNav.Height = btn_config.Height
        pnlNav.Top = btn_config.Top
        pnlNav.Left = btn_config.Left
        btn_config.BackColor = Color.FromArgb(169, 169, 169)
        btn_config.ForeColor = Color.FromArgb(0, 0, 0)
        btn_inicio.BackColor = Color.FromArgb(128, 128, 128)
        btn_inicio.ForeColor = Color.FromArgb(107, 235, 54)
        btn_inicio.Image = My.Resources.homeIco
        btn_config.Image = My.Resources.settingsb

        lbl_titulo.Text = "Sobre"
        pnl_formulario.Controls.Clear()
        Dim config As Configuracoes = New Configuracoes()
        config.TopLevel = False
        pnl_formulario.Controls.Add(config)
        config.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        config.Dock = DockStyle.Fill
        config.Show()

        ConfirmarSenha.Close()
    End Sub

    Private Sub btn_registro_Click(sender As Object, e As EventArgs) Handles btn_registro.Click
        pnlNav.Height = btn_registro.Height
        pnlNav.Top = btn_registro.Top
        pnlNav.Left = btn_registro.Left
        btn_registro.BackColor = Color.FromArgb(169, 169, 169)
        btn_registro.ForeColor = Color.FromArgb(0, 0, 0)
        btn_inicio.BackColor = Color.FromArgb(128, 128, 128)
        btn_inicio.ForeColor = Color.FromArgb(107, 235, 54)
        btn_inicio.Image = My.Resources.homeIco
        btn_registro.Image = My.Resources.police_hatb

        lbl_titulo.Text = "Registro de Ocorrências"
        pnl_formulario.Controls.Clear()
        Dim registro As RegistroQueixa = New RegistroQueixa()
        registro.TopLevel = False
        pnl_formulario.Controls.Add(registro)
        registro.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        registro.Dock = DockStyle.Fill
        registro.Show()

        ConfirmarSenha.Close()
    End Sub

    Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles btn_inicio.Leave
        btn_inicio.BackColor = Color.FromArgb(128, 128, 128)
        btn_inicio.ForeColor = Color.FromArgb(107, 235, 54)
        btn_inicio.Image = My.Resources.homeIco
    End Sub
    Private Sub Button2_Leave(sender As Object, e As EventArgs) Handles btn_relatorio.Leave
        btn_relatorio.BackColor = Color.FromArgb(128, 128, 128)
        btn_relatorio.ForeColor = Color.FromArgb(107, 235, 54)
        btn_relatorio.Image = My.Resources.formsIco
    End Sub
    Private Sub Button4_Leave(sender As Object, e As EventArgs) Handles btn_cadastrar.Leave
        btn_cadastrar.BackColor = Color.FromArgb(128, 128, 128)
        btn_cadastrar.ForeColor = Color.FromArgb(107, 235, 54)
        btn_cadastrar.Image = My.Resources.pencilIco
    End Sub
    Private Sub Button5_Leave(sender As Object, e As EventArgs) Handles btn_config.Leave
        btn_config.BackColor = Color.FromArgb(128, 128, 128)
        btn_config.ForeColor = Color.FromArgb(107, 235, 54)
        btn_config.Image = My.Resources.settingsIco
    End Sub

    Private Sub btn_registro_Leave(sender As Object, e As EventArgs) Handles btn_registro.Leave
        btn_registro.BackColor = Color.FromArgb(128, 128, 128)
        btn_registro.ForeColor = Color.FromArgb(107, 235, 54)
        btn_registro.Image = My.Resources.policehatIco
    End Sub
    Private Sub btn_editar_Leave(sender As Object, e As EventArgs) Handles btn_editar.Leave
        btn_editar.BackColor = Color.FromArgb(128, 128, 128)
        btn_editar.ForeColor = Color.FromArgb(107, 235, 54)
        btn_editar.Image = My.Resources.pencilIco
    End Sub
End Class