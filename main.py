import random


def ejercicio1():
    secreto = random.randint(1, 10)
    intento = 0
    while intento != secreto:
        intento = int(input("Adiviná el número (1 al 10): "))
        if intento < secreto:
            print("Es mayor")
        elif intento > secreto:
            print("Es menor")
    print("¡Adivinaste!")


def ejercicio2():
    num = int(input("Ingresá un número: "))
    for i in range(1, num + 1):
        if num % i == 0:
            print(i)


def ejercicio3():
    a = 0
    b = 1
    for i in range(20):
        print(a)
        siguiente = a + b
        a = b
        b = siguiente


def ejercicio4():
    op = input("Operación (suma, resta, multiplicacion, division): ")
    n1 = float(input("Primer número: "))
    n2 = float(input("Segundo número: "))
    if op == "suma":
        print(n1 + n2)
    elif op == "resta":
        print(n1 - n2)
    elif op == "multiplicacion":
        print(n1 * n2)
    elif op == "division":
        if n2 != 0:
            print(n1 / n2)
        else:
            print("No se puede dividir por cero")


def ejercicio5():
    num = int(input("Ingresá un número: "))
    fact = 1
    for i in range(1, num + 1):
        fact = fact * i
    print("Factorial:", fact)


def ejercicio6():
    turnos = []
    nombre = input("Ingresá nombre (o 'fin' para terminar): ")
    while nombre != "fin":
        turnos.append(nombre)
        nombre = input("Ingresá nombre (o 'fin' para terminar): ")

    for i in range(len(turnos)):
        print("Turno", i + 1, ":", turnos[i])


def ejercicio7():
    pares = 0
    for i in range(1, 101):
        if i % 2 == 0:
            pares = pares + 1
    print("Cantidad de pares:", pares)


def ejercicio8():
    seguir = "si"
    while seguir == "si":
        c = float(input("Grados Celsius: "))
        f = (c * 9 / 5) + 32
        print("Fahrenheit:", f)
        seguir = input("¿Convertir otro? (si/no): ")


def ejercicio9():
    num = int(input("Ingresá un número: "))
    divisores = 0
    for i in range(1, num + 1):
        if num % i == 0:
            divisores = divisores + 1
    if divisores == 2:
        print("Es primo")
    else:
        print("No es primo")


def ejercicio10():
    nombres = []
    nombre = input("Ingresá un nombre (o 'fin'): ")
    while nombre != "fin":
        nombres.append(nombre)
        nombre = input("Ingresá un nombre (o 'fin'): ")

    for n in nombres:
        print("Hola", n)


def ejercicio11():
    nombres = []
    repetido = False
    while repetido == False:
        nombre = input("Ingresá un nombre: ")
        if nombre in nombres:
            repetido = True
        else:
            nombres.append(nombre)
    print("Ingresaste", len(nombres), "nombres antes del repetido")


def ejercicio12():
    for i in range(100, 201):
        if i % 7 == 0 and i % 10 == 3:
            print(i)


def ejercicio13():
    total = 0
    cantidad = 0
    while total <= 1000:
        precio = float(input("Precio del producto: "))
        total = total + precio
        cantidad = cantidad + 1
    print("Productos cargados:", cantidad)


def ejercicio14():
    nombre = input("Nombre: ")
    edad = input("Edad: ")
    while edad.isdigit() == False:
        edad = input("Edad inválida. Ingresá un número: ")

    mail = input("Mail: ")
    while "@" not in mail:
        mail = input("Mail inválido. Debe tener @: ")

    print("Datos:", nombre, edad, mail)


def ejercicio15():
    numero = input("Ingresá un número: ")
    for digito in numero:
        print(digito)


def ejercicio16():
    opciones = ["piedra", "papel", "tijera"]
    usuario_pts = 0
    pc_pts = 0
    for i in range(3):
        usuario = input("Elegí piedra, papel o tijera: ")
        pc = random.choice(opciones)
        print("PC eligió:", pc)
        if usuario == pc:
            print("Empate")
        elif (usuario == "piedra" and pc == "tijera") or (usuario == "papel" and pc == "piedra") or (
                usuario == "tijera" and pc == "papel"):
            print("Ganaste ronda")
            usuario_pts = usuario_pts + 1
        else:
            print("Ganó PC")
            pc_pts = pc_pts + 1

    if usuario_pts > pc_pts:
        print("Ganaste el juego")
    elif pc_pts > usuario_pts:
        print("Ganó la PC")
    else:
        print("Empate final")


def ejercicio17():
    mayores = 0
    for i in range(10):
        num = random.randint(1, 100)
        print(num)
        if num > 50:
            mayores = mayores + 1
    print("Mayores a 50:", mayores)


def ejercicio18():
    suma = 0
    mejor_nota = -1
    mejor_nombre = ""
    for i in range(5):
        nombre = input("Nombre: ")
        nota = float(input("Nota: "))
        suma = suma + nota
        if nota > mejor_nota:
            mejor_nota = nota
            mejor_nombre = nombre
    print("Promedio:", suma / 5)
    print("Mejor nota:", mejor_nombre, "con", mejor_nota)


def ejercicio19():
    letras = "ZYXWVUTSRQPONMLKJIHGFEDCBA"
    for letra in letras:
        print(letra)
