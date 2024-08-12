using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Pedido : Registro
    {

        [BsonId]
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Frete { get; set; }

        public string Prazo { get; set; }

        public string Item { get; set; }

        public string Observacao { get; set; }


    }

}