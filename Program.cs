using System;

namespace POO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizaTarea();

            Console.ReadKey();
        }

        static void realizaTarea()
        {
            Console.WriteLine("¿Qué desea calcular? \n1. La suma de dos numeros " +
                "\n2. La multiplicacion de dos numeros \n3. La division de dos numeros \n4. El resto de una division");

            bool intentar = false;
            
            while (!intentar)
            {
                string op = Console.ReadLine();

                switch (op)
                {

                    case "1":

                        Console.WriteLine("Ingrese el n° uno");
                        double sum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el n° dos");
                        double sum2 = double.Parse(Console.ReadLine());

                        Calculadora suma = new Calculadora(sum1, sum2);

                        break;

                    case "2":
                        Console.WriteLine("Ingrese el n° uno");
                        double multiplicacion1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el n° dos");
                        double multiplicacion2 = double.Parse(Console.ReadLine());

                        Calculadora multiplicacion = new Calculadora(multiplicacion1, multiplicacion2, 0);

                        break;

                    case "3":
                        Console.WriteLine("Ingrese el n° uno");
                        double division1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el n° dos");
                        double division2 = double.Parse(Console.ReadLine());

                        Calculadora division = new Calculadora(division1, division2, 0, 0);

                        break;

                    case "4":
                        Console.WriteLine("Ingrese el n° uno");
                        double residuo1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el n° dos");
                        double residuo2 = double.Parse(Console.ReadLine());

                        Calculadora residuo = new Calculadora(residuo1, residuo2, 0, 0, 0);

                        break;
                    default:
                        Console.WriteLine("Has ingresado una opción incorrecta \nVuelva a intentarlo");
                        
                        break;
                        
                }

                Console.WriteLine("Ingrese N para salir \nIngrese Y para continuar ");
                string salir = Console.ReadLine().ToUpper();

                if (salir == "Y")
                {
                    intentar = false;
                    Console.WriteLine("1. La suma de dos numeros \n2. La multiplicacion de dos numeros \n3. La division de dos numeros \n4. El resto de una division");

                }
                else if(salir == "N")
                {
                    intentar = true;
                }
                

            }
        }
    }
}
