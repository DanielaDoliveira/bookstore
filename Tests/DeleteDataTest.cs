using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Bookstore.Entities;

namespace Bookstore.Tests
{
    public class DeleteDataTest : Test
    {

        public DeleteDataTest(ListOfBooks _listOfBooks)
        {
            ListOfBooks = _listOfBooks;
        }
        public List<Book> VerifyIfObjectDeleted()
        {
            BookList = ListOfBooks.BookList;
            return BookList;
        }

    }
}