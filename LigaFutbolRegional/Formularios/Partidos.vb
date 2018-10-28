Public Class Partidos
    Dim BD As New CONEXION_BD
    Dim Equipos As DataTable
    Dim BD_01 As New CONEXION_BD_01
    Dim Arbitros As DataTable
    Private Sub Partidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_id_campeonato.cargar(BD.leo_tabla("SELECT DISTINCT F.id_campeonato , C.nombre FROM FechaXCampeonato F, Campeonato C WHERE F.id_campeonato = C.id_campeonato "), "id_campeonato", "nombre")
        cmb_jornada.cargar(BD.leo_tabla("Select * FROM FechaXCampeonato WHERE id_campeonato =" & cmb_id_campeonato.SelectedValue), "numero_fecha", "numero_fecha")
        txt_anio.Text = BD.leo_tabla("Select anio_campeonato From Inscripcion WHERE id_campeonato = " & Me.cmb_id_campeonato.SelectedValue).Rows(0)("anio_campeonato")
        Equipos = BD.leo_tabla("select * from Inscripcion where id_campeonato = " & Me.cmb_id_campeonato.SelectedValue)
        Arbitros = BD.leo_tabla("SELECT id_arbitro FROM  Arbitro")
        cargarGrilla()

    End Sub

    Private Sub cargarGrilla()
        'Dim tabla As DataTable = BD_01.leo_tabla("SELECT ")
        DGV.DataSource = Nothing
        DGV.DataSource = BD.leo_tabla("SELECT  P.numero_fecha, P.id_club_local,P.id_club_visitante,P.id_arbitro ,C.nombre  FROM Campeonato C, PartidoXFechaXCampeonato P WHERE C.id_campeonato = " & Me.cmb_id_campeonato.SelectedValue)
    End Sub



    Private Sub generarEmparejamientos(ByVal N As Integer)
        BD_01.iniciar_transaccion()

        Dim matriz1(N - 1, N / 2) As Integer
        Dim matriz2(N - 1, N / 2) As Integer
        Dim jornada(N - 1, N / 2) As String

        Dim count As Integer = 1
        Dim count2 As Integer = N - 1

        For i = 0 To N - 2
            For j = 0 To (N / 2) - 1

                If j = 0 Then
                    matriz2(i, j) = Me.Equipos.Rows(N - 1)("id_club")
                Else matriz2(i, j) = Me.Equipos.Rows(count2 - 1)("id_club")
                    count2 -= 1
                    If count2 = 0 Then
                        count2 = N - 1
                    End If
                End If

            Next
        Next
        count = 1
        count2 = N - 1
        For i = 0 To N - 2
            For j = 0 To (N / 2) - 1
                matriz1(i, j) = Me.Equipos.Rows(count - 1)("id_club")
                count += 1
                If count = (N) Then
                    count = 1
                End If


            Next
        Next
        count = 1
        count2 = N - 1
        For i = 0 To N - 2
            For j = 0 To (N / 2) - 1

                If j = 0 Then
                    If (i Mod 2 = 0) Then
                        jornada(i, j) = CStr(matriz2(i, j)) & "Vs" & CStr(matriz1(i, j)) + " "
                    Else jornada(i, j) = CStr(matriz1(i, j)) & "Vs" & CStr(matriz2(i, j)) + " "
                    End If
                Else jornada(i, j) = CStr(matriz1(i, j)) & "vs" & CStr(matriz2(i, j)) & " "
                End If
            Next
        Next
        Dim nro_fecha As Integer = 1
        Dim sql As String = ""
        count = 1
        count2 = N - 1
        For i = 0 To N - 2
            For j = 0 To (N / 2) - 1

                If j = 0 Then
                    If (i Mod 2 = 0) Then

                        sql = "Insert Into PartidoXFechaXCampeonato (id_club_local, id_club_visitante,id_campeonato, anio, numero_fecha, id_arbitro )"
                        sql += "VALUES (" & CStr(matriz2(i, j)) & "," & CStr(matriz1(i, j)) & ""
                        sql += ", " & Me.cmb_id_campeonato.SelectedValue
                        sql += ", " & CInt(txt_anio.Text) & " , " & nro_fecha & "," & Arbitros.Rows(CInt((2 - 19) * Rnd() + 19))("id_arbitro") & " )"
                        sql += vbLf
                        BD_01.INS_MOD_BOR(sql)

                    Else sql = "Insert Into PartidoXFechaXCampeonato (id_club_local, id_club_visitante,id_campeonato, anio, numero_fecha, id_arbitro )"
                        sql += "VALUES (" & CStr(matriz1(i, j)) & "," & CStr(matriz2(i, j)) & ""
                        sql += ", " & Me.cmb_id_campeonato.SelectedValue
                        sql += ", " & CInt(txt_anio.Text) & " , " & nro_fecha & "," & Arbitros.Rows(CInt((2 - 19) * Rnd() + 19))("id_arbitro") & " )"
                        sql += vbLf
                        BD_01.INS_MOD_BOR(sql)
                    End If
                Else sql = "Insert Into PartidoXFechaXCampeonato (id_club_local, id_club_visitante,id_campeonato, anio, numero_fecha, id_arbitro )"
                    sql += "VALUES (" & CStr(matriz1(i, j)) & "," & CStr(matriz2(i, j)) & ""
                    sql += ", " & Me.cmb_id_campeonato.SelectedValue
                    sql += ", " & CInt(txt_anio.Text) & " , " & nro_fecha & "," & Arbitros.Rows(CInt((2 - 19) * Rnd() + 19))("id_arbitro") & " )"
                    sql += vbLf
                    BD_01.INS_MOD_BOR(sql)
                End If
            Next
            nro_fecha += 1
        Next
        'Muestra la matriz resultante
        'Dim cadena As String = ""
        'Dim jorn As Integer = 1
        'For i = 0 To N - 2
        '    cadena &= vbLf
        '    cadena &= "Jornada " & jorn
        '    cadena &= vbLf
        '    For j = 0 To (N / 2) - 1
        '        cadena &= " " & jornada(i, j)
        '        If j = (N / 2) - 1 Then
        '            cadena &= vbLf
        '        End If
        '    Next
        '    jorn += 1
        'Next
        'MsgBox(cadena)
        BD_01.fin_transaccion()
        cargarGrilla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If BD.leo_tabla("Select * from PartidoXFechaXCampeonato Where id_campeonato = " & Me.cmb_id_campeonato.SelectedValue).Rows.Count > 1 Then
            MsgBox("Las Jornadas con sus partidos ya han sido creadas")
            mostrarEmparejamiento(Equipos.Rows.Count)
        Else
            generarEmparejamientos(Equipos.Rows.Count)
        End If


    End Sub

    Private Sub mostrarEmparejamiento(ByVal N As Integer)


        Dim matriz1(N - 1, N / 2) As String
        Dim matriz2(N - 1, N / 2) As String
        Dim jornada(N - 1, N / 2) As String

        Dim count As Integer = 1
        Dim count2 As Integer = N - 1

        For i = 0 To N - 2
            For j = 0 To (N / 2) - 1

                If j = 0 Then
                    matriz2(i, j) = BD.leo_tabla("Select nombre_club From ClubFutbol where id_club = " & Me.Equipos.Rows(N - 1)("id_club")).Rows(0)("nombre_club")
                Else matriz2(i, j) = BD.leo_tabla("Select nombre_club From ClubFutbol where id_club = " & Me.Equipos.Rows(count2 - 1)("id_club")).Rows(0)("nombre_club")
                    count2 -= 1
                    If count2 = 0 Then
                        count2 = N - 1
                    End If
                End If

            Next
        Next
        count = 1
        count2 = N - 1
        For i = 0 To N - 2
            For j = 0 To (N / 2) - 1
                matriz1(i, j) = BD.leo_tabla("Select nombre_club From ClubFutbol where  id_club = " & Me.Equipos.Rows(count - 1)("id_club")).Rows(0)("nombre_club")
                count += 1
                If count = (N) Then
                    count = 1
                End If


            Next
        Next
        count = 1
        count2 = N - 1
        For i = 0 To N - 2
            For j = 0 To (N / 2) - 1

                If j = 0 Then
                    If (i Mod 2 = 0) Then
                        jornada(i, j) = CStr(matriz2(i, j)) & " Vs " & CStr(matriz1(i, j)) + " "
                    Else jornada(i, j) = CStr(matriz1(i, j)) & " Vs " & CStr(matriz2(i, j)) + " "
                    End If
                Else jornada(i, j) = CStr(matriz1(i, j)) & " Vs " & CStr(matriz2(i, j)) & " "
                End If
            Next
        Next
        Dim nro_fecha As Integer = 1
        Dim sql As String = ""
        count = 1
        count2 = N - 1


        Dim cadena As String = ""
        Dim jorn As Integer = 1
        For i = 0 To N - 2
            cadena &= vbLf
            cadena &= "Jornada " & jorn & "  " & BD.leo_tabla("Select * From FechaXCampeonato WHERE id_campeonato = " & Me.cmb_id_campeonato.SelectedValue & "AND numero_fecha = " & jorn).Rows(0)("fecha_inicio")
            cadena &= vbLf
            For j = 0 To (N / 2) - 1
                cadena &= " " & jornada(i, j)
                cadena &= vbLf
                If j = (N / 2) - 1 Then
                    cadena &= vbLf
                End If
            Next
            jorn += 1
        Next
        MsgBox(cadena)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DGV.DataSource = Nothing
        DGV.DataSource = BD.leo_tabla("SELECT  P.numero_fecha, P.id_club_local,P.id_club_visitante,P.id_arbitro ,C.nombre  FROM Campeonato C, PartidoXFechaXCampeonato P WHERE C.id_campeonato = " & Me.cmb_id_campeonato.SelectedValue & "AND numero_fecha = " & Me.cmb_jornada.SelectedValue)
    End Sub

    Private Sub cmb_id_campeonato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_id_campeonato.SelectedIndexChanged
        If Me.cmb_id_campeonato.SelectedValue.ToString <> "System.Data.DataRowView" Then
            txt_anio.Text = BD.leo_tabla("Select anio_campeonato From Inscripcion WHERE id_campeonato = " & Me.cmb_id_campeonato.SelectedValue).Rows(0)("anio_campeonato")
            cargarGrilla()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mostrarEmparejamiento(Equipos.Rows.Count)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentDoubleClick

    End Sub
End Class