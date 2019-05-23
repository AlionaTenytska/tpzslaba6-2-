using System;

namespace tpzslaba6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество книг: ");
                int n = Convert.ToInt32(Console.ReadLine());
                BookInLibrary[] book = new BookInLibrary[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("-------Книга # {0} ----------\n", i + 1);
                    Console.Write("ФИО автора: ");
                    string name = Console.ReadLine();
                    Console.Write("Название книги: ");
                    string title = Console.ReadLine();
                    Console.Write("Код: ");
                    int code = int.Parse(Console.ReadLine());
                    Console.Write("Год написания: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Количество страниц: ");
                    int numPages = int.Parse(Console.ReadLine());
                    Console.Write("Жанр: ");
                    string genre = Console.ReadLine();
                    book[i] = new BookInLibrary(name, title, code, year, numPages, genre);
                }
                Array.Sort(book);
                Console.WriteLine("\n\t\tНАЗВАНИЯ КНИГ СОРТИРОВАНЫ ПО АЛФАВИТУ");
                foreach (BookInLibrary b in book)
                {
                    Console.WriteLine(b.ToString());
                }
                Console.WriteLine("Введите код книги для поиска: ");
                int codeSeach = int.Parse(Console.ReadLine());
                int check = 0;
                foreach (BookInLibrary b1 in book)
                {
                    check = b1.checkCode(codeSeach);
                }
                if (check == 1)
                {
                    foreach (BookInLibrary b2 in book)
                    {
                        b2.SearchBook(codeSeach);
                    }
                }
                else
                {
                    throw new Exception("Книг с кодом " + codeSeach + " не найдено!");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка - " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
