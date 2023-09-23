<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Relatorio))
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_data2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.dgv_ficha = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_ficha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_filtrar
        '
        Me.btn_filtrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtrar.FlatAppearance.BorderSize = 0
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_filtrar.Location = New System.Drawing.Point(385, 85)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(90, 30)
        Me.btn_filtrar.TabIndex = 4
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = False
        '
        'txt_data
        '
        Me.txt_data.BackColor = System.Drawing.Color.DarkGray
        Me.txt_data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_data.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_data.Location = New System.Drawing.Point(57, 33)
        Me.txt_data.Mask = "00/00/0000"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(215, 20)
        Me.txt_data.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Data inicial"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(57, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 3)
        Me.Panel1.TabIndex = 138
        '
        'txt_data2
        '
        Me.txt_data2.BackColor = System.Drawing.Color.DarkGray
        Me.txt_data2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_data2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txt_data2.Location = New System.Drawing.Point(385, 33)
        Me.txt_data2.Mask = "00/00/0000"
        Me.txt_data2.Name = "txt_data2"
        Me.txt_data2.Size = New System.Drawing.Size(215, 20)
        Me.txt_data2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(381, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Data final"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(385, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 3)
        Me.Panel2.TabIndex = 141
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
        Me.cmb_tipo.Items.AddRange(New Object() {"Todas", "Roubo ou Furto de Veículo", "Furto de Documento", "Furto de Celular", "Furto de Placa de Veículo", "Furto de Bicicleta", "Perda de Documento", "Perda de Celular", "Perda de Placa de Veículo", "Roubo de Documento", "Roubo de Celulares", "Roubo de Objetos", "Injúria, Calúnia ou Difamação", "Acidente de Trânsito Sem Vítimas", "Desaparecimento de Pessoas", "Encontro de Pessoas", "Furto de Fios/Cabos", "Violência Doméstica", "Fraude e Estelionato", "Delegacia da Diversidade Online", "DEPA - Proteção Animal", "Outras Ocorrências"})
        Me.cmb_tipo.Location = New System.Drawing.Point(56, 88)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(216, 27)
        Me.cmb_tipo.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(50, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 19)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Tipo de Queixa"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(56, 115)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(215, 3)
        Me.Panel12.TabIndex = 144
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.FlatAppearance.BorderSize = 0
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_imprimir.Location = New System.Drawing.Point(510, 85)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(90, 30)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'dgv_ficha
        '
        Me.dgv_ficha.AllowUserToAddRows = False
        Me.dgv_ficha.AllowUserToDeleteRows = False
        Me.dgv_ficha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ficha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_ficha.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_ficha.Location = New System.Drawing.Point(0, 135)
        Me.dgv_ficha.Name = "dgv_ficha"
        Me.dgv_ficha.ReadOnly = True
        Me.dgv_ficha.RowTemplate.Height = 25
        Me.dgv_ficha.Size = New System.Drawing.Size(669, 355)
        Me.dgv_ficha.TabIndex = 147
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo da Queixa"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "Data"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "Hora"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 40
        '
        'Column4
        '
        Me.Column4.HeaderText = "Endereço"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Informaçoes"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 305
        '
        'Relatorio
        '
        Me.AcceptButton = Me.btn_filtrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(669, 490)
        Me.Controls.Add(Me.dgv_ficha)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.txt_data2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_filtrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Relatorio"
        Me.Text = "Relatorio"
        CType(Me.dgv_ficha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_filtrar As Button
    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_data2 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents dgv_ficha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
