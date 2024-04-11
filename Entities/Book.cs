

namespace Bookstore.Entities;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public int Preco { get; set; }
    public int QuantidadeDeEstoque { get; set; }

}