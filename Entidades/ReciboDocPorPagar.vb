'Contiene: Num_Recibo, Id_Proveedor, Anulado, Monto, Fecha, Concepto, Total_Cheques
' Total_Transferencia, Total_Efectivo, Total_Dolares, Observaciones, Saldo_Actual, Num_Recibo_proveedor.
Public Class ReciboDocPorPagar

    'Lista usada para la propiedad concepto.
    Enum ListaConcepto
        Cancelacion = 1
        CancelacionAbono = 2
        Abono = 3
    End Enum

    'Se declara un constructor para inicializar la lista que tendrán los detalles del recibo.
    Public Sub New()
        ReciboDetalle = New List(Of ReciboDocPorPagarDetalle)
    End Sub

    'Un identificador autoincrementable único para cada recibo.
    Private _varNumRecibo As Integer
    Public Property NumRecibo() As Integer
        Get
            Return _varNumRecibo
        End Get
        Set(ByVal value As Integer)
            _varNumRecibo = value
        End Set
    End Property

    'Variable extraída de la tabla PROVEEDOR y que específica a cual proveedor pertenece el recibo.
    Private _varIdProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _varIdProveedor
        End Get
        Set(ByVal value As Integer)
            _varIdProveedor = value
        End Set
    End Property

    'Especifica si el recibo esta anulado o no.
    Private _varAnulado As Boolean
    Public Property Anulado() As Boolean
        Get
            Return _varAnulado
        End Get
        Set(ByVal value As Boolean)
            _varAnulado = value
        End Set
    End Property

    'Valor monetario que almacena el monto total del recibo.
    Private _varMonto As Double
    Public Property Monto() As Double
        Get
            Return _varMonto
        End Get
        Set(ByVal value As Double)
            _varMonto = value
        End Set
    End Property

    'Fecha en que fue emitido el recibo.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    '1- Cancelacion 2- Cancelacion_Abono 3- Abono
    Private _varConcepto As ListaConcepto
    Public Property Concepto() As ListaConcepto
        Get
            Return _varConcepto
        End Get
        Set(ByVal value As ListaConcepto)
            _varConcepto = value
        End Set
    End Property

    'Valor monetario del total cancelado en cheques.
    Private _varTotalCheques As Double
    Public Property TotalCheques() As Double
        Get
            Return _varTotalCheques
        End Get
        Set(ByVal value As Double)
            _varTotalCheques = value
        End Set
    End Property

    'Valor monetario del total cancelado en transferencias.
    Private _varTotalTransferencias As Double
    Public Property TotalTransferencias() As Double
        Get
            Return _varTotalTransferencias
        End Get
        Set(ByVal value As Double)
            _varTotalTransferencias = value
        End Set
    End Property

    'Valor monetario del total cancelado en efectivo.
    Private _varTotalEfectivo As Double
    Public Property TotalEfectivo() As Double
        Get
            Return _varTotalEfectivo
        End Get
        Set(ByVal value As Double)
            _varTotalEfectivo = value
        End Set
    End Property

    'Valor monetario del total cancelado en dolares.
    Private _varTotalDolares As Double
    Public Property TotalDolares() As Double
        Get
            Return _varTotalDolares
        End Get
        Set(ByVal value As Double)
            _varTotalDolares = value
        End Set
    End Property

    'Cadena que guarda las observaciones del recibo así como los detalles de la forma de pago.
    Private _varObservaciones As String
    Public Property Observaciones() As String
        Get
            Return _varObservaciones
        End Get
        Set(ByVal value As String)
            _varObservaciones = value
        End Set
    End Property

    'Saldo actual del cliente después de haberse realizado el pago.
    Private _varSaldoActual As Double
    Public Property SaldoActual() As Double
        Get
            Return _varSaldoActual
        End Get
        Set(ByVal value As Double)
            _varSaldoActual = value
        End Set
    End Property

    'Número de recibo que emite el proveedor al cancelarle la factura.
    Private _varNumReciboProveedor As String
    Public Property NumReciboProveedor() As String
        Get
            Return _varNumReciboProveedor
        End Get
        Set(ByVal value As String)
            _varNumReciboProveedor = value
        End Set
    End Property

    'Lista que tendrá todos los detalles del recibo.
    Private _varReciboDetalle As List(Of ReciboDocPorPagarDetalle)
    Public Property ReciboDetalle() As List(Of ReciboDocPorPagarDetalle)
        Get
            Return _varReciboDetalle
        End Get
        Set(ByVal value As List(Of ReciboDocPorPagarDetalle))
            _varReciboDetalle = value
        End Set
    End Property

    Private _varFechaReciboProveedor As Date
    Public Property FechaReciboProveedor() As Date
        Get
            Return _varFechaReciboProveedor
        End Get
        Set(ByVal value As Date)
            _varFechaReciboProveedor = value
        End Set
    End Property

End Class