Public Class inscripcion
    Enum estado_validar
        encontrado
        no_encontrado
    End Enum
    Enum estado_transferencia
        datosErroneos
        ok
    End Enum
    Enum a_donde
        a_la_clase
        al_front_end
    End Enum

    Dim _BD As New CONEXION_BD

    Public Property id_campeonato As Integer
    Public Property anio_campeonato As Integer
    Public Property id_club As Integer
    Public Property estado As Integer
    Public Property fechaInscripcion As String
    Public Property FechaCierre As String

    Public Function transferir(ByRef controles As Object, ByVal a_donde_transferior As a_donde) As estado_transferencia
        If a_donde_transferior = a_donde.a_la_clase Then
            Return transferir_a_la_clase(controles)
        Else
            Return transferir_al_front_end(controles)
        End If
    End Function




    Private Function transferir_al_front_end(ByRef controles As Object) As estado_transferencia

        For Each obj In controles.Controls

            If obj.GetType().Name = "ComboBox_01" Then
                Select Case obj.nombre_campo
                    Case "fechaInscripcion"
                        obj.Text = _fechaInscripcion
                    Case "fechaCierre"

                        'obj.date("MM/dd/yyyy") = _FechaCierre

                        obj.Text = _FechaCierre

                End Select
            End If
            If obj.GetType().Name = "ComboBox_01" Then
                Select Case obj.nombre_campo
                    Case "id_campeonato"
                        obj.SelectedValue = _id_campeonato
                    Case "anio_campeonato"
                        obj.SelectedValue = _anio_campeonato
                    Case "id_club"
                        obj.SelectedValue = _id_club
                    Case "estado"
                        obj.SelectedValue = _estado
                End Select
            End If
        Next
        Return estado_transferencia.ok
    End Function

    Private Function transferir_a_la_clase(ByRef controles As Object) As estado_transferencia
        For Each obj In controles.Controls

            If obj.GetType().Name = "MaskedTextBox_01" Then
                If obj.validable = True Then
                    If obj.text = "" Then
                        'mensaje de error encontrad sobre el objeto
                        MsgBox("el " & obj.nombre_campo & " está vacío")
                        'se enfoca el cursor en el objeto
                        obj.Focus()
                        'se devuelve la condicione de datoErroneo
                        Return estado_transferencia.datosErroneos
                    End If
                End If

                Select Case obj.nombre_campo

                    Case "fechaInscripcion"
                        _fechaInscripcion = obj.Text
                    Case "fechaCierre"
                        _FechaCierre = obj.Text

                    Case "anio_campeonato"
                        _anio_campeonato = obj.Text



                End Select
            End If
            'Para ComboBox_01 se aplica la misma mecánica que para MaskedTextBox_01
            If obj.GetType().Name = "ComboBox_01" Then
                If obj.validable = True Then
                    If obj.SelectedIndex = -1 Then
                        MsgBox("el " & obj.nombre_campo & " está sin selección")
                        obj.Focus()
                        Return estado_transferencia.datosErroneos
                    End If
                End If
                Select Case obj.nombre_campo
                    Case "id_campeonato"
                        _id_campeonato = obj.SelectedValue

                    Case "id_club"
                        _id_club = obj.SelectedValue
                    Case "estado"
                        _estado = obj.SelectedValue
                End Select
            End If
        Next
        Return estado_transferencia.ok
    End Function

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Inscripcion ("

        sql &= "id_campeonato"
        sql &= ",anio_campeonato"
        sql &= ",id_club"
        sql &= ",estado"
        sql &= ",fechaInscripcion"
        sql &= ",fechaCierre"
        sql &= ") VALUES ("

        sql &= "" & _id_campeonato & ""
        sql &= "," & _anio_campeonato & ""
        sql &= "," & _id_club & ""
        sql &= "," & _estado & ""
        sql &= ",'" & _fechaInscripcion & "'"
        sql &= ",'" & _FechaCierre & "'"
        sql &= ")"
        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub borrar(ByVal id_club As Integer)
        Me._BD.INS_MOD_BOR("DELETE FROM Inscripcion WHERE id_club = " & id_club)

    End Sub
    Public Sub modificar(ByVal id_club As Integer)
        Dim sql As String = ""
        sql = "UPDATE Inscripcion "
        sql &= "SET estado =" & _estado & ""

        sql &= "WHERE id_club = " & id_club
        Me._BD.INS_MOD_BOR(sql)
    End Sub

    Public Function lista_inscriptos() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM Inscripcion")
    End Function
End Class
