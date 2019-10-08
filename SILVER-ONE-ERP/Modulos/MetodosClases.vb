Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

'SE AGREGAN DESPUES DE HABER HECHO REFERENCIA A LA LIBRERIA System.Configuration DESDE EL EXPLORADOR DE SOLUCIONES
Imports System.Configuration
Imports System.Configuration.ConfigurationManager


Module MetodosClases
    'SE CREA UNA REGION EXCLUSIVA PARA LAS VARIABLES PUBLICAS DEL SISTEMA
#Region "VARIABLES"


    'VARIABLE PUBLICA QUE ALMACENA UNA CADENA DE CONEXION ESTA PROVIENE DESDE NUESTRO ARCHIVO APP.CONFIG
    Public connection As New SqlConnection(ConfigurationManager.ConnectionStrings("SILVER_ONE_ERP.Settings.SILVER_ERPConnectionString").ConnectionString.ToString())
    'VARIABLE PARA EJECUTAR UN COMANDO SQL DESDE LA PROGRAMACION DEL SISTEMA
    Public Command As New SqlCommand
    'VARIABLE QUE EJECUTA UN LECTOR SQL DESDE LA PROGRAMACION DEL SISTEMA
    Public Reader As SqlDataReader
    'VARIABLE QUE REALIZA UN PUENTE ADAPTANO A UN DATASET DE NUESTRA APLICACION
    Public Adapter As New SqlDataAdapter
    'VARIABLE QUE ALMACENARA EL TOTAL DE UNA FILA RSUELTADO DE UN COMANDO
    Public Rows As Integer
    'VARIABLE QUE REPRESENTA UNA TABLA DE NUESTRA BASE DE DATOS LA CUAL SE LLENARA CON LA EJECUCION DE UN COMANDO SQL POR EJEMPLO: UN SELECT DESDE UN PROCEDIMIENTO ALMACENADO
    Public DataT As DataTable
    'VARIABLE QUE REPRESENTA UN PROVEEDOR DE DATOS REPRESENTA UN CONJUNTO DE DATATABLES
    Public DataS As DataSet
    'VARIABLES QUE ALMACENAN EL USUARIO Y CONTRASEÑA MAESTRAS PARA EL SISTEMA
    Public Username As String = "gadiel"
    Public Password As String = "1992"

#End Region
    'SE CREA UN REGION PARA LOS METODOS DE EVALUACION DEL LOS USUARIO, TIPO DE USUARIO Y SU CONTRASEÑA
