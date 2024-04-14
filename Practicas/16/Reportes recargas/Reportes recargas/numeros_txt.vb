Public Class numeros_txt

    Public Shared Function Main(millones As Integer, centenas_millon As Integer, decenas_millon As Integer, millares As Integer, centenas As Integer, decenas As Integer, unidades As Integer) As String
        ' Definición de listas que contienen palabras para representar los números en diferentes rangos
        Dim numeros_millones() As String = {"un", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim numeros_centenas() As String = {"cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}
        Dim numeros_decenas() As String = {"diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim numeros_decenas_adicionales() As String = {"dieci", "veinti", "treinta y", "cuarenta y", "cincuenta y", "sesenta y", "setenta y", "ochenta y", "noventa y"}
        Dim numeros_unidades() As String = {"uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim numeros_especiales() As String = {"once", "doce", "trece", "catorce", "quince"}
        Dim numeros_millares() As String = {"mil", "dos mil", "tres mil", "cuatro mil", "cinco mil", "seis mil", "siete mil", "ocho mil", "nueve mil", "diez mil"}


        ' Convierte cada parte del número en palabras, considerando su posición y valor.

        Dim texto As String = ""

        If millones > 0 Then
            If millones = 1 Then
                texto &= numeros_millones(millones - 1) & " millón "
            Else
                texto &= numeros_millones(millones - 1) & " millones "
            End If
        End If

        If centenas_millon > 0 Then
            If centenas_millon = 1 AndAlso decenas_millon >= 1 Then
                texto &= numeros_centenas(centenas_millon - 1) & "to"
            ElseIf centenas_millon <= 9 AndAlso decenas_millon >= 1 Then
                texto &= numeros_centenas(centenas_millon - 1)
            ElseIf centenas_millon <= 9 AndAlso decenas_millon = 0 AndAlso millares = 0 Then
                texto &= numeros_centenas(centenas_millon - 1) & " " & "mil"
            End If
        End If

        If decenas_millon > 0 Then
            If decenas_millon = 1 AndAlso millares <= 5 AndAlso millares <> 0 Then
                texto &= " " & numeros_especiales(millares - 1) & " mil"
            ElseIf decenas_millon <= 9 AndAlso millares = 0 Then
                texto &= " " & numeros_decenas(decenas_millon - 1) & " mil"
            ElseIf decenas_millon <= 9 AndAlso millares >= 1 Then
                texto &= " " & numeros_decenas_adicionales(decenas_millon - 1) & " " & numeros_unidades(millares - 1) & " mil"
            End If
        End If

        If decenas_millon = 0 AndAlso millares >= 1 Then
            texto &= " " & numeros_millares(millares - 1)
        End If

        If centenas > 0 Then
            If centenas = 1 AndAlso decenas >= 1 Then
                texto &= " " & numeros_centenas(centenas - 1) & "to"
            ElseIf centenas <= 9 AndAlso decenas <= 9 Then
                texto &= " " & numeros_centenas(centenas - 1)
            End If
        End If

        If decenas > 0 Then
            If decenas = 1 AndAlso unidades <= 5 Then
                texto &= " " & numeros_especiales(unidades - 1)
            ElseIf decenas <= 9 AndAlso unidades = 0 Then
                texto &= " " & numeros_decenas(decenas - 1)
            Else
                texto &= " " & numeros_decenas_adicionales(decenas - 1)
            End If
        End If

        If unidades > 0 Then
            If unidades = 1 Then
                texto &= " un"
            ElseIf decenas = 1 AndAlso unidades <= 5 Then
                texto &= ""
            Else
                texto &= " " & numeros_unidades(unidades - 1)
            End If
        End If

        Return texto
    End Function

    Public Shared Function ConvertirATexto(numero As String) As String
        ' Convierte un número entero en su representación textual en español.

        Dim num As Integer = Integer.Parse(numero)  ' Convertir el número a entero

        Dim millones As Integer = num \ 1000000
        Dim centenas_millon As Integer = (num Mod 1000000) \ 100000
        Dim decenas_millon As Integer = (num Mod 100000) \ 10000
        Dim millar As Integer = (num Mod 10000) \ 1000
        Dim centenas As Integer = (num Mod 1000) \ 100
        Dim decenas As Integer = (num Mod 100) \ 10
        Dim unidades As Integer = num Mod 10

        Return Main(millones, centenas_millon, decenas_millon, millar, centenas, decenas, unidades)
    End Function

    Public Shared Function SepararNumeros(numero As String) As String
        ' Divide un número dado en su parte entera y su parte decimal, luego convierte ambas partes en palabras.

        For i As Integer = 0 To numero.Length - 1
            If numero(i) = "."c Then
                Dim parte_entera As String = ConvertirATexto(numero.Substring(0, i))
                Dim parte_decimal As String = ConvertirATexto(numero.Substring(i + 1))
                Return parte_entera & " pesos con" & parte_decimal & " centavos"
            End If
        Next

        Return ConvertirATexto(numero) & " pesos"
    End Function

    Public Shared Function NumeroATexto(numero As String) As String
        ' Convierte un número, representado como una cadena, en su representación textual en español.

        Return SepararNumeros(numero)
    End Function



End Class
