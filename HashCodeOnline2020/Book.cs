using System;
using System.Collections.Generic;
using System.Text;

namespace HashCodeOnline2020
{
    public class Book
    {
        public int id { get; set; }
        public int Score { get; set; }

        public event Action<Book> deleteBook;

        public void fireEventDeleteBook()
        {
            deleteBook(this);
        }
    }
}
