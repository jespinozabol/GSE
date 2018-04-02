'Contiene: Tipo, Num_Recibo, Doc, Fecha, Monto, Id_DocPorPagar
Public Class ReciboDocPorPagarDetalle

    'Lista usada para la propiedad Tipo.
    Enum ListaTipo
        Cancelacion = 1
        FactAbono = 2
        Abono = 3
        NotaCredito = 4
        NotaDebito = 5
        NotaCreditoGeneral = 6
    End Enum

    '1-Cancelacion 2-Fact_Abono, 3-Abono, 4-Nota_Credito, 5-Nota_Debito, 6-Nota_Credito_General
    Private _varTipo As ListaTipo
    Public Property Tipo() As ListaTipo
        Get
            Return _varTipo
        End Get
        Set(ByVal value As ListaTipo)
            _varTipo = value
        End Set
    End Property

    'Variable extraída de la tabla RECIBODOCPORPAGAR_ENCABEZADO y que específica a cual recibo pertenece la linea de detalle.
    Private _varNumRecibo As Integer
    Public Property NumRecibo() As Integer
        Get
            Return _varNumRecibo
        End Get
        Set(ByVal value As Integer)
            _varNumRecibo = value
        End Set
    End Property

    'Específica el Id segun el tipo de documento.
    Private _varIdDoc As Integer
    Public Property IdDoc() As Integer
        Get
            Return _varIdDoc
        End Get
        Set(ByVal value As Integer)
            _varIdDoc = value
        End Set
    End Property
End Class