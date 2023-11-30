// See https://aka.ms/new-console-template for more information
using LibraryApp.Entities;

Console.WriteLine("Hello, World!");
Library library = new Library();

Book book1 = new Book
{
    id = "1",
    name = "Kitap1",
    writer = "Yazar1",
    year = "2023"
};

Book book2 = new Book
{
    id = "2",
    name = "Kitap2",
    writer = "Yazar2",
    year = "2022"
};

Member member1 = new Member
{
    name = "Member1",
    surname = "MemberSurname",
    membershipNumber = "Membershipnumber",
};

library.AddBook(book1);
library.AddBook(book2);


library.LendBook(book1, member1);

member1.Print();