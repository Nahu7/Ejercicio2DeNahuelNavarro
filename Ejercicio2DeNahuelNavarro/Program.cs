using System;

namespace Ejercicio2DeNahuelNavarro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Triangulos";
                int ladoA, ladoB, ladoC;
                Console.Write("Ingrese el valor del primer lado: ");
                ladoA = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor del segundo lado: ");
                ladoB = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor del tercer lado: ");
                ladoC = int.Parse(Console.ReadLine());
                double ladoA2 = Math.Pow(ladoA, 2);
                double ladoB2 = Math.Pow(ladoB, 2);
                double ladoC2 = Math.Pow(ladoC, 2);
                double superficie, semiperimetro;
                semiperimetro = (ladoA + ladoB + ladoC) / 2;
                superficie = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

                if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
                {

                    if (ladoA2 == ladoB2 + ladoC2)
                    {
                        Console.WriteLine("Los datos ingresados forman un triángulo rectángulo");
                        Console.WriteLine($"Su perimetro es {PerimetroDeTriangulo(ladoA, ladoB, ladoC)}");
                        Console.WriteLine($"Su superficie es {superficie}");
                    }
                    if (ladoA2 > ladoB2 + ladoC2)
                    {
                        Console.WriteLine("Los datos ingresados forman un triángulo obtusángulo");
                        Console.WriteLine($"Su perimetro es {PerimetroDeTriangulo(ladoA, ladoB, ladoC)}");
                        Console.WriteLine($"Su superficie es {superficie}");
                    }
                    else
                    {
                        Console.WriteLine("Los datos ingresados forman un triángulo acutángulo");
                        Console.WriteLine($"Su perimetro es {PerimetroDeTriangulo(ladoA, ladoB, ladoC)}");
                        Console.WriteLine($"Su superficie es {superficie}");
                    }
                }
                else
                {
                    Console.WriteLine("Los datos ingresados no conforman un triangulo");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error... Ingrese datos numericos");
            }
            Console.ReadLine();
        }
        private static object PerimetroDeTriangulo(int ladoA, int ladoB, int ladoC)
        {
            int perimetro;
            return perimetro = ladoA + ladoB + ladoC;
        }
    }
}
