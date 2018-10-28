Public Class ResultadoPartido
    Dim BD As New CONEXION_BD_01
    Private Sub ResultadoPartido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_id_campeonato.cargar(BD.leo_tabla("SELECT DISTINCT F.id_campeonato , C.nombre FROM PartidoXFechaXCampeonato F, Campeonato C WHERE F.id_campeonato = C.id_campeonato "), "id_campeonato", "nombre")
        Me.cmb_jornada.cargar(BD.leo_tabla("SELECT DISTINCT numero_fecha FROM PartidoXFechaXCampeonato WHERE id_campeonato = " & Me.cmb_id_campeonato.SelectedValue), "numero_fecha", "numero_fecha")
        Me.txt_anio_campeonato.Text = BD.leo_tabla("SELECT * FROM Campeonato WHERE id_campeonato = " & Me.cmb_id_campeonato.SelectedValue).Rows(0)("anio")
    End Sub

    Private Sub cargarClub()
        Dim tabla As DataTable
        tabla = BD.leo_tabla("SELECT id_club, nombre_club from ClubFutbol WHERE id_club = " & Me.txt_id_club_local.Text & " or id_club = " & Me.txt_id_club_visitante.Text)
        Me.cmb_id_club.cargar(tabla, "id_club", "nombre_club")
    End Sub

    Private Sub cargarJugador()
        Dim tabla As DataTable
        tabla = BD.leo_tabla("SELECT J.dni , j.nombre FROM Jugador J , JugadorXClubXCampeonato JC WHERE J.dni = JC.dni_jugador AND JC.idClub=  " & Me.cmb_id_club.SelectedValue)
        cmb_id_jugador.cargar(tabla, "dni", "nombre")
    End Sub



    Private Sub cargarGrilla()
        DGV1.DataSource = Nothing
        DGV1.DataSource = BD.leo_tabla("SELECT  P.numero_fecha, P.id_club_local,P.id_club_visitante,P.id_arbitro ,C.nombre  FROM Campeonato C, PartidoXFechaXCampeonato P WHERE C.id_campeonato = " & Me.cmb_id_campeonato.SelectedValue & "AND numero_fecha = " & Me.cmb_jornada.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarGrilla()
    End Sub

    Private Sub DGV1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentDoubleClick
        txt_id_club_local.Text = DGV1(1, DGV1.CurrentRow.Index).Value
        txt_id_club_visitante.Text = DGV1(2, DGV1.CurrentRow.Index).Value
        txt_club_local.Text = BD.leo_tabla("SELECT nombre_club FROM ClubFutbol WHERE id_club = " & Me.txt_id_club_local.Text).Rows(0)("nombre_club")
        txt_club_visitante.Text = BD.leo_tabla("SELECT nombre_club FROM ClubFutbol WHERE id_club = " & Me.txt_id_club_visitante.Text).Rows(0)("nombre_club")
        cargarClub()
        Me.cmb_cant_rojas.SelectedIndex = -1
        Me.cmb_cant_amarillas.SelectedIndex = -1
        Me.txt_faltas.Clear()
        Me.txt_goles_a_favor.Clear()
        Me.txt_goles_en_contra.Clear()
        Me.txt_tipo_documento.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id_resultado As Integer
        If BD.leo_tabla("SELECT * FROM ResultadosPartido WHERE id_club_local = " & Me.txt_id_club_local.Text & " AND " & "id_club_visitante = " & Me.txt_id_club_visitante.Text).Rows.Count > 0 Then
            MsgBox("El partido: " & Me.txt_club_local.Text & " VS " & Me.txt_club_visitante.Text & vbLf & "Ya fue Cargado")
        Else

            Dim sql As String = ""
            sql = "INSERT INTO ResultadosPartido  (id_club_local , id_club_visitante , goles_locales , goles_visitantes , id_campeonato , anio ,numero_fecha) VALUES ("
            sql &= Me.txt_id_club_local.Text & ", "
            sql &= Me.txt_id_club_visitante.Text & ", "
            sql &= Me.txt_goles_local.Text & ", "
            sql &= Me.txt_goles_visitante.Text & ", "
            sql &= Me.cmb_id_campeonato.SelectedValue & ", "
            sql &= Me.txt_anio_campeonato.Text & ", "
            sql &= Me.cmb_jornada.SelectedValue & " "
            sql &= ") "
            BD.iniciar_transaccion()
            BD.INS_MOD_BOR(sql)
            id_resultado = CInt(BD.leo_tabla("select id_resultado from ResultadosPartido where id_club_local =" & Me.txt_id_club_local.Text & "  AND id_club_visitante = " & Me.txt_id_club_visitante.Text).Rows(0)("id_resultado"))
            For c = 0 To DGV2.Rows.Count - 1
                BD.leo_tabla(insertar(c, id_resultado))
            Next

            BD.fin_transaccion()
        End If
    End Sub


    Private Sub cmb_id_club_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_id_club.SelectedIndexChanged
        If Me.cmb_id_club.SelectedValue.ToString <> "System.Data.DataRowView" Then
            cargarJugador()
            Me.cmb_cant_rojas.SelectedIndex = -1
            Me.cmb_cant_amarillas.SelectedIndex = -1
            Me.txt_faltas.Clear()
            Me.txt_goles_a_favor.Clear()
            Me.txt_goles_en_contra.Clear()
            Me.txt_tipo_documento.Clear()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DGV2.Rows.Add()
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(0).Value = Me.cmb_id_club.SelectedValue
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(1).Value = Me.txt_tipo_documento.Text
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(2).Value = Me.cmb_id_jugador.SelectedValue
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(3).Value = Me.txt_goles_a_favor.Text
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(4).Value = Me.txt_goles_en_contra.Text
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(5).Value = Me.cmb_cant_rojas.Text
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(6).Value = Me.cmb_cant_amarillas.Text
        Me.DGV2.Rows(Me.DGV2.Rows().Count - 1).Cells(7).Value = Me.txt_faltas.Text
    End Sub

    Private Sub cmb_id_jugador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_id_jugador.SelectedIndexChanged
        If Me.cmb_id_jugador.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Me.cmb_cant_rojas.SelectedIndex = -1
            Me.cmb_cant_amarillas.SelectedIndex = -1
            Me.txt_faltas.Clear()
            Me.txt_goles_a_favor.Clear()
            Me.txt_goles_en_contra.Clear()
            Me.txt_tipo_documento.Text = BD.leo_tabla("SELECT tipo_doc FROM Jugador WHERE dni = " & Me.cmb_id_jugador.SelectedValue).Rows(0)("tipo_doc")

        End If
    End Sub

    Private Function insertar(ByVal fila As Integer, ByVal id_result As Integer) As String
        Dim sql As String = ""

        sql = "INSERT INTO JugadorXClubXCampeonatoXPartido (idClub, tipoDoc_jugador , dni_jugador, "
        sql &= " goles_a_favor, goles_en_contra,cantidad_rojas, cantidad_amarillas, faltas_cometidas, id_campeonato, anio_campeonato, id_club_local,id_club_visitante, numero_fecha, id_resultado, id_detalle_resultado) VALUES ("
        For c = 0 To CInt(DGV2.ColumnCount.ToString()) - 1
            sql &= DGV2.Rows(fila).Cells(c).Value & ", "

        Next
        sql &= Me.cmb_id_campeonato.SelectedValue & " , " & Me.txt_anio_campeonato.Text & ", " & Me.txt_id_club_local.Text & ", " & Me.txt_id_club_visitante.Text & "," & Me.cmb_jornada.SelectedValue & ", " & id_result & ", " & fila + 1
        sql &= " )"
        'MsgBox(sql)
        Return sql
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class