#Region "METODOS USUARIO"

    'METODO BOOLEAN QUE OBTIENE COMO PARAMETRO EL NOMBRE DEL USUARIO ENVIADO DESDE frm_login QUE EVALUA SI EXISTE UN REGISTRO CON EL NOMBRE ESPECIFICADO

    Function UsuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False 'SE ASIGNA EL RESULTADO INICIALMENTE EN FALSO INDICANDO QUE NO SE ENCONTRO UN REGISTRO CON UNA VALOR SIMILAR
        'INTENTAR
        Try
            'CONECTAR A LA BASE DE DATOS
            Connect_Database()
            'EJECUTAMOS UN COMANDO QUE NOS INDIQUE SI HAY UN REGISTRO EN NUESTRA TABLA CON EL MISMO NOMBRE DE USUARIO QUE RECIBE DESDE frm_login Y QUE SU ESTATUS SEA ACTIVO=1
            Command = New SqlCommand("Select * from SILV_USERS where US_USERNAME='" & nombreUsuario & "' and US_ACTIVE_INACTIVE=1", connection)
            'EJECUTAMOS UN LECTOR AL COMANDO
            Reader = Command.ExecuteReader
            'SI SE HA EJCUTADO EL LECTOR Y ESTE HA LEIDO POR LO MENOS UN REGISTRO QUE COINCIDA CON EL NOMBRE DEL USUARIO ENTONCES
            If Reader.Read Then
                resultado = True 'SE ASIGNA UN VALOR VERDADERO AL RESULTADO
            End If
            Reader.Close() 'SE CIERRA EL LECTOR DE DATOS
        Catch ex As Exception
            'SE MUESTRA UN MENSAJE DE ERROR INDICANDO QUE ALGO DENTRO DEL CODIGO TRY ESTA MAL
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return resultado 'RETONAMOS EL RESULTADO HASTA frm_login
    End Function

    'METODO DE TIPO STRING QUE SELECCIONA LA CONTRASEÑA DEL USUARIO SIEMPRE Y CUANDO ESTE COINCIDA CON EL NOMBRE DE USUARIO QUE OBTIENE DESDE frml_login
    Function Contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = "" 'SE DECLARA LA VARIABLE DE RESULTADO COMO STRING QUE ALMACENADA EL RESULTADO
        Try 'INTENTAR
            'CONECTAR A LA BASE DE DATOS
            Connect_Database()
            'EJECUTAMOS UN COMANDO QUE NOS SELECCIONA LA CONTRASEÑA DEL USUARIO QUE COINCIDA CON EL NOMBRE DE USUARIO PROPORCIONADO Y QUE SU ESTATUS SEA ACTIVO=1
            Command = New SqlCommand("Select US_PASSWORD from SILV_USERS where US_USERNAME='" & nombreUsuario & "' and US_ACTIVE_INACTIVE=1", connection)
            'EJECUTAMOS UN LECTOR AL COMANDO
            Reader = Command.ExecuteReader
            'SI SE HA EJCUTADO EL LECTOR Y ESTE HA LEIDO POR LO MENOS UN REGISTRO QUE COINCIDA CON EL NOMBRE DEL USUARIO ENTONCES
            If Reader.Read Then
                resultado = CType(Reader.Item("US_PASSWORD"), String) 'LE ASIGNAMOS A LA VARIABLE RESULTADO EL VALOR DE LA CONTRASEÑA OBTENIDA DESDE LA EJECUCION DEL COMMAND
            End If
            'CERRAMOS EL LECTOR DE DATOS
            Reader.Close()
        Catch ex As Exception
            'SE MUESTRA UN MENSAJE DE ERROR INDICANDO QUE ALGO DENTRO DEL CODIGO TRY ESTA MAL
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'RETORNAMOS EL VALOR DEL RESULTADO  resultado = CType(Reader.Item("US_PASSWORD"), String)
        Return resultado
    End Function
    'METODO DE TIPO INTEGER (ENTERO) QUE SELECCIONA EL IDENTIFICADOR DE UN REGISTRO DADO EL NOMBRE DEL USUARIO ESTE DEBERA DE RETORNAR EL TIPO DE USUARIO
    'ESTE METODO SE HA DECLARADO DE TIPO ENTERO YA QUE LA COLUMNA DE TIPO DE USUARIO DE ESTA BASE DE DATOS ES DE TIPO INT
    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer 'SE DECLARA UNA VARIABLE DE TIPO ENTERA QUE ALMACENARA EL RESULTADO EN ESTA PARTE SERA DE TIPO ENTERO (RESULTADO TIPO DE USUARIO)
        Try 'INTENTAR
            'CONECTAR A LA BASE DE DATOS
            Connect_Database()
            'EJECUTAMOS EL COMANDO QUE SELECCIONARA EL TIPO DE USUARIO QUE COINCIDA CON EL NOMBRE DE USUARIO PROPORCIONADO Y QUE SU ESTATUS SEA ACTIVO=1
            Command = New SqlCommand("Select ID_USER_TYPE from SILV_USERS where US_USERNAME='" & nombreUsuario & "' and US_ACTIVE_INACTIVE=1", connection)
            'EJECUTAMOS UN LECTOR AL COMANDO
            Reader = Command.ExecuteReader
            'SI SE HA EJCUTADO EL LECTOR Y ESTE HA LEIDO POR LO MENOS UN REGISTRO QUE COINCIDA CON EL NOMBRE DEL USUARIO ENTONCES
            If Reader.Read Then
                resultado = CInt(Reader.Item("ID_USER_TYPE")) 'ASIGNAMOS A LA VARIABLE RESULTADO Dim resultado As Integer EL VALOR RESULTANTE DEL LECTOR EN ESTE CASO ES DE LA COLUMNA ID_USER_TYPE
            End If
            'CERRAMOS EL LECTOR DE DATOS
            Reader.Close()
        Catch ex As Exception
            'SE MUESTRA UN MENSAJE DE ERROR INDICANDO QUE ALGO DENTRO DEL CODIGO TRY ESTA MAL
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'RETORNAMOS EL VALOR DEL RESULTADO resultado = CInt(Reader.Item("ID_USER_TYPE"))
        Return resultado
    End Function
#End Region

#Region "Metodos"
    'METODO QUE VERIFICA SI EXISTE UNA CONEXION A LA BASE DE DATOS
    Sub Connect_Database()
        Try
            'SI EL ESTATUS DE LA CONEXION ES CERRADA ENTONCES
            If (connection.State = ConnectionState.Closed) Then
                'ABRIMOS LA CONEXION
                connection.Open()
                ' MsgBox("OK")
            End If
        Catch ex As Exception
            'SE MUESTRA UN MENSAJE DE ERROR INDICANDO QUE ALGO DENTRO DEL CODIGO TRY ESTA MAL
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'METODO QUE VERIFICA SI EL ESTATUS DE LA CONEXION ES ABIERTA ENTONCES
    Sub Disconnect_Database()
        Try
            'SI EL ESTATUS DE LA CONEXION ES: ABIERTA ENTONCES
            If (connection.State = ConnectionState.Open) Then
                'CERRAMOS LA CONEXION
                connection.Close()
            End If
        Catch ex As Exception
            'SE MUESTRA UN MENSAJE DE ERROR INDICANDO QUE ALGO DENTRO DEL CODIGO TRY ESTA MAL
            XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

End Module
