'Contiene: Id_PorPagar. Además de todos los atributos que tiene el objeto LineaRecibo.
Public Class LineaReciboDocPorPagar
    Inherits LineaRecibo

    'Variable extraída de la tabla FACTURA_PORPAGAR y que específica a cual factura del proveedor pertenece la linea.
    Private _varIdDoc As String
    Public Property IdDoc() As String
        Get
            Return _varIdDoc
        End Get
        Set(ByVal value As String)
            _varIdDoc = value
        End Set
    End Property
End Class