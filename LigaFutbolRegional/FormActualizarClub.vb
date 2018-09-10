Public Class FormActualizarClub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        FormClubes.ClubFutbolTableAdapter.Actualizar(MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, MaskedTextBox5.Text, MaskedTextBox6.Text, MaskedTextBox7.Text, MaskedTextBox8.Text)
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
        MaskedTextBox5.Text = ""
        MaskedTextBox5.Text = ""
        MaskedTextBox6.Text = ""
        MaskedTextBox7.Text = ""
        MaskedTextBox8.Text = ""
        FormClubes.ClubFutbolTableAdapter.Fill(FormClubes.CampeonatoPavDataSet1.ClubFutbol)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class