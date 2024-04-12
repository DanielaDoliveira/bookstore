using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using Bookstore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.UseCases;

public class GetBookByIdUseCase
{
    public ResponseGetBooksById Execute(int _id)
    {
        var request = new RequestGetBookById();

        var request_id = request.Id;
        request_id = _id;
        var l = new ListOfBooks();
        var books_lenght = l.BookList.Count;

        if (request_id >= books_lenght)
        {
            return null;
        }
        else
        {
            var book = l.BookList[request_id];

            var response = new ResponseGetBooksById
            {
                Titulo = book.Titulo,
                Autor = book.Autor,
                Genero = book.Genero,
                Preco = book.Preco,
                QuantidadeDeEstoque = book.QuantidadeDeEstoque

            };


            return response;
        }

    }
}