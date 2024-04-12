using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Entities;

namespace Bookstore.Communication.Responses
{
    public class ResponseGetAllBooksJson
    {
        public List<Book> Books { get; set; } = [];
    }
}