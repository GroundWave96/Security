Imports System.Data.SqlClient

Module Mod_geral
    Public serverPH As String = "DESKTOP-O8SA2V9\SQLEXPRESS"
    Public serverGA As String = "Biel\SQLEXPRESS"
    Public database As String = "db_security"
    Public valid As String = "0"
    Public validar_modo As Integer
    Public valor_cbm, nomee, emaile, senhae, celulare, cpfe As String
    Public reg_id As String
    Public ReadOnly strConPH As String = $"Data Source={serverPH}; Integrated Security=True; Initial Catalog={database}"
    Public ReadOnly strConGA As String = $"Data Source={serverGA}; Integrated Security=True; Initial Catalog={database}"
    Public ReadOnly strConDocker As String = $"Data Source=localhost,1433;Initial Catalog={database};User ID=sa;Password=yourStrong(!)Password;"
    Public ReadOnly strCon As String = strConDocker 'Alterar conexao aqui ---------------------------------------------------
    Public connection As SqlConnection = Nothing


    Public Sub OpenConnection()
        connection = New SqlConnection(strCon)
        connection.Open()
    End Sub

    Public Sub CloseConnection()
        If connection IsNot Nothing Then
            connection.Close()
            connection.Dispose()
            connection = Nothing
        End If
    End Sub
End Module
