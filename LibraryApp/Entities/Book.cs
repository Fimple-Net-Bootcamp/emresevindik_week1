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
        public Book(string id, string name, string author, string year) : base(id, name, author, year)
        {

        }
    }
}
