Public Class Datos
    Private vnombre As String
    Private vapellido1 As String
    Private vapellido2 As String
    Private videntificacion As Integer

    Public Property nombre As String
        Get
            Return vnombre
        End Get
        Set(value As String)
            vnombre = value
        End Set
    End Property

    Public Property apellido1 As String
        Get
            Return vapellido1
        End Get
        Set(value As String)
            vapellido1 = value
        End Set
    End Property

    Public Property apellido2 As String
        Get
            Return vapellido2
        End Get
        Set(value As String)
            vapellido2 = value
        End Set
    End Property

    Public Property identificacion As Integer
        Get
            Return videntificacion
        End Get
        Set(value As Integer)
            videntificacion = value
        End Set
    End Property
End Class
