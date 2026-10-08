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

            QuickSort(VectorNumerosDesordenados, 0, VectorNumerosDesordenados.Length - 1);

            foreach (int numero in VectorNumerosDesordenados)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("BURBUJA CLASICO:");
            Burbuja_clasico(VectorNumerosDesordenados);
            Console.WriteLine("BURBUJA OPTIMIZADO:");
            Burbuja_optimizado(VectorNumerosDesordenados);
            Console.WriteLine("SELECCION:");
            Seleccion(VectorNumerosDesordenados);
            // BÚSQUEDA SECUENCIAL
            // Explicación: Recorre la lista desde el principio hasta encontrar el número buscado.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n).
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
            // BÚSQUEDA SECUENCIAL OPTIMIZADA
            // Explicación: Recorre la lista y, si encuentra un número mayor al buscado,
            // deja de buscar porque sabe que ya no puede encontrarlo.
            // Complejidad algorítmica: O(n).
            // Para que la busqueda secuencial optimizada funcione, el arreglo debe estar ordenado de menor a mayor
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
            // BÚSQUEDA BINARIA
            // Explicación: Busca el número comparándolo con el elemento del medio.
            // Si el buscado es menor, busca en la mitad izquierda.
            // Si es mayor, busca en la mitad derecha.
            // Complejidad algorítmica: O(log n).
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
            // BURBUJA CLÁSICO
            // Explicación: Compara números que están juntos y los intercambia si están desordenados.
            // Condición: No necesita ninguna condición especial.
            // Complejidad algorítmica: O(n²).
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
            // BURBUJA OPTIMIZADO
            // Explicación: Funciona como la burbuja clásica, pero deja de ordenar
            // cuando detecta que ya no hubo ningún intercambio.
            // Condición: No necesita ninguna condición especial.
            // Complejidad algorítmica: O(n²) en el peor caso.
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
            // SELECCIÓN
            // Explicación: Busca el número menor y lo coloca en la primera posición disponible.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n²).
            void Seleccion(int[] NumerosDesordenados)
            {
                int[] numeros = { 5, 2, 8, 1, 3 };

                for (int i = 0; i < numeros.Length - 1; i++)
                {
                    int menor = i;

                    for (int j = i + 1; j < numeros.Length; j++)
                    {
                        if (numeros[j] < numeros[menor])
                        {
                            menor = j;
                        }
                    }

                    int aux = numeros[i];
                    numeros[i] = numeros[menor];
                    numeros[menor] = aux;
                }

                foreach (int numero in numeros)
                {
                    Console.WriteLine(numero);
                }

            }
            // INSERCIÓN
            // Explicación: Va tomando cada elemento y lo coloca en la posición correcta
            // dentro de la parte que ya está ordenada.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n²) en el peor caso.
            void Insercion(int[] NumerosDesordenados)
            {
                for (int i = 1; i < NumerosDesordenados.Length - 1; i++)
                {
                    int Auxiliar = NumerosDesordenados[i]; // 7
                    for (int j = i; j >= 0; j--) // primera vuelta: j vale 1
                    {
                        if (Auxiliar > NumerosDesordenados[j])// 7 es mayor que 7?
                        {
                            NumerosDesordenados[j + 1] = NumerosDesordenados[j];
                        }
                        else if (Auxiliar < NumerosDesordenados[j] || NumerosDesordenados[j] == NumerosDesordenados[0])// va aca
                        {
                            NumerosDesordenados[j] = Auxiliar;
                            break;
                        }

                    }
                }
                for (int x = 0; x < NumerosDesordenados.Length - 1; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }
            }
            // QUICKSORT
            // Explicación: Elige un elemento llamado pivote y separa los números
            // en menores y mayores que él.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n log n) en promedio.
            void QuickSort(int[] numeros, int inicio, int fin)
            {
                if (inicio >= fin)
                    return;

                int i = inicio;
                int j = fin;
                int pivote = numeros[(inicio + fin) / 2];

                while (i <= j)
                {
                    while (numeros[i] < pivote)
                        i++;

                    while (numeros[j] > pivote)
                        j--;

                    if (i <= j)
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;

                        i++;
                        j--;
                    }
                }

                QuickSort(numeros, inicio, j);
                QuickSort(numeros, i, fin);
            }
            // BOGOSORT
            // Explicación: Mezcla los números al azar hasta que quedan ordenados.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n × n!) aproximadamente.
            void Bogosort(int[] NumerosDesordenados)
            {
                Random random = new Random();

                while (true)
                {
                    // Mezclar
                    for (int i = 0; i < NumerosDesordenados.Length; i++)
                    {
                        int j = random.Next(NumerosDesordenados.Length);

                        int aux = NumerosDesordenados[i];
                        NumerosDesordenados[i] = NumerosDesordenados[j];
                        NumerosDesordenados[j] = aux;
                    }

                    // Comprobar si está ordenado
                    bool ordenado = true;

                    for (int i = 0; i < NumerosDesordenados.Length - 1; i++)
                    {
                        if (NumerosDesordenados[i] > NumerosDesordenados[i + 1])
                        {
                            ordenado = false;
                            break;
                        }
                    }

                    if (ordenado)
                        break;
                }
            }
            // STALINSORT
            // Explicación: Recorre la lista y elimina los elementos que están
            // fuera de orden respecto al anterior.
            // Condición: La lista puede estar desordenada.
            // Complejidad algorítmica: O(n).
            void Stalin(int[] numeros)
            {

                int anterior = numeros[0];

                for (int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] >= anterior)
                    {
                        anterior = numeros[i];
                        Console.WriteLine(numeros[i]);
                    }
                }
            }
            // ¿CUÁL CREEMOS QUE ES LA BÚSQUEDA MÁS EFICIENTE?
            // La búsqueda binaria, porque en cada paso descarta aproximadamente
            // la mitad de la lista. Su complejidad es O(log n).
            // ¿CUÁL CREEMOS QUE ES EL ORDENAMIENTO MÁS EFICIENTE?
            // De los ordenamientos que usamos, QuickSort suele ser el más eficiente
            // en promedio, con una complejidad de O(n log n).
            // ¿QUÉ ES LA COMPLEJIDAD ALGORÍTMICA?
            // Es una forma de medir cuánto tiempo o recursos necesita un algoritmo
            // a medida que aumenta la cantidad de elementos que tiene que procesar.
        }
    }
}
