
using Bookstore.Entities;

namespace Bookstore.Tests;

public class Test
{
    public ListOfBooks ListOfBooks = new ListOfBooks();
    public List<Book> BookList = new List<Book>();

    public List<Book> VerifyCompleteListBeforeTest()
    {
        BookList = ListOfBooks.BookList;
        return BookList;
    }
}