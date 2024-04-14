Imports System.IO
Imports Reportes_recargas.numeros_txt
Imports System.Numerics

Public Class Form1
    Dim contador As Long = 0
    Dim objReader As New StreamReader("C:\Users\Carlos Urias\Desktop\recargas\resultados.txt") 'Agregar ruta donde se cargará el archivo
    Dim Sline As String
    Dim array_texto As New ArrayList()



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ciclo para cargar el archivo en un array

        Do
            Sline = objReader.ReadLine()
            If Not Sline Is Nothing Then
                array_texto.Add(Sline)
                ListBox1.Items.Add(Sline)
            End If
        Loop Until Sline Is Nothing

    End Sub

    Private Sub btn_x_fecha_Click(sender As Object, e As EventArgs) Handles btn_x_fecha.Click
        Dim fecha As String = ""
        ListBox1.Items.Clear()
        fecha = obtener_fecha()
        recorrer_vector(1, 10, fecha)

    End Sub

    Public Function obtener_fecha() As String
        Dim fecha As String
        fecha = DateTimePicker1.Value.Date

        Return fecha
    End Function

    Public Function recorrer_vector(posicion1, posicion2, valor) As String
        Dim acumulador_dinero As Integer = 0
        Dim t, m, a, u, p As Integer
        Dim compania As String
        For i As Integer = 0 To array_texto.Count - 1

            compania = Mid(array_texto(i), 23, 1)

            If Mid(array_texto(i), posicion1, posicion2) = valor Then
                acumulador_dinero += Val(Mid(array_texto(i), 25, 3))
                ListBox1.Items.Add("Fecha: " & Mid(array_texto(i), 1, 10) & " " & "Compañia: " & compañia(Mid(array_texto(i), 23, 1)) & " " & "Numero telefonico: " & Mid(array_texto(i), 12, 10) & " " & "recarga por $" & Mid(array_texto(i), 25, 3))

                Select Case compania
                    Case "T"
                        t += Val(Mid(array_texto(i), 25, 3))
                    Case "M"
                        m += Val(Mid(array_texto(i), 25, 3))
                    Case "A"
                        a += Val(Mid(array_texto(i), 25, 3))
                    Case "U"
                        u += Val(Mid(array_texto(i), 25, 3))
                    Case "P"
                        p += Val(Mid(array_texto(i), 25, 3))

                End Select
            End If


        Next

        ListBox1.Items.Add("Total $" & acumulador_dinero & " " & numeros_txt.NumeroATexto(acumulador_dinero))
        ListBox1.Items.Add("Total por compañias: " & "Telcel: $" & t & " " & "Movistar $" & m & " " & "AT&T $" & " " & a & " " & "Unefon $" & u & " " & "Pillofon $" & p)
        ListBox1.Items.Add("Telcel: " & porcentaje(t, acumulador_dinero) & "% " & "Movistar: " & porcentaje(m, acumulador_dinero) & "% " & "AT&T: " & porcentaje(a, acumulador_dinero) & "% " & "Unefon " & porcentaje(u, acumulador_dinero) & "% " & "Pillofon: " & porcentaje(p, acumulador_dinero) & "%")

    End Function

    Public Function compañia(clave) As String
        Dim nombre As String = ""
        Select Case clave
            Case "T"
                nombre = "Telcel"
            Case "A"
                nombre = "AT&T"
            Case "P"
                nombre = "Pillofon"
            Case "M"
                nombre = "Movistar"
            Case = "U"
                nombre = "Unefon"
        End Select

        Return nombre

    End Function

    Public Function porcentaje(cantidad, n)
        Dim porciento As Double

        If n = 0 Then
            Return 0
        Else
            porciento = cantidad / n * 100

            porciento = Math.Round(porciento, 2)

            Return porciento
        End If



    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim compañia As String

        ListBox1.Items.Clear()
        compañia = Microsoft.VisualBasic.Left(cbx_compania.Text, 1)
        recorrer_vector(23, 1, compañia)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numero_telefonico As String

        numero_telefonico = txt_num.Text

        ListBox1.Items.Clear()

        recorrer_vector(12, 10, numero_telefonico)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mes As String
        Dim num_mes As String

        mes = cbx_mes.Text

        num_mes = mes_num(mes)


        ListBox1.Items.Clear()

        recorrer_vector(4, 2, num_mes)
    End Sub

    Public Function mes_num(mes) As String
        Dim num_mes As String

        Select Case mes
            Case "ENERO"
                num_mes = "01"
            Case "FEBRERO"
                num_mes = "02"
            Case "MARZO"
                num_mes = "03"
            Case "ABRIL"
                num_mes = "04"
            Case "MAYO"
                num_mes = "05"
            Case "JUNIO"
                num_mes = "06"
            Case "JULIO"
                num_mes = "07"
            Case "AGOSTO"
                num_mes = "08"
            Case "SEPTIEMBRE"
                num_mes = "09"
            Case "OCTUBRE"
                num_mes = "10"
            Case "NOVIEMBRE"
                num_mes = "11"
            Case "DICIEMBRE"
                num_mes = "12"
        End Select

        Return num_mes
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()

        Dim año As String

        año = txtb_año.Text

        recorrer_vector(7, 4, año)


    End Sub
End Class
