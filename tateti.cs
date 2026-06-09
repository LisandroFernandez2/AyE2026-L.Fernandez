string[,] tateti = new string[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int x = 0; x < 3; x++)
    {
        tateti[i, x] = "-";
        Console.Write(tateti[i, x]);
    }
    Console.WriteLine();
}
void turnodelprimero()
{
    Console.WriteLine("Elija la fila");
    int fila = int.Parse(Console.ReadLine());
    Console.WriteLine("Elija la columna");
    int columna = int.Parse(Console.ReadLine());
    for (int i = 0; i < 3; i++)
    {
        for (int x = 0; x < 3; x++)
        {
            if (tateti[fila, columna] == "X")
            {
                Console.WriteLine("Casilla ya ocupada, vuelva a intentar");
                turnodelsegundo();
            }
            tateti[fila, columna] = "O";
            
            Console.Write(tateti[i, x]);
        }
        Console.WriteLine();
    }
    turnodelsegundo();


}
turnodelprimero();

void turnodelsegundo()
{
    Console.WriteLine("Elija la fila");
    int fila = int.Parse(Console.ReadLine());
    Console.WriteLine("Elija la columna");
    int columna = int.Parse(Console.ReadLine());
    for (int i = 0; i < 3; i++)
    {
        for (int x = 0; x < 3; x++)
        {
          if (tateti[fila,columna] == "O")
            {
                Console.WriteLine("Casilla ya ocupada, vuelva a intentar");
                turnodelsegundo();
            }
            tateti[fila, columna] = "X";
          
            Console.Write(tateti[i, x]);
        }
        Console.WriteLine();
    }
    turnodelprimero();


}
turnodelsegundo();