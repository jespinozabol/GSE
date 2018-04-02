'Continene: Fecha, Efectivo, Cheques, Transferencia, Tarjeta, Dolares_Colones,
' Redondeo, Vales, Ingresos_Creditos, Vuelto.
Public Class FlujoCaja

    'Guarda la fecha del flujo de caja, se almacenará solo un flujo de caja al día
    Private _varFecha As Date
    Public Property Fecha() As Date
        Get
            Return _varFecha
        End Get
        Set(ByVal value As Date)
            _varFecha = value
        End Set
    End Property

    'Valor monetario que especifíca el total en efectivo recogido en un día.
    Private _varEfectivo As Double
    Public Property Efectivo() As Double
        Get
            Return _varEfectivo
        End Get
        Set(ByVal value As Double)
            _varEfectivo = value
        End Set
    End Property

    'Valor monetario que especifíca el total en cheques recogido en un día.
    Private _varCheques As Double
    Public Property Cheques() As Double
        Get
            Return _varCheques
        End Get
        Set(ByVal value As Double)
            _varCheques = value
        End Set
    End Property

    'Valor monetario que especifíca el total en transferencias recogido en un día.
    Private _varTransferencia As Double
    Public Property Transferencia() As Double
        Get
            Return _varTransferencia
        End Get
        Set(ByVal value As Double)
            _varTransferencia = value
        End Set
    End Property

    'Valor monetario que especifíca el total en tarjetas recogido en un día.
    Private _varTarjeta As Double
    Public Property Tarjeta() As Double
        Get
            Return _varTarjeta
        End Get
        Set(ByVal value As Double)
            _varTarjeta = value
        End Set
    End Property

    'Valor monetario que especifíca el total en dolares recogido en un día.
    Private _varEquiDolaresColones As Double
    Public Property DolaresColones() As Double
        Get
            Return _varEquiDolaresColones
        End Get
        Set(ByVal value As Double)
            _varEquiDolaresColones = value
        End Set
    End Property

    'Valor monetario que especifíca el monto sobrante de los redondeos. Puede ser positivo o negativo.
    Private _varRedondeo As Double
    Public Property Redondeo() As Double
        Get
            Return _varRedondeo
        End Get
        Set(ByVal value As Double)
            _varRedondeo = value
        End Set
    End Property

    'Valor monetario que especifíca el total de los vales que se han retirado de la caja.
    Private _varVales As Double
    Public Property Vale() As Double
        Get
            Return _varVales
        End Get
        Set(ByVal value As Double)
            _varVales = value
        End Set
    End Property

    'Valor monetario que especifíca el total que se ha recodigo por facturas de crédito.
    Private _varCreditos As Double
    Public Property Creditos() As Double
        Get
            Return _varCreditos
        End Get
        Set(ByVal value As Double)
            _varCreditos = value
        End Set
    End Property

    ''Valor monetario que especifíca el total de los vueltos que se han entregado a los clientes. 
    Private _varVuelto As Double
    Public Property Vuelto() As Double
        Get
            Return _varVuelto
        End Get
        Set(ByVal value As Double)
            _varVuelto = value
        End Set
    End Property
End Class