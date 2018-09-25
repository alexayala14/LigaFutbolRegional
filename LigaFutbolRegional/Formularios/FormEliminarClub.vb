﻿Imports LigaFutbolRegional.FormClubes
Public Class FormEliminarClub
    Dim _Club As New Club



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Me._Club.borrar(txt_id_club.Text())
        Me.cargar_grilla()

    End Sub
    Private Sub cargar_grilla()
        'Subrutina para carga la grilla
        'Se carga al recurso de datos (DataSource) de la grilla con el valor del resultado
        'del procedmiento ejecutado dentro del objeto negocio (usuarios) que es un DataTable
        FormClubes.ClubFutbolDataGridView.DataSource = Me._Club.lista_clubes()
    End Sub

    Private Sub FormEliminarClub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class