Imports System.Data.SqlClient

Public Class Ficha
    Private Sub Ficha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_preencher()
    End Sub

    Private Sub dgv_preencher()
        OpenConnection()

        Dim sql As String = "SELECT * FROM tb_ocorrencia WHERE registrador = @cpfe"
        Using cmd As New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@cpfe", cpfe)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                dgv_ficha.Rows.Clear()

                While reader.Read()
                    Dim index As Integer = dgv_ficha.Rows.Add()
                    dgv_ficha.Rows(index).Cells("Column1").Value = reader("Tipo")
                    dgv_ficha.Rows(index).Cells("Column2").Value = reader("Data")
                    dgv_ficha.Rows(index).Cells("Column3").Value = reader("Hora")
                    dgv_ficha.Rows(index).Cells("Column4").Value = reader("CEP")
                    dgv_ficha.Rows(index).Cells("Column5").Value = reader("Info")
                End While
            End Using
        End Using

        CloseConnection()
    End Sub





    Private Sub Ficha_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        dgv_preencher()
    End Sub
End Class