namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<Perro> Perros = new Stack<Perro>();

            Perro primerPerro = new Perro(18, "pepe", "Border Collie");

            Perros.Push(primerPerro);

            Perro segundoPerro = new Perro(15, "lisandro", "callejero");

            Perros.Push(segundoPerro);
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
            string decision = "Y";
            Stack<string> URLS = new Stack<string>();
            URLS.Push("classroom.com");
            URLS.Push("tasks.com");
            URLS.Push("github.com");

            while (decision != "N") {
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

            Stack<string> TextoRandom = new Stack<string>();
            Console.WriteLine("Ingrese una palabra con delimitadores");
            string Palabra = Console.ReadLine();
            TextoRandom.Push(Palabra);
            bool VerificarTexto(string ejemplo)
            {
                bool parentesis = false;
                bool parentesisbienpuesto = false;
                bool corchete = false;
                bool corchetebienpuesto = false;
                bool llaves = false;
                bool llavesbienpuesto = false;
                foreach (char c in ejemplo)
                {
                    if (c == '(')
                    {
                        parentesis = true;
                    }
                    if (c == ')' && parentesis == true)
                    {
                        parentesisbienpuesto = true;
                    }
                }
                foreach (char c in ejemplo)
                {
                    if (c == '[')
                    {
                        corchete = true;
                    }
                    if (c == ']' && corchete == true)
                    {
                        corchetebienpuesto = true;
                    }
                }
                foreach (char c in ejemplo)
                {
                    if (c == '{')
                    {
                       llaves = true;
                    }
                    if (c == '}' && llaves == true)
                    {
                        llavesbienpuesto = true;
                    }
                }
                if (llavesbienpuesto == true && corchetebienpuesto == true && parentesisbienpuesto == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            Console.WriteLine(VerificarTexto(TextoRandom.Peek()));
        }
    }
}
