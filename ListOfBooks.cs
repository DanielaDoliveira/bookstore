
using Bookstore.Entities;

namespace Bookstore;

public class ListOfBooks
{


    public List<Book> BookList = [

        new Book{
    Id=0,
    Titulo = "O Castelo no Ar",
    Autor = "Diana Wynne Jones",
    Genero = "Fantasia",
    Preco = 25,
    QuantidadeDeEstoque =10

        },
        new Book{
              Id=1,
    Titulo = "O Castelo Animado",
    Autor = "Diana Wynne Jones",
    Genero = "Fantasia",
    Preco = 25,
    QuantidadeDeEstoque =10

        },
        new Book{
              Id=2,
    Titulo = "Percy Jackson e o Ladrão de Raios",
    Autor = "Rick Riordan",
    Genero = "Fantasia",
    Preco = 45,
    QuantidadeDeEstoque =20

        }
    ];
}