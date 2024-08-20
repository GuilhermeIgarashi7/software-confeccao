using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Pedido : Item
    {

        [BsonId]
        public int Id { get; set; }
        public int Quantidadepedido { get; set; }
        public string Fretepedido { get; set; }

        public string Prazopedido { get; set; }

        public string Nomeitem { get; set; }

        public string Observacaopedido { get; set; }


    }

}