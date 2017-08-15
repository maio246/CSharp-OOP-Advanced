using System;
using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private List<Book> Books;

    public Library(params Book[] books)
    {
        this.Books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new BookIterator(this.Books);
    }
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    private class BookIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currIndex;

        public BookIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public void Dispose() { }
        public bool MoveNext() => ++this.currIndex < this.books.Count;
        public void Reset() => this.currIndex = -1;
        public Book Current =>this.books[this.currIndex];
        object IEnumerator.Current => this.Current;

    }
}