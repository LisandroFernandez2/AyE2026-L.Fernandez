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


Console.WriteLine("Ingrese el dia con dos digitos");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el mes con dos digitos");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el año con dos digitos");
int año = int.Parse(Console.ReadLine());


int ejercicio4 (int dia, int mes, int año)
{
    string mes2 = "";
    switch (mes)
    {
        case 01:
            mes2 = "enero";
            break;
        case 02:
            mes2 = "febrero";
            break;
        case 03:
            mes2 = "marzo";
            break;
        case 04:
            mes2 = "abril";
            break;
        case 05:
            mes2 = "mayo";
            break;
        case 06:
            mes2 = "junio";
            break;
        case 07:
            mes2 = "julio";
            break;
        case 08:
            mes2 = "agosto";
            break;
        case 09:
            mes2 = "septiembre";
            break;
        case 10:
            mes2 = "octubre";
            break;
        case 11:
            mes2 = "noviembre";
            break;
        case 12:
            mes2 = "diciembre";
            break;
        default:
            Console.WriteLine("Ingrese el mes de vuelta");
            mes = int.Parse(Console.ReadLine());
            ejercicio4(dia, mes, año);
            break;
    }
    Console.WriteLine(dia + " de " + mes2 + " de 20" + año);
    return dia; 

    
}
ejercicio4(dia,mes,año);

Console.WriteLine("Elija una figura para sacar ya sea el perimetro y/o la superficie" + " 1. Cuadrado  2. Rectángulo   3. Triángulo   4. Círculo   5. Rombo");
int figura = int.Parse(Console.ReadLine());
Console.WriteLine("Elija si desea calcular el perimetro o la superficie (0 = perimetro, 1 = superficie)");
int calculo = int.Parse(Console.ReadLine());
int ejercicio5(int figura, int calculo)
{
    double resultado = 0;
    int lado = 0;
    int diagomay = 0;
    int diagomen = 0;
    int lado2 = 0;
    int lado3 = 0;
    int basee = 0;
    int altura = 0;
    int diametro = 0;
    int radio = 0;
    switch (figura)
    {
        case 1:
            switch (calculo)
            {
                case 0:

                    Console.WriteLine("USTED VA A CALCULAR EL PERIMETRO DE UN CUADRADO- Ingrese la medida de uno de los lados");
                    lado = int.Parse(Console.ReadLine());
                    resultado = 4 * lado;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
                case 1:
                    Console.WriteLine("USTED VA A CALCULAR LA SUPERFICIE DE UN CUADRADO - Ingrese la medida de uno de los lados");
                    lado = int.Parse(Console.ReadLine());
                    resultado = lado * lado;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
            }
            break;

        case 2:
            switch (calculo)
            {
                case 0:
                    
                        Console.WriteLine("USTED VA A CALCULAR EL PERIMETRO DE UN RECTANGULO- Ingrese la base");
                        basee = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura");
                        altura = int.Parse(Console.ReadLine());
                        resultado = 2 * (basee + altura);
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
                    
                case 1:
                    
                        Console.WriteLine("USTED VA A CALCULAR LA SUPERFICIE DE UN RECTANGULO- Ingrese la base");
                        basee = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura");
                        altura = int.Parse(Console.ReadLine());
                        resultado = basee * altura;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
                    
            }
            break;
        case 3:
            switch (calculo)
            {
                case 0:
                    Console.WriteLine("USTED VA A CALCULAR EL PERIMETRO DE UN TRIANGULO- Ingrese el primer lado");
                    lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo lado");
                    lado2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tercer lado");
                    lado3 = int.Parse(Console.ReadLine());
                    resultado = lado + lado2 + lado3;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
                case 1:
                    Console.WriteLine("USTED VA A CALCULAR LA SUPERFICIE DE UN TRIANGULO- Ingrese la base");
                    basee = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura");
                    altura = int.Parse(Console.ReadLine());
                    resultado = (basee * altura) / 2;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
            }
            break;
        case 4:
            switch (calculo)
            {
                case 0:
                    Console.WriteLine("USTED VA A CALCULAR EL PERIMETRO/LONGITUD DE CIRCUNFERENCIA DE UN CIRCULO- Ingrese el diametro");
                    diametro = int.Parse(Console.ReadLine());
                    resultado = diametro * 3.1416;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
                case 1:
                    Console.WriteLine("USTED VA A CALCULAR LA SUPERFICIE/AREA DE UN CIRCULO- Ingrese el radio del circulo");
                    radio = int.Parse(Console.ReadLine());
                    resultado = 3.1416 * (radio * radio);
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
            }
            break;
        case 5:
            switch (calculo)
            {
                case 0:
                    Console.WriteLine("USTED VA A CALCULAR EL PERIMETRO DE UN ROMBO- Ingrese un lado");
                    lado = int.Parse(Console.ReadLine());
                    resultado = lado * 4;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
                case 1:
                    Console.WriteLine("USTED VA A CALCULAR LA SUPERFICIE/AREA DE UN ROMBO- Ingrese el diagonal mayor");
                    diagomay = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el diagonal menor");
                    diagomen = int.Parse(Console.ReadLine());
                    resultado = (diagomay * diagomen) / 2;
                    Console.WriteLine("El resultado seria: " + resultado);
                    break;
            }

            return lado;
    }
    return lado;
}
ejercicio5(figura, calculo);

