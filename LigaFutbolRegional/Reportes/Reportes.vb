Public Class FormReportes
    Dim _BD As New CONEXION_BD
    Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.JugadorXClubXCampeonato' Puede moverla o quitarla según sea necesario.



    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        Me.ReportViewer1.RefreshReport()
        Me.JugadorXClubXCampeonatoTableAdapter.Fill(Me.DataSet1.JugadorXClubXCampeonato)
    End Sub
End Class