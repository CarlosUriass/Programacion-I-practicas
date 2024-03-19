Imports System 
Imports System.Runtime.InteropServices 

Module Program 
    Dim saler_key As Byte 'clave vendedor 
    Dim sale_key As Integer 'Clave de la venta 
    Dim payment_type As Byte 'Tipo de venta contado/credito  
    Dim amount, commission As Double 'Total de venta y comisión  
    Dim Array(30, 4) As Double 'Matriz 
    Dim next_sale As Byte 'Dato para continuar capturando  
    Dim total_cash, total_credit, total_commission As Double  

    Sub Main(args As String()) 
        Do 
            'Capturar nota de venta 
            Do 
                Console.WriteLine("Ingrese la nota de venta: ")  
                sale_key = Console.ReadLine() 
            Loop While sale_key <= 0 

            'Capturar clave del vendedor 
            Do 
                Console.WriteLine("Ingrese la clave del vendedor: ")  
                saler_key = Console.ReadLine() 
            Loop While saler_key > 30 

            'Capturar importe de la venta 
            Do 
                Console.WriteLine("Ingrese el importe de la venta: ")  
                amount = Console.ReadLine() 
            Loop While amount = 0 

            'Capturar método de pago 
            Console.WriteLine("¿Cuál fue el método de pago? ")  
            Console.WriteLine("1) Contado. 2) Crédito")  
            payment_type = Console.ReadLine() 

            Select Case payment_type 
                Case 1 
                    commission = amount * 0.02 
                Case 2 
                    commission = amount * 0.015 
            End Select 

            'Agregar datos a la matriz 
            Array(saler_key, (payment_type + 1)) += amount  
            Array(saler_key, 4) += commission 

            'Preguntar al usuario si seguir capturando  
            Console.WriteLine("¿Seguir Capturando más ventas? ") 
            Console.WriteLine("1) Si 2) No")  
            next_sale = Console.ReadLine() 

        Loop While next_sale <> 2 

        'Imprimir matriz 
        For i As Integer = 1 To 30 
            If Array(i, 4) > 0 Then 
                Console.WriteLine("Vendedor: " & i & " " & "Ventas de contado:  " & Array(i, 2) & " " & "Ventas a crédito: " & Array(i, 3) & " " & "Comisión a pagar: " & Array(i, 4)) 
            End If 
        Next 

        For j As Integer = 1 To 30 
            total_cash += Array(j, 2) 
            total_credit += Array(j, 3) 
            total_commission += Array(j, 4) 
        Next 

        Console.WriteLine("Suma Ventas al contado: " & total_cash)  
        Console.WriteLine("Suma Ventas a crédito: " & total_credit)  
        Console.WriteLine("Suma de las comisiones a pagar: " & total_commission) 

        Console.WriteLine("Presione cualquier tecla para salir")  
        Console.ReadKey() 
    End Sub 
End Module
