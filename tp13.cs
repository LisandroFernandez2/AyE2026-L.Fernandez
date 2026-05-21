
string[] ejercicio1()
{
    string[] palabras = { "Dada", "una", "lista", "de", "palabras", "escribir", "un", "programa", "que", "use" };
    string palabramaslarga = palabras[0];
    for (int i = 1; i < palabras.Length; i++)
    {
        if (palabras[i].Length > palabramaslarga.Length)
        {
            palabramaslarga = palabras[i];
        }
    }
    Console.WriteLine($"El nombre con más caracteres es: {palabramaslarga}");
    return palabras;
}
ejercicio1();
string[] ejercicio2()
{
    string[] palabras = { "Dada", "una", "lista", "de", "palabras", "escribir", "un", "programa", "que", "use" };
    string vocales = "aeiou";
    int cantvocal = 0;
    for (int i = 0; i < palabras.Length; i++)
    {
        foreach (char n in palabras[i])
        {
            foreach (char m in vocales)
            {
                if (n == m)
                {
                    cantvocal++;
                }
            }
        }

    }
    Console.WriteLine("La cantidad de vocales de todas las palabras es de: " + cantvocal);
    return palabras;
}
ejercicio2();
void ejercicio3()
{
    Console.WriteLine("Ingrese un factor");
    int factor = (Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Ingrese numeros");
    int[] numeros = new int[5];
    for (int i = 0; i <= numeros.Length - 1; i++)
    {
        numeros[i] = int.Parse(Console.ReadLine());

    }
    for (int i = 0; i <= numeros.Length - 1; i++)
    {
        int resultado = factor * numeros[i];
        int[] multi = new int[5];
        multi[i] = resultado;
        Console.WriteLine("Los valores de la lista son de: " + multi[i]);
    }
}
ejercicio3();