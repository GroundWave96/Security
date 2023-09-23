<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmarSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmarSenha))
        Me.btn_view = New System.Windows.Forms.PictureBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_hide = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_view
        '
        Me.btn_view.BackgroundImage = Global.Security.My.Resources.Resources.view
        Me.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_view.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_view.Location = New System.Drawing.Point(232, 245)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(25, 25)
        Me.btn_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_view.TabIndex = 38
        Me.btn_view.TabStop = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmar.FlatAppearance.BorderSize = 0
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_confirmar.Location = New System.Drawing.Point(96, 309)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(100, 30)
        Me.btn_confirmar.TabIndex = 2
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'btn_hide
        '
        Me.btn_hide.BackgroundImage = Global.Security.My.Resources.Resources.hide
        Me.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hide.Location = New System.Drawing.Point(232, 245)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.Size = New System.Drawing.Size(25, 25)
        Me.btn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_hide.TabIndex = 37
        Me.btn_hide.TabStop = False
        Me.btn_hide.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Security.My.Resources.Resources.padlock
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(40, 247)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Senha"
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
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.DarkGray
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_senha.Location = New System.Drawing.Point(65, 248)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(165, 20)
        Me.txt_senha.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(42, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 3)
        Me.Panel3.TabIndex = 32
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
        Me.Panel1.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 3)
        Me.Panel4.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 377)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 3)
        Me.Panel2.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(297, 187)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(3, 193)
        Me.Panel5.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 187)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 193)
        Me.Panel6.TabIndex = 3
        '
        'ConfirmarSenha
        '
        Me.AcceptButton = Me.btn_confirmar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(300, 380)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_hide)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfirmarSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfirmarSenha"
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_view As PictureBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_hide As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
