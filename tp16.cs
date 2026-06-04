void ejercicio1()
{
    int[,] matriz ={ {1 , 2,  3 , 4 },
{ 5  ,6  ,7  ,8 },
{ 9 ,10, 11, 12 },
{ 13 ,14 ,15 ,16 }};
    int acum = 0;


    acum = acum + matriz[0, 0] + matriz[0, 3] + matriz[3, 0] + matriz[3, 3];

   
    Console.WriteLine("La suma de las esquinas de la matriz es de: " + acum);

}
ejercicio1();

void ejercicio2()
{
    int[,] matriz ={
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 } };

    int diagonalprin = 0;
    int diagonalsecu = 0;

    for (int i = 0; i < 3; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            if (x == i)
            {
                diagonalprin = diagonalprin + matriz[i, x];
            }
        }
    }
    for (int i = 0; i <3; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            if (i + x == 3 - 1)
            {
                diagonalsecu = diagonalsecu + matriz[i, x];
            }
        }
    }
    Console.WriteLine("La suma de la diagonal principal de la matriz es de: " + diagonalprin);
    Console.WriteLine("La suma de la diagonal secundaria de la matriz es de: " + diagonalsecu);
}
ejercicio2();
void ejercicio3()
{
    Console.WriteLine("Ingrese la cantidad de filas y columnas.");
    int filasycolumnas = int.Parse(Console.ReadLine());
   
    int[,] matriz = new int[filasycolumnas, filasycolumnas];
   
    for (int i = 0; i < filasycolumnas; i++)
    {
        for (int x = 0; x < filasycolumnas; x++)
        {
           if (x == i)
            {
                matriz[i, x] = 1;
            }
            else
            {
                matriz[i, x] = 0;
            }
        }
      
       
    }
    for (int i = 0; i < filasycolumnas; i++)
    {
        for (int x = 0; x < filasycolumnas; x++)
        {
            Console.Write(matriz[i, x]);
        }
        Console.WriteLine();

    }

}
ejercicio3();
