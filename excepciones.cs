using System.ComponentModel.Design;
bool truie = true;
while (truie)
{
    try
    {
        Console.WriteLine("Ejercicio 1: Ingrese un número");
        Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
        truie = false;
    }
    catch
    {
        Console.WriteLine("Error: Debes ingresar un número válido.");
    }
}
bool truie2 = true;
while (truie2){
    try
    {
        Console.WriteLine("Ejercicio 2: Ingrese su edad");
        Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
        truie2 = false;
    }
    catch
    {
        Console.WriteLine("Error: Edad inválida.");
    }
}
bool truie3 = true;
while (truie3)
{
    try
    {
        Console.WriteLine("Ejercicio 3: Ingrese contraseña");
        Console.WriteLine(Ejercicio3(Console.ReadLine()));
        truie3 = false;
    }
    catch
    {
        Console.WriteLine("Error al ingresar la contraseña.");
    }
}
bool truie4 = true;
while (truie4)
{
    try
    {
        Console.WriteLine("Ejercicio 4: Ingrese un número");
        Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
        truie4 = false;
    }
    catch
    {
        Console.WriteLine("Error: Debes ingresar un número válido.");
    }
}
    bool truie5 = true;
    while (truie5)
    {
        try
        {
            Console.WriteLine("Ejercicio 5: Ingrese su edad");
            Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));
            truie5 = false;
        }
        catch
        {
            Console.WriteLine("Error: Entrada inválida.");
        }
    }

    string Ejercicio1(int n)
    {
        string res;
        if (n > 0)
        {
            res = ("Positivo");
            return res;
        }
        else if (n == 0)
        {
            res = ("Igual");
            return res;
        }
        else
        {
            res = ("Negativo");
            return res;
        }
    }


    string Ejercicio2(int o)
    {
        string res;
        if (o >= 18)
        {
            res = ("¡Bienvenido a la fiesta!");
            return res;
        }
        else
        {
            res = ("Lo siento, eres muy joven");
            return res;
        }
    }


    string Ejercicio3(string p)
    {
        string res;
        if (p == "python123")
        {
            res = ("¡Contraseña correcta! Acceso concedido.");
            return res;
        }
        else
        {
            res = ("¡Contraseña incorrecta, Autodestrucción en 5 minutos!");
            return res;
        }
    }

    string Ejercicio4(int j)
    {
        string res;
        if (j % 2 == 0)
        {
            res = ("El numero es par.");
            return res;
        }
        else
        {
            res = ("El numero es impar");
            return res;
        }
    }

    string Ejercicio5(int h)

    {
        Console.WriteLine("¿Compro pochoclos?");
        string i = Console.ReadLine();
        string res;
        if (h > 65 && i == "si")
        {
            res = ("¡Felicidades! Tienes entrada gratuita al cine.");
            return res;
        }
        else
        {
            res = ("Compra la entrada o raja de acá");
            return res;
        }
    }

