Public Class CONEXION_BD
    'declaro la conexion del tipo oledbconnection (coneta con la base de datos)
    Dim conexion As New OleDb.OleDbConnection
    ' declaro el objeto command (ejecuta los comandos sql, sobre la conexion)
    Dim cmd As New OleDb.OleDbCommand

    Dim _cadena_conexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-HQ9HGAN;Integrated Security=SSPI;Initial Catalog=CampeonatoPav"
    Private Sub conectar()
        'asigno la cadena de conexion que tiene los parametros para conectar
        conexion.ConnectionString = _cadena_conexion
        'abro la conexion con la base de datos, se establece un pipe con el motor-base seleccionada
        conexion.Open()
        'se le cominica al comando cual es la conexion sonbre la cual trabajará
        cmd.Connection = conexion
        'se establece el origen de los comandos sql (textos dentro la aplicación)
        cmd.CommandType = CommandType.Text
    End Sub
    Private Sub cerrar()
        'se cierra la conexion
        conexion.Close()
    End Sub
    Public Sub INS_MOD_BOR(ByVal comando As String)
        ' abre la conexion con la BD
        Me.conectar()
        ' asigna el comando sql que se debe ejecutar
        cmd.CommandText = comando
        ' ejecuta el comando sql
        cmd.ExecuteNonQuery()
        ' cierra la conexion 
        cerrar()
    End Sub
    Public Function leo_tabla(ByVal sql As String) As DataTable
        ' abre la conexion con la BD
        Me.conectar()
        ' asigna el comando sql que se debe ejecutar
        cmd.CommandText = sql
        ' crea una tabla como repositorio para recibir los datos desde la BD
        Dim tabla As New DataTable
        ' carga la tabla con el resultado de la ejecucion del sql 
        tabla.Load(cmd.ExecuteReader())
        'cierra la conexion 
        cerrar()
        'retorna el contenido de la tabla atraves de la funcion
        Return tabla
    End Function
    Public Function leo_tabla(ByVal sql As String, filtros As Object()) As DataTable
        'creo una tabla repositorio para almacenar resultados de consulta sql
        Dim tabla As New DataTable
        ' abre la conexion con la BD
        Me.conectar()
        ' clear: es el comando que faltaba para que funcionara bien la función 
        ' limpia el paquete de parametros 
        cmd.Parameters.Clear()
        ' asigna el comando sql que se debe ejecutar
        cmd.CommandText = sql
        'instancio variable indice para bucle for-next
        Dim c As Integer
        'bucle para recorre el paquete de filtros 
        For c = 0 To filtros.Length - 1
            Dim parametro As String = "@param" & c + 1
            'agrego un nuevo parametro filtro para el comando sql
            cmd.Parameters.AddWithValue(parametro, filtros(c))
        Next
        'cargo tabla con el resultado de la consulta sql ejecutada
        tabla.Load(cmd.ExecuteReader())
        'cierra la conexion 
        cerrar()
        'retorna el contenido de la tabla atraves de la funcion
        Return tabla
    End Function
End Class

