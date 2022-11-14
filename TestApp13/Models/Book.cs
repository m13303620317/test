using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp13.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/a.jpg" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Assets/b.jpg" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/c.jpg" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Option", CoverImage = "Assets/d.jpg" });
            books.Add(new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Accumsan", CoverImage = "Assets/e.jpg" });
            books.Add(new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius", CoverImage = "Assets/f.jpg" });
            books.Add(new Book { BookId = 7, Title = "Nostrud", Author = "Eleifend", CoverImage = "Assets/g.jpg" });
            books.Add(new Book { BookId = 8, Title = "Per Modo", Author = "Vero Tation", CoverImage = "Assets/h.jpg" });
            books.Add(new Book { BookId = 9, Title = "Suscipit Ad", Author = "Jack Tibbles", CoverImage = "Assets/i.jpg" });
            books.Add(new Book { BookId = 10, Title = "Decima", Author = "Tuffy Tibbles", CoverImage = "Assets/j.jpg" });
            books.Add(new Book { BookId = 11, Title = "Erat", Author = "Volupat", CoverImage = "Assets/k.jpg" });
            books.Add(new Book { BookId = 12, Title = "Consequat", Author = "Est Possim", CoverImage = "Assets/l.jpg" });
            books.Add(new Book { BookId = 13, Title = "Aliquip", Author = "Magna", CoverImage = "Assets/m.jpg" });

            return books;
        }
    }
}
