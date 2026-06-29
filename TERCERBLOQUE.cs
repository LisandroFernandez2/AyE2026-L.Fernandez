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
void tercerbloqueB()
{
    bool valido = false;
    int numero = 0;
    while (valido == false)
    {
        Console.WriteLine("Ingresa un numero");
        numero = int.Parse(Console.ReadLine());
        if (numero < 1)
        {
            Console.WriteLine("No puede ser menor a uno.");
        }
        else
        {
            valido = true;
        }
    }
    for (int i = numero; i > 0; i--)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }




}
tercerbloqueB();

void tercerbloqueC()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    Console.WriteLine("Ingrese una letra");
    char letra = Convert.ToChar(Console.ReadLine());
    int contador = 0;
    foreach (char caracter in palabra)
    {
      
        if (caracter == letra)
        {
            contador++;
        }
    }
    Console.WriteLine("La letra " + letra + " aparece un total de " + contador + " veces en la palabra " + palabra);






}
tercerbloqueC();
void tercerbloqueD()
{
    int dinero = 1000;
    bool sigue = true;
    while (sigue)
    {
        Console.WriteLine("¿Que desea hacer? - R (retirar), D (depositar) o S (salir)?");
        string eleccion = Console.ReadLine();
        switch (eleccion)
        {
            case "R":
                Console.WriteLine("¿Cuanto desea retirar?");
                int retirar = int.Parse(Console.ReadLine());
                if (retirar > dinero)
                {
                    Console.WriteLine("No puede retirar mas de lo que tiene");
                    break;
                }
                else
                {
                    dinero = dinero - retirar;
                    Console.WriteLine("Su dinero actual es: " + dinero);
                    break;
                }
            case "D":
                Console.WriteLine("¿Cuanto desea depositar?");
                int deposito = int.Parse(Console.ReadLine());
                dinero = dinero + deposito;
                Console.WriteLine("Su dinero actual es: " + dinero);
                break;
            case "S":
                Console.WriteLine("Saliendo del sistema...");
                sigue = false;
                break;
        }
    }
}
tercerbloqueD();
void tercerbloqueE()
{
    for (int i = 0; i <= 50; i++)
    {
        if (i % 2 == 0 && i % 5 != 0)
        {
            Console.WriteLine("Numero divisible por 2: " + i);
        }
        if (i % 5 == 0 && i % 2 != 0)
        {
            Console.WriteLine("Numero divisible por 5: " + i);
        }


    }
}
tercerbloqueE();
