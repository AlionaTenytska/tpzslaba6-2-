using System;
using System.Collections.Generic;
using System.Text;

namespace tpzslaba6_2_
{
    class BookInLibrary: IComparable
    {
        string Name { get; }
        string Title { get; }
        int Code { get; set; }
        int Year { get; }
        int NumPages { get; }
        string Genre { get; }
        public BookInLibrary() { }
        public BookInLibrary(string name, string title, int code, int year, int numPages, string genre)
        {
            Name = name;
            Title = title;
            Code = code;
            Year = year;
            NumPages = numPages;
            Genre = genre;
        }
        public int CompareTo(object o)
        {
            BookInLibrary p = o as BookInLibrary;
            if (p != null)
                return this.Title.CompareTo(p.Title);
            else
                throw new Exception("Невозможно сравнить!");
        }
        public void SearchBook(int code)
        {
            if (Code == code)
            {
                Console.WriteLine("Книга {0} - {1}, имеет код - {2}", Title, Name, Code);
            }
        }
        public int checkCode(int code)
        {
            if (Code == code)
            {
                return 1;
            }
            return 0;
        }
        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("\n------------------------------------------\nКод - " + this.Code + "\n");
            sb.Append("Название книги - " + this.Title + "\n");
            sb.Append("Ф.И.О. автора - " + this.Name + "\n");
            sb.Append("Год написания - " + this.Year + "\n");
            sb.Append("Жанр - " + this.Genre + "\n");
            sb.Append("Количество страниц - " + this.NumPages + "\n");
            return sb.ToString();
        }
    }
}
