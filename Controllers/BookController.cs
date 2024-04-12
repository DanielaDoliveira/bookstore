
using Bookstore.Communication.Requests;
using Bookstore.Communication.Responses;
using Bookstore.Entities;
using Bookstore.Tests;
using Bookstore.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers;

[ApiController]
[Route("[controller]")]


public class BookController : ControllerBase
{


    [HttpPost]
    [ProducesResponseType(typeof(ResponseBookCreatedJson), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] RequestCreateBookJson request)

    {

        var random = new Random();
        int id = random.Next();
        var listOfBooks = new ListOfBooks();
        var useCase = new CreateBookUseCase();
        var test = new CreateDataTest(listOfBooks);
        var test_list = test.VerifyCompleteListBeforeTest();

        var response = useCase.Execute(request, id, listOfBooks);
        test_list = test.VerifyIfDataCreated();
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseGetAllBooksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetAllBooks()
    {
        var useCase = new GetAllBooksUseCase();
        var response = useCase.Execute();

        return Ok(response);
    }


    [HttpGet]
    [Route("{book_id}")]
    [ProducesResponseType(typeof(ResponseGetBooksById), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int book_id)
    {

        var useCase = new GetBookByIdUseCase();
        var response = useCase.Execute(book_id);
        if (response == null)
        {
            return NotFound("Livro não foi encontrado");
        }
        else
        {
            return Ok(response);
        }

    }

    [HttpPut]
    [Route("{book_id}")]
    [ProducesResponseType(typeof(ResponseUpdateBookById), StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult UpdateBook([FromRoute] int book_id, [FromBody] RequestUpdateBookById request)

    {
        var useCase = new UpdateBookByIdUseCase();
        var listOfBooks = new ListOfBooks();
        var test = new UpdateDataTest(listOfBooks);
        var test_list = test.VerifyCompleteListBeforeTest();
        var response = useCase.Execute(book_id, request, listOfBooks);

        if (response == null)
        {
            return NotFound();
        }
        else
        {
            test_list = test.VerifyIfDataUpdated();
            return NoContent();
        }
    }

    [HttpDelete]
    [Route("{book_id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(Book), StatusCodes.Status404NotFound)]
    public IActionResult DeleteBook([FromRoute] int book_id, RequestDeleteBookbyId request)
    {
        request.Id = book_id;
        var l = new ListOfBooks();
        var test = new DeleteDataTest(l);
        var testing_list = test.VerifyCompleteListBeforeTest();

        var useCase = new DeleteBookByIdUseCase();

        useCase.Execute(request, l);



        testing_list = test.VerifyIfObjectDeleted();
        return NoContent();

    }
}