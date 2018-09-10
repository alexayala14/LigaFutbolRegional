Public Class FormEliminarClub
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        FormClubes.ClubFutbolTableAdapter.Eliminar(MaskedTextBox1.Text)
        MaskedTextBox1.Text = ""
        FormClubes.ClubFutbolTableAdapter.Fill(FormClubes.CampeonatoPavDataSet1.ClubFutbol)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class