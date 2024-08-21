using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Pedido : Item
    {

        [BsonId]
        public int Id { get; set; }
        public string Custoitem { get; set; }
        public string Quantidadepedido { get; set; }
        public string Fretepedido { get; set; }

        public string Prazopedido { get; set; }

        public string Nomeitem { get; set; }

        public string Observacaopedido { get; set; }


    }

}