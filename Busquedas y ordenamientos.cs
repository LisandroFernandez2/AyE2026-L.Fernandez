namespace Busquedas_y_ordenamientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] VectorNumeros = new int[]
            {
                 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                    21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                    31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                    41, 42, 43, 44, 45, 46, 47, 48, 49, 50
            };
            Console.WriteLine("Ingrese el numero que quiere buscar");
            int buscar = int.Parse(Console.ReadLine());
            Console.WriteLine(Busqueda_secuencial(VectorNumeros, buscar));
            Console.WriteLine(Busqueda_secuencial_optimizada(VectorNumeros, buscar));
            Console.WriteLine(Busqueda_binaria(VectorNumeros, buscar));
           // No se tiene que cumplir ninguna condicion
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
            // Para que la busqueda secuencial optimizada funcione, el arreglo debe estar ordenado de menor a mayor, copilot la concha de tu madre
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
          //    Al igual que la busqueda secuencial optimizada, requiere que la lista este ordenada.
            string Busqueda_binaria(int[] numeros, int NumeroBuscado)
            {
                int IzquierdoInicio = numeros[0];
                int DerechoFinal = numeros[numeros.Length - 1];
                bool FueEncontrado = true;
                while (FueEncontrado)
                {// Posicioncentral toma un nuevo valor en cada vuelta
                    int PosicionCentral = (IzquierdoInicio + DerechoFinal) / 2;
                    if (IzquierdoInicio > DerechoFinal || NumeroBuscado > DerechoFinal || NumeroBuscado < IzquierdoInicio)
                    {
                        // si el numero ingresado es mayor que el final de la lista u o menor, automaticamente rompe el while y retorna que no encontro el numero
                        // ya que por logica, no puede ser mayor que el numero final de la lista ni menor al numero inicial (siempre la lista esta ordenada)
                        FueEncontrado = false;
                    }
                    if (NumeroBuscado < numeros[PosicionCentral])
                    {
                       // Si el numero es menor, el rango a encontrar pasa a ser el inicio de la lista (izquierda vale lo mismo)
                       // y derecha vale el medio - 1 (ya que sabemos que el numero buscado no es el mismo que el del medio)
                        DerechoFinal = PosicionCentral - 1;
                    }
                    else if (NumeroBuscado > numeros[PosicionCentral])
                    {
                        // Si el numero es mayor, el rango a encontrar pasa a ser izquierda
                        // (que ahora vale el medio mas uno, porque sabemos que el numero buscado no es el mismo que el del medio)
                        // y derecha vale lo mismo.
                        IzquierdoInicio = PosicionCentral + 1;
                    }
                    else if (NumeroBuscado == numeros[PosicionCentral])
                    {
                       // Si encuentra el numero, retorna la posicion junto a un texto (para que quede mejor)
                        return "Su numero se encuentra en la posicion " + PosicionCentral;
                    }


                }
               // Si se rompio el while, entonces significa que no encontro el numero
                return "Su numero no existe en la lista";

            }

            }
        }
    }
}
