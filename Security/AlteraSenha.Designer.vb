<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlteraSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlteraSenha))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_trocarSenha = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_senhac = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.unchecks = New System.Windows.Forms.PictureBox()
        Me.checks = New System.Windows.Forms.PictureBox()
        Me.btn_view = New System.Windows.Forms.PictureBox()
        Me.btn_hide = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unchecks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 3)
        Me.Panel4.TabIndex = 2
        '
        'btn_trocarSenha
        '
        Me.btn_trocarSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_trocarSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_trocarSenha.FlatAppearance.BorderSize = 0
        Me.btn_trocarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trocarSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_trocarSenha.Location = New System.Drawing.Point(160, 392)
        Me.btn_trocarSenha.Name = "btn_trocarSenha"
        Me.btn_trocarSenha.Size = New System.Drawing.Size(100, 30)
        Me.btn_trocarSenha.TabIndex = 3
        Me.btn_trocarSenha.Text = "Trocar Senha"
        Me.btn_trocarSenha.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Security.My.Resources.Resources.padlock
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(44, 331)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox4.TabIndex = 133
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 19)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Confirma Nova Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Nova Senha"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(45, 354)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 3)
        Me.Panel3.TabIndex = 130
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(42, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 3)
        Me.Panel2.TabIndex = 129
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Security.My.Resources.Resources.logoLogin
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btn_minimizar)
        Me.Panel1.Controls.Add(Me.btn_fechar)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 190)
        Me.Panel1.TabIndex = 128
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImage = Global.Security.My.Resources.Resources.minimize
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Location = New System.Drawing.Point(249, 3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(21, 22)
        Me.btn_minimizar.TabIndex = 4
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
        Me.btn_fechar.Location = New System.Drawing.Point(276, 3)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(21, 22)
        Me.btn_fechar.TabIndex = 3
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.Location = New System.Drawing.Point(45, 392)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(100, 30)
        Me.btn_voltar.TabIndex = 4
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.DarkGray
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_senha.Location = New System.Drawing.Point(65, 252)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(166, 20)
        Me.txt_senha.TabIndex = 1
        '
        'txt_senhac
        '
        Me.txt_senhac.BackColor = System.Drawing.Color.DarkGray
        Me.txt_senhac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senhac.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_senhac.Location = New System.Drawing.Point(69, 335)
        Me.txt_senhac.Name = "txt_senhac"
        Me.txt_senhac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senhac.Size = New System.Drawing.Size(163, 20)
        Me.txt_senhac.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Security.My.Resources.Resources.padlock
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(41, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.TabIndex = 138
        Me.PictureBox1.TabStop = False
        '
        'unchecks
        '
        Me.unchecks.BackgroundImage = Global.Security.My.Resources.Resources.uncheck
        Me.unchecks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.unchecks.Location = New System.Drawing.Point(238, 331)
        Me.unchecks.Name = "unchecks"
        Me.unchecks.Size = New System.Drawing.Size(22, 22)
        Me.unchecks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.unchecks.TabIndex = 140
        Me.unchecks.TabStop = False
        Me.unchecks.Visible = False
        '
        'checks
        '
        Me.checks.BackgroundImage = Global.Security.My.Resources.Resources.check
        Me.checks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.checks.Location = New System.Drawing.Point(238, 331)
        Me.checks.Name = "checks"
        Me.checks.Size = New System.Drawing.Size(22, 22)
        Me.checks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checks.TabIndex = 139
        Me.checks.TabStop = False
        Me.checks.Visible = False
        '
        'btn_view
        '
        Me.btn_view.BackgroundImage = Global.Security.My.Resources.Resources.view
        Me.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_view.Location = New System.Drawing.Point(232, 247)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(25, 25)
        Me.btn_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_view.TabIndex = 142
        Me.btn_view.TabStop = False
        '
        'btn_hide
        '
        Me.btn_hide.BackgroundImage = Global.Security.My.Resources.Resources.hide
        Me.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hide.Location = New System.Drawing.Point(232, 247)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.Size = New System.Drawing.Size(25, 25)
        Me.btn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_hide.TabIndex = 141
        Me.btn_hide.TabStop = False
        Me.btn_hide.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 447)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 3)
        Me.Panel5.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(297, 187)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 263)
        Me.Panel6.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(0, 187)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(3, 263)
        Me.Panel7.TabIndex = 4
        '
        'AlteraSenha
        '
        Me.AcceptButton = Me.btn_trocarSenha
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(300, 450)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.btn_hide)
        Me.Controls.Add(Me.unchecks)
        Me.Controls.Add(Me.checks)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_trocarSenha)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_senhac)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlteraSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlteraSenha"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unchecks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_trocarSenha As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_enviar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_senhac As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents unchecks As PictureBox
    Friend WithEvents checks As PictureBox
    Friend WithEvents btn_view As PictureBox
    Friend WithEvents btn_hide As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
End Class
