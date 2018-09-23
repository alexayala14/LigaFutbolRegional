Public Class FormJugadores
    Dim _Jugador As New Jugador

    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (Jugadores) que es un DataTable
        Me.JugadoresDataGridView.DataSource = Me._Jugador.lista_jugadores()
    End Sub
    Private Sub cmdJugadorConsulta_Click(sender As Object, e As EventArgs) Handles cmdJugadorConsulta.Click

        'Me.JugadorTableAdapter1.Fill(Me.CampeonatoPavDataSet.Jugador)
        Me.cargar_grilla()



    End Sub

    Private Sub FormJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CampeonatoPavDataSet.Jugador' Puede moverla o quitarla según sea necesario.
        'Me.JugadorTableAdapter1.Fill(Me.CampeonatoPavDataSet.Jugador)
        'TODO: esta línea de código carga datos en la tabla 'CampeonatoDataSet.Jugador' Puede moverla o quitarla según sea necesario.


    End Sub



    Private Sub cmdJugadorRegistrar_Click(sender As Object, e As EventArgs) Handles cmdJugadorRegistrar.Click

        FormRegistrarJugador.Show()


    End Sub

    Private Sub cmdJugadorModificar_Click(sender As Object, e As EventArgs) Handles cmdJugadorModificar.Click
        FormActualizarJugador.Show()
    End Sub

    Private Sub cmdJugadorEliminar_Click(sender As Object, e As EventArgs) Handles cmdJugadorEliminar.Click
        FormEliminarJugador.Show()



    End Sub


End Class