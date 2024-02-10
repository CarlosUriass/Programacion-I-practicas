Imports System

Module Program
    Dim client_name As String
    Dim pieces As Integer
    Dim unit_price, total_sale As Single
    Sub Main(args As String())
        Console.WriteLine("** CALCULO VENTA DE LADRILLOS **")
        Console.WriteLine("--------------------------------")

        'Get data of client and sale
        Console.WriteLine("Captura el nombre del cliente: ")
        client_name = Console.ReadLine()
        Console.WriteLine("Captura las piezas vendidas: ")
        pieces = Console.ReadLine()

        'Calcule unit price 
        If pieces < 1000 Then
            unit_price = 8.0
        ElseIf pieces < 5000 Then
            unit_price = 7.5
        ElseIf pieces < 100000 Then
            unit_price = 6.5
        Else
            unit_price = 5.9
        End If

        'Print total sale 
        total_sale = pieces * unit_price
        Console.WriteLine("Total de la venta es = $" & total_sale)

        Console.WriteLine("Presione cualquier letra para salir: ")
        Console.ReadKey()

    End Sub
End Module