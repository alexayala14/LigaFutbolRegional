Public Class FormEliminarJugador
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        FormJugadores.JugadorTableAdapter1.FillBy(FormJugadores.CampeonatoPavDataSet.Jugador, MaskedTextBox2.Text)
        FormJugadores.JugadorTableAdapter1.Eliminar(MaskedTextBox2.Text)
        MaskedTextBox2.Text = ""

        FormJugadores.JugadorTableAdapter1.Fill(FormJugadores.CampeonatoPavDataSet.Jugador)


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub
End Class