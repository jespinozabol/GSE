Imports MySql.Data.MySqlClient

<Serializable()>
Public Class Conexion

    ' Private oConexion As SqlConnection 'Usada para conectarse a la BD
    Private ReadOnly _oConexion As MySqlConnection

    'Construtor se inicializa la variable conexion
    Public Sub New()
        'Utilizado para conectarse con una instancia de MySQL
        'Cadena de conexion que contiene el nombre del servidor, usuario, contraseña, nombre base de datos y el puerto.
        _oConexion = New MySqlConnection("server=localhost;user=root;password=Soluciones;database=gse;port=3306")
    End Sub

    'Se abre la conexion a la BD
    Public Sub AbrirConexion()
        If _oConexion.State = ConnectionState.Closed Then
            _oConexion.Open()
        End If
    End Sub

    'Se cierra la conexion a la BD
    Public Sub CerrarConexion()
        If _oConexion.State = ConnectionState.Open Then
            _oConexion.Close()
        End If
    End Sub

    'Se crea la propiedad de Conexion
    Public ReadOnly Property Conexion() As MySqlConnection
        Get
            Return _oConexion
        End Get
    End Property
End Class