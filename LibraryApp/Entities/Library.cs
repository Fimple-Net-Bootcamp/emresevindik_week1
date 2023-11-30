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
            Console.WriteLine(book.writer);
        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
        }

        public void LendBook(Book book, Member member)
        {
            member.books.Add(book);
            books.Remove(book);
        }

        public void ReturnBook(Book book, Member member)
        {
            if (!books.Contains(book) && member.books.Contains(book))
            {
                member.books.Remove(book);
                books.Add(book);
            }
        }
    }
}
