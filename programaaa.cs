using System.Security.Cryptography.X509Certificates;
string palabra = "futbol";
string adivinanza;
string auxiliar = "_";
int intentos = 7;
int indice;
bool condicion = true;
Console.WriteLine("Ingrese una letra");
adivinanza = Console.ReadLine(); 
while (condicion)
{
    
    if (adivinanza.Length > 1)
    {
        Console.WriteLine("Ingrese una letra");
        adivinanza = Console.ReadLine();
    }
    else
    {
        condicion = false;
    }
}

for (int i = 0; i < palabra.Length; i++)
{
    indice = i;
    Console.WriteLine(palabra[indice]);
}

for (int x = 0; x <= palabra.Length; x++)
{




}