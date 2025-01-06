using System.Threading.Channels;

namespace Otus_HW5_Delegates
{
    public class Program
    {

        static void Main(string[] args)
        {
            #region Первая часть задания
            {

                List<string> list = new List<string> { "first", "second", "third" };

                var maxElement = list.GetMax(s => s.Length);

                Console.WriteLine($"Задача 1.\r\nМаксимальный элемент коллекции: {maxElement}\r\n");
            }
            #endregion

            #region Вторая часть задания
            {

                Console.WriteLine("Задача 2.");

                var finder = new FileFinder(@"..\..\..\..\FolderWithTestFiles\");

                Console.CancelKeyPress += finder.CancelSearch;

                finder.FileFound += (s, e) =>
                {
                    Console.WriteLine($"Найден файл: {e.FileName}");
                };

                finder.Search();
            }

            #endregion
        }


        

    }

}
