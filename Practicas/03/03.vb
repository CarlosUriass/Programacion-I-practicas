Imports System

Module Program
    Dim student_name As String
    Dim anual_pay, student_pay As Single
    Dim major, grade As String
    Dim average As Single
    Dim major_key As String
    Dim enrroled_students As Short
    Dim total_discount, total_payments As Single

    Sub Main(args As String())

        Console.WriteLine(" MODULO DE INSCRIPCIÓN UAS ")
        Console.WriteLine("****************************")

        'Get student data
        enrroled_students += 1 'Count of students enrolled 

        Console.WriteLine("Ingrese el nombre del alumno: ")
        student_name = Console.ReadLine()
        Console.WriteLine("Ingrese la clave de la carrera:")
        Console.WriteLine("1) Ing. Civil. 2) Ing. Geodesica. 3) Ing. Software. 4) Ingenieria en Procesos I. ")
        major_key = Console.ReadLine()

        'Stores the major according to the key
        Select Case major_key
            Case "1"
                major = "Ingenieria Civil"
            Case "2"
                major = "Ingenieria Geodesica"
            Case "3"
                major = "Ingenieria de Software"
            Case "4"
                major = "Ingenieria en procesos industriales"
            Case Else
                Console.WriteLine("La clave de la carrera no coincide con ninguna carrera existente")
        End Select

        'Get grade and average
        Console.WriteLine("Ingrese el año del estudiante ")
        grade = Console.ReadLine()
        Console.WriteLine("Ingrese el promedio del estudiante: ")
        average = Console.ReadLine()

        'Inscription payment calculator
        Console.WriteLine("Ingrese el monto del pago de inscripcion bruto: ")
        anual_pay = Console.ReadLine()

        total_payments += anual_pay 'Acumulador del total de pagos

        If grade = "1" Or average < 8 Then
            student_pay = anual_pay
        ElseIf average > 9 Then
            student_pay = anual_pay - (anual_pay * 0.3)
            total_discount += (anual_pay * 0.3) 'Discount accumulator
        ElseIf average >= 8 And average < 9 Then
            student_pay = anual_pay - (anual_pay * 0.2)
            total_discount += (anual_pay * 0.2) 'Discount accumulator
        End If


        'Print total payments and counters 

        Console.WriteLine("El alumno " & student_name & " De la carrera " & major & " Con promedio de " & average & " Tiene un total a pagar: $" & student_pay)
        Console.WriteLine("El total de los estudiantes inscritos es: " & enrroled_students)
        Console.WriteLine("El total del importe bruto de las inscripciones es: " & total_payments)
        Console.WriteLine("El total de los descuentos aplicados es: " & total_discount)
        Console.WriteLine("El toal del importe neto de las inscripciones es: " & total_payments - total_discount)

        'Exit program
        Console.WriteLine("Presione cualquier tecla para salir ")
        Console.ReadKey()



    End Sub
End Module
