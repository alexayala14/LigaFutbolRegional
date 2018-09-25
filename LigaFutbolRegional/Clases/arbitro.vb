Public Class Arbitro
    Dim _BD As New CONEXION_BD
    'Función para recuparar la lista de Arbitros
    Public Function lista_arbitros() As DataTable
        'Se utiliza el objeto _BD (instancia CONEXION_DB), la función leo tabla que devuelve un DataTable
        Return _BD.leo_tabla("SELECT * FROM Arbitro")
    End Function
End Class
