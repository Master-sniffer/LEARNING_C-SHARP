using System; // позволяет юзать имена стандартных классов из пространства имен system
using System.IO; // Для работы с файлами и не только !
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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



    class D // КЛАСС СО СТАТИЧЕСКИМ И ЗАКРЫТЫММ КОНСТРУКТОРОМИ
    {
        private D() { } // закрытый конструктор
        static D() // статический конструктор
        {
            a = 200;
        }
        static int a;
        static double b = 0.002;
        public static void Print()
        {
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
        }

    }
    class Class2
    {
        static void Main()
        {
            D.Print();
            D d = new D();  // выдаст ошибка, так как экземпляр создать нереал, так как у нас закрытый конструктор
        }
    }



##



            // ЩА БУДЕТ ПРИМЕР РАБОТЫ С КЛАССАМИ
    class Monster
    {
        public Monster()
        {
            this.name = "Nomad";
            this.health = 100;
            this.ammo = 50;
        }
        public Monster (string name): this()
        {
            this.name = name;
        }
        public Monster (int health, int ammo, string name)
        {
            this.name = name;
            this.health = health;
            this.ammo = ammo;
        }

        public string GetName()
        {
            return name;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetAmmo()
        {
            return ammo;
        }

        public void Passport()
        {
            Console.WriteLine("Monster {0} \thealth = {1} and ammo is {2} ", name, health, ammo);
        }
        string name; // ИДЕТ ЗАКРЫТИЕ ПОЛЯ
        int health, ammo;
    }

    class Class1
    {
        static void Main()
        {
            Monster x = new Monster(); // ВЫЗОВ КОНСТРУКТОРА 1
            x.Passport();
            Monster Vasia = new Monster("VasiOchka"); // ВЫЗОВ КОНСТРУКТОРА 2
            Vasia.Passport();
            Monster Masha = new Monster(200, 200, "Masha"); // ВЫЗОВ КОНСТРУКТОРА 3
            Masha.Passport();
        }
    }



##



    // СВОЙСТВА
    public class Button : Control // BUTTON ЯВЛЯЕТСЯ ПРОИЗВОДНЫМ ОТ КЛАССА Control
    {
        private string caption; // Закрытое поле, с которым связано свойство
        public string Caption // свойство
        {
            get // СПОСОБ ПОЛУЧЕНИЯ СВОЙСТВА
            {
                return caption;
            }
            set // СПОСОБ УСТАНОВКИ СВОЙСТВА
            {
                if (caption != value)
                {
                    caption = value;
                }

                Button ok = new Button();
                ok.Caption = "OK";
                string s = ok.Caption;
            }

        }

    }



##



    // КАК МОЖНО ЕЩЕ ИСПОЛЬЗОВАТЬ GET И SET
    class A
    {
        private static ComplexObject x; // закрытое поле
        private static ComplexObject X
        {
            get
            {
                if (x == nul)
                {
                    x = new ComplexSubject(); // Создание объекта при 1-ом обращении
                }
                return x;
            }
        }
    }



##



    class Monster
    {
        public Monster()
        {
            this.name = "Nomad";
            this.health = 100;
            this.ammo = 50;
        }
        public Monster(string name) : this()
        {
            this.name = name;
        }
        public Monster(int health, int ammo, string name)
        {
            this.name = name;
            this.health = health;
            this.ammo = ammo;
        }

        public int Health // свойство связано с полем health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 0) health = value;
                else health = 0;
            }
        }

        public int Ammo // свойство связано с ammo
        {
            get
            {
                return ammo;
            }
            set
            {
                if (value > 2000) ammo = value;
                else ammo = 0;
            }
        }

        public string Name // свойство связано с name
        {
            get
            {
                return name;
            }
        }

        public void Passport()
        {
            Console.WriteLine("Monster {0} \thealth = {1} and ammo is {2} ", name, health, ammo);
        }
        string name; // ИДЕТ ЗАКРЫТИЕ ПОЛЯ
        int health, ammo;
    }

    class Class1
    {
        static void Main()
        {
            Monster Masha = new Monster(200, 200, "Masha");
            Masha.Passport();
            --Masha.Health; // ЮЗАЕМ СВОЙСТВА
            Masha.Ammo = +100;
            Masha.Passport();
        }
    }



##



// МАССИВЫ
int[] w = new int[10] // операция выделяет память под 10 целых элементов
string[] z = new string[100] // операция выделяет память под 100 ссылок на строки, а эти массивы заполняются значением null

int [] a = new int[10] ;
int[] b = a; // b и a указывают на один и тот же массив

// ОДНОМЕРНЫЕ МАССИВЫ

int[] a; // элементов в нем нет
int [] b = new int [4]; // элементы равны нулю (0)
int[] c = {61,2,5,-9}; // подарзумевается new
int [] d = new int [] {61,2,5,-9}; // размерность вычисляется 
int [] e = new int[4] {61,2,5,-9}; // избыточное описание



