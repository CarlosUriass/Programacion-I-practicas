```markdown
# Programa de Registro de Ventas de Combustible

Elaborar un programa que permita capturar y procesar todas las notas de venta de combustible de un día, que se efectuaron en una Estación de Servicio (Gasolinera). Para lo cual cada nota de venta contiene los siguientes datos:

- Tipo de combustible (Puede ser Diesel, Magna o Premium)
- Número de litros cargados
- Tipo de Pago (Puede ser Efectivo, tarjeta Crédito o Cheque)

**PRECIOS VIGENTES DE LOS PRODUCTOS:**

- Litro Diesel: $24.17
- Litro Magna: $22.34
- Litro Premium: $24.22

Al final de la captura, el programa deberá mostrar en pantalla algo similar a esto:

```
TOTALES DE VENTA       | LITROS     | IMPORTE
-----------------------|------------|-------------
DIESEL                 | 8,364.00   | $202,157.88
MAGNA                  | 4,000.00   | $ 89,360.00
PREMIUM                | 3,500.00   | $ 84,770.00
-----------------------|------------|-------------
SUMAS:                 | 15,864.00  | $ 376,287.88
```

**DATOS DE PRUEBA:**

| TIPO COMBUSTIBLE | LITROS CARGADOS | IMPORTE DE NOTA | TIPO DE PAGO |
|------------------|-----------------|-----------------|---------------|
| MAGNA            | 50.00           | $1,117.00       | EFECTIVO      |
| DIESEL           | 300.00          | $7,251.00       | TARJETA CRÉDITO |
| DIESEL           | 400.00          | $9,668.00       | CHEQUE        |
| PREMIUM          | 60.50           | $1,465.31       | EFECTIVO      |
| MAGNA            | 20.00           | $446.80         | EFECTIVO      |
| PREMIUM          | 40.50           | $980.91         | EFECTIVO      |
| MAGNA            | 80.00           | $1,787.20       | TARJETA CRÉDITO |

```
TOTALES DE VENTA       | LITROS     | IMPORTE
-----------------------|------------|-------------
DIESEL                 | 700.00     | $16,919.00
MAGNA                  | 150.00     | $ 3,351.00
PREMIUM                | 101.00     | $ 2,446.22
-----------------------|------------|-------------
SUMAS:                 | 951.00     | $ 22,716.22

VENTAS EN EFECTIVO: $ 4,010.02
VENTAS CON TARJETA DE CRÉDITO: $ 9,038.20
VENTAS CON CHEQUE: $ 9,668.00
```

**EN ESTE PROGRAMA APRENDEREMOS:**

- Group Box (caja agrupadora)
- Radio Button / Personalizarlos y usarlos en IF con la propiedad .checked
- Dar Formato a los valores numéricos tipo Moneda en label
- Alinear a la derecha una caja de texto (LITROS VENDIDOS / TextAlign -> Right)
- Fijar el Focus en el objeto deseado del formulario
- Modificar la propiedad Font y la propiedad backColor
```
