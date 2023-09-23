<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Programa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programa))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btn_config = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_ficha = New System.Windows.Forms.Button()
        Me.btn_registro = New System.Windows.Forms.Button()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.pnl_formulario = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.pnlNav)
        Me.Panel1.Controls.Add(Me.btn_config)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btn_ficha)
        Me.Panel1.Controls.Add(Me.btn_registro)
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 520)
        Me.Panel1.TabIndex = 0
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pnlNav.Location = New System.Drawing.Point(0, 173)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(4, 87)
        Me.pnlNav.TabIndex = 2
        '
        'btn_config
        '
        Me.btn_config.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_config.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_config.FlatAppearance.BorderSize = 0
        Me.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_config.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_config.Image = Global.Security.My.Resources.Resources.settingsIco
        Me.btn_config.Location = New System.Drawing.Point(0, 434)
        Me.btn_config.Name = "btn_config"
        Me.btn_config.Size = New System.Drawing.Size(189, 43)
        Me.btn_config.TabIndex = 1
        Me.btn_config.Text = "Sobre               "
        Me.btn_config.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_config.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_sair.FlatAppearance.BorderSize = 0
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_sair.Image = Global.Security.My.Resources.Resources.logoutIco
        Me.btn_sair.Location = New System.Drawing.Point(0, 477)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(189, 43)
        Me.btn_sair.TabIndex = 1
        Me.btn_sair.Text = "Sair                      "
        Me.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_editar.FlatAppearance.BorderSize = 0
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Nirmala UI", 11.2!, System.Drawing.FontStyle.Bold)
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_editar.Image = Global.Security.My.Resources.Resources.pencilIco
        Me.btn_editar.Location = New System.Drawing.Point(0, 291)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(189, 48)
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.Text = "Editar          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cadastro          "
        Me.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_ficha
        '
        Me.btn_ficha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ficha.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ficha.FlatAppearance.BorderSize = 0
        Me.btn_ficha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ficha.Font = New System.Drawing.Font("Nirmala UI", 11.2!, System.Drawing.FontStyle.Bold)
        Me.btn_ficha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_ficha.Image = Global.Security.My.Resources.Resources.formsIco
        Me.btn_ficha.Location = New System.Drawing.Point(0, 243)
        Me.btn_ficha.Name = "btn_ficha"
        Me.btn_ficha.Size = New System.Drawing.Size(189, 48)
        Me.btn_ficha.TabIndex = 1
        Me.btn_ficha.Text = "Ficha e        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chamados       "
        Me.btn_ficha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ficha.UseVisualStyleBackColor = True
        '
        'btn_registro
        '
        Me.btn_registro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_registro.FlatAppearance.BorderSize = 0
        Me.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registro.Font = New System.Drawing.Font("Nirmala UI", 11.2!, System.Drawing.FontStyle.Bold)
        Me.btn_registro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_registro.Image = Global.Security.My.Resources.Resources.policehatIco
        Me.btn_registro.Location = New System.Drawing.Point(0, 195)
        Me.btn_registro.Name = "btn_registro"
        Me.btn_registro.Size = New System.Drawing.Size(189, 48)
        Me.btn_registro.TabIndex = 1
        Me.btn_registro.Text = " Registro         " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Queixa       "
        Me.btn_registro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_registro.UseVisualStyleBackColor = True
        '
        'btn_inicio
        '
        Me.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_inicio.FlatAppearance.BorderSize = 0
        Me.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_inicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_inicio.Image = Global.Security.My.Resources.Resources.homeIco
        Me.btn_inicio.Location = New System.Drawing.Point(0, 147)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(189, 48)
        Me.btn_inicio.TabIndex = 1
        Me.btn_inicio.Text = "   Início            "
        Me.btn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_inicio.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lbl_nome)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(189, 147)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(189, 3)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(189, 3)
        Me.Panel4.TabIndex = 3
        '
        'lbl_nome
        '
        Me.lbl_nome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nome.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lbl_nome.Location = New System.Drawing.Point(0, 104)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(189, 40)
        Me.lbl_nome.TabIndex = 1
        Me.lbl_nome.Text = "Usuário"
        Me.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Security.My.Resources.Resources.LogoNoBackground
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.BackgroundImage = Global.Security.My.Resources.Resources.close
        Me.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar.FlatAppearance.BorderSize = 0
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Location = New System.Drawing.Point(645, 3)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(21, 22)
        Me.btn_fechar.TabIndex = 1
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImage = Global.Security.My.Resources.Resources.minimize
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Location = New System.Drawing.Point(618, 3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(21, 22)
        Me.btn_minimizar.TabIndex = 2
        Me.btn_minimizar.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Controls.Add(Me.lbl_titulo)
        Me.Panel5.Controls.Add(Me.btn_minimizar)
        Me.Panel5.Controls.Add(Me.btn_fechar)
        Me.Panel5.Location = New System.Drawing.Point(189, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(669, 30)
        Me.Panel5.TabIndex = 3
        '
        'lbl_titulo
        '
        Me.lbl_titulo.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_titulo.ForeColor = System.Drawing.Color.Silver
        Me.lbl_titulo.Location = New System.Drawing.Point(0, -7)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(619, 35)
        Me.lbl_titulo.TabIndex = 3
        Me.lbl_titulo.Text = "Início"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_formulario
        '
        Me.pnl_formulario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_formulario.Location = New System.Drawing.Point(189, 30)
        Me.pnl_formulario.Name = "pnl_formulario"
        Me.pnl_formulario.Size = New System.Drawing.Size(668, 490)
        Me.pnl_formulario.TabIndex = 1
        '
        'Programa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(857, 520)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnl_formulario)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Programa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents btn_inicio As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_ficha As Button
    Friend WithEvents btn_registro As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_config As Button
    Friend WithEvents pnlNav As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnl_formulario As Panel
    Friend WithEvents lbl_titulo As Label
End Class
