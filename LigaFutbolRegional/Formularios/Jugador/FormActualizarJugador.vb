Public Class FormActualizarJugador
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim _TE As New tratamientos_especiales
    Dim _Jugador As New Jugador
    Dim _BD As New CONEXION_BD
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.modificar



    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormJugadores.JugadoresDataGridView.DataSource = Me._Jugador.lista_jugadores()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me._Jugador.buscar_jugador(txt_dni.Text)
        Me._Jugador.transferir(Me, Jugador.a_donde.al_front_end)
    End Sub

    Private Sub FormActualizarJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_tipo_doc.cargar(_BD.leo_tabla("SELECT * FROM TipoDoc"), "id_tipoDoc", "nombre")
        Me.cmb_id_posicion_preferente.cargar(_BD.leo_tabla("SELECT * FROM PosicionJugador"), "id_posicion", "nombre")
        Me.cmb_cod_postal.cargar(_BD.leo_tabla("SELECT * FROM CodigoPostal"), "id_codPostal", "id_codPostal")
        Me.control_estado_grabacion = estado_grabacion.modificar
    End Sub

    Private Sub BtnActualizar_Click_1(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me._Jugador.transferir(Me, Jugador.a_donde.a_la_clase) = Jugador.estado_transferencia.datosErroneos Then
            Exit Sub
        End If
        'Me._Jugador.transferir(Me, Jugador.a_donde.a_la_clase)



        'Se dispara en el objeto negocio (usuarios) el método de insertar datos
        Me._Jugador.modificar(txt_dni.Text)
        MsgBox("Se modifico exitosamente")
        'se recarga la grilla
        Me.cargar_grilla()
        Me._TE.blanquear_objetos(Me)
        Me.txt_dni.Focus()
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub lbl_limpiar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_limpiar.LinkClicked
        Me._TE.blanquear_objetos(Me)
        Me.txt_dni.Focus()
    End Sub
End Class