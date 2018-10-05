﻿Public Class ComboBox_01
    Inherits ComboBox
    Public Property validable As Boolean
    Public Property nombre_tabla As String
    Public Property nombre_campo As String

    Public Sub cargar(ByVal tabla As DataTable)
        Me.DataSource = tabla
    End Sub
    Public Sub cargar(ByVal tabla As DataTable _
                      , ByVal pk As String _
                      , ByVal descripcion As String)
        Me.DataSource = tabla
        Me.DisplayMember = descripcion
        Me.ValueMember = pk
    End Sub
    Public Sub cargar(ByVal tabla As DataTable, ByVal pk1 As String, ByVal pk2 As String, ByVal descripcion As String)
        Me.DataSource = tabla
        Me.DisplayMember = descripcion
        Me.ValueMember = pk1 & pk2
    End Sub
End Class