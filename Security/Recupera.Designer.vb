<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recupera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recupera))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 216)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(350, 3)
        Me.Panel4.TabIndex = 2
        '
        'btn_verificar
        '
        Me.btn_verificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_verificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_verificar.FlatAppearance.BorderSize = 0
        Me.btn_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verificar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_verificar.Location = New System.Drawing.Point(187, 460)
        Me.btn_verificar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(117, 35)
        Me.btn_verificar.TabIndex = 4
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Security.My.Resources.Resources.padlock
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(51, 408)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox4.TabIndex = 121
        Me.PictureBox4.TabStop = False
        '
        'btn_enviar
        '
        Me.btn_enviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enviar.FlatAppearance.BorderSize = 0
        Me.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enviar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_enviar.Location = New System.Drawing.Point(110, 331)
        Me.btn_enviar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(117, 35)
        Me.btn_enviar.TabIndex = 2
        Me.btn_enviar.Text = "Enviar Código"
        Me.btn_enviar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 384)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 251)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Email"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(53, 435)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(251, 3)
        Me.Panel3.TabIndex = 118
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(49, 302)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 3)
        Me.Panel2.TabIndex = 117
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 219)
        Me.Panel1.TabIndex = 116
        '
        'btn_minimizar
        '
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImage = Global.Security.My.Resources.Resources.minimize
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Location = New System.Drawing.Point(291, 3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(25, 25)
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
        Me.btn_fechar.Location = New System.Drawing.Point(322, 3)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(25, 25)
        Me.btn_fechar.TabIndex = 3
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Security.My.Resources.Resources.email
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(48, 277)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox6.TabIndex = 124
        Me.PictureBox6.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.DarkGray
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_email.Location = New System.Drawing.Point(76, 279)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(224, 20)
        Me.txt_email.TabIndex = 1
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.DarkGray
        Me.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_codigo.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_codigo.Location = New System.Drawing.Point(80, 413)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(224, 20)
        Me.txt_codigo.TabIndex = 3
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.Location = New System.Drawing.Point(53, 460)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(117, 35)
        Me.btn_voltar.TabIndex = 5
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Recupera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(350, 519)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_codigo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Recupera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recupera"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_verificar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_enviar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents btn_voltar As Button
End Class
