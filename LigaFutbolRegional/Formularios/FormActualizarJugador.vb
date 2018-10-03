Public Class FormActualizarJugador
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim _TE As New tratamientos_especiales
    Dim _Jugador As New Jugador
    Dim _BD As New CONEXION_BD
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs)
        Me._Jugador.transferir(Me, Jugador.a_donde.a_la_clase)


        'If control_estado_grabacion = estado_grabacion.insertar Then
        '    'Se dispara en el objeto negocio (usuarios) el método de insertar datos
        '    Me._Club.insertar()
        'Else
        'Se dispara en el objeto negocio (usuarios) el método de insertar datos
        Me._Jugador.modificar(txt_dni.Text)
        MsgBox("Se modifico exitosamente")
        'se recarga la grilla
        Me.cargar_grilla()
        Me._TE.blanquear_objetos(Me)
        Me.txt_dni.Focus()
    End Sub
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormJugadores.JugadoresDataGridView.DataSource = Me._Jugador.lista_jugadores()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me._Jugador.buscar_campeonato(txt_dni.Text)
        Me._Jugador.transferir(Me, Jugador.a_donde.al_front_end)
    End Sub

    Private Sub FormActualizarJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_tipo_doc.cargar(_BD.leo_tabla("SELECT * FROM TipoDoc"), "id_tipo_Doc", "nombre")
        Me.cmb_tipo_doc.cargar(_BD.leo_tabla("SELECT * FROM PosicionJugador"), "id_posicion", "nombre")
    End Sub
End Class