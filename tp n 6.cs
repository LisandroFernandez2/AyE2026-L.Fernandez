
bool seguimos = true;

while (seguimos == true)
{
    Console.WriteLine("Ingrese un numero : 1 para el primer ejercicio, 2 para el segundo, 3 para el tercero, 4 para el cuarto, 5 para el quinto y 0 para terminar el programa");
    int x = (Convert.ToInt32(Console.ReadLine()));
    
    switch (x)
    {
        case 1:
            Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
            break;
        case 2:
            Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
            break;
        case 3:
            Console.WriteLine(Ejercicio3(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
            break;
        case 5:
            Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));
            break;
        case 0:
            seguimos = false;
            break;
        default:
            Console.WriteLine("EL NUMERO INGRESADO NO SE ENCUENTRA DENTRO DEL PARAMETRO DESEADO");
            break;
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