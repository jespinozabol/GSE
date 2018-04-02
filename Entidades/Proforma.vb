'Contiene: Num_Proforma, Cliente, Fecha, Id_Referencia, Telefono
Public Class Proforma

    'Se declara un constructor para inicializar la lista que tendrá todas las líneas de productos de la proforma.
    Public Sub New()
        ProformaDetalles = New List(Of ProformaDetalle)
    End Sub

    'Un identificador único para cada proforma, será extraído de la tabla CONSECUTIVO_PROFORMA
    Private _varNumProforma As Integer
    Public Property NumProforma() As Integer
        Get
            Return _varNumProforma
        End Get
        Set(ByVal value As Integer)
            _varNumProforma = value
        End Set
    End Property

    'El nombre del cliente que solicita la proforma.
    Private _varNombreCliente As String
    Public Property Cliente() As String
        Get
            Return _varNombreCliente
        End Get
        Set(ByVal value As String)
            _varNombreCliente = value
        End Set
    End Property

    'La fecha en que fue creada la proforma.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Variable extraída de la tabla REFERENCIA y que específica la referencia de la factura en el caso de que tenga.
    Private _varIdReferencia As Integer
    Public Property IdReferencia() As Integer
        Get
            Return _varIdReferencia
        End Get
        Set(ByVal value As Integer)
            _varIdReferencia = value
        End Set
    End Property

    'Un teléfono del cual se podra localizar al cliente.
    Private _varTelefono As String
    Public Property Telefono() As String
        Get
            Return _varTelefono
        End Get
        Set(ByVal value As String)
            _varTelefono = value
        End Set
    End Property

    'Una lista que guarda todas las líneas con los productos que fueron consultados.
    Private _varProformaDetalles As List(Of ProformaDetalle)
    Public Property ProformaDetalles() As List(Of ProformaDetalle)
        Get
            Return _varProformaDetalles
        End Get
        Set(ByVal value As List(Of ProformaDetalle))
            _varProformaDetalles = value
        End Set
    End Property
End Class