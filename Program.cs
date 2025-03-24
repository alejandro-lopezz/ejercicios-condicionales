using System;

namespace ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1
            /* int numeroIngresado;

            Console.WriteLine("Ingrese un número por favor:");
            numeroIngresado = int.Parse(Console.ReadLine());

            if (numeroIngresado > 10) {
                Console.WriteLine("El número es mayor a 10");
            } else {
                Console.WriteLine("El número no es mayor a 10:(");
            } */

            //EJERCICIO 2

            /* int numeroIngresado2;

            Console.WriteLine("Ingrese un número por favor:");
            numeroIngresado2 = int.Parse(Console.ReadLine());

            if (numeroIngresado2 == 0) {
                Console.WriteLine("El número es igual a 0");
            } else if (numeroIngresado2 > 0) {
                Console.WriteLine("El número es positivo");
            } else {
                Console.WriteLine("El número es negativo");
            } */


            //EJERCICIO 3
            /* float importeInicial;
            float importeFinal;

            Console.WriteLine("Ingrese su importe:");
            importeInicial = float.Parse(Console.ReadLine());

            if (importeInicial >= 5000) {
                importeFinal = importeInicial * 0.82F;
            } else if (importeInicial >= 1000) {
                importeFinal = importeInicial * 0.90F;
            } else {
                importeFinal = importeInicial;
            }   

            Console.WriteLine("Su importe final es: " + importeFinal); */


            //EJERCICIO 4

            /* int n1, n2, n3, n4;
            int numeroMinimo;

            Console.WriteLine("Ingresa el primer número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer número: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el último número: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2) {
                numeroMinimo = n1;
            } else {
                numeroMinimo = n2;
            }

            if(n3 < numeroMinimo) {
                numeroMinimo = n3;
            } 

            if(n4 < numeroMinimo) {
                numeroMinimo = n4;
            }

            Console.WriteLine("El número minimo es: " + numeroMinimo); */

            //EJERCICIO 5

            int a, b, c, d;

            Console.WriteLine("Ingresa un número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el último número:");
            d = int.Parse(Console.ReadLine());

            if(a > 100) {
                Console.WriteLine(a);
            }

            if(b > 100) {
                Console.WriteLine(b);
            }
            
            if(c > 100) {
                Console.WriteLine(c);
            }

            if(d > 100) {
                Console.WriteLine(d);
            }

        }
    }
}
