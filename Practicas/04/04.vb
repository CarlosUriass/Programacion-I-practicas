Imports System

Module Program

    Dim harvest_kg, harvest_ton, harvest_discounted, kg_discount As Double
    Dim humidity As Single
    Dim price_per_ton, amount As Double

    Sub Main(args As String())
        Console.WriteLine("CALCULADORA DE PAGOS POR COSECHA")
        Console.WriteLine("********************************")

        'Get data of harvest
        Console.WriteLine("Cuantos kg es su cosecha?")
        harvest_kg = Console.ReadLine()
        Console.WriteLine("¿Cual es el porcentaje de humedad que tiene la cosecha?")
        humidity = Console.ReadLine()
        Console.WriteLine("¿Cual es el precio por tonelada?")
        price_per_ton = Console.ReadLine()

        'Kg discount per humidity calculator 

        If humidity > 14.0 And humidity <= 16 Then
            harvest_discounted = harvest_kg - (harvest_kg * 0.03)
            kg_discount = harvest_kg * 0.03
        ElseIf humidity > 16 And humidity <= 18 Then
            harvest_discounted = harvest_kg - (harvest_kg * 0.05)
            kg_discount = harvest_kg * 0.05
        ElseIf humidity > 18 Then
            harvest_discounted = harvest_kg - (harvest_kg * 0.07)
            kg_discount = harvest_kg * 0.07
        Else
            harvest_discounted = harvest_kg
            kg_discount = 0
        End If


        'Kg to Ton
        harvest_ton = harvest_discounted / 1000

        'Payment calculator 
        amount = (harvest_ton * price_per_ton)


        Console.WriteLine("Kilos entregados: " & harvest_kg)
        Console.WriteLine("Porcentaje de humedad: " & humidity & " % ")
        Console.WriteLine("Kilos descontados: " & Math.Round(kg_discount, 2))
        Console.WriteLine("Kilos pagados: " & Math.Round(harvest_discounted, 2))
        Console.WriteLine("Total a pagar: $" & Math.Round(amount, 2))


        'Exit the program 
        Console.WriteLine("Presione cualquier letra para salir ")


    End Sub
End Module