##



    class Class1
    {
        static void Main()
        {
            const int n = 6;
            int[] a = new int [n] { 3, 12, 5, -9, 8, -4 };

            Console.WriteLine("ИСХОДНЫЙ МАССИВ");
            for (int i = 0; i <n; ++i)
            {
                Console.WriteLine("\t" + a[i]);
            }
            Console.WriteLine();
            long sum = 0;
            int num = 0;
            for (int i = 0; i<n; ++i) 
                if (a[i] < 0)
                {
                    sum += a[i];
                    ++num;
                }
            Console.WriteLine("SUM OF THE NEGATIVE NUMBERS IS = " + sum);
            Console.WriteLine("NUMBER OF THE NEGATIVES = " + num);

            int max = a[0];
            for (int i = 1; i < n; ++i)
                if (a[i] > max) max = a[i];
            Console.WriteLine("MAX ELEMENT IS " + max);
        }
    }



##



    class Class1
    {
        // ПРЯМОУГОЛЬНЫЕ МАССИВЫ
        int[,] a; // Элементов нет
        int[,] b = new int[2, 3]; // Элементы равны 0
        int[,] c = { { 1, 2, 3 }, { 4, 5, 6 } }; // new подразумевается 
        int[,] k = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }; // размерность вычисляется 
        int[,] d = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // избыточное описание
    }



##



    class Class1
    {
        static void Main()
        {
            const int m = 3, n = 4;
            int[,] a = new int[m, n]
            {
                {2,-2,8,9 },
                {-4,-5,6,-2},
                {7,0,1,1 }
            };
            Console.WriteLine("Исходный массив");
            for (int i=0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                    Console.WriteLine("\t" + a[i, j]);
                Console.WriteLine();
            }
            double sum = 0;
            int nPosEl;
            for (int i = 0; i < m; ++i)
            {
                nPosEl = 0;
                for (int j = 0; j < n; ++j)
                {
                    sum += a[i, j];
                    if (a[i, j] > 0) ++nPosEl;
                }
                Console.WriteLine("В строке {0} {1} положит x элементов", i, nPosEl);
            }
            Console.WriteLine("Среднее арфимет всех элементов " + sum / m / n);
        }
    }



##



    // Ступенчатые массивы 
    class Class1
    {
        int[][] a = new int[3][]; // выделение памяти под ссылки на три строки
        a[0] = new int[5]; // выделение памяти под 0 строку (5 элементов)
        a[1] = new int [3]; // выделение памяти под 1 строку (3 элемента)
        a[2] = new int[4]; // выделение памяти под 2 строку (4 элемента)
    }



##



    class Class1
    {
        static void Main()
        {
            int[] a = { 24, 50, 18, 3, 16, -7, 9, -1 };

            PrintArray("Исходный массив", a);
            Console.WriteLine(Array.IndexOf(a, 18)); // ПОИСК ПЕРВОГО ВХОЖДЕНИЯ ЭЛЕМЕНТА В МАССИВ

            Array.Sort(a); // УПОРЯДОЧИВАНИЕ ЭЛЕМЕНТОВ ОДНОМЕРНОГО МАССИВА
            PrintArray("Упорядочный массив ", a);
            Console.WriteLine(Array.BinarySearch(a, 18)); // ДВОИЧНЫЙ ПОИСК В ОТСОРТИРОВАННОМ МАССИВЕ
        }
        public static void PrintArray (string header, int[] a)
        {
            Console.WriteLine(header);
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine("\t" + a[i]);
            Console.WriteLine();
        }
    }



