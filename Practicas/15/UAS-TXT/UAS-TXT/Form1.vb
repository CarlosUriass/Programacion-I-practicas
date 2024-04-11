Imports System.IO
Public Class Form1
    Dim ARCHIVO As System.IO.StreamWriter
    Dim cadena As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim carrera_str As String

        cadena = ""

        cadena += txtb_nombre.Text & " "  'Agrega el nombre 
        cadena += txtb_primerA.Text & " " 'Agrega el primer apellido
        cadena += txtb_segundoA.Text & " |" 'Agrega el segundo apellido

        carrera_str = carrera()

        cadena += carrera_str & " |"
        cadena += grado_y_grupo() & "|"
        cadena += fecha_nacimiento() & "|"
        cadena += deportes() & "|"

        ListBox1.Items.Add(cadena)

        ARCHIVO.WriteLine(cadena) ' Agrega la cadena al  archivo
        ARCHIVO.Flush()

        limpiar()



    End Sub

    Public Function carrera() As String
        Dim carrera_str As String
        carrera_str = ""

        If rb_civil.Checked = True Then
            carrera_str = "Civil"
        ElseIf rb_geodesia.Checked = True Then
            carrera_str = "Geodesia"
        ElseIf rb_software.Checked = True Then
            carrera_str = "Software"
        End If

        Return carrera_str

    End Function

    Public Function grado_y_grupo() As String
        Dim grado, grupo As String
        Dim grado_grupo As String

        grado = ""
        grupo = ""

        grado_grupo = ""

        grado = txtb_grado.Text
        grupo = Txt_grupo.Text

        grado_grupo = grado & "-" & grupo & " "

        Return grado_grupo

    End Function

    Public Function fecha_nacimiento() As String
        Dim fechaDeNacimiento As String = ""

        fechaDeNacimiento = pick_fecha_nac.Value.Date & " "

        Return fechaDeNacimiento

    End Function

    Public Function deportes() As String
        Dim deportes_str As String
        deportes_str = ""

        If ckb_futbol.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_basketbol.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_voleibol.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_natacion.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_ciclismo.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_box.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_tenis.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_beisbol.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If

        If ckb_otro.Checked Then
            deportes_str += "S"
        Else
            deportes_str += "N"
        End If


        Return deportes_str

    End Function

    Public Function limpiar()
        txtb_primerA.Clear()
        txtb_segundoA.Clear()
        txtb_nombre.Clear()
        txtb_grado.Clear()
        Txt_grupo.Clear()

        rb_civil.Checked = False
        rb_geodesia.Checked = False
        rb_software.Checked = False

        ckb_futbol.Checked = False
        ckb_basketbol.Checked = False
        ckb_voleibol.Checked = False
        ckb_natacion.Checked = False
        ckb_box.Checked = False
        ckb_beisbol.Checked = False
        ckb_ciclismo.Checked = False
        ckb_tenis.Checked = False
        ckb_otro.Checked = False

        pick_fecha_nac.Value = Date.Today

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Beep()
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\FIM-CC3\Desktop\Padron alumnos\alumnos.txt", True)
    End Sub
End Class
