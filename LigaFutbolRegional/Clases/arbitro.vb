﻿Public Class Arbitro

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
    Public Property id_arbitro As Integer
    Public Property tipo_doc As Integer
    Public Property DNI As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property fecha_nacimiento As String
    Public Property rol_autoridad As Integer




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
    'método privado de transferencia de datos desde el negocio (Club) al front end (formulario)
    'parámetro de entrada/salida: el conjunto de objetos de formulario. 
    'recordar que los parametros definidos con ByRef son de entrada/salida, esto es: que todo lo que al 
    'parametro se le procese dentro de la función también se le realizará al objeto que esta puesto 
    'como recurso  en el  parámetro. 
    Private Function transferir_al_front_end(ByRef controles As Object) As estado_transferencia
        'se analiza los objetos del formulario para saber sobre cual se actuará.
        'se recorre los objetos con for each
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

                    Case "id_arbitro"
                        obj.Text = _id_arbitro
                    Case "DNI"
                        obj.Text = _DNI
                    Case "nombre"
                        obj.Text = _nombre
                    Case "apellido"
                        obj.Text = _apellido
                    Case "fecha_nacimiento"
                        obj.Text = _fecha_nacimiento


                End Select
            End If
            'El mismo proceso de analisis que se realizo al MaskeTextBox_01, se realiza al ComboBox_01,
            'pero como es un único objeto no utilizamos una estructura case
            If obj.GetType().Name = "ComboBox_01" Then
                Select Case obj.nombre_campo
                    Case "tipo_doc"
                        obj.SelectedValue = _tipo_doc
                    Case "rol_autoridad"
                        obj.SelectedValue = _rol_autoridad

                End Select
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
            'Se pregunta si el objeto encontrada es validable.
            'Se valida sí el dato de entrada contiene valor o es vacío. Por el caso de que sea vacío
            'se emite un mensaje de error y se ubica el curosr en ese objeto en el formulario
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
                'Se transfier el contenido del objeto a la variable loca del negocio que coincide con la
                'propiedad que es imagen de un nombre de campo de la tabla
                Select Case obj.nombre_campo

                    Case "id_arbitro"
                        _id_arbitro = obj.Text
                    Case "tipo_doc"
                        _tipo_doc = IIf(obj.Text = "", 0, obj.text)
                    Case "DNI"
                        _DNI = obj.Text
                    Case "nombre"
                        _nombre = obj.Text
                    Case "apellido"
                        _apellido = obj.Text
                    Case "fecha_nacimiento"
                        _fecha_nacimiento = obj.Text
                    Case "rol_autoridad"
                        _rol_autoridad = IIf(obj.Text = "", 0, obj.text)
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
                _tipo_doc = obj.SelectedValue
                _rol_autoridad = obj.SelectedValue
            End If
        Next
        Return estado_transferencia.ok
    End Function
    'Función para recuparar la lista de usuarios
    Public Function lista_arbitro() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM Arbitro")
    End Function
    'Subrutina para insertar un nuevo registro
    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Arbitro ("

        sql &= "tipo_doc"
        sql &= ",DNI"
        sql &= ",nombre"
        sql &= ",apellido"
        sql &= ",fecha_nacimiento"
        sql &= ",rol_autoridad ) VALUES ("

        sql &= "" & _tipo_doc & ""
        sql &= ", " & _DNI & ""
        sql &= ",'" & _nombre & "'"
        sql &= ",'" & _apellido & "'"
        sql &= ",'" & _fecha_nacimiento & "'"
        sql &= "," & _rol_autoridad & ")"

        Me._BD.INS_MOD_BOR(sql)
    End Sub
    'subrutina para borrar un registro
    Public Sub borrar(ByVal id_arbitro As Integer)
        Me._BD.INS_MOD_BOR("DELETE FROM Arbitro WHERE id_arbitro = " & id_arbitro)

    End Sub

    Public Sub modificar(ByVal id_arbitro As Integer)
        Dim sql As String = ""
        sql = "UPDATE Arbitro "
        sql &= "SET tipo_doc =" & _tipo_doc & ""
        sql &= ", DNI =" & _DNI & ""
        sql &= ", nombre = '" & _nombre & "'"
        sql &= ", apellido = '" & _apellido & "'"
        sql &= ",fecha_nacimiento = '" & _fecha_nacimiento & "'"
        sql &= ", rol_autoridad = " & _rol_autoridad
        sql &= " WHERE id_arbitro = " & id_arbitro
        Me._BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub buscar_arbitro(ByVal id_arbitro As Integer)
        Dim tabla As New DataTable
        tabla = Me._BD.leo_tabla("SELECT * FROM Arbitro where id_arbitro =" & id_arbitro)
        _id_arbitro = tabla.Rows(0)("id_arbitro")
        _tipo_doc = tabla.Rows(0)("tipo_doc")
        _DNI = tabla.Rows(0)("DNI")
        _nombre = tabla.Rows(0)("nombre")
        _apellido = tabla.Rows(0)("apellido")
        _fecha_nacimiento = tabla.Rows(0)("fecha_nacimiento")
        _rol_autoridad = tabla.Rows(0)("rol_autoridad")


    End Sub
    'Función para recuparar la lista de Arbitros
    Public Function lista_arbitros() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM Arbitro")
    End Function
End Class
