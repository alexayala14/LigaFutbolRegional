Public Class FormActualizarJugador
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        FormJugadores.JugadorTableAdapter1.Actualizar(MaskedTextBox2.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, MaskedTextBox5.Text, MaskedTextBox6.Text, MaskedTextBox7.Text, MaskedTextBox8.Text, MaskedTextBox9.Text)
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
        MaskedTextBox5.Text = ""
        MaskedTextBox6.Text = ""
        MaskedTextBox7.Text = ""
        MaskedTextBox8.Text = ""
        MaskedTextBox9.Text = ""
        FormJugadores.JugadorTableAdapter1.Fill(FormJugadores.CampeonatoPavDataSet.Jugador)
    End Sub
End Class