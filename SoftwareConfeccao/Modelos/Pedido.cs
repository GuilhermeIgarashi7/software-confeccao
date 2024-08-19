using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Pedido : Registro
    {

        [BsonId]
        public int Idpedido { get; set; }
        public int Quantidadepedido { get; set; }
        public string Fretepedido { get; set; }

        public string Prazopedido { get; set; }

        public string Itempedido { get; set; }

        public string Observacaopedido { get; set; }


    }

}