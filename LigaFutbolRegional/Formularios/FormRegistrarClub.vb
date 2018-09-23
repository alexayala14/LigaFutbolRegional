Public Class FormRegistrarClub
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim _TE As New tratamientos_especiales
    Dim _Club As New Club
    Dim _BD As New CONEXION_BD
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar


    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click


        If Me._Club.transferir(Me, Club.a_donde.a_la_clase) = Club.estado_transferencia.datosErroneos Then
            Exit Sub
        End If
        If control_estado_grabacion = estado_grabacion.insertar Then
            'Se dispara en el objeto negocio (usuarios) el método de insertar datos
            Me._Club.insertar()
            MsgBox("Se grabó exitosamente")
            'se recarga la grilla
            Me.cargar_grilla()
        End If
        'FormClubes.ClubFutbolTableAdapter.Fill(FormClubes.CampeonatoPavDataSet1.ClubFutbol)

    End Sub

    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormClubes.ClubFutbolDataGridView.DataSource = Me._Club.lista_clubes()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub FormRegistrarClub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me._TE.blanquear_objetos(Me)
        Me.txt_siglas.Focus()
        Me.control_estado_grabacion = estado_grabacion.insertar
    End Sub
End Class