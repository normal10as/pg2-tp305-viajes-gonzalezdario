Public Class Pasajero
    Inherits Entidad
    Implements IPasajero

    Private _pasaporte As UInteger
    Private _dni As UInteger
    Private _fechaNacimiento As Date

    Sub New(dni As UInteger, nombre As String, domicilio As String, fecha As Date)
        MyBase.New(nombre, domicilio)
        Me.DNI = dni
        Me.FechaNacimiento = fecha
    End Sub

    Sub New(dni As UInteger, nombre As String, domicilio As String, fecha As Date, pasaporte As UInteger)
        MyBase.New(nombre, domicilio)
        Me.DNI = dni
        Me.FechaNacimiento = fecha
        Me.Pasaporte = pasaporte
    End Sub

    Public Property Pasaporte As UInteger Implements IPasajero.Pasaporte
        Get
            Return _pasaporte
        End Get
        Set(value As UInteger)
            _pasaporte = value
        End Set
    End Property

    Public Property DNI As UInteger Implements IPasajero.DNI
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property

    Public Property FechaNacimiento As Date Implements IPasajero.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property
End Class
