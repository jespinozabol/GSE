'Conformado por Id_Abono, Id_Factura_Proveedor, Fecha, Motivo, Estado, Monto, Num_Abono.
Public Class AbonoFacturaProveedor

    'Lista usada para la propiedad Estado.
    Enum ListaEstado
        Pendiente = 0
        Aplicado = 1
        Anulado = 2
    End Enum

    'Variable autoincrementable que lleva el número de abonos realizados
    Private _varIdAbono As Integer
    Public Property IdAbono() As Integer
        Get
            Return _varIdAbono
        End Get
        Set(ByVal value As Integer)
            _varIdAbono = value
        End Set
    End Property

    'Variable extraída de la tabla FACTURA_PROVEEDOR y que específica a cuál factura pertenece el abono.
    Private _varIdFacturaProveedor As Integer
    Public Property IdFacturaProveedor() As Integer
        Get
            Return _varIdFacturaProveedor
        End Get
        Set(ByVal value As Integer)
            _varIdFacturaProveedor = value
        End Set
    End Property

    'Fecha en la cuál se produjo el abono.
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'El monto en colones que fue abonado a la cuenta o la factura.
    Private _varMonto As Double
    Public Property Monto() As Double
        Get
            Return _varMonto
        End Get
        Set(ByVal value As Double)
            _varMonto = value
        End Set
    End Property

    'Cualquier otra información considerada importante.
    Private _varMotivo As String
    Public Property Motivo() As String
        Get
            Return _varMotivo
        End Get
        Set(ByVal value As String)
            _varMotivo = value
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

    'Número de recibo del proveedor en el que fue hecho el abono.
    Private _varNumAbono As String
    Public Property NumAbono() As String
        Get
            Return _varNumAbono
        End Get
        Set(ByVal value As String)
            _varNumAbono = value
        End Set
    End Property
End Class