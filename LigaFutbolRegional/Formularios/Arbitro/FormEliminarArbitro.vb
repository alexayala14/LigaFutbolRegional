Imports LigaFutbolRegional.FormArbitros
Public Class FormEliminarArbitro
    Dim _Arbitro As New Arbitro
    Dim _TE As New tratamientos_especiales

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Me._Arbitro.borrar(txt_id_arbitro.Text())
        MsgBox("Se elimino exitosamente")
        Me.cargar_grilla()
        Me._TE.blanquear_objetos(Me)
        Me.txt_id_arbitro.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormArbitros.ArbitrosDataGridView.DataSource = Me._Arbitro.lista_arbitros()
    End Sub
    Private Sub FormEliminarArbitro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class