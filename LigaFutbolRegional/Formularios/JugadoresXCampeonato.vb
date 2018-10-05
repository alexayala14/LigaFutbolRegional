Public Class JugadoresXCampeonato
    Dim jugadores As New Jugador
    Dim _BD As New CONEXION_BD


    Private Sub cargarGrilla()
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("Select dni, nombre from Jugador")

        Dim aux As Integer = tabla.Rows.Count - 1
        Dim valor As Boolean = True
        While valor
            Me.DGV2.Rows.Add(tabla.Rows(aux)("dni"), tabla.Rows(aux)("nombre"))
            aux -= 1
            If (aux = -1) Then
                valor = False
            End If
        End While


    End Sub

    Private Sub cargar_combo()
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT * FROM PosicionJugador")
        Me.posicion_designada.DataSource = tabla
        Me.posicion_designada.ValueMember = "id_posicion"
        Me.posicion_designada.DisplayMember = "siglas"

    End Sub
    Private Sub JugadoresXCampeonato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
        cargar_combo()

    End Sub



    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentDoubleClick
        Dim dni As Integer
        Dim nombre As String
        Dim tabla As New DataTable
        dni = DGV2(0, DGV2.CurrentRow.Index).Value
        nombre = DGV2(1, DGV2.CurrentRow.Index).Value

        Me.DGV1.Rows.Add(dni, nombre)

        Me.DGV2.Rows.RemoveAt(DGV2.CurrentRow.Index)

        lbl_count.Text = Me.DGV1.Rows.Count - 1
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentDoubleClick
        Dim dni As Integer
        Dim nombre As String
        Dim tabla As New DataTable
        dni = DGV1(0, DGV1.CurrentRow.Index).Value
        nombre = DGV1(1, DGV1.CurrentRow.Index).Value

        Me.DGV2.Rows.Add(dni, nombre)

        Me.DGV1.Rows.RemoveAt(DGV1.CurrentRow.Index)

        lbl_count.Text = Me.DGV1.Rows.Count - 1
    End Sub


End Class