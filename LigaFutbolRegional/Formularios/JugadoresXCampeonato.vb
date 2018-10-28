Public Class JugadoresXCampeonato
    Dim jugadores As New Jugador
    Dim _BD As New CONEXION_BD_01

    Private Sub cargarGrilla()
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("Select dni, nombre from Jugador WHERE id_estado = 2")

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

    Private Sub cargarGrilla2()

        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT dni, nombre , nroCamiseta , posicion_designada FROM  JugadorXClubXCampeonato A ,Jugador J WHERE A.dni_jugador = J.dni and A.idClub =  " & cmb_club.SelectedValue)
        If tabla.Rows.Count > 0 Then
            Dim aux As Integer = tabla.Rows.Count - 1
            Dim valor As Boolean = True
            While valor
                Me.DGV1.Rows.Add(tabla.Rows(aux)("dni"), tabla.Rows(aux)("nombre"), tabla.Rows(aux)("nroCamiseta"), tabla.Rows(aux)("posicion_designada"))
                aux -= 1
                If (aux = -1) Then
                    valor = False
                End If
            End While
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cargar_combo()
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT * FROM PosicionJugador")
        Me.posicion_designada.DataSource = tabla
        Me.posicion_designada.ValueMember = "id_posicion"
        Me.posicion_designada.DisplayMember = "siglas"

    End Sub
    Private Sub JugadoresXCampeonato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable


        cargarGrilla()
        cargar_combo()
        cmb_campeonato.cargar(_BD.leo_tabla("SELECT DISTINCT C.id_campeonato , nombre  FROM Campeonato C, Inscripcion I WHERE C.id_campeonato = I.id_campeonato"), "id_campeonato", "nombre")
        tabla = _BD.leo_tabla("SELECT * FROM Inscripcion WHERE id_campeonato = " & cmb_campeonato.SelectedValue)
        txt_anio_campeonato.Text = tabla.Rows(0)("anio_campeonato")
        cmb_club.cargar(_BD.leo_tabla("SELECT  C.id_club , nombre_club  FROM ClubFutbol C, Inscripcion I WHERE C.id_club = I.id_club"), "id_club", "nombre_club")
        'cargarGrilla2()
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

    Private Sub cmb_campeonato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_campeonato.SelectedIndexChanged
        Dim tabla As New DataTable
        If cmb_campeonato.SelectedValue.ToString <> "System.Data.DataRowView" Then

            tabla = _BD.leo_tabla("SELECT * FROM Inscripcion WHERE id_campeonato = " & cmb_campeonato.SelectedValue)
            txt_anio_campeonato.Text = tabla.Rows(0)("anio_campeonato")
            cmb_club.cargar(_BD.leo_tabla("SELECT  C.id_club , nombre_club  FROM ClubFutbol C, Inscripcion I WHERE C.id_club = I.id_club and I.id_campeonato = " & cmb_campeonato.SelectedValue), "id_club", "nombre_club")


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim aux As Integer = DGV1.Rows.Count()
        Dim tabla As New DataTable

        For c = 1 To aux - 2
            tabla = _BD.leo_tabla("Select tipo_doc FROM Jugador WHERE dni = " & DGV1.Rows(c).Cells(0).Value)
            Dim sql As String = ""
            sql = "INSERT INTO JugadorXClubXCampeonato (idClub , tipo_doc, dni_jugador , id_campeonato , anio_campeonato, nroCamiseta , posicion_designada) "
            sql &= "VALUES ( " & cmb_club.SelectedValue & ", " & tabla.Rows(0)("tipo_doc")
            sql &= " , " & DGV1.Rows(c).Cells(0).Value & ", " & cmb_campeonato.SelectedValue
            sql &= ", " & txt_anio_campeonato.Text & ", " & DGV1.Rows(c).Cells(2).Value
            sql &= ", " & DGV1.Rows(c).Cells("posicion_designada").Value & " )"
            _BD.INS_MOD_BOR(sql)
            sql = "UPDATE Jugador SET id_estado = 1 WHERE dni = " & DGV1.Rows(c).Cells(0).Value
            _BD.INS_MOD_BOR(sql)
        Next

    End Sub

    Private Sub cmb_club_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_club.SelectedIndexChanged
        If cmb_club.SelectedValue.ToString <> "System.Data.DataRowView" Then
            DGV2.Rows.Clear()
            DGV1.Rows.Clear()
            cargarGrilla2()
            cargarGrilla()
        End If
        lbl_count.Text = Me.DGV1.Rows.Count - 1


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dni As Integer
        Dim nombre As String
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = "UPDATE Jugador SET id_estado = 2 WHERE dni = " & DGV1.CurrentRow.Cells(0).Value
        Me._BD.INS_MOD_BOR(sql)
        sql = "DELETE FROM JugadorXClubXCampeonato WHERE dni_jugador = " & DGV1.CurrentRow.Cells(0).Value
        Me._BD.INS_MOD_BOR(sql)

        dni = DGV1(0, DGV1.CurrentRow.Index).Value
        nombre = DGV1(1, DGV1.CurrentRow.Index).Value

        Me.DGV2.Rows.Add(dni, nombre)
        If Me.DGV1.Rows.Count - 1 > 0 Then
            Me.DGV1.Rows.RemoveAt(DGV1.CurrentRow.Index)
        End If


        lbl_count.Text = Me.DGV1.Rows.Count - 1



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        _BD.iniciar_transaccion()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        _BD.fin_transaccion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class