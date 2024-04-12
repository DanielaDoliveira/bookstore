

using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;

namespace Bookstore.UseCases
{
    public class UpdateBookByIdUseCase
    {
        public ResponseUpdateBookById Execute(int _id, RequestUpdateBookById request, ListOfBooks listOfBooks)
        {
            // var listOfBooks = new ListOfBooks();
            var books_lenght = listOfBooks.BookList.Count;
            var book_founded = listOfBooks.BookList[0];

            if (_id >= books_lenght)
            {
                return null;
            }
            else
            {

                book_founded = listOfBooks.BookList[_id];
                book_founded.Titulo = request.Titulo;
                book_founded.Autor = request.Autor;
                book_founded.Genero = request.Genero;
                book_founded.Preco = request.Preco;
                book_founded.QuantidadeDeEstoque = request.QuantidadeDeEstoque;

                var response = new ResponseUpdateBookById
                {
                    Titulo = book_founded.Titulo,
                    Autor = book_founded.Autor,
                    Genero = book_founded.Genero,
                    Preco = book_founded.Preco,
                    QuantidadeDeEstoque = book_founded.QuantidadeDeEstoque
                };
                //    var allList = listOfBooks.BookList;
                return response;

            };
        }
    }
}