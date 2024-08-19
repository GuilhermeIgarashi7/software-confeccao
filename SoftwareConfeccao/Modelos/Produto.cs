using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Produto : Item
    {
        [BsonId]
        public int idProduto { get; set; }
        public string Tempoproducaoproduto { get; set; }

        public string Valorproduto { get; set; }

        public string NomeProduto { get; set; }

    }

}