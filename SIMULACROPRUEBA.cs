using System.Numerics;

string[] nombres = new string[23];
nombres = ["Lisandro", "Lautaro", "Federico", "Matias", "Luciano", "Francesco", "Thiago", "Ramiro", "Juan", "Luis", "Donato", "Camargo", "Traverso", "Olaso", "Zlatna", "Nicolas", "Kevin", "Cesar", "Bruno", "Elias", "Nahuel", "Mateo", "Damian"];
string[] posicion = new string[4];
posicion = ["Delantero", "Mediocampista", "Defensor", "Arquero"];
string[] numero = new string[50];
numero = ["50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"];
string[,] matrizgenerada = new string[23, 3];
string[,] segundamatrizgenerada = new string[23, 3];
Random aleatorio = new Random();
for (int i = 0; i <= 22; i++)
{
    string nombre1 = nombres[aleatorio.Next(0, 23)];
    matrizgenerada[i, 0] = nombre1;
}
for (int i = 0; i<= 22; i++)
{
    string posicion1 = posicion[aleatorio.Next(0, 4)];
    matrizgenerada[i, 1] = posicion1;
}
for (int i = 0; i <= 22; i++)
{
    matrizgenerada[i, 2] = numero[aleatorio.Next(0, 50)];
}
for (int i = 0; i <= 22; i++)
{
    string nombre1 = nombres[aleatorio.Next(0, 23)];
    segundamatrizgenerada[i, 0] = nombre1;
}
for (int i = 0; i <= 22; i++)
{
    string posicion1 = posicion[aleatorio.Next(0, 4)];
    segundamatrizgenerada[i, 1] = posicion1;
}
for (int i = 0; i <= 22; i++)
{
    segundamatrizgenerada[i, 2] = numero[aleatorio.Next(0, 50)];
}
for (int i = 0; i <= 22; i++)
{
    for (int x = 0; x < 3; x++)
    {
        Console.WriteLine(matrizgenerada[i, x]);
    }
}
for (int i = 0; i <= 22; i++)
{
    for (int x = 0; x < 3; x++)
    {
        Console.WriteLine(segundamatrizgenerada[i, x]);
    }
}
int total = 0;
int total2 = 0;
for (int i = 0; i < 23; i++)
{
    total = total + Convert.ToInt32(matrizgenerada[i,2]);
}
for (int i = 0; i < 23; i++)
{
    total2 = total2 + Convert.ToInt32(segundamatrizgenerada[i, 2]);
}
if (total > total2)
{
    Console.WriteLine("El equipo que tiene mas chances de ganar es el equipo 1");
}
else if (total2 > total)
{

    Console.WriteLine("El equipo que tiene mas chances de ganar es el equipo 2");
}
else if (total == total2)
{
    Console.WriteLine("Ambos tienen la misma probabilidad de ganar");
}

int acum = 0;
Console.WriteLine("Elija un numero");
int numeroo = int.Parse(Console.ReadLine());
Console.WriteLine("Elija una potencia");
int numeropotencia = int.Parse(Console.ReadLine());
int resultado = 1;
bool ejercicio2(int numeroo,int numeropotencia, int resultado, int acum)
{
    if (acum == numeropotencia)
    {
        Console.WriteLine("La potencia de su numero es: " + resultado);
        return false;
    }
    else
    {
        resultado = resultado * numeroo;
        acum++;
        ejercicio2(numeroo, numeropotencia,resultado, acum);
        return true;

    }







}
ejercicio2(numeroo, numeropotencia, resultado, acum);