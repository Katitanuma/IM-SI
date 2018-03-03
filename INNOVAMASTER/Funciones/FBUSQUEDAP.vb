Imports System.Data.SqlClient
Public Class FBUSQUEDAP
    Inherits Conexion

    Dim cmd As New SqlCommand
    Public Function MostrarPP(ByVal pedido As DatosBUsquedaPed) As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("Sp_BuscarProductoPedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con
            cmd.Parameters.AddWithValue("@proveedor", pedido.gproveedor)
            Dim da As New SqlDataAdapter
            Dim dt As New DataTable

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            Desconectarse()
        End Try

    End Function


End Class
