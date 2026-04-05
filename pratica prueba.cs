using System.ComponentModel.Design;

void ejerciciop1 ()
{
    for (int x = 0; x <= 100; x += 3)
    {
        Console.WriteLine(x);
    }
} 
ejerciciop1();

void ejerciciop2()
{
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad > 18)
    {

        Console.WriteLine("Usted es mayor de edad");

    }
    else if (edad < 18)
    {

        Console.WriteLine("Usted es menor de edad");
    }
    else
    {

        Console.WriteLine("Usted tiene exactamente 18 años");


    }
    
}
ejerciciop2();