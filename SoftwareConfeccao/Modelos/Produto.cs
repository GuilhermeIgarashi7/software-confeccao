using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Produto : Item
    {
        [BsonId]
        public int Id { get; set; }
        public string Tempoproducaoproduto { get; set; }

        public string Custoitem { get; set; }

        public string Nomeitem { get; set; }

    }

}