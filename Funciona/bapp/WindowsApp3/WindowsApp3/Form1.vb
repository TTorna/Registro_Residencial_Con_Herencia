Public Class Form1
    Dim contador As Integer = 0
    Dim VectorPersonas(contador) As Persona
    Dim respuesta As String
    Dim vectorDatos(0) As String
    Dim posicion As String

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        LBMostrar.Items.Clear()
        For t = 0 To contador - 1 Step 1
            LBMostrar.Items.Add(VectorPersonas(t).Datos())
        Next
        Console.ReadLine()
    End Sub

    Private Sub s_Click(sender As Object, e As EventArgs)
        VectorPersonas(contador) = New Persona(txtApellido.Text, txtNombre.Text, txtDocumento.Text)
        contador += 1

        ReDim Preserve VectorPersonas(contador)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBPersona.CheckedChanged
        Persona.Visible = True 'Not Persona.Visible
        Estudiante.Visible = False
        Residente.Visible = False
        Profesor.Visible = False
    End Sub

    Private Sub RBAlumno_CheckedChanged(sender As Object, e As EventArgs) Handles RBAlumno.CheckedChanged
        Estudiante.Visible = True 'Not Estudiante.Visible
        Persona.Visible = True
        Residente.Visible = False
        Profesor.Visible = False
    End Sub

    Private Sub RBResidente_CheckedChanged(sender As Object, e As EventArgs) Handles RBResidente.CheckedChanged
        Residente.Visible = True 'Not Residente.Visible
        Persona.Visible = True
        Estudiante.Visible = True
        Profesor.Visible = False
    End Sub

    Private Sub RBProfesor_CheckedChanged(sender As Object, e As EventArgs) Handles RBProfesor.CheckedChanged
        Profesor.Visible = True 'Not Profesor.Visible
        Persona.Visible = True
        Residente.Visible = False
        Estudiante.Visible = False
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If RBProfesor.Checked Then
            VectorPersonas(contador) = New Profesor(txtApellido.Text, txtNombre.Text, txtDocumento.Text, txtCurso1.Text, txtCurso2.Text, txtCurso3.Text)
        Else
            If RBAlumno.Checked Then
                VectorPersonas(contador) = New Alumno(txtApellido.Text, txtNombre.Text, txtDocumento.Text, txtMateria1.Text, txtMateria2.Text, TxtMateria3.Text, txtMateria4.Text, txtMateria5.Text)
            Else
                If RBResidente.Checked Then
                    VectorPersonas(contador) = New Residente(txtApellido.Text, txtNombre.Text, txtDocumento.Text, txtMateria1.Text, txtMateria2.Text, TxtMateria3.Text, txtMateria4.Text, txtMateria5.Text, txtHospital.Text, txtArea.Text)

                Else
                    VectorPersonas(contador) = New Persona(txtApellido.Text, txtNombre.Text, txtDocumento.Text)
                End If
            End If
        End If
        contador += 1
        ReDim Preserve VectorPersonas(contador)
    End Sub

    Private Sub BttInforme_Click(sender As Object, e As EventArgs) Handles BttInforme.Click
        Dim AuxPe As Integer = 0
        Dim AuxPr As Integer = 0
        Dim AuxR As Integer = 0
        Dim AuxA As Integer = 0
        Dim PromedioGeneralA As Single = 0
        Dim PromedioGeneralR As Single = 0

        For s = 0 To contador - 1 Step 1
            If VectorPersonas(s).Identificador() = 0 Then
                AuxPe += +1
            Else
                If VectorPersonas(s).Identificador() = 1 Then
                    AuxA += +1
                    PromedioGeneralA += VectorPersonas(s).promedio()
                Else
                    If VectorPersonas(s).Identificador() = 2 Then
                        AuxR += +1
                        PromedioGeneralR += VectorPersonas(s).promedio()
                    Else
                        If VectorPersonas(s).Identificador() = 3 Then
                            AuxPr += +1
                        End If
                    End If
                End If
            End If
        Next

        MsgBox("Hay " + Str(AuxPe) + " Persona" + vbCrLf + "Hay " + Str(AuxA) + " Alumno/s" + vbCrLf + "Hay " + Str(AuxR) + " Residentes" + vbCrLf + "Hay " + Str(AuxPr) + " Profesor/es" + vbCrLf)

        MsgBox("El promedio general de alumnos es: " + Str(PromedioGeneralA) + vbCrLf + "El promedio general de residentes es: " + Str(PromedioGeneralR))

    End Sub

    Private Sub BttCargar_Click(sender As Object, e As EventArgs) Handles BttCargar.Click
        Dim archivo As String
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Archivos de texto (*.txt)|*.TXT"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            archivo = OpenFileDialog1.FileName
        End If
        Dim a_objetos As New System.IO.StreamWriter(archivo)
        For k = 0 To contador - 1 Step 1
            a_objetos.WriteLine(VectorPersonas(k).Identificador())
            a_objetos.WriteLine(VectorPersonas(k).Grabar())
        Next
        a_objetos.close()
    End Sub

    Private Sub BttLeer_Click(sender As Object, e As EventArgs) Handles BttLeer.Click
        Dim archivo As String
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Archivos de texto (*.txt)|*.TXT"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            archivo = OpenFileDialog1.FileName
        End If
        Dim a_objetos As New System.IO.StreamReader(archivo)

        While a_objetos.Peek() <> -1
            posicion = a_objetos.ReadLine()
            If posicion = "0" Then
                ReDim Preserve vectorDatos(2)
                For k = 0 To 2
                    vectorDatos(k) = a_objetos.ReadLine()
                Next
                VectorPersonas(contador) = New Persona(vectorDatos(0), vectorDatos(1), vectorDatos(2))
                contador += 1
                ReDim Preserve VectorPersonas(contador)
            End If
            If posicion = "1" Then
                ReDim Preserve vectorDatos(7)
                For k = 0 To 7
                    vectorDatos(k) = a_objetos.ReadLine()
                Next
                VectorPersonas(contador) = New Alumno(vectorDatos(0), vectorDatos(1), vectorDatos(2), vectorDatos(3), vectorDatos(4), vectorDatos(5), vectorDatos(6), vectorDatos(7))
                contador += 1
                ReDim Preserve VectorPersonas(contador)
            End If
            If posicion = "2" Then
                ReDim Preserve vectorDatos(9)
                For k = 0 To 9
                    vectorDatos(k) = a_objetos.ReadLine()
                Next
                VectorPersonas(contador) = New Residente(vectorDatos(0), vectorDatos(1), vectorDatos(2), vectorDatos(3), vectorDatos(4), vectorDatos(5), vectorDatos(6), vectorDatos(7), vectorDatos(8), vectorDatos(9))
                contador += 1
                ReDim Preserve VectorPersonas(contador)
            End If
            If posicion = "3" Then
                ReDim Preserve vectorDatos(5)
                For k = 0 To 5
                    vectorDatos(k) = a_objetos.ReadLine()
                Next
                VectorPersonas(contador) = New Profesor(vectorDatos(0), vectorDatos(1), vectorDatos(2), vectorDatos(3), vectorDatos(4), vectorDatos(5))
                contador += 1
                ReDim Preserve VectorPersonas(contador)
            End If
        End While
        a_objetos.Close()
    End Sub
End Class
