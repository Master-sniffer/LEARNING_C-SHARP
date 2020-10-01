using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            FileStream f = new FileStream("test.txt", FileMode.Create, FileAccess.ReadWrite);

            f.WriteByte(100); // в начале файла записывается 100

            byte[] x = new byte[10];
            for (byte i=0; i <10; ++i)
            {
                x[i] = (byte)(10 - i);
                f.WriteByte(i); // записывается 10 чисел от 0 до 9
            }

            f.Write(x, 0, 5); // записывается 5 элементов массива

            byte[] y = new byte[20];

            f.Seek(0, SeekOrigin.Begin); // Текущий указатель на начало чтения файла в массиве
            f.Read(y, 0, 20);

            foreach (byte elem in y) Console.WriteLine(" " + elem);
            Console.WriteLine();

            f.Seek(5, SeekOrigin.Begin);// текущий укащатель на 5 элемент
            int a = f.ReadByte();
            Console.WriteLine(a);
            a = f.ReadByte();
            Console.WriteLine(a);

            Console.WriteLine("Current position in the flow is " + f.Position);
            f.Close();
        }
    }
}