
string[] nombre = new string[100];
string[] numeros = new string[100];
bool continua = true;
while (continua)
{
    Console.WriteLine("¿Que desea hacer?: 1- añadir nombre de contactos 2- añadir numero de contacto 3-mostrar todos los contactos 4-buscar por nombre 5-terminar el programa");
    int eleccion = int.Parse(Console.ReadLine());
    switch (eleccion)
    {
        case 1:
            añadir(nombre);
            break;

        case 2:
            numerosañadir(numeros);
            break;

        case 3:
            mostrar(nombre);
            break;

        case 4:
            buscar(nombre);
            break;
        case 5:
            continua = false;
            break;
        default:
            Console.WriteLine("El numero ingresado no corresponde a los parametros especificados");
            break;
    }
}
string[] buscar()
{
    Console.WriteLine("Ingrese el nombre a buscar");
    string buscar = Console.ReadLine();
    for(int i = 0; i < nombre.Length; i++)
    {
        if (buscar == nombre[i])
        {
            Console.WriteLine("Nombre encontrado: " + nombre[i]);
        }
    }
    return nombre;
}
string[] añadir(string[] listanombres)
{
    Console.WriteLine("¿Cuantos contactos desea añadir?");
    int cantidadcont = int.Parse(Console.ReadLine());
    for (int i = 0; i < cantidadcont; i++)
    {
        listanombres[i] = Console.ReadLine();
    }
    return listanombres;
}
string[] numerosañadir(string[] listanumeros)
{
    Console.WriteLine("¿Cuantos numeros desea añadir?");
    int cantidadnum = int.Parse(Console.ReadLine());
    for (int i = 0; i < cantidadnum; i++)
    {
        numeros[i] = Console.ReadLine();
    }
    return numeros;
}
string[] mostrar(string[] listanombres)
{
    for (int i = 0; i < listanombres.Length - 1; i++)
    {
        Console.WriteLine(listanombres[i]);
    }
    return listanombres;
}
