
def Ejercicio1():
 for x in range(100):
    if x % 3 == 0:
        print("Multiplo de 3 encontrado", x)

def Ejercicio2():
    edad = int(input("Por favor, ingresa tu edad: "))
    if edad > 18:
        print("Usted es mayor de edad")
    elif edad < 18:
        print("Usted es menor de edad")
    else:
        print("Usted tiene exactamente 18 años")

def Ejercicio3():
    palabra = input("Por favor, ingrese una palabra: ")
    LargoPalabra = 0
    for x in palabra:
      LargoPalabra += 1
    print("El largo de su palabra es de: ", LargoPalabra)
def Ejercicio4():
    ContraseñaSecreta = "AguanteBoca"
    for x in range(5):
        Adivinar = input("Por favor, ingrese la contraseña: ")
        if Adivinar == ContraseñaSecreta:
            print("Contraseña correcta")
            break;
        else:
            print("Contraseña incorrecta")

def Ejercicio5():
    NumeroMasAlto = 0
    for x in range(10):
        Numero = int(input("Por favor, ingrese un numero: "))
        if Numero > NumeroMasAlto:
            NumeroMasAlto = Numero
    print("El numero mas alto es ", NumeroMasAlto)

def Ejercicio6():
    Nombre = input("Por favor, ingrese tu nombre: ")
    Nombre = Nombre[0].upper() + Nombre[1:]
    print("¡Hola!", Nombre)

def Ejercicio7():
    for x in range(10):
        Numero = 7 * x
        print(Numero)

def Ejercicio8():
    for x in range(10,0,-1):
        print(x)
    print("oa")

def Ejercicio9():
   Numero = int(input("Por favor, ingrese un numero: "))
   if Numero % 2 == 0:
       print("Su numero es par")
   else:
       print("Su numero es impar")

def Ejercicio10():
    Frase = input("Por favor, ingrese una frase: ")
    Frase = Frase.lower()
    CantidadDeVocales = 0
    for x in Frase:
        if (x == "a" or x == "e" or x == "i" or x == "o" or x == "u"):
            CantidadDeVocales += 1
    print("La cantidad de vocales es de: ", CantidadDeVocales)
def Ejercicio11():
    Numero = int(input("Por favor, ingrese un numero: "))
    for x in range(12):
        print (Numero * x)
def Ejercicio12():
    Numero = 0
    while Numero < 100:
        Numero += int(input("Por favor, ingrese un numero: "))
def Ejercicio13():
    palabra = input("Por favor, ingresa una palabra: ")
    for letra in palabra:
        print(letra)
def Ejercicio14():
    edad = int(input("Por favor, ingresa tu edad: "))
    if edad >= 16 and edad >= 17:
        print("Puede votar y manejar.")
    elif edad >= 16:
        print("Solo puede votar.")
    elif edad >= 17:
        print("Solo puede manejar.")
    else:
        print("No puede hacer ninguna de las dos cosas.")
def Ejercicio15():
    for x in range(50,0,-5):
        print(x)
def Ejercicio16():
    ContraseñaSecreta = "AguanteBoca"
    for x in range(2):
        Adivinar = input("Por favor, ingrese la contraseña: ")
        if Adivinar == ContraseñaSecreta:
            print("Acceso permitido")
            break;
        else:
            print("Acceso denegado")
def Ejercicio17():
    LargoDelNombre = 0
    while LargoDelNombre < 10:
        LargoDelNombre = 0
        Nombre = input("Por favor, ingrese una nombre: ")
        for x in Nombre:
            LargoDelNombre += 1
def Ejercicio18():
    Frase = input("Por favor, ingrese una frase: ")
    Frase = Frase.lower()
    CantidadDeA = 0
    for x in Frase:
        if (x == "a"):
            CantidadDeA += 1
    print("La cantidad de A es de: ", CantidadDeA)