Public Class PartidosCargados
    Dim BD As New CONEXION_BD_01


    Private Sub PartidosCargados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = BD.leo_tabla("SELECT id_club_local, id_club_visitante,numero_fecha FROM ResultadosPartido")
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class