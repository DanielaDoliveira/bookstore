
using Bookstore.Entities;

namespace Bookstore.Tests;

public class UpdateDataTest : Test
{
    public UpdateDataTest(ListOfBooks _listOfBooks)
    {
        ListOfBooks = _listOfBooks;
    }
    public List<Book> VerifyIfDataUpdated()
    {
        BookList = ListOfBooks.BookList;
        return BookList;
    }
}