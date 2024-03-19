Imports System 

Module Program 
    Dim capturar As Boolean 
    Dim cont_captura As String 
    Dim clave_vehiculo As String 
    Dim residente As String 
    Dim descuento_residente As Boolean 
    Dim contador_vehiculos As Short 
    Dim clave_pago As String 
    Dim forma_pago As String 
    Dim cuota As Single 
    Dim pago_efectivo As Single 
    Dim pago_credito As Single 
    Dim total_cobrado As Single 
    Dim efectivo_perct, credito_perct As Single 
    Dim moto, auto, camion, trailer As Byte 
    Dim moto_pago, auto_pago, camion_pago, trailer_pago As Single 
    Dim moto_pago_r, auto_pago_r, camion_pago_r, trailer_pago_r As Single 

    Sub Main(args As String()) 
        Console.WriteLine("** CASETA DE COBRO **") 
        Console.WriteLine("*********************") 
        capturar = True 

        While capturar = True 
            contador_vehiculos += 1 'Contador de cuantos vehiculos va cobrando 
            Console.WriteLine("****************************************************") 
            Console.WriteLine("¿Qué tipo de vehículo es?") 
            Console.WriteLine("1) Motocicleta. 2) Automóvil o pick-up 3) Camión de dos o tres ejes. 4) Trailer de tres a cinco ejes") 
            clave_vehiculo = Console.ReadLine() 
            Console.WriteLine("1) Residente 2) No residente") 
            residente = Console.ReadLine 

            If residente = "1" Then 
                descuento_residente = True 
            Else 
                descuento_residente = False 
            End If 

            Console.WriteLine("¿Cuál es la forma de pago?") 
            Console.WriteLine("1) Efectivo 2) IAVE - Crédito") 
            clave_pago = Console.ReadLine() 

            If clave_pago = "1" Then 
                forma_pago = "Efectivo" 
            ElseIf clave_pago = "2" Then
                forma_pago = "IAVE - Tarjeta" 
            End If 

            Select Case clave_vehiculo 
                Case "1" 
                    If descuento_residente = True Then  
                        cuota = 10 
                        moto_pago_r += cuota 
                    Else 
                        cuota = 60 
                        moto_pago += cuota 
                    End If 
                    Console.WriteLine("El pago es: $" & cuota) 
                    moto += 1 

                Case "2" 
                    If descuento_residente = True Then  
                        cuota = 15 
                        auto_pago_r += cuota 
                    Else 
                        cuota = 100 
                        auto_pago += cuota 
                    End If 
                    Console.WriteLine("El pago es: $" & cuota) 
                    auto += 1 

                Case "3" 
                    If descuento_residente = True Then  
                        cuota = 20 
                        camion_pago_r += cuota 
                    Else 
                        cuota = 150 
                        camion_pago += cuota 
                    End If 
                    Console.WriteLine("El pago es: $" & cuota) 
                    camion += 1 

                Case "4" 
                    If descuento_residente = True Then  
                        cuota = 30 
                        trailer_pago_r += cuota 
                    Else 
                        cuota = 200 
                        trailer_pago += cuota 
                    End If 
                    Console.WriteLine("El pago es: $" & cuota) 
                    trailer += 1 
            End Select 

            'Contador tipo de pago 
            If clave_pago = "1" Then 
                pago_efectivo += cuota 
            Else 
                pago_credito += cuota 
            End If 

            'Contador total de pago 
            total_cobrado += cuota 

            Console.WriteLine("Desea seguir capturando más vehículos? Escriba 1 para continuar") 
            cont_captura = Console.ReadLine() 

            If cont_captura = "1" Then 
                capturar = True 
            Else 
                capturar = False 
            End If 
        End While 

        'Calcular porcentajes 
        efectivo_perct = (pago_efectivo / total_cobrado) * 100  
        credito_perct = (pago_credito / total_cobrado) * 100 

        Console.WriteLine("** Datos totales ** ") 
        Console.WriteLine("********************") 
        Console.WriteLine("Total de vehículos capturados: " & contador_vehiculos) 
        Console.WriteLine("Total de motos que pagaron (unidades): " & moto)  
        Console.WriteLine("Importe de motos pago normal: $" & moto_pago)  
        Console.WriteLine("Importe de motos pago residente: $" & moto_pago_r) 
        Console.WriteLine("Total de autos que pagaron (unidades): " & auto)  
        Console.WriteLine("Importe de autos pago normal: $" & auto_pago)  
        Console.WriteLine("Importe de autos pago residente: $" & auto_pago_r) 
        Console.WriteLine("Total de camiones que pagaron (unidades): " & camion) 
        Console.WriteLine("Importe de camión pago normal: $" & camion_pago)  
        Console.WriteLine("Importe de camión pago residente: $" & camion_pago_r) 
        Console.WriteLine("Total de trailers que pagaron (unidades): " & trailer) 
        Console.WriteLine("Importe de trailer pago normal: $" & trailer_pago)  
        Console.WriteLine("Importe de trailer pago residente: $" & trailer_pago_r) 
        Console.WriteLine("El total cobrado en efectivo es: $" & pago_efectivo & " " & efectivo_perct & "%") 
        Console.WriteLine("El total cobrado en IAVE (Crédito) es: $" & pago_credito & " " & credito_perct & "%") 
        Console.WriteLine("Total cobrado por todos los autos: " & total_cobrado & " " & efectivo_perct + credito_perct & "%")
    End Sub 
End Module
