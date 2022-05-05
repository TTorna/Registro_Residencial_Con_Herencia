Public Class Residente
    Inherits Alumno
    Private _hospital As String
    Private _area As String
    Public Sub New(apell As String, nom As String, dn As String, mate1 As Single, mate2 As Single, mate3 As Single, mate4 As Single, mate5 As Single, hospi As String, area_ As String)
        MyBase.New(apell, nom, dn, mate1, mate2, mate3, mate4, mate5)
        hospital = hospi
        area_ = area


    End Sub


    Public Property hospital As String
        Get
            Return _hospital
        End Get
        Set(value As String)
            _hospital = value
        End Set
    End Property
    Public Property area As String
        Get
            Return _area
        End Get
        Set(value As String)
            _area = value
        End Set
    End Property

    Public Overrides Function Datos() As String
        Return MyBase.Datos() + " " + hospital + " " + area
    End Function

    Public Overrides Function Identificador() As Integer
        Return MyBase.Identificador() + 1
    End Function

    Public Overrides Function promedio() As Single
        Return ((materia1 + materia2 + materia3 + materia4 + materia5) / 5)
    End Function

    Public Overrides Function Grabar() As String
        Return (MyBase.Grabar() + hospital + vbCrLf + area + vbCrLf)
    End Function

    Public Overloads Function leer(mat1 As Single, mat2 As Single, mat3 As Single, mat4 As Single, mat5 As Single, cur1 As Single, cur2 As Single, cur3 As Single, Ho As String, Ar As String) As String
        hospital = Ho
        area = Ar
        Return 0
    End Function

End Class
