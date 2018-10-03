Public Class Club
    'enumeración para control explicito de validación
    Enum estado_validar
        encontrado
        no_encontrado
    End Enum
    'enumeración para establecer control de los datos transferidos
    Enum estado_transferencia
        datosErroneos
        ok
    End Enum
    'enumeración para configurar la transferencia de datos desde el front end al obejto negocio (usuarios)
    'esta configuración es bidireccional 
    Enum a_donde
        a_la_clase
        al_front_end
    End Enum
    'instanciación de la clase back end, que es la que se encarga de realizar las gestiones con la base de 
    'datos
    Dim _BD As New CONEXION_BD
    'definición de las propiedades públicas que representan las columnas de la tabla usuarios con la que se
    'procederá a gestionar datos.
    'Recordar que este tipo de definición de propiedad pública, genera en forma implicita una variable local
    'con el mismo nombre que lleva como prefijo un guion bajo ej: la variable para la primera propiedad es
    '_id_usuario
    Public Property id_club As Integer
    Public Property siglas As String
    Public Property nombre_club As String
    Public Property nro_cuil As Integer
    Public Property calle As String
    Public Property nro_calle As Integer
    Public Property cod_postal As Integer
    Public Property id_estado_club As Integer



    'método público que gestiona la transferencia de datos desde el front end (formulario) al negocio (usuarios),
    'como también del negocio al front end. 
    'los parametros de entrada son los objetos de formulario, y luego el camino de recorrido que es bidireciona.
    'cuando ingresa los datos a la clase desde el front end la configuración es: a_la_clase.
    'al_front_end es la transferencia al formulario
    Public Function transferir(ByRef controles As Object, ByVal a_donde_transferior As a_donde) As estado_transferencia
        If a_donde_transferior = a_donde.a_la_clase Then
            Return transferir_a_la_clase(controles)
        Else
            Return transferir_al_front_end(controles)
        End If
    End Function

    Private Function transferir_al_front_end(ByRef controles As Object) As estado_transferencia

        For Each obj In controles.Controls
            'se pregunta por el nombre del tipo de objeto y si es MaskedTextBox_01 se procesa por el 
            'valor de la propiedad nombre_campo.
            'recordar que la clase MaskedTextBox_01 es una clase diseñada por el programador 
            'que hereda de la clase MaskedTextBox,
            'que contiene algunas propiedades convenientes para el proceso ABM (alta baja modificación).
            'Cuando se localiza el nombre del campo de la tabla en la propiedad nombre_campo en el objeto  
            'tratado, se procede a transferir a ese objeto que es del formulario, el 
            'valor de la variable privada que trabaja asociada a la propiedad  
            'con el mismo nombre que el campo de la tabla.
            If obj.GetType().Name = "MaskedTextBox_01" Then
                Select Case obj.nombre_campo
                    'Case "id_club"
                    '    'tranferencia del valor de variable privada a propiedad text del objeto encontrado
                    '    obj.Text = _id_club
                    Case "siglas"
                        obj.Text = _siglas
                    Case "nombre_club"
                        obj.Text = _nombre_club
                    Case "nro_cuil"
                        obj.Text = _nro_cuil
                    Case "calle"
                        obj.Text = _calle
                    Case "nro_calle"
                        obj.Text = _nro_calle
                    Case "cod_postal"
                        obj.Text = _cod_postal

                End Select
            End If
            'El mismo proceso de analisis que se realizo al MaskeTextBox_01, se realiza al ComboBox_01,
            'pero como es un único objeto no utilizamos una estructura case
            If obj.GetType().Name = "ComboBox_01" Then
                If obj.nombre_campo = "id_estado_club" Then
                    obj.SelectedValue = _id_estado_club
                End If
            End If
        Next
        Return estado_transferencia.ok
    End Function
    'método privado de transferencia de datos desde el front end (formulario) al negocio (usiarios) 
    'parámetro de entrada/salida: el conjunto de objetos de formulario. 
    'recordar que los parametros definidos con ByRef son de entrada/salida, esto es: que todo lo que al 
    'parametro se le procese dentro de la función también se le realizará al objeto que esta puesto 
    'como recurso  en el  parámetro. 
    Private Function transferir_a_la_clase(ByRef controles As Object) As estado_transferencia
        For Each obj In controles.Controls

            If obj.GetType().Name = "MaskedTextBox_01" Then
                If obj.validable = True Then
                    If obj.text = "" Then
                        'mensaje de error encontrad sobre el objeto
                        MsgBox("el " & obj.nombre_campo & " está vacío")
                        'se enfoca el cursor en el objeto
                        obj.Focus()
                        'se devuelve la condicione de datoErroneo
                        Return estado_transferencia.datosErroneos
                    End If
                End If

                Select Case obj.nombre_campo
                    'Case "id_club"
                    '    _id_club = obj.Text
                    Case "siglas"
                        _siglas = obj.Text
                    Case "nombre_club"
                        _nombre_club = obj.Text
                    Case "nro_cuil"
                        _nro_cuil = obj.Text
                    Case "calle"
                        _calle = obj.Text
                    Case "nro_calle"
                        _nro_calle = obj.Text
                    Case "cod_postal"
                        _cod_postal = obj.Text
                    Case "id_estado_club"
                        _id_estado_club = IIf(obj.Text = "", 0, obj.text)
                End Select
            End If
            'Para ComboBox_01 se aplica la misma mecánica que para MaskedTextBox_01
            If obj.GetType().Name = "ComboBox_01" Then
                If obj.validable = True Then
                    If obj.SelectedIndex = -1 Then
                        MsgBox("el " & obj.nombre_campo & " está sin selección")
                        obj.Focus()
                        Return estado_transferencia.datosErroneos
                    End If
                End If
                _id_estado_club = obj.SelectedValue
            End If
        Next
        Return estado_transferencia.ok
    End Function
    'Función para recuparar la lista de usuarios
    Public Function lista_clubes() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM ClubFutbol")
    End Function
    'Subrutina para insertar un nuevo registro
    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO ClubFutbol ("

        sql &= "siglas"
        sql &= ",nombre_club"
        sql &= ",nro_cuil"
        sql &= ",calle"
        sql &= ",nro_calle"
        sql &= ",cod_postal"
        sql &= ",id_estado_club) VALUES ("

        sql &= "'" & _siglas & "'"
        sql &= ", '" & _nombre_club & "'"
        sql &= ",'" & _nro_cuil & "'"
        sql &= ",'" & _calle & "'"
        sql &= ",'" & _nro_calle & "'"
        sql &= ",'" & _cod_postal & "'"
        sql &= "," & _id_estado_club & ")"
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    'subrutina para borrar un registro
    Public Sub borrar(ByVal id_club As Integer)
        Me._BD.INS_MOD_BOR("DELETE FROM ClubFutbol WHERE id_club = " & id_club)

    End Sub

    Public Sub modificar(ByVal id_club As Integer)
        Dim sql As String = ""
        sql = "UPDATE ClubFutbol "
        sql &= "SET siglas ='" & _siglas & "'"
        sql &= ", nombre_club ='" & _nombre_club & "'"
        sql &= ", nro_cuil = '" & _nro_cuil & "'"
        sql &= ", calle = '" & _calle & "'"
        sql &= ",nro_calle = " & _nro_calle
        sql &= ", cod_postal =" & _cod_postal
        sql &= ", id_estado_club =" & _id_estado_club
        sql &= "WHERE id_club = " & id_club
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub buscar_club(ByVal id_club As Integer)
        Dim tabla As New DataTable
        tabla = Me._BD.leo_tabla("SELECT * FROM ClubFutbol where id_club =" & id_club)
        _siglas = tabla.Rows(0)("siglas")
        _nombre_club = tabla.Rows(0)("nombre_club")
        _nro_cuil = tabla.Rows(0)("nro_cuil")
        _calle = tabla.Rows(0)("calle")
        _nro_calle = tabla.Rows(0)("nro_calle")
        _cod_postal = tabla.Rows(0)("cod_postal")
        _id_estado_club = tabla.Rows(0)("id_estado_club")

    End Sub

End Class