##



    class Class1
    {
        static void Main()
        {
            int[][] a = new int[3][];
            a[0] = new int[5] { 24, 50, 18, 3, 16 };
            a[1] = new int[3] { 7, 9, -1 };
            a[2] = new int[4] { 6, 15, 3, 1 };

            Console.WriteLine("Исходный массив ");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.WriteLine("\t" + a[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine(Array.IndexOf(a[0], 18));
        }
    }



##



using System;
using System.IO;
namespace ConsoleApplication1
{
    //FOREACH
    class Class1
    {
        static void Main()
        {
            int[] a = { 3, 12, 5, -9, 8, -4 };

            Console.WriteLine("Исходный массив");
            foreach (int elem in a)
                Console.WriteLine("\t" + elem);
            Console.WriteLine();

            long sum = 0;
            int num = 0;
            foreach (int elem in a)
                if (elem < 0)
                {
                    sum += elem;
                    ++num;
                }
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("num = " + num);

            int max= a[0]; // максимальный элемент
            foreach (int elem in a)
                if (elem > max) max = elem;

            Console.WriteLine("max = " + max);
        }
    }
}



##



    // ИСПОЛЬЗОВАНИЕ МЕТОДОВ System.Char
    class Class1
    {
        static void Main()
        {
            try
            {
                char b = 'B', c = '\x63', d = '\u0032';
                Console.WriteLine("{0} {1} {2}", b, c, d);
                Console.WriteLine("{0} {1} {2}",
                    char.ToLower(b), char.ToUpper(c), char.GetNumericValue(d));
                char a;
                do
                {
                    Console.WriteLine("Enter symbol");
                    a = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter symbol {0} and his code is {1}", a, (int)a);
                    if (char.IsLetter(a)) Console.WriteLine("Letter");
                    if (char.IsUpper(a)) Console.WriteLine("Upper reg");
                    if (char.IsLower(a)) Console.WriteLine("Low reg");
                    if (char.IsControl(a)) Console.WriteLine("Controlled");
                    if (char.IsNumber(a)) Console.WriteLine("Number");
                    if (char.IsPunctuation(a)) Console.WriteLine("Devider");
                } while (a != 'q');
            }
            catch
            {
                Console.WriteLine("THERE IS A FUCKING EXCEPTION RIGHT IN THE CODE !");
                return;
            }
        }
    }



##



    // РАБОТА С МАССИВАМИ СПИСКОВ

    class Class1
    {
        static void Main()
        {
            char[] a = { 'm', 'a', 's', 's', 'i', 'v' }; // ЗАДАЛИ ЭЛЕМЕНТЫ МАССИВА
            char[] b = "а роза упала на лапу хера".ToCharArray(); // ПЕРЕВЕЛИ ПРЕДЛОЖЕНИЕ В НУЖНЫЙ НАМ ФОРМАТ

            PrintArray("Исходный массив", a);

            int pos = Array.IndexOf(a, 'm');
            a[pos] = 'M';
            PrintArray("Changed massive a", a);

            PrintArray("Changed massive b ", b);
            Array.Reverse(b);
            PrintArray("Changed massive ", b);
        }

        public static void PrintArray(string header, Array a)
        {
            Console.WriteLine(header);
            foreach (object x in a) Console.Write(x);
            Console.WriteLine("\n");
        }
    }



##



    // СОЗДАНИЕ СТРОК ТИПА string
    class Class1
    {
        string s; // ИНИЦИАЛИЗАЦИЯ ОТЛОЖЕНА
        string u = new string(' ', 20); // КОНСТРУКТОР СОЗДАЕТ СТРОКУ ИЗ 20 ПРОБЕЛОВ
        string t = "qqq"; //  ИНИЦИАЛИЗАЦИЯ СТРОКОВЫМ ЛИТЕРАЛОМ
        char[] a = { '0', '0', '0' }; // МАССИВ ДЛЯ ИНИЦИАЛИЗАЦИИ СТРОКИ
        string v = new string(a); // СОЗДАНИЕ ИЗ МАССИВА СИМВОЛОМ 
    }



##



    // РАБОТА СО СТРОКАМИ ТИПА STRING
    class Class1
    {
        static void Main()
        {
            string s = "Прекрасная королева Изольда";
            Console.WriteLine(s);
            string sub = s.Substring(3).Remove(12, 2);
            Console.WriteLine(sub);

            string[] mas = s.Split(' ');
            string joined = string.Join("! ", mas);
            Console.WriteLine(joined);

            Console.WriteLine("Enter the string");
            string x = Console.ReadLine();
            Console.WriteLine("You've entered the string " + x);

            double a = 12.234;
            int b = 29;
            Console.WriteLine("a = {0,6:C} b = {1,2:X}", a, b);
            Console.WriteLine(" a = {0,6:0.##} b={1,5:0.# ' rub. '}", a, b);
            Console.WriteLine(" a = {0:F3} b= {1:D3}", a, b);
        }
    }



##



    class Class1
    {
        StringBuilder a = new StringBuilder(); // Создается пустая строка размера - 16 байт
        StringBuilder b = new StringBuilder("qwerty"); //  создание 
        StringBuilder c = new StringBuilder(100); // выделение памяти 
        StringBuilder d = new StringBuilder("qweert", 100); // создание и выделение памяти
        StringBuilder e = new StringBuilder("qwerty", 1, 3, 100); // объект инициализируестя подстрокой длиной 3 символа, начиная с 1 (подстрока "wer) 
    }



##



    // РАБОТА СО СТРОКАМИ ТИПА STRINGBUILDER
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter the salary: ");
            double salary = double.Parse(Console.ReadLine());

            StringBuilder a = new StringBuilder();
            a.Append("Salary");
            a.AppendFormat("{0, 6:C} - per year {1,6:C}", salary, salary * 12);
            Console.WriteLine(a);

            a.Replace("p", "thous");
            Console.WriteLine("It would be better if " + a);
        }
    }



