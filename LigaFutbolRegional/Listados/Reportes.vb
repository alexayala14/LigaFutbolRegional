Public Class Reportes
    Dim _BD As New CONEXION_BD


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT * FROM ClubFutbol "
        If IsNumeric(txt_buscar.Text) Then
            sql &= "WHERE id_club = " & Me.txt_buscar.Text
        Else
            If Me.txt_buscar.Text.IndexOf("-") >= 1 Then
                Dim extremos As String()
                extremos = Me.txt_buscar.Text.Split("-")
                If IsNumeric(extremos(0)) _
                        And IsNumeric(extremos(1)) Then
                    sql &= "WHERE id_club BETWEEN " & extremos(0)
                    sql &= " AND " & extremos(1)
                Else
                    MsgBox("Error en dato de calculo")
                    Exit Sub
                End If
            Else
                sql &= "WHERE cod_postal like '%" & Me.txt_buscar.Text.Trim & "%'"
            End If
        End If
        ClubFutbolBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn1_buscar_Click(sender As Object, e As EventArgs) Handles btn1_buscar.Click
        Dim sql As String = "SELECT * FROM JugadorXClubXCampeonatoXPartido "
        If IsNumeric(txt1_buscar.Text) Then
            sql &= "WHERE numero_fecha = " & Me.txt1_buscar.Text
        Else
            If Me.txt1_buscar.Text.IndexOf("-") >= 1 Then
                Dim extremos As String()
                extremos = Me.txt1_buscar.Text.Split("-")
                If IsNumeric(extremos(0)) _
                        And IsNumeric(extremos(1)) Then
                    sql &= "WHERE numero_fecha BETWEEN " & extremos(0)
                    sql &= " AND " & extremos(1)
                Else
                    MsgBox("Error en dato de calculo")
                    Exit Sub
                End If
                'Else
                'sql &= "WHERE cod_postal like '%" & Me.txt_buscar.Text.Trim & "%'"
            End If
            sql &= " Order By faltas_cometidas desc"
        End If
        JugadorXClubXCampeonatoXPartidoBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub btn2_buscar_Click(sender As Object, e As EventArgs) Handles btn2_buscar.Click
        Dim sql As String = "SELECT * FROM ReporteClub "
        If IsNumeric(txt2_buscar.Text) Then
            sql &= "WHERE id_club = " & Me.txt2_buscar.Text
        Else
            If Me.txt2_buscar.Text.IndexOf("-") >= 1 Then
                Dim extremos As String()
                extremos = Me.txt2_buscar.Text.Split("-")
                If IsNumeric(extremos(0)) _
                        And IsNumeric(extremos(1)) Then
                    sql &= "WHERE id_club BETWEEN " & extremos(0)
                    sql &= " AND " & extremos(1)
                Else
                    MsgBox("Error en dato de calculo")
                    Exit Sub
                End If
                'Else
                '    sql &= "WHERE cod_postal like '%" & Me.txt_buscar.Text.Trim & "%'"
            End If
        End If
        sql &= " Order By puntos desc"
        ReporteClubBindingSource.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub btn3_buscar_Click(sender As Object, e As EventArgs) Handles btn3_buscar.Click
        Dim sql As String = "SELECT * from JugadorXClubXCampeonatoXPartido J "
        If IsNumeric(txt3_buscar.Text) Then
            sql &= "WHERE numero_fecha = " & Me.txt3_buscar.Text
        Else
            If Me.txt3_buscar.Text.IndexOf("-") >= 1 Then
                Dim extremos As String()
                extremos = Me.txt3_buscar.Text.Split("-")
                If IsNumeric(extremos(0)) _
                        And IsNumeric(extremos(1)) Then
                    sql &= "WHERE numero_fecha BETWEEN " & extremos(0)
                    sql &= " AND " & extremos(1)
                Else
                    MsgBox("Error en dato de calculo")
                    Exit Sub
                End If

            End If
        End If
        sql &= " order by goles_a_favor desc"
        JugadorXClubXCampeonatoXPartidoBindingSource1.DataSource = _BD.leo_tabla(sql)
        Me.ReportViewer4.RefreshReport()
    End Sub

    Private Sub JugadorBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles JugadorBindingSource.CurrentChanged

    End Sub


End Class