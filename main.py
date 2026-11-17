
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