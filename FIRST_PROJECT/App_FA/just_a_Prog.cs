using System; // позволяет юзать имена стандартных классов из пространства имен system
using System.IO; // Для работы с файлами и не только !
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



##



    class Class1
    {
        static void Main()
        { // ОПЕРАТОРЫ ВЕТВЛЕНИЯ
            Console.WriteLine("Enter x coordinate");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());

            int kol = 0;
            if (x * x + y * y < 1)
            {
                kol = 2;
            }
            else if (x*x+y*y <4)
            {
                kol = 1;
            }
            Console.WriteLine("Result={0} points", kol);
        }   
    }



##



    class Class1
    {
        static void Main()
        { // SWITCH
            double a, b, res;
            Console.WriteLine("Enter the first operand");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sign of the action !");
            char op = (char)Console.Read();
            Console.ReadLine();

            Console.WriteLine("Enter the second operand");
            b = double.Parse(Console.ReadLine());

            bool ok = true;
            switch (op)
            {
                case '+': {
                        res = a + b;
                        break;
                          }
                case '-':
                    {
                        res = a - b;
                        break;
                    }
                case '*':
                    {
                        res = a * b;
                        break;
                    }
                case '/':
                    {
                        res = a / b;
                        break;
                    }
                default:
                    {
                        res = double.NaN;
                        ok = false;
                        break;
                    }
            }
            if (ok)
            {
                Console.WriteLine("Result is " + res);
            }
            else
            {
                Console.WriteLine("Something went wrong :/");
            }
        }   
    }



##



    class Class1
    {
        static void Main()
        { // WHILE
            double Xn = -2, Xk = 12, dx = 2, t = 2, y;
            Console.WriteLine("|    x   |   y   |"); // Заголовок таблицы

            double x = Xn;
            while (x <= Xn)
            {
                y = t;
                if (x>=0 && x < 10)
                {
                    y = t * x;
                }
                if (x >= 10)
                {
                    y = 2 * t;
                }
                Console.WriteLine("|    {0,6}   |   {1,6}   |", x, y); // 6 - Шириеа для вывода значения
                x += dx;
            }
        }   
    }



##



    class Class1
    {
        static void Main()
        { // WHILE
            string buf;
            while (true)
            {
                Console.WriteLine("1- point 1, 2 - point 2, 3- exit");
                buf = Console.ReadLine();
                switch (buf)
                {
                    case "1":
                        {
                            Console.WriteLine("Checking...\nYou are now on the point 1 !");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Checking...\nYou are now on the point 2 !");
                            break;
                        }
                    case "3":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Didnt'hit the button, ae");
                            break;
                        }
                }
            }
           
        }   
    }



##



    class Class1
    {
        static void Main()
        { // DO
            char answer;
            do
            {
                Console.WriteLine("BUT THE FUCKING ELEPHANT, MOM!!!!");
                answer = (char)Console.Read();
                Console.ReadLine();

            } while (answer != 'y');
        }
    }



##



    class Class1
    {
        static void Main()
        { // DO
            double x, left = 0, right = 1;
            do
            {
                x = (left + right) / 2;
                if ((Math.Cos(x) - x) * (Math.Cos(left) - left) < 0)
                {
                    right = x;
                }
                else
                {
                    left = x;
                }
            } while (Math.Abs(right - left) < 1e-4);
            Console.WriteLine("SQRT equals " + x);
        }
    }



##



    class Class1
    {
        static void Main()
        { // FOR
            double Xn = -2, Xk = 12, dx = 2, t = 2, y;
            Console.WriteLine("|    x   |   y   |"); // Заголовок таблицы
            for (double x = Xn; x <= Xk; x += dx)
            {
                y = t;
                if (x>=0 && x<10)
                {
                    y = t * x;
                }
                if (x >= 10)
                {
                    y = 2 * t;
                }
                Console.WriteLine("|    {0,6}   |   {1,6}   |", x, y);
            }
        }
    }



