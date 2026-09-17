using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext;
            Console.WriteLine("Ingrese el Valor x de la primer variable");
            int ValorX1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Valor y de la primer variable");
            int ValorY1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Valor x de la segunda variable");
            int ValorX2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Valor y de la segunda variable");
            int ValorY2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Valor x de la tercer variable");
            int ValorX3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Valor y de la tercer variable");
            int ValorY3 = int.Parse(Console.ReadLine());
            Punto2D PrimerPunto = new Punto2D(ValorX1, ValorY1);
            Punto2D SegundoPunto = new Punto2D(ValorX2, ValorY2);
            Punto2D TercerPunto = new Punto2D(ValorX3, ValorY3);
            Stack<Punto2D> Hola = new Stack<Punto2D>();
            Hola.Push(PrimerPunto);
            Hola.Push(SegundoPunto);
            Hola.Push(TercerPunto);
            PrimerPunto.Mostrar();
            SegundoPunto.Mostrar();
            TercerPunto.Mostrar();

            var nuevo = new punto
            {

                x = PrimerPunto.x

               Y =


            };

            db.Datos.Add(nuevo);


        }
    }
}
