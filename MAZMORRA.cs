namespace ConsoleApp1
{
    internal class Program
    {
        public struct Personaje
        {
          public  string nombre { get; set; }
           public int poder { get; set; }
           public string[] items { get; set; }


            public Personaje(string n, int p, string[] i)
            {

                nombre = n;
                poder = p;
                items = i;


            }
            public void Robar(int dificultad, string item, int poderitem)
            {
                
                if (poder > dificultad)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (items[i] == null)
                        {
                            items[i] = item;
                            poder += poderitem;
                            break;
                        }
                    }
                    Console.WriteLine($"El objeto robado es {item} con un poder de {poderitem}, por lo cual el poder actual de {nombre} es {poder}");
                }
                else
                {
                    Console.WriteLine("El nivel de la sala es mayor a la del personaje, por lo cual no ha podido robar ningun objeto.");
                }



            }
        }
        public struct Salas
        {
           public int dificultad { get; set; }
            public string item { get; set; }
            public int poderitem { get; set; }

            public Salas(int d, string it, int po)
            {
                dificultad = d;
                item = it;
                poderitem = po;
            }


        }
    
        static void Main(string[] args)
        {

            Personaje Personaje1 = new Personaje("Federico", 10, new string[20]);
            Personaje Personaje2 = new Personaje("Lisandro", 10, new string[20]);
            string[] objetosBatalla = new string[20] { "Espada de Hierro", "Arco de Cazador", "Báculo de Fuego", "Daga Envenenada", "Hacha de Guerra", "Lanza Sagrada", "Casco de Acero", "Peto de Placas", "Escudo de Torre", "Guanteletes de Cuero", "Botas de Velocidad", "Capa de Invisibilidad", "Poción de Vida", "Poción de Maná", "Elíxir de Fuerza", "Antídoto de Veneno", "Anillo de Poder", "Amuleto de Protección", "Piedra de Resurrección", "Pergamino de Teletransportación" };
            for (int NumeroDeTurno = 1; NumeroDeTurno <= 20; NumeroDeTurno++)
            {
                Random aleatorio = new Random();
                int DificultadDeSala = aleatorio.Next(0, 35);
                Random aleatorio2 = new Random();
                string ObjetoDeSala = objetosBatalla[aleatorio2.Next(0, 20)];
                Random aleatorio3 = new Random();
                int PoderDeSala = aleatorio3.Next(0, 5);
                Salas Sala = new Salas(DificultadDeSala, ObjetoDeSala, PoderDeSala);
                Console.WriteLine("TURNO " + NumeroDeTurno);
                if (NumeroDeTurno % 2 == 0)
                {
                    Personaje1.Robar(Sala.dificultad,Sala.item,Sala.poderitem);
                }
                else
                {
                    Personaje2.Robar(Sala.dificultad, Sala.item, Sala.poderitem);
                }
            }
            if (Personaje1.poder > Personaje2.poder)
            {
                Console.WriteLine("El ganador de la batalla es " + Personaje1.nombre + " sus items son: ");
                for (int i = 0; i < 20; i++)
                {
                    if (Personaje1.items[i] != null)
                    {
                        Console.WriteLine(Personaje1.items[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("El ganador de la batalla es " + Personaje2.nombre + " sus items son: ");
                for (int i = 0; i < 20; i++)
                {
                    if (Personaje2.items[i] != null)
                    {
                        Console.WriteLine(Personaje2.items[i]);
                    }
                }
            }
        }

    }



}

