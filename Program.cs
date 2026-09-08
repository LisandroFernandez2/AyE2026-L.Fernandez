using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PalabraInvertida()
            {
                Stack<char> PalabraInvertida = new Stack<char>();
                Console.WriteLine("Ingrese una palabra");
                string PalabraIngresada = Console.ReadLine();
                foreach (char c in PalabraIngresada)
                {
                    PalabraInvertida.Push(c);

                }
                foreach (var c in PalabraInvertida)
                {
                    Console.WriteLine(c);

                }
            }
            
            void Paginas()
            {
                string decision = "Y";
                Stack<string> URLS = new Stack<string>();
                URLS.Push("classroom.com");
                URLS.Push("tasks.com");
                URLS.Push("github.com");

                while (decision != "N")
                {
                    try
                    {
                        Console.WriteLine("Pagina actual:" + URLS.Peek());
                        Console.WriteLine("Desea retroceder? Y/N");
                        decision = Console.ReadLine();
                        if (decision == "Y")
                        {
                            URLS.Pop();

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

            Console.WriteLine(VerificarDelimitadores(expresionValida));
            Console.WriteLine(VerificarDelimitadores(expresionInvalida));

            bool VerificarDelimitadores(string expresion)
            {
                Stack<char> pila = new Stack<char>();

                foreach (char caracter in expresion)
                {
                    if (caracter == '(' || caracter == '[' || caracter == '{')
                    {
                        pila.Push(caracter);
                    }
                    else if (caracter == ')' || caracter == ']' || caracter == '}')
                    {
                        if (pila.Count == 0) return false;

                        char aperturaTop = pila.Pop();

                        switch (caracter)
                        {
                            case ')': if (aperturaTop != '(') return false; break;
                            case ']': if (aperturaTop != '[') return false; break;
                            case '}': if (aperturaTop != '{') return false; break;
                        }
                    }
                }

                return pila.Count == 0;
            }

            void AccionTextoo()
            {


                Stack<AccionTexto> historial = new Stack<AccionTexto>();




                historial.Push(new AccionTexto("Escribir", "Hola "));
                Console.WriteLine("[Acción] Escribir: 'Hola '");

                historial.Push(new AccionTexto("Escribir", "Mundo"));
                Console.WriteLine("[Acción] Escribir: 'Mundo'");

                historial.Push(new AccionTexto("Borrar", "Mundo"));
                Console.WriteLine("[Acción] Borrar: 'Mundo'");




                Console.WriteLine("\n--- Presionando Deshacer (Undo) ---");


                if (historial.Count > 0)
                {
                    AccionTexto ultimaAccion = historial.Pop();
                    Console.WriteLine($"[Deshacer] Revertido {ultimaAccion.TipoAccion}: Se restauró '{ultimaAccion.Contenido}'.");
                }


                if (historial.Count > 0)
                {
                    AccionTexto ultimaAccion = historial.Pop();
                    Console.WriteLine($"[Deshacer] Revertido {ultimaAccion.TipoAccion}: Se eliminó '{ultimaAccion.Contenido}'.");
                }




            }

            double EvaluarRPN(string expresion)


            {
                Stack<double> pila = new Stack<double>();

                
                string[] elementos = expresion.Split(' ');

                foreach (string elemento in elementos)
                {
                    
                    if (double.TryParse(elemento, out double numero))
                    {
                        pila.Push(numero);
                    }
                    
                    else if (elemento == "+" || elemento == "-" || elemento == "*" || elemento == "/")
                    {
                        
                        double operandoB = pila.Pop();
                        
                        double operandoA = pila.Pop();

                        switch (elemento)
                        {
                            case "+": pila.Push(operandoA + operandoB); break;
                            case "-": pila.Push(operandoA - operandoB); break;
                            case "*": pila.Push(operandoA * operandoB); break;
                            case "/": pila.Push(operandoA / operandoB); break;
                        }
                    }
                }
                return pila.Pop();
            }
        
            void Tareas()
            {
                Stack<Tarea> pilaTareas = new Stack<Tarea>();

                pilaTareas.Push(new Tarea(1, "Configurar Base de Datos", "Alta", 120));
                pilaTareas.Push(new Tarea(2, "Diseñar Interfaz UI", "Media", 60));
                pilaTareas.Push(new Tarea(3, "Corregir Bug de Login", "Crítica", 30));

                Console.WriteLine($"Se registraron {pilaTareas.Count} tareas en el sistema.\n");

                if (pilaTareas.Count > 0)
                {
                    Tarea proximaTarea = pilaTareas.Peek();
                    Console.WriteLine($"[CIMA] Siguiente tarea a atender: '{proximaTarea.Titulo}' (Prioridad: {proximaTarea.Prioridad})");
                }


                Console.WriteLine("\n--- Procesando tareas en orden ---");

                while (pilaTareas.Count > 0)
                {
                    Tarea tareaAtendida = pilaTareas.Pop();
                    Console.WriteLine($"[Atendida] ID {tareaAtendida.Id}: '{tareaAtendida.Titulo}' finalizada en {tareaAtendida.EstimacionMinutos} mins.");
                }
            }
        }

    }
}

