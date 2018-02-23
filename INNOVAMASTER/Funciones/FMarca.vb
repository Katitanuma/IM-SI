﻿Imports System.Data.SqlClient

Public Class FMarca
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function MostrarMarca() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarMarcaVehiculo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

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

    Public Function Insertar(ByVal Datos As DatosMarca) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarMarcaVehiculo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Marca", Datos.gMarca)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.ToString)

        Finally
            Desconectarse()

        End Try
    End Function

    Public Function Actualizar(ByVal Datos As DatosMarca) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarMarcaVehiculo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@IdMarca", Datos.gIdMarca)
            cmd.Parameters.AddWithValue("@Marca", Datos.gMarca)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.ToString)

        Finally
            Desconectarse()
        End Try
    End Function


End Class
