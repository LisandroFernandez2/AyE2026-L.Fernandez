using System.ComponentModel.Design;
using System.Reflection;
  static void Main()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
        Ejercicio5();
        Ejercicio6();
    }

    static void Ejercicio1()
    {
        Console.WriteLine("--- Ejercicio 1 ---");
        Console.Write("Ingresa una frase: ");
        string frase = Console.ReadLine();
        int contador = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            char c = frase[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' ||
                c == 'á' || c == 'é' || c == 'í' || c == 'ó' || c == 'ú' ||
                c == 'Á' || c == 'É' || c == 'Í' || c == 'Ó' || c == 'Ú')
            {
                contador++;
            }
        }
        Console.WriteLine("Total de vocales: " + contador + "\n");
    }

    static void Ejercicio2()
    {
        Console.WriteLine("--- Ejercicio 2 ---");
        Console.Write("Ingresa una frase: ");
        string texto = Console.ReadLine();
        string invertida = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertida += texto[i];
        }
        Console.WriteLine("Invertida: " + invertida + "\n");
    }

    static void Ejercicio3()
    {
        Console.WriteLine("--- Ejercicio 3 ---");
        Console.Write("Ingresa un número entero: ");
        string n = Console.ReadLine();
        int suma = 0;

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] >= '0' && n[i] <= '9')
            {
                suma += (int)(n[i] - '0');
            }
        }
        Console.WriteLine("La suma de los dígitos es: " + suma + "\n");
    }

    static void Ejercicio4()
    {
        Console.WriteLine("--- Ejercicio 4 ---");
        string parrafo = "El gato juega en el jardin porque el gato es feliz.";
        Console.WriteLine("Texto original: " + parrafo);
        Console.Write("Palabra prohibida: ");
        string prohibida = Console.ReadLine();
        Console.Write("Palabra de reemplazo: ");
        string reemplazo = Console.ReadLine();
        
        string resultado = parrafo.Replace(prohibida, reemplazo);
        Console.WriteLine("Resultado: " + resultado + "\n");
    }

    static void Ejercicio5()
    {
        Console.WriteLine("--- Ejercicio 5 ---");
        Console.Write("Ingresa tu nombre completo: ");
        string entrada = Console.ReadLine();
        string[] partes = entrada.Split(' ');

        if (partes.Length >= 2)
        {
            string nombre = partes[0];
            string apellido = partes[partes.Length - 1];
            
            char inicialNombre = nombre[0];
            char inicialApellido = apellido[0];

            Console.WriteLine("Iniciales: " + inicialNombre + "." + inicialApellido + ".");
            Console.WriteLine("Primer nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido + "\n");
        }
    }

    static void Ejercicio6()
    {
        Console.WriteLine("--- Ejercicio 6 ---");
        Console.Write("Ingresa una palabra: ");
        string entrada = Console.ReadLine();
        
        string palabra = "";
        for (int i = 0; i < entrada.Length; i++)
        {
            if (entrada[i] != ' ')
            {
                char c = entrada[i];
                if (c >= 'A' && c <= 'Z') c = (char)(c + 32); 
                palabra += c;
            }
        }

        bool esPalindromo = true;
        int inicio = 0;
        int fin = palabra.Length - 1;

        while (inicio < fin)
        {
            if (palabra[inicio] != palabra[fin])
            {
                esPalindromo = false;
                break;
            }
            inicio++;
            fin--;
        }

        if (esPalindromo) Console.WriteLine("Es un palíndromo.\n");
        else Console.WriteLine("No es un palíndromo.\n");
    }
