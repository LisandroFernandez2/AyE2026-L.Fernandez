using System.ComponentModel.Design;


string Ejercicio1 (int n) {
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
Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));

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
Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));

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
Console.WriteLine(Ejercicio3(Console.ReadLine()));
string Ejercicio4(int j)
{
    string res;
    if (j%2 == 0)
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
Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));

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
Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));