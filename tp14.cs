using System.Diagnostics.CodeAnalysis;

void ejercicio1()
{
    Console.WriteLine("Ingrese 5 numeros");
    string[] numeros = new string[5];
    for (int i = 0; i < 5; i++)
    {
        numeros[i] = Console.ReadLine();
    }
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}
ejercicio1();

void ejercicio2()
{
    string[] frutas = { "banana", "manzana", "pera", "frutilla", "naranja" };
    Console.WriteLine("¿Que fruta desea buscar?");
    string buscar = Console.ReadLine();
    int acum = 0;
    for (int i = 0; i < frutas.Length; i++)
    {
        if (buscar == frutas[i])
        {
            Console.WriteLine("Fruta encontrada, se encuentra en la posicion: " + i);
            acum ++;
            break;
        }
        

    }
    if (acum == 0)
    {
        Console.WriteLine("La fruta no fue encontrada");
    }
}

ejercicio2();
void ejercicio3()
{
    Console.WriteLine("Ingrese las 10 notas");
    int[] notas = new int[10];
    int suma = 0;
    double promedio = 0;
    for (int i = 0; i <= 9; i++)
    {
        notas[i] = int.Parse(Console.ReadLine());
        suma = suma + notas[i];
    }
    promedio = suma / 10;
    Console.WriteLine("La suma total de las notas es de: " + suma);
    Console.WriteLine("El promedio es de: " + promedio);

}
ejercicio3();
void ejercicio4()
{
    int[] temperaturas = { 25, 35, 32, 45, 21 };
    int acum = 0;
    int acum2 = 99999999;
 
    for (int i = 0; i <= 4; i++)
    {
      
        
        if (temperaturas[i] > acum)
        {
            acum = temperaturas[i];
        }
    }
    for (int i = 0; i <= 4; i++)
    {
       
        if (temperaturas[i] < acum)
        {
            acum2 = temperaturas[i];
     
        }
    }
    Console.WriteLine("La temperatura mayor es de: " + acum);
    Console.WriteLine("La temperatura menor es de: " + acum2);




}
ejercicio4();
void ejercicio5()
{

   
    int[] numeros = { 5, 2, 9, 1, 7, 4 };

  
    for (int i = 0; i < numeros.Length - 1; i++)
    {
        for (int j = 0; j < numeros.Length - 1; j++)
        {
           
            if (numeros[j] > numeros[j + 1])
            {
               
                int temporal = numeros[j];
                numeros[j] = numeros[j + 1];
                numeros[j + 1] = temporal;
            }
        }
    }

    Console.WriteLine("Lista ordenada:");
    for (int k = 0; k < numeros.Length; k++)
    {
        Console.Write(numeros[k] + " ");
    }


}
ejercicio5();
void ejercicio6()
{
    int[] numeros = { 14, 3, 22, 9, 45, 12, 7, 34, 19, 50, 1, 28, 15, 8, 41 };
    int acum = 0;
    int acumimpares = 0;
    for (int i = 0; i < 15; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            acum++;
        }
        else
        {
            acumimpares++;
        }

    }
    Console.WriteLine("La cantidad de pares es de: " + acum);
    Console.WriteLine("La cantidad de impares es de: " + acumimpares);



}
ejercicio6();