
namespace Bookstore.Communication.Responses;

public class ResponseBookCreatedJson
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public float Preco { get; set; }
    public int QuantidadeDeEstoque { get; set; }
}