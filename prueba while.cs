void ejercicio1()
{
    int numero = 2;
    bool condicion = true;
    while (condicion)
    {
        if (numero != 0 && numero != 1)
        {
            Console.WriteLine("Ingrese 0 o 1");
            numero = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            condicion = false;
        }
    }



}


void ejercicio2()
{
    int numero = 3;
    bool condicion = true;
    while (condicion)
    {
       
       
            if (numero > 99 || numero < -99)
            {
                Console.WriteLine("Ingrese un numero de dos cifras");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                condicion = false;
            }
      
    }


}
ejercicio2();