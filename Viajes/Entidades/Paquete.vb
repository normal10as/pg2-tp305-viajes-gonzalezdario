Imports Entidades

Public Class Paquete
    Implements Servicio

    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _descripcion As String
    Private _numeroDias As UShort
    Private _numeroPasajeros As UShort
    Private _servicios As List(Of Servicio)


    Sub New(descripcion As String, fecha As Date, fechaFinal As Date)
        Me.Descripcion = descripcion
        Me.FechaInicial = fecha
        Me.FechaFinal = fechaFinal
        _servicios = New List(Of Servicio)
    End Sub

    Public Property Descripcion As String Implements Servicio.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _descripcion = value
            End If
        End Set
    End Property

    Public Property FechaInicial As Date Implements Servicio.FechaInicial
        Get
            Return _fechaInicial
        End Get
        Set(value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property FechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public ReadOnly Property NumeroDias As UShort
        Get
            Return _numeroDias
        End Get
    End Property

    Public ReadOnly Property NumeroPasajeros As UShort
        Get
            Return _numeroPasajeros
        End Get
    End Property

    Public Sub addServicio(servicio As Servicio)
        _servicios.Add(servicio)
    End Sub

    Public Sub removeServicio(servicio As Servicio)
        _servicios.Remove(servicio)
    End Sub

    Public Function getAllServicios() As List(Of Servicio)
        Return _servicios
    End Function

    Public Overrides Function ToString() As String
        Return "AA"
    End Function
End Class
