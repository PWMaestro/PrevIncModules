using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; }

        public Book(int id, string name, int pagesCount)
        {
            Id = id;
            Name = name;
            Pages = pagesCount;
        }
    }
}
