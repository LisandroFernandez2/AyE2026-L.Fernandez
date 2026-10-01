namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[50] {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                    21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                    31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                    41, 42, 43, 44, 45, 46, 47, 48, 49, 50
            };
            Console.WriteLine("Ingrese el numero que quiere buscar");
            int buscar = int.Parse(Console.ReadLine());
            Console.WriteLine(Busqueda_secuencial(vector, buscar));
            Console.WriteLine(Busqueda_secuencial_optimizada(vector, buscar));
            Console.WriteLine(Busqueda_binaria(vector, buscar));
            string Busqueda_secuencial(int[] numeros, int buscar)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == buscar)
                    {
                        return "Esta en la posicion " + i;
                    }
                }
                return "No se encuentra su numero";
            }
            string Busqueda_secuencial_optimizada(int[] numeros, int buscar)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == buscar) 
                    {
                        return "Esta en la posicion " + i;
                    }
                    if (numeros[i] > buscar)
                    {
                        break;
                    }
                }
                return "No se encuentra su numero";
            }
            int Busqueda_binaria(int[] numeros, int NumeroBuscado)
            {
                int indice = numeros.Length / 2 + 1;
                while (indice != NumeroBuscado)
                {
                    if (numeros[indice] == NumeroBuscado)
                    {
                        return numeros[indice];
                    }
                    if (numeros[indice] < NumeroBuscado)
                    {
                        indice = indice + 1;
                    }
                    else if (numeros[indice] > NumeroBuscado)
                    {
                        indice = indice - 1;
                    }
                    
                }
                return 0;
            }
        }
    }
}

