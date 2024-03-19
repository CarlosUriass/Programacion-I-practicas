Imports System.DirectoryServices.ActiveDirectory

Public Class Form1

    Dim nombre, primer_apellido, segundo_apellido As String
    Dim dia_nacimiento, mes_nacimiento, año_nacimiento As String
    Dim sexo, entidad As String
    Dim CURP As String
    Dim random As Integer
    Dim abc As String = "A0123456789"
    Dim num As String = "0123456789"
    Dim RFC As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Obtener todos los datos en forma de string
        nombre = UCase(txtb_nombre.Text)
        primer_apellido = UCase(txtb_primer_ap.Text)
        segundo_apellido = UCase(txtb_segundo_ap.Text)
        dia_nacimiento = cbx_dia.SelectedItem
        mes_nacimiento = cbx_mes.SelectedItem
        año_nacimiento = txtb_año.Text

        If cbx_sexo.SelectedItem = "HOMBRE" Then
            sexo = "H"
        ElseIf cbx_sexo.SelectedItem = "MUJER" Then
            sexo = "M"
        Else
            sexo = "X"
        End If

        'SI NO TIENE SEGUNDO APELLIDO PONERLE X
        If segundo_apellido = "" Then
            segundo_apellido = "X"
        End If


        'ASIGNAR CLAVES SEGUN ESTADO

        Select Case cbx_estado.SelectedItem
            Case "Aguascalientes"
                entidad = "AS"
            Case "Baja California"
                entidad = "BC"
            Case "Baja California Sur"
                entidad = "BS"
            Case "Campeche"
                entidad = "CC"
            Case "Coahuila"
                entidad = "CL"
            Case "Colima"
                entidad = "CM"
            Case "Chiapas"
                entidad = "CS"
            Case "Chihuahua"
                entidad = "CH"
            Case "Ciudad de México"
                entidad = "DF"
            Case "Durango"
                entidad = "DG"
            Case "Guanajuato"
                entidad = "GT"
            Case "Guerrero"
                entidad = "GR"
            Case "Hidalgo"
                entidad = "HG"
            Case "Jalisco"
                entidad = "JC"
            Case "México"
                entidad = "MC"
            Case "Michoacán"
                entidad = "MN"
            Case "Morelos"
                entidad = "MS"
            Case "Nayarit"
                entidad = "NT"
            Case "Nuevo León"
                entidad = "NL"
            Case "Oaxaca"
                entidad = "OC"
            Case "Puebla"
                entidad = "PL"
            Case "Querétaro"
                entidad = "QT"
            Case "Quintana Roo"
                entidad = "QR"
            Case "San Luis Potosí"
                entidad = "SP"
            Case "Sinaloa"
                entidad = "SL"
            Case "Sonora"
                entidad = "SR"
            Case "Tabasco"
                entidad = "TC"
            Case "Tamaulipas"
                entidad = "TS"
            Case "Tlaxcala"
                entidad = "TL"
            Case "Veracruz"
                entidad = "VZ"
            Case "Yucatán"
                entidad = "YN"
            Case "Zacatecas"
                entidad = "ZS"
            Case "Nacido en el extranjero"
                entidad = "NE"
        End Select


        'Empezar a generar curp

        'Primer letra del primer apellido
        CURP = Microsoft.VisualBasic.Left(primer_apellido, 1)
        RFC = Microsoft.VisualBasic.Left(primer_apellido, 1)

        'Encontrar la primer vocal interna del primer apellido
        For i As Integer = 1 To Len(primer_apellido)
            Dim caracter As Char = primer_apellido(i)
            If (primer_apellido(i) = "A" Or primer_apellido(i) = "E" Or primer_apellido(i) = "I" Or primer_apellido(i) = "O" Or primer_apellido(i) = "U") Then
                CURP += caracter
                RFC += caracter
                Exit For
            End If

        Next

        'Encontrar inicial del segundo apellido

        CURP += Microsoft.VisualBasic.Left(segundo_apellido, 1)
        RFC += Microsoft.VisualBasic.Left(segundo_apellido, 1)


        'Primera letra del primer nombre

        'VALIDAR MARIA Y JOSE

        If nombre.StartsWith("JOSÉ ") Then '
            CURP += nombre(5)
            RFC += nombre(5)
        ElseIf nombre.StartsWith("MARIA ") Then
            CURP += nombre(6)
            RFC += nombre(6)
        Else
            CURP += Microsoft.VisualBasic.Left(nombre, 1)
            RFC += Microsoft.VisualBasic.Left(nombre, 1)

        End If

        'Agregar fecha de nacimiento

        CURP += Microsoft.VisualBasic.Right(año_nacimiento, 2)
        CURP += mes_nacimiento
        CURP += dia_nacimiento

        RFC += Microsoft.VisualBasic.Right(año_nacimiento, 2)
        RFC += mes_nacimiento
        RFC += dia_nacimiento


        'Agregar Sexo
        CURP += sexo

        'Agregar entidad
        CURP += entidad

        'Primera consontante del primer apellido
        For i As Integer = 1 To Len(primer_apellido)
            Dim caracter As Char = primer_apellido(i)
            If (primer_apellido(i) <> "A" And primer_apellido(i) <> "E" And primer_apellido(i) <> "I" And primer_apellido(i) <> "O" And primer_apellido(i) <> "U") And primer_apellido(i) <> "Ñ" Then
                CURP += caracter
                Exit For

            ElseIf primer_apellido(i) = "Ñ" Then
                CURP += "X"

                Exit For
            End If

        Next

        'Primera consonante del segundo apellido
        If segundo_apellido = "X" Then
            CURP += segundo_apellido
        Else
            For i As Integer = 1 To Len(segundo_apellido)
                Dim caracter As Char = segundo_apellido(i)
                If (segundo_apellido(i) <> "A" And segundo_apellido(i) <> "E" And segundo_apellido(i) <> "I" And segundo_apellido(i) <> "O" And segundo_apellido(i) <> "U") And segundo_apellido(i) <> "Ñ" Then
                    CURP += caracter
                    Exit For

                ElseIf segundo_apellido(i) = "Ñ" Then
                    CURP += "X"

                    Exit For

                End If
            Next

        End If


        'Primera consonante del nombre   

        If nombre.StartsWith("JOSÉ ") Then '
            For i As Integer = 6 To Len(nombre)
                Dim caracter As Char = nombre(i)
                If (nombre(i) <> "A" And nombre(i) <> "E" And nombre(i) <> "I" And nombre(i) <> "O" And nombre(i) <> "U") And nombre(i) <> "Ñ" Then
                    CURP += caracter

                    Exit For
                ElseIf nombre(i) = "Ñ" Then
                    CURP += "X"


                End If
            Next
        ElseIf nombre.StartsWith("MARIA ") Then
            For i As Integer = 7 To Len(nombre)
                Dim caracter As Char = nombre(i)
                If (nombre(i) <> "A" And nombre(i) <> "E" And nombre(i) <> "I" And nombre(i) <> "O" And nombre(i) <> "U") And nombre(i) <> "Ñ" Then
                    CURP += caracter
                    Exit For
                ElseIf nombre(i) = "Ñ" Then
                    CURP += "X"
                End If
            Next
        Else
            For i As Integer = 1 To Len(nombre)
                Dim caracter As Char = nombre(i)
                If (nombre(i) <> "A" And nombre(i) <> "E" And nombre(i) <> "I" And nombre(i) <> "O" And nombre(i) <> "U") And nombre(i) <> "Ñ" Then
                    CURP += caracter
                    Exit For
                ElseIf nombre(i) = "Ñ" Then
                    CURP += "X"
                End If
            Next
        End If





        Randomize()
        random = Int((11 * Rnd()) + 1)
        CURP += abc(random - 1)
        RFC += abc(random - 1)
        random = 0

        Randomize()
        random = Int((10 * Rnd()) + 1)


        CURP += num(random - 1)
        RFC += num(random - 1)

        Randomize()
        random = Int((10 * Rnd()) + 1)
        RFC += abc(random - 1)


        lbl_curp.Text = CURP 'Imprimir curp en el formulario
        lbl_rfc.Text = RFC
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtb_nombre.Clear()
        txtb_año.Clear()
        txtb_primer_ap.Clear()
        txtb_segundo_ap.Clear()
        cbx_dia.SelectedIndex = -1
        cbx_estado.SelectedIndex = -1
        cbx_mes.SelectedIndex = -1
        cbx_sexo.SelectedIndex = -1

        lbl_curp.Text = "_________________"
        lbl_rfc.Text = "_________________"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class

