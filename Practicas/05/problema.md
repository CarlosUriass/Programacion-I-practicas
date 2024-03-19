# UAS / FACULTAD DE INGENIERIA MOCHIS / MATERIA: PROGRAMACION I

## Planteamiento del Problema por Resolver con un Software

Elaborar un programa que permita capturar los datos de todos los vehículos que pasen por la caseta de cobro de San Miguel, Ahome, Sinaloa, durante un turno en una de las casetas. Para ello, se debe capturar:

- Tipo de vehículo (moto, automóvil, pick-up, camión, trailer, etc.)
- Forma de pago (efectivo o IAVE-crédito)
- Usuario normal o residente (de los que viven cerca de la caseta y pagan cuota simbólica)

Las tarifas que se cobran son:

| Tipo de Vehículo        | Importe Normal | Importe Residente |
|--------------------------|----------------|-------------------|
| Motocicleta              | $60.00         | $10.00            |
| Automóvil o Pick-up      | $100.00        | $15.00            |
| Camión de 2 o 3 ejes     | $150.00        | $20.00            |
| Trailer de 3 a 5 ejes    | $200.00        | $30.00            |

Considerar que van a pasar "N" vehículos por turno.

Al final de la captura, su programa debe mostrar algo similar a este resumen:


| Tipo de Vehículo          | Unidades que Pagaron | Importe Pago Normal | Importe Pago Residente |
|---------------------------|-----------------------|---------------------|------------------------|
| Motocicleta               | 1                     | $0.00               | $10.00                 |
| Automóvil o Pick-up (2 Ejes) | 6                   | $500.00             | $15.00                 |
| Camión de 2 o 3 ejes      | 2                     | $300.00             | $0.00                  |
| Trailer de 3 a 5 ejes     | 2                     | $400.00             | $0.00                  |
| Sumas                     | 11                    | $1,200.00           | $25.00                 |

Además, que muestre la siguiente información:
- El $ total cobrado en efectivo: $750.00 ... 62.5%
- El $ total cobrado con tarjeta IAVE (crédito): $450.00 ... 37.5%
- El global de $ por todos los autos (efectivo + IAVE): $1,200.00 ... 100%


## Datos de Prueba:
- Automóvil / Pick-up - Pago Normal
- Camión de 2 o 3 ejes - Pago Normal
- Automóvil / Pick-up - Pago Normal
- Trailer de 3 a 5 ejes - Pago Normal
- Automóvil / Pick-up - Residente
- Motocicleta - Residente
- Automóvil / Pick-up - Pago Normal
- Camión de 2 o 3 ejes - Pago Normal
- Automóvil / Pick-up - Pago Normal
- Trailer de 3 a 5 ejes - Pago Normal