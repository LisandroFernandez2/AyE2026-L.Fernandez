void tercerbloqueA()
{
    string[] candidatos = new string[3];
    candidatos = ["Patricia Fedellrich","Lisandro Fernandez De Kirchner","Javier Matilei"];
    int[] cantidaddevotos = new int[3];
    cantidaddevotos = [0, 0, 0];
    string terminar = "";
    while (terminar != "terminar")
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(candidatos[i]);
        }
        Console.WriteLine("¿A quien desea votar? ¿al 1, al 2 o al 3?");
        int eleccion = Convert.ToInt32(Console.ReadLine());
        switch (eleccion)
        {
            case 1:
                cantidaddevotos[0] = cantidaddevotos[0] + 1;
                break;
            case 2:
                cantidaddevotos[1] = cantidaddevotos[1] + 1;
                break;
            case 3:
                cantidaddevotos[2] = cantidaddevotos[2] + 1;
                break;
        }
        Console.WriteLine("¿Desea terminar la votacion (ingrese terminar para finalizar la votacion)");
        terminar = Console.ReadLine();

    }

    if (cantidaddevotos[0] > cantidaddevotos[1] && cantidaddevotos[0] > cantidaddevotos[2]) {
        Console.WriteLine("El ganador es Patricia Fedellrich con " + cantidaddevotos[0] + " votos");
    }
    else if (cantidaddevotos[1] > cantidaddevotos[0] && cantidaddevotos[1] > cantidaddevotos[2]) {
        Console.WriteLine("El ganador es Lisandro Fernandez De Kirchner con " + cantidaddevotos[1] + " votos");
    }
    else { 
        Console.WriteLine("El ganador es Javier Matilei con " + cantidaddevotos[2] + " votos");
    }
   

}
tercerbloqueA();
