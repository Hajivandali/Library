using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitie
{
    public class User
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; }

        public User( string name, string email)
        {
            Name = name;
            Email = email;
            Books = new List<Book>();
        }

    }
}
