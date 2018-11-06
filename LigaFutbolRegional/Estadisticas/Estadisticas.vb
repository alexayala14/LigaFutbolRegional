Public Class Estadisticas
    Dim _BD As New CONEXION_BD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_restriccion.Click
        Dim sql As String = ""
        sql &= "select e.nombre as descriptor           "
        sql &= ", count(*) as calculo                     "
        sql &= "from PosicionJugador e join JugadorXClubXCampeonato hb    "
        sql &= "			on e.id_posicion = hb.posicion_designada "
        sql &= "group by e.nombre  "

        Dim extremos As String()

        If Me.txt_restriccion.Text.IndexOf("-") >= 1 Then
            extremos = Me.txt_restriccion.Text.Split("-")
            If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
                sql &= " having count(*) between " & extremos(0)
                sql &= " AND " & extremos(1)
            End If
        End If
        DataSet31BindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer5.RefreshReport()
    End Sub

    Private Sub btn_restriccion1_Click(sender As Object, e As EventArgs) Handles btn_restriccion1.Click
        Dim sql As String = ""
        sql &= "SELECT J.nombre as descriptor , SUM(JP.goles_a_favor) AS calculo FROM JugadorXClubXCampeonatoXPartido JP , Jugador J WHERE JP.dni_jugador=J.dni GROUP BY J.nombre ORDER BY SUM(JP.goles_a_favor) desc          "

        Dim extremos As String()

        If Me.txt_restriccion.Text.IndexOf("-") >= 1 Then
            extremos = Me.txt_restriccion.Text.Split("-")
            If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
                sql &= " having SUM(JP.goles_a_favor) between " & extremos(0)
                sql &= " AND " & extremos(1)
            End If
        End If
        DataSet31BindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer6.RefreshReport()
    End Sub

    Private Sub btn_restriccion2_Click(sender As Object, e As EventArgs) Handles btn_restriccion2.Click
        Dim sql As String = ""
        sql &= "SELECT J.nombre_club as descriptor , SUM(JP.faltas_cometidas) AS calculo FROM JugadorXClubXCampeonatoXPartido JP , ClubFutbol J WHERE JP.idClub=J.id_club GROUP BY J.nombre_club ORDER BY SUM(JP.goles_a_favor) desc          "

        Dim extremos As String()

        If Me.txt_restriccion.Text.IndexOf("-") >= 1 Then
            extremos = Me.txt_restriccion.Text.Split("-")
            If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
                sql &= " having SUM(JP.faltas_cometidas) between " & extremos(0)
                sql &= " AND " & extremos(1)
            End If
        End If
        DataSet31BindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer7.RefreshReport()
    End Sub

    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_restriccion3_Click(sender As Object, e As EventArgs) Handles btn_restriccion3.Click
        Dim sql As String = ""
        sql &= "SELECT J.nombre_club as descriptor , SUM(JP.cantidad_amarillas) AS calculo FROM JugadorXClubXCampeonatoXPartido JP , ClubFutbol J WHERE JP.idClub=J.id_club GROUP BY J.nombre_club ORDER BY SUM(JP.cantidad_amarillas) desc          "

        Dim extremos As String()

        If Me.txt_restriccion.Text.IndexOf("-") >= 1 Then
            extremos = Me.txt_restriccion.Text.Split("-")
            If IsNumeric(extremos(0)) And IsNumeric(extremos(1)) Then
                sql &= " having SUM(JP.cantidad_amarillas) between " & extremos(0)
                sql &= " AND " & extremos(1)
            End If
        End If
        DataSet31BindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer8.RefreshReport()
    End Sub
End Class