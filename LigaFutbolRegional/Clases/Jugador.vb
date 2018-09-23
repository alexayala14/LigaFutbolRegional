Public Class Jugador
    Dim _BD As New CONEXION_BD
    'Función para recuperar la lista de Jugadores
    Public Function lista_jugadores() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM Jugador")
    End Function
End Class
