Public Class JugadoresXCampeonato
    Dim jugadores As New Jugador
    Dim _BD As New CONEXION_BD


    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If Me.txt_nuevo.Text <> "" Then
            inserta_elemento(Me.txt_nuevo.Text)



            Me.txt_nuevo.Text = ""
        End If
    End Sub
    Sub inserta_elemento(ByVal valor As String)

        Me.lista_elementos.Items.Add(valor)
    End Sub


    Private Sub cargar_jugadores()
        Dim tabla As New DataTable
        tabla = _BD.leo_tabla("SELECT nombre FROM Jugador")
        Dim aux As Integer = tabla.Rows.Count - 1
        Dim valor As Boolean = True
        While valor
            ListBox2.Items.Add(tabla.Rows(aux)("nombre"))
            aux -= 1
            If (aux = -1) Then
                valor = False
            End If
        End While

    End Sub

    Private Sub JugadoresXCampeonato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_jugadores()
    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        lista_elementos.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
End Class