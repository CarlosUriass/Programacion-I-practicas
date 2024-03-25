
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim matriz_datos(20, 4) As String
    Dim contador As Byte = 0

    Public Function numtext(ByVal millones As Integer, ByVal centenas_millon As Integer, ByVal decenas_millon As Integer, ByVal millares As Integer, ByVal centenas As Integer, ByVal decenas As Integer, ByVal unidades As Integer)

        Dim millones_txt() As String = {"un", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim centenas_txt() As String = {"cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}
        Dim decenas_txt() As String = {"diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim decenas_plus() As String = {"dieci", "veinti", "treinta y", "cuarenta y", "cincuenta y", "sesenta y", "setenta y", "ochenta y", "noventa y"}
        Dim unidades_txt() As String = {"uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim especiales() As String = {"once", "doce", "trece", "catorce", "quince"}
        Dim millares_txt() As String = {"mil", "dosmil", "tresmil", "cuatromil", "cincomil", "seismil", "sietemil", "ochomil", "nuevemil", "diezmil"}

        Dim texto As String = ""

        If millones > 0 Then
            If millones = 1 Then
                texto += millones_txt(millones - 1) & " millón "
            Else
                texto += millones_txt(millones - 1) & " millones"
            End If
        End If


        If centenas_millon > 0 Then
            If centenas_millon = 1 And decenas_millon >= 1 Then
                texto += centenas_txt(centenas_millon - 1) & "to"
            ElseIf centenas_millon <= 9 And decenas_millon >= 1 Then
                texto += centenas_txt(centenas_millon - 1)
            ElseIf centenas_millon <= 9 And decenas_millon = 0 And millares = 0 Then
                texto += centenas_txt(centenas_millon - 1) & " " & "mil"
            End If
        End If

        If decenas_millon > 0 Then
            If decenas_millon = 1 And millares <= 5 And millares <> 0 Then
                texto += " " & especiales(millares - 1) & " mil"
            ElseIf decenas_millon <= 9 And millares = 0 Then
                texto += " " & decenas_txt(decenas_millon - 1) & " mil"
            ElseIf decenas_millon <= 9 And millares >= 1 Then
                texto += " " & decenas_plus(decenas_millon - 1) & " " & unidades_txt(millares - 1) & " mil"
            End If
        End If

        If decenas_millon = 0 And millares >= 1 Then
            texto += " " & millares_txt(millares - 1)
        End If


        If centenas > 0 Then
            If centenas = 1 And decenas >= 1 Then
                texto += " " & centenas_txt(centenas - 1) & "to"
            ElseIf centenas <= 9 And decenas <= 9 Then
                texto += " " & centenas_txt(centenas - 1)
            End If
        End If

        If decenas > 0 Then
            If decenas = 1 And unidades <= 5 Then
                texto += " " & especiales(unidades - 1)
            ElseIf decenas <= 9 And unidades = 0 Then
                texto += " " & decenas_txt(decenas - 1)
            Else
                texto += " " & decenas_plus(decenas - 1)
            End If
        End If

        If unidades > 0 Then
            texto += " " & unidades_txt(unidades - 1)
        End If

        Return texto
    End Function

    Public Function numstr(ByVal numero As String) As String
        '-------------------------------------------------------------------------------
        ' Función: numstr
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función extrae de un string "numerico" la cantidad de unidades de millones, 
        '   centenas de millar hasta las unidades. Con esos datos manda llamar otra funcion
        '   que convierte esos datos en su representacion textual.
        '
        ' Parámetros:
        '   numero (String): El número que se va a convertir en palabras.
        '
        ' Devuelve:
        '   String: La representación en palabras del número dado.
        '-------------------------------------------------------------------------------

        ' Declaración de variables para las distintas partes del número
        Dim millones, centenas_mill, decenas_mill, millares, centenas, decenas, unidades As Integer

        ' Dividir el número en sus partes de millones, centenas de millones, etc.
        millones = numero \ 1_000_000
        centenas_mill = (numero Mod 1_000_000) \ 100_000
        decenas_mill = (numero Mod 100_000) \ 10_000
        millares = (numero Mod 10_000) \ 1_000
        centenas = (numero Mod 1_000) \ 100
        decenas = (numero Mod 100) \ 10
        unidades = numero Mod 10

        ' Llama a una funcion que convierte los numeros en texto.
        Return numtext(millones, centenas_mill, decenas_mill, millares, centenas, decenas, unidades)

    End Function


    Public Function validacion_vacio(ByVal texto As String) As Boolean
        '-------------------------------------------------------------------------------
        ' Función: validacion_vacio
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función verifica si un texto dado está vacío o no. Si el texto está vacío,
        '   muestra un mensaje de advertencia y devuelve True; de lo contrario, devuelve False.
        '
        ' Parámetros:
        '   texto (String): El texto que se va a verificar si está vacío o no.
        '
        ' Devuelve:
        '   Boolean: True si el texto está vacío, False si no lo está.
        '-------------------------------------------------------------------------------

        ' Verifica si el texto está vacío
        If texto = "" Then
            ' Si el texto está vacío, muestra un mensaje de advertencia
            MsgBox("No puede haber campos vacíos", MsgBoxStyle.OkOnly)
            Return True
        Else
            ' Si el texto no está vacío, devuelve False
            Return False
        End If
    End Function


    Public Function validacion_longitud(ByVal texto As String) As Boolean
        '-------------------------------------------------------------------------------
        ' Función: validacion_longitud
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función verifica si un texto dado tiene una longitud de exactamente 18 caracteres,
        '   que es la longitud requerida para una CLABE interbancaria en México. Si la longitud
        '   no es de 18 caracteres, muestra un mensaje de advertencia y devuelve True; de lo contrario,
        '   devuelve False.
        '
        ' Parámetros:
        '   texto (String): El texto cuya longitud se va a verificar.
        '
        ' Devuelve:
        '   Boolean: True si la longitud del texto no es 18 caracteres, False si lo es.
        '-------------------------------------------------------------------------------

        ' Verifica si la longitud del texto es diferente de 18 caracteres
        If Len(texto) <> 18 Then
            ' Si la longitud no es 18, muestra un mensaje de advertencia
            MsgBox("La CLABE interbancaria debe tener exactamente 18 caracteres. Revise de nuevo.", MsgBoxStyle.OkOnly)
            Return True
        Else
            ' Si la longitud es 18, devuelve False
            Return False
        End If
    End Function

    Public Function caracteres_especiales(ByVal texto As String) As Boolean
        '-------------------------------------------------------------------------------
        ' Función: caracteres_especiales
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función verifica si un texto contiene caracteres especiales no deseados.
        '   Si encuentra algún carácter especial en el texto, muestra un mensaje de advertencia
        '   y devuelve True; de lo contrario, devuelve False.
        '
        ' Parámetros:
        '   texto (String): El texto que se va a verificar en busca de caracteres especiales.
        '
        ' Devuelve:
        '   Boolean: True si el texto contiene caracteres especiales, False si no los contiene.
        '-------------------------------------------------------------------------------

        ' Itera sobre cada carácter en el texto
        For i As Integer = 1 To Len(texto)
            ' Verifica si el carácter actual es un carácter especial
            If texto(i - 1) = "#" Or texto(i - 1) = "/" Or texto(i - 1) = "!" Or texto(i - 1) = "$" Or texto(i - 1) = "%" Or texto(i - 1) = "&" Or texto(i - 1) = "*" Or texto(i - 1) = "+" Or texto(i - 1) = "=" Or texto(i - 1) = "?" Or texto(i - 1) = "^" Or texto(i - 1) = "`" Or texto(i - 1) = "|" Or texto(i - 1) = "~" Then
                ' Si se encuentra un carácter especial, muestra un mensaje de advertencia
                MsgBox("El campo no debe contener caracteres especiales", MsgBoxStyle.OkOnly)
                Return True
                Exit For ' Sale del bucle ya que se ha encontrado un carácter especial
            End If
        Next

        ' Si no se encontraron caracteres especiales, devuelve False
        Return False
    End Function


    Public Function ClabeBanco(ByVal banco As String) As String
        '-------------------------------------------------------------------------------
        ' Función: ClabeBanco
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función devuelve el código de CLABE asociado a un banco específico.
        '
        ' Parámetros:
        '   banco (String): El nombre del banco para el cual se desea obtener el código de CLABE.
        '
        ' Devuelve:
        '   String: El código de CLABE correspondiente al banco especificado. Si el banco
        '           no está en la lista, devuelve una cadena vacía.
        '-------------------------------------------------------------------------------

        Dim clabe As String = ""

        ' Utiliza una declaración Select Case para asignar el código de CLABE según el banco
        Select Case banco
            Case "BANAMEX"
                clabe = "002"
            Case "Banca Serafín, S.A"
                clabe = "003"
            Case "Santander Mexicano, S.A"
                clabe = "014"
            Case "banco Nacional del Ejercito y Fuerza Aerea y Armada, S.N.C"
                clabe = "019"
            Case "banco del Bajío, S.A"
                clabe = "030"
            Case "banco Inbursa, S.A"
                clabe = "036"
            Case "Scotiabank, S.A"
                clabe = "036"
            Case "HSBC"
                clabe = "119"
            Case "Azteca"
                clabe = "127"
            Case "BBVA Bancomer, S.A"
                clabe = "012"
        End Select

        ' Devuelve el código de CLABE asociado al banco
        Return clabe
    End Function


    Public Function cantidad_importe(ByVal importe As Double) As Boolean
        '-------------------------------------------------------------------------------
        ' Función: cantidad_importe
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función verifica si el importe dado es válido.
        '
        ' Parámetros:
        '   importe (Double): El importe que se va a verificar.
        '
        ' Devuelve:
        '   Boolean: True si el importe no es válido (menor que 0 o mayor que 9,999,999),
        '            False si el importe es válido.
        '-------------------------------------------------------------------------------

        ' Verifica si el importe es menor que 0
        If importe < 0 Then
            ' Si el importe es menor que 0, muestra un mensaje de advertencia
            MsgBox("El importe no puede ser menor que 0", MsgBoxStyle.OkOnly)
            Return True
            ' Verifica si el importe es mayor que 9,999,999
        ElseIf importe > 9999999 Then
            ' Si el importe es mayor que 9,999,999, muestra un mensaje de advertencia
            MsgBox("El importe no puede ser mayor a 9,999,999", MsgBoxStyle.OkOnly)
            Return True
        Else
            ' Si el importe es válido, devuelve False
            Return False
        End If
    End Function

    Public Function bancoReceptor(ByVal clabe As String) As String
        '-------------------------------------------------------------------------------
        ' Función: bancoReceptor
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función devuelve el nombre del banco receptor asociado a una CLABE dada.
        '
        ' Parámetros:
        '   clabe (String): La CLABE del banco para la cual se desea obtener el nombre.
        '
        ' Devuelve:
        '   String: El nombre del banco receptor correspondiente a la CLABE especificada.
        '-------------------------------------------------------------------------------

        Dim banco As String = ""

        ' Utiliza una estructura condicional para asignar el nombre del banco según los primeros dígitos de la CLABE
        If clabe.StartsWith("002") Then
            banco = "BANAMEX"
        ElseIf clabe.StartsWith("003") Then
            banco = "Banca Serafín, S.A"
        ElseIf clabe.StartsWith("014") Then
            banco = "Santander Mexicano, S.A"
        ElseIf clabe.StartsWith("019") Then
            banco = "banco Nacional del Ejercito y Fuerza Aerea y Armada, S.N.C"
        ElseIf clabe.StartsWith("030") Then
            banco = "banco del Bajío, S.A"
        ElseIf clabe.StartsWith("036") Then
            banco = "banco Inbursa, S.A"
        ElseIf clabe.StartsWith("036") Then
            banco = "Scotiabank, S.A"
        ElseIf clabe.StartsWith("119") Then
            banco = "HSBC"
        ElseIf clabe.StartsWith("127") Then
            banco = "Azteca"
        ElseIf clabe.StartsWith("012") Then
            banco = "BBVA Bancomer, S.A"
        End If

        ' Devuelve el nombre del banco receptor asociado a la CLABE
        Return banco
    End Function


    Public Function Validar_clave_banco(ByVal clabe As String) As Boolean
        '-------------------------------------------------------------------------------
        ' Función: Validar_clave_banco
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función valida la clave del banco en una CLABE bancaria.
        '
        ' Parámetros:
        '   clabe (String): La CLABE bancaria para la cual se desea validar la clave del banco.
        '
        ' Devuelve:
        '   Boolean: True si la clave del banco en la CLABE no está en la lista de claves válidas,
        '            False si la clave del banco es válida.
        '-------------------------------------------------------------------------------

        Dim clave_banco As String

        ' Extrae los primeros 3 dígitos de la CLABE que representan la clave del banco
        clave_banco = Microsoft.VisualBasic.Left(clabe, 3)

        ' Verifica si la clave del banco no está en la lista de claves válidas
        If clave_banco <> "002" And clave_banco <> "003" And clave_banco <> "019" And clave_banco <> "030" And clave_banco <> "036" And clave_banco <> "119" And clave_banco <> "127" And clave_banco <> "012" And clave_banco <> "014" Then
            ' Si la clave del banco no es válida, muestra un mensaje de advertencia
            MsgBox("No se encontró el banco según la clave proporcionada", MsgBoxStyle.OkOnly)
            Return True
        End If

        ' Si la clave del banco es válida, devuelve False
        Return False
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim Clabe As String
        Clabe = txtb_clabe.Text

        If validacion_vacio(Clabe) = True Then
            Return
        End If

        If validacion_longitud(Clabe) = True Then
            Return
        End If

        If caracteres_especiales(Clabe) = True Then
            Return
        End If

        If Validar_clave_banco(Clabe) = True Then
            Return
        End If


        'Validar banco emisor NO VACIO
        If validacion_vacio(cbx_banco.SelectedItem) = True Then
            Return
        End If


        'VALIDAR IMPORTE NO VACIO
        Dim importe As Double

        importe = Val(txtb_importe.Text)

        If validacion_vacio(Str(importe)) = True Then
            Return
        End If

        'Validar importe > 0 < 9,999,999
        If cantidad_importe(importe) = True Then
            Return
        End If

        'Validar importe no caracteres especiales

        If caracteres_especiales(Str(importe)) = True Then
            Return
        End If


        'Obtener banco receptor
        Dim banco_receptor As String

        banco_receptor = bancoReceptor(Clabe)

        'Obtener fecha
        Dim fecha As String
        fecha = MonthCalendar1.SelectionStart


        'Mandar datos a la matriz

        matriz(fecha, cbx_banco.SelectedItem, Clabe, banco_receptor, Str(importe))


        MsgBox("Trasnferencia realizada con exito", MsgBoxStyle.OkOnly)
        txtb_clabe.Clear()
        txtb_importe.Clear()
        cbx_banco.SelectedIndex = -1

    End Sub

    Public Function matriz(ByVal fecha As String, ByVal banco_emisor As String, ByVal clabe As String, ByVal banco_receptor As String, ByVal importe As String) As Integer(,)
        '-------------------------------------------------------------------------------
        ' Función: matriz
        '-------------------------------------------------------------------------------
        ' Descripción:
        '   Esta función asigna los datos de una transacción a una matriz.
        '
        ' Parámetros:
        '   fecha (String): La fecha de la transacción.
        '   banco_emisor (String): El nombre del banco emisor.
        '   clabe (String): La CLABE del banco emisor.
        '   banco_receptor (String): El nombre del banco receptor.
        '   importe (String): El importe de la transacción.
        '

        '-------------------------------------------------------------------------------

        ' Asigna los datos de la transacción a la matriz
        matriz_datos(contador, 0) = fecha
        matriz_datos(contador, 1) = banco_emisor
        matriz_datos(contador, 2) = clabe
        matriz_datos(contador, 3) = banco_receptor
        matriz_datos(contador, 4) = importe

        ' Incrementa el contador para la siguiente transacción
        contador += 1


    End Function



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim importe_str As String


        For i As Integer = 0 To contador - 1
            importe_str = numstr(matriz_datos(i, 4))
            ListBox1.Items.Add("Fecha: " & matriz_datos(i, 0) & " " & matriz_datos(i, 1) & " " & matriz_datos(i, 2) & "  " & matriz_datos(i, 3) & " " & "$" & matriz_datos(i, 4) & importe_str & " pesos")
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim clave As String
        ListBox1.Items.Clear()

        Dim matriz_recibidos(9, 1) As String
        Dim banco As String
        Dim num_txt As String

        matriz_recibidos(0, 0) = "BANAMEX"
        matriz_recibidos(1, 0) = "Banca Serafín, S.A"
        matriz_recibidos(2, 0) = "Santander Mexicano, S.A"
        matriz_recibidos(3, 0) = "banco Nacional del Ejercito y Fuerza Aerea y Armada, S.N.C"
        matriz_recibidos(4, 0) = "banco del Bajío, S.A"
        matriz_recibidos(5, 0) = "banco Inbursa, S.A"
        matriz_recibidos(6, 0) = "Scotiabank, S.A"
        matriz_recibidos(7, 0) = "HSBC"
        matriz_recibidos(8, 0) = "Azteca"
        matriz_recibidos(9, 0) = "BBVA Bancomer, S.A"


        For i As Integer = 0 To contador - 1
            banco = matriz_datos(i, 3)

            Select Case banco
                Case "BANAMEX"
                    matriz_recibidos(0, 1) += Val(matriz_datos(i, 4))
                Case "Banca Serafín, S.A"
                    matriz_recibidos(1, 1) += Val(matriz_datos(i, 4))
                Case "Santander Mexicano, S.A"
                    matriz_recibidos(2, 1) += Val(matriz_datos(i, 4))
                Case "banco Nacional del Ejercito y Fuerza Aerea y Armada, S.N.C"
                    matriz_recibidos(3, 1) += Val(matriz_datos(i, 4))
                Case "banco del Bajío, S.A"
                    matriz_recibidos(4, 1) += Val(matriz_datos(i, 4))
                Case "banco Inbursa, S.A"
                    matriz_recibidos(5, 1) += Val(matriz_datos(i, 4))
                Case "Scotiabank, S.A"
                    matriz_recibidos(6, 1) += Val(matriz_datos(i, 4))
                Case "HSBC"
                    matriz_recibidos(7, 1) += Val(matriz_datos(i, 4))
                Case "Azteca"
                    matriz_recibidos(8, 1) += Val(matriz_datos(i, 4))
                Case "BBVA Bancomer, S.A"
                    matriz_recibidos(9, 1) += Val(matriz_datos(i, 4))
            End Select
        Next


        For i As Integer = 0 To 9

            If matriz_recibidos(i, 1) > 0 Then
                clave = ClabeBanco(matriz_recibidos(i, 0))
                num_txt = numstr(matriz_recibidos(i, 1))
                ListBox1.Items.Add("Clave:  " & clave & " " & "Banco: " & matriz_recibidos(i, 0) & " " & "importe: " & "$" & matriz_recibidos(i, 1) & " " & num_txt & " pesos")
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Dim matriz_enviados(9, 1) As String
        Dim banco As String
        Dim num_txt As String
        Dim clave As String

        matriz_enviados(0, 0) = "BANAMEX"
        matriz_enviados(1, 0) = "Banca Serafín, S.A"
        matriz_enviados(2, 0) = "Santander Mexicano, S.A"
        matriz_enviados(3, 0) = "banco Nacional del Ejercito y Fuerza Aerea y Armada, S.N.C"
        matriz_enviados(4, 0) = "banco del Bajío, S.A"
        matriz_enviados(5, 0) = "banco Inbursa, S.A"
        matriz_enviados(6, 0) = "Scotiabank, S.A"
        matriz_enviados(7, 0) = "HSBC"
        matriz_enviados(8, 0) = "Azteca"
        matriz_enviados(9, 0) = "BBVA Bancomer, S.A"

        For i As Integer = 0 To contador - 1
            banco = matriz_datos(i, 1)

            Select Case banco
                Case "BANAMEX"
                    matriz_enviados(0, 1) += Val(matriz_datos(i, 4))
                Case "Banca Serafín, S.A"
                    matriz_enviados(1, 1) += Val(matriz_datos(i, 4))
                Case "Santander Mexicano, S.A"
                    matriz_enviados(2, 1) += Val(matriz_datos(i, 4))
                Case "banco Nacional del Ejercito y Fuerza Aerea y Armada, S.N.C"
                    matriz_enviados(3, 1) += Val(matriz_datos(i, 4))
                Case "banco del Bajío, S.A"
                    matriz_enviados(4, 1) += Val(matriz_datos(i, 4))
                Case "banco Inbursa, S.A"
                    matriz_enviados(5, 1) += Val(matriz_datos(i, 4))
                Case "Scotiabank, S.A"
                    matriz_enviados(6, 1) += Val(matriz_datos(i, 4))
                Case "HSBC"
                    matriz_enviados(7, 1) += Val(matriz_datos(i, 4))
                Case "Azteca"
                    matriz_enviados(8, 1) += Val(matriz_datos(i, 4))
                Case "BBVA Bancomer, S.A"
                    matriz_enviados(9, 1) += Val(matriz_datos(i, 4))
            End Select
        Next

        For i As Integer = 0 To 9

            If matriz_enviados(i, 1) > 0 Then
                clave = ClabeBanco(matriz_enviados(i, 0))
                num_txt = numstr(matriz_enviados(i, 1))
                ListBox1.Items.Add("Clave: " & clave & " " & "Banco: " & matriz_enviados(i, 0) & " " & "importe: " & matriz_enviados(i, 1) & " " & num_txt)
            End If

        Next

    End Sub
End Class
