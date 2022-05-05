Public Class Alumno
    Inherits Persona
    Private _materia1 As Single
    Private _materia2 As Single
    Private _materia3 As Single
    Private _materia4 As Single
    Private _materia5 As Single

    Public Sub New(apell As String, nom As String, dn As String, mate1 As Single, mate2 As Single, mate3 As Single, mate4 As Single, mate5 As Single)
        MyBase.New(apell, nom, dn)

        materia1 = mate1
        materia2 = mate2
        materia3 = mate3
        materia4 = mate4
        materia5 = mate5

    End Sub

    Public Property materia1 As Single
        Get
            Return _materia1
        End Get
        Set(value As Single)
            _materia1 = value
        End Set
    End Property
    Public Property materia5 As Single
        Get
            Return _materia5
        End Get
        Set(value As Single)
            _materia5 = value
        End Set
    End Property
    Public Property materia2 As Single
        Get
            Return _materia2
        End Get
        Set(value As Single)
            _materia2 = value
        End Set
    End Property
    Public Property materia3 As Single
        Get
            Return _materia3
        End Get
        Set(value As Single)
            _materia3 = value
        End Set
    End Property
    Public Property materia4 As Single
        Get
            Return _materia4
        End Get
        Set(value As Single)
            _materia4 = value
        End Set
    End Property

    Public Overrides Function Datos() As String
        Return MyBase.Datos() + " " + Str(materia1) + " " + Str(materia2) + " " + Str(materia3) + " " + Str(materia4) + " " + Str(materia5)
    End Function

    Public Overrides Function Identificador() As Integer
        Return MyBase.Identificador() + 1
    End Function

    Public Overrides Function promedio() As Single
        Return ((materia1 + materia2 + materia3 + materia4 + materia5) / 5)
    End Function

    Public Overrides Function Grabar() As String
        Return (MyBase.Grabar() + materia1 + vbCrLf + materia2 + vbCrLf + materia3 + vbCrLf + materia4 + vbCrLf + materia5 + vbCrLf)
    End Function
    Public Overloads Function leerAlumno(mat1 As Single, mat2 As Single, mat3 As Single, mat4 As Single, mat5 As Single, Ho As String, Ar As String) As String
        materia1 = mat1
        materia2 = mat2
        materia3 = mat3
        materia4 = mat4
        materia5 = mat5
        Return 0
    End Function
End Class
