using System;
using System.Collections.Generic;
using System.Text;

namespace HashCodeOnline2020
{
    public class Library
    {
        public int id { get; set; }
        public int BooksCount { get; set; }
        public int SignUp { get; set; }
        public int ShipCount { get; set; }
        public List<Book> Books { get; set; }

        public void removeBook(Book book)
        {
            Books.Remove(book);
        }

       
    }
}
