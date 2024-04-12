

namespace Bookstore.Communication.Requests;

public class RequestUpdateBookById
{

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public float Preco { get; set; }
    public int QuantidadeDeEstoque { get; set; }
}