
using Bookstore.Entities;

namespace Bookstore.Tests;

public class CreateDataTest : Test
{
    public CreateDataTest(ListOfBooks _listOfBooks)
    {
        ListOfBooks = _listOfBooks;
    }
    public List<Book> VerifyIfDataCreated()
    {
        BookList = ListOfBooks.BookList;
        return BookList;
    }
}