##



    //RANDOM
    class Class1
    {
        static void Main()
        {
            // ВСЕГДА НУЖНО СОЗДАВАТЬ ЭКЗЕМПЛЯР КЛАССА
            Random a = new Random();  // ИСПОЛЬЗУЕТ ЗНАЧЕНИЕ ГЕНЕРАТОРА , КОТОРОЕ ОСНОВАНО НА НЫНЕШНЕМ ВРЕМЕНИ
            Random b = new Random(1); // ИСПОЛЬЗУЕТ ПАРАМЕТР, ЧТО-ТО ТИПА SEED В МАЙНКРАФТЕ
            const int n = 10;

            Console.WriteLine("\n Диапазон [0,1]:");
            for (int i = 0; i< n; i++)
            {
                Console.Write("{0,6:0.##}", a.NextDouble());
            }
            Console.WriteLine("\n Диапазон [0,1000]: ");
            for (int i = 0; i < n; i++)
                Console.Write("   " + b.Next(1000));

            Console.WriteLine("\n Диапазон [-10, 10]: ");
            for (int i = 0; i < n; i++)
                Console.Write("    " + a.Next(-10, 10));

            Console.WriteLine("\n Массив [0,255]: ");
            byte[] mas = new byte[n];
            a.NextBytes(mas);
            for (int i = 0; i < n; ++i) Console.Write(" " + mas[i]);
        }
    }