##



    class Class1
    {
        static void Main()
        { // BREAK
            double e = 1e-6;
            const int MaxIter = 500;
            Console.WriteLine("Enter arguement");
            double x = Convert.ToDouble(Console.ReadLine());

            bool done = true;
            double ch = x, y = ch;
            for (int n=1; Math.Abs(ch)> e; n++)
            {
                ch *= -x * x / (2 * n * (2 * n + 1));
                y += ch;
                if (n > MaxIter)
                {
                    { done = false;break; }
                }
                if (done) Console.WriteLine("Sum is - " + y);
                else Console.WriteLine("Row is not ROWing , heheheheheh\n");
            }
        }
    }



##



    class Class1
    {
        static void Main()
        { // TRY
            string buf;
            double u, i, r;
            try
            {
                Console.WriteLine("Enter conflict");
                u = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the resistance");
                r = double.Parse(Console.ReadLine());

                i = u / r;
                Console.WriteLine("ENERGY POWER IS " + i);
            }
            catch (FormatException)
            {
                Console.WriteLine("UNCORRECT FORMAT, MAN!");
            }
            catch
            {
                Console.WriteLine("UMMMM< SOMETHING WENT WRONG");
            }
            finally
            {
                Console.WriteLine("BYE");
            }
        }
    }



##



    class Class1
    {
        static void F()
        { // throw
            try
            {
                G();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in F " + e.Message);
                e = new Exception("f");
                throw e; // Повторная генерация исключения
            }
        }   static void G()
        {
            throw new Exception("G"); //Моделирование исключительной ситуации
        }
        static void Main()
        {
            try
            {
                F();
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPTION NOW IN MAIN: " + e.Message);
            }
        }
    }



##



    class Class1
    {
        static void Main()
        { // checked unchecked
            a = checked(b + c); //Для выражения - проверка включена
            unchecked // Для блока операторов - проверка выключена
            {
                a = b + c;
            }
        }
    }



##



    // КЛАСС И ОБРАЩЕНИЯ К НЕМУ
    class Demo
        {
        // ШОБЫ У ВСЕХ ВСЕ БЫЛО ВИДНО , НУЖНО , ЧТОБЫ ПЕРЕД ПЕРЕМЕННОЙ БЫЛА public ( перевод: публично) , ТОГДА ВСЕ ТИПА ВСЕ БУДУТ ВИДЕТЬ
    public int a = 1; // ПОЛЯ ДАННЫХ
    public const double c = 1.66; // КОНСТАНТА
    public static string s = "Demo"; // СТАТИЧЕСКОЕ ПОЛЯ КЛАССА
    double y; // ПОЛЕ ЗАКРЫТОЕ, ПОЭТОМУ ДОСТУПА К НЕМУ - НЕМА )))) 
        }
    class Class1
    { static void Main()
        {
            Demo x = new Demo(); // СОЗДАНИЕ НВОГО ЭКЗЕМПЛЯРА КЛАССА DEMO
            Console.WriteLine(x.a); // ОБРАЗЕНИЕ К ПОЛЮ КЛАССА ( ВЫВОД а ИЗ ДРУГОГО КЛАССА)
            Console.WriteLine(Demo.c); // ОБРАЩЕНИЕ К КОНСТАНТЕ
            Console.WriteLine(Demo.s); // ОБРАЩЕНИЕ К СТАТИЧЕСКОМУ ПОЛЮ
        } 
    }



##



    //МЕТОД
    public double Gety() // это тип самый простейший метод
    {
        return y;
    }



##



    class Demo
    {
        public int a = 1;
        public const double c = 1.66;
        static string s = "Demo";
        double y;

        public double Gety()
        {
            return y;
        }

        public void Sety(double y_) // ВЫЗОВ ИДЕТ ЧЕРЕЗ ЭКХЕМПЛЯР (x) - ТАК КАК ТУТ НАПИСАНО void
        {
            y = y_;
        }

        public static string Gets() // ВЫЗОВ ИДЕТ ЧЕРЕЗ КЛАСС (Demo) - ТАК КАК ТУТ НАПИСАНО static
        {
            return s;
        }

    }

    class Class1
    {
        static void Main()
        {
            Demo x = new Demo();
            x.Sety(0.12);
            Console.WriteLine(x.Gety());
            Console.WriteLine(Demo.Gets());
            Console.WriteLine(Demo.Gets());
        }
    }