Console.WriteLine("Ingrese cuanto va a pagar");
int compra = int.Parse(Console.ReadLine());
int ejercicio6 (int compra)
{
    double cantidadfin = 0;
    bool blanco = false;
    bool verde = false;
    bool amarilla = false;
    bool azul = false;
    bool roja = false;
    Console.WriteLine("¿Saco una bolita blanca?");
    blanco = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine("¿Saco una bolita verde?");
    verde = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine("¿Saco una bolita amarilla?");
    amarilla = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine("¿Saco una bolita azul?");
    azul = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine("¿Saco una bolita roja?");
    roja = Convert.ToBoolean(Console.ReadLine());
    if (blanco == true)
    {
        cantidadfin = compra;
    }
    if (verde == true)
    {
        cantidadfin = compra - (compra * 0.1);
    }
    if (amarilla == true)
    {
        cantidadfin = compra - (compra * 0.25);
    }
    if (azul == true)
    {
        cantidadfin = compra - (compra * 0.5);
    }
    if (roja == true)
    {
        cantidadfin = 0;
    }
    Console.WriteLine("La cantidad final es de " + cantidadfin);
    return compra;
}
ejercicio6(compra);
void ejercicio7()
{
    Console.WriteLine("Primer pregunta: ¿Colon descubrio America?");
    string eleccion = Console.ReadLine();
    Console.WriteLine("Segunda pregunta: ¿La independencia de Mexico fue en 1810?");
    string eleccion2 = Console.ReadLine();
    Console.WriteLine("Tercera pregunta: ¿The Doors fue un grupo de rock Americano?");
    string eleccion3 = Console.ReadLine();
    if (eleccion == "no" || eleccion2 == "si" || eleccion3 == "no")
    {
        Console.WriteLine("Usted ha perdido ):");

    }
    else
    {
        Console.WriteLine("¡Felicidades, usted ha ganado!");
    }
}
ejercicio7();
void ejercicio8()
{
    Console.WriteLine("Ingrese el numero escogido");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio total");
    int precio = int.Parse(Console.ReadLine());
    double descuento = 0;
   switch (numero)
    {
        case int n when n < 74:
            descuento = precio * 0.15;
            break;
        case int n when n >= 74:
            descuento = precio * 20;
            break;
    }
    Console.WriteLine("La cantidad de descuento es de: " + descuento);



}
ejercicio8();
void ejercicio9()
{
    Console.WriteLine("Ingrese su edad y yo calculo las pulsaciones que tiene que tener");
    int edad = int.Parse(Console.ReadLine());
    Console.WriteLine("¿Su genero es masculino o femenino?");
    string genero = Console.ReadLine();
    double pulsaciones = 0;
    if (genero == "masculino")
    {
        pulsaciones = (210 - edad) / 10.0;
    }
    else if (genero == "femenino")
    {
        pulsaciones = (220 - edad) / 10.0;
    }
    Console.WriteLine("Sus pulsaciones tendrian que ser de: " + pulsaciones + " por segundo");


}
ejercicio9();
void ejercicio10()
{
        string nombre1 = "", apellido1 = "";
        double promedio1 = -1; 

        string nombre2 = "", apellido2 = "";
        double promedio2 = -1;

        string nombre3 = "", apellido3 = "";
        double promedio3 = -1;

        
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"--- Datos del alumno {i} ---");
            Console.Write("Nombre: ");
            string nombreActual = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellidoActual = Console.ReadLine();

            Console.Write("Promedio: ");
            double promedioActual = double.Parse(Console.ReadLine());

            if (promedioActual > promedio1)
            {
           
                nombre3 = nombre2; apellido3 = apellido2; promedio3 = promedio2;
             
                nombre2 = nombre1; apellido2 = apellido1; promedio2 = promedio1;
          
                nombre1 = nombreActual; apellido1 = apellidoActual; promedio1 = promedioActual;
            }
            else if (promedioActual > promedio2)// profe este lo hice con IA porque no lo entendia ):
            {
               
                nombre3 = nombre2; apellido3 = apellido2; promedio3 = promedio2;
        
                nombre2 = nombreActual; apellido2 = apellidoActual; promedio2 = promedioActual;
            }
            else
            {
                
                nombre3 = nombreActual; apellido3 = apellidoActual; promedio3 = promedioActual;
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Abanderado: {nombre1} {apellido1} (Promedio: {promedio1})");
        Console.WriteLine($"Primer Escolta: {nombre2} {apellido2} (Promedio: {promedio2})");
        Console.WriteLine($"Segundo Escolta: {nombre3} {apellido3} (Promedio: {promedio3})");
}
ejercicio10();
void ejercicio11()
{
    bool sigue = true;
    string numeroeningles = "";
    int numero = 0;
    while (sigue)
    {
        Console.WriteLine("Ingrese un numero entre 0-9");
        numero = int.Parse(Console.ReadLine());
        if (numero > 9 || numero < 0)
        {
            sigue = true;
        }
        else
        {
            sigue = false;
        }
    }
    switch (numero)
    {
        case 0:
            numeroeningles = "Zero";
            break;
        case 1:
            numeroeningles = "One";
            break;
        case 2:
            numeroeningles = "Two";
            break;
        case 3:
            numeroeningles = "Three";
            break;
        case 4:
            numeroeningles = "Four";
            break;
        case 5:
            numeroeningles = "Five";
            break;
        case 6:
            numeroeningles = "Six";
            break;
        case 7:
            numeroeningles = "Seven";
            break;
        case 8:
            numeroeningles = "Eight";
            break;
        case 9:
            numeroeningles = "Nine";
            break;
    }
    Console.WriteLine("Su numero en ingles es " + numeroeningles);





}
ejercicio11();
void ejercicio12()
{
    Console.WriteLine("Ingrese 1 para triangulo, 2 para circulo, 3 para rectangulo y 4 para hexagono");
    int eleccion = int.Parse(Console.ReadLine());
    double area = 0;
    int basee = 0;
    int altura = 0;
    int radio = 0;
    int perimetro = 0;
    int apotema = 0;
    switch (eleccion)
    {
        case 1:
            Console.WriteLine("Ingrese la altura del triangulo");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la base del triangulo");
            basee = int.Parse(Console.ReadLine());
            area = (basee * altura) / 2.0;
            break;
        case 2:
            Console.WriteLine("Ingres el radio del circulo");
            radio = int.Parse(Console.ReadLine());
            area = Math.PI * (radio * radio);
            break;
        case 3:
            Console.WriteLine("Ingrese la base del rectangulo");
            basee = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo");
            altura = int.Parse(Console.ReadLine());
            area = basee * altura;
            break;
        case 4:
            Console.WriteLine("Ingrese el perimetro del hexagono");
            perimetro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el apotema del hexagono");
            apotema = int.Parse(Console.ReadLine());
            area = (perimetro * apotema) / 2;
            break;

    }
    Console.WriteLine("El area de su figura es de: " + area);
}
ejercicio12();
