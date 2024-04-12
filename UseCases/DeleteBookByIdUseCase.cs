using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Communication.Requests;
using Bookstore.Tests;

namespace Bookstore.UseCases;

public class DeleteBookByIdUseCase
{
    public void Execute(RequestDeleteBookbyId request, ListOfBooks l)
    {

        var _id = request.Id;



        var lenght = l.BookList.Count;

        if (_id < lenght)
        {

            l.BookList.RemoveAt(_id);


        }
    }
}