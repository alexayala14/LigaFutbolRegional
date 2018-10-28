Public Class Estadisticas
    Dim _BD As New CONEXION_BD
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        sql &= "select e.nombre as descriptor           " 'FIJATE QUE TABLAS LE PONES PARA LOS REPORTES
        sql &= ", count(*) as calculo                     "
        sql &= "from EstadoJugador e join Jugador hb    "
        sql &= "			on e.id_estado = hb.id_estado "
        sql &= "group by e.nombre  "

        Dim extremos As String()

        If Me.txt_buscar.Text.IndexOf("-") >= 1 Then
            extremos = Me.txt_buscar.Text.Split("-")
            If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
                sql &= " having count(*) between " & extremos(0)
                sql &= " AND " & extremos(1)
            End If
        End If
        '.DataSource = _BD.leo_tabla(sql) 'ESTO ES LO QUE NO ME SALE
        Me.ReportViewer1.RefreshReport() 'ESTE ESTA BIEN
    End Sub

    Private Sub btn1_buscar_Click(sender As Object, e As EventArgs) Handles btn1_buscar.Click
        'Dim sql As String = ""
        'Sql &= "select e.n_estado as descriptor           " 'FIJATE QUE TABLAS LE PONES PARA LOS REPORTES
        'Sql &= ", count(*) as calculo                     "
        'Sql &= "from Estados e join Historiales_Bug hb    "
        'Sql &= "			on e.id_estado = hb.id_estado "
        'Sql &= "group by e.n_estado  "

        'Dim extremos As String()

        'If Me.txt1_buscar.Text.IndexOf("-") >= 1 Then
        'extremos = Me.txt1_buscar.Text.Split("-")
        'If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
        'Sql &= " having count(*) between " & extremos(0)
        'Sql &= " AND " & extremos(1)
        'End If
        'End If
        'estadisticaBindingSource.DataSource = _BD.leo_tabla(sql)
        'Me.ReportViewer2.RefreshReport() 'ESTE ESTA BIEN
    End Sub

    Private Sub btn2_buscar_Click(sender As Object, e As EventArgs) Handles btn2_buscar.Click
        'Dim sql As String = ""
        'Sql &= "select e.n_estado as descriptor           " 'FIJATE QUE TABLAS LE PONES PARA LOS REPORTES
        'Sql &= ", count(*) as calculo                     "
        'Sql &= "from Estados e join Historiales_Bug hb    "
        'Sql &= "			on e.id_estado = hb.id_estado "
        'Sql &= "group by e.n_estado  "

        'Dim extremos As String()

        'If Me.txt2_buscar.Text.IndexOf("-") >= 1 Then
        'extremos = Me.txt2_buscar.Text.Split("-")
        'If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
        'Sql &= " having count(*) between " & extremos(0)
        'Sql &= " AND " & extremos(1)
        'End If
        'End If
        'estadisticaBindingSource.DataSource = _BD.leo_tabla(sql)
        'Me.ReportViewer3.RefreshReport() 'ESTE ESTA BIEN
    End Sub

    Private Sub btn3_buscar_Click(sender As Object, e As EventArgs) Handles btn3_buscar.Click
        'Dim sql As String = ""
        'Sql &= "select e.n_estado as descriptor           " 'FIJATE QUE TABLAS LE PONES PARA LOS REPORTES
        'Sql &= ", count(*) as calculo                     "
        'Sql &= "from Estados e join Historiales_Bug hb    "
        'Sql &= "			on e.id_estado = hb.id_estado "
        'Sql &= "group by e.n_estado  "

        'Dim extremos As String()

        'If Me.txt3_buscar.Text.IndexOf("-") >= 1 Then
        'extremos = Me.txt3_buscar.Text.Split("-")
        'If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
        'Sql &= " having count(*) between " & extremos(0)
        'Sql &= " AND " & extremos(1)
        'End If
        'End If
        'estadisticaBindingSource.DataSource = _BD.leo_tabla(sql)
        'Me.ReportViewer4.RefreshReport() 'ESTE ESTA BIEN
    End Sub
End Class