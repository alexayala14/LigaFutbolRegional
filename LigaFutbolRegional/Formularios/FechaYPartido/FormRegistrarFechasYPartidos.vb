Public Class FormRegistrarFechasYPartidos
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim _TE As New tratamientos_especiales
    Dim _FechasYPartidos As New FechasYPartidos
    Dim _BD As New CONEXION_BD
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

    End Sub


    Private Sub FormRegistrarFechasYPartidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_local.cargar(_BD.leo_tabla("SELECT * FROM Partido"), "id_club_local", "nombre")
        Me.cmb_visitante.cargar(_BD.leo_tabla("SELECT * FROM Partido"), "id_club_visitante", "nombre")
        Me.cmb_visitante.cargar(_BD.leo_tabla("SELECT * FROM Partido"), "id_estado_partido", "nombre")
        Me._TE.blanquear_objetos(Me)
        Me.control_estado_grabacion = estado_grabacion.insertar
    End Sub
End Class