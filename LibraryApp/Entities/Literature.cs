using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public class Literature : IPrintable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }

        public Literature(string id, string name, string author, string year)
        {
            Id = id;
            Name = name;
            Author = author;
            Year = year;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Author: {Author}, Year: {Year}");
        }
    }
}
