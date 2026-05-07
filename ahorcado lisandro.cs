using System.ComponentModel.Design;

Console.WriteLine("Elegí un número para jugar:");
Console.WriteLine("1: palabra 1");
Console.WriteLine("2: palabra 2");
Console.WriteLine("3: palabra 3");
int opcion = 0;
bool valido = true;
while (valido)
{
    try
    {
        opcion = Convert.ToInt32(Console.ReadLine());
        valido = false;
    }
    catch (System.FormatException)
    {
        Console.WriteLine("el caracter que pusiste no es valido");
    }
}
char letra = ' ';
string palabra = "";
bool condicion2 = true;
while (condicion2)
{
    if (opcion == 1)
    {
        palabra = "merentiel";
        condicion2 = false;
    }
    else if (opcion == 2)
    {
        palabra = "pomni";
        condicion2 = false;
    }
    else if (opcion == 3)
    {
        palabra = "ornitorrinco";
        condicion2 = false;
    }
    else if (opcion < 1 || opcion > 3)
    {
        Console.WriteLine("El numero ingresado no se encuentra dentro de los parametros, por favor, ingrese 1,2 o 3");
        opcion = Convert.ToInt32(Console.ReadLine());
    }
}
string progreso = "";
for (int i = 0; i < palabra.Length; i++)
{
    progreso += "_";
}

int intentos = 7;
bool gano = false;

while (intentos > 0 && !gano)
{
    Console.WriteLine("");
    Console.WriteLine("Palabra: " + progreso);
    Console.WriteLine("Intentos restantes: " + intentos);
    Console.WriteLine("Ingrese una letra:");

    try
    {
        letra = Convert.ToChar(Console.ReadLine());
    }
    catch (System.FormatException)
    {
        Console.WriteLine("el caracter que pusiste no es valido");
    }
    bool encontro = false;
    string nuevo = "";


    for (int i = 0; i < palabra.Length; i++)
    {
        if (palabra[i] == letra)
        {
            nuevo += letra;
            encontro = true;
        }
        else
        {
            nuevo += progreso[i];
        }
    }


    progreso = nuevo;


    if (encontro == false)
    {
        intentos--;
        Console.WriteLine("Letra incorrecta");
    }
    else
    {
        Console.WriteLine("Bien! Letra encontrada");
    }


    if (progreso == palabra)
    {
        gano = true;
    }
}


Console.WriteLine("");

if (gano)
{
    Console.WriteLine("Ganaste! La palabra era: " + palabra);
}
else
{
    Console.WriteLine("Perdiste! La palabra era: " + palabra);
}

