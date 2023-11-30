using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public class Book : Literature, IPrintable
    {
        public void Print()
        {
            /*Book book = new Book();
            Console.WriteLine(book.id + " " + book.name + " " + book.writer + " " + book.year);*/
        }
    }
}
