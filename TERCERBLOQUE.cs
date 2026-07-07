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

void tercerbloqueF()
{
    char[] abecedario = new char[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };


    Console.Write("Introduce una palabra: ");
    string palabra = Console.ReadLine().ToLower();


    string[] resultado = new string[palabra.Length];


    for (int i = 0; i < palabra.Length; i++)
    {
        char letraPalabra = palabra[i];
        bool encontrada = false;

        for (int j = 0; j < abecedario.Length; j++)
        {
            if (abecedario[j] == letraPalabra)
            {
                resultado[i] = (j + 1).ToString();
                encontrada = true;
                break;
            }
        }

        if (!encontrada)
        {
            resultado[i] = letraPalabra.ToString();
        }
    }

    Console.WriteLine("Resultado numérico: - ");
    Console.WriteLine(string.Join("-", resultado));




}


void tercerbloqueG()
{
    int secreto = 5;
    int intentos = 0;
    while (true)
    {

        Console.WriteLine("Ingrese un numero");
        int adivinanza = int.Parse(Console.ReadLine());
        if (adivinanza > secreto)
        {
            Console.WriteLine("El numero secreto es menor");
            intentos++;
        }
        else if (adivinanza < secreto)
        {
            Console.WriteLine("El numero secreto es mayor");
            intentos++;
        }
        else
        {
            Console.WriteLine($"Numero encontrado en {intentos} intentos.");
            break;
        }

    }
}


void tercerbloqueH()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    string PalabraInvertida = "";
    for (int i = palabra.Length - 1; i >= 0; i--)
    {
        PalabraInvertida += palabra[i];
    }
    Console.WriteLine("Palabra invertida: " + PalabraInvertida);



}

void tercerbloqueI()
{
 
    char[] minusculas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    char[] mayusculas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    int[] contadores = new int[26];


    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    foreach (char c in palabra)
    {
        for (int i = 0; i < 26; i++)
        {
           
            if (c == minusculas[i] || c == mayusculas[i])
            {
                contadores[i]++;
            }
        }
    }

 
    for (int i = 0; i < 26; i++)
    {
        if (contadores[i] > 0)
        {
            char letra = minusculas[i];
            Console.WriteLine(letra + ": " + contadores[i]);
        }
    }

}

void tercerbloqueJ()
{
    Console.WriteLine("Ingrese nombre de usuario");
    string NombreDeUsuario = Console.ReadLine();
    string contraseñaVerdadera = "futbolpumabuceo";
    int acum = 3;
    while (acum > 0)
    {
        Console.WriteLine("Ingrese la contraseña");
        string contraseña = Console.ReadLine();
        if (contraseña == contraseñaVerdadera)
        {
            Console.WriteLine("Bienvenido, " + NombreDeUsuario);
            acum = 0;
        }
        else
        {
            acum--;
            if (acum > 0)
            {
                Console.WriteLine("Contraseña incorrecta, por favor, ingrese nuevamente");
                
            }
            else
            {
                Console.WriteLine("Se agotaron los intentos");
            }
        }
        
    }




}

void tercerbloqueK()
{
    bool Valido = false;
    int numero = 0;
    while (Valido == false)
    {
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        if (numero <= 100 && numero > 0)
        {
            Valido = true;
        }
        else
        {
            Console.WriteLine("Numero invalido, por favor ingrese un numero entre 1 y 100");
        }
    }
    if (numero <= 25)
    {
        Console.WriteLine("Su numero se encuentra dentro del rango 0-25");
    }
    else if (numero > 25 && numero <= 50)
    {
        Console.WriteLine("Su numero se encuentra dentro del rango 26-50");
    }
    else if (numero > 50 && numero <= 75)
    {
        Console.WriteLine("Su numero se encuentra dentro del rango 51-75");
    }
    else
    {
        Console.WriteLine("Su numero se encuentra dentro del rango 76-100");
    }




}
void tercerbloqueL()
{
    Console.WriteLine("Ingrese su peso en kg");
    double peso = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su altura en metros");
    double altura = Convert.ToDouble(Console.ReadLine());
    double IMC = peso / (altura * altura);
    if (IMC <= 18.5)
    {
        Console.WriteLine("Bajo peso");
    }
    else if ( IMC > 18.5 && IMC <= 24.9)
    {
        Console.WriteLine("Peso saludable");
    }
    else if (IMC > 25 && IMC <= 29.9)
    {
        Console.WriteLine("Sobrepeso");
    }
    else
    {
        Console.WriteLine("Obesidad");
    }
}

void tercerbloqueM()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    string deletreado = "";
    for (int i = 0; i < palabra.Length; i++)
    {
        deletreado += palabra[i];
        Console.WriteLine(deletreado);
    }





}


void tercerbloqueN()
{
    char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
    int indiceVocal = 0;

    Console.WriteLine("Introduce frases. El programa terminará cuando escribas 'agusfortnite2008'.");

    while (true)
    {
        Console.Write("Ingresa una frase: ");
        string entrada = Console.ReadLine();

        if (entrada == "agusfortnite2008")
        {
            Console.WriteLine("Programa finalizado.");
            break;
        }

        char vocalActual = vocales[indiceVocal];

        char[] caracteres = entrada.ToCharArray();

        for (int i = 0; i < caracteres.Length; i++)
        {
            char c = caracteres[i];


            char cMinuscula = char.ToLower(c);

            if (cMinuscula == 'a' || cMinuscula == 'e' || cMinuscula == 'i' ||
                cMinuscula == 'o' || cMinuscula == 'u' || cMinuscula == 'á' ||
                cMinuscula == 'é' || cMinuscula == 'í' || cMinuscula == 'ó' ||
                cMinuscula == 'ú')
            {

                if (char.IsUpper(c))
                {
                    caracteres[i] = char.ToUpper(vocalActual);
                }
                else
                {
                    caracteres[i] = vocalActual;
                }
            }
        }

        string fraseModificada = new string(caracteres);

        Console.WriteLine($"Resultado (con '{vocalActual}'): {fraseModificada}");

        indiceVocal = (indiceVocal + 1) % vocales.Length;
    }
}
