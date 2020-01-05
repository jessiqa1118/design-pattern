using System;
using System.Collections;

public class BookShelf : Aggregate
{
    private ArrayList books;
    private int last = 0;

    public BookShelf()
    {
        this.books = new ArrayList();
    }

    public Object getBookAt(int index)
    {
        return books[index];
    }

    public void appendBook(Book book)
    {
        this.books.Add(book);
        last++;
    }

    public int getLength()
    {
        return last;
    }

    public Iterator iterator()
    {
        return new BookShelfIterator(this);
    }
}
