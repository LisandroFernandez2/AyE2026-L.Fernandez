namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbolitox = new Arbol();
            arbolitox.Insertar(50);
            arbolitox.Insertar(20);
            arbolitox.Insertar(30);
            arbolitox.Insertar(70);
            arbolitox.Insertar(10);
            arbolitox.Insertar(80);

            Console.WriteLine("Busqueda valor");
            Console.WriteLine(arbolitox.buscar(20));
            Console.WriteLine(arbolitox.ObtenerMinimo(arbolitox.Raiz));
            Console.WriteLine(arbolitox.ObtenerMaximo(arbolitox.Raiz));
            Console.WriteLine(arbolitox.ObtenerCantidadNodos(arbolitox.Raiz));
            Console.WriteLine("La altura es " + arbolitox.ObtenerAltura(arbolitox.Raiz));
        }
    }
}
