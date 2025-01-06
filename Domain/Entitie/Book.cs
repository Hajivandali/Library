using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitie
{
    public class Book
    {
        public int Id { get; private set; }
        public string BookName { get; private set; }
        public string Author { get; private set; }
        public string Title { get; private set; }
        public long ISBN { get; private set; }  // شناسه یکتای کتاب
        public DateTime PublishedDate { get; set; }



        public Book(int id, string bookname, string Author, string title, long isbn, DateTime publishedDate)
        {
            Id = id;
            BookName = bookname;
            Author = Author;
            Title = title;
            ISBN = isbn;
            PublishedDate = publishedDate;

        }

    }
}
