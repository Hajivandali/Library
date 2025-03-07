using System;

namespace Domain.Entitie
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public Book() { }

        public Book(int id, string bookname, string author, string title, string isbn, DateTime publishedDate)
        {
            Id = id;
            BookName = bookname;
            Author = author;
            Title = title;
            ISBN = isbn;   
            PublishedDate = publishedDate;
        }
    }
}