##



    // ПЕРЕДАЧА ПАРАМЕТРОВ МЕТОДУ
    class Class1
    {
        static int Max(int a, int b) //метод выбора МАКС значения
        {
            if (a > b) return a;
            else return b;
        }
        static void Main()
        {
            int a = 2, b = 4;
            int x = Max(a, b);
            Console.WriteLine(x);

            short t1 = 3, t2 = 4;
            int y = Max(t1, t2); // ВЫЗОВ МЕТОДА MAX
            Console.WriteLine(y); // ответ 4

            int z = Max(a + t1, t1 / 2 * b); // ВЫЗОВ МЕТОДА MAX
            Console.WriteLine(z); // ответ 5
        }
    }



##



    class Class1 // REF
    { 
        static void P ( int a , ref int b)
        {
            a = 44; b = 33;
            Console.WriteLine("Внутри метода {0} {1}", a, b);
        }
        static void Main()
        {
            int a = 2, b = 4;
            Console.WriteLine("До вызова {0} {1}", a, b);
            P(a, ref b);
            Console.WriteLine("После вызова {0} {1}", a ,b);
        }
    }
   


##



    class Class1 // OUT
    { 
        static void P ( int a , out int b)
        {
            a = 44; b = 33;
            Console.WriteLine("Внутри метода {0} {1}", a, b);
        }
        static void Main()
        {
            int a = 2, b = 4;
            Console.WriteLine("До вызова {0} {1}", a, b);
            P(a, out b);
            Console.WriteLine("После вызова {0} {1}", a ,b);
        }
    }



##



    class Demo // THIS
    {
        double y;
        public Demo T() // метод T возвращает ссылку на экземпляр
        {
            return this;
        }
        public void Sety(double y)
        {
            this.y = y; // Полю у присваевается значение параметра у
        }
    }



##



    class Demo // КОНСТРУКТОРЫ (инициализация объекта)
    {
        public Demo (int a, double y) // КОНСТРУКТОР С ПАРАМЕТРАМИ
        {
            this.a = a;
            this.y = y;
            this.y -= 1;
        }

        public double Gety() // метод получения 
        {
            return y;
        }

        int a;
        double y;
    }
    class Class1
    {
        static void Main()
        {
            Demo a = new Demo(300, 0.002);
            Console.WriteLine(a.Gety());
            Demo b = new Demo(1, 5.71);
            Console.WriteLine(b.Gety());
        }
    }



##



    class Demo // КОНСТРУКТОРЫ (инициализация объекта)
    {
        public Demo ( int a) // КОНСТРУКТОР 1
        {
            this.a = a;
            this.y = 0.02;

        }
        public Demo (double y) // КОНСТРУКТОР 2
        {
            this.a = 1;
            this.y = y;
        }

        public double Gety() // метод получения 
        {
            return y;
        }

        int a;
        double y;
    }
    class Class1
    {
        static void Main()
        {
            Demo a = new Demo(300); // ВЫЗОВ КОНСТРУКТОРА 1
            Demo b = new Demo(5.71); // ВЫЗОВ КОНСТРУКТОРА 2
            Console.WriteLine(a.Gety());
        }
    }



##



    class Demo // КОНСТРУКТОРЫ (инициализация объекта)
    {
        public Demo ( int a) // КОНСТРУКТОР 1
        {
            this.a = a;

        }
        public Demo (int a,double y) : this(a) // ВЫЗОВ КОНСТРУКТОРА 1      this - инициализатор. Это код, который выполняется до начала тела конструктора
        {
            this.y = y;
        }

        public double Gety() // метод получения 
        {
            return y;
        }

        int a;
        double y;
    }
    class Class1
    {
        static void Main()
        {
            Demo a = new Demo(300); // ВЫЗОВ КОНСТРУКТОРА 1
            Console.WriteLine(a.Gety());
        }
    }



##



    class Demo // КОНСТРУКТОРЫ (инициализация объекта)
    {
        public Demo(int a): base() // КОНСТРУКТОР 1
        {
            this.a = a;
        }
    }



##



#
