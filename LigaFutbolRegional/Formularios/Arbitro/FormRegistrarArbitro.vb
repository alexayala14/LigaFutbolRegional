Public Class FormRegistrarArbitro
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim _TE As New tratamientos_especiales
    Dim _Arbitro As New Arbitro
    Dim _BD As New CONEXION_BD
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If Me._Arbitro.transferir(Me, Arbitro.a_donde.a_la_clase) = Club.estado_transferencia.datosErroneos Then
            Exit Sub
        End If
        If control_estado_grabacion = estado_grabacion.insertar Then
            'Se dispara en el objeto negocio (usuarios) el método de insertar datos
            Me._Arbitro.insertar()
            MsgBox("Se grabó exitosamente")
            'se recarga la grilla
            Me.cargar_grilla()
            Me._TE.blanquear_objetos(Me)
            Me.cmb_tipo_doc.Focus()
        End If
    End Sub

    Private Sub FormRegistrarArbitro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_tipo_doc.cargar(_BD.leo_tabla("SELECT * FROM TipoDoc"), "id_tipoDoc", "nombre")
        Me.cmb_rol_autoridad.cargar(_BD.leo_tabla("SELECT * FROM RolArbitro"), "id_rol", "nombre")
        Me._TE.blanquear_objetos(Me)
        Me.cmb_tipo_doc.Focus()
        Me.control_estado_grabacion = estado_grabacion.insertar
    End Sub
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable

        FormArbitros.ArbitrosDataGridView.DataSource = Me._Arbitro.lista_arbitros()

    End Sub

    Private Sub lbl_limpiar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_limpiar.LinkClicked
        Me._TE.blanquear_objetos(Me)
        Me.cmb_tipo_doc.Focus()
    End Sub
End Class