using CalculosMatematicos;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        bool Salir = false;
        while (!Salir)
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Proporciona el numero 1:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proporciona el numero 2:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El resultado de la suma es: {Calculos.Suma(num1, num2)}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Proporciona el numero 1:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proporciona el numero 2:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El resultado de la resta es: {Calculos.Resta(num1, num2)}");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Proporciona el numero 1:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proporciona el numero 2:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El resultado de la resta es: {Calculos.Multiplicacion(num1, num2)}");
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Proporciona el numero 1:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Proporciona el numero 2:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El resultado de la resta es: {Calculos.Division(num1, num2)}");
                    break;

                case 5:
                    Salir = true;
                    break;
            }
        }
    }
}
