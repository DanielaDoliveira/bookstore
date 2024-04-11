
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

    [HttpGet]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetAllBooks()
    {
        var books = new ListOfBooks();

        var response = books.BookList;
        return Ok(response);
    }


    [HttpGet]
    [Route("{book_id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int book_id)
    {
        var l = new ListOfBooks();
        var lenght = l.BookList.Count;

        if (book_id >= lenght)
        {
            return NotFound("Id não foi encontrado");
        }
        else
        {
            var books = l.BookList[book_id];

            return Ok(books);
        }
    }

    [HttpPut]
    [Route("{book_id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(Book), StatusCodes.Status404NotFound)]
    public IActionResult UpdateBook([FromRoute] int book_id, [FromBody] Book bookUpdate)

    {
        var l = new ListOfBooks();
        var lenght = l.BookList.Count;
        var books = l.BookList[0];
        if (book_id >= lenght)
        {
            return NotFound("Id não foi encontrado");
        }
        else
        {
            books = l.BookList[book_id];
            Console.WriteLine(books);
            books.Titulo = bookUpdate.Titulo;
            books.Autor = bookUpdate.Autor;
            books.Genero = bookUpdate.Genero;
            books.Preco = bookUpdate.Preco;
            books.QuantidadeDeEstoque = bookUpdate.QuantidadeDeEstoque;


        };
        return NoContent();
    }

    [HttpDelete]
    [Route("{book_id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(Book), StatusCodes.Status404NotFound)]
    public IActionResult DeleteBook(int book_id)
    {
        var l = new ListOfBooks();
        var lenght = l.BookList.Count;
        if (book_id >= lenght)
        {
            return NotFound("Id não foi encontrado");
        }
        else
        {

            l.BookList.RemoveAt(book_id);

        }



        return NoContent();

    }
}