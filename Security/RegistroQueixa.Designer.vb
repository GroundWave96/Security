<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroQueixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroQueixa))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_info = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.txt_hora = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt_rua = New System.Windows.Forms.TextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(51, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 19)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Tipo de Queixa"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(57, 269)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(215, 3)
        Me.Panel12.TabIndex = 127
        '
        'cmb_tipo
        '
        Me.cmb_tipo.AutoCompleteCustomSource.AddRange(New String() {"Roubo ou Furto de Veículo", "Furto de Documento", "Furto de Celular", "Furto de Placa de Veículo", "Furto de Bicicleta", "Perda de Documento", "Perda de Celular", "Perda de Placa de Veículo", "Roubo de Documento", "Roubo de Celulares", "Roubo de Objetos", "Injúria, Calúnia ou Difamação", "Acidente de Trânsito Sem Vítimas", "Desaparecimento de Pessoas", "Encontro de Pessoas", "Furto de Fios/Cabos", "Violência Doméstica", "Fraude e Estelionato", "Delegacia da Diversidade Online", "DEPA - Proteção Animal", "Outras Ocorrências"})
        Me.cmb_tipo.BackColor = System.Drawing.Color.DarkGray
        Me.cmb_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_tipo.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Roubo ou Furto de Veículo", "Furto de Documento", "Furto de Celular", "Furto de Placa de Veículo", "Furto de Bicicleta", "Perda de Documento", "Perda de Celular", "Perda de Placa de Veículo", "Roubo de Documento", "Roubo de Celulares", "Roubo de Objetos", "Injúria, Calúnia ou Difamação", "Acidente de Trânsito Sem Vítimas", "Desaparecimento de Pessoas", "Encontro de Pessoas", "Furto de Fios/Cabos", "Violência Doméstica", "Fraude e Estelionato", "Delegacia da Diversidade Online", "DEPA - Proteção Animal", "Outras Ocorrências"})
        Me.cmb_tipo.Location = New System.Drawing.Point(57, 242)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(216, 27)
        Me.cmb_tipo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(51, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 19)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Hora (formato de 24hrs)"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(56, 197)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(215, 3)
        Me.Panel8.TabIndex = 131
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(55, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 3)
        Me.Panel1.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(51, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 19)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Informaçoes Adicionais"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(57, 426)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(536, 3)
        Me.Panel3.TabIndex = 134
        '
        'txt_info
        '
        Me.txt_info.BackColor = System.Drawing.Color.DarkGray
        Me.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_info.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_info.Location = New System.Drawing.Point(57, 310)
        Me.txt_info.Multiline = True
        Me.txt_info.Name = "txt_info"
        Me.txt_info.Size = New System.Drawing.Size(536, 115)
        Me.txt_info.TabIndex = 11
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrar.FlatAppearance.BorderSize = 0
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_registrar.Location = New System.Drawing.Point(237, 442)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(171, 30)
        Me.btn_registrar.TabIndex = 12
        Me.btn_registrar.Text = "Registrar Ocorrência"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'txt_num
        '
        Me.txt_num.BackColor = System.Drawing.Color.DarkGray
        Me.txt_num.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_num.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_num.Location = New System.Drawing.Point(401, 247)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(192, 20)
        Me.txt_num.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(378, 267)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(215, 3)
        Me.Panel7.TabIndex = 131
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(373, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 19)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Número / Complemento"
        '
        'txt_data
        '
        Me.txt_data.BackColor = System.Drawing.Color.DarkGray
        Me.txt_data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_data.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_data.Location = New System.Drawing.Point(55, 102)
        Me.txt_data.Mask = "00/00/0000"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(215, 20)
        Me.txt_data.TabIndex = 2
        '
        'txt_hora
        '
        Me.txt_hora.BackColor = System.Drawing.Color.DarkGray
        Me.txt_hora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_hora.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_hora.Location = New System.Drawing.Point(56, 177)
        Me.txt_hora.Mask = "00:00"
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(215, 20)
        Me.txt_hora.TabIndex = 3
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(378, 191)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox10.TabIndex = 188
        Me.PictureBox10.TabStop = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel13.Location = New System.Drawing.Point(528, 52)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(65, 3)
        Me.Panel13.TabIndex = 195
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(378, 139)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox7.TabIndex = 189
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(528, 29)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox8.TabIndex = 197
        Me.PictureBox8.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(374, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 19)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "Rua"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(524, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 19)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(374, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Bairro"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(378, 52)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(130, 3)
        Me.Panel10.TabIndex = 194
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(378, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 3)
        Me.Panel2.TabIndex = 185
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(378, 82)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox12.TabIndex = 184
        Me.PictureBox12.TabStop = False
        '
        'txt_estado
        '
        Me.txt_estado.BackColor = System.Drawing.Color.DarkGray
        Me.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_estado.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_estado.Location = New System.Drawing.Point(551, 31)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(42, 20)
        Me.txt_estado.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(374, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Cidade"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.Security.My.Resources.Resources.magnifier
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Location = New System.Drawing.Point(483, 26)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 192
        Me.PictureBox9.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(378, 162)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(215, 3)
        Me.Panel4.TabIndex = 182
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(378, 107)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(215, 3)
        Me.Panel9.TabIndex = 181
        '
        'txt_rua
        '
        Me.txt_rua.BackColor = System.Drawing.Color.DarkGray
        Me.txt_rua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_rua.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_rua.Location = New System.Drawing.Point(401, 193)
        Me.txt_rua.Name = "txt_rua"
        Me.txt_rua.Size = New System.Drawing.Size(192, 20)
        Me.txt_rua.TabIndex = 9
        '
        'txt_bairro
        '
        Me.txt_bairro.BackColor = System.Drawing.Color.DarkGray
        Me.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_bairro.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_bairro.Location = New System.Drawing.Point(401, 141)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(192, 20)
        Me.txt_bairro.TabIndex = 8
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.Color.DarkGray
        Me.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cidade.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_cidade.Location = New System.Drawing.Point(401, 84)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(192, 20)
        Me.txt_cidade.TabIndex = 7
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.Color.DarkGray
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cep.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_cep.Location = New System.Drawing.Point(404, 32)
        Me.txt_cep.Mask = "00000-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(75, 20)
        Me.txt_cep.TabIndex = 5
        '
        'PictureBox16
        '
        Me.PictureBox16.BackgroundImage = Global.Security.My.Resources.Resources.mailbox
        Me.PictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox16.Location = New System.Drawing.Point(378, 29)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox16.TabIndex = 191
        Me.PictureBox16.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(374, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 19)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "CEP"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Security.My.Resources.Resources.location
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(378, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.TabIndex = 200
        Me.PictureBox1.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.DarkGray
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(81, 32)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(163, 20)
        Me.txt_cpf.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Security.My.Resources.Resources.id_card
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(56, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox3.TabIndex = 204
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(51, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 19)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "CPF"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(56, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(215, 3)
        Me.Panel5.TabIndex = 202
        '
        'RegistroQueixa
        '
        Me.AcceptButton = Me.btn_registrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(669, 490)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.txt_rua)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_info)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistroQueixa"
        Me.Text = "RegistroQueixa"
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_info As TextBox
    Friend WithEvents btn_registrar As Button
    Friend WithEvents txt_num As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents txt_hora As MaskedTextBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_rua As TextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
End Class
