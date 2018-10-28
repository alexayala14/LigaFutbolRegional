Public Class From_Jornada

    Dim BD As New CONEXION_BD
    Private Sub From_Jornada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_id_campeonato.cargar(BD.leo_tabla("SELECT DISTINCT I.id_campeonato, C.nombre from Inscripcion I, Campeonato C where I.id_campeonato = C.id_campeonato"), "id_campeonato", "nombre")
        'Me.insertarJornadas()
        'MsgBox(BD.leo_tabla("select * from FechaXCampeonato where id_campeonato = " & Me.cmb_id_campeonato.SelectedValue).Rows.Count)
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        DGV_Jornadas.DataSource = Nothing
        DGV_Jornadas.DataSource = BD.leo_tabla("SELECT * FROM FechaXCampeonato WHERE id_campeonato = " & Me.cmb_id_campeonato.SelectedValue)

    End Sub
    Private Sub insertarJornadas()
        Dim tablaFecha As DataTable

        tablaFecha = BD.leo_tabla("SELECT fecha_inicio , fecha_fin FROM Campeonato WHERE id_campeonato = " & cmb_id_campeonato.SelectedValue)
        Dim cantClubes As Integer = BD.leo_tabla("SELECT * FROM Inscripcion WHERE id_campeonato = " & Me.cmb_id_campeonato.SelectedValue).Rows.Count - 1
        Dim tablaAnio As DataTable = BD.leo_tabla("SELECT DISTINCT id_campeonato , anio_campeonato FROM Inscripcion WHERE  id_campeonato = " & Me.cmb_id_campeonato.SelectedValue)
        Dim anio As Integer = tablaAnio.Rows(0)("anio_campeonato")
        Dim sql As String = ""
        Dim fechaFin As Date
        Dim fechaInicio As Date
        Dim fechaAdd As Integer
        fechaInicio = CDate(tablaFecha.Rows(0)("fecha_inicio"))
        fechaFin = CDate(tablaFecha.Rows(0)("fecha_fin"))
        MsgBox(Format(fechaFin, "MM/dd/yyyy"))
        MsgBox(cantClubes)
        fechaAdd = ((DateDiff("d", fechaInicio, fechaFin)) / cantClubes)
        For c = 1 To cantClubes

            sql = "INSERT INTO FechaXCampeonato (id_campeonato , anio , numero_fecha , fecha_inicio) VALUES ("
            sql &= Me.cmb_id_campeonato.SelectedValue & ", "
            sql &= anio & ", "
            sql &= c & " , "
            sql &= "'" & Format(fechaInicio, "MM/dd/yyyy") & "' )"
            BD.INS_MOD_BOR(sql)
            fechaInicio = fechaInicio.AddDays(fechaAdd)
        Next
        If cantClubes = BD.leo_tabla("SELECT * FROM FechaXCampeonato WHERE id_campeonato =" & Me.cmb_id_campeonato.SelectedValue).Rows.Count Then
            MsgBox("Se grabo correctamente")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla As DataTable
        tabla = BD.leo_tabla("SELECT * FROM FechaXCampeonato where id_campeonato = " & cmb_id_campeonato.SelectedValue)
        MsgBox(tabla.Rows.Count)
        Dim tablaInscripcion As DataTable = BD.leo_tabla("SELECT DISTINCT id_campeonato , id_club FROM Inscripcion WHERE id_campeonato = " & cmb_id_campeonato.SelectedValue)
        MsgBox(tablaInscripcion.Rows.Count)
        If tablaInscripcion.Rows.Count < 4 Then
            MsgBox("Los clubes inscriptos al campeonato: " & Me.cmb_id_campeonato.Text & ", debe ser mayor a 4")
            Exit Sub
        End If
        If tabla.Rows.Count = 0 Then
            insertarJornadas()
            cargarGrilla()
        Else
            MsgBox("Las Jornadas ya han sido creadas para el campeonato: " & cmb_id_campeonato.Text)
        End If


    End Sub

    Private Sub cmb_id_campeonato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_id_campeonato.SelectedIndexChanged
        If Me.cmb_id_campeonato.SelectedValue.ToString <> "System.Data.DataRowView" Then
            DGV_Jornadas.DataSource = Nothing
            cargarGrilla()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class