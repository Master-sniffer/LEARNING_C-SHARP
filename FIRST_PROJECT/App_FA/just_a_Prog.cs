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
