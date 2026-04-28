using System.ComponentModel.Design;
void ejercicioA()
{
    for (int x = 0; x <= 100; x += 3)
    {
        Console.WriteLine(x);
    }
}
ejercicioA();

void ejercicioB()
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
ejercicioB();

void ejercicioC()
{
    Console.WriteLine("Escribí una palabra:");
    string palabra = Console.ReadLine();

    int cantidad = palabra.Length;

    Console.WriteLine("La palabra tiene " + cantidad + " letras.");
}
ejercicioC();

void ejercicioD()
{

    int acum = 0;
    Console.WriteLine("Intente adivinar la contraseña, solo tiene 5 intentos");
    string adiv = Console.ReadLine();
    while (acum <= 3 && adiv != "bocajrs")
    {
        acum = acum + 1;
        Console.WriteLine("Intente de vuelta");
        adiv = Console.ReadLine();
    }
    if (adiv != "bocajrs")
    {
        Console.WriteLine("Acceso denegado, no ha logrado adivinar la contraseña secreta");
    }
    else
    {
        Console.WriteLine("Felicidades, ha adivinado la contraseña");
    }
}
ejercicioD();
void ejercicioE()
{

    
  
        Console.WriteLine("Ingrese un número:");
        int mayor = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine("Ingrese un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > mayor)
            {
                mayor = numero;
            }
        }

        Console.WriteLine("El número más alto es " + mayor);
    

    
}
ejercicioE();

void ejercicioF()
{
    Console.WriteLine("Por favor, escriba su nombre");

    string nombre = Console.ReadLine();
    Console.WriteLine("Por favor, ingrese que cantidad de letras de su nombre desea mostrar en mayuscula");
    int numeroparte = (Convert.ToInt32(Console.ReadLine()));
    
       string parte = nombre.Substring(0, numeroparte);
        string partemayu = parte.ToUpper();
        Console.WriteLine(partemayu);
    
   
}
ejercicioF();
void ejercicioG()
{
    for (int i = 1; i <=10; i++)
    {
        Console.WriteLine(i * 7);
    }
}  
ejercicioG();
void ejercicioH()
{
    for (int i = 10; i > 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("oa");


}
ejercicioH();
void ejercicioI() {
Console.WriteLine("Ingrese un numero");
int numeroing = (Convert.ToInt32(Console.ReadLine()));
if (numeroing % 2 == 0) {
Console.WriteLine("su numero es par");
}
else 
{
Console.WriteLine("su numero no es par");
}
}
ejercicioI():
