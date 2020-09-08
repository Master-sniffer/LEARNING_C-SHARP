using System; // позволяет юзать имена стандартных классов из пространства имен system
namespace ConsoleApplication1 // создает для проекта собственное пр-во имен , названное по умолчанию ConsoleApplication 1
{
    ///<summary>
    ///Summary description for class 1
    ///</summary>
    class Class1 // объявили класс и назвали его (можно назвать его , как хош, лол )000)00
    {
        ///<summary>
        ///The main entry point for the app
        /// </summary>
        [STAThread] // это спецификатор 
        static void Main(string[] args) // идет тип -> имя метода -> праметры
        { // тут начинается тело метода ( действия, которые выполняются методом. Что-то типа def в питоне , после чего идет само действие\я
            //
            // TODO Add code to start app here
            //
            Console.WriteLine("Слава Аллаху за этот прекрасный код"); // console в данном случае - имя стандартного класса из пр-ва имен System ( смотреть 1 строчку). Его метод (writeline) выводит в ковычках заданный текс
        }
    }
}



##



    class Class1
    {
        static void Main()
        {
            object z = new object(); // Создает новую ссылку на объект
            int i = new int(); // то же самое, что и int i = 0
            Console.WriteLine(z + " " + i);
        }
    }



##



    class Class1
    {
        static void Main()
        {
            sbyte a = 3, b = -63, c = 126;
            bool d = true;
            Console.WriteLine(-a); // ответ  -3 ( что лоигчно )0)
            Console.WriteLine(-c); //  ответ - 126
            Console.WriteLine(!d); // перед d стоит ! Это означает, что-то в роде d, но наоборот
            Console.WriteLine(~a); //  -4 инвертирует каждый разряд в двоичном представлении
            Console.WriteLine(~b); //  62  ИЛИ КОРОЧЕ ГОВОРЯ . ЕСЛИ ЧИСЛО ПОЛОЖИТЕЛЬНОЕ, ТО К НЕМУ ДОБАВЛЯЕТСЯ 1 , ПОСЛЕ ЧЕГО ЧИСЛО СТАНОВИТСЯ ОТРИЦАТЕЛЬНЫМ
            Console.WriteLine(~c); // -127 А ЕСЛИ ЧИСЛО ОТРИЦАТЕЛЬНОЕ , ТО 1 УХОДИТ И ЧИСЛО СТАНОВИТСЯ ПОЛОЖИТЕЛЬНЫМ 
            /// ... Я в Ах*е с этой логики ))
        }
    }



##



    class Class1
    {
        static void Main()
        {
            long b = 300;
            int a = (int)b;
            byte d = (byte)a;
            Console.WriteLine(a + " " + d + " " + b); // типа d это 44 байта )
        }
    }



##



    class Class1
    {
        static void Main()
        {
            int x = 11, y = 4;
            float z = 4;
            Console.WriteLine(z * y); // ответ 16
            Console.WriteLine(z * 1e308); // ответ infinity
            Console.WriteLine(x/y); // ответ 2
            Console.WriteLine(x / z); // ответ 2.75
            Console.WriteLine(x% y); // ответ 3
            Console.WriteLine(1e-324/1e-324); // Ответ Nan 
        }
    }



##



    class Class1
    {
        static void Main()
        {
            byte a = 3, b = 9; // ВСЕ ЭТО
            sbyte c = 9, d = -9; // ОПЕРАЦИИ СДВИГА
            Console.WriteLine(a << 1); // ответ 6
            Console.WriteLine(a << 2); // ответ 12
            Console.WriteLine(b >> 1); // ответ 4
            Console.WriteLine(c >> 1); // ответ 4
            Console.WriteLine(d >> 1); // ответ -5
        }
    }



##



    class Class1
    {
        static void Main()
        { // Поразрядные логические операции
            Console.WriteLine(6 & 5) ; // ответ 4
            Console.WriteLine(6 | 5); // ответ 7
            Console.WriteLine(6 ^ 5); // ответ 3
        }
    }



