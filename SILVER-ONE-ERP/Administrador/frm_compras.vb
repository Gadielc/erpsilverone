Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars

Public Class frm_compras

    Sub LIST_PROVIDERS()
        Try

            Connect_Database()
            Command = New SqlCommand("SP_LIST_PROVIDERS", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                ' .Parameters.Add("@ID_EMPLOYEE", SqlDbType.Int).Value = TXT_ID.Text.Trim
                Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                Message.Direction = ParameterDirection.Output
                Command.Parameters.Add(Message)
                Rows = Command.ExecuteNonQuery
                If (Rows > 0) Then
                    LBL_RESULT_PROVIDER.Visibility = BarItemVisibility.Always
                    LBL_RESULT_PROVIDER.Caption = Convert.ToString(Message.Value)
                Else
                    LBL_RESULT_PROVIDER.Visibility = BarItemVisibility.Always
                    LBL_RESULT_PROVIDER.Caption = Convert.ToString(Message.Value)
                End If
            End With
            Adapter.SelectCommand = Command
            DataT = New DataTable
            Adapter.Fill(DataT)
            With CB_PROVIDER
                .DataSource = DataT
                .ValueMember = "ID_PROVIDERS"
                .DisplayMember = "PROVEEDOR"
            End With
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Disconnect_Database()

        End Try
    End Sub
    Sub LIST_WAREHOUSE()
        Try

            Connect_Database()
            Command = New SqlCommand("SP_LIST_WAREHOUSE", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                ' .Parameters.Add("@ID_EMPLOYEE", SqlDbType.Int).Value = TXT_ID.Text.Trim
                Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                Message.Direction = ParameterDirection.Output
                Command.Parameters.Add(Message)
                Rows = Command.ExecuteNonQuery
                If (Rows > 0) Then
                    LBL_RESULT_WAREH.Visibility = BarItemVisibility.Always
                    LBL_RESULT_WAREH.Caption = Convert.ToString(Message.Value)
                Else
                    LBL_RESULT_WAREH.Visibility = BarItemVisibility.Always
                    LBL_RESULT_WAREH.Caption = Convert.ToString(Message.Value)
                End If
            End With
            Adapter.SelectCommand = Command
            DataT = New DataTable
            Adapter.Fill(DataT)
            With CB_ALMACEN
                .DataSource = DataT
                .ValueMember = "ID_WAREHOUSE"
                .DisplayMember = "ALM_NUMBER_WAREHOUSE"
            End With
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Disconnect_Database()

        End Try
    End Sub


    Private Sub BTN_SAVE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BTN_SAVE.ItemClick
        For Each Row As DataGridViewRow In dgv_data.Rows
            Dim Cantidad As String = CType(Row.Cells("col_cantidad").Value, String)
            Dim Costo As Double = CType(Row.Cells("col_costo_unit").Value, Double)
            Dim Importe As Double = Val(Cantidad) * (Costo)

            'asignamos a la columna importe el valor de la operacion Val(Cantidad) * (Costo)
            Row.Cells("col_importe").Value = Importe

            'asignamos a la columna precio publico el total del costo unitario multiplicado por 3
            Row.Cells("col_precio_pub").Value = Val(Costo) * 3
            'dgv_data.Rows.RemoveAt(dgv_data.Rows.Count - 1)

            'asignamos a la columna de la linea el valor de la columna accesorio concatenado con el valor de la columna del material
            'creando asi la linea del producto

            Row.Cells("col_linea").Value = Row.Cells("col_accesorio").Value + Row.Cells("col_material").Value

        Next

    End Sub



    Private Sub frm_compras_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Inicializamos el control de la fecha con el valor similar a getdate()'
        'para obtener la fecha y esta se asigne automaticamente al documento
        DT_FECHA.EditValue = DateTime.Now


        'Realizamos el listado del PROVEEDOR
        LIST_PROVIDERS()
        'Realizamos el listado de los almacenes disponibles
        LIST_WAREHOUSE()
    End Sub
End Class