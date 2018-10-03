Public Class FormRegistrarCampeonato
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim _TE As New tratamientos_especiales
    Dim _Campeonato As New Campeonato
    Dim _BD As New CONEXION_BD
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If Me._Campeonato.transferir(Me, Campeonato.a_donde.a_la_clase) = Campeonato.estado_transferencia.datosErroneos Then
            Exit Sub
        End If
        If control_estado_grabacion = estado_grabacion.insertar Then
            'Se dispara en el objeto negocio (usuarios) el método de insertar datos
            Me._Campeonato.insertar()
            MsgBox("Se grabó exitosamente")
            'se recarga la grilla
            Me.cargar_grilla()
            Me._TE.blanquear_objetos(Me)
            Me.txt_anio.Focus()
        End If
    End Sub
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormCampeonatos.CampeonatosDataGridView.DataSource = Me._Campeonato.lista_campeonatos()
    End Sub

    Private Sub FormRegistrarCampeonato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_id_estado_campeonato.cargar(_BD.leo_tabla("SELECT * FROM EstadoCampeonato"), "id_estado_campeonato", "nombre_estado")
        Me._TE.blanquear_objetos(Me)
        Me.txt_anio.Focus()
        Me.control_estado_grabacion = estado_grabacion.insertar
    End Sub

    Private Sub lbl_limpiar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_limpiar.LinkClicked
        Me._TE.blanquear_objetos(Me)
        Me.txt_anio.Focus()
    End Sub
End Class