Imports System.Data.SqlClient

Public Class Relatorio
    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Dim dt = ObterDados()
        Using frm = New RelatorioGerado(dt)
            frm.ShowDialog()
        End Using
    End Sub

    Private Function ObterDados() As DataTable
        Dim dt = New DataTable()
        dt.Columns.Add("Tipo")
        dt.Columns.Add("Data")
        dt.Columns.Add("Hora")
        dt.Columns.Add("Endereco")
        dt.Columns.Add("Informacoes")

        For Each item In dgv_ficha.Rows
            dt.Rows.Add(item.cells("Column1").value.ToString(), item.cells("Column2").value.ToString(), item.cells("Column3").value.ToString(), item.cells("Column4").value.ToString(), item.cells("Column5").value.ToString())
        Next

        Return dt
    End Function

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()

        ' Adicione o manipulador de eventos dgv_ficha_CellContentClick aqui

        cmb_tipo.Text = "Todas"

        Dim sql As String = "SELECT * FROM tb_ocorrencia "
        Using da As New SqlDataAdapter(sql, connection)

            Using dt As New DataTable()
                da.Fill(dt)

                dgv_ficha.Rows.Clear()
                For Each row As DataRow In dt.Rows
                    Dim index As Integer = dgv_ficha.Rows.Add()
                    dgv_ficha.Rows(index).Cells("Column1").Value = row("Tipo")
                    dgv_ficha.Rows(index).Cells("Column2").Value = row("Data")
                    dgv_ficha.Rows(index).Cells("Column3").Value = row("Hora")
                    dgv_ficha.Rows(index).Cells("Column4").Value = row("CEP")
                    dgv_ficha.Rows(index).Cells("Column5").Value = row("Info")


                Next row
            End Using
        End Using

        CloseConnection()
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        OpenConnection()

        Dim inicio As DateTime
        Dim fim As DateTime
        If txt_data.Text <> "  /  /" And txt_data2.Text <> "  /  /" And cmb_tipo.Text <> "" Then

            If DateTime.TryParse(txt_data.Text, inicio) AndAlso DateTime.TryParse(txt_data2.Text, fim) Then
                Dim sql As String = "SELECT Tipo, Data, Hora, CEP, Info FROM tb_ocorrencia WHERE CONVERT (date, Data, 103) >= CONVERT (Date, '" + inicio.ToString("dd/MM/yyyy") + "',103) AND CONVERT (date, Data, 103) <= CONVERT (Date, '" + fim.ToString("dd/MM/yyyy") + "',103)"
                If Not String.IsNullOrEmpty(cmb_tipo.Text) And cmb_tipo.Text <> "Todas" Then
                    sql &= " AND Tipo = @tipo"
                End If

                Using da As New SqlDataAdapter(sql, connection)

                    If Not String.IsNullOrEmpty(cmb_tipo.Text) Then
                        da.SelectCommand.Parameters.AddWithValue("@tipo", cmb_tipo.SelectedItem.ToString())
                    End If

                    Using dt As New DataTable()
                        da.Fill(dt)

                        dgv_ficha.Rows.Clear()
                        For Each row As DataRow In dt.Rows
                            Dim index As Integer = dgv_ficha.Rows.Add()
                            dgv_ficha.Rows(index).Cells("Column1").Value = row("Tipo")
                            dgv_ficha.Rows(index).Cells("Column2").Value = row("Data")
                            dgv_ficha.Rows(index).Cells("Column3").Value = row("Hora")
                            dgv_ficha.Rows(index).Cells("Column4").Value = row("CEP")
                            dgv_ficha.Rows(index).Cells("Column5").Value = row("Info")
                        Next row
                    End Using
                End Using
            Else
                MsgBox("Data inválida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro")
            End If

        Else
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
        End If

        CloseConnection()
    End Sub
End Class