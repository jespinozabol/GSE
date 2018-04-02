'Contiene: Id_Referencia, Activo, Ultimo_Calculo. Además tiene los atributos del objeto Persona.
Public Class Referencia
    Inherits Persona

    'Identificador único para cada referencia que se crea.
    Private _varIdReferencia As Integer
    Public Property IdReferencia() As Integer
        Get
            Return _varIdReferencia
        End Get
        Set(ByVal value As Integer)
            _varIdReferencia = value
        End Set
    End Property

    'Si la referencia está activa o no.
    Private _varActivo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _varActivo
        End Get
        Set(ByVal value As Boolean)
            _varActivo = value
        End Set
    End Property

    'Guarda la fecha de la última vez que se realizó el calculo de referencia.
    Private _varUltimoCalculo As Date
    Public Property UltimoCalculo() As Date
        Get
            Return _varUltimoCalculo
        End Get
        Set(ByVal value As Date)
            _varUltimoCalculo = value
        End Set
    End Property
End Class