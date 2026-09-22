using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var productos = new AppDbContext();
            var producto1 = new productito { nombre = "Zanahoria", codigo = 4955, precio = 25.99m };
            var producto2 = new productito { nombre = "Calabaza", codigo = 2300, precio = 12.99m };
            var producto3 = new productito { nombre = "Manzana", codigo = 7812, precio = 17.99m };
            productito[] productoLista = [producto1, producto2, producto3];
            productos.productos.Add(producto1);
            productos.productos.Add(producto2);
            productos.productos.Add(producto3);
            foreach (productito p in productoLista)
            {
                Console.WriteLine($"Producto: {p.nombre} Precio: {p.precio}");
            }
            await productos.SaveChangesAsync();
        }
    }
}
