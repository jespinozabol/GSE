'Contiene: Tipo, Dias, Limite, DiasAtraso
Public Class Tipo_Credito

    'Preferencial, Normal, Prueba
    Private varTipo As String
    Public Property Tipo() As String
        Get
            Return varTipo
        End Get
        Set(ByVal value As String)
            varTipo = value
        End Set
    End Property

    'Número de días atrasados que se le permitirá al cliente antes de que el sistema no deje facturar 
    Private varDias As Integer
    Public Property Dias() As Integer
        Get
            Return varDias
        End Get
        Set(ByVal value As Integer)
            varDias = value
        End Set
    End Property

    'Limite máximo de crédito que se le dará al cliente.
    Private varLimite As Double
    Public Property Limite() As Double
        Get
            Return varLimite
        End Get
        Set(ByVal value As Double)
            varLimite = value
        End Set
    End Property

    'Número de días que se le darán al cliente antes de realizar cobro.
    Private varDiasAtraso As Integer
    Public Property DiasAtraso() As Integer
        Get
            Return varDiasAtraso
        End Get
        Set(ByVal value As Integer)
            varDiasAtraso = value
        End Set
    End Property
End Class