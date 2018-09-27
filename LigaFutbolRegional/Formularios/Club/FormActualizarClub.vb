Public Class FormActualizarClub
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim _TE As New tratamientos_especiales
    Dim _Club As New Club
    Dim _BD As New CONEXION_BD
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Me._Club.transferir(Me, Club.a_donde.a_la_clase)


        'If control_estado_grabacion = estado_grabacion.insertar Then
        '    'Se dispara en el objeto negocio (usuarios) el método de insertar datos
        '    Me._Club.insertar()
        'Else
        'Se dispara en el objeto negocio (usuarios) el método de insertar datos
        Me._Club.modificar(txt_id.Text)
        MsgBox("Se modifico exitosamente")
        'se recarga la grilla
        Me.cargar_grilla()
        Me._TE.blanquear_objetos(Me)
        Me.txt_id.Focus()
        'End If
        'FormClubes.ClubFutbolTableAdapter.Fill(FormClubes.CampeonatoPavDataSet1.ClubFutbol)

    End Sub


    ' FormClubes.ClubFutbolTableAdapter.Actualizar(MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, MaskedTextBox5.Text, MaskedTextBox6.Text, MaskedTextBox7.Text, MaskedTextBox8.Text)

    'FormClubes.ClubFutbolTableAdapter.Fill(FormClubes.CampeonatoPavDataSet1.ClubFutbol)

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FormActualizarClub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_id_estado_club.cargar(_BD.leo_tabla("SELECT * FROM EstadoClub"), "id_estado_club", "nombre")
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me._Club.buscar_club(txt_id.Text)
        Me._Club.transferir(Me, Club.a_donde.al_front_end)

    End Sub
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormClubes.ClubFutbolDataGridView.DataSource = Me._Club.lista_clubes()
    End Sub

    Private Sub lbl_limpiar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_limpiar.LinkClicked
        Me._TE.blanquear_objetos(Me)
        Me.txt_id.Focus()
    End Sub
End Class