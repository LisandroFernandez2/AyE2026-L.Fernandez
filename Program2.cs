using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PalabraInvertida()
            {
                Queue<char> PalabraInvertida = new Queue<char>();
                Console.WriteLine("Ingrese una palabra");
                string PalabraIngresada = Console.ReadLine();
                for (int i = PalabraIngresada.Length - 1; i >= 0; i--)
                {
                    PalabraInvertida.Enqueue(PalabraIngresada[i]);
                }
                foreach (var c in PalabraInvertida)
                {
                    Console.WriteLine(c);

                }
            }
            void Paginas()
            {
                string decision = "Y";
                Queue<string> URLS = new Queue<string>();
                URLS.Enqueue("classroom.com");
                URLS.Enqueue("tasks.com");
                URLS.Enqueue("github.com");
                
                while (decision != "N")
                {
                    try
                    {
                        Console.WriteLine("Pagina actual:" + URLS.Peek());
                        Console.WriteLine("Desea retroceder? Y/N");
                        decision = Console.ReadLine();
                        if (decision == "Y")
                        {
                            URLS.Dequeue();

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ya no puede retroceder mas");
                        decision = "N";
                    }
                }
            }
                string expresionValida = "{ [ ( a + b ) ] }";
    string expresionInvalida = "{ [ ( a + b } ] )";

    Console.WriteLine(VerificarDelimitadoresConQueue(expresionValida));   
    Console.WriteLine(VerificarDelimitadoresConQueue(expresionInvalida)); 

    bool VerificarDelimitadoresConQueue(string expresion)
    {
        Queue<char> aperturas = new Queue<char>();
        Queue<char> cierres = new Queue<char>();

        foreach (char caracter in expresion)
        {
            if (caracter == '(' || caracter == '[' || caracter == '{')
            {
                aperturas.Enqueue(caracter);
            }
            else if (caracter == ')' || caracter == ']' || caracter == '}')
            {
                
                cierres.Enqueue(caracter);
            }
        }

        
        if (aperturas.Count != cierres.Count) return false;

     
        char[] cierresArray = cierres.ToArray();
        int indiceCierre = cierresArray.Length - 1;

        while (aperturas.Count > 0)
        {
            char aperturaActual = aperturas.Dequeue();
            char cierreCorrespondiente = cierresArray[indiceCierre];
            indiceCierre--;

            switch (aperturaActual)
            {
                case '(': if (cierreCorrespondiente != ')') return false; break;
                case '[': if (cierreCorrespondiente != ']') return false; break;
                case '{': if (cierreCorrespondiente != '}') return false; break;
            }
        }

        return true;
    }

    void AccionTextoo()
    {


        Queue<AccionTexto> historial = new Queue<AccionTexto>();




        historial.Enqueue(new AccionTexto("Escribir", "Hola "));
        Console.WriteLine("[Acción] Escribir: 'Hola '");

        historial.Enqueue(new AccionTexto("Escribir", "Mundo"));
        Console.WriteLine("[Acción] Escribir: 'Mundo'");

        historial.Enqueue(new AccionTexto("Borrar", "Mundo"));
        Console.WriteLine("[Acción] Borrar: 'Mundo'");




        Console.WriteLine("--- Presionando Deshacer ---");


        if (historial.Count > 0)
        {
            AccionTexto ultimaAccion = historial.Dequeue();
            Console.WriteLine($"[Deshacer] Revertido {ultimaAccion.TipoAccion}: Se eliminó '{ultimaAccion.Contenido}'.");
        }


        if (historial.Count > 0)
        {
            AccionTexto ultimaAccion = historial.Dequeue();
            Console.WriteLine($"[Deshacer] Revertido {ultimaAccion.TipoAccion}: Se restauró '{ultimaAccion.Contenido}'.");
        }




    }

    double EvaluarRPN(string expresion)


    {
        Queue<double> pila = new Queue<double>();


        string[] elementos = expresion.Split(' ');

        foreach (string elemento in elementos)
        {

            if (double.TryParse(elemento, out double numero))
            {
                pila.Enqueue(numero);
            }

            else if (elemento == "+" || elemento == "-" || elemento == "*" || elemento == "/")
            {

                double operandoB = pila.Dequeue();

                double operandoA = pila.Dequeue();

                switch (elemento)
                {
                    case "+": pila.Enqueue(operandoA + operandoB); break;
                    case "-": pila.Enqueue(operandoA - operandoB); break;
                    case "*": pila.Enqueue(operandoA * operandoB); break;
                    case "/": pila.Enqueue(operandoA / operandoB); break;
                }
            }
        }
        return pila.Dequeue();
    }
    void Tareas()
    {
        Queue<Tarea> pilaTareas = new Queue<Tarea>();

        pilaTareas.Enqueue(new Tarea(1, "Configurar Base de Datos", "Alta", 120));
        pilaTareas.Enqueue(new Tarea(2, "Diseñar Interfaz UI", "Media", 60));
        pilaTareas.Enqueue(new Tarea(3, "Corregir Bug de Login", "Crítica", 30));

        Console.WriteLine($"Se registraron {pilaTareas.Count} tareas en el sistema.\n");

        if (pilaTareas.Count > 0)
        {
            Tarea proximaTarea = pilaTareas.Peek();
            Console.WriteLine($"[CIMA] Siguiente tarea a atender: '{proximaTarea.Titulo}' (Prioridad: {proximaTarea.Prioridad})");
        }


        Console.WriteLine("\n--- Procesando tareas en orden ---");

        while (pilaTareas.Count > 0)
        {
            Tarea tareaAtendida = pilaTareas.Dequeue();
            Console.WriteLine($"[Atendida] ID {tareaAtendida.Id}: '{tareaAtendida.Titulo}' finalizada en {tareaAtendida.EstimacionMinutos} mins.");
        }
    }
        }
    }
}

