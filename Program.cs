using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();
            bool TieneDatos = await db.punto.AnyAsync();
            if (!TieneDatos)
            {
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

                    x = PrimerPunto.x,

                    y = PrimerPunto.y


                };
                var nuevo2 = new punto
                {

                    x = SegundoPunto.x,

                    y = SegundoPunto.y


                };
                var nuevo3 = new punto
                {

                    x = TercerPunto.x,

                    y = TercerPunto.y


                };
                db.punto.Add(nuevo);
                db.punto.Add(nuevo2);
                db.punto.Add(nuevo3);
                
            }
            int id = 3;
            var datoBuscado = await db.punto.FindAsync(id);
            //Update
            if (datoBuscado != null)
            {
                Console.WriteLine("Ingrese un nuevo valor para el tercer punto");
                int XTercerPunto = int.Parse(Console.ReadLine());
                int YTercerPunto = int.Parse(Console.ReadLine());
                datoBuscado.x = XTercerPunto;
                datoBuscado.y = YTercerPunto;
                await db.SaveChangesAsync();
            }
            int id2 = 1;
            var datoBuscado2 = await db.punto.FindAsync(id2);
            if (datoBuscado2 != null)
            {
                db.punto.Remove(datoBuscado2);
                await db.SaveChangesAsync();
            }

            var todosLosPuntos = await db.punto.ToListAsync();

            
            foreach (var p in todosLosPuntos)
            {
               
                Console.WriteLine($"ID: {p.id} Coordenadas: {p.x}, {p.y}");
            }

            await db.SaveChangesAsync();
 
        }
    }
}
