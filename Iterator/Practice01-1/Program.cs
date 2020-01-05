﻿using System;

class Program
{
    static void Main(string[] args)
    {
        BookShelf bookShelf = new BookShelf();
        bookShelf.appendBook(new Book("Around the World in 80 Days"));
        bookShelf.appendBook(new Book("Bible"));
        bookShelf.appendBook(new Book("Cinderella"));
        bookShelf.appendBook(new Book("Daddy-Log-Legs"));
        Iterator it = bookShelf.iterator();

        while (it.hasNext())
        {
            // TODO: Bookの抽象化
            Book book = (Book)it.next();
            Console.WriteLine(book.getName());
        }
    }
}
