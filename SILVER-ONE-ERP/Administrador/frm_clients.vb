﻿Imports DevExpress.XtraEditors
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports System.IO
Public Class frm_clients
    Dim array_nombres(,) As String


    Sub LIST_FOLIO()
        Try
            Connect_Database()
            Command = New SqlCommand("SP_LIST_CODE_CLIENT", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                .Parameters.Add("@US_USERNAME", SqlDbType.NVarChar, 100).Value = frn_main_form.LBL_USERNAME.Caption
                Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                Message.Direction = ParameterDirection.Output
                Command.Parameters.Add(Message)
                Rows = Command.ExecuteNonQuery
                If (Rows > 0) Then
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                Else
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                End If
            End With
            Adapter.SelectCommand = Command
            DataT = New DataTable
            Adapter.Fill(DataT)
            With CB_FOLIO
                .DataSource = DataT
                .ValueMember = "ID_FOLIOS"
                .DisplayMember = "FO_CONCAT"
            End With
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Disconnect_Database()

        End Try
    End Sub
    Sub LIST_CITY()
        Try
            Connect_Database()
            Command = New SqlCommand("SP_LIST_CITY", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                '   .Parameters.Add("@US_USERNAME", SqlDbType.NVarChar, 100).Value = frm_main_menu.lbl_user_name.Caption
                Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                Message.Direction = ParameterDirection.Output
                Command.Parameters.Add(Message)
                Rows = Command.ExecuteNonQuery
                If (Rows > 0) Then
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                Else
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                End If
            End With
            Adapter.SelectCommand = Command
            DataT = New DataTable
            Adapter.Fill(DataT)
            With CB_CITY
                .DataSource = DataT
                .ValueMember = "ID_CITY"
                .DisplayMember = "CI_NAME"
            End With
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Disconnect_Database()

        End Try
    End Sub
    Sub LIST_ESTATUS()
        Try
            Connect_Database()
            Command = New SqlCommand("SP_LIST_ESTATUS_CLIENT", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                '   .Parameters.Add("@US_USERNAME", SqlDbType.NVarChar, 100).Value = frm_main_menu.lbl_user_name.Caption
                Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                Message.Direction = ParameterDirection.Output
                Command.Parameters.Add(Message)
                Rows = Command.ExecuteNonQuery
                If (Rows > 0) Then
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                Else
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                End If
            End With
            Adapter.SelectCommand = Command
            DataT = New DataTable
            Adapter.Fill(DataT)
            With CB_STATUS
                .DataSource = DataT
                .ValueMember = "ID_STATUS_CLIENT"
                .DisplayMember = "ST_NAME"
            End With
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Disconnect_Database()

        End Try
    End Sub
    Sub LIST_VALUE_ESTATUS()
        Try
            Connect_Database()
            Command = New SqlCommand("SP_VALUE_STATUS_CLIENTS_CLIENTS", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                .Parameters.Add("@ID_STATUS_CLIENT", SqlDbType.NVarChar, 100).Value = TXT_ID.Text
                Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                Message.Direction = ParameterDirection.Output
                Command.Parameters.Add(Message)
                Rows = Command.ExecuteNonQuery
                If (Rows > 0) Then
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                Else
                    LB_FOLIO.Visibility = BarItemVisibility.Always
                    LB_FOLIO.Caption = Convert.ToString(Message.Value)
                End If
            End With
            Adapter.SelectCommand = Command
            DataT = New DataTable
            Adapter.Fill(DataT)
            With CB_STATUS
                .DataSource = DataT
                .ValueMember = "ID_STATUS_CLIENT"
                .DisplayMember = "ST_NAME"
            End With
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Disconnect_Database()

        End Try
    End Sub

    Sub FILL_DATA()
        Try
            Connect_Database()
            Command = New SqlCommand("SP_SILV_CLIENTS_VIEW", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                Message.Direction = ParameterDirection.Output
                Command.Parameters.Add(Message)
                Rows = Command.ExecuteNonQuery
                If (Rows > 0) Then
                    LB_RESULT.Visibility = BarItemVisibility.Always
                    LB_RESULT.Caption = Convert.ToString(Message.Value)

                Else
                    LB_RESULT.Visibility = BarItemVisibility.Always
                    LB_RESULT.Caption = Convert.ToString(Message.Value)
                End If
                Adapter = New SqlDataAdapter(Command)
                DataT = New DataTable
                Adapter.Fill(DataT)
                DGV_DATA.DataSource = DataT
                G_DATA.BestFitColumns()
            End With
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Disconnect_Database()
        End Try
    End Sub
    Dim img() As Byte
#Region "Metodos Imagen"
    'funcion para convertir imagen a binario
    Private Function imagen_bytes(ByVal Imagen As Image) As Byte()
        If Not Imagen Is Nothing Then
            'variable de datos binarios
            Dim bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(bin, Imaging.ImageFormat.Jpeg)
            'RETORNA BINARIO
            Return bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    'funcion para convertir binario a imagen
    Private Function bytes_imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay una imagen
            If Not Imagen Is Nothing Then
                'capturamos el arreglo con memorystream hacia bin
                Dim bin As New MemoryStream(Imagen)
                'con el metodo fromstream de image obtenemos la imagen
                Dim resultado As Image = Image.FromStream(bin)
                'la retornamos
                Return resultado
            Else
                Return Nothing

            End If
        Catch ex As Exception
            Return Nothing

        End Try
    End Function
    Sub search_img()
        Try
            Connect_Database()

            Command = New SqlCommand("SP_OBTAIN_IMAGE_CLIENT", connection) With {.CommandType = CommandType.StoredProcedure}
            With Command
                .Parameters.Add("@ID_CLIENT", SqlDbType.Int).Value = TXT_ID.Text
                Dim msgparam As New SqlParameter("@MENSAJE", SqlDbType.VarChar, 100) With {.Direction = ParameterDirection.Output}
                .Parameters.Add(msgparam)
                Dim rowsAffected As Integer = Command.ExecuteNonQuery()
                Dim mensaje As String = ""
                If rowsAffected > 0 Then
                    'Convert.ToString(XtraMessageBox.Show(CType(COMANDO.Parameters("@MSG").Value, String), "SGI-TEBAEV", MessageBoxButtons.OK))
                    LBL_PHOTO.Visibility = CType(True, DevExpress.XtraBars.BarItemVisibility)

                    LBL_PHOTO.Caption = Convert.ToString(Command.Parameters("@MENSAJE").Value)
                Else
                    'Convert.ToString(XtraMessageBox.Show(CType(COMANDO.Parameters("@MSG").Value, String), "SGI-TEBAEV", MessageBoxButtons.OK))
                    LBL_PHOTO.Visibility = CType(True, DevExpress.XtraBars.BarItemVisibility)
                    LBL_PHOTO.Caption = Convert.ToString(Command.Parameters("@MENSAJE").Value)
                End If
            End With
            Dim lectores As SqlDataReader
            lectores = Command.ExecuteReader

            Do While lectores.Read
                Me.pc_img.Image = bytes_imagen(CType(lectores.GetValue(0), Byte()))
                Exit Do
            Loop
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Disconnect_Database()

        End Try
    End Sub

#End Region

    Sub clean_fields()
        TXT_ID.ResetText()
        TX_CALLE.ResetText()
        TX_COLONIA.ResetText()
        TX_CRUZ.ResetText()
        TX_CURP.ResetText()
        TX_EXTERIOR.ResetText()
        TX_INTERIOR.ResetText()
        'TX_LOCAL.ResetText()
        TX_MAT.ResetText()
        TX_NAME.ResetText()
        TX_OBS.ResetText()
        TX_PAT.ResetText()

        TX_TELEFONO.ResetText()
        C_ACTIVE_INACTIVE.CheckState = CheckState.Unchecked
        Me.pc_img.Image = Nothing
    End Sub

    Private Sub frm_clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_SILV_CLIENTS_REPORT' Puede moverla o quitarla según sea necesario.
        'Me.SP_SILV_CLIENTS_REPORTTableAdapter.Fill(Me.DataSet1.SP_SILV_CLIENTS_REPORT)
        'llena en automatico las listas cada que el formulario es mostrado por primera vez
        LIST_FOLIO()
        LIST_CITY()
        LIST_ESTATUS()

        array_nombres = {{"", ""},
           {"AGUASCALIENTES", "AS"},
           {"BAJA CALIFORNIA", "BC"},
           {"BAJA CALIFORNIA SUR", "BS"},
            {"CAMPECHE", "CC"},
               {"CHIAPAS", "CS"},
               {"CHIHUAHUA", "CH"},
               {"COAHUILA", "CL"},
               {"COLIMA", "CM"},
               {"DISTRITO FEDERAL", "DF"},
               {"DURANGO", "DG"},
               {"GUANAJUATO", "GT"},
               {"GUERRERO", "GR"},
               {"HIDALGO", "HG"},
               {"JALISCO", "JC"},
               {"MEXICO", "MC"},
               {"MICHOACAN", "MN"},
               {"MORELOS", "MS"},
               {"NAYARIT", "NT"},
               {"NUEVO LEON", "NL"},
               {"OAXACA", "OC"},
               {"PUEBLA", "PL"},
               {"QUERETARO", "QT"},
               {"QUINTANA ROO", "QR"},
               {"SAN LUIS POTOSI", "SP"},
               {"SINALOA", "SL"},
               {"SONORA", "SR"},
               {"TABASCO", "TC"},
               {"TAMAULIPAS", "TS"},
               {"TLAXCALA", "TL"},
               {"VERACRUZ", "VZ"},
               {"YUCATÁN", "YN"},
               {"ZACATECAS", "ZS"},
               {"NACIDO EXTRANJERO", "NE"}}

        Dim contador As Integer
        contador = 0
        CB_ESTADO.Items.Add("Selecciona")
        CB_ESTADO.SelectedIndex = 0
        CB_ESTADO.DropDownStyle = ComboBoxStyle.DropDownList
        While contador <> array_nombres.Length / 2
            CB_ESTADO.Items.Add(array_nombres(contador, 0))
            contador += 1
        End While
        CB_ESTADO.Items.Remove("")

        FILL_DATA()
    End Sub

    Private Sub BTN_SAVE_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_SAVE.ItemClick
        Dim VALIDA As Boolean = False

        If (TX_NAME.Text = "") Then
            XtraMessageBox.Show("DEBE ESPECIFICAR EL NOMBRE DE LA PERSONA PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VALIDA = True
            Exit Sub
        End If
        If (TX_PAT.Text = "") Then
            XtraMessageBox.Show("DEBE ESPECIFICAR SU APELLIDO PATERNO PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VALIDA = True
            Exit Sub
        End If
        If (TX_MAT.Text = "") Then
            XtraMessageBox.Show("DEBE ESPECIFICAR SU APELLIDO MATERNO PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VALIDA = True
            Exit Sub
        End If
        If (TX_CALLE.Text = "") Then
            XtraMessageBox.Show("DEBE ESPECIFICAR CALLE/DIRECCION PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VALIDA = True
            Exit Sub
        End If


        If (VALIDA = True) Then
            XtraMessageBox.Show("DEBE ESPECIFICAR LA INFORMACION REQUERIDA PARA EL REGISTRO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Try
                Connect_Database()
                Command = New SqlCommand("SP_SILV_CLIENTS_INSERT", connection) With {.CommandType = CommandType.StoredProcedure}
                With Command
                    ' .Parameters.Add("@ID_USER", SqlDbType.Int).Value = TXT_ID.Text
                    .Parameters.Add("@CL_CITY", SqlDbType.NVarChar, 50).Value = CB_CITY.Text
                    .Parameters.Add("@CL_STATE", SqlDbType.NVarChar, 50).Value = CB_ESTADO.Text
                    .Parameters.Add("@ID_STATUS_CLIENT", SqlDbType.Int).Value = CB_STATUS.SelectedValue

                    .Parameters.Add("@CL_NAME", SqlDbType.NVarChar, 200).Value = TX_NAME.Text
                    .Parameters.Add("@CL_PATERN_SURNAME", SqlDbType.NVarChar, 50).Value = TX_PAT.Text
                    .Parameters.Add("@CL_MATERNAL_SURNAME", SqlDbType.NVarChar, 100).Value = TX_MAT.Text
                    'sexo
                    .Parameters.Add("@CL_SEX", SqlDbType.NVarChar, 50).Value = R_SEX.EditValue
                    .Parameters.Add("@CL_DATE_BORN", SqlDbType.Date).Value = DT_FECHA_NAC.EditValue

                    If (TX_CURP.Text = "") Then
                        .Parameters.AddWithValue("@CL_CURP", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_CURP", SqlDbType.NVarChar, 200).Value = TX_CURP.Text
                    End If


                    '  .Parameters.Add("@CL_STREET", SqlDbType.NVarChar, 100).Value = TX_CALLE.Text
                    If (TX_CALLE.Text = "") Then
                        .Parameters.AddWithValue("@CL_STREET", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_STREET", SqlDbType.NVarChar, 200).Value = TX_CALLE.Text
                    End If


                    If (TX_EXTERIOR.Text = "") Then
                        .Parameters.AddWithValue("@CL_NO_EXT", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_NO_EXT", SqlDbType.NVarChar, 200).Value = TX_EXTERIOR.Text
                    End If

                    If (TX_INTERIOR.Text = "") Then
                        .Parameters.AddWithValue("@CL_NO_INT", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_NO_INT", SqlDbType.NVarChar, 200).Value = TX_INTERIOR.Text
                    End If

                    If (TX_CRUZ.Text = "") Then
                        .Parameters.AddWithValue("@CL_CRZMNT", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_CRZMNT", SqlDbType.NVarChar, 200).Value = TX_CRUZ.Text
                    End If

                    If (TX_COLONIA.Text = "") Then
                        .Parameters.AddWithValue("@CL_COLOGNE", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_COLOGNE", SqlDbType.NVarChar, 200).Value = TX_COLONIA.Text
                    End If

                    'If (TX_LOCAL.Text = "") Then
                    '    .Parameters.AddWithValue("@CL_LOC", DBNull.Value)
                    'Else
                    '    .Parameters.Add("@CL_LOC", SqlDbType.NVarChar, 200).Value = TX_LOCAL.Text
                    'End If

                    If (TX_TELEFONO.Text = "") Then
                        .Parameters.AddWithValue("@CL_PHONE", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_PHONE", SqlDbType.NVarChar, 200).Value = TX_TELEFONO.Text
                    End If

                    If (CB_PREF.Text = "") Then
                        .Parameters.AddWithValue("@CL_CLASIF", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_CLASIF", SqlDbType.NVarChar, 200).Value = CB_PREF.Text
                    End If

                    .Parameters.Add("@CL_TYPE", SqlDbType.NVarChar, 100).Value = R_TIPO.EditValue

                    If (TX_OBS.Text = "") Then
                        .Parameters.AddWithValue("@CL_OBSERVATIONS", DBNull.Value)
                    Else
                        .Parameters.Add("@CL_OBSERVATIONS", SqlDbType.NVarChar, 200).Value = TX_OBS.Text
                    End If

                    .Parameters.Add("@CL_ACTIVE_INACTIVE", SqlDbType.Int).Value = C_ACTIVE_INACTIVE.CheckState
                    .Parameters.Add("@CL_USER_CREATOR", SqlDbType.NVarChar, 100).Value = frn_main_form.LBL_USERNAME.Caption
                    .Parameters.Add("@CL_KEY", SqlDbType.NVarChar, 50).Value = CB_FOLIO.Text


                    img = imagen_bytes(Me.pc_img.Image)
                    .Parameters.AddWithValue("@CL_FOTO", img)


                    Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                    Message.Direction = ParameterDirection.Output
                    Command.Parameters.Add(Message)
                    Rows = Command.ExecuteNonQuery
                    If (Rows > 0) Then
                        XtraMessageBox.Show(CType(Message.Value, String), "SISTEMA", MessageBoxButtons.OK)
                    Else
                        XtraMessageBox.Show(CType(Message.Value, String), "SISTEMA", MessageBoxButtons.OK)
                    End If

                End With

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Disconnect_Database()
                clean_fields()
                FILL_DATA()
            End Try

        End If
    End Sub

    Private Sub BTN_EDIT_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_EDIT.ItemClick
        Dim VALIDA As Boolean = False

        If (TX_NAME.Text = "") Then
            XtraMessageBox.Show("DEBE ESPECIFICAR EL NOMBRE DE LA PERSONA PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VALIDA = True
            Exit Sub
        End If
        If (TX_PAT.Text = "") Then
            XtraMessageBox.Show("DEBE ESPECIFICAR SU APELLIDO PATERNO PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VALIDA = True
            Exit Sub
        End If
        If (TX_MAT.Text = "") Then
            XtraMessageBox.Show("DEBE ESPECIFICAR SU APELLIDO MATERNO PARA CONTINUAR", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            VALIDA = True
            Exit Sub
        End If
        If (VALIDA = True) Then
            XtraMessageBox.Show("FALTA INFORMACION POR ESPECIFICAR EN EL SISTEMA", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If (XtraMessageBox.Show("¿DESEA MODIFICAR LA INFORMACION DEL CLIENTE?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                Exit Sub
            Else
                Try
                    Connect_Database()
                    Command = New SqlCommand("SP_SILV_CLIENTS_EDIT", connection) With {.CommandType = CommandType.StoredProcedure}
                    With Command
                        .Parameters.Add("@ID_CLIENT", SqlDbType.Int).Value = TXT_ID.Text
                        .Parameters.Add("@CL_CITY", SqlDbType.NVarChar, 50).Value = CB_CITY.Text
                        .Parameters.Add("@CL_STATE", SqlDbType.NVarChar, 50).Value = CB_ESTADO.Text
                        .Parameters.Add("@ID_STATUS_CLIENT", SqlDbType.Int).Value = CB_STATUS.SelectedValue

                        .Parameters.Add("@CL_NAME", SqlDbType.NVarChar, 200).Value = TX_NAME.Text
                        .Parameters.Add("@CL_PATERN_SURNAME", SqlDbType.NVarChar, 50).Value = TX_PAT.Text
                        .Parameters.Add("@CL_MATERNAL_SURNAME", SqlDbType.NVarChar, 100).Value = TX_MAT.Text
                        'sexo
                        .Parameters.Add("@CL_SEX", SqlDbType.NVarChar, 50).Value = R_SEX.EditValue
                        .Parameters.Add("@CL_DATE_BORN", SqlDbType.Date).Value = DT_FECHA_NAC.EditValue

                        If (TX_CURP.Text = "") Then
                            .Parameters.AddWithValue("@CL_CURP", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_CURP", SqlDbType.NVarChar, 200).Value = TX_CURP.Text
                        End If


                        '  .Parameters.Add("@CL_STREET", SqlDbType.NVarChar, 100).Value = TX_CALLE.Text
                        If (TX_CALLE.Text = "") Then
                            .Parameters.AddWithValue("@CL_STREET", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_STREET", SqlDbType.NVarChar, 200).Value = TX_CALLE.Text
                        End If


                        If (TX_EXTERIOR.Text = "") Then
                            .Parameters.AddWithValue("@CL_NO_EXT", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_NO_EXT", SqlDbType.NVarChar, 200).Value = TX_EXTERIOR.Text
                        End If

                        If (TX_INTERIOR.Text = "") Then
                            .Parameters.AddWithValue("@CL_NO_INT", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_NO_INT", SqlDbType.NVarChar, 200).Value = TX_INTERIOR.Text
                        End If

                        If (TX_CRUZ.Text = "") Then
                            .Parameters.AddWithValue("@CL_CRZMNT", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_CRZMNT", SqlDbType.NVarChar, 200).Value = TX_CRUZ.Text
                        End If

                        If (TX_COLONIA.Text = "") Then
                            .Parameters.AddWithValue("@CL_COLOGNE", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_COLOGNE", SqlDbType.NVarChar, 200).Value = TX_COLONIA.Text
                        End If

                        'If (TX_LOCAL.Text = "") Then
                        '    .Parameters.AddWithValue("@CL_LOC", DBNull.Value)
                        'Else
                        '    .Parameters.Add("@CL_LOC", SqlDbType.NVarChar, 200).Value = TX_LOCAL.Text
                        'End If

                        If (TX_TELEFONO.Text = "") Then
                            .Parameters.AddWithValue("@CL_PHONE", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_PHONE", SqlDbType.NVarChar, 200).Value = TX_TELEFONO.Text
                        End If

                        If (CB_PREF.Text = "") Then
                            .Parameters.AddWithValue("@CL_CLASIF", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_CLASIF", SqlDbType.NVarChar, 200).Value = CB_PREF.Text
                        End If

                        .Parameters.Add("@CL_TYPE", SqlDbType.NVarChar, 100).Value = R_TIPO.EditValue

                        If (TX_OBS.Text = "") Then
                            .Parameters.AddWithValue("@CL_OBSERVATIONS", DBNull.Value)
                        Else
                            .Parameters.Add("@CL_OBSERVATIONS", SqlDbType.NVarChar, 200).Value = TX_OBS.Text
                        End If

                        .Parameters.Add("@CL_ACTIVE_INACTIVE", SqlDbType.Int).Value = C_ACTIVE_INACTIVE.CheckState
                        .Parameters.Add("@CL_USER_UPDATE", SqlDbType.NVarChar, 100).Value = frn_main_form.LBL_USERNAME.Caption
                        .Parameters.Add("@CL_KEY", SqlDbType.NVarChar, 50).Value = CB_FOLIO.Text


                        img = imagen_bytes(Me.pc_img.Image)
                        .Parameters.AddWithValue("@CL_FOTO", img)


                        Dim Message As New SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200)
                        Message.Direction = ParameterDirection.Output
                        Command.Parameters.Add(Message)
                        Rows = Command.ExecuteNonQuery
                        If (Rows > 0) Then
                            XtraMessageBox.Show(CType(Message.Value, String), "SISTEMA", MessageBoxButtons.OK)
                        Else
                            XtraMessageBox.Show(CType(Message.Value, String), "SISTEMA", MessageBoxButtons.OK)
                        End If

                    End With

                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Disconnect_Database()
                    clean_fields()
                    FILL_DATA()
                End Try
            End If
        End If
    End Sub

    Private Sub BTN_DELETE_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_DELETE.ItemClick
        XtraMessageBox.Show("NO DISPONIBLE", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SHOW_PANEL_ItemClick(sender As Object, e As ItemClickEventArgs) Handles SHOW_PANEL.ItemClick
        Me.G_DATA.OptionsFind.AlwaysVisible = True
        SHOW_PANEL.Enabled = False
        HIDE_PANEL.Enabled = True
    End Sub

    Private Sub TXT_ID_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID.TextChanged
        If (TXT_ID.Text = "") Then
            BTN_DELETE.Enabled = False
            BTN_EDIT.Enabled = False
            BTN_SAVE.Enabled = True
        Else
            BTN_EDIT.Enabled = True
            BTN_DELETE.Enabled = True
            BTN_SAVE.Enabled = False
            search_img()
            LIST_VALUE_ESTATUS()
        End If
    End Sub

    Private Sub BTN_CLEAR_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_CLEAR.ItemClick
        clean_fields()
    End Sub

    Private Sub BTN_SHOW_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_SHOW.ItemClick
        FILL_DATA()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim openFileDialog1 As New OpenFileDialog() 'declaramos un cuadro de dialogo referenciado por openfilediaog1
        Dim result As New DialogResult 'el resultado del cuadro que declaramos


        openFileDialog1.InitialDirectory = "Bibliotecas\Imágenes\Imagenes públicas\Imagenes de muestra" 'damos el directorio inicial es donde buscara primero
        openFileDialog1.Filter = "archivos de imagen (*.jpg)|*.png|All files (*.*)|*.*" 'le damos 
        openFileDialog1.FilterIndex = 3
        openFileDialog1.RestoreDirectory = True
        result = openFileDialog1.ShowDialog()

        If (result = DialogResult.OK) Then


            pc_img.Image = Image.FromFile(openFileDialog1.FileName)

        End If
    End Sub

    Private Sub BTN_REFRESH_CITY_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_REFRESH_CITY.ItemClick
        LIST_CITY()
    End Sub

    Private Sub BTN_REFRESH_STATUS_C_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_REFRESH_STATUS_C.ItemClick
        LIST_ESTATUS()
    End Sub

    Private Sub G_DATA_DoubleClick(sender As Object, e As EventArgs) Handles G_DATA.DoubleClick
        Try
            TXT_ID.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "ID"), String)
            TX_NAME.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "NOMBRE(s)"), String)
            TX_PAT.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "APELLIDO PATERNO"), String)
            TX_MAT.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "APELLIDO MATERNO"), String)


            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CIUDAD"))) Then
                CB_CITY.Text = ""
            Else
                CB_CITY.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CIUDAD"), String)
            End If


            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "ESTADO"))) Then
                CB_ESTADO.Text = ""
            Else
                CB_ESTADO.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "ESTADO"), String)
            End If

            R_SEX.EditValue = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "SEXO"), String)
            DT_FECHA_NAC.EditValue = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "FECHA NACIMIENTO"), String)


            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CURP"))) Then
                TX_CURP.Text = ""
            Else
                TX_CURP.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CURP"), String)
            End If

            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CALLE"))) Then
                TX_CALLE.Text = ""
            Else
                TX_CALLE.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CALLE"), String)
            End If


            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "Nº EXTERIOR"))) Then
                TX_EXTERIOR.Text = ""
            Else
                TX_EXTERIOR.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "Nº EXTERIOR"), String)
            End If

            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "Nº INTERIOR"))) Then
                TX_INTERIOR.Text = ""
            Else
                TX_INTERIOR.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "Nº INTERIOR"), String)
            End If

            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "REFERENCIA"))) Then
                TX_CRUZ.Text = ""
            Else
                TX_CRUZ.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "REFERENCIA"), String)
            End If

            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "COLONIA"))) Then
                TX_COLONIA.Text = ""
            Else
                TX_COLONIA.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "COLONIA"), String)
            End If

            'If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "LOCALIDAD"))) Then
            '    TX_LOCAL.Text = ""
            'Else
            '    TX_LOCAL.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "LOCALIDAD"), String)
            'End If


            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "TELEFONO"))) Then
                TX_TELEFONO.Text = ""
            Else
                TX_TELEFONO.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "TELEFONO"), String)
            End If

            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CLASIFICACION"))) Then
                CB_PREF.Text = ""
            Else
                CB_PREF.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "CLASIFICACION"), String)
            End If

            R_TIPO.EditValue = G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "TIPO")

            If (IsDBNull(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "OBSERVACIONES"))) Then
                TX_OBS.Text = ""
            Else
                TX_OBS.Text = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "OBSERVACIONES"), String)
            End If



            C_ACTIVE_INACTIVE.CheckState = CType(G_DATA.GetRowCellValue(G_DATA.FocusedRowHandle, "ACTIVO/INACTIVO"), CheckState)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTN_PRINT_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_PRINT.ItemClick
        DGV_DATA.PrintDialog()

    End Sub

    Private Sub BTN_PREVIEW_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BTN_PREVIEW.ItemClick
        DGV_DATA.ShowRibbonPrintPreview()

    End Sub

    Private Sub HIDE_PANEL_ItemClick(sender As Object, e As ItemClickEventArgs) Handles HIDE_PANEL.ItemClick
        Me.G_DATA.OptionsFind.AlwaysVisible = False
        SHOW_PANEL.Enabled = True
        HIDE_PANEL.Enabled = False
    End Sub

    Private Sub VIEW_AUTOFILTER_ItemClick(sender As Object, e As ItemClickEventArgs) Handles VIEW_AUTOFILTER.ItemClick
        Me.G_DATA.OptionsView.ShowAutoFilterRow = True
        VIEW_AUTOFILTER.Enabled = False
        HIDE_AUTOFILTER.Enabled = True
    End Sub

    Private Sub HIDE_AUTOFILTER_ItemClick(sender As Object, e As ItemClickEventArgs) Handles HIDE_AUTOFILTER.ItemClick
        Me.G_DATA.OptionsView.ShowAutoFilterRow = False
        VIEW_AUTOFILTER.Enabled = True
        HIDE_AUTOFILTER.Enabled = False
    End Sub

    Private Sub R_SEX_Leave(sender As Object, e As EventArgs) Handles R_SEX.Leave
        Try
            Dim CALC As New CURPLib.CURPLib
            TX_CURP.Text = CALC.CURPCompleta(TX_PAT.Text, TX_MAT.Text, TX_NAME.Text, DT_FECHA_NAC.Text, CType(R_SEX.EditValue, String), array_nombres(CB_ESTADO.SelectedIndex, 1))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class