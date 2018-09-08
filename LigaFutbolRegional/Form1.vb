﻿Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm1.Show()
        Me.Close()

    End Sub

    Private Sub cmdCampeonatos_Click(sender As Object, e As EventArgs) Handles cmdCampeonatos.Click
        If PanelCampeonatos.Visible = True Then
            PanelCampeonatos.Visible = False
        Else
            PanelCampeonatos.Visible = True
        End If

        cmdCampeonatos.Location = New Point(3, 3)
        PanelCampeonatos.Location = New Point(3, 154)
        cmdClub.Location = New Point(3, 155)
        cmdJugador.Location = New Point(3, 193)
        cmdArbitro.Location = New Point(3, 231)
        cmdFP.Location = New Point(3, 269)
        cmdRE.Location = New Point(3, 307)

        If PanelCampeonatos.Visible = False Then
            cmdCampeonatos.Location = New Point(3, 3)
            cmdClub.Location = New Point(3, 41)
            cmdJugador.Location = New Point(3, 79)
            cmdArbitro.Location = New Point(3, 117)
            cmdFP.Location = New Point(3, 155)
            cmdRE.Location = New Point(3, 193)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdCampeonatos.Location = New Point(3, 3)
        cmdClub.Location = New Point(3, 41)
        cmdJugador.Location = New Point(3, 79)
        cmdArbitro.Location = New Point(3, 117)
        cmdFP.Location = New Point(3, 155)
        cmdRE.Location = New Point(3, 193)
        PanelCampeonatos.Hide()
    End Sub

    Private Sub cmdClub_Click(sender As Object, e As EventArgs) Handles cmdClub.Click
        FormClubes.Show()
    End Sub

    Private Sub cmdJugador_Click(sender As Object, e As EventArgs) Handles cmdJugador.Click
        FormJugadores.Show()


    End Sub

    Private Sub cmdArbitro_Click(sender As Object, e As EventArgs) Handles cmdArbitro.Click
        FormArbitros.Show()


    End Sub


End Class
