Public Class Profesor
    Inherits Persona

    Private _curso1 As String
    Private _curso2 As String
    Private _curso3 As String
    Public Sub New(apell As String, nom As String, dn As String, cur1 As String, cur2 As String, cur3 As String)
        MyBase.New(apell, nom, dn)
        curso1 = cur1
        curso2 = cur2
        curso3 = cur3

    End Sub

    Public Property curso1 As String
        Get
            Return _curso1
        End Get
        Set(value As String)
            _curso1 = value
        End Set
    End Property
    Public Property curso2 As String
        Get
            Return _curso2
        End Get
        Set(value As String)
            _curso2 = value
        End Set
    End Property
    Public Property curso3 As String
        Get
            Return _curso3
        End Get
        Set(value As String)
            _curso3 = value
        End Set
    End Property

    Public Overrides Function Datos() As String
        Return MyBase.Datos() + " " + curso1 + " " + curso2 + " " + curso3
    End Function

    Public Overrides Function Identificador() As Integer
        Return MyBase.Identificador() + 3
    End Function

    Public Overrides Function Grabar() As String
        Return (MyBase.Grabar() + curso1 + vbCrLf + curso2 + vbCrLf + curso3 + vbCrLf)
    End Function

    Public Overloads Function leer(mat1 As Single, mat2 As Single, mat3 As Single, mat4 As Single, mat5 As Single, cur1 As Single, cur2 As Single, cur3 As Single, Ho As String, Ar As String) As String
        curso1 = cur1
        curso2 = cur2
        curso3 = cur3
        Return 0
    End Function

End Class
