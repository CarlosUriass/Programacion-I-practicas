Public Class Form1
    Dim nombre As String
    Dim dias As String
    Dim email As String
    Dim sueldo As String
    Dim cuenta As String
    Dim matriz(20, 4) As String 'MATRIZ SOLO PARA 20 EMPLEADOS
    Dim contador As Byte = 0
    Dim utilidad As Double
    Dim importe As Double
    Dim porcentaje As Double
    Dim utilidad_pagar As Double
    Dim Calculo_sueldo, suma_sueldo As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = txtb_nombre.Text

        'Validar Nombre

        If nombre = "" Then
            MsgBox("El nombre no puede estar vacio", MsgBoxStyle.OkOnly)
        End If

        'Validar que el nombre no tenga numeros
        For i As Integer = 1 To Len(nombre)
            If nombre(i - 1) = "0" Or nombre(i - 1) = "1" Or nombre(i - 1) = "2" Or nombre(i - 1) = "3" Or nombre(i - 1) = "4" Or nombre(i - 1) = "5" Or nombre(i - 1) = "6" Or nombre(i - 1) = "7" Or nombre(i - 1) = "8" Or nombre(i - 1) = "9" Then
                MsgBox("El nombre no puede contener números", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next

        'Validar que el nombre no contenga caracteres especiales

        For i As Integer = 1 To Len(nombre)
            If nombre(i - 1) = "#" Or nombre(i - 1) = "/" Or nombre(i - 1) = "!" Or nombre(i - 1) = "$" Or nombre(i - 1) = "%" Or nombre(i - 1) = "&" Or nombre(i - 1) = "*" Or nombre(i - 1) = "+" Or nombre(i - 1) = "=" Or nombre(i - 1) = "?" Or nombre(i - 1) = "^" Or nombre(i - 1) = "`" Or nombre(i - 1) = "|" Or nombre(i - 1) = "~" Then
                MsgBox("No se admiten caracteres especiales en el nombre", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next


        'VALIDAR DIAS TRABAJADOS

        'Validar que los dias trabajados no esten vacios

        If txtb_dias.Text = "" Then
            MsgBox("El campo dias trabajados no puede estar vacio", MsgBoxStyle.OkOnly)
            Return
        End If

        ' Validar que solo sean números
        For i As Integer = 1 To Len(txtb_dias.Text)
            If Not Char.IsDigit(txtb_dias.Text(i - 1)) Then
                MsgBox("Los días deben contener solo dígitos del 0 al 9", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next

        ' Validar que no existan caracteres especiales
        For i As Integer = 1 To Len(txtb_dias.Text)
            If txtb_dias.Text(i - 1) = "#" Or txtb_dias.Text(i - 1) = "/" Or txtb_dias.Text(i - 1) = "!" Or txtb_dias.Text(i - 1) = "$" Or txtb_dias.Text(i - 1) = "%" Or txtb_dias.Text(i - 1) = "&" Or txtb_dias.Text(i - 1) = "*" Or txtb_dias.Text(i - 1) = "+" Or txtb_dias.Text(i - 1) = "=" Or txtb_dias.Text(i - 1) = "?" Or txtb_dias.Text(i - 1) = "^" Or txtb_dias.Text(i - 1) = "`" Or txtb_dias.Text(i - 1) = "|" Or txtb_dias.Text(i - 1) = "~" Then
                MsgBox("Los días no pueden contener caracteres especiales", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next

        'Validar que los dias no sean menores a 1
        If txtb_dias.Text < "1" Then
            MsgBox("Los dias trabajados no pueden ser menores a 1")
            Return
        End If


        'VALIDAR SUELDO


        'Validar que el sueldo diario no esté vacio
        If txtb_sueldo.Text = "" Then
            MsgBox("El campo sueldo no puede estar vacio", MsgBoxStyle.OkOnly)
            Return
        End If



        'Validar que no existan caracteres especiales
        For i As Integer = 1 To Len(txtb_sueldo.Text)
            If txtb_sueldo.Text(i - 1) = "#" Or txtb_sueldo.Text(i - 1) = "/" Or txtb_sueldo.Text(i - 1) = "!" Or txtb_sueldo.Text(i - 1) = "$" Or txtb_sueldo.Text(i - 1) = "%" Or txtb_sueldo.Text(i - 1) = "&" Or txtb_sueldo.Text(i - 1) = "*" Or txtb_sueldo.Text(i - 1) = "+" Or txtb_sueldo.Text(i - 1) = "=" Or txtb_sueldo.Text(i - 1) = "?" Or txtb_sueldo.Text(i - 1) = "^" Or txtb_sueldo.Text(i - 1) = "`" Or txtb_sueldo.Text(i - 1) = "|" Or txtb_sueldo.Text(i - 1) = "~" Then
                MsgBox("El sueldo no puede contener caracteres especiales", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next


        'Validar que el sueldo sea mayor que 0
        If txtb_sueldo.Text < "1" Then
            MsgBox("El sueldo diario no puede ser menor a 0", MsgBoxStyle.OkOnly)
            Exit Sub
            Return
        End If


        'VALIDAR CUENTA BANCARIA

        'Valiudar cuenta bancaria


        If txtb_cuenta.Text = "" Then
            MsgBox("la cuenta bancaria puede estar vacia", MsgBoxStyle.OkOnly)
            Return
        End If

        'Validar que la cuenta bancaria no contenga caracteres especiales

        For i As Integer = 1 To Len(txtb_cuenta.Text)
            If txtb_cuenta.Text(i - 1) = "#" Or txtb_cuenta.Text(i - 1) = "/" Or txtb_cuenta.Text(i - 1) = "!" Or txtb_cuenta.Text(i - 1) = "$" Or txtb_cuenta.Text(i - 1) = "%" Or txtb_cuenta.Text(i - 1) = "&" Or txtb_cuenta.Text(i - 1) = "*" Or txtb_cuenta.Text(i - 1) = "+" Or txtb_cuenta.Text(i - 1) = "=" Or txtb_cuenta.Text(i - 1) = "?" Or txtb_cuenta.Text(i - 1) = "^" Or txtb_cuenta.Text(i - 1) = "`" Or txtb_cuenta.Text(i - 1) = "|" Or txtb_cuenta.Text(i - 1) = "~" Then
                MsgBox("No se admiten caracteres especiales en la cuenta bancaria", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next

        ' Validar que la cuenta bancaria solo contenga números (No letras)
        For i As Integer = 1 To Len(txtb_cuenta.Text)
            If Not Char.IsDigit(txtb_cuenta.Text(i - 1)) Then
                MsgBox("La cuenta bancaria no puede contener caracteres diferentes de los dígitos del 0 al 9", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next

        ' Validar longitud de la cuenta bancaria
        If Len(txtb_cuenta.Text) <> 8 Then
            MsgBox("La cuenta bancaria debe tener una longitud de 8 caracteres", MsgBoxStyle.OkOnly)
            Exit Sub
            Return
        End If

        'VALIDAR EMAIL

        email = LCase(txtb_email.Text)

        If email = "" Then
            MsgBox("El email no puede estar vacío", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        'Buscar arrobas
        Dim arroba_posc As Integer
        Dim contador_arroba As Integer
        contador_arroba = 0
        For i As Integer = 1 To Len(email)
            If email(i - 1) = "@" Then
                arroba_posc = i
                contador_arroba += 1
            End If
        Next

        If contador_arroba > 1 Then
            MsgBox("Solo debe existir una arroba en el email", MsgBoxStyle.OkOnly)
            Return
        End If

        If contador_arroba = 0 Then
            MsgBox("El correo debe contener al menos un arroba", MsgBoxStyle.OkOnly)
            Return
        End If

        'Generar nombre de usuario
        Dim nombre_usuario As String
        nombre_usuario = Microsoft.VisualBasic.Left(email, arroba_posc - 1)

        'Validar si el nombre de usuario excede los 64 caracteres
        If Len(nombre_usuario) > 64 Then
            MsgBox("El nombre de usuario excede los 64 caracteres", MsgBoxStyle.OkOnly)
            Return
        End If

        'Generar dominio
        Dim dominio As String
        dominio = Mid(email, arroba_posc + 1)

        If Len(dominio) >= 255 Then
            MsgBox("Los caracteres en el dominio exceden el límite permitido", MsgBoxStyle.OkOnly)
            Return
        End If


        For i As Integer = 1 To Len(email)
            If email(i - 1) = "#" Or email(i - 1) = "/" Or email(i - 1) = "!" Or email(i - 1) = "$" Or email(i - 1) = "%" Or email(i - 1) = "&" Or email(i - 1) = "*" Or email(i - 1) = "+" Or email(i - 1) = "=" Or email(i - 1) = "?" Or email(i - 1) = "^" Or email(i - 1) = "`" Or email(i - 1) = "|" Or email(i - 1) = "~" Then
                MsgBox("No se admiten caracteres especiales", MsgBoxStyle.OkOnly)
                Exit For
                Return
            End If
        Next


        If Not (dominio.EndsWith(".com") Or dominio.EndsWith(".gob") Or dominio.EndsWith(".org") Or dominio.EndsWith(".net")) Then
            MsgBox("El dominio del correo electrónico no es válido.", MsgBoxStyle.OkOnly)
            Return
        End If



        'En teoria si llega hasta aqui es que estan todos los campos validados por la función return
        nombre = txtb_nombre.Text
        dias = txtb_dias.Text
        sueldo = txtb_sueldo.Text
        cuenta = txtb_cuenta.Text
        email = txtb_email.Text

        'Llenar esos datos a la matriz
        matriz(contador, 0) = nombre
        matriz(contador, 1) = dias
        matriz(contador, 2) = sueldo
        matriz(contador, 3) = cuenta
        matriz(contador, 4) = email



        'Ir sumando el total de los sueldos

        If Val(matriz(contador, 1)) >= 60 Then
            Calculo_sueldo = Val(matriz(contador, 1) * Val(matriz(contador, 2)))
            suma_sueldo += Calculo_sueldo
        End If


        'Sumar 1 al contador

        contador += 1



        'Limpiar casillas 
        'De nuevo: En teoria, si la logica del programa llega hasta la ejecución de esta linea se supone que todo estuvo validado
        txtb_nombre.Clear()
        txtb_dias.Clear()
        txtb_sueldo.Clear()
        txtb_cuenta.Clear()
        txtb_email.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        utilidad = Val(txtb_utilidad.Text)


        For i As Integer = 0 To 20 'Recorrer filas
            If matriz(i, 1) >= 60 Then

                importe = Val(matriz(i, 1)) * Val(matriz(i, 2))

                'Calcular el porcentaje relativo 
                porcentaje = Val((importe / suma_sueldo) / 1)

                'Calcular utilidad 

                utilidad_pagar = porcentaje * utilidad

                'Imprimir resultados en listbox
                ListBox1.Items.Add("Nombre: " & matriz(i, 0) & " Utilidades a pagar: " & Math.Round(utilidad_pagar, 2) & " Cuenta bancaria: " & matriz(i, 3) & " Email: " & matriz(i, 4))
            End If

        Next

    End Sub
End Class


'Notas:
''' Habria de validar que el importe de las utilidades a repartir no se pueda modificar
''' Un mensaje que avise que una vez de calcular los datos podria tener alteraciones si no estan completos
''' (Confirmación)
'''
