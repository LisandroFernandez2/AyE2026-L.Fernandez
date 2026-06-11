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
                turnodelprimero();
            }
            tateti[fila, columna] = "O";

            Console.Write(tateti[i, x]);
        }
        Console.WriteLine();
    }



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
            if (tateti[fila, columna] == "O")
            {
                Console.WriteLine("Casilla ya ocupada, vuelva a intentar");
                turnodelsegundo();
            }
            tateti[fila, columna] = "X";

            Console.Write(tateti[i, x]);
        }
        Console.WriteLine();
    }



}
turnodelsegundo();

bool verificar_ganador()
{

    for (int i = 0; i < 3; i++)
    {
        if (tateti[i, 0] == "X" && tateti[i, 1] == "X" && tateti[i, 2] == "X")
        {
            return true;

        }

    }
    for (int i = 0; i < 3; i++)
    {
        if (tateti[i, 0] == "O" && tateti[i, 1] == "O" && tateti[i, 2] == "O")
        {

            return true;


        }

    }
    for (int i = 0; i < 3; i++)
    {
        if (tateti[0, i] == "O" && tateti[1, i] == "O" && tateti[2, i] == "O")
        {

            return true;


        }

    }
    for (int i = 0; i < 3; i++)
    {
        if (tateti[0, i] == "X" && tateti[1, i] == "X" && tateti[2, i] == "X")
        {

            return true;


        }

    }
    if (tateti[0,0] == "X" && tateti[1,1] == "X" && tateti[2,2] == "X")
    {
        return true;
    }
    if (tateti[0, 0] == "O" && tateti[1, 1] == "O" && tateti[2, 2] == "O")
    {
        return true;
    }
    if (tateti[0, 2] == "X" && tateti[1, 1] == "X" && tateti[2, 0] == "X")
    {
        return true;
    }
    if (tateti[0, 2] == "O" && tateti[1, 1] == "O" && tateti[2, 0] == "O")
    {
        return true;
    }
    return false;
}
void ishdoasid()
{
    bool sigue = true;
    while (sigue)
    {
        turnodelprimero();
        if (verificar_ganador() == true)
        {
            sigue = false;
            Console.WriteLine("Felicidades jugador O, usted ha ganado");
            break;
        }
        turnodelsegundo();

        if (verificar_ganador() == true)
        {
            sigue = false;
            Console.WriteLine("Felicidades jugador X, usted ha ganado");
            break;
        }
    }
}
ishdoasid();

