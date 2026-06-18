void segundobloqueA()
{
    Random aleatorio = new Random();
    int numero = aleatorio.Next(0, 11);
    int numeroingresado = 0;
    while (numeroingresado != numero)
    {
        Console.WriteLine("Intente adivinar");
        numeroingresado = int.Parse(Console.ReadLine());
        if (numeroingresado < numero)
        {
            Console.WriteLine("El numero es mas alto");
        }
        else
        {
            Console.WriteLine("El numero es mas bajo");
        }
    }
    Console.WriteLine("¡Felicidades, usted ha adivinado el numero!");
}
segundobloqueA();
void segundobloqueB()
{
    Console.WriteLine("Ingrese un numero");
    int numeroingresado = int.Parse(Console.ReadLine());
    for (int i = 1; i <= numeroingresado; i++)
    {
        if (numeroingresado % i == 0)
        {
            Console.WriteLine("Divisor encontrado: " + i);
        }
    }
}
segundobloqueB();
void segundobloqueC()
{
    bool sigue = true;
    int segundotermino = 1;
    int resultado = 0;
    int primertermino = 0;
    while (resultado < 4181)
    {
        resultado = primertermino + segundotermino;
        Console.WriteLine(resultado);
        primertermino = segundotermino;
        segundotermino = resultado;

    }

}
segundobloqueC();
void segundobloqueD()
{
    Console.WriteLine("Elije una operacion, (suma, resta, multiplicacion o divison)");
    string eleccion = Console.ReadLine();
    Console.WriteLine("Ingrese el primer numero");
    double primernumero = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
    double segundonumero = int.Parse(Console.ReadLine());
    double resultado = 0;
    switch (eleccion)
    {
        case "suma":
            resultado = primernumero + segundonumero;
            break;
        case "resta":
            resultado = primernumero - segundonumero;
            break;
        case "multiplicacion":
            resultado = primernumero * segundonumero;
            break;
        case "division":
            resultado = primernumero / segundonumero;
            break;
    }
    Console.WriteLine("El resultado de la operacion es: " + resultado);
}
segundobloqueD();
void segundobloqueE()
{
    Console.WriteLine("Ingresa un numero y yo te calculo el factorial");
    int numeroingresado = int.Parse(Console.ReadLine());
    int resultado = 1;
    for (int i = 1; i <= numeroingresado; i++)
    {
        resultado = resultado * i;
        
    }
    Console.WriteLine("El factorial de su numero ingresado es " + resultado);
}
segundobloqueE();
void segundobloqueF()
{
    Console.WriteLine("Cuantos turnos quiere generar");
    int turnos = int.Parse(Console.ReadLine());
    int numerodeturnos = 0;
    string[] nombres = new string[turnos];
    for (int i = 0; i <= turnos - 1; i++)
    {
        Console.WriteLine("Ingrese un nombre");
        nombres[i] = Console.ReadLine();
        Random aleatorio = new Random();
        numerodeturnos = aleatorio.Next(0, 100);
        Console.WriteLine("Paciente " + nombres[i] + " numero de orden: " + numerodeturnos);
    }
}
segundobloqueF();
void segundobloqueG()
{
  for (int i = 1; i <= 100; i++)
   {
        if (i % 2 == 0)
        {
            Console.WriteLine("Numero par encontrado: " + i); 
        }     
  }
}
segundobloqueG();
void segundobloqueH()
{
    bool sigue = true;
    while (sigue)
    {
        int celcius = 0;
        double fahrenheit = 0;
        Console.WriteLine("¿Desea continuar? (s/n)");
        string eleccion = Console.ReadLine();
        if (eleccion == "n")
        {
            sigue = false;
        }
        Console.WriteLine("Ingrese la temperatura en celcius");
        celcius = int.Parse(Console.ReadLine());
        fahrenheit = (celcius * 9.0/5.0) + 32.0;
        Console.WriteLine("La temperatura en fahrenheit es: " + fahrenheit);
    }
}
segundobloqueH();
void segundobloqueI()
{

    Console.WriteLine("Ingrese un número");
    int numero = int.Parse(Console.ReadLine());
    if (numero <= 3)
    {
        Console.WriteLine("Su numero es primo");
    }
    if (numero > 3)
    {
        if (numero % 2 == 0 || numero % 3 == 0)
        {
            Console.WriteLine("Su numero no es primo");
        }
        else
        {
            Console.WriteLine("Su numero es primo");
        }
    }
}
segundobloqueI();
void segundobloqueJ()
{
    string[] nombres = new string[100];
    int cantidad = 0;

    while (true)
    {
        Console.WriteLine("Ingrese un nombre (fin para terminar):");
        string nombre = Console.ReadLine();

        if (nombre == "fin")
        {
            break;
        }

        nombres[cantidad] = nombre;
        cantidad++;
    }

    for (int i = 0; i < cantidad; i++)
    {
        Console.WriteLine("Hola " + nombres[i]);
    }
}
segundobloqueJ();
void segundobloqueK()
{
    string nombre;
    string aux = "";
    bool sigue = true;
    int contador = 0;
    while (sigue)
    {
        Console.WriteLine("Ingrese un nombre");
        nombre = Console.ReadLine();
        if (aux == nombre)
        {
            Console.WriteLine("La cantidad de nombres ingresados antes del duplicado es de: " + (contador - 1));
            sigue = false;

        }
        aux = nombre;
        contador++;

    }
}
segundobloqueK();
void segundobloqueL()
{
    for (int i  = 100; i <= 200; i++)
    {
        int resultado = i % 10;
        if (i % 7 == 0 && resultado == 3)
        {
            Console.WriteLine(i);
        }

    }
}
segundobloqueL();
void segundobloqueM()
{
    int total = 0;
    int contador = 0;
    int precio = 0;
    while (total < 1000)
    {
        Console.WriteLine("Ingrese el precio");
        precio = int.Parse(Console.ReadLine());
        total = total + precio;
        contador++;

    }
    Console.WriteLine("La cantidad de productos cargados es de: " + contador);
}
segundobloqueM();
void segundobloqueN()
{
    Console.WriteLine("Ingrese su nombre");
    string nombre = Console.ReadLine();
    bool sigue = true;
    int edad = 0;
    while (sigue)
    {
        try
        {
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            sigue = false;
        }
        catch
        {
            Console.WriteLine("Error: Debes ingresar un número");
        }
    }
    Console.WriteLine("Ingrese su mail");
    bool sigue2 = true;
    while (sigue2)
    {
        string mail = Console.ReadLine();
        bool valido = false;
        foreach (char c in mail)
        {
            if (c == '@')
            {
                valido = true;
            }

        }
        if (valido == true)
        {
            Console.WriteLine("Nombre - " + nombre);
            Console.WriteLine("Edad - " + edad);
            Console.WriteLine("Mail - " + mail);
            sigue2 = false;
        }
        else
        {
            Console.WriteLine("Su mail no tiene @");
        }
    }


}
segundobloqueN();
void segundobloqueO()
{
    Console.WriteLine("Ingrese un numero");
    string numero = Console.ReadLine();
    foreach (char c in numero)
    {
        Console.WriteLine(c);
    }



}
segundobloqueO();
void segundobloqueP()
{
    string[] piedrapapeltijera = new string[3];
    piedrapapeltijera = ["piedra", "papel", "tijera"];
    Random aleatorio = new Random();
    string almomento;
    int contador = 3;
    int contadorbot = 0;
    int contadorusuario = 0;
    while (contador > 0)
    {
        Console.WriteLine("Piedra, papel o tijera");
        string eleccion = Console.ReadLine();
        almomento = piedrapapeltijera[aleatorio.Next(0, 3)];
        Console.WriteLine(almomento);
        if (almomento == eleccion)
        {
            Console.WriteLine("Ronda empatada");
            contador--;
        }
        else if(almomento == "piedra" && eleccion == "tijera" || almomento == "tijera" && eleccion == "papel" || almomento == "papel" && eleccion == "piedra")
        {
            Console.WriteLine("El bot gana la ronda");
            contadorbot++;
            contador--;
        }
        else 
        {
            Console.WriteLine("Usted ha ganado esta ronda");
            contadorusuario++;
            contador--;
        }
    }
    if (contadorbot > contadorusuario)
    {
        Console.WriteLine("El bot fue el que gano mas rondas");
    }
    else if (contadorbot < contadorusuario)
    {
        Console.WriteLine("Tu ganaste mas rondas");
    }
    else
    {
        Console.WriteLine("Hubo un empate");
    }
}
segundobloqueP();
void segundobloqueQ()
{
    for (int i = 0; i < 10; i++)
    {
        Random aleatorio = new Random();
        int random = aleatorio.Next(0,100);
        if (random > 50)
        {
            Console.WriteLine(random);
        }
    }
}
segundobloqueQ();

void segundobloqueR()
{
    Console.WriteLine("Ingrese los nombres");
    string[] nombres = new string[5];
    for (int i = 0; i < 5; i++)
    {
        nombres[i] = Console.ReadLine();

    }
    Console.WriteLine("Ingrese las notas");
    int[] notas = new int[5];
    double acum = 0;
    for (int i = 0; i < 5; i++)
    {
        notas[i] = Convert.ToInt32(Console.ReadLine());
        acum = acum + notas[i];
        Console.WriteLine("Alumno " + nombres[i] + " tiene nota " + notas[i]);
    }
    Console.WriteLine("El promedio gral. fue de " + acum / 5.0);
    int mayor = notas.Max();
    Console.WriteLine("La mayor nota fue " + mayor);

}
segundobloqueR();

void segundobloqueS()
{
    string[] abecedario = new string[27];
    abecedario = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
    "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];

    for (int i = abecedario.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(abecedario[i]);
    }
}
segundobloqueS();
