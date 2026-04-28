using System.ComponentModel.Design;
using System.Reflection;
Console.WriteLine("Por favor, ingrese el numero del ejercicio al cual desea ingresar");
string ingresado = Console.ReadLine();
string nuevoingresado = ingresado.ToUpper();
switch (nuevoingresado)
{
    case "A":
        ejercicioA();
        break;
    case "B":
        ejercicioB();
        break;
    case "C":
        ejercicioC();
        break;
    case "D":
        ejercicioD();
        break;
    case "E":
        ejercicioE();
        break;
    case "F":
        ejercicioF();
        break;
    case "G":
        ejercicioG();
        break;
    case "H":
        ejercicioH();
        break;
    case "I":
        ejercicioI();
        break;
    case "J":
        ejercicioJ();
        break;
    case "K":
        ejercicioK();
        break;
    case "L":
        ejercicioL();
        break;
    case "M":
        ejercicioM();
        break;
    case "N":
        ejercicioN();
        break;
    case "O":
        ejercicioO();
        break;
    case "P":
        ejercicioP();
        break;
    case "Q":
        ejercicioQ();
        break;
    case "R":
        ejercicioR();
        break;
    default:
        Console.WriteLine("Parametros erroneos, ingrese el numero del ejercicio al cual desea ingresar");
        ingresado = Console.ReadLine();
        nuevoingresado = ingresado.ToUpper();
        break;
}






void ejercicioA()
{
    for (int x = 0; x <= 100; x += 3)
    {
        Console.WriteLine(x);
    }
}


void ejercicioB()
{
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad > 18)
    {

        Console.WriteLine("Usted es mayor de edad");

    }
    else if (edad < 18)
    {

        Console.WriteLine("Usted es menor de edad");
    }
    else
    {

        Console.WriteLine("Usted tiene exactamente 18 años");


    }

}


void ejercicioC()
{
    Console.WriteLine("Escribí una palabra:");
    string palabra = Console.ReadLine();

    int cantidad = palabra.Length;

    Console.WriteLine("La palabra tiene " + cantidad + " letras.");
}


void ejercicioD()
{

    int acum = 0;
    Console.WriteLine("Intente adivinar la contraseña, solo tiene 5 intentos");
    string adiv = Console.ReadLine();
    while (acum <= 3 && adiv != "bocajrs")
    {
        acum = acum + 1;
        Console.WriteLine("Intente de vuelta");
        adiv = Console.ReadLine();
    }
    if (adiv != "bocajrs")
    {
        Console.WriteLine("Acceso denegado, no ha logrado adivinar la contraseña secreta");
    }
    else
    {
        Console.WriteLine("Felicidades, ha adivinado la contraseña");
    }
}

void ejercicioE()
{



    Console.WriteLine("Ingrese un número:");
    int mayor = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= 10; i++)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > mayor)
        {
            mayor = numero;
        }
    }

    Console.WriteLine("El número más alto es " + mayor);



}


void ejercicioF()
{
    Console.WriteLine("Por favor, escriba su nombre");

    string nombre = Console.ReadLine();
    Console.WriteLine("Por favor, ingrese que cantidad de letras de su nombre desea mostrar en mayuscula");
    int numeroparte = (Convert.ToInt32(Console.ReadLine()));

    string parte = nombre.Substring(0, numeroparte);
    string partemayu = parte.ToUpper();
    Console.WriteLine(partemayu);


}

void ejercicioG()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i * 7);
    }
}

void ejercicioH()
{
    for (int i = 10; i > 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("oa");


}

void ejercicioI()
{
    Console.WriteLine("Ingrese un numero");
    int numeroing = (Convert.ToInt32(Console.ReadLine()));
    if (numeroing % 2 == 0)
    {
        Console.WriteLine("su numero es par");
    }
    else
    {
        Console.WriteLine("su numero no es par");
    }
}

void ejercicioJ()
{
    string vocales = "aeiou";
    Console.WriteLine("Ingrese una frase");
    string frase = Console.ReadLine();
    string frasenueva = frase.ToLower();
    int acum = 0;
    foreach (char c in vocales)
    {
        foreach (char d in frasenueva)
        {
            if (c == d)
            {
                acum = acum + 1;
                
            }
        }
    }
    Console.WriteLine("La cantidad de vocales en su frase ingresada es de " + acum + "");
}

void ejercicioK()
{
    Console.WriteLine("Por favor, ingrese un numero");
    int numeroing = (Convert.ToInt32(Console.ReadLine()));
    for (int i = 0; i <= 12; i++)
    {
        Console.WriteLine("Las tables de su numero ingresado es");
        Console.WriteLine(i * numeroing);
    }
}

void ejercicioL()
{
    int acum = 0;
    while (acum < 100)
    {
        Console.WriteLine("Ingrese un numero");
       int numeroing = (Convert.ToInt32(Console.ReadLine()));
        acum = acum + numeroing;
        
    }




}

void ejercicioM()
{
    Console.WriteLine("Ingrese una palabra");
    string palabraing = Console.ReadLine();
    foreach (char c in palabraing)
    {
        Console.WriteLine(c);
    }
}

void ejercicioN()
{
    Console.WriteLine("Ingrese su edad");
    int edad = (Convert.ToInt32(Console.ReadLine()));
    if (edad < 16)
    {
        Console.WriteLine("Ustedes no puede ni votar ni manejar");
    }
    else if (edad > 16)
    {
        Console.WriteLine("Usted puede manejar y votar");
    }
    else if (edad == 16)
    {
        Console.WriteLine("Usted solo puede votar");
    }
}

void ejercicioO()
{
    for (int i = 50; i >= 0; i -= 5)
    {
        Console.WriteLine(i);
    }
}

void ejercicioP()
{
    
    
        Console.WriteLine("Ingrese una contraseña:");
        string contraing1 = Console.ReadLine();

        bool coinciden = false;

        while (!coinciden)
        {
            Console.WriteLine("Ingrese la contraseña nuevamente para verificar:");
            string contraing2 = Console.ReadLine();

            if (contraing1 == contraing2)
            {
                Console.WriteLine("Verificación realizada con éxito, su contraseña ha sido creada.");
                coinciden = true;
            }
            else
            {
                Console.WriteLine("Las contraseñas no coinciden. Intente de nuevo.");
            }
        }
    }

void ejercicioQ()
{
    bool condicion = false;
    while (condicion == false)
    {
        Console.WriteLine("Ingrese un nombre");
        string nombre1 = Console.ReadLine();
        if (nombre1.Length > 10)
        {
            condicion = true;
        }
    }
}

void ejercicioR()
{
    string condicion = "a";
    Console.WriteLine("Ingrese una palabra");
    string palabraing = Console.ReadLine();
    int acum = 0;
    foreach (char c in condicion)
    {
        foreach (char d in palabraing)
        {
            if (c == d)
            {
                acum = acum + 1;
                
            }
        }
    }
    Console.WriteLine("La cantidad de letras A en su palabra ingresada es de " +acum);


}
