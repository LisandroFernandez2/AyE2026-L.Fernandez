namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbolitox = new Arbol();
            arbolitox.Insertar(50);
            arbolitox.Insertar(60);
            arbolitox.Insertar(70);
            arbolitox.Insertar(80);
            arbolitox.Insertar(90);
            arbolitox.Insertar(85);
            arbolitox.Insertar(95);
            arbolitox.Insertar(50);
            arbolitox.Insertar(20);
            Console.WriteLine("Busqueda valor");
            Console.WriteLine(arbolitox.buscar(20));
            Console.WriteLine(arbolitox.ObtenerMinimo(arbolitox.Raiz));
            Console.WriteLine(arbolitox.ObtenerMaximo(arbolitox.Raiz));
            Console.WriteLine(arbolitox.ObtenerCantidadNodos(arbolitox.Raiz));
            Console.WriteLine("La altura es de: " + arbolitox.ObtenerAltura(arbolitox.Raiz));
            Console.WriteLine("La cantidad de hojas es de: " + arbolitox.ContarHojas(arbolitox.Raiz));
            Console.WriteLine("Ingrese el valor a eliminar");
            int ValorEliminar = int.Parse(Console.ReadLine());
            arbolitox.Eliminar(ValorEliminar);
            Console.WriteLine(arbolitox.EsValido());
        }
    }
}
