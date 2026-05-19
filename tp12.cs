Console.WriteLine("Ingrese el codigo");
string c = Console.ReadLine();
string c2 = c.ToUpper();
string ejercicio1 (string c2)
{


    switch (c2)
    {
        case "I":
            Console.WriteLine("La cuota es de 800,00 y la categoria es infantiles");
            break;
        case "C":
            Console.WriteLine("La cuota es de 1.000,00 y la categoria es cadete");

            break;
        case "J":
            Console.WriteLine("La cuota es de 1.200,00 y la categoria es juvenil");

            break;
        case "A":
            Console.WriteLine("La cuota es de 900,0 y la categoria es adulto");

            break;
        default:
            Console.WriteLine("El dato ingresado no corresponde a los parametros deseados");
            break;

    }
    return c2;
}
ejercicio1(c2);

Console.WriteLine("Ingrese el tipo");
string t = Console.ReadLine();
string t2 = t.ToUpper();
Console.WriteLine("Ingrese el destino");
string d = Console.ReadLine();
string d2 = d.ToUpper();

string ejercicio2 (string t2, string d2)
{
    int p = 300;
    int acum = 0;
    int acum2 = 0;
    if (t2 == "S")
    {
        acum = 300;
    }
    else if (t2 == "X")
    {
        acum = p + ((p * 20) / 100);
    }
    else if (t2 == "E")
    {
        acum = p + ((p * 40) / 100);
    }
    else
    {
        Console.WriteLine("La letra ingresada no coincide con los parametros establecidos");
    }
    if(d2 == "L")
    {
        acum2 = ((p * 5) / 100);
    }
    else if (d2 == "N")
    {
       acum2 = ((p * 20) / 100);
    }
    else
    {
        Console.WriteLine("La letra ingresada no coincide con los parametros establecidos");
    }
    Console.WriteLine("El coste es de " + (acum + acum2));
    return t2;

}
ejercicio2(t2,d2);

Console.WriteLine("Ingrese el sueldo basico");
int sueldob = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese si corresponde o no el presentismo 0 == CORRESPONDE / 1 == NO CORRESPONDE");
int presentcorr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el codigo de la antiguedad (del 1 al 4)");
int antiguecod = Convert.ToInt32(Console.ReadLine());
int ejercicio3 (int sueldob, int antiguecod, int presentcorr)
{
    double present = 0;
    double sueldonet = 0;
    double remuneracion = 0;
    double descuentos = 0;
    double jubilacion = 0;
    double obrasoci = 0;
    double antigue = 0;
    if (presentcorr == 1)
    {
        present = 0;
    }
    else if (presentcorr == 0)
    {
        present = ((sueldob * 10) / 100);
    }
    if (antiguecod == 1)
    {
        antigue = 0;
    }
    else if (antiguecod == 2)
    {
        antigue = ((sueldob * 10) / 100);
    }
    else if (antiguecod == 3)
    {
        antigue = ((sueldob * 15) / 100);
    }
    else if (antiguecod == 4)
    {
        antigue = ((sueldob * 20) / 100);
    }
    remuneracion = sueldob + antigue + present;
    jubilacion = (remuneracion * 13) / 100;
    obrasoci = (remuneracion * 3) / 100;
    descuentos = jubilacion + obrasoci;
    sueldonet = remuneracion - descuentos;
    Console.WriteLine("Su total de remuneraciones es de: " + remuneracion);
    Console.WriteLine("Su total de descuentos es de: " + descuentos);
    Console.WriteLine("Su sueldo neto es de: " + sueldonet);
    return sueldob;
}
ejercicio3(sueldob, antiguecod, presentcorr);