Public Class campeonato
    Dim _BD As New CONEXION_BD
    'Función para recuperar la lista de campeonatos
    Public Function lista_campeonatos() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM Campeonato")
    End Function

End Class
