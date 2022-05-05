Public Class Persona
    Private _Apellido As String
    Private _nombre As String
    Private _dni As String
    Private _id As Integer
    Private Shared primerID As Integer = 44

    Public Sub New(apell As String, nom As String, dn As String)
        apellido = apell
        nombre = nom
        dni = dn
        _id = primerID
        primerID += 2
    End Sub

    Public ReadOnly Property id As Integer
        Get
            Return _ID
        End Get
    End Property

    Public Property apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Overridable Function Datos() As String
        Return Str(_id) + " " + Left(nombre, 15) + " " + Left(apellido, 15)
    End Function

    Public Overridable Function Identificador() As Integer
        Return 0
    End Function

    Public Overridable Function promedio() As Single
        Return 0
    End Function

    Public Overridable Function Grabar() As String
        Return (apellido + vbCrLf + nombre + vbCrLf + dni + vbCrLf)
    End Function

    Public Overridable Function leerAlumno(mat1 As Single, mat2 As Single, mat3 As Single, mat4 As Single, mat5 As Single, Ho As String, Ar As String) As String
        Return 0
    End Function

    Public Overridable Function leerProfesor(cur1 As Single, cur2 As Single, cur3 As Single) As String
        Return 0
    End Function
End Class
