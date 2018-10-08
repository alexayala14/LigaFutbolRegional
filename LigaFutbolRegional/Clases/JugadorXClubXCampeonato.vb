Public Class JugadorXClubXCampeonato

    Dim _BD As New CONEXION_BD



    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Inscripcion ("


        Me._BD.INS_MOD_BOR(sql)
    End Sub





End Class