##



    // Метод с переменным числом параметров
    class Class1
    {
        public static double Average(params int[] a)
        {
            if (a.Length == 0)
                throw new Exception("Not enough of arguements in the esample");

            double av = 0;
            foreach (int elem in a) av += elem;
            return av / a.Length;
        }

        static void Main()
        {
            try
            {
                int[] a = { 10, 20, 30 };
                Console.WriteLine(Average(a));
                int[] b = { -11, -4, 12, 14, 32, -1, 28 };
                Console.WriteLine(Average(b));
                short z = 1, e = 13;
                byte v = 107;
                Console.WriteLine(Average(z, e, v));
                Console.WriteLine(Average());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }



##



    // ИСПОЛЬЗОВАНИЕ ИНДЕКСАТОРОВ
    class SafeArray
    {
        public SafeArray(int size)
        {
            a = new int[size];
            length = size;
        }
        public int Length
        {
            get { return length; }
        }

        public int this [int i]
        {
            get
            {
                if (i >= 0 && i < length) return a[i];
                else { error = true; return 0; }
            }
            set
            {
                if (i >= 0 && i < length && value >= 0 && value <= 100) a[i] = value;
                else error = true;
            }
        }
        public bool error = false; // открытый признак ошибки
        int[] a; // закрытый массив
        int length; // закрытая размерность
    }

    class Class1
    {
        static void Main()
        {
            int n = 100;
            SafeArray sa = new SafeArray(n);
            for (int i =0; i < n; i++)
            {
                sa[i] = i * 2;
                Console.WriteLine(sa[i]);
            }
            if (sa.error) Console.WriteLine("There were mistakes");
        }
    }



##



    // ИНДЕКСАТОР МАССИВА
    class Pow2
    {
        public ulong this[int i]
        {
            get
            {
                if (i >= 0)
                {
                    ulong res = 1;
                    for (int k = 0; k < 1; k++) //
                        unchecked { res *= 2; }
                    return res;
                }
                else return 0;
            }
        }
    }

    class Class1
    {
        static void Main()
        {
            int n = 13;
            Pow2 pow2 = new Pow2();
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}\t{1}", i, pow2[i]);
        }
    }



##



using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class SafeArray
    {
        public SafeArray (int size)
        {
            a = new int[size];
            length = size;
        }

        public SafeArray (params int[] arr)
        {
            length = arr.Length;
            a = new int[length];
            for (int i = 0; i < length; ++i) a[i] = arr[i];
        }

        public static SafeArray operator ++(SafeArray x)
        {
            SafeArray temp = new SafeArray(x.length);
            for (int i = 0; i < x.length; ++i)
                temp[i] = ++x.a[i];
            return temp;
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < length) return a[i];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (i >= 0 && i < length) a[i] = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public void Print (string name)
        {
            Console.WriteLine(name + ":");
            for (int i = 0; i < length; ++i)
                Console.WriteLine("\t" + a[i]);
            Console.WriteLine();
        }
        int[] a; // закрытый массив
        int length; // закрытая размерность
    }

    class Class1
    {
        static void Main()
        {
            try
            {
                SafeArray a1 = new SafeArray(5, 2, -1, 1, -2);
                a1.Print("MASSIVE");
                a1++;
                a1.Print("ИНКРЕМЕНТ МАССИВА");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}



##



    class SafeArray
    {
        public SafeArray(int size)
        {
            a = new int[size];
            length = size;
        }

        public SafeArray(params int[] arr)
        {
            length = arr.Length;
            arr = new int[length];
            for (int i = 0; i < length; ++i ) a[i] = arr[i];
        }

        public static SafeArray operator + (SafeArray x, SafeArray y) // +
        {
            int len = x.length < y.length ? x.length : y.length;
            SafeArray temp = new SafeArray(len);

            for (int i = 0; i < len; ++i) temp[i] = x[i] + y[i];
            return temp;
        }

        public static SafeArray operator + (SafeArray x, int y)
        {
            SafeArray temp = new SafeArray(x.length);
            for (int i = 0; i < x.length; ++i) temp[i] = x[i] + y;
            return temp;
        }

        public static SafeArray operator + (int x, SafeArray y)
        {
            SafeArray temp = new SafeArray(y.length);
            for (int i = 0; i < y.length; ++i) temp[i] = x + y[i];
            return temp;
        }

        public static SafeArray operator ++ (SafeArray x)
        {
            SafeArray temp = new SafeArray(x.length);
            for (int i = 0; i < x.length; ++i) temp[i] = ++x.a[i];
            return temp;
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < length) return a[i];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (i >= 0 && i < length) a[i] = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public void Print (string name)
        {
            Console.WriteLine(name + ":");
            for (int i = 0; i < length; ++i) Console.WriteLine("\t" + a[i]);
            Console.WriteLine();
        }

        int[] a;
        int length;
    }

    class Class1
    {
        static void Main()
        {
            try
            {
                SafeArray a1 = new SafeArray(5, 2, -1, 1, -2);
                a1.Print("ARRAY 1");

                SafeArray a2 = new SafeArray(1, 0, 3);
                a2.Print("ARRAY 2"); a1++;

                SafeArray a3 = a1 + a2;
                a3.Print("SUM OF THE ARRAYS 1 AND 2");

                a1 += 100;
                a1.Print("ARRAY 1 + 100");

                a1 = 100 + a1;
                a1.Print("100 + ARRAY 1");

                a2 += ++a2 + 1;
                a2.Print("++a2 , a2+a2 +1");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }



##



    class Engine
    {
        public void Launch()
        {
            Console.WriteLine("OTCHISLEN\n");
        }
    }

    class Plane
    {
        public Plane()
        {
            left = new Engine();
            right = new Engine();
        }

        public void Launch_Engine()
        {
            left.Launch();
            right.Launch();
        }
        Engine left, right;
    }

    class Class1
    {
        static void Main()
        {
            Plane Ah24_1 = new Plane();
            Ah24_1.Launch_Engine();
        }
    }



##



    class Monster
    {
        public Monster (int health , int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }

        public override bool Equals(object.obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Monster temp = (Monster) obj;
            return health == temp.health &&
                    ammo == temp.ammo    &&
                    name == temp.name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("Monster {0}\tHealth = {1} and ammo = {2}" , name,health, ammo);
        }

        string name;
        int health, ammo;
    }

    class Class1
    {
        static void Main()
        {
            Monster X = new Monster(80, 80, "VASIA");
            Monster Y = new Monster(80, 80, "VASIA");
            Monster Z = X;

            if (X == Y) Console.WriteLine("X==Y");
            else Console.WriteLine("X!=Y");
            if (X == Z) Console.WriteLine("X==Z");
            else Console.WriteLine("X!=Z");

            if (X.Equals(Y)) Console.WriteLine("X Equals Y");
            else Console.WriteLine("X not Equals Y");

            Console.WriteLine(X.GetType());
        }
    }



##



 // РЕАЛИЗАЦИЯ ИНТЕРФЕЙСА
    interface IAction
    {
        void Draw();
        int Attack(int a);
        void Die();
        int Power { get; }
    }

    class Monster
    {
        public void Draw()
        {
            Console.WriteLine("HEY "+name);
        }

        public int Attack(int ammo_)
        {
            ammo -= ammo_;
            if (ammo_ > 0) Console.WriteLine("BAM !");
            else ammo_ = 0;
            return ammo;
        }

        public void Die()
        {
            Console.WriteLine("MONSTER " + name + "RIPPPP");
            health = 0;
        }

        public int Power
        {
            get
            {
                return ammo * health;
            }
        }
    }



##



    // РАБОТА С ОБЪЕКТАМИ ЧЕРЕЗ ИНТЕРФЕЙСЫ С ПОМОЩЬЮ IS
   class Class1
    {
        static void Act(object A)
        {
            if (A is IAction)
            {
                IAction Actor = (IAction)A;
                Actor.Draw();
            }
        }
    }



##



        // ИНТЕРФЕЙС И НАСЛЕДОВАНИЕ
        interface IBase
        {
            void F(int i);
        }

        interface Ileft : IBase
        {
            new void F(int i); // Переопределение метода F
        }
        interface IRight : IBase
        {
            void G();
        }
        interface Iderived : Ileft, IRight { }

    class A
    {
        void Test (IDerived d)
        {
            d.F(1);
            ((IBase)d).F(1);
            ((Ileft)d).F(1);
            ((IRight)d).F(1);
        }
    }



##



    // ПРИМЕР РЕАЛИЗАЦИИ IComparable

    class Monster : IComparable
    {
        public Monster (int health , int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }

        virtual public void Passport()
        {
            Console.WriteLine("Monster {0} \t health - {1} ammo = {2} ", name, health, ammo);
        }

        public int CompareTo(object obj) // реализация интерфейся
        {
            Monster temp = (Monster)obj;
            if (this.health > temp.health) return 1;
            if (this.health < temp.health) return -1;
            return 0;
        }

        string name;
        int health, ammo;
    }

    class Class1
    {
        static void Main()
        {
            const int n = 3;
            Monster[] stado = new Monster[n];

            stado[0] = new Monster(50, 50, "VASIAN");
            stado[1] = new Monster(80, 80, "PETIA");
            stado[2] = new Monster(40, 10, "MASHA");

            Array.Sort(stado);
            foreach (Monster elem in stado) elem.Passport();
        }
    }



##



    // СОРТИРОВКА ПО 2 КРИТЕРИЯМ

    class Monster
    {
        public Monster (int health , int ammo , string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }

        public int Ammo
        {
            get { return ammo; }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }

        public string Name
        {
            get { return name; }
        }

        virtual public void Passport()
        {
            Console.WriteLine("Monster {0}\t health={1} and ammo = {2}", name, health, ammo);
        }

        public class SortByName : IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                Monster m1 = (Monster)ob1;
                Monster m2 = (Monster)ob2;
                return String.Compare(m1.Name, m2.Name);
            }
        }

        public class SortByAmmo : IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                Monster m1 = (Monster)ob1;
                Monster m2 = (Monster)ob2;
                if (m1.Ammo > m2.Ammo) return 1;
                if (m1.Ammo < m2.Ammo) return -1;
                return 0;
            }
        }
        string name;
        int health, ammo;
    }

    class Class1
    {
        static void Main()
        {
            const int n = 3;
            Monster[] stado = new Monster[n];
            stado[0] = new Monster(50, 50, "VASIA");
            stado[1] = new Monster(80, 80, "MASHA");
            stado[2] = new Monster(40, 10, "PETIA");

            Console.WriteLine("SORT BY NAME\n");
            Array.Sort(stado, new Monster.SortByAmmo());
            foreach (Monster elem in stado) elem.Passport();

            Console.WriteLine("SORT BY THE SURROUNDINGS");
            Array.Sort(stado, new Monster.SortByAmmo());
            foreach (Monster elem in stado) elem.Passport();

        }
    }



##



   // ПЕРЕГРУЗКА ОПЕРАЦИЙ ОТНОШЕНИЯ

    class Monster : IComparable
    {
        public Monster (int health , int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Monster temp = (Monster)obj;
            return health == temp.health &&
                    ammo == temp.ammo &&
                    name == temp.name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public static bool operator == (Monster a, Monster b)
        {
            return a.Equals(b);
        }

        // HOW WE CAN DO IT - 1 VAR
        //public static bool operator == (Monster a, Monster b)
        //{
        //    return (a.CompareTo(b) == 0);
        //}

        public static bool operator != (Monster a, Monster b)
        {
            return !a.Equals(b);
        }

        public static bool operator < (Monster a, Monster b)
        {
            return (a.CompareTo(b) < 0);
        }
        public static bool operator > (Monster a, Monster b)
        {
            return (a.CompareTo(b) > 0);
        }
        
        public static bool operator <=(Monster a, Monster b)
        {
            return (a.CompareTo(b) <= 0);
        }
        
        public static bool operator >=(Monster a, Monster b)
        {
            return (a.CompareTo(b) >= 0);
        }

        public int CompareTo (object obj)
        {
            Monster temp = (Monster)obj;
            if (this.health > temp.health) return 1;
            if (this.health < temp.health) return -1;
            return 0;
        }

        string name;
        int health, ammo;
    }

    class Class1
    {
        static void Main()
        {
            Monster Vasia = new Monster(70, 80, "VASIA");
            Monster Petia = new Monster(80, 80, "PETIA");

            if (Vasia > Petia) Console.WriteLine("VASIA IS BIGGER THAN PETIA");
            else if (Vasia == Petia) Console.WriteLine("VASIA == PETIA");
            else Console.WriteLine("VASIA IS SHORTER THAN PETIA");
        }
    }



##



    // ПРОСТЕЙШИЙ ИТЕРАТОР

    class Num : IEnumerable
    {
        public IEnumerable GetEnumerator()
        {
            yield return "one";
            yield return "two";
            yield return "three";
            yield return "OOPS";
        }
    }

    class Class1
    {
        static void Main()
        {
            foreach (string s in new Num()) Console.WriteLine(s); 
        }
    }



##



    // ЕЩЕ ОДИН ПРОСТОЙ ИНУМЕРАТОР

    class Class1
    {
        public static IEnumerable Count (int from , int to)
        {
            from = 1;
            while (from <= to) yield return from++;
        }
        static void Main()
        {
            foreach (int i in Count(1, 5)) Console.WriteLine(i);
        }
    }



##



    struct Complex
    {
        public double re, im;
        public Complex (double re_ , double im_)
        {
            re = re_; im = im_; // МОЖНО ВМЕСТО ЭТОГО ИСПОЛЬЗОВАТЬ this.re , this.im
        }

        public static Complex operator + (Complex a, Complex b)
        {
            return new Complex(a.re + b.re, a.im + b.im);
        }

        public override string ToString()
        {
            return (string.Format("({0,2:0.##};{1,2:0.##})", re, im));
        }
    }

    class Class1
    {
        static void Main()
        {
            Complex a = new Complex(1.2345, 5.6);

            Console.WriteLine("a= " + a);

            Complex b;
            b.re = 10; b.im = 1;
            Console.WriteLine("b= " + b);

            Complex c = new Complex();
            Console.WriteLine("c= " + c);

            c = a + b;
            Console.WriteLine("c= " + c);
        }
    }



##



    // ПЕРЕЧИСЛЕНИЕ
    struct warrior
    {
        public enum Warrior_rank
        {
            Rook , Sergant, Mayor, General
        }

        public string surname;
        public Warrior_rank rank;
    }   

    class Class1
    {
        static void Main()
        {
            warrior x;
            x.surname = "Ivanov";
            x.rank = warrior.Warrior_rank.Sergant;

            Console.WriteLine(x.rank + " " + x.surname);
        }
    }



##



    // ИСПОЛЬЗОВАНИЕ ДЕЛЕГАТОВ
    delegate void Del(ref string s);

    class Class1
    {
        public static void C001 (ref string s)
        {
            string temp = "";
            for (int i=0; i < s.Length; i++)
            {
                if (s[i] == 'o' || s[i] == 'O') temp += 'O';
                else if (s[i] == 'l') temp += 'l';
                else temp += s[i];
            }
            s = temp;
        }

        public static void Hack (ref string s)
        {
            string temp = "";
            for (int i = 0; i < s.Length; i++)
                if (i / 2 * 2 == i) temp += char.ToUpper(s[i]);
                else temp += s[i];

            s = temp;
        }

        static void Main()
        {
            string s = "Cool hackers";
            Del d; // ЭКЗЕМПЛЯР КЛАССА

            for (int i=0; i <2; ++i)
            {
                d = new Del(C001); // ИНИЦИАЛИЗАЦИЯ МЕТОДОМ 1
                if (i == 1) d = new Del(Hack); // ИНИЦИАЛИЗАЦИЯ МЕТОДОМ 2

                d(ref s); // использование делегата для вызова методов
                Console.WriteLine(s);
            }
        }
    }



##



    // ОПОВЕЩЕНИЕ НАБЛЮДАТЕЛЕЙ С ПОМОЩЬЮ ДЕЛЕГАТА
    public delegate void Del(object o);

    class Subj
    {
        Del dels;

        public void Register (Del d)
        {
            dels += d;
        }

        public void OOPS()
        {
            Console.WriteLine("OOPS!!!");
            if (dels != null) dels(this);
        }
    }

    class ObsA
    {
        public void Do (object o)
        {
            Console.WriteLine("I SEE THAT'S OOPS !");
        }
    }

    class ObsB
    {
        public static void See (object o)
        {
            Console.WriteLine("I SEE IT TOO, MAN !\nFUCKING OOPS");
        }
    }

    class Class1
    {
        static void Main()
        {
            Subj s = new Subj(); // ОБЪЕКТ КЛАССА ИСТОЧНИКА

            ObsA o1 = new ObsA(); // ОБЪЕКТЫ КЛАССА НАБЛЮДАТЕЛЯ
            ObsA o2 = new ObsA();

            s.Register(new Del(o1.Do)); // РЕГИСТРАЦИЯ МЕТОДОВ
            s.Register(new Del(o2.Do)); // НАБЛЮДАТЕЛЕЙ В ИСТОЧНИКЕ
            s.Register(new Del(ObsB.See)); // (ЭКЗЕМПЛЯРЫ ДЕЛЕГАТА)

            s.OOPS(); // ИНИЦИАЛИЗАЦИЯ СОБЫТИЯ
        }
    }
}



##



    // ИСПОЛЬЗОВАНИЕ ДЕЛЕГАТА
    public delegate double Fun(double x);

    class Class1
    {
        public static void Table (Fun F, double x, double b)
        {
            Console.WriteLine(" ---X---Y---");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.00} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("-------");
        }

        public static double Simple (double x)
        {
            return 1;
        }
        
        static void Main()
        {
            Console.WriteLine("TABKE OF VARS OF SIN");

            Table(new Fun(Math.Sin), -2, 2);

            Console.WriteLine("TABLE OF FUNCS SIMPLE");
            Table(new Fun(Simple), 0, 3);
        }
    }



