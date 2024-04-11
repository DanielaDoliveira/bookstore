using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Communication.Requests
{
    public class RequestCreateBookJson
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public float Preco { get; set; }
        public int QuantidadeDeEstoque { get; set; }
    }
}