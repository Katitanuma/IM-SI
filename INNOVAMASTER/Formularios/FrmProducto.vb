Imports System.Data.SqlClient
Imports System.IO
Public Class FrmProducto
    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarProducto()
        Focus()
        LlenarCombos()
        LlenarCombos2()
        CboModelo.EditValue = Nothing
        Validate()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Producto")

    End Sub
    Private Sub MostrarProducto()
        Try
            Dim datos As New Fproducto
            dt = datos.MostrarProducto

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                GCPrincipal.DataSource = dt
            Else
                LblFilas.Visible = True
                GCPrincipal.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtIdProducto.Enabled = True
        BtnCodigoProveedor.Visible = False
        ChkEstado.Checked = True
        ChkGravado.Checked = False
        GbProducto.Enabled = True
        TxtIdProducto.EditValue = Nothing
        TxtDescripcion.EditValue = Nothing
        TxtCosto.Value = 0
        TxtGravado.Value = 0
        TxtPrecioUnitario.Value = 0
        TxtPrecioMayorista.Value = 0
        TxtExistencia.Value = 0
        CboCategoria.EditValue = Nothing
        CboModelo.EditValue = Nothing
        BtnCancelar.Visible = True
        BtnInsertar.Visible = True
        BtnEditar.Visible = False
        BtnNuevo.Visible = False
        GCPrincipal.Enabled = False
        PbProducto.Image = Nothing
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            GCPrincipal.Enabled = True
            GbProducto.Enabled = False
            TxtIdProducto.EditValue = Nothing
            TxtDescripcion.EditValue = Nothing
            TxtCosto.Value = 0
            TxtGravado.Value = 0
            TxtPrecioUnitario.Value = 0
            TxtPrecioMayorista.Value = 0
            TxtExistencia.Value = 0
            CboCategoria.EditValue = Nothing
            CboModelo.EditValue = Nothing
            BtnCancelar.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = False
            BtnEditar.Visible = True
            BtnNuevo.Visible = True
            ChkEstado.Checked = True
            Focus()
            BtnCodigoProveedor.Visible = False

            PbProducto.Image = Nothing
        End If


    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdProducto.Text <> Nothing Then
            TxtIdProducto.Enabled = False
            BtnCodigoProveedor.Visible = True
            GbProducto.Enabled = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            GCPrincipal.Enabled = False
            BtnCodigoProveedor.Visible = True
        Else
            MessageBox.Show("Seleccione el Producto a Editar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtIdProducto.Text = Nothing Then
            MessageBox.Show("Ingrese el Código del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Ingrese la Descripción del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDbl(TxtCosto.Value) <= 0 Then
            MessageBox.Show("Ingrese el Costo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDbl(TxtPrecioUnitario.Value) <= 0 Then
            MessageBox.Show("Ingrese el Precio Unitario del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDbl(TxtPrecioMayorista.Value) <= 0 Then
            MessageBox.Show("Ingrese el Precio Unitario del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboCategoria.EditValue = Nothing Then
            MessageBox.Show("Seleccione la Categoria del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboModelo.EditValue = Nothing Then
            MessageBox.Show("Ingrese el Modelo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CInt(TxtExistencia.Value) <= 5 Then
            MessageBox.Show("No se Puede Ingresar Menor de 5 Productos en Existencia", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim datos As New DatosProducto
                Dim funcion As New Fproducto
                datos.gIdProducto = TxtIdProducto.Text
                datos.gDescripcion = TxtDescripcion.Text
                datos.gCosto = CDbl(TxtCosto.Text)
                If TxtGravado.Text = Nothing Then
                    datos.gGravado = 0
                Else
                    datos.gGravado = CDbl(TxtGravado.Value)
                End If

                datos.gPrecioUnitario = CDbl(TxtPrecioUnitario.Value)
                datos.gPrecioMayorista = CDbl(TxtPrecioMayorista.Value)
                datos.gExistecia = CInt(TxtExistencia.Value)

                Dim ms As New MemoryStream

                If PbProducto.Image Is Nothing Then
                    PbProducto.Image = My.Resources.NULLA
                End If
                PbProducto.Image.Save(ms, PbProducto.Image.RawFormat)
                datos.gImagen = ms.GetBuffer
                If ChkEstado.Checked = True Then
                    datos.gEstado = "Activo"
                Else
                    datos.gEstado = "Inactivo"
                End If

                datos.gIdCategoria = CInt(CboCategoria.EditValue)


                datos.gIdModelo = CInt(CboModelo.EditValue)




                If funcion.Insertar(datos) Then
                    MessageBox.Show("Producto Insertado Con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GbProducto.Enabled = False
                    TxtIdProducto.EditValue = Nothing
                    TxtDescripcion.EditValue = Nothing
                    TxtCosto.Value = 0
                    TxtGravado.Value = 0
                    TxtPrecioUnitario.Value = 0
                    TxtPrecioMayorista.Value = 0
                    TxtExistencia.Value = 0
                    CboCategoria.EditValue = Nothing
                    CboModelo.EditValue = Nothing
                    BtnCancelar.Visible = False
                    BtnInsertar.Visible = False
                    BtnEditar.Visible = False
                    BtnEditar.Visible = True
                    BtnNuevo.Visible = True
                    ChkEstado.Checked = True
                    GCPrincipal.Enabled = True
                    MostrarProducto()
                    PbProducto.Image = Nothing
                    BtnCodigoProveedor.Visible = False
                End If

            Catch ex As Exception

                MsgBox(ex.ToString)


            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub
    Public Sub LlenarCombos()
        Try
            Conec.Conectarse()
            Dim da As New SqlDataAdapter
            Dim _DT2 As New DataTable
            Dim _DT As New DataTable
            cmd = New SqlCommand("Select IdCategoria,Categoria from Categoria")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(_DT2)
                CboCategoria.Properties.DataSource = _DT2
                cmd.Dispose()
                da.Dispose()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub

    Public Sub LlenarCombos2()
        Try
            Conec.Conectarse()
            Dim _DT As New DataTable
            Dim cmd2 As New SqlCommand
            Dim da2 As New SqlDataAdapter
            cmd2 = New SqlCommand("MostrarModeloVehiculo")
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Connection = Conec.Con

            If cmd2.ExecuteNonQuery Then
                da2 = New SqlDataAdapter(cmd2)
                da2.Fill(_DT)
                CboModelo.Properties.DataSource = _DT
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtIdProducto.Text = Nothing Then
            MessageBox.Show("Ingrese el Código del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Ingrese la Descripción del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDbl(TxtCosto.Value) <= 0 Then
            MessageBox.Show("Ingrese el Costo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDbl(TxtPrecioUnitario.Value) <= 0 Then
            MessageBox.Show("Ingrese el Precio Unitario del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDbl(TxtPrecioMayorista.Value) <= 0 Then
            MessageBox.Show("Ingrese el Precio Unitario del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboCategoria.EditValue = Nothing Then
            MessageBox.Show("Seleccione la Categoria del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboModelo.EditValue = Nothing Then
            MessageBox.Show("Ingrese el Modelo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CInt(TxtExistencia.Value) <= 5 Then
            MessageBox.Show("No se Puede Ingresar Menor de 5 Productos en Existencia", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim datos As New DatosProducto
                Dim funcion As New Fproducto
                datos.gIdProducto = TxtIdProducto.Text
                datos.gDescripcion = TxtDescripcion.Text
                datos.gCosto = CDbl(TxtCosto.Text)
                If TxtGravado.Text = Nothing Then
                    datos.gGravado = 0
                Else
                    datos.gGravado = CDbl(TxtGravado.Value)
                End If

                datos.gPrecioUnitario = CDbl(TxtPrecioUnitario.Value)
                datos.gPrecioMayorista = CDbl(TxtPrecioMayorista.Value)
                datos.gExistecia = CInt(TxtExistencia.Value)

                Dim ms As New MemoryStream

                If PbProducto.Image Is Nothing Then
                    PbProducto.Image = My.Resources.NULLA
                End If
                PbProducto.Image.Save(ms, PbProducto.Image.RawFormat)
                datos.gImagen = ms.GetBuffer
                If ChkEstado.Checked = True Then
                    datos.gEstado = "Activo"
                Else
                    datos.gEstado = "Inactivo"
                End If

                datos.gIdCategoria = CInt(CboCategoria.EditValue)


                datos.gIdModelo = CInt(CboModelo.EditValue)




                If funcion.Editar(datos) Then
                    MessageBox.Show("Producto Editado Con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GbProducto.Enabled = False
                    TxtIdProducto.EditValue = Nothing
                    TxtDescripcion.EditValue = Nothing
                    TxtCosto.Value = 0
                    TxtGravado.Value = 0
                    TxtPrecioUnitario.Value = 0
                    TxtPrecioMayorista.Value = 0
                    TxtExistencia.Value = 0
                    CboCategoria.EditValue = Nothing
                    CboModelo.EditValue = Nothing
                    BtnCancelar.Visible = False
                    BtnInsertar.Visible = False
                    BtnEditar.Visible = False
                    BtnEditar.Visible = True
                    BtnNuevo.Visible = True
                    ChkEstado.Checked = True
                    GCPrincipal.Enabled = True
                    MostrarProducto()
                    PbProducto.Image = Nothing
                    BtnCodigoProveedor.Visible = False
                End If

            Catch ex As Exception

                MsgBox(ex.ToString)


            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub
    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs)
        If ChkEstado.Checked = False Then
            ChkEstado.Text = "Inactivo"
        Else
            ChkEstado.Text = "Activo"
        End If
    End Sub
    Private Sub BtnAgregarImagen_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Filter = "Imagenes JPG|*.jpg|Imagenes GIF|*.gif|Imagenes Bitmasps|*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PbProducto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub BtnEliminarImagen_Click(sender As Object, e As EventArgs)
        PbProducto.Image = Nothing
    End Sub






    Private Sub BtnCodigoProveedor_Click(sender As Object, e As EventArgs) Handles BtnCodigoProveedor.Click
        FrmProductoProveedor.ShowDialog()
        FrmProductoProveedor.Focus()
    End Sub



    Private Sub GCPrincipal_Click(sender As Object, e As EventArgs) Handles GCPrincipal.Click
        TxtIdProducto.Text = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColIdProducto)
        TxtDescripcion.Text = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColDescripcion)
        TxtCosto.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCosto)

        TxtGravado.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV)

        If CDbl(TxtGravado.Value) > 0 Then
            ChkGravado.Checked = True
        Else
            ChkGravado.Checked = False
        End If
        TxtPrecioUnitario.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPrecioUnitario)
        TxtPrecioMayorista.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPreciolMayorista)
        TxtExistencia.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColExistencia)
        CboCategoria.Text = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCategoria)
        Conec.Conectarse()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("Select IdModelo From ModeloVehiculo Where Modelo = '" & DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColModelo).ToString & "'")
        cmd.Connection = Conec.Con
        cmd.CommandType = CommandType.Text


        dr = cmd.ExecuteReader
        If (dr.Read) Then
            CboModelo.EditValue = dr(0)
        End If
        dr.Close()
        Conec.Desconectarse()

        Dim Imagen() As Byte = DirectCast(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColImagen), Byte())
        Dim ms As New MemoryStream(Imagen)
        PbProducto.Image = Image.FromStream(ms)

        If DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColEstado).ToString = "Activo" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If

    End Sub

    Private Sub DgvProductos_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles DgvProductos.FocusedRowChanged
        TxtIdProducto.Text = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColIdProducto)
        TxtDescripcion.Text = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColDescripcion)
        TxtCosto.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCosto)

        TxtGravado.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColISV)

        If CDbl(TxtGravado.Value) > 0 Then
            ChkGravado.Checked = True
        Else
            ChkGravado.Checked = False
        End If
        TxtPrecioUnitario.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPrecioUnitario)
        TxtPrecioMayorista.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColPreciolMayorista)
        TxtExistencia.Value = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColExistencia)
        CboCategoria.Text = DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColCategoria)

        Conec.Conectarse()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("Select IdModelo From ModeloVehiculo Where Modelo = '" & DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColModelo).ToString & "'")
        cmd.Connection = Conec.Con
        cmd.CommandType = CommandType.Text


        dr = cmd.ExecuteReader

        If dr.Read Then
            CboModelo.EditValue = dr(0)
        End If
        dr.Close()
        Conec.Desconectarse()

        Dim Imagen() As Byte = DirectCast(DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColImagen), Byte())
        Dim ms As New MemoryStream(Imagen)
        PbProducto.Image = Image.FromStream(ms)

        If DgvProductos.GetRowCellValue(DgvProductos.FocusedRowHandle, ColEstado).ToString = "Activo" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If
    End Sub

    Private Sub ChkGravado_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        MostrarProducto()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Exportar_a_PDF(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Exportar_a_Excel(GCPrincipal, Me.Text)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub ChkGravado_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkGravado.CheckedChanged
        If ChkGravado.CheckState = CheckState.Checked Then
            If CDbl(TxtPrecioUnitario.Value) > 0 Then
                TxtGravado.Value = CDbl(TxtPrecioUnitario.Value) * My.Settings.ISV
            Else
                TxtGravado.Value = 0
                ChkGravado.Checked = False
            End If
        Else
            TxtGravado.Value = 0
        End If

    End Sub

    Private Sub TxtPrecioUnitario_EditValueChanged(sender As Object, e As EventArgs) Handles TxtPrecioUnitario.EditValueChanged
        If ChkGravado.CheckState = CheckState.Checked Then
            If CDbl(TxtPrecioUnitario.Value) > 0 Then
                TxtGravado.Value = CDbl(TxtPrecioUnitario.Value) * My.Settings.ISV
            Else
                TxtGravado.Value = 0
                ChkGravado.Checked = False
            End If
        Else
            TxtGravado.Value = 0
        End If
    End Sub
End Class