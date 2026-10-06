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
            int[] VectorNumerosDesordenados = 
            {
                    42, 7, 89, 15, 63, 2, 55, 18, 91, 34,
                    4, 76, 23, 68, 11, 80, 47, 3, 59, 12,
                    95, 28, 71, 6, 50, 84, 19, 62, 37, 8,
                    44, 99, 14, 73, 25, 52, 9, 87, 31, 66,
                    1, 78, 20, 57, 82, 33, 16, 90, 49, 5
            };
            int izquierda = VectorNumeros[0];
            int derecha = VectorNumeros[VectorNumeros.Length - 1];
            Console.WriteLine("Ingrese el numero que quiere buscar");
            int buscar = int.Parse(Console.ReadLine());
            Console.WriteLine(Busqueda_secuencial(VectorNumeros, buscar));
            Console.WriteLine(Busqueda_secuencial_optimizada(VectorNumeros, buscar));
            Console.WriteLine(Busqueda_binaria(VectorNumeros, buscar));
            BinariaRecursiva(((izquierda + derecha) / 2), izquierda, derecha, buscar);
           
            Console.WriteLine("BURBUJA CLASICO:");
            Burbuja_clasico(VectorNumerosDesordenados);
            Console.WriteLine("BURBUJA OPTIMIZADO:");
            Burbuja_optimizado(VectorNumerosDesordenados);
            Console.WriteLine("SELECCION:");
            Seleccion(VectorNumerosDesordenados);
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
            // AL IGUAL QUE LAS OTRAS BUSQUEDAS, SE REQUIERE QUE ESTE ORDENADO
            void BinariaRecursiva(int central, int izquierda, int derecha, int numeroBuscar)
            {
                if (izquierda > derecha || numeroBuscar > derecha || numeroBuscar < izquierda)
                {
                    Console.WriteLine("No se encontro");
                }
                else if (numeroBuscar < VectorNumeros[central])
                {
                    derecha = central - 1;
                    central = (izquierda + derecha) / 2;
                    BinariaRecursiva(central, izquierda, derecha, buscar);
                }
                else if (numeroBuscar > VectorNumeros[central])
                {
                    izquierda = derecha + 1;
                    central = (izquierda + derecha) / 2;
                    BinariaRecursiva(central, izquierda, derecha, buscar);
                }
                else if (numeroBuscar == VectorNumeros[central])
                {
                    Console.WriteLine("La posicion del numero es: " + central);
                }


            }
            // OTRO FOR QUE IMPRIME LA LISTA YA ORDENADA EN LA CONSOLA
            void Burbuja_clasico(int[] NumerosDesordenados)
            {
                // FOR ANIDADO QUE SIRVE PARA ORDENAR LA LISTA
                for (int j = 0; j < NumerosDesordenados.Length - 1; j++)
                {
                    for (int i = 0; i < NumerosDesordenados.Length - 1; i++)
                    {
                        if (NumerosDesordenados[i] > NumerosDesordenados[i + 1])
                        {
                            // CREO UN AUXILIAR YA QUE SI AL ASIGNARLE NUMEROSDESORDENADOS[I] A NUMEROSDESORDENADOS[I+1], TENDRIA 
                            // EL MISMO VALOR YA QUE ANTES HICE NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            int Aux = NumerosDesordenados[i];
                            NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            NumerosDesordenados[i + 1] = Aux;
                        }
                    }
                }
                // OTRO FOR QUE IMPRIME LA LISTA YA ORDENADA EN LA CONSOLA
                for (int x = 0; x < NumerosDesordenados.Length; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }
            }
            // NO SE TIENE QUE CUMPLIR NINGUNA CONDICION
            void Burbuja_optimizado(int[] NumerosDesordenados)
            {
                // FOR ANIDADO QUE SIRVE PARA ORDENAR LA LISTA
                for (int j = 0; j < NumerosDesordenados.Length - 1; j++)
                {
                    // CREO UNA VARIABLE BOOLEANA LLAMADA ESTA DESORDENADA, LA CUAL EN CADA PASADA VA A VERIFICAR SI HUBO UN INTERCAMBIO
                    // SI HUBO UN INTERCAMBIO PASA A TRUE, SI NO SE QUEDA EN FALSE. AL FINAL DEL FOR, VERIFICA SI ESTAORDENADA ES FALSE, EN ESE CASO
                    // ROMPE EL FOR YA QUE SIGNIFICA QUE ESTA TODO ORDENADO
                    bool EstaDesordenado = false;
                    for (int i = 0; i < NumerosDesordenados.Length - 1; i++)
                    {
                        if (NumerosDesordenados[i] > NumerosDesordenados[i + 1])
                        {
                            // CREO UN AUXILIAR YA QUE SI AL ASIGNARLE NUMEROSDESORDENADOS[I] A NUMEROSDESORDENADOS[I+1], TENDRIA 
                            // EL MISMO VALOR YA QUE ANTES HICE NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            int Aux = NumerosDesordenados[i];
                            NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            NumerosDesordenados[i + 1] = Aux;
                            EstaDesordenado = true;
                        }
                    }
                    if (EstaDesordenado == false)
                    {
                        break;
                    }
                }
                // OTRO FOR QUE IMPRIME LA LISTA YA ORDENADA EN LA CONSOLA
                for (int x = 0; x < NumerosDesordenados.Length; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }

            }
           // NO SE TIENE QUE CUMPLIR NINGUNA CONDICION
            void Seleccion(int[] NumerosDesordenados)
            {
                int Limite = 0;
                int NumeroMenor = 0;
                for (int y = 0; y < NumerosDesordenados.Length - 1; y++)
                {
                    for (int i = Limite; i < NumerosDesordenados.Length - 1; i++)
                    {
                        if (NumerosDesordenados[i] < NumerosDesordenados[i + 1])
                        {
                            NumeroMenor = NumerosDesordenados[i];
                        }
                    }
                    Limite++;
                }
                for (int x = 0; x < NumerosDesordenados.Length - 1; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }
            }
            void Insercion(int[] NumerosDesordenados)
            {
                for (int i = 1; i < NumerosDesordenados.Length - 1; i++)
                {
                    int Auxiliar = NumerosDesordenados[i]; 
                    int j = i - 1;
                    while (j >= 0 && NumerosDesordenados[j] > Auxiliar)
                    {
                        NumerosDesordenados[j + 1] = NumerosDesordenados[j];
                        j = j - 1;
                    }
                    NumerosDesordenados[j + 1] = Auxiliar;
                }
                for (int x = 0; x < NumerosDesordenados.Length - 1; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }
            }
        }
    }
}
