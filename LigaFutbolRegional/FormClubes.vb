Public Class FormClubes
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormClubes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CampeonatoPavDataSet1.ClubFutbol' Puede moverla o quitarla según sea necesario.


    End Sub


    Private Sub cmdClubConsulta_Click(sender As Object, e As EventArgs) Handles cmdClubConsulta.Click
        Me.ClubFutbolTableAdapter.Fill(Me.CampeonatoPavDataSet1.ClubFutbol)
    End Sub

    Private Sub cmdClubRegistrar_Click(sender As Object, e As EventArgs) Handles cmdClubRegistrar.Click
        FormRegistrarClub.Show()
    End Sub

    Private Sub cmdClubModificar_Click(sender As Object, e As EventArgs) Handles cmdClubModificar.Click
        FormActualizarClub.Show()
    End Sub

    Private Sub cmdClubEliminar_Click(sender As Object, e As EventArgs) Handles cmdClubEliminar.Click
        FormEliminarClub.Show()
    End Sub
End Class