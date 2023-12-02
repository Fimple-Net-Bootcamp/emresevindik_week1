using LibraryApp.Entities;

Library library = new Library();

Book book1 = new("1", "Kitap1", "Yazar1", "2023");
Book book2 = new("2", "Kitap2", "Yazar2", "2022");
Book book3 = new("3", "Kitap3", "Yazar3", "2021");


Member member1 = new("Emre", "Sevindik", "123");

library.AddMember(member1);
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

library.LendBook(book1, member1);
library.LendBook(book2, member1);
library.ReturnBook(book1, member1);

member1.Print();