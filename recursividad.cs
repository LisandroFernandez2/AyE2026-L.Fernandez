bool recursiva (int n)
{
   
    if (n == 0)
    {
        
        return false;
    }
    else
    {
        recursiva(n - 1);
        Console.WriteLine(n);
        return true;
    }
    
}
recursiva(10);

bool recursiva2(int n)
{
    
    if (n == 0)
    {
        
        return false;
    }
    else
    {
       
        Console.WriteLine("¡Hola mundo!");
        recursiva2(n - 1);
        return true;
    }
}
recursiva2(5);
bool recursiva3(int n)
{
   
    if (n > 20)
    {
      
        return false;
    }
    else
    {
       
        Console.WriteLine(n);
        recursiva3(n + 2);
        return true;
    }
}
recursiva3(2);
bool recursiva4(int n)
{
    if (n > 70)
    {
        return false;
    }
    else
    {
        Console.WriteLine(n);
        recursiva4(n + 7);
        return true;
    }
}
recursiva4(7);
int aux = 0;
int recursiva5(int n)
{
    if (n == 0)
    {
        return aux;
    }
    else
    {
        aux = aux + n;
        recursiva5(n-1);
        return aux;
    }
}

aux = recursiva5(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(aux);
string recursiva6(string contra2)
{
    string contra = "caine";
    
    if (contra == contra2)
    {
        Console.WriteLine("La contraseña es correcta");
        return contra2;
    }
    else
    {
        Console.WriteLine("Intentelo de nuevo");
        recursiva6(Console.ReadLine());
        return contra2;

    }
}
recursiva6(Console.ReadLine());

int recursiva7 (int z)
{
    if(z == 0)
    {
        Console.WriteLine("Listos para despegar");
        Console.WriteLine("Despegue");
        return z;
    }
    else
    {
        z = z - 1;
        Console.WriteLine(z);
        recursiva7(z);
        return z;
    }
}
recursiva7(6);
int recursiva8 (int secreto)
{
    Console.WriteLine("Adivine el numero");
    int adivin = Convert.ToInt32(Console.ReadLine());
    if (adivin == secreto)
    {
        Console.WriteLine("¡Felicidades! Adivinaste el número.");
        return secreto;
    }
    else
    {
        Console.WriteLine("intentelo de vuelta");
        recursiva8(secreto);
        return secreto;
    }
}
recursiva8(7);
