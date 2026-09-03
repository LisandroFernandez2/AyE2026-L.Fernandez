namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();
            Personaje PrimerPersonaje = new Personaje(100, 100, "Moverse");
            Personaje SegundoPersonaje = new Personaje(100, 100, "Correr");
            Personaje TercerPersonaje = new Personaje(100, 100, "Pegar");
            historialDelPersonaje.Push(PrimerPersonaje);
            historialDelPersonaje.Push(SegundoPersonaje);
            historialDelPersonaje.Push(TercerPersonaje);

                foreach (Personaje recorrer in historialDelPersonaje)
                {
                    Console.WriteLine("Vida total: " + recorrer.VidaTotal);
                    Console.WriteLine("Vida actual: " + recorrer.VidaActual);
                    Console.WriteLine("Accion: " + recorrer.UltimaAccion);
                    Console.WriteLine("-----------------------------");
                }

                void VolverEnElTiempo(Stack<Personaje> ejemplo)
                {
                    Personaje PersonajeBorrado = ejemplo.Pop();
                    Console.WriteLine("La ultima accion borrada fue: " + PersonajeBorrado.UltimaAccion);
                }
                void Golpear(Personaje ejemplo)
                {
                    ejemplo.UltimaAccion = "Golpe recibido";
                    ejemplo.VidaActual = ejemplo.VidaActual - 20;
                }
                VolverEnElTiempo(historialDelPersonaje);   
                Golpear(historialDelPersonaje.Peek());
        }
    }
}
