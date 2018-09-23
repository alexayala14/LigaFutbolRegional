Public Class FormArbitros
    Dim _arbitro As New arbitro
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (arbitros) que es un DataTable
        Me.ArbitrosDataGridView.DataSource = Me._arbitro.lista_arbitros()
    End Sub
    Private Sub cmdArbitroConsulta_Click(sender As Object, e As EventArgs) Handles cmdArbitroConsulta.Click
        Me.cargar_grilla()
    End Sub

    Private Sub cmdArbitroRegistrar_Click(sender As Object, e As EventArgs) Handles cmdArbitroRegistrar.Click
        FormRegistrarArbitro.Show()
    End Sub

    Private Sub cmdArbitroModificar_Click(sender As Object, e As EventArgs) Handles cmdArbitroModificar.Click
        FormActualizarArbitro.Show()
    End Sub

    Private Sub cmdArbitroEliminar_Click(sender As Object, e As EventArgs) Handles cmdArbitroEliminar.Click
        FormEliminarArbitro.Show()
    End Sub
End Class