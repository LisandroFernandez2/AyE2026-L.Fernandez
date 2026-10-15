using System.IO;
using System;
class Program
{
    static void Main(string[] args)
    {
        string rutaSalida = "tp10.txt";
        using (StreamWriter writer = new StreamWriter(rutaSalida, append: true))
        {
            writer.WriteLine(Ejercicio1());
            writer.WriteLine(Ejercicio2());
            writer.WriteLine(Ejercicio3());
            writer.WriteLine(Ejercicio4());
            writer.WriteLine(Ejercicio5());
            writer.WriteLine(Ejercicio6());
            writer.WriteLine(Ejercicio7());
            writer.WriteLine(Ejercicio8());
            writer.WriteLine(Ejercicio9());
            writer.WriteLine(Ejercicio10());
        }
        using (StreamReader reader = new StreamReader(rutaSalida))
        {
            string contenidoCompleto = reader.ReadToEnd();
            Console.WriteLine(contenidoCompleto);
        }
    }

    static string Ejercicio1()
    {
        int numero;
        int unidades;
        int decenas;

        Console.WriteLine("ingrese numero");
        numero = int.Parse(Console.ReadLine());

        if (numero < 99 && numero > -99)
        {
            decenas = (int)Math.Truncate((double)numero / 10);
            unidades = numero % 10;
            return "decenas: " + decenas + "unidades: " + unidades;
        }
        else
        {
            return "no es de dos cifras";
        }
    }

    static string Ejercicio2()
    {
        int numero;
        int numerocentral3;

        Console.WriteLine("ingrese un número de tres cifras");
        numero = int.Parse(Console.ReadLine());

        if ((numero >= 100 && numero <= 999) || (numero <= -100 && numero >= -999))
        {
            numerocentral3 = (numero / 10) % 10;
            numerocentral3 = Math.Abs(numerocentral3);
        }
        else
        {

            numerocentral3 = 0;
            return "no es de tres cifras";
        }

        return "la cifra central es: " + numerocentral3;
    }

    static string Ejercicio3()
    {
        double listaprecio;
        double descuentoprecio;
        double porcentaje;

        Console.WriteLine("ingrese el precio de lista");
        listaprecio = double.Parse(Console.ReadLine());

        porcentaje = (18.0 / 100.0) * listaprecio;
        descuentoprecio = listaprecio - porcentaje;

        return "Precio de lista: " + listaprecio + " Descuento: " + porcentaje + " Precio con descuento: " + descuentoprecio;
    }

    static string Ejercicio4()
    {
        int num, d1, d2, permutado;

        Console.WriteLine("Indicar un número de dos cifras");
        num = int.Parse(Console.ReadLine());

        d1 = num / 10;
        d2 = num % 10;
        permutado = (d2 * 10) + d1;

        return "Valor: " + num + " Valor permutado: " + permutado;
    }

    static string Ejercicio5()
    {
        int fecha, sinDias, mes;

        Console.WriteLine("Indicar una fecha como un entero de 6 dígitos");
        fecha = int.Parse(Console.ReadLine());

        sinDias = fecha % 10000;
        mes = sinDias / 100;

        return "Fecha: " + fecha + " Mes: " + mes;
    }

    static string Ejercicio6()
    {
        int lado;
        int perimetro;
        int superficie;

        Console.WriteLine("Indicar el valor del lado del cuadrado");
        lado = int.Parse(Console.ReadLine());

        perimetro = lado * 4;
        superficie = lado * lado;

        return "Perímetro: " + perimetro + " Superficie: " + superficie;
    }

    static string Ejercicio7()
    {
        double valorHora;
        double cantHoras;
        double sueldoBruto;

        Console.WriteLine("Indicar el valor de la hora de trabajo");
        valorHora = double.Parse(Console.ReadLine());

        Console.WriteLine("Indicar la cantidad de horas trabajadas");
        cantHoras = double.Parse(Console.ReadLine());

        sueldoBruto = valorHora * cantHoras;

        return "Sueldo Bruto: " + sueldoBruto;
    }

    static string Ejercicio8()
    {
        double f;
        double c;

        Console.WriteLine("Indicar temperatura en Fahrenheit");
        f = double.Parse(Console.ReadLine());

        c = (f - 32) * 5 / 9;

        return "Grados Centígrados: " + c;
    }

    static string Ejercicio9()
    {
        int h1, m1, s1;
        int h2, m2, s2;
        int totalSeg1;
        int totalSeg2;
        int diferencia;

        Console.WriteLine("Instante 1 (hora, minuto, segundo). Ingrese uno por uno:");
        h1 = int.Parse(Console.ReadLine());
        m1 = int.Parse(Console.ReadLine());
        s1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Instante 2 (hora, minuto, segundo). Ingrese uno por uno:");
        h2 = int.Parse(Console.ReadLine());
        m2 = int.Parse(Console.ReadLine());
        s2 = int.Parse(Console.ReadLine());

        totalSeg1 = (h1 * 3600) + (m1 * 60) + s1;
        totalSeg2 = (h2 * 3600) + (m2 * 60) + s2;
        diferencia = totalSeg2 - totalSeg1;

        return "Segundos en el intervalo: " + diferencia;
    }

    static string Ejercicio10()
    {
        int num;
        int a;
        int b;
        int c;

        Console.WriteLine("Indicar un valor entero de 3 dígitos");
        num = int.Parse(Console.ReadLine());

        a = num / 100;
        b = (num % 100) / 10;
        c = num % 10;

        return "Valor ingresado: " + num + " Unidades: " + c + " Decenas: " + b + " Centenas: " + a;
    }
}