Public Class Campeonato
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
    Public Property id_campeonato As Integer
    Public Property anio As Integer
    Public Property nombre As String
    Public Property fecha_inicio As String
    Public Property fecha_fin As String
    Public Property puntaje_victoria As Integer
    Public Property puntaje_empate As Integer
    Public Property id_estado_campeonato As Integer

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
                    'Case "id_campeonato"
                    '    'tranferencia del valor de variable privada a propiedad text del objeto encontrado
                    '    obj.Text = _id_campeonato
                    Case "anio"
                        obj.Text = _anio
                    Case "nombre"
                        obj.Text = _nombre
                    Case "fecha_inicio"
                        obj.Text = _fecha_inicio
                    Case "fecha_fin"
                        obj.Text = _fecha_fin
                    Case "puntaje_victoria"
                        obj.Text = _puntaje_victoria
                    Case "puntaje_empate"
                        obj.Text = _puntaje_empate

                End Select
            End If
            'El mismo proceso de analisis que se realizo al MaskeTextBox_01, se realiza al ComboBox_01,
            'pero como es un único objeto no utilizamos una estructura case
            If obj.GetType().Name = "ComboBox_01" Then
                If obj.nombre_campo = "id_estado_campeonato" Then
                    obj.SelectedValue = _id_estado_campeonato
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
                    'Case "id_campeonato"
                    '    _id_campeonato = obj.Text
                    Case "anio"
                        _anio = obj.Text
                    Case "nombre"
                        _nombre = obj.Text
                    Case "fecha_inicio"
                        _fecha_inicio = obj.Text
                    Case "fecha_fin"
                        _fecha_fin = obj.Text
                    Case "puntaje_victoria"
                        _puntaje_victoria = obj.Text
                    Case "puntaje_empate"
                        _puntaje_empate = obj.Text
                    Case "id_estado_campeonato"
                        _id_estado_campeonato = IIf(obj.Text = "", 0, obj.text)
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
                _id_estado_campeonato = obj.SelectedValue
            End If
        Next
        Return estado_transferencia.ok
    End Function

    'Función para recuperar la lista de campeonatos
    Public Function lista_campeonatos() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM Campeonato")
    End Function

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Campeonato ("

        sql &= "anio"
        sql &= ",nombre"
        sql &= ",fecha_inicio"
        sql &= ",fecha_fin"
        sql &= ",puntaje_victoria"
        sql &= ",puntaje_empate"
        sql &= ",id_estado_campeonato) VALUES ("

        sql &= "" & _anio & ""
        sql &= ", '" & _nombre & "'"
        sql &= ",'" & _fecha_inicio & "'"
        sql &= ",'" & _fecha_fin & "'"
        sql &= "," & _puntaje_victoria & ""
        sql &= "," & _puntaje_empate & ""
        sql &= "," & _id_estado_campeonato & ")"
        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar(ByVal id_campeonato As Integer)
        Dim sql As String = ""
        sql = "UPDATE Campeonato "
        sql &= "SET anio ='" & _anio & "'"
        sql &= ", nombre ='" & _nombre & "'"
        sql &= ", fecha_inicio = '" & _fecha_inicio & "'"
        sql &= ", fecha_fin = '" & _fecha_fin & "'"
        sql &= ",puntaje_victoria = " & _puntaje_victoria
        sql &= ", puntaje_empate =" & _puntaje_empate
        sql &= ", id_estado_campeonato =" & _id_estado_campeonato
        sql &= " WHERE id_campeonato = " & id_campeonato
        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub buscar_campeonato(ByVal id_campeonato As Integer)
        Dim tabla As New DataTable
        tabla = Me._BD.leo_tabla("SELECT * FROM Campeonato where id_campeonato =" & id_campeonato)
        _anio = tabla.Rows(0)("anio")
        _nombre = tabla.Rows(0)("nombre")
        _fecha_inicio = tabla.Rows(0)("fecha_inicio")
        _fecha_fin = tabla.Rows(0)("fecha_fin")
        _puntaje_victoria = tabla.Rows(0)("puntaje_victoria")
        _puntaje_empate = tabla.Rows(0)("puntaje_empate")
        _id_estado_campeonato = tabla.Rows(0)("id_estado_campeonato")

    End Sub
    'subrutina para borrar un registro
    Public Sub borrar(ByVal id_campeonato As Integer)
        Me._BD.INS_MOD_BOR("DELETE FROM Campeonato WHERE id_campeonato = " & id_campeonato)

    End Sub
End Class
