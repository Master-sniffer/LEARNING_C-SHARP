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



d
