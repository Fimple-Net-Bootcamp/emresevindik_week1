using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    public class Member : IPrintable
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string MembershipNumber { get; set; }
        private List<Book> Books { get; set; }

        public Member()
        {
            books = new List<Book>();
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }

        public string membershipNumber
        {
            get
            {
                return MembershipNumber;
            }
            set
            {
                MembershipNumber = value;
            }
        }

        public List<Book> books
        {
            get
            {
                return Books;
            }
            set
            {
                Books = value;
            }
        }

        public void Print()
        {
            Console.WriteLine(surname + " " + name + " " + membershipNumber);
        }
    }
}
