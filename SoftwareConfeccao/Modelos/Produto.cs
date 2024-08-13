using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Produto : Item
    {
        [BsonId]
        public int idProduto { get; set; }
        public string Tempoproducao { get; set; }

        public string Valor { get; set; }

        public string NomeProduto { get; set; }

    }

}