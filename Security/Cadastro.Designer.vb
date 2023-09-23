<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.unchecks = New System.Windows.Forms.PictureBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.checks = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_senhac = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_view = New System.Windows.Forms.PictureBox()
        Me.btn_hide = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txt_rua = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        CType(Me.unchecks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'unchecks
        '
        Me.unchecks.BackgroundImage = Global.Security.My.Resources.Resources.uncheck
        Me.unchecks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.unchecks.Location = New System.Drawing.Point(228, 436)
        Me.unchecks.Name = "unchecks"
        Me.unchecks.Size = New System.Drawing.Size(22, 22)
        Me.unchecks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.unchecks.TabIndex = 87
        Me.unchecks.TabStop = False
        Me.unchecks.Visible = False
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.FlatAppearance.BorderSize = 0
        Me.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_entrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_entrar.Location = New System.Drawing.Point(76, 596)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(129, 30)
        Me.btn_entrar.TabIndex = 14
        Me.btn_entrar.Text = "Voltar"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'checks
        '
        Me.checks.BackgroundImage = Global.Security.My.Resources.Resources.check
        Me.checks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.checks.Location = New System.Drawing.Point(228, 436)
        Me.checks.Name = "checks"
        Me.checks.Size = New System.Drawing.Size(22, 22)
        Me.checks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checks.TabIndex = 86
        Me.checks.TabStop = False
        Me.checks.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Security.My.Resources.Resources.email
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(35, 506)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox6.TabIndex = 81
        Me.PictureBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 484)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "E-mail"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.DarkGray
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_email.Location = New System.Drawing.Point(58, 506)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(192, 20)
        Me.txt_email.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(35, 529)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(215, 3)
        Me.Panel6.TabIndex = 79
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Security.My.Resources.Resources.padlock
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(35, 434)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox5.TabIndex = 75
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Confirmar senha"
        '
        'txt_senhac
        '
        Me.txt_senhac.BackColor = System.Drawing.Color.DarkGray
        Me.txt_senhac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senhac.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_senhac.Location = New System.Drawing.Point(58, 436)
        Me.txt_senhac.Name = "txt_senhac"
        Me.txt_senhac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senhac.Size = New System.Drawing.Size(165, 20)
        Me.txt_senhac.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(35, 458)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(215, 3)
        Me.Panel5.TabIndex = 73
        '
        'btn_view
        '
        Me.btn_view.BackgroundImage = Global.Security.My.Resources.Resources.view
        Me.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_view.Location = New System.Drawing.Point(225, 359)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(25, 25)
        Me.btn_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_view.TabIndex = 71
        Me.btn_view.TabStop = False
        '
        'btn_hide
        '
        Me.btn_hide.BackgroundImage = Global.Security.My.Resources.Resources.hide
        Me.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hide.Location = New System.Drawing.Point(225, 359)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.Size = New System.Drawing.Size(25, 25)
        Me.btn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_hide.TabIndex = 70
        Me.btn_hide.TabStop = False
        Me.btn_hide.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Security.My.Resources.Resources.padlock
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(35, 362)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox4.TabIndex = 69
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.DarkGray
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_senha.Location = New System.Drawing.Point(58, 364)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(165, 20)
        Me.txt_senha.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(35, 386)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 3)
        Me.Panel3.TabIndex = 67
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Security.My.Resources.Resources.id_card
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(35, 294)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "CPF"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(35, 317)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 3)
        Me.Panel2.TabIndex = 63
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = Global.Security.My.Resources.Resources.logoLogin
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.btn_minimizar)
        Me.Panel1.Controls.Add(Me.btn_fechar)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 190)
        Me.Panel1.TabIndex = 61
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImage = Global.Security.My.Resources.Resources.minimize
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Location = New System.Drawing.Point(549, 3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(21, 22)
        Me.btn_minimizar.TabIndex = 6
        Me.btn_minimizar.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.BackgroundImage = Global.Security.My.Resources.Resources.close
        Me.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar.FlatAppearance.BorderSize = 0
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Location = New System.Drawing.Point(575, 3)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(21, 22)
        Me.btn_fechar.TabIndex = 5
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(600, 3)
        Me.Panel4.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(312, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Bairro"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(316, 529)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(215, 3)
        Me.Panel7.TabIndex = 105
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(316, 361)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox12.TabIndex = 102
        Me.PictureBox12.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(312, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Cidade"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(316, 458)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(215, 3)
        Me.Panel8.TabIndex = 100
        '
        'PictureBox15
        '
        Me.PictureBox15.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox15.Location = New System.Drawing.Point(466, 294)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox15.TabIndex = 97
        Me.PictureBox15.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(462, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Estado"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(316, 386)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(215, 3)
        Me.Panel9.TabIndex = 95
        '
        'PictureBox16
        '
        Me.PictureBox16.BackgroundImage = Global.Security.My.Resources.Resources.mailbox
        Me.PictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox16.Location = New System.Drawing.Point(316, 294)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox16.TabIndex = 94
        Me.PictureBox16.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(312, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 19)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "CEP"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(316, 317)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(130, 3)
        Me.Panel10.TabIndex = 92
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.DarkGray
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(61, 297)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(163, 20)
        Me.txt_cpf.TabIndex = 2
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.Color.DarkGray
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cep.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_cep.Location = New System.Drawing.Point(342, 297)
        Me.txt_cep.Mask = "00000-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(73, 20)
        Me.txt_cep.TabIndex = 7
        '
        'txt_estado
        '
        Me.txt_estado.BackColor = System.Drawing.Color.DarkGray
        Me.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_estado.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_estado.Location = New System.Drawing.Point(489, 296)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(42, 20)
        Me.txt_estado.TabIndex = 8
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.Color.DarkGray
        Me.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cidade.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_cidade.Location = New System.Drawing.Point(339, 366)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(192, 20)
        Me.txt_cidade.TabIndex = 9
        '
        'txt_bairro
        '
        Me.txt_bairro.BackColor = System.Drawing.Color.DarkGray
        Me.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_bairro.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_bairro.Location = New System.Drawing.Point(339, 439)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(192, 20)
        Me.txt_bairro.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(312, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 19)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Celular"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(316, 255)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(215, 3)
        Me.Panel11.TabIndex = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(29, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 19)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.DarkGray
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_nome.Location = New System.Drawing.Point(58, 232)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(192, 20)
        Me.txt_nome.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(35, 255)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(215, 3)
        Me.Panel12.TabIndex = 117
        '
        'txt_celular
        '
        Me.txt_celular.BackColor = System.Drawing.Color.DarkGray
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_celular.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_celular.Location = New System.Drawing.Point(340, 235)
        Me.txt_celular.Mask = "(00) 0 0000-0000"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(163, 20)
        Me.txt_celular.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Security.My.Resources.Resources.telephone
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(316, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Security.My.Resources.Resources.user
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(35, 232)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(316, 435)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox7.TabIndex = 126
        Me.PictureBox7.TabStop = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.FlatAppearance.BorderSize = 0
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.Location = New System.Drawing.Point(76, 557)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(129, 30)
        Me.btn_cadastrar.TabIndex = 13
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.Security.My.Resources.Resources.magnifier
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Location = New System.Drawing.Point(421, 292)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 127
        Me.PictureBox9.TabStop = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel13.Location = New System.Drawing.Point(466, 317)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(65, 3)
        Me.Panel13.TabIndex = 93
        '
        'txt_rua
        '
        Me.txt_rua.BackColor = System.Drawing.Color.DarkGray
        Me.txt_rua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_rua.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_rua.Location = New System.Drawing.Point(339, 509)
        Me.txt_rua.Name = "txt_rua"
        Me.txt_rua.Size = New System.Drawing.Size(192, 20)
        Me.txt_rua.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(312, 484)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 19)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Rua"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(316, 505)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox10.TabIndex = 126
        Me.PictureBox10.TabStop = False
        '
        'txt_num
        '
        Me.txt_num.BackColor = System.Drawing.Color.DarkGray
        Me.txt_num.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_num.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_num.Location = New System.Drawing.Point(339, 582)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(192, 20)
        Me.txt_num.TabIndex = 12
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel14.Location = New System.Drawing.Point(316, 602)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(215, 3)
        Me.Panel14.TabIndex = 105
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(312, 557)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 19)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "Número / Complemento"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(316, 578)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox11.TabIndex = 126
        Me.PictureBox11.TabStop = False
        '
        'Cadastro
        '
        Me.AcceptButton = Me.btn_cadastrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.unchecks)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.checks)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.txt_rua)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senhac)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.btn_hide)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        CType(Me.unchecks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents unchecks As PictureBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents checks As PictureBox
    Friend WithEvents unchecku As PictureBox
    Friend WithEvents checku As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_senhac As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_view As PictureBox
    Friend WithEvents btn_hide As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents txt_rua As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents txt_num As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox11 As PictureBox
End Class
