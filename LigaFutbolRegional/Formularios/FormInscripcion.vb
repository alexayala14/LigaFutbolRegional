Public Class FormInscripcion
    Dim cam As New Campeonato
    Dim club As New Club
    Dim BD As New CONEXION_BD
    Dim TE As New tratamientos_especiales
    Dim inscrip As New inscripcion
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar

    Private Sub FormInscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_campeonato.cargar(BD.leo_tabla("SELECT * FROM Campeonato"), "id_campeonato", "nombre")
        cmb_año.cargar(BD.leo_tabla("SELECT * FROM Campeonato WHERE id_estado_campeonato = 3"), "anio", "anio")
        cmb_club.cargar(BD.leo_tabla("SELECT * FROM ClubFutbol"), "id_club", "nombre_club")
        cmb_estado.cargar(BD.leo_tabla("SELECT * FROM EstadoInscripcion"), "id_estado", "descripcion")
        cargar_grilla()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TE.blanquear_objetos(Me)
        cmb_club.Focus()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If Me.inscrip.transferir(Me, inscripcion.a_donde.a_la_clase) = inscripcion.estado_transferencia.datosErroneos Then
            Exit Sub
        End If
        If control_estado_grabacion = estado_grabacion.insertar Then
            'Se dispara en el objeto negocio (usuarios) el método de insertar datos
            Me.inscrip.insertar()
            MsgBox("Se grabó exitosamente")
            'se recarga la grilla
            Me.cargar_grilla()
            Me.TE.blanquear_objetos(Me)
            Me.cmb_club.Focus()
        End If

    End Sub

    Private Sub cargar_grilla()

        Me.DataGridView1.DataSource = inscrip.lista_inscriptos()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Me.inscrip.borrar(cmb_club.SelectedValue())
        'MsgBox("Se elimino exitosamente")
        Me.cargar_grilla()
        'Me.TE.blanquear_objetos(Me)
        Me.cmb_club.Focus()
    End Sub

End Class