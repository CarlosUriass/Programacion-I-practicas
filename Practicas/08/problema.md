# NOTAS DE PRESUPUESTO GOBIERNO SINALOA 2024

Elaborar un programa que permita capturar todas las notas del presupuesto de gastos que se van a aplicar en Sinaloa en el ejercicio 2024. Por cada nota se debe capturar:

- Número de folio de la nota (99999999).
- Número de municipio de Sinaloa (1 … 18).
- Rubro/Sector/Concepto donde se va a aplicar el gasto:
  - 1. Salud
  - 2. Educación
  - 3. Seguridad
  - 4. Cultura
  - 5. Turismo
- Importe en pesos ($$$) de dicho gasto.

Algo así como esto:

| FOLIO | MUNIC | MUNICIPIO   | SECTOR    | IMPORTE      |
|-------|-------|-------------|-----------|--------------|
| 1     | 6     | Culiacán    | Salud     | $10,000.00   |
| 2     | 1     | Ahome       | Educación | $20,000.00   |
| 3     | 6     | Culiacán    | Seguridad | $30,000.00   |
| 4     | 10    | El Fuerte   | Cultura   | $40,000.00   |
| 5     | 12    | Mazatlán    | Seguridad | $50,000.00   |
| 6     | 6     | Culiacán    | Educación | $60,000.00   |
| 7     | 1     | Ahome       | Salud     | $70,000.00   |
| 8     | 7     | Choix       | Educación | $80,000.00   |
| 9     | 10    | El Fuerte   | Educación | $90,000.00   |
| 10    | 6     | Culiacán    | Educación | $100,000.00  |
| 11    | 1     | Ahome       | Salud     | $25,000.00   |
| 12    | 7     | Choix       | Seguridad | $35,000.00   |
| 13    | 9     | Escuinapa   | Turismo   | $45,000.00   |
| 14    | 6     | Culiacán    | Salud     | $55,000.00   |
| 15    | 1     | Ahome       | Educación | $65,000.00   |

**SUMA:** $775,000.00

Al final de la captura mostrar los 2 concentrados:

**CONCENTRADO DE PRESUPUESTO SINALOA MUNICIPIO-RUBRO**

| MUNICIPIO | RUBRO     | IMPORTE      |
|-----------|-----------|--------------|
| Ahome     | Educación | $85,000.00   |
| Ahome     | Salud     | $95,000.00   |
| Culiacán  | Educación | $160,000.00  |
| Culiacán  | Salud     | $65,000.00   |
| Culiacán  | Seguridad | $30,000.00   |
| Choix     | Educación | $80,000.00   |
| Choix     | Seguridad | $35,000.00   |
| Escuinapa | Turismo   | $45,000.00   |
| El Fuerte | Cultura   | $40,000.00   |
| El Fuerte | Educación | $90,000.00   |
| Mazatlán  | Seguridad | $50,000.00   |

**SUMA:** $775,000.00

**CONCENTRADO DE PRESUPUESTO SINALOA 2021 X MUNICIPIO**

| MUNICIPIO | %          | IMPORTE      |
|-----------|------------|--------------|
| Ahome     | 23.2%      | $180,000.00  |
| Culiacán  | 32.9%      | $255,000.00  |
| Choix     | 14.8%      | $115,000.00  |
| Escuinapa | 5.8%       | $45,000.00   |
| El Fuerte | 16.8%      | $130,000.00  |
| Mazatlán  | 6.5%       | $50,000.00   |

**SUMA:** $775,000.00

*NOMMUNIC(1) = ‘AHOME’*  
*NGASTO(1) = ‘SALUD’*  
*NGASTO(2) = ‘EDUCACION’*