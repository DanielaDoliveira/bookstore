using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers;

[ApiController]
[Route("[controller]")]


public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] Book book)

    {
        var response = new Book
        {
            Titulo = book.Titulo,
            Autor = book.Autor,
            Genero = book.Genero,
            Preco = book.Preco,
            QuantidadeDeEstoque = book.QuantidadeDeEstoque,

        };
        return Created(string.Empty, response);
    }
}