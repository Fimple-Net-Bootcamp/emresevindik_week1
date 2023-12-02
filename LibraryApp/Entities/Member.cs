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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MembershipNumber { get; set; }
        public List<Book> Books { get; set; }

        public Member(string name, string surname, string membershipNumber)
        {
            Name = name;
            Surname = surname;
            MembershipNumber = membershipNumber;
            Books = new List<Book>();
        }


        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Membership Number: {MembershipNumber}");

            foreach (var book in Books)
            {
                book.Print();
            }
        }
    }
}