##



    //  ОБРАБОТКА ИСКЛЮЧЕНИЙ ПРИ ВЫЗОВЕ ДЕЛЕГАТОВ
    delegate void Del(ref string s);

    class Class1
    {
        public static void COO1(ref string s)
        {
            Console.WriteLine("CALLED METHOD COO1");
            string temp = "";
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == 'o' || s[i] == 'O') temp += 'O';
                else if (s[i] == 'l') temp += 1;
                else temp += s[i];
            }
            s = temp;
        }

        public static void Hack (ref string s)
        {
            Console.WriteLine("Called method HACK");
            string temp = "";
            for (int i = 0; i <s.Length; ++i)
            {
                if (i / 2 * 2 == i) temp += char.ToUpper(s[i]);
                else temp += s[i];
            }

            s = temp;

        }

        public static void BadHack(ref string s)
        {
            Console.WriteLine("CALLED BADHACK, LMAO");
            throw new Exception();
        }

        static void Main()
        {
            string s = "COOL HAЦKERS";
            Del d = new Del(COO1); // создание экземпляра делегата
            d += new Del(BadHack); // дополнение списка методов
            d += new Del(Hack); // дополнение методов списка

            foreach (Del fun in d.GetInvocationList())
            {
                try
                {
                    fun(ref s);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Exception method " + fun.Method.Name);
                }
            }
            Console.WriteLine("RESULT IS " + s);
        }
    }



