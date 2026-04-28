using System.Reflection.PortableExecutable;

void ejercicio1()
{
    string vocales = ("aeiouAEIOU");
    string texto = Console.ReadLine();
    int acum = 0;
    foreach (char t in texto)
    {
        foreach (char v in vocales)
        {
            if (v == t)
            {
                acum = acum + 1;
                Console.WriteLine(acum);
                break;
            }
        }
    }
}


void ejercicio2()
{
    Console.WriteLine("Ingrese una palabra");
    string x = Console.ReadLine();

    for (int i = x.Length - 1; i >= 0; i--)
    {
        char letraActual = x[i];
        Console.Write(letraActual);
    }




}


void ejercicio3()
{
    Console.WriteLine("Por favor, ingrese un numero");
    string texto = Console.ReadLine();
    int aux = 0;
    int aux2 = 0;

    foreach (char t in texto)
    {

        aux2 = Convert.ToInt32("" + t);
        aux = aux + aux2;


    }
    Console.WriteLine(aux);


}

void ejercicio4()
{
    Console.WriteLine("Ingrese la palabra prohibida");
    string x = Console.ReadLine();
    Console.WriteLine("Ingrese la palabra de reemplazo");
    string y = Console.ReadLine();
    Console.WriteLine("Ingrese un texto cualquiera");
    string z = Console.ReadLine();
    string nuevafrase = z.Replace(x, y);
    Console.WriteLine(nuevafrase);
}

void ejercicio5()
{
    Console.WriteLine("Ingrese su nombre y su apellido");
    string x = Console.ReadLine();
   
        string[] texto = x.Split(" ");
        Console.WriteLine(texto[0]);
        Console.WriteLine(texto[1]);
        string t0 = texto[0];
        Console.WriteLine(t0[0]);
        string t1 = texto[1];
        Console.WriteLine(t1[0]);
}

void ejercicio6()
{
    Console.WriteLine(" Ingrese una palabra:");
    string x = Console.ReadLine();
    bool palin = false;
    foreach (char n in x)
    {
        for (int i = x.Length - 1; i >= 0; i--)
        {
            char letraActual = x[i];
            
            if (letraActual == n)
            {
                palin = true;
                
     
            }
            else
            {
                palin = false;
                
            }
            
        }
        
    }

    Console.WriteLine(palin);





}
