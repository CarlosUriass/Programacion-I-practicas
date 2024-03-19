Imports System

Module Program
    Dim folio As String
    Dim importe As Double
    Dim matriz(18, 5) As Double
    Dim Seguir As Boolean
    Dim seguir_str As String
    Dim municipio As Byte
    Dim Sector As Byte
    Dim nombre_sector As String
    Dim municipios(18) As String
    Dim total_municipio As Double
    Dim total_estado As Double

    Sub Main(args As String())

        'Declarar nombres de los municipios
        municipios(1) = "Ahome"
        municipios(2) = "Angostura"
        municipios(3) = "Badiraguato"
        municipios(4) = "Concordia"
        municipios(5) = "Cosalá"
        municipios(6) = "Culiacán"
        municipios(7) = "Choix"
        municipios(8) = "Elota"
        municipios(9) = "Escuinapa"
        municipios(10) = "El Fuerte"
        municipios(11) = "Guasave"
        municipios(12) = "Mazatlán"
        municipios(13) = "Mocorito"
        municipios(14) = "Rosario"
        municipios(15) = "Salvador Alvarado"
        municipios(16) = "San Ignacio"
        municipios(17) = "Sinaloa de Leyva"
        municipios(18) = "Navolato"

        Do
            Console.WriteLine("Ingrese el folio de la nota: ")
            folio = Console.ReadLine()
            Do
                Console.WriteLine("Ingrese el numero de municipio: ")
                municipio = Console.ReadLine()
            Loop While municipio > 18

            Console.WriteLine("Ingrese el rubro donde se va a aplicar el gasto")
            Console.WriteLine("1) Salud. 2) Educación 3) Seguridad 4) Cultura 5) Turismo")
            Sector = Console.ReadLine()
            Console.WriteLine("¿Cual es el importe? ")
            importe = Console.ReadLine()

            'Llenar Matriz
            matriz(municipio, Sector) += importe
            'Suma total de importes en el muncipio
            total_estado += importe

            'Preguntar al usuario si seguir capturando
            Console.WriteLine("Seguir capturando mas? 1) Si 2) No")
            seguir_str = Console.ReadLine

            Select Case seguir_str
                Case 1
                    Seguir = True
                Case 2
                    Seguir = False
            End Select

        Loop While Seguir = True

        'Imprimir concentrado del presupuesto
        For i As Integer = 1 To 18
            For j As Integer = 1 To 5
                Select Case j
                    Case 1
                        nombre_sector = "Salud"
                    Case 2
                        nombre_sector = "Educación"
                    Case 3
                        nombre_sector = "Seguridad"
                    Case 4
                        nombre_sector = "Cultura"
                    Case 5
                        nombre_sector = "Seguridad"
                End Select

                'Solo imprime los campos donde hay datos
                If matriz(i, j) > 0 Then
                    Console.WriteLine("Municipio: " & municipios(i) & " Sector: " & nombre_sector & " Total = " & matriz(i, j))
                End If
            Next
        Next

        'Imprime la suma total
        Console.WriteLine("La suma total es: " & Math.Round(total_estado), 2)

        Console.WriteLine("Presione cualquier tecla para mostrar el reporte 2 ")
        Console.ReadKey()

        'Recorrer la matriz para ir sumando las cantidades
        For i As Integer = 1 To 18
            total_municipio = 0 'Reinciar el valor de la variable en cada iteración
            For j As Integer = 1 To 5
                If matriz(i, j) > 0 Then
                    total_municipio += matriz(i, j)
                End If
            Next

            If total_municipio > 0 Then
                Console.WriteLine("Muncipio " & municipios(i) & " " & Math.Round(((total_municipio / total_estado) * 100), 2) & "% " & "$" & total_municipio)
            End If
        Next

        Console.WriteLine("La suma total es: " & Math.Round(total_estado), 2)
    End Sub
End Module
