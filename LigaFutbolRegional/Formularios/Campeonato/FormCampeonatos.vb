Public Class FormCampeonatos
    Dim _campeonato As New campeonato

    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        Me.CampeonatosDataGridView.DataSource = Me._campeonato.lista_campeonatos()
    End Sub
    Private Sub cmdCampeonatosConsulta_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosConsulta.Click
        Me.cargar_grilla()
    End Sub

    Private Sub cmdCampeonatosRegistrar_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosRegistrar.Click
        FormRegistrarCampeonato.Show()
    End Sub

    Private Sub cmdCampeonatosModificar_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosModificar.Click
        FormActualizarCampeonato.Show()
    End Sub

    Private Sub cmdCampeonatosEliminar_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosEliminar.Click
        FormEliminarCampeonato.Show()
    End Sub
End Class