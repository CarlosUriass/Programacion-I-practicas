# MATERIA: PROGRAMACION I : EJERCICIO PRACTICO DE SOFTWARE PARA CALCULAR EL PAGO DE COMISIONES A LOS VENDEDORES DE UNA ABARROTERA

Elaborar un programa en Visual Basic que permita capturar las notas de ventas que se realizan en una abarrotera en cierto día. Para lo cual por cada nota de venta se debe capturar:

- Número de nota de venta (no permitir número de venta menor o igual a 0)
- Clave # de vendedor (son 30 agentes de ventas que laboran en la abarrotera, validar)
- Tipo de pago en la venta (contado o crédito)
- Importe de venta (no permita cero)

A los agentes de venta se le paga comisión de acuerdo al siguiente criterio:

- Sobre las ventas de contado se le paga el 2% de comisión.
- Sobre las ventas a crédito se le paga el 1.5% de comisión.

No se sabe cuántas notas de ventas se realizarán en el día.

Al final de la captura, su programa debe mostrar "algo similar a esto":

```
| Clave de Vendedor | $ Ventas de Contado | $ Ventas de Crédito | Comisión a Pagar $ |
|-------------------|---------------------|----------------------|----------------------|
| VENDEDOR - 2      | $ 0.00              | $ 10,640.00          | $ 159.60             |
| VENDEDOR - 5      | $ 3,140.00          | $ 25,725.00          | $ 447.80             |
| VENDEDOR - 8      | $ 0.00              | $ 23,168.20          | $ 347.53             |
| VENDEDOR – 10     | $ 5,790.00          | $ 19,488.00          | $ 550.00             |
| >>>>>>>>>>>>>SUMAS: | $ 45,000.00       | $ 120,000.00         | $ 2,700.00           |
```

**NOTA:** Que únicamente se impriman los renglones de los vendedores que realizaron ventas.

**DATOS DE PRUEBA:**

| # Nota Venta | Clave Vendedor | Tipo Pago | Importe $ Venta |
|--------------|----------------|-----------|-----------------|
| 14023        | VEND - 14      | CRÉDITO   | $ 14,824.50     |
| 5125         | VEND – 05      | CONTADO   | $ 3,140.00      |
| 8220         | VEND – 08      | CRÉDITO   | $ 23,168.20     |
| 10182        | VEND – 10      | CRÉDITO   | $ 19,488.00     |
| 14024        | VEND – 14      | CONTADO   | $ 8,240.00      |
| 2460         | VEND - 02      | CRÉDITO   | $ 10,640.00     |
| 5126         | VEND – 05      | CRÉDITO   | $ 25,725.00     |
| 4444         | VEND – 04      | CONTADO   | $ 44,400.00     |
| 10183        | VEND - 10      | CONTADO   | $ 5,790.00      |