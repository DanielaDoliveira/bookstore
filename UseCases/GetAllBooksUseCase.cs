using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Communication.Responses;
using Bookstore.Entities;

namespace Bookstore.UseCases
{
    public class GetAllBooksUseCase
    {
        public ResponseGetAllBooksJson Execute()
        {
            ListOfBooks listOfBooks = new ListOfBooks();
            var BooksOfBookList = listOfBooks.BookList;
            ResponseGetAllBooksJson response = new ResponseGetAllBooksJson
            {
                Books = BooksOfBookList
            };
            return response;

        }


    }
}