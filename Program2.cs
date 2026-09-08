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
        }
    }
}

