import random

def generar_cadena():
    numeros = "0123456789"
    meses = ["01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"]
    años = ["20", "21", "22", "23", "24"]  # Solo dos dígitos para el año
    compañias = ["T", "M", "U", "P", "A"]
    precios = ["020", "030", "050", "100", "200", "500"]

    dia = random.randint(1, 31)  # Genera un día aleatorio
    mes = random.choice(meses)  # Selecciona un mes aleatorio
    año = "20" + random.choice(años)  # Selecciona un año aleatorio
    fecha = f"{dia:02d}/{mes}/{año}"  # Formatea la fecha

    numeros_telefono = ''.join(random.choices(numeros, k=10))  # Genera un número de teléfono aleatorio

    compañia = random.choice(compañias)  # Selecciona una compañía aleatoria
    precio = random.choice(precios)  # Selecciona un precio aleatorio

    return f"{fecha},{numeros_telefono},{compañia},{precio}"

with open("resultados.txt", "w") as archivo:
    for _ in range(100000):
        cadena = generar_cadena()
        archivo.write(cadena + "\n")

