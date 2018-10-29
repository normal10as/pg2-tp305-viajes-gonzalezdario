Public Class Entidad
    Private _nombre As String
    Private _domicilio As String

    Sub New(nombre As String, domicilio As String)
        Me.Nombre = nombre
        Me.Domicilio = domicilio
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 50 Then
                _domicilio = value
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _nombre
    End Function
End Class
