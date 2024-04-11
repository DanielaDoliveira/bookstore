using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Communication.Responses
{
    public class ResponseGetAllBooksJson
    {
        public List<ResponseBookJson> Attendees { get; set; } = [];
    }
}