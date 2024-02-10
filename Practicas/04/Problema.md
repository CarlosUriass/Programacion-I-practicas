# Programa para calcular el importe neto a pagar de la cosecha de un agricultor

Este programa permite calcular el importe neto a pagar de la cosecha de un agricultor. Consideramos que el agricultor entrega en la bodega su cosecha de K kilos de maíz. La bodega le revisa el % de humedad que presenta el maíz y le aplica un descuento dependiendo de la humedad.

Porcentaje de humedad | % Kilos descontados
-----------------------|---------------------
14% o menor            | 0 (cero)
De 14.01 a 16.00       | 3%
De 16.01 a 18.00       | 5%
De 18.01 en adelante    | 7%

En base a estos criterios, se calcula el importe neto a pagar al agricultor. Se proporciona el precio por tonelada de maíz, ej: $5,800.

## Datos de prueba del programa:

| Kilos entregados | Porcentaje de humedad | Kilos descontados | Kilos pagados | Precio por tonelada | Importe a pagar |
|------------------|------------------------|-------------------|---------------|---------------------|-----------------|
| 1,000            | 17.0%                  | 50                | 950           | $5,800.00           | $5,510.00       |
| 20,000           | 14.0%                  | 0                 | 20,000        | $5,800.00           | $116,000.00     |
| 10,000           | 19.0%                  | 700               | 9,300         | $5,800.00           | $53,940.00      |
| 24,000           | 15.5%                  | 720               | 23,280        | $5,800.00           | $135,024.00     |

Al final del programa se mostrarán los kilos pagados y el importe a pagar al agricultor por su cosecha.