##



    class subj
    {
        public event EventHandler Oops;

        public void CryOoops()
        {
            Console.WriteLine("Oops!");
            if (Oops != null) Oops(this,null);
        }
    }

    class ObsA
    {
        public void OnOops (object sender , EventArgs e)
        {
            Console.WriteLine(" I SEE THAT'S OOPS");
        }
    }

    class ObsB
    {
        public static void OnOops (object sender, EventArgs e)
        {
            Console.WriteLine("WELL , I SEE THAT TOO");
        }
    }

    class Class1
    {
        static void Main()
        {
            subj s = new subj();

            ObsA o1 = new ObsA();
            ObsA o2 = new ObsA();

            s.Oops += new EventHandler(o1.OnOops);
            s.Oops += new EventHandler(o2.OnOops);
            s.Oops += new EventHandler(ObsB.OnOops);

            s.CryOoops();
        }
    }



##



    // ОДНОВРЕМЕННАЯ РАБОТА 2 ПОТОКОВ С ПОМОЩЬЮ THREAD

    class Program
    {
        static public void HedgeHog()
        {
            for (int i=0; i < 6; ++i)
            {
                Console.WriteLine(i); Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            Console.WriteLine("FIRST FLOW " + Thread.CurrentThread.GetHashCode());

            Thread ta = new Thread(new ThreadStart(HedgeHog));
            Console.WriteLine("SECOND FLOW " + ta.GetHashCode());
            ta.Start();

            for (int i = 0; i>-6; --i)
            {
                Console.WriteLine(" " + i); Thread.Sleep(400); // SLEEP нужен лоя остановки проги на это кол-во милисекунд
            }
        }
    }



##



    public delegate bool AsyncDelegate(int Num, out int m1, out int m2); // Асинхронный делегат

    public class Factorizer
    {
        public bool Factorize(int Num, out int m1, out int m2) // класс , выполняющий разложение числа на множители
        {
            m1 = 1; m2 = Num;
            for (int i = 2; i < Num; i++)
                if (0 == (Num % i)) { m1 = i; m2 = Num / i; break; }

            if (1 == m1) return false;
            else return true;
        }
    }

    public class PNum
    {
        private int Number;
        public PNum(int number) { Number = number; }
        [OnewWayAttribute()]

        public void Res (IAsyncResult ar)
        {
            int m1, m2;

            AsyncDelegate ad = (AsyncDelegate)((IAsyncResult)ar).AsyncDelegate;

            // получение результатов метода Factorize
            ad.EndInvoke(out m1, out m2, ar);

            Console.WriteLine("First method : Multiplers {0} : {1} {2}", Number, m1, m2);
        }
    }

    public class Simple
    {
        public void Num1() // используется функция обратного вызова
        {
            Factorizer f = new Factorizer();
            AsyncDelegate ad = new AsyncDelegate(f.Factorize);

            int Num = 1000584123, tmp;
            // создание экземпляра класса , который будет вызван после завершения работы метода Factorize

            PNum n = new PNum(Num);

            AsyncCallback callback = new AsyncCallback(n.Res);
            // Асинхронный вызов метода Factorize 

            IAsyncResult ar = ad.BeginInvoke(Num, out tmp, out tmp, callback, null);
        }
        // 2 Способ - используется ожидание окончание выполнения

        public void Num2()
        {
            Factorizer f = new Factorizer();
            AsyncDelegate ad = new AsyncDelegate(f.Factorize);

            int Num = 10085241241, tmp;

            PNum n = new PNum(Num);

            AsyncCallback callback = new AsyncCallback(n.Res);

            IAsyncResult ar = ad.BeginInvoke(Num, out tmp, out tmp, null, null);
            // Ожидание завершения
            ar.AsyncWaitHandle.WaitOne(10000, false);

            if (ar.IsCompleted)
            {
                int m1, m2;
                ad.EndInvoke(out m1, out m2, ar);
                Console.WriteLine("Second method : Multipliers {0} : {1} {2}", Num, m1, m2);
            }

        }

        public static void Main()
        {
            Simple s = new Simple();
            s.Num1();
            s.Num2();
        }
    }



##



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



##



#