##



    class Class1
    {
        static void Main()
        { // ЛОГИЧЕСКИЕ ОПЕРАЦИИ
            Console.WriteLine(true && true) ; // ответ true 
            Console.WriteLine(true && false); // ответ false
            Console.WriteLine(true || false); // ответ true
            Console.WriteLine(true || true); // ответ true
        }
    }



##



    class Class1
    {
        static void Main()
        { // УСЛОВНАЯ ОПЕРАЦИЯ
            int a = 11, b = 4;
            int max = b > a ? b : a; /// СНАЧАЛА (после ? ) ИДЕТ РЕЗУЛЬТАТ FALSE (b) , ЕСЛИ УСЛОВИЕ (b>a) , ВЕРНО , ТО ИДЕТ РЕЗУЛЬТАТ TRUE (a)  ЭТО ПОХОЖЕ НА IF, НО ЭКОНОМНЕЕ
            Console.WriteLine(max) ; // ответ 11 
        }
    }



##



    class Class1
    {
        static void Main()
        { // ПРОСТЕЙШИЙ ВВОД И ВЫВОД
            int i = 3;
            double y = 4.12;
            decimal d = 600m;
            string s = "Vasia";
            Console.WriteLine("i = " + i) ; // 
            Console.WriteLine("y = {0} \nd = {1}", y , d); // Тут идет присваивание переменных, которые идут после "цитаты"
            Console.WriteLine("s = " + s); // 
        }
    }



##



    class Class1
    {
        static void Main()
        { // ПРОСТЕЙШИЙ ВВОД С КЛАВЫ
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine(); // считывание данных
            Console.WriteLine("s= " + s);

            Console.WriteLine("Введите символ");
            char c = (char)Console.Read();
            Console.ReadLine();
            Console.WriteLine("c= " + c);
            string buf; // строка буфер для ввода чисел
            Console.WriteLine("Введите целое число");
            buf = Console.ReadLine();
            int i = Convert.ToInt32(buf);
            Console.WriteLine(i);

            Console.WriteLine("Введите вещественное число");
            buf = Console.ReadLine();
            double x = Convert.ToDouble(buf);
            Console.WriteLine(x);

            Console.WriteLine("Введтие Вещественное число");
            buf = Console.ReadLine();
            double y = double.Parse(buf);
            Console.WriteLine(y);

            Console.WriteLine("Введите вещественное число");
            buf = Console.ReadLine();
            decimal z = decimal.Parse(buf);
            Console.WriteLine(z);
        }
    }



##



    class Class1
    {
        static void Main()
        { // Ввод - вывод в файлы
            StreamWriter f = new StreamWriter("output.txt"); // объявили файловую переменнуб (f) и связали ее с НОВЫМ файлом, который мы назвали output
            int i = 3;
            double y = 4.12;
            decimal d = 600m;
            string s = "Vasiok";

            f.WriteLine("i=" + i); // ВЕДЕТСЯ ЗАПИСЬ В ФАЙЛ
            f.WriteLine("y={0} \nd={1}", y, d); // ВЕДЕТСЯ ЗАПИСЬ В ФАЙЛ
            f.WriteLine("s= " + s); // ВЕДЕТСЯ ЗАПИСЬ В ФАЙЛ

            f.Close(); // ЗАКРЫВАЕТСЯ ФАЙЛ
        } // ФАЙЛ НАХОДИТСЯ В bin\debug и тд
    }



##



    class Class1
    {
        static void Main()
        { // МЕТОД КЛАССА MATH
            Console.Write("Enter x: ");
            string buf = Console.ReadLine();
            double x = double.Parse(buf);
            Console.WriteLine("Value sing: " + Math.Sin(x));

            Console.Write("Enter y: ");
            buf = Console.ReadLine();
            double y = double.Parse(buf);
            Console.WriteLine("Maximum : " + Math.Max(x, y));
        } 
    }



##



e
