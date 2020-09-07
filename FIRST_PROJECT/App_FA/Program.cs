using System;
namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            int x = 3, y = 3;
            Console.Write("Значения префикса равно:");
            Console.WriteLine(++x); // ВНИМАНИЕ НА МЕСТОПОЛОЖЕНИЕ X
            Console.Write("Значение после приращения равно: ");
            Console.WriteLine(x);
            Console.Write("Значения постфикса равно:");
            Console.WriteLine(y++); // ВНИМАНИЕ НА МЕСТОПОЛОЖЕНИЕ Y
            Console.Write("Значение после приращения равно: ");
            Console.WriteLine(y);
        }
    }
}
