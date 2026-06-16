using System.Transactions;

bool sigue = true;
while (sigue)
{
    int intentosRestantes = 3;
    bool numeroValido = false;
    int numero = 0;

    while (intentosRestantes > 0)
    {
        Console.Write("Ingrese un número entero no negativo: ");
        string entrada = Console.ReadLine();

        try
        {
          
            numero = int.Parse(entrada);

            
            if (numero >= 0)
            {
                numeroValido = true;
                break;
            }
            else
            {
              
                throw new FormatException();
            }
        }
        catch (FormatException)
        {
           
            intentosRestantes--;
            if (intentosRestantes > 0)
            {
                Console.WriteLine("no es valido " + intentosRestantes + " intentos restantes ");
            }
            else
            {
                Console.WriteLine("no tiene mas intentos");
                return;
            }
        }
    }

    if (numeroValido)
    {
   
        int resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado = resultado * i;
        }

        Console.WriteLine("El factorial de " + numero + " es: " + resultado);
    }
}
