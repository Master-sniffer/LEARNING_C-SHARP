using System;
using System.IO;
namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        { // МЕТОД КЛАССА MATH
            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine()); // ТУТ СРАЗУ ИДЕТ ПРИСВАИВАНИЕ ( БУДЕТ ПОЛЕЗНО НА БУДУЩЕЕ)

            Console.WriteLine("Enter Alfa");
            double a = Convert.ToDouble(Console.ReadLine());

            double y = Math.Sqrt(Math.PI * x) -
                Math.Exp(0.2 * Math.Sqrt(a)) +
                2 * Math.Tan(2 * a) +
                1.6e3 * Math.Log10(Math.Pow(x, 2));

            Console.WriteLine("For x={0} and alfa = {1}", x, a);
            Console.WriteLine("Result is = " + y);
        } 
    }
}