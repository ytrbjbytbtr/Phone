using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Читаем введенный с консоли символ
                var input = Console.ReadKey().KeyChar;

                // проверяем, число ли это
                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

                // если не соответствует критериям - показываем ошибку
                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Страницы не существует");
                }
                // если соответствует - запускаем вывод
                else
                {
                    // пропускаем нужное количество элементов и берем 2 для показа на странице
                    var pageContent = phoneBook.Skip((pageNumber - 1) * 2).Take(2);
                    Console.WriteLine();

                    // выводим результат
                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

                    Console.WriteLine();
                }
            }
        }
    }
}
