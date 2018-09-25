Public Class FormEliminarJugador
    Dim _Jugador As New Jugador
    Dim _TE As New tratamientos_especiales
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Me._Jugador.borrar(txt_dni.Text())
        MsgBox("Se elimino exitosamente")
        Me.cargar_grilla()
        Me._TE.blanquear_objetos(Me)
        Me.txt_dni.Focus()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormJugadores.JugadoresDataGridView.DataSource = Me._Jugador.lista_jugadores()
    End Sub
End Class