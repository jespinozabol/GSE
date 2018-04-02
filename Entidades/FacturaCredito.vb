'Continene: Monto, Num_Dias, Id_Credito, Fecha, Estado.  Además los atributos del objeto Factura.
Public Class FacturaCredito
    Inherits Factura

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        Pendiente = 0
        Aplicada = 1
        Anulada = 2
    End Enum

    'Se declara un constructor para inicializar la lista que tendrá todos los abonos y las notas de crédito realizados a esa factura.
    Public Sub New()
        Abonos = New List(Of Abono)
        NotasCredito = New List(Of NotaCredito)
    End Sub

    'El monto total de la factura.
    Private _varMonto As Double
    Public Property Monto() As Double
        Get
            Return _varMonto
        End Get
        Set(ByVal value As Double)
            _varMonto = value
        End Set
    End Property

    'El número de días que tiene de vigencia esa factura.
    Private _varNumDias As Integer
    Public Property NumDias() As Integer
        Get
            Return _varNumDias
        End Get
        Set(ByVal value As Integer)
            _varNumDias = value
        End Set
    End Property

    'Variable extraída de la tabla CLIENTE_CREDITO y que específica al crédito a el cuál fue facturado. 
    Private _varIdCredito As Integer
    Public Property IdCredito() As Integer
        Get
            Return _varIdCredito
        End Get
        Set(ByVal value As Integer)
            _varIdCredito = value
        End Set
    End Property

    'Una lista que contiene todos los abonos hechos a la factura.
    Private _varAbonos As List(Of Abono)
    Public Property Abonos() As List(Of Abono)
        Get
            Return _varAbonos
        End Get
        Set(ByVal value As List(Of Abono))
            _varAbonos = value
        End Set
    End Property

    'Una lista que contiene todos las notas de crédito hechas a la factura.
    Private _varNotasCredito As List(Of NotaCredito)
    Public Property NotasCredito() As List(Of NotaCredito)
        Get
            Return _varNotasCredito
        End Get
        Set(ByVal value As List(Of NotaCredito))
            _varNotasCredito = value
        End Set
    End Property

    '0- Pendiente 1- Aplicado 2- Anulado
    Private _varEstado As ListaEstado
    Public Property Estado() As ListaEstado
        Get
            Return _varEstado
        End Get
        Set(ByVal value As ListaEstado)
            _varEstado = value
        End Set
    End Property
End Class
