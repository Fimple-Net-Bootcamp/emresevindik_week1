using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entities
{
    //Kütüphane: Kitapları ve üyeleri yönetir. Kitap ekleme, silme, ödünç verme ve iade etme işlevleri içermelidir.
    public class Library
    {
        private List<Book> books;
        private List<Member> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine(book.Name + " book added");
        }

        public void DeleteBook(Book book)
        {
            if (books.Contains(book))
            {
                Console.WriteLine("Book already exists.");
            }
            books.Remove(book);
            Console.WriteLine("Book deleted");

        }

        public void LendBook(Book book, Member member)
        {
            member.Books.Add(book);
            books.Remove(book);
            Console.WriteLine("Book Lended");
        }

        public void ReturnBook(Book book, Member member)
        {
            if (!books.Contains(book) && member.Books.Contains(book))
            {
                member.Books.Remove(book);
                books.Add(book);
                
            }
        }

        public void AddMember(Member member)
        {
            if (!members.Contains(member))
            {
                members.Add(member);
                Console.WriteLine("Member added!");
            }
            
        }

        public void DeleteMember(Member member)
        {
            if (!members.Contains(member))
            {
                members.Remove(member);
                Console.WriteLine("Member deleted!");
            }

        }
    }
}
