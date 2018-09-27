Public Class FormFechasYPartidos
    Private Sub cmdCampeonatosConsulta_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosConsulta.Click

    End Sub

    Private Sub cmdCampeonatosRegistrar_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosRegistrar.Click
        FormRegistrarFechasYPartidos.Show()

    End Sub

    Private Sub cmdCampeonatosModificar_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosModificar.Click
        FormActualizarFechasYPartidos.Show()
    End Sub

    Private Sub cmdCampeonatosEliminar_Click(sender As Object, e As EventArgs) Handles cmdCampeonatosEliminar.Click
        FormEliminarFechaYPartido.Show()
    End Sub
End Class