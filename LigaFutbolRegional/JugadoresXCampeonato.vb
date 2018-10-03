Public Class JugadoresXCampeonato
    Dim jugadores As New Jugador
    Dim _BD As New CONEXION_BD


    Private Sub cargarGrilla()
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("Select dni, nombre from Jugador")

        Dim aux As Integer = tabla.Rows.Count - 1
        Dim valor As Boolean = True
        While valor
            Me.DataGridView2.Rows.Add(tabla.Rows(aux)("dni"), tabla.Rows(aux)("nombre"))
            aux -= 1
            If (aux = -1) Then
                valor = False
            End If
        End While


    End Sub
    Private Sub JugadoresXCampeonato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()


    End Sub



    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        Dim dni As Integer
        Dim nombre As String
        Dim tabla As New DataTable
        dni = DataGridView2(0, DataGridView2.CurrentRow.Index).Value
        nombre = DataGridView2(1, DataGridView2.CurrentRow.Index).Value

        Me.DataGridView1.Rows.Add(dni, nombre)

        Me.DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index)

        lbl_count.Text = Me.DataGridView1.Rows.Count - 1
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim dni As Integer
        Dim nombre As String
        Dim tabla As New DataTable
        dni = DataGridView1(0, DataGridView1.CurrentRow.Index).Value
        nombre = DataGridView1(1, DataGridView1.CurrentRow.Index).Value

        Me.DataGridView2.Rows.Add(dni, nombre)

        Me.DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)

        lbl_count.Text = Me.DataGridView1.Rows.Count - 1
    End Sub
End Class