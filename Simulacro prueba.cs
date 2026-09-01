namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Ubicacion> HistorialUbicaciones = new Stack<Ubicacion>();
            Ubicacion PrimeraUbicacion = new Ubicacion(5, 5, "Bosque");
            Ubicacion SegundaUbicacion = new Ubicacion(2, 5, "Selva");
            Ubicacion TerceraUbicacion = new Ubicacion(15, 25, "Cueva");
            HistorialUbicaciones.Push(PrimeraUbicacion);
            HistorialUbicaciones.Push(SegundaUbicacion);
            HistorialUbicaciones.Push(TerceraUbicacion);
            foreach (Ubicacion si in HistorialUbicaciones)
            {
                Console.WriteLine("Zona: " + si.NombreZona);
            }


            for (int i = 0; i < HistorialUbicaciones.Count; i++)
            {
                Console.Write("Usted retrocedio de " + HistorialUbicaciones.Peek().NombreZona);
                HistorialUbicaciones.Pop();
                Console.Write(" A " + HistorialUbicaciones.Peek().NombreZona);
                Console.WriteLine();
            }
        }
    }
}
