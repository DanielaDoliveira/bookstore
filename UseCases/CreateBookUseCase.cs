
using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using Bookstore.Entities;

namespace Bookstore.UseCases;

public class CreateBookUseCase
{
    /* Faz a conversão do tipo ResponseBookCreated para Book*/
    public ResponseBookCreatedJson Execute(RequestCreateBookJson request, int _id, ListOfBooks listOfBooks)
    {
        var create_book = new Book
        {
            Id = _id,
            Titulo = request.Titulo,
            Autor = request.Autor,
            Genero = request.Genero,
            Preco = request.Preco,
            QuantidadeDeEstoque = request.QuantidadeDeEstoque,
        };

        var response = new ResponseBookCreatedJson
        {
            Id = create_book.Id,
            Titulo = create_book.Titulo,
            Autor = create_book.Autor,
            Genero = create_book.Genero,
            Preco = create_book.Preco,
            QuantidadeDeEstoque = create_book.QuantidadeDeEstoque,
        };

        // ListOfBooks listOfBooks = new ListOfBooks();
        listOfBooks.BookList.Add(create_book);

        return response;

    }
}