Elaborar un programa que permita registrar la información del cobro de inscripción de un alumno en la Facultad de Ingeniería Mochis. Se debe capturar lo siguiente:

- Clave de la carrera (1- Civil, 2- Geodésica, 3.- Software 4.-Ing. Procesos Industriales)
- Nombre del alumno
- Año escolar que va cursar (1- Primero, 2- Segundo, 3-Tercero. 4-Cuarto, 5- Quinto)
- Calificación promedio acumulado al grado anterior (o bien el que traen de bachillerato)

Además se debe capturar el importe del pago anual de inscripción (ejemplo: $ 2,000.00)
Se debe de calcular el pago aplicando un descuento en base a los siguientes criterios:
  - Solo se aplicará descuentos a los alumnos de 2do, 3ero, 4to y 5to
  - Cuando el promedio sea mayor de 9.0 se debe descontar 30% del pago anual
  - Si el promedio es de 8.0 a 9.0 su descuento será del 20% en el pago anual
  
Al terminar la captura se debe de mostrar en pantalla la siguiente información:
- Importe de descuento aplicado
- Importe de pago neto (ya con descuento)

## Datos de prueba para validar que su programa funcione correctamente: ($ 2,000.00 pesos cuota)

| Clave | Nombre de Alumno      | Año Escolar a Cursar | Calif Promedio | $ Neto (ya con Descto) |
|-------|-----------------------|-----------------------|----------------|------------------------|
| 2     | Jorge Luis Borges     | 3                     | 8.5            | $ 1,600.00            |
| 1     | Juan Rulfo            | 5                     | 9.1            | $ 1,400.00            |
| 1     | Amado Nervo           | 1                     | 9.8            | $2,000.00             |
| 3     | Carlos Fuentes        | 1                     | 9.4            | $2,000.00             |
| 1     | Octavio Paz           | 4                     | 7.5            | $2,000.00             |
| 4     | Pito Perez Peraza     | 2                     | 9.5            | $1,400.00             |
| 3     | Mario Vargas Llosa    | 2                     | 8.8            | $ 1,600.00            |
| 3     | Gabriel Garcia Marquez| 3                     | 7.2            | $2,000.00             |
| 2     | Pablo Neruda          | 1                     | 9.9            | $2,000.00             |
